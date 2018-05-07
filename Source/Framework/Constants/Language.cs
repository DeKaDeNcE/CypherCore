﻿/*
 * Copyright (C) 2012-2018 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Framework.Constants
{
    public enum Language
    {
        Universal = 0,
        Orcish = 1,
        Darnassian = 2,
        Taurahe = 3,
        Dwarvish = 6,
        Common = 7,
        Demonic = 8,
        Titan = 9,
        Thalassian = 10,
        Draconic = 11,
        Kalimag = 12,
        Gnomish = 13,
        Troll = 14,
        Gutterspeak = 33,
        Draenei = 35,
        Zombie = 36,
        GnomishBinary = 37,
        GoblinBinary = 38,
        Worgen = 39,
        Goblin = 40,
        PandarenNeutral = 42,
        PandarenAlliance = 43,
        PandarenHorde = 44,
        Rikkitun = 168,
        Addon = -1                        // Used By Addons, In 2.4.0 Not Exist, Replaced By Messagetype?
    }

    public enum CypherStrings
    {
        // For Chat Commands
        SelectCharOrCreature = 1,
        SelectCreature = 2,

        // Level 0 Chat
        Systemmessage = 3,
        Eventmessage = 4,
        NoHelpCmd = 5,
        NoCmd = 6,
        NoSubcmd = 7,
        SubcmdsList = 8,
        AvailableCmd = 9,
        CmdSyntax = 10,
        AccountLevel = 11,
        ConnectedUsers = 12,
        Uptime = 13,
        PlayerSaved = 14,
        PlayersSaved = 15,
        GmsOnSrv = 16,
        GmsNotLogged = 17,
        YouInFlight = 18,
        UpdateDiff = 19,
        ShutdownTimeleft = 20,
        CharInFlight = 21,
        CharNonMounted = 22,
        YouInCombat = 23,
        YouUsedItRecently = 24,
        CommandNotchangepassword = 25,
        CommandPassword = 26,
        CommandWrongoldpassword = 27,
        CommandAcclocklocked = 28,
        CommandAcclockunlocked = 29,
        SpellRank = 30,
        Known = 31,
        Learn = 32,
        Passive = 33,
        Talent = 34,
        Active = 35,
        Complete = 36,
        Offline = 37,
        On = 38,
        Off = 39,
        YouAre = 40,
        Visible = 41,
        Invisible = 42,
        Done = 43,
        You = 44,
        Unknown = 45,
        Error = 46,
        NonExistCharacter = 47,
        // Unused                           = 48,
        LevelMinrequired = 49,
        LevelMinrequiredAndItem = 50,
        NpcTainerHello = 51,
        CommandInvalidItemCount = 52,
        CommandMailItemsLimit = 53,
        NewPasswordsNotMatch = 54,
        PasswordTooLong = 55,
        MotdCurrent = 56,
        UsingWorldDb = 57,
        UsingScriptLib = 58,
        UsingEventAi = 59,
        ConnectedPlayers = 60,
        AccountAddon = 61,
        ImproperValue = 62,
        RbacWrongParameterId = 63,
        RbacWrongParameterRealm = 64,
        RbacListHeaderGranted = 65,
        RbacListHeaderDenied = 66,
        RbacListHeaderBySecLevel = 67,
        RbacListPermissionsHeader = 68,
        RbacListPermsLinkedHeader = 69,
        RbacListEmpty = 70,
        RbacListElement = 71,
        RbacPermGrantedInList = 72,
        RbacPermGrantedInDeniedList = 73,
        RbacPermGranted = 74,
        RbacPermDeniedInList = 75,
        RbacPermDeniedInGrantedList = 76,
        RbacPermDenied = 77,
        RbacPermRevoked = 78,
        RbacPermRevokedNotInList = 79,
        Pvpstats = 80,
        PvpstatsDisabled = 81,
        CommandNearGraveyard = 82,
        CommandNearGraveyardNotfound = 83,
        GoinfoSize = 84,
        GoinfoAddon = 85,
        GoinfoModel = 86,
        // Free 87 - 95


        GuildRenameAlreadyExists = 96,
        GuildRenameDone = 97,
        RenamePlayerAlreadyExists = 98,
        RenamePlayerWithNewName = 99,

        // Level 1 Chat
        GlobalNotify = 100,
        MapPosition = 101,
        IsTeleported = 102,
        CannotSummonToInst = 103,
        CannotGoToInstParty = 104,
        CannotGoToInstGm = 105,
        CannotGoInstInst = 106,
        CannotSummonInstInst = 107,
        Summoning = 108,
        SummonedBy = 109,
        TeleportingTo = 110,
        TeleportedToBy = 111,
        NoPlayer = 112,
        AppearingAt = 113,
        AppearingTo = 114,
        BadValue = 115,
        NoCharSelected = 116,
        NotInGroup = 117,

        YouChangeHp = 118,
        YoursHpChanged = 119,
        YouChangeMana = 120,
        YoursManaChanged = 121,
        YouChangeEnergy = 122,
        YoursEnergyChanged = 123,

        CurrentEnergy = 124,
        YouChangeRage = 125,
        YoursRageChanged = 126,
        YouChangeLvl = 127,
        CurrentFaction = 128,
        WrongFaction = 129,
        YouChangeFaction = 130,
        YouChangeSpellflatid = 131,
        YoursSpellflatidChanged = 132,
        YouGiveTaxis = 133,
        YouRemoveTaxis = 134,
        YoursTaxisAdded = 135,
        YoursTaxisRemoved = 136,

        YouChangeAspeed = 137,
        YoursAspeedChanged = 138,
        YouChangeSpeed = 139,
        YoursSpeedChanged = 140,
        YouChangeSwimSpeed = 141,
        YoursSwimSpeedChanged = 142,
        YouChangeBackSpeed = 143,
        YoursBackSpeedChanged = 144,
        YouChangeFlySpeed = 145,
        YoursFlySpeedChanged = 146,

        YouChangeSize = 147,
        YoursSizeChanged = 148,
        NoMount = 149,
        YouGiveMount = 150,
        MountGived = 151,

        CurrentMoney = 152,
        YouTakeAllMoney = 153,
        YoursAllMoneyGone = 154,
        YouTakeMoney = 155,
        YoursMoneyTaken = 156,
        YouGiveMoney = 157,
        YoursMoneyGiven = 158,
        YouHearSound = 159,

        NewMoney = 160,              // Log

        RemoveBit = 161,
        SetBit = 162,
        CommandTeleTableempty = 163,
        CommandTeleNotfound = 164,
        CommandTeleParameter = 165,
        CommandTeleNolocation = 166,
        ReservedName = 167,
        CommandTeleLocation = 168,

        MailSent = 169,
        SoundNotExist = 170,
        CantTeleportSelf = 171,
        ConsoleCommand = 172,
        YouChangeRunicPower = 173,
        YoursRunicPowerChanged = 174,
        LiquidStatus = 175,
        InvalidGameobjectType = 176,
        GameobjectDamaged = 177,
        GridPosition = 178,

        PhaseshiftStatus = 179,
        PhaseshiftPhases = 180,
        PhaseshiftVisibleMapIds = 181,
        PhaseshiftUiWorldMapAreaSwaps = 182,
        PhaseFlagCosmetic = 183,
        PhaseFlagPersonal = 184,

        //                                    185 not used
        TransportPosition = 186,
        // Room For More Level 1              187-199 Not Used

        // Level 2 Chat
        NoSelection = 200,
        ObjectGuid = 201,
        TooLongName = 202,
        CharsOnly = 203,
        TooLongSubname = 204,
        NotImplemented = 205,

        ItemAddedToList = 206,
        ItemNotFound = 207,
        ItemDeletedFromList = 208,
        ItemNotInList = 209,
        ItemAlreadyInList = 210,

        ResetSpellsOnline = 211,
        ResetSpellsOffline = 212,
        ResetTalentsOnline = 213,
        ResetTalentsOffline = 214,
        ResetSpells = 215,
        ResetTalents = 216,

        ResetallUnknownCase = 217,
        ResetallSpells = 218,
        ResetallTalents = 219,

        WaypointNotfound = 220,
        WaypointNotfoundlast = 221,
        WaypointNotfoundsearch = 222,
        WaypointNotfounddbproblem = 223,
        WaypointCreatselected = 224,
        WaypointCreatnotfound = 225,
        WaypointVpSelect = 226,
        WaypointVpNotfound = 227,
        WaypointVpNotcreated = 228,
        WaypointVpAllremoved = 229,
        WaypointNotcreated = 230,
        WaypointNoguid = 231,
        WaypointNowaypointgiven = 232,
        WaypointArgumentreq = 233,
        WaypointAdded = 234,
        WaypointAddedNo = 235,
        WaypointChanged = 236,
        WaypointChangedNo = 237,
        WaypointExported = 238,
        WaypointNothingtoexport = 239,
        WaypointImported = 240,
        WaypointRemoved = 241,
        WaypointNotremoved = 242,
        WaypointToofar1 = 243,
        WaypointToofar2 = 244,
        WaypointToofar3 = 245,
        WaypointInfoTitle = 246,
        WaypointInfoWaittime = 247,
        WaypointInfoModel = 248,
        WaypointInfoEmote = 249,
        WaypointInfoSpell = 250,
        WaypointInfoText = 251,
        WaypointInfoAiscript = 252,

        RenamePlayer = 253,
        RenamePlayerGuid = 254,

        WaypointWpcreatnotfound = 255,
        WaypointNpcnotfound = 256,

        MoveTypeSet = 257,
        MoveTypeSetNodel = 258,
        UseBol = 259,
        ValueSaved = 260,
        ValueSavedRejoin = 261,

        CommandGoareatrnotfound = 262,
        InvalidTargetCoord = 263,
        InvalidZoneCoord = 264,
        InvalidZoneMap = 265,
        CommandTargetobjnotfound = 266,
        CommandGoobjnotfound = 267,
        CommandGocreatnotfound = 268,
        CommandGocreatmultiple = 269,
        CommandDelcreatmessage = 270,
        CommandCreaturemoved = 271,
        CommandCreatureatsamemap = 272,
        CommandObjnotfound = 273,
        CommandDelobjrefercreature = 274,
        CommandDelobjmessage = 275,
        CommandTurnobjmessage = 276,
        CommandMoveobjmessage = 277,
        CommandVendorselection = 278,
        CommandNeeditemsend = 279,
        CommandAddvendoritemitems = 280,
        CommandKickself = 281,
        CommandKickmessage = 282,
        CommandDisableChatDelayed = 283,
        CommandWhisperaccepting = 284,
        CommandWhisperon = 285,
        CommandWhisperoff = 286,
        CommandCreatguidnotfound = 287,
        // Ticket Strings Need Rewrite // 288-296 Free

        // End
        CommandSpawndist = 297,
        CommandSpawntime = 298,
        CommandModifyHonor = 299,

        YourChatDisabled = 300,
        YouDisableChat = 301,
        ChatAlreadyEnabled = 302,
        YourChatEnabled = 303,
        YouEnableChat = 304,

        CommandModifyRep = 305,
        CommandModifyArena = 306,
        CommandFactionNotfound = 307,
        CommandFactionUnknown = 308,
        CommandFactionInvparam = 309,
        CommandFactionDelta = 310,
        FactionList = 311,
        FactionVisible = 312,
        FactionAtwar = 313,
        FactionPeaceForced = 314,
        FactionHidden = 315,
        FactionInvisibleForced = 316,
        FactionInactive = 317,
        RepHated = 318,
        RepHostile = 319,
        RepUnfriendly = 320,
        RepNeutral = 321,
        RepFriendly = 322,
        RepHonored = 323,
        RepRevered = 324,
        RepExalted = 325,
        CommandFactionNorepError = 326,
        FactionNoreputation = 327,
        LookupPlayerAccount = 328,
        LookupPlayerCharacter = 329,
        NoPlayersFound = 330,
        ExtendedCostNotExist = 331,
        GmOn = 332,
        GmOff = 333,
        GmChatOn = 334,
        GmChatOff = 335,
        YouRepairItems = 336,
        YourItemsRepaired = 337,
        YouSetWaterwalk = 338,
        YourWaterwalkSet = 339,
        CreatureFollowYouNow = 340,
        CreatureNotFollowYou = 341,
        CreatureNotFollowYouNow = 342,
        CreatureNonTameable = 343,
        YouAlreadyHavePet = 344,
        CustomizePlayer = 345,
        CustomizePlayerGuid = 346,
        CommandGotaxinodenotfound = 347,
        GameobjectHaveInvalidData = 348,
        TitleListChat = 349,
        TitleListConsole = 350,
        CommandNotitlefound = 351,
        InvalidTitleId = 352,
        TitleAddRes = 353,
        TitleRemoveRes = 354,
        TitleCurrentRes = 355,
        CurrentTitleReset = 356,
        CommandCheatStatus = 357,
        CommandCheatGod = 358,
        CommandCheatCt = 359,
        CommandCheatCd = 360,
        CommandCheatPower = 361,
        CommandCheatWw = 362,
        CommandWhisperoffplayer = 363,
        CommandCheatTaxinodes = 364,
        // Room For More Level 2              365-399 Not Used

        // Level 3 Chat
        ScriptsReloaded = 400,
        YouChangeSecurity = 401,
        YoursSecurityChanged = 402,
        YoursSecurityIsLow = 403,
        CreatureMoveDisabled = 404,
        CreatureMoveEnabled = 405,
        NoWeather = 406,
        WeatherDisabled = 407,

        BanYoubanned = 408,
        BanYoupermbanned = 409,
        BanNotfound = 410,

        UnbanUnbanned = 411,
        UnbanError = 412,

        AccountNotExist = 413,

        BaninfoNocharacter = 414,
        BaninfoNoip = 415,
        BaninfoNoaccountban = 416,
        BaninfoBanhistory = 417,
        BaninfoHistoryentry = 418,
        BaninfoInfinite = 419,
        BaninfoNever = 420,
        Yes = 421,
        No = 422,
        BaninfoIpentry = 423,

        BanlistNoip = 424,
        BanlistNoaccount = 425,
        BanlistNocharacter = 426,
        BanlistMatchingip = 427,
        BanlistMatchingaccount = 428,

        CommandLearnManySpells = 429,
        CommandLearnClassSpells = 430,
        CommandLearnClassTalents = 431,
        CommandLearnAllLang = 432,
        CommandLearnAllCraft = 433,
        CommandCouldnotfind = 434,
        CommandItemidinvalid = 435,
        CommandNoitemfound = 436,
        CommandListobjinvalidid = 437,
        CommandListitemmessage = 438,
        CommandListobjmessage = 439,
        CommandInvalidcreatureid = 440,
        CommandListcreaturemessage = 441,
        CommandNoareafound = 442,
        CommandNoitemsetfound = 443,
        CommandNoskillfound = 444,
        CommandNospellfound = 445,
        CommandNoquestfound = 446,
        CommandNocreaturefound = 447,
        CommandNogameobjectfound = 448,
        CommandGraveyardnoexist = 449,
        CommandGraveyardalrlinked = 450,
        CommandGraveyardlinked = 451,
        CommandGraveyardwrongzone = 452,
        //                                  = 453, See PinfoPlayer
        CommandGraveyarderror = 454,
        CommandGraveyardNoteam = 455,
        CommandGraveyardAny = 456,
        CommandGraveyardAlliance = 457,
        CommandGraveyardHorde = 458,
        CommandGraveyardnearest = 459,
        CommandZonenograveyards = 460,
        CommandZonenografaction = 461,
        CommandTpAlreadyexist = 462,
        CommandTpAdded = 463,
        CommandTpAddederr = 464,
        CommandTpDeleted = 465,
        CommandNotaxinodefound = 466,
        CommandTargetListauras = 467,
        CommandTargetAuradetail = 468,
        CommandTargetListauratype = 469,
        CommandTargetAurasimple = 470,

        CommandQuestNotfound = 471,
        CommandQuestStartfromitem = 472,
        CommandQuestRemoved = 473,
        CommandQuestRewarded = 474,
        CommandQuestComplete = 475,
        CommandQuestActive = 476,

        CommandFlymodeStatus = 477,

        CommandOpcodesent = 478,

        CommandImportSuccess = 479,
        CommandImportFailed = 480,
        CommandExportSuccess = 481,
        CommandExportFailed = 482,

        CommandSpellBroken = 483,

        SetSkill = 484,
        SetSkillError = 485,

        InvalidSkillId = 486,
        LearningGmSkills = 487,
        YouKnownSpell = 488,
        TargetKnownSpell = 489,
        UnknownSpell = 490,
        ForgetSpell = 491,
        RemoveallCooldown = 492,
        RemoveCooldown = 493,

        Additem = 494,              //Log
        Additemset = 495,              //Log
        Removeitem = 496,
        ItemCannotCreate = 497,
        InsertGuildName = 498,
        PlayerNotFound = 499,
        PlayerInGuild = 500,
        GuildNotCreated = 501,
        NoItemsFromItemsetFound = 502,

        Distance = 503,

        ItemSlot = 504,
        ItemSlotNotExist = 505,
        ItemAddedToSlot = 506,
        ItemSaveFailed = 507,
        ItemlistSlot = 508,
        ItemlistMail = 509,
        ItemlistAuction = 510,

        WrongLinkType = 511,
        ItemListChat = 512,
        QuestListChat = 513,
        CreatureEntryListChat = 514,
        CreatureListChat = 515,
        GoEntryListChat = 516,
        GoListChat = 517,
        ItemsetListChat = 518,
        TeleList = 519,
        SpellList = 520,
        SkillListChat = 521,

        GameobjectNotExist = 522,

        GameobjectCurrent = 523,              //Log
        GameobjectDetail = 524,
        GameobjectAdd = 525,

        MovegensList = 526,
        MovegensIdle = 527,
        MovegensRandom = 528,
        MovegensWaypoint = 529,
        MovegensAnimalRandom = 530,
        MovegensConfused = 531,
        MovegensChasePlayer = 532,
        MovegensChaseCreature = 533,
        MovegensChaseNull = 534,
        MovegensHomeCreature = 535,
        MovegensHomePlayer = 536,
        MovegensFlight = 537,
        MovegensUnknown = 538,

        NpcinfoChar = 539,
        NpcinfoLevel = 540,
        NpcinfoHealth = 541,
        NpcinfoDynamicFlags = 542,
        NpcinfoLoot = 543,
        NpcinfoPosition = 544,
        NpcinfoVendor = 545,
        NpcinfoTrainer = 546,
        NpcinfoDungeonId = 547,

        //                                  = 548, See PinfoGmActive
        //                                  = 549, See PinfoBanned
        //                                  = 550, See PinfoMuted

        YouSetExploreAll = 551,
        YouSetExploreNothing = 552,
        YoursExploreSetAll = 553,
        YoursExploreSetNothing = 554,

        NpcSetdata = 555,

        //! Old Ones Now Free:
        CommandNearNpcMessage = 556,

        YoursLevelUp = 557,
        YoursLevelDown = 558,
        YoursLevelProgressReset = 559,
        ExploreArea = 560,
        UnexploreArea = 561,

        Update = 562,
        UpdateChange = 563,
        TooBigIndex = 564,
        SetUint = 565,              //Log
        SetUintField = 566,
        SetFloat = 567,              //Log
        SetFloatField = 568,
        GetUint = 569,              //Log
        GetUintField = 570,
        GetFloat = 571,              //Log
        GetFloatField = 572,
        Set32bit = 573,              //Log
        Set32bitField = 574,
        Change32bit = 575,              //Log
        Change32bitField = 576,

        InvisibleInvisible = 577,
        InvisibleVisible = 578,
        SelectedTargetNotHaveVictim = 579,

        CommandLearnAllDefaultAndQuest = 580,
        CommandNearobjmessage = 581,
        CommandRawpawntimes = 582,

        EventEntryListChat = 583,
        Noeventfound = 584,
        EventNotExist = 585,
        EventInfo = 586,
        EventAlreadyActive = 587,
        EventNotActive = 588,

        MovegensPoint = 589,
        MovegensFear = 590,
        MovegensDistract = 591,

        CommandLearnAllRecipes = 592,
        BanlistAccounts = 593,
        BanlistAccountsHeader = 594,
        BanlistIps = 595,
        BanlistIpsHeader = 596,
        Gmlist = 597,
        GmlistHeader = 598,
        GmlistEmpty = 599,

        // End Level 3 List, Continued At 1100

        // 600-704 - free

        WaitBeforeSpeaking = 705,
        NotEquippedItem = 706,
        PlayerDnd = 707,
        PlayerAfk = 708,
        PlayerDndDefault = 709,
        PlayerAfkDefault = 710,

        BgQueueAnnounceSelf = 711,
        BgQueueAnnounceWorld = 712,
        YourArenaLevelReqError = 713,
        //                                      = 714, See PinfoAccAccount
        YourBgLevelReqError = 715,
        //                                      = 716, See PinfoAccLastlogin
        BgStartedAnnounceWorld = 717,
        ArenaQueueAnnounceWorldJoin = 718,
        ArenaQueueAnnounceWorldExit = 719,

        BgGroupTooLarge = 720,              // "Your Group Is Too Large For This Battleground. Please Regroup To Join."
        ArenaGroupTooLarge = 721,              // "Your Group Is Too Large For This Arena. Please Regroup To Join."
        ArenaYourTeamOnly = 722,              // "Your Group Has Members Not In Your Arena Team. Please Regroup To Join."
        ArenaNotEnoughPlayers = 723,              // "Your Group Does Not Have Enough Players To Join This Match."
        // 724-726 - free
        BgGroupOfflineMember = 727,              // "Your Group Has An Offline Member. Please Remove Him Before Joining."
        BgGroupMixedFaction = 728,              // "Your Group Has Players From The Opposing Faction. You Can'T Join The Battleground As A Group."
        BgGroupMixedLevels = 729,              // "Your Group Has Players From Different Battleground Brakets. You Can'T Join As Group."
        BgGroupMemberAlreadyInQueue = 730,            // "Someone In Your Party Is Already In This Battleground Queue. (S)He Must Leave It Before Joining As Group."
        BgGroupMemberDeserter = 731,              // "Someone In Your Party Is Deserter. You Can'T Join As Group."
        BgGroupMemberNoFreeQueueSlots = 732,         // "Someone In Your Party Is Already In Three Battleground Queues. You Cannot Join As Group."

        CannotTeleToBg = 733,              // "You Cannot Teleport To A Battleground Or Arena Map."
        CannotSummonToBg = 734,              // "You Cannot Summon Players To A Battleground Or Arena Map."
        CannotGoToBgGm = 735,              // "You Must Be In Gm Mode To Teleport To A Player In A Battleground."
        CannotGoToBgFromBg = 736,              // "You Cannot Teleport To A Battleground From Another Battleground. Please Leave The Current Battleground First."
        DebugArenaOn = 737,
        DebugArenaOff = 738,
        DebugBgOn = 739,
        DebugBgOff = 740,
        //  DistArenaPointsStart        = 741,
        //  DistArenaPointsOnlineStart = 742,
        //  DistArenaPointsOnlineEnd   = 743,
        //  DistArenaPointsTeamStart   = 744,
        //  DistArenaPointsTeamEnd     = 745,
        //  DistArenaPointsEnd          = 746,
        BgDisabled = 747,
        ArenaDisabled = 748,
        //                                      = 749, See PinfoAccOs
        BattlegroundPrematureFinishWarning = 750,       // "Not Enough Players. This Game Will Close In %U Mins."
        BattlegroundPrematureFinishWarningSecs = 751,  // "Not Enough Players. This Game Will Close In %U Seconds."
        //                                      = 752, See PinfoAccIp
        // 753-755 - free
        // Room For Bg/Arena                = 773-784
        ArenaTesting = 785,
        AutoAnn = 786,
        AnnounceColor = 787,
        // 788-799 - free

        // In Game Strings
        PetInvalidName = 800,
        NotEnoughGold = 801,
        NotFreeTradeSlots = 802,
        NotPartnerFreeTradeSlots = 803,
        YouNotHavePermission = 804,
        UnknownLanguage = 805,
        NotLearnedLanguage = 806,
        NeedCharacterName = 807,
        PlayerNotExistOrOffline = 808,
        AccountForPlayerNotFound = 809,
        // Unused                           = 810,
        GuildMaster = 811,
        GuildOfficer = 812,
        GuildVeteran = 813,
        GuildMember = 814,
        GuildInitiate = 815,
        ZoneNoflyzone = 816,

        CommandCreaturetemplateNotfound = 817,
        CommandCreaturestorageNotfound = 818,

        ChannelCity = 819,

        NpcinfoGossip = 820,
        NpcinfoQuestgiver = 821,
        NpcinfoTrainerClass = 822,
        NpcinfoTrainerProfession = 823,
        NpcinfoVendorAmmo = 824,
        NpcinfoVendorFood = 825,
        NpcinfoVendorPoison = 826,
        NpcinfoVendorReagent = 827,
        NpcinfoRepair = 828,
        NpcinfoFlightmaster = 829,
        NpcinfoSpirithealer = 830,
        NpcinfoSpiritguide = 831,
        NpcinfoInnkeeper = 832,
        NpcinfoBanker = 833,
        NpcinfoPetitioner = 834,
        NpcinfoTabarddesigner = 835,
        NpcinfoBattlemaster = 836,
        NpcinfoAuctioneer = 837,
        NpcinfoStablemaster = 838,
        NpcinfoGuildBanker = 839,
        NpcinfoSpellclick = 840,
        NpcinfoMailbox = 841,
        NpcinfoPlayerVehicle = 842,

        // Pinfo Commands
        PinfoPlayer = 453,
        PinfoGmActive = 548,
        PinfoBanned = 549,
        PinfoMuted = 550,
        PinfoAccAccount = 714,
        PinfoAccLastlogin = 716,
        PinfoAccOs = 749,
        PinfoAccRegmails = 879,
        PinfoAccIp = 752,
        PinfoChrLevelLow = 843,
        PinfoChrRace = 844,
        PinfoChrAlive = 845,
        PinfoChrPhases = 846,
        PinfoChrMoney = 847,
        PinfoChrMap = 848,
        PinfoChrGuild = 849,
        PinfoChrGuildRank = 850,
        PinfoChrGuildNote = 851,
        PinfoChrGuildOnote = 852,
        PinfoChrPlayedtime = 853,
        PinfoChrMails = 854,
        PinfoChrLevelHigh = 871,

        CharacterGenderMale = 855,
        CharacterGenderFemale = 856,

        ArenaErrorNotFound = 857,
        ArenaErrorNameExists = 858,
        ArenaErrorSize = 859,
        ArenaErrorCombat = 860,
        AreanErrorNameNotFound = 861,
        ArenaErrorNotMember = 862,
        ArenaErrorCaptain = 863,
        ArenaCreate = 864,
        ArenaDisband = 865,
        ArenaRename = 866,
        ArenaCaptain = 867,
        ArenaInfoHeader = 868,
        ArenaInfoMembers = 869,
        ArenaLookup = 870,
        //                                  = 871, See PinfoChrLevelHigh
        CommandWrongemail = 872,
        NewEmailsNotMatch = 873,
        CommandEmail = 874,
        EmailTooLong = 875,
        CommandNotchangeemail = 876,
        OldEmailIsNewEmail = 877,
        CommandEmailOutput = 878,
        //                                  = 879, See PinfoChrRegmails
        AccountSecType = 880,
        RbacEmailRequired = 881,
        // Room For In-Game Strings           882-999 Not Used

        // Level 4 (Cli Only Commands)
        CommandExit = 1000,
        AccountDeleted = 1001,
        AccountNotDeletedSqlError = 1002,
        AccountNotDeleted = 1003,
        AccountCreated = 1004,
        AccountNameTooLong = 1005,
        AccountAlreadyExist = 1006,
        AccountNotCreatedSqlError = 1007,
        AccountNotCreated = 1008,
        CharacterDeleted = 1009,
        AccountListHeader = 1010,
        AccountListError = 1011,
        AccountListBar = 1012,
        AccountListLine = 1013,
        AccountListEmpty = 1014,
        AccountListBarHeader = 1015,
        CharacterDeletedListHeader = 1016,
        CharacterDeletedListLineConsole = 1017,
        CharacterDeletedListBar = 1018,
        CharacterDeletedListEmpty = 1019,
        CharacterDeletedRestore = 1020,
        CharacterDeletedDelete = 1021,
        CharacterDeletedErrRename = 1022,
        CharacterDeletedSkipAccount = 1023,
        CharacterDeletedSkipFull = 1024,
        CharacterDeletedSkipName = 1025,
        CharacterDeletedListLineChat = 1026,
        SqldriverQueryLoggingEnabled = 1027,
        SqldriverQueryLoggingDisabled = 1028,
        AccountInvalidBnetName = 1029,
        AccountUseBnetCommands = 1030,
        AccountPassTooLong = 1031,
        AccountCreatedBnetWithGame = 1032,
        AccountCreatedBnet = 1033,
        AccountBnetListHeader = 1034,
        AccountBnetListNoAccounts = 1035,
        // Room For More Level 4              1036-1099 Not Used

        // Level 3 (Continue)
        AccountSetaddon = 1100,
        MotdNew = 1101,
        Sendmessage = 1102,
        EventEntryListConsole = 1103,
        CreatureEntryListConsole = 1104,
        ItemListConsole = 1105,
        ItemsetListConsole = 1106,
        GoEntryListConsole = 1107,
        QuestListConsole = 1108,
        SkillListConsole = 1109,
        CreatureListConsole = 1110,
        GoListConsole = 1111,
        FileOpenFail = 1112,
        AccountCharacterListFull = 1113,
        DumpBroken = 1114,
        InvalidCharacterName = 1115,
        InvalidCharacterGuid = 1116,
        CharacterGuidInUse = 1117,
        ItemlistGuild = 1118,
        MustMaleOrFemale = 1119,
        YouChangeGender = 1120,
        YourGenderChanged = 1121,
        SkillValues = 1122,
        NoPetFound = 1123,
        WrongPetType = 1124,
        CommandLearnPetTalents = 1125,
        ResetPetTalents = 1126,
        ResetPetTalentsOnline = 1127,
        TaxinodeEntryListChat = 1128,
        TaxinodeEntryListConsole = 1129,
        CommandExportDeletedChar = 1130,
        BanlistMatchingcharacter = 1131,
        BanlistCharacters = 1132,
        BanlistCharactersHeader = 1133,
        AllowTickets = 1134,
        DisallowTickets = 1135,
        CharNotBanned = 1136,
        DevOn = 1137,
        DevOff = 1138,
        MovegensFollowPlayer = 1139,
        MovegensFollowCreature = 1140,
        MovegensFollowNull = 1141,
        MovegensEffect = 1142,
        MoveflagsGet = 1143,
        MoveflagsSet = 1144,
        GroupAlreadyInGroup = 1145,
        GroupPlayerJoined = 1146,
        GroupNotInGroup = 1147,
        GroupFull = 1148,
        GroupType = 1149,
        GroupPlayerNameGuid = 1150,
        ListMailHeader = 1151,
        ListMailInfo1 = 1152,
        ListMailInfo2 = 1153,
        ListMailInfo3 = 1154,
        ListMailInfoItem = 1155,
        ListMailNotFound = 1156,
        AhbotReloadOk = 1157,
        AhbotStatusBarConsole = 1158,
        AhbotStatusMidbarConsole = 1159,
        AhbotStatusTitle1Console = 1160,
        AhbotStatusTitle1Chat = 1161,
        AhbotStatusFormatConsole = 1162,
        AhbotStatusFormatChat = 1163,
        AhbotStatusItemCount = 1164,
        AhbotStatusItemRatio = 1165,
        AhbotStatusTitle2Console = 1166,
        AhbotStatusTitle2Chat = 1167,
        AhbotQualityGray = 1168,
        AhbotQualityWhite = 1169,
        AhbotQualityGreen = 1170,
        AhbotQualityBlue = 1171,
        AhbotQualityPurple = 1172,
        AhbotQualityOrange = 1173,
        AhbotQualityYellow = 1174,
        AhbotItemsAmount = 1175,
        AhbotItemsRatio = 1176,
        GuildInfoName = 1177,
        GuildInfoGuildMaster = 1178,
        GuildInfoCreationDate = 1179,
        GuildInfoMemberCount = 1180,
        GuildInfoBankGold = 1181,
        GuildInfoMotd = 1182,
        GuildInfoExtraInfo = 1183,
        GuildInfoLevel = 1184,
        AccountBnetLinked = 1185,
        AccountOrBnetDoesNotExist = 1186,
        AccountAlreadyLinked = 1187,
        AccountBnetUnlinked = 1188,
        AccountBnetNotLinked = 1189,
        DisallowTicketsConfig = 1190,
        BanExists = 1191,
        // Room For More Level 3              1192-1198 Not Used

        // Debug Commands
        DebugAreatriggerLeft = 1999,
        CinematicNotExist = 1200,
        MovieNotExist = 1201,
        DebugAreatriggerOn = 1202,
        DebugAreatriggerOff = 1203,
        DebugAreatriggerEntered = 1204,
        // 1205-2002 - free

        // Ticket Strings 2003-2028
        CommandTicketclosed = 2003,
        CommandTicketdeleted = 2004,
        CommandTicketnotexist = 2005,
        CommandTicketclosefirst = 2006,
        CommandTicketalreadyassigned = 2007,
        CommandTicketshowlist = 2009,
        CommandTicketshowclosedlist = 2011,
        CommandTicketassignerrorA = 2012,
        CommandTicketassignerrorB = 2013,
        CommandTicketnotassigned = 2014,
        CommandTicketunassignsecurity = 2015,
        CommandTicketcannotclose = 2016,
        CommandTicketlistguid = 2017,
        CommandTicketlistname = 2018,
        CommandTicketlistassignedto = 2020,
        CommandTicketlistunassigned = 2021,
        CommandTicketlistmessage = 2022,
        CommandTicketlistcomment = 2023,
        CommandTicketlistaddcomment = 2024,
        CommandTicketlistagecreate = 2025,
        CommandTicketpending = 2027,
        CommandTicketreset = 2028,

        // Trinity Strings                    5000-9999
        CommandFreeze = 5000,
        CommandFreezeError = 5001,
        CommandFreezeWrong = 5002,
        CommandUnfreeze = 5003,
        CommandNoFrozenPlayers = 5004,
        CommandListFreeze = 5005,
        CommandPermaFrozenPlayer = 5006,
        PhaseNotfound = 5007,
        InstanceClosed = 5008,
        CommandPlayedToAll = 5009,
        NpcinfoLinkguid = 5010,
        TeleportedToByConsole = 5011,
        // For Command Lookup Map
        CommandNomapfound = 5012,
        Continent = 5013,
        Instance = 5014,
        Battleground = 5015,
        Arena = 5016,
        Raid = 5017,
        NpcinfoPhaseIds = 5018,
        CommandTempFrozenPlayer = 5019,
        NpcinfoPhases = 5020,
        NpcinfoArmor = 5021,
        ChannelEnableOwnership = 5022,
        ChannelDisableOwnership = 5023,
        GoinfoEntry = 5024,
        GoinfoType = 5025,
        GoinfoDisplayid = 5026,
        GoinfoName = 5027,
        GoinfoLootid = 5028,
        CommandLookupMaxResults = 5029,
        Unauthorized = 5030,
        NpcinfoAiinfo = 5031,
        CommandNoBattlegroundFound = 5032,
        CommandNoAchievementCriteriaFound = 5033,
        CommandNoOutdoorPvpForund = 5034,
        NoReason = 5035,
        NpcinfoEquipment = 5036,
        NpcinfoMechanicImmune = 5037,
        NpcinfoUnitFieldFlags = 5038,
        Console = 5039,
        Character = 5040,
        Permanently = 5041,
        GpsPositionOutdoors = 5042,
        GpsPositionIndoors = 5043,
        GpsNoVmap = 5044,

        // Instance Commands
        CommandListBindInfo = 5045,
        CommandListBindPlayerBinds = 5046,
        CommandListBindGroupBinds = 5047,
        CommandInstUnbindUnbinding = 5048,
        CommandInstUnbindUnbound = 5049,
        CommandInstStatLoadedInst = 5050,
        CommandInstStatPlayersIn = 5051,
        CommandInstStatSaves = 5052,
        CommandInstStatPlayersbound = 5053,
        CommandInstStatGroupsbound = 5054,
        NotDungeon = 5055, // Map Is Not A Dungeon.
        NoInstanceData = 5056, // Map Has No Instance Data.
        CommandInstSetBossState = 5057,
        CommandInstGetBossState = 5058,

        // Mutehistory Commands
        CommandMutehistory = 5059,
        CommandMutehistoryEmpty = 5060,
        CommandMutehistoryOutput = 5061,

        // Scene Debugs Commands
        CommandSceneDebugOn = 5062,
        CommandSceneDebugOff = 5063,
        CommandSceneDebugPlay = 5064,
        CommandSceneDebugTrigger = 5065,
        CommandSceneDebugCancel = 5066,
        CommandSceneDebugComplete = 5067,
        DebugSceneObjectList = 5068,
        DebugSceneObjectDetail = 5069,

        NpcinfoUnitFieldFlags2 = 5070,
        NpcinfoUnitFieldFlags3 = 5071,
        NpcinfoNpcFlags = 5072,

        // Room For More Trinity Strings      5073-9999

        // Level Requirement Notifications
        SayReq = 6604,
        WhisperReq = 6605,
        ChannelReq = 6606,
        AuctionReq = 6607,
        TicketReq = 6608,
        TradeReq = 6609,
        TradeOtherReq = 6610,
        MailSenderReq = 6611,
        MailReceiverReq = 6612,

        // Used For Gm Announcements
        GmBroadcast = 6613,
        GmNotify = 6614,
        GmAnnounceColor = 6615,

        GmSilence = 6616,              // "Silence Is On For %S" - Spell 1852

        WorldClosed = 7523,
        WorldOpened = 7524,

        LfgPlayerInfo = 9980,
        LfgGroupInfo = 9981,
        LfgNotInGroup = 9982,
        LfgClean = 9983,
        LfgOptions = 9984,
        LfgOptionsChanged = 9985,
        LfgStateNone = 9986,
        LfgStateRolecheck = 9987,
        LfgStateQueued = 9988,
        LfgStateProposal = 9989,
        LfgStateBoot = 9990,
        LfgStateDungeon = 9991,
        LfgStateFinishedDungeon = 9992,
        LfgStateRaidbrowser = 9993,
        LfgRoleTank = 9994,
        LfgRoleHealer = 9995,
        LfgRoleDamage = 9996,
        LfgRoleLeader = 9997,
        LfgRoleNone = 9998,
        LfgError = 9999,

        // Use For Not-In-Offcial-Sources Patches
        //                                    10000-10999
        // Opvp Si
        OpvpSiCaptureH = 10049,
        OpvpSiCaptureA = 10050,
        // Opvp Gossips
        OpvpEpFlightNpt = 10051,
        OpvpEpFlightEwt = 10052,
        OpvpEpFlightCgt = 10053,
        OpvpZmGossipAlliance = 10054,
        OpvpZmGossipHorde = 10055,

        // 10056-10066 - free

        // Use For Custom Patches             11000-11999
        AutoBroadcast = 11000,
        InvalidRealmid = 11001,

        // Show Kick In World
        CommandKickmessageWorld = 11002,

        // Show Mute In World
        CommandMutemessageWorld = 11003,

        // Show Ban In World
        BanCharacterYoubannedmessageWorld = 11004,
        BanCharacterYoupermbannedmessageWorld = 11005,
        BanAccountYoubannedmessageWorld = 11006,
        BanAccountYoupermbannedmessageWorld = 11007,

        NpcinfoInhabitType = 11008,
        NpcinfoFlagsExtra = 11009,
        InstanceLoginGamemasterException = 11010,

        CreatureNoInteriorPointFound = 11011,
        CreatureMovementNotBounded = 11012,
        CreatureMovementMaybeUnbounded = 11013,
        InstanceBindMismatch = 11014,
        CreatureNotAiEnabled = 11015,
        SelectPlayerOrPet = 11016,
        ShutdownDelayed = 11017,
        ShutdownCancelled = 11018,
        YouChangePower = 11019,
        YourPowerChanged = 11020,
        InvalidPowerName = 11021
    }

    public enum BroadcastTextIds
    {
        AchivementEarned = 29245,
        CallForHelp = 2541,
        FleeForAssist = 1150
    }

    public enum LanguageType
    {
        BasicLatin = 0x00,
        ExtendenLatin = 0x01,
        Cyrillic = 0x02,
        EastAsia = 0x04,
        Any = 0xFFFF
    }
}
