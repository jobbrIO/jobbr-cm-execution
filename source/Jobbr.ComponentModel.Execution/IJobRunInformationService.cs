using System;
using Jobbr.ComponentModel.Execution.Model;

namespace Jobbr.ComponentModel.Execution
{
    public interface IJobRunInformationService
    {
        JobRunInfo GetByUniqueId(Guid uniqueId);

        JobRunInfo GetByJobRunId(long jobRunId);
    }
}
