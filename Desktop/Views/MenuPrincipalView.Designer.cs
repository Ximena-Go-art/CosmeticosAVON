namespace Desktop
{
    partial class MenuPrincipalView
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
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            SubMenuUsuarios = new ToolStripMenuItem();
            SubMenuConsultores = new ToolStripMenuItem();
            SunMenuProductos = new ToolStripMenuItem();
            SubMenuMiHistorial = new ToolStripMenuItem();
            SubMenuContactanos = new ToolStripMenuItem();
            SubMenuHistoria = new ToolStripMenuItem();
            contactanosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            SubMenuSalir = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, SubMenuContactanos, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubMenuUsuarios, SubMenuConsultores, SunMenuProductos, SubMenuMiHistorial });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(80, 24);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // SubMenuUsuarios
            // 
            SubMenuUsuarios.Name = "SubMenuUsuarios";
            SubMenuUsuarios.Size = new Size(224, 26);
            SubMenuUsuarios.Text = "Usuarios";
            SubMenuUsuarios.Click += SubMenuUsuarios_Click;
            // 
            // SubMenuConsultores
            // 
            SubMenuConsultores.Name = "SubMenuConsultores";
            SubMenuConsultores.Size = new Size(224, 26);
            SubMenuConsultores.Text = "Ventas";
            // 
            // SunMenuProductos
            // 
            SunMenuProductos.Name = "SunMenuProductos";
            SunMenuProductos.Size = new Size(224, 26);
            SunMenuProductos.Text = "Productos";
            // 
            // SubMenuMiHistorial
            // 
            SubMenuMiHistorial.Name = "SubMenuMiHistorial";
            SubMenuMiHistorial.Size = new Size(224, 26);
            SubMenuMiHistorial.Text = "Mi Histotial";
            // 
            // SubMenuContactanos
            // 
            SubMenuContactanos.DropDownItems.AddRange(new ToolStripItem[] { SubMenuHistoria, contactanosToolStripMenuItem });
            SubMenuContactanos.Name = "SubMenuContactanos";
            SubMenuContactanos.Size = new Size(82, 24);
            SubMenuContactanos.Text = "Nosotras";
            // 
            // SubMenuHistoria
            // 
            SubMenuHistoria.Name = "SubMenuHistoria";
            SubMenuHistoria.Size = new Size(199, 26);
            SubMenuHistoria.Text = "Nuestra Historia";
            // 
            // contactanosToolStripMenuItem
            // 
            contactanosToolStripMenuItem.Name = "contactanosToolStripMenuItem";
            contactanosToolStripMenuItem.Size = new Size(199, 26);
            contactanosToolStripMenuItem.Text = "Contactanos";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalir });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // SubMenuSalir
            // 
            SubMenuSalir.Name = "SubMenuSalir";
            SubMenuSalir.Size = new Size(200, 26);
            SubMenuSalir.Text = "Salir del sistema";
            SubMenuSalir.Click += SubMenuSalir_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "Venta de Cosmeticos";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem SubMenuContactanos;
        private ToolStripMenuItem SubMenuHistoria;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem SubMenuUsuarios;
        private ToolStripMenuItem SubMenuConsultores;
        private ToolStripMenuItem SunMenuProductos;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem SubMenuSalir;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem contactanosToolStripMenuItem;
        private ToolStripMenuItem SubMenuMiHistorial;
    }
}
