using Domain.Model;
using Microsoft.IdentityModel.Tokens;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

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
        this.txtnota.Text = this.Entidad.nota.ToString();

        this.cmbCondicion.DataSource = await CondicionApiClient.GetAllAsync();
        this.cmbCondicion.DisplayMember = "Descripcion";
        this.cmbCondicion.ValueMember = "Id_Condicion";
        this.cmbCondicion.SelectedValue = this.Entidad.id_condicion;

     

        if(UsuarioAutenticadoService.isAlumno())
        {
            this.cmbid_alumno.Enabled = false;
            this.txtnota.Enabled = false;

            this.cmbid_curso.DataSource = await CursoApiClient.GetDropDownValuesByPersonaAsync(UsuarioAutenticadoService.usuarioAutenticado.id_persona ?? 0);
            this.cmbid_curso.DisplayMember = "desc_materia_comi_anio";
            this.cmbid_curso.ValueMember = "id_curso";
        }          
        else
        {
            this.cmbid_alumno.DataSource = await PersonaApiClient.GetAlumnosAsync();
            this.cmbid_alumno.DisplayMember = "nombre";
            this.cmbid_alumno.ValueMember = "id_persona";
            this.cmbid_alumno.SelectedValue = this.Entidad.id_alumno;

            this.cmbid_curso.DataSource = await CursoApiClient.GetDropDownValuesAsync();
            this.cmbid_curso.DisplayMember = "desc_materia_comi_anio";
            this.cmbid_curso.ValueMember = "id_curso";
            
        }
        this.cmbid_curso.SelectedValue = this.Entidad.id_curso;
    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        // PropiedadApiClient propiedadApi = new PropiedadApiClient();
        if (ValidarInscripcion())
        {
            //   this.Materia.id_materia = int.Parse(this.txtId.Text);
            this.Entidad.id_condicion = (int)this.cmbCondicion.SelectedValue;
        this.Entidad.nota = = txtnota.Text.Length == 0 ? 0 : int.Parse(this.txtnota.Text);
            if (UsuarioAutenticadoService.isAlumno())
                this.Entidad.id_alumno =  = UsuarioAutenticadoService.usuarioAutenticado.id_persona ?? 0;
            else
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
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private bool ValidarInscripcion()
    {
        bool valid = true;
        if (cmbid_alumno.SelectedIndex == -1)
        {
            valid = false;
            lblalumno.ForeColor = Color.Red;
        }
        if (cmbid_curso.SelectedIndex == -1)
        {
            valid = false;
            lblcurso.ForeColor = Color.Red;
        }
        if (cmbCondicion.SelectedIndex == -1)
        {
            valid = false;
            lblcondicion.ForeColor = Color.Red;
        }
        
        return valid;
    }
    private void cambiaDatos(object sender, EventArgs e)
    {
        lblalumno.ForeColor= Color.Black;
        lblcurso.ForeColor= Color.Black;
        lblcondicion.ForeColor= Color.Black;
    }
}
