namespace XhElementManageTool
{
	partial class SelectPcbElement
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.elementSelectControl1 = new XhElementManageTool.ElementSelectControl();
			this.btn_no = new System.Windows.Forms.Button();
			this.btn_yes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// elementSelectControl1
			// 
			this.elementSelectControl1.Location = new System.Drawing.Point(0, 0);
			this.elementSelectControl1.Name = "elementSelectControl1";
			this.elementSelectControl1.Size = new System.Drawing.Size(242, 328);
			this.elementSelectControl1.TabIndex = 0;
			// 
			// btn_no
			// 
			this.btn_no.Location = new System.Drawing.Point(123, 328);
			this.btn_no.Name = "btn_no";
			this.btn_no.Size = new System.Drawing.Size(115, 23);
			this.btn_no.TabIndex = 1;
			this.btn_no.Text = "取消";
			this.btn_no.UseVisualStyleBackColor = true;
			this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
			// 
			// btn_yes
			// 
			this.btn_yes.Location = new System.Drawing.Point(3, 328);
			this.btn_yes.Name = "btn_yes";
			this.btn_yes.Size = new System.Drawing.Size(119, 23);
			this.btn_yes.TabIndex = 1;
			this.btn_yes.Text = "确定";
			this.btn_yes.UseVisualStyleBackColor = true;
			this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
			// 
			// SelectPcbElement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 354);
			this.ControlBox = false;
			this.Controls.Add(this.btn_yes);
			this.Controls.Add(this.btn_no);
			this.Controls.Add(this.elementSelectControl1);
			this.Name = "SelectPcbElement";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SelectPcbElement";
			this.ResumeLayout(false);

		}

		#endregion

		private ElementSelectControl elementSelectControl1;
		private System.Windows.Forms.Button btn_no;
		private System.Windows.Forms.Button btn_yes;
	}
}