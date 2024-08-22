using System.Reflection.Metadata;
using FitnessHub.Entity;

namespace FitnessHub.Services;

//This file sets up a service to interact with DB, then ExerciseService implements that
public interface IExerciseService
{
    Task<List<ExercisePlan>> GetAllExercisePlans();
    Task<ExercisePlan> AddExercisePlan(ExercisePlan exerciseplan);

    Task<ExercisePlan> GetOneExercisePlan(int id);

    Task<Exercise> AddExercise(Exercise exercise);

    Task<List<Exercise>> GetAllExercisesForId(int id);
}