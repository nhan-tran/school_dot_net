using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nt_lab3_HomeInventory.ViewModel;
using nt_lab3_HomeInventory.Models;

namespace nt_lab3_HomeInventory.Controllers
{
    public class FileAttachmentController : Controller
    {

        private HomeInsDBContext db = new HomeInsDBContext();
        //
        // GET: /FileAttachment/

        public ActionResult Index()
        {
            var model = new FileAttachment();
            ViewBag.ItemId = new SelectList(db.Items, "ItemId", "Title");
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FileAttachment model)
        {
            ViewBag.ItemId = new SelectList(db.Items, "ItemId", "Title");

            if (!ModelState.IsValid || model.File == null)
            {
                model.Message = "Import unsuccessfully. Please try again.";
                //return RedirectToAction("Index");
                return View(model);
            }

            byte[] uploadedFile = new byte[model.File.InputStream.Length];
            model.File.InputStream.Read(uploadedFile, 0, uploadedFile.Length);
            
            var item = db.Items.Find(model.ItemId);
            item.Picture = uploadedFile;
            db.SaveChanges();
            model.Message = "Import completed successfully.";
            //return RedirectToAction("Index");
            return View(model);
            //return Content("Thanks for uploading the file");
        }

        //Return the byte[] array to the browser
        //http://researchaholic.com/2012/07/06/mvc-display-an-image-that-is-stored-as-a-byte-array/#comment-636
        public ActionResult Download(int id)
        { 
            var image = db.Items.Find(id).Picture;
            return image != null ? new FileContentResult(image, "image/png") : null;
        }


        //
        // GET: /FileAttachment/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /FileAttachment/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FileAttachment/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /FileAttachment/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /FileAttachment/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /FileAttachment/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /FileAttachment/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
