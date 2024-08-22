using Microsoft.EntityFrameworkCore;
using FitnessHub.Data;
using FitnessHub.Entity;
using FitnessHub.Services;
using System.Reflection.Metadata;

// This file implements that IExerciseService and behaves similarly to a controller. We will inject this service into our app

public class ExerciseService : IExerciseService
{
    private DataContext _context;

    public ExerciseService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<ExercisePlan>> GetAllExercisePlans()
    {
        List<ExercisePlan> plans = await _context.ExercisePlans.ToListAsync();
        return plans;
    }

    public async Task<ExercisePlan> AddExercisePlan(ExercisePlan exerciseplan)
    {
        _context.Add(exerciseplan);
        await _context.SaveChangesAsync();
        return exerciseplan;
    }

    public async Task<ExercisePlan> GetOneExercisePlan(int id)
    {
        ExercisePlan? OnePlan = await _context.ExercisePlans
                                                            .FirstOrDefaultAsync(p => p.WorkoutId == id);

        return OnePlan;
    }

    public async Task<Exercise> AddExercise(Exercise exercise)
    {
        _context.Add(exercise);
        await _context.SaveChangesAsync();
        return exercise;
    }

    public async Task<List<Exercise>> GetAllExercisesForId(int id)
    {
        List<Exercise> AllExercisesForId = await _context.Exercises
                                                                    .Where(e => e.ExercisePlanId == id)
                                                                    .ToListAsync();
        return AllExercisesForId;
    }
}