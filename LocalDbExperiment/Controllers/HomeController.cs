using Data;
using LocalDbExperiment.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalDbExperiment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test() {

            var people = new ListOfPeopleViewModel();
            var workflow = new Workflow();

            people.People = workflow.FindAllPeople();
            ViewBag.Message = workflow.ConnectionString;

            return View(people);
        }
    }
}
