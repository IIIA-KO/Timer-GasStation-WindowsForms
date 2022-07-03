using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstTaskButton_Click(object sender, EventArgs e)
        {
            FirstTaskForm firstTaskForm = new FirstTaskForm();
            firstTaskForm.MdiParent = this;
            firstTaskForm.Dock = DockStyle.Fill;
            firstTaskForm.Show();
        }

        private void SecondTaskButton_Click(object sender, EventArgs e)
        {
            SecondTaskForm secondTaskForm = new SecondTaskForm();
            secondTaskForm.ShowDialog();
        }
    }
}
