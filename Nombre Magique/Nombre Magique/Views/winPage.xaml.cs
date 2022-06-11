using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nombre_Magique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class winPage : ContentPage
    {
        public winPage(int nombreMagique)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            mainLayout.Scale = 0.7;
            mainLayout.ScaleTo(1.0, 1500, Easing.BounceIn);

            magicNumberLabel.Text = "Le nombre magique était: " + nombreMagique;

            NavigateBackToWelcomPage();
        }

        private async Task NavigateBackToWelcomPage()
        {
            // on paramétre le delai d'affichage de la page avant de retourner sur la page d'accueil
            await Task.Delay(3000);
            await Navigation.PopToRootAsync();
        }
    }
}