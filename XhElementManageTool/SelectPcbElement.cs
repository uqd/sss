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
        private readonly Form1 _f;
        private readonly AmumuReadAndWriteHelper rwh;

        public SelectPcbElement(Form1 form1, AmumuReadAndWriteHelper rwh)
        {
            _f = form1;
            this.rwh = rwh;
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Close();
            _f.AddEleMentToPcb(elementSelectControl1.SelectElementName);
        }
    }
}