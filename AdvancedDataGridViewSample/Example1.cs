using App.Entities;
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
    public partial class Example1 : Form
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void Example1_Load(object sender, EventArgs e)
        {
            List<EntityData> ls = new List<EntityData>();
            for (int i = 0; i < 100; i++)
            {
                ls.Add(new EntityData()
                {
                    StringData = "string" + i,
                    IntData = i,
                    DateTimeData = DateTime.Now.AddDays(i)
                });
            }

            bindingSource1.DataSource = ls;
            this.advancedDataGridView1.DataSource = bindingSource1;
            this.advancedDataGridViewSearchToolBar1.SetColumns(this.advancedDataGridView1.Columns);
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = advancedDataGridView1.FilterString;
        }
    }
}
