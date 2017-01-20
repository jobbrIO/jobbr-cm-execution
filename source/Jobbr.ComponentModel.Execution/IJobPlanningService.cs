using System;
using System.Collections.Generic;
using Jobbr.ComponentModel.Execution.Model;

namespace Jobbr.ComponentModel.Execution
{
    public interface IJobPlanningService
    {
        List<PlannedJobRun> GetCurrentPlan();

        event EventHandler<EventArgs> OnUpdatedPlan;

        event EventHandler<RequestCancellationEventArgs> OnRequestCancellation;

        event EventHandler<UpdatedJobRunEventArgs> OnUpdatedJobRun;
    }

    public class UpdatedJobRunEventArgs : EventArgs
    {
        public PlannedJobRun JobRun { get; set; }
    }

    public class RequestCancellationEventArgs : EventArgs
    {
        public Guid UniqueId { get; set; }
    }
}
