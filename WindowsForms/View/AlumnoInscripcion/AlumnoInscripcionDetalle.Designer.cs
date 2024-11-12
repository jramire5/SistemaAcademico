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
            lblcondicion = new Label();
            lblalumno = new Label();
            cmbid_alumno = new ComboBox();
            txtnota = new TextBox();
            lblnota = new Label();
            cmbid_curso = new ComboBox();
            lblcurso = new Label();
            cmbCondicion = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtid_inscripcion
            // 
            txtid_inscripcion.Enabled = false;
            txtid_inscripcion.Location = new Point(118, 33);
            txtid_inscripcion.Margin = new Padding(3, 2, 3, 2);
            txtid_inscripcion.Name = "txtid_inscripcion";
            txtid_inscripcion.Size = new Size(253, 23);
            txtid_inscripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(90, 207);
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
            btnCancelar.Location = new Point(279, 207);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblcondicion
            // 
            lblcondicion.AutoSize = true;
            lblcondicion.Location = new Point(30, 127);
            lblcondicion.Name = "lblcondicion";
            lblcondicion.Size = new Size(67, 15);
            lblcondicion.TabIndex = 4;
            lblcondicion.Text = "Condición*";
            // 
            // lblalumno
            // 
            lblalumno.AutoSize = true;
            lblalumno.Location = new Point(30, 68);
            lblalumno.Name = "lblalumno";
            lblalumno.Size = new Size(55, 15);
            lblalumno.TabIndex = 10;
            lblalumno.Text = "Alumno*";
            // 
            // cmbid_alumno
            // 
            cmbid_alumno.FormattingEnabled = true;
            cmbid_alumno.Location = new Point(118, 62);
            cmbid_alumno.Margin = new Padding(3, 2, 3, 2);
            cmbid_alumno.Name = "cmbid_alumno";
            cmbid_alumno.Size = new Size(253, 23);
            cmbid_alumno.TabIndex = 2;
            cmbid_alumno.ValueMemberChanged += cambiaDatos;
            cmbid_alumno.Click += cambiaDatos;
            // 
            // txtnota
            // 
            txtnota.Location = new Point(118, 152);
            txtnota.Margin = new Padding(3, 2, 3, 2);
            txtnota.Name = "txtnota";
            txtnota.Size = new Size(253, 23);
            txtnota.TabIndex = 5;
            // 
            // lblnota
            // 
            lblnota.AutoSize = true;
            lblnota.Location = new Point(30, 158);
            lblnota.Name = "lblnota";
            lblnota.Size = new Size(33, 15);
            lblnota.TabIndex = 12;
            lblnota.Text = "Nota";
            // 
            // cmbid_curso
            // 
            cmbid_curso.FormattingEnabled = true;
            cmbid_curso.Location = new Point(118, 91);
            cmbid_curso.Margin = new Padding(3, 2, 3, 2);
            cmbid_curso.Name = "cmbid_curso";
            cmbid_curso.Size = new Size(253, 23);
            cmbid_curso.TabIndex = 3;
            cmbid_curso.ValueMemberChanged += cambiaDatos;
            cmbid_curso.Click += cambiaDatos;
            // 
            // lblcurso
            // 
            lblcurso.AutoSize = true;
            lblcurso.Location = new Point(30, 97);
            lblcurso.Name = "lblcurso";
            lblcurso.Size = new Size(43, 15);
            lblcurso.TabIndex = 14;
            lblcurso.Text = "Curso*";
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(118, 121);
            cmbCondicion.Margin = new Padding(3, 2, 3, 2);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(253, 23);
            cmbCondicion.TabIndex = 15;
            cmbCondicion.ValueMemberChanged += cambiaDatos;
            cmbCondicion.Click += cambiaDatos;
            // 
            // AlumnoInscripcionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 255);
            Controls.Add(cmbCondicion);
            Controls.Add(cmbid_curso);
            Controls.Add(lblcurso);
            Controls.Add(txtnota);
            Controls.Add(lblnota);
            Controls.Add(cmbid_alumno);
            Controls.Add(lblalumno);
            Controls.Add(lblcondicion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_inscripcion);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblcondicion;
        private TextBox txths_semanales;
        private Label lblnota;
        private TextBox txths_totales;
        private Label lblcurso;
        private Label lblalumno;
        private ComboBox cmbid_alumno;
        private TextBox txtnota;
        private ComboBox cmbid_curso;
        private ComboBox cmbCondicion;
    }
}