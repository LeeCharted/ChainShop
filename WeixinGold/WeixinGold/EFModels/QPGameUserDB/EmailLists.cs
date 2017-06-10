namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmailLists
    {
        [StringLength(200)]
        public string EmalTitle { get; set; }

        [StringLength(1000)]
        public string EmalContent { get; set; }

        public int? EmalType { get; set; }

        public int? UserID { get; set; }

        public int? EmaID { get; set; }

        public DateTime? CreateDate { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string Accounts { get; set; }

        public int? IsRead { get; set; }

        public int? Is_LinQun { get; set; }

        [StringLength(100)]
        public string F_File { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(31)]
        public string NickName { get; set; }
    }
}
