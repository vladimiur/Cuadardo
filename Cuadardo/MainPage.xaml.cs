using System.Text.RegularExpressions;

namespace Cuadardo;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	//En este codigo con Math.pow hacemos que el numero insertado este elevado al cuadrado y al cubo
    private void Btncalcular_Clicked(object sender, EventArgs e)
    {
		var ValorA = Convert.ToInt32(numero.Text);
		double resultadoA = Math.Pow(ValorA, 2);
		double resultadoB = Math.Pow(ValorA, 3);
		cuadro.Text = Convert.ToString(resultadoA);
		cubo.Text = Convert.ToString(resultadoB);
    }
}

