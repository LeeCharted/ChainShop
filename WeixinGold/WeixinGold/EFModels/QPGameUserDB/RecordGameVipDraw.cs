namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordGameVipDraw")]
    public partial class RecordGameVipDraw
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int CurVip { get; set; }

        public int GoodsType { get; set; }

        public int GoodsID { get; set; }

        public long GoodsCount { get; set; }

        public long BeforeCount { get; set; }

        public long AfterCount { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
