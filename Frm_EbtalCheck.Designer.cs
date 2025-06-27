namespace FruitBox
{
	// Token: 0x020000EC RID: 236
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_EbtalCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x00118B98 File Offset: 0x00116D98
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

		// Token: 0x060018E6 RID: 6374 RVA: 0x00118BE8 File Offset: 0x00116DE8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_EbtalCheck));
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			global::FruitBox.Column column4 = new global::FruitBox.Column();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_tozih = new global::FruitBox.EditBox(this.components);
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txt_checkbarg = new global::FruitBox.SelectItem(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txt_dastecheck = new global::FruitBox.SelectItem(this.components);
			this.txt_hesabbank = new global::FruitBox.SelectItem(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.txt_tozih);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.txt_checkbarg);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.txt_dastecheck);
			this.UiGroupBox1.Controls.Add(this.txt_hesabbank);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_24C_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_24C_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_27D_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(578, 523);
			arg_27D_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_325_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_325_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_353_0 = this.Bar1;
			size = new global::System.Drawing.Size(578, 41);
			arg_353_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.list1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "لیست چک های ابطالی";
			this.txt_tozih.AcceptEnter = true;
			this.txt_tozih.AllowEdit = true;
			this.txt_tozih.AllowNew = true;
			this.txt_tozih.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tozih.FocusColor = true;
			this.txt_tozih.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_49A_0 = this.txt_tozih;
			location = new global::System.Drawing.Point(11, 180);
			arg_49A_0.Location = location;
			this.txt_tozih.Name = "txt_tozih";
			this.txt_tozih.Nullable = true;
			this.txt_tozih.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_tozih.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_4F3_0 = this.txt_tozih;
			size = new global::System.Drawing.Size(471, 36);
			arg_4F3_0.Size = size;
			this.txt_tozih.TabIndex = 5;
			this.txt_tozih.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_57B_0 = this.Label4;
			location = new global::System.Drawing.Point(484, 189);
			arg_57B_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_5A6_0 = this.Label4;
			size = new global::System.Drawing.Size(67, 19);
			arg_5A6_0.Size = size;
			this.Label4.TabIndex = 4;
			this.Label4.Text = "توضیحات";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_632_0 = this.Label3;
			location = new global::System.Drawing.Point(484, 147);
			arg_632_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_65D_0 = this.Label3;
			size = new global::System.Drawing.Size(85, 19);
			arg_65D_0.Size = size;
			this.Label3.TabIndex = 4;
			this.Label3.Text = "شماره چک";
			this.txt_checkbarg.AcceptEnter = true;
			this.txt_checkbarg.AddNewForm = null;
			this.txt_checkbarg.AllowEdit = true;
			this.txt_checkbarg.AllowNew = true;
			this.txt_checkbarg.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_checkbarg.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_checkbarg.ButtonText = "...";
			this.txt_checkbarg.CanEdit = false;
			this.txt_checkbarg.DisplayMember = "ShomareBarg";
			this.txt_checkbarg.Edit_Frm = null;
			this.txt_checkbarg.ExtraData = 0L;
			this.txt_checkbarg.FocusColor = true;
			this.txt_checkbarg.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "شماره برگ";
			column.Name = "ShomareBarg";
			column.Size = 100;
			this.txt_checkbarg.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_7A2_0 = this.txt_checkbarg;
			location = new global::System.Drawing.Point(11, 138);
			arg_7A2_0.Location = location;
			this.txt_checkbarg.Name = "txt_checkbarg";
			this.txt_checkbarg.Nullable = true;
			this.txt_checkbarg.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_checkbarg.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_checkbarg.SelectCommand = null;
			this.txt_checkbarg.SelectedRow = null;
			this.txt_checkbarg.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_822_0 = this.txt_checkbarg;
			size = new global::System.Drawing.Size(471, 36);
			arg_822_0.Size = size;
			this.txt_checkbarg.TabIndex = 3;
			this.txt_checkbarg.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_checkbarg.Value = null;
			this.txt_checkbarg.ValueMember = "ID";
			this.txt_checkbarg.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
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
			this.GridEX1.HideSelection = global::Janus.Windows.GridEX.HideSelection.Highlight;
			global::System.Windows.Forms.Control arg_936_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 341);
			arg_936_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_98E_0 = this.GridEX1;
			size = new global::System.Drawing.Size(572, 179);
			arg_98E_0.Size = size;
			this.GridEX1.TabIndex = 2;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.Visible = false;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A6B_0 = this.Label2;
			location = new global::System.Drawing.Point(484, 105);
			arg_A6B_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_A96_0 = this.Label2;
			size = new global::System.Drawing.Size(78, 19);
			arg_A96_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "دسته چک";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_B1F_0 = this.Label1;
			location = new global::System.Drawing.Point(484, 64);
			arg_B1F_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_B4A_0 = this.Label1;
			size = new global::System.Drawing.Size(98, 19);
			arg_B4A_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "حساب بانکی";
			this.txt_dastecheck.AcceptEnter = true;
			this.txt_dastecheck.AddNewForm = null;
			this.txt_dastecheck.AllowEdit = true;
			this.txt_dastecheck.AllowNew = true;
			this.txt_dastecheck.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_dastecheck.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_dastecheck.ButtonText = "...";
			this.txt_dastecheck.CanEdit = false;
			this.txt_dastecheck.DisplayMember = "ShomareBarg";
			this.txt_dastecheck.Edit_Frm = null;
			this.txt_dastecheck.ExtraData = 0L;
			this.txt_dastecheck.FocusColor = true;
			this.txt_dastecheck.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column2.Caption = "شماره برگ";
			column2.Name = "ShomareBarg";
			column2.Size = 100;
			this.txt_dastecheck.Items.AddRange(new global::FruitBox.Column[]
			{
				column2
			});
			global::System.Windows.Forms.Control arg_C8C_0 = this.txt_dastecheck;
			location = new global::System.Drawing.Point(11, 96);
			arg_C8C_0.Location = location;
			this.txt_dastecheck.Name = "txt_dastecheck";
			this.txt_dastecheck.Nullable = true;
			this.txt_dastecheck.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_dastecheck.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_dastecheck.SelectCommand = null;
			this.txt_dastecheck.SelectedRow = null;
			this.txt_dastecheck.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_D0C_0 = this.txt_dastecheck;
			size = new global::System.Drawing.Size(471, 36);
			arg_D0C_0.Size = size;
			this.txt_dastecheck.TabIndex = 1;
			this.txt_dastecheck.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_dastecheck.Value = null;
			this.txt_dastecheck.ValueMember = "ID";
			this.txt_dastecheck.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_hesabbank.AcceptEnter = true;
			this.txt_hesabbank.AddNewForm = null;
			this.txt_hesabbank.AllowEdit = true;
			this.txt_hesabbank.AllowNew = true;
			this.txt_hesabbank.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_hesabbank.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_hesabbank.ButtonText = "...";
			this.txt_hesabbank.CanEdit = false;
			this.txt_hesabbank.DisplayMember = "Name";
			this.txt_hesabbank.Edit_Frm = null;
			this.txt_hesabbank.ExtraData = 0L;
			this.txt_hesabbank.FocusColor = true;
			this.txt_hesabbank.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column3.Caption = "کد";
			column3.Name = "ID";
			column3.Size = 20;
			column4.Caption = "حساب بانکی";
			column4.Name = "Name";
			column4.Size = 80;
			this.txt_hesabbank.Items.AddRange(new global::FruitBox.Column[]
			{
				column3,
				column4
			});
			global::System.Windows.Forms.Control arg_E9C_0 = this.txt_hesabbank;
			location = new global::System.Drawing.Point(11, 54);
			arg_E9C_0.Location = location;
			this.txt_hesabbank.Name = "txt_hesabbank";
			this.txt_hesabbank.Nullable = true;
			this.txt_hesabbank.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_hesabbank.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_hesabbank.SelectCommand = null;
			this.txt_hesabbank.SelectedRow = null;
			this.txt_hesabbank.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_F1C_0 = this.txt_hesabbank;
			size = new global::System.Drawing.Size(471, 36);
			arg_F1C_0.Size = size;
			this.txt_hesabbank.TabIndex = 0;
			this.txt_hesabbank.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_hesabbank.Value = null;
			this.txt_hesabbank.ValueMember = "ID";
			this.txt_hesabbank.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(578, 523);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_EbtalCheck";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ابطال چک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040009B3 RID: 2483
		private global::System.ComponentModel.IContainer components;
	}
}
