namespace WeixinGold.EFModels.QPGameUserDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QPGameUserDB : DbContext
    {
        public QPGameUserDB()
            : base("name=QPGameUserDB")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AccountsInfo> AccountsInfo { get; set; }
        public virtual DbSet<AndroidUserInfo> AndroidUserInfo { get; set; }
        public virtual DbSet<BindedPhone> BindedPhone { get; set; }
        public virtual DbSet<CheckLogon> CheckLogon { get; set; }
        public virtual DbSet<Cls_Log> Cls_Log { get; set; }
        public virtual DbSet<ConfineAddress> ConfineAddress { get; set; }
        public virtual DbSet<ConfineContent> ConfineContent { get; set; }
        public virtual DbSet<ConfineMachine> ConfineMachine { get; set; }
        public virtual DbSet<CustomFace> CustomFace { get; set; }
        public virtual DbSet<CustomFaceInfo> CustomFaceInfo { get; set; }
        public virtual DbSet<EmailList> EmailList { get; set; }
        public virtual DbSet<EnterRoomNoLimitRecord> EnterRoomNoLimitRecord { get; set; }
        public virtual DbSet<ESecretSecurity> ESecretSecurity { get; set; }
        public virtual DbSet<ExchangeExpList> ExchangeExpList { get; set; }
        public virtual DbSet<GameBoxKey> GameBoxKey { get; set; }
        public virtual DbSet<GameBoxPrize> GameBoxPrize { get; set; }
        public virtual DbSet<GameCharacters> GameCharacters { get; set; }
        public virtual DbSet<GameConfig> GameConfig { get; set; }
        public virtual DbSet<GameIdentifier> GameIdentifier { get; set; }
        public virtual DbSet<GameLimitInit> GameLimitInit { get; set; }
        public virtual DbSet<GameLimitWave> GameLimitWave { get; set; }
        public virtual DbSet<GameMission> GameMission { get; set; }
        public virtual DbSet<GameTaskType> GameTaskType { get; set; }
        public virtual DbSet<GameVipGift> GameVipGift { get; set; }
        public virtual DbSet<GameVipLevel> GameVipLevel { get; set; }
        public virtual DbSet<IndividualDatum> IndividualDatum { get; set; }
        public virtual DbSet<LevelGiftCate> LevelGiftCate { get; set; }
        public virtual DbSet<LevelResources> LevelResources { get; set; }
        public virtual DbSet<LimitEnterRoom> LimitEnterRoom { get; set; }
        public virtual DbSet<MallInfo> MallInfo { get; set; }
        public virtual DbSet<MemberInfo> MemberInfo { get; set; }
        public virtual DbSet<MissionFinish> MissionFinish { get; set; }
        public virtual DbSet<ModifyInsure> ModifyInsure { get; set; }
        public virtual DbSet<OnlineReward> OnlineReward { get; set; }
        public virtual DbSet<PassWordList> PassWordList { get; set; }
        public virtual DbSet<PrizeInfo> PrizeInfo { get; set; }
        public virtual DbSet<PropInfo> PropInfo { get; set; }
        public virtual DbSet<RecordAccountSMS> RecordAccountSMS { get; set; }
        public virtual DbSet<RecordBoxPrize> RecordBoxPrize { get; set; }
        public virtual DbSet<RecordBuyBill> RecordBuyBill { get; set; }
        public virtual DbSet<RecordExchangeExp> RecordExchangeExp { get; set; }
        public virtual DbSet<RecordGameVipDraw> RecordGameVipDraw { get; set; }
        public virtual DbSet<RecordGetUserRight> RecordGetUserRight { get; set; }
        public virtual DbSet<RecordLevelDraw> RecordLevelDraw { get; set; }
        public virtual DbSet<RecordLogonError> RecordLogonError { get; set; }
        public virtual DbSet<RecordLogonMall> RecordLogonMall { get; set; }
        public virtual DbSet<RecordMall> RecordMall { get; set; }
        public virtual DbSet<RecordManagerOperate> RecordManagerOperate { get; set; }
        public virtual DbSet<RecordModifyMaster> RecordModifyMaster { get; set; }
        public virtual DbSet<RecordOnlineReward> RecordOnlineReward { get; set; }
        public virtual DbSet<RecordOperatorTask> RecordOperatorTask { get; set; }
        public virtual DbSet<RecordRussianRoulette> RecordRussianRoulette { get; set; }
        public virtual DbSet<RecordSignup> RecordSignup { get; set; }
        public virtual DbSet<RecordTask> RecordTask { get; set; }
        public virtual DbSet<RecordUseProp> RecordUseProp { get; set; }
        public virtual DbSet<RecordUserActive> RecordUserActive { get; set; }
        public virtual DbSet<RecordUserEnter> RecordUserEnter { get; set; }
        public virtual DbSet<RecordUserLeave> RecordUserLeave { get; set; }
        public virtual DbSet<ReserveIdentifier> ReserveIdentifier { get; set; }
        public virtual DbSet<ReserveIdentifierTypeInfo> ReserveIdentifierTypeInfo { get; set; }
        public virtual DbSet<RrcordWechatBind> RrcordWechatBind { get; set; }
        public virtual DbSet<RussianRoulette> RussianRoulette { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SystemStreamInfo> SystemStreamInfo { get; set; }
        public virtual DbSet<TaskInfo> TaskInfo { get; set; }
        public virtual DbSet<TaskList> TaskList { get; set; }
        public virtual DbSet<TaskSchedule> TaskSchedule { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<UserCharacters> UserCharacters { get; set; }
        public virtual DbSet<UserClothes> UserClothes { get; set; }
        public virtual DbSet<UserEmalList> UserEmalList { get; set; }
        public virtual DbSet<UserOnline> UserOnline { get; set; }
        public virtual DbSet<UserSecurityCode> UserSecurityCode { get; set; }
        public virtual DbSet<UserTaskFinish> UserTaskFinish { get; set; }
        public virtual DbSet<UserTaskSystem> UserTaskSystem { get; set; }
        public virtual DbSet<wxGold> wxGold { get; set; }
        public virtual DbSet<AppURL> AppURL { get; set; }
        public virtual DbSet<GameClothes> GameClothes { get; set; }
        public virtual DbSet<GameTaskSystem> GameTaskSystem { get; set; }
        public virtual DbSet<admin_RecordManagerOperate> admin_RecordManagerOperate { get; set; }
        public virtual DbSet<AndroidList> AndroidList { get; set; }
        public virtual DbSet<ChouJiangInfo> ChouJiangInfo { get; set; }
        public virtual DbSet<eCshopLog> eCshopLog { get; set; }
        public virtual DbSet<EmailLists> EmailLists { get; set; }
        public virtual DbSet<F_hao> F_hao { get; set; }
        public virtual DbSet<GetUserVipList> GetUserVipList { get; set; }
        public virtual DbSet<ImmortalView> ImmortalView { get; set; }
        public virtual DbSet<LandUserMissionFinish> LandUserMissionFinish { get; set; }
        public virtual DbSet<landUsertaskMes> landUsertaskMes { get; set; }
        public virtual DbSet<LimitAccountList> LimitAccountList { get; set; }
        public virtual DbSet<Matchrecords> Matchrecords { get; set; }
        public virtual DbSet<NewWebUser_Message> NewWebUser_Message { get; set; }
        public virtual DbSet<Phone_Exchange_Record_Infos> Phone_Exchange_Record_Infos { get; set; }
        public virtual DbSet<Phone_Online_reward_Info> Phone_Online_reward_Info { get; set; }
        public virtual DbSet<Phone_turntable_Info> Phone_turntable_Info { get; set; }
        public virtual DbSet<Phone_VIP_Draw_Reward_Info> Phone_VIP_Draw_Reward_Info { get; set; }
        public virtual DbSet<PropertyInfo> PropertyInfo { get; set; }
        public virtual DbSet<RecordBuyBillViews> RecordBuyBillViews { get; set; }
        public virtual DbSet<RecordTaskViews> RecordTaskViews { get; set; }
        public virtual DbSet<RRIdTInfo> RRIdTInfo { get; set; }
        public virtual DbSet<taskMes> taskMes { get; set; }
        public virtual DbSet<UserBindList> UserBindList { get; set; }
        public virtual DbSet<userCheckLogon> userCheckLogon { get; set; }
        public virtual DbSet<userGameHallOnline> userGameHallOnline { get; set; }
        public virtual DbSet<UserLeaveGameList> UserLeaveGameList { get; set; }
        public virtual DbSet<UserLoginGameList> UserLoginGameList { get; set; }
        public virtual DbSet<userLoginIpinfo> userLoginIpinfo { get; set; }
        public virtual DbSet<userMachineInfo> userMachineInfo { get; set; }
        public virtual DbSet<userMesLandtaskMes> userMesLandtaskMes { get; set; }
        public virtual DbSet<userMesLandUserTaskMissionFinish> userMesLandUserTaskMissionFinish { get; set; }
        public virtual DbSet<userRecordLogonError> userRecordLogonError { get; set; }
        public virtual DbSet<UserUpLeval> UserUpLeval { get; set; }
        public virtual DbSet<WebUser_Message> WebUser_Message { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountsInfo>()
                .Property(e => e.LogonPass)
                .IsFixedLength();

            modelBuilder.Entity<AccountsInfo>()
                .Property(e => e.InsurePass)
                .IsFixedLength();

            modelBuilder.Entity<AccountsInfo>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<ConfineMachine>()
                .Property(e => e.MachineSerial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmailList>()
                .Property(e => e.EmalTitle)
                .IsUnicode(false);

            modelBuilder.Entity<EmailList>()
                .Property(e => e.EmalContent)
                .IsUnicode(false);

            modelBuilder.Entity<ESecretSecurity>()
                .Property(e => e.serial_Number)
                .IsUnicode(false);

            modelBuilder.Entity<ESecretSecurity>()
                .Property(e => e.Password_protect)
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeExpList>()
                .Property(e => e.LevelName)
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeExpList>()
                .Property(e => e.LevelImage)
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeExpList>()
                .Property(e => e.BackImage1)
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeExpList>()
                .Property(e => e.BackImage2)
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeExpList>()
                .Property(e => e.BackImage3)
                .IsUnicode(false);

            modelBuilder.Entity<GameBoxKey>()
                .Property(e => e.Pic)
                .IsUnicode(false);

            modelBuilder.Entity<GameBoxPrize>()
                .Property(e => e.PrizeName)
                .IsUnicode(false);

            modelBuilder.Entity<GameBoxPrize>()
                .Property(e => e.PrizeImage)
                .IsUnicode(false);

            modelBuilder.Entity<GameBoxPrize>()
                .Property(e => e.ScoreImage)
                .IsUnicode(false);

            modelBuilder.Entity<GameBoxPrize>()
                .Property(e => e.IcoImage)
                .IsUnicode(false);

            modelBuilder.Entity<LevelResources>()
                .Property(e => e.BackImage)
                .IsUnicode(false);

            modelBuilder.Entity<LevelResources>()
                .Property(e => e.ScoreImage)
                .IsUnicode(false);

            modelBuilder.Entity<LevelResources>()
                .Property(e => e.IcoImage)
                .IsUnicode(false);

            modelBuilder.Entity<PrizeInfo>()
                .Property(e => e.PrizeName)
                .IsUnicode(false);

            modelBuilder.Entity<PrizeInfo>()
                .Property(e => e.PrizeImageAdd)
                .IsUnicode(false);

            modelBuilder.Entity<RecordLogonError>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<RecordOnlineReward>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<RecordRussianRoulette>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<RecordUserEnter>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<RecordUserLeave>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<ReserveIdentifierTypeInfo>()
                .Property(e => e.typeName)
                .IsUnicode(false);

            modelBuilder.Entity<ReserveIdentifierTypeInfo>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<UserOnline>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<admin_RecordManagerOperate>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<ChouJiangInfo>()
                .Property(e => e.PrizeName)
                .IsUnicode(false);

            modelBuilder.Entity<eCshopLog>()
                .Property(e => e.LogonPass)
                .IsFixedLength();

            modelBuilder.Entity<EmailLists>()
                .Property(e => e.EmalTitle)
                .IsUnicode(false);

            modelBuilder.Entity<EmailLists>()
                .Property(e => e.EmalContent)
                .IsUnicode(false);

            modelBuilder.Entity<GetUserVipList>()
                .Property(e => e.LevelName)
                .IsUnicode(false);

            modelBuilder.Entity<NewWebUser_Message>()
                .Property(e => e.LogonPass)
                .IsFixedLength();

            modelBuilder.Entity<NewWebUser_Message>()
                .Property(e => e.InsurePass)
                .IsFixedLength();

            modelBuilder.Entity<NewWebUser_Message>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<NewWebUser_Message>()
                .Property(e => e.MachineSerial2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phone_Online_reward_Info>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<Phone_turntable_Info>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<RecordBuyBillViews>()
                .Property(e => e.AdminName)
                .IsUnicode(false);

            modelBuilder.Entity<RRIdTInfo>()
                .Property(e => e.typeName)
                .IsUnicode(false);

            modelBuilder.Entity<RRIdTInfo>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<userGameHallOnline>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<UserLeaveGameList>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<UserLoginGameList>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<userMachineInfo>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<userMachineInfo>()
                .Property(e => e.MachineSerial2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<userRecordLogonError>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<WebUser_Message>()
                .Property(e => e.LogonPass)
                .IsFixedLength();

            modelBuilder.Entity<WebUser_Message>()
                .Property(e => e.InsurePass)
                .IsFixedLength();

            modelBuilder.Entity<WebUser_Message>()
                .Property(e => e.MachineSerial)
                .IsFixedLength();

            modelBuilder.Entity<WebUser_Message>()
                .Property(e => e.MachineSerial2)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
