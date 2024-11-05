﻿using Domain.Model;

using WindowsForms.ApiServices;

namespace WindowsForms;

public partial class MateriaLista : Form
{
    public MateriaLista()
    {
        InitializeComponent();
    }

    private void MateriaLista_Load(object sender, EventArgs e)
    {
        this.GetAllAndLoad();
    }
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        MateriaDetalle materiaDetalle = new MateriaDetalle();

        Materia materiaNueva = new Materia();

        materiaDetalle.Materia = materiaNueva;

        materiaDetalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_modificar_click(object sender, EventArgs e)
    {

        MateriaDetalle materiaDetalle = new MateriaDetalle();

        int id;

        id = this.SelectedItem().id_materia;

        Materia materia = await MateriaApiClient.GetAsync(id);

        // personaDetalle.editMode = true;
        materiaDetalle.Materia = materia;

        materiaDetalle.ShowDialog();

        this.GetAllAndLoad();
    }

    private async void btn_eliminar_click(object sender, EventArgs e)
    {
        int id;

        id = this.SelectedItem().id_materia;
        await MateriaApiClient.DeleteAsync(id);

        this.GetAllAndLoad();
    }

    private async void GetAllAndLoad()
    {
        MateriaApiClient clienteApi = new MateriaApiClient();

        this.MateriasGrid.DataSource = null;
        this.MateriasGrid.DataSource = await MateriaApiClient.GetAllAsync();

        if (this.MateriasGrid.Rows.Count > 0)
        {
            this.MateriasGrid.Rows[0].Selected = true;
            this.btnEliminar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.MateriasGrid.Columns[0].HeaderText = "Id";
            this.MateriasGrid.Columns[1].HeaderText = "Descripción";
            this.MateriasGrid.Columns[2].HeaderText = "Horas Semanales";
            this.MateriasGrid.Columns[3].HeaderText = "Horas Totales";
            this.MateriasGrid.Columns[4].HeaderText = "Plan";
        }
        else
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
        }
    }

    private MateriaDto SelectedItem()
    {
        MateriaDto materia;

        materia = (MateriaDto)MateriasGrid.SelectedRows[0].DataBoundItem;

        return materia;
    }

}
