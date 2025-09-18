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
            toolStripMenuItem1 = new ToolStripMenuItem();
            SubMenuHistoria = new ToolStripMenuItem();
            principalToolStripMenuItem = new ToolStripMenuItem();
            SubMenuUsuarios = new ToolStripMenuItem();
            SubMenuConsultores = new ToolStripMenuItem();
            SunMenuProductos = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            SubMenuSalir = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubMenuHistoria });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(82, 24);
            toolStripMenuItem1.Text = "Nosotras";
            // 
            // SubMenuHistoria
            // 
            SubMenuHistoria.Name = "SubMenuHistoria";
            SubMenuHistoria.Size = new Size(199, 26);
            SubMenuHistoria.Text = "Nuestra Historia";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubMenuUsuarios, SubMenuConsultores, SunMenuProductos });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(80, 24);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // SubMenuUsuarios
            // 
            SubMenuUsuarios.Name = "SubMenuUsuarios";
            SubMenuUsuarios.Size = new Size(224, 26);
            SubMenuUsuarios.Text = "Usuarios";
            // 
            // SubMenuConsultores
            // 
            SubMenuConsultores.Name = "SubMenuConsultores";
            SubMenuConsultores.Size = new Size(224, 26);
            SubMenuConsultores.Text = "Consultores";
            // 
            // SunMenuProductos
            // 
            SunMenuProductos.Name = "SunMenuProductos";
            SunMenuProductos.Size = new Size(224, 26);
            SunMenuProductos.Text = "Productos";
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
            SubMenuSalir.Size = new Size(224, 26);
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
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Venta de Cosmeticos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem SubMenuHistoria;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem SubMenuUsuarios;
        private ToolStripMenuItem SubMenuConsultores;
        private ToolStripMenuItem SunMenuProductos;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem SubMenuSalir;
        private ToolStrip toolStrip1;
    }
}
