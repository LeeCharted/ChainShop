namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RrcordWechatBind")]
    public partial class RrcordWechatBind
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        public int Type { get; set; }

        [Required]
        [StringLength(50)]
        public string WechatID { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
