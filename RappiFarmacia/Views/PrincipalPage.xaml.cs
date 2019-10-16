using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RappiFarmacia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private void Domicilio_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DomicilioPage());
            IsPresented = false;
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PerfilPage());
            IsPresented = false;
        }

    }
}