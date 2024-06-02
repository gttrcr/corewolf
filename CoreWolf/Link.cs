using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace CoreWolf
{
    public class Link
    {
        private Socket? mathKernel;
        public Engine Engine { get; private set; }
        public static readonly int PacketSize = 131072;
        private static bool kernelIsRunning = false;
        private static Mutex cctor = new();

        public Link()
        {
            Engine = new(this);

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
                        new Thread(() => GttrcrGist.Process.Run(null, "wolframscript -f listener.wl")) { IsBackground = true }.Start();
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

        public string ToEngine(string input)
        {
            int length = SocketCommunicate(input, out byte[] rec);
            if (length == 0)
                throw new Exception("Link received an empty response");

            string response = Encoding.ASCII.GetString(rec, 0, length);
            Result res = JsonConvert.DeserializeObject<Result>(response);
            if (!res.IsOk())
                throw new Exception("Result " + res);

            return res.Data;
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
            Engine.CloseKernels(string.Empty, null);
            SocketCommunicate("Quit[]", out byte[] rec);
            Close();
        }
    }
}