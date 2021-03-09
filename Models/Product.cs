using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBclotheingEF.Models
{

    public enum Size
    {
        S, M, L, XL, XXL
    }
    public class Product//Table Product Model
    {
        public int ID { get; set; }//PimaryKey
        // [ForeignKey("Brand")]

        public int BrandID { get; set; }//PrimaryKey From Brand Model
        public Brand Brand { get; set; }//Brand Name Conected With Brand Model
        public string name { get; set; }
        public int price { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
     }
}