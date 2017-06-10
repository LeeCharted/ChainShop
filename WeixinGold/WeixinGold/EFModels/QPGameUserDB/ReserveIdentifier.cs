namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReserveIdentifier")]
    public partial class ReserveIdentifier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        public int IDLevel { get; set; }

        public bool Distribute { get; set; }

        public long? Score { get; set; }

        public int? typeId { get; set; }

        public int? sellerPrice { get; set; }
    }
}
