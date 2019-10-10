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
    public partial class DomicilioPage : ContentPage
    {
        public DomicilioPage()
        {
            InitializeComponent();
            lsvProductos.ItemsSource = ProductoService.GetProductos();
        }

        private async void Perfil_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PedidosPage());
        }
    }
}