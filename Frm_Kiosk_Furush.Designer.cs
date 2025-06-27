namespace FruitBox
{
	// Token: 0x020000FE RID: 254
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Kiosk_Furush : global::System.Windows.Forms.Form
	{
		// Token: 0x06002073 RID: 8307 RVA: 0x0018274C File Offset: 0x0018094C
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

		// Token: 0x06002074 RID: 8308 RVA: 0x0018279C File Offset: 0x0018099C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Kiosk_Furush));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference3 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference4 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column18.ButtonImage");
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference5 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference6 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference7 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.ButtonImage");
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem11 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem15 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem16 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem17 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem18 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem19 = new global::DevComponents.DotNetBar.ButtonItem();
			this.RibbonStatusBar1 = new global::Janus.Windows.Ribbon.RibbonStatusBar();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Highlighter1 = new global::DevComponents.DotNetBar.Validator.Highlighter();
			this.txt_tarikh = new global::FruitBox.DateBox2(this.components);
			this.txt_fee_n = new global::FruitBox.CurrencyBox(this.components);
			this.txt_jamkol_n = new global::FruitBox.CurrencyBox(this.components);
			this.gridex2 = new global::FruitBox.DataEntryGrid(this.components);
			this.txt_kargari = new global::FruitBox.CurrencyBox(this.components);
			this.txt_jam_kol = new global::FruitBox.CurrencyBox(this.components);
			this.txt_fee = new global::FruitBox.CurrencyBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.txt_sh_mashin = new global::FruitBox.EditBox(this.components);
			this.txt_makharej = new global::FruitBox.CurrencyBox(this.components);
			this.LabelCommand5 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand6 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand7 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand8 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand1 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand2 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand3 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand4 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.NumericBox1 = new global::FruitBox.NumericBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.gridex2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_tarikh);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.txt_fee_n);
			this.UiGroupBox1.Controls.Add(this.txt_jamkol_n);
			this.UiGroupBox1.Controls.Add(this.gridex2);
			this.UiGroupBox1.Controls.Add(this.txt_kargari);
			this.UiGroupBox1.Controls.Add(this.txt_jam_kol);
			this.UiGroupBox1.Controls.Add(this.txt_fee);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.txt_sh_mashin);
			this.UiGroupBox1.Controls.Add(this.txt_makharej);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.RibbonStatusBar1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_448_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_448_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_479_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1124, 629);
			arg_479_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_4DC_0 = this.Label1;
			location = new global::System.Drawing.Point(1053, 61);
			arg_4DC_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_507_0 = this.Label1;
			size = new global::System.Drawing.Size(39, 19);
			arg_507_0.Size = size;
			this.Label1.TabIndex = 32;
			this.Label1.Text = "تاریخ";
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_56C_0 = this.Label4;
			location = new global::System.Drawing.Point(-14, 50);
			arg_56C_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_597_0 = this.Label4;
			size = new global::System.Drawing.Size(41, 19);
			arg_597_0.Size = size;
			this.Label4.TabIndex = 17;
			this.Label4.Text = "کرایه";
			this.Label4.Visible = false;
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_60C_0 = this.Label3;
			location = new global::System.Drawing.Point(278, 50);
			arg_60C_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_637_0 = this.Label3;
			size = new global::System.Drawing.Size(106, 19);
			arg_637_0.Size = size;
			this.Label3.TabIndex = 17;
			this.Label3.Text = "شماره ماشین";
			this.Label3.Visible = false;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem11,
				this.ButtonItem3,
				this.ButtonItem15
			});
			global::DevComponents.DotNetBar.Bar arg_712_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_712_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_740_0 = this.Bar1;
			size = new global::System.Drawing.Size(1124, 41);
			arg_740_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.document;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "جدید (Ins)";
			this.ButtonItem1.Visible = false;
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem11.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem11.Image = global::FruitBox.My.Resources.Resources.list1;
			this.ButtonItem11.Name = "ButtonItem11";
			this.ButtonItem11.Text = "صورتحساب (F3)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.trash_bin;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف ردیف (F5)";
			this.ButtonItem15.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem15.Image = global::FruitBox.My.Resources.Resources.table;
			this.ButtonItem15.Name = "ButtonItem15";
			this.ButtonItem15.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem16,
				this.ButtonItem17,
				this.ButtonItem18,
				this.ButtonItem19
			});
			this.ButtonItem15.Text = "نحوه فروش";
			this.ButtonItem16.Name = "ButtonItem16";
			this.ButtonItem16.Text = "تعداد - وزن خالص";
			this.ButtonItem17.Name = "ButtonItem17";
			this.ButtonItem17.Text = "وزن خالص";
			this.ButtonItem18.Name = "ButtonItem18";
			this.ButtonItem18.Text = "تعداد";
			this.ButtonItem19.Name = "ButtonItem19";
			this.ButtonItem19.Text = "تعداد - وزن با ظرف - ظرف - وزن خالص";
			this.RibbonStatusBar1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.RibbonStatusBar1.LeftPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.LabelCommand5,
				this.LabelCommand6,
				this.LabelCommand7,
				this.LabelCommand8
			});
			global::System.Windows.Forms.Control arg_A27_0 = this.RibbonStatusBar1;
			location = new global::System.Drawing.Point(0, 603);
			arg_A27_0.Location = location;
			this.RibbonStatusBar1.Name = "RibbonStatusBar1";
			this.RibbonStatusBar1.RightPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.LabelCommand1,
				this.LabelCommand2,
				this.LabelCommand3,
				this.LabelCommand4
			});
			global::System.Windows.Forms.Control arg_A9C_0 = this.RibbonStatusBar1;
			size = new global::System.Drawing.Size(1124, 26);
			arg_A9C_0.Size = size;
			this.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
			this.RibbonStatusBar1.SuperTipComponent.ImageList = null;
			this.RibbonStatusBar1.TabIndex = 28;
			this.RibbonStatusBar1.Text = "RibbonStatusBar1";
			this.RibbonStatusBar1.VisualStyle = global::Janus.Windows.Ribbon.VisualStyle.Office2010;
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 200;
			this.Highlighter1.ContainerControl = this.UiGroupBox1;
			this.txt_tarikh.AcceptEnter = true;
			this.txt_tarikh.AllowEdit = true;
			this.txt_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tarikh.ButtonEnable = true;
			this.txt_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_tarikh.FocusDatePart = 2;
			this.txt_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_BAE_0 = this.txt_tarikh;
			location = new global::System.Drawing.Point(936, 52);
			arg_BAE_0.Location = location;
			this.txt_tarikh.Mask = "0000/00/00";
			this.txt_tarikh.Name = "txt_tarikh";
			this.txt_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_BF7_0 = this.txt_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_BF7_0.Size = size;
			this.txt_tarikh.TabIndex = 33;
			this.txt_tarikh.Text = "1392/10/02";
			this.txt_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_fee_n.AcceptEnter = false;
			this.txt_fee_n.AllowEdit = true;
			this.txt_fee_n.AllowNew = true;
			this.txt_fee_n.AllowZero = true;
			this.txt_fee_n.FocusColor = false;
			global::System.Windows.Forms.Control arg_C84_0 = this.txt_fee_n;
			location = new global::System.Drawing.Point(133, 149);
			arg_C84_0.Location = location;
			this.txt_fee_n.Name = "txt_fee_n";
			this.txt_fee_n.Nullable = true;
			this.txt_fee_n.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_fee_n.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_CDA_0 = this.txt_fee_n;
			size = new global::System.Drawing.Size(100, 27);
			arg_CDA_0.Size = size;
			this.txt_fee_n.TabIndex = 31;
			this.txt_fee_n.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_fee_n.Value = value;
			this.txt_fee_n.Visible = false;
			this.txt_fee_n.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_jamkol_n.AcceptEnter = true;
			this.txt_jamkol_n.AllowEdit = true;
			this.txt_jamkol_n.AllowNew = true;
			this.txt_jamkol_n.AllowZero = true;
			this.txt_jamkol_n.FocusColor = false;
			global::System.Windows.Forms.Control arg_D7B_0 = this.txt_jamkol_n;
			location = new global::System.Drawing.Point(17, 149);
			arg_D7B_0.Location = location;
			this.txt_jamkol_n.Name = "txt_jamkol_n";
			this.txt_jamkol_n.Nullable = true;
			this.txt_jamkol_n.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_jamkol_n.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_DD1_0 = this.txt_jamkol_n;
			size = new global::System.Drawing.Size(100, 27);
			arg_DD1_0.Size = size;
			this.txt_jamkol_n.TabIndex = 30;
			this.txt_jamkol_n.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_jamkol_n.Value = value;
			this.txt_jamkol_n.Visible = false;
			this.txt_jamkol_n.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.gridex2.AcceptsEscape = false;
			this.gridex2.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridex2.AlternatingColors = true;
			this.gridex2.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("gridex2_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("gridex2_DesignTimeLayout_Reference_1.Instance"));
			janusLayoutReference3.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("gridex2_DesignTimeLayout_Reference_2.Instance"));
			janusLayoutReference4.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("gridex2_DesignTimeLayout_Reference_3.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2,
				janusLayoutReference3,
				janusLayoutReference4
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("gridex2_DesignTimeLayout.LayoutString");
			this.gridex2.DesignTimeLayout = gridEXLayout;
			this.gridex2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.gridex2.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridex2.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridex2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.gridex2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridex2.GroupByBoxVisible = false;
			this.Highlighter1.SetHighlightOnFocus(this.gridex2, true);
			global::System.Windows.Forms.Control arg_F8C_0 = this.gridex2;
			location = new global::System.Drawing.Point(0, 94);
			arg_F8C_0.Location = location;
			this.gridex2.Name = "gridex2";
			this.gridex2.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.gridex2.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_FD7_0 = this.gridex2;
			size = new global::System.Drawing.Size(1124, 509);
			arg_FD7_0.Size = size;
			this.gridex2.TabIndex = 29;
			this.gridex2.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridex2.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.gridex2.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.gridex2.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.gridex2.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.gridex2.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.gridex2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_kargari.AcceptEnter = true;
			this.txt_kargari.AllowEdit = true;
			this.txt_kargari.AllowNew = true;
			this.txt_kargari.AllowZero = true;
			this.txt_kargari.FocusColor = false;
			global::System.Windows.Forms.Control arg_10B5_0 = this.txt_kargari;
			location = new global::System.Drawing.Point(239, 116);
			arg_10B5_0.Location = location;
			this.txt_kargari.Name = "txt_kargari";
			this.txt_kargari.Nullable = true;
			this.txt_kargari.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_kargari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_110B_0 = this.txt_kargari;
			size = new global::System.Drawing.Size(100, 27);
			arg_110B_0.Size = size;
			this.txt_kargari.TabIndex = 27;
			this.txt_kargari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_kargari.Value = value;
			this.txt_kargari.Visible = false;
			this.txt_kargari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_jam_kol.AcceptEnter = false;
			this.txt_jam_kol.AllowEdit = true;
			this.txt_jam_kol.AllowNew = true;
			this.txt_jam_kol.AllowZero = true;
			this.txt_jam_kol.FocusColor = false;
			global::System.Windows.Forms.Control arg_11AC_0 = this.txt_jam_kol;
			location = new global::System.Drawing.Point(133, 116);
			arg_11AC_0.Location = location;
			this.txt_jam_kol.Name = "txt_jam_kol";
			this.txt_jam_kol.Nullable = true;
			this.txt_jam_kol.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_jam_kol.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1202_0 = this.txt_jam_kol;
			size = new global::System.Drawing.Size(100, 27);
			arg_1202_0.Size = size;
			this.txt_jam_kol.TabIndex = 22;
			this.txt_jam_kol.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_jam_kol.Value = value;
			this.txt_jam_kol.Visible = false;
			this.txt_jam_kol.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_fee.AcceptEnter = true;
			this.txt_fee.AllowEdit = true;
			this.txt_fee.AllowNew = true;
			this.txt_fee.AllowZero = true;
			this.txt_fee.FocusColor = false;
			global::System.Windows.Forms.Control arg_12A0_0 = this.txt_fee;
			location = new global::System.Drawing.Point(17, 116);
			arg_12A0_0.Location = location;
			this.txt_fee.Name = "txt_fee";
			this.txt_fee.Nullable = true;
			this.txt_fee.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_fee.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_12F6_0 = this.txt_fee;
			size = new global::System.Drawing.Size(100, 27);
			arg_12F6_0.Size = size;
			this.txt_fee.TabIndex = 21;
			this.txt_fee.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_fee.Value = value;
			this.txt_fee.Visible = false;
			this.txt_fee.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutoEdit = true;
			janusLayoutReference5.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference6.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"));
			janusLayoutReference7.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"));
			gridEXLayout2.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference5,
				janusLayoutReference6,
				janusLayoutReference7
			});
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout2;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			this.Highlighter1.SetHighlightOnFocus(this.GridEX1, true);
			global::System.Windows.Forms.Control arg_148D_0 = this.GridEX1;
			location = new global::System.Drawing.Point(748, 179);
			arg_148D_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_14D8_0 = this.GridEX1;
			size = new global::System.Drawing.Size(376, 331);
			arg_14D8_0.Size = size;
			this.GridEX1.TabIndex = 3;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.Visible = false;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_sh_mashin.AcceptEnter = true;
			this.txt_sh_mashin.AllowEdit = true;
			this.txt_sh_mashin.AllowNew = true;
			this.txt_sh_mashin.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_sh_mashin.FocusColor = true;
			this.txt_sh_mashin.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_15E2_0 = this.txt_sh_mashin;
			location = new global::System.Drawing.Point(79, 42);
			arg_15E2_0.Location = location;
			this.txt_sh_mashin.MaxLength = 9;
			this.txt_sh_mashin.Name = "txt_sh_mashin";
			this.txt_sh_mashin.Nullable = true;
			this.txt_sh_mashin.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_sh_mashin.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1649_0 = this.txt_sh_mashin;
			size = new global::System.Drawing.Size(197, 36);
			arg_1649_0.Size = size;
			this.txt_sh_mashin.TabIndex = 2;
			this.txt_sh_mashin.Visible = false;
			this.txt_sh_mashin.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_makharej.AcceptEnter = true;
			this.txt_makharej.AllowEdit = true;
			this.txt_makharej.AllowNew = true;
			this.txt_makharej.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_makharej.ButtonText = "...";
			this.txt_makharej.FocusColor = true;
			this.txt_makharej.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_1702_0 = this.txt_makharej;
			location = new global::System.Drawing.Point(-213, 42);
			arg_1702_0.Location = location;
			this.txt_makharej.Name = "txt_makharej";
			this.txt_makharej.Nullable = true;
			this.txt_makharej.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_makharej.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.txt_makharej.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1768_0 = this.txt_makharej;
			size = new global::System.Drawing.Size(197, 36);
			arg_1768_0.Size = size;
			this.txt_makharej.TabIndex = 3;
			this.txt_makharej.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			this.txt_makharej.Value = value;
			this.txt_makharej.Visible = false;
			this.txt_makharej.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.LabelCommand5.Key = "LabelCommand1";
			this.LabelCommand5.Name = "LabelCommand5";
			this.LabelCommand6.Key = "LabelCommand2";
			this.LabelCommand6.Name = "LabelCommand6";
			this.LabelCommand7.Key = "LabelCommand3";
			this.LabelCommand7.Name = "LabelCommand7";
			this.LabelCommand8.Key = "LabelCommand4";
			this.LabelCommand8.Name = "LabelCommand8";
			this.LabelCommand1.Key = "LabelCommand1";
			this.LabelCommand1.Name = "LabelCommand1";
			this.LabelCommand2.Key = "LabelCommand2";
			this.LabelCommand2.Name = "LabelCommand2";
			this.LabelCommand3.Key = "LabelCommand3";
			this.LabelCommand3.Name = "LabelCommand3";
			this.LabelCommand4.Key = "LabelCommand4";
			this.LabelCommand4.Name = "LabelCommand4";
			this.NumericBox1.AcceptEnter = true;
			this.NumericBox1.AllowEdit = true;
			this.NumericBox1.AllowNew = true;
			this.NumericBox1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.NumericBox1.FocusColor = true;
			this.NumericBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_1935_0 = this.NumericBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_1935_0.Location = location;
			global::System.Windows.Forms.Control arg_194F_0 = this.NumericBox1;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			arg_194F_0.Margin = margin;
			this.NumericBox1.Name = "NumericBox1";
			this.NumericBox1.Nullable = true;
			this.NumericBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.NumericBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_19A5_0 = this.NumericBox1;
			size = new global::System.Drawing.Size(98, 27);
			arg_19A5_0.Size = size;
			this.NumericBox1.TabIndex = 0;
			this.NumericBox1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Center;
			this.NumericBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(9f, 19f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1124, 629);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Kiosk_Furush";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "فروش روزانه";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.gridex2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000C9B RID: 3227
		private global::System.ComponentModel.IContainer components;
	}
}
