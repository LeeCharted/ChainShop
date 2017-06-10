namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecordBuyBillViews
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TypeID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BuyCount { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime BuyDate { get; set; }

        [StringLength(16)]
        public string PhoneNumber { get; set; }

        public int? AdminID { get; set; }

        public DateTime? AdminDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordState { get; set; }

        public long? EndFare { get; set; }

        public long? BeginFare { get; set; }

        public long? EndSilver { get; set; }

        public long? BeginSilver { get; set; }

        [StringLength(100)]
        public string AdminName { get; set; }

        public string ChuliInfo { get; set; }
    }
}
