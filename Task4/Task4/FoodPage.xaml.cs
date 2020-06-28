using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage : ContentPage
    {
        public FoodPage()
        {
            InitializeComponent();
        }
        async void OnRestaurantsClicked(object sender, EventArgs e)
        {
            var destination = new RestaurantsPage();
            await this.Navigation.PushAsync(destination);
           
        }
       
        async void OnCancelClicked(object sender, EventArgs e)
        {
           
            await this.Navigation.PopAsync();
        }
    }
}