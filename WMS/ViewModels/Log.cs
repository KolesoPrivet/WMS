﻿using System;

namespace WMS.WinformsClient.ViewModels
{
    public class Log
    {
        public DateTime EventLogTime { get; set; }

        public Level LevelType { get; set; }

        public string Description { get; set; }
    }

    public enum Level
    {
        Critical,
        Error,
        Attention,
        Success,
        Info
    }
}
