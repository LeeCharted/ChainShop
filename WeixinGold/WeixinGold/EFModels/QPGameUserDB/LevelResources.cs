namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LevelResources
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string BackImage { get; set; }

        [StringLength(50)]
        public string ScoreImage { get; set; }

        [StringLength(50)]
        public string IcoImage { get; set; }

        public int? IcoIndex { get; set; }
    }
}
