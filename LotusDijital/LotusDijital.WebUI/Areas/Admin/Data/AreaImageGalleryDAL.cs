using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
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

        public static async Task<ImageGalleryModel> GetImageGallery(int id)
        {
            var imageGalleryModel = new ImageGalleryModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getImageGallery/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    imageGalleryModel = JsonSerializer.Deserialize<ImageGalleryModel>(responseContent);
                    return imageGalleryModel;
                }
                return imageGalleryModel;
            }
        }

        public static async Task<List<ImageGalleryModel>> GetImageGalleryList()
        {
            var imageGalleryList = new List<ImageGalleryModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getImageGalleryList");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    imageGalleryList = JsonSerializer.Deserialize<List<ImageGalleryModel>>(responseContent);
                    return imageGalleryList;
                }
                return imageGalleryList;
            }
        }
    }
}
