using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class AlumnoInscripcionLista : Form
{
    public AlumnoInscripcionLista()
    {
        InitializeComponent();
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
        this.Grid.DataSource = await AlumnoInscripcionApiClient.GetAllAsync();

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            this.btnEliminar.Enabled = true;
            this.btnModificar.Enabled = true;
        }
        else
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
        }
    }

    private AlumnoInscripcionDto SelectedItem()
    {
        AlumnoInscripcionDto registro;

        registro = (AlumnoInscripcionDto)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
