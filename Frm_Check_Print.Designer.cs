namespace FruitBox
{
	// Token: 0x0200011B RID: 283
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Check_Print : global::System.Windows.Forms.Form
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x001F6CEC File Offset: 0x001F4EEC
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

		// Token: 0x06002999 RID: 10649 RVA: 0x001F6D3C File Offset: 0x001F4F3C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiCheckBox1 = new global::Janus.Windows.EditControls.UICheckBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiCheckBox1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.UiButton2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_124_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_124_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_154_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(447, 194);
			arg_154_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiCheckBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiCheckBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.UiCheckBox1.Checked = true;
			this.UiCheckBox1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.UiCheckBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_1E5_0 = this.UiCheckBox1;
			location = new global::System.Drawing.Point(247, 96);
			arg_1E5_0.Location = location;
			this.UiCheckBox1.Name = "UiCheckBox1";
			global::System.Windows.Forms.Control arg_212_0 = this.UiCheckBox1;
			size = new global::System.Drawing.Size(185, 23);
			arg_212_0.Size = size;
			this.UiCheckBox1.TabIndex = 29;
			this.UiCheckBox1.Text = "چاپ نام مشتری در وجه";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_29B_0 = this.Label1;
			location = new global::System.Drawing.Point(372, 34);
			arg_29B_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_2C5_0 = this.Label1;
			size = new global::System.Drawing.Size(65, 19);
			arg_2C5_0.Size = size;
			this.Label1.TabIndex = 28;
			this.Label1.Text = "در وجه :";
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_361_0 = this.EditBox1;
			location = new global::System.Drawing.Point(12, 56);
			arg_361_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3B9_0 = this.EditBox1;
			size = new global::System.Drawing.Size(423, 36);
			arg_3B9_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.check_edit;
			global::Janus.Windows.EditControls.UIButton arg_42D_0 = this.UiButton2;
			size = new global::System.Drawing.Size(32, 32);
			arg_42D_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_44C_0 = this.UiButton2;
			location = new global::System.Drawing.Point(187, 143);
			arg_44C_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_494_0 = this.UiButton2;
			size = new global::System.Drawing.Size(123, 41);
			arg_494_0.Size = size;
			this.UiButton2.TabIndex = 2;
			this.UiButton2.Text = "طراحی چاپ چک";
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.check_print;
			global::Janus.Windows.EditControls.UIButton arg_519_0 = this.UiButton1;
			size = new global::System.Drawing.Size(32, 32);
			arg_519_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_538_0 = this.UiButton1;
			location = new global::System.Drawing.Point(316, 143);
			arg_538_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_580_0 = this.UiButton1;
			size = new global::System.Drawing.Size(119, 41);
			arg_580_0.Size = size;
			this.UiButton1.TabIndex = 1;
			this.UiButton1.Text = "چاپ چک";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(447, 194);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Check_Print";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "چاپ چک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x0400103D RID: 4157
		private global::System.ComponentModel.IContainer components;
	}
}
