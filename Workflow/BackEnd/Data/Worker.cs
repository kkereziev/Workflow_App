
namespace BackEnd.Data
{
    using System.Collections.Generic;

    public class Worker:WorkflowDTO.Worker
    {
        public virtual ICollection<AssignmentWorker> Workers { get; set; } = new List<AssignmentWorker>();
    }
}
