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
                    if (currentCharValue <= 14) //if Charisma Value is below the cap of '15', let the user increase the number
                    {
                        currentCharValue++;
                        charVal.Text = currentCharValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Constitution Increase
                else if (btnName == "BtnConInc")
                {
                    int currentConValue = int.Parse(conVal.Text.ToString());
                    if (currentConValue <= 14) //if Constitution Value is below the cap of '15', let the user increase the number
                    {
                        currentConValue++;
                        conVal.Text = currentConValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Increase
                else if (btnName == "BtnDexInc")
                {
                    int currentDexValue = int.Parse(dexVal.Text.ToString());
                    if (currentDexValue <= 14) //if Dexterity Value is below the cap of '15', let the user increase the number
                    {
                        currentDexValue++;
                        dexVal.Text = currentDexValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Intelligence Increase
                else if (btnName == "BtnIntInc")
                {
                    int currentIntValue = int.Parse(intVal.Text.ToString());
                    if (currentIntValue <= 14) //if Intelligence Value is below the cap of '15', let the user increase the number
                    {
                        currentIntValue++;
                        intVal.Text = currentIntValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Increase
                else if (btnName == "BtnStrInc")
                {
                    int currentStrValue = int.Parse(strVal.Text.ToString());
                    if (currentStrValue <= 14) //if Strength Value is below the cap of '15', let the user increase the number
                    {
                        currentStrValue++;
                        strVal.Text = currentStrValue.ToString();
                        remainingPoints--;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Wisdom Increase
                else if (btnName == "BtnWisInc")
                {
                    int currentWisValue = int.Parse(wisVal.Text.ToString());
                    if (currentWisValue <= 14) //if Dexterity Value is below the cap of '15', let the user increase the number
                    {
                        currentWisValue++;
                        wisVal.Text = currentWisValue.ToString();
                        remainingPoints--;
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
                    if (currentCharValue >= 9) //if Charisma Value is above the min of '8', let the user decrease the number
                    {
                        currentCharValue--;
                        charVal.Text = currentCharValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Constitution Decrease
                else if (btnName == "BtnConDec")
                {
                    int currentConValue = int.Parse(conVal.Text.ToString());
                    if (currentConValue >= 9) //if Constitution Value is above the min of '8', let the user decrease the number
                    {
                        currentConValue--;
                        conVal.Text = currentConValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Decrease
                else if (btnName == "BtnDexDec")
                {
                    int currentDexValue = int.Parse(dexVal.Text.ToString());
                    if (currentDexValue >= 9) //if Dexterity Value is above the min of '8', let the user decrease the number
                    {
                        currentDexValue--;
                        dexVal.Text = currentDexValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Intelligence Decrease
                else if (btnName == "BtnIntDec")
                {
                    int currentIntValue = int.Parse(intVal.Text.ToString());
                    if (currentIntValue >= 9) //if Intelligence Value is above the min of '8', let the user decrease the number
                {
                        currentIntValue--;
                        intVal.Text = currentIntValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Dexterity Decrease
                else if (btnName == "BtnStrInc")
                {
                    int currentStrValue = int.Parse(strVal.Text.ToString());
                    if (currentStrValue >= 9) //if Strength Value is above the min of '8', let the user decrease the number
                    {
                        currentStrValue--;
                        strVal.Text = currentStrValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }
                //Wisdom Decrease
                else if (btnName == "BtnWisInc")
                {
                    int currentWisValue = int.Parse(wisVal.Text.ToString());
                    if (currentWisValue >= 9) //if Dexterity Value is above the min of '8', let the user decrease the number
                    {
                        currentWisValue--;
                        wisVal.Text = currentWisValue.ToString();
                        remainingPoints++;
                        pointsRemain.Text = remainingPoints.ToString();
                    }
                }        
        }
        private void BtnRoll_Clicked(object sender, EventArgs e)
        {
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
            /*var db = new SQLiteConnection(dbPath); //Connect to local database 
            Character character = new Character()
            {
                characterID = selectedCharID,
                skillChar = int.Parse(charVal.Text.ToString()),
                skillCon = int.Parse(conVal.Text.ToString()),
                skillDex = int.Parse(dexVal.Text.ToString()),
                skillInt = int.Parse(intVal.Text.ToString()),
                skillStr = int.Parse(strVal.Text.ToString()),
                skillWis = int.Parse(wisVal.Text.ToString())
            };
            db.Update(character);*/
            await Navigation.PushAsync(new CharacterCreatePage3()); //Navigate to step 3/4 of the character creation process and pass the 'characterID' parameter
        }
    }
}