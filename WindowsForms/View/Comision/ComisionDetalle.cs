using Domain.Model;
using System.CodeDom;
using WindowsForms.ApiServices;

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

        this.txtid_comision.Text = this.Entidad.id_comision.ToString();
        this.txtdesc_comision.Text = this.Entidad.desc_comision;
        this.txtanio_especialidad.Text = this.Entidad.anio_especialidad.ToString();

        this.cmbid_plan.DataSource = await PlanApiClient.GetDropDownValuesAsync();
        this.cmbid_plan.DisplayMember = "desc_plan_especialidad";
        this.cmbid_plan.ValueMember = "id_plan";

        this.cmbid_plan.SelectedValue = this.Entidad.id_plan;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {

        bool faltanRequired = false;
        ErrorDesc.Visible = false;
        Errores.Text = "";
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
        //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        if (this.txtdesc_comision.Text.Length > 0 || this.txtdesc_comision.Text.Length > 0)
            {
                this.Entidad.desc_comision = this.txtdesc_comision.Text;
            }
            else
            {
                faltanRequired = true;
                ErrorDesc.Visible = true;
            }
        if (faltanRequired == false)
        {
            if (this.txtanio_especialidad.Text.Length > 0)
            {
                this.Entidad.anio_especialidad = int.Parse(this.txtanio_especialidad.Text);
            }
            else
            {
                this.Entidad.anio_especialidad = 0;
            }
            if (this.cmbid_plan.SelectedIndex != -1)
            {
                this.Entidad.id_plan = (int)this.cmbid_plan.SelectedValue;
            }
            else
            {
                faltanRequired = true;
                Errores.Text = Errores.Text + "Elija un Plan válido";
            }
            //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;
            if (!faltanRequired)
            {
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
            else
            {
                Errores.Visible = true;
           
            }
        }
    }

    private async void cambianDatos(object sender, EventArgs e)
    {
        ErrorDesc.Visible = false;
        Errores.Visible = false;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }


}
