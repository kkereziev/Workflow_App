namespace BackEnd.Data
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reporter>()
                .HasIndex(a => a.UserName)
                .IsUnique();

            modelBuilder.Entity<AssignmentReporter>()
                .HasKey(ar => new {ar.AssignmentId, ar.ReportedId});

            modelBuilder.Entity<AssignmentWorker>()
                .HasKey(aw => new {aw.AssignmentId, aw.WorkerId});
        }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Reporter> Reporters { get; set; }
    }
}
