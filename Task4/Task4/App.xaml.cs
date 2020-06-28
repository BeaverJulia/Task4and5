using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*
            var homePage = new HomePage();
            var navPage = new NavigationPage(homePage);
            this.MainPage = navPage;*/
            MainPage = new NavigationPage(new MainPage());
            var tabbedPage = new TabbedPage();

            tabbedPage.Children.Add(new GlobePage());
            tabbedPage.Children.Add(new CompassPage());
            tabbedPage.Children.Add(new MapPage());

            MainPage = tabbedPage;
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

    /*internal class MapPage : Page
    {
    }

    public class CompassPage : Page
    {
    }*/
}
