namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RRIdTInfo")]
    public partial class RRIdTInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLevel { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Distribute { get; set; }

        public long? Score { get; set; }

        public int? typeId { get; set; }

        [StringLength(100)]
        public string typeName { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(3000)]
        public string mark { get; set; }
    }
}
