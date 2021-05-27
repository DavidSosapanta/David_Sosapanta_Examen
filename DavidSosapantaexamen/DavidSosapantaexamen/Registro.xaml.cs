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
    public partial class Registro : ContentPage
    {
        public Registro(String usario, String pass)
        {
            InitializeComponent();
            lblUsuario.Text = usario;
            lblclave.Text = pass;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor = (1800 * 0.05);
                double cuota;
                double cuota2;
                double cuota3;
                double valor1 = Convert.ToDouble(txtmonto.Text);
                cuota = (1800 - valor1);
                cuota2 = (cuota / 3);
                cuota3 = cuota2 + valor;
                txtPago.Text = cuota3.ToString();


            }

            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Ok");

            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            String usuario1 = lblUsuario.Text;
            String nombre = txtNombre.Text;
            String pago = txtPago.Text;

            await DisplayAlert("Mensaje", "Elemento Guardado con exito", "OK");
            await Navigation.PushAsync(new Resumen(usuario1, nombre, pago));
        }
    }
}