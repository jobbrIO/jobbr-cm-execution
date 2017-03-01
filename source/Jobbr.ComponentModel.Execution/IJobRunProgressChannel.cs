using System;
using System.IO;
using Jobbr.ComponentModel.Execution.Model;

namespace Jobbr.ComponentModel.Execution
{
    public interface IJobRunProgressChannel
    {
        void PublishStatusUpdate(JobRunInfo jobRunInfo, JobRunStates state);

        void PublishProgressUpdate(JobRunInfo jobRunInfo, double progress);

        // TODO: Rename
        void PublicArtefact(Guid uniqueId, string fileName, Stream result);
    }
}