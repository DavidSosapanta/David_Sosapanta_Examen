using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DavidSosapantaexamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario1, String nombre2, String pago2)
        {
            InitializeComponent();
            lblUsuario1.Text = usuario1;
            lblnombre.Text = nombre2;
            lblpagar.Text = pago2;
        }
    }
}