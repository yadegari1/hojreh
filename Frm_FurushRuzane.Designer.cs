namespace FruitBox
{
	// Token: 0x020000F6 RID: 246
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_FurushRuzane : global::System.Windows.Forms.Form
	{
		// Token: 0x06001D0B RID: 7435 RVA: 0x001570D0 File Offset: 0x001552D0
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

		// Token: 0x06001D0C RID: 7436 RVA: 0x00157120 File Offset: 0x00155320
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
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
			global::System.Windows.Forms.Control arg_11A_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_11A_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_14A_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(440, 242);
			arg_14A_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.txt_mablagh);
			this.UiGroupBox2.Controls.Add(this.Label3);
			this.UiGroupBox2.Controls.Add(this.Label6);
			this.UiGroupBox2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_1EF_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(6, 3);
			arg_1EF_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_21F_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(425, 198);
			arg_21F_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_mablagh.AcceptEnter = true;
			this.txt_mablagh.AllowEdit = true;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.AllowZero = true;
			this.txt_mablagh.FocusColor = true;
			this.txt_mablagh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_2B5_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(12, 16);
			arg_2B5_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_30D_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(276, 36);
			arg_30D_0.Size = size;
			this.txt_mablagh.TabIndex = 0;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_37C_0 = this.Label3;
			location = new global::System.Drawing.Point(290, 26);
			arg_37C_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_3A6_0 = this.Label3;
			size = new global::System.Drawing.Size(125, 19);
			arg_3A6_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "جمع فروش روزانه";
			this.Label6.BackColor = global::System.Drawing.Color.Transparent;
			this.Label6.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			global::System.Windows.Forms.Control arg_3FB_0 = this.Label6;
			location = new global::System.Drawing.Point(12, 66);
			arg_3FB_0.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control arg_428_0 = this.Label6;
			size = new global::System.Drawing.Size(384, 57);
			arg_428_0.Size = size;
			this.Label6.TabIndex = 2;
			this.Label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.UiButton2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.delete;
			global::System.Windows.Forms.Control arg_491_0 = this.UiButton2;
			location = new global::System.Drawing.Point(6, 207);
			arg_491_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_4D9_0 = this.UiButton2;
			size = new global::System.Drawing.Size(93, 32);
			arg_4D9_0.Size = size;
			this.UiButton2.TabIndex = 2;
			this.UiButton2.Text = "انصراف";
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.accept;
			global::System.Windows.Forms.Control arg_553_0 = this.UiButton1;
			location = new global::System.Drawing.Point(105, 207);
			arg_553_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_59E_0 = this.UiButton1;
			size = new global::System.Drawing.Size(153, 32);
			arg_59E_0.Size = size;
			this.UiButton1.TabIndex = 1;
			this.UiButton1.Text = "تایید";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(440, 242);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_FurushRuzane";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "فروش روزانه";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x04000B4A RID: 2890
		private global::System.ComponentModel.IContainer components;
	}
}
