﻿namespace FruitBox
{
	// Token: 0x020000D5 RID: 213
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_PardakhtKonande : global::System.Windows.Forms.Form
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x000C9F9C File Offset: 0x000C819C
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

		// Token: 0x060012D0 RID: 4816 RVA: 0x000C9FEC File Offset: 0x000C81EC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_tarikh = new global::FruitBox.DateBox2(this.components);
			this.txt_address = new global::FruitBox.EditBox(this.components);
			this.txt_tel = new global::FruitBox.EditBox(this.components);
			this.txt_codeposti = new global::FruitBox.EditBox(this.components);
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txt_namepedar = new global::FruitBox.EditBox(this.components);
			this.txt_shsh = new global::FruitBox.EditBox(this.components);
			this.txt_codemelli = new global::FruitBox.EditBox(this.components);
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txt_name = new global::FruitBox.EditBox(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.EditBox3 = new global::FruitBox.EditBox(this.components);
			this.EditBox4 = new global::FruitBox.EditBox(this.components);
			this.EditBox5 = new global::FruitBox.EditBox(this.components);
			this.EditBox6 = new global::FruitBox.EditBox(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_tarikh);
			this.UiGroupBox1.Controls.Add(this.txt_address);
			this.UiGroupBox1.Controls.Add(this.txt_tel);
			this.UiGroupBox1.Controls.Add(this.txt_codeposti);
			this.UiGroupBox1.Controls.Add(this.Label7);
			this.UiGroupBox1.Controls.Add(this.Label8);
			this.UiGroupBox1.Controls.Add(this.Label6);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.txt_namepedar);
			this.UiGroupBox1.Controls.Add(this.txt_shsh);
			this.UiGroupBox1.Controls.Add(this.txt_codemelli);
			this.UiGroupBox1.Controls.Add(this.Label5);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.txt_name);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_354_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 41);
			arg_354_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_391_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(469, 377);
			arg_391_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_tarikh.AcceptEnter = true;
			this.txt_tarikh.AllowEdit = true;
			this.txt_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tarikh.ButtonEnable = true;
			this.txt_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_tarikh.FocusDatePart = 2;
			this.txt_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_43B_0 = this.txt_tarikh;
			location = new global::System.Drawing.Point(212, 300);
			arg_43B_0.Location = location;
			this.txt_tarikh.Mask = "0000/00/00";
			this.txt_tarikh.Name = "txt_tarikh";
			this.txt_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_483_0 = this.txt_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_483_0.Size = size;
			this.txt_tarikh.TabIndex = 7;
			this.txt_tarikh.Text = "1394/05/14";
			this.txt_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_address.AcceptEnter = true;
			this.txt_address.AllowEdit = true;
			this.txt_address.AllowNew = true;
			this.txt_address.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_address.FocusColor = true;
			this.txt_address.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_52E_0 = this.txt_address;
			location = new global::System.Drawing.Point(68, 257);
			arg_52E_0.Location = location;
			this.txt_address.Name = "txt_address";
			this.txt_address.Nullable = true;
			this.txt_address.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_address.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_586_0 = this.txt_address;
			size = new global::System.Drawing.Size(259, 36);
			arg_586_0.Size = size;
			this.txt_address.TabIndex = 6;
			this.txt_address.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_tel.AcceptEnter = true;
			this.txt_tel.AllowEdit = true;
			this.txt_tel.AllowNew = true;
			this.txt_tel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tel.FocusColor = true;
			this.txt_tel.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_620_0 = this.txt_tel;
			location = new global::System.Drawing.Point(68, 215);
			arg_620_0.Location = location;
			this.txt_tel.Name = "txt_tel";
			this.txt_tel.Nullable = true;
			this.txt_tel.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_tel.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_678_0 = this.txt_tel;
			size = new global::System.Drawing.Size(259, 36);
			arg_678_0.Size = size;
			this.txt_tel.TabIndex = 5;
			this.txt_tel.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_codeposti.AcceptEnter = true;
			this.txt_codeposti.AllowEdit = true;
			this.txt_codeposti.AllowNew = true;
			this.txt_codeposti.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_codeposti.FocusColor = true;
			this.txt_codeposti.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_712_0 = this.txt_codeposti;
			location = new global::System.Drawing.Point(68, 131);
			arg_712_0.Location = location;
			this.txt_codeposti.Name = "txt_codeposti";
			this.txt_codeposti.Nullable = true;
			this.txt_codeposti.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_codeposti.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_76A_0 = this.txt_codeposti;
			size = new global::System.Drawing.Size(259, 36);
			arg_76A_0.Size = size;
			this.txt_codeposti.TabIndex = 3;
			this.txt_codeposti.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label7.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label7.AutoSize = true;
			this.Label7.BackColor = global::System.Drawing.Color.Transparent;
			this.Label7.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label7.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_802_0 = this.Label7;
			location = new global::System.Drawing.Point(329, 308);
			arg_802_0.Location = location;
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control arg_82C_0 = this.Label7;
			size = new global::System.Drawing.Size(69, 19);
			arg_82C_0.Size = size;
			this.Label7.TabIndex = 0;
			this.Label7.Text = "تاریخ تولد";
			this.Label8.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label8.AutoSize = true;
			this.Label8.BackColor = global::System.Drawing.Color.Transparent;
			this.Label8.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label8.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_8C8_0 = this.Label8;
			location = new global::System.Drawing.Point(329, 267);
			arg_8C8_0.Location = location;
			this.Label8.Name = "Label8";
			global::System.Windows.Forms.Control arg_8F2_0 = this.Label8;
			size = new global::System.Drawing.Size(45, 19);
			arg_8F2_0.Size = size;
			this.Label8.TabIndex = 0;
			this.Label8.Text = "آدرس";
			this.Label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Transparent;
			this.Label6.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label6.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_98E_0 = this.Label6;
			location = new global::System.Drawing.Point(329, 224);
			arg_98E_0.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control arg_9B8_0 = this.Label6;
			size = new global::System.Drawing.Size(39, 19);
			arg_9B8_0.Size = size;
			this.Label6.TabIndex = 0;
			this.Label6.Text = "تلفن";
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_A54_0 = this.Label4;
			location = new global::System.Drawing.Point(329, 142);
			arg_A54_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_A7E_0 = this.Label4;
			size = new global::System.Drawing.Size(69, 19);
			arg_A7E_0.Size = size;
			this.Label4.TabIndex = 0;
			this.Label4.Text = "کدپستی";
			this.txt_namepedar.AcceptEnter = true;
			this.txt_namepedar.AllowEdit = true;
			this.txt_namepedar.AllowNew = true;
			this.txt_namepedar.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_namepedar.FocusColor = true;
			this.txt_namepedar.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_B19_0 = this.txt_namepedar;
			location = new global::System.Drawing.Point(68, 48);
			arg_B19_0.Location = location;
			this.txt_namepedar.Name = "txt_namepedar";
			this.txt_namepedar.Nullable = true;
			this.txt_namepedar.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_namepedar.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_B71_0 = this.txt_namepedar;
			size = new global::System.Drawing.Size(259, 36);
			arg_B71_0.Size = size;
			this.txt_namepedar.TabIndex = 1;
			this.txt_namepedar.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_shsh.AcceptEnter = true;
			this.txt_shsh.AllowEdit = true;
			this.txt_shsh.AllowNew = true;
			this.txt_shsh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_shsh.FocusColor = true;
			this.txt_shsh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_C0B_0 = this.txt_shsh;
			location = new global::System.Drawing.Point(68, 173);
			arg_C0B_0.Location = location;
			this.txt_shsh.Name = "txt_shsh";
			this.txt_shsh.Nullable = true;
			this.txt_shsh.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_shsh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_C63_0 = this.txt_shsh;
			size = new global::System.Drawing.Size(259, 36);
			arg_C63_0.Size = size;
			this.txt_shsh.TabIndex = 4;
			this.txt_shsh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_codemelli.AcceptEnter = true;
			this.txt_codemelli.AllowEdit = true;
			this.txt_codemelli.AllowNew = true;
			this.txt_codemelli.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_codemelli.FocusColor = true;
			this.txt_codemelli.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_CFA_0 = this.txt_codemelli;
			location = new global::System.Drawing.Point(68, 90);
			arg_CFA_0.Location = location;
			this.txt_codemelli.Name = "txt_codemelli";
			this.txt_codemelli.Nullable = true;
			this.txt_codemelli.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_codemelli.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_D52_0 = this.txt_codemelli;
			size = new global::System.Drawing.Size(259, 36);
			arg_D52_0.Size = size;
			this.txt_codemelli.TabIndex = 2;
			this.txt_codemelli.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			this.Label5.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label5.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_DEA_0 = this.Label5;
			location = new global::System.Drawing.Point(329, 182);
			arg_DEA_0.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control arg_E17_0 = this.Label5;
			size = new global::System.Drawing.Size(130, 19);
			arg_E17_0.Size = size;
			this.Label5.TabIndex = 0;
			this.Label5.Text = "شماره شناسنامه";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_EB0_0 = this.Label2;
			location = new global::System.Drawing.Point(330, 58);
			arg_EB0_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_EDA_0 = this.Label2;
			size = new global::System.Drawing.Size(51, 19);
			arg_EDA_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "نام پدر";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_F73_0 = this.Label3;
			location = new global::System.Drawing.Point(329, 100);
			arg_F73_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_F9D_0 = this.Label3;
			size = new global::System.Drawing.Size(56, 19);
			arg_F9D_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "کدملی";
			this.txt_name.AcceptEnter = true;
			this.txt_name.AllowEdit = true;
			this.txt_name.AllowNew = true;
			this.txt_name.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_name.FocusColor = true;
			this.txt_name.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_1037_0 = this.txt_name;
			location = new global::System.Drawing.Point(68, 6);
			arg_1037_0.Location = location;
			this.txt_name.Name = "txt_name";
			this.txt_name.Nullable = false;
			this.txt_name.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.txt_name.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_108F_0 = this.txt_name;
			size = new global::System.Drawing.Size(259, 36);
			arg_108F_0.Size = size;
			this.txt_name.TabIndex = 0;
			this.txt_name.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_1124_0 = this.Label1;
			location = new global::System.Drawing.Point(329, 16);
			arg_1124_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_1151_0 = this.Label1;
			size = new global::System.Drawing.Size(129, 19);
			arg_1151_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "نام و نام خانوادگی";
			this.EditBox3.AcceptEnter = true;
			this.EditBox3.AllowEdit = true;
			this.EditBox3.AllowNew = true;
			this.EditBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox3.FocusColor = true;
			this.EditBox3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_11EC_0 = this.EditBox3;
			location = new global::System.Drawing.Point(93, 57);
			arg_11EC_0.Location = location;
			this.EditBox3.Name = "EditBox3";
			this.EditBox3.Nullable = true;
			this.EditBox3.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.EditBox3.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1244_0 = this.EditBox3;
			size = new global::System.Drawing.Size(259, 23);
			arg_1244_0.Size = size;
			this.EditBox3.TabIndex = 1;
			this.EditBox3.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox4.AcceptEnter = true;
			this.EditBox4.AllowEdit = true;
			this.EditBox4.AllowNew = true;
			this.EditBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox4.FocusColor = true;
			this.EditBox4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_12DE_0 = this.EditBox4;
			location = new global::System.Drawing.Point(93, 144);
			arg_12DE_0.Location = location;
			this.EditBox4.Name = "EditBox4";
			this.EditBox4.Nullable = true;
			this.EditBox4.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.EditBox4.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1336_0 = this.EditBox4;
			size = new global::System.Drawing.Size(259, 23);
			arg_1336_0.Size = size;
			this.EditBox4.TabIndex = 3;
			this.EditBox4.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox5.AcceptEnter = true;
			this.EditBox5.AllowEdit = true;
			this.EditBox5.AllowNew = true;
			this.EditBox5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox5.FocusColor = true;
			this.EditBox5.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_13CD_0 = this.EditBox5;
			location = new global::System.Drawing.Point(93, 86);
			arg_13CD_0.Location = location;
			this.EditBox5.Name = "EditBox5";
			this.EditBox5.Nullable = true;
			this.EditBox5.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.EditBox5.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1425_0 = this.EditBox5;
			size = new global::System.Drawing.Size(259, 23);
			arg_1425_0.Size = size;
			this.EditBox5.TabIndex = 2;
			this.EditBox5.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox6.AcceptEnter = true;
			this.EditBox6.AllowEdit = true;
			this.EditBox6.AllowNew = true;
			this.EditBox6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox6.FocusColor = true;
			this.EditBox6.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_14BC_0 = this.EditBox6;
			location = new global::System.Drawing.Point(93, 26);
			arg_14BC_0.Location = location;
			this.EditBox6.Name = "EditBox6";
			this.EditBox6.Nullable = false;
			this.EditBox6.NullToolTipText = "عنوان کالا را وارد نمائید";
			this.EditBox6.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1514_0 = this.EditBox6;
			size = new global::System.Drawing.Size(259, 23);
			arg_1514_0.Size = size;
			this.EditBox6.TabIndex = 0;
			this.EditBox6.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_15B9_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_15B9_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_15E6_0 = this.Bar1;
			size = new global::System.Drawing.Size(469, 41);
			arg_15E6_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 15;
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
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.bin_closed;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف (F5)";
			this.ButtonItem3.Visible = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(469, 418);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_PardakhtKonande";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تعریف پرداخت کننده";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000742 RID: 1858
		private global::System.ComponentModel.IContainer components;
	}
}
