namespace FruitBox
{
	// Token: 0x0200010C RID: 268
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_safiEzafe : global::System.Windows.Forms.Form
	{
		// Token: 0x06002679 RID: 9849 RVA: 0x001D1D14 File Offset: 0x001CFF14
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

		// Token: 0x0600267A RID: 9850 RVA: 0x001D1D64 File Offset: 0x001CFF64
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_safikol = new global::FruitBox.CurrencyBox(this.components);
			this.txt_safi = new global::FruitBox.CurrencyBox(this.components);
			this.txt_ezafe = new global::FruitBox.CurrencyBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_F7_0 = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(307, 100);
			arg_F7_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_122_0 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(109, 19);
			arg_122_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "اضافه به فروش";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_188_0 = this.Label2;
			location = new global::System.Drawing.Point(307, 58);
			arg_188_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_1B3_0 = this.Label2;
			size = new global::System.Drawing.Size(49, 19);
			arg_1B3_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "فروش";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_21C_0 = this.Label3;
			location = new global::System.Drawing.Point(307, 141);
			arg_21C_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_247_0 = this.Label3;
			size = new global::System.Drawing.Size(84, 19);
			arg_247_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "جمع فروش";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.txt_safikol);
			this.UiGroupBox1.Controls.Add(this.txt_safi);
			this.UiGroupBox1.Controls.Add(this.txt_ezafe);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_344_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_344_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_375_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(426, 383);
			arg_375_0.Size = size;
			this.UiGroupBox1.TabIndex = 2;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2
			});
			global::DevComponents.DotNetBar.Bar arg_411_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_411_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_43F_0 = this.Bar1;
			size = new global::System.Drawing.Size(426, 41);
			arg_43F_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 14;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.txt_safikol.AcceptEnter = true;
			this.txt_safikol.AllowEdit = false;
			this.txt_safikol.AllowNew = true;
			this.txt_safikol.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_safikol.FocusColor = true;
			this.txt_safikol.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_548_0 = this.txt_safikol;
			location = new global::System.Drawing.Point(132, 131);
			arg_548_0.Location = location;
			this.txt_safikol.Name = "txt_safikol";
			this.txt_safikol.Nullable = true;
			this.txt_safikol.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_safikol.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_5A1_0 = this.txt_safikol;
			size = new global::System.Drawing.Size(173, 36);
			arg_5A1_0.Size = size;
			this.txt_safikol.TabIndex = 1;
			this.txt_safikol.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_safikol.Value = value;
			this.txt_safikol.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_safi.AcceptEnter = true;
			this.txt_safi.AllowEdit = false;
			this.txt_safi.AllowNew = true;
			this.txt_safi.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_safi.FocusColor = true;
			this.txt_safi.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_656_0 = this.txt_safi;
			location = new global::System.Drawing.Point(132, 47);
			arg_656_0.Location = location;
			this.txt_safi.Name = "txt_safi";
			this.txt_safi.Nullable = true;
			this.txt_safi.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_safi.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_6AF_0 = this.txt_safi;
			size = new global::System.Drawing.Size(173, 36);
			arg_6AF_0.Size = size;
			this.txt_safi.TabIndex = 2;
			this.txt_safi.TabStop = false;
			this.txt_safi.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_safi.Value = value;
			this.txt_safi.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_ezafe.AcceptEnter = true;
			this.txt_ezafe.AllowEdit = true;
			this.txt_ezafe.AllowNew = true;
			this.txt_ezafe.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_ezafe.FocusColor = true;
			this.txt_ezafe.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_771_0 = this.txt_ezafe;
			location = new global::System.Drawing.Point(132, 89);
			arg_771_0.Location = location;
			this.txt_ezafe.Name = "txt_ezafe";
			this.txt_ezafe.Nullable = true;
			this.txt_ezafe.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_ezafe.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7CA_0 = this.txt_ezafe;
			size = new global::System.Drawing.Size(173, 36);
			arg_7CA_0.Size = size;
			this.txt_ezafe.TabIndex = 0;
			this.txt_ezafe.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_ezafe.Value = value;
			this.txt_ezafe.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(9f, 19f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(426, 383);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_safiEzafe";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "اضافه به فروش";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F0C RID: 3852
		private global::System.ComponentModel.IContainer components;
	}
}
