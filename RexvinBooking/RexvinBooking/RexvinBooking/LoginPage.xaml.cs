using RexvinBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RexvinBooking
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            //Lbl_Password.TextColor = Constants.MainTextColor;
            //Lbl_Username.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeights;
            Entry_Username.TextColor = Constants.MainTextColor;
            Entry_Password.TextColor = Constants.MainTextColor;
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                Navigation.PushModalAsync(new MainPage());                
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct", "Oke");
            }
        }
	}
}