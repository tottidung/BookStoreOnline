﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Areas.Admin.Controllers
{
    public class AdminReviewController : Controller
    {
        NhaSachEntities db = new NhaSachEntities();

        // GET: AdminReview
        public ActionResult Index()
        {
            var reviews = db.DANHGIAs.Include("KHACHHANG").Include("SANPHAM").ToList();
            return View(reviews);
        }

        // GET: AdminReview/Delete/5
        public ActionResult Delete(int id)
        {
            var review = db.DANHGIAs.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: AdminReview/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var review = db.DANHGIAs.Find(id);
            if (review != null)
            {
                db.DANHGIAs.Remove(review);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}