namespace WindowsForms
{
    partial class ModuloUsuarioDetalle
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
            label1 = new Label();
            txtIdModuloUsuario = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cmbIdModulo = new ComboBox();
            cmbIdUsuario = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            chkAlta = new CheckBox();
            chkBaja = new CheckBox();
            chkConsulta = new CheckBox();
            chkModificacion = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 51);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtIdModuloUsuario
            // 
            txtIdModuloUsuario.Enabled = false;
            txtIdModuloUsuario.Location = new Point(135, 44);
            txtIdModuloUsuario.Name = "txtIdModuloUsuario";
            txtIdModuloUsuario.Size = new Size(289, 27);
            txtIdModuloUsuario.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(135, 305);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbIdModulo
            // 
            cmbIdModulo.FormattingEnabled = true;
            cmbIdModulo.Location = new Point(137, 84);
            cmbIdModulo.Name = "cmbIdModulo";
            cmbIdModulo.Size = new Size(287, 28);
            cmbIdModulo.TabIndex = 7;
            // 
            // cmbIdUsuario
            // 
            cmbIdUsuario.FormattingEnabled = true;
            cmbIdUsuario.Location = new Point(137, 131);
            cmbIdUsuario.Name = "cmbIdUsuario";
            cmbIdUsuario.Size = new Size(287, 28);
            cmbIdUsuario.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 87);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Modulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 134);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 10;
            label5.Text = "Usuario";
            // 
            // chkAlta
            // 
            chkAlta.AutoSize = true;
            chkAlta.Location = new Point(137, 186);
            chkAlta.Name = "chkAlta";
            chkAlta.Size = new Size(58, 24);
            chkAlta.TabIndex = 11;
            chkAlta.Text = "Alta";
            chkAlta.UseVisualStyleBackColor = true;
            // 
            // chkBaja
            // 
            chkBaja.AutoSize = true;
            chkBaja.Location = new Point(137, 229);
            chkBaja.Name = "chkBaja";
            chkBaja.Size = new Size(60, 24);
            chkBaja.TabIndex = 12;
            chkBaja.Text = "Baja";
            chkBaja.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            chkConsulta.AutoSize = true;
            chkConsulta.Location = new Point(308, 229);
            chkConsulta.Name = "chkConsulta";
            chkConsulta.Size = new Size(88, 24);
            chkConsulta.TabIndex = 13;
            chkConsulta.Text = "Consulta";
            chkConsulta.UseVisualStyleBackColor = true;
            // 
            // chkModificacion
            // 
            chkModificacion.AutoSize = true;
            chkModificacion.Location = new Point(308, 186);
            chkModificacion.Name = "chkModificacion";
            chkModificacion.Size = new Size(118, 24);
            chkModificacion.TabIndex = 14;
            chkModificacion.Text = "Modificacion";
            chkModificacion.UseVisualStyleBackColor = true;
            // 
            // ModuloUsuarioDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 358);
            Controls.Add(chkModificacion);
            Controls.Add(chkConsulta);
            Controls.Add(chkBaja);
            Controls.Add(chkAlta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbIdUsuario);
            Controls.Add(cmbIdModulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtIdModuloUsuario);
            Controls.Add(label1);
            Name = "ModuloUsuarioDetalle";
            Text = "Modulo Usuario Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdModuloUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txths_semanales;
        private TextBox txths_totales;
        private Label label4;
        private ComboBox cmbIdModulo;
        private ComboBox cmbIdUsuario;
        private Label label5;
        private CheckBox chkAlta;
        private CheckBox chkBaja;
        private CheckBox chkConsulta;
        private CheckBox chkModificacion;
    }
}