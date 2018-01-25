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
        List<EntityData> ls = new List<EntityData>();

        public Example1()
        {
            InitializeComponent();
        }

        private void Example1_Load(object sender, EventArgs e)
        {
          
            for (int i = 0; i < 100; i++)
            {
                ls.Add(new EntityData()
                {
                    StringData = "string" + i,
                    IntData = i,
                    
                });
            }

            
            bindingSource1.DataSource = ls;
           // bindingSource1.Filter = "([StringData] IN ('string1', 'string0'))";

            this.advancedDataGridView1.DataSource = bindingSource1;
            this.dataGridView1.DataSource = bindingSource1;


        }

        private void RefReshData()
        {
            bindingSource1.DataSource = ls;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = advancedDataGridView1.FilterString;
           
       
            txtFilter.Text = advancedDataGridView1.FilterString;
            RefReshData();
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.txtSort.Text = this.advancedDataGridView1.SortString;
            RefReshData();
        }
    }
}
