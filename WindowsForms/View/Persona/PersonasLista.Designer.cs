namespace WindowsForms
{
    partial class PersonasLista
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
            personaDataGrid = new DataGridView();
            btn_agregar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)personaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // personaDataGrid
            // 
            personaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personaDataGrid.Location = new Point(34, 33);
            personaDataGrid.Name = "personaDataGrid";
            personaDataGrid.Size = new Size(754, 290);
            personaDataGrid.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(518, 339);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(619, 339);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(713, 339);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_click;
            // 
            // PersonasLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(personaDataGrid);
            Name = "PersonasLista";
            Text = "Form1";
            Load += PersonasLista_Load;
            ((System.ComponentModel.ISupportInitialize)personaDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personaDataGrid;
        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_eliminar;
    }
}