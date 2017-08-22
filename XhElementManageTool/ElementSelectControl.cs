using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;

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
		    //课题 如何用户控件访问from的非静态方法。
			Form1.SelectionChanged(dataGridView_select.SelectedCells[0].Value.ToString());
		}
	}
}