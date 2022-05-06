using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.PatagoniaModels
{
    public class CompanyPatagoniaModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string industry { get; set; }
        public string photo_url { get; set; }
        public string verified { get; set; }
        public string type { get; set; }
        public string public_url { get; set; }
        public object is_women_company { get; set; }
        public string bussiness_objetives { get; set; }
        public object bussiness_description { get; set; }
        public string employees_number { get; set; }
        public Rating rating { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string address_line2 { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string year_established { get; set; }
        public object social_websites { get; set; }
        public string major_customer { get; set; }
        public List<Employee> employees { get; set; }
        public string province_state_department { get; set; }
        public object other_lines_of_business { get; set; }
        public string company_target_countries { get; set; }
        public string company_presence_countries { get; set; }
        public List<Catalog> catalog { get; set; }
        public string country_id { get; set; }
        public string certifications { get; set; }
        public object affiliations { get; set; }
        public List<AttachedFile> attached_files { get; set; }
        public string women_president { get; set; }
        public object women51p { get; set; }
        public object is_orange { get; set; }
        public int is_microbusiness { get; set; }
        public object is_vulnerable { get; set; }
        public object is_victim { get; set; }
        public object victim_code { get; set; }
        public int is_bic { get; set; }
        public object whatsapp { get; set; }
        public object ecommerce { get; set; }
        public string tax_id { get; set; }
        public Embedded _embedded { get; set; }
      
    }
    public class Rating
    {
        public int user_rating { get; set; }
        public int average_rating { get; set; }
        public int votes { get; set; }
    }

    public class Profile
    {
        public string picture { get; set; }
    }

    public class Employee
    {
        public string uid { get; set; }
        public string hierarchy_level { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public Profile profile { get; set; }
    }

    public class ProductsService
    {
        public string id { get; set; }
        public string product_alias_id { get; set; }
        public string product_id { get; set; }
        public string industry_id { get; set; }
        public string product_alias_name { get; set; }
        public string description { get; set; }
        public string display_order { get; set; }
    }

    public class Catalog
    {
        public string industry_id { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public bool main_industry { get; set; }
        public string display_order { get; set; }
        public List<ProductsService> products_services { get; set; }
    }

    public class AttachedFile
    {
        public string title { get; set; }
        public string file { get; set; }
        public string type { get; set; }
        public string thumbnail { get; set; }
    }

    public class Embedded
    {
        public Rating rating { get; set; }
    }
}
