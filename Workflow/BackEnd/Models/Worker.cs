namespace BackEnd.Models
{
    using System.ComponentModel.DataAnnotations;
    using Interfaces;

    public class Worker:IWorker
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(4000)]
        public string Bio { get; set; }

        public Team TeamId { get; set; }

        [StringLength(200)]
        public string Username { get; set; }
    }
}
