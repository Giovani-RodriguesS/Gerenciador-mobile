using Microsoft.Maui.Controls;

namespace MathGame;

public partial class MainPage : ContentPage
{
	int score = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void BtnZerar_Clicked(object sender, EventArgs e)
	{
		string Title = "Zero";
		string Message = "Deseja zerar o Score";

		bool resp = await DisplayAlert(Title, Message, "Sim", "Nao" );
		
		if (resp==true)
		{
			score = 0;
			lbScore.Text = "0";
		}
	}

	private async void BtnJogar_Clicked(object sender, EventArgs e)
	{
		Random random= new Random();

		int num1 = random.Next(1, 40);
		int num2 = random.Next(1, 40);
		string title = "Pergunta";
		string message = "Quanto é" + num1 + " + " + num2 + "?";

		int total = num1 + num2;

		string text = await DisplayPromptAsync(title, message, "Sim", "Não");
	
		try 
		{
			int resp = Convert.ToInt32(text);
			if (resp == total)
			{
				score += 10;
				text = "Acertou! +10 pontos";
			}
			else 
			{
				score -= 10;
				text = "Errou! -10 pontos";
			}

			lbScore.Text = score.ToString();
			await DisplayAlert("Resposta", text, "OK");


		}catch(Exception ex)
		{
			await DisplayAlert("Erro", "Entrada inválida!", "OK");
		}
		
	}
}

