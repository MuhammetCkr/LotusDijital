using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products = await AreaProductDAL.GetProductListAsync();
            return View(products);
        }

        public async Task<IActionResult> AddProduct()
        {
            var categories = await AreaCategoryDAL.GetCategoriesAsync();
            var imageGalleries = await AreaImageGalleryDAL.GetImageGalleryList();
            var productModel = new ProductModel()
            {
                Categories = categories,
                ImageGalleries = imageGalleries
            };
            return View(productModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductModel addProductModel, IFormFile image, IFormFile smallImage, IFormFile banner)
        {
            if (image != null)
                addProductModel.Image = Jobs.UploadImage(image);
            if (smallImage != null)
                addProductModel.SmallImage = Jobs.UploadImage(smallImage);
            if (banner != null)
                addProductModel.Banner = Jobs.UploadImage(banner);

            var response = await AreaProductDAL.AddProductAsync(addProductModel);
            return Json(new { status = response });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var response = await AreaProductDAL.DeleteProduct(id);
            var status = response ? 200 : 0;
            return Json(new { status = status });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await AreaProductDAL.GetProductById(id);
            var categories = await AreaCategoryDAL.GetCategoriesAsync();
            var imageGalleries = await AreaImageGalleryDAL.GetImageGalleryList();
            var productModel = new UpdateProductViewModel()
            {
                Categories = categories,
                ImageGalleries = imageGalleries,
                Banner = product.Banner,
                CategoryIds = product.Categories.Select(c => c.Id).ToList(),
                ImageGalleryIds = product.ImageGalleries.Select(ig => ig.Id).ToList(),
                Id = product.Id,
                Contents = product.Contents,
                Image = product.Image,
                IsActive = product.IsActive,
                IsHome = product.IsHome,
                Link = product.Link,
                Name = product.Name,
                ShortContent = product.ShortContent,
                SmallImage = product.SmallImage,
                Title = product.Title,
                Url = product.Url,
                TrendyolLink = product.TrendyolLink,
                HepsiBuradaLink = product.HepsiBuradaLink,
                CicekSepetiLink = product.CicekSepetiLink,
            };
            return View(productModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductViewModel updateProduct, IFormFile image, IFormFile smallImage, IFormFile banner)
        {
            if (image != null)
                updateProduct.Image = Jobs.UploadImage(image);
            if (smallImage != null)
                updateProduct.SmallImage = Jobs.UploadImage(smallImage);
            if (banner != null)
                updateProduct.Banner = Jobs.UploadImage(banner);
            var response = await AreaProductDAL.UpdateProduct(updateProduct);
            //return Json(new { status = response });
            return RedirectToAction("UpdateProduct",updateProduct.Id);
        }
    }
}
