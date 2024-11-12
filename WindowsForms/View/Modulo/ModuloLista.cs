using Domain.Model;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class ModuloLista : Form
{
    public ModuloLista()
    {
        InitializeComponent();
        btn_agregar.Enabled = UsuarioAutenticadoService.AccedeAAlta(this.Name);
        btn_modificar.Enabled = UsuarioAutenticadoService.AccedeAModificar(this.Name);
        btn_eliminar.Enabled = UsuarioAutenticadoService.AccedeABaja(this.Name);
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        ModuloDetalle detalle = new ModuloDetalle();

        detalle.Entidad = new Modulo();

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        ModuloDetalle detalle = new ModuloDetalle();

        int id;

        id = this.SelectedItem().Id_modulo;

        Modulo registroModifica = await ModuloApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Entidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().Id_modulo;
        await ModuloApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {

        this.Grid.DataSource = null;
        this.Grid.DataSource = await ModuloApiClient.GetAllAsync();

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;
            this.Grid.Columns[0].HeaderText = "Id";
            this.Grid.Columns[1].HeaderText = "Descripción";
        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
    }

    private Modulo SelectedItem()
    {
        Modulo selectedItem;

        selectedItem = (Modulo)Grid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
