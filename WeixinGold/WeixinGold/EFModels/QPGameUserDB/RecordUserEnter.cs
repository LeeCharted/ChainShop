namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordUserEnter")]
    public partial class RecordUserEnter
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
        public string ServerIP { get; set; }

        [Required]
        [StringLength(15)]
        public string ClientIP { get; set; }

        public byte LogonType { get; set; }

        [Required]
        [StringLength(32)]
        public string MachineSerial { get; set; }

        public int Loveliness { get; set; }

        public DateTime EnterTime { get; set; }
    }
}
