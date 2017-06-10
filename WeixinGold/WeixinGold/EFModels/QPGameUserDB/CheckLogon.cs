namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckLogon")]
    public partial class CheckLogon
    {
        [Key]
        [StringLength(31)]
        public string Accounts { get; set; }

        public int LogonStatus { get; set; }

        public DateTime CollectDate { get; set; }

        public int id { get; set; }
    }
}
