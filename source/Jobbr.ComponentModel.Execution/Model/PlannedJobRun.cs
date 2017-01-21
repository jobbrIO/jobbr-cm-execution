using System;

namespace Jobbr.ComponentModel.Execution.Model
{
    public class PlannedJobRun
    {
        public Guid UniqueId { get; set; }

        public DateTime PlannedStartDateTimeUtc { get; set; }
    }
}
