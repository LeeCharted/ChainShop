namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameIdentifier")]
    public partial class GameIdentifier
    {
        [Key]
        public int UserID { get; set; }

        public int GameID { get; set; }

        public int IDLevel { get; set; }
    }
}
