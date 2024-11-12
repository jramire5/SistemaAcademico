using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class ComisionLista : Form
{
    public ComisionLista()
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
        this.Grid.DataSource = null;
        this.Grid.DataSource = await ComisionApiClient.GetAllAsync();

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
        this.Grid.Columns[1].HeaderText = "Comisión";
        this.Grid.Columns[2].HeaderText = "Año Especialidad";
        this.Grid.Columns[3].HeaderText = "Plan";
    }

    private ComisionDto SelectedItem()
    {
        ComisionDto registro;

        registro = (ComisionDto)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
