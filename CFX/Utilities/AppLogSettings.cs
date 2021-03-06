﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Utilities
{
    public class AppLogSettings
    {
        public AppLogSettings()
        {
            LoggingEnabled = true;
            LogFilePath = null;
            LoggingLevel = LogMessageType.Error | LogMessageType.Info;
            AmqpTraceEnabled = false;
        }

        public bool LoggingEnabled
        {
            get;
            set;
        }

        public string LogFilePath
        {
            get;
            set;
        }

        public LogMessageType LoggingLevel
        {
            get;
            set;
        }

        public bool AmqpTraceEnabled
        {
            get;
            set;
        }
    }
}
