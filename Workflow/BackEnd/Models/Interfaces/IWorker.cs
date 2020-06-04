namespace BackEnd.Models.Interfaces
{
    interface IWorker
    {
        int Id { get; set; }
        
       
        string Name { get; set; }

        
        string Bio { get; set; }

        Team TeamId { get; set; }

        
        string Username { get; set; }
    }
}
