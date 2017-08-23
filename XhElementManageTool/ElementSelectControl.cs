using System;
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
        //公用的控件
        private OleDbConnection _conn;

        private OleDbCommand _cmd;

        private bool isReay = false;

        //这是用来公用的，其他的外部方法也是可以用的
        public List<List<string>> _selectList = new List<List<string>>();
        
        //申明一个委托
        public delegate void SelectValueChangeHandler(ElementStruct.Element element);
        //同时申明一个事件
        public event SelectValueChangeHandler SelectChange;

        public ElementSelectControl()
        {
            InitializeComponent();

            Init();
        }

        //初始化
        private void Init()
        {
            _conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " +
                                        "D:\\Code\\Rider\\XhElementManageTool\\XhElementManageTool\\XhElementManageLib.mdb");

            //载入comobox的数据情况
            LoadComboBoxData();

            isReay = true;

            SelectSettingChange(null, null);
        }

        private void LoadComboBoxData()
        {
            string[] ooo = {"eType", "eFacturer", "ePosition"};
            foreach (var o in ooo)
            {
                _cmd = _conn.CreateCommand();
                _cmd.CommandText = "select " + o + " from Element group by " + o;
                _conn.Open();
                var dr = _cmd.ExecuteReader();
                var list = new List<string> {"全部"};
                while (dr != null && dr.Read())
                {
                    list.Add((string) dr[0]);
                }
                _selectList.Add(list);
                _cmd.Dispose();
                _conn.Close();
            }
            cb_type.DataSource = _selectList[0];
            cb_facturer.DataSource = _selectList[1];
            cb_position.DataSource = _selectList[2];
        }

        public void SelectSettingChange(object sender, EventArgs e)
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

            _cmd = _conn.CreateCommand();
            _cmd.CommandText = "select eName " + strNo + strModel + strPackage + " from Element " + strSqlWhere;
            _conn.Open();
            LoadData(_conn, _cmd);
        }

        private void LoadData(OleDbConnection conn, OleDbCommand cmd)
        {
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
            conn.Close();
            dataGridView_select.DataSource = dt;
        }


        //加载的时候会执行两次，不知道为什么，不管了
        private void dataGridView_select_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_select.SelectedCells.Count == 0) return;
            //获取型号名字
            var eName = dataGridView_select.SelectedCells[0].Value.ToString();
            if (_conn.State == ConnectionState.Open) _conn.Close();
            _cmd = _conn.CreateCommand();
            _cmd.CommandText = "select * from Element where eName = '" + eName + "'";
            _conn.Open();
            var dr = _cmd.ExecuteReader();
            if (dr == null) return;
            if (!dr.HasRows)
            {
                MessageBox.Show("异常，未找到名称为 " + eName + " 项");
            }
            else
            {
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
                //反正就是把element传出去了
                SelectChange?.Invoke(element);
            }
            _cmd.Dispose();
            _conn.Close();
        }
    }
}