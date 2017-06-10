namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfineMachine")]
    public partial class ConfineMachine
    {
        [Key]
        [StringLength(32)]
        public string MachineSerial { get; set; }

        public bool EnjoinLogon { get; set; }

        public bool EnjoinRegister { get; set; }

        public DateTime EnjoinOverDate { get; set; }

        public DateTime CollectDate { get; set; }

        [Required]
        [StringLength(32)]
        public string CollectNote { get; set; }
    }
}
