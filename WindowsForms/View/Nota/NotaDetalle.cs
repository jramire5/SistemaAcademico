using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class NotaDetalle : Form
{
    private Nota entidad;

    public Nota Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
            this.SetNota();
        }
    }
    public NotaDetalle()
    {
        InitializeComponent();
    }
    private async void SetNota()
    {
        this.cmbid_dictado.DataSource = await DocenteCursoApiClient.GetDropDownValuesAsync(UsuarioAutenticadoService.usuarioAutenticado.id_persona ?? 0);
        this.cmbid_dictado.DisplayMember = "desc_docenteCurso";
        this.cmbid_dictado.ValueMember = "id_dictado";
        this.cmbid_dictado.SelectedValue = this.Entidad.id_dictado;


        if (this.Entidad.id_alumno > 0)
        {
            this.cmbid_alumno.DataSource = await PersonaApiClient.GetAlumnosAsync();
            this.cmbid_alumno.DisplayMember = "nombre";
            this.cmbid_alumno.ValueMember = "id_persona";
            this.cmbid_alumno.SelectedValue = this.Entidad.id_alumno;
        }
        this.txt_descr.Text = this.Entidad.descripcion;
        this.txt_nota.Text = this.Entidad.nota.ToString();

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        this.Entidad.id_dictado = (int)this.cmbid_dictado.SelectedValue;
        this.Entidad.id_alumno = (int)this.cmbid_alumno.SelectedValue;
        this.Entidad.descripcion = this.txt_descr.Text;
        this.Entidad.nota = int.Parse(this.txt_nota.Text);

        if (txtid_nota.Text == "0" || txtid_nota.Text.Length == 0)
        {
            await NotaApiClient.AddAsync(Entidad);
        }
        else
        {
            await NotaApiClient.UpdateAsync(Entidad);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }    
    private async void cmbid_dictado_SelectedValueChanged(object sender, EventArgs e)
    {
        DocenteCursoDropdownDto selectedItem = (DocenteCursoDropdownDto)cmbid_dictado.SelectedItem;// Obtén el valor seleccionado y realiza alguna acción

        if (this.cmbid_dictado.SelectedIndex > 0 && selectedItem?.id_dictado > 0)
        {
            this.cmbid_alumno.DataSource = await AlumnoInscripcionApiClient.GetAlumnosEnCursoAsync(selectedItem.id_curso);
            this.cmbid_alumno.DisplayMember = "nombre";
            this.cmbid_alumno.ValueMember = "id_persona";
            this.cmbid_alumno.SelectedValue = 0;
        }       
    }
}
