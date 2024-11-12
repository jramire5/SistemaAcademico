namespace WindowsForms
{
    partial class NotaDetalle
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
            txtid_nota = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label5 = new Label();
            cmbid_alumno = new ComboBox();
            cmbid_dictado = new ComboBox();
            label4 = new Label();
            txt_descr = new TextBox();
            txt_nota = new TextBox();
            label3 = new Label();
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
            // txtid_nota
            // 
            txtid_nota.Enabled = false;
            txtid_nota.Location = new Point(135, 44);
            txtid_nota.Name = "txtid_nota";
            txtid_nota.Size = new Size(315, 27);
            txtid_nota.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(170, 295);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(307, 295);
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
            label2.Location = new Point(34, 145);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 186);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "Alumno";
            // 
            // cmbid_alumno
            // 
            cmbid_alumno.FormattingEnabled = true;
            cmbid_alumno.Location = new Point(135, 178);
            cmbid_alumno.Name = "cmbid_alumno";
            cmbid_alumno.Size = new Size(315, 28);
            cmbid_alumno.TabIndex = 3;
            // 
            // cmbid_dictado
            // 
            cmbid_dictado.FormattingEnabled = true;
            cmbid_dictado.Location = new Point(135, 86);
            cmbid_dictado.Name = "cmbid_dictado";
            cmbid_dictado.Size = new Size(315, 28);
            cmbid_dictado.TabIndex = 2;
            cmbid_dictado.SelectedValueChanged += cmbid_dictado_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 94);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 14;
            label4.Text = "Dictado";
            // 
            // txt_descr
            // 
            txt_descr.Enabled = false;
            txt_descr.Location = new Point(135, 138);
            txt_descr.Name = "txt_descr";
            txt_descr.Size = new Size(315, 27);
            txt_descr.TabIndex = 15;
            // 
            // txt_nota
            // 
            txt_nota.Enabled = false;
            txt_nota.Location = new Point(135, 220);
            txt_nota.Name = "txt_nota";
            txt_nota.Size = new Size(315, 27);
            txt_nota.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 227);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 17;
            label3.Text = "Nota";
            // 
            // NotaDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 355);
            Controls.Add(label3);
            Controls.Add(txt_nota);
            Controls.Add(txt_descr);
            Controls.Add(label4);
            Controls.Add(cmbid_dictado);
            Controls.Add(cmbid_alumno);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_nota);
            Controls.Add(label1);
            Name = "NotaDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nota Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_nota;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txths_semanales;
        private TextBox txths_totales;
        private Label label4;
        private Label label5;
        private ComboBox cmbid_alumno;
        private ComboBox cmbid_dictado;
        private TextBox txt_descr;
        private TextBox txt_nota;
        private Label label3;
    }
}