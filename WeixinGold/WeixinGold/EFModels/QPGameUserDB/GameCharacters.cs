namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameCharacters
    {
        public int ID { get; set; }

        public int SortID { get; set; }

        public int MainID { get; set; }

        public int ClothesType { get; set; }

        public bool Status { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string ResName { get; set; }

        public short ClothesSex { get; set; }

        public long Price { get; set; }

        public int PriceType { get; set; }

        public int Discount { get; set; }

        public long FeedBack { get; set; }

        public int DateLimit { get; set; }

        public DateTime CollectDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
