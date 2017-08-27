using System.Data;
using System.Data.OleDb;

namespace XhElementManageTool
{
    //阿木木读写助手，简写为rwh
    public class AmumuReadAndWriteHelper
    {
        private readonly OleDbConnection _conn;
        private OleDbCommand _cmd;

        //初始化
        public AmumuReadAndWriteHelper(OleDbConnection conn)
        {
            _conn = conn;
        }

        //打开一个选择的sql语句，返回值是是否有返回值;
        //注意返回null的时候是没必要close的，已经做过了
        public OleDbDataReader OpenSelectSqlStr(string s)
        {
            if(_conn.State!=ConnectionState.Open)
            _conn.Open();
            _cmd = _conn.CreateCommand();
            _cmd.CommandText = s;
            var dr = _cmd.ExecuteReader();
            //_conn.Close();
            if (dr != null && dr.HasRows) return dr;
            _cmd.Dispose();
            return null;
        }

        //运行执行语句，没有返回值
        public void RunSqlStr(string s)
        {
            if(_conn.State!=ConnectionState.Open)
            _conn.Open();
            _cmd = new OleDbCommand(s,_conn);
            _cmd.ExecuteNonQuery();
            _cmd.Dispose();
//            _conn.Close();
        }

    }
}