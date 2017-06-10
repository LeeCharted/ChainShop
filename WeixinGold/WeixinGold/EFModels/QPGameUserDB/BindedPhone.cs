namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BindedPhone")]
    public partial class BindedPhone
    {
        public int ID { get; set; }

        [Required]
        [StringLength(16)]
        public string BindMobilePhone { get; set; }

        public DateTime? GetPwdDate { get; set; }

        public int? UserID { get; set; }

        public DateTime? CollectDate { get; set; }

        public long? PresentScore { get; set; }

        public long? AccountInsureScore { get; set; }
    }
}
