using System;
using SQLite;

namespace AluraNutricao
{
	public class Refeicao
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nome { get; set; }
		public double Calorias { get; set; }
		public int Quantidade { get; set; }

		public Refeicao()
		{
		}
	}
}
