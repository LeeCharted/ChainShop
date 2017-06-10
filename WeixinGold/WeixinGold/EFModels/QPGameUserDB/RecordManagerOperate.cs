namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordManagerOperate")]
    public partial class RecordManagerOperate
    {
        [Key]
        public int RecordID { get; set; }

        [Required]
        [StringLength(64)]
        public string GameID { get; set; }

        public int UserID { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }

        public int TableID { get; set; }

        public int ChairID { get; set; }

        public int UserRight { get; set; }

        public bool IsUserGlobal { get; set; }

        public int MasterRight { get; set; }

        public bool IsMasterGlobal { get; set; }

        public int CtrlOrder { get; set; }

        public int CtrlType { get; set; }

        public int CtrlResult { get; set; }

        public DateTime CollectDate { get; set; }

        [Required]
        [StringLength(15)]
        public string ClientIP { get; set; }

        [StringLength(50)]
        public string Note { get; set; }
    }
}
