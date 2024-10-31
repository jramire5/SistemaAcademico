namespace WindowsForms
{
    partial class PersonaDetalle
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
            txtid_persona = new TextBox();
            lblid_persona = new Label();
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblapellido = new Label();
            txtapellido = new TextBox();
            lbldireccion = new Label();
            txtdireccion = new TextBox();
            lblemail = new Label();
            txtemail = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblFecha_Nacimiento = new Label();
            Aceptar = new Button();
            Cancelar = new Button();
            datetimeFechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // txtid_persona
            // 
            txtid_persona.Enabled = false;
            txtid_persona.Location = new Point(222, 57);
            txtid_persona.Margin = new Padding(3, 4, 3, 4);
            txtid_persona.Name = "txtid_persona";
            txtid_persona.Size = new Size(114, 27);
            txtid_persona.TabIndex = 0;
            // 
            // lblid_persona
            // 
            lblid_persona.AutoSize = true;
            lblid_persona.Location = new Point(70, 68);
            lblid_persona.Name = "lblid_persona";
            lblid_persona.Size = new Size(77, 20);
            lblid_persona.TabIndex = 1;
            lblid_persona.Text = "Id Persona";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(70, 123);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(64, 20);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(222, 112);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(114, 27);
            txtnombre.TabIndex = 2;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(70, 177);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(66, 20);
            lblapellido.TabIndex = 5;
            lblapellido.Text = "Apellido";
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(222, 167);
            txtapellido.Margin = new Padding(3, 4, 3, 4);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(114, 27);
            txtapellido.TabIndex = 4;
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Location = new Point(70, 224);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new Size(72, 20);
            lbldireccion.TabIndex = 7;
            lbldireccion.Text = "Direccion";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(222, 220);
            txtdireccion.Margin = new Padding(3, 4, 3, 4);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(114, 27);
            txtdireccion.TabIndex = 6;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(70, 279);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 9;
            lblemail.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(222, 275);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(114, 27);
            txtemail.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(70, 333);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(222, 329);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 27);
            txtTelefono.TabIndex = 10;
            // 
            // lblFecha_Nacimiento
            // 
            lblFecha_Nacimiento.AutoSize = true;
            lblFecha_Nacimiento.Location = new Point(70, 387);
            lblFecha_Nacimiento.Name = "lblFecha_Nacimiento";
            lblFecha_Nacimiento.Size = new Size(146, 20);
            lblFecha_Nacimiento.TabIndex = 13;
            lblFecha_Nacimiento.Text = "Fecha de nacimiento";
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(118, 495);
            Aceptar.Margin = new Padding(3, 4, 3, 4);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(86, 31);
            Aceptar.TabIndex = 14;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(222, 495);
            Cancelar.Margin = new Padding(3, 4, 3, 4);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(86, 31);
            Cancelar.TabIndex = 15;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += btnCancelar_Click;
            // 
            // datetimeFechaNacimiento
            // 
            datetimeFechaNacimiento.Location = new Point(222, 387);
            datetimeFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            datetimeFechaNacimiento.Name = "datetimeFechaNacimiento";
            datetimeFechaNacimiento.Size = new Size(271, 27);
            datetimeFechaNacimiento.TabIndex = 16;
            // 
            // PersonaDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(datetimeFechaNacimiento);
            Controls.Add(Cancelar);
            Controls.Add(Aceptar);
            Controls.Add(lblFecha_Nacimiento);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblemail);
            Controls.Add(txtemail);
            Controls.Add(lbldireccion);
            Controls.Add(txtdireccion);
            Controls.Add(lblapellido);
            Controls.Add(txtapellido);
            Controls.Add(lblnombre);
            Controls.Add(txtnombre);
            Controls.Add(lblid_persona);
            Controls.Add(txtid_persona);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersonaDetalle";
            Text = "Detalle de Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid_persona;
        private Label lblid_persona;
        private Label lblnombre;
        private TextBox txtnombre;
        private Label lblapellido;
        private TextBox txtapellido;
        private Label lbldireccion;
        private TextBox txtdireccion;
        private Label lblemail;
        private TextBox txtemail;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblFecha_Nacimiento;
        private Button Aceptar;
        private Button Cancelar;
        private DateTimePicker datetimeFechaNacimiento;
    }
}