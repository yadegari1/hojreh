namespace FruitBox
{
	// Token: 0x0200010D RID: 269
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sanad_Dasti : global::System.Windows.Forms.Form
	{
		// Token: 0x06002696 RID: 9878 RVA: 0x001D29FC File Offset: 0x001D0BFC
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

		// Token: 0x06002697 RID: 9879 RVA: 0x001D2A4C File Offset: 0x001D0C4C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem2 = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sanad_Dasti));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_desc = new global::FruitBox.EditBox(this.components);
			this.txt_bes = new global::FruitBox.CurrencyBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txt_bed = new global::FruitBox.CurrencyBox(this.components);
			this.UiComboBox1 = new global::Janus.Windows.EditControls.UIComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_desc);
			this.UiGroupBox1.Controls.Add(this.txt_bes);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.txt_bed);
			this.UiGroupBox1.Controls.Add(this.UiComboBox1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1F2_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1F2_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_223_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1000, 537);
			arg_223_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_desc.AcceptEnter = true;
			this.txt_desc.AllowEdit = true;
			this.txt_desc.AllowNew = true;
			this.txt_desc.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_desc.FocusColor = true;
			this.txt_desc.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_2BE_0 = this.txt_desc;
			location = new global::System.Drawing.Point(398, 47);
			arg_2BE_0.Location = location;
			this.txt_desc.Name = "txt_desc";
			this.txt_desc.Nullable = true;
			this.txt_desc.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_desc.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_317_0 = this.txt_desc;
			size = new global::System.Drawing.Size(320, 36);
			arg_317_0.Size = size;
			this.txt_desc.TabIndex = 2;
			this.txt_desc.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_bes.AcceptEnter = false;
			this.txt_bes.AllowEdit = true;
			this.txt_bes.AllowNew = true;
			this.txt_bes.FocusColor = true;
			global::System.Windows.Forms.Control arg_385_0 = this.txt_bes;
			location = new global::System.Drawing.Point(334, 274);
			arg_385_0.Location = location;
			this.txt_bes.Name = "txt_bes";
			this.txt_bes.Nullable = true;
			this.txt_bes.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_bes.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3DB_0 = this.txt_bes;
			size = new global::System.Drawing.Size(100, 20);
			arg_3DB_0.Size = size;
			this.txt_bes.TabIndex = 18;
			this.txt_bes.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_bes.Value = value;
			this.txt_bes.Visible = false;
			this.txt_bes.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_489_0 = this.Label2;
			location = new global::System.Drawing.Point(720, 52);
			arg_489_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_4B4_0 = this.Label2;
			size = new global::System.Drawing.Size(75, 28);
			arg_4B4_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "توضیحات";
			this.txt_bed.AcceptEnter = false;
			this.txt_bed.AllowEdit = true;
			this.txt_bed.AllowNew = true;
			this.txt_bed.FocusColor = true;
			global::System.Windows.Forms.Control arg_526_0 = this.txt_bed;
			location = new global::System.Drawing.Point(334, 248);
			arg_526_0.Location = location;
			this.txt_bed.Name = "txt_bed";
			this.txt_bed.Nullable = true;
			this.txt_bed.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_bed.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_57C_0 = this.txt_bed;
			size = new global::System.Drawing.Size(100, 20);
			arg_57C_0.Size = size;
			this.txt_bed.TabIndex = 17;
			this.txt_bed.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_bed.Value = value;
			this.txt_bed.Visible = false;
			this.txt_bed.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiComboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiComboBox1.ComboStyle = global::Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.UiComboBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			uIComboBoxItem.FormatStyle.Alpha = 0;
			uIComboBoxItem.IsSeparator = false;
			uIComboBoxItem.Text = "دریافتی";
			uIComboBoxItem.Value = "1";
			uIComboBoxItem2.FormatStyle.Alpha = 0;
			uIComboBoxItem2.IsSeparator = false;
			uIComboBoxItem2.Text = "پرداختی";
			uIComboBoxItem2.Value = "2";
			this.UiComboBox1.Items.AddRange(new global::Janus.Windows.EditControls.UIComboBoxItem[]
			{
				uIComboBoxItem,
				uIComboBoxItem2
			});
			global::System.Windows.Forms.Control arg_69A_0 = this.UiComboBox1;
			location = new global::System.Drawing.Point(797, 46);
			arg_69A_0.Location = location;
			this.UiComboBox1.Name = "UiComboBox1";
			global::System.Windows.Forms.Control arg_6C5_0 = this.UiComboBox1;
			size = new global::System.Drawing.Size(124, 36);
			arg_6C5_0.Size = size;
			this.UiComboBox1.TabIndex = 1;
			this.UiComboBox1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_74A_0 = this.Label1;
			location = new global::System.Drawing.Point(926, 52);
			arg_74A_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_775_0 = this.Label1;
			size = new global::System.Drawing.Size(64, 28);
			arg_775_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "نوع سند";
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_856_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 88);
			arg_856_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			global::System.Windows.Forms.Control arg_8A1_0 = this.GridEX1;
			size = new global::System.Drawing.Size(1000, 449);
			arg_8A1_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_9A1_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_9A1_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_9CF_0 = this.Bar1;
			size = new global::System.Drawing.Size(1000, 41);
			arg_9CF_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.trash_bin;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف ردیف  (F5)";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1000, 537);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sanad_Dasti";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ثبت سند دستی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F18 RID: 3864
		private global::System.ComponentModel.IContainer components;
	}
}
