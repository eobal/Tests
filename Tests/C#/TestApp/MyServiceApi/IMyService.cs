using System;
using System.ServiceModel;

namespace MyServiceApi
{
	[ServiceContract]
	public interface IMyService
	{
		[OperationContract]
		void Operation1();

		[OperationContract]
		void Operation2();
	}
}

