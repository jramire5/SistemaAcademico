using Domain.Model;
using WindowsForms.ApiServices;

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

    private async void SetPersona()
    {
        this.txtid_persona.Text = this.Persona.id_persona.ToString();
        this.txtnombre.Text = this.Persona.nombre;
        this.txtapellido.Text = this.Persona.apellido;
        this.txtdireccion.Text = this.Persona.direccion;
        this.txtemail.Text = this.Persona.email;
        this.txtTelefono.Text = this.Persona.telefono;


        this.cmbtipo_persona.DataSource = await TipoPersonaApiClient.GetAllAsync();
        this.cmbtipo_persona.DisplayMember = "descripcion";
        this.cmbtipo_persona.ValueMember = "id_tipo";

        this.cmbPlan.DataSource = await PlanApiClient.GetDropDownValuesAsync();
        this.cmbPlan.DisplayMember = "desc_plan_especialidad";
        this.cmbPlan.ValueMember = "id_plan";

        this.cmbPlan.SelectedValue = this.Persona.id_plan ?? 0;
        this.cmbtipo_persona.SelectedValue = this.Persona.tipo_persona ?? 0;

        if (this.Persona.fecha_nacimiento == DateTime.MinValue)
            this.datetimeFechaNacimiento.Value = DateTime.Now;
        else
            this.datetimeFechaNacimiento.Value = this.Persona.fecha_nacimiento;
    }


    private async void Aceptar_Click(object sender, EventArgs e)
    {
        PersonaApiClient persona = new PersonaApiClient();
        
        this.persona.nombre = txtnombre.Text;
        this.persona.apellido = txtapellido.Text;
        this.persona.direccion = txtdireccion.Text;
        this.persona.email = txtemail.Text;
        this.persona.telefono = txtTelefono.Text;
        this.persona.fecha_nacimiento = datetimeFechaNacimiento.Value;

        this.persona.tipo_persona = (int?)this.cmbtipo_persona.SelectedValue;
        
        this.persona.id_plan = (int?)this.cmbPlan.SelectedValue;

        if (ValidaPersona(sender, e) == true)
        {
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
        else { 
            Errores.Visible = true;
        }
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void cambianDatos(object sender, EventArgs e)
    {
        Errores.Visible = false;
        lbltipo.ForeColor = Color.Black;
        lblnombre.ForeColor = Color.Black;
        lblemail.ForeColor = Color.Black;
        lblplan.ForeColor = Color.Black;
    }

    private bool ValidaPersona(object sender, EventArgs e)
    {
        bool valid = true;
        Errores.Text = string.Empty;
        if (txtnombre.Text.Length == 0)
        {
            valid = false;
            lblnombre.ForeColor = Color.Red;
            Errores.Text = Errores.Text + "Nombre es requerido \n"; 
        };
        if (txtemail.Text.Length == 0)
        {
            valid = false;
            lblemail.ForeColor = Color.Red;
            Errores.Text = Errores.Text + "Email es requerido \n";
        };
        if (cmbtipo_persona.SelectedIndex == -1) 
        {
            valid = false;
            lbltipo.ForeColor = Color.Red;
            Errores.Text = Errores.Text + "Tipo de persona es requerido\n";
        }
        if (cmbPlan.SelectedIndex == -1) {
            valid = false;
            lblplan.ForeColor = Color.Red;
            Errores.Text = Errores.Text + "Plan Es requerido";
            }
        return valid;
    }
}
