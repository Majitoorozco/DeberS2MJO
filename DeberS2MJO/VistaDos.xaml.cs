using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberS2MJO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaDos : ContentPage
    {
        public VistaDos()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            //validacion de la contrasena 
           
            if (user == "estudiante2021" && pass == "uisrael2021")
            {
                await Navigation.PushAsync(new MainPage(user));
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "OK");
            }

           

            //2.1 direcciona la paguina que abrira "MaiPage" 
            //await Navigation.PushAsync(new MainPage(user, pass));
        }
    }
}