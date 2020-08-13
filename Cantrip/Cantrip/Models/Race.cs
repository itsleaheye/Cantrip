using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Cantrip.Models
{
    public class Race
    {
        [PrimaryKey]
        public string raceID { get; set; }
        public string description { get; set; }

        public string racialTrait { get; set; }

        //public List abilities { get; set; }
        public string resistance { get; set; }
        public string language { get; set; }

        public override string ToString()
        {
            return this.description;
        }
    }
}
