namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("eCshopLog")]
    public partial class eCshopLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string LogonPass { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int? ReelCount { get; set; }

        public long? Score { get; set; }
    }
}
