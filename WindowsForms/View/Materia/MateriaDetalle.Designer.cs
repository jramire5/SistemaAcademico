namespace WindowsForms
{
    partial class MateriaDetalle
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
            txtId = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtdesc_materia = new TextBox();
            label2 = new Label();
            txths_semanales = new TextBox();
            label3 = new Label();
            txths_totales = new TextBox();
            label4 = new Label();
            lblplan = new Label();
            cmbplan = new ComboBox();
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
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(118, 33);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(253, 23);
            txtId.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(118, 215);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(289, 215);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtdesc_materia
            // 
            txtdesc_materia.Location = new Point(118, 65);
            txtdesc_materia.Margin = new Padding(3, 2, 3, 2);
            txtdesc_materia.Name = "txtdesc_materia";
            txtdesc_materia.Size = new Size(253, 23);
            txtdesc_materia.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción*";
            // 
            // txths_semanales
            // 
            txths_semanales.Location = new Point(118, 98);
            txths_semanales.Margin = new Padding(3, 2, 3, 2);
            txths_semanales.Name = "txths_semanales";
            txths_semanales.Size = new Size(253, 23);
            txths_semanales.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Horas Sem.";
            // 
            // txths_totales
            // 
            txths_totales.Location = new Point(262, 130);
            txths_totales.Margin = new Padding(3, 2, 3, 2);
            txths_totales.Name = "txths_totales";
            txths_totales.Size = new Size(110, 23);
            txths_totales.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 136);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "Horas Totales";
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(32, 169);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(35, 15);
            lblplan.TabIndex = 10;
            lblplan.Text = "Plan*";
            // 
            // cmbplan
            // 
            cmbplan.FormattingEnabled = true;
            cmbplan.Location = new Point(118, 163);
            cmbplan.Margin = new Padding(3, 2, 3, 2);
            cmbplan.Name = "cmbplan";
            cmbplan.Size = new Size(253, 23);
            cmbplan.TabIndex = 11;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 276);
            Controls.Add(cmbplan);
            Controls.Add(lblplan);
            Controls.Add(txths_totales);
            Controls.Add(label4);
            Controls.Add(txths_semanales);
            Controls.Add(label3);
            Controls.Add(txtdesc_materia);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MateriaDetalle";
            Text = "MateriaDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtdesc_materia;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
        private Label lblplan;
        private ComboBox cmbplan;
    }
}