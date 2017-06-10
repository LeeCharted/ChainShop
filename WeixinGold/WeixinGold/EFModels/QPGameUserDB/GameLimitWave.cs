namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameLimitWave")]
    public partial class GameLimitWave
    {
        public int ID { get; set; }

        public int InitID { get; set; }

        public int WaveIndex { get; set; }

        public long UpperLimit { get; set; }

        public long LowerLimit { get; set; }
    }
}
