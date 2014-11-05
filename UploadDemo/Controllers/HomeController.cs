using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace UploadDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if(this.Request.Files != null || this.Request.Files.Count > 0)
            {
                this.Request.Files[0].SaveAs(Server.MapPath("~/App_Data/" + this.Request.Files[0].FileName));
            }
            return View("Index");
        }
        
        [HttpGet]
        public ActionResult Beauty()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Beauty(HttpPostedFileBase file)
        {
            if (this.Request.Files != null || this.Request.Files.Count > 0)
            {
                this.Request.Files[0].SaveAs(Server.MapPath("~/App_Data/" + this.Request.Files[0].FileName));
            }
            return View("Beauty");
        }

        public ActionResult Html5()
        {
            return View();
        }

        public ActionResult Flash()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MD5()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Base64()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Flash(HttpPostedFileBase file)
        {
            if (this.Request.Files != null || this.Request.Files.Count > 0)
            {
                this.Request.Files[0].SaveAs(Server.MapPath("~/App_Data/" + this.Request.Files[0].FileName));
            }
            return Json(new { status = "ok" });
        }


        [HttpPost]
        public ActionResult H5Upload(HttpPostedFileBase file)
        {
            StringBuilder builder = new StringBuilder();
            if (this.Request.Files != null || this.Request.Files.Count > 0)
            {
                for (int i = 0; i < this.Request.Files.Count; i++ )
                {
                    var item = this.Request.Files[i];
                    item.SaveAs(Server.MapPath("~/App_Data/" + item.FileName));
                    builder.AppendLine(item.FileName);
                }
                    
            }

            return Json(new { status = "ok", list = builder.ToString()});
        }

        [HttpPost]
        public ActionResult H5UploadStream(string name)
        {
            var filePath = Path.Combine(Server.MapPath("~/App_Data/"), name);
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);

            using (var fileStream = System.IO.File.Create(filePath))
            {
                this.Request.InputStream.CopyTo(fileStream);
            }

            return Json(new { status = "ok", list = name });
        }
    }
}