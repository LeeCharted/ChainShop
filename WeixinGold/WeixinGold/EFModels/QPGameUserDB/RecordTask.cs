namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordTask")]
    public partial class RecordTask
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int TaskID { get; set; }

        public int TaskCount { get; set; }

        public DateTime? LastReachedDate { get; set; }

        public DateTime? LastReceivedDate { get; set; }

        public int? BeginPhoneFare { get; set; }

        public int? AddPhoneFare { get; set; }

        public int? EndPhoneFare { get; set; }
    }
}
