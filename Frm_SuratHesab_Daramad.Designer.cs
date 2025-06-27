namespace FruitBox
{
	// Token: 0x02000142 RID: 322
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_SuratHesab_Daramad : global::System.Windows.Forms.Form
	{
		// Token: 0x06002F20 RID: 12064 RVA: 0x0022BD2C File Offset: 0x00229F2C
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

		// Token: 0x06002F21 RID: 12065 RVA: 0x0022BD7C File Offset: 0x00229F7C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_SuratHesab_Daramad));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_mande = new global::Janus.Windows.EditControls.UICheckBox();
			this.UiCheckBox2 = new global::Janus.Windows.EditControls.UICheckBox();
			this.txt_ta_tarikh = new global::FruitBox.DateBox2(this.components);
			this.txt_az_tarikh = new global::FruitBox.DateBox2(this.components);
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
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
			global::System.Windows.Forms.Control arg_1D6_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1D6_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_207_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(821, 518);
			arg_207_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_2A1_0 = this.EditBox1;
			location = new global::System.Drawing.Point(427, 97);
			arg_2A1_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_2FA_0 = this.EditBox1;
			size = new global::System.Drawing.Size(301, 36);
			arg_2FA_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_37E_0 = this.Label2;
			location = new global::System.Drawing.Point(732, 107);
			arg_37E_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_3A9_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_3A9_0.Size = size;
			this.Label2.TabIndex = 30;
			this.Label2.Text = "جستجو";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_44A_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_44A_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_478_0 = this.Bar1;
			size = new global::System.Drawing.Size(821, 41);
			arg_478_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 19;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
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
			global::System.Windows.Forms.Control arg_5AF_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 139);
			arg_5AF_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_607_0 = this.GridEX1;
			size = new global::System.Drawing.Size(815, 379);
			arg_607_0.Size = size;
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
			this.UiGroupBox2.Controls.Add(this.txt_mande);
			this.UiGroupBox2.Controls.Add(this.UiCheckBox2);
			this.UiGroupBox2.Controls.Add(this.txt_ta_tarikh);
			this.UiGroupBox2.Controls.Add(this.txt_az_tarikh);
			this.UiGroupBox2.Controls.Add(this.Label3);
			global::System.Windows.Forms.Control arg_72D_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(6, 40);
			arg_72D_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_75B_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(812, 51);
			arg_75B_0.Size = size;
			this.UiGroupBox2.TabIndex = 1;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_mande.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_mande.BackColor = global::System.Drawing.Color.Transparent;
			this.txt_mande.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_7D2_0 = this.txt_mande;
			location = new global::System.Drawing.Point(302, 18);
			arg_7D2_0.Location = location;
			this.txt_mande.Name = "txt_mande";
			global::System.Windows.Forms.Control arg_7FD_0 = this.txt_mande;
			size = new global::System.Drawing.Size(103, 23);
			arg_7FD_0.Size = size;
			this.txt_mande.TabIndex = 3;
			this.txt_mande.Text = "مانده از قبل";
			this.UiCheckBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiCheckBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.UiCheckBox2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_878_0 = this.UiCheckBox2;
			location = new global::System.Drawing.Point(725, 18);
			arg_878_0.Location = location;
			this.UiCheckBox2.Name = "UiCheckBox2";
			global::System.Windows.Forms.Control arg_8A3_0 = this.UiCheckBox2;
			size = new global::System.Drawing.Size(73, 23);
			arg_8A3_0.Size = size;
			this.UiCheckBox2.TabIndex = 3;
			this.UiCheckBox2.Text = "از تاریخ";
			this.txt_ta_tarikh.AcceptEnter = true;
			this.txt_ta_tarikh.AllowEdit = true;
			this.txt_ta_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_ta_tarikh.ButtonEnable = true;
			this.txt_ta_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_ta_tarikh.Enabled = false;
			this.txt_ta_tarikh.FocusDatePart = 2;
			this.txt_ta_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_95B_0 = this.txt_ta_tarikh;
			location = new global::System.Drawing.Point(421, 11);
			arg_95B_0.Location = location;
			this.txt_ta_tarikh.Mask = "0000/00/00";
			this.txt_ta_tarikh.Name = "txt_ta_tarikh";
			this.txt_ta_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_9A4_0 = this.txt_ta_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_9A4_0.Size = size;
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
			global::System.Windows.Forms.Control arg_A69_0 = this.txt_az_tarikh;
			location = new global::System.Drawing.Point(607, 11);
			arg_A69_0.Location = location;
			this.txt_az_tarikh.Mask = "0000/00/00";
			this.txt_az_tarikh.Name = "txt_az_tarikh";
			this.txt_az_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_AB2_0 = this.txt_az_tarikh;
			size = new global::System.Drawing.Size(115, 36);
			arg_AB2_0.Size = size;
			this.txt_az_tarikh.TabIndex = 2;
			this.txt_az_tarikh.Text = "1392/10/02";
			this.txt_az_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_B47_0 = this.Label3;
			location = new global::System.Drawing.Point(538, 21);
			arg_B47_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_B72_0 = this.Label3;
			size = new global::System.Drawing.Size(53, 19);
			arg_B72_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "تا تاریخ";
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
			this.Name = "Frm_SuratHesab_Daramad";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "صورتحساب درآمد";
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

		// Token: 0x0400124A RID: 4682
		private global::System.ComponentModel.IContainer components;
	}
}
