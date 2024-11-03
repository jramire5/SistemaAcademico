namespace WindowsForms
{
    partial class ModuloDetalle
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
            txtId_modulo = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtdescripcion_modulo = new TextBox();
            label2 = new Label();
            txtejecuta = new TextBox();
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
            // txtId_modulo
            // 
            txtId_modulo.Enabled = false;
            txtId_modulo.Location = new Point(135, 44);
            txtId_modulo.Name = "txtId_modulo";
            txtId_modulo.Size = new Size(289, 27);
            txtId_modulo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(77, 184);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(306, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtdescripcion_modulo
            // 
            txtdescripcion_modulo.Location = new Point(135, 87);
            txtdescripcion_modulo.Name = "txtdescripcion_modulo";
            txtdescripcion_modulo.Size = new Size(289, 27);
            txtdescripcion_modulo.TabIndex = 2;
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
            // txtejecuta
            // 
            txtejecuta.Location = new Point(135, 129);
            txtejecuta.Name = "txtejecuta";
            txtejecuta.Size = new Size(289, 27);
            txtejecuta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 136);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Ejecuta";
            // 
            // ModuloDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 290);
            Controls.Add(txtejecuta);
            Controls.Add(label3);
            Controls.Add(txtdescripcion_modulo);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtId_modulo);
            Controls.Add(label1);
            Name = "ModuloDetalle";
            Text = "Modulo Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId_modulo;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtdescripcion_modulo;
        private Label label2;
        private TextBox txths_semanales;
        private Label label3;
        private TextBox txths_totales;
        private Label label4;
        private TextBox txtejecuta;
    }
}