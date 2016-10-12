using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace testing.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			List<Employee> employees = new List<Employee>()
			{
				new Employee{EmpID = "1", EmpFirstName = "Cristian", EmpLastName = "Morataya"},
				new Employee{EmpID = "2", EmpFirstName = "Rizwan", EmpLastName = "Mukhtar"},
				new Employee{EmpID = "3", EmpFirstName = "Rehan", EmpLastName = "Ahmad"},
				new Employee{EmpID = "4", EmpFirstName = "Zeeshan", EmpLastName = "Khalid"},
				new Employee{EmpID = "5", EmpFirstName = "Sajid", EmpLastName = "Majeed"}
			};
			return View (employees);
		}
	}
}

