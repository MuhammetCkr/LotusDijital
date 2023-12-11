using LotusDijital.WebUI.Models;
using System.Text.Json;

namespace LotusDijital.WebUI.Data
{
    public static class CategoryDAL
    {
        public static async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var categories = new List<CategoryModel>();
            using(var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://localhost:44354/categories");
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
