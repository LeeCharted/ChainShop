namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordBuyBill")]
    public partial class RecordBuyBill
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public short TypeID { get; set; }

        public int BuyCount { get; set; }

        public DateTime BuyDate { get; set; }

        [StringLength(16)]
        public string PhoneNumber { get; set; }

        public int? AdminID { get; set; }

        public DateTime? AdminDate { get; set; }

        public int RecordState { get; set; }

        public long? BeginFare { get; set; }

        public long? EndFare { get; set; }

        public long? BeginSilver { get; set; }

        public long? EndSilver { get; set; }

        public string ChuliInfo { get; set; }
    }
}
