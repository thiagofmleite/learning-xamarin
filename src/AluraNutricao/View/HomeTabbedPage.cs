using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace AluraNutricao.View
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			#region DATA
			SQLiteConnection conn = DependencyService.Get<ISQLite>().GetConnection(); // Pega qual a implementação correta para o ambiente no qual o app está senndo executado
			RefeicaoDAO dao = new RefeicaoDAO(conn);
			#endregion

			#region Telas
			CadastroRefeicoes telaCadastro = new CadastroRefeicoes(dao);
			ListaRefeicoes telaLista = new ListaRefeicoes(dao);
			#endregion

			this.Children.Add(telaCadastro);
			this.Children.Add(telaLista);
		}
	}
}

