using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeServer.Models
{
    public class Device
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsUsed { get; set; }
    }
}
