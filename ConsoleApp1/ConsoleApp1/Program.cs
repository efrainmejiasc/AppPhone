using ConsoleApp1.Clases;
using ConsoleApp1.Models;
using ConsoleApp1.Models.SmitcoModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetMLCategories();
            //GetMLEspecificCategorie();
            //GetMLTrendsCOAsync();
            //GetProductsFromFreeMarketAsync();
            //GetTrendsCountryAndCategoriesAsync();

            //ExcuteSp();

            //CreateComponentNewsTrends();

            //GetFIAsync();

            //SolicitudPatagonia();

            //solution("abc", "abccba");

            var R = SerializeME();
        }


        static int solution(string a, string b)
        {
            var cont = 0;
            var lA = a.Length;
            var lB = b.Length;
            var lAB = b.Length / a.Length;
            var listB = new List<string>();

          


            for (int i = 0; i <= lAB - 1; i++)
            {
                
                if(i == 0)
                {
                    if (a.Contains(b.Substring(i, lA)))
                        cont++;
                }
                else
                {
                    if (a.Contains(b.Substring(i, lA)))
                        cont++;
                }
            }

            Console.WriteLine("solution(a, b) =" + cont);
            return 0;
        }

        public static void SolicitudPaises()
        {
            var solicitudML = new SolicitudPaises();
            var respuesta = solicitudML.GetPaisesAsync().Result;
        }

        public static void GetMLCategories()
        {
            var solicitudML = new SolicitudesML();
            var respuesta = solicitudML.GetMLCategoriesAsync().Result;
        }

        public static void GetMLTrendsCOAsync()
        {
            var solicitudML = new SolicitudesML();
            var respuesta = solicitudML.GetMLTrendsCOAsync().Result;
        }

        public static void GetMLEspecificCategorie()
        {
            var solicitudML = new SolicitudesML();
            var respuesta = solicitudML.GetMLSubEspecificCategorieAsync().Result;
        }

        public static void GetProductsFromFreeMarketAsync()
        {
            var solicitudML = new SolicitudesML();
            var respuesta = solicitudML.GetProductsFromFreeMarketAsync().Result;
        }


        public static void GetTrendsCountryAndCategoriesAsync()
        {
            var solicitudML = new SolicitudesML();
            var respuesta = solicitudML.GetTrendsCountryAndCategoriesAsync().Result;
        }


        public static void GetFIAsync()
        {
            var solicitudML = new SolicitudesFaceInstagram();

            //var respuesta = solicitudML.AuthAppTokenFIAsync().Result;
            //var accesoApp = JsonConvert.DeserializeObject<AccessAppFI>(respuesta);
            //respuesta = solicitudML.AuthUserTokenFIAsync(accesoApp.access_token).Result;
            //var accesoClient = JsonConvert.DeserializeObject<AccessClientFI>(respuesta);

            //respuesta = solicitudML.TestFIAsync(accesoClient.data.Select(x => x.access_token).FirstOrDefault()).Result;
            var tk = "EAAKWexagxaYBAJ05LRpfZCKPrgAWxhThahMDZCuuI7Eftld8Ju1Hfu8OV290JJNbYKLcaZAsYKvpSdaffJXCOjtbBrAAAttdCvMndqfNYXAY5n4yTAXYjU8vKZB0sbOwe29SkHnCU3qgPr8VZAPWrsaWBicoHI1D1BuIZBGl1JKwZDZD";
            var respuesta = solicitudML.TestFIAsync(tk).Result;
        }

        public static void SolicitudPatagonia()
        {
            var solicitudML = new SolicitudesPatagonia();
            var respuesta = solicitudML.GetDataPatagoniaAsync().Result;
        }

        public static void ExcuteSp()
        {
            //TestSp.UsarSpOne();
            //TestSp.UsarSpTwo();
            TestSp.UsarSpFour();
        }

        public static async void CreateComponentNewsTrends()
        {
            var lst = new List<CreateComponent>();
            var component = new CreateComponent();
            component.id = 0;
            component.name = "nombre propiedad";
            component.idTemplate = 1;
            component.idState = 1;
            component.state = "1";
            component.attributes = SetAttributes();
            lst.Add(component);

            var jsonContent = JsonConvert.SerializeObject(lst);

            await  SolicitudesNewsTrends.CreateComponentAsync(jsonContent);

            Console.ReadKey();
        }

        public static List<Models.Attribute> SetAttributes()
        {
            var x = new Models.Attribute();
            var lst = new List<Models.Attribute>();
            x.id = 1;
            x.name = "nombre1";
            x.value = "valor1";
            lst.Add(x);

            x = new Models.Attribute();
            x.id = 2;
            x.name = "nombre2";
            x.value = "valor2";
            lst.Add(x);

            return lst;
        }

        public static string SerializeME()
        {
            var m = new MovimientoMonedaExtranjeraParametrosModel()
            {
                Empresa = 6,
                Anio = 2022,
                FechaInicial = 2022 - 01 - 01,
                FechaFinal = 2022 - 02 - 28,
                CuentaInicial = 11050501,
                CuentaFinal = 11100501,
                Comprobantes = "T",
                TipoComprobanteInicial = "",
                ComprobanteInicial = "",
                NumeroInicial = "",
                TipoComprobanteFinal = "",
                ComprobanteFinal = "",
                NumeroFinal = "",
                GenerarPor = "C",
                OrdenadoPor = "F",
                IncluirCuentasNoMarcadasExtranjera = true
            };

            return JsonConvert.SerializeObject(m);
        }

    }
}
