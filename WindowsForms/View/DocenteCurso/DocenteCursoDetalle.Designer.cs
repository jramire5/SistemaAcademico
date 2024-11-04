namespace WindowsForms
{
    partial class DocenteCursoDetalle
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
            txtid_id_dictado = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label5 = new Label();
            cmbid_docente = new ComboBox();
            cmbid_curso = new ComboBox();
            label4 = new Label();
            cmbid_cargo = new ComboBox();
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
            // txtid_id_dictado
            // 
            txtid_id_dictado.Enabled = false;
            txtid_id_dictado.Location = new Point(135, 44);
            txtid_id_dictado.Name = "txtid_id_dictado";
            txtid_id_dictado.Size = new Size(289, 27);
            txtid_id_dictado.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(98, 234);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(282, 234);
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
            label2.Location = new Point(34, 179);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 138);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "Persona";
            // 
            // cmbid_docente
            // 
            cmbid_docente.FormattingEnabled = true;
            cmbid_docente.Location = new Point(135, 130);
            cmbid_docente.Name = "cmbid_docente";
            cmbid_docente.Size = new Size(289, 28);
            cmbid_docente.TabIndex = 3;
            // 
            // cmbid_curso
            // 
            cmbid_curso.FormattingEnabled = true;
            cmbid_curso.Location = new Point(135, 86);
            cmbid_curso.Name = "cmbid_curso";
            cmbid_curso.Size = new Size(289, 28);
            cmbid_curso.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 94);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 14;
            label4.Text = "Curso";
            // 
            // cmbid_cargo
            // 
            cmbid_cargo.FormattingEnabled = true;
            cmbid_cargo.Location = new Point(135, 171);
            cmbid_cargo.Name = "cmbid_cargo";
            cmbid_cargo.Size = new Size(289, 28);
            cmbid_cargo.TabIndex = 15;
            // 
            // DocenteCursoDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 314);
            Controls.Add(cmbid_cargo);
            Controls.Add(label4);
            Controls.Add(cmbid_curso);
            Controls.Add(cmbid_docente);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_id_dictado);
            Controls.Add(label1);
            Name = "DocenteCursoDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Docente Curso Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_id_dictado;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txths_semanales;
        private TextBox txths_totales;
        private Label label4;
        private Label label5;
        private ComboBox cmbid_docente;
        private ComboBox cmbid_curso;
        private ComboBox cmbid_cargo;
    }
}