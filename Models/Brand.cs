using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBclotheingEF.Models
{
    public class Brand//Table Brand model
    {
        public int ID { get; set; }//PrimaryKey 

        public string Name { get; set; }
        public ICollection<Product> products { get; set; }//Navigation which connect with Product Model


    }
}