using RappiFarmacia.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RappiFarmacia
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }

        private void Domicilio_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DomicilioPage());
            IsPresented = false;
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PedidosPage());
            IsPresented = false;
        }
    }
}
