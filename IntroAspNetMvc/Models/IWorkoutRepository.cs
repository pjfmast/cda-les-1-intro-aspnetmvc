namespace IntroAspNetMvc.Models
{
    public interface IWorkoutRepository
    {
        IEnumerable<Workout> AllWorkouts { get; }

    }
}
