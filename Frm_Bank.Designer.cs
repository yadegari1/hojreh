namespace FruitBox
{
	// Token: 0x020000C2 RID: 194
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Bank : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F8B RID: 3979 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
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

		// Token: 0x06000F8C RID: 3980 RVA: 0x000ACF14 File Offset: 0x000AB114
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Bank));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.txt_name = new global::FruitBox.EditBox(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.txt_name);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_143_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 41);
			arg_143_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_181_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(469, 473);
			arg_181_0.Size = size;
			this.UiGroupBox1.TabIndex = 14;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutoEdit = true;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_257_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 43);
			arg_257_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_2AF_0 = this.GridEX1;
			size = new global::System.Drawing.Size(466, 430);
			arg_2AF_0.Size = size;
			this.GridEX1.TabIndex = 2;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_name.AcceptEnter = true;
			this.txt_name.AllowEdit = true;
			this.txt_name.AllowNew = true;
			this.txt_name.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_name.FocusColor = true;
			this.txt_name.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_394_0 = this.txt_name;
			location = new global::System.Drawing.Point(146, 10);
			arg_394_0.Location = location;
			this.txt_name.Name = "txt_name";
			this.txt_name.Nullable = false;
			this.txt_name.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_name.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3ED_0 = this.txt_name;
			size = new global::System.Drawing.Size(259, 27);
			arg_3ED_0.Size = size;
			this.txt_name.TabIndex = 1;
			this.txt_name.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_482_0 = this.Label1;
			location = new global::System.Drawing.Point(411, 16);
			arg_482_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_4AD_0 = this.Label1;
			size = new global::System.Drawing.Size(46, 19);
			arg_4AD_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "عنوان";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_556_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_556_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_584_0 = this.Bar1;
			size = new global::System.Drawing.Size(469, 41);
			arg_584_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 15;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.document;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "جدید (Ins)";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.trash_bin;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف (F5)";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(469, 514);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Bank";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تعریف بانک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040005D9 RID: 1497
		private global::System.ComponentModel.IContainer components;
	}
}
