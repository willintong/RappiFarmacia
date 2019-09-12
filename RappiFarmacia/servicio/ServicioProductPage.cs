using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RappiFarmacia.servicio
{
    public class ServicioProductPage : ContentPage
    {
        public List<Productos> ConsultarProductos()
        {
            //var lista = new List<Productos>();
            //lista.Add(new Productos() { foto = "login1.png", nombre = "Hamburguesa", valor = "12.000" });
            //lista.Add(new Productos() { foto = "login1.png", nombre = "Perro", valor = "10.000" });
            //lista.Add(new Productos() { foto = "login1.png", nombre = "Picada", valor = "20.000" });
            //lista.Add(new Productos() { foto = "login1.png", nombre = "Salchipapa", valor = "25.000" });
            //return lista;
            return null;
        }

        internal IEnumerable<Productos> ConsultarPersona()
        {
            throw new NotImplementedException();
        }
    }
}