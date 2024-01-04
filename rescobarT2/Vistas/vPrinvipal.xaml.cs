namespace rescobarT2.Vistas;

public partial class vPrinvipal : ContentPage
{
	public vPrinvipal(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Bienvenido " + usuario;

	}

    private void txtNota1_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota1 = Convert.ToInt32(txtNota1.Text);
            if (nota1 > 10 || nota1 < 0)
            {
                DisplayAlert("Alerta", "Solo puede ingresar datos del 0 al 10", "Cerrar");
            }
        }
        catch (Exception)
        {

        }
    }

    private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota2 = Convert.ToInt32(txtNota2.Text);
            if (nota2 > 10 || nota2 < 0)
            {
                DisplayAlert("Alerta", "Solo puede ingresar datos del 0 al 10", "Cerrar");
            }
        }
        catch (Exception)
        {

        }
    }

    private void btnParcial1_Clicked(object sender, EventArgs e)
    {
        double nota1 = Convert.ToInt32(txtNota1.Text) * 0.3;
        double nota2 = Convert.ToInt32(txtNota2.Text) * 0.2;
        double notaP1 = nota1 + nota2;

        DisplayAlert("NOTA PARCIAL 1", "Su nota del primer parcial es: " + notaP1, "Cerrar");
    }

    private void txtNota3_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota3 = Convert.ToInt32(txtNota3.Text);
            if (nota3 > 10 || nota3 < 0)
            {
                DisplayAlert("Alerta", "Solo puede ingresar datos del 0 al 10", "Cerrar");
            }
        }
        catch (Exception)
        {

        }
    }

    private void txtNota4_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota4 = Convert.ToInt32(txtNota4.Text);
            if (nota4 > 10 || nota4 < 0)
            {
                DisplayAlert("Alerta", "Solo puede ingresar datos del 0 al 10", "Cerrar");
            }
        }
        catch (Exception)
        {

        }
    }

    private void btnParcial2_Clicked(object sender, EventArgs e)
    {
        double nota3 = Convert.ToInt32(txtNota3.Text) * 0.3;
        double nota4 = Convert.ToInt32(txtNota4.Text) * 0.2;
        double notaP2 = nota3 + nota4;

        DisplayAlert("NOTA PARCIAL 2", "Su nota del segundo parcial es: " + notaP2, "Cerrar");
    }

    private void btnNotaFinal_Clicked(object sender, EventArgs e)
    {
        double nota1 = Convert.ToInt32(txtNota1.Text) * 0.3;
        double nota2 = Convert.ToInt32(txtNota2.Text) * 0.2;
        double nota3 = Convert.ToInt32(txtNota3.Text) * 0.3;
        double nota4 = Convert.ToInt32(txtNota4.Text) * 0.2;
        double notafinal = nota1 + nota2 + nota3 + nota4;

        if (notafinal >= 7)
        {
            DisplayAlert("NOTA FINAL"," APROBADO" + "\n Su nota es: "+notafinal,"Cerrar");
        }
        else if (notafinal >=5 && notafinal <= 6.9)
        {
            DisplayAlert("NOTA FINAL", " COMPLEMENTARIO" + "\n Su nota es: " + notafinal, "Cerrar");
        }
        else if (notafinal <5)
        {
            DisplayAlert("NOTA FINAL", " REPROBADO" + "\n Su nota es: " + notafinal, "Cerrar");
        }
        else
        {
            DisplayAlert("NOTA FINAL", "NINGUNA", "Cerrar"); ;
        }

        
        //DisplayAlert("NOTA FINAL", "Su nota final es: " + notafinal , "Cerrar");
    }
}