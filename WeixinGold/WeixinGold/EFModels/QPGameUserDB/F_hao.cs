namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F_hao
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string NickName { get; set; }

        public int? F_why { get; set; }

        public DateTime? EndTime { get; set; }

        public int? ID { get; set; }

        [StringLength(50)]
        public string Why { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? adminid { get; set; }
    }
}
