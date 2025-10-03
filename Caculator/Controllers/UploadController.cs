using Grpc.Core;
using Microsoft.AspNetCore.Mvc;

namespace Caculator.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View("UploadFiles");
        }
        public IActionResult UploadFiles(IFormFile image, IFormFile document)
        {
            if (document != null && document.Length > 0)
            {
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UploadFiles");
                var filePath = Path.Combine(uploadPath, document.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    document.CopyTo(stream); // tương đương SaveAs(path)
                }

                if (image is { Length: > 0 })
                {
                    var imgPath = Path.Combine(uploadPath, image.FileName);
                    using var s1 = new FileStream(imgPath, FileMode.Create);
                    image.CopyTo(s1);

                    ViewBag.ImagePath = "/UploadFiles/" + image.FileName;
                    ViewBag.ImageType = image.ContentType;
                }

                ViewBag.filePath = "/UploadFiles/" + document.FileName;
                ViewBag.fileName = document.FileName;
                ViewBag.fileType = document.ContentType;
                ViewBag.fileSize = document.Length;
            }
            return View("UploadFiles");
        }
    }
}
