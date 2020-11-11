using Newtonsoft.Json;

namespace UniversityApp.BL.DTOs
{
    public class CourseDTO
    {
        [JsonProperty("CourseID")]
        public long CourseID { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Credits")]
        public long Credits { get; set; }
    }
}
