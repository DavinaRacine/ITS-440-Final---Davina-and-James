using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using SQLite;
using DavinaJamesFinal.Droid;

namespace DavinaJamesFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();

			//Connection to Database - specifically the Account table *MAY NOT BE CORRECT*
			SQLiteConnection myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
			myDatabase.Table<Account>();

			BackgroundColor = Color.AliceBlue;

			//Labels and Text Entry
			Label WelcomeLabel = new Label();
			WelcomeLabel.Text = "Welcome Back!";
			WelcomeLabel.FontSize = 60;
			WelcomeLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Label UsernameLabel = new Label();
			UsernameLabel.Text = "Username:";
			UsernameLabel.FontSize = 60;
			UsernameLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			UsernameLabel.HorizontalOptions = LayoutOptions.Start;
			UsernameLabel.VerticalOptions = LayoutOptions.StartAndExpand;

			Entry UsernameField = new Entry();
			UsernameField.Text = "Username";
			UsernameField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			UsernameField.HorizontalOptions = LayoutOptions.Start;
			UsernameField.VerticalOptions = LayoutOptions.StartAndExpand;

			Label PasswordLabel = new Label();
			PasswordLabel.Text = "Password:";
			PasswordLabel.FontSize = 60;
			PasswordLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			PasswordLabel.HorizontalOptions = LayoutOptions.Start;
			PasswordLabel.VerticalOptions = LayoutOptions.StartAndExpand;

			Entry PasswordField = new Entry();
			PasswordField.Text = "Password";
			PasswordField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			PasswordField.HorizontalOptions = LayoutOptions.Start;
			PasswordField.VerticalOptions = LayoutOptions.StartAndExpand;

			//Logging in to the site. *Account has to be validated by Account table in database*
			Button SubmitButton = new Button
			{
				Text = "Login",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill

			};

			SubmitButton.Clicked += (sender, args) =>
			{
				//MUST CHECK TO MAKE SURE NAME AND PASSWORD ARE IN DATABASE TO CONTINUE, NEED AN "IF STATEMENT"
				var User = UsernameField.Text;
				Navigation.PushAsync(new Browse(User));

			};

			this.Padding = new Thickness(10, 10, 10, 10);

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{

					WelcomeLabel,
					UsernameLabel,
					UsernameField,
					PasswordLabel,
					PasswordField,
					SubmitButton


				}
			};

			Content = new ScrollView
			{
				Content = stack
			};
		}
	}
}