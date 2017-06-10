namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wxGold")]
    public partial class wxGold
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int typeid { get; set; }

        public int GoldName { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Ip { get; set; }
    }
}
