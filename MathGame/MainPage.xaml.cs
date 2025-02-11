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

		int num1 = random.Next(1, 10);
		int num2 = random.Next(1, 10);

		int op  = random.Next(0, 3);
		
		string title = "Pergunta";
		string message = "Quanto é " + num1 + "  " + num2 + "?";
		int total;

		switch (op)
		{
			case 0:
				message = "Quanto é " + num1 + " + " + num2 + "?";
				total = num1 + num2;
				break;
			case 1:
				message = "Quanto é " + num1 + " - " + num2 + "?";
				total = num1 - num2;
				break;
			case 2:
				message = "Quanto é " + num1 + " * " + num2 + "?";
				total = num1 * num2;
				break;
			default:
				message = "Quanto é " + num1 + " / " + num2 + "?";
				total = num1 / num2;
				break;
		}



		string text = await DisplayPromptAsync(title, message, "Sim", "Não");
	
		try 
		{
			int resp = Convert.ToInt32(text);
			if (resp == total)
			{
				score += 10;
				text = "Acertou! +10 pontos";
			}
			else if (resp != total && text.Length > 0)
			{
				score -= 10;
				text = "Errou! -10 pontos";
			}
			else 
			{
				text = "Cancelado";
			}

			lbScore.Text = score.ToString();
			await DisplayAlert("Resposta", text, "OK");


		}catch(Exception ex)
		{
			await DisplayAlert("Erro", "Entrada inválida!", "OK");
		}
		
	}
}

