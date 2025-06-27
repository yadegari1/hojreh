namespace FruitBox
{
	// Token: 0x02000102 RID: 258
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_PardakhtCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x00197944 File Offset: 0x00195B44
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

		// Token: 0x06002246 RID: 8774 RVA: 0x00197994 File Offset: 0x00195B94
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_PardakhtCheck));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference3 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage");
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.GridEX2 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox3 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.txt_tarikhGrid = new global::FruitBox.DateBox2(this.components);
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Highlighter1 = new global::DevComponents.DotNetBar.Validator.Highlighter();
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			this.RibbonStatusBar1 = new global::Janus.Windows.Ribbon.RibbonStatusBar();
			this.LabelCommand1 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_jamcheck = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand3 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_jamkol = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand5 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_codem = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand7 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_name = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand9 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand10 = new global::Janus.Windows.Ribbon.LabelCommand();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox3).BeginInit();
			this.UiGroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutoEdit = true;
			this.GridEX1.AutomaticSort = false;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			this.Highlighter1.SetHighlightOnFocus(this.GridEX1, true);
			global::System.Windows.Forms.Control arg_2C6_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(6, 33);
			arg_2C6_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			global::System.Windows.Forms.Control arg_2F7_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(898, 208);
			arg_2F7_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX2.AcceptsEscape = false;
			this.GridEX2.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX2.AlternatingColors = true;
			this.GridEX2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX2.AutoEdit = true;
			this.GridEX2.AutomaticSort = false;
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX2_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference3.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX2_DesignTimeLayout_Reference_1.Instance"));
			gridEXLayout2.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference2,
				janusLayoutReference3
			});
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridEX2_DesignTimeLayout.LayoutString");
			this.GridEX2.DesignTimeLayout = gridEXLayout2;
			this.GridEX2.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX2.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX2.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX2.GroupByBoxVisible = false;
			this.Highlighter1.SetHighlightOnFocus(this.GridEX2, true);
			global::System.Windows.Forms.Control arg_44F_0 = this.GridEX2;
			location = new global::System.Drawing.Point(6, 20);
			arg_44F_0.Location = location;
			this.GridEX2.Name = "GridEX2";
			global::System.Windows.Forms.Control arg_480_0 = this.GridEX2;
			size = new global::System.Drawing.Size(898, 182);
			arg_480_0.Size = size;
			this.GridEX2.TabIndex = 0;
			this.GridEX2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiGroupBox3);
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_507_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_507_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_545_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(916, 487);
			arg_545_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiGroupBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox3.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox3.Controls.Add(this.UiButton1);
			this.UiGroupBox3.Controls.Add(this.txt_tarikhGrid);
			this.UiGroupBox3.Controls.Add(this.GridEX2);
			this.UiGroupBox3.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5FD_0 = this.UiGroupBox3;
			location = new global::System.Drawing.Point(3, 256);
			arg_5FD_0.Location = location;
			this.UiGroupBox3.Name = "UiGroupBox3";
			this.UiGroupBox3.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_63B_0 = this.UiGroupBox3;
			size = new global::System.Drawing.Size(910, 225);
			arg_63B_0.Size = size;
			this.UiGroupBox3.TabIndex = 1;
			this.UiGroupBox3.Text = "دسته چک";
			this.UiGroupBox3.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.check_print;
			global::Janus.Windows.EditControls.UIButton arg_6B3_0 = this.UiButton1;
			size = new global::System.Drawing.Size(32, 32);
			arg_6B3_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_6D0_0 = this.UiButton1;
			location = new global::System.Drawing.Point(12, 178);
			arg_6D0_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_719_0 = this.UiButton1;
			size = new global::System.Drawing.Size(97, 41);
			arg_719_0.Size = size;
			this.UiButton1.TabIndex = 25;
			this.UiButton1.Text = "چاپ چک";
			this.UiButton1.Visible = false;
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.txt_tarikhGrid.AcceptEnter = false;
			this.txt_tarikhGrid.AllowEdit = true;
			this.txt_tarikhGrid.BorderStyle = global::Janus.Windows.GridEX.BorderStyle.None;
			this.txt_tarikhGrid.ButtonEnable = false;
			this.txt_tarikhGrid.ButtonEnabled = false;
			this.txt_tarikhGrid.FocusDatePart = 1;
			this.txt_tarikhGrid.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_7DF_0 = this.txt_tarikhGrid;
			location = new global::System.Drawing.Point(9, 153);
			arg_7DF_0.Location = location;
			this.txt_tarikhGrid.Mask = "0000/00/00";
			this.txt_tarikhGrid.Name = "txt_tarikhGrid";
			this.txt_tarikhGrid.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_828_0 = this.txt_tarikhGrid;
			size = new global::System.Drawing.Size(100, 25);
			arg_828_0.Size = size;
			this.txt_tarikhGrid.TabIndex = 24;
			this.txt_tarikhGrid.TabStop = false;
			this.txt_tarikhGrid.Text = "1393/05/28";
			this.txt_tarikhGrid.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_tarikhGrid.Visible = false;
			this.txt_tarikhGrid.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.GridEX1);
			this.UiGroupBox2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_8E7_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(6, 3);
			arg_8E7_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			this.UiGroupBox2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_925_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(910, 247);
			arg_925_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.Text = "چک مشتری";
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Highlighter1.ContainerControl = this.UiGroupBox1;
			this.txt_mablagh.AcceptEnter = false;
			this.txt_mablagh.AllowEdit = true;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.FocusColor = false;
			global::System.Windows.Forms.Control arg_9B6_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(455, 186);
			arg_9B6_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_A0C_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(100, 21);
			arg_A0C_0.Size = size;
			this.txt_mablagh.TabIndex = 2;
			this.txt_mablagh.TabStop = false;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			long? value;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.RibbonStatusBar1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.RibbonStatusBar1.LeftPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.LabelCommand1,
				this.lbl_jamcheck,
				this.LabelCommand3,
				this.lbl_jamkol,
				this.LabelCommand5
			});
			global::System.Windows.Forms.Control arg_ADE_0 = this.RibbonStatusBar1;
			location = new global::System.Drawing.Point(0, 464);
			arg_ADE_0.Location = location;
			this.RibbonStatusBar1.Name = "RibbonStatusBar1";
			this.RibbonStatusBar1.RightPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.lbl_codem,
				this.LabelCommand7,
				this.lbl_name,
				this.LabelCommand9,
				this.LabelCommand10
			});
			this.RibbonStatusBar1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_B6B_0 = this.RibbonStatusBar1;
			size = new global::System.Drawing.Size(916, 23);
			arg_B6B_0.Size = size;
			this.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
			this.RibbonStatusBar1.SuperTipComponent.ImageList = null;
			this.RibbonStatusBar1.TabIndex = 26;
			this.RibbonStatusBar1.Text = "RibbonStatusBar1";
			this.RibbonStatusBar1.VisualStyle = global::Janus.Windows.Ribbon.VisualStyle.Office2010;
			this.LabelCommand1.Key = "LabelCommand1";
			this.LabelCommand1.Name = "LabelCommand1";
			this.lbl_jamcheck.Key = "LabelCommand2";
			this.lbl_jamcheck.Name = "lbl_jamcheck";
			this.LabelCommand3.Key = "LabelCommand3";
			this.LabelCommand3.Name = "LabelCommand3";
			this.LabelCommand3.Text = "جمع چک ها";
			this.lbl_jamkol.Key = "LabelCommand4";
			this.lbl_jamkol.Name = "lbl_jamkol";
			this.LabelCommand5.Key = "LabelCommand5";
			this.LabelCommand5.Name = "LabelCommand5";
			this.LabelCommand5.Text = "جمع کل پرداختی";
			this.lbl_codem.Key = "LabelCommand1";
			this.lbl_codem.Name = "lbl_codem";
			this.LabelCommand7.Key = "LabelCommand2";
			this.LabelCommand7.Name = "LabelCommand7";
			this.LabelCommand7.Text = "کد مشتری";
			this.lbl_name.Key = "LabelCommand3";
			this.lbl_name.Name = "lbl_name";
			this.LabelCommand9.Key = "LabelCommand4";
			this.LabelCommand9.Name = "LabelCommand9";
			this.LabelCommand9.Text = "نام مشتری";
			this.LabelCommand10.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LabelCommand10.Image");
			this.LabelCommand10.Key = "LabelCommand5";
			this.LabelCommand10.Name = "LabelCommand10";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(916, 487);
			this.ClientSize = size;
			this.Controls.Add(this.RibbonStatusBar1);
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.txt_mablagh);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_PardakhtCheck";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "پرداخت چک";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox3).EndInit();
			this.UiGroupBox3.ResumeLayout(false);
			this.UiGroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000D5E RID: 3422
		private global::System.ComponentModel.IContainer components;
	}
}
