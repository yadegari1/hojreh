namespace FruitBox
{
	// Token: 0x020000D9 RID: 217
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_SelectDasteCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x06001365 RID: 4965 RVA: 0x000CEB80 File Offset: 0x000CCD80
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

		// Token: 0x06001366 RID: 4966 RVA: 0x000CEBD0 File Offset: 0x000CCDD0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_SelectDasteCheck));
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txt_dastecheck = new global::FruitBox.SelectItem(this.components);
			this.txt_hesabbank = new global::FruitBox.SelectItem(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.txt_dastecheck);
			this.UiGroupBox1.Controls.Add(this.txt_hesabbank);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_166_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_166_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_197_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(330, 523);
			arg_197_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
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
			global::System.Windows.Forms.Control arg_27B_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 92);
			arg_27B_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_2D3_0 = this.GridEX1;
			size = new global::System.Drawing.Size(324, 428);
			arg_2D3_0.Size = size;
			this.GridEX1.TabIndex = 2;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_3A3_0 = this.Label2;
			location = new global::System.Drawing.Point(237, 59);
			arg_3A3_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_3CE_0 = this.Label2;
			size = new global::System.Drawing.Size(78, 19);
			arg_3CE_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "دسته چک";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_457_0 = this.Label1;
			location = new global::System.Drawing.Point(237, 18);
			arg_457_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_482_0 = this.Label1;
			size = new global::System.Drawing.Size(98, 19);
			arg_482_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "حساب بانکی";
			this.txt_dastecheck.AcceptEnter = true;
			this.txt_dastecheck.AddNewForm = null;
			this.txt_dastecheck.AllowEdit = true;
			this.txt_dastecheck.AllowNew = true;
			this.txt_dastecheck.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_dastecheck.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_dastecheck.ButtonText = "...";
			this.txt_dastecheck.CanEdit = false;
			this.txt_dastecheck.DisplayMember = "ShomareBarg";
			this.txt_dastecheck.Edit_Frm = null;
			this.txt_dastecheck.ExtraData = 0L;
			this.txt_dastecheck.FocusColor = true;
			this.txt_dastecheck.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "شماره برگ";
			column.Name = "ShomareBarg";
			column.Size = 100;
			this.txt_dastecheck.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_5C4_0 = this.txt_dastecheck;
			location = new global::System.Drawing.Point(12, 50);
			arg_5C4_0.Location = location;
			this.txt_dastecheck.Name = "txt_dastecheck";
			this.txt_dastecheck.Nullable = true;
			this.txt_dastecheck.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_dastecheck.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_dastecheck.SelectCommand = null;
			this.txt_dastecheck.SelectedRow = null;
			this.txt_dastecheck.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_644_0 = this.txt_dastecheck;
			size = new global::System.Drawing.Size(223, 36);
			arg_644_0.Size = size;
			this.txt_dastecheck.TabIndex = 1;
			this.txt_dastecheck.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_dastecheck.Value = null;
			this.txt_dastecheck.ValueMember = "ID";
			this.txt_dastecheck.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_hesabbank.AcceptEnter = true;
			this.txt_hesabbank.AddNewForm = null;
			this.txt_hesabbank.AllowEdit = true;
			this.txt_hesabbank.AllowNew = true;
			this.txt_hesabbank.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_hesabbank.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_hesabbank.ButtonText = "...";
			this.txt_hesabbank.CanEdit = false;
			this.txt_hesabbank.DisplayMember = "Name";
			this.txt_hesabbank.Edit_Frm = null;
			this.txt_hesabbank.ExtraData = 0L;
			this.txt_hesabbank.FocusColor = true;
			this.txt_hesabbank.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column2.Caption = "کد";
			column2.Name = "ID";
			column2.Size = 20;
			column3.Caption = "حساب بانکی";
			column3.Name = "Name";
			column3.Size = 80;
			this.txt_hesabbank.Items.AddRange(new global::FruitBox.Column[]
			{
				column2,
				column3
			});
			global::System.Windows.Forms.Control arg_7D3_0 = this.txt_hesabbank;
			location = new global::System.Drawing.Point(12, 8);
			arg_7D3_0.Location = location;
			this.txt_hesabbank.Name = "txt_hesabbank";
			this.txt_hesabbank.Nullable = true;
			this.txt_hesabbank.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_hesabbank.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_hesabbank.SelectCommand = null;
			this.txt_hesabbank.SelectedRow = null;
			this.txt_hesabbank.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_853_0 = this.txt_hesabbank;
			size = new global::System.Drawing.Size(223, 36);
			arg_853_0.Size = size;
			this.txt_hesabbank.TabIndex = 0;
			this.txt_hesabbank.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_hesabbank.Value = null;
			this.txt_hesabbank.ValueMember = "ID";
			this.txt_hesabbank.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(330, 523);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_SelectDasteCheck";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "انتخاب برگ دسته چک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000781 RID: 1921
		private global::System.ComponentModel.IContainer components;
	}
}
