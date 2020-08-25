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
using Cantrip.ViewModels;

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
                charListView.ItemTapped += OnItemSelected;
                /*Load corresponding Image
                var _classID = db.Table<Character>().Where(c => c.characterID == charListView.SelectedItem.characterID).Select(i => i.classID); //Locate class by passed FK 'classID'
                var characterImage = db.Table<Class>().Where(c => c.classID == _classID.ToString()).Select(i => i.classIconSource); //Locate class image source by PK 'classID'*/
            }
            //Test this leah
        }
        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            Character _character = (Character)e.Item;
            Navigation.PushAsync(new CharacterPage(_character)); //Navigate to character details with selected Character
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CharacterCreatePage()); //Navigate to step 1/4 of the character creation process
            
            //Refresh list 
            charListView.ItemsSource = null;
            var db = new SQLiteConnection(dbPath); //Connect to database
            var characterEntry = db.Table<Character>().OrderBy(x => x.Name).ToList(); //Populate the list view element with characters

            //Add error handling if no characters exist
            var characterEntries = characterEntry.Count;
            if (characterEntries > 0)
            {
                charListView.ItemsSource = characterEntry;
            }
            else //Test this 
            {
                charListView.IsVisible = false;
                emptyList.IsVisible = true;
            }
        }

    }
}