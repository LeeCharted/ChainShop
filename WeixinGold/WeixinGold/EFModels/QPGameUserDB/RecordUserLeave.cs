namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordUserLeave")]
    public partial class RecordUserLeave
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public long Score { get; set; }

        public long InsureScore { get; set; }

        public int GoldCount { get; set; }

        public int TicketCount { get; set; }

        [Required]
        [StringLength(15)]
        public string ClientIP { get; set; }

        [Required]
        [StringLength(32)]
        public string MachineSerial { get; set; }

        public int Loveliness { get; set; }

        public int OnlineTimeCount { get; set; }

        public DateTime LeaveTime { get; set; }
    }
}
