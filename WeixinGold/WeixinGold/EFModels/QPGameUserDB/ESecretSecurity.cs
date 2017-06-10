namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESecretSecurity")]
    public partial class ESecretSecurity
    {
        [Key]
        public int ProtectID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string serial_Number { get; set; }

        [Required]
        public string Password_protect { get; set; }

        public int validate { get; set; }

        [Column(TypeName = "ntext")]
        public string remarks { get; set; }
    }
}
