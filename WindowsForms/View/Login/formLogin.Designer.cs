namespace WindowsForms;

partial class formLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnIngresar = new Button();
        lnkOlvidaPass = new LinkLabel();
        label1 = new Label();
        txtUsuario = new TextBox();
        txtPass = new TextBox();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // btnIngresar
        // 
        btnIngresar.Location = new Point(335, 224);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(94, 29);
        btnIngresar.TabIndex = 0;
        btnIngresar.Text = "Ingresar";
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // lnkOlvidaPass
        // 
        lnkOlvidaPass.AutoSize = true;
        lnkOlvidaPass.Location = new Point(12, 277);
        lnkOlvidaPass.Name = "lnkOlvidaPass";
        lnkOlvidaPass.Size = new Size(149, 20);
        lnkOlvidaPass.TabIndex = 1;
        lnkOlvidaPass.TabStop = true;
        lnkOlvidaPass.Text = "Olvidé mi contraseña";
        lnkOlvidaPass.Click += lnkOlvidaPass_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(98, 55);
        label1.Name = "label1";
        label1.Size = new Size(287, 40);
        label1.TabIndex = 2;
        label1.Text = "        ¡Bienvenido al Sistema!\r\nPor favor digite su información de Ingreso\r\n";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(190, 134);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(239, 27);
        txtUsuario.TabIndex = 3;
        // 
        // txtPass
        // 
        txtPass.Location = new Point(190, 179);
        txtPass.Name = "txtPass";
        txtPass.PasswordChar = '*';
        txtPass.Size = new Size(239, 27);
        txtPass.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(43, 137);
        label2.Name = "label2";
        label2.Size = new Size(142, 20);
        label2.TabIndex = 5;
        label2.Text = "Nombre de Usuario:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(98, 182);
        label3.Name = "label3";
        label3.Size = new Size(86, 20);
        label3.TabIndex = 6;
        label3.Text = "Contraseña:";
        // 
        // formLogin
        // 
        AcceptButton = btnIngresar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(499, 308);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtPass);
        Controls.Add(txtUsuario);
        Controls.Add(label1);
        Controls.Add(lnkOlvidaPass);
        Controls.Add(btnIngresar);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "formLogin";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Ingreso";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnIngresar;
    private LinkLabel lnkOlvidaPass;
    private Label label1;
    private TextBox txtUsuario;
    private TextBox txtPass;
    private Label label2;
    private Label label3;
}
