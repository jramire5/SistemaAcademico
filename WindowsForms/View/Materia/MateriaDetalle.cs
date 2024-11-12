using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class MateriaDetalle : Form
{
    private Materia materia;

    public Materia Materia
    {
        get { return materia; }
        set
        {
            materia = value;
            this.SetMateria();
        }
    }
    public MateriaDetalle()
    {
        InitializeComponent();
    }
    private async void SetMateria()
    {

        this.txtId.Text = this.Materia.id_materia.ToString();
        this.txtdesc_materia.Text = this.Materia.desc_materia;
        this.txths_semanales.Text = this.Materia.hs_semanales.ToString();
        this.txths_totales.Text = this.Materia.hs_totales.ToString();

        this.cmbplan.DataSource = await PlanApiClient.GetDropDownValuesAsync();
        this.cmbplan.DisplayMember = "desc_plan_especialidad";
        this.cmbplan.ValueMember = "id_plan";

        this.cmbplan.SelectedValue = this.Materia.id_plan;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
        //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        this.Materia.desc_materia = this.txtdesc_materia.Text;
        this.Materia.hs_semanales = int.Parse(this.txths_semanales.Text);
        this.Materia.hs_totales = int.Parse(this.txths_totales.Text);

        this.Materia.id_plan = (int)this.cmbplan.SelectedValue;
        //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;

        if (txtId.Text == "0" || txtId.Text.Length == 0)
        {
            await MateriaApiClient.AddAsync(Materia);
        }
        else
        {
            await MateriaApiClient.UpdateAsync(Materia);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }


}
