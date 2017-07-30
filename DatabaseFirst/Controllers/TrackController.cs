using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirst.Controllers
{
    public class TrackController : Controller
    {
        // GET: Track
        public ActionResult Index(int itemId)
        {
            DBFirstEntities db = new DBFirstEntities();
            List<tblTracks> tracks = db.tblTracks.Where(m => m.AlbumID == itemId).ToList();
            
            return View(tracks);
        }


        public ActionResult Create(int itemId)
        {
            DBFirstEntities db = new DBFirstEntities();
            List<tblTracks> tracks = db.tblTracks.Where(m => m.AlbumID == itemId).ToList();

            return View(tracks);
        }
        [HttpPost]
        public ActionResult Create(tblTracks track)
        {
            DBFirstEntities db = new DBFirstEntities();
            if (ModelState.IsValid)
            {
                db.tblTracks.Add(track);
                db.SaveChanges();
                return View("Index");
            }

            return View(track);
            

        }
    }
}