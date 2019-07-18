using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301027317_
{
    public static class Program
    {
        public static StartForm startForm;
        public static MainForm mainForm;
        public static EndForm endForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            mainForm = new MainForm();
            endForm = new EndForm();
            Application.Run(new StartForm());
            Program.startForm.Hide();
            Program.mainForm.Show();
        }
       
    }
}
