using System;

namespace Jobbr.ComponentModel.Execution.Model
{
    public class JobRunInfo
    {
        public Guid UniqueId { get; set; }
        public long Id { get; set; }
        public long JobId { get; set; }
        public long TriggerId { get; set; }
        public string Type { get; set; }
        public string UniqueName { get; set; }
    }
}