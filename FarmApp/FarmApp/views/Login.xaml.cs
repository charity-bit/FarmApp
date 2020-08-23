using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FarmApp.views
{
    
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

       async  private void Forget_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Verify());
        }

      async  private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Home());
        }
    }
}