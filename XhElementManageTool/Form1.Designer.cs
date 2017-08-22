﻿namespace XhElementManageTool
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.elementSelectControl1 = new XhElementManageTool.ElementSelectControl();
			this.cb_position = new System.Windows.Forms.ComboBox();
			this.cb_facturer = new System.Windows.Forms.ComboBox();
			this.cb_type = new System.Windows.Forms.ComboBox();
			this.tb_otherInfo = new System.Windows.Forms.TextBox();
			this.tb_count = new System.Windows.Forms.TextBox();
			this.tb_price = new System.Windows.Forms.TextBox();
			this.tb_package = new System.Windows.Forms.TextBox();
			this.tb_model = new System.Windows.Forms.TextBox();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.tb_No = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_delect = new System.Windows.Forms.Button();
			this.btn_reback = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.tb_createDate = new System.Windows.Forms.TextBox();
			this.tb_modifyDate = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(494, 341);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 361);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(514, 393);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tb_modifyDate);
			this.tabPage1.Controls.Add(this.tb_createDate);
			this.tabPage1.Controls.Add(this.btn_save);
			this.tabPage1.Controls.Add(this.btn_reback);
			this.tabPage1.Controls.Add(this.btn_delect);
			this.tabPage1.Controls.Add(this.btn_add);
			this.tabPage1.Controls.Add(this.elementSelectControl1);
			this.tabPage1.Controls.Add(this.cb_position);
			this.tabPage1.Controls.Add(this.cb_facturer);
			this.tabPage1.Controls.Add(this.cb_type);
			this.tabPage1.Controls.Add(this.tb_otherInfo);
			this.tabPage1.Controls.Add(this.tb_count);
			this.tabPage1.Controls.Add(this.tb_price);
			this.tabPage1.Controls.Add(this.tb_package);
			this.tabPage1.Controls.Add(this.tb_model);
			this.tabPage1.Controls.Add(this.tb_Name);
			this.tabPage1.Controls.Add(this.tb_No);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(506, 367);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "元件库";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// elementSelectControl1
			// 
			this.elementSelectControl1.Location = new System.Drawing.Point(6, 5);
			this.elementSelectControl1.Name = "elementSelectControl1";
			this.elementSelectControl1.Size = new System.Drawing.Size(226, 329);
			this.elementSelectControl1.TabIndex = 41;
			// 
			// cb_position
			// 
			this.cb_position.FormattingEnabled = true;
			this.cb_position.Location = new System.Drawing.Point(342, 229);
			this.cb_position.Name = "cb_position";
			this.cb_position.Size = new System.Drawing.Size(154, 20);
			this.cb_position.TabIndex = 40;
			// 
			// cb_facturer
			// 
			this.cb_facturer.FormattingEnabled = true;
			this.cb_facturer.Location = new System.Drawing.Point(342, 109);
			this.cb_facturer.Name = "cb_facturer";
			this.cb_facturer.Size = new System.Drawing.Size(154, 20);
			this.cb_facturer.TabIndex = 39;
			// 
			// cb_type
			// 
			this.cb_type.FormattingEnabled = true;
			this.cb_type.Location = new System.Drawing.Point(342, 84);
			this.cb_type.Name = "cb_type";
			this.cb_type.Size = new System.Drawing.Size(154, 20);
			this.cb_type.TabIndex = 38;
			// 
			// tb_otherInfo
			// 
			this.tb_otherInfo.Location = new System.Drawing.Point(342, 252);
			this.tb_otherInfo.Name = "tb_otherInfo";
			this.tb_otherInfo.Size = new System.Drawing.Size(154, 21);
			this.tb_otherInfo.TabIndex = 36;
			// 
			// tb_count
			// 
			this.tb_count.Location = new System.Drawing.Point(342, 204);
			this.tb_count.Name = "tb_count";
			this.tb_count.Size = new System.Drawing.Size(154, 21);
			this.tb_count.TabIndex = 34;
			// 
			// tb_price
			// 
			this.tb_price.Location = new System.Drawing.Point(342, 180);
			this.tb_price.Name = "tb_price";
			this.tb_price.Size = new System.Drawing.Size(154, 21);
			this.tb_price.TabIndex = 33;
			// 
			// tb_package
			// 
			this.tb_package.Location = new System.Drawing.Point(342, 156);
			this.tb_package.Name = "tb_package";
			this.tb_package.Size = new System.Drawing.Size(154, 21);
			this.tb_package.TabIndex = 32;
			// 
			// tb_model
			// 
			this.tb_model.Location = new System.Drawing.Point(342, 132);
			this.tb_model.Name = "tb_model";
			this.tb_model.Size = new System.Drawing.Size(154, 21);
			this.tb_model.TabIndex = 31;
			// 
			// tb_Name
			// 
			this.tb_Name.Location = new System.Drawing.Point(342, 60);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(154, 21);
			this.tb_Name.TabIndex = 28;
			// 
			// tb_No
			// 
			this.tb_No.Location = new System.Drawing.Point(342, 36);
			this.tb_No.Name = "tb_No";
			this.tb_No.Size = new System.Drawing.Size(154, 21);
			this.tb_No.TabIndex = 27;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(259, 256);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 12);
			this.label15.TabIndex = 23;
			this.label15.Text = "备注";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(259, 232);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 12);
			this.label14.TabIndex = 22;
			this.label14.Text = "放置位置";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(259, 301);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(77, 12);
			this.label13.TabIndex = 21;
			this.label13.Text = "最近修改时间";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(259, 278);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 12);
			this.label12.TabIndex = 20;
			this.label12.Text = "创建时间";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(259, 208);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 19;
			this.label11.Text = "数量";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(259, 184);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 12);
			this.label10.TabIndex = 18;
			this.label10.Text = "单价";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(259, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 12);
			this.label9.TabIndex = 17;
			this.label9.Text = "封装";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(259, 136);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 16;
			this.label8.Text = "型号";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(259, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "厂商";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(259, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 14;
			this.label6.Text = "种类";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(259, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 13;
			this.label5.Text = "名称";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(259, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "编号";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(506, 367);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "元件库-列表";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(506, 367);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "PCB板";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(8, 335);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(101, 23);
			this.btn_add.TabIndex = 42;
			this.btn_add.Text = "新增";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.Btn_Click);
			// 
			// btn_delect
			// 
			this.btn_delect.Location = new System.Drawing.Point(128, 335);
			this.btn_delect.Name = "btn_delect";
			this.btn_delect.Size = new System.Drawing.Size(101, 23);
			this.btn_delect.TabIndex = 43;
			this.btn_delect.Text = "删除";
			this.btn_delect.UseVisualStyleBackColor = true;
			// 
			// btn_reback
			// 
			this.btn_reback.Location = new System.Drawing.Point(261, 335);
			this.btn_reback.Name = "btn_reback";
			this.btn_reback.Size = new System.Drawing.Size(101, 23);
			this.btn_reback.TabIndex = 44;
			this.btn_reback.Text = "重置";
			this.btn_reback.UseVisualStyleBackColor = true;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(395, 335);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(101, 23);
			this.btn_save.TabIndex = 45;
			this.btn_save.Text = "保存";
			this.btn_save.UseVisualStyleBackColor = true;
			// 
			// tb_createDate
			// 
			this.tb_createDate.Enabled = false;
			this.tb_createDate.Location = new System.Drawing.Point(342, 278);
			this.tb_createDate.Name = "tb_createDate";
			this.tb_createDate.Size = new System.Drawing.Size(154, 21);
			this.tb_createDate.TabIndex = 46;
			// 
			// tb_modifyDate
			// 
			this.tb_modifyDate.Enabled = false;
			this.tb_modifyDate.Location = new System.Drawing.Point(342, 305);
			this.tb_modifyDate.Name = "tb_modifyDate";
			this.tb_modifyDate.Size = new System.Drawing.Size(154, 21);
			this.tb_modifyDate.TabIndex = 47;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 393);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_otherInfo;
		private System.Windows.Forms.TextBox tb_count;
		private System.Windows.Forms.TextBox tb_price;
		private System.Windows.Forms.TextBox tb_package;
		private System.Windows.Forms.TextBox tb_model;
		private System.Windows.Forms.TextBox tb_Name;
		private System.Windows.Forms.TextBox tb_No;
		private System.Windows.Forms.ComboBox cb_type;
		private System.Windows.Forms.ComboBox cb_position;
		private System.Windows.Forms.ComboBox cb_facturer;
		private ElementSelectControl elementSelectControl1;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_reback;
		private System.Windows.Forms.Button btn_delect;
		private System.Windows.Forms.TextBox tb_modifyDate;
		private System.Windows.Forms.TextBox tb_createDate;
	}
}

