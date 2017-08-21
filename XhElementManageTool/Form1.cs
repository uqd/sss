using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XhElementManageTool
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//============================================
			String path = System.AppDomain.CurrentDomain.BaseDirectory;

			OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "+ "D:\\Code\\RiderProjects\\XhElementManageTool\\XhElementManageTool\\" + "XhElementManageLib.mdb");

			OleDbCommand cmd = conn.CreateCommand();

			cmd.CommandText = "select * from Element";

			conn.Open();

			OleDbDataReader dr = cmd.ExecuteReader();

			DataTable dt = new DataTable();

			if (dr.HasRows)
			{
				for (int i = 0; i < dr.FieldCount; i++)
				{
					dt.Columns.Add(dr.GetName(i));
				}
				dt.Rows.Clear();
			}

			while (dr.Read())
			{
				DataRow row = dt.NewRow();  //在这里就根据dt的columns确定了数组的长度。
				for (int i = 0; i < dr.FieldCount; i++)
				{
					row[i] = dr[i];
				}
				dt.Rows.Add(row);
			}
			cmd.Dispose();
			conn.Close();
			dataGridView1.DataSource = dt;

			//===================================================


		}

	}
}
