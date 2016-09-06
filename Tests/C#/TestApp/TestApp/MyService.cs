using System;
using System.ServiceModel;
using MyServiceApi;

namespace TestApp
{
	internal class MyService : IMyService
	{
		#region IMyService implementation

		public void Operation1 ()
		{
			Console.WriteLine ("Operation 1");
		}

		public void Operation2 ()
		{
			Console.WriteLine ("Operation 2");
		}

		#endregion
	}
}

