using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Video.Models;

namespace Video.Controllers
{
    public class VideoController : Controller
    {
        VideoContext context = new VideoContext();
        // GET: Video
        public ActionResult Index() {
            string[] mas = Directory.GetFiles(Request.PhysicalApplicationPath + "Video");
            for (int i = 0; i < mas.Length; i++) {
                mas[i] = Path.GetFileName(mas[i]);
            }
            ViewBag.Catalogs = mas;
            return View("list");
        }
        public FileStreamResult GetFile(string name) {
            string path = Request.PhysicalApplicationPath + "Video\\" + name;
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            return new FileStreamResult(fileStream, "video/mp4");
        }
        public ActionResult GetVideo(string name) {
            ViewBag.VideoName = name;
            return View("Player");
        }

        public ActionResult Upload(HttpPostedFileBase upload) {
            if (upload != null) {
                // получаем имя файла
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                // сохраняем файл в папку Files в проекте
                upload.SaveAs(Server.MapPath("~/Video/" + fileName));
            }
            return RedirectToAction("Index");
        }
    }
}
