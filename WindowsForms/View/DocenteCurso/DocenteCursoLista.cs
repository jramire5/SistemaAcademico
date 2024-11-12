using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class DocenteCursoLista : Form
{
    public DocenteCursoLista()
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
        this.Grid.DataSource = await DocenteCursoApiClient.GetAllAsync(UsuarioAutenticadoService.usuarioAutenticado.id_persona ?? 0);

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
        this.Grid.Columns[1].HeaderText = "Materia";
        this.Grid.Columns[2].HeaderText = "Comisión";
        this.Grid.Columns[3].HeaderText = "Año";
        this.Grid.Columns[4].HeaderText = "Docente";
        this.Grid.Columns[5].HeaderText = "Cargo";
    }

    private DocenteDictadoDto SelectedItem()
    {
        DocenteDictadoDto registro;

        registro = (DocenteDictadoDto)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
