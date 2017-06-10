namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordLogonMall")]
    public partial class RecordLogonMall
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public DateTime RequestTime { get; set; }

        public int RequestCode { get; set; }

        public DateTime? LogonTime { get; set; }
    }
}
