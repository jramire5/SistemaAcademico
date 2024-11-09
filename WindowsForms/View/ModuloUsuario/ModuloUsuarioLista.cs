using Domain.Model;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class ModuloUsuarioLista : Form
{
    public ModuloUsuarioLista()
    {
        InitializeComponent();
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        ModuloUsuarioDetalle detalle = new ModuloUsuarioDetalle();

        detalle.Entidad = new ModuloUsuario();

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        ModuloUsuarioDetalle detalle = new ModuloUsuarioDetalle();

        int id;

        id = this.SelectedItem().IdModuloUsuario;

        ModuloUsuario registroModifica = await ModuloUsuarioApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Entidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().IdModuloUsuario;
        await ModuloUsuarioApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {

        this.Grid.DataSource = null;
        this.Grid.DataSource = await ModuloUsuarioApiClient.GetAllAsync();

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            this.btnEliminar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnModificar.Enabled = true;
        }
        else
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
        }
    }

    private ModuloUsuario SelectedItem()
    {
        ModuloUsuario selectedItem;

        selectedItem = (ModuloUsuario)Grid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
