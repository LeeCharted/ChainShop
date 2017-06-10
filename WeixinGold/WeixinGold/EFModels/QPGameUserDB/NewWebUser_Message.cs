namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewWebUser_Message
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Loveliness { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProtectID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(31)]
        public string RegAccounts { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FaceID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(15)]
        public string LastLogonIP { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Nullity { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte Gender { get; set; }

        public DateTime? LoginDateTime { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte MoorMachine { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime RegisterDate { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(15)]
        public string RegisterIP { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool StunDown { get; set; }

        [Key]
        [Column(Order = 15)]
        public byte MemberOrder { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime MemberOverDate { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameLogonTimes { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(32)]
        public string LogonPass { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(32)]
        public string InsurePass { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Experience { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }

        [StringLength(16)]
        public string Compellation { get; set; }

        [StringLength(16)]
        public string QQ { get; set; }

        [StringLength(20)]
        public string Usersfz { get; set; }

        [StringLength(32)]
        public string EMail { get; set; }

        [StringLength(32)]
        public string SeatPhone { get; set; }

        [StringLength(16)]
        public string MobilePhone { get; set; }

        public long? Score { get; set; }

        public int? WinCount { get; set; }

        public long? InsureScore { get; set; }

        public int? LostCount { get; set; }

        public int? DrawCount { get; set; }

        public int? FleeCount { get; set; }

        public int? OnLineTimeCount { get; set; }

        public int? Gold { get; set; }

        public int? ReelCount { get; set; }

        [StringLength(15)]
        public string AddrString { get; set; }

        [StringLength(32)]
        public string MachineSerial2 { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(31)]
        public string SpreaderID { get; set; }

        [StringLength(128)]
        public string DwellingPlace { get; set; }

        [StringLength(101)]
        public string UnderWrite { get; set; }

        [Key]
        [Column(Order = 22)]
        public DateTime LastLogonDate { get; set; }

        public int? Total_Gold { get; set; }

        [StringLength(200)]
        public string WeiXinID { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhoneBill { get; set; }

        public byte? CustomFaceVer { get; set; }
    }
}
