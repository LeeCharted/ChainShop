namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MallInfo")]
    public partial class MallInfo
    {
        public int ID { get; set; }

        public int SortID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public byte VirtualItem { get; set; }

        public int Price { get; set; }

        public int StockCount { get; set; }
    }
}
