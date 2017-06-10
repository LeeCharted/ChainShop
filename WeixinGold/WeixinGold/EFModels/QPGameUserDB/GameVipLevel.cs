namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameVipLevel")]
    public partial class GameVipLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VipID { get; set; }

        public int GoldValue { get; set; }

        public int Gift1Type { get; set; }

        public int Gift1ID { get; set; }

        public int Gift1Count { get; set; }

        [StringLength(50)]
        public string Gift1Note { get; set; }

        [StringLength(50)]
        public string Gift1ResName { get; set; }

        public int Gift2Type { get; set; }

        public int Gift2ID { get; set; }

        public int Gift2Count { get; set; }

        [StringLength(50)]
        public string Gift2Note { get; set; }

        [StringLength(50)]
        public string Gift2ResName { get; set; }

        public int ExchangeGold { get; set; }

        public long ExchangeValue { get; set; }
    }
}
