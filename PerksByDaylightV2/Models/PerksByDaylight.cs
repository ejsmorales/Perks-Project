using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerksByDaylightV2.Models
{
    public class PerksByDaylight
    {
        // [Column("_PerkName")]
        public string PerkName { get; set; }
        // [Column("_Description")]
        public string Character { get; set; }
        // [Column("_Role")]
        public string Role { get; set; }
        //[Column("_Character")]
        public string Description { get; set; }
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int Version { get; set; }
        public byte[] Image { get; set; }

        public string Type { get; set; }

        public string Picture { get; set; }
    }
}
