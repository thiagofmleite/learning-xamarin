using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AluraNutricao.ViewModel
{
	public class CadastroRefeicoesViewModel : INotifyPropertyChanged
	{

		private string descricao;
		private double calorias;
		private int quantidade;

		#region Propriedades
		public string Descricao
		{
			get
			{
				return descricao;
			}
			set
			{
				if (!value.Equals(descricao))
				{
					OnPropertyChanged("Descricao");
					descricao = value;
				}
			}
		}

		public double Calorias
		{
			get
			{
				return calorias;
			}
			set
			{
				if (!value.Equals(calorias))
				{
					calorias = value;
					OnPropertyChanged("Calorias");
				}

			}
		}
		public int Quantidade
		{
			get
			{
				return quantidade;
			}
			set
			{
				if (!value.Equals(quantidade))
				{
					quantidade = value;
					OnPropertyChanged("Quantidade");
				}
			}
		}


		public ICommand SalvaRefeicao { get; protected set;}
		#endregion

		#region Propriedades Privadas
		private RefeicaoDAO dao;
		private ContentPage page;
		#endregion

		public event PropertyChangedEventHandler PropertyChanged;



		public CadastroRefeicoesViewModel(RefeicaoDAO _dao, ContentPage _page)
		{
			this.dao = _dao;
			this.page = _page;

			SalvaRefeicao = new Command(() =>
			{
				var refeicao = new Refeicao
				{
					Nome = descricao,
					Calorias = calorias,
					Quantidade = quantidade
				};

				dao.Salvar(refeicao);
				string msg = "A refeição: (" + refeicao.Quantidade.ToString() + ")" + refeicao.Nome + " (" + refeicao.Calorias.ToString() + "kcal) foi salvo com sucesso!";

				page.DisplayAlert("Refeição Adicionada", msg, "OK");
			});
		}

		#region Eventos



		private void OnPropertyChanged(string nome)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}

		#endregion

	}
}
