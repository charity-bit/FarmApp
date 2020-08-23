using System;
using System.Collections.Generic;
using System.Text;

using FarmApp.Model;

namespace FarmApp.viewModel
{
   public class FarmerViewModel
    {

        public static List<Farmer> GetFarmers { get; set; } = new List<Farmer>();


        public FarmerViewModel()
        {
            GetFarmers = new List<Farmer>
             {
                new Farmer { FarmerName="Rainy Gandhi",FarmerID=125211,Status="Approved",StatusColor="Green"},
                new Farmer { FarmerName="Rainy Gandhi",FarmerID=125211,Status="Pending",StatusColor="Red"},
                new Farmer { FarmerName="Rainy Gandhi",FarmerID=125211,Status="Approved",StatusColor="Green" },
                new Farmer {  FarmerName="Rainy Gandhi",FarmerID=125211,Status="Pending",StatusColor="Red"},
                new Farmer {  FarmerName="Rainy Gandhi",FarmerID=125211,Status="Pending",StatusColor="Red"},

            };
         }



        

    }
}
