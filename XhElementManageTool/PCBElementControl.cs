using System;
using System.Windows.Forms;

namespace XhElementManageTool
{
    public partial class PCBElementControl : UserControl
    {
        public string eName { get; set; }
        public string eWeihao { get; set; }
        public string eCount { get; set; }

        private bool isModifing = false; //是否正在修改

        //需要一个委托，委托是否点击了保存修改按钮或者删除按钮
        //其中需要一个判断符号和数据。
        //符号：0为保存，1为删除，
        //string[]中，保存为长度3（eName,eWeihao,eCount)，删除时为长度1（eName),
        public delegate void ClickControlHandler(int fu,string[] data);

        //然后是一个event
        public event ClickControlHandler ClickEvent;

        public PCBElementControl(string eName, string eWeihao, string eCount)
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
            if (e.KeyChar < 48 || e.KeyChar > 57 || e.KeyChar == 8) e.Handled = true;
        }

        //变换也修改的样式
        private void btn_switch_Click(object sender, EventArgs e)
        {
            if (isModifing)
            {
                //那就保存
                //通过委托把要修改的东西传出去
                ClickEvent?.Invoke(0,new []{eName,tb_weihao.Text,tb_count.Text});
                
                tb_weihao.Enabled = false;
                tb_count.Enabled = false;
                btn_switch.Text = "/";
                isModifing = false;
            }
            else
            {
                //那就进入修改模式	
                tb_weihao.Enabled = true;
                tb_count.Enabled = true;
                btn_switch.Text = "√";
                isModifing = true;
            }
        }

        //删除
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //通过委托把要删除的东西传出去
            ClickEvent?.Invoke(1,new []{eName});
        }
    }
}