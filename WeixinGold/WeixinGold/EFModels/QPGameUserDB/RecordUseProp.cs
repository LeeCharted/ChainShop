namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordUseProp")]
    public partial class RecordUseProp
    {
        [Key]
        public int RecordID { get; set; }

        public int PropID { get; set; }

        public int SendUserID { get; set; }

        public int RecvUserID { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }

        public long BeforeScore { get; set; }

        public long AfterScore { get; set; }

        public int BeforeLoveliness { get; set; }

        public int AfterLoveliness { get; set; }

        public DateTime? UsePropDate { get; set; }
    }
}
