namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class userMesLandtaskMes
    {
        public int? UserID { get; set; }

        public int? GameID { get; set; }

        [StringLength(31)]
        public string Accounts { get; set; }

        [StringLength(31)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int missionid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userTaskId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskData { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CollectDate { get; set; }

        public int? ID { get; set; }

        public int? KindID { get; set; }

        public int? TaskID { get; set; }

        public int? f { get; set; }

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

        [StringLength(32)]
        public string KindName { get; set; }
    }
}
