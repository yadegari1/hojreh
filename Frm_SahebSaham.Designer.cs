namespace FruitBox
{
	// Token: 0x020000D6 RID: 214
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_SahebSaham : global::System.Windows.Forms.Form
	{
		// Token: 0x06001309 RID: 4873 RVA: 0x000CBDDC File Offset: 0x000C9FDC
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

		// Token: 0x0600130A RID: 4874 RVA: 0x000CBE2C File Offset: 0x000CA02C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_SahebSaham));
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_name = new global::FruitBox.SelectItem(this.components);
			this.txt_darsad = new global::FruitBox.NumericBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
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
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_16A_0 = this.Bar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_16A_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_198_0 = this.Bar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(658, 41);
			arg_198_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 13;
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
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_31A_0 = this.Label1;
			location = new global::System.Drawing.Point(523, 16);
			arg_31A_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_348_0 = this.Label1;
			size = new global::System.Drawing.Size(129, 19);
			arg_348_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "نام و نام خانوادگی";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_name);
			this.UiGroupBox1.Controls.Add(this.txt_darsad);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_419_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 41);
			arg_419_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			this.UiGroupBox1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Blue;
			global::System.Windows.Forms.Control arg_457_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(658, 519);
			arg_457_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_name.AcceptEnter = true;
			this.txt_name.AddNewForm = null;
			this.txt_name.AllowEdit = true;
			this.txt_name.AllowNew = true;
			this.txt_name.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_name.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_name.ButtonText = "...";
			this.txt_name.CanEdit = true;
			this.txt_name.DisplayMember = "Name";
			this.txt_name.Edit_Frm = null;
			this.txt_name.ExtraData = 0L;
			this.txt_name.FocusColor = true;
			this.txt_name.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "مشتری";
			column.Name = "Name";
			column.Size = 100;
			this.txt_name.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_597_0 = this.txt_name;
			location = new global::System.Drawing.Point(271, 7);
			arg_597_0.Location = location;
			this.txt_name.Name = "txt_name";
			this.txt_name.Nullable = false;
			this.txt_name.NullToolTipText = "لطفا شریک را مشخص فرمائید";
			this.txt_name.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_name.SelectCommand = "Select Id,name + ' ' + Family as Name From Moshtari where id > -1";
			this.txt_name.SelectedRow = null;
			this.txt_name.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_61B_0 = this.txt_name;
			size = new global::System.Drawing.Size(249, 36);
			arg_61B_0.Size = size;
			this.txt_name.TabIndex = 0;
			this.txt_name.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_name.Value = null;
			this.txt_name.ValueMember = "ID";
			this.txt_name.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_darsad.AcceptEnter = true;
			this.txt_darsad.AllowEdit = true;
			this.txt_darsad.AllowNew = true;
			this.txt_darsad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_darsad.DecimalDigits = 5;
			this.txt_darsad.FocusColor = true;
			this.txt_darsad.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_6ED_0 = this.txt_darsad;
			location = new global::System.Drawing.Point(128, 7);
			arg_6ED_0.Location = location;
			this.txt_darsad.MaxLength = 8;
			this.txt_darsad.Name = "txt_darsad";
			this.txt_darsad.Nullable = true;
			this.txt_darsad.NullToolTipText = "درصد شراکت را وارد نمایید";
			this.txt_darsad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_750_0 = this.txt_darsad;
			size = new global::System.Drawing.Size(92, 36);
			arg_750_0.Size = size;
			this.txt_darsad.TabIndex = 1;
			this.txt_darsad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_7F3_0 = this.Label2;
			location = new global::System.Drawing.Point(222, 16);
			arg_7F3_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_81E_0 = this.Label2;
			size = new global::System.Drawing.Size(43, 19);
			arg_81E_0.Size = size;
			this.Label2.TabIndex = 3;
			this.Label2.Text = "درصد";
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
			global::System.Windows.Forms.Control arg_8F8_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 49);
			arg_8F8_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_950_0 = this.GridEX1;
			size = new global::System.Drawing.Size(655, 470);
			arg_950_0.Size = size;
			this.GridEX1.TabIndex = 3;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(658, 560);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_SahebSaham";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تعریف شرکا ";
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400075E RID: 1886
		private global::System.ComponentModel.IContainer components;
	}
}
