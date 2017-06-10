namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskList")]
    public partial class TaskList
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        public int TaskType { get; set; }
    }
}
