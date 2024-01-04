using Examen.ApplicationCore.Domaine;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class ChansonController : Controller
    {
        IChansonService _chansonService;
        IArtisteService _artisteService;

        public ChansonController(IChansonService chansonService, IArtisteService artisteService)
        {
            _chansonService = chansonService;
            _artisteService = artisteService;
        }

        // GET: ChansonController
        public ActionResult Index(int? duree)
        {
            if (duree == null)
            return View(_chansonService.GetAll().OrderBy(p => p.VuesYoutube).ToList());
            else
            return View(_chansonService.GetMany(c => c.Duree.Equals(duree)).ToList());
        }

        // GET: ChansonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Artiste(int id)
        {
            return View(_artisteService.GetById(id));
        }

        // GET: ChansonController/Create
        public ActionResult Create()
        {
            ViewBag.ArtisteList = new SelectList(_artisteService.GetAll().ToList(), "ArtisteId", "Nom");
            return View();
        }

        // POST: ChansonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chanson chanson)
        {
            try
            {
                _chansonService.Add(chanson);
                _artisteService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChansonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChansonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
