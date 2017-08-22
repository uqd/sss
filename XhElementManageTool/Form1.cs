﻿using System;
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
		private OleDbConnection conn;

		public Form1()
		{
			InitializeComponent();

			//============================================
			String path = System.AppDomain.CurrentDomain.BaseDirectory;

			conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "+path+ "XhElementManageLib.mdb");

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

		//点击方法的设置
		private void Btn_Click(object sender, EventArgs e)
		{
			switch(((Button )sender).Name)
			{
				case "btn_add":
					CreateNewElement();
					break;
				case "btn_delete":
					break;
				case "btn_reback":
					break;
				case "btn_save":
					break;
			}
		}

		//清空元件的属性区域的数据便于许督输入
		private void CreateNewElement()
		{
			tb_No.Text = "";
			tb_Name .Text = "";
			tb_model .Text = "";
			tb_package.Text = "";
			tb_price.Text = "";
			tb_count.Text = "";
			tb_otherInfo.Text = "";
			tb_createDate.Text = "";
			tb_modifyDate.Text = "";

			var data = elementSelectControl1._selectList;
			data[0].Remove("全部");
			data[1].Remove("全部");
			data[2].Remove("全部");
			cb_type.DataSource = data[0];
			cb_facturer.DataSource = data[1];
			cb_position.DataSource = data[2];
		}
	}
}
