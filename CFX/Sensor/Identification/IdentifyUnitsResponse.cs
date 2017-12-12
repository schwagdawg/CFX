﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Sensor.Identification
{
    public class IdentifyUnitsResponse
    {
        public IdentifyUnitsResponse()
        {
            Units = new List<UnitPosition>();
            Result = new RequestResult();
        }

        public RequestResult Result
        {
            get;
            private set;
        }

        /// <summary>
        /// The barcode, RFID, etc. that was most recently acquired by the scanner / reader.  If a single production unit is moving through the
        /// process, this would be the actual unique identifier of that individual unition unit.  However, if multiple production units are moving
        /// through the process as a group (as in the case of a PCB panel, a fixture, or any sort of carrier), this would be an identifier that
        /// represents the entire group of units, such as a carrier UID, a PCB panel UID, etc.
        /// </summary>
        public string PrimaryIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// An optional list of actual production unit identifiers, in the case that multiple production units are moving through the 
        /// process, and the sensor is capable if reading multiple identifiers. 
        /// </summary>
        public List<UnitPosition> Units
        {
            get;
            private set;
        }
    }
}
