namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LevelGiftCate")]
    public partial class LevelGiftCate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelID { get; set; }

        [Required]
        [StringLength(32)]
        public string GiftName { get; set; }

        [Required]
        [StringLength(32)]
        public string ResName { get; set; }
    }
}
