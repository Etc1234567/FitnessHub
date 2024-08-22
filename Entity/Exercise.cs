using System.ComponentModel.DataAnnotations;
namespace FitnessHub.Entity;

// this model is used to link exercises to exercise plan
public class Exercise 
{
    [Key]
    public int MoveId {get; set;}
    public string? Name {get; set;}

    public int NumSets {get; set;}

    public int NumReps {get; set;}

    public bool Warmup {get; set;}

    public int Weight {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // fk and nav props

    public int ExercisePlanId { get; set; }

    public ExercisePlan? ExercisePlan { get; set; }

}