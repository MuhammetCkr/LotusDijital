using LotusDijital.WebUI.Areas.Admin.Models;
using System.Text;
using System.Text.Json;

namespace LotusDijital.WebUI.Areas.Admin.Data
{
    public static class AreaSettingsDAL
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

        public static async Task<int> UpdateAsync(SettingsModel settingsModel)
        {
            using (var httpClient = new HttpClient())
            {
                var serializeSettings = JsonSerializer.Serialize(settingsModel);
                var stringContent = new StringContent(serializeSettings, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(Jobs.ApiUrlString+ "/updateSettings", stringContent);
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
