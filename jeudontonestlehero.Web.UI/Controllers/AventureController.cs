using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestlehero.Web.UI.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestlehero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;
        public AventureController(DefaultContext context)
        {
            _context =  context;
        }

        public IActionResult Index()
        {
            ViewBag.MonTitre = "Aventures";

            var query = from item in this._context.Aventures
                        select item;

            return View(query.ToList());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Aventure aventure)
        {
            if (ModelState.IsValid) 
            {
                _context.Aventures.Add(aventure);
                _context.SaveChanges();
            }
            return View(aventure);
        }

        public IActionResult Edit(int id)
        {
            Aventure aventure = null;
            aventure = _context.Aventures.FirstOrDefault(a => a.Id == id);

            if (aventure != null) 
            {
                return View(aventure);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Aventure aventure)
        {
            return View();
        }
    }
}
