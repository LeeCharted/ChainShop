namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserUpLeval")]
    public partial class UserUpLeval
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(31)]
        public string Accounts { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelID { get; set; }

        public long? OriginalScore { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Score { get; set; }

        public long? AfterScore { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CollectDate { get; set; }

        public long? SpreaderScore { get; set; }

        public DateTime? SpreaderDate { get; set; }

        public long? OriginalSpreaderScore { get; set; }

        public int? SpreaderID { get; set; }

        public long? AfterSpreaderScore { get; set; }
    }
}
