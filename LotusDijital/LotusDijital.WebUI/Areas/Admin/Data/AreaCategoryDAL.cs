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
    }
}
