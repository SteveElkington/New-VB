<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADIFootball
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADIFootball))
        Me.Connect = New System.Windows.Forms.Button()
        Me.countTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OnScreenClock = New System.Windows.Forms.Timer(Me.components)
        Me.Clock = New System.Windows.Forms.GroupBox()
        Me.secondHalfRadBTN = New System.Windows.Forms.RadioButton()
        Me.firstHalfRadBTN = New System.Windows.Forms.RadioButton()
        Me.StopTime = New System.Windows.Forms.Label()
        Me.StartTimeLabel = New System.Windows.Forms.Label()
        Me.StopClock = New System.Windows.Forms.Button()
        Me.showClock = New System.Windows.Forms.Button()
        Me.stopClockTime = New System.Windows.Forms.TextBox()
        Me.startClockTime = New System.Windows.Forms.TextBox()
        Me.sec = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.clockAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Crawl = New System.Windows.Forms.GroupBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.UpdateTextButton = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CrawlText4 = New System.Windows.Forms.TextBox()
        Me.CrawlText3 = New System.Windows.Forms.TextBox()
        Me.CrawlText2 = New System.Windows.Forms.TextBox()
        Me.CrawlOff = New System.Windows.Forms.Button()
        Me.CrawlOn = New System.Windows.Forms.Button()
        Me.CrawlText1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SubOn = New System.Windows.Forms.ComboBox()
        Me.SubOff = New System.Windows.Forms.ComboBox()
        Me.aw_subOff = New System.Windows.Forms.ComboBox()
        Me.aw_subOn = New System.Windows.Forms.ComboBox()
        Me.LoadTeams = New System.Windows.Forms.Button()
        Me.showSub = New System.Windows.Forms.Button()
        Me.SubOFFBtn = New System.Windows.Forms.Button()
        Me.ShowTeamSheet = New System.Windows.Forms.Button()
        Me.ShowSubsSheet = New System.Windows.Forms.Button()
        Me.Ts_Off = New System.Windows.Forms.Button()
        Me.backgroundOn = New System.Windows.Forms.CheckBox()
        Me.PremScoresTitle = New System.Windows.Forms.TextBox()
        Me.HidePremScoresBTN = New System.Windows.Forms.Button()
        Me.TXPremScores_2BTN = New System.Windows.Forms.Button()
        Me.Score47 = New System.Windows.Forms.TextBox()
        Me.Score48 = New System.Windows.Forms.TextBox()
        Me.Score46 = New System.Windows.Forms.TextBox()
        Me.Score45 = New System.Windows.Forms.TextBox()
        Me.Score43 = New System.Windows.Forms.TextBox()
        Me.Score44 = New System.Windows.Forms.TextBox()
        Me.Score42 = New System.Windows.Forms.TextBox()
        Me.Score41 = New System.Windows.Forms.TextBox()
        Me.Score39 = New System.Windows.Forms.TextBox()
        Me.Score40 = New System.Windows.Forms.TextBox()
        Me.Score38 = New System.Windows.Forms.TextBox()
        Me.Score37 = New System.Windows.Forms.TextBox()
        Me.Score35 = New System.Windows.Forms.TextBox()
        Me.Score36 = New System.Windows.Forms.TextBox()
        Me.Score34 = New System.Windows.Forms.TextBox()
        Me.Score33 = New System.Windows.Forms.TextBox()
        Me.Score31 = New System.Windows.Forms.TextBox()
        Me.Score32 = New System.Windows.Forms.TextBox()
        Me.Score30 = New System.Windows.Forms.TextBox()
        Me.Score29 = New System.Windows.Forms.TextBox()
        Me.Score27 = New System.Windows.Forms.TextBox()
        Me.Score28 = New System.Windows.Forms.TextBox()
        Me.Score26 = New System.Windows.Forms.TextBox()
        Me.Score25 = New System.Windows.Forms.TextBox()
        Me.HidePremScores = New System.Windows.Forms.Button()
        Me.showPremScores = New System.Windows.Forms.Button()
        Me.Score23 = New System.Windows.Forms.TextBox()
        Me.Score24 = New System.Windows.Forms.TextBox()
        Me.Score22 = New System.Windows.Forms.TextBox()
        Me.Score21 = New System.Windows.Forms.TextBox()
        Me.Score19 = New System.Windows.Forms.TextBox()
        Me.Score20 = New System.Windows.Forms.TextBox()
        Me.Score18 = New System.Windows.Forms.TextBox()
        Me.Score17 = New System.Windows.Forms.TextBox()
        Me.Score15 = New System.Windows.Forms.TextBox()
        Me.Score16 = New System.Windows.Forms.TextBox()
        Me.Score14 = New System.Windows.Forms.TextBox()
        Me.Score13 = New System.Windows.Forms.TextBox()
        Me.Score11 = New System.Windows.Forms.TextBox()
        Me.Score12 = New System.Windows.Forms.TextBox()
        Me.Score10 = New System.Windows.Forms.TextBox()
        Me.Score9 = New System.Windows.Forms.TextBox()
        Me.Score7 = New System.Windows.Forms.TextBox()
        Me.Score8 = New System.Windows.Forms.TextBox()
        Me.Score6 = New System.Windows.Forms.TextBox()
        Me.Score5 = New System.Windows.Forms.TextBox()
        Me.Score3 = New System.Windows.Forms.TextBox()
        Me.Score4 = New System.Windows.Forms.TextBox()
        Me.Score2 = New System.Windows.Forms.TextBox()
        Me.Score1 = New System.Windows.Forms.TextBox()
        Me.AwayTeamsOff = New System.Windows.Forms.Button()
        Me.ShowAwaySubsSheet = New System.Windows.Forms.Button()
        Me.ShowAwayFirstEleven = New System.Windows.Forms.Button()
        Me.AwaySubOff = New System.Windows.Forms.Button()
        Me.AwaySubOn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.loadLastAwaySquadBTN = New System.Windows.Forms.Button()
        Me.loadLastHomeSquadBTN = New System.Windows.Forms.Button()
        Me.HomeTeam = New System.Windows.Forms.ListBox()
        Me.AwayTeam = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AwaySubsCount = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.homeSubsCount = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.AwayTeamName = New System.Windows.Forms.TextBox()
        Me.HomeTeamName = New System.Windows.Forms.TextBox()
        Me.AwayMoveDown = New System.Windows.Forms.Button()
        Me.AwayMoveUp = New System.Windows.Forms.Button()
        Me.HomeDown = New System.Windows.Forms.Button()
        Me.HomeMoveUp = New System.Windows.Forms.Button()
        Me.AwayPlayerCount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.homePlayerCount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddtoSqaudNotListedAway = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AwayPlayerNotListed = New System.Windows.Forms.TextBox()
        Me.AddtoSquadNotListed = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomePlayerNotListed = New System.Windows.Forms.TextBox()
        Me.updateAllTeams = New System.Windows.Forms.Button()
        Me.clearAwaySquad = New System.Windows.Forms.Button()
        Me.removeAwaySquad = New System.Windows.Forms.Button()
        Me.addAwaySquad = New System.Windows.Forms.Button()
        Me.HomeClearSquadList = New System.Windows.Forms.Button()
        Me.removeHomeSquad = New System.Windows.Forms.Button()
        Me.addHomeSquad = New System.Windows.Forms.Button()
        Me.FullAwaySquad = New System.Windows.Forms.ListBox()
        Me.FullHomeSquad = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AwayManagerTXT = New System.Windows.Forms.TextBox()
        Me.HomeManagerTXT = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.hideNameIDBTN = New System.Windows.Forms.Button()
        Me.showNameIDBTN = New System.Windows.Forms.Button()
        Me.nameRoleIdentText4 = New System.Windows.Forms.TextBox()
        Me.nameIdentText4 = New System.Windows.Forms.TextBox()
        Me.nameRoleIdentText3 = New System.Windows.Forms.TextBox()
        Me.nameIdentText3 = New System.Windows.Forms.TextBox()
        Me.nameRoleIdentText2 = New System.Windows.Forms.TextBox()
        Me.nameIdentText2 = New System.Windows.Forms.TextBox()
        Me.nameRoleIdentText1 = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.nameIDCHK4 = New System.Windows.Forms.RadioButton()
        Me.nameIDCHK3 = New System.Windows.Forms.RadioButton()
        Me.nameIDCHK2 = New System.Windows.Forms.RadioButton()
        Me.nameIDCHK1 = New System.Windows.Forms.RadioButton()
        Me.nameIdentText1 = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.OutGameCrawlUpdateBTN = New System.Windows.Forms.Button()
        Me.outGameCrawlRadBTN4 = New System.Windows.Forms.RadioButton()
        Me.outGameCrawlRadBTN3 = New System.Windows.Forms.RadioButton()
        Me.outGameCrawlRadBTN2 = New System.Windows.Forms.RadioButton()
        Me.outGameCrawlRadBTN1 = New System.Windows.Forms.RadioButton()
        Me.outGameCrawl4 = New System.Windows.Forms.TextBox()
        Me.outGameCrawl3 = New System.Windows.Forms.TextBox()
        Me.outGameCrawl2 = New System.Windows.Forms.TextBox()
        Me.OutGameCrawlOffBTN = New System.Windows.Forms.Button()
        Me.OutGameCrawlOnBTN = New System.Windows.Forms.Button()
        Me.outGameCrawl1 = New System.Windows.Forms.TextBox()
        Me.awayCrestBTN = New System.Windows.Forms.Button()
        Me.homeCrestsBTN = New System.Windows.Forms.Button()
        Me.identTeamsBTN = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AwayTeamLabel = New System.Windows.Forms.Label()
        Me.HomeTeamLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.stillsPlayLoadBTN = New System.Windows.Forms.Button()
        Me.stillsPlaySaveBTN = New System.Windows.Forms.Button()
        Me.WipeTrans = New System.Windows.Forms.RadioButton()
        Me.PushTrans = New System.Windows.Forms.RadioButton()
        Me.MixTrans = New System.Windows.Forms.RadioButton()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.PL1MoveDown = New System.Windows.Forms.Button()
        Me.playNext = New System.Windows.Forms.Button()
        Me.PL1MoveUp = New System.Windows.Forms.Button()
        Me.stopVid = New System.Windows.Forms.Button()
        Me.playVid = New System.Windows.Forms.Button()
        Me.ClearPlaylist = New System.Windows.Forms.Button()
        Me.RemovePlaylist = New System.Windows.Forms.Button()
        Me.AddPlaylist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rereshVids = New System.Windows.Forms.Button()
        Me.playlistFiles = New System.Windows.Forms.ListBox()
        Me.SourceFiles = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.hideScoresScroller = New System.Windows.Forms.Button()
        Me.showScoresScroller = New System.Windows.Forms.Button()
        Me.sscoresT2Right = New System.Windows.Forms.RadioButton()
        Me.sscoresT2Left = New System.Windows.Forms.RadioButton()
        Me.sscoresT1Right = New System.Windows.Forms.RadioButton()
        Me.sscoresT1Left = New System.Windows.Forms.RadioButton()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tab1Logo2Select = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.tab1Logo1Select = New System.Windows.Forms.ComboBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.FT12 = New System.Windows.Forms.CheckBox()
        Me.FT11 = New System.Windows.Forms.CheckBox()
        Me.FT10 = New System.Windows.Forms.CheckBox()
        Me.FT9 = New System.Windows.Forms.CheckBox()
        Me.FT8 = New System.Windows.Forms.CheckBox()
        Me.FT7 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.FT6 = New System.Windows.Forms.CheckBox()
        Me.FT5 = New System.Windows.Forms.CheckBox()
        Me.FT4 = New System.Windows.Forms.CheckBox()
        Me.FT3 = New System.Windows.Forms.CheckBox()
        Me.FT2 = New System.Windows.Forms.CheckBox()
        Me.FT1 = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PremScoresTitle2 = New System.Windows.Forms.TextBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.middle24 = New System.Windows.Forms.ComboBox()
        Me.middle23 = New System.Windows.Forms.ComboBox()
        Me.middle22 = New System.Windows.Forms.ComboBox()
        Me.middle21 = New System.Windows.Forms.ComboBox()
        Me.middle20 = New System.Windows.Forms.ComboBox()
        Me.middle19 = New System.Windows.Forms.ComboBox()
        Me.middle18 = New System.Windows.Forms.ComboBox()
        Me.middle17 = New System.Windows.Forms.ComboBox()
        Me.middle16 = New System.Windows.Forms.ComboBox()
        Me.middle15 = New System.Windows.Forms.ComboBox()
        Me.middle14 = New System.Windows.Forms.ComboBox()
        Me.middle13 = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tab2Logo2Select = New System.Windows.Forms.ComboBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.tab2Logo1Select = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.FT24 = New System.Windows.Forms.CheckBox()
        Me.FT23 = New System.Windows.Forms.CheckBox()
        Me.FT22 = New System.Windows.Forms.CheckBox()
        Me.FT21 = New System.Windows.Forms.CheckBox()
        Me.FT20 = New System.Windows.Forms.CheckBox()
        Me.FT19 = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FT18 = New System.Windows.Forms.CheckBox()
        Me.FT17 = New System.Windows.Forms.CheckBox()
        Me.FT16 = New System.Windows.Forms.CheckBox()
        Me.FT15 = New System.Windows.Forms.CheckBox()
        Me.FT14 = New System.Windows.Forms.CheckBox()
        Me.FT13 = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ChampScoresTitle2 = New System.Windows.Forms.TextBox()
        Me.middle12 = New System.Windows.Forms.ComboBox()
        Me.middle11 = New System.Windows.Forms.ComboBox()
        Me.middle10 = New System.Windows.Forms.ComboBox()
        Me.middle9 = New System.Windows.Forms.ComboBox()
        Me.middle8 = New System.Windows.Forms.ComboBox()
        Me.middle7 = New System.Windows.Forms.ComboBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.middle6 = New System.Windows.Forms.ComboBox()
        Me.middle5 = New System.Windows.Forms.ComboBox()
        Me.middle4 = New System.Windows.Forms.ComboBox()
        Me.middle3 = New System.Windows.Forms.ComboBox()
        Me.middle2 = New System.Windows.Forms.ComboBox()
        Me.middle1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ChampScoresTitle = New System.Windows.Forms.TextBox()
        Me.ChampHide2BTN = New System.Windows.Forms.Button()
        Me.ChampScore1 = New System.Windows.Forms.TextBox()
        Me.ChampTX2Btn = New System.Windows.Forms.Button()
        Me.ChampScore2 = New System.Windows.Forms.TextBox()
        Me.ChampScore47 = New System.Windows.Forms.TextBox()
        Me.ChampScore4 = New System.Windows.Forms.TextBox()
        Me.ChampScore48 = New System.Windows.Forms.TextBox()
        Me.ChampScore3 = New System.Windows.Forms.TextBox()
        Me.ChampScore46 = New System.Windows.Forms.TextBox()
        Me.ChampScore5 = New System.Windows.Forms.TextBox()
        Me.ChampScore45 = New System.Windows.Forms.TextBox()
        Me.ChampScore6 = New System.Windows.Forms.TextBox()
        Me.ChampScore43 = New System.Windows.Forms.TextBox()
        Me.ChampScore8 = New System.Windows.Forms.TextBox()
        Me.ChampScore44 = New System.Windows.Forms.TextBox()
        Me.ChampScore7 = New System.Windows.Forms.TextBox()
        Me.ChampScore42 = New System.Windows.Forms.TextBox()
        Me.ChampScore9 = New System.Windows.Forms.TextBox()
        Me.ChampScore41 = New System.Windows.Forms.TextBox()
        Me.ChampScore10 = New System.Windows.Forms.TextBox()
        Me.ChampScore39 = New System.Windows.Forms.TextBox()
        Me.ChampScore12 = New System.Windows.Forms.TextBox()
        Me.ChampScore40 = New System.Windows.Forms.TextBox()
        Me.ChampScore11 = New System.Windows.Forms.TextBox()
        Me.ChampScore38 = New System.Windows.Forms.TextBox()
        Me.ChampScore13 = New System.Windows.Forms.TextBox()
        Me.ChampScore37 = New System.Windows.Forms.TextBox()
        Me.ChampScore14 = New System.Windows.Forms.TextBox()
        Me.ChampScore35 = New System.Windows.Forms.TextBox()
        Me.ChampScore16 = New System.Windows.Forms.TextBox()
        Me.ChampScore36 = New System.Windows.Forms.TextBox()
        Me.ChampScore15 = New System.Windows.Forms.TextBox()
        Me.ChampScore34 = New System.Windows.Forms.TextBox()
        Me.ChampScore17 = New System.Windows.Forms.TextBox()
        Me.ChampScore33 = New System.Windows.Forms.TextBox()
        Me.ChampScore18 = New System.Windows.Forms.TextBox()
        Me.ChampScore31 = New System.Windows.Forms.TextBox()
        Me.ChampScore20 = New System.Windows.Forms.TextBox()
        Me.ChampScore32 = New System.Windows.Forms.TextBox()
        Me.ChampScore19 = New System.Windows.Forms.TextBox()
        Me.ChampScore30 = New System.Windows.Forms.TextBox()
        Me.ChampScore21 = New System.Windows.Forms.TextBox()
        Me.ChampScore29 = New System.Windows.Forms.TextBox()
        Me.ChampScore22 = New System.Windows.Forms.TextBox()
        Me.ChampScore27 = New System.Windows.Forms.TextBox()
        Me.ChampScore24 = New System.Windows.Forms.TextBox()
        Me.ChampScore28 = New System.Windows.Forms.TextBox()
        Me.ChampScore23 = New System.Windows.Forms.TextBox()
        Me.ChampScore26 = New System.Windows.Forms.TextBox()
        Me.ChampTX1Btn = New System.Windows.Forms.Button()
        Me.ChampScore25 = New System.Windows.Forms.TextBox()
        Me.ChampHide1BTN = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SendEditedAwayScorers = New System.Windows.Forms.Button()
        Me.EditTextAwayScorers = New System.Windows.Forms.TextBox()
        Me.EditAwayScorers = New System.Windows.Forms.Button()
        Me.RemoveAwayScoreresLB = New System.Windows.Forms.Button()
        Me.SendEditedHomeScorers = New System.Windows.Forms.Button()
        Me.EditTextHomeScorers = New System.Windows.Forms.TextBox()
        Me.EditHomeScorers = New System.Windows.Forms.Button()
        Me.RemoveHomerScoreresLB = New System.Windows.Forms.Button()
        Me.awayScorers = New System.Windows.Forms.ListBox()
        Me.HomeScorers = New System.Windows.Forms.ListBox()
        Me.hideBigScore = New System.Windows.Forms.Button()
        Me.showBigScore = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Away1stElevenCrawler = New System.Windows.Forms.RadioButton()
        Me.Home1stElevenCrawler = New System.Windows.Forms.RadioButton()
        Me.ShowAwayFirstElevenCrawl = New System.Windows.Forms.RadioButton()
        Me.ShowHomeFirstElevenCrawl = New System.Windows.Forms.RadioButton()
        Me.TSCrawlOffBTN = New System.Windows.Forms.Button()
        Me.TSCrawlOnBTN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hideAddedTimeButton = New System.Windows.Forms.Button()
        Me.addedTimeVals = New System.Windows.Forms.ComboBox()
        Me.showAddedTimeBTN = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.igPlaylistLoadBTN = New System.Windows.Forms.Button()
        Me.igPlaylistSaveBTN = New System.Windows.Forms.Button()
        Me.WipeTransInGame = New System.Windows.Forms.RadioButton()
        Me.PushTransInGame = New System.Windows.Forms.RadioButton()
        Me.MixTransInGame = New System.Windows.Forms.RadioButton()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.PLInGameMoveDown = New System.Windows.Forms.Button()
        Me.PlayNextVidInGame = New System.Windows.Forms.Button()
        Me.PLInGameMoveUp = New System.Windows.Forms.Button()
        Me.stopVidInGame = New System.Windows.Forms.Button()
        Me.PlayVidInGame = New System.Windows.Forms.Button()
        Me.ClearPlaylistInGame = New System.Windows.Forms.Button()
        Me.RemovePlaylistInGame = New System.Windows.Forms.Button()
        Me.AddPlaylistInGame = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.refreshVideInGame = New System.Windows.Forms.Button()
        Me.playlistFilesInGame = New System.Windows.Forms.ListBox()
        Me.SourceFilesInGame = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FullScreenSubsCheck = New System.Windows.Forms.RadioButton()
        Me.LowerThirdSubsCheck = New System.Windows.Forms.RadioButton()
        Me.AwayTeamSubsLabel = New System.Windows.Forms.Label()
        Me.HomeTeamSubsLablel = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LowerThirdTimePeriodTXT = New System.Windows.Forms.ComboBox()
        Me.ScoreMatchIDRadioBut = New System.Windows.Forms.RadioButton()
        Me.LTMatchIDRadioBut = New System.Windows.Forms.RadioButton()
        Me.LTStrapDate = New System.Windows.Forms.TextBox()
        Me.LTStrapHideBTN = New System.Windows.Forms.Button()
        Me.LTStrapKO = New System.Windows.Forms.TextBox()
        Me.LTStrapTXBTN = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.AwayGoalWithoutScoreChange_BTN = New System.Windows.Forms.Button()
        Me.HomeGoalWithoutScoreChange_BTN = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.unknownGoalAway = New System.Windows.Forms.Button()
        Me.unknownGoalHome = New System.Windows.Forms.Button()
        Me.AwayHomeGoalBTN = New System.Windows.Forms.Button()
        Me.HomeOwnGoalBTN = New System.Windows.Forms.Button()
        Me.goalAway = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.goalHome = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.commsLoadBTN = New System.Windows.Forms.Button()
        Me.commsSaveBTN = New System.Windows.Forms.Button()
        Me.commsRadWIPE = New System.Windows.Forms.RadioButton()
        Me.commsRadPUSH = New System.Windows.Forms.RadioButton()
        Me.commsRadMIX = New System.Windows.Forms.RadioButton()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.commsMoveDOWNBTN = New System.Windows.Forms.Button()
        Me.commsNextBTN = New System.Windows.Forms.Button()
        Me.commsMoveUpBTN = New System.Windows.Forms.Button()
        Me.commsStopBTN = New System.Windows.Forms.Button()
        Me.commsPlayBTN = New System.Windows.Forms.Button()
        Me.commsClearBTN = New System.Windows.Forms.Button()
        Me.commsRemoveBTN = New System.Windows.Forms.Button()
        Me.commsAddBTN = New System.Windows.Forms.Button()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.commsRefreshBTN = New System.Windows.Forms.Button()
        Me.commsPlayListLB = New System.Windows.Forms.ListBox()
        Me.commsSourceFilesLB = New System.Windows.Forms.ListBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.commsChooseBackingBTN = New System.Windows.Forms.Button()
        Me.commsChooseBackingCOMBI = New System.Windows.Forms.ComboBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.commericalRefreshImagesBTN = New System.Windows.Forms.Button()
        Me.commercialCHooseImage = New System.Windows.Forms.ComboBox()
        Me.commercialRefreshTemplateListBTN = New System.Windows.Forms.Button()
        Me.commercialChooseTemplate = New System.Windows.Forms.ComboBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.commercialsRadio4 = New System.Windows.Forms.RadioButton()
        Me.commercialsRadio3 = New System.Windows.Forms.RadioButton()
        Me.commercialsRadio2 = New System.Windows.Forms.RadioButton()
        Me.commercialsRadio1 = New System.Windows.Forms.RadioButton()
        Me.commercialsCrawlText4 = New System.Windows.Forms.TextBox()
        Me.commercialsCrawlText3 = New System.Windows.Forms.TextBox()
        Me.commercialsCrawlText2 = New System.Windows.Forms.TextBox()
        Me.CommercialCrawlOffBTN = New System.Windows.Forms.Button()
        Me.CommercialCrawlOnBTN = New System.Windows.Forms.Button()
        Me.commercialsCrawlText1 = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Msg8ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg7ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg6ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg5ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg4ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg3ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg2ColPickBTN = New System.Windows.Forms.Button()
        Me.Msg1ColPickBTN = New System.Windows.Forms.Button()
        Me.msg8OffBtn = New System.Windows.Forms.Button()
        Me.msg8OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx8 = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.backgrounds8 = New System.Windows.Forms.ComboBox()
        Me.msg8Line4 = New System.Windows.Forms.TextBox()
        Me.msg8Line3 = New System.Windows.Forms.TextBox()
        Me.msg8Line2 = New System.Windows.Forms.TextBox()
        Me.msg8Line1 = New System.Windows.Forms.TextBox()
        Me.msg8Title = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.msg7OffBtn = New System.Windows.Forms.Button()
        Me.msg7OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx7 = New System.Windows.Forms.Button()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.backgrounds7 = New System.Windows.Forms.ComboBox()
        Me.msg7Line4 = New System.Windows.Forms.TextBox()
        Me.msg7Line3 = New System.Windows.Forms.TextBox()
        Me.msg7Line2 = New System.Windows.Forms.TextBox()
        Me.msg7Line1 = New System.Windows.Forms.TextBox()
        Me.msg7Title = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.msg6OffBtn = New System.Windows.Forms.Button()
        Me.msg6OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx6 = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.backgrounds6 = New System.Windows.Forms.ComboBox()
        Me.msg6Line4 = New System.Windows.Forms.TextBox()
        Me.msg6Line3 = New System.Windows.Forms.TextBox()
        Me.msg6Line2 = New System.Windows.Forms.TextBox()
        Me.msg6Line1 = New System.Windows.Forms.TextBox()
        Me.msg6Title = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.msg5OffBtn = New System.Windows.Forms.Button()
        Me.msg5OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx5 = New System.Windows.Forms.Button()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.backgrounds5 = New System.Windows.Forms.ComboBox()
        Me.msg5Line4 = New System.Windows.Forms.TextBox()
        Me.msg5Line3 = New System.Windows.Forms.TextBox()
        Me.msg5Line2 = New System.Windows.Forms.TextBox()
        Me.msg5Line1 = New System.Windows.Forms.TextBox()
        Me.msg5Title = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.msg4OffBtn = New System.Windows.Forms.Button()
        Me.msg4OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx4 = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.backgrounds4 = New System.Windows.Forms.ComboBox()
        Me.msg4Line4 = New System.Windows.Forms.TextBox()
        Me.msg4Line3 = New System.Windows.Forms.TextBox()
        Me.msg4Line2 = New System.Windows.Forms.TextBox()
        Me.msg4Line1 = New System.Windows.Forms.TextBox()
        Me.msg4Title = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.msg3OffBtn = New System.Windows.Forms.Button()
        Me.msg3OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx3 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.backgrounds3 = New System.Windows.Forms.ComboBox()
        Me.msg3Line4 = New System.Windows.Forms.TextBox()
        Me.msg3Line3 = New System.Windows.Forms.TextBox()
        Me.msg3Line2 = New System.Windows.Forms.TextBox()
        Me.msg3Line1 = New System.Windows.Forms.TextBox()
        Me.msg3Title = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.msg2OffBtn = New System.Windows.Forms.Button()
        Me.msg2OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx2 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.backgrounds2 = New System.Windows.Forms.ComboBox()
        Me.msg2Line4 = New System.Windows.Forms.TextBox()
        Me.msg2Line3 = New System.Windows.Forms.TextBox()
        Me.msg2Line2 = New System.Windows.Forms.TextBox()
        Me.msg2Line1 = New System.Windows.Forms.TextBox()
        Me.msg2Title = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.msg1OffBtn = New System.Windows.Forms.Button()
        Me.msg1OnBtn = New System.Windows.Forms.Button()
        Me.ReloadBackgroundsComboBx = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.backgrounds1 = New System.Windows.Forms.ComboBox()
        Me.msg1Line4 = New System.Windows.Forms.TextBox()
        Me.msg1Line3 = New System.Windows.Forms.TextBox()
        Me.msg1Line2 = New System.Windows.Forms.TextBox()
        Me.msg1Line1 = New System.Windows.Forms.TextBox()
        Me.msg1Title = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.webPageOff2BTN = New System.Windows.Forms.Button()
        Me.webPageOn2BTN = New System.Windows.Forms.Button()
        Me.urlText2TXT = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.webPageOff1BTN = New System.Windows.Forms.Button()
        Me.webPageOn1BTN = New System.Windows.Forms.Button()
        Me.urlText1TXT = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.miscTempOffBTN2 = New System.Windows.Forms.Button()
        Me.miscTempOnBTN2 = New System.Windows.Forms.Button()
        Me.miscTempText3TXT2 = New System.Windows.Forms.TextBox()
        Me.miscTempText2TXT2 = New System.Windows.Forms.TextBox()
        Me.miscTempText1TXT2 = New System.Windows.Forms.TextBox()
        Me.miscTempName2TXT = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.miscTempOffBTN = New System.Windows.Forms.Button()
        Me.miscTempOnBTN = New System.Windows.Forms.Button()
        Me.miscTempText3TXT = New System.Windows.Forms.TextBox()
        Me.miscTempText2TXT = New System.Windows.Forms.TextBox()
        Me.miscTempText1TXT = New System.Windows.Forms.TextBox()
        Me.miscTempNameTXT = New System.Windows.Forms.TextBox()
        Me.AwayScore = New System.Windows.Forms.TextBox()
        Me.awayThreeLetters = New System.Windows.Forms.TextBox()
        Me.HomeScore = New System.Windows.Forms.TextBox()
        Me.homeThreeLetters = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ClearTXBTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.timeOfDayText = New System.Windows.Forms.Label()
        Me.TimeOfDayCLock = New System.Windows.Forms.Timer(Me.components)
        Me.BPlayChanFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.scoresFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog3 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog4 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog5 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog6 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog7 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog8 = New System.Windows.Forms.ColorDialog()
        Me.ClearGFXOnlyBTN = New System.Windows.Forms.Button()
        Me.playlistStop = New System.Windows.Forms.Timer(Me.components)
        Me.updateScore = New System.Windows.Forms.Button()
        Me.saveBTN = New System.Windows.Forms.Button()
        Me.loadBTN = New System.Windows.Forms.Button()
        Me.commsPlaylistStop = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Clock.SuspendLayout()
        Me.Crawl.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Connect
        '
        Me.Connect.Location = New System.Drawing.Point(12, 12)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(75, 23)
        Me.Connect.TabIndex = 0
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'countTimer
        '
        '
        'OnScreenClock
        '
        Me.OnScreenClock.Interval = 1000
        '
        'Clock
        '
        Me.Clock.Controls.Add(Me.secondHalfRadBTN)
        Me.Clock.Controls.Add(Me.firstHalfRadBTN)
        Me.Clock.Controls.Add(Me.StopTime)
        Me.Clock.Controls.Add(Me.StartTimeLabel)
        Me.Clock.Controls.Add(Me.StopClock)
        Me.Clock.Controls.Add(Me.showClock)
        Me.Clock.Controls.Add(Me.stopClockTime)
        Me.Clock.Controls.Add(Me.startClockTime)
        Me.Clock.Location = New System.Drawing.Point(416, 18)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(369, 120)
        Me.Clock.TabIndex = 3
        Me.Clock.TabStop = False
        Me.Clock.Text = "Clock"
        '
        'secondHalfRadBTN
        '
        Me.secondHalfRadBTN.AutoSize = True
        Me.secondHalfRadBTN.Location = New System.Drawing.Point(200, 16)
        Me.secondHalfRadBTN.Name = "secondHalfRadBTN"
        Me.secondHalfRadBTN.Size = New System.Drawing.Size(65, 17)
        Me.secondHalfRadBTN.TabIndex = 57
        Me.secondHalfRadBTN.Text = "2nd Half"
        Me.secondHalfRadBTN.UseVisualStyleBackColor = True
        '
        'firstHalfRadBTN
        '
        Me.firstHalfRadBTN.AutoSize = True
        Me.firstHalfRadBTN.Checked = True
        Me.firstHalfRadBTN.Location = New System.Drawing.Point(105, 16)
        Me.firstHalfRadBTN.Name = "firstHalfRadBTN"
        Me.firstHalfRadBTN.Size = New System.Drawing.Size(61, 17)
        Me.firstHalfRadBTN.TabIndex = 56
        Me.firstHalfRadBTN.TabStop = True
        Me.firstHalfRadBTN.Text = "1st Half"
        Me.firstHalfRadBTN.UseVisualStyleBackColor = True
        '
        'StopTime
        '
        Me.StopTime.AutoSize = True
        Me.StopTime.Location = New System.Drawing.Point(176, 43)
        Me.StopTime.Name = "StopTime"
        Me.StopTime.Size = New System.Drawing.Size(55, 13)
        Me.StopTime.TabIndex = 55
        Me.StopTime.Text = "Stop Time"
        '
        'StartTimeLabel
        '
        Me.StartTimeLabel.AutoSize = True
        Me.StartTimeLabel.Location = New System.Drawing.Point(6, 44)
        Me.StartTimeLabel.Name = "StartTimeLabel"
        Me.StartTimeLabel.Size = New System.Drawing.Size(55, 13)
        Me.StartTimeLabel.TabIndex = 54
        Me.StartTimeLabel.Text = "Start Time"
        '
        'StopClock
        '
        Me.StopClock.Location = New System.Drawing.Point(200, 72)
        Me.StopClock.Name = "StopClock"
        Me.StopClock.Size = New System.Drawing.Size(160, 33)
        Me.StopClock.TabIndex = 12
        Me.StopClock.Text = "Stop Clock"
        Me.StopClock.UseVisualStyleBackColor = True
        '
        'showClock
        '
        Me.showClock.Location = New System.Drawing.Point(8, 71)
        Me.showClock.Name = "showClock"
        Me.showClock.Size = New System.Drawing.Size(186, 34)
        Me.showClock.TabIndex = 11
        Me.showClock.Text = "Show Clock"
        Me.showClock.UseVisualStyleBackColor = True
        '
        'stopClockTime
        '
        Me.stopClockTime.Location = New System.Drawing.Point(237, 40)
        Me.stopClockTime.Name = "stopClockTime"
        Me.stopClockTime.Size = New System.Drawing.Size(100, 20)
        Me.stopClockTime.TabIndex = 1
        Me.stopClockTime.Text = "45"
        '
        'startClockTime
        '
        Me.startClockTime.Location = New System.Drawing.Point(67, 40)
        Me.startClockTime.Name = "startClockTime"
        Me.startClockTime.Size = New System.Drawing.Size(100, 20)
        Me.startClockTime.TabIndex = 0
        Me.startClockTime.Text = "0"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.sec.Location = New System.Drawing.Point(569, 46)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(46, 31)
        Me.sec.TabIndex = 5
        Me.sec.Text = "00"
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.min.Location = New System.Drawing.Point(517, 46)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(46, 31)
        Me.min.TabIndex = 4
        Me.min.Text = "00"
        Me.min.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'clockAnimation
        '
        '
        'Crawl
        '
        Me.Crawl.Controls.Add(Me.Label85)
        Me.Crawl.Controls.Add(Me.Label84)
        Me.Crawl.Controls.Add(Me.Label82)
        Me.Crawl.Controls.Add(Me.Label80)
        Me.Crawl.Controls.Add(Me.UpdateTextButton)
        Me.Crawl.Controls.Add(Me.RadioButton4)
        Me.Crawl.Controls.Add(Me.RadioButton3)
        Me.Crawl.Controls.Add(Me.RadioButton2)
        Me.Crawl.Controls.Add(Me.RadioButton1)
        Me.Crawl.Controls.Add(Me.CrawlText4)
        Me.Crawl.Controls.Add(Me.CrawlText3)
        Me.Crawl.Controls.Add(Me.CrawlText2)
        Me.Crawl.Controls.Add(Me.CrawlOff)
        Me.Crawl.Controls.Add(Me.CrawlOn)
        Me.Crawl.Controls.Add(Me.CrawlText1)
        Me.Crawl.Location = New System.Drawing.Point(18, 171)
        Me.Crawl.Name = "Crawl"
        Me.Crawl.Size = New System.Drawing.Size(369, 171)
        Me.Crawl.TabIndex = 16
        Me.Crawl.TabStop = False
        Me.Crawl.Text = "Crawl"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(3, 100)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(13, 13)
        Me.Label85.TabIndex = 122
        Me.Label85.Text = "4"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(3, 74)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(13, 13)
        Me.Label84.TabIndex = 121
        Me.Label84.Text = "3"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(3, 48)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(13, 13)
        Me.Label82.TabIndex = 120
        Me.Label82.Text = "2"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(3, 22)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(13, 13)
        Me.Label80.TabIndex = 119
        Me.Label80.Text = "1"
        '
        'UpdateTextButton
        '
        Me.UpdateTextButton.Location = New System.Drawing.Point(87, 140)
        Me.UpdateTextButton.Name = "UpdateTextButton"
        Me.UpdateTextButton.Size = New System.Drawing.Size(100, 23)
        Me.UpdateTextButton.TabIndex = 9
        Me.UpdateTextButton.Text = "Update Text (TX)"
        Me.UpdateTextButton.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(342, 100)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(342, 74)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(342, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(342, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CrawlText4
        '
        Me.CrawlText4.Location = New System.Drawing.Point(22, 97)
        Me.CrawlText4.Name = "CrawlText4"
        Me.CrawlText4.Size = New System.Drawing.Size(314, 20)
        Me.CrawlText4.TabIndex = 6
        Me.CrawlText4.Text = "Crawl Text Goes Here"
        '
        'CrawlText3
        '
        Me.CrawlText3.Location = New System.Drawing.Point(22, 71)
        Me.CrawlText3.Name = "CrawlText3"
        Me.CrawlText3.Size = New System.Drawing.Size(314, 20)
        Me.CrawlText3.TabIndex = 4
        Me.CrawlText3.Text = "Crawl Text Goes Here"
        '
        'CrawlText2
        '
        Me.CrawlText2.Location = New System.Drawing.Point(22, 45)
        Me.CrawlText2.Name = "CrawlText2"
        Me.CrawlText2.Size = New System.Drawing.Size(314, 20)
        Me.CrawlText2.TabIndex = 2
        Me.CrawlText2.Text = "Crawl Text Goes Here"
        '
        'CrawlOff
        '
        Me.CrawlOff.Location = New System.Drawing.Point(274, 140)
        Me.CrawlOff.Name = "CrawlOff"
        Me.CrawlOff.Size = New System.Drawing.Size(75, 23)
        Me.CrawlOff.TabIndex = 10
        Me.CrawlOff.Text = "Crawl Off"
        Me.CrawlOff.UseVisualStyleBackColor = True
        '
        'CrawlOn
        '
        Me.CrawlOn.Location = New System.Drawing.Point(6, 140)
        Me.CrawlOn.Name = "CrawlOn"
        Me.CrawlOn.Size = New System.Drawing.Size(75, 23)
        Me.CrawlOn.TabIndex = 8
        Me.CrawlOn.Text = "Crawl On"
        Me.CrawlOn.UseVisualStyleBackColor = True
        '
        'CrawlText1
        '
        Me.CrawlText1.Location = New System.Drawing.Point(22, 19)
        Me.CrawlText1.Name = "CrawlText1"
        Me.CrawlText1.Size = New System.Drawing.Size(314, 20)
        Me.CrawlText1.TabIndex = 0
        Me.CrawlText1.Text = "Crawl Text Goes Here"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 71)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 316)
        Me.ListBox1.TabIndex = 19
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(246, 71)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(220, 316)
        Me.ListBox2.TabIndex = 20
        '
        'SubOn
        '
        Me.SubOn.FormattingEnabled = True
        Me.SubOn.Location = New System.Drawing.Point(55, 47)
        Me.SubOn.Name = "SubOn"
        Me.SubOn.Size = New System.Drawing.Size(124, 21)
        Me.SubOn.TabIndex = 7
        '
        'SubOff
        '
        Me.SubOff.FormattingEnabled = True
        Me.SubOff.Location = New System.Drawing.Point(55, 74)
        Me.SubOff.Name = "SubOff"
        Me.SubOff.Size = New System.Drawing.Size(124, 21)
        Me.SubOff.TabIndex = 8
        '
        'aw_subOff
        '
        Me.aw_subOff.FormattingEnabled = True
        Me.aw_subOff.Location = New System.Drawing.Point(230, 74)
        Me.aw_subOff.Name = "aw_subOff"
        Me.aw_subOff.Size = New System.Drawing.Size(119, 21)
        Me.aw_subOff.TabIndex = 12
        '
        'aw_subOn
        '
        Me.aw_subOn.FormattingEnabled = True
        Me.aw_subOn.Location = New System.Drawing.Point(230, 47)
        Me.aw_subOn.Name = "aw_subOn"
        Me.aw_subOn.Size = New System.Drawing.Size(119, 21)
        Me.aw_subOn.TabIndex = 11
        '
        'LoadTeams
        '
        Me.LoadTeams.Location = New System.Drawing.Point(19, 15)
        Me.LoadTeams.Name = "LoadTeams"
        Me.LoadTeams.Size = New System.Drawing.Size(98, 39)
        Me.LoadTeams.TabIndex = 0
        Me.LoadTeams.Text = "Load Squads"
        Me.LoadTeams.UseVisualStyleBackColor = True
        '
        'showSub
        '
        Me.showSub.Location = New System.Drawing.Point(17, 101)
        Me.showSub.Name = "showSub"
        Me.showSub.Size = New System.Drawing.Size(75, 21)
        Me.showSub.TabIndex = 9
        Me.showSub.Text = "Sub GFX On"
        Me.showSub.UseVisualStyleBackColor = True
        '
        'SubOFFBtn
        '
        Me.SubOFFBtn.Location = New System.Drawing.Point(104, 101)
        Me.SubOFFBtn.Name = "SubOFFBtn"
        Me.SubOFFBtn.Size = New System.Drawing.Size(75, 21)
        Me.SubOFFBtn.TabIndex = 10
        Me.SubOFFBtn.Text = "SubGFX Off"
        Me.SubOFFBtn.UseVisualStyleBackColor = True
        '
        'ShowTeamSheet
        '
        Me.ShowTeamSheet.Location = New System.Drawing.Point(16, 500)
        Me.ShowTeamSheet.Name = "ShowTeamSheet"
        Me.ShowTeamSheet.Size = New System.Drawing.Size(210, 23)
        Me.ShowTeamSheet.TabIndex = 1
        Me.ShowTeamSheet.Text = "Show 1st 11"
        Me.ShowTeamSheet.UseVisualStyleBackColor = True
        '
        'ShowSubsSheet
        '
        Me.ShowSubsSheet.Location = New System.Drawing.Point(16, 529)
        Me.ShowSubsSheet.Name = "ShowSubsSheet"
        Me.ShowSubsSheet.Size = New System.Drawing.Size(210, 23)
        Me.ShowSubsSheet.TabIndex = 2
        Me.ShowSubsSheet.Text = "Show Subs"
        Me.ShowSubsSheet.UseVisualStyleBackColor = True
        '
        'Ts_Off
        '
        Me.Ts_Off.Location = New System.Drawing.Point(16, 554)
        Me.Ts_Off.Name = "Ts_Off"
        Me.Ts_Off.Size = New System.Drawing.Size(210, 52)
        Me.Ts_Off.TabIndex = 3
        Me.Ts_Off.Text = "OFF"
        Me.Ts_Off.UseVisualStyleBackColor = True
        '
        'backgroundOn
        '
        Me.backgroundOn.AutoSize = True
        Me.backgroundOn.Location = New System.Drawing.Point(114, 16)
        Me.backgroundOn.Name = "backgroundOn"
        Me.backgroundOn.Size = New System.Drawing.Size(128, 17)
        Me.backgroundOn.TabIndex = 1
        Me.backgroundOn.Text = "Background On PGM"
        Me.backgroundOn.UseVisualStyleBackColor = True
        '
        'PremScoresTitle
        '
        Me.PremScoresTitle.Location = New System.Drawing.Point(21, 19)
        Me.PremScoresTitle.Name = "PremScoresTitle"
        Me.PremScoresTitle.Size = New System.Drawing.Size(126, 20)
        Me.PremScoresTitle.TabIndex = 55
        Me.PremScoresTitle.Text = "LATEST SCORES"
        '
        'HidePremScoresBTN
        '
        Me.HidePremScoresBTN.Location = New System.Drawing.Point(729, 206)
        Me.HidePremScoresBTN.Name = "HidePremScoresBTN"
        Me.HidePremScoresBTN.Size = New System.Drawing.Size(102, 26)
        Me.HidePremScoresBTN.TabIndex = 54
        Me.HidePremScoresBTN.Text = "Hide"
        Me.HidePremScoresBTN.UseVisualStyleBackColor = True
        '
        'TXPremScores_2BTN
        '
        Me.TXPremScores_2BTN.Location = New System.Drawing.Point(460, 206)
        Me.TXPremScores_2BTN.Name = "TXPremScores_2BTN"
        Me.TXPremScores_2BTN.Size = New System.Drawing.Size(102, 26)
        Me.TXPremScores_2BTN.TabIndex = 53
        Me.TXPremScores_2BTN.Text = "Show"
        Me.TXPremScores_2BTN.UseVisualStyleBackColor = True
        '
        'Score47
        '
        Me.Score47.Location = New System.Drawing.Point(665, 180)
        Me.Score47.Name = "Score47"
        Me.Score47.Size = New System.Drawing.Size(34, 20)
        Me.Score47.TabIndex = 51
        '
        'Score48
        '
        Me.Score48.Location = New System.Drawing.Point(705, 180)
        Me.Score48.Name = "Score48"
        Me.Score48.Size = New System.Drawing.Size(126, 20)
        Me.Score48.TabIndex = 52
        '
        'Score46
        '
        Me.Score46.Location = New System.Drawing.Point(592, 180)
        Me.Score46.Name = "Score46"
        Me.Score46.Size = New System.Drawing.Size(34, 20)
        Me.Score46.TabIndex = 50
        '
        'Score45
        '
        Me.Score45.Location = New System.Drawing.Point(460, 180)
        Me.Score45.Name = "Score45"
        Me.Score45.Size = New System.Drawing.Size(126, 20)
        Me.Score45.TabIndex = 49
        '
        'Score43
        '
        Me.Score43.Location = New System.Drawing.Point(665, 154)
        Me.Score43.Name = "Score43"
        Me.Score43.Size = New System.Drawing.Size(34, 20)
        Me.Score43.TabIndex = 47
        '
        'Score44
        '
        Me.Score44.Location = New System.Drawing.Point(705, 154)
        Me.Score44.Name = "Score44"
        Me.Score44.Size = New System.Drawing.Size(126, 20)
        Me.Score44.TabIndex = 48
        '
        'Score42
        '
        Me.Score42.Location = New System.Drawing.Point(592, 154)
        Me.Score42.Name = "Score42"
        Me.Score42.Size = New System.Drawing.Size(34, 20)
        Me.Score42.TabIndex = 46
        '
        'Score41
        '
        Me.Score41.Location = New System.Drawing.Point(460, 154)
        Me.Score41.Name = "Score41"
        Me.Score41.Size = New System.Drawing.Size(126, 20)
        Me.Score41.TabIndex = 45
        '
        'Score39
        '
        Me.Score39.Location = New System.Drawing.Point(665, 128)
        Me.Score39.Name = "Score39"
        Me.Score39.Size = New System.Drawing.Size(34, 20)
        Me.Score39.TabIndex = 43
        '
        'Score40
        '
        Me.Score40.Location = New System.Drawing.Point(705, 128)
        Me.Score40.Name = "Score40"
        Me.Score40.Size = New System.Drawing.Size(126, 20)
        Me.Score40.TabIndex = 44
        '
        'Score38
        '
        Me.Score38.Location = New System.Drawing.Point(592, 128)
        Me.Score38.Name = "Score38"
        Me.Score38.Size = New System.Drawing.Size(34, 20)
        Me.Score38.TabIndex = 42
        '
        'Score37
        '
        Me.Score37.Location = New System.Drawing.Point(460, 128)
        Me.Score37.Name = "Score37"
        Me.Score37.Size = New System.Drawing.Size(126, 20)
        Me.Score37.TabIndex = 41
        '
        'Score35
        '
        Me.Score35.Location = New System.Drawing.Point(665, 102)
        Me.Score35.Name = "Score35"
        Me.Score35.Size = New System.Drawing.Size(34, 20)
        Me.Score35.TabIndex = 39
        '
        'Score36
        '
        Me.Score36.Location = New System.Drawing.Point(705, 102)
        Me.Score36.Name = "Score36"
        Me.Score36.Size = New System.Drawing.Size(126, 20)
        Me.Score36.TabIndex = 40
        '
        'Score34
        '
        Me.Score34.Location = New System.Drawing.Point(592, 102)
        Me.Score34.Name = "Score34"
        Me.Score34.Size = New System.Drawing.Size(34, 20)
        Me.Score34.TabIndex = 38
        '
        'Score33
        '
        Me.Score33.Location = New System.Drawing.Point(460, 102)
        Me.Score33.Name = "Score33"
        Me.Score33.Size = New System.Drawing.Size(126, 20)
        Me.Score33.TabIndex = 37
        '
        'Score31
        '
        Me.Score31.Location = New System.Drawing.Point(665, 76)
        Me.Score31.Name = "Score31"
        Me.Score31.Size = New System.Drawing.Size(34, 20)
        Me.Score31.TabIndex = 35
        '
        'Score32
        '
        Me.Score32.Location = New System.Drawing.Point(705, 76)
        Me.Score32.Name = "Score32"
        Me.Score32.Size = New System.Drawing.Size(126, 20)
        Me.Score32.TabIndex = 36
        '
        'Score30
        '
        Me.Score30.Location = New System.Drawing.Point(592, 76)
        Me.Score30.Name = "Score30"
        Me.Score30.Size = New System.Drawing.Size(34, 20)
        Me.Score30.TabIndex = 34
        '
        'Score29
        '
        Me.Score29.Location = New System.Drawing.Point(460, 76)
        Me.Score29.Name = "Score29"
        Me.Score29.Size = New System.Drawing.Size(126, 20)
        Me.Score29.TabIndex = 32
        '
        'Score27
        '
        Me.Score27.Location = New System.Drawing.Point(665, 50)
        Me.Score27.Name = "Score27"
        Me.Score27.Size = New System.Drawing.Size(34, 20)
        Me.Score27.TabIndex = 30
        '
        'Score28
        '
        Me.Score28.Location = New System.Drawing.Point(705, 50)
        Me.Score28.Name = "Score28"
        Me.Score28.Size = New System.Drawing.Size(126, 20)
        Me.Score28.TabIndex = 31
        '
        'Score26
        '
        Me.Score26.Location = New System.Drawing.Point(592, 50)
        Me.Score26.Name = "Score26"
        Me.Score26.Size = New System.Drawing.Size(34, 20)
        Me.Score26.TabIndex = 29
        '
        'Score25
        '
        Me.Score25.Location = New System.Drawing.Point(460, 50)
        Me.Score25.Name = "Score25"
        Me.Score25.Size = New System.Drawing.Size(126, 20)
        Me.Score25.TabIndex = 28
        '
        'HidePremScores
        '
        Me.HidePremScores.Location = New System.Drawing.Point(289, 206)
        Me.HidePremScores.Name = "HidePremScores"
        Me.HidePremScores.Size = New System.Drawing.Size(102, 26)
        Me.HidePremScores.TabIndex = 25
        Me.HidePremScores.Text = "Hide"
        Me.HidePremScores.UseVisualStyleBackColor = True
        '
        'showPremScores
        '
        Me.showPremScores.Location = New System.Drawing.Point(25, 206)
        Me.showPremScores.Name = "showPremScores"
        Me.showPremScores.Size = New System.Drawing.Size(102, 26)
        Me.showPremScores.TabIndex = 24
        Me.showPremScores.Text = "Show"
        Me.showPremScores.UseVisualStyleBackColor = True
        '
        'Score23
        '
        Me.Score23.Location = New System.Drawing.Point(225, 180)
        Me.Score23.Name = "Score23"
        Me.Score23.Size = New System.Drawing.Size(34, 20)
        Me.Score23.TabIndex = 22
        '
        'Score24
        '
        Me.Score24.Location = New System.Drawing.Point(265, 180)
        Me.Score24.Name = "Score24"
        Me.Score24.Size = New System.Drawing.Size(126, 20)
        Me.Score24.TabIndex = 23
        '
        'Score22
        '
        Me.Score22.Location = New System.Drawing.Point(153, 180)
        Me.Score22.Name = "Score22"
        Me.Score22.Size = New System.Drawing.Size(34, 20)
        Me.Score22.TabIndex = 21
        '
        'Score21
        '
        Me.Score21.Location = New System.Drawing.Point(21, 180)
        Me.Score21.Name = "Score21"
        Me.Score21.Size = New System.Drawing.Size(126, 20)
        Me.Score21.TabIndex = 20
        '
        'Score19
        '
        Me.Score19.Location = New System.Drawing.Point(225, 154)
        Me.Score19.Name = "Score19"
        Me.Score19.Size = New System.Drawing.Size(34, 20)
        Me.Score19.TabIndex = 18
        '
        'Score20
        '
        Me.Score20.Location = New System.Drawing.Point(265, 154)
        Me.Score20.Name = "Score20"
        Me.Score20.Size = New System.Drawing.Size(126, 20)
        Me.Score20.TabIndex = 19
        '
        'Score18
        '
        Me.Score18.Location = New System.Drawing.Point(153, 154)
        Me.Score18.Name = "Score18"
        Me.Score18.Size = New System.Drawing.Size(34, 20)
        Me.Score18.TabIndex = 17
        '
        'Score17
        '
        Me.Score17.Location = New System.Drawing.Point(21, 154)
        Me.Score17.Name = "Score17"
        Me.Score17.Size = New System.Drawing.Size(126, 20)
        Me.Score17.TabIndex = 16
        '
        'Score15
        '
        Me.Score15.Location = New System.Drawing.Point(225, 128)
        Me.Score15.Name = "Score15"
        Me.Score15.Size = New System.Drawing.Size(34, 20)
        Me.Score15.TabIndex = 14
        '
        'Score16
        '
        Me.Score16.Location = New System.Drawing.Point(265, 128)
        Me.Score16.Name = "Score16"
        Me.Score16.Size = New System.Drawing.Size(126, 20)
        Me.Score16.TabIndex = 15
        '
        'Score14
        '
        Me.Score14.Location = New System.Drawing.Point(153, 128)
        Me.Score14.Name = "Score14"
        Me.Score14.Size = New System.Drawing.Size(34, 20)
        Me.Score14.TabIndex = 13
        '
        'Score13
        '
        Me.Score13.Location = New System.Drawing.Point(21, 128)
        Me.Score13.Name = "Score13"
        Me.Score13.Size = New System.Drawing.Size(126, 20)
        Me.Score13.TabIndex = 12
        '
        'Score11
        '
        Me.Score11.Location = New System.Drawing.Point(225, 102)
        Me.Score11.Name = "Score11"
        Me.Score11.Size = New System.Drawing.Size(34, 20)
        Me.Score11.TabIndex = 10
        '
        'Score12
        '
        Me.Score12.Location = New System.Drawing.Point(265, 102)
        Me.Score12.Name = "Score12"
        Me.Score12.Size = New System.Drawing.Size(126, 20)
        Me.Score12.TabIndex = 11
        '
        'Score10
        '
        Me.Score10.Location = New System.Drawing.Point(153, 102)
        Me.Score10.Name = "Score10"
        Me.Score10.Size = New System.Drawing.Size(34, 20)
        Me.Score10.TabIndex = 9
        '
        'Score9
        '
        Me.Score9.Location = New System.Drawing.Point(21, 102)
        Me.Score9.Name = "Score9"
        Me.Score9.Size = New System.Drawing.Size(126, 20)
        Me.Score9.TabIndex = 8
        '
        'Score7
        '
        Me.Score7.Location = New System.Drawing.Point(225, 76)
        Me.Score7.Name = "Score7"
        Me.Score7.Size = New System.Drawing.Size(34, 20)
        Me.Score7.TabIndex = 6
        '
        'Score8
        '
        Me.Score8.Location = New System.Drawing.Point(265, 76)
        Me.Score8.Name = "Score8"
        Me.Score8.Size = New System.Drawing.Size(126, 20)
        Me.Score8.TabIndex = 7
        '
        'Score6
        '
        Me.Score6.Location = New System.Drawing.Point(153, 76)
        Me.Score6.Name = "Score6"
        Me.Score6.Size = New System.Drawing.Size(34, 20)
        Me.Score6.TabIndex = 5
        '
        'Score5
        '
        Me.Score5.Location = New System.Drawing.Point(21, 76)
        Me.Score5.Name = "Score5"
        Me.Score5.Size = New System.Drawing.Size(126, 20)
        Me.Score5.TabIndex = 4
        '
        'Score3
        '
        Me.Score3.Location = New System.Drawing.Point(225, 50)
        Me.Score3.Name = "Score3"
        Me.Score3.Size = New System.Drawing.Size(34, 20)
        Me.Score3.TabIndex = 2
        '
        'Score4
        '
        Me.Score4.Location = New System.Drawing.Point(265, 50)
        Me.Score4.Name = "Score4"
        Me.Score4.Size = New System.Drawing.Size(126, 20)
        Me.Score4.TabIndex = 3
        '
        'Score2
        '
        Me.Score2.Location = New System.Drawing.Point(153, 50)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(34, 20)
        Me.Score2.TabIndex = 1
        '
        'Score1
        '
        Me.Score1.Location = New System.Drawing.Point(21, 50)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(126, 20)
        Me.Score1.TabIndex = 0
        '
        'AwayTeamsOff
        '
        Me.AwayTeamsOff.Location = New System.Drawing.Point(246, 554)
        Me.AwayTeamsOff.Name = "AwayTeamsOff"
        Me.AwayTeamsOff.Size = New System.Drawing.Size(220, 52)
        Me.AwayTeamsOff.TabIndex = 6
        Me.AwayTeamsOff.Text = "OFF"
        Me.AwayTeamsOff.UseVisualStyleBackColor = True
        '
        'ShowAwaySubsSheet
        '
        Me.ShowAwaySubsSheet.Location = New System.Drawing.Point(246, 528)
        Me.ShowAwaySubsSheet.Name = "ShowAwaySubsSheet"
        Me.ShowAwaySubsSheet.Size = New System.Drawing.Size(220, 23)
        Me.ShowAwaySubsSheet.TabIndex = 5
        Me.ShowAwaySubsSheet.Text = "Show Subs"
        Me.ShowAwaySubsSheet.UseVisualStyleBackColor = True
        '
        'ShowAwayFirstEleven
        '
        Me.ShowAwayFirstEleven.Location = New System.Drawing.Point(246, 501)
        Me.ShowAwayFirstEleven.Name = "ShowAwayFirstEleven"
        Me.ShowAwayFirstEleven.Size = New System.Drawing.Size(220, 23)
        Me.ShowAwayFirstEleven.TabIndex = 4
        Me.ShowAwayFirstEleven.Text = "Show 1st 11"
        Me.ShowAwayFirstEleven.UseVisualStyleBackColor = True
        '
        'AwaySubOff
        '
        Me.AwaySubOff.Location = New System.Drawing.Point(275, 101)
        Me.AwaySubOff.Name = "AwaySubOff"
        Me.AwaySubOff.Size = New System.Drawing.Size(75, 21)
        Me.AwaySubOff.TabIndex = 14
        Me.AwaySubOff.Text = "SubGFX Off"
        Me.AwaySubOff.UseVisualStyleBackColor = True
        '
        'AwaySubOn
        '
        Me.AwaySubOn.Location = New System.Drawing.Point(194, 101)
        Me.AwaySubOn.Name = "AwaySubOn"
        Me.AwaySubOn.Size = New System.Drawing.Size(75, 21)
        Me.AwaySubOn.TabIndex = 13
        Me.AwaySubOn.Text = "Sub GFX On"
        Me.AwaySubOn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(12, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1260, 662)
        Me.TabControl1.TabIndex = 61
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage6.Controls.Add(Me.loadLastAwaySquadBTN)
        Me.TabPage6.Controls.Add(Me.loadLastHomeSquadBTN)
        Me.TabPage6.Controls.Add(Me.HomeTeam)
        Me.TabPage6.Controls.Add(Me.AwayTeam)
        Me.TabPage6.Controls.Add(Me.Panel4)
        Me.TabPage6.Controls.Add(Me.AwaySubsCount)
        Me.TabPage6.Controls.Add(Me.Label81)
        Me.TabPage6.Controls.Add(Me.homeSubsCount)
        Me.TabPage6.Controls.Add(Me.Label83)
        Me.TabPage6.Controls.Add(Me.Label75)
        Me.TabPage6.Controls.Add(Me.Label74)
        Me.TabPage6.Controls.Add(Me.AwayTeamName)
        Me.TabPage6.Controls.Add(Me.HomeTeamName)
        Me.TabPage6.Controls.Add(Me.AwayMoveDown)
        Me.TabPage6.Controls.Add(Me.AwayMoveUp)
        Me.TabPage6.Controls.Add(Me.HomeDown)
        Me.TabPage6.Controls.Add(Me.HomeMoveUp)
        Me.TabPage6.Controls.Add(Me.AwayPlayerCount)
        Me.TabPage6.Controls.Add(Me.Label10)
        Me.TabPage6.Controls.Add(Me.homePlayerCount)
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.AddtoSqaudNotListedAway)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.AwayPlayerNotListed)
        Me.TabPage6.Controls.Add(Me.AddtoSquadNotListed)
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.HomePlayerNotListed)
        Me.TabPage6.Controls.Add(Me.updateAllTeams)
        Me.TabPage6.Controls.Add(Me.clearAwaySquad)
        Me.TabPage6.Controls.Add(Me.removeAwaySquad)
        Me.TabPage6.Controls.Add(Me.addAwaySquad)
        Me.TabPage6.Controls.Add(Me.HomeClearSquadList)
        Me.TabPage6.Controls.Add(Me.removeHomeSquad)
        Me.TabPage6.Controls.Add(Me.addHomeSquad)
        Me.TabPage6.Controls.Add(Me.FullAwaySquad)
        Me.TabPage6.Controls.Add(Me.FullHomeSquad)
        Me.TabPage6.Controls.Add(Me.LoadTeams)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Set Up Teams"
        '
        'loadLastAwaySquadBTN
        '
        Me.loadLastAwaySquadBTN.Location = New System.Drawing.Point(571, 328)
        Me.loadLastAwaySquadBTN.Name = "loadLastAwaySquadBTN"
        Me.loadLastAwaySquadBTN.Size = New System.Drawing.Size(188, 23)
        Me.loadLastAwaySquadBTN.TabIndex = 122
        Me.loadLastAwaySquadBTN.Text = "Load Last Squad"
        Me.loadLastAwaySquadBTN.UseVisualStyleBackColor = True
        '
        'loadLastHomeSquadBTN
        '
        Me.loadLastHomeSquadBTN.Location = New System.Drawing.Point(369, 328)
        Me.loadLastHomeSquadBTN.Name = "loadLastHomeSquadBTN"
        Me.loadLastHomeSquadBTN.Size = New System.Drawing.Size(188, 23)
        Me.loadLastHomeSquadBTN.TabIndex = 121
        Me.loadLastHomeSquadBTN.Text = "Load Last Squad"
        Me.loadLastHomeSquadBTN.UseVisualStyleBackColor = True
        '
        'HomeTeam
        '
        Me.HomeTeam.FormattingEnabled = True
        Me.HomeTeam.Location = New System.Drawing.Point(369, 72)
        Me.HomeTeam.Name = "HomeTeam"
        Me.HomeTeam.Size = New System.Drawing.Size(188, 251)
        Me.HomeTeam.TabIndex = 2
        '
        'AwayTeam
        '
        Me.AwayTeam.FormattingEnabled = True
        Me.AwayTeam.Location = New System.Drawing.Point(571, 72)
        Me.AwayTeam.Name = "AwayTeam"
        Me.AwayTeam.Size = New System.Drawing.Size(193, 251)
        Me.AwayTeam.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel4.Location = New System.Drawing.Point(356, 216)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(420, 107)
        Me.Panel4.TabIndex = 120
        '
        'AwaySubsCount
        '
        Me.AwaySubsCount.AutoSize = True
        Me.AwaySubsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwaySubsCount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AwaySubsCount.Location = New System.Drawing.Point(819, 418)
        Me.AwaySubsCount.Name = "AwaySubsCount"
        Me.AwaySubsCount.Size = New System.Drawing.Size(37, 39)
        Me.AwaySubsCount.TabIndex = 85
        Me.AwaySubsCount.Text = "0"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label81.Location = New System.Drawing.Point(777, 381)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(118, 24)
        Me.Label81.TabIndex = 84
        Me.Label81.Text = "Subs Count"
        '
        'homeSubsCount
        '
        Me.homeSubsCount.AutoSize = True
        Me.homeSubsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeSubsCount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.homeSubsCount.Location = New System.Drawing.Point(269, 418)
        Me.homeSubsCount.Name = "homeSubsCount"
        Me.homeSubsCount.Size = New System.Drawing.Size(37, 39)
        Me.homeSubsCount.TabIndex = 83
        Me.homeSubsCount.Text = "0"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label83.Location = New System.Drawing.Point(226, 381)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(118, 24)
        Me.Label83.TabIndex = 82
        Me.Label83.Text = "Subs Count"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(630, 51)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(80, 16)
        Me.Label75.TabIndex = 81
        Me.Label75.Text = "Away Team"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(424, 51)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(84, 16)
        Me.Label74.TabIndex = 80
        Me.Label74.Text = "Home Team"
        '
        'AwayTeamName
        '
        Me.AwayTeamName.Location = New System.Drawing.Point(904, 72)
        Me.AwayTeamName.Name = "AwayTeamName"
        Me.AwayTeamName.Size = New System.Drawing.Size(209, 20)
        Me.AwayTeamName.TabIndex = 79
        '
        'HomeTeamName
        '
        Me.HomeTeamName.Location = New System.Drawing.Point(17, 72)
        Me.HomeTeamName.Name = "HomeTeamName"
        Me.HomeTeamName.Size = New System.Drawing.Size(209, 20)
        Me.HomeTeamName.TabIndex = 78
        '
        'AwayMoveDown
        '
        Me.AwayMoveDown.Location = New System.Drawing.Point(781, 260)
        Me.AwayMoveDown.Name = "AwayMoveDown"
        Me.AwayMoveDown.Size = New System.Drawing.Size(118, 23)
        Me.AwayMoveDown.TabIndex = 77
        Me.AwayMoveDown.Text = "Move Down"
        Me.AwayMoveDown.UseVisualStyleBackColor = True
        '
        'AwayMoveUp
        '
        Me.AwayMoveUp.Location = New System.Drawing.Point(781, 231)
        Me.AwayMoveUp.Name = "AwayMoveUp"
        Me.AwayMoveUp.Size = New System.Drawing.Size(118, 23)
        Me.AwayMoveUp.TabIndex = 76
        Me.AwayMoveUp.Text = "Move Up"
        Me.AwayMoveUp.UseVisualStyleBackColor = True
        '
        'HomeDown
        '
        Me.HomeDown.Location = New System.Drawing.Point(232, 260)
        Me.HomeDown.Name = "HomeDown"
        Me.HomeDown.Size = New System.Drawing.Size(118, 23)
        Me.HomeDown.TabIndex = 75
        Me.HomeDown.Text = "Move Down"
        Me.HomeDown.UseVisualStyleBackColor = True
        '
        'HomeMoveUp
        '
        Me.HomeMoveUp.Location = New System.Drawing.Point(232, 231)
        Me.HomeMoveUp.Name = "HomeMoveUp"
        Me.HomeMoveUp.Size = New System.Drawing.Size(118, 23)
        Me.HomeMoveUp.TabIndex = 74
        Me.HomeMoveUp.Text = "Move Up"
        Me.HomeMoveUp.UseVisualStyleBackColor = True
        '
        'AwayPlayerCount
        '
        Me.AwayPlayerCount.AutoSize = True
        Me.AwayPlayerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayPlayerCount.ForeColor = System.Drawing.Color.Green
        Me.AwayPlayerCount.Location = New System.Drawing.Point(819, 336)
        Me.AwayPlayerCount.Name = "AwayPlayerCount"
        Me.AwayPlayerCount.Size = New System.Drawing.Size(37, 39)
        Me.AwayPlayerCount.TabIndex = 73
        Me.AwayPlayerCount.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(777, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 24)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Player Count"
        '
        'homePlayerCount
        '
        Me.homePlayerCount.AutoSize = True
        Me.homePlayerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homePlayerCount.ForeColor = System.Drawing.Color.Green
        Me.homePlayerCount.Location = New System.Drawing.Point(269, 336)
        Me.homePlayerCount.Name = "homePlayerCount"
        Me.homePlayerCount.Size = New System.Drawing.Size(37, 39)
        Me.homePlayerCount.TabIndex = 71
        Me.homePlayerCount.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(226, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 24)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Player Count"
        '
        'AddtoSqaudNotListedAway
        '
        Me.AddtoSqaudNotListedAway.Location = New System.Drawing.Point(782, 499)
        Me.AddtoSqaudNotListedAway.Name = "AddtoSqaudNotListedAway"
        Me.AddtoSqaudNotListedAway.Size = New System.Drawing.Size(118, 23)
        Me.AddtoSqaudNotListedAway.TabIndex = 17
        Me.AddtoSqaudNotListedAway.Text = "Add to Squad"
        Me.AddtoSqaudNotListedAway.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(903, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Add Player Not Listed"
        '
        'AwayPlayerNotListed
        '
        Me.AwayPlayerNotListed.Location = New System.Drawing.Point(906, 502)
        Me.AwayPlayerNotListed.Name = "AwayPlayerNotListed"
        Me.AwayPlayerNotListed.Size = New System.Drawing.Size(207, 20)
        Me.AwayPlayerNotListed.TabIndex = 15
        '
        'AddtoSquadNotListed
        '
        Me.AddtoSquadNotListed.Location = New System.Drawing.Point(232, 499)
        Me.AddtoSquadNotListed.Name = "AddtoSquadNotListed"
        Me.AddtoSquadNotListed.Size = New System.Drawing.Size(118, 23)
        Me.AddtoSquadNotListed.TabIndex = 14
        Me.AddtoSquadNotListed.Text = "Add to Squad"
        Me.AddtoSquadNotListed.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 486)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Add Player Not Listed"
        '
        'HomePlayerNotListed
        '
        Me.HomePlayerNotListed.Location = New System.Drawing.Point(19, 502)
        Me.HomePlayerNotListed.Name = "HomePlayerNotListed"
        Me.HomePlayerNotListed.Size = New System.Drawing.Size(207, 20)
        Me.HomePlayerNotListed.TabIndex = 12
        '
        'updateAllTeams
        '
        Me.updateAllTeams.Location = New System.Drawing.Point(356, 357)
        Me.updateAllTeams.Name = "updateAllTeams"
        Me.updateAllTeams.Size = New System.Drawing.Size(420, 76)
        Me.updateAllTeams.TabIndex = 11
        Me.updateAllTeams.Text = "Update all Teams"
        Me.updateAllTeams.UseVisualStyleBackColor = True
        '
        'clearAwaySquad
        '
        Me.clearAwaySquad.Location = New System.Drawing.Point(782, 162)
        Me.clearAwaySquad.Name = "clearAwaySquad"
        Me.clearAwaySquad.Size = New System.Drawing.Size(118, 23)
        Me.clearAwaySquad.TabIndex = 10
        Me.clearAwaySquad.Text = "Clear Team List"
        Me.clearAwaySquad.UseVisualStyleBackColor = True
        '
        'removeAwaySquad
        '
        Me.removeAwaySquad.Location = New System.Drawing.Point(781, 101)
        Me.removeAwaySquad.Name = "removeAwaySquad"
        Me.removeAwaySquad.Size = New System.Drawing.Size(118, 23)
        Me.removeAwaySquad.TabIndex = 9
        Me.removeAwaySquad.Text = "Remove from Team"
        Me.removeAwaySquad.UseVisualStyleBackColor = True
        '
        'addAwaySquad
        '
        Me.addAwaySquad.Location = New System.Drawing.Point(781, 72)
        Me.addAwaySquad.Name = "addAwaySquad"
        Me.addAwaySquad.Size = New System.Drawing.Size(118, 23)
        Me.addAwaySquad.TabIndex = 8
        Me.addAwaySquad.Text = "Add to Team"
        Me.addAwaySquad.UseVisualStyleBackColor = True
        '
        'HomeClearSquadList
        '
        Me.HomeClearSquadList.Location = New System.Drawing.Point(232, 162)
        Me.HomeClearSquadList.Name = "HomeClearSquadList"
        Me.HomeClearSquadList.Size = New System.Drawing.Size(118, 23)
        Me.HomeClearSquadList.TabIndex = 7
        Me.HomeClearSquadList.Text = "Clear Team List"
        Me.HomeClearSquadList.UseVisualStyleBackColor = True
        '
        'removeHomeSquad
        '
        Me.removeHomeSquad.Location = New System.Drawing.Point(232, 101)
        Me.removeHomeSquad.Name = "removeHomeSquad"
        Me.removeHomeSquad.Size = New System.Drawing.Size(118, 23)
        Me.removeHomeSquad.TabIndex = 6
        Me.removeHomeSquad.Text = "Remove from Team"
        Me.removeHomeSquad.UseVisualStyleBackColor = True
        '
        'addHomeSquad
        '
        Me.addHomeSquad.Location = New System.Drawing.Point(232, 72)
        Me.addHomeSquad.Name = "addHomeSquad"
        Me.addHomeSquad.Size = New System.Drawing.Size(118, 23)
        Me.addHomeSquad.TabIndex = 5
        Me.addHomeSquad.Text = "Add to Team"
        Me.addHomeSquad.UseVisualStyleBackColor = True
        '
        'FullAwaySquad
        '
        Me.FullAwaySquad.FormattingEnabled = True
        Me.FullAwaySquad.Location = New System.Drawing.Point(906, 98)
        Me.FullAwaySquad.Name = "FullAwaySquad"
        Me.FullAwaySquad.Size = New System.Drawing.Size(207, 368)
        Me.FullAwaySquad.TabIndex = 4
        '
        'FullHomeSquad
        '
        Me.FullHomeSquad.FormattingEnabled = True
        Me.FullHomeSquad.Location = New System.Drawing.Point(19, 98)
        Me.FullHomeSquad.Name = "FullHomeSquad"
        Me.FullHomeSquad.Size = New System.Drawing.Size(207, 368)
        Me.FullHomeSquad.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.AwayManagerTXT)
        Me.TabPage1.Controls.Add(Me.HomeManagerTXT)
        Me.TabPage1.Controls.Add(Me.Label109)
        Me.TabPage1.Controls.Add(Me.Label108)
        Me.TabPage1.Controls.Add(Me.GroupBox11)
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.awayCrestBTN)
        Me.TabPage1.Controls.Add(Me.homeCrestsBTN)
        Me.TabPage1.Controls.Add(Me.identTeamsBTN)
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.AwayTeamLabel)
        Me.TabPage1.Controls.Add(Me.HomeTeamLabel)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.AwayTeamsOff)
        Me.TabPage1.Controls.Add(Me.ShowAwaySubsSheet)
        Me.TabPage1.Controls.Add(Me.Ts_Off)
        Me.TabPage1.Controls.Add(Me.ShowSubsSheet)
        Me.TabPage1.Controls.Add(Me.ShowTeamSheet)
        Me.TabPage1.Controls.Add(Me.ShowAwayFirstEleven)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Out of Game"
        '
        'AwayManagerTXT
        '
        Me.AwayManagerTXT.Location = New System.Drawing.Point(246, 406)
        Me.AwayManagerTXT.Name = "AwayManagerTXT"
        Me.AwayManagerTXT.Size = New System.Drawing.Size(220, 20)
        Me.AwayManagerTXT.TabIndex = 129
        '
        'HomeManagerTXT
        '
        Me.HomeManagerTXT.Location = New System.Drawing.Point(16, 406)
        Me.HomeManagerTXT.Name = "HomeManagerTXT"
        Me.HomeManagerTXT.Size = New System.Drawing.Size(210, 20)
        Me.HomeManagerTXT.TabIndex = 128
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Location = New System.Drawing.Point(243, 390)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(49, 13)
        Me.Label109.TabIndex = 127
        Me.Label109.Text = "Manager"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(13, 390)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(49, 13)
        Me.Label108.TabIndex = 126
        Me.Label108.Text = "Manager"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.hideNameIDBTN)
        Me.GroupBox11.Controls.Add(Me.showNameIDBTN)
        Me.GroupBox11.Controls.Add(Me.nameRoleIdentText4)
        Me.GroupBox11.Controls.Add(Me.nameIdentText4)
        Me.GroupBox11.Controls.Add(Me.nameRoleIdentText3)
        Me.GroupBox11.Controls.Add(Me.nameIdentText3)
        Me.GroupBox11.Controls.Add(Me.nameRoleIdentText2)
        Me.GroupBox11.Controls.Add(Me.nameIdentText2)
        Me.GroupBox11.Controls.Add(Me.nameRoleIdentText1)
        Me.GroupBox11.Controls.Add(Me.Label104)
        Me.GroupBox11.Controls.Add(Me.Label105)
        Me.GroupBox11.Controls.Add(Me.Label106)
        Me.GroupBox11.Controls.Add(Me.Label107)
        Me.GroupBox11.Controls.Add(Me.nameIDCHK4)
        Me.GroupBox11.Controls.Add(Me.nameIDCHK3)
        Me.GroupBox11.Controls.Add(Me.nameIDCHK2)
        Me.GroupBox11.Controls.Add(Me.nameIDCHK1)
        Me.GroupBox11.Controls.Add(Me.nameIdentText1)
        Me.GroupBox11.Location = New System.Drawing.Point(476, 268)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(364, 322)
        Me.GroupBox11.TabIndex = 125
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Name Ident"
        '
        'hideNameIDBTN
        '
        Me.hideNameIDBTN.Location = New System.Drawing.Point(188, 284)
        Me.hideNameIDBTN.Name = "hideNameIDBTN"
        Me.hideNameIDBTN.Size = New System.Drawing.Size(144, 23)
        Me.hideNameIDBTN.TabIndex = 135
        Me.hideNameIDBTN.Text = "Hide"
        Me.hideNameIDBTN.UseVisualStyleBackColor = True
        '
        'showNameIDBTN
        '
        Me.showNameIDBTN.Location = New System.Drawing.Point(18, 284)
        Me.showNameIDBTN.Name = "showNameIDBTN"
        Me.showNameIDBTN.Size = New System.Drawing.Size(144, 23)
        Me.showNameIDBTN.TabIndex = 134
        Me.showNameIDBTN.Text = "Show"
        Me.showNameIDBTN.UseVisualStyleBackColor = True
        '
        'nameRoleIdentText4
        '
        Me.nameRoleIdentText4.Location = New System.Drawing.Point(18, 258)
        Me.nameRoleIdentText4.Name = "nameRoleIdentText4"
        Me.nameRoleIdentText4.Size = New System.Drawing.Size(314, 20)
        Me.nameRoleIdentText4.TabIndex = 133
        Me.nameRoleIdentText4.Text = "Role/Info Goes Here"
        '
        'nameIdentText4
        '
        Me.nameIdentText4.Location = New System.Drawing.Point(18, 232)
        Me.nameIdentText4.Name = "nameIdentText4"
        Me.nameIdentText4.Size = New System.Drawing.Size(314, 20)
        Me.nameIdentText4.TabIndex = 132
        Me.nameIdentText4.Text = "Name Goes Here"
        '
        'nameRoleIdentText3
        '
        Me.nameRoleIdentText3.Location = New System.Drawing.Point(18, 188)
        Me.nameRoleIdentText3.Name = "nameRoleIdentText3"
        Me.nameRoleIdentText3.Size = New System.Drawing.Size(314, 20)
        Me.nameRoleIdentText3.TabIndex = 131
        Me.nameRoleIdentText3.Text = "Role/Info Goes Here"
        '
        'nameIdentText3
        '
        Me.nameIdentText3.Location = New System.Drawing.Point(18, 162)
        Me.nameIdentText3.Name = "nameIdentText3"
        Me.nameIdentText3.Size = New System.Drawing.Size(314, 20)
        Me.nameIdentText3.TabIndex = 130
        Me.nameIdentText3.Text = "Name Goes Here"
        '
        'nameRoleIdentText2
        '
        Me.nameRoleIdentText2.Location = New System.Drawing.Point(18, 121)
        Me.nameRoleIdentText2.Name = "nameRoleIdentText2"
        Me.nameRoleIdentText2.Size = New System.Drawing.Size(314, 20)
        Me.nameRoleIdentText2.TabIndex = 129
        Me.nameRoleIdentText2.Text = "Role/Info Goes Here"
        '
        'nameIdentText2
        '
        Me.nameIdentText2.Location = New System.Drawing.Point(18, 95)
        Me.nameIdentText2.Name = "nameIdentText2"
        Me.nameIdentText2.Size = New System.Drawing.Size(314, 20)
        Me.nameIdentText2.TabIndex = 128
        Me.nameIdentText2.Text = "Name Goes Here"
        '
        'nameRoleIdentText1
        '
        Me.nameRoleIdentText1.Location = New System.Drawing.Point(18, 47)
        Me.nameRoleIdentText1.Name = "nameRoleIdentText1"
        Me.nameRoleIdentText1.Size = New System.Drawing.Size(314, 20)
        Me.nameRoleIdentText1.TabIndex = 127
        Me.nameRoleIdentText1.Text = "Role/Info Goes Here"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(2, 245)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(13, 13)
        Me.Label104.TabIndex = 126
        Me.Label104.Text = "4"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Location = New System.Drawing.Point(2, 178)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(13, 13)
        Me.Label105.TabIndex = 125
        Me.Label105.Text = "3"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(6, 109)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(13, 13)
        Me.Label106.TabIndex = 124
        Me.Label106.Text = "2"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Location = New System.Drawing.Point(6, 31)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(13, 13)
        Me.Label107.TabIndex = 123
        Me.Label107.Text = "1"
        '
        'nameIDCHK4
        '
        Me.nameIDCHK4.AutoSize = True
        Me.nameIDCHK4.Location = New System.Drawing.Point(338, 250)
        Me.nameIDCHK4.Name = "nameIDCHK4"
        Me.nameIDCHK4.Size = New System.Drawing.Size(14, 13)
        Me.nameIDCHK4.TabIndex = 14
        Me.nameIDCHK4.UseVisualStyleBackColor = True
        '
        'nameIDCHK3
        '
        Me.nameIDCHK3.AutoSize = True
        Me.nameIDCHK3.Location = New System.Drawing.Point(338, 178)
        Me.nameIDCHK3.Name = "nameIDCHK3"
        Me.nameIDCHK3.Size = New System.Drawing.Size(14, 13)
        Me.nameIDCHK3.TabIndex = 13
        Me.nameIDCHK3.UseVisualStyleBackColor = True
        '
        'nameIDCHK2
        '
        Me.nameIDCHK2.AutoSize = True
        Me.nameIDCHK2.Location = New System.Drawing.Point(338, 109)
        Me.nameIDCHK2.Name = "nameIDCHK2"
        Me.nameIDCHK2.Size = New System.Drawing.Size(14, 13)
        Me.nameIDCHK2.TabIndex = 12
        Me.nameIDCHK2.UseVisualStyleBackColor = True
        '
        'nameIDCHK1
        '
        Me.nameIDCHK1.AutoSize = True
        Me.nameIDCHK1.Checked = True
        Me.nameIDCHK1.Location = New System.Drawing.Point(338, 36)
        Me.nameIDCHK1.Name = "nameIDCHK1"
        Me.nameIDCHK1.Size = New System.Drawing.Size(14, 13)
        Me.nameIDCHK1.TabIndex = 11
        Me.nameIDCHK1.TabStop = True
        Me.nameIDCHK1.UseVisualStyleBackColor = True
        '
        'nameIdentText1
        '
        Me.nameIdentText1.Location = New System.Drawing.Point(18, 21)
        Me.nameIdentText1.Name = "nameIdentText1"
        Me.nameIdentText1.Size = New System.Drawing.Size(314, 20)
        Me.nameIdentText1.TabIndex = 7
        Me.nameIdentText1.Text = "Name Goes Here"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label86)
        Me.GroupBox10.Controls.Add(Me.Label87)
        Me.GroupBox10.Controls.Add(Me.Label88)
        Me.GroupBox10.Controls.Add(Me.Label89)
        Me.GroupBox10.Controls.Add(Me.OutGameCrawlUpdateBTN)
        Me.GroupBox10.Controls.Add(Me.outGameCrawlRadBTN4)
        Me.GroupBox10.Controls.Add(Me.outGameCrawlRadBTN3)
        Me.GroupBox10.Controls.Add(Me.outGameCrawlRadBTN2)
        Me.GroupBox10.Controls.Add(Me.outGameCrawlRadBTN1)
        Me.GroupBox10.Controls.Add(Me.outGameCrawl4)
        Me.GroupBox10.Controls.Add(Me.outGameCrawl3)
        Me.GroupBox10.Controls.Add(Me.outGameCrawl2)
        Me.GroupBox10.Controls.Add(Me.OutGameCrawlOffBTN)
        Me.GroupBox10.Controls.Add(Me.OutGameCrawlOnBTN)
        Me.GroupBox10.Controls.Add(Me.outGameCrawl1)
        Me.GroupBox10.Location = New System.Drawing.Point(472, 71)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(369, 171)
        Me.GroupBox10.TabIndex = 124
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Crawl"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(3, 100)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(13, 13)
        Me.Label86.TabIndex = 122
        Me.Label86.Text = "4"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(3, 74)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(13, 13)
        Me.Label87.TabIndex = 121
        Me.Label87.Text = "3"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(3, 48)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(13, 13)
        Me.Label88.TabIndex = 120
        Me.Label88.Text = "2"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(3, 22)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(13, 13)
        Me.Label89.TabIndex = 119
        Me.Label89.Text = "1"
        '
        'OutGameCrawlUpdateBTN
        '
        Me.OutGameCrawlUpdateBTN.Location = New System.Drawing.Point(87, 140)
        Me.OutGameCrawlUpdateBTN.Name = "OutGameCrawlUpdateBTN"
        Me.OutGameCrawlUpdateBTN.Size = New System.Drawing.Size(100, 23)
        Me.OutGameCrawlUpdateBTN.TabIndex = 9
        Me.OutGameCrawlUpdateBTN.Text = "Update Text (TX)"
        Me.OutGameCrawlUpdateBTN.UseVisualStyleBackColor = True
        '
        'outGameCrawlRadBTN4
        '
        Me.outGameCrawlRadBTN4.AutoSize = True
        Me.outGameCrawlRadBTN4.Location = New System.Drawing.Point(342, 100)
        Me.outGameCrawlRadBTN4.Name = "outGameCrawlRadBTN4"
        Me.outGameCrawlRadBTN4.Size = New System.Drawing.Size(14, 13)
        Me.outGameCrawlRadBTN4.TabIndex = 7
        Me.outGameCrawlRadBTN4.UseVisualStyleBackColor = True
        '
        'outGameCrawlRadBTN3
        '
        Me.outGameCrawlRadBTN3.AutoSize = True
        Me.outGameCrawlRadBTN3.Location = New System.Drawing.Point(342, 74)
        Me.outGameCrawlRadBTN3.Name = "outGameCrawlRadBTN3"
        Me.outGameCrawlRadBTN3.Size = New System.Drawing.Size(14, 13)
        Me.outGameCrawlRadBTN3.TabIndex = 5
        Me.outGameCrawlRadBTN3.UseVisualStyleBackColor = True
        '
        'outGameCrawlRadBTN2
        '
        Me.outGameCrawlRadBTN2.AutoSize = True
        Me.outGameCrawlRadBTN2.Location = New System.Drawing.Point(342, 48)
        Me.outGameCrawlRadBTN2.Name = "outGameCrawlRadBTN2"
        Me.outGameCrawlRadBTN2.Size = New System.Drawing.Size(14, 13)
        Me.outGameCrawlRadBTN2.TabIndex = 3
        Me.outGameCrawlRadBTN2.UseVisualStyleBackColor = True
        '
        'outGameCrawlRadBTN1
        '
        Me.outGameCrawlRadBTN1.AutoSize = True
        Me.outGameCrawlRadBTN1.Checked = True
        Me.outGameCrawlRadBTN1.Location = New System.Drawing.Point(342, 22)
        Me.outGameCrawlRadBTN1.Name = "outGameCrawlRadBTN1"
        Me.outGameCrawlRadBTN1.Size = New System.Drawing.Size(14, 13)
        Me.outGameCrawlRadBTN1.TabIndex = 1
        Me.outGameCrawlRadBTN1.TabStop = True
        Me.outGameCrawlRadBTN1.UseVisualStyleBackColor = True
        '
        'outGameCrawl4
        '
        Me.outGameCrawl4.Location = New System.Drawing.Point(22, 97)
        Me.outGameCrawl4.Name = "outGameCrawl4"
        Me.outGameCrawl4.Size = New System.Drawing.Size(314, 20)
        Me.outGameCrawl4.TabIndex = 6
        Me.outGameCrawl4.Text = "Crawl Text Goes Here"
        '
        'outGameCrawl3
        '
        Me.outGameCrawl3.Location = New System.Drawing.Point(22, 71)
        Me.outGameCrawl3.Name = "outGameCrawl3"
        Me.outGameCrawl3.Size = New System.Drawing.Size(314, 20)
        Me.outGameCrawl3.TabIndex = 4
        Me.outGameCrawl3.Text = "Crawl Text Goes Here"
        '
        'outGameCrawl2
        '
        Me.outGameCrawl2.Location = New System.Drawing.Point(22, 45)
        Me.outGameCrawl2.Name = "outGameCrawl2"
        Me.outGameCrawl2.Size = New System.Drawing.Size(314, 20)
        Me.outGameCrawl2.TabIndex = 2
        Me.outGameCrawl2.Text = "Crawl Text Goes Here"
        '
        'OutGameCrawlOffBTN
        '
        Me.OutGameCrawlOffBTN.Location = New System.Drawing.Point(274, 140)
        Me.OutGameCrawlOffBTN.Name = "OutGameCrawlOffBTN"
        Me.OutGameCrawlOffBTN.Size = New System.Drawing.Size(75, 23)
        Me.OutGameCrawlOffBTN.TabIndex = 10
        Me.OutGameCrawlOffBTN.Text = "Crawl Off"
        Me.OutGameCrawlOffBTN.UseVisualStyleBackColor = True
        '
        'OutGameCrawlOnBTN
        '
        Me.OutGameCrawlOnBTN.Location = New System.Drawing.Point(6, 140)
        Me.OutGameCrawlOnBTN.Name = "OutGameCrawlOnBTN"
        Me.OutGameCrawlOnBTN.Size = New System.Drawing.Size(75, 23)
        Me.OutGameCrawlOnBTN.TabIndex = 8
        Me.OutGameCrawlOnBTN.Text = "Crawl On"
        Me.OutGameCrawlOnBTN.UseVisualStyleBackColor = True
        '
        'outGameCrawl1
        '
        Me.outGameCrawl1.Location = New System.Drawing.Point(22, 19)
        Me.outGameCrawl1.Name = "outGameCrawl1"
        Me.outGameCrawl1.Size = New System.Drawing.Size(314, 20)
        Me.outGameCrawl1.TabIndex = 0
        Me.outGameCrawl1.Text = "Crawl Text Goes Here"
        '
        'awayCrestBTN
        '
        Me.awayCrestBTN.Location = New System.Drawing.Point(246, 472)
        Me.awayCrestBTN.Name = "awayCrestBTN"
        Me.awayCrestBTN.Size = New System.Drawing.Size(220, 23)
        Me.awayCrestBTN.TabIndex = 123
        Me.awayCrestBTN.Text = "Away Crest"
        Me.awayCrestBTN.UseVisualStyleBackColor = True
        '
        'homeCrestsBTN
        '
        Me.homeCrestsBTN.Location = New System.Drawing.Point(16, 472)
        Me.homeCrestsBTN.Name = "homeCrestsBTN"
        Me.homeCrestsBTN.Size = New System.Drawing.Size(210, 23)
        Me.homeCrestsBTN.TabIndex = 122
        Me.homeCrestsBTN.Text = "Home Crest"
        Me.homeCrestsBTN.UseVisualStyleBackColor = True
        '
        'identTeamsBTN
        '
        Me.identTeamsBTN.Location = New System.Drawing.Point(16, 438)
        Me.identTeamsBTN.Name = "identTeamsBTN"
        Me.identTeamsBTN.Size = New System.Drawing.Size(450, 28)
        Me.identTeamsBTN.TabIndex = 121
        Me.identTeamsBTN.Text = "Ident Teams"
        Me.identTeamsBTN.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Location = New System.Drawing.Point(0, 217)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 170)
        Me.Panel3.TabIndex = 120
        '
        'AwayTeamLabel
        '
        Me.AwayTeamLabel.AutoSize = True
        Me.AwayTeamLabel.Location = New System.Drawing.Point(243, 48)
        Me.AwayTeamLabel.Name = "AwayTeamLabel"
        Me.AwayTeamLabel.Size = New System.Drawing.Size(72, 13)
        Me.AwayTeamLabel.TabIndex = 24
        Me.AwayTeamLabel.Text = "AWAY TEAM"
        '
        'HomeTeamLabel
        '
        Me.HomeTeamLabel.AutoSize = True
        Me.HomeTeamLabel.Location = New System.Drawing.Point(13, 48)
        Me.HomeTeamLabel.Name = "HomeTeamLabel"
        Me.HomeTeamLabel.Size = New System.Drawing.Size(72, 13)
        Me.HomeTeamLabel.TabIndex = 23
        Me.HomeTeamLabel.Text = "HOME TEAM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stillsPlayLoadBTN)
        Me.GroupBox2.Controls.Add(Me.stillsPlaySaveBTN)
        Me.GroupBox2.Controls.Add(Me.WipeTrans)
        Me.GroupBox2.Controls.Add(Me.PushTrans)
        Me.GroupBox2.Controls.Add(Me.MixTrans)
        Me.GroupBox2.Controls.Add(Me.Label72)
        Me.GroupBox2.Controls.Add(Me.PL1MoveDown)
        Me.GroupBox2.Controls.Add(Me.playNext)
        Me.GroupBox2.Controls.Add(Me.PL1MoveUp)
        Me.GroupBox2.Controls.Add(Me.stopVid)
        Me.GroupBox2.Controls.Add(Me.playVid)
        Me.GroupBox2.Controls.Add(Me.ClearPlaylist)
        Me.GroupBox2.Controls.Add(Me.RemovePlaylist)
        Me.GroupBox2.Controls.Add(Me.AddPlaylist)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rereshVids)
        Me.GroupBox2.Controls.Add(Me.playlistFiles)
        Me.GroupBox2.Controls.Add(Me.SourceFiles)
        Me.GroupBox2.Location = New System.Drawing.Point(847, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 608)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stills Playout"
        '
        'stillsPlayLoadBTN
        '
        Me.stillsPlayLoadBTN.Location = New System.Drawing.Point(101, 579)
        Me.stillsPlayLoadBTN.Name = "stillsPlayLoadBTN"
        Me.stillsPlayLoadBTN.Size = New System.Drawing.Size(86, 23)
        Me.stillsPlayLoadBTN.TabIndex = 82
        Me.stillsPlayLoadBTN.Text = "Load"
        Me.stillsPlayLoadBTN.UseVisualStyleBackColor = True
        '
        'stillsPlaySaveBTN
        '
        Me.stillsPlaySaveBTN.Location = New System.Drawing.Point(9, 579)
        Me.stillsPlaySaveBTN.Name = "stillsPlaySaveBTN"
        Me.stillsPlaySaveBTN.Size = New System.Drawing.Size(86, 23)
        Me.stillsPlaySaveBTN.TabIndex = 81
        Me.stillsPlaySaveBTN.Text = "Save"
        Me.stillsPlaySaveBTN.UseVisualStyleBackColor = True
        '
        'WipeTrans
        '
        Me.WipeTrans.AutoSize = True
        Me.WipeTrans.Location = New System.Drawing.Point(240, 546)
        Me.WipeTrans.Name = "WipeTrans"
        Me.WipeTrans.Size = New System.Drawing.Size(50, 17)
        Me.WipeTrans.TabIndex = 26
        Me.WipeTrans.Text = "Wipe"
        Me.WipeTrans.UseVisualStyleBackColor = True
        '
        'PushTrans
        '
        Me.PushTrans.AutoSize = True
        Me.PushTrans.Location = New System.Drawing.Point(128, 546)
        Me.PushTrans.Name = "PushTrans"
        Me.PushTrans.Size = New System.Drawing.Size(49, 17)
        Me.PushTrans.TabIndex = 80
        Me.PushTrans.Text = "Push"
        Me.PushTrans.UseVisualStyleBackColor = True
        '
        'MixTrans
        '
        Me.MixTrans.AutoSize = True
        Me.MixTrans.Checked = True
        Me.MixTrans.Location = New System.Drawing.Point(9, 546)
        Me.MixTrans.Name = "MixTrans"
        Me.MixTrans.Size = New System.Drawing.Size(41, 17)
        Me.MixTrans.TabIndex = 25
        Me.MixTrans.TabStop = True
        Me.MixTrans.Text = "Mix"
        Me.MixTrans.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(6, 526)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(58, 13)
        Me.Label72.TabIndex = 25
        Me.Label72.Text = "Transitions"
        '
        'PL1MoveDown
        '
        Me.PL1MoveDown.Location = New System.Drawing.Point(175, 282)
        Me.PL1MoveDown.Name = "PL1MoveDown"
        Me.PL1MoveDown.Size = New System.Drawing.Size(166, 23)
        Me.PL1MoveDown.TabIndex = 79
        Me.PL1MoveDown.Text = "Move Down"
        Me.PL1MoveDown.UseVisualStyleBackColor = True
        '
        'playNext
        '
        Me.playNext.Location = New System.Drawing.Point(129, 491)
        Me.playNext.Name = "playNext"
        Me.playNext.Size = New System.Drawing.Size(105, 23)
        Me.playNext.TabIndex = 8
        Me.playNext.Text = "Play Next"
        Me.playNext.UseVisualStyleBackColor = True
        '
        'PL1MoveUp
        '
        Me.PL1MoveUp.Location = New System.Drawing.Point(6, 282)
        Me.PL1MoveUp.Name = "PL1MoveUp"
        Me.PL1MoveUp.Size = New System.Drawing.Size(163, 23)
        Me.PL1MoveUp.TabIndex = 78
        Me.PL1MoveUp.Text = "Move Up"
        Me.PL1MoveUp.UseVisualStyleBackColor = True
        '
        'stopVid
        '
        Me.stopVid.Location = New System.Drawing.Point(240, 491)
        Me.stopVid.Name = "stopVid"
        Me.stopVid.Size = New System.Drawing.Size(101, 23)
        Me.stopVid.TabIndex = 10
        Me.stopVid.Text = "Stop"
        Me.stopVid.UseVisualStyleBackColor = True
        '
        'playVid
        '
        Me.playVid.Location = New System.Drawing.Point(6, 491)
        Me.playVid.Name = "playVid"
        Me.playVid.Size = New System.Drawing.Size(117, 23)
        Me.playVid.TabIndex = 7
        Me.playVid.Text = "Play"
        Me.playVid.UseVisualStyleBackColor = True
        '
        'ClearPlaylist
        '
        Me.ClearPlaylist.Location = New System.Drawing.Point(6, 253)
        Me.ClearPlaylist.Name = "ClearPlaylist"
        Me.ClearPlaylist.Size = New System.Drawing.Size(163, 23)
        Me.ClearPlaylist.TabIndex = 4
        Me.ClearPlaylist.Text = "Clear Playlist"
        Me.ClearPlaylist.UseVisualStyleBackColor = True
        '
        'RemovePlaylist
        '
        Me.RemovePlaylist.Location = New System.Drawing.Point(175, 253)
        Me.RemovePlaylist.Name = "RemovePlaylist"
        Me.RemovePlaylist.Size = New System.Drawing.Size(166, 23)
        Me.RemovePlaylist.TabIndex = 5
        Me.RemovePlaylist.Text = "Remove From Playlist"
        Me.RemovePlaylist.UseVisualStyleBackColor = True
        '
        'AddPlaylist
        '
        Me.AddPlaylist.Location = New System.Drawing.Point(175, 221)
        Me.AddPlaylist.Name = "AddPlaylist"
        Me.AddPlaylist.Size = New System.Drawing.Size(166, 23)
        Me.AddPlaylist.TabIndex = 3
        Me.AddPlaylist.Text = "Add to Playlist"
        Me.AddPlaylist.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Files In Media Directory"
        '
        'rereshVids
        '
        Me.rereshVids.Location = New System.Drawing.Point(6, 220)
        Me.rereshVids.Name = "rereshVids"
        Me.rereshVids.Size = New System.Drawing.Size(163, 23)
        Me.rereshVids.TabIndex = 2
        Me.rereshVids.Text = "Refresh Video List"
        Me.rereshVids.UseVisualStyleBackColor = True
        '
        'playlistFiles
        '
        Me.playlistFiles.FormattingEnabled = True
        Me.playlistFiles.Location = New System.Drawing.Point(6, 312)
        Me.playlistFiles.Name = "playlistFiles"
        Me.playlistFiles.Size = New System.Drawing.Size(335, 173)
        Me.playlistFiles.TabIndex = 6
        '
        'SourceFiles
        '
        Me.SourceFiles.FormattingEnabled = True
        Me.SourceFiles.Location = New System.Drawing.Point(3, 42)
        Me.SourceFiles.Name = "SourceFiles"
        Me.SourceFiles.Size = New System.Drawing.Size(338, 173)
        Me.SourceFiles.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Scores"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.hideScoresScroller)
        Me.GroupBox9.Controls.Add(Me.showScoresScroller)
        Me.GroupBox9.Controls.Add(Me.sscoresT2Right)
        Me.GroupBox9.Controls.Add(Me.sscoresT2Left)
        Me.GroupBox9.Controls.Add(Me.sscoresT1Right)
        Me.GroupBox9.Controls.Add(Me.sscoresT1Left)
        Me.GroupBox9.Location = New System.Drawing.Point(973, 243)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(273, 253)
        Me.GroupBox9.TabIndex = 19
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Scrolling Scores"
        '
        'hideScoresScroller
        '
        Me.hideScoresScroller.Location = New System.Drawing.Point(17, 198)
        Me.hideScoresScroller.Name = "hideScoresScroller"
        Me.hideScoresScroller.Size = New System.Drawing.Size(250, 36)
        Me.hideScoresScroller.TabIndex = 8
        Me.hideScoresScroller.Text = "Hide"
        Me.hideScoresScroller.UseVisualStyleBackColor = True
        '
        'showScoresScroller
        '
        Me.showScoresScroller.Location = New System.Drawing.Point(17, 156)
        Me.showScoresScroller.Name = "showScoresScroller"
        Me.showScoresScroller.Size = New System.Drawing.Size(250, 36)
        Me.showScoresScroller.TabIndex = 7
        Me.showScoresScroller.Text = "Show"
        Me.showScoresScroller.UseVisualStyleBackColor = True
        '
        'sscoresT2Right
        '
        Me.sscoresT2Right.AutoSize = True
        Me.sscoresT2Right.Location = New System.Drawing.Point(146, 77)
        Me.sscoresT2Right.Name = "sscoresT2Right"
        Me.sscoresT2Right.Size = New System.Drawing.Size(81, 17)
        Me.sscoresT2Right.TabIndex = 3
        Me.sscoresT2Right.Text = "Tab 2 Right"
        Me.sscoresT2Right.UseVisualStyleBackColor = True
        '
        'sscoresT2Left
        '
        Me.sscoresT2Left.AutoSize = True
        Me.sscoresT2Left.Location = New System.Drawing.Point(17, 77)
        Me.sscoresT2Left.Name = "sscoresT2Left"
        Me.sscoresT2Left.Size = New System.Drawing.Size(74, 17)
        Me.sscoresT2Left.TabIndex = 2
        Me.sscoresT2Left.Text = "Tab 2 Left"
        Me.sscoresT2Left.UseVisualStyleBackColor = True
        '
        'sscoresT1Right
        '
        Me.sscoresT1Right.AutoSize = True
        Me.sscoresT1Right.Location = New System.Drawing.Point(146, 28)
        Me.sscoresT1Right.Name = "sscoresT1Right"
        Me.sscoresT1Right.Size = New System.Drawing.Size(81, 17)
        Me.sscoresT1Right.TabIndex = 1
        Me.sscoresT1Right.Text = "Tab 1 Right"
        Me.sscoresT1Right.UseVisualStyleBackColor = True
        '
        'sscoresT1Left
        '
        Me.sscoresT1Left.AutoSize = True
        Me.sscoresT1Left.Checked = True
        Me.sscoresT1Left.Location = New System.Drawing.Point(17, 28)
        Me.sscoresT1Left.Name = "sscoresT1Left"
        Me.sscoresT1Left.Size = New System.Drawing.Size(74, 17)
        Me.sscoresT1Left.TabIndex = 0
        Me.sscoresT1Left.TabStop = True
        Me.sscoresT1Left.Text = "Tab 1 Left"
        Me.sscoresT1Left.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(17, 223)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(935, 273)
        Me.TabControl2.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.tab1Logo2Select)
        Me.TabPage3.Controls.Add(Me.Label77)
        Me.TabPage3.Controls.Add(Me.tab1Logo1Select)
        Me.TabPage3.Controls.Add(Me.Label76)
        Me.TabPage3.Controls.Add(Me.FT12)
        Me.TabPage3.Controls.Add(Me.FT11)
        Me.TabPage3.Controls.Add(Me.FT10)
        Me.TabPage3.Controls.Add(Me.FT9)
        Me.TabPage3.Controls.Add(Me.FT8)
        Me.TabPage3.Controls.Add(Me.FT7)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.FT6)
        Me.TabPage3.Controls.Add(Me.FT5)
        Me.TabPage3.Controls.Add(Me.FT4)
        Me.TabPage3.Controls.Add(Me.FT3)
        Me.TabPage3.Controls.Add(Me.FT2)
        Me.TabPage3.Controls.Add(Me.FT1)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.PremScoresTitle2)
        Me.TabPage3.Controls.Add(Me.CheckBox24)
        Me.TabPage3.Controls.Add(Me.CheckBox23)
        Me.TabPage3.Controls.Add(Me.CheckBox22)
        Me.TabPage3.Controls.Add(Me.CheckBox21)
        Me.TabPage3.Controls.Add(Me.CheckBox20)
        Me.TabPage3.Controls.Add(Me.CheckBox19)
        Me.TabPage3.Controls.Add(Me.CheckBox18)
        Me.TabPage3.Controls.Add(Me.CheckBox17)
        Me.TabPage3.Controls.Add(Me.CheckBox16)
        Me.TabPage3.Controls.Add(Me.CheckBox15)
        Me.TabPage3.Controls.Add(Me.CheckBox14)
        Me.TabPage3.Controls.Add(Me.CheckBox13)
        Me.TabPage3.Controls.Add(Me.middle24)
        Me.TabPage3.Controls.Add(Me.middle23)
        Me.TabPage3.Controls.Add(Me.middle22)
        Me.TabPage3.Controls.Add(Me.middle21)
        Me.TabPage3.Controls.Add(Me.middle20)
        Me.TabPage3.Controls.Add(Me.middle19)
        Me.TabPage3.Controls.Add(Me.middle18)
        Me.TabPage3.Controls.Add(Me.middle17)
        Me.TabPage3.Controls.Add(Me.middle16)
        Me.TabPage3.Controls.Add(Me.middle15)
        Me.TabPage3.Controls.Add(Me.middle14)
        Me.TabPage3.Controls.Add(Me.middle13)
        Me.TabPage3.Controls.Add(Me.PremScoresTitle)
        Me.TabPage3.Controls.Add(Me.HidePremScoresBTN)
        Me.TabPage3.Controls.Add(Me.Score1)
        Me.TabPage3.Controls.Add(Me.TXPremScores_2BTN)
        Me.TabPage3.Controls.Add(Me.Score2)
        Me.TabPage3.Controls.Add(Me.Score47)
        Me.TabPage3.Controls.Add(Me.Score4)
        Me.TabPage3.Controls.Add(Me.Score48)
        Me.TabPage3.Controls.Add(Me.Score3)
        Me.TabPage3.Controls.Add(Me.Score46)
        Me.TabPage3.Controls.Add(Me.Score5)
        Me.TabPage3.Controls.Add(Me.Score45)
        Me.TabPage3.Controls.Add(Me.Score6)
        Me.TabPage3.Controls.Add(Me.Score43)
        Me.TabPage3.Controls.Add(Me.Score8)
        Me.TabPage3.Controls.Add(Me.Score44)
        Me.TabPage3.Controls.Add(Me.Score7)
        Me.TabPage3.Controls.Add(Me.Score42)
        Me.TabPage3.Controls.Add(Me.Score9)
        Me.TabPage3.Controls.Add(Me.Score41)
        Me.TabPage3.Controls.Add(Me.Score10)
        Me.TabPage3.Controls.Add(Me.Score39)
        Me.TabPage3.Controls.Add(Me.Score12)
        Me.TabPage3.Controls.Add(Me.Score40)
        Me.TabPage3.Controls.Add(Me.Score11)
        Me.TabPage3.Controls.Add(Me.Score38)
        Me.TabPage3.Controls.Add(Me.Score13)
        Me.TabPage3.Controls.Add(Me.Score37)
        Me.TabPage3.Controls.Add(Me.Score14)
        Me.TabPage3.Controls.Add(Me.Score35)
        Me.TabPage3.Controls.Add(Me.Score16)
        Me.TabPage3.Controls.Add(Me.Score36)
        Me.TabPage3.Controls.Add(Me.Score15)
        Me.TabPage3.Controls.Add(Me.Score34)
        Me.TabPage3.Controls.Add(Me.Score17)
        Me.TabPage3.Controls.Add(Me.Score33)
        Me.TabPage3.Controls.Add(Me.Score18)
        Me.TabPage3.Controls.Add(Me.Score31)
        Me.TabPage3.Controls.Add(Me.Score20)
        Me.TabPage3.Controls.Add(Me.Score32)
        Me.TabPage3.Controls.Add(Me.Score19)
        Me.TabPage3.Controls.Add(Me.Score30)
        Me.TabPage3.Controls.Add(Me.Score21)
        Me.TabPage3.Controls.Add(Me.Score29)
        Me.TabPage3.Controls.Add(Me.Score22)
        Me.TabPage3.Controls.Add(Me.Score27)
        Me.TabPage3.Controls.Add(Me.Score24)
        Me.TabPage3.Controls.Add(Me.Score28)
        Me.TabPage3.Controls.Add(Me.Score23)
        Me.TabPage3.Controls.Add(Me.Score26)
        Me.TabPage3.Controls.Add(Me.showPremScores)
        Me.TabPage3.Controls.Add(Me.Score25)
        Me.TabPage3.Controls.Add(Me.HidePremScores)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(927, 247)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Tab 1"
        '
        'tab1Logo2Select
        '
        Me.tab1Logo2Select.FormattingEnabled = True
        Me.tab1Logo2Select.Items.AddRange(New Object() {"Premier League", "Championship", "FA Cup", "Capital One Cup", "Europa League", "Champions League"})
        Me.tab1Logo2Select.Location = New System.Drawing.Point(630, 19)
        Me.tab1Logo2Select.Name = "tab1Logo2Select"
        Me.tab1Logo2Select.Size = New System.Drawing.Size(177, 21)
        Me.tab1Logo2Select.TabIndex = 146
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(590, 23)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(34, 13)
        Me.Label77.TabIndex = 145
        Me.Label77.Text = "Logo:"
        '
        'tab1Logo1Select
        '
        Me.tab1Logo1Select.FormattingEnabled = True
        Me.tab1Logo1Select.Items.AddRange(New Object() {"Premier League", "Championship", "FA Cup", "Capital One Cup", "Europa League", "Champions League"})
        Me.tab1Logo1Select.Location = New System.Drawing.Point(193, 19)
        Me.tab1Logo1Select.Name = "tab1Logo1Select"
        Me.tab1Logo1Select.Size = New System.Drawing.Size(177, 21)
        Me.tab1Logo1Select.TabIndex = 144
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(153, 23)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(34, 13)
        Me.Label76.TabIndex = 143
        Me.Label76.Text = "Logo:"
        '
        'FT12
        '
        Me.FT12.AutoSize = True
        Me.FT12.Location = New System.Drawing.Point(863, 183)
        Me.FT12.Name = "FT12"
        Me.FT12.Size = New System.Drawing.Size(15, 14)
        Me.FT12.TabIndex = 142
        Me.FT12.UseVisualStyleBackColor = True
        '
        'FT11
        '
        Me.FT11.AutoSize = True
        Me.FT11.Location = New System.Drawing.Point(863, 156)
        Me.FT11.Name = "FT11"
        Me.FT11.Size = New System.Drawing.Size(15, 14)
        Me.FT11.TabIndex = 141
        Me.FT11.UseVisualStyleBackColor = True
        '
        'FT10
        '
        Me.FT10.AutoSize = True
        Me.FT10.Location = New System.Drawing.Point(863, 131)
        Me.FT10.Name = "FT10"
        Me.FT10.Size = New System.Drawing.Size(15, 14)
        Me.FT10.TabIndex = 140
        Me.FT10.UseVisualStyleBackColor = True
        '
        'FT9
        '
        Me.FT9.AutoSize = True
        Me.FT9.Location = New System.Drawing.Point(863, 105)
        Me.FT9.Name = "FT9"
        Me.FT9.Size = New System.Drawing.Size(15, 14)
        Me.FT9.TabIndex = 139
        Me.FT9.UseVisualStyleBackColor = True
        '
        'FT8
        '
        Me.FT8.AutoSize = True
        Me.FT8.Location = New System.Drawing.Point(863, 79)
        Me.FT8.Name = "FT8"
        Me.FT8.Size = New System.Drawing.Size(15, 14)
        Me.FT8.TabIndex = 138
        Me.FT8.UseVisualStyleBackColor = True
        '
        'FT7
        '
        Me.FT7.AutoSize = True
        Me.FT7.Location = New System.Drawing.Point(861, 53)
        Me.FT7.Name = "FT7"
        Me.FT7.Size = New System.Drawing.Size(15, 14)
        Me.FT7.TabIndex = 137
        Me.FT7.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(858, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 136
        Me.Label18.Text = "FT"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(823, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 13)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "USE"
        '
        'FT6
        '
        Me.FT6.AutoSize = True
        Me.FT6.Location = New System.Drawing.Point(423, 183)
        Me.FT6.Name = "FT6"
        Me.FT6.Size = New System.Drawing.Size(15, 14)
        Me.FT6.TabIndex = 134
        Me.FT6.UseVisualStyleBackColor = True
        '
        'FT5
        '
        Me.FT5.AutoSize = True
        Me.FT5.Location = New System.Drawing.Point(423, 156)
        Me.FT5.Name = "FT5"
        Me.FT5.Size = New System.Drawing.Size(15, 14)
        Me.FT5.TabIndex = 133
        Me.FT5.UseVisualStyleBackColor = True
        '
        'FT4
        '
        Me.FT4.AutoSize = True
        Me.FT4.Location = New System.Drawing.Point(423, 131)
        Me.FT4.Name = "FT4"
        Me.FT4.Size = New System.Drawing.Size(15, 14)
        Me.FT4.TabIndex = 132
        Me.FT4.UseVisualStyleBackColor = True
        '
        'FT3
        '
        Me.FT3.AutoSize = True
        Me.FT3.Location = New System.Drawing.Point(423, 105)
        Me.FT3.Name = "FT3"
        Me.FT3.Size = New System.Drawing.Size(15, 14)
        Me.FT3.TabIndex = 131
        Me.FT3.UseVisualStyleBackColor = True
        '
        'FT2
        '
        Me.FT2.AutoSize = True
        Me.FT2.Location = New System.Drawing.Point(423, 78)
        Me.FT2.Name = "FT2"
        Me.FT2.Size = New System.Drawing.Size(15, 14)
        Me.FT2.TabIndex = 130
        Me.FT2.UseVisualStyleBackColor = True
        '
        'FT1
        '
        Me.FT1.AutoSize = True
        Me.FT1.Location = New System.Drawing.Point(423, 53)
        Me.FT1.Name = "FT1"
        Me.FT1.Size = New System.Drawing.Size(15, 14)
        Me.FT1.TabIndex = 129
        Me.FT1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(418, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "FT"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(383, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "USE"
        '
        'PremScoresTitle2
        '
        Me.PremScoresTitle2.Location = New System.Drawing.Point(460, 19)
        Me.PremScoresTitle2.Name = "PremScoresTitle2"
        Me.PremScoresTitle2.Size = New System.Drawing.Size(126, 20)
        Me.PremScoresTitle2.TabIndex = 126
        Me.PremScoresTitle2.Text = "LATEST SCORES"
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Checked = True
        Me.CheckBox24.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox24.Location = New System.Drawing.Point(837, 182)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox24.TabIndex = 125
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Checked = True
        Me.CheckBox23.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox23.Location = New System.Drawing.Point(837, 157)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox23.TabIndex = 124
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Checked = True
        Me.CheckBox22.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox22.Location = New System.Drawing.Point(837, 131)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox22.TabIndex = 123
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Checked = True
        Me.CheckBox21.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox21.Location = New System.Drawing.Point(837, 105)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox21.TabIndex = 122
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Checked = True
        Me.CheckBox20.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox20.Location = New System.Drawing.Point(837, 79)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox20.TabIndex = 121
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Checked = True
        Me.CheckBox19.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox19.Location = New System.Drawing.Point(837, 53)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox19.TabIndex = 120
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Checked = True
        Me.CheckBox18.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox18.Location = New System.Drawing.Point(397, 183)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox18.TabIndex = 119
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Checked = True
        Me.CheckBox17.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox17.Location = New System.Drawing.Point(397, 156)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox17.TabIndex = 118
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Checked = True
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox16.Location = New System.Drawing.Point(397, 131)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox16.TabIndex = 117
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Checked = True
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox15.Location = New System.Drawing.Point(397, 105)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox15.TabIndex = 116
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.Location = New System.Drawing.Point(397, 78)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox14.TabIndex = 115
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = True
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.Location = New System.Drawing.Point(397, 53)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox13.TabIndex = 114
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'middle24
        '
        Me.middle24.FormattingEnabled = True
        Me.middle24.Items.AddRange(New Object() {":", "-"})
        Me.middle24.Location = New System.Drawing.Point(630, 180)
        Me.middle24.Name = "middle24"
        Me.middle24.Size = New System.Drawing.Size(29, 21)
        Me.middle24.TabIndex = 74
        '
        'middle23
        '
        Me.middle23.FormattingEnabled = True
        Me.middle23.Items.AddRange(New Object() {":", "-"})
        Me.middle23.Location = New System.Drawing.Point(630, 153)
        Me.middle23.Name = "middle23"
        Me.middle23.Size = New System.Drawing.Size(29, 21)
        Me.middle23.TabIndex = 73
        '
        'middle22
        '
        Me.middle22.FormattingEnabled = True
        Me.middle22.Items.AddRange(New Object() {":", "-"})
        Me.middle22.Location = New System.Drawing.Point(630, 128)
        Me.middle22.Name = "middle22"
        Me.middle22.Size = New System.Drawing.Size(29, 21)
        Me.middle22.TabIndex = 72
        '
        'middle21
        '
        Me.middle21.FormattingEnabled = True
        Me.middle21.Items.AddRange(New Object() {":", "-"})
        Me.middle21.Location = New System.Drawing.Point(630, 101)
        Me.middle21.Name = "middle21"
        Me.middle21.Size = New System.Drawing.Size(29, 21)
        Me.middle21.TabIndex = 71
        '
        'middle20
        '
        Me.middle20.FormattingEnabled = True
        Me.middle20.Items.AddRange(New Object() {":", "-"})
        Me.middle20.Location = New System.Drawing.Point(630, 75)
        Me.middle20.Name = "middle20"
        Me.middle20.Size = New System.Drawing.Size(29, 21)
        Me.middle20.TabIndex = 70
        '
        'middle19
        '
        Me.middle19.FormattingEnabled = True
        Me.middle19.Items.AddRange(New Object() {":", "-"})
        Me.middle19.Location = New System.Drawing.Point(630, 50)
        Me.middle19.Name = "middle19"
        Me.middle19.Size = New System.Drawing.Size(29, 21)
        Me.middle19.TabIndex = 69
        '
        'middle18
        '
        Me.middle18.FormattingEnabled = True
        Me.middle18.Items.AddRange(New Object() {":", "-"})
        Me.middle18.Location = New System.Drawing.Point(193, 179)
        Me.middle18.Name = "middle18"
        Me.middle18.Size = New System.Drawing.Size(29, 21)
        Me.middle18.TabIndex = 68
        '
        'middle17
        '
        Me.middle17.FormattingEnabled = True
        Me.middle17.Items.AddRange(New Object() {":", "-"})
        Me.middle17.Location = New System.Drawing.Point(193, 153)
        Me.middle17.Name = "middle17"
        Me.middle17.Size = New System.Drawing.Size(29, 21)
        Me.middle17.TabIndex = 67
        '
        'middle16
        '
        Me.middle16.FormattingEnabled = True
        Me.middle16.Items.AddRange(New Object() {":", "-"})
        Me.middle16.Location = New System.Drawing.Point(193, 128)
        Me.middle16.Name = "middle16"
        Me.middle16.Size = New System.Drawing.Size(29, 21)
        Me.middle16.TabIndex = 66
        '
        'middle15
        '
        Me.middle15.FormattingEnabled = True
        Me.middle15.Items.AddRange(New Object() {":", "-"})
        Me.middle15.Location = New System.Drawing.Point(193, 102)
        Me.middle15.Name = "middle15"
        Me.middle15.Size = New System.Drawing.Size(29, 21)
        Me.middle15.TabIndex = 65
        '
        'middle14
        '
        Me.middle14.FormattingEnabled = True
        Me.middle14.Items.AddRange(New Object() {":", "-"})
        Me.middle14.Location = New System.Drawing.Point(193, 76)
        Me.middle14.Name = "middle14"
        Me.middle14.Size = New System.Drawing.Size(29, 21)
        Me.middle14.TabIndex = 64
        '
        'middle13
        '
        Me.middle13.FormattingEnabled = True
        Me.middle13.Items.AddRange(New Object() {":", "-"})
        Me.middle13.Location = New System.Drawing.Point(193, 50)
        Me.middle13.Name = "middle13"
        Me.middle13.Size = New System.Drawing.Size(29, 21)
        Me.middle13.TabIndex = 63
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Controls.Add(Me.tab2Logo2Select)
        Me.TabPage4.Controls.Add(Me.Label79)
        Me.TabPage4.Controls.Add(Me.tab2Logo1Select)
        Me.TabPage4.Controls.Add(Me.Label78)
        Me.TabPage4.Controls.Add(Me.FT24)
        Me.TabPage4.Controls.Add(Me.FT23)
        Me.TabPage4.Controls.Add(Me.FT22)
        Me.TabPage4.Controls.Add(Me.FT21)
        Me.TabPage4.Controls.Add(Me.FT20)
        Me.TabPage4.Controls.Add(Me.FT19)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.FT18)
        Me.TabPage4.Controls.Add(Me.FT17)
        Me.TabPage4.Controls.Add(Me.FT16)
        Me.TabPage4.Controls.Add(Me.FT15)
        Me.TabPage4.Controls.Add(Me.FT14)
        Me.TabPage4.Controls.Add(Me.FT13)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.ChampScoresTitle2)
        Me.TabPage4.Controls.Add(Me.middle12)
        Me.TabPage4.Controls.Add(Me.middle11)
        Me.TabPage4.Controls.Add(Me.middle10)
        Me.TabPage4.Controls.Add(Me.middle9)
        Me.TabPage4.Controls.Add(Me.middle8)
        Me.TabPage4.Controls.Add(Me.middle7)
        Me.TabPage4.Controls.Add(Me.CheckBox7)
        Me.TabPage4.Controls.Add(Me.CheckBox8)
        Me.TabPage4.Controls.Add(Me.CheckBox9)
        Me.TabPage4.Controls.Add(Me.CheckBox10)
        Me.TabPage4.Controls.Add(Me.CheckBox11)
        Me.TabPage4.Controls.Add(Me.CheckBox12)
        Me.TabPage4.Controls.Add(Me.middle6)
        Me.TabPage4.Controls.Add(Me.middle5)
        Me.TabPage4.Controls.Add(Me.middle4)
        Me.TabPage4.Controls.Add(Me.middle3)
        Me.TabPage4.Controls.Add(Me.middle2)
        Me.TabPage4.Controls.Add(Me.middle1)
        Me.TabPage4.Controls.Add(Me.CheckBox6)
        Me.TabPage4.Controls.Add(Me.CheckBox5)
        Me.TabPage4.Controls.Add(Me.CheckBox4)
        Me.TabPage4.Controls.Add(Me.CheckBox3)
        Me.TabPage4.Controls.Add(Me.CheckBox2)
        Me.TabPage4.Controls.Add(Me.CheckBox1)
        Me.TabPage4.Controls.Add(Me.ChampScoresTitle)
        Me.TabPage4.Controls.Add(Me.ChampHide2BTN)
        Me.TabPage4.Controls.Add(Me.ChampScore1)
        Me.TabPage4.Controls.Add(Me.ChampTX2Btn)
        Me.TabPage4.Controls.Add(Me.ChampScore2)
        Me.TabPage4.Controls.Add(Me.ChampScore47)
        Me.TabPage4.Controls.Add(Me.ChampScore4)
        Me.TabPage4.Controls.Add(Me.ChampScore48)
        Me.TabPage4.Controls.Add(Me.ChampScore3)
        Me.TabPage4.Controls.Add(Me.ChampScore46)
        Me.TabPage4.Controls.Add(Me.ChampScore5)
        Me.TabPage4.Controls.Add(Me.ChampScore45)
        Me.TabPage4.Controls.Add(Me.ChampScore6)
        Me.TabPage4.Controls.Add(Me.ChampScore43)
        Me.TabPage4.Controls.Add(Me.ChampScore8)
        Me.TabPage4.Controls.Add(Me.ChampScore44)
        Me.TabPage4.Controls.Add(Me.ChampScore7)
        Me.TabPage4.Controls.Add(Me.ChampScore42)
        Me.TabPage4.Controls.Add(Me.ChampScore9)
        Me.TabPage4.Controls.Add(Me.ChampScore41)
        Me.TabPage4.Controls.Add(Me.ChampScore10)
        Me.TabPage4.Controls.Add(Me.ChampScore39)
        Me.TabPage4.Controls.Add(Me.ChampScore12)
        Me.TabPage4.Controls.Add(Me.ChampScore40)
        Me.TabPage4.Controls.Add(Me.ChampScore11)
        Me.TabPage4.Controls.Add(Me.ChampScore38)
        Me.TabPage4.Controls.Add(Me.ChampScore13)
        Me.TabPage4.Controls.Add(Me.ChampScore37)
        Me.TabPage4.Controls.Add(Me.ChampScore14)
        Me.TabPage4.Controls.Add(Me.ChampScore35)
        Me.TabPage4.Controls.Add(Me.ChampScore16)
        Me.TabPage4.Controls.Add(Me.ChampScore36)
        Me.TabPage4.Controls.Add(Me.ChampScore15)
        Me.TabPage4.Controls.Add(Me.ChampScore34)
        Me.TabPage4.Controls.Add(Me.ChampScore17)
        Me.TabPage4.Controls.Add(Me.ChampScore33)
        Me.TabPage4.Controls.Add(Me.ChampScore18)
        Me.TabPage4.Controls.Add(Me.ChampScore31)
        Me.TabPage4.Controls.Add(Me.ChampScore20)
        Me.TabPage4.Controls.Add(Me.ChampScore32)
        Me.TabPage4.Controls.Add(Me.ChampScore19)
        Me.TabPage4.Controls.Add(Me.ChampScore30)
        Me.TabPage4.Controls.Add(Me.ChampScore21)
        Me.TabPage4.Controls.Add(Me.ChampScore29)
        Me.TabPage4.Controls.Add(Me.ChampScore22)
        Me.TabPage4.Controls.Add(Me.ChampScore27)
        Me.TabPage4.Controls.Add(Me.ChampScore24)
        Me.TabPage4.Controls.Add(Me.ChampScore28)
        Me.TabPage4.Controls.Add(Me.ChampScore23)
        Me.TabPage4.Controls.Add(Me.ChampScore26)
        Me.TabPage4.Controls.Add(Me.ChampTX1Btn)
        Me.TabPage4.Controls.Add(Me.ChampScore25)
        Me.TabPage4.Controls.Add(Me.ChampHide1BTN)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(927, 247)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Tab 2"
        '
        'tab2Logo2Select
        '
        Me.tab2Logo2Select.FormattingEnabled = True
        Me.tab2Logo2Select.Items.AddRange(New Object() {"Premier League", "Championship", "FA Cup", "Capital One Cup", "Europa League", "Champions League"})
        Me.tab2Logo2Select.Location = New System.Drawing.Point(630, 18)
        Me.tab2Logo2Select.Name = "tab2Logo2Select"
        Me.tab2Logo2Select.Size = New System.Drawing.Size(177, 21)
        Me.tab2Logo2Select.TabIndex = 156
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(590, 22)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(34, 13)
        Me.Label79.TabIndex = 155
        Me.Label79.Text = "Logo:"
        '
        'tab2Logo1Select
        '
        Me.tab2Logo1Select.FormattingEnabled = True
        Me.tab2Logo1Select.Items.AddRange(New Object() {"Premier League", "Championship", "FA Cup", "Capital One Cup", "Europa League", "Champions League"})
        Me.tab2Logo1Select.Location = New System.Drawing.Point(176, 18)
        Me.tab2Logo1Select.Name = "tab2Logo1Select"
        Me.tab2Logo1Select.Size = New System.Drawing.Size(177, 21)
        Me.tab2Logo1Select.TabIndex = 154
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(136, 22)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(34, 13)
        Me.Label78.TabIndex = 153
        Me.Label78.Text = "Logo:"
        '
        'FT24
        '
        Me.FT24.AutoSize = True
        Me.FT24.Location = New System.Drawing.Point(864, 183)
        Me.FT24.Name = "FT24"
        Me.FT24.Size = New System.Drawing.Size(15, 14)
        Me.FT24.TabIndex = 152
        Me.FT24.UseVisualStyleBackColor = True
        '
        'FT23
        '
        Me.FT23.AutoSize = True
        Me.FT23.Location = New System.Drawing.Point(864, 156)
        Me.FT23.Name = "FT23"
        Me.FT23.Size = New System.Drawing.Size(15, 14)
        Me.FT23.TabIndex = 151
        Me.FT23.UseVisualStyleBackColor = True
        '
        'FT22
        '
        Me.FT22.AutoSize = True
        Me.FT22.Location = New System.Drawing.Point(864, 131)
        Me.FT22.Name = "FT22"
        Me.FT22.Size = New System.Drawing.Size(15, 14)
        Me.FT22.TabIndex = 150
        Me.FT22.UseVisualStyleBackColor = True
        '
        'FT21
        '
        Me.FT21.AutoSize = True
        Me.FT21.Location = New System.Drawing.Point(864, 105)
        Me.FT21.Name = "FT21"
        Me.FT21.Size = New System.Drawing.Size(15, 14)
        Me.FT21.TabIndex = 149
        Me.FT21.UseVisualStyleBackColor = True
        '
        'FT20
        '
        Me.FT20.AutoSize = True
        Me.FT20.Location = New System.Drawing.Point(864, 78)
        Me.FT20.Name = "FT20"
        Me.FT20.Size = New System.Drawing.Size(15, 14)
        Me.FT20.TabIndex = 148
        Me.FT20.UseVisualStyleBackColor = True
        '
        'FT19
        '
        Me.FT19.AutoSize = True
        Me.FT19.Location = New System.Drawing.Point(864, 53)
        Me.FT19.Name = "FT19"
        Me.FT19.Size = New System.Drawing.Size(15, 14)
        Me.FT19.TabIndex = 147
        Me.FT19.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(859, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 13)
        Me.Label22.TabIndex = 146
        Me.Label22.Text = "FT"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(824, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "USE"
        '
        'FT18
        '
        Me.FT18.AutoSize = True
        Me.FT18.Location = New System.Drawing.Point(410, 183)
        Me.FT18.Name = "FT18"
        Me.FT18.Size = New System.Drawing.Size(15, 14)
        Me.FT18.TabIndex = 144
        Me.FT18.UseVisualStyleBackColor = True
        '
        'FT17
        '
        Me.FT17.AutoSize = True
        Me.FT17.Location = New System.Drawing.Point(410, 156)
        Me.FT17.Name = "FT17"
        Me.FT17.Size = New System.Drawing.Size(15, 14)
        Me.FT17.TabIndex = 143
        Me.FT17.UseVisualStyleBackColor = True
        '
        'FT16
        '
        Me.FT16.AutoSize = True
        Me.FT16.Location = New System.Drawing.Point(410, 131)
        Me.FT16.Name = "FT16"
        Me.FT16.Size = New System.Drawing.Size(15, 14)
        Me.FT16.TabIndex = 142
        Me.FT16.UseVisualStyleBackColor = True
        '
        'FT15
        '
        Me.FT15.AutoSize = True
        Me.FT15.Location = New System.Drawing.Point(410, 105)
        Me.FT15.Name = "FT15"
        Me.FT15.Size = New System.Drawing.Size(15, 14)
        Me.FT15.TabIndex = 141
        Me.FT15.UseVisualStyleBackColor = True
        '
        'FT14
        '
        Me.FT14.AutoSize = True
        Me.FT14.Location = New System.Drawing.Point(410, 78)
        Me.FT14.Name = "FT14"
        Me.FT14.Size = New System.Drawing.Size(15, 14)
        Me.FT14.TabIndex = 140
        Me.FT14.UseVisualStyleBackColor = True
        '
        'FT13
        '
        Me.FT13.AutoSize = True
        Me.FT13.Location = New System.Drawing.Point(410, 53)
        Me.FT13.Name = "FT13"
        Me.FT13.Size = New System.Drawing.Size(15, 14)
        Me.FT13.TabIndex = 139
        Me.FT13.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(405, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 13)
        Me.Label20.TabIndex = 138
        Me.Label20.Text = "FT"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(370, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "USE"
        '
        'ChampScoresTitle2
        '
        Me.ChampScoresTitle2.Location = New System.Drawing.Point(456, 19)
        Me.ChampScoresTitle2.Name = "ChampScoresTitle2"
        Me.ChampScoresTitle2.Size = New System.Drawing.Size(126, 20)
        Me.ChampScoresTitle2.TabIndex = 136
        Me.ChampScoresTitle2.Text = "LATEST SCORES"
        '
        'middle12
        '
        Me.middle12.FormattingEnabled = True
        Me.middle12.Items.AddRange(New Object() {":", "-"})
        Me.middle12.Location = New System.Drawing.Point(630, 181)
        Me.middle12.Name = "middle12"
        Me.middle12.Size = New System.Drawing.Size(29, 21)
        Me.middle12.TabIndex = 135
        '
        'middle11
        '
        Me.middle11.FormattingEnabled = True
        Me.middle11.Items.AddRange(New Object() {":", "-"})
        Me.middle11.Location = New System.Drawing.Point(630, 155)
        Me.middle11.Name = "middle11"
        Me.middle11.Size = New System.Drawing.Size(29, 21)
        Me.middle11.TabIndex = 134
        '
        'middle10
        '
        Me.middle10.FormattingEnabled = True
        Me.middle10.Items.AddRange(New Object() {":", "-"})
        Me.middle10.Location = New System.Drawing.Point(630, 129)
        Me.middle10.Name = "middle10"
        Me.middle10.Size = New System.Drawing.Size(29, 21)
        Me.middle10.TabIndex = 133
        '
        'middle9
        '
        Me.middle9.FormattingEnabled = True
        Me.middle9.Items.AddRange(New Object() {":", "-"})
        Me.middle9.Location = New System.Drawing.Point(630, 102)
        Me.middle9.Name = "middle9"
        Me.middle9.Size = New System.Drawing.Size(29, 21)
        Me.middle9.TabIndex = 132
        '
        'middle8
        '
        Me.middle8.FormattingEnabled = True
        Me.middle8.Items.AddRange(New Object() {":", "-"})
        Me.middle8.Location = New System.Drawing.Point(630, 77)
        Me.middle8.Name = "middle8"
        Me.middle8.Size = New System.Drawing.Size(29, 21)
        Me.middle8.TabIndex = 131
        '
        'middle7
        '
        Me.middle7.FormattingEnabled = True
        Me.middle7.Items.AddRange(New Object() {":", "-"})
        Me.middle7.Location = New System.Drawing.Point(630, 50)
        Me.middle7.Name = "middle7"
        Me.middle7.Size = New System.Drawing.Size(29, 21)
        Me.middle7.TabIndex = 124
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Location = New System.Drawing.Point(838, 183)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 130
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Location = New System.Drawing.Point(838, 157)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 129
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(838, 131)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox9.TabIndex = 128
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(838, 105)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox10.TabIndex = 127
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(838, 79)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox11.TabIndex = 126
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(838, 53)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox12.TabIndex = 125
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'middle6
        '
        Me.middle6.FormattingEnabled = True
        Me.middle6.Items.AddRange(New Object() {":", "-"})
        Me.middle6.Location = New System.Drawing.Point(176, 181)
        Me.middle6.Name = "middle6"
        Me.middle6.Size = New System.Drawing.Size(29, 21)
        Me.middle6.TabIndex = 123
        '
        'middle5
        '
        Me.middle5.FormattingEnabled = True
        Me.middle5.Items.AddRange(New Object() {":", "-"})
        Me.middle5.Location = New System.Drawing.Point(176, 155)
        Me.middle5.Name = "middle5"
        Me.middle5.Size = New System.Drawing.Size(29, 21)
        Me.middle5.TabIndex = 122
        '
        'middle4
        '
        Me.middle4.FormattingEnabled = True
        Me.middle4.Items.AddRange(New Object() {":", "-"})
        Me.middle4.Location = New System.Drawing.Point(176, 129)
        Me.middle4.Name = "middle4"
        Me.middle4.Size = New System.Drawing.Size(29, 21)
        Me.middle4.TabIndex = 121
        '
        'middle3
        '
        Me.middle3.FormattingEnabled = True
        Me.middle3.Items.AddRange(New Object() {":", "-"})
        Me.middle3.Location = New System.Drawing.Point(176, 102)
        Me.middle3.Name = "middle3"
        Me.middle3.Size = New System.Drawing.Size(29, 21)
        Me.middle3.TabIndex = 120
        '
        'middle2
        '
        Me.middle2.FormattingEnabled = True
        Me.middle2.Items.AddRange(New Object() {":", "-"})
        Me.middle2.Location = New System.Drawing.Point(176, 77)
        Me.middle2.Name = "middle2"
        Me.middle2.Size = New System.Drawing.Size(29, 21)
        Me.middle2.TabIndex = 119
        '
        'middle1
        '
        Me.middle1.FormattingEnabled = True
        Me.middle1.Items.AddRange(New Object() {":", "-"})
        Me.middle1.Location = New System.Drawing.Point(176, 50)
        Me.middle1.Name = "middle1"
        Me.middle1.Size = New System.Drawing.Size(29, 21)
        Me.middle1.TabIndex = 62
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(384, 183)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 118
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(384, 157)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 117
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(384, 131)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 116
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(384, 105)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 115
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(384, 79)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 114
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(384, 53)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 113
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ChampScoresTitle
        '
        Me.ChampScoresTitle.Location = New System.Drawing.Point(6, 19)
        Me.ChampScoresTitle.Name = "ChampScoresTitle"
        Me.ChampScoresTitle.Size = New System.Drawing.Size(126, 20)
        Me.ChampScoresTitle.TabIndex = 112
        Me.ChampScoresTitle.Text = "LATEST SCORES"
        '
        'ChampHide2BTN
        '
        Me.ChampHide2BTN.Location = New System.Drawing.Point(729, 206)
        Me.ChampHide2BTN.Name = "ChampHide2BTN"
        Me.ChampHide2BTN.Size = New System.Drawing.Size(102, 26)
        Me.ChampHide2BTN.TabIndex = 111
        Me.ChampHide2BTN.Text = "Hide"
        Me.ChampHide2BTN.UseVisualStyleBackColor = True
        '
        'ChampScore1
        '
        Me.ChampScore1.Location = New System.Drawing.Point(6, 51)
        Me.ChampScore1.Name = "ChampScore1"
        Me.ChampScore1.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore1.TabIndex = 56
        '
        'ChampTX2Btn
        '
        Me.ChampTX2Btn.Location = New System.Drawing.Point(456, 206)
        Me.ChampTX2Btn.Name = "ChampTX2Btn"
        Me.ChampTX2Btn.Size = New System.Drawing.Size(102, 26)
        Me.ChampTX2Btn.TabIndex = 110
        Me.ChampTX2Btn.Text = "Show"
        Me.ChampTX2Btn.UseVisualStyleBackColor = True
        '
        'ChampScore2
        '
        Me.ChampScore2.Location = New System.Drawing.Point(138, 51)
        Me.ChampScore2.Name = "ChampScore2"
        Me.ChampScore2.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore2.TabIndex = 57
        '
        'ChampScore47
        '
        Me.ChampScore47.Location = New System.Drawing.Point(665, 180)
        Me.ChampScore47.Name = "ChampScore47"
        Me.ChampScore47.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore47.TabIndex = 108
        '
        'ChampScore4
        '
        Me.ChampScore4.Location = New System.Drawing.Point(252, 50)
        Me.ChampScore4.Name = "ChampScore4"
        Me.ChampScore4.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore4.TabIndex = 59
        '
        'ChampScore48
        '
        Me.ChampScore48.Location = New System.Drawing.Point(705, 180)
        Me.ChampScore48.Name = "ChampScore48"
        Me.ChampScore48.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore48.TabIndex = 109
        '
        'ChampScore3
        '
        Me.ChampScore3.Location = New System.Drawing.Point(212, 50)
        Me.ChampScore3.Name = "ChampScore3"
        Me.ChampScore3.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore3.TabIndex = 58
        '
        'ChampScore46
        '
        Me.ChampScore46.Location = New System.Drawing.Point(588, 180)
        Me.ChampScore46.Name = "ChampScore46"
        Me.ChampScore46.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore46.TabIndex = 107
        '
        'ChampScore5
        '
        Me.ChampScore5.Location = New System.Drawing.Point(6, 77)
        Me.ChampScore5.Name = "ChampScore5"
        Me.ChampScore5.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore5.TabIndex = 61
        '
        'ChampScore45
        '
        Me.ChampScore45.Location = New System.Drawing.Point(456, 180)
        Me.ChampScore45.Name = "ChampScore45"
        Me.ChampScore45.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore45.TabIndex = 106
        '
        'ChampScore6
        '
        Me.ChampScore6.Location = New System.Drawing.Point(138, 77)
        Me.ChampScore6.Name = "ChampScore6"
        Me.ChampScore6.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore6.TabIndex = 62
        '
        'ChampScore43
        '
        Me.ChampScore43.Location = New System.Drawing.Point(665, 154)
        Me.ChampScore43.Name = "ChampScore43"
        Me.ChampScore43.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore43.TabIndex = 104
        '
        'ChampScore8
        '
        Me.ChampScore8.Location = New System.Drawing.Point(252, 76)
        Me.ChampScore8.Name = "ChampScore8"
        Me.ChampScore8.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore8.TabIndex = 64
        '
        'ChampScore44
        '
        Me.ChampScore44.Location = New System.Drawing.Point(705, 154)
        Me.ChampScore44.Name = "ChampScore44"
        Me.ChampScore44.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore44.TabIndex = 105
        '
        'ChampScore7
        '
        Me.ChampScore7.Location = New System.Drawing.Point(212, 76)
        Me.ChampScore7.Name = "ChampScore7"
        Me.ChampScore7.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore7.TabIndex = 63
        '
        'ChampScore42
        '
        Me.ChampScore42.Location = New System.Drawing.Point(588, 154)
        Me.ChampScore42.Name = "ChampScore42"
        Me.ChampScore42.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore42.TabIndex = 103
        '
        'ChampScore9
        '
        Me.ChampScore9.Location = New System.Drawing.Point(6, 103)
        Me.ChampScore9.Name = "ChampScore9"
        Me.ChampScore9.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore9.TabIndex = 65
        '
        'ChampScore41
        '
        Me.ChampScore41.Location = New System.Drawing.Point(456, 154)
        Me.ChampScore41.Name = "ChampScore41"
        Me.ChampScore41.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore41.TabIndex = 102
        '
        'ChampScore10
        '
        Me.ChampScore10.Location = New System.Drawing.Point(138, 103)
        Me.ChampScore10.Name = "ChampScore10"
        Me.ChampScore10.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore10.TabIndex = 66
        '
        'ChampScore39
        '
        Me.ChampScore39.Location = New System.Drawing.Point(665, 128)
        Me.ChampScore39.Name = "ChampScore39"
        Me.ChampScore39.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore39.TabIndex = 100
        '
        'ChampScore12
        '
        Me.ChampScore12.Location = New System.Drawing.Point(252, 102)
        Me.ChampScore12.Name = "ChampScore12"
        Me.ChampScore12.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore12.TabIndex = 68
        '
        'ChampScore40
        '
        Me.ChampScore40.Location = New System.Drawing.Point(705, 128)
        Me.ChampScore40.Name = "ChampScore40"
        Me.ChampScore40.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore40.TabIndex = 101
        '
        'ChampScore11
        '
        Me.ChampScore11.Location = New System.Drawing.Point(212, 102)
        Me.ChampScore11.Name = "ChampScore11"
        Me.ChampScore11.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore11.TabIndex = 67
        '
        'ChampScore38
        '
        Me.ChampScore38.Location = New System.Drawing.Point(588, 128)
        Me.ChampScore38.Name = "ChampScore38"
        Me.ChampScore38.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore38.TabIndex = 99
        '
        'ChampScore13
        '
        Me.ChampScore13.Location = New System.Drawing.Point(6, 129)
        Me.ChampScore13.Name = "ChampScore13"
        Me.ChampScore13.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore13.TabIndex = 69
        '
        'ChampScore37
        '
        Me.ChampScore37.Location = New System.Drawing.Point(456, 128)
        Me.ChampScore37.Name = "ChampScore37"
        Me.ChampScore37.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore37.TabIndex = 98
        '
        'ChampScore14
        '
        Me.ChampScore14.Location = New System.Drawing.Point(138, 129)
        Me.ChampScore14.Name = "ChampScore14"
        Me.ChampScore14.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore14.TabIndex = 70
        '
        'ChampScore35
        '
        Me.ChampScore35.Location = New System.Drawing.Point(665, 102)
        Me.ChampScore35.Name = "ChampScore35"
        Me.ChampScore35.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore35.TabIndex = 96
        '
        'ChampScore16
        '
        Me.ChampScore16.Location = New System.Drawing.Point(252, 128)
        Me.ChampScore16.Name = "ChampScore16"
        Me.ChampScore16.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore16.TabIndex = 72
        '
        'ChampScore36
        '
        Me.ChampScore36.Location = New System.Drawing.Point(705, 102)
        Me.ChampScore36.Name = "ChampScore36"
        Me.ChampScore36.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore36.TabIndex = 97
        '
        'ChampScore15
        '
        Me.ChampScore15.Location = New System.Drawing.Point(212, 128)
        Me.ChampScore15.Name = "ChampScore15"
        Me.ChampScore15.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore15.TabIndex = 71
        '
        'ChampScore34
        '
        Me.ChampScore34.Location = New System.Drawing.Point(588, 102)
        Me.ChampScore34.Name = "ChampScore34"
        Me.ChampScore34.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore34.TabIndex = 95
        '
        'ChampScore17
        '
        Me.ChampScore17.Location = New System.Drawing.Point(6, 155)
        Me.ChampScore17.Name = "ChampScore17"
        Me.ChampScore17.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore17.TabIndex = 73
        '
        'ChampScore33
        '
        Me.ChampScore33.Location = New System.Drawing.Point(456, 102)
        Me.ChampScore33.Name = "ChampScore33"
        Me.ChampScore33.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore33.TabIndex = 94
        '
        'ChampScore18
        '
        Me.ChampScore18.Location = New System.Drawing.Point(138, 155)
        Me.ChampScore18.Name = "ChampScore18"
        Me.ChampScore18.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore18.TabIndex = 74
        '
        'ChampScore31
        '
        Me.ChampScore31.Location = New System.Drawing.Point(665, 76)
        Me.ChampScore31.Name = "ChampScore31"
        Me.ChampScore31.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore31.TabIndex = 92
        '
        'ChampScore20
        '
        Me.ChampScore20.Location = New System.Drawing.Point(252, 154)
        Me.ChampScore20.Name = "ChampScore20"
        Me.ChampScore20.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore20.TabIndex = 76
        '
        'ChampScore32
        '
        Me.ChampScore32.Location = New System.Drawing.Point(705, 76)
        Me.ChampScore32.Name = "ChampScore32"
        Me.ChampScore32.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore32.TabIndex = 93
        '
        'ChampScore19
        '
        Me.ChampScore19.Location = New System.Drawing.Point(212, 154)
        Me.ChampScore19.Name = "ChampScore19"
        Me.ChampScore19.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore19.TabIndex = 75
        '
        'ChampScore30
        '
        Me.ChampScore30.Location = New System.Drawing.Point(588, 76)
        Me.ChampScore30.Name = "ChampScore30"
        Me.ChampScore30.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore30.TabIndex = 91
        '
        'ChampScore21
        '
        Me.ChampScore21.Location = New System.Drawing.Point(6, 181)
        Me.ChampScore21.Name = "ChampScore21"
        Me.ChampScore21.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore21.TabIndex = 77
        '
        'ChampScore29
        '
        Me.ChampScore29.Location = New System.Drawing.Point(456, 76)
        Me.ChampScore29.Name = "ChampScore29"
        Me.ChampScore29.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore29.TabIndex = 89
        '
        'ChampScore22
        '
        Me.ChampScore22.Location = New System.Drawing.Point(138, 181)
        Me.ChampScore22.Name = "ChampScore22"
        Me.ChampScore22.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore22.TabIndex = 78
        '
        'ChampScore27
        '
        Me.ChampScore27.Location = New System.Drawing.Point(665, 50)
        Me.ChampScore27.Name = "ChampScore27"
        Me.ChampScore27.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore27.TabIndex = 87
        '
        'ChampScore24
        '
        Me.ChampScore24.Location = New System.Drawing.Point(252, 180)
        Me.ChampScore24.Name = "ChampScore24"
        Me.ChampScore24.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore24.TabIndex = 80
        '
        'ChampScore28
        '
        Me.ChampScore28.Location = New System.Drawing.Point(705, 50)
        Me.ChampScore28.Name = "ChampScore28"
        Me.ChampScore28.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore28.TabIndex = 88
        '
        'ChampScore23
        '
        Me.ChampScore23.Location = New System.Drawing.Point(212, 180)
        Me.ChampScore23.Name = "ChampScore23"
        Me.ChampScore23.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore23.TabIndex = 79
        '
        'ChampScore26
        '
        Me.ChampScore26.Location = New System.Drawing.Point(588, 50)
        Me.ChampScore26.Name = "ChampScore26"
        Me.ChampScore26.Size = New System.Drawing.Size(34, 20)
        Me.ChampScore26.TabIndex = 86
        '
        'ChampTX1Btn
        '
        Me.ChampTX1Btn.Location = New System.Drawing.Point(6, 207)
        Me.ChampTX1Btn.Name = "ChampTX1Btn"
        Me.ChampTX1Btn.Size = New System.Drawing.Size(102, 26)
        Me.ChampTX1Btn.TabIndex = 81
        Me.ChampTX1Btn.Text = "Show"
        Me.ChampTX1Btn.UseVisualStyleBackColor = True
        '
        'ChampScore25
        '
        Me.ChampScore25.Location = New System.Drawing.Point(456, 50)
        Me.ChampScore25.Name = "ChampScore25"
        Me.ChampScore25.Size = New System.Drawing.Size(126, 20)
        Me.ChampScore25.TabIndex = 85
        '
        'ChampHide1BTN
        '
        Me.ChampHide1BTN.Location = New System.Drawing.Point(276, 206)
        Me.ChampHide1BTN.Name = "ChampHide1BTN"
        Me.ChampHide1BTN.Size = New System.Drawing.Size(102, 26)
        Me.ChampHide1BTN.TabIndex = 82
        Me.ChampHide1BTN.Text = "Hide"
        Me.ChampHide1BTN.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SendEditedAwayScorers)
        Me.GroupBox3.Controls.Add(Me.EditTextAwayScorers)
        Me.GroupBox3.Controls.Add(Me.EditAwayScorers)
        Me.GroupBox3.Controls.Add(Me.RemoveAwayScoreresLB)
        Me.GroupBox3.Controls.Add(Me.SendEditedHomeScorers)
        Me.GroupBox3.Controls.Add(Me.EditTextHomeScorers)
        Me.GroupBox3.Controls.Add(Me.EditHomeScorers)
        Me.GroupBox3.Controls.Add(Me.RemoveHomerScoreresLB)
        Me.GroupBox3.Controls.Add(Me.awayScorers)
        Me.GroupBox3.Controls.Add(Me.HomeScorers)
        Me.GroupBox3.Controls.Add(Me.hideBigScore)
        Me.GroupBox3.Controls.Add(Me.showBigScore)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(876, 184)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Scorers"
        '
        'SendEditedAwayScorers
        '
        Me.SendEditedAwayScorers.Location = New System.Drawing.Point(627, 104)
        Me.SendEditedAwayScorers.Name = "SendEditedAwayScorers"
        Me.SendEditedAwayScorers.Size = New System.Drawing.Size(122, 23)
        Me.SendEditedAwayScorers.TabIndex = 61
        Me.SendEditedAwayScorers.Text = "Save Edited"
        Me.SendEditedAwayScorers.UseVisualStyleBackColor = True
        '
        'EditTextAwayScorers
        '
        Me.EditTextAwayScorers.Location = New System.Drawing.Point(627, 77)
        Me.EditTextAwayScorers.Name = "EditTextAwayScorers"
        Me.EditTextAwayScorers.Size = New System.Drawing.Size(208, 20)
        Me.EditTextAwayScorers.TabIndex = 60
        '
        'EditAwayScorers
        '
        Me.EditAwayScorers.Location = New System.Drawing.Point(627, 48)
        Me.EditAwayScorers.Name = "EditAwayScorers"
        Me.EditAwayScorers.Size = New System.Drawing.Size(122, 23)
        Me.EditAwayScorers.TabIndex = 59
        Me.EditAwayScorers.Text = "Edit"
        Me.EditAwayScorers.UseVisualStyleBackColor = True
        '
        'RemoveAwayScoreresLB
        '
        Me.RemoveAwayScoreresLB.Location = New System.Drawing.Point(627, 19)
        Me.RemoveAwayScoreresLB.Name = "RemoveAwayScoreresLB"
        Me.RemoveAwayScoreresLB.Size = New System.Drawing.Size(122, 23)
        Me.RemoveAwayScoreresLB.TabIndex = 58
        Me.RemoveAwayScoreresLB.Text = "Remove"
        Me.RemoveAwayScoreresLB.UseVisualStyleBackColor = True
        '
        'SendEditedHomeScorers
        '
        Me.SendEditedHomeScorers.Location = New System.Drawing.Point(94, 104)
        Me.SendEditedHomeScorers.Name = "SendEditedHomeScorers"
        Me.SendEditedHomeScorers.Size = New System.Drawing.Size(122, 23)
        Me.SendEditedHomeScorers.TabIndex = 57
        Me.SendEditedHomeScorers.Text = "Save Edited"
        Me.SendEditedHomeScorers.UseVisualStyleBackColor = True
        '
        'EditTextHomeScorers
        '
        Me.EditTextHomeScorers.Location = New System.Drawing.Point(25, 77)
        Me.EditTextHomeScorers.Name = "EditTextHomeScorers"
        Me.EditTextHomeScorers.Size = New System.Drawing.Size(195, 20)
        Me.EditTextHomeScorers.TabIndex = 56
        '
        'EditHomeScorers
        '
        Me.EditHomeScorers.Location = New System.Drawing.Point(94, 48)
        Me.EditHomeScorers.Name = "EditHomeScorers"
        Me.EditHomeScorers.Size = New System.Drawing.Size(122, 23)
        Me.EditHomeScorers.TabIndex = 10
        Me.EditHomeScorers.Text = "Edit"
        Me.EditHomeScorers.UseVisualStyleBackColor = True
        '
        'RemoveHomerScoreresLB
        '
        Me.RemoveHomerScoreresLB.Location = New System.Drawing.Point(94, 19)
        Me.RemoveHomerScoreresLB.Name = "RemoveHomerScoreresLB"
        Me.RemoveHomerScoreresLB.Size = New System.Drawing.Size(122, 23)
        Me.RemoveHomerScoreresLB.TabIndex = 9
        Me.RemoveHomerScoreresLB.Text = "Remove"
        Me.RemoveHomerScoreresLB.UseVisualStyleBackColor = True
        '
        'awayScorers
        '
        Me.awayScorers.FormattingEnabled = True
        Me.awayScorers.Location = New System.Drawing.Point(441, 19)
        Me.awayScorers.Name = "awayScorers"
        Me.awayScorers.Size = New System.Drawing.Size(180, 108)
        Me.awayScorers.TabIndex = 8
        '
        'HomeScorers
        '
        Me.HomeScorers.FormattingEnabled = True
        Me.HomeScorers.Location = New System.Drawing.Point(222, 19)
        Me.HomeScorers.Name = "HomeScorers"
        Me.HomeScorers.Size = New System.Drawing.Size(180, 108)
        Me.HomeScorers.TabIndex = 7
        '
        'hideBigScore
        '
        Me.hideBigScore.Location = New System.Drawing.Point(489, 142)
        Me.hideBigScore.Name = "hideBigScore"
        Me.hideBigScore.Size = New System.Drawing.Size(132, 23)
        Me.hideBigScore.TabIndex = 6
        Me.hideBigScore.Text = "Hide"
        Me.hideBigScore.UseVisualStyleBackColor = True
        '
        'showBigScore
        '
        Me.showBigScore.Location = New System.Drawing.Point(220, 142)
        Me.showBigScore.Name = "showBigScore"
        Me.showBigScore.Size = New System.Drawing.Size(122, 23)
        Me.showBigScore.TabIndex = 6
        Me.showBigScore.Text = "Show"
        Me.showBigScore.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage5.Controls.Add(Me.GroupBox7)
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Controls.Add(Me.Clock)
        Me.TabPage5.Controls.Add(Me.Crawl)
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "In Game"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Away1stElevenCrawler)
        Me.GroupBox7.Controls.Add(Me.Home1stElevenCrawler)
        Me.GroupBox7.Controls.Add(Me.ShowAwayFirstElevenCrawl)
        Me.GroupBox7.Controls.Add(Me.ShowHomeFirstElevenCrawl)
        Me.GroupBox7.Controls.Add(Me.TSCrawlOffBTN)
        Me.GroupBox7.Controls.Add(Me.TSCrawlOnBTN)
        Me.GroupBox7.Location = New System.Drawing.Point(18, 520)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(369, 101)
        Me.GroupBox7.TabIndex = 117
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Team Sheet Crawl"
        '
        'Away1stElevenCrawler
        '
        Me.Away1stElevenCrawler.AutoSize = True
        Me.Away1stElevenCrawler.Location = New System.Drawing.Point(173, 17)
        Me.Away1stElevenCrawler.Name = "Away1stElevenCrawler"
        Me.Away1stElevenCrawler.Size = New System.Drawing.Size(83, 17)
        Me.Away1stElevenCrawler.TabIndex = 121
        Me.Away1stElevenCrawler.Text = "Away 1st 11"
        Me.Away1stElevenCrawler.UseVisualStyleBackColor = True
        '
        'Home1stElevenCrawler
        '
        Me.Home1stElevenCrawler.AutoSize = True
        Me.Home1stElevenCrawler.Checked = True
        Me.Home1stElevenCrawler.Location = New System.Drawing.Point(55, 19)
        Me.Home1stElevenCrawler.Name = "Home1stElevenCrawler"
        Me.Home1stElevenCrawler.Size = New System.Drawing.Size(85, 17)
        Me.Home1stElevenCrawler.TabIndex = 120
        Me.Home1stElevenCrawler.TabStop = True
        Me.Home1stElevenCrawler.Text = "Home 1st 11"
        Me.Home1stElevenCrawler.UseVisualStyleBackColor = True
        '
        'ShowAwayFirstElevenCrawl
        '
        Me.ShowAwayFirstElevenCrawl.AutoSize = True
        Me.ShowAwayFirstElevenCrawl.Location = New System.Drawing.Point(173, 40)
        Me.ShowAwayFirstElevenCrawl.Name = "ShowAwayFirstElevenCrawl"
        Me.ShowAwayFirstElevenCrawl.Size = New System.Drawing.Size(81, 17)
        Me.ShowAwayFirstElevenCrawl.TabIndex = 119
        Me.ShowAwayFirstElevenCrawl.Text = "Away Team"
        Me.ShowAwayFirstElevenCrawl.UseVisualStyleBackColor = True
        '
        'ShowHomeFirstElevenCrawl
        '
        Me.ShowHomeFirstElevenCrawl.AutoSize = True
        Me.ShowHomeFirstElevenCrawl.Location = New System.Drawing.Point(55, 40)
        Me.ShowHomeFirstElevenCrawl.Name = "ShowHomeFirstElevenCrawl"
        Me.ShowHomeFirstElevenCrawl.Size = New System.Drawing.Size(83, 17)
        Me.ShowHomeFirstElevenCrawl.TabIndex = 118
        Me.ShowHomeFirstElevenCrawl.Text = "Home Team"
        Me.ShowHomeFirstElevenCrawl.UseVisualStyleBackColor = True
        '
        'TSCrawlOffBTN
        '
        Me.TSCrawlOffBTN.Location = New System.Drawing.Point(161, 72)
        Me.TSCrawlOffBTN.Name = "TSCrawlOffBTN"
        Me.TSCrawlOffBTN.Size = New System.Drawing.Size(75, 23)
        Me.TSCrawlOffBTN.TabIndex = 12
        Me.TSCrawlOffBTN.Text = "Crawl Off"
        Me.TSCrawlOffBTN.UseVisualStyleBackColor = True
        '
        'TSCrawlOnBTN
        '
        Me.TSCrawlOnBTN.Location = New System.Drawing.Point(80, 72)
        Me.TSCrawlOnBTN.Name = "TSCrawlOnBTN"
        Me.TSCrawlOnBTN.Size = New System.Drawing.Size(75, 23)
        Me.TSCrawlOnBTN.TabIndex = 11
        Me.TSCrawlOnBTN.Text = "Crawl On"
        Me.TSCrawlOnBTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hideAddedTimeButton)
        Me.GroupBox1.Controls.Add(Me.addedTimeVals)
        Me.GroupBox1.Controls.Add(Me.showAddedTimeBTN)
        Me.GroupBox1.Location = New System.Drawing.Point(791, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(94, 120)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Added Time"
        '
        'hideAddedTimeButton
        '
        Me.hideAddedTimeButton.Location = New System.Drawing.Point(6, 77)
        Me.hideAddedTimeButton.Name = "hideAddedTimeButton"
        Me.hideAddedTimeButton.Size = New System.Drawing.Size(75, 23)
        Me.hideAddedTimeButton.TabIndex = 58
        Me.hideAddedTimeButton.Text = "Hide"
        Me.hideAddedTimeButton.UseVisualStyleBackColor = True
        '
        'addedTimeVals
        '
        Me.addedTimeVals.FormattingEnabled = True
        Me.addedTimeVals.Items.AddRange(New Object() {"+1", "+2", "+3", "+4", "+5", "+6", "+7", "+8", "+9", "+10", "+11", "+12", "+13", "+14", "+15"})
        Me.addedTimeVals.Location = New System.Drawing.Point(6, 20)
        Me.addedTimeVals.Name = "addedTimeVals"
        Me.addedTimeVals.Size = New System.Drawing.Size(75, 21)
        Me.addedTimeVals.TabIndex = 56
        '
        'showAddedTimeBTN
        '
        Me.showAddedTimeBTN.Location = New System.Drawing.Point(6, 48)
        Me.showAddedTimeBTN.Name = "showAddedTimeBTN"
        Me.showAddedTimeBTN.Size = New System.Drawing.Size(75, 23)
        Me.showAddedTimeBTN.TabIndex = 29
        Me.showAddedTimeBTN.Text = "Show"
        Me.showAddedTimeBTN.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.igPlaylistLoadBTN)
        Me.GroupBox6.Controls.Add(Me.igPlaylistSaveBTN)
        Me.GroupBox6.Controls.Add(Me.WipeTransInGame)
        Me.GroupBox6.Controls.Add(Me.PushTransInGame)
        Me.GroupBox6.Controls.Add(Me.MixTransInGame)
        Me.GroupBox6.Controls.Add(Me.Label73)
        Me.GroupBox6.Controls.Add(Me.PLInGameMoveDown)
        Me.GroupBox6.Controls.Add(Me.PlayNextVidInGame)
        Me.GroupBox6.Controls.Add(Me.PLInGameMoveUp)
        Me.GroupBox6.Controls.Add(Me.stopVidInGame)
        Me.GroupBox6.Controls.Add(Me.PlayVidInGame)
        Me.GroupBox6.Controls.Add(Me.ClearPlaylistInGame)
        Me.GroupBox6.Controls.Add(Me.RemovePlaylistInGame)
        Me.GroupBox6.Controls.Add(Me.AddPlaylistInGame)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.refreshVideInGame)
        Me.GroupBox6.Controls.Add(Me.playlistFilesInGame)
        Me.GroupBox6.Controls.Add(Me.SourceFilesInGame)
        Me.GroupBox6.Location = New System.Drawing.Point(900, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(347, 605)
        Me.GroupBox6.TabIndex = 116
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stills Playout"
        '
        'igPlaylistLoadBTN
        '
        Me.igPlaylistLoadBTN.Location = New System.Drawing.Point(101, 574)
        Me.igPlaylistLoadBTN.Name = "igPlaylistLoadBTN"
        Me.igPlaylistLoadBTN.Size = New System.Drawing.Size(86, 23)
        Me.igPlaylistLoadBTN.TabIndex = 125
        Me.igPlaylistLoadBTN.Text = "Load"
        Me.igPlaylistLoadBTN.UseVisualStyleBackColor = True
        '
        'igPlaylistSaveBTN
        '
        Me.igPlaylistSaveBTN.Location = New System.Drawing.Point(9, 574)
        Me.igPlaylistSaveBTN.Name = "igPlaylistSaveBTN"
        Me.igPlaylistSaveBTN.Size = New System.Drawing.Size(86, 23)
        Me.igPlaylistSaveBTN.TabIndex = 124
        Me.igPlaylistSaveBTN.Text = "Save"
        Me.igPlaylistSaveBTN.UseVisualStyleBackColor = True
        '
        'WipeTransInGame
        '
        Me.WipeTransInGame.AutoSize = True
        Me.WipeTransInGame.Location = New System.Drawing.Point(240, 542)
        Me.WipeTransInGame.Name = "WipeTransInGame"
        Me.WipeTransInGame.Size = New System.Drawing.Size(50, 17)
        Me.WipeTransInGame.TabIndex = 122
        Me.WipeTransInGame.Text = "Wipe"
        Me.WipeTransInGame.UseVisualStyleBackColor = True
        '
        'PushTransInGame
        '
        Me.PushTransInGame.AutoSize = True
        Me.PushTransInGame.Location = New System.Drawing.Point(128, 542)
        Me.PushTransInGame.Name = "PushTransInGame"
        Me.PushTransInGame.Size = New System.Drawing.Size(49, 17)
        Me.PushTransInGame.TabIndex = 123
        Me.PushTransInGame.Text = "Push"
        Me.PushTransInGame.UseVisualStyleBackColor = True
        '
        'MixTransInGame
        '
        Me.MixTransInGame.AutoSize = True
        Me.MixTransInGame.Checked = True
        Me.MixTransInGame.Location = New System.Drawing.Point(9, 542)
        Me.MixTransInGame.Name = "MixTransInGame"
        Me.MixTransInGame.Size = New System.Drawing.Size(41, 17)
        Me.MixTransInGame.TabIndex = 120
        Me.MixTransInGame.TabStop = True
        Me.MixTransInGame.Text = "Mix"
        Me.MixTransInGame.UseVisualStyleBackColor = True
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(6, 525)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(58, 13)
        Me.Label73.TabIndex = 121
        Me.Label73.Text = "Transitions"
        '
        'PLInGameMoveDown
        '
        Me.PLInGameMoveDown.Location = New System.Drawing.Point(176, 288)
        Me.PLInGameMoveDown.Name = "PLInGameMoveDown"
        Me.PLInGameMoveDown.Size = New System.Drawing.Size(166, 23)
        Me.PLInGameMoveDown.TabIndex = 119
        Me.PLInGameMoveDown.Text = "Move Down"
        Me.PLInGameMoveDown.UseVisualStyleBackColor = True
        '
        'PlayNextVidInGame
        '
        Me.PlayNextVidInGame.Location = New System.Drawing.Point(122, 496)
        Me.PlayNextVidInGame.Name = "PlayNextVidInGame"
        Me.PlayNextVidInGame.Size = New System.Drawing.Size(110, 23)
        Me.PlayNextVidInGame.TabIndex = 8
        Me.PlayNextVidInGame.Text = "Play Next"
        Me.PlayNextVidInGame.UseVisualStyleBackColor = True
        '
        'PLInGameMoveUp
        '
        Me.PLInGameMoveUp.Location = New System.Drawing.Point(7, 288)
        Me.PLInGameMoveUp.Name = "PLInGameMoveUp"
        Me.PLInGameMoveUp.Size = New System.Drawing.Size(163, 23)
        Me.PLInGameMoveUp.TabIndex = 118
        Me.PLInGameMoveUp.Text = "Move Up"
        Me.PLInGameMoveUp.UseVisualStyleBackColor = True
        '
        'stopVidInGame
        '
        Me.stopVidInGame.Location = New System.Drawing.Point(233, 496)
        Me.stopVidInGame.Name = "stopVidInGame"
        Me.stopVidInGame.Size = New System.Drawing.Size(109, 23)
        Me.stopVidInGame.TabIndex = 10
        Me.stopVidInGame.Text = "Stop"
        Me.stopVidInGame.UseVisualStyleBackColor = True
        '
        'PlayVidInGame
        '
        Me.PlayVidInGame.Location = New System.Drawing.Point(7, 496)
        Me.PlayVidInGame.Name = "PlayVidInGame"
        Me.PlayVidInGame.Size = New System.Drawing.Size(115, 23)
        Me.PlayVidInGame.TabIndex = 7
        Me.PlayVidInGame.Text = "Play"
        Me.PlayVidInGame.UseVisualStyleBackColor = True
        '
        'ClearPlaylistInGame
        '
        Me.ClearPlaylistInGame.Location = New System.Drawing.Point(6, 263)
        Me.ClearPlaylistInGame.Name = "ClearPlaylistInGame"
        Me.ClearPlaylistInGame.Size = New System.Drawing.Size(163, 23)
        Me.ClearPlaylistInGame.TabIndex = 4
        Me.ClearPlaylistInGame.Text = "Clear Playlist"
        Me.ClearPlaylistInGame.UseVisualStyleBackColor = True
        '
        'RemovePlaylistInGame
        '
        Me.RemovePlaylistInGame.Location = New System.Drawing.Point(175, 263)
        Me.RemovePlaylistInGame.Name = "RemovePlaylistInGame"
        Me.RemovePlaylistInGame.Size = New System.Drawing.Size(166, 23)
        Me.RemovePlaylistInGame.TabIndex = 5
        Me.RemovePlaylistInGame.Text = "Remove From Playlist"
        Me.RemovePlaylistInGame.UseVisualStyleBackColor = True
        '
        'AddPlaylistInGame
        '
        Me.AddPlaylistInGame.Location = New System.Drawing.Point(175, 237)
        Me.AddPlaylistInGame.Name = "AddPlaylistInGame"
        Me.AddPlaylistInGame.Size = New System.Drawing.Size(166, 23)
        Me.AddPlaylistInGame.TabIndex = 3
        Me.AddPlaylistInGame.Text = "Add to Playlist"
        Me.AddPlaylistInGame.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Files In Media Directory"
        '
        'refreshVideInGame
        '
        Me.refreshVideInGame.Location = New System.Drawing.Point(6, 236)
        Me.refreshVideInGame.Name = "refreshVideInGame"
        Me.refreshVideInGame.Size = New System.Drawing.Size(163, 23)
        Me.refreshVideInGame.TabIndex = 2
        Me.refreshVideInGame.Text = "Refresh Video List"
        Me.refreshVideInGame.UseVisualStyleBackColor = True
        '
        'playlistFilesInGame
        '
        Me.playlistFilesInGame.FormattingEnabled = True
        Me.playlistFilesInGame.Location = New System.Drawing.Point(7, 317)
        Me.playlistFilesInGame.Name = "playlistFilesInGame"
        Me.playlistFilesInGame.Size = New System.Drawing.Size(335, 173)
        Me.playlistFilesInGame.TabIndex = 6
        '
        'SourceFilesInGame
        '
        Me.SourceFilesInGame.FormattingEnabled = True
        Me.SourceFilesInGame.Location = New System.Drawing.Point(3, 58)
        Me.SourceFilesInGame.Name = "SourceFilesInGame"
        Me.SourceFilesInGame.Size = New System.Drawing.Size(338, 173)
        Me.SourceFilesInGame.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.FullScreenSubsCheck)
        Me.GroupBox5.Controls.Add(Me.LowerThirdSubsCheck)
        Me.GroupBox5.Controls.Add(Me.AwayTeamSubsLabel)
        Me.GroupBox5.Controls.Add(Me.HomeTeamSubsLablel)
        Me.GroupBox5.Controls.Add(Me.SubOn)
        Me.GroupBox5.Controls.Add(Me.AwaySubOff)
        Me.GroupBox5.Controls.Add(Me.SubOff)
        Me.GroupBox5.Controls.Add(Me.showSub)
        Me.GroupBox5.Controls.Add(Me.aw_subOn)
        Me.GroupBox5.Controls.Add(Me.AwaySubOn)
        Me.GroupBox5.Controls.Add(Me.SubOFFBtn)
        Me.GroupBox5.Controls.Add(Me.aw_subOff)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 357)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(369, 157)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Subs"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(194, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "OFF:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(198, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "ON:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(19, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "OFF:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(23, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "ON:"
        '
        'FullScreenSubsCheck
        '
        Me.FullScreenSubsCheck.AutoSize = True
        Me.FullScreenSubsCheck.Location = New System.Drawing.Point(104, 134)
        Me.FullScreenSubsCheck.Name = "FullScreenSubsCheck"
        Me.FullScreenSubsCheck.Size = New System.Drawing.Size(75, 17)
        Me.FullScreenSubsCheck.TabIndex = 18
        Me.FullScreenSubsCheck.Text = "FullScreen"
        Me.FullScreenSubsCheck.UseVisualStyleBackColor = True
        '
        'LowerThirdSubsCheck
        '
        Me.LowerThirdSubsCheck.AutoSize = True
        Me.LowerThirdSubsCheck.Checked = True
        Me.LowerThirdSubsCheck.Location = New System.Drawing.Point(17, 134)
        Me.LowerThirdSubsCheck.Name = "LowerThirdSubsCheck"
        Me.LowerThirdSubsCheck.Size = New System.Drawing.Size(81, 17)
        Me.LowerThirdSubsCheck.TabIndex = 17
        Me.LowerThirdSubsCheck.TabStop = True
        Me.LowerThirdSubsCheck.Text = "Lower Third"
        Me.LowerThirdSubsCheck.UseVisualStyleBackColor = True
        '
        'AwayTeamSubsLabel
        '
        Me.AwayTeamSubsLabel.AutoSize = True
        Me.AwayTeamSubsLabel.Location = New System.Drawing.Point(191, 26)
        Me.AwayTeamSubsLabel.Name = "AwayTeamSubsLabel"
        Me.AwayTeamSubsLabel.Size = New System.Drawing.Size(63, 13)
        Me.AwayTeamSubsLabel.TabIndex = 16
        Me.AwayTeamSubsLabel.Text = "Away Team"
        '
        'HomeTeamSubsLablel
        '
        Me.HomeTeamSubsLablel.AutoSize = True
        Me.HomeTeamSubsLablel.Location = New System.Drawing.Point(22, 26)
        Me.HomeTeamSubsLablel.Name = "HomeTeamSubsLablel"
        Me.HomeTeamSubsLablel.Size = New System.Drawing.Size(65, 13)
        Me.HomeTeamSubsLablel.TabIndex = 15
        Me.HomeTeamSubsLablel.Text = "Home Team"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LowerThirdTimePeriodTXT)
        Me.GroupBox4.Controls.Add(Me.ScoreMatchIDRadioBut)
        Me.GroupBox4.Controls.Add(Me.LTMatchIDRadioBut)
        Me.GroupBox4.Controls.Add(Me.LTStrapDate)
        Me.GroupBox4.Controls.Add(Me.LTStrapHideBTN)
        Me.GroupBox4.Controls.Add(Me.LTStrapKO)
        Me.GroupBox4.Controls.Add(Me.LTStrapTXBTN)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(369, 131)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lower Third Match ID"
        '
        'LowerThirdTimePeriodTXT
        '
        Me.LowerThirdTimePeriodTXT.FormattingEnabled = True
        Me.LowerThirdTimePeriodTXT.Items.AddRange(New Object() {"", "FIRST HALF", "HALF TIME", "SECOND HALF", "FULL TIME"})
        Me.LowerThirdTimePeriodTXT.Location = New System.Drawing.Point(229, 80)
        Me.LowerThirdTimePeriodTXT.Name = "LowerThirdTimePeriodTXT"
        Me.LowerThirdTimePeriodTXT.Size = New System.Drawing.Size(121, 21)
        Me.LowerThirdTimePeriodTXT.TabIndex = 119
        '
        'ScoreMatchIDRadioBut
        '
        Me.ScoreMatchIDRadioBut.AutoSize = True
        Me.ScoreMatchIDRadioBut.Location = New System.Drawing.Point(230, 42)
        Me.ScoreMatchIDRadioBut.Name = "ScoreMatchIDRadioBut"
        Me.ScoreMatchIDRadioBut.Size = New System.Drawing.Size(85, 17)
        Me.ScoreMatchIDRadioBut.TabIndex = 118
        Me.ScoreMatchIDRadioBut.Text = "Latest Score"
        Me.ScoreMatchIDRadioBut.UseVisualStyleBackColor = True
        '
        'LTMatchIDRadioBut
        '
        Me.LTMatchIDRadioBut.AutoSize = True
        Me.LTMatchIDRadioBut.Checked = True
        Me.LTMatchIDRadioBut.Location = New System.Drawing.Point(230, 20)
        Me.LTMatchIDRadioBut.Name = "LTMatchIDRadioBut"
        Me.LTMatchIDRadioBut.Size = New System.Drawing.Size(119, 17)
        Me.LTMatchIDRadioBut.TabIndex = 117
        Me.LTMatchIDRadioBut.TabStop = True
        Me.LTMatchIDRadioBut.Text = "Match ID (no score)"
        Me.LTMatchIDRadioBut.UseVisualStyleBackColor = True
        '
        'LTStrapDate
        '
        Me.LTStrapDate.Location = New System.Drawing.Point(6, 19)
        Me.LTStrapDate.Name = "LTStrapDate"
        Me.LTStrapDate.Size = New System.Drawing.Size(211, 20)
        Me.LTStrapDate.TabIndex = 20
        Me.LTStrapDate.Text = "Insert Date Here"
        '
        'LTStrapHideBTN
        '
        Me.LTStrapHideBTN.Location = New System.Drawing.Point(115, 80)
        Me.LTStrapHideBTN.Name = "LTStrapHideBTN"
        Me.LTStrapHideBTN.Size = New System.Drawing.Size(102, 26)
        Me.LTStrapHideBTN.TabIndex = 114
        Me.LTStrapHideBTN.Text = "Hide"
        Me.LTStrapHideBTN.UseVisualStyleBackColor = True
        '
        'LTStrapKO
        '
        Me.LTStrapKO.Location = New System.Drawing.Point(6, 45)
        Me.LTStrapKO.Name = "LTStrapKO"
        Me.LTStrapKO.Size = New System.Drawing.Size(211, 20)
        Me.LTStrapKO.TabIndex = 21
        Me.LTStrapKO.Text = "Insert KO Here"
        '
        'LTStrapTXBTN
        '
        Me.LTStrapTXBTN.Location = New System.Drawing.Point(6, 80)
        Me.LTStrapTXBTN.Name = "LTStrapTXBTN"
        Me.LTStrapTXBTN.Size = New System.Drawing.Size(102, 26)
        Me.LTStrapTXBTN.TabIndex = 113
        Me.LTStrapTXBTN.Text = "Show"
        Me.LTStrapTXBTN.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.AwayGoalWithoutScoreChange_BTN)
        Me.GroupBox8.Controls.Add(Me.HomeGoalWithoutScoreChange_BTN)
        Me.GroupBox8.Controls.Add(Me.Panel2)
        Me.GroupBox8.Controls.Add(Me.ListBox3)
        Me.GroupBox8.Controls.Add(Me.unknownGoalAway)
        Me.GroupBox8.Controls.Add(Me.unknownGoalHome)
        Me.GroupBox8.Controls.Add(Me.AwayHomeGoalBTN)
        Me.GroupBox8.Controls.Add(Me.HomeOwnGoalBTN)
        Me.GroupBox8.Controls.Add(Me.goalAway)
        Me.GroupBox8.Controls.Add(Me.Panel1)
        Me.GroupBox8.Controls.Add(Me.goalHome)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.ListBox4)
        Me.GroupBox8.Location = New System.Drawing.Point(416, 144)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(478, 479)
        Me.GroupBox8.TabIndex = 118
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Scoring"
        '
        'AwayGoalWithoutScoreChange_BTN
        '
        Me.AwayGoalWithoutScoreChange_BTN.Location = New System.Drawing.Point(254, 447)
        Me.AwayGoalWithoutScoreChange_BTN.Name = "AwayGoalWithoutScoreChange_BTN"
        Me.AwayGoalWithoutScoreChange_BTN.Size = New System.Drawing.Size(220, 23)
        Me.AwayGoalWithoutScoreChange_BTN.TabIndex = 122
        Me.AwayGoalWithoutScoreChange_BTN.Text = "GOAL - Without Score Change"
        Me.AwayGoalWithoutScoreChange_BTN.UseVisualStyleBackColor = True
        '
        'HomeGoalWithoutScoreChange_BTN
        '
        Me.HomeGoalWithoutScoreChange_BTN.Location = New System.Drawing.Point(14, 447)
        Me.HomeGoalWithoutScoreChange_BTN.Name = "HomeGoalWithoutScoreChange_BTN"
        Me.HomeGoalWithoutScoreChange_BTN.Size = New System.Drawing.Size(220, 23)
        Me.HomeGoalWithoutScoreChange_BTN.TabIndex = 121
        Me.HomeGoalWithoutScoreChange_BTN.Text = "GOAL - Without Score Change"
        Me.HomeGoalWithoutScoreChange_BTN.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Location = New System.Drawing.Point(0, 184)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(18, 170)
        Me.Panel2.TabIndex = 120
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(17, 38)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(220, 316)
        Me.ListBox3.TabIndex = 25
        '
        'unknownGoalAway
        '
        Me.unknownGoalAway.Location = New System.Drawing.Point(256, 389)
        Me.unknownGoalAway.Name = "unknownGoalAway"
        Me.unknownGoalAway.Size = New System.Drawing.Size(220, 23)
        Me.unknownGoalAway.TabIndex = 34
        Me.unknownGoalAway.Text = "GOAL - Unknown Scorer"
        Me.unknownGoalAway.UseVisualStyleBackColor = True
        '
        'unknownGoalHome
        '
        Me.unknownGoalHome.Location = New System.Drawing.Point(14, 389)
        Me.unknownGoalHome.Name = "unknownGoalHome"
        Me.unknownGoalHome.Size = New System.Drawing.Size(220, 23)
        Me.unknownGoalHome.TabIndex = 33
        Me.unknownGoalHome.Text = "GOAL - Unknown Scorer"
        Me.unknownGoalHome.UseVisualStyleBackColor = True
        '
        'AwayHomeGoalBTN
        '
        Me.AwayHomeGoalBTN.Location = New System.Drawing.Point(256, 418)
        Me.AwayHomeGoalBTN.Name = "AwayHomeGoalBTN"
        Me.AwayHomeGoalBTN.Size = New System.Drawing.Size(220, 23)
        Me.AwayHomeGoalBTN.TabIndex = 32
        Me.AwayHomeGoalBTN.Text = "OWN GOAL"
        Me.AwayHomeGoalBTN.UseVisualStyleBackColor = True
        '
        'HomeOwnGoalBTN
        '
        Me.HomeOwnGoalBTN.Location = New System.Drawing.Point(14, 418)
        Me.HomeOwnGoalBTN.Name = "HomeOwnGoalBTN"
        Me.HomeOwnGoalBTN.Size = New System.Drawing.Size(220, 23)
        Me.HomeOwnGoalBTN.TabIndex = 31
        Me.HomeOwnGoalBTN.Text = "OWN GOAL"
        Me.HomeOwnGoalBTN.UseVisualStyleBackColor = True
        '
        'goalAway
        '
        Me.goalAway.Location = New System.Drawing.Point(254, 360)
        Me.goalAway.Name = "goalAway"
        Me.goalAway.Size = New System.Drawing.Size(220, 23)
        Me.goalAway.TabIndex = 30
        Me.goalAway.Text = "GOAL - Known Scorer"
        Me.goalAway.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Location = New System.Drawing.Point(237, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(18, 170)
        Me.Panel1.TabIndex = 119
        '
        'goalHome
        '
        Me.goalHome.Location = New System.Drawing.Point(14, 360)
        Me.goalHome.Name = "goalHome"
        Me.goalHome.Size = New System.Drawing.Size(220, 23)
        Me.goalHome.TabIndex = 29
        Me.goalHome.Text = "GOAL - Known Scorer"
        Me.goalHome.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(243, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "AWAY TEAM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "HOME TEAM"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(254, 38)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(220, 316)
        Me.ListBox4.TabIndex = 26
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage9.Controls.Add(Me.GroupBox13)
        Me.TabPage9.Controls.Add(Me.GroupBox12)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage9.TabIndex = 6
        Me.TabPage9.Text = "Commercial"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.commsLoadBTN)
        Me.GroupBox13.Controls.Add(Me.commsSaveBTN)
        Me.GroupBox13.Controls.Add(Me.commsRadWIPE)
        Me.GroupBox13.Controls.Add(Me.commsRadPUSH)
        Me.GroupBox13.Controls.Add(Me.commsRadMIX)
        Me.GroupBox13.Controls.Add(Me.Label114)
        Me.GroupBox13.Controls.Add(Me.commsMoveDOWNBTN)
        Me.GroupBox13.Controls.Add(Me.commsNextBTN)
        Me.GroupBox13.Controls.Add(Me.commsMoveUpBTN)
        Me.GroupBox13.Controls.Add(Me.commsStopBTN)
        Me.GroupBox13.Controls.Add(Me.commsPlayBTN)
        Me.GroupBox13.Controls.Add(Me.commsClearBTN)
        Me.GroupBox13.Controls.Add(Me.commsRemoveBTN)
        Me.GroupBox13.Controls.Add(Me.commsAddBTN)
        Me.GroupBox13.Controls.Add(Me.Label115)
        Me.GroupBox13.Controls.Add(Me.commsRefreshBTN)
        Me.GroupBox13.Controls.Add(Me.commsPlayListLB)
        Me.GroupBox13.Controls.Add(Me.commsSourceFilesLB)
        Me.GroupBox13.Location = New System.Drawing.Point(453, 16)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(347, 605)
        Me.GroupBox13.TabIndex = 126
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Keyed Video Commerial Playout"
        '
        'commsLoadBTN
        '
        Me.commsLoadBTN.Location = New System.Drawing.Point(101, 574)
        Me.commsLoadBTN.Name = "commsLoadBTN"
        Me.commsLoadBTN.Size = New System.Drawing.Size(86, 23)
        Me.commsLoadBTN.TabIndex = 125
        Me.commsLoadBTN.Text = "Load"
        Me.commsLoadBTN.UseVisualStyleBackColor = True
        '
        'commsSaveBTN
        '
        Me.commsSaveBTN.Location = New System.Drawing.Point(9, 574)
        Me.commsSaveBTN.Name = "commsSaveBTN"
        Me.commsSaveBTN.Size = New System.Drawing.Size(86, 23)
        Me.commsSaveBTN.TabIndex = 124
        Me.commsSaveBTN.Text = "Save"
        Me.commsSaveBTN.UseVisualStyleBackColor = True
        '
        'commsRadWIPE
        '
        Me.commsRadWIPE.AutoSize = True
        Me.commsRadWIPE.Location = New System.Drawing.Point(240, 542)
        Me.commsRadWIPE.Name = "commsRadWIPE"
        Me.commsRadWIPE.Size = New System.Drawing.Size(50, 17)
        Me.commsRadWIPE.TabIndex = 122
        Me.commsRadWIPE.Text = "Wipe"
        Me.commsRadWIPE.UseVisualStyleBackColor = True
        '
        'commsRadPUSH
        '
        Me.commsRadPUSH.AutoSize = True
        Me.commsRadPUSH.Location = New System.Drawing.Point(128, 542)
        Me.commsRadPUSH.Name = "commsRadPUSH"
        Me.commsRadPUSH.Size = New System.Drawing.Size(49, 17)
        Me.commsRadPUSH.TabIndex = 123
        Me.commsRadPUSH.Text = "Push"
        Me.commsRadPUSH.UseVisualStyleBackColor = True
        '
        'commsRadMIX
        '
        Me.commsRadMIX.AutoSize = True
        Me.commsRadMIX.Checked = True
        Me.commsRadMIX.Location = New System.Drawing.Point(9, 542)
        Me.commsRadMIX.Name = "commsRadMIX"
        Me.commsRadMIX.Size = New System.Drawing.Size(41, 17)
        Me.commsRadMIX.TabIndex = 120
        Me.commsRadMIX.TabStop = True
        Me.commsRadMIX.Text = "Mix"
        Me.commsRadMIX.UseVisualStyleBackColor = True
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(6, 525)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(58, 13)
        Me.Label114.TabIndex = 121
        Me.Label114.Text = "Transitions"
        '
        'commsMoveDOWNBTN
        '
        Me.commsMoveDOWNBTN.Location = New System.Drawing.Point(176, 288)
        Me.commsMoveDOWNBTN.Name = "commsMoveDOWNBTN"
        Me.commsMoveDOWNBTN.Size = New System.Drawing.Size(166, 23)
        Me.commsMoveDOWNBTN.TabIndex = 119
        Me.commsMoveDOWNBTN.Text = "Move Down"
        Me.commsMoveDOWNBTN.UseVisualStyleBackColor = True
        '
        'commsNextBTN
        '
        Me.commsNextBTN.Location = New System.Drawing.Point(122, 496)
        Me.commsNextBTN.Name = "commsNextBTN"
        Me.commsNextBTN.Size = New System.Drawing.Size(110, 23)
        Me.commsNextBTN.TabIndex = 8
        Me.commsNextBTN.Text = "Play Next"
        Me.commsNextBTN.UseVisualStyleBackColor = True
        '
        'commsMoveUpBTN
        '
        Me.commsMoveUpBTN.Location = New System.Drawing.Point(7, 288)
        Me.commsMoveUpBTN.Name = "commsMoveUpBTN"
        Me.commsMoveUpBTN.Size = New System.Drawing.Size(163, 23)
        Me.commsMoveUpBTN.TabIndex = 118
        Me.commsMoveUpBTN.Text = "Move Up"
        Me.commsMoveUpBTN.UseVisualStyleBackColor = True
        '
        'commsStopBTN
        '
        Me.commsStopBTN.Location = New System.Drawing.Point(233, 496)
        Me.commsStopBTN.Name = "commsStopBTN"
        Me.commsStopBTN.Size = New System.Drawing.Size(109, 23)
        Me.commsStopBTN.TabIndex = 10
        Me.commsStopBTN.Text = "Stop"
        Me.commsStopBTN.UseVisualStyleBackColor = True
        '
        'commsPlayBTN
        '
        Me.commsPlayBTN.Location = New System.Drawing.Point(7, 496)
        Me.commsPlayBTN.Name = "commsPlayBTN"
        Me.commsPlayBTN.Size = New System.Drawing.Size(115, 23)
        Me.commsPlayBTN.TabIndex = 7
        Me.commsPlayBTN.Text = "Play"
        Me.commsPlayBTN.UseVisualStyleBackColor = True
        '
        'commsClearBTN
        '
        Me.commsClearBTN.Location = New System.Drawing.Point(6, 263)
        Me.commsClearBTN.Name = "commsClearBTN"
        Me.commsClearBTN.Size = New System.Drawing.Size(163, 23)
        Me.commsClearBTN.TabIndex = 4
        Me.commsClearBTN.Text = "Clear Playlist"
        Me.commsClearBTN.UseVisualStyleBackColor = True
        '
        'commsRemoveBTN
        '
        Me.commsRemoveBTN.Location = New System.Drawing.Point(175, 263)
        Me.commsRemoveBTN.Name = "commsRemoveBTN"
        Me.commsRemoveBTN.Size = New System.Drawing.Size(166, 23)
        Me.commsRemoveBTN.TabIndex = 5
        Me.commsRemoveBTN.Text = "Remove From Playlist"
        Me.commsRemoveBTN.UseVisualStyleBackColor = True
        '
        'commsAddBTN
        '
        Me.commsAddBTN.Location = New System.Drawing.Point(175, 237)
        Me.commsAddBTN.Name = "commsAddBTN"
        Me.commsAddBTN.Size = New System.Drawing.Size(166, 23)
        Me.commsAddBTN.TabIndex = 3
        Me.commsAddBTN.Text = "Add to Playlist"
        Me.commsAddBTN.UseVisualStyleBackColor = True
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(6, 42)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(117, 13)
        Me.Label115.TabIndex = 0
        Me.Label115.Text = "Files In Media Directory"
        '
        'commsRefreshBTN
        '
        Me.commsRefreshBTN.Location = New System.Drawing.Point(6, 236)
        Me.commsRefreshBTN.Name = "commsRefreshBTN"
        Me.commsRefreshBTN.Size = New System.Drawing.Size(163, 23)
        Me.commsRefreshBTN.TabIndex = 2
        Me.commsRefreshBTN.Text = "Refresh Video List"
        Me.commsRefreshBTN.UseVisualStyleBackColor = True
        '
        'commsPlayListLB
        '
        Me.commsPlayListLB.FormattingEnabled = True
        Me.commsPlayListLB.Location = New System.Drawing.Point(7, 317)
        Me.commsPlayListLB.Name = "commsPlayListLB"
        Me.commsPlayListLB.Size = New System.Drawing.Size(335, 173)
        Me.commsPlayListLB.TabIndex = 6
        '
        'commsSourceFilesLB
        '
        Me.commsSourceFilesLB.FormattingEnabled = True
        Me.commsSourceFilesLB.Location = New System.Drawing.Point(3, 58)
        Me.commsSourceFilesLB.Name = "commsSourceFilesLB"
        Me.commsSourceFilesLB.Size = New System.Drawing.Size(338, 173)
        Me.commsSourceFilesLB.TabIndex = 1
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label118)
        Me.GroupBox12.Controls.Add(Me.commsChooseBackingBTN)
        Me.GroupBox12.Controls.Add(Me.commsChooseBackingCOMBI)
        Me.GroupBox12.Controls.Add(Me.Label117)
        Me.GroupBox12.Controls.Add(Me.Label116)
        Me.GroupBox12.Controls.Add(Me.commericalRefreshImagesBTN)
        Me.GroupBox12.Controls.Add(Me.commercialCHooseImage)
        Me.GroupBox12.Controls.Add(Me.commercialRefreshTemplateListBTN)
        Me.GroupBox12.Controls.Add(Me.commercialChooseTemplate)
        Me.GroupBox12.Controls.Add(Me.Label110)
        Me.GroupBox12.Controls.Add(Me.Label111)
        Me.GroupBox12.Controls.Add(Me.Label112)
        Me.GroupBox12.Controls.Add(Me.Label113)
        Me.GroupBox12.Controls.Add(Me.commercialsRadio4)
        Me.GroupBox12.Controls.Add(Me.commercialsRadio3)
        Me.GroupBox12.Controls.Add(Me.commercialsRadio2)
        Me.GroupBox12.Controls.Add(Me.commercialsRadio1)
        Me.GroupBox12.Controls.Add(Me.commercialsCrawlText4)
        Me.GroupBox12.Controls.Add(Me.commercialsCrawlText3)
        Me.GroupBox12.Controls.Add(Me.commercialsCrawlText2)
        Me.GroupBox12.Controls.Add(Me.CommercialCrawlOffBTN)
        Me.GroupBox12.Controls.Add(Me.CommercialCrawlOnBTN)
        Me.GroupBox12.Controls.Add(Me.commercialsCrawlText1)
        Me.GroupBox12.Location = New System.Drawing.Point(50, 49)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(369, 329)
        Me.GroupBox12.TabIndex = 125
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Crawl"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(22, 185)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(115, 13)
        Me.Label118.TabIndex = 131
        Me.Label118.Text = "Choose Backing Video"
        '
        'commsChooseBackingBTN
        '
        Me.commsChooseBackingBTN.Location = New System.Drawing.Point(22, 201)
        Me.commsChooseBackingBTN.Name = "commsChooseBackingBTN"
        Me.commsChooseBackingBTN.Size = New System.Drawing.Size(75, 23)
        Me.commsChooseBackingBTN.TabIndex = 130
        Me.commsChooseBackingBTN.Text = "Refresh"
        Me.commsChooseBackingBTN.UseVisualStyleBackColor = True
        '
        'commsChooseBackingCOMBI
        '
        Me.commsChooseBackingCOMBI.FormattingEnabled = True
        Me.commsChooseBackingCOMBI.Location = New System.Drawing.Point(103, 203)
        Me.commsChooseBackingCOMBI.Name = "commsChooseBackingCOMBI"
        Me.commsChooseBackingCOMBI.Size = New System.Drawing.Size(249, 21)
        Me.commsChooseBackingCOMBI.TabIndex = 129
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(22, 228)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(104, 13)
        Me.Label117.TabIndex = 128
        Me.Label117.Text = "Choose Image/Crest"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(22, 140)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(90, 13)
        Me.Label116.TabIndex = 127
        Me.Label116.Text = "Choose Template"
        '
        'commericalRefreshImagesBTN
        '
        Me.commericalRefreshImagesBTN.Location = New System.Drawing.Point(22, 244)
        Me.commericalRefreshImagesBTN.Name = "commericalRefreshImagesBTN"
        Me.commericalRefreshImagesBTN.Size = New System.Drawing.Size(75, 23)
        Me.commericalRefreshImagesBTN.TabIndex = 126
        Me.commericalRefreshImagesBTN.Text = "Refresh"
        Me.commericalRefreshImagesBTN.UseVisualStyleBackColor = True
        '
        'commercialCHooseImage
        '
        Me.commercialCHooseImage.FormattingEnabled = True
        Me.commercialCHooseImage.Location = New System.Drawing.Point(103, 246)
        Me.commercialCHooseImage.Name = "commercialCHooseImage"
        Me.commercialCHooseImage.Size = New System.Drawing.Size(249, 21)
        Me.commercialCHooseImage.TabIndex = 125
        '
        'commercialRefreshTemplateListBTN
        '
        Me.commercialRefreshTemplateListBTN.Location = New System.Drawing.Point(22, 156)
        Me.commercialRefreshTemplateListBTN.Name = "commercialRefreshTemplateListBTN"
        Me.commercialRefreshTemplateListBTN.Size = New System.Drawing.Size(75, 23)
        Me.commercialRefreshTemplateListBTN.TabIndex = 124
        Me.commercialRefreshTemplateListBTN.Text = "Refresh"
        Me.commercialRefreshTemplateListBTN.UseVisualStyleBackColor = True
        '
        'commercialChooseTemplate
        '
        Me.commercialChooseTemplate.FormattingEnabled = True
        Me.commercialChooseTemplate.Location = New System.Drawing.Point(103, 158)
        Me.commercialChooseTemplate.Name = "commercialChooseTemplate"
        Me.commercialChooseTemplate.Size = New System.Drawing.Size(249, 21)
        Me.commercialChooseTemplate.TabIndex = 123
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(3, 100)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(13, 13)
        Me.Label110.TabIndex = 122
        Me.Label110.Text = "4"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(3, 74)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(13, 13)
        Me.Label111.TabIndex = 121
        Me.Label111.Text = "3"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(3, 48)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(13, 13)
        Me.Label112.TabIndex = 120
        Me.Label112.Text = "2"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(3, 22)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(13, 13)
        Me.Label113.TabIndex = 119
        Me.Label113.Text = "1"
        '
        'commercialsRadio4
        '
        Me.commercialsRadio4.AutoSize = True
        Me.commercialsRadio4.Location = New System.Drawing.Point(342, 100)
        Me.commercialsRadio4.Name = "commercialsRadio4"
        Me.commercialsRadio4.Size = New System.Drawing.Size(14, 13)
        Me.commercialsRadio4.TabIndex = 7
        Me.commercialsRadio4.UseVisualStyleBackColor = True
        '
        'commercialsRadio3
        '
        Me.commercialsRadio3.AutoSize = True
        Me.commercialsRadio3.Location = New System.Drawing.Point(342, 74)
        Me.commercialsRadio3.Name = "commercialsRadio3"
        Me.commercialsRadio3.Size = New System.Drawing.Size(14, 13)
        Me.commercialsRadio3.TabIndex = 5
        Me.commercialsRadio3.UseVisualStyleBackColor = True
        '
        'commercialsRadio2
        '
        Me.commercialsRadio2.AutoSize = True
        Me.commercialsRadio2.Location = New System.Drawing.Point(342, 48)
        Me.commercialsRadio2.Name = "commercialsRadio2"
        Me.commercialsRadio2.Size = New System.Drawing.Size(14, 13)
        Me.commercialsRadio2.TabIndex = 3
        Me.commercialsRadio2.UseVisualStyleBackColor = True
        '
        'commercialsRadio1
        '
        Me.commercialsRadio1.AutoSize = True
        Me.commercialsRadio1.Checked = True
        Me.commercialsRadio1.Location = New System.Drawing.Point(342, 22)
        Me.commercialsRadio1.Name = "commercialsRadio1"
        Me.commercialsRadio1.Size = New System.Drawing.Size(14, 13)
        Me.commercialsRadio1.TabIndex = 1
        Me.commercialsRadio1.TabStop = True
        Me.commercialsRadio1.UseVisualStyleBackColor = True
        '
        'commercialsCrawlText4
        '
        Me.commercialsCrawlText4.Location = New System.Drawing.Point(22, 97)
        Me.commercialsCrawlText4.Name = "commercialsCrawlText4"
        Me.commercialsCrawlText4.Size = New System.Drawing.Size(314, 20)
        Me.commercialsCrawlText4.TabIndex = 6
        Me.commercialsCrawlText4.Text = "Crawl Text Goes Here"
        '
        'commercialsCrawlText3
        '
        Me.commercialsCrawlText3.Location = New System.Drawing.Point(22, 71)
        Me.commercialsCrawlText3.Name = "commercialsCrawlText3"
        Me.commercialsCrawlText3.Size = New System.Drawing.Size(314, 20)
        Me.commercialsCrawlText3.TabIndex = 4
        Me.commercialsCrawlText3.Text = "Crawl Text Goes Here"
        '
        'commercialsCrawlText2
        '
        Me.commercialsCrawlText2.Location = New System.Drawing.Point(22, 45)
        Me.commercialsCrawlText2.Name = "commercialsCrawlText2"
        Me.commercialsCrawlText2.Size = New System.Drawing.Size(314, 20)
        Me.commercialsCrawlText2.TabIndex = 2
        Me.commercialsCrawlText2.Text = "Crawl Text Goes Here"
        '
        'CommercialCrawlOffBTN
        '
        Me.CommercialCrawlOffBTN.Location = New System.Drawing.Point(182, 284)
        Me.CommercialCrawlOffBTN.Name = "CommercialCrawlOffBTN"
        Me.CommercialCrawlOffBTN.Size = New System.Drawing.Size(174, 23)
        Me.CommercialCrawlOffBTN.TabIndex = 10
        Me.CommercialCrawlOffBTN.Text = "Crawl Off"
        Me.CommercialCrawlOffBTN.UseVisualStyleBackColor = True
        '
        'CommercialCrawlOnBTN
        '
        Me.CommercialCrawlOnBTN.Location = New System.Drawing.Point(6, 285)
        Me.CommercialCrawlOnBTN.Name = "CommercialCrawlOnBTN"
        Me.CommercialCrawlOnBTN.Size = New System.Drawing.Size(170, 23)
        Me.CommercialCrawlOnBTN.TabIndex = 8
        Me.CommercialCrawlOnBTN.Text = "Crawl On"
        Me.CommercialCrawlOnBTN.UseVisualStyleBackColor = True
        '
        'commercialsCrawlText1
        '
        Me.commercialsCrawlText1.Location = New System.Drawing.Point(22, 19)
        Me.commercialsCrawlText1.Name = "commercialsCrawlText1"
        Me.commercialsCrawlText1.Size = New System.Drawing.Size(314, 20)
        Me.commercialsCrawlText1.TabIndex = 0
        Me.commercialsCrawlText1.Text = "Crawl Text Goes Here"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage7.Controls.Add(Me.Msg8ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg7ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg6ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg5ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg4ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg3ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg2ColPickBTN)
        Me.TabPage7.Controls.Add(Me.Msg1ColPickBTN)
        Me.TabPage7.Controls.Add(Me.msg8OffBtn)
        Me.TabPage7.Controls.Add(Me.msg8OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx8)
        Me.TabPage7.Controls.Add(Me.Label48)
        Me.TabPage7.Controls.Add(Me.backgrounds8)
        Me.TabPage7.Controls.Add(Me.msg8Line4)
        Me.TabPage7.Controls.Add(Me.msg8Line3)
        Me.TabPage7.Controls.Add(Me.msg8Line2)
        Me.TabPage7.Controls.Add(Me.msg8Line1)
        Me.TabPage7.Controls.Add(Me.msg8Title)
        Me.TabPage7.Controls.Add(Me.Label49)
        Me.TabPage7.Controls.Add(Me.Label50)
        Me.TabPage7.Controls.Add(Me.Label51)
        Me.TabPage7.Controls.Add(Me.Label52)
        Me.TabPage7.Controls.Add(Me.Label53)
        Me.TabPage7.Controls.Add(Me.msg7OffBtn)
        Me.TabPage7.Controls.Add(Me.msg7OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx7)
        Me.TabPage7.Controls.Add(Me.Label54)
        Me.TabPage7.Controls.Add(Me.backgrounds7)
        Me.TabPage7.Controls.Add(Me.msg7Line4)
        Me.TabPage7.Controls.Add(Me.msg7Line3)
        Me.TabPage7.Controls.Add(Me.msg7Line2)
        Me.TabPage7.Controls.Add(Me.msg7Line1)
        Me.TabPage7.Controls.Add(Me.msg7Title)
        Me.TabPage7.Controls.Add(Me.Label55)
        Me.TabPage7.Controls.Add(Me.Label56)
        Me.TabPage7.Controls.Add(Me.Label57)
        Me.TabPage7.Controls.Add(Me.Label58)
        Me.TabPage7.Controls.Add(Me.Label59)
        Me.TabPage7.Controls.Add(Me.msg6OffBtn)
        Me.TabPage7.Controls.Add(Me.msg6OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx6)
        Me.TabPage7.Controls.Add(Me.Label60)
        Me.TabPage7.Controls.Add(Me.backgrounds6)
        Me.TabPage7.Controls.Add(Me.msg6Line4)
        Me.TabPage7.Controls.Add(Me.msg6Line3)
        Me.TabPage7.Controls.Add(Me.msg6Line2)
        Me.TabPage7.Controls.Add(Me.msg6Line1)
        Me.TabPage7.Controls.Add(Me.msg6Title)
        Me.TabPage7.Controls.Add(Me.Label61)
        Me.TabPage7.Controls.Add(Me.Label62)
        Me.TabPage7.Controls.Add(Me.Label63)
        Me.TabPage7.Controls.Add(Me.Label64)
        Me.TabPage7.Controls.Add(Me.Label65)
        Me.TabPage7.Controls.Add(Me.msg5OffBtn)
        Me.TabPage7.Controls.Add(Me.msg5OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx5)
        Me.TabPage7.Controls.Add(Me.Label66)
        Me.TabPage7.Controls.Add(Me.backgrounds5)
        Me.TabPage7.Controls.Add(Me.msg5Line4)
        Me.TabPage7.Controls.Add(Me.msg5Line3)
        Me.TabPage7.Controls.Add(Me.msg5Line2)
        Me.TabPage7.Controls.Add(Me.msg5Line1)
        Me.TabPage7.Controls.Add(Me.msg5Title)
        Me.TabPage7.Controls.Add(Me.Label67)
        Me.TabPage7.Controls.Add(Me.Label68)
        Me.TabPage7.Controls.Add(Me.Label69)
        Me.TabPage7.Controls.Add(Me.Label70)
        Me.TabPage7.Controls.Add(Me.Label71)
        Me.TabPage7.Controls.Add(Me.msg4OffBtn)
        Me.TabPage7.Controls.Add(Me.msg4OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx4)
        Me.TabPage7.Controls.Add(Me.Label42)
        Me.TabPage7.Controls.Add(Me.backgrounds4)
        Me.TabPage7.Controls.Add(Me.msg4Line4)
        Me.TabPage7.Controls.Add(Me.msg4Line3)
        Me.TabPage7.Controls.Add(Me.msg4Line2)
        Me.TabPage7.Controls.Add(Me.msg4Line1)
        Me.TabPage7.Controls.Add(Me.msg4Title)
        Me.TabPage7.Controls.Add(Me.Label43)
        Me.TabPage7.Controls.Add(Me.Label44)
        Me.TabPage7.Controls.Add(Me.Label45)
        Me.TabPage7.Controls.Add(Me.Label46)
        Me.TabPage7.Controls.Add(Me.Label47)
        Me.TabPage7.Controls.Add(Me.msg3OffBtn)
        Me.TabPage7.Controls.Add(Me.msg3OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx3)
        Me.TabPage7.Controls.Add(Me.Label36)
        Me.TabPage7.Controls.Add(Me.backgrounds3)
        Me.TabPage7.Controls.Add(Me.msg3Line4)
        Me.TabPage7.Controls.Add(Me.msg3Line3)
        Me.TabPage7.Controls.Add(Me.msg3Line2)
        Me.TabPage7.Controls.Add(Me.msg3Line1)
        Me.TabPage7.Controls.Add(Me.msg3Title)
        Me.TabPage7.Controls.Add(Me.Label37)
        Me.TabPage7.Controls.Add(Me.Label38)
        Me.TabPage7.Controls.Add(Me.Label39)
        Me.TabPage7.Controls.Add(Me.Label40)
        Me.TabPage7.Controls.Add(Me.Label41)
        Me.TabPage7.Controls.Add(Me.msg2OffBtn)
        Me.TabPage7.Controls.Add(Me.msg2OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx2)
        Me.TabPage7.Controls.Add(Me.Label30)
        Me.TabPage7.Controls.Add(Me.backgrounds2)
        Me.TabPage7.Controls.Add(Me.msg2Line4)
        Me.TabPage7.Controls.Add(Me.msg2Line3)
        Me.TabPage7.Controls.Add(Me.msg2Line2)
        Me.TabPage7.Controls.Add(Me.msg2Line1)
        Me.TabPage7.Controls.Add(Me.msg2Title)
        Me.TabPage7.Controls.Add(Me.Label31)
        Me.TabPage7.Controls.Add(Me.Label32)
        Me.TabPage7.Controls.Add(Me.Label33)
        Me.TabPage7.Controls.Add(Me.Label34)
        Me.TabPage7.Controls.Add(Me.Label35)
        Me.TabPage7.Controls.Add(Me.msg1OffBtn)
        Me.TabPage7.Controls.Add(Me.msg1OnBtn)
        Me.TabPage7.Controls.Add(Me.ReloadBackgroundsComboBx)
        Me.TabPage7.Controls.Add(Me.Label29)
        Me.TabPage7.Controls.Add(Me.backgrounds1)
        Me.TabPage7.Controls.Add(Me.msg1Line4)
        Me.TabPage7.Controls.Add(Me.msg1Line3)
        Me.TabPage7.Controls.Add(Me.msg1Line2)
        Me.TabPage7.Controls.Add(Me.msg1Line1)
        Me.TabPage7.Controls.Add(Me.msg1Title)
        Me.TabPage7.Controls.Add(Me.Label28)
        Me.TabPage7.Controls.Add(Me.Label27)
        Me.TabPage7.Controls.Add(Me.Label26)
        Me.TabPage7.Controls.Add(Me.Label25)
        Me.TabPage7.Controls.Add(Me.Label24)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Generic Messages"
        '
        'Msg8ColPickBTN
        '
        Me.Msg8ColPickBTN.Location = New System.Drawing.Point(1131, 293)
        Me.Msg8ColPickBTN.Name = "Msg8ColPickBTN"
        Me.Msg8ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg8ColPickBTN.TabIndex = 127
        Me.Msg8ColPickBTN.Text = "Colour"
        Me.Msg8ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg7ColPickBTN
        '
        Me.Msg7ColPickBTN.Location = New System.Drawing.Point(835, 291)
        Me.Msg7ColPickBTN.Name = "Msg7ColPickBTN"
        Me.Msg7ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg7ColPickBTN.TabIndex = 126
        Me.Msg7ColPickBTN.Text = "Colour"
        Me.Msg7ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg6ColPickBTN
        '
        Me.Msg6ColPickBTN.Location = New System.Drawing.Point(536, 293)
        Me.Msg6ColPickBTN.Name = "Msg6ColPickBTN"
        Me.Msg6ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg6ColPickBTN.TabIndex = 125
        Me.Msg6ColPickBTN.Text = "Colour"
        Me.Msg6ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg5ColPickBTN
        '
        Me.Msg5ColPickBTN.Location = New System.Drawing.Point(245, 291)
        Me.Msg5ColPickBTN.Name = "Msg5ColPickBTN"
        Me.Msg5ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg5ColPickBTN.TabIndex = 124
        Me.Msg5ColPickBTN.Text = "Colour"
        Me.Msg5ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg4ColPickBTN
        '
        Me.Msg4ColPickBTN.Location = New System.Drawing.Point(1131, 44)
        Me.Msg4ColPickBTN.Name = "Msg4ColPickBTN"
        Me.Msg4ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg4ColPickBTN.TabIndex = 123
        Me.Msg4ColPickBTN.Text = "Colour"
        Me.Msg4ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg3ColPickBTN
        '
        Me.Msg3ColPickBTN.Location = New System.Drawing.Point(835, 42)
        Me.Msg3ColPickBTN.Name = "Msg3ColPickBTN"
        Me.Msg3ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg3ColPickBTN.TabIndex = 122
        Me.Msg3ColPickBTN.Text = "Colour"
        Me.Msg3ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg2ColPickBTN
        '
        Me.Msg2ColPickBTN.Location = New System.Drawing.Point(536, 44)
        Me.Msg2ColPickBTN.Name = "Msg2ColPickBTN"
        Me.Msg2ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg2ColPickBTN.TabIndex = 121
        Me.Msg2ColPickBTN.Text = "Colour"
        Me.Msg2ColPickBTN.UseVisualStyleBackColor = True
        '
        'Msg1ColPickBTN
        '
        Me.Msg1ColPickBTN.Location = New System.Drawing.Point(245, 42)
        Me.Msg1ColPickBTN.Name = "Msg1ColPickBTN"
        Me.Msg1ColPickBTN.Size = New System.Drawing.Size(75, 23)
        Me.Msg1ColPickBTN.TabIndex = 120
        Me.Msg1ColPickBTN.Text = "Colour"
        Me.Msg1ColPickBTN.UseVisualStyleBackColor = True
        '
        'msg8OffBtn
        '
        Me.msg8OffBtn.Location = New System.Drawing.Point(1073, 472)
        Me.msg8OffBtn.Name = "msg8OffBtn"
        Me.msg8OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg8OffBtn.TabIndex = 119
        Me.msg8OffBtn.Text = "Message Off"
        Me.msg8OffBtn.UseVisualStyleBackColor = True
        '
        'msg8OnBtn
        '
        Me.msg8OnBtn.Location = New System.Drawing.Point(936, 472)
        Me.msg8OnBtn.Name = "msg8OnBtn"
        Me.msg8OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg8OnBtn.TabIndex = 118
        Me.msg8OnBtn.Text = "Message On"
        Me.msg8OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx8
        '
        Me.ReloadBackgroundsComboBx8.Location = New System.Drawing.Point(1134, 429)
        Me.ReloadBackgroundsComboBx8.Name = "ReloadBackgroundsComboBx8"
        Me.ReloadBackgroundsComboBx8.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx8.TabIndex = 117
        Me.ReloadBackgroundsComboBx8.Text = "Reload"
        Me.ReloadBackgroundsComboBx8.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(933, 434)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 13)
        Me.Label48.TabIndex = 116
        Me.Label48.Text = "Background:"
        '
        'backgrounds8
        '
        Me.backgrounds8.FormattingEnabled = True
        Me.backgrounds8.Location = New System.Drawing.Point(1007, 431)
        Me.backgrounds8.Name = "backgrounds8"
        Me.backgrounds8.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds8.TabIndex = 115
        '
        'msg8Line4
        '
        Me.msg8Line4.Location = New System.Drawing.Point(1007, 405)
        Me.msg8Line4.Name = "msg8Line4"
        Me.msg8Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg8Line4.TabIndex = 114
        '
        'msg8Line3
        '
        Me.msg8Line3.Location = New System.Drawing.Point(1007, 379)
        Me.msg8Line3.Name = "msg8Line3"
        Me.msg8Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg8Line3.TabIndex = 113
        '
        'msg8Line2
        '
        Me.msg8Line2.Location = New System.Drawing.Point(1007, 353)
        Me.msg8Line2.Name = "msg8Line2"
        Me.msg8Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg8Line2.TabIndex = 112
        '
        'msg8Line1
        '
        Me.msg8Line1.Location = New System.Drawing.Point(1007, 327)
        Me.msg8Line1.Name = "msg8Line1"
        Me.msg8Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg8Line1.TabIndex = 111
        '
        'msg8Title
        '
        Me.msg8Title.Location = New System.Drawing.Point(1007, 293)
        Me.msg8Title.Name = "msg8Title"
        Me.msg8Title.Size = New System.Drawing.Size(121, 20)
        Me.msg8Title.TabIndex = 110
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(962, 408)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(39, 13)
        Me.Label49.TabIndex = 109
        Me.Label49.Text = "Line 4:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(962, 382)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(39, 13)
        Me.Label50.TabIndex = 108
        Me.Label50.Text = "Line 3:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(962, 356)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(39, 13)
        Me.Label51.TabIndex = 107
        Me.Label51.Text = "Line 2:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(962, 330)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(39, 13)
        Me.Label52.TabIndex = 106
        Me.Label52.Text = "Line 1:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(971, 296)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(30, 13)
        Me.Label53.TabIndex = 105
        Me.Label53.Text = "Title:"
        '
        'msg7OffBtn
        '
        Me.msg7OffBtn.Location = New System.Drawing.Point(777, 472)
        Me.msg7OffBtn.Name = "msg7OffBtn"
        Me.msg7OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg7OffBtn.TabIndex = 104
        Me.msg7OffBtn.Text = "Message Off"
        Me.msg7OffBtn.UseVisualStyleBackColor = True
        '
        'msg7OnBtn
        '
        Me.msg7OnBtn.Location = New System.Drawing.Point(640, 472)
        Me.msg7OnBtn.Name = "msg7OnBtn"
        Me.msg7OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg7OnBtn.TabIndex = 103
        Me.msg7OnBtn.Text = "Message On"
        Me.msg7OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx7
        '
        Me.ReloadBackgroundsComboBx7.Location = New System.Drawing.Point(838, 429)
        Me.ReloadBackgroundsComboBx7.Name = "ReloadBackgroundsComboBx7"
        Me.ReloadBackgroundsComboBx7.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx7.TabIndex = 102
        Me.ReloadBackgroundsComboBx7.Text = "Reload"
        Me.ReloadBackgroundsComboBx7.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(637, 434)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(68, 13)
        Me.Label54.TabIndex = 101
        Me.Label54.Text = "Background:"
        '
        'backgrounds7
        '
        Me.backgrounds7.FormattingEnabled = True
        Me.backgrounds7.Location = New System.Drawing.Point(711, 431)
        Me.backgrounds7.Name = "backgrounds7"
        Me.backgrounds7.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds7.TabIndex = 100
        '
        'msg7Line4
        '
        Me.msg7Line4.Location = New System.Drawing.Point(711, 405)
        Me.msg7Line4.Name = "msg7Line4"
        Me.msg7Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg7Line4.TabIndex = 99
        '
        'msg7Line3
        '
        Me.msg7Line3.Location = New System.Drawing.Point(711, 379)
        Me.msg7Line3.Name = "msg7Line3"
        Me.msg7Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg7Line3.TabIndex = 98
        '
        'msg7Line2
        '
        Me.msg7Line2.Location = New System.Drawing.Point(711, 353)
        Me.msg7Line2.Name = "msg7Line2"
        Me.msg7Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg7Line2.TabIndex = 97
        '
        'msg7Line1
        '
        Me.msg7Line1.Location = New System.Drawing.Point(711, 327)
        Me.msg7Line1.Name = "msg7Line1"
        Me.msg7Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg7Line1.TabIndex = 96
        '
        'msg7Title
        '
        Me.msg7Title.Location = New System.Drawing.Point(711, 293)
        Me.msg7Title.Name = "msg7Title"
        Me.msg7Title.Size = New System.Drawing.Size(121, 20)
        Me.msg7Title.TabIndex = 95
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(666, 408)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(39, 13)
        Me.Label55.TabIndex = 94
        Me.Label55.Text = "Line 4:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(666, 382)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(39, 13)
        Me.Label56.TabIndex = 93
        Me.Label56.Text = "Line 3:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(666, 356)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(39, 13)
        Me.Label57.TabIndex = 92
        Me.Label57.Text = "Line 2:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(666, 330)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(39, 13)
        Me.Label58.TabIndex = 91
        Me.Label58.Text = "Line 1:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(675, 296)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(30, 13)
        Me.Label59.TabIndex = 90
        Me.Label59.Text = "Title:"
        '
        'msg6OffBtn
        '
        Me.msg6OffBtn.Location = New System.Drawing.Point(478, 472)
        Me.msg6OffBtn.Name = "msg6OffBtn"
        Me.msg6OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg6OffBtn.TabIndex = 89
        Me.msg6OffBtn.Text = "Message Off"
        Me.msg6OffBtn.UseVisualStyleBackColor = True
        '
        'msg6OnBtn
        '
        Me.msg6OnBtn.Location = New System.Drawing.Point(341, 472)
        Me.msg6OnBtn.Name = "msg6OnBtn"
        Me.msg6OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg6OnBtn.TabIndex = 88
        Me.msg6OnBtn.Text = "Message On"
        Me.msg6OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx6
        '
        Me.ReloadBackgroundsComboBx6.Location = New System.Drawing.Point(539, 429)
        Me.ReloadBackgroundsComboBx6.Name = "ReloadBackgroundsComboBx6"
        Me.ReloadBackgroundsComboBx6.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx6.TabIndex = 87
        Me.ReloadBackgroundsComboBx6.Text = "Reload"
        Me.ReloadBackgroundsComboBx6.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(338, 434)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(68, 13)
        Me.Label60.TabIndex = 86
        Me.Label60.Text = "Background:"
        '
        'backgrounds6
        '
        Me.backgrounds6.FormattingEnabled = True
        Me.backgrounds6.Location = New System.Drawing.Point(412, 431)
        Me.backgrounds6.Name = "backgrounds6"
        Me.backgrounds6.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds6.TabIndex = 85
        '
        'msg6Line4
        '
        Me.msg6Line4.Location = New System.Drawing.Point(412, 405)
        Me.msg6Line4.Name = "msg6Line4"
        Me.msg6Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg6Line4.TabIndex = 84
        '
        'msg6Line3
        '
        Me.msg6Line3.Location = New System.Drawing.Point(412, 379)
        Me.msg6Line3.Name = "msg6Line3"
        Me.msg6Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg6Line3.TabIndex = 83
        '
        'msg6Line2
        '
        Me.msg6Line2.Location = New System.Drawing.Point(412, 353)
        Me.msg6Line2.Name = "msg6Line2"
        Me.msg6Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg6Line2.TabIndex = 82
        '
        'msg6Line1
        '
        Me.msg6Line1.Location = New System.Drawing.Point(412, 327)
        Me.msg6Line1.Name = "msg6Line1"
        Me.msg6Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg6Line1.TabIndex = 81
        '
        'msg6Title
        '
        Me.msg6Title.Location = New System.Drawing.Point(412, 293)
        Me.msg6Title.Name = "msg6Title"
        Me.msg6Title.Size = New System.Drawing.Size(121, 20)
        Me.msg6Title.TabIndex = 80
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(367, 408)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(39, 13)
        Me.Label61.TabIndex = 79
        Me.Label61.Text = "Line 4:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(367, 382)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(39, 13)
        Me.Label62.TabIndex = 78
        Me.Label62.Text = "Line 3:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(367, 356)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(39, 13)
        Me.Label63.TabIndex = 77
        Me.Label63.Text = "Line 2:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(367, 330)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(39, 13)
        Me.Label64.TabIndex = 76
        Me.Label64.Text = "Line 1:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(376, 296)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(30, 13)
        Me.Label65.TabIndex = 75
        Me.Label65.Text = "Title:"
        '
        'msg5OffBtn
        '
        Me.msg5OffBtn.Location = New System.Drawing.Point(187, 472)
        Me.msg5OffBtn.Name = "msg5OffBtn"
        Me.msg5OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg5OffBtn.TabIndex = 74
        Me.msg5OffBtn.Text = "Message Off"
        Me.msg5OffBtn.UseVisualStyleBackColor = True
        '
        'msg5OnBtn
        '
        Me.msg5OnBtn.Location = New System.Drawing.Point(50, 472)
        Me.msg5OnBtn.Name = "msg5OnBtn"
        Me.msg5OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg5OnBtn.TabIndex = 73
        Me.msg5OnBtn.Text = "Message On"
        Me.msg5OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx5
        '
        Me.ReloadBackgroundsComboBx5.Location = New System.Drawing.Point(248, 429)
        Me.ReloadBackgroundsComboBx5.Name = "ReloadBackgroundsComboBx5"
        Me.ReloadBackgroundsComboBx5.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx5.TabIndex = 72
        Me.ReloadBackgroundsComboBx5.Text = "Reload"
        Me.ReloadBackgroundsComboBx5.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(47, 434)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(68, 13)
        Me.Label66.TabIndex = 71
        Me.Label66.Text = "Background:"
        '
        'backgrounds5
        '
        Me.backgrounds5.FormattingEnabled = True
        Me.backgrounds5.Location = New System.Drawing.Point(121, 431)
        Me.backgrounds5.Name = "backgrounds5"
        Me.backgrounds5.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds5.TabIndex = 70
        '
        'msg5Line4
        '
        Me.msg5Line4.Location = New System.Drawing.Point(121, 405)
        Me.msg5Line4.Name = "msg5Line4"
        Me.msg5Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg5Line4.TabIndex = 69
        '
        'msg5Line3
        '
        Me.msg5Line3.Location = New System.Drawing.Point(121, 379)
        Me.msg5Line3.Name = "msg5Line3"
        Me.msg5Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg5Line3.TabIndex = 68
        '
        'msg5Line2
        '
        Me.msg5Line2.Location = New System.Drawing.Point(121, 353)
        Me.msg5Line2.Name = "msg5Line2"
        Me.msg5Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg5Line2.TabIndex = 67
        '
        'msg5Line1
        '
        Me.msg5Line1.Location = New System.Drawing.Point(121, 327)
        Me.msg5Line1.Name = "msg5Line1"
        Me.msg5Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg5Line1.TabIndex = 66
        '
        'msg5Title
        '
        Me.msg5Title.Location = New System.Drawing.Point(121, 293)
        Me.msg5Title.Name = "msg5Title"
        Me.msg5Title.Size = New System.Drawing.Size(121, 20)
        Me.msg5Title.TabIndex = 65
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(76, 408)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(39, 13)
        Me.Label67.TabIndex = 64
        Me.Label67.Text = "Line 4:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(76, 382)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(39, 13)
        Me.Label68.TabIndex = 63
        Me.Label68.Text = "Line 3:"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(76, 356)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(39, 13)
        Me.Label69.TabIndex = 62
        Me.Label69.Text = "Line 2:"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(76, 330)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(39, 13)
        Me.Label70.TabIndex = 61
        Me.Label70.Text = "Line 1:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(85, 296)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(30, 13)
        Me.Label71.TabIndex = 60
        Me.Label71.Text = "Title:"
        '
        'msg4OffBtn
        '
        Me.msg4OffBtn.Location = New System.Drawing.Point(1073, 223)
        Me.msg4OffBtn.Name = "msg4OffBtn"
        Me.msg4OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg4OffBtn.TabIndex = 59
        Me.msg4OffBtn.Text = "Message Off"
        Me.msg4OffBtn.UseVisualStyleBackColor = True
        '
        'msg4OnBtn
        '
        Me.msg4OnBtn.Location = New System.Drawing.Point(936, 223)
        Me.msg4OnBtn.Name = "msg4OnBtn"
        Me.msg4OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg4OnBtn.TabIndex = 58
        Me.msg4OnBtn.Text = "Message On"
        Me.msg4OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx4
        '
        Me.ReloadBackgroundsComboBx4.Location = New System.Drawing.Point(1134, 180)
        Me.ReloadBackgroundsComboBx4.Name = "ReloadBackgroundsComboBx4"
        Me.ReloadBackgroundsComboBx4.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx4.TabIndex = 57
        Me.ReloadBackgroundsComboBx4.Text = "Reload"
        Me.ReloadBackgroundsComboBx4.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(933, 185)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 13)
        Me.Label42.TabIndex = 56
        Me.Label42.Text = "Background:"
        '
        'backgrounds4
        '
        Me.backgrounds4.FormattingEnabled = True
        Me.backgrounds4.Location = New System.Drawing.Point(1007, 182)
        Me.backgrounds4.Name = "backgrounds4"
        Me.backgrounds4.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds4.TabIndex = 55
        '
        'msg4Line4
        '
        Me.msg4Line4.Location = New System.Drawing.Point(1007, 156)
        Me.msg4Line4.Name = "msg4Line4"
        Me.msg4Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg4Line4.TabIndex = 54
        '
        'msg4Line3
        '
        Me.msg4Line3.Location = New System.Drawing.Point(1007, 130)
        Me.msg4Line3.Name = "msg4Line3"
        Me.msg4Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg4Line3.TabIndex = 53
        '
        'msg4Line2
        '
        Me.msg4Line2.Location = New System.Drawing.Point(1007, 104)
        Me.msg4Line2.Name = "msg4Line2"
        Me.msg4Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg4Line2.TabIndex = 52
        '
        'msg4Line1
        '
        Me.msg4Line1.Location = New System.Drawing.Point(1007, 78)
        Me.msg4Line1.Name = "msg4Line1"
        Me.msg4Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg4Line1.TabIndex = 51
        '
        'msg4Title
        '
        Me.msg4Title.Location = New System.Drawing.Point(1007, 44)
        Me.msg4Title.Name = "msg4Title"
        Me.msg4Title.Size = New System.Drawing.Size(121, 20)
        Me.msg4Title.TabIndex = 50
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(962, 159)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(39, 13)
        Me.Label43.TabIndex = 49
        Me.Label43.Text = "Line 4:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(962, 133)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(39, 13)
        Me.Label44.TabIndex = 48
        Me.Label44.Text = "Line 3:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(962, 107)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(39, 13)
        Me.Label45.TabIndex = 47
        Me.Label45.Text = "Line 2:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(962, 81)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(39, 13)
        Me.Label46.TabIndex = 46
        Me.Label46.Text = "Line 1:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(971, 47)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(30, 13)
        Me.Label47.TabIndex = 45
        Me.Label47.Text = "Title:"
        '
        'msg3OffBtn
        '
        Me.msg3OffBtn.Location = New System.Drawing.Point(777, 223)
        Me.msg3OffBtn.Name = "msg3OffBtn"
        Me.msg3OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg3OffBtn.TabIndex = 44
        Me.msg3OffBtn.Text = "Message Off"
        Me.msg3OffBtn.UseVisualStyleBackColor = True
        '
        'msg3OnBtn
        '
        Me.msg3OnBtn.Location = New System.Drawing.Point(640, 223)
        Me.msg3OnBtn.Name = "msg3OnBtn"
        Me.msg3OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg3OnBtn.TabIndex = 43
        Me.msg3OnBtn.Text = "Message On"
        Me.msg3OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx3
        '
        Me.ReloadBackgroundsComboBx3.Location = New System.Drawing.Point(838, 180)
        Me.ReloadBackgroundsComboBx3.Name = "ReloadBackgroundsComboBx3"
        Me.ReloadBackgroundsComboBx3.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx3.TabIndex = 42
        Me.ReloadBackgroundsComboBx3.Text = "Reload"
        Me.ReloadBackgroundsComboBx3.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(637, 185)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(68, 13)
        Me.Label36.TabIndex = 41
        Me.Label36.Text = "Background:"
        '
        'backgrounds3
        '
        Me.backgrounds3.FormattingEnabled = True
        Me.backgrounds3.Location = New System.Drawing.Point(711, 182)
        Me.backgrounds3.Name = "backgrounds3"
        Me.backgrounds3.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds3.TabIndex = 40
        '
        'msg3Line4
        '
        Me.msg3Line4.Location = New System.Drawing.Point(711, 156)
        Me.msg3Line4.Name = "msg3Line4"
        Me.msg3Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg3Line4.TabIndex = 39
        '
        'msg3Line3
        '
        Me.msg3Line3.Location = New System.Drawing.Point(711, 130)
        Me.msg3Line3.Name = "msg3Line3"
        Me.msg3Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg3Line3.TabIndex = 38
        '
        'msg3Line2
        '
        Me.msg3Line2.Location = New System.Drawing.Point(711, 104)
        Me.msg3Line2.Name = "msg3Line2"
        Me.msg3Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg3Line2.TabIndex = 37
        '
        'msg3Line1
        '
        Me.msg3Line1.Location = New System.Drawing.Point(711, 78)
        Me.msg3Line1.Name = "msg3Line1"
        Me.msg3Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg3Line1.TabIndex = 36
        '
        'msg3Title
        '
        Me.msg3Title.Location = New System.Drawing.Point(711, 44)
        Me.msg3Title.Name = "msg3Title"
        Me.msg3Title.Size = New System.Drawing.Size(121, 20)
        Me.msg3Title.TabIndex = 35
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(666, 159)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 13)
        Me.Label37.TabIndex = 34
        Me.Label37.Text = "Line 4:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(666, 133)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(39, 13)
        Me.Label38.TabIndex = 33
        Me.Label38.Text = "Line 3:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(666, 107)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(39, 13)
        Me.Label39.TabIndex = 32
        Me.Label39.Text = "Line 2:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(666, 81)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(39, 13)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Line 1:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(675, 47)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(30, 13)
        Me.Label41.TabIndex = 30
        Me.Label41.Text = "Title:"
        '
        'msg2OffBtn
        '
        Me.msg2OffBtn.Location = New System.Drawing.Point(478, 223)
        Me.msg2OffBtn.Name = "msg2OffBtn"
        Me.msg2OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg2OffBtn.TabIndex = 29
        Me.msg2OffBtn.Text = "Message Off"
        Me.msg2OffBtn.UseVisualStyleBackColor = True
        '
        'msg2OnBtn
        '
        Me.msg2OnBtn.Location = New System.Drawing.Point(341, 223)
        Me.msg2OnBtn.Name = "msg2OnBtn"
        Me.msg2OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg2OnBtn.TabIndex = 28
        Me.msg2OnBtn.Text = "Message On"
        Me.msg2OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx2
        '
        Me.ReloadBackgroundsComboBx2.Location = New System.Drawing.Point(539, 180)
        Me.ReloadBackgroundsComboBx2.Name = "ReloadBackgroundsComboBx2"
        Me.ReloadBackgroundsComboBx2.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx2.TabIndex = 27
        Me.ReloadBackgroundsComboBx2.Text = "Reload"
        Me.ReloadBackgroundsComboBx2.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(338, 185)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "Background:"
        '
        'backgrounds2
        '
        Me.backgrounds2.FormattingEnabled = True
        Me.backgrounds2.Location = New System.Drawing.Point(412, 182)
        Me.backgrounds2.Name = "backgrounds2"
        Me.backgrounds2.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds2.TabIndex = 25
        '
        'msg2Line4
        '
        Me.msg2Line4.Location = New System.Drawing.Point(412, 156)
        Me.msg2Line4.Name = "msg2Line4"
        Me.msg2Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg2Line4.TabIndex = 24
        '
        'msg2Line3
        '
        Me.msg2Line3.Location = New System.Drawing.Point(412, 130)
        Me.msg2Line3.Name = "msg2Line3"
        Me.msg2Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg2Line3.TabIndex = 23
        '
        'msg2Line2
        '
        Me.msg2Line2.Location = New System.Drawing.Point(412, 104)
        Me.msg2Line2.Name = "msg2Line2"
        Me.msg2Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg2Line2.TabIndex = 22
        '
        'msg2Line1
        '
        Me.msg2Line1.Location = New System.Drawing.Point(412, 78)
        Me.msg2Line1.Name = "msg2Line1"
        Me.msg2Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg2Line1.TabIndex = 21
        '
        'msg2Title
        '
        Me.msg2Title.Location = New System.Drawing.Point(412, 44)
        Me.msg2Title.Name = "msg2Title"
        Me.msg2Title.Size = New System.Drawing.Size(121, 20)
        Me.msg2Title.TabIndex = 20
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(367, 159)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 13)
        Me.Label31.TabIndex = 19
        Me.Label31.Text = "Line 4:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(367, 133)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 13)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Line 3:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(367, 107)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 13)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Line 2:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(367, 81)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(39, 13)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "Line 1:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(376, 47)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 13)
        Me.Label35.TabIndex = 15
        Me.Label35.Text = "Title:"
        '
        'msg1OffBtn
        '
        Me.msg1OffBtn.Location = New System.Drawing.Point(187, 223)
        Me.msg1OffBtn.Name = "msg1OffBtn"
        Me.msg1OffBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg1OffBtn.TabIndex = 14
        Me.msg1OffBtn.Text = "Message Off"
        Me.msg1OffBtn.UseVisualStyleBackColor = True
        '
        'msg1OnBtn
        '
        Me.msg1OnBtn.Location = New System.Drawing.Point(50, 223)
        Me.msg1OnBtn.Name = "msg1OnBtn"
        Me.msg1OnBtn.Size = New System.Drawing.Size(133, 23)
        Me.msg1OnBtn.TabIndex = 13
        Me.msg1OnBtn.Text = "Message On"
        Me.msg1OnBtn.UseVisualStyleBackColor = True
        '
        'ReloadBackgroundsComboBx
        '
        Me.ReloadBackgroundsComboBx.Location = New System.Drawing.Point(248, 180)
        Me.ReloadBackgroundsComboBx.Name = "ReloadBackgroundsComboBx"
        Me.ReloadBackgroundsComboBx.Size = New System.Drawing.Size(72, 23)
        Me.ReloadBackgroundsComboBx.TabIndex = 12
        Me.ReloadBackgroundsComboBx.Text = "Reload"
        Me.ReloadBackgroundsComboBx.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(47, 185)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 13)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Background:"
        '
        'backgrounds1
        '
        Me.backgrounds1.FormattingEnabled = True
        Me.backgrounds1.Location = New System.Drawing.Point(121, 182)
        Me.backgrounds1.Name = "backgrounds1"
        Me.backgrounds1.Size = New System.Drawing.Size(121, 21)
        Me.backgrounds1.TabIndex = 10
        '
        'msg1Line4
        '
        Me.msg1Line4.Location = New System.Drawing.Point(121, 156)
        Me.msg1Line4.Name = "msg1Line4"
        Me.msg1Line4.Size = New System.Drawing.Size(199, 20)
        Me.msg1Line4.TabIndex = 9
        '
        'msg1Line3
        '
        Me.msg1Line3.Location = New System.Drawing.Point(121, 130)
        Me.msg1Line3.Name = "msg1Line3"
        Me.msg1Line3.Size = New System.Drawing.Size(199, 20)
        Me.msg1Line3.TabIndex = 8
        '
        'msg1Line2
        '
        Me.msg1Line2.Location = New System.Drawing.Point(121, 104)
        Me.msg1Line2.Name = "msg1Line2"
        Me.msg1Line2.Size = New System.Drawing.Size(199, 20)
        Me.msg1Line2.TabIndex = 7
        '
        'msg1Line1
        '
        Me.msg1Line1.Location = New System.Drawing.Point(121, 78)
        Me.msg1Line1.Name = "msg1Line1"
        Me.msg1Line1.Size = New System.Drawing.Size(199, 20)
        Me.msg1Line1.TabIndex = 6
        '
        'msg1Title
        '
        Me.msg1Title.Location = New System.Drawing.Point(121, 44)
        Me.msg1Title.Name = "msg1Title"
        Me.msg1Title.Size = New System.Drawing.Size(121, 20)
        Me.msg1Title.TabIndex = 5
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(76, 159)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Line 4:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(76, 133)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Line 3:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(76, 107)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Line 2:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(76, 81)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Line 1:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(85, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Title:"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage8.Controls.Add(Me.Label102)
        Me.TabPage8.Controls.Add(Me.webPageOff2BTN)
        Me.TabPage8.Controls.Add(Me.webPageOn2BTN)
        Me.TabPage8.Controls.Add(Me.urlText2TXT)
        Me.TabPage8.Controls.Add(Me.Label103)
        Me.TabPage8.Controls.Add(Me.Label101)
        Me.TabPage8.Controls.Add(Me.webPageOff1BTN)
        Me.TabPage8.Controls.Add(Me.webPageOn1BTN)
        Me.TabPage8.Controls.Add(Me.urlText1TXT)
        Me.TabPage8.Controls.Add(Me.Label100)
        Me.TabPage8.Controls.Add(Me.Label95)
        Me.TabPage8.Controls.Add(Me.Label96)
        Me.TabPage8.Controls.Add(Me.Label97)
        Me.TabPage8.Controls.Add(Me.Label98)
        Me.TabPage8.Controls.Add(Me.Label99)
        Me.TabPage8.Controls.Add(Me.miscTempOffBTN2)
        Me.TabPage8.Controls.Add(Me.miscTempOnBTN2)
        Me.TabPage8.Controls.Add(Me.miscTempText3TXT2)
        Me.TabPage8.Controls.Add(Me.miscTempText2TXT2)
        Me.TabPage8.Controls.Add(Me.miscTempText1TXT2)
        Me.TabPage8.Controls.Add(Me.miscTempName2TXT)
        Me.TabPage8.Controls.Add(Me.Label94)
        Me.TabPage8.Controls.Add(Me.Label93)
        Me.TabPage8.Controls.Add(Me.Label92)
        Me.TabPage8.Controls.Add(Me.Label91)
        Me.TabPage8.Controls.Add(Me.Label90)
        Me.TabPage8.Controls.Add(Me.miscTempOffBTN)
        Me.TabPage8.Controls.Add(Me.miscTempOnBTN)
        Me.TabPage8.Controls.Add(Me.miscTempText3TXT)
        Me.TabPage8.Controls.Add(Me.miscTempText2TXT)
        Me.TabPage8.Controls.Add(Me.miscTempText1TXT)
        Me.TabPage8.Controls.Add(Me.miscTempNameTXT)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1252, 636)
        Me.TabPage8.TabIndex = 5
        Me.TabPage8.Text = "Misc"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(598, 374)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(29, 13)
        Me.Label102.TabIndex = 31
        Me.Label102.Text = "URL"
        '
        'webPageOff2BTN
        '
        Me.webPageOff2BTN.Location = New System.Drawing.Point(811, 404)
        Me.webPageOff2BTN.Name = "webPageOff2BTN"
        Me.webPageOff2BTN.Size = New System.Drawing.Size(160, 23)
        Me.webPageOff2BTN.TabIndex = 30
        Me.webPageOff2BTN.Text = "HIDE"
        Me.webPageOff2BTN.UseVisualStyleBackColor = True
        '
        'webPageOn2BTN
        '
        Me.webPageOn2BTN.Location = New System.Drawing.Point(633, 404)
        Me.webPageOn2BTN.Name = "webPageOn2BTN"
        Me.webPageOn2BTN.Size = New System.Drawing.Size(156, 23)
        Me.webPageOn2BTN.TabIndex = 29
        Me.webPageOn2BTN.Text = "SHOW"
        Me.webPageOn2BTN.UseVisualStyleBackColor = True
        '
        'urlText2TXT
        '
        Me.urlText2TXT.Location = New System.Drawing.Point(633, 371)
        Me.urlText2TXT.Name = "urlText2TXT"
        Me.urlText2TXT.Size = New System.Drawing.Size(338, 20)
        Me.urlText2TXT.TabIndex = 28
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(630, 335)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(170, 16)
        Me.Label103.TabIndex = 27
        Me.Label103.Text = "Show Misc Web Page 2"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(598, 112)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(29, 13)
        Me.Label101.TabIndex = 26
        Me.Label101.Text = "URL"
        '
        'webPageOff1BTN
        '
        Me.webPageOff1BTN.Location = New System.Drawing.Point(811, 142)
        Me.webPageOff1BTN.Name = "webPageOff1BTN"
        Me.webPageOff1BTN.Size = New System.Drawing.Size(160, 23)
        Me.webPageOff1BTN.TabIndex = 25
        Me.webPageOff1BTN.Text = "HIDE"
        Me.webPageOff1BTN.UseVisualStyleBackColor = True
        '
        'webPageOn1BTN
        '
        Me.webPageOn1BTN.Location = New System.Drawing.Point(633, 142)
        Me.webPageOn1BTN.Name = "webPageOn1BTN"
        Me.webPageOn1BTN.Size = New System.Drawing.Size(156, 23)
        Me.webPageOn1BTN.TabIndex = 24
        Me.webPageOn1BTN.Text = "SHOW"
        Me.webPageOn1BTN.UseVisualStyleBackColor = True
        '
        'urlText1TXT
        '
        Me.urlText1TXT.Location = New System.Drawing.Point(633, 109)
        Me.urlText1TXT.Name = "urlText1TXT"
        Me.urlText1TXT.Size = New System.Drawing.Size(338, 20)
        Me.urlText1TXT.TabIndex = 23
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(630, 73)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(170, 16)
        Me.Label100.TabIndex = 22
        Me.Label100.Text = "Show Misc Web Page 1"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(133, 335)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(163, 16)
        Me.Label95.TabIndex = 21
        Me.Label95.Text = "Show Misc Template 2"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(94, 456)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(36, 13)
        Me.Label96.TabIndex = 20
        Me.Label96.Text = "Line 3"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(94, 430)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(36, 13)
        Me.Label97.TabIndex = 19
        Me.Label97.Text = "Line 2"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(94, 404)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(36, 13)
        Me.Label98.TabIndex = 18
        Me.Label98.Text = "Line 1"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(79, 378)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(51, 13)
        Me.Label99.TabIndex = 17
        Me.Label99.Text = "Template"
        '
        'miscTempOffBTN2
        '
        Me.miscTempOffBTN2.Location = New System.Drawing.Point(314, 488)
        Me.miscTempOffBTN2.Name = "miscTempOffBTN2"
        Me.miscTempOffBTN2.Size = New System.Drawing.Size(160, 23)
        Me.miscTempOffBTN2.TabIndex = 16
        Me.miscTempOffBTN2.Text = "HIDE"
        Me.miscTempOffBTN2.UseVisualStyleBackColor = True
        '
        'miscTempOnBTN2
        '
        Me.miscTempOnBTN2.Location = New System.Drawing.Point(136, 488)
        Me.miscTempOnBTN2.Name = "miscTempOnBTN2"
        Me.miscTempOnBTN2.Size = New System.Drawing.Size(156, 23)
        Me.miscTempOnBTN2.TabIndex = 15
        Me.miscTempOnBTN2.Text = "SHOW"
        Me.miscTempOnBTN2.UseVisualStyleBackColor = True
        '
        'miscTempText3TXT2
        '
        Me.miscTempText3TXT2.Location = New System.Drawing.Point(136, 453)
        Me.miscTempText3TXT2.Name = "miscTempText3TXT2"
        Me.miscTempText3TXT2.Size = New System.Drawing.Size(338, 20)
        Me.miscTempText3TXT2.TabIndex = 14
        '
        'miscTempText2TXT2
        '
        Me.miscTempText2TXT2.Location = New System.Drawing.Point(136, 427)
        Me.miscTempText2TXT2.Name = "miscTempText2TXT2"
        Me.miscTempText2TXT2.Size = New System.Drawing.Size(338, 20)
        Me.miscTempText2TXT2.TabIndex = 13
        '
        'miscTempText1TXT2
        '
        Me.miscTempText1TXT2.Location = New System.Drawing.Point(136, 401)
        Me.miscTempText1TXT2.Name = "miscTempText1TXT2"
        Me.miscTempText1TXT2.Size = New System.Drawing.Size(338, 20)
        Me.miscTempText1TXT2.TabIndex = 12
        '
        'miscTempName2TXT
        '
        Me.miscTempName2TXT.Location = New System.Drawing.Point(136, 375)
        Me.miscTempName2TXT.Name = "miscTempName2TXT"
        Me.miscTempName2TXT.Size = New System.Drawing.Size(338, 20)
        Me.miscTempName2TXT.TabIndex = 11
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(133, 73)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(163, 16)
        Me.Label94.TabIndex = 10
        Me.Label94.Text = "Show Misc Template 1"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(94, 194)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(36, 13)
        Me.Label93.TabIndex = 9
        Me.Label93.Text = "Line 3"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(94, 168)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(36, 13)
        Me.Label92.TabIndex = 8
        Me.Label92.Text = "Line 2"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(94, 142)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(36, 13)
        Me.Label91.TabIndex = 7
        Me.Label91.Text = "Line 1"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(79, 116)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(51, 13)
        Me.Label90.TabIndex = 6
        Me.Label90.Text = "Template"
        '
        'miscTempOffBTN
        '
        Me.miscTempOffBTN.Location = New System.Drawing.Point(314, 226)
        Me.miscTempOffBTN.Name = "miscTempOffBTN"
        Me.miscTempOffBTN.Size = New System.Drawing.Size(160, 23)
        Me.miscTempOffBTN.TabIndex = 5
        Me.miscTempOffBTN.Text = "HIDE"
        Me.miscTempOffBTN.UseVisualStyleBackColor = True
        '
        'miscTempOnBTN
        '
        Me.miscTempOnBTN.Location = New System.Drawing.Point(136, 226)
        Me.miscTempOnBTN.Name = "miscTempOnBTN"
        Me.miscTempOnBTN.Size = New System.Drawing.Size(156, 23)
        Me.miscTempOnBTN.TabIndex = 4
        Me.miscTempOnBTN.Text = "SHOW"
        Me.miscTempOnBTN.UseVisualStyleBackColor = True
        '
        'miscTempText3TXT
        '
        Me.miscTempText3TXT.Location = New System.Drawing.Point(136, 191)
        Me.miscTempText3TXT.Name = "miscTempText3TXT"
        Me.miscTempText3TXT.Size = New System.Drawing.Size(338, 20)
        Me.miscTempText3TXT.TabIndex = 3
        '
        'miscTempText2TXT
        '
        Me.miscTempText2TXT.Location = New System.Drawing.Point(136, 165)
        Me.miscTempText2TXT.Name = "miscTempText2TXT"
        Me.miscTempText2TXT.Size = New System.Drawing.Size(338, 20)
        Me.miscTempText2TXT.TabIndex = 2
        '
        'miscTempText1TXT
        '
        Me.miscTempText1TXT.Location = New System.Drawing.Point(136, 139)
        Me.miscTempText1TXT.Name = "miscTempText1TXT"
        Me.miscTempText1TXT.Size = New System.Drawing.Size(338, 20)
        Me.miscTempText1TXT.TabIndex = 1
        '
        'miscTempNameTXT
        '
        Me.miscTempNameTXT.Location = New System.Drawing.Point(136, 113)
        Me.miscTempNameTXT.Name = "miscTempNameTXT"
        Me.miscTempNameTXT.Size = New System.Drawing.Size(338, 20)
        Me.miscTempNameTXT.TabIndex = 0
        '
        'AwayScore
        '
        Me.AwayScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwayScore.Location = New System.Drawing.Point(688, 14)
        Me.AwayScore.Name = "AwayScore"
        Me.AwayScore.Size = New System.Drawing.Size(31, 45)
        Me.AwayScore.TabIndex = 7
        Me.AwayScore.Text = "0"
        Me.AwayScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'awayThreeLetters
        '
        Me.awayThreeLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awayThreeLetters.Location = New System.Drawing.Point(725, 13)
        Me.awayThreeLetters.Name = "awayThreeLetters"
        Me.awayThreeLetters.Size = New System.Drawing.Size(147, 29)
        Me.awayThreeLetters.TabIndex = 13
        Me.awayThreeLetters.Text = "AWAY ABBREV"
        '
        'HomeScore
        '
        Me.HomeScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeScore.Location = New System.Drawing.Point(649, 14)
        Me.HomeScore.Name = "HomeScore"
        Me.HomeScore.Size = New System.Drawing.Size(33, 45)
        Me.HomeScore.TabIndex = 6
        Me.HomeScore.Text = "0"
        Me.HomeScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'homeThreeLetters
        '
        Me.homeThreeLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeThreeLetters.Location = New System.Drawing.Point(497, 14)
        Me.homeThreeLetters.Name = "homeThreeLetters"
        Me.homeThreeLetters.Size = New System.Drawing.Size(146, 29)
        Me.homeThreeLetters.TabIndex = 12
        Me.homeThreeLetters.Text = "HOME ABBREV"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ClearTXBTN
        '
        Me.ClearTXBTN.Location = New System.Drawing.Point(248, 39)
        Me.ClearTXBTN.Name = "ClearTXBTN"
        Me.ClearTXBTN.Size = New System.Drawing.Size(128, 23)
        Me.ClearTXBTN.TabIndex = 67
        Me.ClearTXBTN.Text = "CLEAR ALL"
        Me.ClearTXBTN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.Location = New System.Drawing.Point(556, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 31)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label4.Location = New System.Drawing.Point(491, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 31)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Game Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(718, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 31)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Time of Day"
        '
        'timeOfDayText
        '
        Me.timeOfDayText.AutoSize = True
        Me.timeOfDayText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeOfDayText.ForeColor = System.Drawing.Color.RoyalBlue
        Me.timeOfDayText.Location = New System.Drawing.Point(732, 46)
        Me.timeOfDayText.Name = "timeOfDayText"
        Me.timeOfDayText.Size = New System.Drawing.Size(128, 31)
        Me.timeOfDayText.TabIndex = 71
        Me.timeOfDayText.Text = "00:00:00"
        '
        'TimeOfDayCLock
        '
        Me.TimeOfDayCLock.Enabled = True
        '
        'BPlayChanFadeOut
        '
        '
        'scoresFadeOut
        '
        '
        'ClearGFXOnlyBTN
        '
        Me.ClearGFXOnlyBTN.Location = New System.Drawing.Point(114, 39)
        Me.ClearGFXOnlyBTN.Name = "ClearGFXOnlyBTN"
        Me.ClearGFXOnlyBTN.Size = New System.Drawing.Size(128, 23)
        Me.ClearGFXOnlyBTN.TabIndex = 72
        Me.ClearGFXOnlyBTN.Text = "Clear GFX Only"
        Me.ClearGFXOnlyBTN.UseVisualStyleBackColor = True
        '
        'playlistStop
        '
        '
        'updateScore
        '
        Me.updateScore.Location = New System.Drawing.Point(649, 65)
        Me.updateScore.Name = "updateScore"
        Me.updateScore.Size = New System.Drawing.Size(75, 23)
        Me.updateScore.TabIndex = 9
        Me.updateScore.Text = "UPDATE"
        Me.updateScore.UseVisualStyleBackColor = True
        '
        'saveBTN
        '
        Me.saveBTN.Location = New System.Drawing.Point(882, 32)
        Me.saveBTN.Name = "saveBTN"
        Me.saveBTN.Size = New System.Drawing.Size(128, 23)
        Me.saveBTN.TabIndex = 74
        Me.saveBTN.Text = "Save"
        Me.saveBTN.UseVisualStyleBackColor = True
        '
        'loadBTN
        '
        Me.loadBTN.Location = New System.Drawing.Point(882, 56)
        Me.loadBTN.Name = "loadBTN"
        Me.loadBTN.Size = New System.Drawing.Size(128, 23)
        Me.loadBTN.TabIndex = 75
        Me.loadBTN.Text = "Load"
        Me.loadBTN.UseVisualStyleBackColor = True
        '
        'commsPlaylistStop
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Caspar_Test_2___No_PVW.My.Resources.Resources.lilLVDude
        Me.PictureBox1.Location = New System.Drawing.Point(1016, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'ADIFootball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1276, 769)
        Me.Controls.Add(Me.loadBTN)
        Me.Controls.Add(Me.saveBTN)
        Me.Controls.Add(Me.updateScore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearGFXOnlyBTN)
        Me.Controls.Add(Me.timeOfDayText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClearTXBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.backgroundOn)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.awayThreeLetters)
        Me.Controls.Add(Me.AwayScore)
        Me.Controls.Add(Me.HomeScore)
        Me.Controls.Add(Me.homeThreeLetters)
        Me.Controls.Add(Me.min)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ADIFootball"
        Me.Text = "liveGFX v1"
        Me.Clock.ResumeLayout(False)
        Me.Clock.PerformLayout()
        Me.Crawl.ResumeLayout(False)
        Me.Crawl.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Connect As System.Windows.Forms.Button
    Friend WithEvents countTimer As System.Windows.Forms.Timer
    Friend WithEvents OnScreenClock As System.Windows.Forms.Timer
    Friend WithEvents Clock As System.Windows.Forms.GroupBox
    Friend WithEvents startClockTime As System.Windows.Forms.TextBox
    Friend WithEvents sec As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.Label
    Friend WithEvents showClock As System.Windows.Forms.Button
    Friend WithEvents StopClock As System.Windows.Forms.Button
    Friend WithEvents clockAnimation As System.Windows.Forms.Timer
    Friend WithEvents Crawl As System.Windows.Forms.GroupBox
    Friend WithEvents CrawlOff As System.Windows.Forms.Button
    Friend WithEvents CrawlOn As System.Windows.Forms.Button
    Friend WithEvents CrawlText1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents SubOn As System.Windows.Forms.ComboBox
    Friend WithEvents SubOff As System.Windows.Forms.ComboBox
    Friend WithEvents aw_subOff As System.Windows.Forms.ComboBox
    Friend WithEvents aw_subOn As System.Windows.Forms.ComboBox
    Friend WithEvents LoadTeams As System.Windows.Forms.Button
    Friend WithEvents showSub As System.Windows.Forms.Button
    Friend WithEvents SubOFFBtn As System.Windows.Forms.Button
    Friend WithEvents ShowTeamSheet As System.Windows.Forms.Button
    Friend WithEvents ShowSubsSheet As System.Windows.Forms.Button
    Friend WithEvents Ts_Off As System.Windows.Forms.Button
    Friend WithEvents backgroundOn As System.Windows.Forms.CheckBox
    Friend WithEvents HidePremScores As System.Windows.Forms.Button
    Friend WithEvents showPremScores As System.Windows.Forms.Button
    Friend WithEvents Score23 As System.Windows.Forms.TextBox
    Friend WithEvents Score24 As System.Windows.Forms.TextBox
    Friend WithEvents Score22 As System.Windows.Forms.TextBox
    Friend WithEvents Score21 As System.Windows.Forms.TextBox
    Friend WithEvents Score19 As System.Windows.Forms.TextBox
    Friend WithEvents Score20 As System.Windows.Forms.TextBox
    Friend WithEvents Score18 As System.Windows.Forms.TextBox
    Friend WithEvents Score17 As System.Windows.Forms.TextBox
    Friend WithEvents Score15 As System.Windows.Forms.TextBox
    Friend WithEvents Score16 As System.Windows.Forms.TextBox
    Friend WithEvents Score14 As System.Windows.Forms.TextBox
    Friend WithEvents Score13 As System.Windows.Forms.TextBox
    Friend WithEvents Score11 As System.Windows.Forms.TextBox
    Friend WithEvents Score12 As System.Windows.Forms.TextBox
    Friend WithEvents Score10 As System.Windows.Forms.TextBox
    Friend WithEvents Score9 As System.Windows.Forms.TextBox
    Friend WithEvents Score7 As System.Windows.Forms.TextBox
    Friend WithEvents Score8 As System.Windows.Forms.TextBox
    Friend WithEvents Score6 As System.Windows.Forms.TextBox
    Friend WithEvents Score5 As System.Windows.Forms.TextBox
    Friend WithEvents Score3 As System.Windows.Forms.TextBox
    Friend WithEvents Score4 As System.Windows.Forms.TextBox
    Friend WithEvents Score2 As System.Windows.Forms.TextBox
    Friend WithEvents Score1 As System.Windows.Forms.TextBox
    Friend WithEvents AwayTeamsOff As System.Windows.Forms.Button
    Friend WithEvents ShowAwaySubsSheet As System.Windows.Forms.Button
    Friend WithEvents ShowAwayFirstEleven As System.Windows.Forms.Button
    Friend WithEvents AwaySubOff As System.Windows.Forms.Button
    Friend WithEvents AwaySubOn As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents playNext As System.Windows.Forms.Button
    Friend WithEvents stopVid As System.Windows.Forms.Button
    Friend WithEvents playVid As System.Windows.Forms.Button
    Friend WithEvents ClearPlaylist As System.Windows.Forms.Button
    Friend WithEvents RemovePlaylist As System.Windows.Forms.Button
    Friend WithEvents AddPlaylist As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rereshVids As System.Windows.Forms.Button
    Friend WithEvents playlistFiles As System.Windows.Forms.ListBox
    Friend WithEvents SourceFiles As System.Windows.Forms.ListBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CrawlText4 As System.Windows.Forms.TextBox
    Friend WithEvents CrawlText3 As System.Windows.Forms.TextBox
    Friend WithEvents CrawlText2 As System.Windows.Forms.TextBox
    Friend WithEvents UpdateTextButton As System.Windows.Forms.Button
    Friend WithEvents StartTimeLabel As System.Windows.Forms.Label
    Friend WithEvents AwayScore As System.Windows.Forms.TextBox
    Friend WithEvents awayThreeLetters As System.Windows.Forms.TextBox
    Friend WithEvents HomeScore As System.Windows.Forms.TextBox
    Friend WithEvents homeThreeLetters As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents hideBigScore As System.Windows.Forms.Button
    Friend WithEvents showBigScore As System.Windows.Forms.Button
    Friend WithEvents HidePremScoresBTN As System.Windows.Forms.Button
    Friend WithEvents TXPremScores_2BTN As System.Windows.Forms.Button
    Friend WithEvents Score47 As System.Windows.Forms.TextBox
    Friend WithEvents Score48 As System.Windows.Forms.TextBox
    Friend WithEvents Score46 As System.Windows.Forms.TextBox
    Friend WithEvents Score45 As System.Windows.Forms.TextBox
    Friend WithEvents Score43 As System.Windows.Forms.TextBox
    Friend WithEvents Score44 As System.Windows.Forms.TextBox
    Friend WithEvents Score42 As System.Windows.Forms.TextBox
    Friend WithEvents Score41 As System.Windows.Forms.TextBox
    Friend WithEvents Score39 As System.Windows.Forms.TextBox
    Friend WithEvents Score40 As System.Windows.Forms.TextBox
    Friend WithEvents Score38 As System.Windows.Forms.TextBox
    Friend WithEvents Score37 As System.Windows.Forms.TextBox
    Friend WithEvents Score35 As System.Windows.Forms.TextBox
    Friend WithEvents Score36 As System.Windows.Forms.TextBox
    Friend WithEvents Score34 As System.Windows.Forms.TextBox
    Friend WithEvents Score33 As System.Windows.Forms.TextBox
    Friend WithEvents Score31 As System.Windows.Forms.TextBox
    Friend WithEvents Score32 As System.Windows.Forms.TextBox
    Friend WithEvents Score30 As System.Windows.Forms.TextBox
    Friend WithEvents Score29 As System.Windows.Forms.TextBox
    Friend WithEvents Score27 As System.Windows.Forms.TextBox
    Friend WithEvents Score28 As System.Windows.Forms.TextBox
    Friend WithEvents Score26 As System.Windows.Forms.TextBox
    Friend WithEvents Score25 As System.Windows.Forms.TextBox
    Friend WithEvents PremScoresTitle As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ChampScoresTitle As System.Windows.Forms.TextBox
    Friend WithEvents ChampHide2BTN As System.Windows.Forms.Button
    Friend WithEvents ChampScore1 As System.Windows.Forms.TextBox
    Friend WithEvents ChampTX2Btn As System.Windows.Forms.Button
    Friend WithEvents ChampScore2 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore47 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore4 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore48 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore3 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore46 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore5 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore45 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore6 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore43 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore8 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore44 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore7 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore42 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore9 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore41 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore10 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore39 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore12 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore40 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore11 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore38 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore13 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore37 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore14 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore35 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore16 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore36 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore15 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore34 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore17 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore33 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore18 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore31 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore20 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore32 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore19 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore30 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore21 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore29 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore22 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore27 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore24 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore28 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore23 As System.Windows.Forms.TextBox
    Friend WithEvents ChampScore26 As System.Windows.Forms.TextBox
    Friend WithEvents ChampTX1Btn As System.Windows.Forms.Button
    Friend WithEvents ChampScore25 As System.Windows.Forms.TextBox
    Friend WithEvents ChampHide1BTN As System.Windows.Forms.Button
    Friend WithEvents LTStrapHideBTN As System.Windows.Forms.Button
    Friend WithEvents LTStrapTXBTN As System.Windows.Forms.Button
    Friend WithEvents LTStrapKO As System.Windows.Forms.TextBox
    Friend WithEvents LTStrapDate As System.Windows.Forms.TextBox
    Friend WithEvents ClearTXBTN As System.Windows.Forms.Button
    Friend WithEvents timeOfDayText As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TimeOfDayCLock As System.Windows.Forms.Timer
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PlayNextVidInGame As System.Windows.Forms.Button
    Friend WithEvents stopVidInGame As System.Windows.Forms.Button
    Friend WithEvents PlayVidInGame As System.Windows.Forms.Button
    Friend WithEvents ClearPlaylistInGame As System.Windows.Forms.Button
    Friend WithEvents RemovePlaylistInGame As System.Windows.Forms.Button
    Friend WithEvents AddPlaylistInGame As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents refreshVideInGame As System.Windows.Forms.Button
    Friend WithEvents playlistFilesInGame As System.Windows.Forms.ListBox
    Friend WithEvents SourceFilesInGame As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents FullScreenSubsCheck As System.Windows.Forms.RadioButton
    Friend WithEvents LowerThirdSubsCheck As System.Windows.Forms.RadioButton
    Friend WithEvents AwayTeamSubsLabel As System.Windows.Forms.Label
    Friend WithEvents HomeTeamSubsLablel As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ScoreMatchIDRadioBut As System.Windows.Forms.RadioButton
    Friend WithEvents LTMatchIDRadioBut As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hideAddedTimeButton As System.Windows.Forms.Button
    Friend WithEvents addedTimeVals As System.Windows.Forms.ComboBox
    Friend WithEvents showAddedTimeBTN As System.Windows.Forms.Button
    Friend WithEvents BPlayChanFadeOut As System.Windows.Forms.Timer
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TSCrawlOffBTN As System.Windows.Forms.Button
    Friend WithEvents TSCrawlOnBTN As System.Windows.Forms.Button
    Friend WithEvents ShowAwayFirstElevenCrawl As System.Windows.Forms.RadioButton
    Friend WithEvents ShowHomeFirstElevenCrawl As System.Windows.Forms.RadioButton
    Friend WithEvents HomeScorers As System.Windows.Forms.ListBox
    Friend WithEvents awayScorers As System.Windows.Forms.ListBox
    Friend WithEvents SendEditedAwayScorers As System.Windows.Forms.Button
    Friend WithEvents EditTextAwayScorers As System.Windows.Forms.TextBox
    Friend WithEvents EditAwayScorers As System.Windows.Forms.Button
    Friend WithEvents RemoveAwayScoreresLB As System.Windows.Forms.Button
    Friend WithEvents SendEditedHomeScorers As System.Windows.Forms.Button
    Friend WithEvents EditTextHomeScorers As System.Windows.Forms.TextBox
    Friend WithEvents EditHomeScorers As System.Windows.Forms.Button
    Friend WithEvents RemoveHomerScoreresLB As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents FullAwaySquad As System.Windows.Forms.ListBox
    Friend WithEvents AwayTeam As System.Windows.Forms.ListBox
    Friend WithEvents HomeTeam As System.Windows.Forms.ListBox
    Friend WithEvents FullHomeSquad As System.Windows.Forms.ListBox
    Friend WithEvents HomeClearSquadList As System.Windows.Forms.Button
    Friend WithEvents removeHomeSquad As System.Windows.Forms.Button
    Friend WithEvents addHomeSquad As System.Windows.Forms.Button
    Friend WithEvents clearAwaySquad As System.Windows.Forms.Button
    Friend WithEvents removeAwaySquad As System.Windows.Forms.Button
    Friend WithEvents addAwaySquad As System.Windows.Forms.Button
    Friend WithEvents updateAllTeams As System.Windows.Forms.Button
    Friend WithEvents AwayTeamLabel As System.Windows.Forms.Label
    Friend WithEvents HomeTeamLabel As System.Windows.Forms.Label
    Friend WithEvents scoresFadeOut As System.Windows.Forms.Timer
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents AddtoSquadNotListed As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HomePlayerNotListed As System.Windows.Forms.TextBox
    Friend WithEvents AddtoSqaudNotListedAway As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AwayPlayerNotListed As System.Windows.Forms.TextBox
    Friend WithEvents homePlayerCount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AwayPlayerCount As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents middle1 As System.Windows.Forms.ComboBox
    Friend WithEvents middle6 As System.Windows.Forms.ComboBox
    Friend WithEvents middle5 As System.Windows.Forms.ComboBox
    Friend WithEvents middle4 As System.Windows.Forms.ComboBox
    Friend WithEvents middle3 As System.Windows.Forms.ComboBox
    Friend WithEvents middle2 As System.Windows.Forms.ComboBox
    Friend WithEvents middle12 As System.Windows.Forms.ComboBox
    Friend WithEvents middle11 As System.Windows.Forms.ComboBox
    Friend WithEvents middle10 As System.Windows.Forms.ComboBox
    Friend WithEvents middle9 As System.Windows.Forms.ComboBox
    Friend WithEvents middle8 As System.Windows.Forms.ComboBox
    Friend WithEvents middle7 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents middle24 As System.Windows.Forms.ComboBox
    Friend WithEvents middle23 As System.Windows.Forms.ComboBox
    Friend WithEvents middle22 As System.Windows.Forms.ComboBox
    Friend WithEvents middle21 As System.Windows.Forms.ComboBox
    Friend WithEvents middle20 As System.Windows.Forms.ComboBox
    Friend WithEvents middle19 As System.Windows.Forms.ComboBox
    Friend WithEvents middle18 As System.Windows.Forms.ComboBox
    Friend WithEvents middle17 As System.Windows.Forms.ComboBox
    Friend WithEvents middle16 As System.Windows.Forms.ComboBox
    Friend WithEvents middle15 As System.Windows.Forms.ComboBox
    Friend WithEvents middle14 As System.Windows.Forms.ComboBox
    Friend WithEvents middle13 As System.Windows.Forms.ComboBox
    Friend WithEvents HomeDown As System.Windows.Forms.Button
    Friend WithEvents HomeMoveUp As System.Windows.Forms.Button
    Friend WithEvents AwayMoveDown As System.Windows.Forms.Button
    Friend WithEvents AwayMoveUp As System.Windows.Forms.Button
    Friend WithEvents PL1MoveDown As System.Windows.Forms.Button
    Friend WithEvents PL1MoveUp As System.Windows.Forms.Button
    Friend WithEvents PLInGameMoveDown As System.Windows.Forms.Button
    Friend WithEvents PLInGameMoveUp As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents goalAway As System.Windows.Forms.Button
    Friend WithEvents goalHome As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents AwayHomeGoalBTN As System.Windows.Forms.Button
    Friend WithEvents HomeOwnGoalBTN As System.Windows.Forms.Button
    Friend WithEvents AwayTeamName As System.Windows.Forms.TextBox
    Friend WithEvents HomeTeamName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents unknownGoalAway As System.Windows.Forms.Button
    Friend WithEvents unknownGoalHome As System.Windows.Forms.Button
    Friend WithEvents ChampScoresTitle2 As System.Windows.Forms.TextBox
    Friend WithEvents PremScoresTitle2 As System.Windows.Forms.TextBox
    Friend WithEvents FT6 As System.Windows.Forms.CheckBox
    Friend WithEvents FT5 As System.Windows.Forms.CheckBox
    Friend WithEvents FT4 As System.Windows.Forms.CheckBox
    Friend WithEvents FT3 As System.Windows.Forms.CheckBox
    Friend WithEvents FT2 As System.Windows.Forms.CheckBox
    Friend WithEvents FT1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents FT12 As System.Windows.Forms.CheckBox
    Friend WithEvents FT11 As System.Windows.Forms.CheckBox
    Friend WithEvents FT10 As System.Windows.Forms.CheckBox
    Friend WithEvents FT9 As System.Windows.Forms.CheckBox
    Friend WithEvents FT8 As System.Windows.Forms.CheckBox
    Friend WithEvents FT7 As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents FT24 As System.Windows.Forms.CheckBox
    Friend WithEvents FT23 As System.Windows.Forms.CheckBox
    Friend WithEvents FT22 As System.Windows.Forms.CheckBox
    Friend WithEvents FT21 As System.Windows.Forms.CheckBox
    Friend WithEvents FT20 As System.Windows.Forms.CheckBox
    Friend WithEvents FT19 As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents FT18 As System.Windows.Forms.CheckBox
    Friend WithEvents FT17 As System.Windows.Forms.CheckBox
    Friend WithEvents FT16 As System.Windows.Forms.CheckBox
    Friend WithEvents FT15 As System.Windows.Forms.CheckBox
    Friend WithEvents FT14 As System.Windows.Forms.CheckBox
    Friend WithEvents FT13 As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents msg1OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg1OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents backgrounds1 As System.Windows.Forms.ComboBox
    Friend WithEvents msg1Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg1Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg1Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg1Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg1Title As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents msg4OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg4OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx4 As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents backgrounds4 As System.Windows.Forms.ComboBox
    Friend WithEvents msg4Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg4Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg4Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg4Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg4Title As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents msg3OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg3OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx3 As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents backgrounds3 As System.Windows.Forms.ComboBox
    Friend WithEvents msg3Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg3Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg3Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg3Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg3Title As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents msg2OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg2OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx2 As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents backgrounds2 As System.Windows.Forms.ComboBox
    Friend WithEvents msg2Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg2Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg2Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg2Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg2Title As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents msg8OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg8OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx8 As System.Windows.Forms.Button
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents backgrounds8 As System.Windows.Forms.ComboBox
    Friend WithEvents msg8Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg8Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg8Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg8Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg8Title As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents msg7OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg7OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx7 As System.Windows.Forms.Button
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents backgrounds7 As System.Windows.Forms.ComboBox
    Friend WithEvents msg7Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg7Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg7Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg7Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg7Title As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents msg6OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg6OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx6 As System.Windows.Forms.Button
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents backgrounds6 As System.Windows.Forms.ComboBox
    Friend WithEvents msg6Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg6Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg6Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg6Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg6Title As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents msg5OffBtn As System.Windows.Forms.Button
    Friend WithEvents msg5OnBtn As System.Windows.Forms.Button
    Friend WithEvents ReloadBackgroundsComboBx5 As System.Windows.Forms.Button
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents backgrounds5 As System.Windows.Forms.ComboBox
    Friend WithEvents msg5Line4 As System.Windows.Forms.TextBox
    Friend WithEvents msg5Line3 As System.Windows.Forms.TextBox
    Friend WithEvents msg5Line2 As System.Windows.Forms.TextBox
    Friend WithEvents msg5Line1 As System.Windows.Forms.TextBox
    Friend WithEvents msg5Title As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents WipeTrans As System.Windows.Forms.RadioButton
    Friend WithEvents PushTrans As System.Windows.Forms.RadioButton
    Friend WithEvents MixTrans As System.Windows.Forms.RadioButton
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents WipeTransInGame As System.Windows.Forms.RadioButton
    Friend WithEvents PushTransInGame As System.Windows.Forms.RadioButton
    Friend WithEvents MixTransInGame As System.Windows.Forms.RadioButton
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Msg1ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Msg8ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents Msg7ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents Msg6ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents Msg5ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents Msg4ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents Msg3ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents Msg2ColPickBTN As System.Windows.Forms.Button
    Friend WithEvents ColorDialog2 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog3 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog4 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog5 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog6 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog7 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog8 As System.Windows.Forms.ColorDialog
    Friend WithEvents ClearGFXOnlyBTN As System.Windows.Forms.Button
    Friend WithEvents Away1stElevenCrawler As System.Windows.Forms.RadioButton
    Friend WithEvents Home1stElevenCrawler As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tab1Logo1Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents tab1Logo2Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents tab2Logo2Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents tab2Logo1Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents hideScoresScroller As System.Windows.Forms.Button
    Friend WithEvents showScoresScroller As System.Windows.Forms.Button
    Friend WithEvents sscoresT2Right As System.Windows.Forms.RadioButton
    Friend WithEvents sscoresT2Left As System.Windows.Forms.RadioButton
    Friend WithEvents sscoresT1Right As System.Windows.Forms.RadioButton
    Friend WithEvents sscoresT1Left As System.Windows.Forms.RadioButton
    Friend WithEvents playlistStop As System.Windows.Forms.Timer
    Friend WithEvents AwaySubsCount As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents homeSubsCount As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents StopTime As System.Windows.Forms.Label
    Friend WithEvents stopClockTime As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents secondHalfRadBTN As System.Windows.Forms.RadioButton
    Friend WithEvents firstHalfRadBTN As System.Windows.Forms.RadioButton
    Friend WithEvents awayCrestBTN As System.Windows.Forms.Button
    Friend WithEvents homeCrestsBTN As System.Windows.Forms.Button
    Friend WithEvents identTeamsBTN As System.Windows.Forms.Button
    Friend WithEvents updateScore As System.Windows.Forms.Button
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents OutGameCrawlUpdateBTN As System.Windows.Forms.Button
    Friend WithEvents outGameCrawlRadBTN4 As System.Windows.Forms.RadioButton
    Friend WithEvents outGameCrawlRadBTN3 As System.Windows.Forms.RadioButton
    Friend WithEvents outGameCrawlRadBTN2 As System.Windows.Forms.RadioButton
    Friend WithEvents outGameCrawlRadBTN1 As System.Windows.Forms.RadioButton
    Friend WithEvents outGameCrawl4 As System.Windows.Forms.TextBox
    Friend WithEvents outGameCrawl3 As System.Windows.Forms.TextBox
    Friend WithEvents outGameCrawl2 As System.Windows.Forms.TextBox
    Friend WithEvents OutGameCrawlOffBTN As System.Windows.Forms.Button
    Friend WithEvents OutGameCrawlOnBTN As System.Windows.Forms.Button
    Friend WithEvents outGameCrawl1 As System.Windows.Forms.TextBox
    Friend WithEvents loadBTN As System.Windows.Forms.Button
    Friend WithEvents saveBTN As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents miscTempOffBTN As System.Windows.Forms.Button
    Friend WithEvents miscTempOnBTN As System.Windows.Forms.Button
    Friend WithEvents miscTempText3TXT As System.Windows.Forms.TextBox
    Friend WithEvents miscTempText2TXT As System.Windows.Forms.TextBox
    Friend WithEvents miscTempText1TXT As System.Windows.Forms.TextBox
    Friend WithEvents miscTempNameTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents miscTempOffBTN2 As System.Windows.Forms.Button
    Friend WithEvents miscTempOnBTN2 As System.Windows.Forms.Button
    Friend WithEvents miscTempText3TXT2 As System.Windows.Forms.TextBox
    Friend WithEvents miscTempText2TXT2 As System.Windows.Forms.TextBox
    Friend WithEvents miscTempText1TXT2 As System.Windows.Forms.TextBox
    Friend WithEvents miscTempName2TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents webPageOff1BTN As System.Windows.Forms.Button
    Friend WithEvents webPageOn1BTN As System.Windows.Forms.Button
    Friend WithEvents urlText1TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents webPageOff2BTN As System.Windows.Forms.Button
    Friend WithEvents webPageOn2BTN As System.Windows.Forms.Button
    Friend WithEvents urlText2TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents hideNameIDBTN As System.Windows.Forms.Button
    Friend WithEvents showNameIDBTN As System.Windows.Forms.Button
    Friend WithEvents nameRoleIdentText4 As System.Windows.Forms.TextBox
    Friend WithEvents nameIdentText4 As System.Windows.Forms.TextBox
    Friend WithEvents nameRoleIdentText3 As System.Windows.Forms.TextBox
    Friend WithEvents nameIdentText3 As System.Windows.Forms.TextBox
    Friend WithEvents nameRoleIdentText2 As System.Windows.Forms.TextBox
    Friend WithEvents nameIdentText2 As System.Windows.Forms.TextBox
    Friend WithEvents nameRoleIdentText1 As System.Windows.Forms.TextBox
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents nameIDCHK4 As System.Windows.Forms.RadioButton
    Friend WithEvents nameIDCHK3 As System.Windows.Forms.RadioButton
    Friend WithEvents nameIDCHK2 As System.Windows.Forms.RadioButton
    Friend WithEvents nameIDCHK1 As System.Windows.Forms.RadioButton
    Friend WithEvents nameIdentText1 As System.Windows.Forms.TextBox
    Friend WithEvents stillsPlayLoadBTN As System.Windows.Forms.Button
    Friend WithEvents stillsPlaySaveBTN As System.Windows.Forms.Button
    Friend WithEvents igPlaylistLoadBTN As System.Windows.Forms.Button
    Friend WithEvents igPlaylistSaveBTN As System.Windows.Forms.Button
    Friend WithEvents loadLastHomeSquadBTN As System.Windows.Forms.Button
    Friend WithEvents loadLastAwaySquadBTN As System.Windows.Forms.Button
    Friend WithEvents AwayManagerTXT As System.Windows.Forms.TextBox
    Friend WithEvents HomeManagerTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents LowerThirdTimePeriodTXT As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents commsLoadBTN As System.Windows.Forms.Button
    Friend WithEvents commsSaveBTN As System.Windows.Forms.Button
    Friend WithEvents commsRadWIPE As System.Windows.Forms.RadioButton
    Friend WithEvents commsRadPUSH As System.Windows.Forms.RadioButton
    Friend WithEvents commsRadMIX As System.Windows.Forms.RadioButton
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents commsMoveDOWNBTN As System.Windows.Forms.Button
    Friend WithEvents commsNextBTN As System.Windows.Forms.Button
    Friend WithEvents commsMoveUpBTN As System.Windows.Forms.Button
    Friend WithEvents commsStopBTN As System.Windows.Forms.Button
    Friend WithEvents commsPlayBTN As System.Windows.Forms.Button
    Friend WithEvents commsClearBTN As System.Windows.Forms.Button
    Friend WithEvents commsRemoveBTN As System.Windows.Forms.Button
    Friend WithEvents commsAddBTN As System.Windows.Forms.Button
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents commsRefreshBTN As System.Windows.Forms.Button
    Friend WithEvents commsPlayListLB As System.Windows.Forms.ListBox
    Friend WithEvents commsSourceFilesLB As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents commercialChooseTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents commercialsRadio4 As System.Windows.Forms.RadioButton
    Friend WithEvents commercialsRadio3 As System.Windows.Forms.RadioButton
    Friend WithEvents commercialsRadio2 As System.Windows.Forms.RadioButton
    Friend WithEvents commercialsRadio1 As System.Windows.Forms.RadioButton
    Friend WithEvents commercialsCrawlText4 As System.Windows.Forms.TextBox
    Friend WithEvents commercialsCrawlText3 As System.Windows.Forms.TextBox
    Friend WithEvents commercialsCrawlText2 As System.Windows.Forms.TextBox
    Friend WithEvents CommercialCrawlOffBTN As System.Windows.Forms.Button
    Friend WithEvents CommercialCrawlOnBTN As System.Windows.Forms.Button
    Friend WithEvents commercialsCrawlText1 As System.Windows.Forms.TextBox
    Friend WithEvents commercialRefreshTemplateListBTN As System.Windows.Forms.Button
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents commericalRefreshImagesBTN As System.Windows.Forms.Button
    Friend WithEvents commercialCHooseImage As System.Windows.Forms.ComboBox
    Friend WithEvents commsPlaylistStop As System.Windows.Forms.Timer
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents commsChooseBackingBTN As System.Windows.Forms.Button
    Friend WithEvents commsChooseBackingCOMBI As System.Windows.Forms.ComboBox
    Friend WithEvents AwayGoalWithoutScoreChange_BTN As System.Windows.Forms.Button
    Friend WithEvents HomeGoalWithoutScoreChange_BTN As System.Windows.Forms.Button

End Class
