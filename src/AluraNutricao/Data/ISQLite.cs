using System;
using SQLite;

namespace AluraNutricao
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
