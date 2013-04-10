﻿#region Copyright (C) 2007-2013 ARGUS TV
/*
 *	Copyright (C) 2007-2013 ARGUS TV
 *	http://www.argus-tv.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace ArgusTV.UI.MediaPortal
{
    #region Enums

    internal enum TextId
    {
        // ARGUS TV strings
        AbortThisRecording = 49200,
        ActiveRecordings = 49201,
        AreYouSure = 49202,
        CancelThisShow = 49203,
        ChangeChannelGroup = 49204,
        Default = 49205,
        DeleteEntireSchedule = 49206,
        DeleteThisSchedule = 49208,
        DontRecord = 49209,
        Error = 49210,
        GroupByCategory = 49211,
        GroupByChannel = 49212,
        GroupBySchedule = 49213,
        GroupByTitle = 49214,
        High = 49215,
        Highest = 49216,
        Information = 49217,
        Keep = 49218,
        Low = 49219,
        MinutesSuffix = 49220,
        MinuteSuffix = 49221,
        NoChannels = 49222,
        OnlyNewEpisodes = 49224,
        PostRecord = 49225,
        PreRecord = 49226,
        Priority = 49227,
        Record = 49228,
        RecordedSuffix = 49229,
        RecordedTv = 49230,
        RecordingInProgress = 49235,
        RecordingsGroupNameRecordings = 49236,
        RecordingsListItemsSuffix = 49237,
        ResetToSchedulePriority = 49241,
        Schedules = 49242,
        SearchGuide = 49243,
        SelectScheduleType = 49244,
        TvGuide = 49245,
        UncancelThisShow = 49246,
        UpcomingPrograms = 49247,
        UpcomingRecordings = 49248,
        UpcomingTypeAlerts = 49249,
        UpcomingTypeRecordings = 49250,
        UpcomingTypeSuggestions = 49251,
        VeryHigh = 49252,
        VeryLow = 49253,
        ThisProgramIsAlreadyQueued = 49254,
        ForRecordingAtAnEarlierTime = 49255,
        ThisProgramWasPreviouslyRecorded = 49256,
        RadioGuide = 49257,
        RecordedRadio = 49258,
        RadioOn = 49259,
        NoFreeCardFound = 49260,
        ChannelTuneFailed = 49261,
        NotSupported = 49262,
        NoRetunePossible = 49263,
        IsScrambled = 49264,
        UnknownError = 49265,
        RecordingDiskAlmostFull = 49266,
        FromDate = 49267,
        OnDate = 49268,
        SelectDays = 49269,
        GroupByScheduleSelect = 49270,
        GroupByRecordingDay = 49271,
        SearchOnTitle = 49272,
        SearchOnDescription = 49273,
        SearchOnProgramInfo = 49274,
        SearchOnActor = 49275,
        SearchOnDirectedBy = 49276,
        All = 49277,
        Channels = 49278,
        Categories = 49279,
        SelectGroup = 49280,
        SelectChannel = 49281,
        SelectCategorie = 49282,
        NoMoreChannelsToAdd = 49283,
        NoMoreCategoriesToAdd = 49284,
        AlsoDeleteChannelAndCategorie = 49285,
        NoValidSearchText = 49286,
        ContinueWithPrevResults = 49287,
        Attention = 49288,
        RenameShedule = 49289,
        SatellitePosition = 49290,
        Modulation = 49291,
        Encrypted = 49292,
        Polarisation = 49293,
        Frequency = 49294,
        Provider = 49295,
        Type = 49296,
        SignalLevel = 49297,
        SignalQuality = 49298,
        Channel = 49299,
        AudioType = 49300,
        AudioLanguage = 49301,
        VideoResolution = 49302,
        Bandwidth = 49303,
        TransmissionMode = 49304,
        StreamingMode = 49305,
        CurrentSubtitle = 49306,
        AllWatched = 49307,
        AllInvalid = 49308,
        AllInvalidAndWatched = 49309,
        WatchedInThisFolder = 49310,
        Cancel = 49311,
        EveryDayAtThisTime = 49312,
        EverytimeOnEveryChannel = 49313,
        EverytimeOnThisChannel = 49314,
        EveryWeekAtThisTime = 49315,
        Once = 49316,
        MonFri = 49317,
        SatSun = 49318,
        DeleteProgram = 49319,
        CancelThisSchedule = 49320,
        UnCancelThisSchedule = 49321,
        Daily = 49322,
        AlwaysThisChannel = 49323,
        AlwaysEveryChannel = 49324,
        Weekly = 49325,
        Value = 49326,
        ChannelsInGroup = 49327,
        ChannelsNotInGroup = 49328,
        NewGroup = 49329,
        ChannelGroups = 49330,
        SelectThisGroup = 49331,
        DeleteThisGroup = 49332,
        HideFromGuide = 49333,
        ShowInGuide = 49334,
        GuideChannel = 49335,
        None = 49336,
        AddToGroup = 49337,
        MoveChannel = 49338,
        DeleteChannel = 49339,
        DeleteChannelFromGroup = 49340,
        SelectGuideChannel = 49341,
        Television = 49342,
        Radio = 49343,
        PreferAC3 = 49344,
        DVBSubtitles = 49345,
        TXTSubtitles = 49346,
        HideAllChannelsGroup = 49347,
        ShowChannelNrInGuide = 49348,
        RecordingNotifications = 49349,
        AutoFullscreen = 49350,
        OnlySleepOnHome = 49351,
        RTSPForRec = 49352,
        RTSPForTv = 49353,
        AutoSelectRTSP = 49354,
        WolTimeout = 49355,
        EnableWol = 49356,
        ClientSettingsInfo = 49357,
        TestConnection = 49358,
        ConnectionSucceeded = 49359,
        ConnectionFailed = 49360,
        RecommendedToRestartMP = 49361,
        RestartMPNow = 49362,
        RecommendedToStopPlayback = 49363,
        StopPlayBackNow = 49364,
        PreferedEPGSource = 49365,
        DeleteAllGuideData = 49366,
        RestoreDefaults = 49367,
        FreeDiskSpace = 49368,
        MinFreeDiskSpace = 49369,
        DefaultPreRec = 49370,
        DefaultPostRec = 49371,
        RecThumbs = 49372,
        MetaDataForRec = 49373,
        ShowLogs = 49374,
        ServerSettingsInfo = 49375,
        UntilSpaceNeeded = 49376,
        NumberOfDays = 49377,
        NumberOfEpisodes = 49378,
        NumberOfWatchedEpisodes = 49379,
        Forever = 49380,
        DefaultKeepMode = 49381,
        DefaultKeepValue = 49382,
        ChannelManagmentInfo = 49383,
        ArgusClientSettings = 49384,
        ArgusServerSettings = 49385,
        ChannelManager = 49386,
        RadioScheduler = 49387,
        RadioGuideSearch = 49388,
        Port = 49389,
        Server = 49390,

        // MediaPortal strings
        LayoutIcons = 100,
        LayoutList = 101,
        SortByTitle = 268,
        Manual = 413,
        AudioStream = 460,
        Active = 461,
        Subtitle = 462,
        SubtitlesOff = 519,
        MyTv= 605,
        SortByChannel = 620,
        SortByDate = 621,
        DeleteThisRecording = 653,
        Mon = 657,
        Tue = 658,
        Wed = 659,
        Thu = 660,
        Fri = 661,
        Sat = 662,
        Sun = 663,
        SortByType = 668,
        SortByGenre = 669,
        SortByBitRate = 670,
        SortByWatched = 671,
        Times = 677,
        NoDataAvailable = 736,
        NoProgrammesFound = 769,
        Now = 789,
        Next = 790,
        DeleteUnwatchedRecording = 820,
        CurrentProgram = 875,
        UntilManualStop = 876,
        ResumeMovieFromLastTime = 900,
        ResumeFrom = 936,
        Stretch = 942,
        Normal = 943,
        Original = 944,
        Letterbox4over3 = 945,
        PanAndScan = 946,
        Zoom = 947,
        Group = 971,
        AllChannels = 972,
        SortByDuration = 1017,
        NoSignalDetected = 1034,
        TvChannelIsScrambled = 1035,
        NoVideoFound = 1036,
        Recording = 1054,
        Timeshifting = 1055,
        Unavailable = 1056,
        Zoom14over9 = 1190,
        RecordingStarted = 1446,
        RecordingStopped = 1447,
        StopRecording = 1449,
        Unknown = 2014,
        Hour = 3001,
        Hours = 3002,
        Minute = 3003,
        Minutes = 3004,
        HourAgo = 3005,
        HoursAgo = 3006,
        MinuteAgo = 3007,
        MinutesAgo = 3008,
        StartsIn = 3009,
        MinutesRemaining = 3010,
        HourRemaining = 3011,
        HoursRemaining = 3012,
        StartingNow = 3013,
        Day = 3014,
        Days = 3015,
        AlreadyEnded = 3016,
        Started = 3017,
        Teletext = 1441,
        NoActiveRecordings = 200053,
        SetReminder = 1040,
        CancelReminder = 1212,
        Settings = 1048,
        UnavailableText = 161,
        Off = 474,
        Yes = 200031,
        No = 200032,
        TVScheduler = 100601,
        TVGuideSearch = 100604,
    }

    #endregion
}
