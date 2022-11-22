using ConsoleApp1.Models;
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
using System.Xml;

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
            var result = new Dictionary<string, List<object>>();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("clientToken", clientToken);
                //HttpResponseMessage response = await client.GetAsync(urlBase + "company/301699");

                //HttpResponseMessage response = await client.GetAsync(urlBase + "report/courses/companies");
                //HttpResponseMessage response = await client.GetAsync(urlBase + "report/postulations?from=2019-01-01&to=2022-07-30");
                // HttpResponseMessage response = await client.GetAsync(urlBase + "report/communities/companies");
                //HttpResponseMessage response = await client.GetAsync(urlBase + "community");
                //HttpResponseMessage response = await client.GetAsync(urlBase + "business_opportunity?items_per_page=60&offset=0&lang=es&country=2007");

                HttpResponseMessage response = await client.GetAsync(urlBase + "report/courses/users");

                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<Dictionary<string, List<object>>>(respuesta);
                    var companyInCommunity = new List<PatagonianCompanyInCommunity>();
                    var community = new PatagonianCompanyInCommunity();
                    foreach (var item in result.ToList())
                    {
                        community.CommunityName = item.Key;
                        community.CompanyProperty = new List<CompanyProperty>();
                        foreach(var subItem in item.Value)
                        {
                            var single = JsonConvert.DeserializeObject<CompanyProperty>(subItem.ToString());
                            community.CompanyProperty.Add(single);
                        }

                        companyInCommunity.Add(community);
                        community = new PatagonianCompanyInCommunity();
                    }

                    var test = "";

                    //userCourse = JsonConvert.DeserializeObject<UserCoursePatagoniaModel>(respuesta);
                    // companyCourse = JsonConvert.DeserializeObject<CompanyCoursePatagoniaModel>(respuesta);
                    //XmlDocument doc = JsonConvert.DeserializeXmlNode(respuesta);
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return respuesta;
        }

        public async Task<string> GetDataPatagoniaAsync(bool opt)
        {
            var respuesta = string.Empty;
            var userCourse = new UserCoursePatagoniaModel();
            var companyCourse = new CompanyCoursePatagoniaModel();
            var result = new List<object>();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("clientToken", clientToken);
                HttpResponseMessage response = await client.GetAsync(urlBase + "report/postulations?from=2019-01-01&to=2022-07-30");
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<object>>(respuesta);
                    var productsServices = new List<PatagonianApplicationsForProductsService>();
                    var single = new PatagonianApplicationsForProductsService();
                    foreach(var item in result)
                    {
                        single = JsonConvert.DeserializeObject<PatagonianApplicationsForProductsService>(item.ToString());
                        productsServices.Add(single);
                    }

                    var allProductsService = productsServices.Where(x => x.Products != null).Select(x => x.Products).Distinct().ToList();


                    var n = "";
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
