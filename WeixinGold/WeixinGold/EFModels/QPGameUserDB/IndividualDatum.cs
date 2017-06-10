namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualDatum")]
    public partial class IndividualDatum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(16)]
        public string Compellation { get; set; }

        [StringLength(16)]
        public string QQ { get; set; }

        [StringLength(32)]
        public string EMail { get; set; }

        [StringLength(32)]
        public string SeatPhone { get; set; }

        [StringLength(16)]
        public string MobilePhone { get; set; }

        [StringLength(128)]
        public string DwellingPlace { get; set; }

        [StringLength(8)]
        public string PostalCode { get; set; }

        public DateTime CollectDate { get; set; }

        [Required]
        [StringLength(256)]
        public string UserNote { get; set; }

        [StringLength(20)]
        public string Usersfz { get; set; }

        public int BindPhone { get; set; }

        [StringLength(7)]
        public string CheckNum { get; set; }

        public DateTime? CheckDate { get; set; }

        public int? Is_Receive { get; set; }

        public int? F_why { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(200)]
        public string WeiXinID { get; set; }

        [StringLength(200)]
        public string MouthAddress { get; set; }
    }
}
