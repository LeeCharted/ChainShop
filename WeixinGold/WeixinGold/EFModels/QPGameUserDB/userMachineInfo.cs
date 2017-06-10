namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userMachineInfo")]
    public partial class userMachineInfo
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
        public string RegAccounts { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(32)]
        public string MachineSerial { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime LastLogonDate { get; set; }

        [StringLength(32)]
        public string MachineSerial2 { get; set; }

        public bool? EnjoinLogon { get; set; }

        public bool? EnjoinRegister { get; set; }

        public DateTime? EnjoinOverDate { get; set; }

        public DateTime? CollectDate { get; set; }

        [StringLength(32)]
        public string CollectNote { get; set; }
    }
}
