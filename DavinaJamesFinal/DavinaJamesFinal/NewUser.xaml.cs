using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using SQLite;
using System.Diagnostics;
using DavinaJamesFinal.Droid;


namespace DavinaJamesFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewUser : ContentPage
	{
		public NewUser()
		{
			InitializeComponent();

			//Connection to Database - specifically the Account table
			SQLiteConnection myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
			myDatabase.CreateTable<Account>();
			
			//Creating a new account
			var Account1 = new Account { FName = "", LName = "", Address = "", Card = "", Username = "", Password = "" };
			BackgroundColor = Color.AliceBlue;

			//Labels and Text Entry
			Label WelcomeLabel = new Label();
			WelcomeLabel.Text = "Welcome to Game Palace!";
			WelcomeLabel.FontSize = 75;
			WelcomeLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Label WelcomeLabel2 = new Label();
			WelcomeLabel2.Text = "We appreciate your interest in our site! \nPlease fill out the form below to create your account.";
			WelcomeLabel2.FontSize = 60;
			WelcomeLabel2.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel2.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel2.VerticalOptions = LayoutOptions.CenterAndExpand;

			Label FNameLabel = new Label();
			FNameLabel.Text = "\nPlease your first name:";
			FNameLabel.FontSize = 60;
			FNameLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			FNameLabel.HorizontalOptions = LayoutOptions.Center;
			FNameLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Entry FNameField = new Entry();
			FNameField.Text = "First Name";
			FNameField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			FNameField.HorizontalOptions = LayoutOptions.Start;
			FNameField.VerticalOptions = LayoutOptions.StartAndExpand;

			Label LNameLabel = new Label();
			LNameLabel.Text = "\nPlease enter your last name:";
			LNameLabel.FontSize = 60;
			LNameLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			LNameLabel.HorizontalOptions = LayoutOptions.Center;
			LNameLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Entry LNameField = new Entry();
			LNameField.Text = "Last Name";
			LNameField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			LNameField.HorizontalOptions = LayoutOptions.Start;
			LNameField.VerticalOptions = LayoutOptions.StartAndExpand;

			Label AddressLabel = new Label();
			AddressLabel.Text = "\nPlease enter your shipping address:";
			AddressLabel.FontSize = 60;
			AddressLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			AddressLabel.HorizontalOptions = LayoutOptions.Center;
			AddressLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Entry AddressField = new Entry();
			AddressField.Text = "Address";
			AddressField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			AddressField.HorizontalOptions = LayoutOptions.Start;
			AddressField.VerticalOptions = LayoutOptions.StartAndExpand;

			Label CardLabel = new Label();
			CardLabel.Text = "\nPlease enter your card number(optional):";
			CardLabel.FontSize = 60;
			CardLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			CardLabel.HorizontalOptions = LayoutOptions.Center;
			CardLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Entry CardField = new Entry();
			CardField.Text = "Card #";
			CardField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			CardField.HorizontalOptions = LayoutOptions.Start;
			CardField.VerticalOptions = LayoutOptions.StartAndExpand;

			Label UsernameLabel = new Label();
			UsernameLabel.Text = "\nPlease enter a username.";
			UsernameLabel.FontSize = 60;
			UsernameLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			UsernameLabel.HorizontalOptions = LayoutOptions.Center;
			UsernameLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Entry UsernameField = new Entry();
			UsernameField.Text = "Username";
			UsernameField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			UsernameField.HorizontalOptions = LayoutOptions.Start;
			UsernameField.VerticalOptions = LayoutOptions.StartAndExpand;

			Label PasswordLabel = new Label();
			PasswordLabel.Text = "\nPlease enter a password.";
			PasswordLabel.FontSize = 60;
			PasswordLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			PasswordLabel.HorizontalOptions = LayoutOptions.Center;
			PasswordLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Entry PasswordField = new Entry();
			PasswordField.Text = "Password";
			PasswordField.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			PasswordField.HorizontalOptions = LayoutOptions.Start;
			PasswordField.VerticalOptions = LayoutOptions.StartAndExpand;

			

			//Saving the data to the database
			Button LoginButton = new Button
			{
				Text = "Get Started",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill,

		};

			LoginButton.Clicked += (sender, args) =>
			{
				//Checks every entry to see if there is any text entered
				if (String.IsNullOrWhiteSpace((FNameField.Text)) == true ||
				   String.IsNullOrWhiteSpace((LNameField.Text)) == true ||
				   String.IsNullOrWhiteSpace((AddressField.Text)) == true ||
				   String.IsNullOrWhiteSpace((UsernameField.Text)) == true ||
				   String.IsNullOrWhiteSpace((PasswordField.Text)) == true)
                {
					DisplayAlert("Error", "Please check information entered", "Ok");
                }
				else
				{ 

					//Send information to database
					Account1.FName = FNameField.Text;
					Account1.LName = LNameField.Text;
					Account1.Address = AddressField.Text;
					Account1.Card = CardField.Text.ToString();
					Account1.Username = UsernameField.Text;
					Account1.Password = PasswordField.Text;
					myDatabase.Insert(Account1);

					//Direct to browsing page BUT as a user
					var User = FNameField.Text;
					Navigation.PushAsync(new Browse(User));
				}
			};

			

			this.Padding = new Thickness(10, 10, 10, 10);

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{

					WelcomeLabel,
					WelcomeLabel2,
					FNameLabel,
					FNameField,
					LNameLabel,
					LNameField,
					AddressLabel,
					AddressField,
					CardLabel,
					CardField,
					UsernameLabel,
					UsernameField,
					PasswordLabel,
					PasswordField,
					LoginButton
					


				}
			};

			Content = new ScrollView
			{
				Content = stack
			};
		}
	}
}