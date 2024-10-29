namespace WindowsForms
{
    partial class PlanDetalle
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
            txtid_plan = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtdesc_plan = new TextBox();
            label2 = new Label();
            label5 = new Label();
            cmbespecialidad = new ComboBox();
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
            // txtid_plan
            // 
            txtid_plan.Location = new Point(135, 44);
            txtid_plan.Name = "txtid_plan";
            txtid_plan.Size = new Size(289, 27);
            txtid_plan.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(87, 212);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(302, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtdesc_plan
            // 
            txtdesc_plan.Location = new Point(135, 87);
            txtdesc_plan.Name = "txtdesc_plan";
            txtdesc_plan.Size = new Size(289, 27);
            txtdesc_plan.TabIndex = 5;
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
            label5.Location = new Point(34, 136);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 10;
            label5.Text = "Especialidad";
            // 
            // cmbespecialidad
            // 
            cmbespecialidad.FormattingEnabled = true;
            cmbespecialidad.Location = new Point(135, 133);
            cmbespecialidad.Name = "cmbespecialidad";
            cmbespecialidad.Size = new Size(289, 28);
            cmbespecialidad.TabIndex = 11;
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 290);
            Controls.Add(cmbespecialidad);
            Controls.Add(label5);
            Controls.Add(txtdesc_plan);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtid_plan);
            Controls.Add(label1);
            Name = "PlanDetalle";
            Text = "PlanDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid_plan;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtdesc_plan;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
        private Label label5;
        private ComboBox cmbespecialidad;
    }
}