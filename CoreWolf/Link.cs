using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace CoreWolf
{
    public class Link
    {
        private Socket? mathKernel;
        private static bool kernelIsRunning = false;
        private static readonly Mutex cctor = new();
        private static readonly string ListenerFile = "listener.wl";
        private static readonly string ListenerContent = $@"
SendResponse[client_, error_, result_] := WriteString[client, ""{{\""Error\"":"" <> error <> "", \""Data\"":"" <> ToString[result, InputForm] <> ""}}""]
Quiet[Close[server]]

handler[assoc_Association] :=  Module[{{client, request, svg}},
    client = assoc[""SourceSocket""];
    request = ByteArrayToString[assoc[""DataByteArray""]];
    (*Echo[request, ""Received ""];*)
    If[SyntaxQ[request],
        SendResponse[client, ""0"", ToExpression[request]],
        SendResponse[client, ""-1"", ""Cannot evaluate expression"" <> request]
    ]
]

listener = SocketListen[7734, handler]
server = listener[""Socket""]
Pause[4294967295]
";

        public byte[] Buffer { get; private set; }
        public static readonly int PacketSize = 131072;

        public Link()
        {
            Buffer = [];

            while (!kernelIsRunning)
            {
                try
                {
                    cctor.WaitOne();
                    SocketConnect();
                    kernelIsRunning = true;
                }
                catch
                {
                    try
                    {
                        File.WriteAllText(ListenerFile, ListenerContent);
                        new Thread(() => GttrcrGist.Process.Run(null, $"wolframscript -f {ListenerFile}")) { IsBackground = true }.Start();
                        Thread.Sleep(5000);
                        SocketConnect();
                        kernelIsRunning = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Cannot connect to any kernel @ 127.0.0.1:7734 or cannot start the kernel itself. " + ex.Message);
                    }
                }
            }
        }

        private int SocketCommunicate(string input, out byte[] rec)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(input);
            if (byteData.Length > PacketSize)
                throw new OverflowException("WLServer input string is larger than the maximum allowable package size of " + PacketSize + " bytes");
            if (mathKernel?.Send(byteData) != byteData.Length)
                throw new Exception("The size of the sent message differs from the original size of the message");
            rec = new byte[PacketSize];
            return mathKernel.Receive(rec);
        }

        private void SocketConnect()
        {
            mathKernel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint remoteEP = new(IPAddress.Parse("127.0.0.1"), 7734);
            mathKernel.Connect(remoteEP);
        }

        public void ToSocket(string input)
        {
            int length = SocketCommunicate(input, out byte[] rec);
            if (length == 0)
                throw new Exception("Link received an empty response");

            Buffer = new byte[length];
            Array.Copy(rec, Buffer, length);
        }

        public void Close()
        {
            mathKernel?.Disconnect(true);
            mathKernel?.Close();
            mathKernel?.Dispose();
            mathKernel = null;
        }

        public void Dispose()
        {
            SocketCommunicate("Quit[]", out byte[] rec);
            Close();
        }
    }
}