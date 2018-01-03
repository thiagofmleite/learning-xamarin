using System;
using System.IO;
using AluraNutricao.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency (typeof(SQLite_droid))]
namespace AluraNutricao.Droid
{
	public class SQLite_droid : ISQLite
	{
		public SQLite_droid()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var fileName = "Refeicoes.db3";
			string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(folder, fileName);
			var connection = new SQLiteConnection(path);

			return connection;
		}
	}
}
