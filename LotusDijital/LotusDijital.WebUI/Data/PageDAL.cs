using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text.Json;

namespace LotusDijital.WebUI.Data
{
    public static class PageDAL
    {
        public static async Task<List<PageModel>> PageList()
        {
            var pages = new List<PageModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/pageList");
                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();
                    pages = JsonSerializer.Deserialize<List<PageModel>>(contentResponse);
                    return pages;
                }
                return pages;
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
    }
}
