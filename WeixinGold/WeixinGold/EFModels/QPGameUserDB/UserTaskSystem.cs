namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTaskSystem")]
    public partial class UserTaskSystem
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int TaskClassify { get; set; }

        public int TaskID { get; set; }

        public long TaskCount { get; set; }

        public DateTime StartTime { get; set; }
    }
}
