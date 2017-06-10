namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserBindList")]
    public partial class UserBindList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(16)]
        public string BindMobilePhone { get; set; }

        public DateTime? CollectDate { get; set; }

        public long? PresentScore { get; set; }

        public long? AccountInsureScore { get; set; }

        public int? BindPhone { get; set; }

        [StringLength(16)]
        public string MobilePhone { get; set; }
    }
}
