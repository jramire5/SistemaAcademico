using Domain.Model;
using WindowsForms.APIServices;

namespace WindowsForms;

public partial class UsuarioDetalle : Form
{
    private Usuario usuario;

    public Usuario Usuario
    {
        get { return usuario; }
        set
        {
            usuario = value;
            this.SetUsuario();
        }
    }
    public UsuarioDetalle()
    {
        InitializeComponent();
    }
    private async void SetUsuario()
    {

        this.txtid_usuario.Text = this.Usuario.id_usuario.ToString();
        this.txtnombre_usuario.Text = this.Usuario.nombre_usuario;
        this.txtclave.Text = this.Usuario.clave;
        this.txtnombre.Text = this.Usuario.nombre;
        this.txtapellido.Text = this.Usuario.apellido;
        this.txtemail.Text = this.Usuario.email;
        this.chkcambia_clave.Checked = this.Usuario.cambia_clave;
        this.chkhabilitado.Checked = this.Usuario.habilitado;

        this.cmbid_persona.DataSource = await PersonaApiClient.GetAllAsync();
        this.cmbid_persona.DisplayMember = "nombre";
        this.cmbid_persona.ValueMember = "id_persona";
        this.cmbid_persona.SelectedValue = this.Usuario.id_persona;  

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        this.Usuario.nombre_usuario = this.txtnombre_usuario.Text;
        this.Usuario.clave = this.txtclave.Text;
        this.Usuario.nombre = this.txtnombre.Text;
        this.Usuario.apellido = this.txtapellido.Text;
        this.Usuario.email = this.txtemail.Text;
        this.Usuario.cambia_clave = this.chkcambia_clave.Checked;
        this.Usuario.habilitado = this.chkhabilitado.Checked;
        this.Usuario.id_persona = (int?)this.cmbid_persona.SelectedValue; 

        if (txtid_usuario.Text == "0" || txtid_usuario.Text.Length == 0)
        {
            await UsuarioAPIClient.AddAsync(Usuario);
        }
        else
        {
            await UsuarioAPIClient.UpdateAsync(Usuario);
        }
        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
