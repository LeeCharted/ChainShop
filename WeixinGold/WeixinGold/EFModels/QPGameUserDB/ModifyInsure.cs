namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModifyInsure")]
    public partial class ModifyInsure
    {
        [Key]
        public int RecordID { get; set; }

        public int AdminID { get; set; }

        public int UserID { get; set; }

        public long GoldCount { get; set; }

        [Required]
        [StringLength(15)]
        public string CollectIP { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
