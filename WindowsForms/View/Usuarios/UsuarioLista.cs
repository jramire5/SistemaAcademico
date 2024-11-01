using Domain.Model.Dtos;
using Domain.Model;
using WindowsForms.APIServices;

namespace WindowsForms.View.Usuarios;

public partial class UsuarioLista : Form
{
    public UsuarioLista()
    {
        InitializeComponent();
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        UsuarioDetalle detalle = new UsuarioDetalle();

        detalle.Usuario = new Usuario();
        
        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        UsuarioDetalle detalle = new UsuarioDetalle();

        int id = this.SelectedItem().id_usuario;
        // personaDetalle.editMode = true;
        detalle.Usuario = await UsuarioAPIClient.GetAsync(id); 

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_usuario;
        await UsuarioAPIClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    { 
        this.Grid.DataSource = null;
        this.Grid.DataSource = await UsuarioAPIClient.GetAllAsync();

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;
        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
    }

    private UsuarioDto SelectedItem()=>(UsuarioDto)Grid.SelectedRows[0].DataBoundItem;

}
