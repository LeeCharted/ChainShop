namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordSignup")]
    public partial class RecordSignup
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }

        public int SignType { get; set; }

        public DateTime MatchTime { get; set; }

        public int PropertyCount { get; set; }

        [Required]
        [StringLength(100)]
        public string ProType { get; set; }

        [Required]
        [StringLength(100)]
        public string ProID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProCount { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
