using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await AreaCategoryDAL.GetCategoriesAsync();
            return View(categories);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryModel addCategoryModel, IFormFile file)
        {
            if (file != null)
                addCategoryModel.Image = Jobs.UploadImage(file);

            var response = await AreaCategoryDAL.AddCategory(addCategoryModel);
            return Json(new { status = response });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var response = await AreaCategoryDAL.DeleteCategory(id);
            var status = response ? 200 : 0;
            return Json(new { status = status });
        }

        [HttpGet]
        public async Task<IActionResult> EditCategory(int id)
        {
            var response = await AreaCategoryDAL.GetCategoryAsync(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(EditCategoryModel editCategoryModel, IFormFile image)
        {
            editCategoryModel.Image = image == null ? "" : Jobs.UploadImage(image);
            var response = await AreaCategoryDAL.EditCategory(editCategoryModel);
            return Json(new { status = response });
        }
    }
}
