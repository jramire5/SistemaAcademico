using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class CursosLista : Form
{
    public CursosLista()
    {
        InitializeComponent();
    }

    private void Lista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        CursosDetalle detalle = new CursosDetalle();
 
        detalle.Curso =  new Curso();

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        CursosDetalle detalle = new CursosDetalle();

        int id;

        id = this.SelectedItem().id_curso;

        Curso registroModifica = await CursoApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Curso = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_curso;
        await CursoApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {
        CursoApiClient clienteApi = new CursoApiClient();

        this.EspecialidadGrid.DataSource = null;
        this.EspecialidadGrid.DataSource = await CursoApiClient.GetAllAsync();

        if (this.EspecialidadGrid.Rows.Count > 0)
        {
            this.EspecialidadGrid.Rows[0].Selected = true;
            this.btnEliminar.Enabled = true;
            this.btnModificar.Enabled = true;

            this.EspecialidadGrid.Columns[0].HeaderText = "Id";
            this.EspecialidadGrid.Columns[1].HeaderText = "Año";
            this.EspecialidadGrid.Columns[2].HeaderText = "Cupo";
            this.EspecialidadGrid.Columns[3].HeaderText = "Materia";
            this.EspecialidadGrid.Columns[4].HeaderText = "Comisión";

        }
        else
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
        }
    }

    private CursoDto SelectedItem()
    {
        CursoDto selectedItem;

        selectedItem = (CursoDto)EspecialidadGrid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
