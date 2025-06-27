namespace FruitBox
{
	// Token: 0x0200012F RID: 303
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_rpt_dpNaghd : global::System.Windows.Forms.Form
	{
		// Token: 0x06002BD6 RID: 11222 RVA: 0x00209E38 File Offset: 0x00208038
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

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00209E88 File Offset: 0x00208088
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.frm_rpt_dpNaghd));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEx2 = new global::FruitBox.DataEntryGrid(this.components);
			this.txt_mande = new global::FruitBox.CurrencyBox(this.components);
			this.txt_pardakhti = new global::FruitBox.CurrencyBox(this.components);
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txt_daryafti = new global::FruitBox.CurrencyBox(this.components);
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txt_ruzegabl = new global::FruitBox.CurrencyBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEx2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEx2);
			this.UiGroupBox1.Controls.Add(this.txt_mande);
			this.UiGroupBox1.Controls.Add(this.txt_pardakhti);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.txt_daryafti);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.txt_ruzegabl);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_226_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_226_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_257_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(677, 685);
			arg_257_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEx2.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEx2.AlternatingColors = true;
			this.GridEx2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEx2_DesignTimeLayout.LayoutString");
			this.GridEx2.DesignTimeLayout = gridEXLayout;
			this.GridEx2.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEx2.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEx2.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEx2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEx2.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_323_0 = this.GridEx2;
			location = new global::System.Drawing.Point(3, 418);
			arg_323_0.Location = location;
			this.GridEx2.Name = "GridEx2";
			this.GridEx2.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEx2.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEx2.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEx2.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_388_0 = this.GridEx2;
			size = new global::System.Drawing.Size(677, 266);
			arg_388_0.Size = size;
			this.GridEx2.TabIndex = 24;
			this.GridEx2.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEx2.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEx2.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEx2.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEx2.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEx2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_mande.AcceptEnter = true;
			this.txt_mande.AllowEdit = true;
			this.txt_mande.AllowNew = true;
			this.txt_mande.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_mande.FocusColor = true;
			this.txt_mande.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_47F_0 = this.txt_mande;
			location = new global::System.Drawing.Point(248, 131);
			arg_47F_0.Location = location;
			this.txt_mande.Name = "txt_mande";
			this.txt_mande.Nullable = true;
			this.txt_mande.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mande.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_4D8_0 = this.txt_mande;
			size = new global::System.Drawing.Size(199, 36);
			arg_4D8_0.Size = size;
			this.txt_mande.TabIndex = 23;
			this.txt_mande.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_mande.Value = value;
			this.txt_mande.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_pardakhti.AcceptEnter = true;
			this.txt_pardakhti.AllowEdit = true;
			this.txt_pardakhti.AllowNew = true;
			this.txt_pardakhti.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_pardakhti.FocusColor = true;
			this.txt_pardakhti.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_58F_0 = this.txt_pardakhti;
			location = new global::System.Drawing.Point(248, 89);
			arg_58F_0.Location = location;
			this.txt_pardakhti.Name = "txt_pardakhti";
			this.txt_pardakhti.Nullable = true;
			this.txt_pardakhti.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_pardakhti.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_5E8_0 = this.txt_pardakhti;
			size = new global::System.Drawing.Size(199, 36);
			arg_5E8_0.Size = size;
			this.txt_pardakhti.TabIndex = 23;
			this.txt_pardakhti.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_pardakhti.Value = value;
			this.txt_pardakhti.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_69D_0 = this.Label4;
			location = new global::System.Drawing.Point(449, 136);
			arg_69D_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_6C8_0 = this.Label4;
			size = new global::System.Drawing.Size(118, 28);
			arg_6C8_0.Size = size;
			this.Label4.TabIndex = 22;
			this.Label4.Text = "مانده نقد صندوق";
			this.txt_daryafti.AcceptEnter = true;
			this.txt_daryafti.AllowEdit = true;
			this.txt_daryafti.AllowNew = true;
			this.txt_daryafti.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_daryafti.FocusColor = true;
			this.txt_daryafti.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_768_0 = this.txt_daryafti;
			location = new global::System.Drawing.Point(248, 47);
			arg_768_0.Location = location;
			this.txt_daryafti.Name = "txt_daryafti";
			this.txt_daryafti.Nullable = true;
			this.txt_daryafti.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_daryafti.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7C1_0 = this.txt_daryafti;
			size = new global::System.Drawing.Size(199, 36);
			arg_7C1_0.Size = size;
			this.txt_daryafti.TabIndex = 23;
			this.txt_daryafti.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_daryafti.Value = value;
			this.txt_daryafti.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_873_0 = this.Label3;
			location = new global::System.Drawing.Point(449, 94);
			arg_873_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_8A1_0 = this.Label3;
			size = new global::System.Drawing.Size(177, 28);
			arg_8A1_0.Size = size;
			this.Label3.TabIndex = 22;
			this.Label3.Text = "منهای پرداختی های نقدی";
			this.txt_ruzegabl.AcceptEnter = true;
			this.txt_ruzegabl.AllowEdit = true;
			this.txt_ruzegabl.AllowNew = true;
			this.txt_ruzegabl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_ruzegabl.FocusColor = true;
			this.txt_ruzegabl.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_940_0 = this.txt_ruzegabl;
			location = new global::System.Drawing.Point(248, 3);
			arg_940_0.Location = location;
			this.txt_ruzegabl.Name = "txt_ruzegabl";
			this.txt_ruzegabl.Nullable = true;
			this.txt_ruzegabl.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_ruzegabl.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_999_0 = this.txt_ruzegabl;
			size = new global::System.Drawing.Size(199, 36);
			arg_999_0.Size = size;
			this.txt_ruzegabl.TabIndex = 23;
			this.txt_ruzegabl.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_ruzegabl.Value = value;
			this.txt_ruzegabl.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_A4B_0 = this.Label2;
			location = new global::System.Drawing.Point(449, 52);
			arg_A4B_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_A79_0 = this.Label2;
			size = new global::System.Drawing.Size(187, 28);
			arg_A79_0.Size = size;
			this.Label2.TabIndex = 22;
			this.Label2.Text = "به اضافه دریافتی های نقدی";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control arg_B13_0 = this.Label1;
			location = new global::System.Drawing.Point(449, 8);
			arg_B13_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_B41_0 = this.Label1;
			size = new global::System.Drawing.Size(167, 28);
			arg_B41_0.Size = size;
			this.Label1.TabIndex = 22;
			this.Label1.Text = "موجودی صندوق روز قبل";
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout2;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_C12_0 = this.GridEX1;
			location = new global::System.Drawing.Point(3, 173);
			arg_C12_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_C77_0 = this.GridEX1;
			size = new global::System.Drawing.Size(677, 239);
			arg_C77_0.Size = size;
			this.GridEX1.TabIndex = 21;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(677, 685);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_rpt_dpNaghd";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "صورتحساب نقد صندوق";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEx2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400110B RID: 4363
		private global::System.ComponentModel.IContainer components;
	}
}
