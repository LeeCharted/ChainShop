namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnterRoomNoLimitRecord")]
    public partial class EnterRoomNoLimitRecord
    {
        [Key]
        public int RecordID { get; set; }

        public int? UserID { get; set; }

        public int? KindID { get; set; }

        public int? ServerID { get; set; }

        public int? NoLimitItem { get; set; }

        public DateTime? CollectDate { get; set; }
    }
}
