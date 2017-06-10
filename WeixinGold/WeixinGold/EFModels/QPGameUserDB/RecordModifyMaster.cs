namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordModifyMaster")]
    public partial class RecordModifyMaster
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int TargetUserID { get; set; }

        public int LastRight { get; set; }

        public int MasterRight { get; set; }

        [Required]
        [StringLength(15)]
        public string ClientIP { get; set; }
    }
}
