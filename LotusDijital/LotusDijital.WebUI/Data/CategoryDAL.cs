using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Data
{
    public static class CategoryDAL
    {
        public static async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var categories = new List<CategoryModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/categories");
                if (response.IsSuccessStatusCode)
                {
                    var contentRespose = await response.Content.ReadAsStringAsync();
                    categories = JsonSerializer.Deserialize<List<CategoryModel>>(contentRespose);
                }
                else
                {
                    categories = new List<CategoryModel>();
                }
            }
            return categories;
        }
        public static async Task<List<CategoryModel>> GetCategoriesWithProducts()
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
            var categories = new List<CategoryModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getCategoriesWithProducts");
                if (response.IsSuccessStatusCode)
                {
                    var contentRespose = await response.Content.ReadAsStringAsync();
                    categories = JsonSerializer.Deserialize<List<CategoryModel>>(contentRespose,options);
                }
                else
                {
                    categories = new List<CategoryModel>();
                }
            }
            return categories;
        }
    }
}
