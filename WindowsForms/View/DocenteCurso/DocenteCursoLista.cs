using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class DocenteCursoLista : Form
{
    public DocenteCursoLista()
    {
        InitializeComponent();
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        DocenteCursoDetalle detalle = new DocenteCursoDetalle();

        detalle.Entidad = new DocenteCurso();

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        DocenteCursoDetalle detalle = new DocenteCursoDetalle();

        int id;

        id = this.SelectedItem().id_dictado;

        DocenteCurso registroModifica = await DocenteCursoApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Entidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_dictado;
        await DocenteCursoApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {    
        this.Grid.DataSource = null;
        this.Grid.DataSource = await DocenteCursoApiClient.GetAllAsync();

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

    private DocenteCursoDto SelectedItem()
    {
        DocenteCursoDto registro;

        registro = (DocenteCursoDto)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
