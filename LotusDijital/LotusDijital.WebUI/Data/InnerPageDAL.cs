using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text.Json;

namespace LotusDijital.WebUI.Data
{
    public static class InnerPageDAL
    {
        public static async Task<InnerPageModel> GetInnerPage(int id)
        {
            var innerPageModel = new InnerPageModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getInnerPage/"+ id);
                if(response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    innerPageModel = JsonSerializer.Deserialize<InnerPageModel>(responseContent);
                    return innerPageModel;
                }
                return innerPageModel;
            }
        }
    }
}
