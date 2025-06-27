namespace FruitBox
{
	// Token: 0x02000078 RID: 120
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sal_Mali : global::System.Windows.Forms.Form
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x0008079C File Offset: 0x0007E99C
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

		// Token: 0x060009C8 RID: 2504 RVA: 0x000807EC File Offset: 0x0007E9EC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiRadioButton2 = new global::Janus.Windows.EditControls.UIRadioButton();
			this.UiRadioButton1 = new global::Janus.Windows.EditControls.UIRadioButton();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Controls.Add(this.UiButton2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_109_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_109_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_139_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(868, 564);
			arg_139_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiGroupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.UiRadioButton2);
			this.UiGroupBox2.Controls.Add(this.UiRadioButton1);
			this.UiGroupBox2.Controls.Add(this.Label1);
			global::System.Windows.Forms.Control arg_1CC_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(12, 12);
			arg_1CC_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_1F9_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(844, 115);
			arg_1F9_0.Size = size;
			this.UiGroupBox2.TabIndex = 1;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiRadioButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiRadioButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.UiRadioButton2.Checked = true;
			global::System.Windows.Forms.Control arg_25B_0 = this.UiRadioButton2;
			location = new global::System.Drawing.Point(640, 63);
			arg_25B_0.Location = location;
			this.UiRadioButton2.Name = "UiRadioButton2";
			global::System.Windows.Forms.Control arg_288_0 = this.UiRadioButton2;
			size = new global::System.Drawing.Size(182, 34);
			arg_288_0.Size = size;
			this.UiRadioButton2.TabIndex = 1;
			this.UiRadioButton2.TabStop = true;
			this.UiRadioButton2.Text = "شروع از شماره یک";
			this.UiRadioButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiRadioButton1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_2EE_0 = this.UiRadioButton1;
			location = new global::System.Drawing.Point(402, 63);
			arg_2EE_0.Location = location;
			this.UiRadioButton1.Name = "UiRadioButton1";
			global::System.Windows.Forms.Control arg_31B_0 = this.UiRadioButton1;
			size = new global::System.Drawing.Size(222, 34);
			arg_31B_0.Size = size;
			this.UiRadioButton1.TabIndex = 1;
			this.UiRadioButton1.Text = "ادامه شماره گذاری از سال قبل";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_381_0 = this.Label1;
			location = new global::System.Drawing.Point(583, 23);
			arg_381_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_3AE_0 = this.Label1;
			size = new global::System.Drawing.Size(255, 28);
			arg_3AE_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "نحوه شماره گذاری اسناد در سال جدید";
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_41B_0 = this.UiButton2;
			location = new global::System.Drawing.Point(713, 217);
			arg_41B_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			global::System.Windows.Forms.Control arg_448_0 = this.UiButton2;
			size = new global::System.Drawing.Size(143, 31);
			arg_448_0.Size = size;
			this.UiButton2.TabIndex = 0;
			this.UiButton2.Text = "انتقال";
			this.UiButton2.Visible = false;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.database_add1;
			global::Janus.Windows.EditControls.UIButton arg_4CD_0 = this.UiButton1;
			size = new global::System.Drawing.Size(32, 32);
			arg_4CD_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_4EC_0 = this.UiButton1;
			location = new global::System.Drawing.Point(593, 149);
			arg_4EC_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_519_0 = this.UiButton1;
			size = new global::System.Drawing.Size(263, 62);
			arg_519_0.Size = size;
			this.UiButton1.TabIndex = 0;
			this.UiButton1.Text = "ایجاد سال مالی";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(10f, 28f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(868, 564);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sal_Mali";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ایجاد سال مالی جدید";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040003E0 RID: 992
		private global::System.ComponentModel.IContainer components;
	}
}
