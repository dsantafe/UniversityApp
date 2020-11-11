namespace UniversityApp.ViewModels
{
    public class MainViewModel
    {
        public CoursesViewModel Courses { get; set; }
        public CourseInstructorsViewModel CourseInstructors { get; set; }

        public MainViewModel()
        {
            Courses = new CoursesViewModel();
            CourseInstructors = new CourseInstructorsViewModel();
        }
    }
}
