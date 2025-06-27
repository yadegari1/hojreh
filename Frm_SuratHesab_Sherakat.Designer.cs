namespace FruitBox
{
	// Token: 0x02000151 RID: 337
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_SuratHesab_Sherakat : global::System.Windows.Forms.Form
	{
		// Token: 0x060032BD RID: 12989 RVA: 0x0024DD94 File Offset: 0x0024BF94
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

		// Token: 0x060032BE RID: 12990 RVA: 0x0024DDE4 File Offset: 0x0024BFE4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_SuratHesab_Sherakat));
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem8 = new global::DevComponents.DotNetBar.ButtonItem();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txt_moshtari = new global::FruitBox.SelectItem(this.components);
			this.txt_mande = new global::Janus.Windows.EditControls.UICheckBox();
			this.txt_ta_tarikh = new global::FruitBox.DateBox2(this.components);
			this.txt_az_tarikh = new global::FruitBox.DateBox2(this.components);
			this.Label3 = new global::System.Windows.Forms.Label();
			this.UiCheckBox2 = new global::Janus.Windows.EditControls.UICheckBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_220_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_220_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_251_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(821, 518);
			arg_251_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_2EF_0 = this.EditBox1;
			location = new global::System.Drawing.Point(411, 145);
			arg_2EF_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_348_0 = this.EditBox1;
			size = new global::System.Drawing.Size(317, 36);
			arg_348_0.Size = size;
			this.EditBox1.TabIndex = 1;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_3D0_0 = this.Label2;
			location = new global::System.Drawing.Point(732, 155);
			arg_3D0_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_3FB_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_3FB_0.Size = size;
			this.Label2.TabIndex = 30;
			this.Label2.Text = "جستجو";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem8
			});
			global::DevComponents.DotNetBar.Bar arg_4A8_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_4A8_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_4D6_0 = this.Bar1;
			size = new global::System.Drawing.Size(821, 41);
			arg_4D6_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 19;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			this.ButtonItem8.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem8.Image = global::FruitBox.My.Resources.Resources.document_attach;
			this.ButtonItem8.Name = "ButtonItem8";
			this.ButtonItem8.Text = "PDF";
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_64F_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 187);
			arg_64F_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_6A7_0 = this.GridEX1;
			size = new global::System.Drawing.Size(815, 331);
			arg_6A7_0.Size = size;
			this.GridEX1.TabIndex = 18;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.Label1);
			this.UiGroupBox2.Controls.Add(this.txt_moshtari);
			this.UiGroupBox2.Controls.Add(this.txt_mande);
			this.UiGroupBox2.Controls.Add(this.txt_ta_tarikh);
			this.UiGroupBox2.Controls.Add(this.txt_az_tarikh);
			this.UiGroupBox2.Controls.Add(this.Label3);
			this.UiGroupBox2.Controls.Add(this.UiCheckBox2);
			global::System.Windows.Forms.Control arg_7FC_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(6, 40);
			arg_7FC_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_82A_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(812, 99);
			arg_82A_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_8AF_0 = this.Label1;
			location = new global::System.Drawing.Point(724, 23);
			arg_8AF_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_8DA_0 = this.Label1;
			size = new global::System.Drawing.Size(61, 19);
			arg_8DA_0.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "مشتری";
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
			column.Caption = "کد مشتری";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "مشتری";
			column2.Name = "Name";
			column2.Size = 65;
			column3.Caption = "منطقه";
			column3.Name = "Shahr";
			column3.Size = 20;
			this.txt_moshtari.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2,
				column3
			});
			global::System.Windows.Forms.Control arg_A6D_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(405, 14);
			arg_A6D_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			this.txt_moshtari.Nullable = true;
			this.txt_moshtari.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_moshtari.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_moshtari.SelectCommand = componentResourceManager.GetString("txt_moshtari.SelectCommand");
			this.txt_moshtari.SelectedRow = null;
			this.txt_moshtari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_AF8_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(317, 36);
			arg_AF8_0.Size = size;
			this.txt_moshtari.TabIndex = 0;
			this.txt_moshtari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_moshtari.Value = null;
			this.txt_moshtari.ValueMember = "ID";
			this.txt_moshtari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_mande.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_mande.BackColor = global::System.Drawing.Color.Transparent;
			this.txt_mande.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_B9B_0 = this.txt_mande;
			location = new global::System.Drawing.Point(283, 19);
			arg_B9B_0.Location = location;
			this.txt_mande.Name = "txt_mande";
			global::System.Windows.Forms.Control arg_BC6_0 = this.txt_mande;
			size = new global::System.Drawing.Size(103, 23);
			arg_BC6_0.Size = size;
			this.txt_mande.TabIndex = 3;
			this.txt_mande.Text = "مانده از قبل";
			this.txt_ta_tarikh.AcceptEnter = true;
			this.txt_ta_tarikh.AllowEdit = true;
			this.txt_ta_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_ta_tarikh.ButtonEnable = true;
			this.txt_ta_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_ta_tarikh.Enabled = false;
			this.txt_ta_tarikh.FocusDatePart = 2;
			this.txt_ta_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_C7F_0 = this.txt_ta_tarikh;
			location = new global::System.Drawing.Point(405, 56);
			arg_C7F_0.Location = location;
			this.txt_ta_tarikh.Mask = "0000/00/00";
			this.txt_ta_tarikh.Name = "txt_ta_tarikh";
			this.txt_ta_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_CC8_0 = this.txt_ta_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_CC8_0.Size = size;
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
			global::System.Windows.Forms.Control arg_D8E_0 = this.txt_az_tarikh;
			location = new global::System.Drawing.Point(607, 56);
			arg_D8E_0.Location = location;
			this.txt_az_tarikh.Mask = "0000/00/00";
			this.txt_az_tarikh.Name = "txt_az_tarikh";
			this.txt_az_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_DD7_0 = this.txt_az_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_DD7_0.Size = size;
			this.txt_az_tarikh.TabIndex = 2;
			this.txt_az_tarikh.Text = "1392/10/02";
			this.txt_az_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_E6D_0 = this.Label3;
			location = new global::System.Drawing.Point(526, 67);
			arg_E6D_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_E98_0 = this.Label3;
			size = new global::System.Drawing.Size(53, 19);
			arg_E98_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "تا تاریخ";
			this.UiCheckBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiCheckBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.UiCheckBox2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_F14_0 = this.UiCheckBox2;
			location = new global::System.Drawing.Point(716, 63);
			arg_F14_0.Location = location;
			this.UiCheckBox2.Name = "UiCheckBox2";
			global::System.Windows.Forms.Control arg_F3F_0 = this.UiCheckBox2;
			size = new global::System.Drawing.Size(70, 23);
			arg_F3F_0.Size = size;
			this.UiCheckBox2.TabIndex = 3;
			this.UiCheckBox2.Text = "از تاریخ";
			this.Timer1.Enabled = true;
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
			this.Name = "Frm_SuratHesab_Sherakat";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "صورتحساب شراکت";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040013B2 RID: 5042
		private global::System.ComponentModel.IContainer components;
	}
}
