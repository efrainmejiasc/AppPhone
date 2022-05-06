using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1.Clases
{
    public class SolicitudesML
    {
        string end1 = "https://developers/mercadolibre.com.ar/es_ar/tendencias";
        string end2 = "https://api.mercadolibre.com/sites/MCO/categories";
        string end3 = "https://api.mercadolibre.com/categories/MCO1747";
        string end4 = "https://api.mercadolibre.com/trends/MCO";
        string end5 = "https://api.mercadolibre.com/products/search?status=active&site_id=MCO&q=Samsung%20Galaxy%20S8&limit=10000";
        string end6 = " https://api.mercadolibre.com/trends/MCO/MCO1747";

        //Devuelve todas las categorias
        public async Task<List<CategoriesMLModel>> GetMLCategoriesAsync()
        {
            var respuesta = string.Empty;
            var lstCategories = new List<CategoriesMLModel>();

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "APP_USR-12345678-031820-X-12345678");
                HttpResponseMessage response = await client.GetAsync(end2);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    lstCategories = JsonConvert.DeserializeObject<List<CategoriesMLModel>>(respuesta);

                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return lstCategories;
        }

        //Devuelve todas las sub categorias de una especifica
        public async Task<string> GetMLSubEspecificCategorieAsync()
        {
            var respuesta = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "APP_USR-12345678-031820-X-12345678");
                HttpResponseMessage response = await client.GetAsync(end3);
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

        // Devuelve tendencias en mercado libre 
        public async Task<List<FreeMarketTrends>> GetMLTrendsCOAsync()
        {
            var respuesta = string.Empty;
            var lstTrends = new List<FreeMarketTrends>();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "APP_USR-12345678-031820-X-12345678");
                HttpResponseMessage response = await client.GetAsync(end4);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    lstTrends = JsonConvert.DeserializeObject<List<FreeMarketTrends>>(respuesta);

                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return lstTrends;
        }

        public async Task<FreeMarketSearchProduct> GetProductsFromFreeMarketAsync()
        {
            var respuesta = string.Empty;
            var product = new FreeMarketSearchProduct();
            var keyWord = string.Empty;
            keyWord =  keyWord.Replace(" ", "%20");

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "APP_USR-12345678-031820-X-12345678");
                HttpResponseMessage response = await client.GetAsync(end5);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<FreeMarketSearchProduct> (respuesta);
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return product;
        }


        public async Task<string> GetTrendsCountryAndCategoriesAsync()
        {
            var respuesta = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "APP_USR-12345678-031820-X-12345678");
                HttpResponseMessage response = await client.GetAsync(end6);
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
