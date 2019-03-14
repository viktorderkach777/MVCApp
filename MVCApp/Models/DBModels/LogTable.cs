using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp
{
    public class LogTable
    {
        public int Id { get; set; }

        public string ActionName { get; set; }

        public DateTime StartTime { get; set; }

        public TimeSpan ActionRunningTime { get; set; }

        public TimeSpan ViewRenderingTime { get; set; }

        public string GetPostName { get; set; }
    }
}