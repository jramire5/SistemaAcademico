namespace WindowsForms
{
    partial class AlumnoInscripcionDetalle
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
            txtid_inscripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label5 = new Label();
            cmbid_alumno = new ComboBox();
            txtnota = new TextBox();
            label3 = new Label();
            cmbid_curso = new ComboBox();
            label4 = new Label();
            cmbCondicion = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtid_inscripcion
            // 
            txtid_inscripcion.Enabled = false;
            txtid_inscripcion.Location = new Point(135, 44);
            txtid_inscripcion.Name = "txtid_inscripcion";
            txtid_inscripcion.Size = new Size(289, 27);
            txtid_inscripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(103, 276);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(319, 276);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 169);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Condición";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 90);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "Alumno";
            // 
            // cmbid_alumno
            // 
            cmbid_alumno.FormattingEnabled = true;
            cmbid_alumno.Location = new Point(135, 82);
            cmbid_alumno.Name = "cmbid_alumno";
            cmbid_alumno.Size = new Size(289, 28);
            cmbid_alumno.TabIndex = 2;
            // 
            // txtnota
            // 
            txtnota.Location = new Point(135, 203);
            txtnota.Name = "txtnota";
            txtnota.Size = new Size(289, 27);
            txtnota.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 210);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 12;
            label3.Text = "Nota";
            // 
            // cmbid_curso
            // 
            cmbid_curso.FormattingEnabled = true;
            cmbid_curso.Location = new Point(135, 121);
            cmbid_curso.Name = "cmbid_curso";
            cmbid_curso.Size = new Size(289, 28);
            cmbid_curso.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 129);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 14;
            label4.Text = "Curso";
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(135, 161);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(289, 28);
            cmbCondicion.TabIndex = 15;
            // 
            // AlumnoInscripcionDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 340);
            Controls.Add(cmbCondicion);
            Controls.Add(cmbid_curso);
            Controls.Add(label4);
            Controls.Add(txtnota);
            Controls.Add(label3);
            Controls.Add(cmbid_alumno);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_inscripcion);
            Controls.Add(label1);
            Name = "AlumnoInscripcionDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alumno Inscripción Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_inscripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
        private Label label5;
        private ComboBox cmbid_alumno;
        private TextBox txtnota;
        private ComboBox cmbid_curso;
        private ComboBox cmbCondicion;
    }
}