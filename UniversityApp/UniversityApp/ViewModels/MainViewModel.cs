using System.Threading.Tasks;
using UniversityApp.Views;
using Xamarin.Forms;

namespace UniversityApp.ViewModels
{
    public class MainViewModel
    {
        public CoursesViewModel Courses { get; set; }
        public CourseInstructorsViewModel CourseInstructors { get; set; }
        public MoviesViewModel Movies { get; set; }
        public CreateCourseViewModel CreateCourse { get; set; }
        public EditCourseViewModel EditCourse { get; set; }
        public LoginViewModel Login { get; set; }
        public HomeViewModel Home { get; set; }

        public MainViewModel()
        {
            instance = this;

            Courses = new CoursesViewModel();
            CourseInstructors = new CourseInstructorsViewModel();
            CreateCourse = new CreateCourseViewModel();            
            Login = new LoginViewModel();
            Home = new HomeViewModel();            

            //Movies = new MoviesViewModel();

            CreateCourseCommand = new Command(async () => await GoToCreateCourse());
        }

        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
                return new MainViewModel();

            return instance;
        }

        public Command CreateCourseCommand { get; set; }
        async Task GoToCreateCourse()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateCoursePage());
        }
    }
}
