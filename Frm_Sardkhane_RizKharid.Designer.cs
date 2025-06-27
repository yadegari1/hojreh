namespace FruitBox
{
	// Token: 0x0200010E RID: 270
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sardkhane_RizKharid : global::System.Windows.Forms.Form
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x001D51F4 File Offset: 0x001D33F4
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

		// Token: 0x060026C9 RID: 9929 RVA: 0x001D5244 File Offset: 0x001D3444
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sardkhane_RizKharid));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference3 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column15.ButtonImage");
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_tarikhGrid = new global::FruitBox.DateBox2(this.components);
			this.txt_jam_kol = new global::FruitBox.CurrencyBox(this.components);
			this.txt_fee = new global::FruitBox.CurrencyBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_tarikhGrid);
			this.UiGroupBox1.Controls.Add(this.txt_jam_kol);
			this.UiGroupBox1.Controls.Add(this.txt_fee);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_158_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_158_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_189_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1299, 432);
			arg_189_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_tarikhGrid.AcceptEnter = false;
			this.txt_tarikhGrid.AllowEdit = true;
			this.txt_tarikhGrid.BorderStyle = global::Janus.Windows.GridEX.BorderStyle.None;
			this.txt_tarikhGrid.ButtonEnable = false;
			this.txt_tarikhGrid.ButtonEnabled = false;
			this.txt_tarikhGrid.FocusDatePart = 2;
			global::System.Windows.Forms.Control arg_211_0 = this.txt_tarikhGrid;
			location = new global::System.Drawing.Point(789, 377);
			arg_211_0.Location = location;
			this.txt_tarikhGrid.Mask = "0000/00/00";
			this.txt_tarikhGrid.Name = "txt_tarikhGrid";
			this.txt_tarikhGrid.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_25A_0 = this.txt_tarikhGrid;
			size = new global::System.Drawing.Size(100, 21);
			arg_25A_0.Size = size;
			this.txt_tarikhGrid.TabIndex = 24;
			this.txt_tarikhGrid.Text = "1393/05/28";
			this.txt_tarikhGrid.Visible = false;
			this.txt_tarikhGrid.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_jam_kol.AcceptEnter = false;
			this.txt_jam_kol.AllowEdit = true;
			this.txt_jam_kol.AllowNew = true;
			this.txt_jam_kol.FocusColor = false;
			global::System.Windows.Forms.Control arg_2E7_0 = this.txt_jam_kol;
			location = new global::System.Drawing.Point(683, 346);
			arg_2E7_0.Location = location;
			this.txt_jam_kol.Name = "txt_jam_kol";
			this.txt_jam_kol.Nullable = true;
			this.txt_jam_kol.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_jam_kol.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_33D_0 = this.txt_jam_kol;
			size = new global::System.Drawing.Size(100, 23);
			arg_33D_0.Size = size;
			this.txt_jam_kol.TabIndex = 16;
			this.txt_jam_kol.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_jam_kol.Value = value;
			this.txt_jam_kol.Visible = false;
			this.txt_jam_kol.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_fee.AcceptEnter = true;
			this.txt_fee.AllowEdit = true;
			this.txt_fee.AllowNew = true;
			this.txt_fee.DecimalDigits = 1;
			this.txt_fee.FocusColor = false;
			global::System.Windows.Forms.Control arg_3E1_0 = this.txt_fee;
			location = new global::System.Drawing.Point(683, 375);
			arg_3E1_0.Location = location;
			this.txt_fee.Name = "txt_fee";
			this.txt_fee.Nullable = true;
			this.txt_fee.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_fee.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_437_0 = this.txt_fee;
			size = new global::System.Drawing.Size(100, 23);
			arg_437_0.Size = size;
			this.txt_fee.TabIndex = 15;
			this.txt_fee.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_fee.Value = value;
			this.txt_fee.Visible = false;
			this.txt_fee.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"));
			janusLayoutReference3.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2,
				janusLayoutReference3
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_5B3_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 0);
			arg_5B3_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_5FE_0 = this.GridEX1;
			size = new global::System.Drawing.Size(1299, 432);
			arg_5FE_0.Size = size;
			this.GridEX1.TabIndex = 14;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1299, 432);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sardkhane_RizKharid";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ثبت ریز خرید به سردخانه";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F2B RID: 3883
		private global::System.ComponentModel.IContainer components;
	}
}
