using System.Collections.Generic;
using Xamarin.Forms;

namespace FeatureApp
{
    public partial class App : Application
    {
        internal static FeatureApp.Helpers.AnimateObject ViewAnimation;
        public App()
        {
            ViewAnimation = new Helpers.AnimateObject();
            InitializeComponent();
            Xamarin.Forms.Device.SetFlags(new List<string>() {
                "StateTriggers_Experimental",
                "IndicatorView_Experimental",
                "CarouselView_Experimental",
                "MediaElement_Experimental"
            });
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
