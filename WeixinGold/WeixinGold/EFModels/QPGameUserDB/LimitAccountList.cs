namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LimitAccountList")]
    public partial class LimitAccountList
    {
        public int? UserID { get; set; }

        public int? KindID { get; set; }

        public int? ServerID { get; set; }

        public int? NoLimitItem { get; set; }

        public DateTime? CollectDate { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string NickName { get; set; }

        [StringLength(32)]
        public string KindName { get; set; }

        [StringLength(32)]
        public string ServerName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }
    }
}
