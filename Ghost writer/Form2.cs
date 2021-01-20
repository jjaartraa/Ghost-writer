using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghost_writer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            int counter = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = counter.ToString();
            this.Refresh();
            counter -= 1;
            if (counter == 0)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
