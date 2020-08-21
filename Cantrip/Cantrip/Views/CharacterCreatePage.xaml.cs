using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Cantrip.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        public CharacterCreatePage()
        {
            this.Title = "New Character";
            InitializeComponent();

            //Populate race picker from list
            List<Race> races = new List<Race>();
            races.Add(new Race() { raceID = "Dragonborn", description = "Dragonborn" });
            races.Add(new Race() { raceID = "Dwarf", description = "Dwarf" });
            races.Add(new Race() { raceID = "Elf", description = "Elf" });
            races.Add(new Race() { raceID = "Gnome", description = "Gnome" });
            races.Add(new Race() { raceID = "HalfElf", description = "Half Elf" });
            races.Add(new Race() { raceID = "Halfling", description = "Halfling" });
            races.Add(new Race() { raceID = "HalfOrc", description = "Half Orc" });
            races.Add(new Race() { raceID = "Human", description = "Human" });
            races.Add(new Race() { raceID = "Tiefling", description = "Tiefling" });
            pickerRace.ItemsSource = races;

            //Populate background picker from list
            List<Background> backgrounds = new List<Background>();
            backgrounds.Add(new Background() { backgroundID = "Acolyte" });
            backgrounds.Add(new Background() { backgroundID = "Charlatan" });
            backgrounds.Add(new Background() { backgroundID = "Criminal" });
            backgrounds.Add(new Background() { backgroundID = "Folk Hero" });
            backgrounds.Add(new Background() { backgroundID = "Gladiator" });
            backgrounds.Add(new Background() { backgroundID = "Guild Artisan" });
            backgrounds.Add(new Background() { backgroundID = "Hermit" });
            backgrounds.Add(new Background() { backgroundID = "Knight" });
            backgrounds.Add(new Background() { backgroundID = "Noble" });
            backgrounds.Add(new Background() { backgroundID = "Outlander" });
            backgrounds.Add(new Background() { backgroundID = "Pirate" });
            backgrounds.Add(new Background() { backgroundID = "Sage" });
            backgrounds.Add(new Background() { backgroundID = "Sailor" });
            backgrounds.Add(new Background() { backgroundID = "Soldier" });
            backgrounds.Add(new Background() { backgroundID = "Urchin" });
            pickerBackground.ItemsSource = backgrounds;

            //Populate class objects
            List<Class> classes = new List<Class>();
            classes.Add(new Class() { classID = "Barbarian", description = "A ferocious warrior who can enter a primitive battle rage.", classIconSource = "classBarbarianLogo.png" });
            classes.Add(new Class() { classID = "Bard", description = "A talented musician that weaves magic into their words.", classIconSource = "classBardLogo.png" });
            classes.Add(new Class() { classID = "Cleric", description = "A priest like champion that wields divine magic.", classIconSource = "classClericLogo.png" });
            classes.Add(new Class() { classID = "Druid", description = "A wielder of nature-themed magics.", classIconSource = "classDruidLogo.png" });
            classes.Add(new Class() { classID = "Fighter", description = "A versatile warrior utilizing weapons, strategy and tactics.", classIconSource = "ClassFighter2Logo.png" });
            classes.Add(new Class() { classID = "Monk", description = "A mystic and master of the martial arts.", classIconSource = "ClassMonkLogo.png" });
            classes.Add(new Class() { classID = "Paladin", description = "A holy warrior that can cast divine magic.", classIconSource = "ClassPaladinLogo.png" });
            classes.Add(new Class() { classID = "Ranger", description = "A protecter uses nature magic and weapons in combat.", classIconSource = "ClassRangerLogo.png" });
            classes.Add(new Class() { classID = "Rogue", description = "A stealthy and dexterous character that uses trickery.", classIconSource = "ClassRogueLogo.png" });
            classes.Add(new Class() { classID = "Sorcerer", description = "A spellcaster who inherited their magic as a gift.", classIconSource = "ClassSorcererLogo.png" });
            classes.Add(new Class() { classID = "Warlock", description = "A spellcaster who bargained with an extraplanar entity.", classIconSource = "ClassWarlockLogo.png" });
            classes.Add(new Class() { classID = "Wizard", description = "A scholarly spellcaster who can manipulate reality.", classIconSource = "ClassWizardLogo.png" });
            cardClass.ItemsSource = classes;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Ensure fields have been filled
            if (pickerRace.SelectedItem == null || pickerBackground.SelectedItem == null || entryName.Text == "")
            {
                await DisplayAlert("Incomplete", "Please ensure all fields have been filled", "OK");
            }
            else
            {
                var db = new SQLiteConnection(dbPath); //Connect to local database  
                db.CreateTable<Character>(); //Create new instance of a character
                var maxPK = db.Table<Character>().OrderByDescending(c => c.characterID).FirstOrDefault();

                var selectedRace = pickerRace.SelectedItem;
                var selectedClass = cardClass.CurrentItem;
                var selectedBg = pickerBackground.SelectedItem;

                Character character = new Character()
                {
                    characterID = (maxPK == null ? 1 : maxPK.characterID + 1),
                    Name = entryName.Text,
                    raceID = selectedRace.ToString(),
                    classID = selectedClass.ToString(),
                    backgroundID = selectedBg.ToString(),
                    TotalLevel = "1" //Characters start at lvl 1
                };

                db.Insert(character); //Insert new character table into the db
                await Navigation.PushAsync(new CharacterCreatePage2(character.characterID)); //Navigate to step 2/4 of the character creation process and pass the 'characterID'
            }

        }
    }
}