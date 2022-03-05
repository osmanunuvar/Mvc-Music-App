using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMusic.Models;
using MvcMusic.ViewModels;

namespace MvcMusic.Controllers
{
    public class MusicsController : Controller
    {
        private MusicDbContext db = new MusicDbContext();

        // GET: Musics
        public ActionResult Index(string search)
        {
            return View(db.Musics.Where(x => x.Title.Contains(search) || x.Artist.Contains(search) || search == null).ToList());
        }

        // GET: Musics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // GET: Musics/Create
        public ActionResult Create()
        {
            return View(new CreateMusicViewModel { ListItems = new List<SelectListItem> { new SelectListItem { Text = "Pop", Value = "Pop" } } });
        }

        // POST: Musics/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Artist,ReleaseDate,Genre")] Music music)
        {
            if (ModelState.IsValid)
            {
                db.Musics.Add(music);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(music);
        }

        // GET: Musics/Edit/5
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(new EditMusicViewModel
            {
                Artist= music.Artist,
                Title=music.Title,
                Genre= music.Genre,
                ReleaseDate=music.ReleaseDate,
                ID=music.ID,
                ListItems = new List<SelectListItem> { new SelectListItem { Text = "Pop", Value = "Pop" } }
            });
        }

        // POST: Musics/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Artist,ReleaseDate,Genre")] EditMusicViewModel musicViewModel)
        {
            if (ModelState.IsValid)
            {
                Music music = db.Musics.Find(musicViewModel.ID);
                if (music == null)
                {
                    return HttpNotFound();
                }
                music.Artist = musicViewModel.Artist;
                music.Genre = musicViewModel.Genre;
                music.ReleaseDate = musicViewModel.ReleaseDate;
                music.Title = musicViewModel.Title;
                db.Entry(music).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musicViewModel);
        }

        // GET: Musics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // POST: Musics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Music music = db.Musics.Find(id);
            db.Musics.Remove(music);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
