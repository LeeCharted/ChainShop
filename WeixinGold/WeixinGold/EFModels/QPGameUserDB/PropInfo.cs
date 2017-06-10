namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropInfo")]
    public partial class PropInfo
    {
        [Key]
        public int PropID { get; set; }

        [Column("PropInfo")]
        [StringLength(50)]
        public string PropInfo1 { get; set; }

        public int? PropPrice { get; set; }

        public int? GlamourAorS { get; set; }
    }
}
