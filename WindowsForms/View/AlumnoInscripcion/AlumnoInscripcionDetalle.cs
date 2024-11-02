using Domain.Model;
using WindowsForms.APIServices;

namespace WindowsForms;

public partial class AlumnoInscripcionDetalle : Form
{
    private AlumnoInscripcion entidad;

    public AlumnoInscripcion Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
            this.SetAlumnoInscripcion();
        }
    }
    public AlumnoInscripcionDetalle()
    {
        InitializeComponent();
    }
    private async void SetAlumnoInscripcion()
    {

        this.txtid_inscripcion.Text=this.Entidad.id_inscripcion.ToString();
        this.txtcondicion.Text = this.Entidad.condicion;
        this.txtnota.Text = this.Entidad.nota.ToString();

        this.cmbid_curso.DataSource = await CursoApiClient.GetDropDownValuesAsync();
        this.cmbid_curso.DisplayMember = "desc_materia_comi_anio";
        this.cmbid_curso.ValueMember = "id_curso";

        this.cmbid_alumno.DataSource = await PersonaApiClient.GetAllAsync();
        this.cmbid_alumno.DisplayMember = "nombre";
        this.cmbid_alumno.ValueMember = "id_persona";

        this.cmbid_curso.SelectedValue = this.Entidad.id_curso;
        this.cmbid_alumno.SelectedValue = this.Entidad.id_alumno;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        //if (this.ValidateCliente())
        //   this.Materia.id_materia = int.Parse(this.txtId.Text);
        this.Entidad.condicion = this.txtcondicion.Text;
        this.Entidad.nota = int.Parse(this.txtnota.Text);
        this.Entidad.id_alumno = (int)this.cmbid_alumno.SelectedValue;
        this.Entidad.id_curso = (int)this.cmbid_curso.SelectedValue;
        //  this.propiedad.FechaAlta = this.txtFechaAlta.Value;

        if (txtid_inscripcion.Text == "0" || txtid_inscripcion.Text.Length == 0)
        {
            await AlumnoInscripcionApiClient.AddAsync(Entidad);
        }
        else
        {
            await AlumnoInscripcionApiClient.UpdateAsync(Entidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
