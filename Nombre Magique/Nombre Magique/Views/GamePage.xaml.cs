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
    public partial class GamePage : ContentPage
    {
        const int NB_MAGIQUE_MIN = 1;
        const int NB_MAGIQUE_MAX = 10;
        int nombreMagique = 0;
        public GamePage()
        {
            InitializeComponent();
            nombreMagique = new Random().Next(NB_MAGIQUE_MIN, NB_MAGIQUE_MAX);
            minMaxLabel.Text = "Entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(numberEntry.Text))
            {
                DisplayAlert("Oops", "Vous devez rentrer un nombre", "OK");
                return;
            }
            int nombreUtilisateur = 0;



            try 
            { 
                nombreUtilisateur = Int32.Parse(numberEntry.Text);
            }
            catch (Exception)
            {
                DisplayAlert("Oops", "Vous devez rentrer uniquement des chiffres", "OK");
                return;
            }

            if ((nombreUtilisateur < NB_MAGIQUE_MIN) || (nombreUtilisateur > NB_MAGIQUE_MAX))
            {
                DisplayAlert("Oops", "Vous devez rentrer un nombre entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX, "OK");
                return;
            }

            if ( nombreMagique > nombreUtilisateur)
            {
                DisplayAlert("Oops", "le nombre est supérieur à " + nombreUtilisateur, "OK");
                return;
            }

            if (nombreMagique < nombreUtilisateur)
            {
                DisplayAlert("Oops", "le nombre est inférieur à " + nombreUtilisateur, "OK");
                return;
            }

            if (nombreMagique == nombreUtilisateur)
            {

#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                WinAction();
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                return;
            }
        }

        private async Task WinAction()
        {
           // await DisplayAlert("Gagné", "vous avez trouvé le nombre magique", "OK");
           // await this.Navigation.PopAsync();
           await Navigation.PushAsync(new winPage(nombreMagique));
        }
    }
}