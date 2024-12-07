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
        if (string.IsNullOrEmpty(this.txtUsuario.Text) || string.IsNullOrEmpty(this.txtPass.Text))
        {
            MessageBox.Show("Por favor introdusca tanto el usuario como la contraseña.", "Error de inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
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
}
