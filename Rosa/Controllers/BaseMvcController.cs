using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Rosa.Controllers
{
    public class BaseMvcController : Controller
    {
        
        readonly protected IWebHostEnvironment _env;
        public BaseMvcController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void SetMessage(string message, string type = "success")
        {
            TempData["message"] = message;
            TempData["type"] = type;
        }

        protected string UploadImage(IFormFile file)
        {
            if (file == null)
                return null;

            string filePathToSave = Path.Combine("upload","images", $"{Guid.NewGuid()}_{file.FileName}");
            FileInfo fileInfo = new FileInfo(Path.Combine(_env.WebRootPath, filePathToSave));

            if (!fileInfo.Directory.Exists)
                fileInfo.Directory.Create();

            using(var fileStream = new FileStream(fileInfo.FullName, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return $"/{filePathToSave.Replace(@"\", "/")}" ;
        }

    }
}
