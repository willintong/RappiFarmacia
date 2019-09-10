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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Registrarse_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DomicilioPage());
        }

        private async void Inicio_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}