﻿namespace XhElementManageTool
{
	partial class PCBElementControl
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
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_weihao = new System.Windows.Forms.TextBox();
			this.tb_count = new System.Windows.Forms.TextBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_switch = new System.Windows.Forms.Button();
			this.tb_ePrice = new System.Windows.Forms.TextBox();
			this.tb_zongJia = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tb_name
			// 
			this.tb_name.Enabled = false;
			this.tb_name.Location = new System.Drawing.Point(3, 3);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(155, 21);
			this.tb_name.TabIndex = 0;
			// 
			// tb_weihao
			// 
			this.tb_weihao.Enabled = false;
			this.tb_weihao.Location = new System.Drawing.Point(162, 3);
			this.tb_weihao.Name = "tb_weihao";
			this.tb_weihao.Size = new System.Drawing.Size(33, 21);
			this.tb_weihao.TabIndex = 1;
			this.tb_weihao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_weihao_KeyPress);
			// 
			// tb_count
			// 
			this.tb_count.Enabled = false;
			this.tb_count.Location = new System.Drawing.Point(200, 3);
			this.tb_count.Name = "tb_count";
			this.tb_count.Size = new System.Drawing.Size(33, 21);
			this.tb_count.TabIndex = 2;
			this.tb_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_count_KeyPress);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(338, 2);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(23, 23);
			this.btn_delete.TabIndex = 3;
			this.btn_delete.Text = "-";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_switch
			// 
			this.btn_switch.Location = new System.Drawing.Point(312, 2);
			this.btn_switch.Name = "btn_switch";
			this.btn_switch.Size = new System.Drawing.Size(23, 23);
			this.btn_switch.TabIndex = 4;
			this.btn_switch.Text = "/";
			this.btn_switch.UseVisualStyleBackColor = true;
			this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
			// 
			// tb_ePrice
			// 
			this.tb_ePrice.Enabled = false;
			this.tb_ePrice.Location = new System.Drawing.Point(237, 3);
			this.tb_ePrice.Name = "tb_ePrice";
			this.tb_ePrice.Size = new System.Drawing.Size(34, 21);
			this.tb_ePrice.TabIndex = 5;
			// 
			// tb_zongJia
			// 
			this.tb_zongJia.Enabled = false;
			this.tb_zongJia.Location = new System.Drawing.Point(276, 3);
			this.tb_zongJia.Name = "tb_zongJia";
			this.tb_zongJia.Size = new System.Drawing.Size(33, 21);
			this.tb_zongJia.TabIndex = 6;
			// 
			// PCBElementControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tb_zongJia);
			this.Controls.Add(this.tb_ePrice);
			this.Controls.Add(this.btn_switch);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.tb_count);
			this.Controls.Add(this.tb_weihao);
			this.Controls.Add(this.tb_name);
			this.Name = "PCBElementControl";
			this.Size = new System.Drawing.Size(363, 27);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_weihao;
		private System.Windows.Forms.TextBox tb_count;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_switch;
		private System.Windows.Forms.TextBox tb_ePrice;
		private System.Windows.Forms.TextBox tb_zongJia;
	}
}
