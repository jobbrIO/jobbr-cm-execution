using System.IO;
using Jobbr.ComponentModel.Execution.Model;

namespace Jobbr.ComponentModel.Execution
{
    /// <summary>
    /// IJobRunProgressChannel is implemented by the Server. Job Executors report progress
    /// of jobs via this interface to the server.
    /// </summary>
    public interface IJobRunProgressChannel
    {
        void PublishStatusUpdate(JobRunInfo jobRunInfo, JobRunStates state);

        void PublishProgressUpdate(JobRunInfo jobRunInfo, double progress);

        void PublishArtefact(long id, string fileName, Stream result);
    }
}