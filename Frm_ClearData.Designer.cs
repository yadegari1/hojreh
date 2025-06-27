namespace FruitBox
{
	// Token: 0x02000063 RID: 99
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_ClearData : global::System.Windows.Forms.Form
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x0006B678 File Offset: 0x00069878
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

		// Token: 0x060006FB RID: 1787 RVA: 0x0006B6C8 File Offset: 0x000698C8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_hesab = new global::Janus.Windows.EditControls.UICheckBox();
			this.txt_moshtari = new global::Janus.Windows.EditControls.UICheckBox();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.txt_mande_avalie = new global::Janus.Windows.EditControls.UICheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_hesab);
			this.UiGroupBox1.Controls.Add(this.txt_mande_avalie);
			this.UiGroupBox1.Controls.Add(this.txt_moshtari);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_F0_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_F0_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_120_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(426, 383);
			arg_120_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_hesab.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_hesab.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_175_0 = this.txt_hesab;
			location = new global::System.Drawing.Point(232, 74);
			arg_175_0.Location = location;
			this.txt_hesab.Name = "txt_hesab";
			global::System.Windows.Forms.Control arg_1A2_0 = this.txt_hesab;
			size = new global::System.Drawing.Size(182, 23);
			arg_1A2_0.Size = size;
			this.txt_hesab.TabIndex = 1;
			this.txt_hesab.Text = "حذف حساب های بانکی";
			this.txt_moshtari.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_moshtari.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_1FB_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(232, 31);
			arg_1FB_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			global::System.Windows.Forms.Control arg_228_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(182, 23);
			arg_228_0.Size = size;
			this.txt_moshtari.TabIndex = 1;
			this.txt_moshtari.Text = "حذف مشتریان";
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			global::System.Windows.Forms.Control arg_273_0 = this.UiButton1;
			location = new global::System.Drawing.Point(232, 173);
			arg_273_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_2A0_0 = this.UiButton1;
			size = new global::System.Drawing.Size(182, 37);
			arg_2A0_0.Size = size;
			this.UiButton1.TabIndex = 0;
			this.UiButton1.Text = "شروع پاک سازی";
			this.txt_mande_avalie.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_mande_avalie.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_2F9_0 = this.txt_mande_avalie;
			location = new global::System.Drawing.Point(208, 122);
			arg_2F9_0.Location = location;
			this.txt_mande_avalie.Name = "txt_mande_avalie";
			global::System.Windows.Forms.Control arg_326_0 = this.txt_mande_avalie;
			size = new global::System.Drawing.Size(206, 23);
			arg_326_0.Size = size;
			this.txt_mande_avalie.TabIndex = 1;
			this.txt_mande_avalie.Text = "حذف مانده اولیه مشتریان";
			this.txt_mande_avalie.Visible = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(9f, 19f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(426, 383);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_ClearData";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "پاک سازی بانک اطلاعاتی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x040002A7 RID: 679
		private global::System.ComponentModel.IContainer components;
	}
}
