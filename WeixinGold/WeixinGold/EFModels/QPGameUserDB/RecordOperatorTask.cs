namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordOperatorTask")]
    public partial class RecordOperatorTask
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int TaskID { get; set; }

        public int TaskCount { get; set; }

        public short sOperator { get; set; }

        public int BeforeCount { get; set; }

        public int AfterCount { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
