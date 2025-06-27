namespace FruitBox
{
	// Token: 0x02000070 RID: 112
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_MessageBox : global::System.Windows.Forms.Form
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00078A10 File Offset: 0x00076C10
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00078A60 File Offset: 0x00076C60
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.pic_warning = new global::System.Windows.Forms.PictureBox();
			this.pic_error = new global::System.Windows.Forms.PictureBox();
			this.pic_question = new global::System.Windows.Forms.PictureBox();
			this.pic_info = new global::System.Windows.Forms.PictureBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.btn_no = new global::Janus.Windows.EditControls.UIButton();
			this.btn_yes = new global::Janus.Windows.EditControls.UIButton();
			this.btn_cancel = new global::Janus.Windows.EditControls.UIButton();
			this.btn_ok = new global::Janus.Windows.EditControls.UIButton();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic_warning).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pic_error).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pic_question).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pic_info).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.pic_warning);
			this.UiGroupBox1.Controls.Add(this.pic_error);
			this.UiGroupBox1.Controls.Add(this.pic_question);
			this.UiGroupBox1.Controls.Add(this.pic_info);
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1C6_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1C6_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1F6_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(443, 167);
			arg_1F6_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_25C_0 = this.Label1;
			location = new global::System.Drawing.Point(66, 9);
			arg_25C_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_289_0 = this.Label1;
			size = new global::System.Drawing.Size(365, 79);
			arg_289_0.Size = size;
			this.Label1.TabIndex = 7;
			this.Label1.Text = "آیا مایل به حذف اطلاعات میباشید؟";
			this.pic_warning.BackColor = global::System.Drawing.Color.Transparent;
			this.pic_warning.Image = global::FruitBox.My.Resources.Resources.onebit_36;
			global::System.Windows.Forms.Control arg_2E2_0 = this.pic_warning;
			location = new global::System.Drawing.Point(12, 9);
			arg_2E2_0.Location = location;
			this.pic_warning.Name = "pic_warning";
			global::System.Windows.Forms.Control arg_30C_0 = this.pic_warning;
			size = new global::System.Drawing.Size(48, 48);
			arg_30C_0.Size = size;
			this.pic_warning.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pic_warning.TabIndex = 5;
			this.pic_warning.TabStop = false;
			this.pic_warning.Visible = false;
			this.pic_error.BackColor = global::System.Drawing.Color.Transparent;
			this.pic_error.Image = global::FruitBox.My.Resources.Resources.onebit_35;
			global::System.Windows.Forms.Control arg_37B_0 = this.pic_error;
			location = new global::System.Drawing.Point(12, 9);
			arg_37B_0.Location = location;
			this.pic_error.Name = "pic_error";
			global::System.Windows.Forms.Control arg_3A5_0 = this.pic_error;
			size = new global::System.Drawing.Size(48, 48);
			arg_3A5_0.Size = size;
			this.pic_error.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pic_error.TabIndex = 6;
			this.pic_error.TabStop = false;
			this.pic_error.Visible = false;
			this.pic_question.BackColor = global::System.Drawing.Color.Transparent;
			this.pic_question.Image = global::FruitBox.My.Resources.Resources.onebit_37;
			global::System.Windows.Forms.Control arg_414_0 = this.pic_question;
			location = new global::System.Drawing.Point(12, 9);
			arg_414_0.Location = location;
			this.pic_question.Name = "pic_question";
			global::System.Windows.Forms.Control arg_43E_0 = this.pic_question;
			size = new global::System.Drawing.Size(48, 48);
			arg_43E_0.Size = size;
			this.pic_question.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pic_question.TabIndex = 3;
			this.pic_question.TabStop = false;
			this.pic_question.Visible = false;
			this.pic_info.BackColor = global::System.Drawing.Color.Transparent;
			this.pic_info.Image = global::FruitBox.My.Resources.Resources.onebit_38;
			global::System.Windows.Forms.Control arg_4AD_0 = this.pic_info;
			location = new global::System.Drawing.Point(12, 9);
			arg_4AD_0.Location = location;
			this.pic_info.Name = "pic_info";
			global::System.Windows.Forms.Control arg_4D7_0 = this.pic_info;
			size = new global::System.Drawing.Size(48, 48);
			arg_4D7_0.Size = size;
			this.pic_info.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pic_info.TabIndex = 4;
			this.pic_info.TabStop = false;
			this.pic_info.Visible = false;
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.UiButton1);
			this.UiGroupBox2.Controls.Add(this.UiButton2);
			this.UiGroupBox2.Controls.Add(this.btn_no);
			this.UiGroupBox2.Controls.Add(this.btn_yes);
			this.UiGroupBox2.Controls.Add(this.btn_cancel);
			this.UiGroupBox2.Controls.Add(this.btn_ok);
			this.UiGroupBox2.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.Top;
			global::System.Windows.Forms.Control arg_5C7_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(0, 114);
			arg_5C7_0.Location = location;
			global::System.Windows.Forms.Control arg_5DE_0 = this.UiGroupBox2;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(0);
			arg_5DE_0.Margin = margin;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_60B_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(456, 53);
			arg_60B_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.delete;
			global::System.Windows.Forms.Control arg_65B_0 = this.UiButton1;
			location = new global::System.Drawing.Point(3, 22);
			arg_65B_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_692_0 = this.UiButton1;
			size = new global::System.Drawing.Size(106, 23);
			arg_692_0.Size = size;
			this.UiButton1.TabIndex = 3;
			this.UiButton1.Text = "مشاهده خطا";
			this.UiButton1.Visible = false;
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.UiButton2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_715_0 = this.UiButton2;
			location = new global::System.Drawing.Point(159, 13);
			arg_715_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			this.UiButton2.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_76A_0 = this.UiButton2;
			size = new global::System.Drawing.Size(119, 36);
			arg_76A_0.Size = size;
			this.UiButton2.TabIndex = 2;
			this.UiButton2.Text = "ماندن در سند فعلی";
			this.UiButton2.Visible = false;
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.btn_no.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btn_no.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_7ED_0 = this.btn_no;
			location = new global::System.Drawing.Point(284, 13);
			arg_7ED_0.Location = location;
			this.btn_no.Name = "btn_no";
			this.btn_no.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.btn_no.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			this.btn_no.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_842_0 = this.btn_no;
			size = new global::System.Drawing.Size(75, 36);
			arg_842_0.Size = size;
			this.btn_no.TabIndex = 1;
			this.btn_no.Text = "خیر";
			this.btn_no.Visible = false;
			this.btn_no.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.btn_yes.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btn_yes.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_8C5_0 = this.btn_yes;
			location = new global::System.Drawing.Point(365, 13);
			arg_8C5_0.Location = location;
			this.btn_yes.Name = "btn_yes";
			this.btn_yes.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.btn_yes.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			this.btn_yes.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_91A_0 = this.btn_yes;
			size = new global::System.Drawing.Size(75, 36);
			arg_91A_0.Size = size;
			this.btn_yes.TabIndex = 0;
			this.btn_yes.Text = "بلی";
			this.btn_yes.Visible = false;
			this.btn_yes.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.btn_cancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btn_cancel.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_99D_0 = this.btn_cancel;
			location = new global::System.Drawing.Point(284, 22);
			arg_99D_0.Location = location;
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.btn_cancel.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			this.btn_cancel.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_9F2_0 = this.btn_cancel;
			size = new global::System.Drawing.Size(75, 23);
			arg_9F2_0.Size = size;
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "انصراف";
			this.btn_cancel.Visible = false;
			this.btn_cancel.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.btn_ok.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btn_ok.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A75_0 = this.btn_ok;
			location = new global::System.Drawing.Point(365, 13);
			arg_A75_0.Location = location;
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.btn_ok.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			this.btn_ok.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_ACA_0 = this.btn_ok;
			size = new global::System.Drawing.Size(75, 36);
			arg_ACA_0.Size = size;
			this.btn_ok.TabIndex = 2;
			this.btn_ok.Text = "تائید";
			this.btn_ok.Visible = false;
			this.btn_ok.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(443, 167);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_MessageBox";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic_warning).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pic_error).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pic_question).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pic_info).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x04000362 RID: 866
		private global::System.ComponentModel.IContainer components;
	}
}
