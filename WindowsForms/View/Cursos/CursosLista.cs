using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class CursosLista : Form
{
    public CursosLista()
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

        this.Grid.DataSource = null;
        this.Grid.DataSource = await CursoApiClient.GetAllAsync();

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;

            this.Grid.Columns[0].HeaderText = "Id";
            this.Grid.Columns[1].HeaderText = "Año";
            this.Grid.Columns[2].HeaderText = "Cupo";
            this.Grid.Columns[3].HeaderText = "Materia";
            this.Grid.Columns[4].HeaderText = "Comisión";

        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
    }

    private CursoDto SelectedItem()
    {
        CursoDto selectedItem;

        selectedItem = (CursoDto)Grid.SelectedRows[0].DataBoundItem;

        return selectedItem;
    }

}
