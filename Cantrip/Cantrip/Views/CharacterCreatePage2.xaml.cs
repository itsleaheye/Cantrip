using System;
using System.Collections.Generic;
using System.IO;
using Cantrip.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage2 : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        int selectedCharID;
        public CharacterCreatePage2(int characterID)
        {
            this.Title = "Abilities";
            InitializeComponent();
            selectedCharID = characterID;
        }
        private void BtnIncrease_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var btnName = btn.ClassId;

            if (btnName == "BtnCharInc")
            {
                string value = charVal.Text.ToString();
                int charValue = int.Parse(value);
                charVal.Text = charValue += 1
            }
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(dbPath); //Connect to local database 
            Character character = new Character()
            {
                characterID = selectedCharID,
                skillChar = entryName.Text,
                skillCon = selectedRace.ToString(),
                skillDex = selectedClass.ToString(),
                skillInt = selectedBg.ToString(),
                skillStr = "1",
                skillWis = 
            };
            db.Update(character);
            await Navigation.PushAsync(new CharacterCreatePage3()); //Navigate to step 2/4 of the character creation process and pass the 'characterID' parameter
        }
    }
}