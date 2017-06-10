namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailList")]
    public partial class EmailList
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string EmalTitle { get; set; }

        [StringLength(1000)]
        public string EmalContent { get; set; }

        public int? EmalType { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string F_File { get; set; }
    }
}
