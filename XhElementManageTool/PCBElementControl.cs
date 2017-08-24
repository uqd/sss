using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XhElementManageTool
{
	public partial class PCBElementControl : UserControl
	{

		public string Pname { get; set; }
		public string Pweihao { get; set; }
		public string Pcount { get; set; }
		
		//需要一个委托
		public delegate void ClickDeleteHandler(string eName);
		//然后是一个event
		public event ClickDeleteHandler ClickDelete;

		public PCBElementControl()
		{
			InitializeComponent();
		}

		public void UpdatePcbElement()
		{
			tb_name.Text = Pname;
			tb_weihao.Text = Pname;
			tb_count.Text = Pname;
		}

		//设置只能是数字或者删除键
		private void tb_count_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < 48 || e.KeyChar > 57||e.KeyChar==8) e.Handled = true;
		}

		//
		private void btn_switch_Click(object sender, EventArgs e)
		{

		}

		//删除
		private void btn_delete_Click(object sender, EventArgs e)
		{
			//通过委托把要删除的东西传出去
			ClickDelete?.Invoke(Pname);
		}
	}
}
