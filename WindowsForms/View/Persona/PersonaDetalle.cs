using Domain.Model;
using WindowsForms.APIServices;

namespace WindowsForms;

public partial class PersonaDetalle : Form
{

    private Persona persona;

    public Persona Persona
    {
        get { return persona; }
        set
        {
            persona = value;
            this.SetPersona();
        }
    }

    public PersonaDetalle()
    {
        InitializeComponent();
    }

    private void SetPersona()
    {
        this.txtid_persona.Text = this.Persona.id_persona.ToString();
        this.txtnombre.Text = this.Persona.nombre;
        this.txtapellido.Text = this.Persona.apellido;
        this.txtdireccion.Text = this.Persona.direccion;
        this.txtemail.Text = this.Persona.email;
        this.txtTelefono.Text = this.Persona.telefono;
        if (this.Persona.fecha_nacimiento == DateTime.MinValue)
            this.datetimeFechaNacimiento.Value = DateTime.Now;
        else
            this.datetimeFechaNacimiento.Value = this.Persona.fecha_nacimiento;
    }


    private async void Aceptar_Click(object sender, EventArgs e)
    {
        PersonaApiClient persona = new PersonaApiClient();
        //if (this.ValidateCliente())
        this.persona.nombre = txtnombre.Text;
        this.persona.apellido = txtapellido.Text;
        this.persona.direccion = txtdireccion.Text;
        this.persona.email = txtemail.Text;
        this.persona.telefono = txtTelefono.Text;
        this.persona.fecha_nacimiento = datetimeFechaNacimiento.Value;


        if (txtid_persona.Text == "" || txtid_persona.Text.Length == 0 || txtid_persona.Text == "0")
        {
            await PersonaApiClient.AddAsync(this.persona);

        }
        else
        {
            await PersonaApiClient.UpdateAsync(this.persona);

        }

        this.Close();
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
