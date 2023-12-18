using DecouverteValidateur.Models;
using Microsoft.AspNetCore.Mvc;

namespace DecouverteValidateur.Controllers
{
    public class JediController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Jedi jedi)
        {
            if (ModelState.IsValid)
            {

            }
            return View(jedi);
        }
    }
}
