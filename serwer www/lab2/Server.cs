using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab2
{
    class Server
    {
        static TcpListener server;
        static string dir;
        Thread thr;

        public Server()
        {
            server = null;
            dir = "";
            //thr = new Thread(() => ListenForConnection(server));
        }

        public static void ListenForConnection(TcpListener passedServer, string passedDir)
        {
            // Start listening for client requests.
            passedServer.Start();

            while (true)
            {
                //TcpClient client = server.AcceptTcpClient();
                
                TcpClient client = passedServer.AcceptTcpClient();

                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                StreamReader file;

                try
                {
                    string request = sr.ReadLine();
                    string[] tokens = request.Split(' ');
                    string page = tokens[1];
                    if (page == "/")
                    { page = "index.html"; }
                    else if (page == "/boom.html")
                    { throw new Exception(); }

                    try
                    {
                        file = new StreamReader(passedDir + page);
                        sw.WriteLine("HTTP/1.1 200 OK\n");
                        sw.Flush();

                        string data = file.ReadLine();
                        while (data != null)
                        {
                            sw.WriteLine(data);
                            sw.Flush();
                            data = file.ReadLine();
                        }
                    }
                    catch (FileNotFoundException err)
                    {
                        file = null;
                        sw.WriteLine("HTTP/1.1 404 OK\n");
                        sw.WriteLine("could not find your file");
                        sw.Flush();
                    }
                }
                catch (Exception err)
                {
                    sw.WriteLine("HTTP/1.1 500 OK\n");
                    sw.WriteLine("server error");
                    sw.Flush();
                }

                client.Close();
            }

        }

        public void StartServer(string portInput , string dirInput)
        {
            int port;
            if (portInput == "")
            {
                port = 8077;
            }
            else
            {
                port = Convert.ToInt32(portInput);
            }

            if (dirInput == "")
            {
                dir = "../../";
            }
            else
            {
                dir = dirInput;
            }
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                thr = new Thread(() => ListenForConnection(server, dir));
                //ListenForConnection();
                thr.Start();
            }
            catch (SocketException err)
            {
                Console.WriteLine("SocketException: {0}", err);
            }
            finally
            {
                server.Stop();
            }

        }

        public void StopServer()
        {
            thr.Abort();
            server.Stop();
        }
    }
}

