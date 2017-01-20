using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobbr.ComponentModel.Execution.Model
{
    public class PlannedJobRun
    {
        public Guid UniqueId { get; set; }

        public DateTime PlannedStartDateTimeUtc { get; set; }
    }
}
