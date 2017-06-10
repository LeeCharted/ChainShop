namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppURL")]
    public partial class AppURL
    {
        [StringLength(128)]
        public string url { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool valid { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte platformCode { get; set; }
    }
}
