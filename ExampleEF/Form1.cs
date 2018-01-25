using App.DAL;
using App.Entities;
using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleEF
{
    public partial class Form1 : Form
    {
        ModelConext context = new ModelConext();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = bindingSource1;
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
           


            context.EntityDatas.Load();


           // BindingListView<EntityData> view = new BindingListView<EntityData>(context.EntityDatas.Local);
            
            this.bindingSource1.DataSource = context.EntityDatas.Local;


             this.bindingSource1.Filter = "IntData = 1";
            MessageBox.Show("this.bindingSource1.SupportsFiltering :" + this.bindingSource1.SupportsFiltering);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            context.SaveChanges();
        
        }
    }
}
