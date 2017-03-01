using System;

namespace Jobbr.ComponentModel.Execution.Model
{
    public class PlannedJobRun
    {
        public long UniqueId { get; set; }

        public DateTime PlannedStartDateTimeUtc { get; set; }
    }
}
