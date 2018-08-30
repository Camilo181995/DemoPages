using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Page4 : ContentPage
    {
        void BtnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }


        public Page4()
        {
            InitializeComponent();
            btnCerrar.Clicked+= BtnCerrar_Clicked;
        }
    }
}
