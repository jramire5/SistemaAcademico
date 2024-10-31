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
            label5 = new Label();
            cmbplan = new ComboBox();
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
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(135, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(289, 27);
            txtId.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(135, 287);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtdesc_materia
            // 
            txtdesc_materia.Location = new Point(135, 87);
            txtdesc_materia.Name = "txtdesc_materia";
            txtdesc_materia.Size = new Size(289, 27);
            txtdesc_materia.TabIndex = 5;
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
            // txths_semanales
            // 
            txths_semanales.Location = new Point(135, 130);
            txths_semanales.Name = "txths_semanales";
            txths_semanales.Size = new Size(289, 27);
            txths_semanales.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 137);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "Horas Sem.";
            // 
            // txths_totales
            // 
            txths_totales.Location = new Point(299, 174);
            txths_totales.Name = "txths_totales";
            txths_totales.Size = new Size(125, 27);
            txths_totales.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 181);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "Horas Totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 225);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "Plan";
            // 
            // cmbplan
            // 
            cmbplan.FormattingEnabled = true;
            cmbplan.Location = new Point(135, 217);
            cmbplan.Name = "cmbplan";
            cmbplan.Size = new Size(289, 28);
            cmbplan.TabIndex = 11;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 368);
            Controls.Add(cmbplan);
            Controls.Add(label5);
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
        private Label label5;
        private ComboBox cmbplan;
    }
}