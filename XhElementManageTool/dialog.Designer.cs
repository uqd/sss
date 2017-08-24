namespace XhElementManageTool
{
	partial class Dialog
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
			this.tb_dl_No = new System.Windows.Forms.TextBox();
			this.tb_dl_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_dl_info1 = new System.Windows.Forms.Label();
			this.label_dl_info2 = new System.Windows.Forms.Label();
			this.btn_dl_yes = new System.Windows.Forms.Button();
			this.btn_no = new System.Windows.Forms.Button();
			this.tb_otherInfo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_dl_No
			// 
			this.tb_dl_No.Location = new System.Drawing.Point(103, 12);
			this.tb_dl_No.Name = "tb_dl_No";
			this.tb_dl_No.Size = new System.Drawing.Size(100, 21);
			this.tb_dl_No.TabIndex = 0;
			// 
			// tb_dl_name
			// 
			this.tb_dl_name.Location = new System.Drawing.Point(103, 39);
			this.tb_dl_name.Name = "tb_dl_name";
			this.tb_dl_name.Size = new System.Drawing.Size(100, 21);
			this.tb_dl_name.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "编号";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "名称";
			// 
			// label_dl_info1
			// 
			this.label_dl_info1.AutoSize = true;
			this.label_dl_info1.Location = new System.Drawing.Point(222, 20);
			this.label_dl_info1.Name = "label_dl_info1";
			this.label_dl_info1.Size = new System.Drawing.Size(0, 12);
			this.label_dl_info1.TabIndex = 4;
			// 
			// label_dl_info2
			// 
			this.label_dl_info2.AutoSize = true;
			this.label_dl_info2.Location = new System.Drawing.Point(222, 42);
			this.label_dl_info2.Name = "label_dl_info2";
			this.label_dl_info2.Size = new System.Drawing.Size(0, 12);
			this.label_dl_info2.TabIndex = 5;
			// 
			// btn_dl_yes
			// 
			this.btn_dl_yes.Location = new System.Drawing.Point(59, 117);
			this.btn_dl_yes.Name = "btn_dl_yes";
			this.btn_dl_yes.Size = new System.Drawing.Size(75, 23);
			this.btn_dl_yes.TabIndex = 6;
			this.btn_dl_yes.Text = "确定";
			this.btn_dl_yes.UseVisualStyleBackColor = true;
			this.btn_dl_yes.Click += new System.EventHandler(this.btn_dl_yes_Click);
			// 
			// btn_no
			// 
			this.btn_no.Location = new System.Drawing.Point(168, 117);
			this.btn_no.Name = "btn_no";
			this.btn_no.Size = new System.Drawing.Size(75, 23);
			this.btn_no.TabIndex = 7;
			this.btn_no.Text = "取消";
			this.btn_no.UseVisualStyleBackColor = true;
			this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
			// 
			// tb_otherInfo
			// 
			this.tb_otherInfo.Location = new System.Drawing.Point(103, 66);
			this.tb_otherInfo.Multiline = true;
			this.tb_otherInfo.Name = "tb_otherInfo";
			this.tb_otherInfo.Size = new System.Drawing.Size(191, 44);
			this.tb_otherInfo.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "备注";
			// 
			// Dialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 147);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_otherInfo);
			this.Controls.Add(this.btn_no);
			this.Controls.Add(this.btn_dl_yes);
			this.Controls.Add(this.label_dl_info2);
			this.Controls.Add(this.label_dl_info1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_dl_name);
			this.Controls.Add(this.tb_dl_No);
			this.Name = "Dialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "请输入pcb编号与名称";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_dl_No;
		private System.Windows.Forms.TextBox tb_dl_name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_dl_info1;
		private System.Windows.Forms.Label label_dl_info2;
		private System.Windows.Forms.Button btn_dl_yes;
		private System.Windows.Forms.Button btn_no;
		private System.Windows.Forms.TextBox tb_otherInfo;
		private System.Windows.Forms.Label label3;
	}
}