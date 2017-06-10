namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordOnlineReward")]
    public partial class RecordOnlineReward
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }

        public int OnlineID { get; set; }

        public int Score { get; set; }

        public long BeforeScore { get; set; }

        public long AfterScore { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
