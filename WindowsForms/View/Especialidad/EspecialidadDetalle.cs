using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class EspecialidadDetalle : Form
{
    private Especialidad especialidad;

    public Especialidad Especialidad
    {
        get { return especialidad; }
        set
        {
            especialidad = value;
            this.SetPlan();
        }
    }
    public EspecialidadDetalle()
    {
        InitializeComponent();
    }
    private async void SetPlan()
    {

        this.txtid_especialidad.Text=this.Especialidad.id_especialidad.ToString();
        this.txtdesc_especialidad.Text = this.Especialidad.desc_especialidad;      
   

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
        //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        this.Especialidad.desc_especialidad = this.txtdesc_especialidad.Text;     
    
        //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;

        if (txtid_especialidad.Text == "0" || txtid_especialidad.Text.Length == 0)
        {
            await EspecialidadApiClient.AddAsync(Especialidad);
        }
        else
        {
            await EspecialidadApiClient.UpdateAsync(Especialidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
