namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameMission")]
    public partial class GameMission
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int TaskID { get; set; }

        public int TaskData { get; set; }

        public DateTime CollectDate { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }
    }
}
