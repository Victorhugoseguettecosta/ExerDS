using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void exer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExer1 Form2 = new frmExer1();
            Form2.Show();
        }

        private void exer2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExer2 Form3 = new frmExer2();
            Form3.Show();
        }
    }
}
