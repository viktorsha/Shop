using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id{ get; set; }
        public string name { get; set; }
        public string shortInfo { get; set; }
        public string longInfo { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool isAvailable { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}
