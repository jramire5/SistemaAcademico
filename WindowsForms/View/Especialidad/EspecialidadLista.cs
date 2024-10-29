using Domain.Model;

using WindowsForms.APIServices;

namespace WindowsForms;

public partial class EspecialidadLista : Form
{
    public EspecialidadLista()
    {
        InitializeComponent();
    }

    private void EspecialidadLista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        EspecialidadDetalle detalle = new EspecialidadDetalle();

        Especialidad nuevoRegistro = new Especialidad();

        detalle.Especialidad = nuevoRegistro;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        EspecialidadDetalle detalle = new EspecialidadDetalle();

        int id;

        id = this.SelectedItem().id_especialidad;

        Especialidad registroModifica = await EspecialidadApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Especialidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_especialidad;
        await EspecialidadApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {
        EspecialidadApiClient clienteApi = new EspecialidadApiClient();

        this.EspecialidadGrid.DataSource = null;
        this.EspecialidadGrid.DataSource = await EspecialidadApiClient.GetAllAsync();

        if (this.EspecialidadGrid.Rows.Count > 0)
        {
            this.EspecialidadGrid.Rows[0].Selected = true;
            this.btnEliminar.Enabled = true;
            this.btnModificar.Enabled = true;
        }
        else
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
        }
    }

    private Especialidad SelectedItem()
    {
        Especialidad selectedItem;

        selectedItem = (Especialidad)EspecialidadGrid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
