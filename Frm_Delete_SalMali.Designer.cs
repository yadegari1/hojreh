namespace FruitBox
{
	// Token: 0x02000067 RID: 103
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Delete_SalMali : global::System.Windows.Forms.Form
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x0006ED88 File Offset: 0x0006CF88
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

		// Token: 0x06000771 RID: 1905 RVA: 0x0006EDD8 File Offset: 0x0006CFD8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiCheckBox1 = new global::Janus.Windows.EditControls.UICheckBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label3 = new global::System.Windows.Forms.Label();
			this.EditBox2 = new global::FruitBox.EditBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_121_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_121_0.Location = location;
			global::System.Windows.Forms.Control arg_13A_0 = this.UiGroupBox1;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			arg_13A_0.Margin = margin;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_16B_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1248, 564);
			arg_16B_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.database_delete1;
			global::Janus.Windows.EditControls.UIButton arg_1BE_0 = this.UiButton1;
			size = new global::System.Drawing.Size(32, 32);
			arg_1BE_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_1DD_0 = this.UiButton1;
			location = new global::System.Drawing.Point(973, 179);
			arg_1DD_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_20B_0 = this.UiButton1;
			size = new global::System.Drawing.Size(263, 62);
			arg_20B_0.Size = size;
			this.UiButton1.TabIndex = 1;
			this.UiButton1.Text = "حذف سال مالی";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiGroupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.EditBox2);
			this.UiGroupBox2.Controls.Add(this.EditBox1);
			this.UiGroupBox2.Controls.Add(this.Label3);
			this.UiGroupBox2.Controls.Add(this.UiCheckBox1);
			this.UiGroupBox2.Controls.Add(this.Label2);
			this.UiGroupBox2.Controls.Add(this.Label1);
			global::System.Windows.Forms.Control arg_2F4_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(12, 12);
			arg_2F4_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_325_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(1224, 151);
			arg_325_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiCheckBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiCheckBox1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_37A_0 = this.UiCheckBox1;
			location = new global::System.Drawing.Point(973, 102);
			arg_37A_0.Location = location;
			this.UiCheckBox1.Name = "UiCheckBox1";
			global::System.Windows.Forms.Control arg_3A8_0 = this.UiCheckBox1;
			size = new global::System.Drawing.Size(231, 31);
			arg_3A8_0.Size = size;
			this.UiCheckBox1.TabIndex = 1;
			this.UiCheckBox1.Text = "شرایط فوق را قبول می کنم";
			this.UiCheckBox1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_41B_0 = this.Label1;
			location = new global::System.Drawing.Point(748, 25);
			arg_41B_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_449_0 = this.Label1;
			size = new global::System.Drawing.Size(461, 28);
			arg_449_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "با حذف سال مالی همه اطلاعات ثبت شده در سال مالی حذف خواهد شد";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_4AF_0 = this.Label2;
			location = new global::System.Drawing.Point(1132, 68);
			arg_4AF_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_4DA_0 = this.Label2;
			size = new global::System.Drawing.Size(73, 28);
			arg_4DA_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "سال مالی";
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = false;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			global::System.Windows.Forms.Control arg_556_0 = this.EditBox1;
			location = new global::System.Drawing.Point(973, 63);
			arg_556_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_5AF_0 = this.EditBox1;
			size = new global::System.Drawing.Size(157, 36);
			arg_5AF_0.Size = size;
			this.EditBox1.TabIndex = 2;
			this.EditBox1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_61E_0 = this.Label3;
			location = new global::System.Drawing.Point(875, 68);
			arg_61E_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_649_0 = this.Label3;
			size = new global::System.Drawing.Size(83, 28);
			arg_649_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "تاریخ ایجاد";
			this.EditBox2.AcceptEnter = true;
			this.EditBox2.AllowEdit = false;
			this.EditBox2.AllowNew = true;
			this.EditBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox2.FocusColor = true;
			global::System.Windows.Forms.Control arg_6C5_0 = this.EditBox2;
			location = new global::System.Drawing.Point(716, 63);
			arg_6C5_0.Location = location;
			this.EditBox2.Name = "EditBox2";
			this.EditBox2.Nullable = true;
			this.EditBox2.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox2.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_71E_0 = this.EditBox2;
			size = new global::System.Drawing.Size(157, 36);
			arg_71E_0.Size = size;
			this.EditBox2.TabIndex = 2;
			this.EditBox2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(10f, 28f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1248, 564);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Delete_SalMali";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "حذف سال مالی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040002D7 RID: 727
		private global::System.ComponentModel.IContainer components;
	}
}
