using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RexvinBooking
{
	public partial class MainPage : ContentPage
	{
		void Icon1_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page1();
            PlaceHolder.Content = page.Content;
        }

        void Icon2_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page2();
            PlaceHolder.Content = page.Content;
        }

        void Icon3_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page3();
            PlaceHolder.Content = page.Content;
        }

        void Icon4_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page4();
            PlaceHolder.Content = page.Content;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
