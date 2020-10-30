using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeServer.Models
{
    public class Room
    {
        public long RoomID { get; set; }
        public string RoomName { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
