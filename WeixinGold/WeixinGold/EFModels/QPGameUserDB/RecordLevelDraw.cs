namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordLevelDraw")]
    public partial class RecordLevelDraw
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int LevelID { get; set; }

        public int Gift1Type { get; set; }

        public int Gift1ID { get; set; }

        public int Gift1Count { get; set; }

        public int Gift2Type { get; set; }

        public int Gift2ID { get; set; }

        public int Gift2Count { get; set; }

        [Required]
        [StringLength(15)]
        public string ClientIP { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
