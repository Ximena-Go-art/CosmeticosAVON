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
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value+=2;
            if(ProgressBar.Value == 100)
            {
                TimerSplash.Stop();
                this.Hide();
                var logInView = new LogInView();
                logInView.ShowDialog();
                this.Close();
            }
        }
    }
}
