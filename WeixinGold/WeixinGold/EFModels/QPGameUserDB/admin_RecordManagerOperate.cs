namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_RecordManagerOperate
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KindID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServerID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChairID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserRight { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsUserGlobal { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MasterRight { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsMasterGlobal { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CtrlOrder { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CtrlType { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CtrlResult { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime CollectDate { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(15)]
        public string ClientIP { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        [StringLength(32)]
        public string ServerName { get; set; }

        [StringLength(32)]
        public string KindName { get; set; }

        [StringLength(31)]
        public string NickName { get; set; }

        [StringLength(31)]
        public string AdminNickName { get; set; }

        [StringLength(32)]
        public string NodeName { get; set; }

        public int? GameID { get; set; }

        [StringLength(31)]
        public string Accounts { get; set; }

        [StringLength(20)]
        public string Usersfz { get; set; }

        [StringLength(16)]
        public string MobilePhone { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }

        [StringLength(15)]
        public string LastLogonIP { get; set; }
    }
}
