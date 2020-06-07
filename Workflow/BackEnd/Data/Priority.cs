using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class Priority:WorkflowDTO.Priority
    {
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
