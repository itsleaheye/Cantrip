using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;
using SQLiteNetExtensions;
using System.IO;
using Cantrip.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage3 : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        int _selectedCharID;
        public CharacterCreatePage3(int selectedCharID)
        {
            this.Title = "Skills & Proficiency";
            InitializeComponent();
            _selectedCharID = selectedCharID;

            //Find character by id that was passed
            var db = new SQLiteConnection(dbPath); //Connect to local database 
            var character = db.Table<Character>().Where(c => c.characterID == _selectedCharID); //Locate character by passed PK
            var background = db.Query<Character>("Select backgroundID from Character where characterID=?",_selectedCharID);

            //Trigger certain checkboxes based on background
            if (background.ToString() == "Acolyte")
            {
                insVal.IsChecked = true;
                insVal.IsEnabled = false;
                relVal.IsChecked = true;
                relVal.IsEnabled = false;
            }
            else if (background.ToString() == "Charlatan")
            {
                decVal.IsChecked = true;
                decVal.IsEnabled = false;
                sleightVal.IsChecked = true;
                sleightVal.IsEnabled = false;
            }
            else if (background.ToString() == "Criminal")
            {
                decVal.IsChecked = true;
                decVal.IsEnabled = false;
                steVal.IsChecked = true;
                steVal.IsEnabled = false;
            }
            else if (background.ToString() == "Folk Hero")
            {
                aniVal.IsChecked = true;
                aniVal.IsEnabled = false;
                survVal.IsChecked = true;
                survVal.IsEnabled = false;
            }
            else if (background.ToString() == "Gladiator")
            {
                acroVal.IsChecked = true;
                acroVal.IsEnabled = false;
                performVal.IsChecked = true;
                performVal.IsEnabled = false;
            }
            else if (background.ToString() == "Guild Artisan")
            {
                insVal.IsChecked = true;
                insVal.IsEnabled = false;
                persVal.IsChecked = true;
                persVal.IsEnabled = false;
            }
            else if (background.ToString() == "Hermit")
            {
                medVal.IsChecked = true;
                medVal.IsEnabled = false;
                relVal.IsChecked = true;
                relVal.IsEnabled = false;
            }
            else if (background.ToString() == "Hermit")
            {
                medVal.IsChecked = true;
                medVal.IsEnabled = false;
                relVal.IsChecked = true;
                relVal.IsEnabled = false;
            }
            else if (background.ToString() == "Knight" || background.ToString() == "Noble")
            {
                hisVal.IsChecked = true;
                hisVal.IsEnabled = false;
                persVal.IsChecked = true;
                persVal.IsEnabled = false;
            }
            else if (background.ToString() == "Outlander")
            {
                athVal.IsChecked = true;
                athVal.IsEnabled = false;
                survVal.IsChecked = true;
                survVal.IsEnabled = false;
            }
            else if (background.ToString() == "Sage")
            {
                arcVal.IsChecked = true;
                arcVal.IsEnabled = false;
                hisVal.IsChecked = true;
                hisVal.IsEnabled = false;
            }
            else if (background.ToString() == "Sailor")
            {
                athVal.IsChecked = true;
                athVal.IsEnabled = false;
                perceptVal.IsChecked = true;
                perceptVal.IsEnabled = false;
            }
            else if (background.ToString() == "Soldier")
            {
                athVal.IsChecked = true;
                athVal.IsEnabled = false;
                intVal.IsChecked = true;
                intVal.IsEnabled = false;
            }
            else if (background.ToString() == "Urchin")
            {
                sleightVal.IsChecked = true;
                sleightVal.IsEnabled = false;
                steVal.IsChecked = true;
                steVal.IsEnabled = false;
            }
        }
    }
}