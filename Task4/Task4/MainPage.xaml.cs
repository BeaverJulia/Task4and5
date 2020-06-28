using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Task4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            /*btnSunrise.Clicked += (s, e) => Navigation.PushAsync(new SunrisePage());
            btnMoonPhase.Clicked += (s, e) => Navigation.PushAsync(new MoonPhasePage());
            btnSpaceInfo.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodiesPage());
            btnAbout.Clicked += (s, e) => Navigation.PushAsync(new AboutPage());*/
            InitializeComponent();
            this.Children.Add(new SunrisePage());
            this.Children.Add(new MoonPhasePage());
            this.Children.Add(new AboutPage());
        }
    }

   
}
