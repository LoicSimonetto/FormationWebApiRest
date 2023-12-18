using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestlehero.BackOffice.Web.UI.Controllers
{
    public class ReponseController : Controller
    {
        private readonly DefaultContext _context;
        public ReponseController(DefaultContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            ViewBag.QuestionList = _context.Questions.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Reponse reponse)
        {
            ViewBag.QuestionList = _context.Questions.ToList();
            if (ModelState.IsValid)
            {
                _context.Reponses.Add(reponse);
                _context.SaveChanges();
            }

            return View(reponse);
        }
    }
}
