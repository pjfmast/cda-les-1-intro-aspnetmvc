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
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Monday, 10, 0),
                Instructor = "Marcel",
                Location = "Zaal 3"
            },
            new Workout {
                Id = 2,
                Title = "Club power",
                Capacity = 28,
                StartTime = DateTime.Now.NextDayAt(DayOfWeek.Saturday, 10, 0),
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Saturday, 10, 50),
                Instructor = "Laura",
                Location = "Zaal 1"
            },
            new Workout {
                Id = 3,
                Title = "Boksen",
                Capacity = 12,
                StartTime = DateTime.Now.NextDayAt(DayOfWeek.Sunday, 11, 0),
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Sunday, 11, 50),
                Instructor = "Emilio",
                Location = "buiten"
            }
        }.AsQueryable<Workout>();

        public IQueryable<Workout> EnrolledWorkouts(int id) {
            throw new NotImplementedException();
        }
    }
}
