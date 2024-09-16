namespace WindowsForms.View.Usuario
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
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            dataGridView1 = new DataGridView();
            usuarioBindingSource = new BindingSource(components);
            idusuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreusuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claveDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cambiaclaveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            idpersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(683, 346);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(589, 346);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(488, 346);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idusuarioDataGridViewTextBoxColumn, nombreusuarioDataGridViewTextBoxColumn, claveDataGridViewTextBoxColumn, cambiaclaveDataGridViewCheckBoxColumn, idpersonaDataGridViewTextBoxColumn, personaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = usuarioBindingSource;
            dataGridView1.Location = new Point(60, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(637, 281);
            dataGridView1.TabIndex = 7;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Domain.Model.Usuario);
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            nombreusuarioDataGridViewTextBoxColumn.HeaderText = "nombre_usuario";
            nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            claveDataGridViewTextBoxColumn.HeaderText = "clave";
            claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // cambiaclaveDataGridViewCheckBoxColumn
            // 
            cambiaclaveDataGridViewCheckBoxColumn.DataPropertyName = "cambia_clave";
            cambiaclaveDataGridViewCheckBoxColumn.HeaderText = "cambia_clave";
            cambiaclaveDataGridViewCheckBoxColumn.Name = "cambiaclaveDataGridViewCheckBoxColumn";
            // 
            // idpersonaDataGridViewTextBoxColumn
            // 
            idpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona";
            idpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona";
            idpersonaDataGridViewTextBoxColumn.Name = "idpersonaDataGridViewTextBoxColumn";
            // 
            // personaDataGridViewTextBoxColumn
            // 
            personaDataGridViewTextBoxColumn.DataPropertyName = "persona";
            personaDataGridViewTextBoxColumn.HeaderText = "persona";
            personaDataGridViewTextBoxColumn.Name = "personaDataGridViewTextBoxColumn";
            // 
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Name = "UsuarioLista";
            Text = "UsuarioLista";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn cambiaclaveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn idpersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personaDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
    }
}