namespace WindowsForms;

partial class UsuarioDetalle
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
        components = new System.ComponentModel.Container();
        lblcambiaclave = new Label();
        lblapellido = new Label();
        lblid_usuario = new Label();
        txtid_usuario = new TextBox();
        Cancelar = new Button();
        Aceptar = new Button();
        chkcambia_clave = new CheckBox();
        personaBindingSource = new BindingSource(components);
        personaApiClientBindingSource = new BindingSource(components);
        txtnombre_usuario = new TextBox();
        label2 = new Label();
        txtclave = new TextBox();
        txtnombre = new TextBox();
        label1 = new Label();
        txtapellido = new TextBox();
        label3 = new Label();
        txtemail = new TextBox();
        label4 = new Label();
        chkhabilitado = new CheckBox();
        label5 = new Label();
        cmbid_persona = new ComboBox();
        label6 = new Label();
        ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)personaApiClientBindingSource).BeginInit();
        SuspendLayout();
        // 
        // lblcambiaclave
        // 
        lblcambiaclave.AutoSize = true;
        lblcambiaclave.Location = new Point(504, 44);
        lblcambiaclave.Name = "lblcambiaclave";
        lblcambiaclave.Size = new Size(100, 20);
        lblcambiaclave.TabIndex = 24;
        lblcambiaclave.Text = "Cambia Clave";
        // 
        // lblapellido
        // 
        lblapellido.AutoSize = true;
        lblapellido.Location = new Point(56, 114);
        lblapellido.Name = "lblapellido";
        lblapellido.Size = new Size(45, 20);
        lblapellido.TabIndex = 22;
        lblapellido.Text = "Clave";
        // 
        // lblid_usuario
        // 
        lblid_usuario.AutoSize = true;
        lblid_usuario.Location = new Point(56, 37);
        lblid_usuario.Name = "lblid_usuario";
        lblid_usuario.Size = new Size(76, 20);
        lblid_usuario.TabIndex = 18;
        lblid_usuario.Text = "Id Usuario";
        // 
        // txtid_usuario
        // 
        txtid_usuario.Enabled = false;
        txtid_usuario.Location = new Point(208, 37);
        txtid_usuario.Margin = new Padding(3, 4, 3, 4);
        txtid_usuario.Name = "txtid_usuario";
        txtid_usuario.Size = new Size(174, 27);
        txtid_usuario.TabIndex = 1;
        // 
        // Cancelar
        // 
        Cancelar.Location = new Point(370, 316);
        Cancelar.Margin = new Padding(3, 4, 3, 4);
        Cancelar.Name = "Cancelar";
        Cancelar.Size = new Size(86, 31);
        Cancelar.TabIndex = 34;
        Cancelar.Text = "Cancelar";
        Cancelar.UseVisualStyleBackColor = true;
        Cancelar.Click += btnCancelar_Click;
        // 
        // Aceptar
        // 
        Aceptar.Location = new Point(147, 316);
        Aceptar.Margin = new Padding(3, 4, 3, 4);
        Aceptar.Name = "Aceptar";
        Aceptar.Size = new Size(86, 31);
        Aceptar.TabIndex = 33;
        Aceptar.Text = "Aceptar";
        Aceptar.UseVisualStyleBackColor = true;
        Aceptar.Click += Aceptar_Click;
        // 
        // chkcambia_clave
        // 
        chkcambia_clave.AutoSize = true;
        chkcambia_clave.Location = new Point(669, 47);
        chkcambia_clave.Margin = new Padding(3, 4, 3, 4);
        chkcambia_clave.Name = "chkcambia_clave";
        chkcambia_clave.Size = new Size(18, 17);
        chkcambia_clave.TabIndex = 8;
        chkcambia_clave.UseVisualStyleBackColor = true;
        // 
        // txtnombre_usuario
        // 
        txtnombre_usuario.Location = new Point(208, 72);
        txtnombre_usuario.Margin = new Padding(3, 4, 3, 4);
        txtnombre_usuario.Name = "txtnombre_usuario";
        txtnombre_usuario.Size = new Size(174, 27);
        txtnombre_usuario.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(56, 75);
        label2.Name = "label2";
        label2.Size = new Size(139, 20);
        label2.TabIndex = 20;
        label2.Text = "Nombre de Usuario";
        // 
        // txtclave
        // 
        txtclave.Location = new Point(208, 107);
        txtclave.Margin = new Padding(3, 4, 3, 4);
        txtclave.Name = "txtclave";
        txtclave.Size = new Size(174, 27);
        txtclave.TabIndex = 3;
        // 
        // txtnombre
        // 
        txtnombre.Location = new Point(210, 179);
        txtnombre.Margin = new Padding(3, 4, 3, 4);
        txtnombre.Name = "txtnombre";
        txtnombre.Size = new Size(174, 27);
        txtnombre.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(58, 186);
        label1.Name = "label1";
        label1.Size = new Size(64, 20);
        label1.TabIndex = 38;
        label1.Text = "Nombre";
        // 
        // txtapellido
        // 
        txtapellido.Location = new Point(210, 214);
        txtapellido.Margin = new Padding(3, 4, 3, 4);
        txtapellido.Name = "txtapellido";
        txtapellido.Size = new Size(174, 27);
        txtapellido.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(58, 221);
        label3.Name = "label3";
        label3.Size = new Size(66, 20);
        label3.TabIndex = 40;
        label3.Text = "Apellido";
        // 
        // txtemail
        // 
        txtemail.Location = new Point(210, 249);
        txtemail.Margin = new Padding(3, 4, 3, 4);
        txtemail.Name = "txtemail";
        txtemail.Size = new Size(174, 27);
        txtemail.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(58, 256);
        label4.Name = "label4";
        label4.Size = new Size(46, 20);
        label4.TabIndex = 42;
        label4.Text = "Email";
        // 
        // chkhabilitado
        // 
        chkhabilitado.AutoSize = true;
        chkhabilitado.Location = new Point(669, 86);
        chkhabilitado.Margin = new Padding(3, 4, 3, 4);
        chkhabilitado.Name = "chkhabilitado";
        chkhabilitado.Size = new Size(18, 17);
        chkhabilitado.TabIndex = 9;
        chkhabilitado.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(515, 83);
        label5.Name = "label5";
        label5.Size = new Size(80, 20);
        label5.TabIndex = 43;
        label5.Text = "Habilitado";
        // 
        // cmbid_persona
        // 
        cmbid_persona.FormattingEnabled = true;
        cmbid_persona.Location = new Point(208, 141);
        cmbid_persona.Name = "cmbid_persona";
        cmbid_persona.Size = new Size(172, 28);
        cmbid_persona.TabIndex = 7;
        cmbid_persona.SelectedValueChanged += cmbid_persona_SelectedValueChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(56, 149);
        label6.Name = "label6";
        label6.Size = new Size(60, 20);
        label6.TabIndex = 46;
        label6.Text = "Persona";
        // 
        // UsuarioDetalle
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(754, 370);
        Controls.Add(label6);
        Controls.Add(cmbid_persona);
        Controls.Add(chkhabilitado);
        Controls.Add(label5);
        Controls.Add(txtemail);
        Controls.Add(label4);
        Controls.Add(txtapellido);
        Controls.Add(label3);
        Controls.Add(txtnombre);
        Controls.Add(label1);
        Controls.Add(txtclave);
        Controls.Add(chkcambia_clave);
        Controls.Add(Cancelar);
        Controls.Add(Aceptar);
        Controls.Add(lblcambiaclave);
        Controls.Add(lblapellido);
        Controls.Add(label2);
        Controls.Add(txtnombre_usuario);
        Controls.Add(lblid_usuario);
        Controls.Add(txtid_usuario);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UsuarioDetalle";
        Text = "Usuario Detalle";
        ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)personaApiClientBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblemail;
    private TextBox txtemail;
    private Label lblcambiaclave;
    private TextBox txtdireccion;
    private Label lblapellido;
    private TextBox txtclave;
    private TextBox txtnombre;
    private Label label1;
    private TextBox txtapellido;
    private Label label3;
    private Label label4;
    private CheckBox chkhabilitado;
    private Label label5;
    private ComboBox cmbid_persona;
    private Label label6;
    private Label lblid_usuario;
    private TextBox txtid_usuario;
    private Button Cancelar;
    private Button Aceptar;
    private CheckBox chkcambia_clave;
    private BindingSource personaBindingSource;
    private BindingSource personaApiClientBindingSource;
    private TextBox txtnombre_usuario;
    private Label label2;
}