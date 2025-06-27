namespace FruitBox
{
	// Token: 0x02000061 RID: 97
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Calc : global::System.Windows.Forms.Form
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x000672CC File Offset: 0x000654CC
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

		// Token: 0x060006A4 RID: 1700 RVA: 0x0006731C File Offset: 0x0006551C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Calc));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout3 = new global::Janus.Windows.GridEX.GridEXLayout();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.CurrencyBox6 = new global::FruitBox.NumericBox(this.components);
			this.CurrencyBox3 = new global::FruitBox.NumericBox(this.components);
			this.CurrencyBox5 = new global::FruitBox.NumericBox(this.components);
			this.CurrencyBox2 = new global::FruitBox.NumericBox(this.components);
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.GridEX3 = new global::Janus.Windows.GridEX.GridEX();
			this.GridEX2 = new global::Janus.Windows.GridEX.GridEX();
			this.CurrencyBox4 = new global::FruitBox.CurrencyBox(this.components);
			this.CurrencyBox1 = new global::FruitBox.CurrencyBox(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.GridEX1.AutoEdit = true;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_1AF_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(11, 131);
			arg_1AF_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			global::System.Windows.Forms.Control arg_1E0_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(204, 540);
			arg_1E0_0.Size = size;
			this.GridEX1.TabIndex = 3;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.CurrencyBox6);
			this.UiGroupBox1.Controls.Add(this.CurrencyBox3);
			this.UiGroupBox1.Controls.Add(this.CurrencyBox5);
			this.UiGroupBox1.Controls.Add(this.CurrencyBox2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.GridEX3);
			this.UiGroupBox1.Controls.Add(this.GridEX2);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.CurrencyBox4);
			this.UiGroupBox1.Controls.Add(this.CurrencyBox1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_336_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_336_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_367_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(675, 673);
			arg_367_0.Size = size;
			this.UiGroupBox1.TabIndex = 1;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.CurrencyBox6.AcceptEnter = true;
			this.CurrencyBox6.AllowEdit = true;
			this.CurrencyBox6.AllowNew = true;
			this.CurrencyBox6.FocusColor = true;
			this.CurrencyBox6.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_3F4_0 = this.CurrencyBox6;
			location = new global::System.Drawing.Point(505, 89);
			arg_3F4_0.Location = location;
			this.CurrencyBox6.Name = "CurrencyBox6";
			this.CurrencyBox6.Nullable = true;
			this.CurrencyBox6.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox6.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_44D_0 = this.CurrencyBox6;
			size = new global::System.Drawing.Size(156, 36);
			arg_44D_0.Size = size;
			this.CurrencyBox6.TabIndex = 11;
			this.CurrencyBox6.TabStop = false;
			this.CurrencyBox6.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.CurrencyBox6.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.CurrencyBox3.AcceptEnter = false;
			this.CurrencyBox3.AllowEdit = true;
			this.CurrencyBox3.AllowNew = true;
			this.CurrencyBox3.DecimalDigits = 3;
			this.CurrencyBox3.FocusColor = true;
			this.CurrencyBox3.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_502_0 = this.CurrencyBox3;
			location = new global::System.Drawing.Point(505, 47);
			arg_502_0.Location = location;
			this.CurrencyBox3.Name = "CurrencyBox3";
			this.CurrencyBox3.Nullable = true;
			this.CurrencyBox3.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox3.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_55B_0 = this.CurrencyBox3;
			size = new global::System.Drawing.Size(156, 36);
			arg_55B_0.Size = size;
			this.CurrencyBox3.TabIndex = 2;
			this.CurrencyBox3.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.CurrencyBox3.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.CurrencyBox5.AcceptEnter = true;
			this.CurrencyBox5.AllowEdit = true;
			this.CurrencyBox5.AllowNew = true;
			this.CurrencyBox5.DecimalDigits = 3;
			this.CurrencyBox5.FocusColor = true;
			this.CurrencyBox5.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_602_0 = this.CurrencyBox5;
			location = new global::System.Drawing.Point(282, 89);
			arg_602_0.Location = location;
			this.CurrencyBox5.Name = "CurrencyBox5";
			this.CurrencyBox5.Nullable = true;
			this.CurrencyBox5.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox5.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_65B_0 = this.CurrencyBox5;
			size = new global::System.Drawing.Size(156, 36);
			arg_65B_0.Size = size;
			this.CurrencyBox5.TabIndex = 10;
			this.CurrencyBox5.TabStop = false;
			this.CurrencyBox5.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.CurrencyBox5.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.CurrencyBox2.AcceptEnter = false;
			this.CurrencyBox2.AllowEdit = true;
			this.CurrencyBox2.AllowNew = true;
			this.CurrencyBox2.DecimalDigits = 3;
			this.CurrencyBox2.FocusColor = true;
			this.CurrencyBox2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_710_0 = this.CurrencyBox2;
			location = new global::System.Drawing.Point(282, 47);
			arg_710_0.Location = location;
			this.CurrencyBox2.Name = "CurrencyBox2";
			this.CurrencyBox2.Nullable = true;
			this.CurrencyBox2.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox2.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_769_0 = this.CurrencyBox2;
			size = new global::System.Drawing.Size(156, 36);
			arg_769_0.Size = size;
			this.CurrencyBox2.TabIndex = 1;
			this.CurrencyBox2.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.CurrencyBox2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Windows.Forms.Control arg_7AA_0 = this.UiButton1;
			location = new global::System.Drawing.Point(11, 47);
			arg_7AA_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_7D5_0 = this.UiButton1;
			size = new global::System.Drawing.Size(43, 36);
			arg_7D5_0.Size = size;
			this.UiButton1.TabIndex = 9;
			this.UiButton1.Text = "C";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.GridEX3.AutoEdit = true;
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridEX3_DesignTimeLayout.LayoutString");
			this.GridEX3.DesignTimeLayout = gridEXLayout2;
			this.GridEX3.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX3.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_87C_0 = this.GridEX3;
			location = new global::System.Drawing.Point(457, 131);
			arg_87C_0.Location = location;
			this.GridEX3.Name = "GridEX3";
			global::System.Windows.Forms.Control arg_8AD_0 = this.GridEX3;
			size = new global::System.Drawing.Size(204, 540);
			arg_8AD_0.Size = size;
			this.GridEX3.TabIndex = 5;
			this.GridEX3.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX2.AutoEdit = true;
			gridEXLayout3.LayoutString = componentResourceManager.GetString("GridEX2_DesignTimeLayout.LayoutString");
			this.GridEX2.DesignTimeLayout = gridEXLayout3;
			this.GridEX2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX2.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_942_0 = this.GridEX2;
			location = new global::System.Drawing.Point(234, 131);
			arg_942_0.Location = location;
			this.GridEX2.Name = "GridEX2";
			global::System.Windows.Forms.Control arg_973_0 = this.GridEX2;
			size = new global::System.Drawing.Size(204, 540);
			arg_973_0.Size = size;
			this.GridEX2.TabIndex = 4;
			this.GridEX2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.CurrencyBox4.AcceptEnter = false;
			this.CurrencyBox4.AllowEdit = false;
			this.CurrencyBox4.AllowNew = true;
			this.CurrencyBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.CurrencyBox4.FocusColor = true;
			this.CurrencyBox4.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A0A_0 = this.CurrencyBox4;
			location = new global::System.Drawing.Point(59, 89);
			arg_A0A_0.Location = location;
			this.CurrencyBox4.Name = "CurrencyBox4";
			this.CurrencyBox4.Nullable = true;
			this.CurrencyBox4.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox4.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_A63_0 = this.CurrencyBox4;
			size = new global::System.Drawing.Size(156, 36);
			arg_A63_0.Size = size;
			this.CurrencyBox4.TabIndex = 3;
			this.CurrencyBox4.TabStop = false;
			this.CurrencyBox4.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.CurrencyBox4.Value = value;
			this.CurrencyBox4.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.CurrencyBox1.AcceptEnter = false;
			this.CurrencyBox1.AllowEdit = true;
			this.CurrencyBox1.AllowNew = true;
			this.CurrencyBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.CurrencyBox1.FocusColor = true;
			this.CurrencyBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_B22_0 = this.CurrencyBox1;
			location = new global::System.Drawing.Point(59, 47);
			arg_B22_0.Location = location;
			this.CurrencyBox1.Name = "CurrencyBox1";
			this.CurrencyBox1.Nullable = true;
			this.CurrencyBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_B7B_0 = this.CurrencyBox1;
			size = new global::System.Drawing.Size(156, 36);
			arg_B7B_0.Size = size;
			this.CurrencyBox1.TabIndex = 0;
			this.CurrencyBox1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.CurrencyBox1.Value = value;
			this.CurrencyBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_C33_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_C33_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_C61_0 = this.Bar1;
			size = new global::System.Drawing.Size(675, 41);
			arg_C61_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.trash_bin;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف ردیف (F5)";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(9f, 19f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(675, 673);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Calc";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ماشین حساب";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000285 RID: 645
		private global::System.ComponentModel.IContainer components;
	}
}
