using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace XhElementManageTool
{
    public partial class Form1 : Form
    {
        private OleDbConnection _conn;

        private bool isLocal = true;

        public Form1()
        {
            //============================================
            if (isLocal)
            {
                _conn = new OleDbConnection(
                    "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "
                    + AppDomain.CurrentDomain.BaseDirectory + "XhElementManageLib.mdb");
            }
            else
            {
                _conn = new OleDbConnection(
                    "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "
                    + "D:\\Code\\Rider\\XhElementManageTool\\XhElementManageTool\\XhElementManageLib.mdb");
            }

            InitializeComponent();

            //绑定委托与事件,也就是同时更新Tab1中的Element数据
            elementSelectControl1.SelectChange += SelectValueChange;

            //这是啥啊
            WhatIsThis();

            UpDatePcbBox();
        }

        //向pcb的元件列表中添加新的元件
        internal void AddEleMentToPCB(string selectElementName)
        {
            if (selectElementName == "") return;
            var pName = lb_pcb.SelectedItem.ToString();
            var eName = selectElementName;
            _conn.Open();

            //首先查询数据库中是否有重复的元件
            var cmd = _conn.CreateCommand();
            cmd.CommandText = " select * from " + pName + " where eName = '" + eName + "'";
            var dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("此元件已添加！");
                cmd.Dispose();
                _conn.Close();
                return;
            }
            dr.Dispose();
            cmd = _conn.CreateCommand();
            cmd.CommandText = " insert into " + pName + " (eName ,eWeihao,eCount) "
                              + "values( '" + eName + "', '请输入',0)";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            _conn.Close();
            UpDatePcbElementPanel();
        }

        private void WhatIsThis()
        {
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

            //这就是删除,弹出删除框。
            var result = MessageBox.Show("你确定要删除元件 '" + eName + "' 吗?", "删除", MessageBoxButtons.OKCancel);
            if ((int) result != 1) return;
            var sqlStr = "delete from Element where eName = '" + eName + "'";
            var cmd = new OleDbCommand(sqlStr, _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功");

            //需要刷新界面
            elementSelectControl1.UpdateValue();
            cmd.Dispose();
            _conn.Close();
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
                //这就是新增,弹出新增框。
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
                                 + "'" + DateTime.Now.ToString() + "',"
                                 + "'" + DateTime.Now.ToString() + "',"
                                 + "'" + cb_position.Text + "',"
                                 + "'" + tb_otherInfo.Text + "'"
                                 + ")";
                    var cmd = new OleDbCommand(SqlStr, _conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("保存成功");

                    _conn.Close();
                    //需要刷新界面
                    elementSelectControl1.UpdateValue();
                }
            }
            else
            {
                //这就是修改 ,对于结果来说,1是确定,2是取消
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
                                 + "'" + DateTime.Now.ToString() + "',"
                                 + "eOtherInfo="
                                 + "'" + tb_otherInfo.Text + "'"
                                 + " where eName = '" + eName + "'";
                    var cmd = new OleDbCommand(SqlStr, _conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功");
                    //需要刷新界面
                    elementSelectControl1.UpdateValue();
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
            tb_price.Text = "0";
            tb_count.Text = "0";
            tb_otherInfo.Text = "";
            var now = DateTime.Now;
            tb_createDate.Text = now.ToString();
            tb_modifyDate.Text = now.ToString();

            SetComboBoxValue();
        }

        private void SetComboBoxValue()
        {
            var data = elementSelectControl1.SelectList;
            data[0].Remove("全部");
            data[1].Remove("全部");
            data[2].Remove("全部");
            cb_type.DataSource = data[0];
            cb_facturer.DataSource = data[1];
            cb_position.DataSource = data[2];
        }

        //限制输入的只能为数字和小数点
        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型

            //如果输入的不是数字并且也不是“.”或者 “《--”退格键 或者 "del"键,那么拦截操作,不向下传递
            if (((int) e.KeyChar < 48 || (int) e.KeyChar > 57)
                && (int) e.KeyChar != 8 && (int) e.KeyChar != 46 && (int) e.KeyChar != 127)
                e.Handled = true;

            //
            if ((int) e.KeyChar == 46)
            {
                if (tb_price.Text.Length <= 0) e.Handled = true; //小数点不能在第一位
            }
        }

        //限制输入的只能为数字,小数点都不能有
        private void tb_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型

            //如果输入的不是数字并且也不是“.”或者 “《--”退格键 或者 "del"键,那么拦截操作,不向下传递
            if (((int) e.KeyChar < 48 || (int) e.KeyChar > 57)
                && (int) e.KeyChar != 8 && (int) e.KeyChar != 127)
                e.Handled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            elementSelectControl1.UpdateValue();
        }

        //新增了一个pcb板子,那也得在数据库中新增一个表
        private void btn_pcb_add_Click(object sender, EventArgs e)
        {
            //显示一个对话框询问pcb板的名字和编号
            var dl = new Dialog(_conn);
            dl.ShowDialog();
            UpDatePcbBox();
        }

        //刷新pcbBox
        private void UpDatePcbBox()
        {
            List<string> tables = new List<string>();
            //遍历PCBs
            _conn.Open();
            var cmd = _conn.CreateCommand();
            cmd.CommandText = " select elementTableName from PCBs ";
            var dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                _conn.Close();
                return;
            }
            while (dr.Read())
            {
                tables.Add((string) dr[0]);
            }
            lb_pcb.DataSource = tables;
            _conn.Close();
        }

        //删除pcb板子
        private void btn_pcb_delete_Click(object sender, EventArgs e)
        {
            if (lb_pcb.Items.Count == 0) return;
            //获取此时pcbsList中的所选项
            var pName = (string) lb_pcb.SelectedValue;
            var result = MessageBox.Show("你确定要删除名为 '" + pName + "' 的PCB数据吗?", "删除PCB", MessageBoxButtons.OKCancel);
            if ((int) result != 1) return;
            _conn.Open();
            //删除PCBs中的数据
            var cmd = _conn.CreateCommand();
            cmd.CommandText = "delete from PCBs where pName = '" + pName + "'";
            cmd.ExecuteNonQuery();
            //删除表
            cmd = _conn.CreateCommand();
            cmd.CommandText = "drop Table " + pName + "";
            cmd.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("删除成功");
            UpDatePcbBox();
        }

        private void UpDatePcbElementPanel()
        {
            lb_pcb_SelectedValueChanged(null, null);
        }

        private void lb_pcb_SelectedValueChanged(object sender, EventArgs e)
        {
            var s = 0;
            Console.Out.WriteLine("第三页 :" + s);

            //获得当前选中的pName
            var pName = lb_pcb.SelectedItem.ToString();
            //查找表数据
            if (_conn.State == ConnectionState.Closed) _conn.Open();
            var cmd = _conn.CreateCommand();
            cmd.CommandText = "select * from " + pName;
            var dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                p_pcbEle.Controls.Clear();
                _conn.Close();
                return;
            }
            p_pcbEle.Controls.Clear();
            while (dr.Read())
            {
                //构造新的PCBElementControl
                var pe = new PCBElementControl(
                    dr["eName"].ToString(),
                    dr["eWeihao"].ToString(),
                    dr["eCount"].ToString())
                {
                    Name = "pe" + s,
                    Location = new Point(0, 30 * s)
                };
                s++;
                p_pcbEle.Controls.Add(pe);
                //来点委托
                pe.ClickEvent += EventPcbElement;
            }
            _conn.Close();
        }

        //操作pcb元件表中的元件
        private void EventPcbElement(int fu, string[] datas)
        {
            if (fu == 0)
            {
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = "update " + lb_pcb.SelectedItem + " set eWeihao = '" + datas[1] + "',"
                                  + "eCount = " + datas[2]
                                  + " where eName ='" + datas[0] + "'";
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            if (fu == 1)
            {
                var re = MessageBox.Show("你确定要从pcb中删除名为:'" + datas[0] + "' 的元件?", "", MessageBoxButtons.OKCancel);
                if ((int) re == 0) return;
                _conn.Open();
                var cmd = _conn.CreateCommand();
                cmd.CommandText = "delete from " + lb_pcb.SelectedItem + " where eName ='" + datas[0] + "'";
                cmd.ExecuteNonQuery();
                _conn.Close();
                UpDatePcbElementPanel();
            }
        }

        private void btn_pcbAddElement_Click(object sender, EventArgs e)
        {
            SelectPcbElement spe = new SelectPcbElement(this, _conn);
            spe.ShowDialog();
        }

        //导入元件库
        private void btn_element_input_Click(object sender, EventArgs e)
        {
            //选择一个文件
            var ofd = new OpenFileDialog()
            {
                Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*",
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            var strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ofd.FileName + ";"
                          + "Extended Properties=Excel 8.0";
            var ds = new DataSet();
            var oada = new OleDbDataAdapter("select * from [Sheet1$]", strConn);
            oada.Fill(ds); //填充dataSet
            if (ds.Tables.Count <= 0) return;
            var dt = ds.Tables[0];
            //接下来将dataTable中的数据载入到element数据库中,因为现在只有立创一个品牌的的
            //所以先直接按照一个模板来做
            _conn.Open();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                //数据的预处理,例如价格和数量和名称
                var ePrice = dt.Rows[i][10].ToString();
                ePrice = ePrice.Substring(1, ePrice.Length - 3);
                var eCount = dt.Rows[i][7].ToString();
                eCount = eCount.Substring(0, eCount.Length - 1);
                var eName = dt.Rows[i][5].ToString();
                var eCreateDate = DateTime.Now.ToString();
                var eModifyDate = eCreateDate;

                //第一步，检查数据库中是否有已存在的 元件，如果有的话，那就只更新数量和单价
                //检测标准暂定为 商品编号，品牌和厂家型号。
                var cmd = _conn.CreateCommand();
                cmd.CommandText = "select * from Element where eNo = '" + dt.Rows[i][1] + "' and eFacturer ='"
                                  + dt.Rows[i][2] + "' and eModel = '" + dt.Rows[i][3] + "'";
                if (cmd.ExecuteReader().HasRows)
                {
                    //说明已存在,只更新数量和单价,并保存记录
                    var sqlStr0 = "update Element set ePrice = " + ePrice + ", eCount+=" + eCount
                                  + "where eNo = '" + dt.Rows[i][1] + "' and eFacturer ='"
                                  + dt.Rows[i][2] + "' and eModel = '" + dt.Rows[i][3] + "'";
                    cmd = new OleDbCommand(sqlStr0, _conn);
                    cmd.ExecuteNonQuery();

                    //记录


                    continue;
                }
                //插入新元件
                ExeSQLString("insert into Element (eNo,eName,eType,eFacturer,eModel,ePackage,ePrice,eCount,"
                             + "eCreateDate,eModifyDate,ePosition,eOtherInfo) values("
                             + "'" + dt.Rows[i][1] + "',"
                             + "'" + eName + "',"
                             + "'" + "未知" + "',"
                             + "'" + dt.Rows[i][2] + "',"
                             + "'" + dt.Rows[i][3] + "',"
                             + "'" + dt.Rows[i][4] + "',"
                             + "" + ePrice + ","
                             + "" + eCount + ","
                             + "'" + eCreateDate + "',"
                             + "'" + eModifyDate + "',"
                             + "'" + "未知" + "',"
                             + "'" + "" + "'"
                             + ")");
                ExeSQLString("insert into Info (type,info,modifyDate) values ('element','新增元件" + eName
                             + " 当前价格:"+ePrice+"','" + eModifyDate + "')");
            }
            _conn.Close();
            MessageBox.Show("导入成功");
            elementSelectControl1.UpdateValue();
        }

        //因为很多的执行语句，所以终于写了
        private void ExeSQLString(string str)
        {
            var cmd = new OleDbCommand(str, _conn);
            cmd.ExecuteNonQuery();
        }
    }
}