namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskType")]
    public partial class TaskType
    {
        [Key]
        public int TaskID { get; set; }

        [StringLength(128)]
        public string TaskInfo { get; set; }

        public int? GoodsType { get; set; }

        public int? GoodsID { get; set; }

        public int? Award { get; set; }

        public byte? Limitless { get; set; }

        [StringLength(32)]
        public string TaskName { get; set; }
    }
}
