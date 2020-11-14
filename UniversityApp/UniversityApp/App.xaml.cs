﻿using UniversityApp.Views;
using Xamarin.Forms;

namespace UniversityApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MoviesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
