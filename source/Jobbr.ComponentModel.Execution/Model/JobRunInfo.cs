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
        public long? UserId { get; set; }
        public string Username { get; set; }
        public string JobParameters { get; set; }
        public string InstanceParameters { get; set; }
    }
}