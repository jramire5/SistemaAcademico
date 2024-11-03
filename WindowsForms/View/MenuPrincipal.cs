using WindowsForms.View.Usuarios;

namespace WindowsForms;

public partial class MenuPrincipal : Form
{
    public MenuPrincipal()
    {
        InitializeComponent();
    }
    private void formMain_Shown(object sender, EventArgs e)
    {
        formLogin appLogin = new formLogin();
        if (appLogin.ShowDialog() != DialogResult.OK)
        {
            this.Dispose();
        }
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

    private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CursosLista listado = new CursosLista();
        listado.ShowDialog();
    }

    private void docenteCursosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DocenteCursoLista listado = new DocenteCursoLista();
        listado.ShowDialog();
    }

    private void alumnoInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AlumnoInscripcionLista listado = new AlumnoInscripcionLista();
        listado.ShowDialog();
    }

    private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        UsuarioLista listado = new UsuarioLista();
        listado.ShowDialog();
    }

    private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ModuloLista listado = new ModuloLista();
        listado.ShowDialog();
    }

    private void modulosUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ModuloUsuarioLista listado = new ModuloUsuarioLista();
        listado.ShowDialog();
    }
}
