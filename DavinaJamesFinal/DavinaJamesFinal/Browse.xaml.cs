using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
		public Browse(string x)
		{
			InitializeComponent();
			BackgroundColor = Color.AliceBlue;

			//Welcome Labels
			Label WelcomeLabel = new Label();
			WelcomeLabel.Text = "Welcome " + x + "!";
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