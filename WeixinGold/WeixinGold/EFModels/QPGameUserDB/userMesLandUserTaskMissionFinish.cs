namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userMesLandUserTaskMissionFinish")]
    public partial class userMesLandUserTaskMissionFinish
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int finishid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int finishTaskID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int finishtaskCount { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CollectDate { get; set; }

        public int? ID { get; set; }

        public int? KindID { get; set; }

        public int? TaskID { get; set; }

        public int? TaskDate { get; set; }

        public bool? TaskPause { get; set; }

        public int? PrizeCount { get; set; }

        public int? PrizeType { get; set; }

        public int? TaskCount { get; set; }

        [StringLength(125)]
        public string TaskName { get; set; }

        public int? TaskGrade { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        [StringLength(50)]
        public string taskinfoName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OriReelCount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OriPrizeCount { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServerID { get; set; }

        [StringLength(32)]
        public string KindName { get; set; }

        [StringLength(32)]
        public string ServerName { get; set; }

        [StringLength(32)]
        public string NodeName { get; set; }

        public int? GameID { get; set; }

        [StringLength(31)]
        public string Accounts { get; set; }

        [StringLength(31)]
        public string NickName { get; set; }
    }
}
