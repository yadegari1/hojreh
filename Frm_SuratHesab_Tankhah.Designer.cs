namespace FruitBox
{
	// Token: 0x02000155 RID: 341
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_SuratHesab_Tankhah : global::System.Windows.Forms.Form
	{
		// Token: 0x06003380 RID: 13184 RVA: 0x00254B78 File Offset: 0x00252D78
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

		// Token: 0x06003381 RID: 13185 RVA: 0x00254BC8 File Offset: 0x00252DC8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_SuratHesab_Tankhah));
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiCheckBox2 = new global::Janus.Windows.EditControls.UICheckBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txt_moshtari = new global::FruitBox.SelectItem(this.components);
			this.SelectItem1 = new global::FruitBox.SelectItem(this.components);
			this.txt_ta_tarikh = new global::FruitBox.DateBox2(this.components);
			this.txt_az_tarikh = new global::FruitBox.DateBox2(this.components);
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_moshtari);
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_248_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_248_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_279_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(821, 518);
			arg_279_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiGroupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.SelectItem1);
			this.UiGroupBox2.Controls.Add(this.UiCheckBox2);
			this.UiGroupBox2.Controls.Add(this.txt_ta_tarikh);
			this.UiGroupBox2.Controls.Add(this.Label1);
			this.UiGroupBox2.Controls.Add(this.txt_az_tarikh);
			this.UiGroupBox2.Controls.Add(this.Label3);
			this.UiGroupBox2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_373_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(3, 47);
			arg_373_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_39E_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(121, 51);
			arg_39E_0.Size = size;
			this.UiGroupBox2.TabIndex = 1;
			this.UiGroupBox2.Visible = false;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiCheckBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiCheckBox2.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_3FE_0 = this.UiCheckBox2;
			location = new global::System.Drawing.Point(29, 16);
			arg_3FE_0.Location = location;
			this.UiCheckBox2.Name = "UiCheckBox2";
			global::System.Windows.Forms.Control arg_429_0 = this.UiCheckBox2;
			size = new global::System.Drawing.Size(79, 23);
			arg_429_0.Size = size;
			this.UiCheckBox2.TabIndex = 0;
			this.UiCheckBox2.Text = "از تاریخ";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4B2_0 = this.Label1;
			location = new global::System.Drawing.Point(-337, 17);
			arg_4B2_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_4DD_0 = this.Label1;
			size = new global::System.Drawing.Size(46, 19);
			arg_4DD_0.Size = size;
			this.Label1.TabIndex = 32;
			this.Label1.Text = "هزینه";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_545_0 = this.Label3;
			location = new global::System.Drawing.Point(-149, 16);
			arg_545_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_570_0 = this.Label3;
			size = new global::System.Drawing.Size(53, 19);
			arg_570_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "تا تاریخ";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5F9_0 = this.Label2;
			location = new global::System.Drawing.Point(725, 101);
			arg_5F9_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_624_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_624_0.Size = size;
			this.Label2.TabIndex = 32;
			this.Label2.Text = "جستجو";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_6C6_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_6C6_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_6F4_0 = this.Bar1;
			size = new global::System.Drawing.Size(821, 41);
			arg_6F4_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 20;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			this.Timer1.Enabled = true;
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_7F2_0 = this.Label4;
			location = new global::System.Drawing.Point(725, 60);
			arg_7F2_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_81D_0 = this.Label4;
			size = new global::System.Drawing.Size(91, 19);
			arg_81D_0.Size = size;
			this.Label4.TabIndex = 32;
			this.Label4.Text = "تنخواه گردان";
			this.txt_moshtari.AcceptEnter = false;
			this.txt_moshtari.AddNewForm = null;
			this.txt_moshtari.AllowEdit = true;
			this.txt_moshtari.AllowNew = true;
			this.txt_moshtari.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_moshtari.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_moshtari.ButtonText = "...";
			this.txt_moshtari.CanEdit = true;
			this.txt_moshtari.DisplayMember = "Name";
			this.txt_moshtari.Edit_Frm = null;
			this.txt_moshtari.ExtraData = 0L;
			this.txt_moshtari.FocusColor = true;
			this.txt_moshtari.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "Code";
			column.Size = 15;
			column2.Caption = "مشتری";
			column2.Name = "Name";
			column2.Size = 65;
			this.txt_moshtari.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2
			});
			global::System.Windows.Forms.Control arg_98A_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(428, 50);
			arg_98A_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			this.txt_moshtari.Nullable = true;
			this.txt_moshtari.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_moshtari.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_moshtari.SelectCommand = componentResourceManager.GetString("txt_moshtari.SelectCommand");
			this.txt_moshtari.SelectedRow = null;
			this.txt_moshtari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_A15_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(295, 36);
			arg_A15_0.Size = size;
			this.txt_moshtari.TabIndex = 33;
			this.txt_moshtari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_moshtari.Value = null;
			this.txt_moshtari.ValueMember = "ID";
			this.txt_moshtari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.SelectItem1.AcceptEnter = true;
			this.SelectItem1.AddNewForm = null;
			this.SelectItem1.AllowEdit = true;
			this.SelectItem1.AllowNew = true;
			this.SelectItem1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SelectItem1.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.SelectItem1.ButtonText = "...";
			this.SelectItem1.CanEdit = false;
			this.SelectItem1.DisplayMember = "Name";
			this.SelectItem1.Edit_Frm = null;
			this.SelectItem1.ExtraData = 0L;
			this.SelectItem1.FocusColor = true;
			this.SelectItem1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column3.Caption = "عنوان";
			column3.Name = "Name";
			column3.Size = 100;
			this.SelectItem1.Items.AddRange(new global::FruitBox.Column[]
			{
				column3
			});
			global::System.Windows.Forms.Control arg_B82_0 = this.SelectItem1;
			location = new global::System.Drawing.Point(-538, 11);
			arg_B82_0.Location = location;
			this.SelectItem1.Name = "SelectItem1";
			this.SelectItem1.Nullable = true;
			this.SelectItem1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.SelectItem1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.SelectItem1.SelectCommand = "select * from hazine";
			this.SelectItem1.SelectedRow = null;
			this.SelectItem1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_C06_0 = this.SelectItem1;
			size = new global::System.Drawing.Size(195, 36);
			arg_C06_0.Size = size;
			this.SelectItem1.TabIndex = 33;
			this.SelectItem1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.SelectItem1.Value = null;
			this.SelectItem1.ValueMember = "ID";
			this.SelectItem1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_ta_tarikh.AcceptEnter = true;
			this.txt_ta_tarikh.AllowEdit = true;
			this.txt_ta_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_ta_tarikh.ButtonEnable = true;
			this.txt_ta_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_ta_tarikh.Enabled = false;
			this.txt_ta_tarikh.FocusDatePart = 2;
			this.txt_ta_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_CE7_0 = this.txt_ta_tarikh;
			location = new global::System.Drawing.Point(-270, 11);
			arg_CE7_0.Location = location;
			this.txt_ta_tarikh.Mask = "0000/00/00";
			this.txt_ta_tarikh.Name = "txt_ta_tarikh";
			this.txt_ta_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_D30_0 = this.txt_ta_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_D30_0.Size = size;
			this.txt_ta_tarikh.TabIndex = 2;
			this.txt_ta_tarikh.Text = "1392/10/02";
			this.txt_ta_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_az_tarikh.AcceptEnter = true;
			this.txt_az_tarikh.AllowEdit = true;
			this.txt_az_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_az_tarikh.ButtonEnable = true;
			this.txt_az_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_az_tarikh.Enabled = false;
			this.txt_az_tarikh.FocusDatePart = 2;
			this.txt_az_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_DF3_0 = this.txt_az_tarikh;
			location = new global::System.Drawing.Point(-90, 11);
			arg_DF3_0.Location = location;
			this.txt_az_tarikh.Mask = "0000/00/00";
			this.txt_az_tarikh.Name = "txt_az_tarikh";
			this.txt_az_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_E3C_0 = this.txt_az_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_E3C_0.Size = size;
			this.txt_az_tarikh.TabIndex = 1;
			this.txt_az_tarikh.Text = "1392/10/02";
			this.txt_az_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_EE8_0 = this.EditBox1;
			location = new global::System.Drawing.Point(428, 91);
			arg_EE8_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_F41_0 = this.EditBox1;
			size = new global::System.Drawing.Size(295, 36);
			arg_F41_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_100E_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 133);
			arg_100E_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_1066_0 = this.GridEX1;
			size = new global::System.Drawing.Size(821, 385);
			arg_1066_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(821, 518);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_SuratHesab_Tankhah";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "صورتحساب تنخواه";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040013FB RID: 5115
		private global::System.ComponentModel.IContainer components;
	}
}
