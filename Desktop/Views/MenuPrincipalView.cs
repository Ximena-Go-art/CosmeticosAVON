using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void SubMenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuUsuarios_Click(object sender, EventArgs e)
        {
           var usuariosView = new UsuariosListaView();
             usuariosView.MdiParent = this;
               usuariosView.Show();
        }
    }
}
