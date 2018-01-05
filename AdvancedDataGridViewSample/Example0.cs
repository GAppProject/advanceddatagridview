using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdvancedDataGridViewSample
{
    public partial class Example0 : Form
    {
        private DataTable _dataTable = null;
        private DataSet _dataSet = null;


        public Example0()
        {
            InitializeComponent();

            //initialize dataset
            _dataTable = new DataTable();
            _dataSet = new DataSet();

            //initialize bindingsource
            bindingSource_main.DataSource = _dataSet;

            //initialize datagridview
            advancedDataGridView_main.SetDoubleBuffered();
            advancedDataGridView_main.DataSource = bindingSource_main;

            //set bindingsource
            SetTestData();
        }

 
        private void SetTestData()
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

            _dataTable = _dataSet.Tables.Add("TableTest");
            _dataTable.Columns.Add("int", typeof(int));
            _dataTable.Columns.Add("decimal", typeof(decimal));
            _dataTable.Columns.Add("double", typeof(double));
            _dataTable.Columns.Add("date", typeof(DateTime));
            _dataTable.Columns.Add("datetime", typeof(DateTime));
            _dataTable.Columns.Add("string", typeof(string));
            _dataTable.Columns.Add("boolean", typeof(bool));
            _dataTable.Columns.Add("guid", typeof(Guid));
            _dataTable.Columns.Add("image", typeof(Bitmap));
            _dataTable.Columns.Add("timespan", typeof(TimeSpan));

            bindingSource_main.DataMember = _dataTable.TableName;

           // bindingSource_main.DataSource = ls;

          //  advancedDataGridViewSearchToolBar_main.SetColumns(advancedDataGridView_main.Columns);
        }

        private void AddTestData()
        {
            Random r = new Random();
            Image[] sampleimages = new Image[2];
            sampleimages[0] = Image.FromFile(Path.Combine(Application.StartupPath, "flag-green_24.png"));
            sampleimages[1] = Image.FromFile(Path.Combine(Application.StartupPath, "flag-red_24.png"));

            int maxMinutes = (int)((TimeSpan.FromHours(20) - TimeSpan.FromHours(10)).TotalMinutes);

            for (int i = 0; i <= 100; i++)
            {
                object[] newrow = new object[] {
                    i,
                    (decimal)i*2/3,
                    i % 2 == 0 ? (double)i*2/3 : (double)i/2,
                    DateTime.Today.AddHours(i*2).AddHours(i%2 == 0 ?i*10+1:0).AddMinutes(i%2 == 0 ?i*10+1:0).AddSeconds(i%2 == 0 ?i*10+1:0).AddMilliseconds(i%2 == 0 ?i*10+1:0).Date,
                    DateTime.Today.AddHours(i*2).AddHours(i%2 == 0 ?i*10+1:0).AddMinutes(i%2 == 0 ?i*10+1:0).AddSeconds(i%2 == 0 ?i*10+1:0).AddMilliseconds(i%2 == 0 ?i*10+1:0),
                    i*2 % 3 == 0 ? null : i.ToString()+" str",
                    i % 2 == 0 ? true:false,
                    Guid.NewGuid(),
                    sampleimages[r.Next(0, 2)],
                    TimeSpan.FromHours(10).Add(TimeSpan.FromMinutes(r.Next(maxMinutes)))
                };

                _dataTable.Rows.Add(newrow);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            AddTestData();

  }

        private void advancedDataGridView_main_FilterStringChanged(object sender, EventArgs e)
        {
            bindingSource_main.Filter = advancedDataGridView_main.FilterString;
            textBox_filter.Text = bindingSource_main.Filter;
        }

        private void advancedDataGridView_main_SortStringChanged(object sender, EventArgs e)
        {
            bindingSource_main.Sort = advancedDataGridView_main.SortString;
            textBox_sort.Text = bindingSource_main.Sort;
        }

        private void bindingSource_main_ListChanged(object sender, ListChangedEventArgs e)
        {
            
        }

       


        

        private void advancedDataGridViewSearchToolBar_main_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            //bool restartsearch = true;
            //int startColumn = 0;
            //int startRow = 0;
            //if (!e.FromBegin)
            //{
            //    bool endcol = advancedDataGridView_main.CurrentCell.ColumnIndex + 1 >= advancedDataGridView_main.ColumnCount;
            //    bool endrow = advancedDataGridView_main.CurrentCell.RowIndex + 1 >= advancedDataGridView_main.RowCount;

            //    if (endcol && endrow)
            //    {
            //        startColumn = advancedDataGridView_main.CurrentCell.ColumnIndex;
            //        startRow = advancedDataGridView_main.CurrentCell.RowIndex;
            //    }
            //    else
            //    {
            //        startColumn = endcol ? 0 : advancedDataGridView_main.CurrentCell.ColumnIndex + 1;
            //        startRow = advancedDataGridView_main.CurrentCell.RowIndex + (endcol ? 1 : 0);
            //    }
            //}
            //DataGridViewCell c = advancedDataGridView_main.FindCell(
            //    e.ValueToSearch,
            //    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
            //    startRow,
            //    startColumn,
            //    e.WholeWord,
            //    e.CaseSensitive);
            //if (c == null && restartsearch)
            //    c = advancedDataGridView_main.FindCell(
            //        e.ValueToSearch,
            //        e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
            //        0,
            //        0,
            //        e.WholeWord,
            //        e.CaseSensitive);
            //if (c != null)
            //    advancedDataGridView_main.CurrentCell = c;
        }

    }
}
