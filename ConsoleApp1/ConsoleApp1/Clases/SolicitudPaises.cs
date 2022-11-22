using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public  class SolicitudPaises
    {
        public async Task<string> GetPaisesAsync()
        {
            var respuesta = string.Empty;

            try
            {

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://restcountries.com/v3.1/all");
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

        bool solution(string sequence)
        {
            var result = false;
            if (!string.IsNullOrEmpty(sequence))
            {
                Console.WriteLine("solution =  (" + sequence + ") = true");
                return true;
              }
            else
            
                Console.WriteLine("solution =  (" + sequence + ") = false");
 
            return result;
        }
    }
}
