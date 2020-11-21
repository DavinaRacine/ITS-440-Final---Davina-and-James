using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DavinaJamesFinal
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BackgroundColor = Color.AliceBlue;

			//Welcome Label
			Label WelcomeLabel = new Label();
			WelcomeLabel.Text = "Welcome To Game Palace";
			WelcomeLabel.FontSize = 60;
			WelcomeLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			//Directs to Login page (Login.xaml.cs)
			Button LoginButton = new Button
			{
				Text = "Login",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill

			};

			LoginButton.Clicked += (sender, args) =>
			{
				Navigation.PushAsync(new Login());

			};

			//Directs to New User page/account creation (NewUser.xaml.cs)
			Button NewUserButton = new Button
			{
				Text = "Create An Account",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill

			};

			NewUserButton.Clicked += (sender, args) =>
			{
				Navigation.PushAsync(new NewUser());

			};

			//Directs to Browse page (Browse.xaml.cs)
			Button BrowseButton = new Button
			{
				Text = "Browse Selections as Guest",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill

			};

			BrowseButton.Clicked += (sender, args) =>
			{
				//This specifically sends the user to the browse page with no account needed/linked, however they cannot check out items or add the items to a cart.
				//The login page (Login.xaml.cs) is where users need to login then they are directed to the browse page (after their account is validated). They are able to purchase and add things to cart.

				Navigation.PushAsync(new Browse());

			};

			this.Padding = new Thickness(10, 10, 10, 10);

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{

					WelcomeLabel,
					 LoginButton,
					 NewUserButton,
					 BrowseButton


				}
			};

			Content = new ScrollView
			{
				Content = stack
			};
		}
	}
}
