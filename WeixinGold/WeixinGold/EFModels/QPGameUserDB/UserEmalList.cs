namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEmalList")]
    public partial class UserEmalList
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? EmaID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? IsRead { get; set; }

        public int? Is_LinQun { get; set; }
    }
}
