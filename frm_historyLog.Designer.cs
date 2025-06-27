namespace FruitBox
{
	// Token: 0x0200006D RID: 109
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_historyLog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x0007636C File Offset: 0x0007456C
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

		// Token: 0x0600085F RID: 2143 RVA: 0x000763BC File Offset: 0x000745BC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.frm_historyLog));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout3 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout4 = new global::Janus.Windows.GridEX.GridEXLayout();
			this.GridEX2 = new global::Janus.Windows.GridEX.GridEX();
			this.GridDelete = new global::Janus.Windows.GridEX.GridEX();
			this.GridEX4 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEslah = new global::Janus.Windows.GridEX.GridEX();
			this.SuperTabStrip1 = new global::DevComponents.DotNetBar.SuperTabStrip();
			this.SuperTabItem1 = new global::DevComponents.DotNetBar.SuperTabItem();
			this.SuperTabItem2 = new global::DevComponents.DotNetBar.SuperTabItem();
			this.SuperTabItem3 = new global::DevComponents.DotNetBar.SuperTabItem();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridDelete).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEslah).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SuperTabStrip1).BeginInit();
			this.SuspendLayout();
			this.GridEX2.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX2_DesignTimeLayout.LayoutString");
			this.GridEX2.DesignTimeLayout = gridEXLayout;
			this.GridEX2.Font = new global::System.Drawing.Font("Tahoma", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX2.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_17E_0 = this.GridEX2;
			global::System.Drawing.Point location = new global::System.Drawing.Point(650, 0);
			arg_17E_0.Location = location;
			this.GridEX2.Name = "GridEX2";
			this.GridEX2.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_1BC_0 = this.GridEX2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(302, 456);
			arg_1BC_0.Size = size;
			this.GridEX2.TabIndex = 1;
			this.GridEX2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridDelete.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridDelete.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridDelete_DesignTimeLayout.LayoutString");
			this.GridDelete.DesignTimeLayout = gridEXLayout2;
			this.GridDelete.Font = new global::System.Drawing.Font("Tahoma", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridDelete.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridDelete.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_266_0 = this.GridDelete;
			location = new global::System.Drawing.Point(4, 30);
			arg_266_0.Location = location;
			this.GridDelete.Name = "GridDelete";
			global::System.Windows.Forms.Control arg_297_0 = this.GridDelete;
			size = new global::System.Drawing.Size(637, 426);
			arg_297_0.Size = size;
			this.GridDelete.TabIndex = 0;
			this.GridDelete.Visible = false;
			this.GridDelete.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			gridEXLayout3.LayoutString = componentResourceManager.GetString("GridEX4_DesignTimeLayout.LayoutString");
			this.GridEX4.DesignTimeLayout = gridEXLayout3;
			this.GridEX4.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX4.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_314_0 = this.GridEX4;
			location = new global::System.Drawing.Point(4, 308);
			arg_314_0.Location = location;
			this.GridEX4.Name = "GridEX4";
			global::System.Windows.Forms.Control arg_345_0 = this.GridEX4;
			size = new global::System.Drawing.Size(465, 148);
			arg_345_0.Size = size;
			this.GridEX4.TabIndex = 0;
			this.GridEX4.Visible = false;
			this.GridEX4.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEslah);
			this.UiGroupBox1.Controls.Add(this.SuperTabStrip1);
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_3DA_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(1, 0);
			arg_3DA_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_40B_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(643, 456);
			arg_40B_0.Size = size;
			this.UiGroupBox1.TabIndex = 4;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEslah.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEslah.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout4.LayoutString = componentResourceManager.GetString("GridEslah_DesignTimeLayout.LayoutString");
			this.GridEslah.DesignTimeLayout = gridEXLayout4;
			this.GridEslah.Font = new global::System.Drawing.Font("Tahoma", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEslah.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEslah.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_4B5_0 = this.GridEslah;
			location = new global::System.Drawing.Point(6, 30);
			arg_4B5_0.Location = location;
			this.GridEslah.Name = "GridEslah";
			this.GridEslah.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_4F3_0 = this.GridEslah;
			size = new global::System.Drawing.Size(637, 426);
			arg_4F3_0.Size = size;
			this.GridEslah.TabIndex = 5;
			this.GridEslah.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.SuperTabStrip1.AutoSelectAttachedControl = false;
			this.SuperTabStrip1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.SuperTabStrip1.ContainerControlProcessDialogKey = true;
			this.SuperTabStrip1.ControlBox.CloseBox.Name = "";
			this.SuperTabStrip1.ControlBox.MenuBox.Name = "";
			this.SuperTabStrip1.ControlBox.Name = "";
			this.SuperTabStrip1.ControlBox.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.SuperTabStrip1.ControlBox.MenuBox,
				this.SuperTabStrip1.ControlBox.CloseBox
			});
			this.SuperTabStrip1.ControlBox.Visible = false;
			this.SuperTabStrip1.Dock = global::System.Windows.Forms.DockStyle.Top;
			global::System.Windows.Forms.Control arg_606_0 = this.SuperTabStrip1;
			location = new global::System.Drawing.Point(0, 0);
			arg_606_0.Location = location;
			this.SuperTabStrip1.Name = "SuperTabStrip1";
			this.SuperTabStrip1.ReorderTabsEnabled = true;
			this.SuperTabStrip1.SelectedTabFont = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.SuperTabStrip1.SelectedTabIndex = 2;
			global::System.Windows.Forms.Control arg_66A_0 = this.SuperTabStrip1;
			size = new global::System.Drawing.Size(643, 24);
			arg_66A_0.Size = size;
			this.SuperTabStrip1.TabCloseButtonHot = null;
			this.SuperTabStrip1.TabFont = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.SuperTabStrip1.TabIndex = 4;
			this.SuperTabStrip1.Tabs.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.SuperTabItem1,
				this.SuperTabItem2,
				this.SuperTabItem3
			});
			this.SuperTabStrip1.TabStyle = global::DevComponents.DotNetBar.eSuperTabStyle.WinMediaPlayer12;
			this.SuperTabStrip1.Text = "SuperTabStrip1";
			global::DevComponents.DotNetBar.SuperTabItem arg_719_0 = this.SuperTabItem1;
			size = new global::System.Drawing.Size(100, 0);
			arg_719_0.FixedTabSize = size;
			this.SuperTabItem1.GlobalItem = false;
			this.SuperTabItem1.Name = "SuperTabItem1";
			this.SuperTabItem1.Text = "اصلاح";
			this.SuperTabItem1.TextAlignment = global::DevComponents.DotNetBar.eItemAlignment.Center;
			global::DevComponents.DotNetBar.SuperTabItem arg_773_0 = this.SuperTabItem2;
			size = new global::System.Drawing.Size(100, 0);
			arg_773_0.FixedTabSize = size;
			this.SuperTabItem2.GlobalItem = false;
			this.SuperTabItem2.Name = "SuperTabItem2";
			this.SuperTabItem2.Text = "ایجاد";
			this.SuperTabItem2.TextAlignment = global::DevComponents.DotNetBar.eItemAlignment.Center;
			global::DevComponents.DotNetBar.SuperTabItem arg_7CD_0 = this.SuperTabItem3;
			size = new global::System.Drawing.Size(100, 0);
			arg_7CD_0.FixedTabSize = size;
			this.SuperTabItem3.GlobalItem = false;
			this.SuperTabItem3.Name = "SuperTabItem3";
			this.SuperTabItem3.Text = "حذف";
			this.SuperTabItem3.TextAlignment = global::DevComponents.DotNetBar.eItemAlignment.Center;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(954, 459);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.GridEX4);
			this.Controls.Add(this.GridDelete);
			this.Controls.Add(this.GridEX2);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_historyLog";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "تاریخچه اطلاعات";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridDelete).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.GridEslah).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SuperTabStrip1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000343 RID: 835
		private global::System.ComponentModel.IContainer components;
	}
}
