using System;
using System.IO;
using AluraNutricao.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_ios))]
namespace AluraNutricao.iOS
{
	public class SQLite_ios : ISQLite
	{
		public SQLite_ios()
		{
			
		}

		public SQLiteConnection GetConnection()
		{
			var fileName = "Refeicoes.db3";
			// Pasta "documentos" do iOS
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			// Caminho aonde o arquivo do SQLite será salvo
			var path = Path.Combine(documents, "..", "Library", fileName);

			return new SQLiteConnection(path);
		}
	}
}
