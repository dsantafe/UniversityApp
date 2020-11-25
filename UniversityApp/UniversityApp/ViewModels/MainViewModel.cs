namespace UniversityApp.ViewModels
{
    public class MainViewModel
    {
        public CoursesViewModel Courses { get; set; }
        public CourseInstructorsViewModel CourseInstructors { get; set; }
        public MoviesViewModel Movies { get; set; }
        public CreateCourseViewModel CreateCourse { get; set; }
        public LoginViewModel Login { get; set; }
        public HomeViewModel Home { get; set; }

        public MainViewModel()
        {
            Courses = new CoursesViewModel();
            CourseInstructors = new CourseInstructorsViewModel();
            CreateCourse = new CreateCourseViewModel();
            Login = new LoginViewModel();
            Home = new HomeViewModel();

            //Movies = new MoviesViewModel();
        }
    }
}
