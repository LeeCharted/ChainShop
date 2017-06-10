namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeExpList")]
    public partial class ExchangeExpList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelID { get; set; }

        public int Experience { get; set; }

        public long Score { get; set; }

        [Required]
        [StringLength(30)]
        public string LevelName { get; set; }

        [Required]
        [StringLength(50)]
        public string LevelImage { get; set; }

        public long? SpreaderScore { get; set; }

        public int? GiftType1 { get; set; }

        public int? GiftID1 { get; set; }

        public int? GiftCount1 { get; set; }

        [StringLength(50)]
        public string BackImage1 { get; set; }

        public int? GiftType2 { get; set; }

        public int? GiftID2 { get; set; }

        public int? GiftCount2 { get; set; }

        [StringLength(50)]
        public string BackImage2 { get; set; }

        public int? GiftType3 { get; set; }

        public int? GiftID3 { get; set; }

        public int? GiftCount3 { get; set; }

        [StringLength(50)]
        public string BackImage3 { get; set; }

        [StringLength(128)]
        public string Description { get; set; }
    }
}
