using IntroAspNetMvc.Infrastructure;

namespace IntroAspNetMvc.Models
{
    public class FakeWorkoutRepository : IWorkoutRepository
    {
        public IEnumerable<Workout> AllWorkouts => new List<Workout> {
            new Workout {
                Id = 1,
                Title = "Yin Yoga",
                Capacity = 15,
                StartTime = DateTime.Now.NextDayAt(DayOfWeek.Monday, 9, 15),
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Monday, 10, 0)
            },
            new Workout {
                Id = 2,
                Title = "Club power",
                Capacity = 20,
                StartTime = DateTime.Now.NextDayAt(DayOfWeek.Saturday, 10, 0),
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Saturday, 10, 50)
            }
        }.AsQueryable<Workout>();

        public IQueryable<Workout> EnrolledWorkouts(int id) {
            throw new NotImplementedException();
        }
    }
}
