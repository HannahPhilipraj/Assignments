using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingServer;


namespace RemotingClient
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            //create channel with port
            TcpChannel tcp = new TcpChannel(85);

            //register channel
            ChannelServices.RegisterChannel(tcp);
            //create class service object
            Service service = (Service)Activator.GetObject(typeof(Service), "tcp://localhost:8089/FirstRemoteService");
            
            Console.Write("Enter a string to find its length : ");
            string s1 = Console.ReadLine();
            Console.WriteLine(service.Enter_name(s1));

            Console.Write("Enter a number to find its square root : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(service.Sqrtof_Number(n1));
            Console.Read();
        }
    }
}