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
            TabControlUsuarios = new TabControl();
            ListaIsuariosPage = new TabPage();
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
            label1 = new Label();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControlUsuarios.SuspendLayout();
            ListaIsuariosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // TabControlUsuarios
            // 
            TabControlUsuarios.Controls.Add(ListaIsuariosPage);
            TabControlUsuarios.Controls.Add(AgregarEditarUsuarios);
            TabControlUsuarios.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlUsuarios.Location = new Point(0, 43);
            TabControlUsuarios.Name = "TabControlUsuarios";
            TabControlUsuarios.SelectedIndex = 0;
            TabControlUsuarios.Size = new Size(798, 407);
            TabControlUsuarios.TabIndex = 0;
            // 
            // ListaIsuariosPage
            // 
            ListaIsuariosPage.BackColor = Color.LavenderBlush;
            ListaIsuariosPage.Controls.Add(LabelStatusMessage);
            ListaIsuariosPage.Controls.Add(BtnRestaurar);
            ListaIsuariosPage.Controls.Add(CheckVerEliminados);
            ListaIsuariosPage.Controls.Add(GridUsuarios);
            ListaIsuariosPage.Controls.Add(BtnSalir);
            ListaIsuariosPage.Controls.Add(TxtBuscar);
            ListaIsuariosPage.Controls.Add(BtnEliminar);
            ListaIsuariosPage.Controls.Add(BtnBuscar);
            ListaIsuariosPage.Controls.Add(BtnModificar);
            ListaIsuariosPage.Controls.Add(BtnAgregar);
            ListaIsuariosPage.Location = new Point(4, 27);
            ListaIsuariosPage.Name = "ListaIsuariosPage";
            ListaIsuariosPage.Padding = new Padding(3);
            ListaIsuariosPage.Size = new Size(790, 376);
            ListaIsuariosPage.TabIndex = 0;
            ListaIsuariosPage.Text = "Lista de Usuarios";
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
            BtnRestaurar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRestaurar.Location = new Point(643, 221);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(119, 45);
            BtnRestaurar.TabIndex = 10;
            BtnRestaurar.Text = "Restaurar";
            BtnRestaurar.UseVisualStyleBackColor = true;
            // 
            // CheckVerEliminados
            // 
            CheckVerEliminados.AutoSize = true;
            CheckVerEliminados.Location = new Point(642, 11);
            CheckVerEliminados.Name = "CheckVerEliminados";
            CheckVerEliminados.Size = new Size(137, 22);
            CheckVerEliminados.TabIndex = 9;
            CheckVerEliminados.Text = "Ver Eliminados";
            CheckVerEliminados.UseVisualStyleBackColor = true;
            // 
            // GridUsuarios
            // 
            GridUsuarios.AllowUserToAddRows = false;
            GridUsuarios.AllowUserToDeleteRows = false;
            GridUsuarios.BackgroundColor = Color.Snow;
            GridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridUsuarios.Location = new Point(21, 44);
            GridUsuarios.Name = "GridUsuarios";
            GridUsuarios.ReadOnly = true;
            GridUsuarios.RowHeadersWidth = 51;
            GridUsuarios.Size = new Size(583, 293);
            GridUsuarios.TabIndex = 8;
            // 
            // BtnSalir
            // 
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
            TxtBuscar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(8, 12);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(484, 26);
            TxtBuscar.TabIndex = 3;
            // 
            // BtnEliminar
            // 
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
            BtnBuscar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(520, 6);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(101, 32);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(643, 119);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(119, 45);
            BtnModificar.TabIndex = 5;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregar.Location = new Point(643, 68);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(119, 45);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // AgregarEditarUsuarios
            // 
            AgregarEditarUsuarios.Location = new Point(4, 27);
            AgregarEditarUsuarios.Name = "AgregarEditarUsuarios";
            AgregarEditarUsuarios.Padding = new Padding(3);
            AgregarEditarUsuarios.Size = new Size(790, 376);
            AgregarEditarUsuarios.TabIndex = 1;
            AgregarEditarUsuarios.Text = "Agregar/Editar Usuarios";
            AgregarEditarUsuarios.UseVisualStyleBackColor = true;
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
            TimerStatusBar.Interval = 500;
            // 
            // UsuariosListaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = Properties.Resources.f0925a8958ac8ea048b98f828a087882;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TabControlUsuarios);
            Name = "UsuariosListaView";
            Text = "Usuarios";
            TabControlUsuarios.ResumeLayout(false);
            ListaIsuariosPage.ResumeLayout(false);
            ListaIsuariosPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabControlUsuarios;
        private TabPage ListaIsuariosPage;
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
    }
}