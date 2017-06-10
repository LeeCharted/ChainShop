namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MissionFinish")]
    public partial class MissionFinish
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int TaskID { get; set; }

        public int TaskCount { get; set; }

        public int OriReelCount { get; set; }

        public long OriPrizeCount { get; set; }

        public DateTime CollectDate { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }
    }
}
