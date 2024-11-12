using Domain.Model.Dtos;
using WindowsForms.ApiServices;
using WindowsForms.Servicios;

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
            this.Dispose();
        else
            MenuDinamico();

    }
    private async void MenuDinamico()
    {
        menuStrip1.Items.Clear();
        menuStrip1.Items.Add(salirToolStripMenuItem);
        IEnumerable<MenuItemDto> menuItems = await ModuloUsuarioApiClient.GetMenuItemsAsync(UsuarioAutenticadoService.usuarioAutenticado.id_usuario);//Carga los menú de los usuarios autenticados.
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

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        menuStrip1.Items.Clear();
        menuStrip1.Items.Add(salirToolStripMenuItem);

        formLogin appLogin = new formLogin();
        if (appLogin.ShowDialog() != DialogResult.OK)
            this.Dispose();
        else
            MenuDinamico();
    }
}
