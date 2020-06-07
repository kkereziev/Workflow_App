namespace BackEnd.Data
{
    using WorkflowDTO;

    public class AssignmentWorker
    {
        public int AssignmentId { get; set; }

        public Assignment Assignment { get; set; }

        public int WorkerId { get; set; }

        public Worker Worker { get; set; }
    }
}
