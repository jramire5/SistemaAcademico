namespace WindowsForms
{
    partial class CursosDetalle
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
            txtid_id_curso = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            cmbid_materia = new ComboBox();
            cmbid_comision = new ComboBox();
            label3 = new Label();
            txtanio_calendario = new TextBox();
            label4 = new Label();
            txtcupo = new TextBox();
            label5 = new Label();
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
            // txtid_id_curso
            // 
            txtid_id_curso.Enabled = false;
            txtid_id_curso.Location = new Point(163, 44);
            txtid_id_curso.Name = "txtid_id_curso";
            txtid_id_curso.Size = new Size(289, 27);
            txtid_id_curso.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(83, 280);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 94);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Materia";
            // 
            // cmbid_materia
            // 
            cmbid_materia.FormattingEnabled = true;
            cmbid_materia.Location = new Point(163, 91);
            cmbid_materia.Name = "cmbid_materia";
            cmbid_materia.Size = new Size(289, 28);
            cmbid_materia.TabIndex = 2;
            // 
            // cmbid_comision
            // 
            cmbid_comision.FormattingEnabled = true;
            cmbid_comision.Location = new Point(163, 137);
            cmbid_comision.Name = "cmbid_comision";
            cmbid_comision.Size = new Size(289, 28);
            cmbid_comision.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 140);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Comisión";
            // 
            // txtanio_calendario
            // 
            txtanio_calendario.Location = new Point(163, 176);
            txtanio_calendario.Name = "txtanio_calendario";
            txtanio_calendario.Size = new Size(289, 27);
            txtanio_calendario.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 176);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 8;
            label4.Text = "Año Canlendario";
            // 
            // txtcupo
            // 
            txtcupo.Location = new Point(163, 218);
            txtcupo.Name = "txtcupo";
            txtcupo.Size = new Size(289, 27);
            txtcupo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 218);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 10;
            label5.Text = "Cupo";
            // 
            // CursosDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 333);
            Controls.Add(txtcupo);
            Controls.Add(label5);
            Controls.Add(txtanio_calendario);
            Controls.Add(label4);
            Controls.Add(cmbid_comision);
            Controls.Add(label3);
            Controls.Add(cmbid_materia);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_id_curso);
            Controls.Add(label1);
            Name = "CursosDetalle";
            Text = "Curso Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_id_curso;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
        private ComboBox cmbid_materia;
        private ComboBox cmbid_comision;
        private TextBox txtanio_calendario;
        private TextBox txtcupo;
        private Label label5;
    }
}