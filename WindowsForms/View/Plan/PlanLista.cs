using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

namespace WindowsForms;

public partial class PlanLista : Form
{
    public PlanLista()
    {
        InitializeComponent();
        btn_agregar.Enabled = UsuarioAutenticadoService.AccedeAAlta(this.Name);      
    }

    private void MateriaLista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        PlanDetalle planDetalle = new PlanDetalle();

        Plan planNueva = new Plan();

        planDetalle.Plan = planNueva;

        planDetalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        PlanDetalle planDetalle = new PlanDetalle();

        int id;

        id = this.SelectedItem().id_plan;

        Plan plan = await PlanApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        planDetalle.Plan = plan;

        planDetalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_plan;
        await PlanApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {
        PlanApiClient clienteApi = new PlanApiClient();

        this.PlanGrid.DataSource = null;
        this.PlanGrid.DataSource = await PlanApiClient.GetAllAsync();

        if (this.PlanGrid.Rows.Count > 0)
        {
            this.PlanGrid.Rows[0].Selected = true;
            btn_modificar.Enabled = UsuarioAutenticadoService.AccedeAModificar(this.Name);
            btn_eliminar.Enabled = UsuarioAutenticadoService.AccedeABaja(this.Name);          
        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
        this.PlanGrid.Columns[0].HeaderText = "Id";
        this.PlanGrid.Columns[1].HeaderText = "Año Plan";
        this.PlanGrid.Columns[2].HeaderText = "Especialidad";
    }

    private PlanDto SelectedItem()
    {
        PlanDto plan;

        plan = (PlanDto)PlanGrid.SelectedRows[0].DataBoundItem;

        return plan;
    }

}
