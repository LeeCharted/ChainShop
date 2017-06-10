namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RussianRoulette")]
    public partial class RussianRoulette
    {
        public int ID { get; set; }

        public int Probability { get; set; }

        public int GoodsType { get; set; }

        public int GoodsID { get; set; }

        public int GoodsCount { get; set; }
    }
}
