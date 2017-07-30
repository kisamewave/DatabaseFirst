using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirst.Controllers
{
    public class AlbumController : Controller
    {
        DBFirstEntities db = new DBFirstEntities();
        
        public ActionResult Index()
        {
            List<tblAlbums> albums = db.tblAlbums.ToList();
            return View(albums);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblAlbums album)
        {
            if (this.ModelState.IsValid)
            {
                db.tblAlbums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(album);
        }

       
    }
    
}