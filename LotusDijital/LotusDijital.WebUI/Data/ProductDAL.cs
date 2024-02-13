using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Data
{
    public static class ProductDAL
    {
        public static async Task<List<ProductModel>> GetProductsWithCategories()
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
            var productList = new List<ProductModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/productsWithCategories");
                if(response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    productList = JsonSerializer.Deserialize<List<ProductModel>>(responseContent,options);
                    return productList;
                }
                return productList;
            }
        }

        public static async Task<ProductModel> GetProduct(int id)
        {
            var productModel = new ProductModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getProduct/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    productModel = JsonSerializer.Deserialize<ProductModel>(responseContent);
                    return productModel;
                }
                return productModel;
            }
        }

        public static async Task<List<ProductModel>> GetProductList()
        {
            var productModel = new List<ProductModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/products");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    productModel = JsonSerializer.Deserialize<List<ProductModel>>(responseContent);
                    return productModel;
                }
                return productModel;
            }
        }

        public static async Task<ProductModel> GetProductById(int id)
        {
            var productModel = new ProductModel();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/productById/" + id);
                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                };
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    productModel = JsonSerializer.Deserialize<ProductModel>(responseContent, options);
                    return productModel;
                }
                return productModel;
            }
        }
    }
}
