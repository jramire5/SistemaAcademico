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
    public partial class MateriaDetalle : Form
    {
        private Materia materia;

        public Materia Materia
        {
            get { return persona; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }
        public MateriaDetalle()
        {
            InitializeComponent();
        }
        private void SetMateria()
        {
           /* this.txtid_persona.Text = this.Persona.id_persona.ToString();
            this.txtnombre.Text = this.Persona.nombre;
            this.txtapellido.Text = this.Persona.apellido;
            this.txtdireccion.Text = this.Persona.direccion;
            this.txtemail.Text = this.Persona.email;
            this.txtTelefono.Text = this.Persona.telefono.ToString();*/
            // this.datetimeFechaNacimiento.Value = this.Persona.fecha_nacimiento;
        }
    }
}
