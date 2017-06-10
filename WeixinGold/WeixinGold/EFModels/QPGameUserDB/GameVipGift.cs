namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameVipGift")]
    public partial class GameVipGift
    {
        public int ID { get; set; }

        public int PrizeID { get; set; }
    }
}
