namespace FruitBox
{
	// Token: 0x020000E2 RID: 226
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_CheckVariz : global::System.Windows.Forms.Form
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x000DCD48 File Offset: 0x000DAF48
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

		// Token: 0x060014B1 RID: 5297 RVA: 0x000DCD98 File Offset: 0x000DAF98
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_CheckVariz));
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			this.ButtonItem4 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			this.GridEX1.AutomaticSort = false;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_1C9_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 41);
			arg_1C9_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			global::System.Windows.Forms.Control arg_1FA_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(916, 394);
			arg_1FA_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_29B_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_29B_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Silver;
			global::System.Windows.Forms.Control arg_2D9_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(916, 435);
			arg_2D9_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem3,
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem4
			});
			global::DevComponents.DotNetBar.Bar arg_397_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_397_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_3C5_0 = this.Bar1;
			size = new global::System.Drawing.Size(916, 41);
			arg_3C5_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "چاپ برگ واگذاری";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print_edit;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "طراحی برگ واگذاری";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "چاپ پشت نویسی";
			this.txt_mablagh.AcceptEnter = false;
			this.txt_mablagh.AllowEdit = true;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.FocusColor = false;
			global::System.Windows.Forms.Control arg_51F_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(455, 186);
			arg_51F_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_575_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(100, 21);
			arg_575_0.Size = size;
			this.txt_mablagh.TabIndex = 2;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			long? value;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.ButtonItem4.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem4.Image = global::FruitBox.My.Resources.Resources.print_edit;
			this.ButtonItem4.Name = "ButtonItem4";
			this.ButtonItem4.Text = "طراحی پشت نویسی";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(916, 435);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.txt_mablagh);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_CheckVariz";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "واگذاری چک به بانک";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400080A RID: 2058
		private global::System.ComponentModel.IContainer components;
	}
}
