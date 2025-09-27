namespace Desktop.Views
{
    partial class UsuariosListaView
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
            TabControl = new TabControl();
            ListaUsuariosPage = new TabPage();
            LabelStatusMessage = new StatusStrip();
            BtnRestaurar = new Button();
            CheckVerEliminados = new CheckBox();
            GridUsuarios = new DataGridView();
            BtnSalir = new Button();
            TxtBuscar = new TextBox();
            BtnEliminar = new Button();
            BtnBuscar = new Button();
            BtnModificar = new Button();
            BtnAgregar = new Button();
            AgregarEditarUsuarios = new TabPage();
            BtnCancelar = new Button();
            CbRol = new ComboBox();
            TxtPassword = new TextBox();
            TxtEmail = new TextBox();
            TxtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnGuardar = new Button();
            label1 = new Label();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            ListaUsuariosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).BeginInit();
            AgregarEditarUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(ListaUsuariosPage);
            TabControl.Controls.Add(AgregarEditarUsuarios);
            TabControl.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(0, 43);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(798, 407);
            TabControl.TabIndex = 0;
            // 
            // ListaUsuariosPage
            // 
            ListaUsuariosPage.BackColor = Color.LavenderBlush;
            ListaUsuariosPage.Controls.Add(LabelStatusMessage);
            ListaUsuariosPage.Controls.Add(BtnRestaurar);
            ListaUsuariosPage.Controls.Add(CheckVerEliminados);
            ListaUsuariosPage.Controls.Add(GridUsuarios);
            ListaUsuariosPage.Controls.Add(BtnSalir);
            ListaUsuariosPage.Controls.Add(TxtBuscar);
            ListaUsuariosPage.Controls.Add(BtnEliminar);
            ListaUsuariosPage.Controls.Add(BtnBuscar);
            ListaUsuariosPage.Controls.Add(BtnModificar);
            ListaUsuariosPage.Controls.Add(BtnAgregar);
            ListaUsuariosPage.ImeMode = ImeMode.NoControl;
            ListaUsuariosPage.Location = new Point(4, 27);
            ListaUsuariosPage.Name = "ListaUsuariosPage";
            ListaUsuariosPage.Padding = new Padding(3);
            ListaUsuariosPage.RightToLeft = RightToLeft.No;
            ListaUsuariosPage.Size = new Size(790, 376);
            ListaUsuariosPage.TabIndex = 0;
            ListaUsuariosPage.Text = "Lista de Usuarios";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.BackColor = Color.Transparent;
            LabelStatusMessage.ImageScalingSize = new Size(20, 20);
            LabelStatusMessage.Location = new Point(3, 351);
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(784, 22);
            LabelStatusMessage.TabIndex = 11;
            LabelStatusMessage.Text = "statusStrip1";
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRestaurar.Location = new Point(643, 221);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(119, 45);
            BtnRestaurar.TabIndex = 10;
            BtnRestaurar.Text = "Restaurar";
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // CheckVerEliminados
            // 
            CheckVerEliminados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CheckVerEliminados.AutoSize = true;
            CheckVerEliminados.Location = new Point(642, 11);
            CheckVerEliminados.Name = "CheckVerEliminados";
            CheckVerEliminados.Size = new Size(137, 22);
            CheckVerEliminados.TabIndex = 9;
            CheckVerEliminados.Text = "Ver Eliminados";
            CheckVerEliminados.UseVisualStyleBackColor = true;
            CheckVerEliminados.CheckedChanged += CheckVerEliminados_CheckedChanged_1;
            // 
            // GridUsuarios
            // 
            GridUsuarios.AllowUserToAddRows = false;
            GridUsuarios.AllowUserToDeleteRows = false;
            GridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridUsuarios.BackgroundColor = Color.Snow;
            GridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridUsuarios.Location = new Point(21, 44);
            GridUsuarios.Name = "GridUsuarios";
            GridUsuarios.ReadOnly = true;
            GridUsuarios.RowHeadersWidth = 51;
            GridUsuarios.Size = new Size(583, 293);
            GridUsuarios.TabIndex = 8;
            GridUsuarios.SelectionChanged += GridUsuario_SelectionChanged_1;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.BackColor = Color.LavenderBlush;
            BtnSalir.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.Location = new Point(717, 320);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(62, 28);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(8, 12);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(484, 26);
            TxtBuscar.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(643, 170);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(119, 45);
            BtnEliminar.TabIndex = 6;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(520, 6);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(101, 32);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModificar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(643, 119);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(119, 45);
            BtnModificar.TabIndex = 5;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregar.Location = new Point(643, 68);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(119, 45);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // AgregarEditarUsuarios
            // 
            AgregarEditarUsuarios.Controls.Add(BtnCancelar);
            AgregarEditarUsuarios.Controls.Add(CbRol);
            AgregarEditarUsuarios.Controls.Add(TxtPassword);
            AgregarEditarUsuarios.Controls.Add(TxtEmail);
            AgregarEditarUsuarios.Controls.Add(TxtNombre);
            AgregarEditarUsuarios.Controls.Add(label5);
            AgregarEditarUsuarios.Controls.Add(label4);
            AgregarEditarUsuarios.Controls.Add(label3);
            AgregarEditarUsuarios.Controls.Add(label2);
            AgregarEditarUsuarios.Controls.Add(BtnGuardar);
            AgregarEditarUsuarios.Location = new Point(4, 27);
            AgregarEditarUsuarios.Name = "AgregarEditarUsuarios";
            AgregarEditarUsuarios.Padding = new Padding(3);
            AgregarEditarUsuarios.Size = new Size(790, 376);
            AgregarEditarUsuarios.TabIndex = 1;
            AgregarEditarUsuarios.Text = "Agregar/Editar Usuarios";
            AgregarEditarUsuarios.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(466, 273);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // CbRol
            // 
            CbRol.FormattingEnabled = true;
            CbRol.Location = new Point(261, 186);
            CbRol.Name = "CbRol";
            CbRol.Size = new Size(339, 26);
            CbRol.TabIndex = 9;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(261, 137);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(339, 26);
            TxtPassword.TabIndex = 8;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(261, 88);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(339, 26);
            TxtEmail.TabIndex = 7;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(261, 39);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(339, 26);
            TxtNombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 193);
            label5.Name = "label5";
            label5.Size = new Size(31, 18);
            label5.TabIndex = 5;
            label5.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 147);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 96);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 47);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(261, 273);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 0;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(119, 36);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            // 
            // UsuariosListaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TabControl);
            Name = "UsuariosListaView";
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
            TabControl.ResumeLayout(false);
            ListaUsuariosPage.ResumeLayout(false);
            ListaUsuariosPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).EndInit();
            AgregarEditarUsuarios.ResumeLayout(false);
            AgregarEditarUsuarios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabControl;
        private TabPage ListaUsuariosPage;
        private TabPage AgregarEditarUsuarios;
        private Label label1;
        private Button BtnBuscar;
        private TextBox TxtBuscar;
        private Button BtnAgregar;
        private Button BtnModificar;
        private Button BtnEliminar;
        private Button BtnSalir;
        private DataGridView GridUsuarios;
        private CheckBox CheckVerEliminados;
        private Button BtnRestaurar;
        private System.Windows.Forms.Timer TimerStatusBar;
        private StatusStrip LabelStatusMessage;
        private TextBox textBox4;
        private TextBox TxtPassword;
        private TextBox TxtEmail;
        private TextBox TxtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button BtnGuardar;
        private ComboBox CbRol;
        private Button BtnCancelar;
    }
}