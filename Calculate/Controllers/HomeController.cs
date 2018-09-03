using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculate.Models;
using Calculate.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using MathLib;

namespace Calculate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hellur! Lets calculate";
            CalculateVM model = new CalculateVM();
            model.FirstNumber = 0;
            model.SecondNumber = 0;

            model.OperatorsList = new List<operatorlist> {

            new operatorlist { Id =1, operators = "Add" },
            new operatorlist { Id = 2, operators = "Sub" },
            new operatorlist { Id = 3, operators = "Mul" },
            new operatorlist { Id = 4, operators = "Div" }
        };

            CalculateResultVM Model = new CalculateResultVM();

            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate (CalculateVM model){
            
            CalculateResultVM resultModel = new CalculateResultVM();
            resultModel.Operator = model.Operator;

            TryValidateModel(model);

            if (ModelState.IsValid)
            {
                Class1 calculator = new Class1();
                resultModel.Result = calculator.Calculate(model.FirstNumber, model.SecondNumber, resultModel.Operator);

                return View(resultModel);
            }
            return View("Index", model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
