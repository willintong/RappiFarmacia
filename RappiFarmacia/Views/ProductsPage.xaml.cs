using RappiFarmacia.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RappiFarmacia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
            var lista = new List<Productos>();
            lista.Add(new Productos() { Foto = "login1.png", Nombre = "Hamburguesa", Valor = "12.000" });
            lista.Add(new Productos() { Foto = "login1.png", Nombre = "Perro", Valor = "10.000" });
            lista.Add(new Productos() { Foto = "login1.png", Nombre = "Picada", Valor = "20.000" });
            lista.Add(new Productos() { Foto = "login1.png", Nombre = "Salchipapa", Valor = "25.000" });

            //ObservableCollection<Productos> ListaProductos = new ObservableCollection<Productos>(new ServicioProductPage().ConsultarPersona());
            Listaproductos.ItemsSource = lista;
        }

        private async void Perfil_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PedidosPage());
        }
    }
}