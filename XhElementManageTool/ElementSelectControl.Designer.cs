namespace XhElementManageTool
{
	partial class ElementSelectControl
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView_select = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_position = new System.Windows.Forms.ComboBox();
			this.l_facturer = new System.Windows.Forms.Label();
			this.cb_facturer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_type = new System.Windows.Forms.ComboBox();
			this.cb_package = new System.Windows.Forms.CheckBox();
			this.cb_model = new System.Windows.Forms.CheckBox();
			this.cb_No = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_select)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_select
			// 
			this.dataGridView_select.AllowUserToAddRows = false;
			this.dataGridView_select.AllowUserToDeleteRows = false;
			this.dataGridView_select.AllowUserToOrderColumns = true;
			this.dataGridView_select.AllowUserToResizeRows = false;
			this.dataGridView_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_select.Location = new System.Drawing.Point(3, 82);
			this.dataGridView_select.Name = "dataGridView_select";
			this.dataGridView_select.ReadOnly = true;
			this.dataGridView_select.RowHeadersVisible = false;
			this.dataGridView_select.RowTemplate.Height = 23;
			this.dataGridView_select.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_select.Size = new System.Drawing.Size(235, 243);
			this.dataGridView_select.TabIndex = 36;
			this.dataGridView_select.SelectionChanged += new System.EventHandler(this.dataGridView_select_SelectionChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 35;
			this.label2.Text = "位置";
			// 
			// cb_position
			// 
			this.cb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_position.FormattingEnabled = true;
			this.cb_position.Location = new System.Drawing.Point(114, 57);
			this.cb_position.Name = "cb_position";
			this.cb_position.Size = new System.Drawing.Size(115, 20);
			this.cb_position.TabIndex = 34;
			this.cb_position.SelectedValueChanged += new System.EventHandler(this.SelectSettingChange);
			// 
			// l_facturer
			// 
			this.l_facturer.AutoSize = true;
			this.l_facturer.Location = new System.Drawing.Point(74, 33);
			this.l_facturer.Name = "l_facturer";
			this.l_facturer.Size = new System.Drawing.Size(29, 12);
			this.l_facturer.TabIndex = 33;
			this.l_facturer.Text = "厂商";
			// 
			// cb_facturer
			// 
			this.cb_facturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_facturer.FormattingEnabled = true;
			this.cb_facturer.Location = new System.Drawing.Point(114, 30);
			this.cb_facturer.Name = "cb_facturer";
			this.cb_facturer.Size = new System.Drawing.Size(115, 20);
			this.cb_facturer.TabIndex = 32;
			this.cb_facturer.SelectedValueChanged += new System.EventHandler(this.SelectSettingChange);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 31;
			this.label1.Text = "种类";
			// 
			// cb_type
			// 
			this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_type.FormattingEnabled = true;
			this.cb_type.Location = new System.Drawing.Point(114, 3);
			this.cb_type.Name = "cb_type";
			this.cb_type.Size = new System.Drawing.Size(115, 20);
			this.cb_type.TabIndex = 30;
			this.cb_type.SelectedValueChanged += new System.EventHandler(this.SelectSettingChange);
			// 
			// cb_package
			// 
			this.cb_package.AutoSize = true;
			this.cb_package.Location = new System.Drawing.Point(13, 59);
			this.cb_package.Name = "cb_package";
			this.cb_package.Size = new System.Drawing.Size(48, 16);
			this.cb_package.TabIndex = 29;
			this.cb_package.Text = "封装";
			this.cb_package.UseVisualStyleBackColor = true;
			this.cb_package.CheckedChanged += new System.EventHandler(this.SelectSettingChange);
			// 
			// cb_model
			// 
			this.cb_model.AutoSize = true;
			this.cb_model.Location = new System.Drawing.Point(13, 32);
			this.cb_model.Name = "cb_model";
			this.cb_model.Size = new System.Drawing.Size(48, 16);
			this.cb_model.TabIndex = 28;
			this.cb_model.Text = "型号";
			this.cb_model.UseVisualStyleBackColor = true;
			this.cb_model.CheckedChanged += new System.EventHandler(this.SelectSettingChange);
			// 
			// cb_No
			// 
			this.cb_No.AutoSize = true;
			this.cb_No.Location = new System.Drawing.Point(13, 5);
			this.cb_No.Name = "cb_No";
			this.cb_No.Size = new System.Drawing.Size(48, 16);
			this.cb_No.TabIndex = 27;
			this.cb_No.Text = "编号";
			this.cb_No.UseVisualStyleBackColor = true;
			this.cb_No.CheckedChanged += new System.EventHandler(this.SelectSettingChange);
			// 
			// ElementSelectControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView_select);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cb_position);
			this.Controls.Add(this.l_facturer);
			this.Controls.Add(this.cb_facturer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_type);
			this.Controls.Add(this.cb_package);
			this.Controls.Add(this.cb_model);
			this.Controls.Add(this.cb_No);
			this.Name = "ElementSelectControl";
			this.Size = new System.Drawing.Size(242, 328);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_select)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_select;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_position;
		private System.Windows.Forms.Label l_facturer;
		private System.Windows.Forms.ComboBox cb_facturer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_type;
		private System.Windows.Forms.CheckBox cb_package;
		private System.Windows.Forms.CheckBox cb_model;
		private System.Windows.Forms.CheckBox cb_No;
	}
}
