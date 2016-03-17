using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    /// <summary>
    /// Protocol supported by a device
    /// </summary>
    public enum DeviceProtocol
    {
        /// <summary>
        /// Wifi protocol
        /// </summary>
        Wifi = 0,
        /// <summary>
        /// Ethernet protocol
        /// </summary>
        Ethernet = 1,
        /// <summary>
        /// Bluetooth protocol
        /// </summary>
        Bluetooth = 2,
        /// <summary>
        /// Bluetooth Low Energy protocol
        /// </summary>
        BluetoothLE = 3,
        /// <summary>
        /// Zwave protocol
        /// </summary>
        Zwave = 4,
        /// <summary>
        /// EnOcean protocol
        /// </summary>
        EnOcean = 5,
        /// <summary>
        /// AllJoyn protocol
        /// </summary>
        AllJoyn = 6
    }
}