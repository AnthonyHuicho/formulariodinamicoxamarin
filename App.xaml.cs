using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using form_to_CV;

namespace form_to_CV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Establece la página principal de la aplicación envuelta en una NavigationPage
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Manejar cuando la aplicación arranca
        }

        protected override void OnSleep()
        {
            // Manejar cuando la aplicación entra en modo de suspensión
        }

        protected override void OnResume()
        {
            // Manejar cuando la aplicación se reanuda
        }
    }
}