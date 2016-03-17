using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    /// <summary>
    /// Device model
    /// </summary>
    public class Device
    {
        private byte _BatteryLevel;

        /// <summary>
        /// Device identifier
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Device name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Battery level 0-100
        /// </summary>
        public byte BatteryLevel
        {
            get { return _BatteryLevel; }
            set
            {
                if (value == _BatteryLevel)
                    return;
                if (value > 100)
                    return;
                _BatteryLevel = value;
            }
        }
        /// <summary>
        /// Protocol supported by the device
        /// </summary>
        public DeviceProtocol Protocol { get; set; }
    }
}