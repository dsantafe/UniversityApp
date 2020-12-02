using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UniversityApp.BL.DTOs;
using UniversityApp.BL.Services.Implements;
using UniversityApp.Helpers;
using Xamarin.Forms;

namespace UniversityApp.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
        private BL.Services.IStudentService studentService;
        private ObservableCollection<StudentDTO> students;
        private bool isRefreshing;
        private CourseDTO course;

        public CourseDTO Course
        {
            get { return this.course; }
            set { this.SetValue(ref this.course, value); }
        }

        public ObservableCollection<StudentDTO> Students
        {
            get { return this.students; }
            set { this.SetValue(ref this.students, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }

        public StudentsViewModel(CourseDTO course)
        {
            this.course = course;

            this.studentService = new StudentService();
            this.RefreshCommand = new Command(async () => await GetStudentsByCourse());
            this.RefreshCommand.Execute(null);
        }
        
        public Command RefreshCommand { get; set; }

        async Task GetStudentsByCourse()
        {
            try
            {
                this.IsRefreshing = true;

                var connection = await studentService.CheckConnection();
                if (!connection)
                {
                    this.IsRefreshing = false;
                    await Application.Current.MainPage.DisplayAlert("Error", "No internet connection", "Cancel");
                    return;
                }

                var listStudents = await studentService.GetAll(Endpoints.GET_STUDENTS_BY_COURSE + this.course.CourseID);                
                this.Students = new ObservableCollection<StudentDTO>(listStudents);
                this.IsRefreshing = false;
            }
            catch (Exception ex)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Cancel");
            }
        }
    }
}
