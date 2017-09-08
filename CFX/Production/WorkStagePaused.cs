﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFX.Production
{
    public class WorkStagePaused : CFXMessage
    {
        public Guid TransactionID
        {
            get;
            set;
        }

        public string Stage
        {
            get;
            set;
        }
    }
}