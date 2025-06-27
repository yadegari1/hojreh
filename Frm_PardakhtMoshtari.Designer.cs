namespace FruitBox
{
	// Token: 0x02000104 RID: 260
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_PardakhtMoshtari : global::System.Windows.Forms.Form
	{
		// Token: 0x060022EB RID: 8939 RVA: 0x001A0FF8 File Offset: 0x0019F1F8
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

		// Token: 0x060022EC RID: 8940 RVA: 0x001A1048 File Offset: 0x0019F248
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_PardakhtMoshtari));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference3 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage");
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.GridEX2 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_babat_kart = new global::FruitBox.EditBox(this.components);
			this.txt_kart_bankhesab = new global::FruitBox.SelectItem(this.components);
			this.txt_cart = new global::FruitBox.CurrencyBox(this.components);
			this.txt_naghd = new global::FruitBox.CurrencyBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.txt_tarikhGrid = new global::FruitBox.DateBox2(this.components);
			this.Highlighter1 = new global::DevComponents.DotNetBar.Validator.Highlighter();
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
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
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
			global::System.Windows.Forms.Control arg_31F_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(7, 191);
			arg_31F_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			global::System.Windows.Forms.Control arg_350_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(812, 203);
			arg_350_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX2.AcceptsEscape = false;
			this.GridEX2.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX2.AlternatingColors = true;
			this.GridEX2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
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
			global::System.Windows.Forms.Control arg_4AC_0 = this.GridEX2;
			location = new global::System.Drawing.Point(7, 2);
			arg_4AC_0.Location = location;
			this.GridEX2.Name = "GridEX2";
			global::System.Windows.Forms.Control arg_4DD_0 = this.GridEX2;
			size = new global::System.Drawing.Size(812, 182);
			arg_4DD_0.Size = size;
			this.GridEX2.TabIndex = 0;
			this.GridEX2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_babat_kart);
			this.UiGroupBox1.Controls.Add(this.txt_kart_bankhesab);
			this.UiGroupBox1.Controls.Add(this.txt_cart);
			this.UiGroupBox1.Controls.Add(this.txt_naghd);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label6);
			this.UiGroupBox1.Controls.Add(this.Label5);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEX2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.txt_tarikhGrid);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_678_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_678_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_6B6_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(928, 510);
			arg_6B6_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_babat_kart.AcceptEnter = true;
			this.txt_babat_kart.AllowEdit = true;
			this.txt_babat_kart.AllowNew = true;
			this.txt_babat_kart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_babat_kart.FocusColor = true;
			this.txt_babat_kart.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_750_0 = this.txt_babat_kart;
			location = new global::System.Drawing.Point(7, 443);
			arg_750_0.Location = location;
			this.txt_babat_kart.Name = "txt_babat_kart";
			this.txt_babat_kart.Nullable = true;
			this.txt_babat_kart.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_babat_kart.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7A9_0 = this.txt_babat_kart;
			size = new global::System.Drawing.Size(176, 36);
			arg_7A9_0.Size = size;
			this.txt_babat_kart.TabIndex = 5;
			this.txt_babat_kart.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_kart_bankhesab.AcceptEnter = true;
			this.txt_kart_bankhesab.AddNewForm = null;
			this.txt_kart_bankhesab.AllowEdit = true;
			this.txt_kart_bankhesab.AllowNew = true;
			this.txt_kart_bankhesab.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_kart_bankhesab.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_kart_bankhesab.ButtonText = "...";
			this.txt_kart_bankhesab.CanEdit = false;
			this.txt_kart_bankhesab.DisplayMember = "Name";
			this.txt_kart_bankhesab.Edit_Frm = null;
			this.txt_kart_bankhesab.ExtraData = 0L;
			this.txt_kart_bankhesab.FocusColor = true;
			this.txt_kart_bankhesab.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "حساب بانکی";
			column2.Name = "Name";
			column2.Size = 85;
			this.txt_kart_bankhesab.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2
			});
			global::System.Windows.Forms.Control arg_914_0 = this.txt_kart_bankhesab;
			location = new global::System.Drawing.Point(291, 443);
			arg_914_0.Location = location;
			this.txt_kart_bankhesab.Name = "txt_kart_bankhesab";
			this.txt_kart_bankhesab.Nullable = true;
			this.txt_kart_bankhesab.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_kart_bankhesab.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_kart_bankhesab.SelectCommand = "SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID";
			this.txt_kart_bankhesab.SelectedRow = null;
			this.txt_kart_bankhesab.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_998_0 = this.txt_kart_bankhesab;
			size = new global::System.Drawing.Size(245, 36);
			arg_998_0.Size = size;
			this.txt_kart_bankhesab.TabIndex = 4;
			this.txt_kart_bankhesab.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_kart_bankhesab.Value = null;
			this.txt_kart_bankhesab.ValueMember = "ID";
			this.txt_kart_bankhesab.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_cart.AcceptEnter = true;
			this.txt_cart.AllowEdit = true;
			this.txt_cart.AllowNew = true;
			this.txt_cart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_cart.ButtonImage = (global::System.Drawing.Image)componentResourceManager.GetObject("txt_cart.ButtonImage");
			this.txt_cart.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
			this.txt_cart.FocusColor = true;
			this.txt_cart.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A8B_0 = this.txt_cart;
			location = new global::System.Drawing.Point(639, 443);
			arg_A8B_0.Location = location;
			this.txt_cart.Name = "txt_cart";
			this.txt_cart.Nullable = true;
			this.txt_cart.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_cart.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.txt_cart.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_AF1_0 = this.txt_cart;
			size = new global::System.Drawing.Size(180, 36);
			arg_AF1_0.Size = size;
			this.txt_cart.TabIndex = 3;
			this.txt_cart.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_cart.Value = value;
			this.txt_cart.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_naghd.AcceptEnter = true;
			this.txt_naghd.AllowEdit = false;
			this.txt_naghd.AllowNew = true;
			this.txt_naghd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_naghd.FocusColor = true;
			this.txt_naghd.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_BAA_0 = this.txt_naghd;
			location = new global::System.Drawing.Point(639, 401);
			arg_BAA_0.Location = location;
			this.txt_naghd.Name = "txt_naghd";
			this.txt_naghd.Nullable = true;
			this.txt_naghd.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_naghd.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_C03_0 = this.txt_naghd;
			size = new global::System.Drawing.Size(180, 36);
			arg_C03_0.Size = size;
			this.txt_naghd.TabIndex = 2;
			this.txt_naghd.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_naghd.Value = value;
			this.txt_naghd.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_CA3_0 = this.Label2;
			location = new global::System.Drawing.Point(825, 15);
			arg_CA3_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_CCE_0 = this.Label2;
			size = new global::System.Drawing.Size(78, 19);
			arg_CCE_0.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "دسته چک";
			this.Label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Transparent;
			this.Label6.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_D5A_0 = this.Label6;
			location = new global::System.Drawing.Point(184, 452);
			arg_D5A_0.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control arg_D85_0 = this.Label6;
			size = new global::System.Drawing.Size(105, 19);
			arg_D85_0.Size = size;
			this.Label6.TabIndex = 1;
			this.Label6.Text = "شماره پیگیری";
			this.Label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			this.Label5.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_E11_0 = this.Label5;
			location = new global::System.Drawing.Point(537, 452);
			arg_E11_0.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control arg_E3C_0 = this.Label5;
			size = new global::System.Drawing.Size(98, 19);
			arg_E3C_0.Size = size;
			this.Label5.TabIndex = 1;
			this.Label5.Text = "حساب بانکی";
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_EC8_0 = this.Label4;
			location = new global::System.Drawing.Point(822, 452);
			arg_EC8_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_EF3_0 = this.Label4;
			size = new global::System.Drawing.Size(96, 19);
			arg_EF3_0.Size = size;
			this.Label4.TabIndex = 1;
			this.Label4.Text = "کارت به کارت";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_F7F_0 = this.Label3;
			location = new global::System.Drawing.Point(821, 411);
			arg_F7F_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_FAA_0 = this.Label3;
			size = new global::System.Drawing.Size(64, 19);
			arg_FAA_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "مبلغ نقد";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_1036_0 = this.Label1;
			location = new global::System.Drawing.Point(825, 199);
			arg_1036_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_1061_0 = this.Label1;
			size = new global::System.Drawing.Size(92, 19);
			arg_1061_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "چک مشتری";
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.check_print;
			global::Janus.Windows.EditControls.UIButton arg_10CC_0 = this.UiButton1;
			size = new global::System.Drawing.Size(32, 32);
			arg_10CC_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_10EC_0 = this.UiButton1;
			location = new global::System.Drawing.Point(827, 341);
			arg_10EC_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_1135_0 = this.UiButton1;
			size = new global::System.Drawing.Size(97, 41);
			arg_1135_0.Size = size;
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
			global::System.Windows.Forms.Control arg_11FE_0 = this.txt_tarikhGrid;
			location = new global::System.Drawing.Point(827, 310);
			arg_11FE_0.Location = location;
			this.txt_tarikhGrid.Mask = "0000/00/00";
			this.txt_tarikhGrid.Name = "txt_tarikhGrid";
			this.txt_tarikhGrid.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_1247_0 = this.txt_tarikhGrid;
			size = new global::System.Drawing.Size(100, 25);
			arg_1247_0.Size = size;
			this.txt_tarikhGrid.TabIndex = 24;
			this.txt_tarikhGrid.TabStop = false;
			this.txt_tarikhGrid.Text = "1393/05/28";
			this.txt_tarikhGrid.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_tarikhGrid.Visible = false;
			this.txt_tarikhGrid.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Highlighter1.ContainerControl = this.UiGroupBox1;
			this.RibbonStatusBar1.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.RibbonStatusBar1.LeftPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.LabelCommand1,
				this.lbl_jamcheck,
				this.LabelCommand3,
				this.lbl_jamkol,
				this.LabelCommand5
			});
			global::System.Windows.Forms.Control arg_133C_0 = this.RibbonStatusBar1;
			location = new global::System.Drawing.Point(0, 487);
			arg_133C_0.Location = location;
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
			global::System.Windows.Forms.Control arg_13C9_0 = this.RibbonStatusBar1;
			size = new global::System.Drawing.Size(928, 23);
			arg_13C9_0.Size = size;
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
			this.txt_mablagh.AcceptEnter = false;
			this.txt_mablagh.AllowEdit = true;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.FocusColor = false;
			global::System.Windows.Forms.Control arg_1626_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(455, 186);
			arg_1626_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_167C_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(100, 21);
			arg_167C_0.Size = size;
			this.txt_mablagh.TabIndex = 2;
			this.txt_mablagh.TabStop = false;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(928, 510);
			this.ClientSize = size;
			this.Controls.Add(this.RibbonStatusBar1);
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.txt_mablagh);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_PardakhtMoshtari";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "پرداخت به مشتری";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000D9A RID: 3482
		private global::System.ComponentModel.IContainer components;
	}
}
