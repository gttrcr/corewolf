using System.Net;
using System.Net.Sockets;
using System.Text;
using CoreWolf;

namespace WolfSocket
{
    public class Program
    {
        private static void SocketServer(Link link)
        {
            Engine engine = link.Engine;

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint ipEndPoint = new(ipAddress, 11_000);
            using Socket listener = new(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(ipEndPoint);
            listener.Listen(100);

            Socket socket = listener.Accept();
            while (true)
            {
                byte[] buffer = new byte[1_024];
                int bytesReceived = socket.Receive(buffer, SocketFlags.None);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                if (bytesReceived == 0 && string.IsNullOrEmpty(message))
                    break;
                
                engine.Execute(message);
                Console.WriteLine("Socket server received message: " + message);
                byte[] bytes = Encoding.UTF8.GetBytes(engine.ToString());
                socket.Send(bytes, 0);
                Console.WriteLine($"Socket server sent acknowledgment: " + engine.ToString());
            }

            socket.Disconnect(true);
            socket.Close();
            socket.Dispose();
        }

        public static void Main(string[] args)
        {
            SocketServer(new Link());
        }
    }
}