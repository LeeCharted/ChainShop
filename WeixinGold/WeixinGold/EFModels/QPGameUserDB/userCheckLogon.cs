namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userCheckLogon")]
    public partial class userCheckLogon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogonStatus { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CollectDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? UserID { get; set; }

        public int? GameID { get; set; }

        [StringLength(31)]
        public string NickName { get; set; }
    }
}
