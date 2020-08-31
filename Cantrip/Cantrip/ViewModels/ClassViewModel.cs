using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Cantrip.Models;

namespace Cantrip.ViewModels
{

    public class ClassViewModel
    {
        public ObservableCollection<Class> ClassList { get; set; }
        public ClassViewModel()
        {
            ClassList = new ObservableCollection<Class>();
            ClassList.Add(new Class { classID = "Barbarian", description = "A ferocious warrior who can enter a primitive battle rage.", classIconSource = "classBarbarianLogo.png", hitDie = "1d12", armor = "Light, Medium, and Shields", weapon = "Simple and Martial Weapons", tool = "None", saves = "Strength and Constitution", 
                acrobatics = true, animalHandling = true, arcana = false,athletics =true , deception = false, history = false, insight = false, intimidation = true,investigate = false, medicine = false, nature = true, perception = true, performance =false , persuasion =false , religion = false, sleightOfHand = false, stealth =false, survival = true});
            ClassList.Add(new Class { classID = "Bard", description = "A talented musician that weaves magic into their words.", classIconSource = "classBardLogo.png", hitDie = "1d8", armor = "Light", weapon = "Simple Weapons, Hand Crossbows, Longswords, Rapiers, Shortswords", tool = "3 Musical Instruments", saves = "Charisma and Dexterity",
                acrobatics = true, animalHandling = true, arcana = true,athletics = true, deception = true, history = true, insight = true, intimidation =true , investigate = true,medicine = true, nature = true, perception = true, performance = true, persuasion = true, religion = true, sleightOfHand = true, stealth =true, survival =true });
            ClassList.Add(new Class { classID = "Cleric", description = "A priest like champion that wields divine magic.", classIconSource = "classClericLogo.png", hitDie = "1d8", armor = "Light, Medium, and Shields", weapon = "Simple Weapons", tool="None", saves="Charisma and Wisdom",
                acrobatics = false, animalHandling = false, arcana = false,athletics = false, deception = false, history = true, insight = true, intimidation = false, investigate = false, medicine = true, nature = false, perception = false, performance = false, persuasion = true, religion = true, sleightOfHand = false, stealth =false, survival = false}); 
            ClassList.Add(new Class() { classID = "Druid", description = "A wielder of nature-themed magics.", classIconSource = "classDruidLogo.png", hitDie="1d8", armor="Light, Medium, and Shields", weapon="Clubs, Daggers, Darts, Javelins, Maces, Staffs, Scimitars, Sickles, Slings, and Spears", tool="Herbalism Kit", saves="Intelligence and Wisdom",
                acrobatics = false, animalHandling = true, arcana = true,athletics = false, deception = false, history = false, insight = true, intimidation = false, investigate = false, medicine =true , nature =true , perception = true, performance = false, persuasion = false, religion = true, sleightOfHand = false, stealth =false, survival = true});
            ClassList.Add(new Class() { classID = "Fighter", description = "A versatile warrior utilizing weapons, strategy and tactics.", classIconSource = "ClassFighter2Logo.png", hitDie = "1d10", armor = "All armor, and shields", weapon = "Simple and Martial Weapons", tool = "None", saves = "Constitution and Strength",
                acrobatics = true, animalHandling = true, arcana = false, athletics = true, deception = false, history = true, insight = true, intimidation = false, investigate = false,  medicine = false, nature = false, perception = true, performance = false, persuasion = false, religion = false, sleightOfHand = false, stealth =false, survival = true});
            ClassList.Add(new Class() { classID = "Monk", description = "A mystic and master of the martial arts.", classIconSource = "ClassMonkLogo.png", hitDie = "1d8", armor = "None", weapon = "Simple Weapons, and Shortswords", tool = "1 Artisian Tool, or Musical Instrument", saves = "Dexterity and Strength",
                acrobatics = true, animalHandling = true, arcana = false,athletics = true, deception = false, history = true, insight = true , intimidation = true,  investigate = false, medicine =false  , nature = false , perception =true  , performance = false, persuasion = false, religion = false, sleightOfHand = false, stealth =false, survival = true});
            ClassList.Add(new Class() { classID = "Paladin", description = "A holy warrior that can cast divine magic.", classIconSource = "ClassPaladinLogo.png", hitDie = "1d10", armor = "All Armor, and Shields", weapon = "Simple and Martial Weapons", tool = "None", saves = "Charisma and Wisdom",
                acrobatics = false, animalHandling = false, arcana = false,athletics = true, deception = false, history = false, insight = true, intimidation = true, investigate = false, medicine =true , nature = false, perception = false, performance = false, persuasion = true, religion = true, sleightOfHand = false, stealth =false, survival = false});
            ClassList.Add(new Class() { classID = "Ranger", description = "A protecter uses nature magic and weapons in combat.", classIconSource = "ClassRangerLogo.png", hitDie = "1d10", armor = "Light, Medium, and Shields", weapon = "Simple and Martial Weapons", tool = "None", saves = "Dexterity and Strength",
                acrobatics = false, animalHandling = true, arcana = false,athletics = true, deception = false, history =false , insight = true, intimidation = false, investigate = true, medicine = false, nature = true, perception = true, performance = false, persuasion =false , religion =false , sleightOfHand = false, stealth =false, survival = true});
            ClassList.Add(new Class() { classID = "Rogue", description = "A stealthy and dexterous character that uses trickery.", classIconSource = "ClassRogueLogo.png", hitDie = "1d8", armor = "Light", weapon = "Simple Weapons, Hand Crossbows, Longswords, Rapiers, Shortswords", tool = "Thieves Tools", saves = "Dexterity and Intelligence",
                acrobatics = true, animalHandling = false, arcana = false,athletics = true, deception = true, history =false , insight = true, intimidation = true,  investigate = true, medicine = false, nature = false, perception = true, performance = true, persuasion = true, religion = false, sleightOfHand = true, stealth =true, survival = false});
            ClassList.Add(new Class() { classID = "Sorcerer", description = "A spellcaster who inherited their magic as a gift.", classIconSource = "ClassSorcererLogo.png", hitDie = "1d6", armor = "None", weapon = "Daggers, Darts, Slings, Staffs, and Light Crossbows", tool = "None", saves = "Constitution and Charisma",
                acrobatics = false, animalHandling = false, arcana = true,athletics =false , deception = true, history = false, insight = true, intimidation = true, investigate = false, medicine = false, nature = false, perception = false, performance = false, persuasion = true, religion = true, sleightOfHand = false, stealth =false, survival = false});
            ClassList.Add(new Class() { classID = "Warlock", description = "A spellcaster who bargained with an extraplanar entity.", classIconSource = "ClassWarlockLogo.png", hitDie="1d8", armor = "Light", weapon = "Simple Weapons", tool="None", saves="Charisma and Wisdom",
                acrobatics = false, animalHandling = false, arcana = true,athletics =false , deception = true, history = true, insight = false, intimidation = true, investigate = true, medicine = false, nature = true, perception = false, performance = false, persuasion = false, religion = true, sleightOfHand = false, stealth =false, survival = false});
            ClassList.Add(new Class() { classID = "Wizard", description = "A scholarly spellcaster who can manipulate reality.", classIconSource = "ClassWizardLogo.png", hitDie = "1d6", armor = "None", weapon = "Daggers, Darts, Slings, Staffs, and Light Crossbows", tool = "None", saves = "Intelligence and Wisdom",
                acrobatics = false, animalHandling = false, arcana = true,athletics = false, deception = false, history = true, insight = true, intimidation = false, investigate = true, medicine = true, nature = false, perception = false, performance = false, persuasion = false, religion = true, sleightOfHand = false, stealth =false, survival = false});

        }

    }

}
