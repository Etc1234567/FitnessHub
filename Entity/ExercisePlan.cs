using System.ComponentModel.DataAnnotations;
namespace FitnessHub.Entity;

// this model is used to read the JSON data
public class ExercisePlan 
{
    [Key]
    public int WorkoutId {get; set;}

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public string? Category {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //Nav prop
    public List<Exercise> Exercises {get; set;} = new List<Exercise>();
}
