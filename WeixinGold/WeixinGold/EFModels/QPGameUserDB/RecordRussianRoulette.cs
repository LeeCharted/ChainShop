namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordRussianRoulette")]
    public partial class RecordRussianRoulette
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }

        public int PrizeID { get; set; }

        public int VipID { get; set; }

        public long BeforeScore { get; set; }

        public long AfterScore { get; set; }

        public long Score { get; set; }

        public DateTime CollectDate { get; set; }

        public DateTime PrizeDate { get; set; }

        public byte Status { get; set; }
    }
}
