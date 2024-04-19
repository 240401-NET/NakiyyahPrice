using Microsoft.EntityFrameworkCore;

namespace P1;

public class GunplaDbContext : DbContext
{
    public GunplaDbContext() : base() {}
    public GunplaDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Grade> Grades { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Gunpla> Gunplas { get; set; }


}