using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class NotaLista : Form
{
    public NotaLista()
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
        NotaDetalle detalle = new NotaDetalle();

        detalle.Entidad = new NotaUpdateDto();

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        NotaDetalle detalle = new NotaDetalle();

        int id;

        id = this.SelectedItem().id_nota;

        Nota registroModifica = await NotaApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        detalle.Entidad = registroModifica;

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_nota;
        await NotaApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {    
        this.Grid.DataSource = null;
        this.Grid.DataSource = await NotaApiClient.GetAllAsync();

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
        this.Grid.Columns[1].HeaderText = "Docente";
        this.Grid.Columns[2].HeaderText = "Materia";
        this.Grid.Columns[3].HeaderText = "Comisión";
        this.Grid.Columns[4].HeaderText = "Año";
        this.Grid.Columns[5].HeaderText = "Evaluación";
        this.Grid.Columns[6].HeaderText = "Alumno";
        this.Grid.Columns[7].HeaderText = "Nota";
    }

    private NotaDto SelectedItem()
    {
        NotaDto registro;

        registro = (NotaDto)Grid.SelectedRows[0].DataBoundItem;

        return registro;
    }

}
