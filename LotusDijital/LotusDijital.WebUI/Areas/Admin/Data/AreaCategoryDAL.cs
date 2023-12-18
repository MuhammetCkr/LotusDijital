using LotusDijital.WebUI.Models;
using System.Text.Json;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public static class AreaCategoryDAL
    {
        public static async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var categories = new List<CategoryModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("http://localhost:5111/categories");
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

        public static async Task<bool> AddCategory(CategoryModel categoryModel)
        {
            var category = new CategoryModel();
            using (var httpClient = new HttpClient())
            {
                var serializeCategory = JsonSerializer.Serialize(categoryModel);
                var stringContent = new StringContent(serializeCategory, System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://localhost:5111/addcategory",stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();
                    return true;
                }
                else
                {
                   return false;
                }
            }
        }
    }
}
