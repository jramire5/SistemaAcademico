using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms;

public partial class MenuPrincipal : Form
{
    public MenuPrincipal()
    {
        InitializeComponent();
    }

    private void personasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PersonasLista personasLista = new PersonasLista();
        personasLista.ShowDialog();
    }
    private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MateriaLista listado = new MateriaLista();
        listado.ShowDialog();
    }
    private void planesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PlanLista listado = new PlanLista();
        listado.ShowDialog();
    }

    private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EspecialidadLista listado = new EspecialidadLista();
        listado.ShowDialog();
    }

    private void comisionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ComisionLista listado = new ComisionLista();
        listado.ShowDialog();
    }
}
