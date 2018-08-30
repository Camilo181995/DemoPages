using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Page2 : ContentPage
    {

        public Page2()
        {
            InitializeComponent();
        }
        private async void btntres_Clicked(object sender ,EventArgs e)
        {
            this.lbOption.Text = string.Empty;
            await Navigation.PushAsync(new Page3());
        }
        private void btnTest_Clicked(object sender,EventArgs e)
        {
            this.lbOption.Text = string.Empty;
           
        }
    }
}
