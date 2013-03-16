using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts
{
	using System.ServiceModel;

	[ServiceContract]
    public interface IRegistry
	{
		 [OperationContract()]
			IEnumerable<string> GetCurrentUserKeys();
    }
}
