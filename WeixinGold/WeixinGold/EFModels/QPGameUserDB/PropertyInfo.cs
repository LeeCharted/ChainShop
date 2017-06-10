namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyInfo")]
    public partial class PropertyInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        [StringLength(50)]
        public string PropInfo { get; set; }

        public int? PropPrice { get; set; }

        public int? GlamourAorS { get; set; }

        [StringLength(31)]
        public string SendNickName { get; set; }

        public int? SendGameID { get; set; }

        public int? SendUserID { get; set; }

        public int? RecvUserID { get; set; }

        public int? RecvGameID { get; set; }

        [StringLength(31)]
        public string RecvNickName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KindID { get; set; }

        [StringLength(32)]
        public string KindName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServerID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string ServerName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BeforeScore { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AfterScore { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BeforeLoveliness { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AfterLoveliness { get; set; }

        public DateTime? UsePropDate { get; set; }

        [StringLength(31)]
        public string SendAccounts { get; set; }

        [StringLength(31)]
        public string RecvAccounts { get; set; }
    }
}
