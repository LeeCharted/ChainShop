namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLoginGameList")]
    public partial class UserLoginGameList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Score { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long InsureScore { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoldCount { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketCount { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(15)]
        public string ServerIP { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(15)]
        public string ClientIP { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(32)]
        public string MachineSerial { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Loveliness { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime EnterTime { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte LogonType { get; set; }
    }
}
