namespace WindowsForms
{
    partial class EspecialidadDetalle
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
            txtid_especialidad = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtdesc_especialidad = new TextBox();
            label2 = new Label();
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
            // txtid_especialidad
            // 
            txtid_especialidad.Enabled = false;
            txtid_especialidad.Location = new Point(135, 44);
            txtid_especialidad.Name = "txtid_especialidad";
            txtid_especialidad.Size = new Size(289, 27);
            txtid_especialidad.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(76, 165);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(297, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtdesc_especialidad
            // 
            txtdesc_especialidad.Location = new Point(135, 87);
            txtdesc_especialidad.Name = "txtdesc_especialidad";
            txtdesc_especialidad.Size = new Size(289, 27);
            txtdesc_especialidad.TabIndex = 5;
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
            // EspecialidadDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 290);
            Controls.Add(txtdesc_especialidad);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_especialidad);
            Controls.Add(label1);
            Name = "EspecialidadDetalle";
            Text = "Especialidad Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_especialidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtdesc_especialidad;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
    }
}