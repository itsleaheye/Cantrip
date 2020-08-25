using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Cantrip.Models
{
    public class Character
    {
        [PrimaryKey]
        public int characterID { get; set; } //Primary key declaration

        public string Name { get; set; } //User sets the character name
        //Omitted public string Alignment { get; set; }
        public string Notes { get; set; } //String content
        //public List Skills { get; set; }
        public string TotalLevel { get; set; } //Updates on 'totalLevelUp'
        public int CurrentHP { get; set; } //User can manually modify this
        public int MaxHP { get; set; } //Updates/increases as characters level increases
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int WalkingSpeed { get; set; }
        public string footNotes { get; set; }
        
        //Skills
        public int skillChar { get; set; }
        public int skillCon { get; set; }
        public int skillDex { get; set; }
        public int skillInt { get; set; }
        public int skillStr { get; set; }
        public int skillWis { get; set; }
        
        //Foriegn Keys
        public string classID { get; set; } //Foreign key to 'Class' objects, selected by the user 
        public string raceID { get; set; } //Foreign key to 'Race' objects, selected by the user 
        public string backgroundID { get; set; }

        //Not Mapped property
        public string TotalLevelString
        {
            get { return "Lvl " + this.TotalLevel; }
        }
    }
}
