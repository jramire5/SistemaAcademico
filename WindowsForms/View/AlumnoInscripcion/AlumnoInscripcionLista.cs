using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class AlumnoInscripcionLista : Form
{
    public AlumnoInscripcionLista()
    {
        InitializeComponent();
        btn_agregar.Enabled = UsuarioAutenticadoService.AccedeAAlta(this.Name);       
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        AlumnoInscripcionDetalle detalle = new AlumnoInscripcionDetalle();

        detalle.Entidad  = new AlumnoInscripcion();

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        AlumnoInscripcionDetalle detalle = new AlumnoInscripcionDetalle();

        int id;

        id = this.SelectedItem().id_inscripcion;

        AlumnoInscripcion registroModifica = await AlumnoInscripcionApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Entidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_inscripcion;
        await AlumnoInscripcionApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {
        this.Grid.DataSource = null;
        this.Grid.DataSource = await AlumnoInscripcionApiClient.GetAllAsync(UsuarioAutenticadoService.usuarioAutenticado.id_persona);

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            btn_modificar.Enabled = UsuarioAutenticadoService.AccedeAModificar(this.Name);
            btn_eliminar.Enabled = UsuarioAutenticadoService.AccedeABaja(this.Name);
        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
        this.Grid.Columns[0].HeaderText = "Id";
        this.Grid.Columns[1].HeaderText = "Alumno";
        this.Grid.Columns[2].HeaderText = "Materia";
        this.Grid.Columns[3].HeaderText = "Comisión";
        this.Grid.Columns[4].HeaderText = "Año Calendario";
    }

    private AlumnoInscripcionDto SelectedItem()
    {
        AlumnoInscripcionDto registro;

        registro = (AlumnoInscripcionDto)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
