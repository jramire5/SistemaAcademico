namespace WindowsForms
{
    partial class ComisionDetalle
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
            txtid_comision = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtdesc_comision = new TextBox();
            label2 = new Label();
            label5 = new Label();
            cmbid_plan = new ComboBox();
            txtanio_especialidad = new TextBox();
            label3 = new Label();
            ErrorDesc = new Label();
            Errores = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtid_comision
            // 
            txtid_comision.Enabled = false;
            txtid_comision.Location = new Point(118, 33);
            txtid_comision.Margin = new Padding(3, 2, 3, 2);
            txtid_comision.Name = "txtid_comision";
            txtid_comision.Size = new Size(253, 23);
            txtid_comision.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(89, 176);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(270, 176);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtdesc_comision
            // 
            txtdesc_comision.Location = new Point(118, 65);
            txtdesc_comision.Margin = new Padding(3, 2, 3, 2);
            txtdesc_comision.Name = "txtdesc_comision";
            txtdesc_comision.Size = new Size(253, 23);
            txtdesc_comision.TabIndex = 2;
            txtdesc_comision.TextChanged += cambianDatos;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 147);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "Plan";
            // 
            // cmbid_plan
            // 
            cmbid_plan.FormattingEnabled = true;
            cmbid_plan.Location = new Point(116, 141);
            cmbid_plan.Margin = new Padding(3, 2, 3, 2);
            cmbid_plan.Name = "cmbid_plan";
            cmbid_plan.Size = new Size(253, 23);
            cmbid_plan.TabIndex = 4;
            cmbid_plan.SelectedValueChanged += cambianDatos;
            // 
            // txtanio_especialidad
            // 
            txtanio_especialidad.Location = new Point(118, 103);
            txtanio_especialidad.Margin = new Padding(3, 2, 3, 2);
            txtanio_especialidad.Name = "txtanio_especialidad";
            txtanio_especialidad.Size = new Size(253, 23);
            txtanio_especialidad.TabIndex = 3;
            txtanio_especialidad.TextChanged += cambianDatos;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 109);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 12;
            label3.Text = "Año";
            // 
            // ErrorDesc
            // 
            ErrorDesc.AutoSize = true;
            ErrorDesc.ForeColor = Color.Red;
            ErrorDesc.Location = new Point(118, 86);
            ErrorDesc.Name = "ErrorDesc";
            ErrorDesc.Size = new Size(97, 15);
            ErrorDesc.TabIndex = 13;
            ErrorDesc.Text = "Falta Descripción";
            ErrorDesc.Visible = false;
            // 
            // Errores
            // 
            Errores.AutoSize = true;
            Errores.ForeColor = Color.Red;
            Errores.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            Errores.Location = new Point(42, 212);
            Errores.Name = "Errores";
            Errores.Size = new Size(10, 15);
            Errores.TabIndex = 14;
            Errores.Text = " ";
            // 
            // ComisionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 254);
            Controls.Add(Errores);
            Controls.Add(ErrorDesc);
            Controls.Add(txtanio_especialidad);
            Controls.Add(label3);
            Controls.Add(cmbid_plan);
            Controls.Add(label5);
            Controls.Add(txtdesc_comision);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_comision);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ComisionDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Comision Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_comision;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtdesc_comision;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
        private Label label5;
        private ComboBox cmbid_plan;
        private TextBox txtanio_especialidad;
        private Label ErrorDesc;
        private Label Errores;
    }
}