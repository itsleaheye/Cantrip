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
        public CharacterCreatePage3(Character _character)
        {
            this.Title = "Skills & Proficiency";
            InitializeComponent();

            //Find character by id that was passed
            /*var db = new SQLiteConnection(dbPath); //Connect to local database 
            var character = db.Table<Character>().Where(c => c.characterID == _selectedCharID).Select(b => b.backgroundID); //Locate character by passed PK
            var background = db.Query<Character>("Select backgroundID from Character where characterID=?",_selectedCharID);
            skillsRemain.Text = background.ToString();*/

            skillsRemain.Text = _character.backgroundID; //Not Pulling BG value
            //Trigger certain checkboxes based on background
            if (_character.backgroundID == "Acolyte")
            {
                insVal.IsChecked = true;
                insVal.IsEnabled = false;
                relVal.IsChecked = true;
                relVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Charlatan")
            {
                decVal.IsChecked = true;
                decVal.IsEnabled = false;
                sleightVal.IsChecked = true;
                sleightVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Criminal")
            {
                decVal.IsChecked = true;
                decVal.IsEnabled = false;
                steVal.IsChecked = true;
                steVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Folk Hero")
            {
                aniVal.IsChecked = true;
                aniVal.IsEnabled = false;
                survVal.IsChecked = true;
                survVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Gladiator")
            {
                acroVal.IsChecked = true;
                acroVal.IsEnabled = false;
                performVal.IsChecked = true;
                performVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Guild Artisan")
            {
                insVal.IsChecked = true;
                insVal.IsEnabled = false;
                persVal.IsChecked = true;
                persVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Hermit")
            {
                medVal.IsChecked = true;
                medVal.IsEnabled = false;
                relVal.IsChecked = true;
                relVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Knight" || _character.backgroundID == "Noble")
            {
                hisVal.IsChecked = true;
                hisVal.IsEnabled = false;
                persVal.IsChecked = true;
                persVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Outlander")
            {
                athVal.IsChecked = true;
                athVal.IsEnabled = false;
                survVal.IsChecked = true;
                survVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Sage")
            {
                arcVal.IsChecked = true;
                arcVal.IsEnabled = false;
                hisVal.IsChecked = true;
                hisVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Sailor")
            {
                athVal.IsChecked = true;
                athVal.IsEnabled = false;
                perceptVal.IsChecked = true;
                perceptVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Soldier")
            {
                athVal.IsChecked = true;
                athVal.IsEnabled = false;
                intVal.IsChecked = true;
                intVal.IsEnabled = false;
            }
            else if (_character.backgroundID == "Urchin")
            {
                sleightVal.IsChecked = true;
                sleightVal.IsEnabled = false;
                steVal.IsChecked = true;
                steVal.IsEnabled = false;
            }
        }
    }
}