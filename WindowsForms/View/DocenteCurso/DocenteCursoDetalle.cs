using Domain.Model;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

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
        this.cmbid_curso.SelectedValue = this.Entidad.id_curso;

        if (UsuarioAutenticadoService.isDocente())
        {
            this.cmbid_docente.Enabled = false;
        }
        else
        {
            this.cmbid_docente.DataSource = await PersonaApiClient.GetDocentesAsync();
            this.cmbid_docente.DisplayMember = "nombre";
            this.cmbid_docente.ValueMember = "id_persona";
            this.cmbid_docente.SelectedValue = this.Entidad.id_docente;
        }

           

        this.cmbid_cargo.DataSource = await CargoApiClient.GetAllAsync();
        this.cmbid_cargo.DisplayMember = "Descripcion";
        this.cmbid_cargo.ValueMember = "Id_Cargo";
        this.cmbid_cargo.SelectedValue = this.Entidad.id_cargo ?? 0;

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        this.Entidad.id_curso = (int)this.cmbid_curso.SelectedValue;
        if (UsuarioAutenticadoService.isDocente())
            this.Entidad.id_docente = UsuarioAutenticadoService.usuarioAutenticado.id_persona ?? 0;
        else
            this.Entidad.id_docente = (int)this.cmbid_docente.SelectedValue;

        this.Entidad.id_cargo = (int?)this.cmbid_cargo.SelectedValue;
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
