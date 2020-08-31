using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions;
using SQLitePCL;
using Cantrip.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Cantrip.ViewModels;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterPage : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        string charImgPath;
        public CharacterPage(Character _character)
        {
            this.Title = "Character";
            InitializeComponent();

            string charClass = _character.classID;
            //Add error handling for future custom images, otherwise assign icon to matching class icon
            if (charClass == "Bard")
            {
                charImgPath = "classBarbarianLogo.png";
            }
            else if (charClass == "Barbarian")
            {
                charImgPath = "classBardLogo.png";
            }
            else if (charClass == "Cleric")
            {
                charImgPath = "classClericLogo.png";
            }
            else if (charClass == "Druid")
            {
                charImgPath = "classDruidLogo.png";
            }
            else if (charClass == "Fighter")
            {
                charImgPath = "ClassFighter2Logo.png";
            }
            else if (charClass == "Monk")
            {
                charImgPath = "ClassMonkLogo.png";
            }
            else if (charClass == "Paladin")
            {
                charImgPath = "ClassPaladinLogo.png";
            }
            else if (charClass == "Ranger")
            {
                charImgPath = "ClassRangerLogo.png";
            }
            else if (charClass == "Rogue")
            {
                charImgPath = "ClassMonkLogo.png";
            }
            else if (charClass == "Sorcerer")
            {
                charImgPath = "ClassSorcererLogo.png";
            }
            else if (charClass == "Warlock")
            {
                charImgPath = "ClassWarlockLogo.png";
            }
            else if (charClass == "Wizard")
            {
                charImgPath = "ClassWizardLogo.png";
            }
            charImg.Source = "" + charImgPath + "";

            charNameLabel.Text = _character.Name;
            charRaceLabel.Text = _character.raceID;
            charClassLabel.Text = _character.classID;
            charBGLabel.Text = _character.backgroundID;


            /*var db = new SQLiteConnection(dbPath); //Connect to local database 
            var _characterName = db.Table<Character>().Where(c => c.characterID == _selectedCharID).Select(b => b.Name); //Locate character name
            var _characterRace = db.Table<Character>().Where(c => c.characterID == _selectedCharID).Select(b => b.raceID); //Locate character name
            var _characterClass = db.Table<Character>().Where(c => c.characterID == _selectedCharID).Select(b => b.classID); //Locate character name
            var _classID = db.Table<Character>().Where(c => c.characterID == _selectedCharID).Select(i => i.classID); //Locate class by passed FK 'classID'
            var characterImage = db.Table<Class>().Where(c => c.classID == _classID.ToString()).Select(i => i.classIconSource); //Locate class image source by PK 'classID'*/
        }
        private async void LoadCombatView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CombatViewPage()); //Navigate to combat view page
        }
        private async void LoadInventoryView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InventoryViewPage()); //Navigate to combat view page
        }
    }
}