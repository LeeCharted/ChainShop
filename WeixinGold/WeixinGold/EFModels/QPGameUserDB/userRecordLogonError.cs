namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userRecordLogonError")]
    public partial class userRecordLogonError
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        [StringLength(31)]
        public string Accounts { get; set; }

        [StringLength(31)]
        public string LogonPass { get; set; }

        [StringLength(15)]
        public string LastLogonIP { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }

        [StringLength(20)]
        public string UserSfz { get; set; }

        public int? ErrorType { get; set; }

        [StringLength(128)]
        public string ErrorDescribe { get; set; }

        public DateTime? CollectDate { get; set; }

        public int? UserID { get; set; }

        public int? GameID { get; set; }

        [StringLength(31)]
        public string NickName { get; set; }
    }
}