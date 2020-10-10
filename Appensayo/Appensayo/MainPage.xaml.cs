using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Appensayo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Acerca de", "informacion blalbalblalblalblabllabaalvllavlalvalv kfdbdfnbk fdbgdfbgdf df gbdf gbdf gbdf gb df bd f bdf g df g", "ok");


        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
