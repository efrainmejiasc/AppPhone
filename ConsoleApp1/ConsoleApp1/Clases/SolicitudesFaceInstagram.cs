using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public  class SolicitudesFaceInstagram
    {
        
        string appId = "728405358200230";

        string ivolucionId = "728405358200230";
        string ivolucionKey = "96faff62c31606030daf7c868f6175d9";
        string tokencito = "728405358200230|ctprcfHOiqfnjAIARy1TLLxsp2w";
        string tokenCliente = "2c0797dd760a721d451f28192e5b31ae";

        string emcId = "17841437055492222";
        string efraId = "17841405361556515";
        string appId2 = "3134845913232087";
        string ivolucionId2 = "1167581320723828";
        string ivolucionKey2 = "12fdedbcb16ac1f20d9957e14bac3f39";



        public async Task<string> AuthAppTokenFIAsync()
        {
            var respuesta = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://graph.facebook.com/oauth/access_token");
                var formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("client_id",ivolucionId));
                formData.Add(new KeyValuePair<string, string>("client_secret", ivolucionKey));
                formData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                request.Content = new FormUrlEncodedContent(formData);
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    respuesta = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch(Exception ex)
            {
                var error = ex.Message;
            }
         

            return respuesta;
        }

        public async Task<string> AuthUserTokenFIAsync(string tokencito)
        {
            var respuesta = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokencito);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://graph.facebook.com/" + ivolucionId + "/accounts" );
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    respuesta = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }


            return respuesta;
        }


        public async Task<string> TestFIAsync( string access_token)
        {
            var respuesta = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
                var url = "https://graph.facebook.com/v13.0/me?fields=id%2Cname%2Cfeed";
                HttpResponseMessage response = await client.GetAsync(url);
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
    }
}
