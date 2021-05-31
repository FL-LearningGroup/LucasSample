using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetConfiguration
{
    public class TransientFaultHandlingOptions
    {
        public bool Enabled { get; set; }
        public TimeSpan AutoRetryDelay { get; set; }
    }
}
