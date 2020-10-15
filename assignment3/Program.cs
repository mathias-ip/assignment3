using System;
using System.Net.Sockets;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TcpClient client = new TcpClient()) 
            {
                client.Connect ("address", port);
                using (NetworkStream n= client.GetStream()) 
                {
                    //network...
                }
            }

            TcpListener listener = new TcpListener (<ip address>, port);
            listener.Start();

            while(keepProcessingRequests)
                using (TcpClient c = listener.AcceptTcpClient())
                using (NetworkStream n= c.GetStream())
                {
                    //NetworkStream... 
                }

            listener.Stop();
          
        }
    }
}
