namespace FruitBox
{
	// Token: 0x02000111 RID: 273
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sud_Furush : global::System.Windows.Forms.Form
	{
		// Token: 0x0600273D RID: 10045 RVA: 0x001DB37C File Offset: 0x001D957C
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

		// Token: 0x0600273E RID: 10046 RVA: 0x001DB3CC File Offset: 0x001D95CC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sud_Furush));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage");
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiRadioButton2 = new global::Janus.Windows.EditControls.UIRadioButton();
			this.UiRadioButton1 = new global::Janus.Windows.EditControls.UIRadioButton();
			this.txt_karmozd = new global::FruitBox.CurrencyBox(this.components);
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			this.txt_sanad = new global::FruitBox.NumericBox(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_darsad = new global::FruitBox.NumericBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txt_darsad2 = new global::FruitBox.NumericBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiRadioButton2);
			this.UiGroupBox1.Controls.Add(this.UiRadioButton1);
			this.UiGroupBox1.Controls.Add(this.txt_karmozd);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.txt_mablagh);
			this.UiGroupBox1.Controls.Add(this.txt_sanad);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.txt_darsad);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.Label5);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.txt_darsad2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_2DA_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_2DA_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_30B_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(653, 434);
			arg_30B_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiRadioButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiRadioButton2.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_364_0 = this.UiRadioButton2;
			location = new global::System.Drawing.Point(311, 133);
			arg_364_0.Location = location;
			this.UiRadioButton2.Name = "UiRadioButton2";
			global::System.Windows.Forms.Control arg_38F_0 = this.UiRadioButton2;
			size = new global::System.Drawing.Size(104, 23);
			arg_38F_0.Size = size;
			this.UiRadioButton2.TabIndex = 19;
			this.UiRadioButton2.Text = "از 100 درصد";
			this.UiRadioButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiRadioButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.UiRadioButton1.Checked = true;
			global::System.Windows.Forms.Control arg_3FA_0 = this.UiRadioButton1;
			location = new global::System.Drawing.Point(450, 133);
			arg_3FA_0.Location = location;
			this.UiRadioButton1.Name = "UiRadioButton1";
			global::System.Windows.Forms.Control arg_425_0 = this.UiRadioButton1;
			size = new global::System.Drawing.Size(104, 23);
			arg_425_0.Size = size;
			this.UiRadioButton1.TabIndex = 19;
			this.UiRadioButton1.TabStop = true;
			this.UiRadioButton1.Text = "از درصد صافی";
			this.txt_karmozd.AcceptEnter = true;
			this.txt_karmozd.AllowEdit = false;
			this.txt_karmozd.AllowNew = true;
			this.txt_karmozd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_karmozd.FocusColor = true;
			this.txt_karmozd.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4D2_0 = this.txt_karmozd;
			location = new global::System.Drawing.Point(168, 90);
			arg_4D2_0.Location = location;
			this.txt_karmozd.Name = "txt_karmozd";
			this.txt_karmozd.Nullable = true;
			this.txt_karmozd.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_karmozd.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_52B_0 = this.txt_karmozd;
			size = new global::System.Drawing.Size(156, 36);
			arg_52B_0.Size = size;
			this.txt_karmozd.TabIndex = 18;
			this.txt_karmozd.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_karmozd.Value = value;
			this.txt_karmozd.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5CC_0 = this.Label4;
			location = new global::System.Drawing.Point(330, 98);
			arg_5CC_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_5F7_0 = this.Label4;
			size = new global::System.Drawing.Size(89, 19);
			arg_5F7_0.Size = size;
			this.Label4.TabIndex = 17;
			this.Label4.Text = "کارمزد مانده";
			this.txt_mablagh.AcceptEnter = true;
			this.txt_mablagh.AllowEdit = false;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_mablagh.FocusColor = true;
			this.txt_mablagh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_697_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(168, 48);
			arg_697_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_6F0_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(156, 36);
			arg_6F0_0.Size = size;
			this.txt_mablagh.TabIndex = 16;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_sanad.AcceptEnter = true;
			this.txt_sanad.AllowEdit = false;
			this.txt_sanad.AllowNew = true;
			this.txt_sanad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_sanad.FocusColor = true;
			this.txt_sanad.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_7A7_0 = this.txt_sanad;
			location = new global::System.Drawing.Point(454, 48);
			arg_7A7_0.Location = location;
			this.txt_sanad.Name = "txt_sanad";
			this.txt_sanad.Nullable = true;
			this.txt_sanad.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_sanad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7FD_0 = this.txt_sanad;
			size = new global::System.Drawing.Size(100, 36);
			arg_7FD_0.Size = size;
			this.txt_sanad.TabIndex = 15;
			this.txt_sanad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_sanad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_8B3_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_8B3_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_8E1_0 = this.Bar1;
			size = new global::System.Drawing.Size(653, 41);
			arg_8E1_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 14;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.trash_bin;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف (F5)";
			this.txt_darsad.AcceptEnter = false;
			this.txt_darsad.AllowEdit = true;
			this.txt_darsad.AllowNew = true;
			this.txt_darsad.DecimalDigits = 2;
			this.txt_darsad.FixLength = 5;
			this.txt_darsad.FocusColor = false;
			global::System.Windows.Forms.Control arg_A0F_0 = this.txt_darsad;
			location = new global::System.Drawing.Point(12, 44);
			arg_A0F_0.Location = location;
			this.txt_darsad.MaxLength = 5;
			this.txt_darsad.Name = "txt_darsad";
			this.txt_darsad.Nullable = true;
			this.txt_darsad.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_darsad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_A72_0 = this.txt_darsad;
			size = new global::System.Drawing.Size(100, 23);
			arg_A72_0.Size = size;
			this.txt_darsad.TabIndex = 3;
			this.txt_darsad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad.Visible = false;
			this.txt_darsad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_BC1_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 169);
			arg_BC1_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_C0C_0 = this.GridEX1;
			size = new global::System.Drawing.Size(653, 265);
			arg_C0C_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_CF6_0 = this.Label1;
			location = new global::System.Drawing.Point(330, 56);
			arg_CF6_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_D21_0 = this.Label1;
			size = new global::System.Drawing.Size(84, 19);
			arg_D21_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "جمع فروش";
			this.Label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			this.Label5.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_DAD_0 = this.Label5;
			location = new global::System.Drawing.Point(556, 132);
			arg_DAD_0.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control arg_DD8_0 = this.Label5;
			size = new global::System.Drawing.Size(69, 19);
			arg_DD8_0.Size = size;
			this.Label5.TabIndex = 2;
			this.Label5.Text = "نوع درصد";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_E61_0 = this.Label3;
			location = new global::System.Drawing.Point(556, 98);
			arg_E61_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_E8C_0 = this.Label3;
			size = new global::System.Drawing.Size(82, 19);
			arg_E8C_0.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "درصد مانده";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_F15_0 = this.Label2;
			location = new global::System.Drawing.Point(556, 56);
			arg_F15_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_F40_0 = this.Label2;
			size = new global::System.Drawing.Size(90, 19);
			arg_F40_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "شماره سند";
			this.txt_darsad2.AcceptEnter = true;
			this.txt_darsad2.AllowEdit = false;
			this.txt_darsad2.AllowNew = true;
			this.txt_darsad2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_darsad2.FixLength = 2;
			this.txt_darsad2.FocusColor = true;
			this.txt_darsad2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_FEC_0 = this.txt_darsad2;
			location = new global::System.Drawing.Point(454, 90);
			arg_FEC_0.Location = location;
			this.txt_darsad2.MaxLength = 2;
			this.txt_darsad2.Name = "txt_darsad2";
			this.txt_darsad2.Nullable = true;
			this.txt_darsad2.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_darsad2.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_104F_0 = this.txt_darsad2;
			size = new global::System.Drawing.Size(100, 36);
			arg_104F_0.Size = size;
			this.txt_darsad2.TabIndex = 1;
			this.txt_darsad2.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(653, 434);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sud_Furush";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "درصد مشارکت";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F51 RID: 3921
		private global::System.ComponentModel.IContainer components;
	}
}
