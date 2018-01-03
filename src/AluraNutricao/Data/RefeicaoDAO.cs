using System;
using System.Collections.ObjectModel;
using SQLite;

namespace AluraNutricao
{
	public class RefeicaoDAO
	{
		private SQLiteConnection Conn;
		private ObservableCollection<Refeicao> lista;

		public ObservableCollection<Refeicao> Lista
		{
			get
			{
				if (lista == null)
				{
					lista = GetAll();
				}

				return lista;
			}

			private set
			{
				lista = value;
			}
		}


		public RefeicaoDAO(SQLiteConnection conn)
		{
			this.Conn = conn;
			Conn.CreateTable<Refeicao>(); // Só vai criar a tabela caso ela não exista
		}

		public void Salvar(Refeicao refeicao)
		{
			Conn.Insert(refeicao);
			lista.Add(refeicao);
		}

		public void Atualizar(Refeicao refeicao)
		{
		}

		private ObservableCollection<Refeicao> GetAll()
		{
			return new ObservableCollection<Refeicao>(Conn.Table<Refeicao>());
		}

		public void Remove(Refeicao refeicao)
		{
			Conn.Delete<Refeicao>(refeicao.Id);
			lista.Remove(refeicao);
		}


	}
}
