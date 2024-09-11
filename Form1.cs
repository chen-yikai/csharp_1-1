using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void showans_Click(object sender, EventArgs e)
        {
    
            label1.Text = "知本";
        }

        private void retry_Click(object sender, EventArgs e)
        {
            label1.Text = "飲水思源，猜一個台灣地名";
        }
    }
}
