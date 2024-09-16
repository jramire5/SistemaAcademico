namespace WindowsForms.View.Usuario
{
    partial class UsuarioDetalle
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
            lblcambiaclave = new Label();
            lblapellido = new Label();
            txtclave = new TextBox();
            lblnombreusu = new Label();
            txtnombreusu = new TextBox();
            lblid_usuario = new Label();
            txtid_usuario = new TextBox();
            lblid_persona = new Label();
            txtid_persona = new TextBox();
            Cancelar = new Button();
            Aceptar = new Button();
            checkBoxCambiaClave = new CheckBox();
            comboPersona = new ComboBox();
            personaApiClientBindingSource = new BindingSource(components);
            personaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)personaApiClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblcambiaclave
            // 
            lblcambiaclave.AutoSize = true;
            lblcambiaclave.Location = new Point(214, 168);
            lblcambiaclave.Name = "lblcambiaclave";
            lblcambiaclave.Size = new Size(80, 15);
            lblcambiaclave.TabIndex = 24;
            lblcambiaclave.Text = "Cambia Clave";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(214, 133);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(36, 15);
            lblapellido.TabIndex = 22;
            lblapellido.Text = "Clave";
            // 
            // txtclave
            // 
            txtclave.Location = new Point(347, 125);
            txtclave.MaxLength = 16;
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(100, 23);
            txtclave.TabIndex = 21;
            txtclave.UseSystemPasswordChar = true;
            // 
            // lblnombreusu
            // 
            lblnombreusu.AutoSize = true;
            lblnombreusu.Location = new Point(214, 92);
            lblnombreusu.Name = "lblnombreusu";
            lblnombreusu.Size = new Size(110, 15);
            lblnombreusu.TabIndex = 20;
            lblnombreusu.Text = "Nombre de Usuario";
            // 
            // txtnombreusu
            // 
            txtnombreusu.Location = new Point(347, 84);
            txtnombreusu.Name = "txtnombreusu";
            txtnombreusu.Size = new Size(100, 23);
            txtnombreusu.TabIndex = 19;
            // 
            // lblid_usuario
            // 
            lblid_usuario.AutoSize = true;
            lblid_usuario.Location = new Point(214, 51);
            lblid_usuario.Name = "lblid_usuario";
            lblid_usuario.Size = new Size(60, 15);
            lblid_usuario.TabIndex = 18;
            lblid_usuario.Text = "Id Usuario";
            lblid_usuario.Click += lblid_usuario_Click;
            // 
            // txtid_usuario
            // 
            txtid_usuario.Location = new Point(347, 43);
            txtid_usuario.Name = "txtid_usuario";
            txtid_usuario.Size = new Size(100, 23);
            txtid_usuario.TabIndex = 17;
            // 
            // lblid_persona
            // 
            lblid_persona.AutoSize = true;
            lblid_persona.Location = new Point(214, 219);
            lblid_persona.Name = "lblid_persona";
            lblid_persona.Size = new Size(62, 15);
            lblid_persona.TabIndex = 32;
            lblid_persona.Text = "Id Persona";
            // 
            // txtid_persona
            // 
            txtid_persona.Location = new Point(347, 211);
            txtid_persona.Name = "txtid_persona";
            txtid_persona.Size = new Size(100, 23);
            txtid_persona.TabIndex = 31;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(340, 309);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 34;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(259, 309);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 33;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            // 
            // checkBoxCambiaClave
            // 
            checkBoxCambiaClave.AutoSize = true;
            checkBoxCambiaClave.Location = new Point(374, 169);
            checkBoxCambiaClave.Name = "checkBoxCambiaClave";
            checkBoxCambiaClave.Size = new Size(15, 14);
            checkBoxCambiaClave.TabIndex = 35;
            checkBoxCambiaClave.UseVisualStyleBackColor = true;
            checkBoxCambiaClave.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboPersona
            // 
            comboPersona.DataSource = personaBindingSource;
            comboPersona.DisplayMember = "nombre";
            comboPersona.FormattingEnabled = true;
            comboPersona.Location = new Point(468, 211);
            comboPersona.Name = "comboPersona";
            comboPersona.Size = new Size(121, 23);
            comboPersona.TabIndex = 36;
            comboPersona.ValueMember = "id_persona";
            comboPersona.SelectedIndexChanged += comboPersona_SelectedIndexChanged;
            // 
            // personaApiClientBindingSource
            // 
            personaApiClientBindingSource.DataSource = typeof(WindowsForms.PersonaApiClient);
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Domain.Model.Persona);
            // 
            // UsuarioDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboPersona);
            Controls.Add(checkBoxCambiaClave);
            Controls.Add(Cancelar);
            Controls.Add(Aceptar);
            Controls.Add(lblid_persona);
            Controls.Add(txtid_persona);
            Controls.Add(lblcambiaclave);
            Controls.Add(lblapellido);
            Controls.Add(txtclave);
            Controls.Add(lblnombreusu);
            Controls.Add(txtnombreusu);
            Controls.Add(lblid_usuario);
            Controls.Add(txtid_usuario);
            Name = "UsuarioDetalle";
            Text = "UsuarioDetalle";
            Load += UsuarioDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)personaApiClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblemail;
        private TextBox txtemail;
        private Label lblcambiaclave;
        private TextBox txtdireccion;
        private Label lblapellido;
        private TextBox txtclave;
        private Label lblnombreusu;
        private TextBox txtnombreusu;
        private Label lblid_usuario;
        private TextBox txtid_usuario;
        private Label lblid_persona;
        private TextBox txtid_persona;
        private Button Cancelar;
        private Button Aceptar;
        private CheckBox checkBoxCambiaClave;
        private ComboBox comboPersona;
        private BindingSource personaBindingSource;
        private BindingSource personaApiClientBindingSource;
    }
}