using LotusDijital.WebUI.Models;
using System.Text;
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
                var response = await httpClient.GetAsync(ApiUrl.ApiUrlString + "categories");
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

        public static async Task<int> AddCategory(AddCategoryModel addCategoryModel)
        {
            var category = new CategoryModel();
            using (var httpClient = new HttpClient())
            {
                var serializeCategory = JsonSerializer.Serialize(addCategoryModel);
                var stringContent = new StringContent(serializeCategory, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(ApiUrl.ApiUrlString + "addcategory", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent == "true" ? 200 : 300;
                }
                else
                {
                    return 400;
                }
            }
        }

        public static async Task<bool> DeleteCategory(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync(ApiUrl.ApiUrlString + "deletecategory/" + id);

                return response.IsSuccessStatusCode;
            }
        }

        public static async Task<CategoryModel> GetCategoryAsync(int id)
        {
            var category = new CategoryModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(ApiUrl.ApiUrlString + "category/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();
                    category = JsonSerializer.Deserialize<CategoryModel>(contentResponse);
                }
            }
            return category;
        }

        public static async Task<int> EditCategory(EditCategoryModel editCategoryModel)
        {
            using (var httpClient = new HttpClient())
            {
                var serializeCategory = JsonSerializer.Serialize(editCategoryModel);
                var stringContent = new StringContent(serializeCategory, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(ApiUrl.ApiUrlString + "updatecategory", stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent == "true" ? 200 : 300;

                }
                else
                {

                    return 400;
                }
            }
        }

    }
}
