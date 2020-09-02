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
using Cantrip.ViewModels;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage3 : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        string _charName, _charClass, _charBg, _charRace, _charLvl, _charVal, _conVal, _dexVal, _intVal, _strVal, _wisVal;
        int pointPool;
        public CharacterCreatePage3(string charName, string charRace, string charClass, string charBg, string charLvl, string charVal, string conVal, string dexVal, string intVal, string strVal, string wisVal)
        {
            this.Title = "Skills & Proficiency";
            InitializeComponent();
            _charName = charName;
            _charClass = charClass;
            _charBg = charBg;
            _charRace = charRace;
            _charLvl = charLvl;
            _charVal = charVal;
            _conVal = conVal;
            _dexVal = dexVal;
            _intVal = intVal;
            _strVal = strVal;
            _wisVal = wisVal;
            pointPool = 0;

            //In the future could possibly bind .IsVisible in XAMl to class value

            //Trigger certain visibilities based on class
            if (_charClass == "Bard")
            {
                pointPool = 3;

                acroFrame.IsVisible = true;
                aniFrame.IsVisible = true;
                arcFrame.IsVisible = true;
                athFrame.IsVisible = true;
                decFrame.IsVisible = true;
                hisFrame.IsVisible = true;
                insFrame.IsVisible = true;
                intimFrame.IsVisible = true;
                medFrame.IsVisible = true;
                natFrame.IsVisible = true;
                perceptFrame.IsVisible = true;
                performFrame.IsVisible = true;
                persFrame.IsVisible = true;
                relFrame.IsVisible = true;
                sleightFrame.IsVisible = true;
                steFrame.IsVisible = true;
                survFrame.IsVisible = true;
            }
            else if (_charClass == "Barbarian")
            {
                pointPool = 2;

                aniFrame.IsVisible = true;
                athFrame.IsVisible = true;
                intimFrame.IsVisible = true;
                natFrame.IsVisible = true;
                perceptFrame.IsVisible = true;
                survFrame.IsVisible = true;
            }
            else if (charClass == "Cleric")
            {
                pointPool = 2;

                hisFrame.IsVisible = true;
                insFrame.IsVisible = true;
                medFrame.IsVisible = true;
                persFrame.IsVisible = true;
                relFrame.IsVisible = true;
            }
            else if (charClass == "Druid")
            {
                pointPool = 2;

                arcFrame.IsVisible = true;
                aniFrame.IsVisible = true;
                insFrame.IsVisible = true;
                medFrame.IsVisible = true;
                natFrame.IsVisible = true;
                perceptFrame.IsVisible = true;
                relFrame.IsVisible = true;
                survFrame.IsVisible = true;
            }
            else if (charClass == "Fighter")
            {
                pointPool = 2;

                acroFrame.IsVisible = true;
                aniFrame.IsVisible = true;
                athFrame.IsVisible = true;
                insFrame.IsVisible = true;
                intimFrame.IsVisible = true;
                perceptFrame.IsVisible = true;
                survFrame.IsVisible = true;
            }
            else if (charClass == "Monk")
            {
                pointPool = 2;

                acroFrame.IsVisible = true;
                athFrame.IsVisible = true;
                hisFrame.IsVisible = true;
                insFrame.IsVisible = true;
                relFrame.IsVisible = true;
                steFrame.IsVisible = true;
            }
            else if (charClass == "Paladin")
            {
                pointPool = 2;

                athFrame.IsVisible = true;
                insFrame.IsVisible = true;
                intimFrame.IsVisible = true;
                persFrame.IsVisible = true;
                relFrame.IsVisible = true;    
            }
            else if (charClass == "Ranger")
            {
                pointPool = 3;

                aniFrame.IsVisible = true;
                athFrame.IsVisible = true;
                insFrame.IsVisible = true;
                invFrame.IsVisible = true;
                perceptFrame.IsVisible = true;
                steFrame.IsVisible = true;
                survFrame.IsVisible = true;
            }
            else if (charClass == "Rogue")
            {
                pointPool = 4;

                acroFrame.IsVisible = true;
                athFrame.IsVisible = true;
                insFrame.IsVisible = true;
                invFrame.IsVisible = true;
                perceptFrame.IsVisible = true;
                performFrame.IsVisible = true;
                persFrame.IsVisible = true;
                sleightFrame.IsVisible = true;
                steFrame.IsVisible = true;
            }
            else if (charClass == "Sorcerer")
            {
                pointPool = 2;

                arcFrame.IsVisible = true;
                decFrame.IsVisible = true;
                insFrame.IsVisible = true;
                intimFrame.IsVisible = true;
                persFrame.IsVisible = true;
                relFrame.IsVisible = true;
            }
            else if (charClass == "Warlock")
            {
                pointPool = 2;

                arcFrame.IsVisible = true;
                decFrame.IsVisible = true;
                hisFrame.IsVisible = true;
                intimFrame.IsVisible = true;
                invFrame.IsVisible = true;
                natFrame.IsVisible = true;
                relFrame.IsVisible = true;
            }
            else if (charClass == "Wizard")
            {
                pointPool = 2;

                arcFrame.IsVisible = true;
                hisFrame.IsVisible = true;
                insFrame.IsVisible = true;
                invFrame.IsVisible = true;
                medFrame.IsVisible = true;
                relFrame.IsVisible = true;
            } 
            skillsRemain.Text = pointPool.ToString();
             
            //Character Backgrounds influence character proficiency
            if (_charBg == "Acolyte")
                {
                    insVal.IsChecked = true;
                    insVal.IsEnabled = false;
                    insFrame.IsVisible = true;

                    relVal.IsChecked = true;
                    relVal.IsEnabled = false;
                    relFrame.IsVisible = true;
                }
                else if (_charBg == "Charlatan")
                {
                    decVal.IsChecked = true;
                    decFrame.IsVisible = true;
                    decVal.IsEnabled = false;

                    sleightVal.IsChecked = true;
                    sleightFrame.IsVisible = true;
                    sleightVal.IsEnabled = false;
                }
                else if (_charBg == "Criminal")
                {
                    decVal.IsChecked = true;
                    decFrame.IsVisible = true;
                    decVal.IsEnabled = false;

                    steVal.IsChecked = true;
                    steFrame.IsVisible = true;
                    steVal.IsEnabled = false;
                }
                else if (_charBg == "Folk Hero")
                {
                    aniVal.IsChecked = true;
                    aniFrame.IsVisible = true;
                    aniVal.IsEnabled = false;

                    survVal.IsChecked = true;
                    survFrame.IsVisible = true;
                    survVal.IsEnabled = false;
                }
                else if (_charBg == "Gladiator")
                {
                    acroVal.IsChecked = true;
                    acroFrame.IsVisible = true;
                    acroVal.IsEnabled = false;

                    performVal.IsChecked = true;
                    performFrame.IsVisible = true;
                    performVal.IsEnabled = false;
                }
                else if (_charBg == "Guild Artisan")
                {
                    insVal.IsChecked = true;
                    insFrame.IsVisible = true;
                    insVal.IsEnabled = false;

                    persVal.IsChecked = true;
                    persFrame.IsVisible = true;
                    persVal.IsEnabled = false;
                }
                else if (_charBg == "Hermit")
                {
                    medVal.IsChecked = true;
                    medFrame.IsVisible = true;
                    medVal.IsEnabled = false;

                    relVal.IsChecked = true;
                    relFrame.IsVisible = true;
                    relVal.IsEnabled = false;
                }
                else if (_charBg == "Knight" || _charBg == "Noble")
                {
                    hisVal.IsChecked = true;
                    hisFrame.IsVisible = true;
                    hisVal.IsEnabled = false;

                    persVal.IsChecked = true;
                    persFrame.IsVisible = true;
                    persVal.IsEnabled = false;
                }
                else if (_charBg == "Outlander")
                {
                    athVal.IsChecked = true;
                    athFrame.IsVisible = true;
                    athVal.IsEnabled = false;

                    survVal.IsChecked = true;
                    survFrame.IsVisible = true;
                    survVal.IsEnabled = false;
                }
                else if (_charBg == "Sage")
                {
                    arcVal.IsChecked = true;
                    arcFrame.IsVisible = true;
                    arcVal.IsEnabled = false;

                    hisVal.IsChecked = true;
                    hisFrame.IsVisible = true;
                    hisVal.IsEnabled = false;
                }
                else if (_charBg == "Sailor")
                {
                    athVal.IsChecked = true;
                    athFrame.IsVisible = true;
                    athVal.IsEnabled = false;

                    perceptVal.IsChecked = true;
                    perceptFrame.IsVisible = true;
                    perceptVal.IsEnabled = false;
                }
                else if (_charBg == "Soldier")
                {
                    athVal.IsChecked = true;
                    athFrame.IsVisible = true;
                    athVal.IsEnabled = false;

                    intimVal.IsChecked = true;
                    intimFrame.IsVisible = true;
                    intimVal.IsEnabled = false;
                }
                else if (_charBg == "Urchin")
                {
                    sleightVal.IsChecked = true;
                    sleightFrame.IsVisible = true;
                    sleightVal.IsEnabled = false;

                    steVal.IsChecked = true;
                    steFrame.IsVisible = true;
                    steVal.IsEnabled = false;
                }
            }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CharacterCreatePage3(_charName, _charRace, _charClass, _charBg, _charLvl, _charVal, _conVal, _dexVal, _intVal, _strVal, _wisVal)); //Navigate to step 4/4 of the character creation process
        }
    }
}