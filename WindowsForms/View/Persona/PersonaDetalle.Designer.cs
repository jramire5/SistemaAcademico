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
            cmbtipo_persona = new ComboBox();
            lbltipo = new Label();
            cmbPlan = new ComboBox();
            lblplan = new Label();
            Errores = new Label();
            SuspendLayout();
            // 
            // txtid_persona
            // 
            txtid_persona.Enabled = false;
            txtid_persona.Location = new Point(194, 43);
            txtid_persona.Name = "txtid_persona";
            txtid_persona.Size = new Size(100, 23);
            txtid_persona.TabIndex = 0;
            // 
            // lblid_persona
            // 
            lblid_persona.AutoSize = true;
            lblid_persona.Location = new Point(61, 51);
            lblid_persona.Name = "lblid_persona";
            lblid_persona.Size = new Size(65, 15);
            lblid_persona.TabIndex = 1;
            lblid_persona.Text = "Id Persona ";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(61, 92);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(59, 15);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "Nombre *";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(194, 84);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 2;
            txtnombre.TextChanged += cambianDatos;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(61, 133);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(51, 15);
            lblapellido.TabIndex = 5;
            lblapellido.Text = "Apellido";
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(194, 125);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 4;
            txtapellido.TextChanged += cambianDatos;
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Location = new Point(61, 168);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new Size(57, 15);
            lbldireccion.TabIndex = 7;
            lbldireccion.Text = "Direccion";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(194, 165);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(100, 23);
            txtdireccion.TabIndex = 6;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(61, 209);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(44, 15);
            lblemail.TabIndex = 9;
            lblemail.Text = "Email *";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(194, 206);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(100, 23);
            txtemail.TabIndex = 8;
            txtemail.TextChanged += cambianDatos;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(61, 250);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(194, 247);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 10;
            // 
            // lblFecha_Nacimiento
            // 
            lblFecha_Nacimiento.AutoSize = true;
            lblFecha_Nacimiento.Location = new Point(61, 290);
            lblFecha_Nacimiento.Name = "lblFecha_Nacimiento";
            lblFecha_Nacimiento.Size = new Size(117, 15);
            lblFecha_Nacimiento.TabIndex = 13;
            lblFecha_Nacimiento.Text = "Fecha de nacimiento";
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(65, 339);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 14;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(156, 339);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 15;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += btnCancelar_Click;
            // 
            // datetimeFechaNacimiento
            // 
            datetimeFechaNacimiento.Location = new Point(194, 290);
            datetimeFechaNacimiento.Name = "datetimeFechaNacimiento";
            datetimeFechaNacimiento.Size = new Size(238, 23);
            datetimeFechaNacimiento.TabIndex = 16;
            // 
            // cmbtipo_persona
            // 
            cmbtipo_persona.FormattingEnabled = true;
            cmbtipo_persona.Location = new Point(541, 49);
            cmbtipo_persona.Margin = new Padding(3, 2, 3, 2);
            cmbtipo_persona.Name = "cmbtipo_persona";
            cmbtipo_persona.Size = new Size(199, 23);
            cmbtipo_persona.TabIndex = 11;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(430, 55);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(83, 15);
            lbltipo.TabIndex = 18;
            lbltipo.Text = "Tipo Persona *";
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(541, 86);
            cmbPlan.Margin = new Padding(3, 2, 3, 2);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(199, 23);
            cmbPlan.TabIndex = 12;
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(430, 89);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(38, 15);
            lblplan.TabIndex = 20;
            lblplan.Text = "Plan *";
            // 
            // Errores
            // 
            Errores.AutoSize = true;
            Errores.ForeColor = Color.Red;
            Errores.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            Errores.Location = new Point(65, 379);
            Errores.Name = "Errores";
            Errores.Size = new Size(10, 15);
            Errores.TabIndex = 21;
            Errores.Text = " ";
            // 
            // PersonaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(Errores);
            Controls.Add(lblplan);
            Controls.Add(cmbPlan);
            Controls.Add(lbltipo);
            Controls.Add(cmbtipo_persona);
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
        private ComboBox cmbtipo_persona;
        private Label label1;
        private ComboBox cmbPlan;
        private Label label2;
        private Label Errores;
        private Label bltipo;
        private Label lblplan;
        private Label lbltipo;
    }
}