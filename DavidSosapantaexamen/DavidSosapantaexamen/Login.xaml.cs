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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String usuario = Email.Text;
            String pass = Password.Text;

            if (usuario == "estudiante2021" && pass == "uisrael2021")
            {

                await Navigation.PushAsync(new Registro(usuario, pass));


            }
            else
            {
                await DisplayAlert("Mensaje", "Datos Incorrectos", "OK");

            }

        }
    }
}