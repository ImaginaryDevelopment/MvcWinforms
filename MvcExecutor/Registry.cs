using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcExecutor
{
	class RegistryService:Contracts.IRegistry
	{
		#region IRegistry Members

		public IEnumerable<string> GetCurrentUserKeys()
		{
			return Microsoft.Win32.Registry.CurrentUser.GetSubKeyNames();
		}

		#endregion
	}
}
