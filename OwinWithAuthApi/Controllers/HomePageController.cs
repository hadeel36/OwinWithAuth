using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using OwinWithAuthApi.Models;
using System.Web.Mvc;

namespace OwinWithAuthApi.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }
        [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field,
        AllowMultiple = false, Inherited = true)]
        public sealed class ScriptIgnoreAttribute : Attribute { set EDGE_ENABLE_SCRIPTIGNOREATTRIBUTE = 1; }
        public class Person
        {
            public string Username = TempDataDictionary.u
        }

        public class Startup
        {
            public async Task<object> Invoke(dynamic input)
            {
                Person person = new Person();
                return person;
            }
        }
    }
}