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
        private OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();

            //绑定委托与事件
            elementSelectControl1.SelectChange += SelectValueChange;

            //============================================

            _conn = new OleDbConnection(
                "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\Code\\Rider\\XhElementManageTool\\XhElementManageTool\\XhElementManageLib.mdb");

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
                DataRow row = dt.NewRow(); //在这里就根据dt的columns确定了数组的长度。
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

        private void SelectValueChange(ElementStruct.Element element)
        {
            SetComboBoxValue();

            //将数据设置出去
            tb_No.Text = element.eNo;
            tb_Name.Text = element.eName;
            cb_type.Text = element.eType;
            cb_facturer.Text = element.eFacturer;
            tb_model.Text = element.eModel;
            tb_package.Text = element.ePackage;
            tb_price.Text = element.ePrice + "";
            tb_count.Text = element.eCount + "";
            tb_createDate.Text = element.eCreateDate;
            tb_modifyDate.Text = element.eModifDate;
            cb_position.Text = element.ePosition;
            tb_otherInfo.Text = element.eOtherInfo;
        }

        //点击方法的设置
        private void Btn_Click(object sender, EventArgs e)
        {
            switch (((Button) sender).Name)
            {
                case "btn_add":
                    CreateNewElement();
                    break;
                case "btn_delete":
                    DeleteElement();
                    break;
                case "btn_reback":
                    break;
                case "btn_save":
                    SaveElement();
                    break;
            }
        }

        private void DeleteElement()
        {
            var eName = tb_Name.Text.Trim();
            if (eName == "") return;

            //这就是删除，弹出删除框。
            var result = MessageBox.Show("你确定要删除元件 '" + eName + "' 吗?", "删除", MessageBoxButtons.OKCancel);
            if ((int) result != 1) return;
            var sqlStr = "delect from Element where eName = '" + eName + "'"; 
            var cmd = new OleDbCommand(sqlStr, _conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功");

            //需要刷新界面
            elementSelectControl1.SelectSettingChange(null, null);
        }

        private void SaveElement()
        {
            var eName = tb_Name.Text.Trim();
            //首先需要一些东西是必填的
            //为了简单就只是名称是必填的
            if (eName == "")
            {
                MessageBox.Show("元件名称是必需填写的！");
                return;
            }
            //我们需要在数据库中查找是否有相应的eName
            //来确定这是新增一个元件还是修改一个元件的信息
            var com = _conn.CreateCommand();
            com.CommandText = "select Count(*) from Element where eName = '" + eName + "'";
            _conn.Open();
            var dr = com.ExecuteReader();
            if (dr == null) return;
            if (!dr.Read()) return;
            if (dr[0].ToString().Equals("0"))
            {
                //这就是新增，弹出新增框。
                var result = MessageBox.Show("你确定要新增一个新元件'" + eName + "'?", "新增", MessageBoxButtons.OKCancel);
                if ((int) result == 1)
                {
                    var SqlStr = "insert into Element "
                                 + "("
                                 + "eNo,"
                                 + "eName,"
                                 + "eType,"
                                 + "eFacturer,"
                                 + "eModel,"
                                 + "ePackage,"
                                 + "ePrice,"
                                 + "eCount,"
                                 + "eCreateDate,"
                                 + "eModifyDate,"
                                 + "ePosition,"
                                 + "eOtherInfo"
                                 + ") "
                                 + "values("
                                 + "'" + tb_No.Text + "',"
                                 + "'" + tb_Name.Text + "',"
                                 + "'" + cb_type.Text + "',"
                                 + "'" + cb_facturer.Text + "',"
                                 + "'" + tb_model.Text + "',"
                                 + "'" + tb_package.Text + "',"
                                 + "" + tb_price.Text + ","
                                 + "" + tb_count.Text + ","
                                 + "'" + tb_createDate.Text + "',"
                                 + "'" + tb_modifyDate.Text + "',"
                                 + "'" + cb_position.Text + "',"
                                 + "'" + tb_otherInfo.Text + "'"
                                 + ")";
                    var cmd = new OleDbCommand(SqlStr, _conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("保存成功");

                    //需要刷新界面
                    elementSelectControl1.SelectSettingChange(null, null);
                }
            }
            else
            {
                //这就是修改 ,对于结果来说，1是确定，2是取消
                var result = MessageBox.Show("你确定要修改名为'" + eName + "'资料?", "修改", MessageBoxButtons.OKCancel);
                if ((int) result == 1)
                {
                    var SqlStr = "update Element set "
                                 + "eModel="
                                 + "'" + tb_model.Text + "',"
                                 + "ePrice="
                                 + "" + tb_price.Text + ","
                                 + "eCreateDate="
                                 + "'" + tb_createDate.Text + "',"
                                 + "ePosition="
                                 + "'" + cb_position.Text + "',"
                                 + "eNo="
                                 + "'" + tb_No.Text + "',"
                                 + "eType="
                                 + "'" + cb_type.Text + "',"
                                 + "eFacturer="
                                 + "'" + cb_facturer.Text + "',"
                                 + "ePackage="
                                 + "'" + tb_package.Text + "',"
                                 + "eCount="
                                 + "" + tb_count.Text + ","
                                 + "eModifyDate="
                                 + "'" + tb_modifyDate.Text + "',"
                                 + "eOtherInfo="
                                 + "'" + tb_otherInfo.Text + "'"
                                 + " where eName = '" + eName + "'";
                    var cmd = new OleDbCommand(SqlStr, _conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功");
                    //需要刷新界面
                    elementSelectControl1.SelectSettingChange(null, null);
                }
            }
            dr.Dispose();
            _conn.Close();
        }

        //清空元件的属性区域的数据便于许督输入
        private void CreateNewElement()
        {
            tb_No.Text = "";
            tb_Name.Text = "";
            tb_model.Text = "";
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
    }
}