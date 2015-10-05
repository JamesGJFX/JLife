using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jLife.DAL;
using jLife.Models;

namespace jLife.Controllers
{
    public class RssFeedsController : Controller
    {
        private RssFeedContext db = new RssFeedContext();

        // GET: RssFeeds
        public ActionResult Index()
        {
            return View(db.RssFeeds.ToList());
        }

        // GET: RssFeeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RssFeed rssFeed = db.RssFeeds.Find(id);
            if (rssFeed == null)
            {
                return HttpNotFound();
            }
            return View(rssFeed);
        }

        // GET: RssFeeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RssFeeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Url")] RssFeed rssFeed)
        {
            if (ModelState.IsValid)
            {
                db.RssFeeds.Add(rssFeed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rssFeed);
        }

        // GET: RssFeeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RssFeed rssFeed = db.RssFeeds.Find(id);
            if (rssFeed == null)
            {
                return HttpNotFound();
            }
            return View(rssFeed);
        }

        // POST: RssFeeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Url")] RssFeed rssFeed)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rssFeed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rssFeed);
        }

        // GET: RssFeeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RssFeed rssFeed = db.RssFeeds.Find(id);
            if (rssFeed == null)
            {
                return HttpNotFound();
            }
            return View(rssFeed);
        }

        // POST: RssFeeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RssFeed rssFeed = db.RssFeeds.Find(id);
            db.RssFeeds.Remove(rssFeed);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
