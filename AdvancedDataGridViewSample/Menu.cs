using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedDataGridViewSample
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Example0_Click(object sender, EventArgs e)
        {
            Example0 form = new AdvancedDataGridViewSample.Example0();
            form.Show();

        }

        private void Example1_Click(object sender, EventArgs e)
        {
            Example1 form = new Example1();
            form.Show();
        }
    }
}
