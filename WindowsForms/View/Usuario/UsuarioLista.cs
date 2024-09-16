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
using WindowsForms.APIServices;

namespace WindowsForms.View.Usuario
{
    public partial class UsuarioLista : Form
    {
        public UsuarioLista()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            UsuarioDetalle usuarioDetalle = new UsuarioDetalle();

            Usuario nuevoUsuario = new Usuario();

            usuarioDetalle.usuario = nuevoUsuario;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            PersonaApiClient clienteApi = new PersonaApiClient();
/*
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
                this.btn_eliminar.Enabled = false;
                this.btn_modificar.Enabled = false;
            }*/
        }
    }
}
