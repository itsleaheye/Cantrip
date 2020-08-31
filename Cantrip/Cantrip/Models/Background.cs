using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Cantrip.Models
{
    public class Background
    {
        [PrimaryKey]
        public string backgroundID { get; set; } //Primary key declaration

        public string language { get; set; } //language

        public override string ToString()
        {
            return this.backgroundID;
        }
    }
}
