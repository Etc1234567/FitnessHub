using System.Text.Json;
namespace FitnessHub.Entity;

// this model is used to read the JSON data
public class Workout 
{
    public string? Name {get; set;}
    public string? Force {get; set;}
    public string? Level {get; set;}
    public List<string>? PrimaryMuscles {get; set;}
    public List<string>? SecondaryMuscles {get; set;}
    public List<string>? Instructions {get; set;}
    public string? Category {get; set;}
    public List<string>? Images {get; set;}

}
