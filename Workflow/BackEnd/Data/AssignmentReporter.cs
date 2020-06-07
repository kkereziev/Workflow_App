using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowDTO;

namespace BackEnd.Data
{
    public class AssignmentReporter
    {
        public int AssignmentId { get; set; }

        public Assignment Assignment { get; set; }

        public int ReportedId { get; set; }

        public Reporter Reporter { get; set; }
    }
}
