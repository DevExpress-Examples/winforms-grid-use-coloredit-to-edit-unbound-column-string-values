using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Text.RegularExpressions;

namespace ColorEditExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = FillDataTable();
            gridControl1.DataSource = dt;
            gridControl2.DataSource = dt;
            gridView1.Columns["ColorString"].Visible = false;

            GridColumn unboundColumn = gridView1.Columns.AddField("Color");
            unboundColumn.VisibleIndex = gridView1.Columns.Count;
            unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            RepositoryItemColorEdit ce = new RepositoryItemColorEdit();
            ce.ShowCustomColors = false;
            unboundColumn.ColumnEdit = ce;
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            DataView dv = view.DataSource as DataView;
            if (e.IsGetData)
                e.Value = GetColorFromString(dv[e.ListSourceRowIndex]["ColorString"].ToString());
            else
                dv[e.ListSourceRowIndex]["ColorString"] = ((Color)e.Value).Name;
        }

        Color GetColorFromString(string colorString)
        {
            Color color = Color.Empty;
            ColorConverter converter = new ColorConverter();
            try
            { 
                color = (Color)converter.ConvertFromString(colorString); 
            }
            catch 
            { }
            return color;
        }

        DataTable FillDataTable()
        {
            DataTable _dataTable = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn("ID", System.Type.GetType("System.Int32"));
            _dataTable.Columns.Add(col);
            col = new DataColumn("ColorString", System.Type.GetType("System.String"));
            _dataTable.Columns.Add(col);

            row = _dataTable.NewRow();
            row["ID"] = "1"; row["ColorString"] = "Red";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = "2"; row["ColorString"] = "Green";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = "3"; row["ColorString"] = "Blue";
            _dataTable.Rows.Add(row);

            return _dataTable;
        }
    }
}
