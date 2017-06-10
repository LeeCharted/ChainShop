namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PassWordList")]
    public partial class PassWordList
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Passw { get; set; }

        [StringLength(50)]
        public string Passd { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string TelMail { get; set; }

        [StringLength(800)]
        public string Txt { get; set; }

        public int? IsCut { get; set; }

        public DateTime? SSDate { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(500)]
        public string PassWord2 { get; set; }
    }
}
