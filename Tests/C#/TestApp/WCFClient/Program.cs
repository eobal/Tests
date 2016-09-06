using System;
using System.ServiceModel;
using MyServiceApi;
using System.Threading;

namespace WCFClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("WCF Client");

			Thread.CurrentThread.Name = "ABC";
			Thread.Sleep (1000);

			Console.WriteLine ("Create WCF proxy...");
			var binding = new NetTcpBinding();
			EndpointAddress address = new EndpointAddress ("net.tcp://localhost:11001/MyService");
			var factory = new ChannelFactory<IMyService>(binding, address);

			IMyService proxy = factory.CreateChannel ();
			
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine ("Call WCF service.....");
				proxy.Operation1();

				Thread.Sleep(500);
			}

		}
	}
}
