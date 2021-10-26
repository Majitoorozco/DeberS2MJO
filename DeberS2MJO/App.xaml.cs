using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberS2MJO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Navegacion entre ventanas

            MainPage = new NavigationPage(new VistaDos ());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
