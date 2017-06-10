namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfineContent")]
    public partial class ConfineContent
    {
        [Key]
        [StringLength(31)]
        public string String { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
