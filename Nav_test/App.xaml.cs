using System;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nav_test
{
    public partial class App : Application
    {
        public App() {
            InitializeComponent();

            var abp = new AppBootStrapper();
            MainPage = abp.CreateMainPage();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
