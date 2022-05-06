using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public  class SolicitudesNewsTrends
    {
        public static async Task CreateComponentAsync(string jsonContent)
        {
            var respuesta = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");
                HttpResponseMessage response = await client.PostAsync("https://localhost:44387/api/HomeComponent/createComponents", new StringContent(jsonContent, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
        }
    }
}
