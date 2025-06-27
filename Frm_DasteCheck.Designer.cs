namespace FruitBox
{
	// Token: 0x020000C8 RID: 200
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_DasteCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x06001092 RID: 4242 RVA: 0x000B6DA0 File Offset: 0x000B4FA0
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

		// Token: 0x06001093 RID: 4243 RVA: 0x000B6DF0 File Offset: 0x000B4FF0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_DasteCheck));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_tashomare = new global::FruitBox.NumericBox(this.components);
			this.txt_tedad = new global::FruitBox.NumericBox(this.components);
			this.txt_azshomare = new global::FruitBox.NumericBox(this.components);
			this.txt_hesabbank = new global::FruitBox.SelectItem(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_tashomare);
			this.UiGroupBox1.Controls.Add(this.txt_tedad);
			this.UiGroupBox1.Controls.Add(this.txt_azshomare);
			this.UiGroupBox1.Controls.Add(this.txt_hesabbank);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_234_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 41);
			arg_234_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_272_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(612, 473);
			arg_272_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_tashomare.AcceptEnter = true;
			this.txt_tashomare.AllowEdit = false;
			this.txt_tashomare.AllowNew = true;
			this.txt_tashomare.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tashomare.FocusColor = true;
			this.txt_tashomare.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_30A_0 = this.txt_tashomare;
			location = new global::System.Drawing.Point(60, 48);
			arg_30A_0.Location = location;
			this.txt_tashomare.Name = "txt_tashomare";
			this.txt_tashomare.Nullable = true;
			this.txt_tashomare.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_tashomare.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_360_0 = this.txt_tashomare;
			size = new global::System.Drawing.Size(100, 36);
			arg_360_0.Size = size;
			this.txt_tashomare.TabIndex = 3;
			this.txt_tashomare.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_tashomare.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_tedad.AcceptEnter = true;
			this.txt_tedad.AllowEdit = true;
			this.txt_tedad.AllowNew = true;
			this.txt_tedad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tedad.FocusColor = true;
			this.txt_tedad.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_408_0 = this.txt_tedad;
			location = new global::System.Drawing.Point(245, 48);
			arg_408_0.Location = location;
			this.txt_tedad.Name = "txt_tedad";
			this.txt_tedad.Nullable = false;
			this.txt_tedad.NullToolTipText = "تعداد برگ دسته چک را وارد نمائید";
			this.txt_tedad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_45E_0 = this.txt_tedad;
			size = new global::System.Drawing.Size(100, 36);
			arg_45E_0.Size = size;
			this.txt_tedad.TabIndex = 2;
			this.txt_tedad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_tedad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_azshomare.AcceptEnter = true;
			this.txt_azshomare.AllowEdit = true;
			this.txt_azshomare.AllowNew = true;
			this.txt_azshomare.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_azshomare.FocusColor = true;
			this.txt_azshomare.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_506_0 = this.txt_azshomare;
			location = new global::System.Drawing.Point(421, 48);
			arg_506_0.Location = location;
			this.txt_azshomare.Name = "txt_azshomare";
			this.txt_azshomare.Nullable = false;
			this.txt_azshomare.NullToolTipText = "شماره شروع دسته چک را وارد نمائید";
			this.txt_azshomare.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_55C_0 = this.txt_azshomare;
			size = new global::System.Drawing.Size(81, 36);
			arg_55C_0.Size = size;
			this.txt_azshomare.TabIndex = 1;
			this.txt_azshomare.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_azshomare.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_hesabbank.AcceptEnter = true;
			this.txt_hesabbank.AddNewForm = null;
			this.txt_hesabbank.AllowEdit = false;
			this.txt_hesabbank.AllowNew = true;
			this.txt_hesabbank.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_hesabbank.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_hesabbank.ButtonText = "...";
			this.txt_hesabbank.CanEdit = true;
			this.txt_hesabbank.DisplayMember = "Name";
			this.txt_hesabbank.Edit_Frm = null;
			this.txt_hesabbank.ExtraData = 0L;
			this.txt_hesabbank.FocusColor = true;
			this.txt_hesabbank.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "حساب بانکی";
			column2.Name = "Name";
			column2.Size = 85;
			this.txt_hesabbank.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2
			});
			global::System.Windows.Forms.Control arg_6D0_0 = this.txt_hesabbank;
			location = new global::System.Drawing.Point(245, 6);
			arg_6D0_0.Location = location;
			this.txt_hesabbank.Name = "txt_hesabbank";
			this.txt_hesabbank.Nullable = false;
			this.txt_hesabbank.NullToolTipText = "حساب بانکی را انتخاب فرمائید";
			this.txt_hesabbank.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_hesabbank.SelectCommand = null;
			this.txt_hesabbank.SelectedRow = null;
			this.txt_hesabbank.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_750_0 = this.txt_hesabbank;
			size = new global::System.Drawing.Size(257, 36);
			arg_750_0.Size = size;
			this.txt_hesabbank.TabIndex = 0;
			this.txt_hesabbank.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_hesabbank.Value = null;
			this.txt_hesabbank.ValueMember = "ID";
			this.txt_hesabbank.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
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
			global::System.Windows.Forms.Control arg_85E_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 90);
			arg_85E_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_8B6_0 = this.GridEX1;
			size = new global::System.Drawing.Size(609, 383);
			arg_8B6_0.Size = size;
			this.GridEX1.TabIndex = 4;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_997_0 = this.Label4;
			location = new global::System.Drawing.Point(162, 58);
			arg_997_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_9C2_0 = this.Label4;
			size = new global::System.Drawing.Size(68, 19);
			arg_9C2_0.Size = size;
			this.Label4.TabIndex = 0;
			this.Label4.Text = "تا شماره";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_A5C_0 = this.Label3;
			location = new global::System.Drawing.Point(347, 58);
			arg_A5C_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_A87_0 = this.Label3;
			size = new global::System.Drawing.Size(72, 19);
			arg_A87_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "تعداد برگ";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_B21_0 = this.Label2;
			location = new global::System.Drawing.Point(504, 58);
			arg_B21_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_B4C_0 = this.Label2;
			size = new global::System.Drawing.Size(69, 19);
			arg_B4C_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "از شماره";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_BE6_0 = this.Label1;
			location = new global::System.Drawing.Point(504, 15);
			arg_BE6_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_C11_0 = this.Label1;
			size = new global::System.Drawing.Size(98, 19);
			arg_C11_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "حساب بانکی";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_CBB_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_CBB_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_CE9_0 = this.Bar1;
			size = new global::System.Drawing.Size(612, 41);
			arg_CE9_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 15;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.document;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "جدید (Ins)";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.trash_bin;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف (F5)";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(612, 514);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_DasteCheck";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تعریف دسته چک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400065A RID: 1626
		private global::System.ComponentModel.IContainer components;
	}
}
