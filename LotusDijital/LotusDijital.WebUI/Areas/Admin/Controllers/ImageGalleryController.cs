using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ImageGalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddImageGallery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddImageGallery(AddImageGalleryModel addImageGalleryModel, List<IFormFile> images)
        {
            foreach (var image in images)
            {
                var imageModel = new ImageModel();
                imageModel.Name = image.FileName;
                imageModel.Url = Jobs.UploadImage(image);
                addImageGalleryModel.Images.Add(imageModel);
            }
            var response = await AreaImageGalleryDAL.AddImageGallery(addImageGalleryModel);
            return Json(new { status = response });
        }

        [HttpGet]
        public async Task<IActionResult> GetImageGallery(int id)
        {
            var imageGalleryModel = await AreaImageGalleryDAL.GetImageGallery(id);
            return View(imageGalleryModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetImageGalleryList()
        {
            var imageGalleryList = await AreaImageGalleryDAL.GetImageGalleryList();
            return View(imageGalleryList);
        }
    }
}
