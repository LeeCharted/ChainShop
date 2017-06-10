namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountsInfo")]
    public partial class AccountsInfo
    {
        [Key]
        public int UserID { get; set; }

        public int GameID { get; set; }

        public int ProtectID { get; set; }

        [Required]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Required]
        [StringLength(31)]
        public string RegAccounts { get; set; }

        [StringLength(101)]
        public string UnderWrite { get; set; }

        [Required]
        [StringLength(32)]
        public string LogonPass { get; set; }

        [Required]
        [StringLength(32)]
        public string InsurePass { get; set; }

        [Required]
        [StringLength(31)]
        public string SpreaderID { get; set; }

        public short FaceID { get; set; }

        public int Experience { get; set; }

        public int UserRight { get; set; }

        public int MasterRight { get; set; }

        public int ServiceRight { get; set; }

        public byte MasterOrder { get; set; }

        public byte MemberOrder { get; set; }

        public DateTime MemberOverDate { get; set; }

        public int Loveliness { get; set; }

        public byte Gender { get; set; }

        public bool Nullity { get; set; }

        public bool StunDown { get; set; }

        public byte MoorMachine { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }

        public int WebLogonTimes { get; set; }

        public int GameLogonTimes { get; set; }

        [Required]
        [StringLength(15)]
        public string RegisterIP { get; set; }

        [Required]
        [StringLength(15)]
        public string LastLogonIP { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime LastLogonDate { get; set; }

        public byte? CustomFaceVer { get; set; }

        [StringLength(50)]
        public string C_IDNO { get; set; }

        [StringLength(50)]
        public string C_ADDRESS { get; set; }

        [StringLength(50)]
        public string C_EMAIL { get; set; }

        [StringLength(50)]
        public string C_PROTECTQUES { get; set; }

        [StringLength(50)]
        public string C_PROTECTANSW { get; set; }

        [StringLength(50)]
        public string C_BOXPASSWORD { get; set; }

        [StringLength(50)]
        public string OlePassWord { get; set; }

        public bool IsCheckPassWord { get; set; }

        public bool? IsBoxPassWord { get; set; }

        [StringLength(50)]
        public string PassWordCode { get; set; }

        [StringLength(50)]
        public string LoginKick { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; }

        public int? Del { get; set; }

        public int yy { get; set; }

        public DateTime? LoginDateTime { get; set; }

        public int? YYCar { get; set; }

        public int? F_why { get; set; }

        public DateTime? EndTime { get; set; }

        public bool? bGuest { get; set; }

        [Required]
        [StringLength(31)]
        public string NickName { get; set; }

        public int PhoneBill { get; set; }

        public int RoomCard { get; set; }
    }
}
