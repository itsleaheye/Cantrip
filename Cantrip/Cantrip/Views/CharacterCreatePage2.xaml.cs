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
using Cantrip.ViewModels;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage2 : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        string _charName, _charRace, _charClass, _charBg, _charLvl;
        int _charID;
        public CharacterCreatePage2(int characterID, string charName, string charRace, string charClass, string charBg, string charLvl)
        {
            this.Title = "Abilities";
            InitializeComponent();
            _charID = characterID;
            _charName = charName;
            _charClass = charClass;
            _charRace = charRace;
            _charBg = charBg;
            _charLvl = charLvl;
        }
        private void BtnIncreased_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var btnName = btn.ClassId;
            int remainingPoints = int.Parse(pointsRemain.Text.ToString());
            if (remainingPoints >= 1)
            {
                //Charisma Increase
                if (btnName == "BtnCharInc")
                {
                    int currentCharValue = int.Parse(charVal.Text.ToString());
                    if (currentCharValue <= 12 && currentCharValue <= 14) //if Charisma Value is below 12 and below the cap of 15 let the user increase the number
                    {
                        currentCharValue++;
                        charVal.Text = currentCharValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentCharValue >= 13 && currentCharValue <= 14) //Skills cost 2 points after level 13
                    {
                        currentCharValue++;
                        charVal.Text = currentCharValue.ToString();
                        remainingPoints= remainingPoints-2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Constitution Increase
                else if (btnName == "BtnConInc")
                {
                    int currentConValue = int.Parse(conVal.Text.ToString());
                    if (currentConValue <= 12 && currentConValue <= 14) //if Constitution Value is below the cap of '15', let the user increase the number
                    {
                        currentConValue++;
                        conVal.Text = currentConValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentConValue >= 13 && currentConValue <= 14) //Skills cost 2 points after level 13
                    {
                        currentConValue++;
                        conVal.Text = currentConValue.ToString();
                        remainingPoints = remainingPoints - 2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Increase
                else if (btnName == "BtnDexInc")
                {
                    int currentDexValue = int.Parse(dexVal.Text.ToString());
                    if (currentDexValue <= 12 && currentDexValue <= 14) //if Dexterity Value is below the cap of '15', let the user increase the number
                    {
                        currentDexValue++;
                        dexVal.Text = currentDexValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentDexValue >= 13 && currentDexValue <= 14) //Skills cost 2 points after level 13
                    {
                        currentDexValue++;
                        dexVal.Text = currentDexValue.ToString();
                        remainingPoints = remainingPoints - 2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Intelligence Increase
                else if (btnName == "BtnIntInc")
                {
                    int currentIntValue = int.Parse(intVal.Text.ToString());
                    if (currentIntValue >= 12 && currentIntValue <= 14) //if Intelligence Value is below the cap of '15', let the user increase the number
                    {
                        currentIntValue++;
                        intVal.Text = currentIntValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentIntValue >= 13 && currentIntValue <= 14) //Skills cost 2 points after level 13
                    {
                        currentIntValue++;
                        intVal.Text = currentIntValue.ToString();
                        remainingPoints = remainingPoints - 2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Increase
                else if (btnName == "BtnStrInc")
                {
                    int currentStrValue = int.Parse(strVal.Text.ToString());
                    if (currentStrValue >= 12 && currentStrValue <= 14) //if Strength Value is below the cap of '15', let the user increase the number
                    {
                        currentStrValue++;
                        strVal.Text = currentStrValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentStrValue >= 13 && currentStrValue <= 14) //Skills cost 2 points after level 13
                    {
                        currentStrValue++;
                        strVal.Text = currentStrValue.ToString();
                        remainingPoints = remainingPoints - 2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Wisdom Increase
                else if (btnName == "BtnWisInc")
                {
                    int currentWisValue = int.Parse(wisVal.Text.ToString());
                    if (currentWisValue >= 12 && currentWisValue <= 14) //if Dexterity Value is below the cap of '15', let the user increase the number
                    {
                        currentWisValue++;
                        wisVal.Text = currentWisValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentWisValue >= 13 && currentWisValue <= 14) //Skills cost 2 points after level 13
                    {
                        currentWisValue++;
                        wisVal.Text = currentWisValue.ToString();
                        remainingPoints = remainingPoints - 2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
            }
        }
        //Points Remaining Banner not Decreasing
        private void BtnDecreased_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var btnName = btn.ClassId;
            int remainingPoints = int.Parse(pointsRemain.Text.ToString());
                //Charisma Increase
                if (btnName == "BtnCharDec")
                {
                    int currentCharValue = int.Parse(charVal.Text.ToString());
                    if (currentCharValue >= 9 && currentCharValue <= 12) //if Charisma Value is above the min of '8', let the user decrease the number
                    {
                        currentCharValue--;
                        charVal.Text = currentCharValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentCharValue >= 13) //Skills cost 2 points after level 13
                    {
                        currentCharValue--;
                        charVal.Text = currentCharValue.ToString();
                        remainingPoints = remainingPoints + 2;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Constitution Decrease
                else if (btnName == "BtnConDec")
                {
                    int currentConValue = int.Parse(conVal.Text.ToString());
                    if (currentConValue >= 9 && currentConValue <= 12) //if Constitution Value is above the min of '8', let the user decrease the number
                {
                        currentConValue--;
                        conVal.Text = currentConValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentConValue >= 13) //Skills cost 2 points after level 13
                    {
                    currentConValue--;
                    conVal.Text = currentConValue.ToString();
                    remainingPoints = remainingPoints + 2;
                    pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Decrease
                else if (btnName == "BtnDexDec")
                {
                    int currentDexValue = int.Parse(dexVal.Text.ToString());
                    if (currentDexValue >= 9 && currentDexValue <= 12) //if Dexterity Value is above the min of '8', let the user decrease the number
                    {
                        currentDexValue--;
                        dexVal.Text = currentDexValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                    else if (currentDexValue >= 13) //Skills cost 2 points after level 13
                    {
                        currentDexValue--;
                        dexVal.Text = currentDexValue.ToString();
                    remainingPoints = remainingPoints + 2;
                    pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Intelligence Decrease
                else if (btnName == "BtnIntDec")
                {
                    int currentIntValue = int.Parse(intVal.Text.ToString());
                    if (currentIntValue >= 9 && currentIntValue <= 12) //if Intelligence Value is above the min of '8', let the user decrease the number
                {
                        currentIntValue--;
                        intVal.Text = currentIntValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                }
                else if (currentIntValue >= 13) //Skills cost 2 points after level 13
                {
                    currentIntValue--;
                    intVal.Text = currentIntValue.ToString();
                    remainingPoints = remainingPoints + 2;
                    pointsRemain.Text = remainingPoints.ToString();
                }
            }
                //Dexterity Decrease
                else if (btnName == "BtnStrDec")
                {
                    int currentStrValue = int.Parse(strVal.Text.ToString());
                    if (currentStrValue >= 9 && currentStrValue <= 12) //if Strength Value is above the min of '8', let the user decrease the number
                    {
                        currentStrValue--;
                        strVal.Text = currentStrValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }

                else if (currentStrValue >= 13) //Skills cost 2 points after level 13
                {
                    currentStrValue--;
                    strVal.Text = currentStrValue.ToString();
                    remainingPoints = remainingPoints + 2;
                    pointsRemain.Text = remainingPoints.ToString();
                }
            }
                //Wisdom Decrease
                else if (btnName == "BtnWisDec")
                {
                    int currentWisValue = int.Parse(wisVal.Text.ToString());
                    if (currentWisValue >= 9 && currentWisValue <= 12) //if Dexterity Value is above the min of '8', let the user decrease the number
                    {
                        currentWisValue--;
                        wisVal.Text = currentWisValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }

                else if (currentWisValue >= 13) //Skills cost 2 points after level 13
                {
                    currentWisValue--;
                    wisVal.Text = currentWisValue.ToString();
                    remainingPoints = remainingPoints + 2;
                    pointsRemain.Text = remainingPoints.ToString();
                }
            }        
        }
        private void BtnBuy_Clicked(object sender, EventArgs e)
        {
            pointsRemain.Text = "27"; //Set title text - If user wants to buy points, set the value to pool of remaining points to 27
            pointsText.Text = "Points Remaining"; //Caption Text
            //Reset values to default
            charVal.Text = "8";
            conVal.Text = "8";
            dexVal.Text = "8";
            intVal.Text = "8";
            strVal.Text = "8";
            wisVal.Text = "8";

            //Create event to trigger visibility=visible of increase and decrease buttons
            charInc.IsVisible = true;
            conInc.IsVisible = true;
            dexInc.IsVisible = true;
            intInc.IsVisible = true;
            strInc.IsVisible = true;
            wisInc.IsVisible = true;

            charDec.IsVisible = true;
            conDec.IsVisible = true;
            dexDec.IsVisible = true;
            intDec.IsVisible = true;
            strDec.IsVisible = true;
            wisDec.IsVisible = true;
        }
        private void BtnRoll_Clicked(object sender, EventArgs e)
        {
            pointsRemain.Text = "3d6"; //Set title text
            pointsText.Text = "Rolling Points"; //Caption Text
            //Create event to trigger visibility=off of increase and decrease buttons
            charInc.IsVisible = false;
            conInc.IsVisible = false;
            dexInc.IsVisible = false;
            intInc.IsVisible = false;
            strInc.IsVisible = false;
            wisInc.IsVisible = false;

            charDec.IsVisible = false;
            conDec.IsVisible = false;
            dexDec.IsVisible = false;
            intDec.IsVisible = false;
            strDec.IsVisible = false;
            wisDec.IsVisible = false;

            Random r = new Random();
            int diceRolled = 6;//1d6 rolled
            int charRolls = 0, conRolls = 0, dexRolls = 0, intRolls = 0, strRolls = 0, wisRolls = 0; //Rolls per stat. User rolls 3 times and adds them together
            int charValue = 0, conValue = 0, dexValue = 0, intValue = 0, strValue = 0, wisValue = 0;
            while (charRolls < 3)
            {
                int rdmInt = r.Next(1, diceRolled);
                charRolls++;
                charValue = charValue + rdmInt;
            }
            while (conRolls < 3)
            {
                int rdmInt = r.Next(1, diceRolled);
                conValue = conValue + rdmInt;
                conRolls++;
            }
            while (dexRolls < 3)
            {
                int rdmInt = r.Next(1, diceRolled);
                dexValue = dexValue + rdmInt;
                dexRolls++;

            }
            while (intRolls < 3)
            {
                int rdmInt = r.Next(1, diceRolled);
                intValue = intValue + rdmInt;
                intRolls++;
            }
            while (strRolls < 3)
            {
                int rdmInt = r.Next(1, diceRolled);
                strValue += rdmInt;
                strRolls++;
            }
            while (wisRolls < 3)
            {
                int rdmInt = r.Next(1, diceRolled);     
                wisValue = wisValue + rdmInt;
                wisRolls++;
            }
            charVal.Text = charValue.ToString();
            conVal.Text = conValue.ToString();
            dexVal.Text = dexValue.ToString();
            intVal.Text = intValue.ToString();
            strVal.Text = strValue.ToString();
            wisVal.Text = wisValue.ToString();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(dbPath); //Connect to local database 
            Character character = new Character() //This is deleting the chars values for some reason
            {
                //Passed values
                characterID = _charID,
                Name = _charName,
                classID = _charClass,
                raceID = _charRace,
                backgroundID = _charBg,
                TotalLevel = _charLvl,

                //New values
                skillChar = int.Parse(charVal.Text.ToString()),
                skillCon = int.Parse(conVal.Text.ToString()),
                skillDex = int.Parse(dexVal.Text.ToString()),
                skillInt = int.Parse(intVal.Text.ToString()),
                skillStr = int.Parse(strVal.Text.ToString()),
                skillWis = int.Parse(wisVal.Text.ToString())
            };
            db.Update(character);
            await Navigation.PushAsync(new CharacterCreatePage3(character)); //Navigate to step 3/4 of the character creation process and pass the 'characterID' parameter
        }
    }
}