using System;
using System.ServiceModel;
using MyServiceApi;

namespace TestApp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Specify a base address for the service
			String baseAddress = "http://localhost:11001/MyService";

			// Create the binding to be used by the service.
			BasicHttpBinding binding1 = new BasicHttpBinding();

			using (ServiceHost host = new ServiceHost (typeof(MyService)))
			{
				host.AddServiceEndpoint(typeof(IMyService), binding1, baseAddress);

				Console.WriteLine ("Open host...");
				host.Open();

				Console.WriteLine("The service is ready at {0}", baseAddress);
				Console.WriteLine("Press <Enter> to stop the service.");
				Console.ReadLine();

				// Close the ServiceHost.
				host.Close();
			}
		}
	}
}
