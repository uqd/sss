using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XhElementManageTool
{
    public partial class Dialog : Form
    {
        private AmumuReadAndWriteHelper rwh;

        public Dialog(AmumuReadAndWriteHelper rwh)
        {
            this.rwh = rwh;
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();
        }

        //判断,这是辣眼睛的烂代码
        private void btn_dl_yes_Click(object sender, EventArgs e)
        {
            if (tb_dl_No.Text.Trim() == "") return;
            if (tb_dl_name.Text.Trim() == "") return;
            //从数据库中检测是否有同名的
            var dr = rwh.OpenSelectSqlStr("select pNo from PCBs where pNo = '" + tb_dl_No.Text.Trim() + "'");
            if (dr != null)
            {
                label_dl_info1.Text = "此编号已存在";
                return;
            }
            dr = rwh.OpenSelectSqlStr("select pName from PCBs where pName = '" + tb_dl_name.Text.Trim() + "'");
            if (dr != null)
            {
                label_dl_info2.Text = "此名称已存在";
                return;
            }
            rwh.Close();
            //需要在PCBs表中添加
            //这就是新的
            rwh.RunSqlStr("insert into PCBs "
                          + "(pNo,"
                          + "pName,"
                          + "elementTableName,"
                          + "createDate,"
                          + "modifyDate,"
                          + "OtherInfo)"
                          + " values("
                          + "'" + tb_dl_No.Text.Trim() + "',"
                          + "'" + tb_dl_name.Text.Trim() + "',"
                          + "'" + tb_dl_name.Text.Trim() + "',"
                          + "'" + DateTime.Now + "',"
                          + "'" + DateTime.Now + "',"
                          + "'" + tb_otherInfo.Text.Trim() + "')");
            rwh.RunSqlStr("CREATE TABLE " + tb_dl_name.Text.Trim()
                          + " (_id AUTOINCREMENT PRIMARY KEY , " +
                          "eName varchar(255) NOT NULL ," +
                          "eWeihao varchar(255), eCount SmallInt)");
            Close();
        }
    }
}