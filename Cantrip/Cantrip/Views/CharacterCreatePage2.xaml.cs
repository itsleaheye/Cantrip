using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage2 : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        public CharacterCreatePage2(int characterID)
        {
            this.Title = "Abilities";
            InitializeComponent();
            var selectedChar = characterID;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CharacterCreatePage3()); //Navigate to step 2/4 of the character creation process and pass the 'characterID'
        }
    }
}