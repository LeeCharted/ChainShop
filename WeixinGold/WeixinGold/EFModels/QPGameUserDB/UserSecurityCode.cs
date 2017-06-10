namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSecurityCode")]
    public partial class UserSecurityCode
    {
        [Key]
        public int Record { get; set; }

        public int UserID { get; set; }

        public int CodeType { get; set; }

        [Required]
        [StringLength(16)]
        public string MobilePhone { get; set; }

        [Required]
        [StringLength(7)]
        public string SecurityCde { get; set; }

        public DateTime StartDate { get; set; }
    }
}
