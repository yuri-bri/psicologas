using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appensayo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());

        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Informacion", "dudas contenido demamas cosas blalbalblalblalblabllabaalvllavlalvalv kfdbdfnbk fdbgdfbgdf df gbdf gbdf gbdf gb df bd f bdf g df g", "ok");

        }
    }
}