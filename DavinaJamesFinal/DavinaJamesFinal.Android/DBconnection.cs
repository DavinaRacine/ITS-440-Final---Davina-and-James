using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SQLite;
using System.IO;
using Xamarin.Forms;
using DavinaJamesFinal.Droid;

[assembly: Dependency(typeof(DBconnection))]
namespace DavinaJamesFinal.Droid
{
	public class DBconnection : IDatabase
	{
		public DBconnection()
		{

		}

		public SQLiteConnection ConnectToDB()
		{
			//Going to work with name "TrialFileX" for now
			var filename = "TrialFile1.db3";
			string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(folder, filename);
			var connection = new SQLiteConnection(path);
			return connection;
		}
	}
}