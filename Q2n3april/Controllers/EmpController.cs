using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Q2n3april.Models;

namespace Q2n3april.Controllers
{
    public class EmpController : Controller
    {
        List<Emp> Emps = new List<Emp>()
        {
                new Emp{Id=1,name="Abha",contact="9876543219"},
                 new Emp{Id=2,name="Arun",contact="8876543219"},
                    new Emp{Id=3,name="Tannu",contact="78765432198"}
        };
        public IActionResult Index()
        {
            
        ViewBag.Emp= Emps;
            return View();
        }
    }
}
