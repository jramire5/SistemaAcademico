namespace WindowsForms.View.Usuarios
{
    partial class UsuarioLista
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
            components = new System.ComponentModel.Container();
            usuarioBindingSource = new BindingSource(components);
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            Grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Domain.Model.Usuario);
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(735, 329);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(86, 31);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(627, 329);
            btn_modificar.Margin = new Padding(3, 4, 3, 4);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(86, 31);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(512, 329);
            btn_agregar.Margin = new Padding(3, 4, 3, 4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(86, 31);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Location = new Point(27, 30);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.Size = new Size(828, 281);
            Grid.TabIndex = 7;
            // 
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Grid);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsuarioLista";
            Text = "Usuario Lista";
            Load += Lista_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource usuarioBindingSource;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private DataGridView Grid;
    }
}