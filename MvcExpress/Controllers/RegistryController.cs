using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExpress.Controllers
{
	using Contracts;

	public class RegistryController : Controller
    {
		readonly IRegistry _registry;

		public RegistryController(IRegistry registry)
			{
				_registry = registry;
			}
        //
        // GET: /Registry/

        public ActionResult Index()
        {
            return View(_registry.GetCurrentUserKeys());
        }

    }
}
