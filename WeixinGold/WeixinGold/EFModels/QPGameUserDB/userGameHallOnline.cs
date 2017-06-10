namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userGameHallOnline")]
    public partial class userGameHallOnline
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool OnlineStatus { get; set; }

        [StringLength(31)]
        public string Accounts { get; set; }

        [StringLength(31)]
        public string NickName { get; set; }

        public int? GameID { get; set; }

        [StringLength(32)]
        public string MachineSerial { get; set; }
    }
}
