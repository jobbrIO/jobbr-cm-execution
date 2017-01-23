using System;
using System.Collections.Generic;
using System.IO;
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

        void PublicArtefact(Guid uniqueId, string fileName, Stream result);
    }
}