﻿﻿namespace XhElementManageTool
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
			this.btn_element_output = new System.Windows.Forms.Button();
			this.btn_element_input = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.f_cb_type = new System.Windows.Forms.ComboBox();
			this.tb_modifyDate = new System.Windows.Forms.TextBox();
			this.tb_No = new System.Windows.Forms.TextBox();
			this.tb_createDate = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.f_cb_position = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.f_cb_facturer = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tb_otherInfo = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tb_count = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tb_price = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.tb_package = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tb_model = new System.Windows.Forms.TextBox();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tb_pcb_info = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_pcbAddElement = new System.Windows.Forms.Button();
			this.p_pcbEle = new System.Windows.Forms.Panel();
			this.btn_pcb_output = new System.Windows.Forms.Button();
			this.btn_pcb_input = new System.Windows.Forms.Button();
			this.btn_pcb_delete = new System.Windows.Forms.Button();
			this.btn_pcb_add = new System.Windows.Forms.Button();
			this.lb_pcb = new System.Windows.Forms.ListBox();
			this.label22 = new System.Windows.Forms.Label();
			this.l_zongCount = new System.Windows.Forms.Label();
			this.l_zongJiaGe = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
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
			this.dataGridView1.Size = new System.Drawing.Size(494, 362);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 382);
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
			this.tabControl1.Size = new System.Drawing.Size(514, 414);
			this.tabControl1.TabIndex = 2;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.elementSelectControl1);
			this.tabPage1.Controls.Add(this.btn_element_output);
			this.tabPage1.Controls.Add(this.btn_element_input);
			this.tabPage1.Controls.Add(this.btn_save);
			this.tabPage1.Controls.Add(this.btn_delete);
			this.tabPage1.Controls.Add(this.btn_add);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(506, 388);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "元件库";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// elementSelectControl1
			// 
			this.elementSelectControl1.Location = new System.Drawing.Point(6, 6);
			this.elementSelectControl1.Name = "elementSelectControl1";
			this.elementSelectControl1.Size = new System.Drawing.Size(236, 323);
			this.elementSelectControl1.TabIndex = 51;
			// 
			// btn_element_output
			// 
			this.btn_element_output.Location = new System.Drawing.Point(133, 361);
			this.btn_element_output.Name = "btn_element_output";
			this.btn_element_output.Size = new System.Drawing.Size(110, 23);
			this.btn_element_output.TabIndex = 50;
			this.btn_element_output.Text = "导出";
			this.btn_element_output.UseVisualStyleBackColor = true;
			// 
			// btn_element_input
			// 
			this.btn_element_input.Location = new System.Drawing.Point(8, 361);
			this.btn_element_input.Name = "btn_element_input";
			this.btn_element_input.Size = new System.Drawing.Size(110, 23);
			this.btn_element_input.TabIndex = 49;
			this.btn_element_input.Text = "导入";
			this.btn_element_input.UseVisualStyleBackColor = true;
			this.btn_element_input.Click += new System.EventHandler(this.btn_element_input_Click);
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(253, 361);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(247, 23);
			this.btn_save.TabIndex = 45;
			this.btn_save.Text = "保存";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.Btn_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(133, 335);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(110, 23);
			this.btn_delete.TabIndex = 43;
			this.btn_delete.Text = "删除";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.Btn_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(8, 335);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(110, 23);
			this.btn_add.TabIndex = 42;
			this.btn_add.Text = "新增";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.Btn_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.f_cb_type);
			this.panel2.Controls.Add(this.tb_modifyDate);
			this.panel2.Controls.Add(this.tb_No);
			this.panel2.Controls.Add(this.tb_createDate);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.f_cb_position);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.f_cb_facturer);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.tb_otherInfo);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.tb_count);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.tb_price);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.tb_package);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.tb_model);
			this.panel2.Controls.Add(this.tb_Name);
			this.panel2.Location = new System.Drawing.Point(253, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(247, 350);
			this.panel2.TabIndex = 48;
			// 
			// f_cb_type
			// 
			this.f_cb_type.FormattingEnabled = true;
			this.f_cb_type.Location = new System.Drawing.Point(87, 61);
			this.f_cb_type.Name = "f_cb_type";
			this.f_cb_type.Size = new System.Drawing.Size(154, 20);
			this.f_cb_type.TabIndex = 48;
			// 
			// tb_modifyDate
			// 
			this.tb_modifyDate.Enabled = false;
			this.tb_modifyDate.Location = new System.Drawing.Point(87, 321);
			this.tb_modifyDate.Name = "tb_modifyDate";
			this.tb_modifyDate.Size = new System.Drawing.Size(154, 21);
			this.tb_modifyDate.TabIndex = 47;
			// 
			// tb_No
			// 
			this.tb_No.Location = new System.Drawing.Point(87, 5);
			this.tb_No.Name = "tb_No";
			this.tb_No.Size = new System.Drawing.Size(154, 21);
			this.tb_No.TabIndex = 27;
			// 
			// tb_createDate
			// 
			this.tb_createDate.Enabled = false;
			this.tb_createDate.Location = new System.Drawing.Point(87, 292);
			this.tb_createDate.Name = "tb_createDate";
			this.tb_createDate.Size = new System.Drawing.Size(154, 21);
			this.tb_createDate.TabIndex = 46;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "编号";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 13;
			this.label5.Text = "名称";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 14;
			this.label6.Text = "种类";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "厂商";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 125);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 16;
			this.label8.Text = "型号";
			// 
			// f_cb_position
			// 
			this.f_cb_position.FormattingEnabled = true;
			this.f_cb_position.Location = new System.Drawing.Point(87, 235);
			this.f_cb_position.Name = "f_cb_position";
			this.f_cb_position.Size = new System.Drawing.Size(154, 20);
			this.f_cb_position.TabIndex = 40;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 154);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 12);
			this.label9.TabIndex = 17;
			this.label9.Text = "封装";
			// 
			// f_cb_facturer
			// 
			this.f_cb_facturer.FormattingEnabled = true;
			this.f_cb_facturer.Location = new System.Drawing.Point(87, 91);
			this.f_cb_facturer.Name = "f_cb_facturer";
			this.f_cb_facturer.Size = new System.Drawing.Size(154, 20);
			this.f_cb_facturer.TabIndex = 55;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 183);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 12);
			this.label10.TabIndex = 18;
			this.label10.Text = "单价";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 212);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 19;
			this.label11.Text = "数量";
			// 
			// tb_otherInfo
			// 
			this.tb_otherInfo.Location = new System.Drawing.Point(87, 263);
			this.tb_otherInfo.Name = "tb_otherInfo";
			this.tb_otherInfo.Size = new System.Drawing.Size(154, 21);
			this.tb_otherInfo.TabIndex = 36;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 299);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 12);
			this.label12.TabIndex = 20;
			this.label12.Text = "创建时间";
			// 
			// tb_count
			// 
			this.tb_count.Location = new System.Drawing.Point(87, 206);
			this.tb_count.Name = "tb_count";
			this.tb_count.Size = new System.Drawing.Size(154, 21);
			this.tb_count.TabIndex = 34;
			this.tb_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_count_KeyPress);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 328);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(77, 12);
			this.label13.TabIndex = 21;
			this.label13.Text = "最近修改时间";
			// 
			// tb_price
			// 
			this.tb_price.Location = new System.Drawing.Point(87, 177);
			this.tb_price.MaxLength = 10;
			this.tb_price.Name = "tb_price";
			this.tb_price.Size = new System.Drawing.Size(154, 21);
			this.tb_price.TabIndex = 33;
			this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 241);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 12);
			this.label14.TabIndex = 22;
			this.label14.Text = "放置位置";
			// 
			// tb_package
			// 
			this.tb_package.Location = new System.Drawing.Point(87, 148);
			this.tb_package.Name = "tb_package";
			this.tb_package.Size = new System.Drawing.Size(154, 21);
			this.tb_package.TabIndex = 32;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 270);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 12);
			this.label15.TabIndex = 23;
			this.label15.Text = "备注";
			// 
			// tb_model
			// 
			this.tb_model.Location = new System.Drawing.Point(87, 119);
			this.tb_model.Name = "tb_model";
			this.tb_model.Size = new System.Drawing.Size(154, 21);
			this.tb_model.TabIndex = 31;
			// 
			// tb_Name
			// 
			this.tb_Name.Location = new System.Drawing.Point(87, 34);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(154, 21);
			this.tb_Name.TabIndex = 28;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(506, 388);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "元件库-列表";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.l_zongJiaGe);
			this.tabPage3.Controls.Add(this.l_zongCount);
			this.tabPage3.Controls.Add(this.label22);
			this.tabPage3.Controls.Add(this.label21);
			this.tabPage3.Controls.Add(this.label20);
			this.tabPage3.Controls.Add(this.label19);
			this.tabPage3.Controls.Add(this.tb_pcb_info);
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Controls.Add(this.btn_pcbAddElement);
			this.tabPage3.Controls.Add(this.p_pcbEle);
			this.tabPage3.Controls.Add(this.btn_pcb_output);
			this.tabPage3.Controls.Add(this.btn_pcb_input);
			this.tabPage3.Controls.Add(this.btn_pcb_delete);
			this.tabPage3.Controls.Add(this.btn_pcb_add);
			this.tabPage3.Controls.Add(this.lb_pcb);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(506, 388);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "PCB板";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(390, 10);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(29, 12);
			this.label21.TabIndex = 18;
			this.label21.Text = "总价";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(354, 10);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(29, 12);
			this.label20.TabIndex = 17;
			this.label20.Text = "单价";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(110, 336);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(35, 12);
			this.label19.TabIndex = 16;
			this.label19.Text = "备注:";
			// 
			// tb_pcb_info
			// 
			this.tb_pcb_info.Enabled = false;
			this.tb_pcb_info.Location = new System.Drawing.Point(151, 331);
			this.tb_pcb_info.Multiline = true;
			this.tb_pcb_info.Name = "tb_pcb_info";
			this.tb_pcb_info.Size = new System.Drawing.Size(347, 25);
			this.tb_pcb_info.TabIndex = 15;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 10);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(47, 12);
			this.label18.TabIndex = 14;
			this.label18.Text = "PCB名称";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(454, 10);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(17, 12);
			this.label17.TabIndex = 13;
			this.label17.Text = "删";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(428, 10);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(17, 12);
			this.label16.TabIndex = 12;
			this.label16.Text = "改";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(316, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 11;
			this.label3.Text = "数量";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(277, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "位号";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "元件名称";
			// 
			// btn_pcbAddElement
			// 
			this.btn_pcbAddElement.Location = new System.Drawing.Point(112, 360);
			this.btn_pcbAddElement.Name = "btn_pcbAddElement";
			this.btn_pcbAddElement.Size = new System.Drawing.Size(386, 23);
			this.btn_pcbAddElement.TabIndex = 8;
			this.btn_pcbAddElement.Text = "添加元件";
			this.btn_pcbAddElement.UseVisualStyleBackColor = true;
			this.btn_pcbAddElement.Click += new System.EventHandler(this.btn_pcbAddElement_Click);
			// 
			// p_pcbEle
			// 
			this.p_pcbEle.AutoScroll = true;
			this.p_pcbEle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p_pcbEle.Location = new System.Drawing.Point(112, 25);
			this.p_pcbEle.Name = "p_pcbEle";
			this.p_pcbEle.Size = new System.Drawing.Size(386, 271);
			this.p_pcbEle.TabIndex = 7;
			// 
			// btn_pcb_output
			// 
			this.btn_pcb_output.Location = new System.Drawing.Point(8, 331);
			this.btn_pcb_output.Name = "btn_pcb_output";
			this.btn_pcb_output.Size = new System.Drawing.Size(98, 23);
			this.btn_pcb_output.TabIndex = 5;
			this.btn_pcb_output.Text = "导出";
			this.btn_pcb_output.UseVisualStyleBackColor = true;
			// 
			// btn_pcb_input
			// 
			this.btn_pcb_input.Location = new System.Drawing.Point(8, 360);
			this.btn_pcb_input.Name = "btn_pcb_input";
			this.btn_pcb_input.Size = new System.Drawing.Size(98, 23);
			this.btn_pcb_input.TabIndex = 4;
			this.btn_pcb_input.Text = "导入";
			this.btn_pcb_input.UseVisualStyleBackColor = true;
			// 
			// btn_pcb_delete
			// 
			this.btn_pcb_delete.Location = new System.Drawing.Point(8, 302);
			this.btn_pcb_delete.Name = "btn_pcb_delete";
			this.btn_pcb_delete.Size = new System.Drawing.Size(98, 23);
			this.btn_pcb_delete.TabIndex = 3;
			this.btn_pcb_delete.Text = "删除";
			this.btn_pcb_delete.UseVisualStyleBackColor = true;
			this.btn_pcb_delete.Click += new System.EventHandler(this.btn_pcb_delete_Click);
			// 
			// btn_pcb_add
			// 
			this.btn_pcb_add.Location = new System.Drawing.Point(8, 273);
			this.btn_pcb_add.Name = "btn_pcb_add";
			this.btn_pcb_add.Size = new System.Drawing.Size(98, 23);
			this.btn_pcb_add.TabIndex = 2;
			this.btn_pcb_add.Text = "新增";
			this.btn_pcb_add.UseVisualStyleBackColor = true;
			this.btn_pcb_add.Click += new System.EventHandler(this.btn_pcb_add_Click);
			// 
			// lb_pcb
			// 
			this.lb_pcb.FormattingEnabled = true;
			this.lb_pcb.ItemHeight = 12;
			this.lb_pcb.Location = new System.Drawing.Point(8, 25);
			this.lb_pcb.Name = "lb_pcb";
			this.lb_pcb.Size = new System.Drawing.Size(98, 244);
			this.lb_pcb.TabIndex = 0;
			this.lb_pcb.SelectedValueChanged += new System.EventHandler(this.lb_pcb_SelectedValueChanged);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(110, 307);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(29, 12);
			this.label22.TabIndex = 19;
			this.label22.Text = "统计";
			// 
			// l_zongCount
			// 
			this.l_zongCount.AutoSize = true;
			this.l_zongCount.Location = new System.Drawing.Point(316, 307);
			this.l_zongCount.Name = "l_zongCount";
			this.l_zongCount.Size = new System.Drawing.Size(0, 12);
			this.l_zongCount.TabIndex = 20;
			// 
			// l_zongJiaGe
			// 
			this.l_zongJiaGe.AutoSize = true;
			this.l_zongJiaGe.Location = new System.Drawing.Point(390, 307);
			this.l_zongJiaGe.Name = "l_zongJiaGe";
			this.l_zongJiaGe.Size = new System.Drawing.Size(0, 12);
			this.l_zongJiaGe.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 414);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "元件管理工具";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
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
		private System.Windows.Forms.ComboBox f_cb_position;
		private System.Windows.Forms.ComboBox f_cb_facturer;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.TextBox tb_modifyDate;
		private System.Windows.Forms.TextBox tb_createDate;
		private System.Windows.Forms.ListBox lb_pcb;
		private System.Windows.Forms.Button btn_pcb_output;
		private System.Windows.Forms.Button btn_pcb_input;
		private System.Windows.Forms.Button btn_pcb_delete;
		private System.Windows.Forms.Button btn_pcb_add;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel p_pcbEle;
		private System.Windows.Forms.Button btn_pcbAddElement;
		private System.Windows.Forms.Button btn_element_input;
		private System.Windows.Forms.Button btn_element_output;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ElementSelectControl elementSelectControl1;
		private System.Windows.Forms.ComboBox f_cb_type;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tb_pcb_info;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label l_zongJiaGe;
		private System.Windows.Forms.Label l_zongCount;
		private System.Windows.Forms.Label label22;
	}
}

