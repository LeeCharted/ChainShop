namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordExchangeExp")]
    public partial class RecordExchangeExp
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int LevelID { get; set; }

        public long? OriginalScore { get; set; }

        public long Score { get; set; }

        public long? AfterScore { get; set; }

        public DateTime CollectDate { get; set; }

        public short? IsGiftGet { get; set; }

        public DateTime? GiftDate { get; set; }

        public int? SpreaderID { get; set; }

        public long? OriginalSpreaderScore { get; set; }

        public long? SpreaderScore { get; set; }

        public long? AfterSpreaderScore { get; set; }

        public short? IsSpreaderGet { get; set; }

        public DateTime? SpreaderDate { get; set; }
    }
}
