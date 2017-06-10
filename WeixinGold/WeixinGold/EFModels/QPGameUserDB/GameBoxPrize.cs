namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameBoxPrize")]
    public partial class GameBoxPrize
    {
        [Key]
        public int PrizeID { get; set; }

        [Required]
        [StringLength(100)]
        public string PrizeName { get; set; }

        public int Probability { get; set; }

        public int GoodsType { get; set; }

        public int GoodsID { get; set; }

        public long PrizePrice { get; set; }

        public int PrizeCount { get; set; }

        public bool IsReceive { get; set; }

        [Required]
        [StringLength(50)]
        public string PrizeImage { get; set; }

        [StringLength(50)]
        public string ScoreImage { get; set; }

        [StringLength(50)]
        public string IcoImage { get; set; }

        public int? IcoIndex { get; set; }

        public int Classify { get; set; }

        public int ShowProb { get; set; }

        public int GameBox { get; set; }

        [Required]
        [StringLength(128)]
        public string Description { get; set; }
    }
}
