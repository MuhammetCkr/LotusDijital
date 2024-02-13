using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public class AreaProductDAL
    {
        public static async Task<List<ProductModel>> GetProductListAsync()
        {
            var products = new List<ProductModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/products");
                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();
                    products = JsonSerializer.Deserialize<List<ProductModel>>(contentResponse);
                }
                else
                {
                    products = new List<ProductModel>();
                }
            }
            return products;
        }

        public static async Task<int> AddProductAsync(AddProductModel addProductModel)
        {
            using (var httpClient = new HttpClient())
            {
                var serializeProduct = JsonSerializer.Serialize(addProductModel);
                var stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(Jobs.ApiUrlString + "/addProduct", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent == "true" ? 200 : 300;
                }
                return 400;
            }
        }

        public static async Task<bool> DeleteProduct(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync(Jobs.ApiUrlString + "/deleteProduct/" + id);
                return response.IsSuccessStatusCode;
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

        public static async Task<int> UpdateProduct(UpdateProductViewModel model)
        {
            using (var httpClient = new HttpClient())
            {
                var serializeProduct = JsonSerializer.Serialize(model);
                var stringContent = new StringContent(serializeProduct, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(Jobs.ApiUrlString + "/updateProduct", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent == "true" ? 200 : 300;
                }
                return 400;
            }
        }
    }
}
