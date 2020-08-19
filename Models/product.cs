using System.Data;
//using System.Data.Entity;
namespace Mercury.models{

    public class product{
     public int p_id{get; set;}
     
        public string p_price {get; set;}
        public string p_quantity {get; set;}
        public string p_description {get; set;}
        public string p_image  {get; set;}
        public string created_at {get; set;}
        public string updated_at {get; set;}

    }
}