namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameTaskType")]
    public partial class GameTaskType
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }
    }
}
