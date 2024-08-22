using Microsoft.EntityFrameworkCore;
using FitnessHub.Entity;
namespace FitnessHub.Data;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions options) : base(options){}
    public DbSet<ExercisePlan> ExercisePlans {get; set;}
    public DbSet<Exercise> Exercises {get; set;}
}




