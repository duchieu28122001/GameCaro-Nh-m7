using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Demo_CoCaro
{
    class LANNetwork
    {
        bool isConnected;
        public LANNetwork()
        {
            isConnected = false;
        }

        public Socket createServer(int port)
        {
            try
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Any, port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(ipe);
                isConnected = true;
                return socket;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isConnected = false;
                return null;
            }
        }

        public Socket connectServer(string ipaddress, int port)
        {
            try
            {
                IPAddress ipa = IPAddress.Parse(ipaddress);
                IPEndPoint ipe = new IPEndPoint(ipa, port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipe);
                isConnected = true;
                return socket;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isConnected = false;
                return null;
            }
        }

        public string findServer(int port)
        {
            try
            {
                using (UdpClient client = new UdpClient(port))
                {
                    var wait = TimeSpan.FromSeconds(3);
                    var result = client.BeginReceive(null, null);
                    result.AsyncWaitHandle.WaitOne(wait);
                    if (result.IsCompleted)
                    {
                        IPEndPoint ipe = null;
                        byte[] rev = client.EndReceive(result, ref ipe);
                        string data = Encoding.ASCII.GetString(rev);
                        client.Close();
                        return data;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool sendIPServer(string ipaddress, int port)
        {
            try
            {
                using (UdpClient client = new UdpClient())
                {
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Broadcast, port);
                    byte[] data = Encoding.ASCII.GetBytes(ipaddress);
                    client.Send(data, data.Length, ipe);
                    client.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void sentData(Socket socket, string[] data)
        {
            try
            {
                if (isConnected)
                    socket.Send(obj2Byte(data));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public byte[] obj2Byte(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        public object byte2Obj(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream);
            }
        }
    }
}
