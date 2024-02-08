using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text;
using System.Text.Json;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public static class AreaPageDAL
    {
        public static async Task<List<PageModel>> PageList()
        {
            var pageList = new List<PageModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/pageList");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    pageList = JsonSerializer.Deserialize<List<PageModel>>(responseContent);
                    return pageList;
                }
                return pageList;
            }

        }

        public static async Task<PageModel> GetPage(int id)
        {
            var pageModel = new PageModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getPage/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    pageModel = JsonSerializer.Deserialize<PageModel>(responseContent);
                    return pageModel;
                }
                return pageModel;
            }
        }

        public static async Task<int> AddPage(AddPageModel addPageModel)
        {
            using (var httpClient = new HttpClient())
            {
                var serailazePage = JsonSerializer.Serialize(addPageModel);
                var stringPage = new StringContent(serailazePage, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(Jobs.ApiUrlString + "/addPage", stringPage);
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

        public static async Task<int> DeletePage(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync(Jobs.ApiUrlString + "/deletePage/" + id);
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
