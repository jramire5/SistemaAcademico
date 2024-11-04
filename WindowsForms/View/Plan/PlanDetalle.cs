using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class PlanDetalle : Form
{
    private Plan plan;

    public Plan Plan
    {
        get { return plan; }
        set
        {
            plan = value;
            this.SetPlan();
        }
    }
    public PlanDetalle()
    {
        InitializeComponent();
    }
    private async void SetPlan()
    {

        this.txtid_plan.Text=this.Plan.id_plan.ToString();
        this.txtdesc_plan.Text = this.Plan.desc_plan;
      
        this.cmbespecialidad.DataSource = await EspecialidadApiClient.GetAllAsync();
        this.cmbespecialidad.DisplayMember = "desc_especialidad";
        this.cmbespecialidad.ValueMember = "id_especialidad";

        this.cmbespecialidad.SelectedValue = this.Plan.id_especialidad;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
     //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        this.Plan.desc_plan = this.txtdesc_plan.Text;     
        this.Plan.id_especialidad = (int)this.cmbespecialidad.SelectedValue;
        //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;

        if (txtid_plan.Text == "0" || txtid_plan.Text.Length == 0)
        {
            await PlanApiClient.AddAsync(Plan);
        }
        else
        {
            await PlanApiClient.UpdateAsync(Plan);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
