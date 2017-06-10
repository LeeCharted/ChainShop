namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameConfig")]
    public partial class GameConfig
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Mark { get; set; }

        public int Value1 { get; set; }

        public int? Value2 { get; set; }

        [StringLength(50)]
        public string Value3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Destription { get; set; }
    }
}
