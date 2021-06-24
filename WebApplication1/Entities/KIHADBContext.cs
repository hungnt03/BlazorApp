using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class KIHADBContext : DbContext
    {
        public KIHADBContext()
        {
        }

        public KIHADBContext(DbContextOptions<KIHADBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BbsBoard> BbsBoards { get; set; }
        public virtual DbSet<BbsTopic> BbsTopics { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Fhc主婦会場別受診予定者数> Fhc主婦会場別受診予定者数s { get; set; }
        public virtual DbSet<Fhc主婦会場別受診予定者数20190806> Fhc主婦会場別受診予定者数20190806s { get; set; }
        public virtual DbSet<HpDownload> HpDownloads { get; set; }
        public virtual DbSet<HpHotnews> HpHotnews { get; set; }
        public virtual DbSet<HpSaiyo> HpSaiyos { get; set; }
        public virtual DbSet<Hp施設予約> Hp施設予約s { get; set; }
        public virtual DbSet<Hp施設予約カレンダー> Hp施設予約カレンダーs { get; set; }
        public virtual DbSet<Hスケジュールt> Hスケジュールts { get; set; }
        public virtual DbSet<Hスケジュール種別mt> Hスケジュール種別mts { get; set; }
        public virtual DbSet<H予約品mt> H予約品mts { get; set; }
        public virtual DbSet<H予約品種別mt> H予約品種別mts { get; set; }
        public virtual DbSet<H支所mt> H支所mts { get; set; }
        public virtual DbSet<H要望依頼content> H要望依頼contents { get; set; }
        public virtual DbSet<H要望依頼mt> H要望依頼mts { get; set; }
        public virtual DbSet<H設備予約t> H設備予約ts { get; set; }
        public virtual DbSet<H設備予約種別mt> H設備予約種別mts { get; set; }
        public virtual DbSet<H部署mt> H部署mts { get; set; }
        public virtual DbSet<JigJc販売> JigJc販売s { get; set; }
        public virtual DbSet<Jig担当一覧閲覧用> Jig担当一覧閲覧用s { get; set; }
        public virtual DbSet<LogonＭシステム> LogonＭシステムs { get; set; }
        public virtual DbSet<LogonＭスタッフ> LogonＭスタッフs { get; set; }
        public virtual DbSet<LogonＴシステム利用> LogonＴシステム利用s { get; set; }
        public virtual DbSet<MenuSystem> MenuSystems { get; set; }
        public virtual DbSet<M全健協接続サーバー管理> M全健協接続サーバー管理s { get; set; }
        public virtual DbSet<Nyusatsu入札> Nyusatsu入札s { get; set; }
        public virtual DbSet<Nyusatsu入札明細> Nyusatsu入札明細s { get; set; }
        public virtual DbSet<PcgrdO> PcgrdOs { get; set; }
        public virtual DbSet<PcgrdT設置場所> PcgrdT設置場所s { get; set; }
        public virtual DbSet<Pcgrdホスト接続形態> Pcgrdホスト接続形態s { get; set; }
        public virtual DbSet<Pcgrd使用状況> Pcgrd使用状況s { get; set; }
        public virtual DbSet<Pcgrd最終更新日> Pcgrd最終更新日s { get; set; }
        public virtual DbSet<Pcgrd機種> Pcgrd機種s { get; set; }
        public virtual DbSet<PdDocument> PdDocuments { get; set; }
        public virtual DbSet<PdJirei> PdJireis { get; set; }
        public virtual DbSet<PdJireiItem> PdJireiItems { get; set; }
        public virtual DbSet<PdJireiTag> PdJireiTags { get; set; }
        public virtual DbSet<PdKisokuKitei> PdKisokuKiteis { get; set; }
        public virtual DbSet<PdTag> PdTags { get; set; }
        public virtual DbSet<PdTagitem> PdTagitems { get; set; }
        public virtual DbSet<Seikyu漢字請求項目> Seikyu漢字請求項目s { get; set; }
        public virtual DbSet<Seikyu請求販売連結用> Seikyu請求販売連結用s { get; set; }
        public virtual DbSet<Seikyu閲覧用2> Seikyu閲覧用2s { get; set; }
        public virtual DbSet<SftMk> SftMks { get; set; }
        public virtual DbSet<SftName> SftNames { get; set; }
        public virtual DbSet<Souken> Soukens { get; set; }
        public virtual DbSet<TelnoCmbFlr> TelnoCmbFlrs { get; set; }
        public virtual DbSet<TelnoCmbSish> TelnoCmbSishes { get; set; }
        public virtual DbSet<TelnoGano> TelnoGanos { get; set; }
        public virtual DbSet<TelnoGanoLb> TelnoGanoLbs { get; set; }
        public virtual DbSet<TelnoPer> TelnoPers { get; set; }
        public virtual DbSet<TelnoPersLb> TelnoPersLbs { get; set; }
        public virtual DbSet<TelnoSect> TelnoSects { get; set; }
        public virtual DbSet<TelnoSectLb> TelnoSectLbs { get; set; }
        public virtual DbSet<Testcalendar> Testcalendars { get; set; }
        public virtual DbSet<TesttelnoPer> TesttelnoPers { get; set; }
        public virtual DbSet<ViewerError管理> ViewerError管理s { get; set; }
        public virtual DbSet<Viewer重要キーワード管理> Viewer重要キーワード管理s { get; set; }
        public virtual DbSet<Vwぐるぐる検索> Vwぐるぐる検索s { get; set; }
        public virtual DbSet<要望依頼> 要望依頼s { get; set; }
        public virtual DbSet<ＶSeikyu黒> ＶSeikyu黒s { get; set; }
        public virtual DbSet<Ｖシステム利用> Ｖシステム利用s { get; set; }
        public virtual DbSet<Ｖシステム利用all> Ｖシステム利用alls { get; set; }
        public virtual DbSet<Ｖパソコン管理> Ｖパソコン管理s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
#if DEBUG
                optionsBuilder.UseSqlServer("Server=L200;Database=KIHADB_TEST;Trusted_Connection=True;");
#else
                optionsBuilder.UseSqlServer("Server=L200;Database=KIHADB;Trusted_Connection=True;");
#endif

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Japanese_CI_AS");

            modelBuilder.Entity<BbsBoard>(entity =>
            {
                entity.HasKey(e => e.BoardId);

                entity.ToTable("BBS_BOARD");

                entity.Property(e => e.BoardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOARD_ID");

                entity.Property(e => e.BoardName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BOARD_NAME");
            });

            modelBuilder.Entity<BbsTopic>(entity =>
            {
                entity.HasKey(e => new { e.BoardId, e.Id });

                entity.ToTable("BBS_Topic");

                entity.Property(e => e.BoardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOARD_ID")
                    .HasDefaultValueSql("(999)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateDel)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date_Del");

                entity.Property(e => e.DateNow)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Now");

                entity.Property(e => e.DateUp)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date_Up");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.BbsTopics)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BBS_Topic_BBS_BOARD");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.FDate);

                entity.ToTable("CALENDAR");

                entity.Property(e => e.FDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("f_date");

                entity.Property(e => e.FFlag)
                    .HasColumnName("f_flag")
                    .HasComment("1;休診日　2;センター特別開催日 3;祝日 4;休診日+祝日 5;センター特別開催日+祝日");
            });

            modelBuilder.Entity<Fhc主婦会場別受診予定者数>(entity =>
            {
                entity.HasKey(e => e.会場ｺｰﾄﾞ);

                entity.ToTable("FHC_主婦会場別受診予定者数");

                entity.Property(e => e.会場ｺｰﾄﾞ).ValueGeneratedNever();

                entity.Property(e => e.Stop).HasColumnName("STOP");

                entity.Property(e => e.乳ｴｺｰ).HasDefaultValueSql("((0))");

                entity.Property(e => e.乳ﾏﾝﾓ1).HasDefaultValueSql("((0))");

                entity.Property(e => e.乳ﾏﾝﾓ1pm)
                    .HasColumnName("乳ﾏﾝﾓ1PM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.乳ﾏﾝﾓ2).HasDefaultValueSql("((0))");

                entity.Property(e => e.乳ﾏﾝﾓ2pm)
                    .HasColumnName("乳ﾏﾝﾓ2PM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.会場no).HasColumnName("会場No");

                entity.Property(e => e.会場名).HasMaxLength(50);

                entity.Property(e => e.健診日).HasColumnType("smalldatetime");

                entity.Property(e => e.備考)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.受診予定者数).HasDefaultValueSql("((0))");

                entity.Property(e => e.基本).HasDefaultValueSql("((0))");

                entity.Property(e => e.子宮医).HasDefaultValueSql("((0))");

                entity.Property(e => e.子宮自).HasDefaultValueSql("((0))");

                entity.Property(e => e.眼底).HasDefaultValueSql("((0))");

                entity.Property(e => e.胃直).HasDefaultValueSql("((0))");

                entity.Property(e => e.胃間).HasDefaultValueSql("((0))");

                entity.Property(e => e.腹囲).HasDefaultValueSql("((0))");

                entity.Property(e => e.腹部).HasDefaultValueSql("((0))");

                entity.Property(e => e.骨).HasDefaultValueSql("((0))");

                entity.Property(e => e.ｵｰｼﾞｵ).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Fhc主婦会場別受診予定者数20190806>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FHC_主婦会場別受診予定者数20190806");

                entity.Property(e => e.Stop).HasColumnName("STOP");

                entity.Property(e => e.乳ﾏﾝﾓ1pm).HasColumnName("乳ﾏﾝﾓ1PM");

                entity.Property(e => e.乳ﾏﾝﾓ2pm).HasColumnName("乳ﾏﾝﾓ2PM");

                entity.Property(e => e.会場no).HasColumnName("会場No");

                entity.Property(e => e.会場名).HasMaxLength(50);

                entity.Property(e => e.健診日).HasColumnType("smalldatetime");

                entity.Property(e => e.備考).HasMaxLength(20);
            });

            modelBuilder.Entity<HpDownload>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("HP_download");

                entity.Property(e => e.FileId)
                    .ValueGeneratedNever()
                    .HasColumnName("file_id");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("delete_date")
                    .HasComment("ファイル削除日");

                entity.Property(e => e.DownloadCount)
                    .HasColumnName("download_count")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DownloadDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("download_date");

                entity.Property(e => e.DownloadMax)
                    .HasColumnName("download_max")
                    .HasDefaultValueSql("(5)");

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.FileComment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("file_comment");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("file_name");

                entity.Property(e => e.FilePassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("file_password");

                entity.Property(e => e.FileSize).HasColumnName("file_size");

                entity.Property(e => e.LogonCount)
                    .HasColumnName("logon_count")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LogonMax)
                    .HasColumnName("logon_max")
                    .HasDefaultValueSql("(50)");

                entity.Property(e => e.LogonUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("logon_user");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail")
                    .HasComment("担当者メールアドレス");

                entity.Property(e => e.TourokuDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("touroku_date")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("ファイル登録日");
            });

            modelBuilder.Entity<HpHotnews>(entity =>
            {
                entity.ToTable("HP_HOTNEWS");

                entity.HasIndex(e => e.DateUp, "IDX_HP_HOTNEWS_SORTER")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateDel)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date_Del");

                entity.Property(e => e.DateNow)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Now")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUp)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date_Up");

                entity.Property(e => e.DateUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Update")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TitleSubText).HasColumnType("ntext");

                entity.Property(e => e.Topic).HasColumnType("ntext");
            });

            modelBuilder.Entity<HpSaiyo>(entity =>
            {
                entity.ToTable("HP_saiyo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DATE");

                entity.Property(e => e.職種グループ1).HasColumnType("text");

                entity.Property(e => e.職種グループ11)
                    .HasColumnType("text")
                    .HasColumnName("職種グループ1_1");

                entity.Property(e => e.職種グループ12)
                    .HasColumnType("text")
                    .HasColumnName("職種グループ1_2");

                entity.Property(e => e.職種グループ13)
                    .HasColumnType("text")
                    .HasColumnName("職種グループ1_3");

                entity.Property(e => e.職種グループ14)
                    .HasColumnType("text")
                    .HasColumnName("職種グループ1_4");

                entity.Property(e => e.見出し文1).HasColumnType("text");

                entity.Property(e => e.項目11)
                    .HasColumnType("text")
                    .HasColumnName("項目1_1");

                entity.Property(e => e.項目11内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_1内容");

                entity.Property(e => e.項目12)
                    .HasColumnType("text")
                    .HasColumnName("項目1_2");

                entity.Property(e => e.項目12内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_2内容");

                entity.Property(e => e.項目13)
                    .HasColumnType("text")
                    .HasColumnName("項目1_3");

                entity.Property(e => e.項目13内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_3内容");

                entity.Property(e => e.項目14)
                    .HasColumnType("text")
                    .HasColumnName("項目1_4");

                entity.Property(e => e.項目14内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_4内容");

                entity.Property(e => e.項目15)
                    .HasColumnType("text")
                    .HasColumnName("項目1_5");

                entity.Property(e => e.項目15内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_5内容");

                entity.Property(e => e.項目16)
                    .HasColumnType("text")
                    .HasColumnName("項目1_6");

                entity.Property(e => e.項目16内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_6内容");

                entity.Property(e => e.項目17)
                    .HasColumnType("text")
                    .HasColumnName("項目1_7");

                entity.Property(e => e.項目17内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_7内容");

                entity.Property(e => e.項目18)
                    .HasColumnType("text")
                    .HasColumnName("項目1_8");

                entity.Property(e => e.項目18内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_8内容");

                entity.Property(e => e.項目19)
                    .HasColumnType("text")
                    .HasColumnName("項目1_9");

                entity.Property(e => e.項目19内容)
                    .HasColumnType("text")
                    .HasColumnName("項目1_9内容");
            });

            modelBuilder.Entity<Hp施設予約>(entity =>
            {
                entity.HasKey(e => e.予約連番);

                entity.ToTable("HP_施設予約");

                entity.Property(e => e.フリガナ)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.メールアドレス)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.事業所名)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.備考)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.所属名)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.日付).HasColumnType("smalldatetime");

                entity.Property(e => e.更新日時)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.氏名)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.連絡先電話番号)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hp施設予約カレンダー>(entity =>
            {
                entity.HasKey(e => new { e.機器コード, e.日付 })
                    .HasName("PK_HP_機器予約");

                entity.ToTable("HP_施設予約カレンダー");

                entity.Property(e => e.日付).HasColumnType("smalldatetime");

                entity.Property(e => e.予約数).HasDefaultValueSql("(0)");

                entity.Property(e => e.日付種別).HasDefaultValueSql("(0)");

                entity.Property(e => e.更新日時)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.枠数).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Hスケジュールt>(entity =>
            {
                entity.ToTable("H_スケジュールT");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.内容).HasMaxLength(50);

                entity.Property(e => e.削除フラグ).HasMaxLength(50);

                entity.Property(e => e.直帰f)
                    .HasMaxLength(50)
                    .HasColumnName("直帰F");

                entity.Property(e => e.直行f)
                    .HasMaxLength(50)
                    .HasColumnName("直行F");

                entity.Property(e => e.種別cd)
                    .HasMaxLength(50)
                    .HasColumnName("種別CD");

                entity.Property(e => e.終了日時).HasColumnType("smalldatetime");

                entity.Property(e => e.職員コード).HasMaxLength(50);

                entity.Property(e => e.詳細).HasMaxLength(255);

                entity.Property(e => e.開始日時).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Hスケジュール種別mt>(entity =>
            {
                entity.HasKey(e => e.種別cd);

                entity.ToTable("H_スケジュール種別MT");

                entity.Property(e => e.種別cd)
                    .HasMaxLength(50)
                    .HasColumnName("種別CD");

                entity.Property(e => e.種別).HasMaxLength(50);
            });

            modelBuilder.Entity<H予約品mt>(entity =>
            {
                entity.HasKey(e => e.予約品id);

                entity.ToTable("H_予約品MT");

                entity.Property(e => e.予約品id)
                    .HasMaxLength(50)
                    .HasColumnName("予約品ID");

                entity.Property(e => e.予約品名).HasMaxLength(50);

                entity.Property(e => e.支所cd)
                    .HasMaxLength(50)
                    .HasColumnName("支所CD");

                entity.Property(e => e.種別cd)
                    .HasMaxLength(50)
                    .HasColumnName("種別CD");
            });

            modelBuilder.Entity<H予約品種別mt>(entity =>
            {
                entity.HasKey(e => e.種別cd);

                entity.ToTable("H_予約品種別MT");

                entity.Property(e => e.種別cd)
                    .HasMaxLength(50)
                    .HasColumnName("種別CD");

                entity.Property(e => e.種別名).HasMaxLength(50);
            });

            modelBuilder.Entity<H支所mt>(entity =>
            {
                entity.HasKey(e => e.支所cd);

                entity.ToTable("H_支所MT");

                entity.Property(e => e.支所cd)
                    .HasMaxLength(50)
                    .HasColumnName("支所CD");

                entity.Property(e => e.支所名).HasMaxLength(50);
            });

            modelBuilder.Entity<H要望依頼content>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("H_要望依頼Content");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.ContentHtml).HasColumnType("ntext");
            });

            modelBuilder.Entity<H要望依頼mt>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Id })
                    .HasName("PK_M_要望依頼");

                entity.ToTable("H_要望依頼MT");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Info).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<H設備予約t>(entity =>
            {
                entity.ToTable("H_設備予約T");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.キャンセルフラグ).HasMaxLength(1);

                entity.Property(e => e.予約品id)
                    .HasMaxLength(50)
                    .HasColumnName("予約品ID");

                entity.Property(e => e.更新日時).HasColumnType("smalldatetime");

                entity.Property(e => e.種別cd)
                    .HasMaxLength(50)
                    .HasColumnName("種別CD");

                entity.Property(e => e.終了日時).HasColumnType("smalldatetime");

                entity.Property(e => e.職員コード).HasMaxLength(50);

                entity.Property(e => e.詳細).HasMaxLength(50);

                entity.Property(e => e.開始日時).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<H設備予約種別mt>(entity =>
            {
                entity.HasKey(e => e.種別cd);

                entity.ToTable("H_設備予約種別MT");

                entity.Property(e => e.種別cd)
                    .HasMaxLength(50)
                    .HasColumnName("種別CD");

                entity.Property(e => e.種別).HasMaxLength(50);
            });

            modelBuilder.Entity<H部署mt>(entity =>
            {
                entity.HasKey(e => e.部署);

                entity.ToTable("H_部署MT");

                entity.Property(e => e.部署).HasMaxLength(50);

                entity.Property(e => e.部署名).HasMaxLength(50);
            });

            modelBuilder.Entity<JigJc販売>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JIG_JC販売");

                entity.Property(e => e.その他).HasMaxLength(50);

                entity.Property(e => e.事業場コード).HasMaxLength(6);

                entity.Property(e => e.住所上段).HasMaxLength(255);

                entity.Property(e => e.住所下段).HasMaxLength(255);

                entity.Property(e => e.健診実施事業場名)
                    .HasMaxLength(255)
                    .HasColumnName("健診実施 ： 事業場名");

                entity.Property(e => e.受注担当者名).HasMaxLength(255);

                entity.Property(e => e.得意先主コード).HasMaxLength(255);

                entity.Property(e => e.得意先補助コード).HasMaxLength(50);

                entity.Property(e => e.得意先ｺｰﾄﾞ).HasMaxLength(255);

                entity.Property(e => e.正式名称).HasMaxLength(255);

                entity.Property(e => e.簡略名称).HasMaxLength(255);

                entity.Property(e => e.請求先事業場名)
                    .HasMaxLength(255)
                    .HasColumnName("請求先 ： 事業場名");

                entity.Property(e => e.連想).HasMaxLength(255);

                entity.Property(e => e.郵便番号１).HasMaxLength(8);

                entity.Property(e => e.Ｆｄ).HasColumnName("ＦＤ");
            });

            modelBuilder.Entity<Jig担当一覧閲覧用>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JIG_担当一覧閲覧用");

                entity.HasIndex(e => e.Hmp, "IX_JIG_担当一覧閲覧用_HMP")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.カナ事業場名, "IX_JIG_担当一覧閲覧用_カナ事業場名")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.上位事業場コード, "IX_JIG_担当一覧閲覧用_上位事業場コード")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.事業場コード, "IX_JIG_担当一覧閲覧用_事業場コード")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.事業場名, "IX_JIG_担当一覧閲覧用_事業場名")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.親事業場コード, "IX_JIG_担当一覧閲覧用_親事業場コード")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Hma2)
                    .HasMaxLength(10)
                    .HasColumnName("HMA2");

                entity.Property(e => e.Hma１)
                    .HasMaxLength(10)
                    .HasColumnName("HMA１");

                entity.Property(e => e.Hmp)
                    .HasMaxLength(10)
                    .HasColumnName("HMP");

                entity.Property(e => e.Ocr等)
                    .HasMaxLength(255)
                    .HasColumnName("OCR等");

                entity.Property(e => e.Y0).HasMaxLength(255);

                entity.Property(e => e.Y1).HasMaxLength(255);

                entity.Property(e => e.Y2).HasMaxLength(255);

                entity.Property(e => e.Y3).HasMaxLength(255);

                entity.Property(e => e.Y4).HasMaxLength(255);

                entity.Property(e => e._07年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("07年度区分");

                entity.Property(e => e._08年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("08年度区分");

                entity.Property(e => e._09年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("09年度区分");

                entity.Property(e => e._10年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("10年度区分");

                entity.Property(e => e._11年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("11年度区分");

                entity.Property(e => e._12年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("12年度区分");

                entity.Property(e => e._13年度区分)
                    .HasMaxLength(255)
                    .HasColumnName("13年度区分");

                entity.Property(e => e.カナ事業場名).HasMaxLength(255);

                entity.Property(e => e.センターフロア).HasMaxLength(100);

                entity.Property(e => e.センター担当).HasMaxLength(100);

                entity.Property(e => e.ファックス).HasMaxLength(20);

                entity.Property(e => e.一部負担金).HasMaxLength(100);

                entity.Property(e => e.上位事業場コード).HasMaxLength(6);

                entity.Property(e => e.事業場コード)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.事業場名).HasMaxLength(255);

                entity.Property(e => e.他1).HasMaxLength(255);

                entity.Property(e => e.会員種別).HasMaxLength(100);

                entity.Property(e => e.住所).HasMaxLength(255);

                entity.Property(e => e.健保協同組合)
                    .HasMaxLength(100)
                    .HasColumnName("健保・協同組合");

                entity.Property(e => e.健診実施備考).HasMaxLength(255);

                entity.Property(e => e.健診課担当者).HasMaxLength(10);

                entity.Property(e => e.地区コード).HasMaxLength(7);

                entity.Property(e => e.政管番号).HasMaxLength(8);

                entity.Property(e => e.政管記号).HasMaxLength(12);

                entity.Property(e => e.産業分類).HasMaxLength(3);

                entity.Property(e => e.産業医).HasMaxLength(1);

                entity.Property(e => e.産業医名).HasMaxLength(100);

                entity.Property(e => e.看護師担当).HasMaxLength(100);

                entity.Property(e => e.職員担当者).HasMaxLength(100);

                entity.Property(e => e.親事業場コード).HasMaxLength(6);

                entity.Property(e => e.郵便番号).HasMaxLength(12);

                entity.Property(e => e.電話番号).HasMaxLength(20);
            });

            modelBuilder.Entity<LogonＭシステム>(entity =>
            {
                entity.HasKey(e => e.システムid);

                entity.ToTable("LOGON_Ｍシステム");

                entity.Property(e => e.システムid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("システムID");

                entity.Property(e => e.システム名称)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.許可既定値)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<LogonＭスタッフ>(entity =>
            {
                entity.HasKey(e => e.ログオン名);

                entity.ToTable("LOGON_Ｍスタッフ");

                entity.HasIndex(e => e.カナ氏名, "IX_LOGON_Ｍスタッフ_カナ氏名")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.パソコン, "IX_LOGON_Ｍスタッフ_パソコン")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.メール, "IX_LOGON_Ｍスタッフ_メール")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.ログオン名, "IX_LOGON_Ｍスタッフ_ログオン名")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.漢字氏名, "IX_LOGON_Ｍスタッフ_漢字氏名")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.職員コード, "IX_LOGON_Ｍスタッフ_職員コード")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.部署, "IX_LOGON_Ｍスタッフ_部署")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ログオン名)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.カナ氏名)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.パソコン)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.メール)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.対象外).HasDefaultValueSql("((0))");

                entity.Property(e => e.更新日時)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.漢字氏名)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.職員コード)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("職員コード（これだけでも、KEYになるが、基本的には現在ログオン用なので、KEYにはしていない）");

                entity.Property(e => e.課)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.部)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.部署)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("部署コード");
            });

            modelBuilder.Entity<LogonＴシステム利用>(entity =>
            {
                entity.HasKey(e => new { e.ログオン名, e.システムid });

                entity.ToTable("LOGON_Ｔシステム利用");

                entity.HasIndex(e => e.システムid, "IX_LOGON_Ｔシステム利用_システムID")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.ログオン名, "IX_LOGON_Ｔシステム利用_ログオン名")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ログオン名)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.システムid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("システムID");

                entity.Property(e => e.使用フラグ)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.HasOne(d => d.システム)
                    .WithMany(p => p.LogonＴシステム利用s)
                    .HasForeignKey(d => d.システムid)
                    .HasConstraintName("FK_LOGON_Ｔシステム利用_LOGON_Ｍシステム");

                entity.HasOne(d => d.ログオン名Navigation)
                    .WithMany(p => p.LogonＴシステム利用s)
                    .HasForeignKey(d => d.ログオン名)
                    .HasConstraintName("FK_LOGON_Ｔシステム利用_LOGON_Ｍスタッフ");
            });

            modelBuilder.Entity<MenuSystem>(entity =>
            {
                entity.HasKey(e => e.Nodeno);

                entity.ToTable("MENU_SYSTEM");

                entity.HasIndex(e => new { e.ParentNodeno, e.表示順 }, "IX_MENU_SYSTEM")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ParentNodeno, e.Nodeno }, "IX_MENU_SYSTEM_1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ParentNodeno, e.Nodeno, e.システムid }, "IX_MENU_SYSTEM_2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ParentNodeno, e.Nodeno, e.表示順 }, "IX_MENU_SYSTEM_3")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Nodeno)
                    .ValueGeneratedNever()
                    .HasColumnName("NODENO")
                    .HasComment("ノード番号");

                entity.Property(e => e.ParentNodeno)
                    .HasColumnName("PARENT_NODENO")
                    .HasComment("親ノード番号");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.UrlImage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("URL_IMAGE");

                entity.Property(e => e.UrlTarget)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("URL_TARGET");

                entity.Property(e => e.システムid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("システムID");

                entity.Property(e => e.表示名称)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.表示順).HasComment("全体的並び順　ノードは関係なし");
            });

            modelBuilder.Entity<M全健協接続サーバー管理>(entity =>
            {
                entity.HasKey(e => e.システムid);

                entity.ToTable("M_全健協接続サーバー管理");

                entity.Property(e => e.システムid)
                    .HasMaxLength(10)
                    .HasColumnName("システムID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.サーバー名)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.備考)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.全健協機関コード).HasMaxLength(5);
            });

            modelBuilder.Entity<Nyusatsu入札>(entity =>
            {
                entity.HasKey(e => e.入札ｋｅｙ);

                entity.ToTable("NYUSATSU_入札");

                entity.HasIndex(e => e.入札コード, "IX_NYUSATSU_入札")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.担当者, "IX_NYUSATSU_入札_1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.入札ｋｅｙ)
                    .ValueGeneratedNever()
                    .HasColumnName("入札ＫＥＹ");

                entity.Property(e => e.データ更新日).HasColumnType("smalldatetime");

                entity.Property(e => e.データ更新者)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.入札コード)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.入札件名)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.入札件名フリガナ)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.入札時期).HasColumnType("smalldatetime");

                entity.Property(e => e.入札金額).HasColumnType("money");

                entity.Property(e => e.前年入札ｋｅｙ)
                    .HasColumnName("前年入札ＫＥＹ")
                    .HasComment("前年度実施　入札ＫＥＹをセット");

                entity.Property(e => e.品目)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.担当者)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.有効期限).HasColumnType("smalldatetime");

                entity.Property(e => e.登録日).HasColumnType("smalldatetime");

                entity.Property(e => e.落札機関)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.落札金額).HasColumnType("money");

                entity.Property(e => e.行政件名)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nyusatsu入札明細>(entity =>
            {
                entity.HasKey(e => new { e.入札ｋｅｙ, e.入札明細番号 });

                entity.ToTable("NYUSATSU_入札明細");

                entity.Property(e => e.入札ｋｅｙ).HasColumnName("入札ＫＥＹ");

                entity.Property(e => e.品目)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.金額).HasColumnType("money");

                entity.HasOne(d => d.入札ｋｅｙNavigation)
                    .WithMany(p => p.Nyusatsu入札明細s)
                    .HasForeignKey(d => d.入札ｋｅｙ)
                    .HasConstraintName("FK_NYUSATSU_入札明細_NYUSATSU_入札");
            });

            modelBuilder.Entity<PcgrdO>(entity =>
            {
                entity.HasKey(e => e.Osid);

                entity.ToTable("PCgrd_OS");

                entity.Property(e => e.Osid)
                    .HasMaxLength(50)
                    .HasColumnName("OSID");

                entity.Property(e => e.Os名)
                    .HasMaxLength(50)
                    .HasColumnName("OS名");
            });

            modelBuilder.Entity<PcgrdT設置場所>(entity =>
            {
                entity.HasKey(e => e.場所id);

                entity.ToTable("PCgrd_T_設置場所");

                entity.Property(e => e.場所id)
                    .HasMaxLength(50)
                    .HasColumnName("場所ID");

                entity.Property(e => e.場所名).HasMaxLength(50);
            });

            modelBuilder.Entity<Pcgrdホスト接続形態>(entity =>
            {
                entity.ToTable("PCgrd_ホスト接続形態");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.形態).HasMaxLength(50);
            });

            modelBuilder.Entity<Pcgrd使用状況>(entity =>
            {
                entity.HasKey(e => e.通番);

                entity.ToTable("PCgrd_使用状況");

                entity.Property(e => e.通番).HasMaxLength(255);

                entity.Property(e => e.Apsプリンタ)
                    .HasMaxLength(255)
                    .HasColumnName("APSプリンタ");

                entity.Property(e => e.Macアドレス)
                    .HasMaxLength(255)
                    .HasColumnName("MACアドレス");

                entity.Property(e => e.クラス).HasMaxLength(255);

                entity.Property(e => e.プリンタグループ).HasMaxLength(255);

                entity.Property(e => e.ホスト接続形態).HasMaxLength(255);

                entity.Property(e => e.備考).HasMaxLength(255);

                entity.Property(e => e.接続プリンタ).HasMaxLength(255);

                entity.Property(e => e.用途).HasMaxLength(255);

                entity.Property(e => e.管理者１).HasMaxLength(50);

                entity.Property(e => e.管理者２).HasMaxLength(50);

                entity.Property(e => e.設置場所).HasMaxLength(255);

                entity.Property(e => e.設置場所詳細).HasMaxLength(255);

                entity.Property(e => e.購入年月日).HasMaxLength(50);

                entity.Property(e => e.Ｏｓ)
                    .HasMaxLength(255)
                    .HasColumnName("ＯＳ");
            });

            modelBuilder.Entity<Pcgrd最終更新日>(entity =>
            {
                entity.ToTable("PCgrd_最終更新日");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.更新日).HasMaxLength(50);
            });

            modelBuilder.Entity<Pcgrd機種>(entity =>
            {
                entity.HasKey(e => e.通番);

                entity.ToTable("PCgrd_機種");

                entity.Property(e => e.通番).HasMaxLength(255);

                entity.Property(e => e.コンピューター名).HasMaxLength(255);

                entity.Property(e => e.型番１).HasMaxLength(255);

                entity.Property(e => e.型番２).HasMaxLength(255);

                entity.Property(e => e.機種名).HasMaxLength(255);

                entity.Property(e => e.端末ｉｄ)
                    .HasMaxLength(255)
                    .HasColumnName("端末ＩＤ");
            });

            modelBuilder.Entity<PdDocument>(entity =>
            {
                entity.HasKey(e => e.ドキュメントid);

                entity.ToTable("PD_document");

                entity.Property(e => e.ドキュメントid)
                    .ValueGeneratedNever()
                    .HasColumnName("ドキュメントID");

                entity.Property(e => e.ファイル名).HasMaxLength(100);

                entity.Property(e => e.分類).HasMaxLength(20);

                entity.Property(e => e.名称).HasMaxLength(100);

                entity.Property(e => e.改定日).HasColumnType("datetime");

                entity.Property(e => e.更新日時)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.更新者)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.表示有無).HasDefaultValueSql("(1)");

                entity.Property(e => e.表示順).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PdJirei>(entity =>
            {
                entity.HasKey(e => e.事例id);

                entity.ToTable("PD_jirei");

                entity.Property(e => e.事例id)
                    .ValueGeneratedNever()
                    .HasColumnName("事例ID");

                entity.Property(e => e.事例).HasMaxLength(255);

                entity.Property(e => e.更新日時)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.更新者)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.表示有無).HasDefaultValueSql("(1)");

                entity.Property(e => e.表示順).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PdJireiItem>(entity =>
            {
                entity.HasKey(e => new { e.事例id, e.ドキュメントid });

                entity.ToTable("PD_jirei_item");

                entity.Property(e => e.事例id).HasColumnName("事例ID");

                entity.Property(e => e.ドキュメントid).HasColumnName("ドキュメントID");

                entity.Property(e => e.表示有無)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.HasOne(d => d.ドキュメント)
                    .WithMany(p => p.PdJireiItems)
                    .HasForeignKey(d => d.ドキュメントid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PD_jirei_item_PD_document");

                entity.HasOne(d => d.事例)
                    .WithMany(p => p.PdJireiItems)
                    .HasForeignKey(d => d.事例id)
                    .HasConstraintName("FK_PD_jirei_item_PD_jirei");
            });

            modelBuilder.Entity<PdJireiTag>(entity =>
            {
                entity.HasKey(e => new { e.事例id, e.タグid });

                entity.ToTable("PD_jirei_tag");

                entity.Property(e => e.事例id).HasColumnName("事例ID");

                entity.Property(e => e.タグid).HasColumnName("タグID");

                entity.Property(e => e.表示有無)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.HasOne(d => d.タグ)
                    .WithMany(p => p.PdJireiTags)
                    .HasForeignKey(d => d.タグid)
                    .HasConstraintName("FK_PD_jirei_tag_PD_tag");

                entity.HasOne(d => d.事例)
                    .WithMany(p => p.PdJireiTags)
                    .HasForeignKey(d => d.事例id)
                    .HasConstraintName("FK_PD_jirei_tag_PD_jirei");
            });

            modelBuilder.Entity<PdKisokuKitei>(entity =>
            {
                entity.HasKey(e => e.規則規定id);

                entity.ToTable("PD_kisoku_kitei");

                entity.Property(e => e.規則規定id)
                    .ValueGeneratedNever()
                    .HasColumnName("規則規定ID");

                entity.Property(e => e.タグid).HasColumnName("タグID");

                entity.Property(e => e.中分類).HasMaxLength(20);

                entity.Property(e => e.名称).HasMaxLength(100);

                entity.Property(e => e.大分類).HasMaxLength(20);

                entity.Property(e => e.更新日時)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.更新者)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.表示有無).HasDefaultValueSql("(1)");

                entity.Property(e => e.表示順).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.タグ)
                    .WithMany(p => p.PdKisokuKiteis)
                    .HasForeignKey(d => d.タグid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PD_kisoku_kitei_PD_tag");
            });

            modelBuilder.Entity<PdTag>(entity =>
            {
                entity.HasKey(e => e.タグid);

                entity.ToTable("PD_tag");

                entity.Property(e => e.タグid)
                    .ValueGeneratedNever()
                    .HasColumnName("タグID");

                entity.Property(e => e.タグ).HasMaxLength(40);

                entity.Property(e => e.更新日時)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.更新者)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.表示有無).HasDefaultValueSql("(1)");

                entity.Property(e => e.表示順).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PdTagitem>(entity =>
            {
                entity.HasKey(e => new { e.タグid, e.ドキュメントid });

                entity.ToTable("PD_tagitem");

                entity.Property(e => e.タグid).HasColumnName("タグID");

                entity.Property(e => e.ドキュメントid).HasColumnName("ドキュメントID");

                entity.Property(e => e.表示有無)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.HasOne(d => d.タグ)
                    .WithMany(p => p.PdTagitems)
                    .HasForeignKey(d => d.タグid)
                    .HasConstraintName("FK_PD_tagitem_PD_tag");

                entity.HasOne(d => d.ドキュメント)
                    .WithMany(p => p.PdTagitems)
                    .HasForeignKey(d => d.ドキュメントid)
                    .HasConstraintName("FK_PD_tagitem_PD_document");
            });

            modelBuilder.Entity<Seikyu漢字請求項目>(entity =>
            {
                entity.HasKey(e => e.Insertno)
                    .IsClustered(false);

                entity.ToTable("SEIKYU_漢字請求項目");

                entity.HasIndex(e => e.番号, "IX_SEIKYU_漢字請求項目")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Insertno).HasColumnName("INSERTNO");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.コード).HasMaxLength(6);

                entity.Property(e => e.会員).HasMaxLength(1);

                entity.Property(e => e.健保番号).HasMaxLength(5);

                entity.Property(e => e.健保記号).HasMaxLength(5);

                entity.Property(e => e.健診コース).HasMaxLength(6);

                entity.Property(e => e.健診種別).HasMaxLength(6);

                entity.Property(e => e.区分).HasMaxLength(6);

                entity.Property(e => e.受付番号).HasMaxLength(6);

                entity.Property(e => e.受診日).HasMaxLength(6);

                entity.Property(e => e.年齢).HasMaxLength(2);

                entity.Property(e => e.性別).HasMaxLength(1);

                entity.Property(e => e.所属コード).HasMaxLength(10);

                entity.Property(e => e.有害業務).HasMaxLength(6);

                entity.Property(e => e.氏名かな).HasMaxLength(15);

                entity.Property(e => e.氏名コード).HasMaxLength(10);

                entity.Property(e => e.氏名漢字).HasMaxLength(24);

                entity.Property(e => e.特健項目).HasMaxLength(14);

                entity.Property(e => e.生年月日).HasMaxLength(7);

                entity.Property(e => e.社員コード).HasMaxLength(10);

                entity.Property(e => e.種別).HasMaxLength(1);

                entity.Property(e => e.行為).HasMaxLength(6);

                entity.Property(e => e.Ｃｃ)
                    .HasMaxLength(4)
                    .HasColumnName("ＣＣ");

                entity.Property(e => e.Ｉｘ001)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ001");

                entity.Property(e => e.Ｉｘ002)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ002");

                entity.Property(e => e.Ｉｘ003)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ003");

                entity.Property(e => e.Ｉｘ004)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ004");

                entity.Property(e => e.Ｉｘ005)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ005");

                entity.Property(e => e.Ｉｘ006)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ006");

                entity.Property(e => e.Ｉｘ007)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ007");

                entity.Property(e => e.Ｉｘ008)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ008");

                entity.Property(e => e.Ｉｘ009)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ009");

                entity.Property(e => e.Ｉｘ010)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ010");

                entity.Property(e => e.Ｉｘ011)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ011");

                entity.Property(e => e.Ｉｘ012)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ012");

                entity.Property(e => e.Ｉｘ013)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ013");

                entity.Property(e => e.Ｉｘ014)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ014");

                entity.Property(e => e.Ｉｘ015)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ015");

                entity.Property(e => e.Ｉｘ016)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ016");

                entity.Property(e => e.Ｉｘ017)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ017");

                entity.Property(e => e.Ｉｘ018)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ018");

                entity.Property(e => e.Ｉｘ019)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ019");

                entity.Property(e => e.Ｉｘ020)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ020");

                entity.Property(e => e.Ｉｘ021)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ021");

                entity.Property(e => e.Ｉｘ022)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ022");

                entity.Property(e => e.Ｉｘ023)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ023");

                entity.Property(e => e.Ｉｘ024)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ024");

                entity.Property(e => e.Ｉｘ025)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ025");

                entity.Property(e => e.Ｉｘ026)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ026");

                entity.Property(e => e.Ｉｘ027)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ027");

                entity.Property(e => e.Ｉｘ028)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ028");

                entity.Property(e => e.Ｉｘ029)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ029");

                entity.Property(e => e.Ｉｘ030)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ030");

                entity.Property(e => e.Ｉｘ031)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ031");

                entity.Property(e => e.Ｉｘ032)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ032");

                entity.Property(e => e.Ｉｘ033)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ033");

                entity.Property(e => e.Ｉｘ034)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ034");

                entity.Property(e => e.Ｉｘ035)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ035");

                entity.Property(e => e.Ｉｘ036)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ036");

                entity.Property(e => e.Ｉｘ037)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ037");

                entity.Property(e => e.Ｉｘ038)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ038");

                entity.Property(e => e.Ｉｘ039)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ039");

                entity.Property(e => e.Ｉｘ040)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ040");

                entity.Property(e => e.Ｉｘ041)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ041");

                entity.Property(e => e.Ｉｘ042)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ042");

                entity.Property(e => e.Ｉｘ043)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ043");

                entity.Property(e => e.Ｉｘ044)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ044");

                entity.Property(e => e.Ｉｘ045)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ045");

                entity.Property(e => e.Ｉｘ046)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ046");

                entity.Property(e => e.Ｉｘ047)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ047");

                entity.Property(e => e.Ｉｘ048)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ048");

                entity.Property(e => e.Ｉｘ049)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ049");

                entity.Property(e => e.Ｉｘ050)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ050");

                entity.Property(e => e.Ｉｘ051)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ051");

                entity.Property(e => e.Ｉｘ052)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ052");

                entity.Property(e => e.Ｉｘ053)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ053");

                entity.Property(e => e.Ｉｘ054)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ054");

                entity.Property(e => e.Ｉｘ055)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ055");

                entity.Property(e => e.Ｉｘ056)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ056");

                entity.Property(e => e.Ｉｘ057)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ057");

                entity.Property(e => e.Ｉｘ058)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ058");

                entity.Property(e => e.Ｉｘ059)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ059");

                entity.Property(e => e.Ｉｘ060)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ060");

                entity.Property(e => e.Ｉｘ061)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ061");

                entity.Property(e => e.Ｉｘ062)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ062");

                entity.Property(e => e.Ｉｘ063)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ063");

                entity.Property(e => e.Ｉｘ064)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ064");

                entity.Property(e => e.Ｉｘ065)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ065");

                entity.Property(e => e.Ｉｘ066)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ066");

                entity.Property(e => e.Ｉｘ067)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ067");

                entity.Property(e => e.Ｉｘ068)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ068");

                entity.Property(e => e.Ｉｘ069)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ069");

                entity.Property(e => e.Ｉｘ070)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ070");

                entity.Property(e => e.Ｉｘ071)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ071");

                entity.Property(e => e.Ｉｘ072)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ072");

                entity.Property(e => e.Ｉｘ073)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ073");

                entity.Property(e => e.Ｉｘ074)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ074");

                entity.Property(e => e.Ｉｘ075)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ075");

                entity.Property(e => e.Ｉｘ076)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ076");

                entity.Property(e => e.Ｉｘ077)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ077");

                entity.Property(e => e.Ｉｘ078)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ078");

                entity.Property(e => e.Ｉｘ079)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ079");

                entity.Property(e => e.Ｉｘ080)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ080");

                entity.Property(e => e.Ｉｘ081)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ081");

                entity.Property(e => e.Ｉｘ082)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ082");

                entity.Property(e => e.Ｉｘ083)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ083");

                entity.Property(e => e.Ｉｘ084)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ084");

                entity.Property(e => e.Ｉｘ085)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ085");

                entity.Property(e => e.Ｉｘ086)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ086");

                entity.Property(e => e.Ｉｘ087)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ087");

                entity.Property(e => e.Ｉｘ088)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ088");

                entity.Property(e => e.Ｉｘ089)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ089");

                entity.Property(e => e.Ｉｘ090)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ090");
            });

            modelBuilder.Entity<Seikyu請求販売連結用>(entity =>
            {
                entity.HasKey(e => e.Insertno)
                    .IsClustered(false);

                entity.ToTable("SEIKYU_請求販売連結用");

                entity.HasIndex(e => e.販売登録番号, "IX_SEIKYU_請求販売連結用")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Insertno).HasColumnName("INSERTNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.備考).HasMaxLength(50);

                entity.Property(e => e.販売登録日).HasColumnType("smalldatetime");

                entity.Property(e => e.送付関係).HasMaxLength(100);

                entity.Property(e => e.遅延理由).HasMaxLength(50);
            });

            modelBuilder.Entity<Seikyu閲覧用2>(entity =>
            {
                entity.HasKey(e => e.Insertno)
                    .IsClustered(false);

                entity.ToTable("SEIKYU_閲覧用_2");

                entity.HasIndex(e => e.事業場名, "IX_SEIKYU_閲覧用_2_事業場名")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.伝票日付, "IX_SEIKYU_閲覧用_2_伝票日付ASC")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.伝票日付, "IX_SEIKYU_閲覧用_2_伝票日付DESC")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.売伝番号, "IX_SEIKYU_閲覧用_2_売伝番号")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.請求書番号, "IX_SEIKYU_閲覧用_2_請求書番号")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.項目, "IX_SEIKYU_閲覧用_2_項目")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.得意先主コード, "IX_SEIKYU_閲覧用_得意先主コード")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Insertno).HasColumnName("INSERTNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.事業場名).HasMaxLength(255);

                entity.Property(e => e.伝票日付).HasColumnType("smalldatetime");

                entity.Property(e => e.得意先主コード).HasMaxLength(255);

                entity.Property(e => e.得意先補助コード).HasMaxLength(50);

                entity.Property(e => e.担当者名).HasMaxLength(255);

                entity.Property(e => e.摘要１).HasMaxLength(255);

                entity.Property(e => e.請求日付).HasColumnType("smalldatetime");

                entity.Property(e => e.請求書番号).HasMaxLength(50);

                entity.Property(e => e.項目).HasMaxLength(255);
            });

            modelBuilder.Entity<SftMk>(entity =>
            {
                entity.ToTable("SFT_mk");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.名称)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SftName>(entity =>
            {
                entity.HasKey(e => new { e.メーカーｉｄ, e.コード });

                entity.ToTable("SFT_name");

                entity.Property(e => e.メーカーｉｄ)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("メーカーＩＤ");

                entity.Property(e => e.コード)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ソフト名称)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ファイル名)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.使用者パソコン)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("使用者のパソコン名");

                entity.Property(e => e.使用者ログオン)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("使用者のログオンID");

                entity.Property(e => e.備考1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.更新スタンプ)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.更新日).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Souken>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("SOUKEN");

                entity.HasIndex(e => e.Path, "IX_SOUKEN_PATH")
                    .IsUnique();

                entity.Property(e => e.No)
                    .ValueGeneratedNever()
                    .HasColumnName("NO");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("PATH");

                entity.Property(e => e.年).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.登録担当).HasMaxLength(50);

                entity.Property(e => e.登録日)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TelnoCmbFlr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TELNO_cmb_flr");

                entity.Property(e => e.Fr1)
                    .HasMaxLength(10)
                    .HasColumnName("FR1");
            });

            modelBuilder.Entity<TelnoCmbSish>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TELNO_cmb_sish");

                entity.Property(e => e.Fr1)
                    .HasMaxLength(50)
                    .HasColumnName("FR1");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TelnoGano>(entity =>
            {
                entity.ToTable("TELNO_gano");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Fr1)
                    .HasMaxLength(255)
                    .HasColumnName("FR1");

                entity.Property(e => e.Fr2)
                    .HasMaxLength(255)
                    .HasColumnName("FR2");

                entity.Property(e => e.Fr3)
                    .HasMaxLength(255)
                    .HasColumnName("FR3");

                entity.Property(e => e.Fr4)
                    .HasMaxLength(255)
                    .HasColumnName("FR4");

                entity.Property(e => e.Fr5)
                    .HasMaxLength(255)
                    .HasColumnName("FR5");
            });

            modelBuilder.Entity<TelnoGanoLb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TELNO_gano_lb");

                entity.Property(e => e.Fr)
                    .HasMaxLength(10)
                    .HasColumnName("FR");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<TelnoPer>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Fr3 });

                entity.ToTable("TELNO_pers");

                entity.HasIndex(e => e.Fr1, "IX_TELNO_pers_FR1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr2, "IX_TELNO_pers_FR2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr4, "IX_TELNO_pers_FR4")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr5, "IX_TELNO_pers_FR5")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr6, "IX_TELNO_pers_FR6")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Fr3)
                    .HasMaxLength(255)
                    .HasColumnName("FR3");

                entity.Property(e => e.Fr1)
                    .HasMaxLength(255)
                    .HasColumnName("FR1");

                entity.Property(e => e.Fr10)
                    .HasMaxLength(30)
                    .HasColumnName("FR10");

                entity.Property(e => e.Fr2)
                    .HasMaxLength(255)
                    .HasColumnName("FR2");

                entity.Property(e => e.Fr4)
                    .HasMaxLength(255)
                    .HasColumnName("FR4");

                entity.Property(e => e.Fr5)
                    .HasMaxLength(50)
                    .HasColumnName("FR5");

                entity.Property(e => e.Fr6)
                    .HasMaxLength(50)
                    .HasColumnName("FR6");

                entity.Property(e => e.Fr7)
                    .HasMaxLength(50)
                    .HasColumnName("FR7");

                entity.Property(e => e.Fr8)
                    .HasMaxLength(50)
                    .HasColumnName("FR8");

                entity.Property(e => e.Fr9)
                    .HasMaxLength(50)
                    .HasColumnName("FR9");
            });

            modelBuilder.Entity<TelnoPersLb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TELNO_pers_lb");

                entity.Property(e => e.Fr)
                    .HasMaxLength(10)
                    .HasColumnName("FR");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<TelnoSect>(entity =>
            {
                entity.ToTable("TELNO_sect");

                entity.HasIndex(e => e.Fr1, "IX_TELNO_sect_FR1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr2, "IX_TELNO_sect_FR2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr3, "IX_TELNO_sect_FR3")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Fr4, "IX_TELNO_sect_FR4")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Fr1)
                    .HasMaxLength(255)
                    .HasColumnName("FR1");

                entity.Property(e => e.Fr2)
                    .HasMaxLength(255)
                    .HasColumnName("FR2");

                entity.Property(e => e.Fr3)
                    .HasMaxLength(255)
                    .HasColumnName("FR3");

                entity.Property(e => e.Fr4)
                    .HasMaxLength(255)
                    .HasColumnName("FR4");

                entity.Property(e => e.Fr5)
                    .HasMaxLength(255)
                    .HasColumnName("FR5");
            });

            modelBuilder.Entity<TelnoSectLb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TELNO_sect_lb");

                entity.Property(e => e.Fr)
                    .HasMaxLength(10)
                    .HasColumnName("FR");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Testcalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTCALENDAR");

                entity.Property(e => e.FDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("f_date");

                entity.Property(e => e.FFlag).HasColumnName("f_flag");
            });

            modelBuilder.Entity<TesttelnoPer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTTELNO_pers");

                entity.Property(e => e.Fr1)
                    .HasMaxLength(255)
                    .HasColumnName("FR1");

                entity.Property(e => e.Fr2)
                    .HasMaxLength(255)
                    .HasColumnName("FR2");

                entity.Property(e => e.Fr3)
                    .HasMaxLength(255)
                    .HasColumnName("FR3");

                entity.Property(e => e.Fr4)
                    .HasMaxLength(255)
                    .HasColumnName("FR4");

                entity.Property(e => e.Fr5)
                    .HasMaxLength(50)
                    .HasColumnName("FR5");

                entity.Property(e => e.Fr6)
                    .HasMaxLength(50)
                    .HasColumnName("FR6");

                entity.Property(e => e.Fr7)
                    .HasMaxLength(50)
                    .HasColumnName("FR7");

                entity.Property(e => e.Fr8)
                    .HasMaxLength(50)
                    .HasColumnName("FR8");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<ViewerError管理>(entity =>
            {
                entity.HasKey(e => new { e.イベントid, e.ソース, e.サーバ名 });

                entity.ToTable("Viewer_Error管理");

                entity.Property(e => e.イベントid)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("イベントID");

                entity.Property(e => e.ソース).HasMaxLength(128);

                entity.Property(e => e.サーバ名).HasMaxLength(128);

                entity.Property(e => e.ユーザ)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ログ名)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.分類)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.発生日時).HasColumnType("datetime");

                entity.Property(e => e.発生源pc)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("発生源PC");

                entity.Property(e => e.登録日)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.登録者)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.解説)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.説明)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Viewer重要キーワード管理>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("Viewer_重要キーワード管理");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.登録日)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.登録者)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Vwぐるぐる検索>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ぐるぐる検索");

                entity.Property(e => e.カナ事業場名).HasMaxLength(20);

                entity.Property(e => e.ストレス健診).HasMaxLength(6);

                entity.Property(e => e.ドックhmp)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ドックHMP");

                entity.Property(e => e.ドック健診).HasMaxLength(6);

                entity.Property(e => e.上位事業場コード).HasMaxLength(255);

                entity.Property(e => e.事業場コード)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.事業場名).HasMaxLength(40);

                entity.Property(e => e.住所)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.保険者名).HasMaxLength(40);

                entity.Property(e => e.保険者番号).HasMaxLength(8);

                entity.Property(e => e.定健hmp)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("定健HMP");

                entity.Property(e => e.定健健診).HasMaxLength(6);

                entity.Property(e => e.検索用電話番号).HasMaxLength(4000);

                entity.Property(e => e.親事業場コード).HasMaxLength(6);

                entity.Property(e => e.郵便番号).HasMaxLength(7);

                entity.Property(e => e.電話番号).HasMaxLength(15);
            });

            modelBuilder.Entity<要望依頼>(entity =>
            {
                entity.ToTable("要望依頼");

                entity.HasIndex(e => e.起票日, "IX_起票日");

                entity.Property(e => e.FileKey).HasMaxLength(255);

                entity.Property(e => e.その他備考).HasMaxLength(500);

                entity.Property(e => e.ファイル添付).HasMaxLength(1000);

                entity.Property(e => e.上記以外text)
                    .HasMaxLength(50)
                    .HasColumnName("上記以外Text");

                entity.Property(e => e.依頼内容).HasMaxLength(1000);

                entity.Property(e => e.備考).HasMaxLength(1000);

                entity.Property(e => e.効果).HasMaxLength(1000);

                entity.Property(e => e.受付日).HasColumnType("datetime");

                entity.Property(e => e.外注備考).HasMaxLength(500);

                entity.Property(e => e.完了日).HasColumnType("datetime");

                entity.Property(e => e.工数単位).HasMaxLength(50);

                entity.Property(e => e.希望納期).HasColumnType("datetime");

                entity.Property(e => e.影響範囲).HasMaxLength(1000);

                entity.Property(e => e.納期).HasColumnType("datetime");

                entity.Property(e => e.緊急の理由).HasMaxLength(500);

                entity.Property(e => e.補足).HasMaxLength(500);

                entity.Property(e => e.購買備考).HasMaxLength(500);

                entity.Property(e => e.起票日).HasColumnType("datetime");

                entity.Property(e => e.起票者).HasMaxLength(50);
            });

            modelBuilder.Entity<ＶSeikyu黒>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ｖ＿SEIKYU＿黒");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.コード).HasMaxLength(6);

                entity.Property(e => e.健保番号).HasMaxLength(5);

                entity.Property(e => e.健保記号).HasMaxLength(5);

                entity.Property(e => e.健診コース).HasMaxLength(6);

                entity.Property(e => e.健診種別).HasMaxLength(6);

                entity.Property(e => e.区分).HasMaxLength(6);

                entity.Property(e => e.受付番号).HasMaxLength(6);

                entity.Property(e => e.受診日).HasMaxLength(6);

                entity.Property(e => e.年齢).HasMaxLength(2);

                entity.Property(e => e.性別).HasMaxLength(1);

                entity.Property(e => e.所属コード).HasMaxLength(10);

                entity.Property(e => e.有害業務).HasMaxLength(6);

                entity.Property(e => e.氏名かな).HasMaxLength(15);

                entity.Property(e => e.氏名コード).HasMaxLength(10);

                entity.Property(e => e.氏名漢字).HasMaxLength(24);

                entity.Property(e => e.特健項目).HasMaxLength(14);

                entity.Property(e => e.生年月日).HasMaxLength(7);

                entity.Property(e => e.社員コード).HasMaxLength(10);

                entity.Property(e => e.行為).HasMaxLength(6);

                entity.Property(e => e.Ｉｘ001)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ001");

                entity.Property(e => e.Ｉｘ002)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ002");

                entity.Property(e => e.Ｉｘ003)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ003");

                entity.Property(e => e.Ｉｘ004)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ004");

                entity.Property(e => e.Ｉｘ005)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ005");

                entity.Property(e => e.Ｉｘ006)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ006");

                entity.Property(e => e.Ｉｘ007)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ007");

                entity.Property(e => e.Ｉｘ008)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ008");

                entity.Property(e => e.Ｉｘ009)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ009");

                entity.Property(e => e.Ｉｘ010)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ010");

                entity.Property(e => e.Ｉｘ011)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ011");

                entity.Property(e => e.Ｉｘ012)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ012");

                entity.Property(e => e.Ｉｘ013)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ013");

                entity.Property(e => e.Ｉｘ014)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ014");

                entity.Property(e => e.Ｉｘ015)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ015");

                entity.Property(e => e.Ｉｘ016)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ016");

                entity.Property(e => e.Ｉｘ017)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ017");

                entity.Property(e => e.Ｉｘ018)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ018");

                entity.Property(e => e.Ｉｘ019)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ019");

                entity.Property(e => e.Ｉｘ020)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ020");

                entity.Property(e => e.Ｉｘ021)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ021");

                entity.Property(e => e.Ｉｘ022)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ022");

                entity.Property(e => e.Ｉｘ023)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ023");

                entity.Property(e => e.Ｉｘ024)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ024");

                entity.Property(e => e.Ｉｘ025)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ025");

                entity.Property(e => e.Ｉｘ026)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ026");

                entity.Property(e => e.Ｉｘ027)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ027");

                entity.Property(e => e.Ｉｘ028)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ028");

                entity.Property(e => e.Ｉｘ029)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ029");

                entity.Property(e => e.Ｉｘ030)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ030");

                entity.Property(e => e.Ｉｘ031)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ031");

                entity.Property(e => e.Ｉｘ032)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ032");

                entity.Property(e => e.Ｉｘ033)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ033");

                entity.Property(e => e.Ｉｘ034)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ034");

                entity.Property(e => e.Ｉｘ035)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ035");

                entity.Property(e => e.Ｉｘ036)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ036");

                entity.Property(e => e.Ｉｘ037)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ037");

                entity.Property(e => e.Ｉｘ038)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ038");

                entity.Property(e => e.Ｉｘ039)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ039");

                entity.Property(e => e.Ｉｘ040)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ040");

                entity.Property(e => e.Ｉｘ041)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ041");

                entity.Property(e => e.Ｉｘ042)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ042");

                entity.Property(e => e.Ｉｘ043)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ043");

                entity.Property(e => e.Ｉｘ044)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ044");

                entity.Property(e => e.Ｉｘ045)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ045");

                entity.Property(e => e.Ｉｘ046)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ046");

                entity.Property(e => e.Ｉｘ047)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ047");

                entity.Property(e => e.Ｉｘ048)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ048");

                entity.Property(e => e.Ｉｘ049)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ049");

                entity.Property(e => e.Ｉｘ050)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ050");

                entity.Property(e => e.Ｉｘ051)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ051");

                entity.Property(e => e.Ｉｘ052)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ052");

                entity.Property(e => e.Ｉｘ053)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ053");

                entity.Property(e => e.Ｉｘ054)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ054");

                entity.Property(e => e.Ｉｘ055)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ055");

                entity.Property(e => e.Ｉｘ056)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ056");

                entity.Property(e => e.Ｉｘ057)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ057");

                entity.Property(e => e.Ｉｘ058)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ058");

                entity.Property(e => e.Ｉｘ059)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ059");

                entity.Property(e => e.Ｉｘ060)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ060");

                entity.Property(e => e.Ｉｘ061)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ061");

                entity.Property(e => e.Ｉｘ062)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ062");

                entity.Property(e => e.Ｉｘ063)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ063");

                entity.Property(e => e.Ｉｘ064)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ064");

                entity.Property(e => e.Ｉｘ065)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ065");

                entity.Property(e => e.Ｉｘ066)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ066");

                entity.Property(e => e.Ｉｘ067)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ067");

                entity.Property(e => e.Ｉｘ068)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ068");

                entity.Property(e => e.Ｉｘ069)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ069");

                entity.Property(e => e.Ｉｘ070)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ070");

                entity.Property(e => e.Ｉｘ071)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ071");

                entity.Property(e => e.Ｉｘ072)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ072");

                entity.Property(e => e.Ｉｘ073)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ073");

                entity.Property(e => e.Ｉｘ074)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ074");

                entity.Property(e => e.Ｉｘ075)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ075");

                entity.Property(e => e.Ｉｘ076)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ076");

                entity.Property(e => e.Ｉｘ077)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ077");

                entity.Property(e => e.Ｉｘ078)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ078");

                entity.Property(e => e.Ｉｘ079)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ079");

                entity.Property(e => e.Ｉｘ080)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ080");

                entity.Property(e => e.Ｉｘ081)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ081");

                entity.Property(e => e.Ｉｘ082)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ082");

                entity.Property(e => e.Ｉｘ083)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ083");

                entity.Property(e => e.Ｉｘ084)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ084");

                entity.Property(e => e.Ｉｘ085)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ085");

                entity.Property(e => e.Ｉｘ086)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ086");

                entity.Property(e => e.Ｉｘ087)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ087");

                entity.Property(e => e.Ｉｘ088)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ088");

                entity.Property(e => e.Ｉｘ089)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ089");

                entity.Property(e => e.Ｉｘ090)
                    .HasMaxLength(18)
                    .HasColumnName("ＩＸ090");
            });

            modelBuilder.Entity<Ｖシステム利用>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ｖ＿システム利用");

                entity.Property(e => e.システムid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("システムID");

                entity.Property(e => e.システム名称)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ログオン名)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.漢字氏名)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.部署)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ｖシステム利用all>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ｖ＿システム利用ALL");

                entity.Property(e => e.システムid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("システムID");

                entity.Property(e => e.システム名称)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ログオン名)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.漢字氏名)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.部署)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ｖパソコン管理>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ｖ＿パソコン管理");

                entity.Property(e => e.Apsプリンタ)
                    .HasMaxLength(255)
                    .HasColumnName("APSプリンタ");

                entity.Property(e => e.Macアドレス)
                    .HasMaxLength(255)
                    .HasColumnName("MACアドレス");

                entity.Property(e => e.Os名)
                    .HasMaxLength(50)
                    .HasColumnName("OS名");

                entity.Property(e => e.クラス).HasMaxLength(255);

                entity.Property(e => e.コンピューター名).HasMaxLength(255);

                entity.Property(e => e.プリンタグループ).HasMaxLength(255);

                entity.Property(e => e.ホスト接続形態).HasMaxLength(255);

                entity.Property(e => e.備考).HasMaxLength(255);

                entity.Property(e => e.型番１).HasMaxLength(255);

                entity.Property(e => e.型番２).HasMaxLength(255);

                entity.Property(e => e.場所名).HasMaxLength(50);

                entity.Property(e => e.形態).HasMaxLength(50);

                entity.Property(e => e.接続プリンタ).HasMaxLength(255);

                entity.Property(e => e.機種名).HasMaxLength(255);

                entity.Property(e => e.用途).HasMaxLength(255);

                entity.Property(e => e.端末ｉｄ)
                    .HasMaxLength(255)
                    .HasColumnName("端末ＩＤ");

                entity.Property(e => e.管理者カナ氏名１)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.管理者カナ氏名２)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.管理者メール１)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.管理者メール２)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.管理者ログオン名２)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.管理者ログオン１)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.管理者漢字氏名１)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.管理者漢字氏名２)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.管理者部署１)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("部署コード");

                entity.Property(e => e.管理者部署２)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("部署コード");

                entity.Property(e => e.管理者１).HasMaxLength(50);

                entity.Property(e => e.管理者２).HasMaxLength(50);

                entity.Property(e => e.設置場所).HasMaxLength(255);

                entity.Property(e => e.設置場所詳細).HasMaxLength(255);

                entity.Property(e => e.購入年月日).HasMaxLength(50);

                entity.Property(e => e.通番)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ｏｓ)
                    .HasMaxLength(255)
                    .HasColumnName("ＯＳ");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
