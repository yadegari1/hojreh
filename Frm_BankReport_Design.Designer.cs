namespace FruitBox
{
	// Token: 0x02000119 RID: 281
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_BankReport_Design : global::System.Windows.Forms.Form
	{
		// Token: 0x0600296C RID: 10604 RVA: 0x001F54D0 File Offset: 0x001F36D0
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

		// Token: 0x0600296D RID: 10605 RVA: 0x001F5520 File Offset: 0x001F3720
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_BankReport_Design));
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton3 = new global::Janus.Windows.EditControls.UIButton();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.NumericBox1 = new global::FruitBox.NumericBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.document_flat_edit;
			this.UiButton1.ImageHorizontalAlignment = global::Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
			global::Janus.Windows.EditControls.UIButton arg_EC_0 = this.UiButton1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(24, 24);
			arg_EC_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_109_0 = this.UiButton1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(308, 12);
			arg_109_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_154_0 = this.UiButton1;
			size = new global::System.Drawing.Size(188, 36);
			arg_154_0.Size = size;
			this.UiButton1.TabIndex = 4;
			this.UiButton1.Text = "طراحی فرم واگذاری چک به بانک";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.document_flat_edit;
			this.UiButton2.ImageHorizontalAlignment = global::Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
			global::Janus.Windows.EditControls.UIButton arg_1C4_0 = this.UiButton2;
			size = new global::System.Drawing.Size(24, 24);
			arg_1C4_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_1E1_0 = this.UiButton2;
			location = new global::System.Drawing.Point(308, 69);
			arg_1E1_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_22C_0 = this.UiButton2;
			size = new global::System.Drawing.Size(188, 36);
			arg_22C_0.Size = size;
			this.UiButton2.TabIndex = 4;
			this.UiButton2.Text = "طراحی فرم واریز به حساب";
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton3.Image = global::FruitBox.My.Resources.Resources.document_flat_edit;
			this.UiButton3.ImageHorizontalAlignment = global::Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
			global::Janus.Windows.EditControls.UIButton arg_29C_0 = this.UiButton3;
			size = new global::System.Drawing.Size(24, 24);
			arg_29C_0.ImageSize = size;
			global::System.Windows.Forms.Control arg_2B9_0 = this.UiButton3;
			location = new global::System.Drawing.Point(308, 125);
			arg_2B9_0.Location = location;
			this.UiButton3.Name = "UiButton3";
			this.UiButton3.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton3.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_304_0 = this.UiButton3;
			size = new global::System.Drawing.Size(188, 36);
			arg_304_0.Size = size;
			this.UiButton3.TabIndex = 4;
			this.UiButton3.Text = "طراحی چاپ چک";
			this.UiButton3.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_378_0 = this.Label1;
			location = new global::System.Drawing.Point(192, 24);
			arg_378_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_3A2_0 = this.Label1;
			size = new global::System.Drawing.Size(93, 13);
			arg_3A2_0.Size = size;
			this.Label1.TabIndex = 6;
			this.Label1.Text = "تعداد ردیف در فیش";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.NumericBox1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_42D_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_42D_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_45D_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(711, 412);
			arg_45D_0.Size = size;
			this.UiGroupBox1.TabIndex = 7;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_535_0 = this.GridEX1;
			location = new global::System.Drawing.Point(502, 0);
			arg_535_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_58C_0 = this.GridEX1;
			size = new global::System.Drawing.Size(209, 412);
			arg_58C_0.Size = size;
			this.GridEX1.TabIndex = 3;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.NumericBox1.AcceptEnter = true;
			this.NumericBox1.AllowEdit = true;
			this.NumericBox1.AllowNew = true;
			this.NumericBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.NumericBox1.FocusColor = true;
			global::System.Windows.Forms.Control arg_64D_0 = this.NumericBox1;
			location = new global::System.Drawing.Point(86, 19);
			arg_64D_0.Location = location;
			this.NumericBox1.Name = "NumericBox1";
			this.NumericBox1.Nullable = true;
			this.NumericBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.NumericBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_6A2_0 = this.NumericBox1;
			size = new global::System.Drawing.Size(100, 21);
			arg_6A2_0.Size = size;
			this.NumericBox1.TabIndex = 5;
			this.NumericBox1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.NumericBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(711, 412);
			this.ClientSize = size;
			this.Controls.Add(this.UiButton3);
			this.Controls.Add(this.UiButton2);
			this.Controls.Add(this.UiButton1);
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_BankReport_Design";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "طراحی گزارشات بانکی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400102B RID: 4139
		private global::System.ComponentModel.IContainer components;
	}
}
