using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNutricao.View
{
	public partial class ListaRefeicoes : ContentPage
	{

		public ObservableCollection<Refeicao> Refeicoes { get; set; }
		public string Nome { get; set; }
		private RefeicaoDAO dao;

		public ListaRefeicoes(RefeicaoDAO _dao)
		{
			Nome = "Alura";
			BindingContext = this;
			this.Refeicoes = _dao.Lista;
			this.dao = _dao;
			InitializeComponent();
		}


		public async void AcaoItem(object sender, ItemTappedEventArgs e)
		{
			Refeicao refeicao = (Refeicao) e.Item;
			var apaga = await DisplayAlert("Remover Refeição", "Você deseja remover " + refeicao.Nome, "Sim", "Não");

			if (apaga)
			{
				dao.Remove(refeicao);
				await DisplayAlert("Remover Item", "Refeição removida com sucesso", "OK");
			}

		}
	}
}
