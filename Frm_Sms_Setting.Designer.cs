namespace FruitBox
{
	// Token: 0x0200007F RID: 127
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sms_Setting : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AFD RID: 2813 RVA: 0x0008B7CC File Offset: 0x000899CC
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

		// Token: 0x06000AFE RID: 2814 RVA: 0x0008B81C File Offset: 0x00089A1C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_apikey = new global::Janus.Windows.GridEX.EditControls.EditBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.txt_credit = new global::FruitBox.CurrencyBox(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_pass = new global::FruitBox.EditBox(this.components);
			this.txt_user = new global::FruitBox.EditBox(this.components);
			this.txt_titr = new global::FruitBox.EditBox(this.components);
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_apikey);
			this.UiGroupBox1.Controls.Add(this.PictureBox1);
			this.UiGroupBox1.Controls.Add(this.txt_credit);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.txt_pass);
			this.UiGroupBox1.Controls.Add(this.txt_user);
			this.UiGroupBox1.Controls.Add(this.txt_titr);
			this.UiGroupBox1.Controls.Add(this.Label5);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label6);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_28A_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_28A_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_2BA_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(690, 564);
			arg_2BA_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			global::System.Windows.Forms.Control arg_2ED_0 = this.txt_apikey;
			location = new global::System.Drawing.Point(63, 110);
			arg_2ED_0.Location = location;
			this.txt_apikey.Name = "txt_apikey";
			this.txt_apikey.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control arg_327_0 = this.txt_apikey;
			size = new global::System.Drawing.Size(533, 36);
			arg_327_0.Size = size;
			this.txt_apikey.TabIndex = 1;
			this.txt_apikey.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.PictureBox1.Image = global::FruitBox.My.Resources.Resources.comment1;
			global::System.Windows.Forms.Control arg_37F_0 = this.PictureBox1;
			location = new global::System.Drawing.Point(12, 480);
			arg_37F_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control arg_3A9_0 = this.PictureBox1;
			size = new global::System.Drawing.Size(74, 72);
			arg_3A9_0.Size = size;
			this.PictureBox1.TabIndex = 19;
			this.PictureBox1.TabStop = false;
			this.txt_credit.AcceptEnter = true;
			this.txt_credit.AllowEdit = false;
			this.txt_credit.AllowNew = true;
			this.txt_credit.FocusColor = true;
			global::System.Windows.Forms.Control arg_417_0 = this.txt_credit;
			location = new global::System.Drawing.Point(413, 238);
			arg_417_0.Location = location;
			this.txt_credit.Name = "txt_credit";
			this.txt_credit.Nullable = true;
			this.txt_credit.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_credit.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_46F_0 = this.txt_credit;
			size = new global::System.Drawing.Size(183, 36);
			arg_46F_0.Size = size;
			this.txt_credit.TabIndex = 4;
			this.txt_credit.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_credit.Value = value;
			this.txt_credit.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_531_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_531_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_55E_0 = this.Bar1;
			size = new global::System.Drawing.Size(690, 41);
			arg_55E_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 17;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.disk;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.money_coins_add;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "شارژ حساب";
			this.txt_pass.AcceptEnter = true;
			this.txt_pass.AllowEdit = true;
			this.txt_pass.AllowNew = true;
			this.txt_pass.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_pass.FocusColor = true;
			global::System.Windows.Forms.Control arg_682_0 = this.txt_pass;
			location = new global::System.Drawing.Point(63, 194);
			arg_682_0.Location = location;
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Nullable = true;
			this.txt_pass.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_pass.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_pass.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_6E7_0 = this.txt_pass;
			size = new global::System.Drawing.Size(533, 36);
			arg_6E7_0.Size = size;
			this.txt_pass.TabIndex = 3;
			this.txt_pass.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_user.AcceptEnter = true;
			this.txt_user.AllowEdit = true;
			this.txt_user.AllowNew = true;
			this.txt_user.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_user.FocusColor = true;
			global::System.Windows.Forms.Control arg_75F_0 = this.txt_user;
			location = new global::System.Drawing.Point(63, 152);
			arg_75F_0.Location = location;
			this.txt_user.Name = "txt_user";
			this.txt_user.Nullable = true;
			this.txt_user.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_user.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_user.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7C4_0 = this.txt_user;
			size = new global::System.Drawing.Size(533, 36);
			arg_7C4_0.Size = size;
			this.txt_user.TabIndex = 2;
			this.txt_user.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_titr.AcceptEnter = true;
			this.txt_titr.AllowEdit = true;
			this.txt_titr.AllowNew = true;
			this.txt_titr.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_titr.FocusColor = true;
			global::System.Windows.Forms.Control arg_839_0 = this.txt_titr;
			location = new global::System.Drawing.Point(63, 68);
			arg_839_0.Location = location;
			this.txt_titr.Name = "txt_titr";
			this.txt_titr.Nullable = true;
			this.txt_titr.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_titr.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_891_0 = this.txt_titr;
			size = new global::System.Drawing.Size(533, 36);
			arg_891_0.Size = size;
			this.txt_titr.TabIndex = 0;
			this.txt_titr.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_8F6_0 = this.Label5;
			location = new global::System.Drawing.Point(371, 242);
			arg_8F6_0.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control arg_920_0 = this.Label5;
			size = new global::System.Drawing.Size(40, 28);
			arg_920_0.Size = size;
			this.Label5.TabIndex = 0;
			this.Label5.Text = "ریال";
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_989_0 = this.Label4;
			location = new global::System.Drawing.Point(598, 243);
			arg_989_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_9B3_0 = this.Label4;
			size = new global::System.Drawing.Size(95, 28);
			arg_9B3_0.Size = size;
			this.Label4.TabIndex = 0;
			this.Label4.Text = "اعتبار حساب";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_A1C_0 = this.Label3;
			location = new global::System.Drawing.Point(598, 199);
			arg_A1C_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_A46_0 = this.Label3;
			size = new global::System.Drawing.Size(67, 28);
			arg_A46_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "رمز عبور";
			this.Label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_AAC_0 = this.Label6;
			location = new global::System.Drawing.Point(598, 73);
			arg_AAC_0.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control arg_AD6_0 = this.Label6;
			size = new global::System.Drawing.Size(78, 28);
			arg_AD6_0.Size = size;
			this.Label6.TabIndex = 0;
			this.Label6.Text = "تیتر پیامک";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_B3F_0 = this.Label2;
			location = new global::System.Drawing.Point(598, 157);
			arg_B3F_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_B69_0 = this.Label2;
			size = new global::System.Drawing.Size(80, 28);
			arg_B69_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "نام کاربری";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_BCF_0 = this.Label1;
			location = new global::System.Drawing.Point(598, 115);
			arg_BCF_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_BF9_0 = this.Label1;
			size = new global::System.Drawing.Size(80, 28);
			arg_BF9_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "کلید پیامک";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(10f, 28f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(690, 564);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sms_Setting";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تنظیمات پیامک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000457 RID: 1111
		private global::System.ComponentModel.IContainer components;
	}
}
