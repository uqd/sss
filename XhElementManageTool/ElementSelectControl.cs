﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using System.Reflection;

namespace XhElementManageTool
{
    public partial class ElementSelectControl : UserControl
    {
        private AmumuReadAndWriteHelper rwh;

        //公用的控件
        private bool isReay = false;

        //这是用来公用的，其他的外部方法也是可以用的
        public List<List<string>> SelectList;

        //申明一个委托，这是代表选择的项改变了
        public delegate void SelectValueChangeHandler(ElementStruct.Element element);

        //同时申明一个事件
        public event SelectValueChangeHandler SelectChange;

        //同样是委托，这是代表双击
        public delegate void DBClickElementHandler(string eName);

        //声明事件
        public event DBClickElementHandler DbClickElement;

        //可调用的被选择元件名字
        public string SelectElementName = "";

        public ElementSelectControl()
        {
            InitializeComponent();
        }

        public void setRwh(AmumuReadAndWriteHelper rwh)
        {
            this.rwh = rwh;
        }

        //初始化
        public void Init()
        {
            //载入comobox的数据情况
            LoadComboBoxData();

            isReay = true;

            SelectSettingChange(null, null);
        }

        public void LoadComboBoxData()
        {
            string[] ooo = {"eType", "eFacturer", "ePosition"};
            SelectList = new List<List<string>>();
            foreach (var o in ooo)
            {
                var dr = rwh.OpenSelectSqlStr("select " + o + " from Element group by " + o + " order by " + o);
                var list = new List<string> {"全部"};
                while (dr != null && dr.Read())
                {
                    list.Add((string) dr[0]);
                }
                SelectList.Add(list);
            }
            cb_type.DataSource = SelectList[0];
            cb_facturer.DataSource = SelectList[1];
            cb_position.DataSource = SelectList[2];
            cb_type.Update();
            cb_facturer.Update();
            cb_position.Update();
            rwh.Close();
        }

        //外部提示更新控件
        public void UpdateValue()
        {
            SelectSettingChange(null, null);
        }

        private void SelectSettingChange(object sender, EventArgs e)
        {
            if (isReay == false) return;

            var strNo = cb_No.Checked ? " ,eNo" : "";
            var strModel = cb_model.Checked ? " ,eModel" : "";
            var strPackage = cb_package.Checked ? " ,ePackage" : "";
            var strType = cb_type.Text.Equals("全部") ? "'%'" : " '" + cb_type.Text + "'";
            var strfacturer = cb_facturer.Text.Equals("全部") ? "'%'" : " '" + cb_facturer.Text + "'";
            var strPosition = cb_position.Text.Equals("全部") ? "'%'" : " '" + cb_position.Text + "'";

            var strSqlWhere = " where eType like " + strType + " and eFacturer like " + strfacturer +
                              " and ePosition like " + strPosition;

            var dr = rwh.OpenSelectSqlStr("select eName " + strNo + strModel + strPackage + " from Element " +
                                          strSqlWhere);
            LoadData(dr);
        }

        private void LoadData(IDataReader dr)
        {
            if (dr == null)
            {
                dataGridView_select.DataSource = null;
                return;
            }
            var dt = new DataTable();

            for (var i = 0; i < dr.FieldCount; i++)
            {
                dt.Columns.Add(dr.GetName(i));
            }

            while (dr.Read())
            {
                var row = dt.NewRow(); //在这里就根据dt的columns确定了数组的长度。
                for (var i = 0; i < dr.FieldCount; i++)
                {
                    row[i] = dr[i];
                }
                dt.Rows.Add(row);
            }
            dataGridView_select.DataSource = dt;
			dataGridView_select.Columns[0].Width = 100;

			rwh.Close();
        }

        int k = 0;

        //加载的时候会执行两次，不知道为什么，不管了
        private void dataGridView_select_SelectionChanged(object sender, EventArgs e)
        {
            k++;
            Console.Out.WriteLine("第一页: " + k);

            if (dataGridView_select.SelectedCells.Count == 0) return;
            //获取型号名字
            var eName = dataGridView_select.SelectedCells[0].Value.ToString();
            SelectElementName = eName;
            var dr = rwh.OpenSelectSqlStr("select * from Element where eName = '" + eName + "'");
            if (dr == null)
            {
                MessageBox.Show("异常，未找到名称为 " + eName + " 项");
                return;
            }
            dr.Read();
            var element = new ElementStruct.Element(
                dr["eNo"].ToString(),
                dr["eName"].ToString(),
                dr["eType"].ToString(),
                dr["eFacturer"].ToString(),
                dr["eModel"].ToString(),
                dr["ePackage"].ToString(),
                dr["ePrice"].ToString(),
                dr["eCount"].ToString(),
                dr["eCreateDate"].ToString(),
                dr["eModifyDate"].ToString(),
                dr["ePosition"].ToString(),
                dr["eOtherInfo"].ToString()
            );
            rwh.Close();
            //反正就是把element传出去了
            SelectChange?.Invoke(element);
        }

        private void dataGridView_select_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DbClickElement?.Invoke(dataGridView_select.SelectedCells[0].Value.ToString());
        }
    }
}