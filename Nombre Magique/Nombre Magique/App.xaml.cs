using Nombre_Magique.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nombre_Magique
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new homePage());
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
