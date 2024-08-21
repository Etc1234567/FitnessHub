using System.Text.Json;
namespace FitnessHub.Entity;

public class Workout 
{
    // public int WorkoutId {get; set;}
    public string? Name {get; set;}
    public string? Force {get; set;}
    public string? Level {get; set;}
    public List<string>? PrimaryMuscles {get; set;}
    public List<string>? SecondaryMuscles {get; set;}
    public List<string>? Instructions {get; set;}
    public string? Category {get; set;}
    public List<string>? Images {get; set;}

}
