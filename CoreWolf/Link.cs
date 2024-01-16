﻿using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Runtime.InteropServices;

namespace CoreWolf
{
    public class Link
    {
        private readonly Mutex wolfMtx;
        private static Socket? mathKernel;
        public Engine Engine { get; private set; }

        public Link(string? ip = null)
        {
            Engine = new(this);
            wolfMtx = new();

            if (mathKernel != null)
                return;

            ip ??= Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToList().Where(x => x.AddressFamily == AddressFamily.InterNetwork).ToList().First().ToString();

            string args = "";
            File.WriteAllText(WLServer.Name, WLServer.Code);

            Mutex cctor = new();
            new Thread(() =>
            {
                cctor.WaitOne();
                try
                {
                    List<GttrcrGist.Process.OSCommand> killProcesses = new()
                    {
                        { new GttrcrGist.Process.OSCommand() { Command = "lsof -i tcp:" + WLServer.Port + " | awk 'NR!=1 {print $2}' | xargs --no-run-if-empty kill -9 ", OSPlatform = OSPlatform.Linux } },
                        { new GttrcrGist.Process.OSCommand() { Command = "pgrep WolframKernel | xargs --no-run-if-empty kill -9 ", OSPlatform = OSPlatform.Linux } }
                    };
                    GttrcrGist.Process.Run(killProcesses);

                    string executable = string.Empty;
                    if (GttrcrGist.Process.Exists("python"))
                        executable = "python";
                    else if (GttrcrGist.Process.Exists("python3"))
                        executable = "python3";

                    GttrcrGist.Process.Run("python3", string.Format("{0} {1}", WLServer.Name, args), () =>
                    {
                        Thread.Sleep(2000);
                        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                        IPAddress ipAddress = IPAddress.Parse(ip);
                        IPEndPoint remoteEP = new(ipAddress, WLServer.Port);
                        mathKernel = new(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                        mathKernel.Connect(remoteEP);
                        cctor.ReleaseMutex();
                    });
                    throw new Exception("python and python3 was not found");
                }
                catch (Exception ex)
                {
                    throw new Exception("CoreWolf: error on launching kernels: " + ex.Message);
                }
            })
            { IsBackground = true }.Start();

            Thread.Sleep(200);
            cctor.WaitOne();
        }

        public string ToEngine(string input)
        {
            wolfMtx.WaitOne();

            byte[] byteData = Encoding.ASCII.GetBytes(input);
            if (byteData.Length > WLServer.PacketSize)
                throw new OverflowException("WLServer input string is larger than the maximum allowable package size of " + WLServer.PacketSize + " bytes");
            if (mathKernel?.Send(byteData) != byteData.Length)
                throw new Exception("The size of the sent message differs from the original size of the message");
            byte[] rec = new byte[WLServer.PacketSize];
            int length = mathKernel.Receive(rec);
            string response = Encoding.ASCII.GetString(rec, 0, length);

            wolfMtx.ReleaseMutex();

            return response;
        }

        public void Dispose()
        {
            mathKernel?.Dispose();
        }
    }
}