using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobbr.ComponentModel.Execution.Model;

namespace Jobbr.ComponentModel.Execution
{
    public interface IJobRunProgressChannel
    {
        void PublishStatusUpdate(JobRunInfo jobRunInfo, JobRunStates state);

        void PublishProgressUpdate(JobRunInfo jobRunInfo, double progress);
    }
}