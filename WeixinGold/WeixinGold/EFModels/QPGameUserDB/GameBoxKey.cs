namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameBoxKey")]
    public partial class GameBoxKey
    {
        [Key]
        public int KeyID { get; set; }

        [Required]
        [StringLength(32)]
        public string KeyName { get; set; }

        public long KeyPrice { get; set; }

        public int PriceType { get; set; }

        public int BoxIndex { get; set; }

        public int Discount { get; set; }

        [Required]
        [StringLength(32)]
        public string KeyNote { get; set; }

        public bool Nullity { get; set; }

        [StringLength(100)]
        public string Pic { get; set; }
    }
}
