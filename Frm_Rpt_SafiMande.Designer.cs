namespace FruitBox
{
	// Token: 0x02000137 RID: 311
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Rpt_SafiMande : global::System.Windows.Forms.Form
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x00216934 File Offset: 0x00214B34
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

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00216984 File Offset: 0x00214B84
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Rpt_SafiMande));
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txt_bankhesab = new global::FruitBox.SelectItem(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_152_0 = this.Bar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_152_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_180_0 = this.Bar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1118, 41);
			arg_180_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 15;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.list1;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "صورتحساب گیری جدید (F3)";
			this.ButtonItem2.Visible = false;
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ صافی (F4)";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_2D8_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 41);
			arg_2D8_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_309_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(1118, 531);
			arg_309_0.Size = size;
			this.UiGroupBox1.TabIndex = 16;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_3C6_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 48);
			arg_3C6_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_41E_0 = this.GridEX1;
			size = new global::System.Drawing.Size(1118, 483);
			arg_41E_0.Size = size;
			this.GridEX1.TabIndex = 20;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_51E_0 = this.EditBox1;
			location = new global::System.Drawing.Point(715, 6);
			arg_51E_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_577_0 = this.EditBox1;
			size = new global::System.Drawing.Size(317, 36);
			arg_577_0.Size = size;
			this.EditBox1.TabIndex = 19;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5FD_0 = this.Label2;
			location = new global::System.Drawing.Point(1034, 15);
			arg_5FD_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_628_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_628_0.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "جستجو";
			this.txt_bankhesab.AcceptEnter = false;
			this.txt_bankhesab.AddNewForm = null;
			this.txt_bankhesab.AllowEdit = true;
			this.txt_bankhesab.AllowNew = true;
			this.txt_bankhesab.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_bankhesab.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_bankhesab.ButtonText = "...";
			this.txt_bankhesab.CanEdit = true;
			this.txt_bankhesab.DisplayMember = "Name";
			this.txt_bankhesab.Edit_Frm = null;
			this.txt_bankhesab.ExtraData = 0L;
			this.txt_bankhesab.FocusColor = true;
			this.txt_bankhesab.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "حساب بانکی";
			column2.Name = "Name";
			column2.Size = 85;
			this.txt_bankhesab.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2
			});
			global::System.Windows.Forms.Control arg_794_0 = this.txt_bankhesab;
			location = new global::System.Drawing.Point(476, 11);
			arg_794_0.Location = location;
			this.txt_bankhesab.Name = "txt_bankhesab";
			this.txt_bankhesab.Nullable = true;
			this.txt_bankhesab.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_bankhesab.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_bankhesab.SelectCommand = "SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID";
			this.txt_bankhesab.SelectedRow = null;
			this.txt_bankhesab.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_818_0 = this.txt_bankhesab;
			size = new global::System.Drawing.Size(317, 36);
			arg_818_0.Size = size;
			this.txt_bankhesab.TabIndex = 0;
			this.txt_bankhesab.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_bankhesab.Value = null;
			this.txt_bankhesab.ValueMember = "ID";
			this.txt_bankhesab.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1118, 572);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Rpt_SafiMande";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "صافی های اعلام نشده";
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04001176 RID: 4470
		private global::System.ComponentModel.IContainer components;
	}
}
