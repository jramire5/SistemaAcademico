using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
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
            this.txtTelefono.Text = this.Persona.telefono.ToString();
           // this.datetimeFechaNacimiento.Value = this.Persona.fecha_nacimiento;
        }


        private async void Aceptar_Click(object sender, EventArgs e)
        {
            PersonaApiClient persona = new PersonaApiClient();
            //if (this.ValidateCliente())
            this.persona.nombre = txtnombre.Text;
            this.persona.apellido = txtapellido.Text;
            this.persona.direccion = txtdireccion.Text;
            this.persona.email = txtemail.Text;
            this.persona.telefono = int.Parse(txtTelefono.Text);
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



         
    }
}
