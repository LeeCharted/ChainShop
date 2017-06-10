namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskInfo")]
    public partial class TaskInfo
    {
        public int ID { get; set; }

        public int SortID { get; set; }

        public int KindID { get; set; }

        public int TaskTypeID { get; set; }

        public int TaskDate { get; set; }

        public bool TaskPause { get; set; }

        public int PrizeType { get; set; }

        public int PrizeCount { get; set; }

        public int TaskCount { get; set; }

        public int NextID { get; set; }

        [Required]
        [StringLength(125)]
        public string TaskName { get; set; }

        public int TaskGrade { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public bool IsPushMsg { get; set; }

        [StringLength(1024)]
        public string PushContent { get; set; }
    }
}
