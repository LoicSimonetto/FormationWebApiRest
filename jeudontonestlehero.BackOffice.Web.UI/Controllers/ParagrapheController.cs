using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestlehero.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private readonly DefaultContext _context = null;

        public ParagrapheController(DefaultContext context)
        {
            _context= context;
        }

        #region Public Methods
        public ActionResult Index(int id)
        {
            this.ViewBag.MonId = id;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                this._context.Paragraphes.Add(paragraphe);
                this._context.SaveChanges();
            }
            


            return View();
        }
        public ActionResult Edit(int id) 
        {
            Paragraphe? paragraphe = null;

            paragraphe = _context.Paragraphes.First(p => p.Id == id);

            return View(paragraphe);
        }
        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            _context.Paragraphes.Update(paragraphe);
            //_context.Attach<Paragraphe>(paragraphe);
            //_context.Entry(paragraphe).Property(item => item.Titre).IsModified = true;
            _context.SaveChanges();

            return View(paragraphe);
        }

        #endregion
    }
}
