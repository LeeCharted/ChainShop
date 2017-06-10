namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cls_Log
    {
        public int id { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string Game { get; set; }

        public DateTime? ClsDate { get; set; }

        public int? Score { get; set; }
    }
}
