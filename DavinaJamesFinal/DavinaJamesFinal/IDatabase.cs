using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace DavinaJamesFinal.Droid
{
	public interface IDatabase
	{
		SQLiteConnection ConnectToDB();
	}
}
