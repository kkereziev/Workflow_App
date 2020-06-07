using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class Assignment :WorkflowDTO.Assignment
    {
        public virtual ICollection<AssignmentWorker> Workers { get; set; }

        public virtual ICollection<AssignmentReporter> Reporters { get; set; }

        public Priority Priority { get; set; }
    }
}
