namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordGetUserRight")]
    public partial class RecordGetUserRight
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }

        public int MasterRight { get; set; }

        [Required]
        [StringLength(15)]
        public string ClientIP { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
