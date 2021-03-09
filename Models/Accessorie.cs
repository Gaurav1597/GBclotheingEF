using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBclotheingEF.Models
{
    public class Accessorie//Tabel Accessorie Model
    {
        public int ID { get; set; }//PrimaryKey
        public string name { get; set; }
        public int price { get; set; }
        public string colours { get; set; }
    }
}
