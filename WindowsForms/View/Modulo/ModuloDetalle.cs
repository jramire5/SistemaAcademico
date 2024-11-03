using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class ModuloDetalle : Form
{
    private Modulo entidad;

    public Modulo Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
            this.SetRegistro();
        }
    }
    public ModuloDetalle()
    {
        InitializeComponent();
    }
    private async void SetRegistro()
    {

        this.txtId_modulo.Text=this.Entidad.Id_modulo.ToString();
        this.txtdescripcion_modulo.Text = this.Entidad.descripcion_modulo;
        this.txtejecuta.Text = this.Entidad.ejecuta;


    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
        //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        this.Entidad.descripcion_modulo = this.txtdescripcion_modulo.Text;
        this.Entidad.ejecuta = this.txtejecuta.Text;

        if (txtId_modulo.Text == "0" || txtId_modulo.Text.Length == 0)
        {
            await ModuloApiClient.AddAsync(Entidad);
        }
        else
        {
            await ModuloApiClient.UpdateAsync(Entidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
