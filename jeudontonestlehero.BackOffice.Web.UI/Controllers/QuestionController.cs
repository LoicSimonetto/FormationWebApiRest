using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestlehero.BackOffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        private readonly DefaultContext _context;
        public QuestionController(DefaultContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.ParagrapheList = _context.Paragraphes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Question question)
        {
            ViewBag.ParagrapheList = _context.Paragraphes.ToList();
            if (ModelState.IsValid) 
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
            }
            
            return View(question);
        }
    }
}
