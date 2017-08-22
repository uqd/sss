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
		private OleDbConnection _conn;

		public Form1()
		{
			InitializeComponent();

			//============================================

			_conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\Code\\Rider\\XhElementManageTool\\XhElementManageTool\\XhElementManageLib.mdb");

			OleDbCommand cmd = _conn.CreateCommand();

			cmd.CommandText = "select * from Element";

			_conn.Open();

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
			_conn.Close();
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

			SetComboBoxValue();
		}

		private void SetComboBoxValue()
		{
			var data = elementSelectControl1._selectList;
			data[0].Remove("全部");
			data[1].Remove("全部");
			data[2].Remove("全部");
			cb_type.DataSource = data[0];
			cb_facturer.DataSource = data[1];
			cb_position.DataSource = data[2];
		}

		public static void UpdateData(ElementStruct.Element element)
		{
			throw new NotImplementedException();
		}

		public void SelectionChanged(string eName)
		{
			if (_conn.State == ConnectionState.Open) _conn.Close();
			var _cmd = _conn.CreateCommand();
			_cmd.CommandText = "select * from Element where eName = '" + eName + "'";
			_conn.Open();
			var dr = _cmd.ExecuteReader();
			if (!dr.HasRows)
			{
				MessageBox.Show("异常，未找到名称为 " + eName + " 项");
			}
			else
			{
				dr.Read ();

				tb_No.Text = dr["eNo"].ToString();
					dr["eName"].ToString(),
					dr["eType"].ToString(),
					dr["eFacturer"].ToString(),
					dr["eModel"].ToString(),
					dr["ePackage"].ToString(),
					(int)dr["ePrice"],
					(int)dr["eCount"],
					dr["eCreateDate"].ToString(),
					dr["eModifyDate"].ToString(),
					dr["ePosition"].ToString(),
					dr["eOtherInfo"].ToString()

			}
			_cmd.Dispose();
			_conn.Close();
		}
	}
}
