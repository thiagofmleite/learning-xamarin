using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AluraNutricao.ViewModel;
using Xamarin.Forms;

namespace AluraNutricao.View
{
	public partial class CadastroRefeicoes : ContentPage
	{
		private RefeicaoDAO dao;

		public CadastroRefeicoes(RefeicaoDAO _dao)
		{
			this.dao = _dao;
			var vm = new CadastroRefeicoesViewModel(dao, this);
			// Associa o ViewModel à View
			BindingContext = vm;

			InitializeComponent();
		}

	}
}
