using LotusDijital.WebUI.Areas.Admin.Models;
using System.Text;
using System.Text.Json;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public static class AreaImageGalleryDAL
    {
        public static async Task<int> AddImageGallery(AddImageGalleryModel addImageGalleryModel)
        {
            using (var httpClient = new HttpClient())
            {
                var serialize = JsonSerializer.Serialize(addImageGalleryModel);
                var stringContent = new StringContent(serialize, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(Jobs.ApiUrlString + "/addImageGallery", stringContent);
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
