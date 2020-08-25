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


        public override string ToString()
        {
            return this.classID;
        }
    }
}
