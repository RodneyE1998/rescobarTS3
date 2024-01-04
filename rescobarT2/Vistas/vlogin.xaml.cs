using System.Globalization;

namespace rescobarT2.Vistas;

public partial class vlogin : ContentPage
{
	public vlogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[] users = { "Carlos", "Ana", "Jose" };
        string[] passwords = { "carlos123", "ana123", "jose123" };

        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContraseña.Text;

        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] == usuarioIngresado && passwords[i] == contrasenaIngresada)
            {
                Navigation.PushAsync(new vPrinvipal(usuarioIngresado));
                DisplayAlert("WELCOME", "Bienvenido " + usuarioIngresado + "\n" + "Usuario Conectado", "Cerrar");
                break;
            }
            else
            {
                DisplayAlert("ALERTA", "Usuarios o contraseña Incorrectos", "Cerrar");
            }
        }

        
    }
 

}