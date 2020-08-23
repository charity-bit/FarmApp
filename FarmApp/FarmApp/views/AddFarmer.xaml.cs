using FarmApp.viewModel;
using FarmApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FarmApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFarmer : ContentPage
    {       
        public AddFarmer()
        {   InitializeComponent();
            Farmers.ItemsSource = FarmerViewModel.GetFarmers;
           
           
            
          }

      async  private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            await Navigation.PopModalAsync();


        }
    }
}