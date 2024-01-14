using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text;
using System.Text.Json;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public class AreaProductDAL
    {
        public static async Task<List<ProductModel>> GetProductAsync()
        {
            var products = new List<ProductModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(ApiUrl.ApiUrlString + "products");
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
                var response = await httpClient.PostAsync(ApiUrl.ApiUrlString + "addProduct", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent == "true" ? 200 : 300;
                }
                else
                    return 400;
            }
        }

        public static async Task<bool> DeleteProduct(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync(ApiUrl.ApiUrlString + "deleteProduct/" + id);
                return response.IsSuccessStatusCode;
            }
        }
    }
}
