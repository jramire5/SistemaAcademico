using Domain.Model;

using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class EspecialidadLista : Form
{
    public EspecialidadLista()
    {
        InitializeComponent();
        btn_agregar.Enabled = UsuarioAutenticadoService.AccedeAAlta(this.Name);       
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
            btn_modificar.Enabled = UsuarioAutenticadoService.AccedeAModificar(this.Name);
            btn_eliminar.Enabled = UsuarioAutenticadoService.AccedeABaja(this.Name);           
        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
        this.EspecialidadGrid.Columns[0].HeaderText = "Id";
        this.EspecialidadGrid.Columns[1].HeaderText = "Descripción";
    }

    private Especialidad SelectedItem()
    {
        Especialidad selectedItem;

        selectedItem = (Especialidad)EspecialidadGrid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
