namespace FruitBox
{
	// Token: 0x020000DF RID: 223
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_BastanSandug : global::System.Windows.Forms.Form
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x000D4F9C File Offset: 0x000D319C
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

		// Token: 0x06001425 RID: 5157 RVA: 0x000D4FEC File Offset: 0x000D31EC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.CurrencyBox1 = new global::FruitBox.CurrencyBox(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.UiButton3 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Controls.Add(this.UiButton3);
			this.UiGroupBox1.Controls.Add(this.UiButton2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_16D_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_16D_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_19D_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(440, 304);
			arg_19D_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.CurrencyBox1);
			this.UiGroupBox2.Controls.Add(this.Label1);
			this.UiGroupBox2.Controls.Add(this.Label3);
			this.UiGroupBox2.Controls.Add(this.Label5);
			this.UiGroupBox2.Controls.Add(this.Label2);
			this.UiGroupBox2.Controls.Add(this.Label4);
			this.UiGroupBox2.Controls.Add(this.Label6);
			this.UiGroupBox2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_29E_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(6, 3);
			arg_29E_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_2CE_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(425, 260);
			arg_2CE_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.CurrencyBox1.AcceptEnter = true;
			this.CurrencyBox1.AllowEdit = true;
			this.CurrencyBox1.AllowNew = true;
			this.CurrencyBox1.AllowZero = true;
			this.CurrencyBox1.FocusColor = true;
			this.CurrencyBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_364_0 = this.CurrencyBox1;
			location = new global::System.Drawing.Point(12, 62);
			arg_364_0.Location = location;
			this.CurrencyBox1.Name = "CurrencyBox1";
			this.CurrencyBox1.Nullable = true;
			this.CurrencyBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.CurrencyBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3BC_0 = this.CurrencyBox1;
			size = new global::System.Drawing.Size(240, 36);
			arg_3BC_0.Size = size;
			this.CurrencyBox1.TabIndex = 0;
			this.CurrencyBox1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.CurrencyBox1.Value = value;
			this.CurrencyBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_42B_0 = this.Label1;
			location = new global::System.Drawing.Point(255, 31);
			arg_42B_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_458_0 = this.Label1;
			size = new global::System.Drawing.Size(142, 19);
			arg_458_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "موجودی نقد صندوق";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_4B0_0 = this.Label3;
			location = new global::System.Drawing.Point(254, 70);
			arg_4B0_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_4DA_0 = this.Label3;
			size = new global::System.Drawing.Size(101, 19);
			arg_4DA_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "موجودی جدید";
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_525_0 = this.Label5;
			location = new global::System.Drawing.Point(253, 107);
			arg_525_0.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control arg_552_0 = this.Label5;
			size = new global::System.Drawing.Size(143, 29);
			arg_552_0.Size = size;
			this.Label5.TabIndex = 1;
			this.Label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5C6_0 = this.Label2;
			location = new global::System.Drawing.Point(12, 23);
			arg_5C6_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_5F3_0 = this.Label2;
			size = new global::System.Drawing.Size(240, 36);
			arg_5F3_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_667_0 = this.Label4;
			location = new global::System.Drawing.Point(12, 101);
			arg_667_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_694_0 = this.Label4;
			size = new global::System.Drawing.Size(240, 38);
			arg_694_0.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Label6.BackColor = global::System.Drawing.Color.Transparent;
			this.Label6.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_70B_0 = this.Label6;
			location = new global::System.Drawing.Point(12, 142);
			arg_70B_0.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control arg_738_0 = this.Label6;
			size = new global::System.Drawing.Size(407, 106);
			arg_738_0.Size = size;
			this.Label6.TabIndex = 2;
			this.Label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.UiButton3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_794_0 = this.UiButton3;
			location = new global::System.Drawing.Point(315, 272);
			arg_794_0.Location = location;
			this.UiButton3.Name = "UiButton3";
			this.UiButton3.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton3.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_7DC_0 = this.UiButton3;
			size = new global::System.Drawing.Size(122, 32);
			arg_7DC_0.Size = size;
			this.UiButton3.TabIndex = 2;
			this.UiButton3.Text = "ریز حساب";
			this.UiButton3.Visible = false;
			this.UiButton3.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.delete;
			global::System.Windows.Forms.Control arg_862_0 = this.UiButton2;
			location = new global::System.Drawing.Point(6, 268);
			arg_862_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_8AA_0 = this.UiButton2;
			size = new global::System.Drawing.Size(93, 32);
			arg_8AA_0.Size = size;
			this.UiButton2.TabIndex = 2;
			this.UiButton2.Text = "انصراف";
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.accept;
			global::System.Windows.Forms.Control arg_924_0 = this.UiButton1;
			location = new global::System.Drawing.Point(105, 268);
			arg_924_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_96F_0 = this.UiButton1;
			size = new global::System.Drawing.Size(153, 32);
			arg_96F_0.Size = size;
			this.UiButton1.TabIndex = 1;
			this.UiButton1.Text = "تایید";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(440, 304);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_BastanSandug";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "بستن صندوق";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040007D2 RID: 2002
		private global::System.ComponentModel.IContainer components;
	}
}
