using Domain.Model;
using Domain.Model.Dtos;
using System.Diagnostics.Eventing.Reader;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class NotaDetalle : Form
{
    private bool onload;
    private bool onDictadoChangedProcessing;
    private Nota entidad;

    public Nota Entidad
    {
        get { return entidad; }
        set
        {
            entidad = value;
        }
    }
    public NotaDetalle()
    {
        InitializeComponent();
    }
   
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        NotaUpdateDto notatoUpdate = new NotaUpdateDto();
        notatoUpdate.id_nota = Entidad.id_nota;
        notatoUpdate.id_dictado = (int)this.cmbid_dictado.SelectedValue;
        notatoUpdate.id_inscripcion = (int)this.cmbid_inscripcion.SelectedValue;
        notatoUpdate.descripcion = this.txt_descr.Text;
        notatoUpdate.nota = int.Parse(this.txt_nota.Text);

        if ((txtid_nota.Text == "0" || txtid_nota.Text.Length == 0) && Entidad.id_nota == 0)
        {
            if (await NuevaNotaValida())
            {
                await NotaApiClient.AddAsync(notatoUpdate);
                this.Close();
            }
        }                       
        else
            {
                await NotaApiClient.UpdateAsync(notatoUpdate);
                this.Close();
            }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private async void cmbid_dictado_SelectedValueChanged(object sender, EventArgs e)
    {
        if (onload)
            return;

        onDictadoChangedProcessing = true;
        DocenteCursoDropdownDto selectedItem = (DocenteCursoDropdownDto)cmbid_dictado.SelectedItem;// Obtén el valor seleccionado y realiza alguna acción

        if (this.cmbid_dictado.SelectedIndex >= 0 && selectedItem?.id_dictado > 0)
        {
            this.cmbid_inscripcion.DataSource = await AlumnoInscripcionApiClient.GetAlumnosEnCursoAsync(selectedItem.id_curso);
            this.cmbid_inscripcion.DisplayMember = "nombre";
            this.cmbid_inscripcion.ValueMember = "id_inscripcion";
            onDictadoChangedProcessing = false;

            //Resetea la inscripción
            this.cmbid_inscripcion.SelectedItem = null;
            this.cmbid_inscripcion.Text = string.Empty;
            //Resetea el campo nota
            this.txt_nota.Text = string.Empty;
        }
    }

    private async void cmbid_inscripcion_SelectedValueChanged(object sender, EventArgs e)
    {
        if (onload || onDictadoChangedProcessing)
            return;

        AlumnoDropDownDto selectedItem = (AlumnoDropDownDto)cmbid_inscripcion.SelectedItem;// Obtén el valor seleccionado y realiza alguna acción

        if (this.cmbid_inscripcion.SelectedIndex >= 0 && selectedItem?.id_inscripcion > 0)
        {
            AlumnoInscripcion alumnoInscripcion = await AlumnoInscripcionApiClient.GetAsync(selectedItem.id_inscripcion);

            if (alumnoInscripcion is not null)
                this.txt_nota.Text = alumnoInscripcion.nota.ToString() ?? string.Empty;
            else
                this.txt_nota.Text = string.Empty;
        }
        else
            this.txt_nota.Text = string.Empty;

    }

    private async void NotaDetalle_Load(object sender, EventArgs e)
    {
        onload = true;
        bool rtn;
        if (await LoadDicatadoData())
            rtn= await LoadInscripcionesdata();

        txtid_nota.Text = this.Entidad.id_nota.ToString();
        this.cmbid_dictado.SelectedValue = this.Entidad.id_dictado;
        this.cmbid_inscripcion.SelectedValue = this.Entidad.id_inscripcion;
        this.txt_descr.Text = this.Entidad.descripcion;
        onload = false;
    }

    private async Task<bool> LoadDicatadoData()
    {
        this.cmbid_dictado.DataSource = await DocenteCursoApiClient.GetDropDownValuesAsync(UsuarioAutenticadoService.usuarioAutenticado.id_persona ?? 0);
        this.cmbid_dictado.DisplayMember = "desc_docenteCurso";
        this.cmbid_dictado.ValueMember = "id_dictado";
      /*  if (this.Entidad.id_dictado > 0 && this.Entidad.id_inscripcion > 0)
        {
            DocenteCursoDropdownDto dictadoItem = (DocenteCursoDropdownDto)cmbid_dictado.SelectedItem;

            this.cmbid_inscripcion.DataSource = await AlumnoInscripcionApiClient.GetAlumnosEnCursoAsync(dictadoItem.id_curso);
            this.cmbid_inscripcion.DisplayMember = "nombre";
            this.cmbid_inscripcion.ValueMember = "id_inscripcion";

            AlumnoInscripcion alumnoInscripcion = await AlumnoInscripcionApiClient.GetAsync(this.Entidad.id_inscripcion);
            if (alumnoInscripcion is not null)
                this.txt_nota.Text = alumnoInscripcion.nota.ToString() ?? string.Empty;
        }*/
        return true;
    }
    private async Task<bool> LoadInscripcionesdata()
    {
        if (this.Entidad.id_dictado > 0 && this.Entidad.id_inscripcion > 0)
        {
            AlumnoInscripcion alumnoInscripcion = await AlumnoInscripcionApiClient.GetAsync(this.Entidad.id_inscripcion);

            this.cmbid_inscripcion.DataSource = await AlumnoInscripcionApiClient.GetAlumnosEnCursoAsync(alumnoInscripcion.id_curso);
            this.cmbid_inscripcion.DisplayMember = "nombre";
            this.cmbid_inscripcion.ValueMember = "id_inscripcion";
    
            if (alumnoInscripcion is not null)
                this.txt_nota.Text = alumnoInscripcion.nota.ToString() ?? string.Empty;
        }
        return true;
    }

    private async Task<bool> NuevaNotaValida()
    {
        Nota nota = await NotaApiClient.GetByInscripcionAsync((int)this.cmbid_inscripcion.SelectedValue);
        if(nota is not null)
        {
            MessageBox.Show("No se puede agregar una nueva nota para está inscripción. Se debe modifcar.", "Nota ya existente."
            , MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;

    }
}
