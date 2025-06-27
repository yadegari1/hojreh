namespace FruitBox
{
	// Token: 0x0200007B RID: 123
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_SelectItemSql : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A43 RID: 2627 RVA: 0x000857E0 File Offset: 0x000839E0
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

		// Token: 0x06000A44 RID: 2628 RVA: 0x00085830 File Offset: 0x00083A30
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.EditBox1 = new global::Janus.Windows.GridEX.EditControls.EditBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutomaticSort = false;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_DE_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 46);
			arg_DE_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_11B_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(620, 336);
			arg_11B_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1CF_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_1CF_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1FF_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(620, 382);
			arg_1FF_0.Size = size;
			this.UiGroupBox1.TabIndex = 1;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.add;
			global::System.Windows.Forms.Control arg_263_0 = this.UiButton1;
			location = new global::System.Drawing.Point(4, 4);
			arg_263_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_2AB_0 = this.UiButton1;
			size = new global::System.Drawing.Size(102, 36);
			arg_2AB_0.Size = size;
			this.UiButton1.TabIndex = 2;
			this.UiButton1.Text = "جدید (Ins)";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_31E_0 = this.EditBox1;
			location = new global::System.Drawing.Point(112, 4);
			arg_31E_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			global::System.Windows.Forms.Control arg_34B_0 = this.EditBox1;
			size = new global::System.Drawing.Size(445, 36);
			arg_34B_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_3CF_0 = this.Label1;
			location = new global::System.Drawing.Point(559, 9);
			arg_3CF_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_3F9_0 = this.Label1;
			size = new global::System.Drawing.Size(61, 19);
			arg_3F9_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "جستجو";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(620, 382);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_SelectItemSql";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x0400040B RID: 1035
		private global::System.ComponentModel.IContainer components;
	}
}
