using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Linq;
using System.IO;
using System;
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
            if (mathKernel.Send(byteData) != byteData.Length)
                throw new Exception("The size of the sent message differs from the original size of the message");
            byte[] rec = new byte[WLServer.PacketSize];
            int length = mathKernel.Receive(rec);
            string response = Encoding.ASCII.GetString(rec, 0, length);

            wolfMtx.ReleaseMutex();

            return response;
        }

        public void Dispose()
        {
            mathKernel.Dispose();
        }

        #region DEPRECATED

        /*
        public List<string> RecursiveSimplify(string input)
        {
            string pattern = @"Abs\[([^\[\]A]+|(?<Level>\[)|(?<-Level>\]))+(?(Level)(?!))\]";
            MatchCollection matchList = Regex.Matches(input, pattern);
            List<string> list = matchList.Cast<Match>().Select(match => match.Value).Distinct().ToList();
            List<string> binary = Enumerable.Range(0, (int)Math.Pow(2, list.Count)).Select(x => ToBinary(x, list.Count)).ToList();

            List<string> output = Execute(ReplaceAbs(input, list, binary)).Select(x => x.Text).ToList();
            for (int i = 0; i < output.Count; i++)
            {
                if (output[i].Contains("Abs["))
                {
                    string tmp = output[i];
                    output.RemoveAt(i);
                    output.AddRange(RecursiveSimplify(tmp));
                    i = -1;
                }
            }

            return output;
        }

        private List<string> ReplaceAbs(string input, List<string> abs, List<string> positive)
        {
            List<string> ret = new List<string>();
            List<string> args = abs.Select(x => x.Substring(4, x.Length - 5)).ToList();
            for (int i = 0; i < positive.Count; i++)
            {
                string retEl = input;
                string pos = positive[i];
                for (int p = 0; p < pos.Length; p++)
                {
                    string argsSign = "";
                    if (pos[p] == '1')
                        argsSign = args[p];
                    else if (args[p][0] == 's')
                        argsSign = "-" + string.Concat(args[p].Select(c => c == '-' ? '+' : c == '+' ? '-' : c));
                    else
                        argsSign = string.Concat(args[p].Select(c => c == '-' ? '+' : c == '+' ? '-' : c));

                    retEl = retEl.Replace(abs[p], "(" + argsSign + ")");
                }

                ret.Add(retEl);
            }

            return ret;
        }

        private string ToBinary(int x, int size = 32)
        {
            char[] buff = new char[size];

            for (int i = size - 1; i >= 0; i--)
            {
                int mask = 1 << i;
                buff[size - 1 - i] = (x & mask) != 0 ? '1' : '0';
            }

            return new string(buff);
        }
        */

        #endregion DEPRECATED
    }
}