using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UDisk
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void buttongotoClick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonquitClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出U盘助手吗？", "助手提示", MessageBoxButtons.YesNo);
            if ((result == System.Windows.Forms.DialogResult.No))
            {
                return;
            }
            if ((result == System.Windows.Forms.DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void formclose(object sender, FormClosedEventArgs e)
        {
            Process close = Process.GetProcessById(Process.GetCurrentProcess().Id);
        }

    }
}
