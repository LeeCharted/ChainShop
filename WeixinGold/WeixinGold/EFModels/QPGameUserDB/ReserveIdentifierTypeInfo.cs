namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReserveIdentifierTypeInfo")]
    public partial class ReserveIdentifierTypeInfo
    {
        [Key]
        public int typeId { get; set; }

        [Required]
        [StringLength(100)]
        public string typeName { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(3000)]
        public string mark { get; set; }
    }
}
