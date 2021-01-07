using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeServer.Models
{
    public class DataEntity
    {
        public long GatewayID { get; set; }
        public long DeviceID { get; set; }
        public int Value { get; set; }
        public dynamic Unit { get; set; }
        public bool Enabled { get; set; }
    }
}
