using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301007115
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.startForm.Hide(); //Refactoring
            Program.mainForm.Show(); //Refactoring

            //MainForm mainForm = new MainForm();
            //mainForm.Show();
           // this.Hide();

        }

        private void Welcomelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
