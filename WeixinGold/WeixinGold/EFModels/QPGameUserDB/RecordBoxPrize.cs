namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordBoxPrize")]
    public partial class RecordBoxPrize
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int BoxID { get; set; }

        public int ResultID { get; set; }

        public int PrizeID1 { get; set; }

        public int PrizeID2 { get; set; }

        public int PrizeID3 { get; set; }

        public int PrizeID4 { get; set; }

        public int PrizeID5 { get; set; }

        public int PrizeID6 { get; set; }

        public int PrizeID7 { get; set; }

        public int PrizeID8 { get; set; }

        public int PrizeSatuts { get; set; }

        public DateTime CollectDate { get; set; }

        [StringLength(16)]
        public string QQ { get; set; }

        [StringLength(128)]
        public string DwellingPlace { get; set; }

        [StringLength(8)]
        public string PostalCode { get; set; }

        [StringLength(16)]
        public string MobilePhone { get; set; }
    }
}
