namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrizeInfo")]
    public partial class PrizeInfo
    {
        [Key]
        public int PrizeID { get; set; }

        [Required]
        [StringLength(100)]
        public string PrizeName { get; set; }

        public int Probability { get; set; }

        public int PrizeType { get; set; }

        public long PrizePrice { get; set; }

        public int PrizeCount { get; set; }

        public bool IsReceive { get; set; }

        [Required]
        [StringLength(200)]
        public string PrizeImageAdd { get; set; }

        public int ShowProb { get; set; }
    }
}
