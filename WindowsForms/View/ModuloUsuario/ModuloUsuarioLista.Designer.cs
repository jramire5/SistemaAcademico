namespace WindowsForms;

partial class ModuloUsuarioLista
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Grid = new DataGridView();
        btn_agregar = new Button();
        btn_modificar = new Button();
        btn_eliminar = new Button();
        ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
        SuspendLayout();
        // 
        // Grid
        // 
        Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        Grid.Location = new Point(52, 58);
        Grid.Name = "Grid";
        Grid.RowHeadersWidth = 51;
        Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        Grid.Size = new Size(1052, 350);
        Grid.TabIndex = 0;
        // 
        // btnAceptar
        // 
        btn_agregar.Location = new Point(759, 443);
        btn_agregar.Name = "btnAceptar";
        btn_agregar.Size = new Size(94, 29);
        btn_agregar.TabIndex = 1;
        btn_agregar.Text = "Agregar";
        btn_agregar.UseVisualStyleBackColor = true;
        btn_agregar.Click += btn_agregar_Click;
        // 
        // btnModificar
        // 
        btn_modificar.Location = new Point(882, 443);
        btn_modificar.Name = "btnModificar";
        btn_modificar.Size = new Size(94, 29);
        btn_modificar.TabIndex = 2;
        btn_modificar.Text = "Modificar";
        btn_modificar.UseVisualStyleBackColor = true;
        btn_modificar.Click += btn_modificar_click;
        // 
        // btnEliminar
        // 
        btn_eliminar.Location = new Point(1010, 443);
        btn_eliminar.Name = "btnEliminar";
        btn_eliminar.Size = new Size(94, 29);
        btn_eliminar.TabIndex = 3;
        btn_eliminar.Text = "Eliminar";
        btn_eliminar.UseVisualStyleBackColor = true;
        btn_eliminar.Click += btn_eliminar_click;
        // 
        // ModuloUsuarioLista
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1157, 600);
        Controls.Add(btn_eliminar);
        Controls.Add(btn_modificar);
        Controls.Add(btn_agregar);
        Controls.Add(Grid);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ModuloUsuarioLista";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Modulo Usuario Lista";
        Load += Lista_Load;
        ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView Grid;
    private Button btn_agregar;
    private Button btn_modificar;
    private Button btn_eliminar;
}