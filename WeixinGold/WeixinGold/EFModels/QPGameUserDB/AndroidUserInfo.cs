namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AndroidUserInfo")]
    public partial class AndroidUserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public bool Nullity { get; set; }

        public bool Used { get; set; }

        public int KindID { get; set; }

        public int ServerID { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(32)]
        public string AndroidNote { get; set; }
    }
}
