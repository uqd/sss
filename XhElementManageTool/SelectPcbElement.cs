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
	public partial class SelectPcbElement : Form
	{
		private Form1 f1;
		public OleDbConnection _conn;
		public SelectPcbElement(Form1 form1,OleDbConnection _conn)
		{
			f1 = form1;
			this._conn = _conn;
			InitializeComponent();
		}

		private void btn_no_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_yes_Click(object sender, EventArgs e)
		{
			Close();
			f1.AddEleMentToPCB(elementSelectControl1.SelectElementName);
		}
	}
}
