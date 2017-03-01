using System.IO;
using Jobbr.ComponentModel.Execution.Model;

namespace Jobbr.ComponentModel.Execution
{
    public interface IJobRunProgressChannel
    {
        void PublishStatusUpdate(JobRunInfo jobRunInfo, JobRunStates state);

        void PublishProgressUpdate(JobRunInfo jobRunInfo, double progress);

        void PublishArtefact(long id, string fileName, Stream result);
    }
}