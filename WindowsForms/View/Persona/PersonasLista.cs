using Domain.Model;
using Domain.Model.Dtos;
using WindowsForms.APIServices;

namespace WindowsForms;

public partial class PersonasLista : Form
{
    public PersonasLista()
    {
        InitializeComponent();
    }

      private void btn_agregar_Click(object sender, EventArgs e)
      {
          PersonaDetalle personaDetalle = new PersonaDetalle();

          Persona personaNueva = new Persona();

          personaDetalle.Persona = personaNueva;

          personaDetalle.ShowDialog();

          this.GetAllAndLoad();
      }

       private async void btn_modificar_click(object sender, EventArgs e)
       {

        PersonaDetalle personaDetalle = new PersonaDetalle();

        int id;

        id = this.SelectedItem().id_persona;

           Persona persona = await PersonaApiClient.GetAsync(id);

          // personaDetalle.editMode = true;
           personaDetalle.Persona = persona;

           personaDetalle.ShowDialog();

           this.GetAllAndLoad();
       }

     private async void btn_eliminar_click(object sender, EventArgs e)
     {
        int id;

         id = this.SelectedItem().id_persona;
         await PersonaApiClient.DeleteAsync(id);

         this.GetAllAndLoad();
     }

    private async void GetAllAndLoad()
    {
        PersonaApiClient clienteApi = new PersonaApiClient();

        this.personaDataGrid.DataSource = null;
        this.personaDataGrid.DataSource = await PersonaApiClient.GetAllAsync();

        if (this.personaDataGrid.Rows.Count > 0)
        {
            this.personaDataGrid.Rows[0].Selected = true;
              this.btn_eliminar.Enabled = true;
              this.btn_modificar.Enabled = true;
        }
        else
        {
                this.btn_eliminar.Enabled  = false;
                this.btn_modificar.Enabled = false;
        }
    }

    private PersonaDto SelectedItem()
    {
        PersonaDto persona;

        persona = (PersonaDto)personaDataGrid.SelectedRows[0].DataBoundItem;

        return persona;
    }

    private void PersonasLista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }

}
