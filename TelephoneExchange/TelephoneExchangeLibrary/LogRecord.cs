using System;

namespace TelephoneExchangeLibrary
{
    public struct LogRecord
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int FromNumber { get; set; }
        public int ToNumber { get; set; }
    }
}
