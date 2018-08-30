using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Page3 : ContentPage
    {
        private async void Btn_Inicio(object sender,System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void Btn_Atras(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Btn_Modal(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4());
        }
        public Page3()
        {
            InitializeComponent();
        }
    }
}
