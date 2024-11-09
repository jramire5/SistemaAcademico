using Domain.Model.Dtos;
using Domain.Model;
using WindowsForms.ApiServices;
using System.Windows.Forms;
using System.Drawing.Text;

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
        if(!FilaSeleccionada())
        {
            MessageBox.Show("Por favor seleccione una fila.", ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var entidad = this.SelectedItem();

        UsuarioDetalle detalle = new UsuarioDetalle();
        
        // personaDetalle.editMode = true;
        detalle.Usuario = await UsuarioApiClient.GetAsync(entidad.id_usuario); 

        detalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_usuario;
        await UsuarioApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    { 
        this.Grid.DataSource = null;
        this.Grid.DataSource = await UsuarioApiClient.GetAllAsync();

        if (this.Grid.Rows.Count > 0)
        {
            this.Grid.Rows[0].Selected = true;
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;
            this.Grid.Columns[0].HeaderText = "Id";
            this.Grid.Columns[1].HeaderText = "Usuario";
            this.Grid.Columns[2].HeaderText = "Nombre";
            this.Grid.Columns[3].HeaderText = "Apellido";
            this.Grid.Columns[4].HeaderText = "Email";
        }
        else
        {
            this.btn_eliminar.Enabled = false;
            this.btn_modificar.Enabled = false;
        }
    }

    private bool FilaSeleccionada()=> !((Grid.SelectedRows is null || Grid.SelectedRows.Count==0) && Grid.CurrentCell.RowIndex < 0);
           
    

    private UsuarioDto SelectedItem()
    { 
        if(Grid.SelectedRows is not null && Grid.SelectedRows.Count > 0)        
           return (UsuarioDto)Grid.SelectedRows[0].DataBoundItem;
        

        if(Grid.CurrentCell.RowIndex>=0)
            return (UsuarioDto)Grid.CurrentCell.OwningRow.DataBoundItem;

        return null;
    }


}
