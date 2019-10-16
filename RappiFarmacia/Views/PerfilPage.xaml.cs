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
    public partial class PerfilPage
    {
        public PerfilPage()
        {
            InitializeComponent();
        }

        private async void Ingresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }

        private async void ResumenProducto_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DomicilioPage());

        }

        private async void ProductoOne_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }

        private async void ProductoTwo_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }

        private async void ProductoThre_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }
    }
}