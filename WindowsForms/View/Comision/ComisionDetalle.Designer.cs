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
            // txtid_comision
            // 
            txtid_comision.Enabled = false;
            txtid_comision.Location = new Point(135, 44);
            txtid_comision.Name = "txtid_comision";
            txtid_comision.Size = new Size(289, 27);
            txtid_comision.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(102, 221);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(309, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtdesc_comision
            // 
            txtdesc_comision.Location = new Point(135, 87);
            txtdesc_comision.Name = "txtdesc_comision";
            txtdesc_comision.Size = new Size(289, 27);
            txtdesc_comision.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 94);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 180);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "Plan";
            // 
            // cmbid_plan
            // 
            cmbid_plan.FormattingEnabled = true;
            cmbid_plan.Location = new Point(133, 172);
            cmbid_plan.Name = "cmbid_plan";
            cmbid_plan.Size = new Size(289, 28);
            cmbid_plan.TabIndex = 4;
            // 
            // txtanio_especialidad
            // 
            txtanio_especialidad.Location = new Point(135, 131);
            txtanio_especialidad.Name = "txtanio_especialidad";
            txtanio_especialidad.Size = new Size(289, 27);
            txtanio_especialidad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 138);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 12;
            label3.Text = "Año";
            // 
            // ComisionDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 290);
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
    }
}