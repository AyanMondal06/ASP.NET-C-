using Microsoft.AspNetCore.Mvc;
using webapp2.Models;

namespace webapp2.Controllers
{
    public class AdditionController : Controller
    {
        public IActionResult ShowAddition(int x, int y)
        {
            Addition a1 = new Addition();
            
            a1.a = x;
            a1.b = y;
            a1.sum = x + y;
            return View(a1);
        }
        public IActionResult GetAddition(int x, int y)
        {
            Addition a1 = new Addition();

          
            return View();
        }
    }
}
