using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301027317_
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void TheBackButton_Click(object sender, EventArgs e)
        {
            TheBackButton.Enabled = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            
        }

       
    }
}
