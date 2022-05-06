using ConsoleApp1.Models.PatagoniaModels;
using ConsoleApp1.Models.PatagoniaModels.UC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class SolicitudesPatagonia
    {
        private string urlBase = "https://qat02-ws.connectamericas.com/apirest/v6/";
        private string clientToken = "ivo-IvByAbqsMy";
        public async Task<string> GetAuthPatagoniaAsync()
        {
            var respuesta = string.Empty;

            try
            {

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "ivo-IvByAbqsMy");
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://qat02-auth.connectamericas.com/ca-cas/login?service=/user/sso");
                var formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("user", "bruno @patagonian.it"));
                formData.Add(new KeyValuePair<string, string>("pass", "123456789"));
                request.Content = new FormUrlEncodedContent(formData);
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();

                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return respuesta;
        }

        public async Task<string> GetDataPatagoniaAsync()
        {
            var respuesta = string.Empty;
            var userCourse = new UserCoursePatagoniaModel();
            var companyCourse = new CompanyCoursePatagoniaModel();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("clientToken", clientToken);
                 //HttpResponseMessage response = await client.GetAsync(urlBase + "company/301699");
                //HttpResponseMessage response = await client.GetAsync(urlBase + "report/courses/users");
                HttpResponseMessage response = await client.GetAsync(urlBase + "report/courses/companies");


                //HttpResponseMessage response = await client.GetAsync(urlBase + "community");
                //HttpResponseMessage response = await client.GetAsync(urlBase + "business_opportunity");
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    //userCourse = JsonConvert.DeserializeObject<UserCoursePatagoniaModel>(respuesta);
                    companyCourse = JsonConvert.DeserializeObject<CompanyCoursePatagoniaModel>(respuesta);
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return respuesta;
        }

    }
}
