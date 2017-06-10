namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OnlineReward")]
    public partial class OnlineReward
    {
        public int ID { get; set; }

        public int TimeSpan { get; set; }

        public int Score { get; set; }
    }
}
