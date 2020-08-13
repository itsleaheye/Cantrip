using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cantrip.Models;
using SQLite;
using System.IO;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCharactersPage : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3"); //Declare database pathing
        public MyCharactersPage()
        {
            this.Title = "My Characters";
            InitializeComponent(); //Load Xaml layout components
            charListView.ItemsSource = null;

            //Connect to local database and populate existing local characters list
            var db = new SQLiteConnection(dbPath); //Connect to local database
            var characterEntry = db.Table<Character>().OrderBy(x => x.Name).ToList(); //Populate the list view element with characters

            //Add error handling if no characters exist
            var characterEntries = characterEntry.Count;
            if (characterEntries > 0)
            {
                charListView.ItemsSource = characterEntry;
            }
            //Test this leah

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CharacterCreatePage()); //Navigate to step 1/4 of the character creation process
        }
    }
}