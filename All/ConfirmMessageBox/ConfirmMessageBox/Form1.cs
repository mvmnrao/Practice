using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConfirmMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

            if(dr == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("You have clicked Yes");
            }
            else
            {
                MessageBox.Show("You have clicked No");
            }
        }
    }
}
