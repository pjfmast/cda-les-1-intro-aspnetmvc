using System.Text.Json;

namespace IntroAspNetMvc.Models
{
    public class JsonWorkoutRepository : IWorkoutRepository
    {
        IEnumerable<Workout> IWorkoutRepository.AllWorkouts
            => LoadJson().AsQueryable();


        public IEnumerable<Workout> EnrolledWorkouts(int id) {
            throw new NotImplementedException();
        }

        // to convert from Newtonsoft.Json, see:
        // https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-migrate-from-newtonsoft-how-to?pivots=dotnet-6-0
        private IList<Workout> LoadJson() {
            using (StreamReader r = new StreamReader("Workouts.json")) {
                string json = r.ReadToEnd();

                var options = new JsonSerializerOptions {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    PropertyNameCaseInsensitive = true,
                };
                List<Workout>? items = JsonSerializer.Deserialize<List<Workout>>(json, options);
                return items ?? new List<Workout>();
            }
        }
    }
}
