using Domain.Model;

using WindowsForms.APIServices;

namespace WindowsForms;

public partial class ComisionLista : Form
{
    public ComisionLista()
    {
        InitializeComponent();
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        ComisionDetalle detalle = new ComisionDetalle();

        Comision registroNuevo = new Comision();

        detalle.Entidad  = registroNuevo;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        ComisionDetalle detalle = new ComisionDetalle();

        int id;

        id = this.SelectedItem().id_comision;

        Comision registroModifica = await ComisionApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Entidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_comision;
        await ComisionApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {
        PlanApiClient clienteApi = new PlanApiClient();

        this.Grid.DataSource = null;
        this.Grid.DataSource = await PlanApiClient.GetAllAsync();

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

    private Comision SelectedItem()
    {
        Comision registro;

        registro = (Comision)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
