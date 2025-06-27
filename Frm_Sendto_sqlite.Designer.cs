namespace FruitBox
{
	// Token: 0x0200010F RID: 271
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sendto_sqlite : global::System.Windows.Forms.Form
	{
		// Token: 0x06002707 RID: 9991 RVA: 0x001D8F68 File Offset: 0x001D7168
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

		// Token: 0x06002708 RID: 9992 RVA: 0x001D8FB8 File Offset: 0x001D71B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sendto_sqlite));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.PanelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.PanelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.PictureBox1);
			this.UiGroupBox1.Controls.Add(this.PanelEx2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_119_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_119_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_14A_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(892, 642);
			arg_14A_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.PanelEx2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PanelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.PanelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.PanelEx2.Controls.Add(this.PictureBox2);
			this.PanelEx2.Controls.Add(this.Label1);
			this.PanelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			global::System.Windows.Forms.Control arg_1EE_0 = this.PanelEx2;
			location = new global::System.Drawing.Point(252, 164);
			arg_1EE_0.Location = location;
			this.PanelEx2.Name = "PanelEx2";
			global::System.Windows.Forms.Control arg_21F_0 = this.PanelEx2;
			size = new global::System.Drawing.Size(342, 146);
			arg_21F_0.Size = size;
			this.PanelEx2.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.PanelEx2.Style.BackColor1.Color = global::System.Drawing.Color.White;
			this.PanelEx2.Style.BackColor2.Color = global::System.Drawing.Color.White;
			this.PanelEx2.Style.Border = global::DevComponents.DotNetBar.eBorderType.DoubleLine;
			this.PanelEx2.Style.BorderColor.Color = global::System.Drawing.Color.FromArgb(132, 157, 189);
			this.PanelEx2.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.PanelEx2.Style.GradientAngle = 90;
			this.PanelEx2.TabIndex = 2;
			this.PanelEx2.Text = "PanelEx2";
			this.PanelEx2.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_344_0 = this.Label1;
			location = new global::System.Drawing.Point(144, 35);
			arg_344_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_372_0 = this.Label1;
			size = new global::System.Drawing.Size(175, 18);
			arg_372_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "در حال ذخیره اطلاعات...";
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_3DF_0 = this.UiButton1;
			location = new global::System.Drawing.Point(712, 286);
			arg_3DF_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_40A_0 = this.UiButton1;
			size = new global::System.Drawing.Size(106, 42);
			arg_40A_0.Size = size;
			this.UiButton1.TabIndex = 0;
			this.UiButton1.Text = "ذخیره";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.PictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control arg_48C_0 = this.PictureBox1;
			location = new global::System.Drawing.Point(624, 12);
			arg_48C_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control arg_4BD_0 = this.PictureBox1;
			size = new global::System.Drawing.Size(256, 256);
			arg_4BD_0.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 3;
			this.PictureBox1.TabStop = false;
			this.PictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox2.Image");
			global::System.Windows.Forms.Control arg_519_0 = this.PictureBox2;
			location = new global::System.Drawing.Point(26, 19);
			arg_519_0.Location = location;
			this.PictureBox2.Name = "PictureBox2";
			global::System.Windows.Forms.Control arg_544_0 = this.PictureBox2;
			size = new global::System.Drawing.Size(64, 64);
			arg_544_0.Size = size;
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex = 1;
			this.PictureBox2.TabStop = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(892, 642);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sendto_sqlite";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ارسال اطلاعات به گوشی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.PanelEx2.ResumeLayout(false);
			this.PanelEx2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F3E RID: 3902
		private global::System.ComponentModel.IContainer components;
	}
}
