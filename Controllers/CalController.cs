using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Mvc;


namespace First_csharp_web.Controllers
{
    public class CalController : Controller 
    {
        public ActionResult Sqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqrt(string firstnumber, string secondnumber)
        {

            int intfirstnumber = int.Parse(firstnumber);
            int intsecondnumber = int.Parse(secondnumber);

            double result_1 = Math.Sqrt(intfirstnumber);
            double result_2 = Math.Sqrt(intsecondnumber);

            double result = Math.Max(result_1, result_2);
            double result_diff = result_1 - result_2;
            
            ViewBag.result_diff = result_diff;

            ViewBag.Result = result;
            
            return View();
        }
    }
    
}