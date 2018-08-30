using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class DemoNavigation : ContentPage
    {
       
            private async void BTN1_Clicked(object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new Page2());
            }


        public DemoNavigation()
        {
            InitializeComponent();
        }
    }
}
