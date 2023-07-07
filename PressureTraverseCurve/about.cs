using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressureTraverseCurve
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
        }
    }
}
