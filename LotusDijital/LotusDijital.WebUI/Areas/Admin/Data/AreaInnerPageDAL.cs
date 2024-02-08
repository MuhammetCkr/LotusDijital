using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using System.Text;
using System.Text.Json;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public static class AreaInnerPageDAL
    {
        public static async Task<int> AddInnerPage(AddInnerPageModel addInnerPage)
        {
            using (var httpClient = new HttpClient())
            {
                var serializeInnerPage = JsonSerializer.Serialize(addInnerPage);
                var stringInnerPage = new StringContent(serializeInnerPage, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(Jobs.ApiUrlString + "/addInnerPage", stringInnerPage);
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
