using System;

namespace Jobbr.ComponentModel.Execution
{
    /// <summary>
    /// The JobStarter interface.
    /// </summary>
    public interface IJobExecutor : IDisposable
    {
        void Start();

        void Stop();
    }
}