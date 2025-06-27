namespace FruitBox
{
	// Token: 0x02000080 RID: 128
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sortdp : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B29 RID: 2857 RVA: 0x0008CC14 File Offset: 0x0008AE14
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

		// Token: 0x06000B2A RID: 2858 RVA: 0x0008CC64 File Offset: 0x0008AE64
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sortdp));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			this.UiComboBox1 = new global::Janus.Windows.EditControls.UIComboBox();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GridEx2 = new global::FruitBox.DataEntryGrid(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.UiButton4 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton3 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEx2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiComboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiComboBox1.ComboStyle = global::Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.UiComboBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_167_0 = this.UiComboBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(466, 53);
			arg_167_0.Location = location;
			this.UiComboBox1.Name = "UiComboBox1";
			global::System.Windows.Forms.Control arg_195_0 = this.UiComboBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(349, 27);
			arg_195_0.Size = size;
			this.UiComboBox1.TabIndex = 0;
			this.UiComboBox1.Visible = false;
			this.UiComboBox1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEx2);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.UiButton4);
			this.UiGroupBox1.Controls.Add(this.UiButton3);
			this.UiGroupBox1.Controls.Add(this.UiButton2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.UiComboBox1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_2CA_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_2CA_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_2FB_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(914, 500);
			arg_2FB_0.Size = size;
			this.UiGroupBox1.TabIndex = 1;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_380_0 = this.Label1;
			location = new global::System.Drawing.Point(824, 59);
			arg_380_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_3AB_0 = this.Label1;
			size = new global::System.Drawing.Size(87, 19);
			arg_3AB_0.Size = size;
			this.Label1.TabIndex = 18;
			this.Label1.Text = "منوی اصلی";
			this.Label1.Visible = false;
			this.GridEx2.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEx2.AlternatingColors = true;
			this.GridEx2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEx2.AutoEdit = true;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEx2_DesignTimeLayout.LayoutString");
			this.GridEx2.DesignTimeLayout = gridEXLayout;
			this.GridEx2.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEx2.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEx2.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEx2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEx2.GroupByBoxVisible = false;
			this.GridEx2.HideSelection = global::Janus.Windows.GridEX.HideSelection.Highlight;
			global::System.Windows.Forms.Control arg_4A1_0 = this.GridEx2;
			location = new global::System.Drawing.Point(38, 86);
			arg_4A1_0.Location = location;
			this.GridEx2.Name = "GridEx2";
			this.GridEx2.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEx2.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEx2.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_4F9_0 = this.GridEx2;
			size = new global::System.Drawing.Size(351, 411);
			arg_4F9_0.Size = size;
			this.GridEx2.TabIndex = 17;
			this.GridEx2.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEx2.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEx2.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEx2.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEx2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutoEdit = true;
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout2;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			this.GridEX1.HideSelection = global::Janus.Windows.GridEX.HideSelection.Highlight;
			global::System.Windows.Forms.Control arg_62C_0 = this.GridEX1;
			location = new global::System.Drawing.Point(466, 86);
			arg_62C_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_684_0 = this.GridEX1;
			size = new global::System.Drawing.Size(349, 411);
			arg_684_0.Size = size;
			this.GridEX1.TabIndex = 17;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_783_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_783_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_7B1_0 = this.Bar1;
			size = new global::System.Drawing.Size(914, 41);
			arg_7B1_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.page;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "جدید (Ins)";
			this.ButtonItem1.Visible = false;
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.disk;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.page_edit;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "تنظیم منوی اصلی";
			this.ButtonItem3.Visible = false;
			this.UiButton4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton4.Image = global::FruitBox.My.Resources.Resources.arrow_down;
			global::Janus.Windows.EditControls.UIButton arg_90A_0 = this.UiButton4;
			size = new global::System.Drawing.Size(32, 32);
			arg_90A_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_92A_0 = this.UiButton4;
			location = new global::System.Drawing.Point(395, 199);
			arg_92A_0.Location = location;
			this.UiButton4.Name = "UiButton4";
			this.UiButton4.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton4.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_973_0 = this.UiButton4;
			size = new global::System.Drawing.Size(42, 39);
			arg_973_0.Size = size;
			this.UiButton4.TabIndex = 2;
			this.UiButton4.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton3.Image = global::FruitBox.My.Resources.Resources.arrow_up;
			global::Janus.Windows.EditControls.UIButton arg_9C6_0 = this.UiButton3;
			size = new global::System.Drawing.Size(32, 32);
			arg_9C6_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_9E6_0 = this.UiButton3;
			location = new global::System.Drawing.Point(395, 158);
			arg_9E6_0.Location = location;
			this.UiButton3.Name = "UiButton3";
			this.UiButton3.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton3.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_A2F_0 = this.UiButton3;
			size = new global::System.Drawing.Size(42, 35);
			arg_A2F_0.Size = size;
			this.UiButton3.TabIndex = 2;
			this.UiButton3.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.arrow_down;
			global::Janus.Windows.EditControls.UIButton arg_A82_0 = this.UiButton2;
			size = new global::System.Drawing.Size(32, 32);
			arg_A82_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_AA2_0 = this.UiButton2;
			location = new global::System.Drawing.Point(824, 199);
			arg_AA2_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_AEB_0 = this.UiButton2;
			size = new global::System.Drawing.Size(42, 39);
			arg_AEB_0.Size = size;
			this.UiButton2.TabIndex = 2;
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.arrow_up;
			global::Janus.Windows.EditControls.UIButton arg_B3E_0 = this.UiButton1;
			size = new global::System.Drawing.Size(32, 32);
			arg_B3E_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_B5E_0 = this.UiButton1;
			location = new global::System.Drawing.Point(824, 158);
			arg_B5E_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_BA7_0 = this.UiButton1;
			size = new global::System.Drawing.Size(42, 35);
			arg_BA7_0.Size = size;
			this.UiButton1.TabIndex = 2;
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(914, 500);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sortdp";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تنظیم گزینه های دریافت و پرداخت";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEx2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400046A RID: 1130
		private global::System.ComponentModel.IContainer components;
	}
}
