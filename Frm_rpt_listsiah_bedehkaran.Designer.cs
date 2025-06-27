namespace FruitBox
{
	// Token: 0x02000132 RID: 306
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_rpt_listsiah_bedehkaran : global::System.Windows.Forms.Form
	{
		// Token: 0x06002C2D RID: 11309 RVA: 0x0020D04C File Offset: 0x0020B24C
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

		// Token: 0x06002C2E RID: 11310 RVA: 0x0020D09C File Offset: 0x0020B29C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_rpt_listsiah_bedehkaran));
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem2 = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem3 = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem4 = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem5 = new global::Janus.Windows.EditControls.UIComboBoxItem();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_search = new global::FruitBox.EditBox(this.components);
			this.SelectItem1 = new global::FruitBox.SelectItem(this.components);
			this.UiComboBox1 = new global::Janus.Windows.EditControls.UIComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem5 = new global::DevComponents.DotNetBar.ButtonItem();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.UiProgressBar1 = new global::Janus.Windows.EditControls.UIProgressBar();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutomaticSort = false;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_211_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 112);
			arg_211_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_24F_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(825, 409);
			arg_24F_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_search);
			this.UiGroupBox1.Controls.Add(this.SelectItem1);
			this.UiGroupBox1.Controls.Add(this.UiComboBox1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_34C_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_34C_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_37D_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(825, 544);
			arg_37D_0.Size = size;
			this.UiGroupBox1.TabIndex = 2;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_search.AcceptEnter = true;
			this.txt_search.AllowEdit = true;
			this.txt_search.AllowNew = true;
			this.txt_search.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_search.FocusColor = true;
			this.txt_search.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_418_0 = this.txt_search;
			location = new global::System.Drawing.Point(499, 80);
			arg_418_0.Location = location;
			this.txt_search.Name = "txt_search";
			this.txt_search.Nullable = true;
			this.txt_search.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_search.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_471_0 = this.txt_search;
			size = new global::System.Drawing.Size(247, 27);
			arg_471_0.Size = size;
			this.txt_search.TabIndex = 4;
			this.txt_search.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
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
			this.SelectItem1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "عنوان";
			column.Name = "Name";
			column.Size = 100;
			this.SelectItem1.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_5B2_0 = this.SelectItem1;
			location = new global::System.Drawing.Point(188, 47);
			arg_5B2_0.Location = location;
			this.SelectItem1.Name = "SelectItem1";
			this.SelectItem1.Nullable = true;
			this.SelectItem1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.SelectItem1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.SelectItem1.SelectCommand = "SELECT     1 as kind,ID, Name FROM         Grouh_Moshtari union all SELECT     2 as kind,ID, Name FROM         Grouh_Moshtari2";
			this.SelectItem1.SelectedRow = null;
			this.SelectItem1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_636_0 = this.SelectItem1;
			size = new global::System.Drawing.Size(161, 27);
			arg_636_0.Size = size;
			this.SelectItem1.TabIndex = 3;
			this.SelectItem1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.SelectItem1.Value = null;
			this.SelectItem1.ValueMember = "ID";
			this.SelectItem1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiComboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiComboBox1.ComboStyle = global::Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.UiComboBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			uIComboBoxItem.FormatStyle.Alpha = 0;
			uIComboBoxItem.IsSeparator = false;
			uIComboBoxItem.Text = "مانده از تاریخ";
			uIComboBoxItem.Value = "0";
			uIComboBoxItem2.FormatStyle.Alpha = 0;
			uIComboBoxItem2.IsSeparator = false;
			uIComboBoxItem2.Text = "بدهکاری";
			uIComboBoxItem2.Value = "1";
			uIComboBoxItem3.FormatStyle.Alpha = 0;
			uIComboBoxItem3.IsSeparator = false;
			uIComboBoxItem3.Text = "نام خانوادگی";
			uIComboBoxItem3.Value = "2";
			uIComboBoxItem4.FormatStyle.Alpha = 0;
			uIComboBoxItem4.IsSeparator = false;
			uIComboBoxItem4.Text = "نام";
			uIComboBoxItem4.Value = "3";
			uIComboBoxItem5.FormatStyle.Alpha = 0;
			uIComboBoxItem5.IsSeparator = false;
			uIComboBoxItem5.Text = "تاریخ مانده اول دوره";
			uIComboBoxItem5.Value = "4";
			this.UiComboBox1.Items.AddRange(new global::Janus.Windows.EditControls.UIComboBoxItem[]
			{
				uIComboBoxItem,
				uIComboBoxItem2,
				uIComboBoxItem3,
				uIComboBoxItem4,
				uIComboBoxItem5
			});
			global::System.Windows.Forms.Control arg_803_0 = this.UiComboBox1;
			location = new global::System.Drawing.Point(499, 47);
			arg_803_0.Location = location;
			this.UiComboBox1.Name = "UiComboBox1";
			global::System.Windows.Forms.Control arg_831_0 = this.UiComboBox1;
			size = new global::System.Drawing.Size(166, 27);
			arg_831_0.Size = size;
			this.UiComboBox1.TabIndex = 2;
			this.UiComboBox1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_8B6_0 = this.Label2;
			location = new global::System.Drawing.Point(355, 52);
			arg_8B6_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_8E1_0 = this.Label2;
			size = new global::System.Drawing.Size(127, 19);
			arg_8E1_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "شهر / شهرستان";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_96A_0 = this.Label3;
			location = new global::System.Drawing.Point(748, 85);
			arg_96A_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_995_0 = this.Label3;
			size = new global::System.Drawing.Size(61, 19);
			arg_995_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "جستجو";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A1E_0 = this.Label1;
			location = new global::System.Drawing.Point(671, 50);
			arg_A1E_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_A4C_0 = this.Label1;
			size = new global::System.Drawing.Size(154, 19);
			arg_A4C_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "مرتب سازی بر اساس";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem3,
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem5
			});
			global::DevComponents.DotNetBar.Bar arg_B01_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_B01_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_B2F_0 = this.Bar1;
			size = new global::System.Drawing.Size(825, 41);
			arg_B2F_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 25;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.list1;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "صورتحساب (F3)";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.filter_delete;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "پاک کردن فیلتر (F5)";
			this.ButtonItem5.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem5.Image = global::FruitBox.My.Resources.Resources.list_remove;
			this.ButtonItem5.Name = "ButtonItem5";
			this.ButtonItem5.Text = "حذف از لیست سوخته";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.UiProgressBar1.BorderStyle = global::Janus.Windows.UI.BorderStyle.None;
			this.UiProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control arg_CC9_0 = this.UiProgressBar1;
			location = new global::System.Drawing.Point(0, 521);
			arg_CC9_0.Location = location;
			this.UiProgressBar1.Name = "UiProgressBar1";
			this.UiProgressBar1.ShowPercentage = true;
			global::System.Windows.Forms.Control arg_D04_0 = this.UiProgressBar1;
			size = new global::System.Drawing.Size(825, 23);
			arg_D04_0.Size = size;
			this.UiProgressBar1.TabIndex = 26;
			this.UiProgressBar1.Visible = false;
			this.UiProgressBar1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(825, 544);
			this.ClientSize = size;
			this.Controls.Add(this.UiProgressBar1);
			this.Controls.Add(this.Bar1);
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_rpt_listsiah_bedehkaran";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "لیست سوخته";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04001130 RID: 4400
		private global::System.ComponentModel.IContainer components;
	}
}
