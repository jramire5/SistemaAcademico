using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class DocenteCursoDetalle : Form
{
    private DocenteCurso entidad;

    public DocenteCurso Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
            this.SetPlan();
        }
    }
    public DocenteCursoDetalle()
    {
        InitializeComponent();
    }
    private async void SetPlan()
    {

        this.txtid_id_dictado.Text=this.Entidad.id_dictado.ToString();

        this.cmbid_curso.DataSource = await CursoApiClient.GetDropDownValuesAsync();
        this.cmbid_curso.DisplayMember = "desc_materia_comi_anio";
        this.cmbid_curso.ValueMember = "id_curso";

        this.cmbid_docente.DataSource = await PersonaApiClient.GetAllAsync();
        this.cmbid_docente.DisplayMember = "nombre";
        this.cmbid_docente.ValueMember = "id_persona";

        this.cmbid_curso.SelectedValue = this.Entidad.id_curso;
        this.cmbid_docente.SelectedValue = this.Entidad.id_docente;

        this.txtcargo.Text = this.Entidad.cargo.ToString();

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        this.Entidad.id_curso = (int)this.cmbid_curso.SelectedValue;
        this.Entidad.id_docente = (int)this.cmbid_docente.SelectedValue;

        this.Entidad.cargo = int.Parse(this.txtcargo.Text);
        //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;

        if (txtid_id_dictado.Text == "0" || txtid_id_dictado.Text.Length == 0)
        {
            await DocenteCursoApiClient.AddAsync(Entidad);
        }
        else
        {
            await DocenteCursoApiClient.UpdateAsync(Entidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
