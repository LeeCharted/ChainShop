namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemStreamInfo")]
    public partial class SystemStreamInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DateID { get; set; }

        public int WebLogonSuccess { get; set; }

        public int WebRegisterSuccess { get; set; }

        public int GameLogonSuccess { get; set; }

        public int GameRegisterSuccess { get; set; }

        public DateTime CollectDate { get; set; }
    }
}
