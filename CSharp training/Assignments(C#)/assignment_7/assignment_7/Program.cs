using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServer
{

    //service class
    public class Service : MarshalByRefObject
    {
        public int Enter_name(string s1)
        {
            
            int len = s1.Length;
            Console.WriteLine("Remote Call 1 Executed");
            return len;
        }

        public double Sqrtof_Number(int n1)
        {
            double sqrtnum = Math.Sqrt(n1);
            Console.WriteLine("Remote Call 2 Executed");
            return sqrtnum;
        }
        
    }
    //server class
    //it hosts the services by registering them
    class Server
    {
        static void Main(string[] args)
        {
            //create a new channel for communication
            TcpChannel tcp = new TcpChannel(8089); 

            //register the channel
            ChannelServices.RegisterChannel(tcp);

            //configure all known services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "FirstRemoteService",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started at Port No: 8089");
            Console.WriteLine("Press any Key to Stop the Server Services");
            Console.ReadLine();
        }
    }
}
