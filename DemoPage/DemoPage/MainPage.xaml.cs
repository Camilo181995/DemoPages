using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoPage
{
    public partial class MainPage : ContentPage
    {
        void BTN1_Clicked(object sender, System.EventArgs e)
        {
            Panel.Children.Add(new Button()
            {
                Text = $"Boton{Panel.Children.Count + 1}"
            });
        }

        public MainPage()

        {
            InitializeComponent();
        }


    }
}
