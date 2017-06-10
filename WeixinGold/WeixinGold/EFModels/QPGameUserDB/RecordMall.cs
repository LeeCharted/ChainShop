namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordMall")]
    public partial class RecordMall
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int MallID { get; set; }

        public long? BeforeCount { get; set; }

        public int BuyCount { get; set; }

        public long? AfterCount { get; set; }

        public int BeforeScore { get; set; }

        public int Score { get; set; }

        public int AfterScore { get; set; }

        public DateTime BuyDate { get; set; }

        [StringLength(16)]
        public string Compellation { get; set; }

        [StringLength(128)]
        public string DwellingPlace { get; set; }

        [StringLength(12)]
        public string MobilePhone { get; set; }

        public int? AdminID { get; set; }

        public DateTime? AdminDate { get; set; }

        [StringLength(128)]
        public string ExpressInfo { get; set; }

        public int RecordState { get; set; }
    }
}
