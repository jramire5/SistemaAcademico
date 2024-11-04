using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class ModuloUsuarioDetalle : Form
{
    private ModuloUsuario entidad;

    public ModuloUsuario Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
            this.SetRegistro();
        }
    }
    public ModuloUsuarioDetalle()
    {
        InitializeComponent();
    }
    private async void SetRegistro()
    {

        this.txtIdModuloUsuario.Text=this.Entidad.IdModuloUsuario.ToString();

        this.cmbIdModulo.DataSource = await ModuloApiClient.GetAllAsync();
        this.cmbIdModulo.DisplayMember = "descripcion_modulo";
        this.cmbIdModulo.ValueMember = "Id_modulo";
        this.cmbIdModulo.SelectedValue = this.Entidad.IdModulo;

        this.cmbIdUsuario.DataSource = await UsuarioApiClient.GetAllAsync();
        this.cmbIdUsuario.DisplayMember = "nombre_usuario";
        this.cmbIdUsuario.ValueMember = "id_usuario";
        this.cmbIdUsuario.SelectedValue = this.Entidad.IdUsuario;

        this.chkAlta.Checked = this.Entidad.Alta;
        this.chkBaja.Checked = this.Entidad.Baja;
        this.chkModificacion.Checked = this.Entidad.Modificacion;
        this.chkConsulta.Checked = this.Entidad.Consulta;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        this.Entidad.IdModulo =  (int)this.cmbIdModulo.SelectedValue;
        this.Entidad.IdUsuario = (int)this.cmbIdUsuario.SelectedValue;
        this.Entidad.Alta = this.chkAlta.Checked;
        this.Entidad.Baja = this.chkBaja.Checked;
        this.Entidad.Modificacion = this.chkModificacion.Checked;
        this.Entidad.Consulta = this.chkConsulta.Checked;


        if (txtIdModuloUsuario.Text == "0" || txtIdModuloUsuario.Text.Length == 0)
        {
            await ModuloUsuarioApiClient.AddAsync(Entidad);
        }
        else
        {
            await ModuloUsuarioApiClient.UpdateAsync(Entidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
