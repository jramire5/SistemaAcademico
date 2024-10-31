using Domain.Model;
using WindowsForms.APIServices;

namespace WindowsForms;

public partial class ComisionDetalle : Form
{
    private Comision entidad;

    public Comision Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
            this.SetPlan();
        }
    }
    public ComisionDetalle()
    {
        InitializeComponent();
    }
    private async void SetPlan()
    {

        this.txtid_comision.Text=this.Entidad.id_comision.ToString();
        this.txtdesc_comision.Text = this.Entidad.desc_comision;
        this.txtanio_especialidad.Text = this.Entidad.anio_especialidad.ToString();

        this.cmbid_plan.DataSource = await PlanApiClient.GetDropDownValuesAsync();
        this.cmbid_plan.DisplayMember = "desc_plan_especialidad";
        this.cmbid_plan.ValueMember = "id_plan";

        this.cmbid_plan.SelectedValue = this.Entidad.id_plan;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
        //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        this.Entidad.desc_comision = this.txtdesc_comision.Text;
        this.Entidad.anio_especialidad = int.Parse(this.txtanio_especialidad.Text);
        this.Entidad.id_plan = (int)this.cmbid_plan.SelectedValue;
        //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;

        if (txtid_comision.Text == "0" || txtid_comision.Text.Length == 0)
        {
            await ComisionApiClient.AddAsync(Entidad);
        }
        else
        {
            await ComisionApiClient.UpdateAsync(Entidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
