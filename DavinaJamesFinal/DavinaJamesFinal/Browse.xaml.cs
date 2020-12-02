using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DavinaJamesFinal.Droid;
namespace DavinaJamesFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Browse : ContentPage
	{
		//Browsing site as a guest
		public Browse()
		{
			InitializeComponent();
			BackgroundColor = Color.AliceBlue;

			//Welcome Labels
			Label WelcomeLabel = new Label();
			WelcomeLabel.Text = "Here are our selections:";
			WelcomeLabel.FontSize = 60;
			WelcomeLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			//List to select which console to browse games for
			Label pick1Label = new Label();
			pick1Label.Text = "Please Select Which Console To Browse Games For:";

			var picker1Prod = new Label();
			Picker picker = new Picker()
			{
				Title = "Console Options",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			var options = new List<string> { "Xbox", "Playstation", "Computer", "Nintendo Switch" };
			foreach (string optionName in options)
			{
				picker.Items.Add(optionName);
			}

			picker.SelectedIndexChanged += (sender, args) =>
			{
				picker1Prod.Text = picker.Items[picker.SelectedIndex];
			};

			//Populate each category (Xbox, Playstation, Computer, Nintendo Switch) with 2-3 games. Games should have a name, price, description, and *photo*

			this.Padding = new Thickness(10, 10, 10, 10);

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{

					WelcomeLabel,
					pick1Label,
					picker,
					//picker1Prod
					 

				}
			};

			Content = new ScrollView
			{
				Content = stack
			};
		}

		//Browing site as a user
		public Browse(Account A1)
		{
			InitializeComponent();
			BackgroundColor = Color.AliceBlue;

			//This section was used to create and insert elements into the games table
			/*
			SQLiteConnection myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

			myDatabase.CreateTable<Games>();

			Games game1 = new Games("Not Mario", "This game is about a contractor not trying to save a princess.", "Nintendo", "E");
			Games game2 = new Games("Lunk", "Some crazy kid with a sword fights an adult that has magic.", "Nintendo", "E");
			Games game3 = new Games("ToyTanfall Two", "You're a green army man that teams up with a lincoln logs mech to fight a dangerous foe.", "Xbox", "M");
			Games game4 = new Games("GoneCall 5", "Trapped behind a mountain range and no way to call out, you must uncover the secret of this new cult.", "Xbox", "M");
			Games game5 = new Games("Only Us 2", "Chase after a group of survivors that took something dear to you.", "Playstation", "M");
			Games game6 = new Games("Joike and Rax", "Follow the adventures of Joike and Rax in this fantastical journey.", "Playstation", "E");
			Games game7 = new Games("Outerareas 2", "Acclaimed sequel to the first Outerareas, this time everything is cranked up past 11 and onto 12.", "Computer", "M");
			Games game8 = new Games("Modern Zone of War Remastered", "Fight the dreaded Meta Huggers in this annual installement of Modern Zone of War", "Computer", "M");

			myDatabase.Insert(game1);
			myDatabase.Insert(game2);
			myDatabase.Insert(game3);
			myDatabase.Insert(game4);
			myDatabase.Insert(game5);
			myDatabase.Insert(game6);
			myDatabase.Insert(game7);
			myDatabase.Insert(game8);
			*/
			//Welcome Labels
			Label WelcomeLabel = new Label();
			WelcomeLabel.Text = "Welcome " + A1.FName + "!";
			WelcomeLabel.FontSize = 60;
			WelcomeLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel.VerticalOptions = LayoutOptions.CenterAndExpand;

			Label WelcomeLabel2 = new Label();
			WelcomeLabel2.Text = "Here are our selections:";
			WelcomeLabel2.FontSize = 60;
			WelcomeLabel2.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			WelcomeLabel2.HorizontalOptions = LayoutOptions.Center;
			WelcomeLabel2.VerticalOptions = LayoutOptions.CenterAndExpand;

			this.Padding = new Thickness(10, 10, 10, 10);

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{

					WelcomeLabel,
					WelcomeLabel2


				}
			};

			Content = new ScrollView
			{
				Content = stack
			};
		}
	}
}