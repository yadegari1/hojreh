namespace FruitBox
{
	// Token: 0x020000DA RID: 218
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_ShomareHesab : global::System.Windows.Forms.Form
	{
		// Token: 0x0600138E RID: 5006 RVA: 0x000CFF78 File Offset: 0x000CE178
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

		// Token: 0x0600138F RID: 5007 RVA: 0x000CFFC8 File Offset: 0x000CE1C8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_shobe = new global::FruitBox.SelectItem(this.components);
			this.txt_bank = new global::FruitBox.SelectItem(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txt_shomareHesab = new global::FruitBox.EditBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_shobe);
			this.UiGroupBox1.Controls.Add(this.txt_bank);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.txt_shomareHesab);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1B2_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1B2_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1E3_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(401, 262);
			arg_1E3_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.VS2010;
			this.txt_shobe.AcceptEnter = true;
			this.txt_shobe.AddNewForm = null;
			this.txt_shobe.AllowEdit = true;
			this.txt_shobe.AllowNew = true;
			this.txt_shobe.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_shobe.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_shobe.ButtonText = "...";
			this.txt_shobe.CanEdit = false;
			this.txt_shobe.DisplayMember = "Name";
			this.txt_shobe.Edit_Frm = null;
			this.txt_shobe.ExtraData = 0L;
			this.txt_shobe.FocusColor = true;
			this.txt_shobe.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "عنوان";
			column.Name = "Name";
			column.Size = 100;
			this.txt_shobe.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_323_0 = this.txt_shobe;
			location = new global::System.Drawing.Point(12, 145);
			arg_323_0.Location = location;
			this.txt_shobe.Name = "txt_shobe";
			this.txt_shobe.Nullable = false;
			this.txt_shobe.NullToolTipText = "شعبه را وارد نمائید";
			this.txt_shobe.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_shobe.SelectCommand = "select * from shobe";
			this.txt_shobe.SelectedRow = null;
			this.txt_shobe.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3A7_0 = this.txt_shobe;
			size = new global::System.Drawing.Size(275, 36);
			arg_3A7_0.Size = size;
			this.txt_shobe.TabIndex = 2;
			this.txt_shobe.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_shobe.Value = null;
			this.txt_shobe.ValueMember = "ID";
			this.txt_shobe.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_bank.AcceptEnter = true;
			this.txt_bank.AddNewForm = null;
			this.txt_bank.AllowEdit = true;
			this.txt_bank.AllowNew = true;
			this.txt_bank.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_bank.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_bank.ButtonText = "...";
			this.txt_bank.CanEdit = false;
			this.txt_bank.DisplayMember = "Name";
			this.txt_bank.Edit_Frm = null;
			this.txt_bank.ExtraData = 0L;
			this.txt_bank.FocusColor = true;
			this.txt_bank.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column2.Caption = "عنوان";
			column2.Name = "Name";
			column2.Size = 100;
			this.txt_bank.Items.AddRange(new global::FruitBox.Column[]
			{
				column2
			});
			global::System.Windows.Forms.Control arg_50F_0 = this.txt_bank;
			location = new global::System.Drawing.Point(12, 102);
			arg_50F_0.Location = location;
			this.txt_bank.Name = "txt_bank";
			this.txt_bank.Nullable = false;
			this.txt_bank.NullToolTipText = "بانک را مشخص کنید";
			this.txt_bank.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_bank.SelectCommand = "select * from bank";
			this.txt_bank.SelectedRow = null;
			this.txt_bank.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_593_0 = this.txt_bank;
			size = new global::System.Drawing.Size(275, 36);
			arg_593_0.Size = size;
			this.txt_bank.TabIndex = 1;
			this.txt_bank.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_bank.Value = null;
			this.txt_bank.ValueMember = "ID";
			this.txt_bank.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_670_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_670_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_69E_0 = this.Bar1;
			size = new global::System.Drawing.Size(401, 41);
			arg_69E_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.page;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "جدید (Ins)";
			this.ButtonItem1.Visible = false;
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.bin_closed;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف (F5)";
			this.ButtonItem3.Visible = false;
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_82B_0 = this.Label3;
			location = new global::System.Drawing.Point(289, 155);
			arg_82B_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_856_0 = this.Label3;
			size = new global::System.Drawing.Size(48, 19);
			arg_856_0.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "شعبه";
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_8DE_0 = this.Label2;
			location = new global::System.Drawing.Point(289, 112);
			arg_8DE_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_909_0 = this.Label2;
			size = new global::System.Drawing.Size(37, 19);
			arg_909_0.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "بانک";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_991_0 = this.Label1;
			location = new global::System.Drawing.Point(289, 69);
			arg_991_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_9BC_0 = this.Label1;
			size = new global::System.Drawing.Size(105, 19);
			arg_9BC_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "شماره حساب";
			this.txt_shomareHesab.AcceptEnter = true;
			this.txt_shomareHesab.AllowEdit = true;
			this.txt_shomareHesab.AllowNew = true;
			this.txt_shomareHesab.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_shomareHesab.FocusColor = true;
			this.txt_shomareHesab.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A57_0 = this.txt_shomareHesab;
			location = new global::System.Drawing.Point(12, 60);
			arg_A57_0.Location = location;
			this.txt_shomareHesab.Name = "txt_shomareHesab";
			this.txt_shomareHesab.Nullable = false;
			this.txt_shomareHesab.NullToolTipText = "شماره حساب وا وارد نمائید";
			this.txt_shomareHesab.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_AB0_0 = this.txt_shomareHesab;
			size = new global::System.Drawing.Size(275, 36);
			arg_AB0_0.Size = size;
			this.txt_shomareHesab.TabIndex = 0;
			this.txt_shomareHesab.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(401, 262);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_ShomareHesab";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "اصلاح شماره حساب";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000791 RID: 1937
		private global::System.ComponentModel.IContainer components;
	}
}
