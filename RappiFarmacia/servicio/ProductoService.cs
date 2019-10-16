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
            var products = ApiHelper.Get<List<Producto>>("/inventario/medicamentos");
            return products;

        }
        public static List<Login> GetLogins()
            {
            var login = ApiHelper.Get<List<Login>>("/login");
            return login;

        }
        public static List<Register> GetRegisters()
        {
            var register = ApiHelper.Get<List<Register>>("/register");
            return register;

        }
    }
}
