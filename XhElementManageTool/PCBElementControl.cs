using System;
using System.Windows.Forms;

namespace XhElementManageTool
{
	public partial class PCBElementControl : UserControl
	{

		public string eName { get; set; }
		public string eWeihao { get; set; }
		public string eCount { get; set; }
		
		//需要一个委托
		public delegate void ClickDeleteHandler(string eName);
		//然后是一个event
		public event ClickDeleteHandler ClickDelete;

		public PCBElementControl(string eName,string eWeihao,string eCount)
		{
			this.eName = eName;
			this.eWeihao = eWeihao;
			this.eCount = eCount;
			InitializeComponent();
			UpdatePcbElement();
		}

		public void UpdatePcbElement()
		{
			tb_name.Text = eName;
			tb_weihao.Text = eWeihao;
			tb_count.Text = eCount;
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
			ClickDelete?.Invoke(eName);
		}
	}
}
