using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class Reporter: WorkflowDTO.Reporter
    {
        public virtual ICollection<AssignmentReporter> Reporters { get; set; }
    }
}
