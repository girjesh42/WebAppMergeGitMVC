using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC1GitBranch.Models;

namespace WebAppMVC1GitBranch.Controllers
{
    public class EmpsController : Controller
    {
        public static List<Emp> listEmps = new List<Emp>
        {
            new Emp{Eid=1,Ename="Raj Sharma",Edesig="Developer",Edoj=DateTime.Parse("12/02/2021")},
            new Emp{Eid=5,Ename="Rohan rai",Edesig="HR",Edoj=DateTime.Parse("03/02/2020")},
            new Emp{Eid=8,Ename="Raman",Edesig="Manager",Edoj=DateTime.Parse("08/11/2015")},
            new Emp{Eid=45,Ename="Aman",Edesig="Developer",Edoj=DateTime.Parse("06/07/2016")},
            new Emp{Eid=100,Ename="Diksha",Edesig="HR",Edoj=DateTime.Parse("01/01/1990")}

        };
        // GET: Emps
        public ActionResult Index()
        {
            return View(listEmps);
        }
    }
}