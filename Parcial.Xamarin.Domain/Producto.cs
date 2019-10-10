using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Xamarin.Domain
{
    public class Producto
    {
        public string code { get; set; }
        public string name { get; set; }
        public int salePrice { get; set; }
        public int purchasePrice { get; set; }
        public string image { get; set; }
        public int stock { get; set; }
       
    }
}
