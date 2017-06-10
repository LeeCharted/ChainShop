namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserOnline")]
    public partial class UserOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public bool OnlineStatus { get; set; }

        [Required]
        [StringLength(15)]
        public string ServerIP { get; set; }

        [Required]
        [StringLength(15)]
        public string LastLogonIP { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }
    }
}
