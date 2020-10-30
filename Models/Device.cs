using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeServer.Models
{
    public class Device
    {
        public long DeviceID { get; set; }
        public string DeviceName { get; set; }
        public bool Enabled { get; set; }
        public int RoomID { get; set; }
        public Room Room { get; set; }
    }
}
