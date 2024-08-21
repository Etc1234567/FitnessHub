using Microsoft.EntityFrameworkCore;
using FitnessHub.Entity;
namespace FitnessHub.Data;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions options) : base(options){}
    public DbSet<Workout> Workouts {get; set;}
}




