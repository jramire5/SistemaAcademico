using Domain.Model.Dtos;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class formLogin : Form
{
    public formLogin()
    {
        InitializeComponent();
    }

    private async void btnIngresar_Click(object sender, EventArgs e)
    {
        //la propiedad Text de los TextBox contiene el texto escrito en ellos
        if (await AutenticacionApiClient.Login(new UsuarioLoginDto() { nombre_usuario = this.txtUsuario.Text, clave = this.txtPass.Text }))
        {
            this.DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void lnkOlvidaPass_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    }
}
