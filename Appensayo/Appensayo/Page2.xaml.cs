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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Page1());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Informacion", "dudas contenido demamas cosas blalbalblalblalblabllabaalvllavlalvalv kfdbdfnbk fdbgdfbgdf df gbdf gbdf gbdf gb df bd f bdf g df g", "ok");

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Acerca de", "informacion blalbalblalblalblabllabaalvllavlalvalv kfdbdfnbk fdbgdfbgdf df gbdf gbdf gbdf gb df bd f bdf g df g", "ok");

        }
    }
}