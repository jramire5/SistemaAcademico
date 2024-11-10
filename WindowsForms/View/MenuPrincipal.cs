using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.View.Usuarios;

namespace WindowsForms;

public partial class MenuPrincipal : Form
{
    public MenuPrincipal()
    {
        InitializeComponent();
      //  menuStrip1.Items.Clear();
    }
   
 
    private void formMain_Shown(object sender, EventArgs e)
    {
        formLogin appLogin = new formLogin();
        if (appLogin.ShowDialog() != DialogResult.OK)
        {
            this.Dispose();
        }
        else
        {
            MenuDinamico();
        }
    }
    private async void MenuDinamico()
    {
        menuStrip1.Items.Clear();

        IEnumerable<MenuItemDto> menuItems = await ModuloUsuarioApiClient.GetMenuItemsAsync(UsuarioAutenticado.idUsuarioAutenticado);//Carga los menú de los usuarios autenticados.
        foreach (MenuItemDto item in menuItems.OrderBy(i => i.secuencia))
        {
            ToolStripMenuItem mItem = new ToolStripMenuItem();
            mItem.Name = item.label;
            mItem.Size = new Size(80, 24);
            mItem.Text = item.label;
            mItem.Click += async (sender, e) => await MenuItem_Click(sender, e, item.ejecuta);
            menuStrip1.Items.Add(mItem);
        }
    }
    private async Task MenuItem_Click(object sender, EventArgs e, string formName)
    {
        // Use reflection to find the type of the form by name
        Type formType = Type.GetType("WindowsForms." + formName);

        if (formType != null)
        {
            // Create an instance of the form
            Form formInstance = (Form)Activator.CreateInstance(formType);

            // Show the form
            formInstance.Show();
        }
        else
        {
            MessageBox.Show($"Form '{formName}' not found.");
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
