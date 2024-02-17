using LotusDijital.WebUI.Areas.Admin.Models;
using System.Text.Json;

namespace LotusDijital.WebUI.Data
{
    public static class SettingsDAL
    {
        public static async Task<SettingsModel> GetSettings(int id)
        {
            var settings = new SettingsModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Jobs.ApiUrlString + "/getSettings/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    settings = JsonSerializer.Deserialize<SettingsModel>(responseContent);
                    return settings;
                }
                return settings;
            }
        }
    }
}
