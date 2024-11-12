using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class ModuloUsuarioLista : Form
{
    public ModuloUsuarioLista()
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
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;
            this.btn_modificar.Enabled = true;

        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
        this.Grid.Columns[0].HeaderText = "Id Modulo Usuario";
        this.Grid.Columns[1].HeaderText = "Usuario";
        this.Grid.Columns[2].HeaderText = "Modulo";
    }

    private ModuloUsuarioDto SelectedItem()
    {
        ModuloUsuarioDto selectedItem;

        selectedItem = (ModuloUsuarioDto)Grid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
