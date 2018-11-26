using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/form")]
        public ActionResult Form() 
        { 
            return View(); 
        }

        [Route("/formtwo")]
        public ActionResult FormTwo() 
        { 
            return View(); 
        }

         [Route("/madlib")]
        public ActionResult Madlib(string name, string nameTwo, string animal, string adjective, string exclamation)
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.SetName(name);
            myMadlibVariable.SetNameTwo(nameTwo);
            myMadlibVariable.SetAnimal(animal);
            myMadlibVariable.SetAdjective(adjective);
            myMadlibVariable.SetExclamation(exclamation);
            return View(myMadlibVariable);
        }

        [Route("/madlibtwo")]
        public ActionResult MadlibTwo(string name, string nameTwo, string animal, string adjective, string exclamation)
        {
            MadlibVariable myMadlibVariableTwo = new MadlibVariable();
            myMadlibVariableTwo.SetName(name);
            myMadlibVariableTwo.SetNameTwo(nameTwo);
            myMadlibVariableTwo.SetAnimal(animal);
            myMadlibVariableTwo.SetAdjective(adjective);
            myMadlibVariableTwo.SetExclamation(exclamation);
            return View(myMadlibVariableTwo);
        }

       
    }
}