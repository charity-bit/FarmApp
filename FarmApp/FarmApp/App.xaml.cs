using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using FarmApp.views;

namespace FarmApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            Device.SetFlags(new String[] {"Shapes_Experimental" });
            MainPage = new NavigationPage(new Login());
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
