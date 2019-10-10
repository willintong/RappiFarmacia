using Parcial.Xamarin.Domain;
using RappiFarmacia.helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RappiFarmacia.servicio
{
    public static class ProductoService
    {
  

        public static List<Producto> GetProductos()
        {
            var products = ApiHelper.Get<List<Producto>>("/api_inventario/medicamentos");
            return products;
        }
    }
}
