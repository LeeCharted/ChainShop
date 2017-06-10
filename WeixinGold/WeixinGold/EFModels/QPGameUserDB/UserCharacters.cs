namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserCharacters
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int MainID { get; set; }

        public int CharacterID { get; set; }

        public bool Duplicate { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public bool ShowThis { get; set; }

        public DateTime BuyDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        [StringLength(128)]
        public string Description { get; set; }
    }
}
