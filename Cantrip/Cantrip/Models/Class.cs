using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Cantrip.Models
{
    public class Class
    {
        [PrimaryKey]
        public string classID { get; set; }

        public string classIconSource { get; set; }
        public string description { get; set; }
        public string hitDie { get; set; }
        public string saves { get; set; }

        public string armor { get; set; }
        public string weapon { get; set; }
        public string tool { get; set; }
        public string language { get; set; }

        //Class Skill Proficiency
        public bool acrobatics { get; set; }
        public bool animalHandling { get; set; }
        public bool arcana { get; set; }
        public bool athletics { get; set; }
        public bool deception { get; set; }
        public bool history { get; set; }
        public bool insight { get; set; }
        public bool intimidation { get; set; }
        public bool investigate { get; set; }
        public bool medicine { get; set; }
        public bool nature { get; set; }
        public bool perception { get; set; }
        public bool performance { get; set; }
        public bool persuasion { get; set; }
        public bool religion { get; set; }
        public bool sleightOfHand { get; set; }
        public bool stealth { get; set; }
        public bool survival { get; set; }


        public override string ToString()
        {
            return this.classID;
        }
    }
}
