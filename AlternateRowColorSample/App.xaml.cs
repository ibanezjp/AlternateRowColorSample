﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AlternateRowColorSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            App.Current.Resources.MergedDictionaries.Clear();
            Current.Resources.MergedDictionaries.Add(new DarkTheme());

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
