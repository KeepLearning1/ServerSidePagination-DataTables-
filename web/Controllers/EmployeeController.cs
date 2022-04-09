using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.DataLayer;

namespace web.Controllers
{
    public class EmployeeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult loaddata()
        {
            using (EmployeeContext dc = new EmployeeContext())
            {
                // dc.Configuration.LazyLoadingEnabled = false; // if your table is relational, contain foreign key
                var data = dc.Employees.OrderBy(a => a.Emp_Id).ToList();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}