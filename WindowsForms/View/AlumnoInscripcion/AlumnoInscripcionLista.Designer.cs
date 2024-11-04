namespace WindowsForms;

partial class AlumnoInscripcionLista
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
        btnAceptar = new Button();
        btnModificar = new Button();
        btnEliminar = new Button();
        ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
        SuspendLayout();
        // 
        // Grid
        // 
        Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        Grid.Location = new Point(60, 58);
        Grid.Name = "Grid";
        Grid.RowHeadersWidth = 51;
        Grid.Size = new Size(797, 350);
        Grid.TabIndex = 0;
        // 
        // btnAceptar
        // 
        btnAceptar.Location = new Point(377, 458);
        btnAceptar.Name = "btnAceptar";
        btnAceptar.Size = new Size(94, 29);
        btnAceptar.TabIndex = 1;
        btnAceptar.Text = "Agregar";
        btnAceptar.UseVisualStyleBackColor = true;
        btnAceptar.Click += btn_agregar_Click;
        // 
        // btnModificar
        // 
        btnModificar.Location = new Point(494, 458);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new Size(94, 29);
        btnModificar.TabIndex = 2;
        btnModificar.Text = "Modificar";
        btnModificar.UseVisualStyleBackColor = true;
        btnModificar.Click += btn_modificar_click;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new Point(618, 458);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(94, 29);
        btnEliminar.TabIndex = 3;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btn_eliminar_click;
        // 
        // AlumnoInscripcionLista
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(btnEliminar);
        Controls.Add(btnModificar);
        Controls.Add(btnAceptar);
        Controls.Add(Grid);
        Margin = new Padding(3, 4, 3, 4);
        Name = "AlumnoInscripcionLista";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Inscripciones Lista";
        Load += Lista_Load;
        ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView Grid;
    private Button btnAceptar;
    private Button btnModificar;
    private Button btnEliminar;
}