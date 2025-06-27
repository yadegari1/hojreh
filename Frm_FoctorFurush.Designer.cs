namespace FruitBox
{
	// Token: 0x0200011E RID: 286
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_FoctorFurush : global::System.Windows.Forms.Form
	{
		// Token: 0x060029C9 RID: 10697 RVA: 0x001F8088 File Offset: 0x001F6288
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

		// Token: 0x060029CA RID: 10698 RVA: 0x001F80D8 File Offset: 0x001F62D8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_FoctorFurush));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.txt_moshtari = new global::FruitBox.SelectItem(this.components);
			this.txt_tarikh = new global::FruitBox.DateBox2(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.txt_moshtari);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.txt_tarikh);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1F3_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1F3_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_224_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(846, 453);
			arg_224_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2
			});
			global::DevComponents.DotNetBar.Bar arg_2CC_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_2CC_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_2FA_0 = this.Bar1;
			size = new global::System.Drawing.Size(846, 41);
			arg_2FA_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.select_all;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "انتخاب همه (F5)";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_42B_0 = this.Label3;
			location = new global::System.Drawing.Point(278, 55);
			arg_42B_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_456_0 = this.Label3;
			size = new global::System.Drawing.Size(84, 19);
			arg_456_0.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "نام مشتری";
			this.Label3.Visible = false;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4EC_0 = this.Label2;
			location = new global::System.Drawing.Point(582, 55);
			arg_4EC_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_517_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_517_0.Size = size;
			this.Label2.TabIndex = 3;
			this.Label2.Text = "مشتری";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5A0_0 = this.Label1;
			location = new global::System.Drawing.Point(799, 54);
			arg_5A0_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_5CB_0 = this.Label1;
			size = new global::System.Drawing.Size(39, 19);
			arg_5CB_0.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "تاریخ";
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_686_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 92);
			arg_686_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			global::System.Windows.Forms.Control arg_6B7_0 = this.GridEX1;
			size = new global::System.Drawing.Size(846, 361);
			arg_6B7_0.Size = size;
			this.GridEX1.TabIndex = 3;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_74F_0 = this.EditBox1;
			location = new global::System.Drawing.Point(27, 50);
			arg_74F_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7A8_0 = this.EditBox1;
			size = new global::System.Drawing.Size(249, 27);
			arg_7A8_0.Size = size;
			this.EditBox1.TabIndex = 2;
			this.EditBox1.Visible = false;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_moshtari.AcceptEnter = true;
			this.txt_moshtari.AddNewForm = null;
			this.txt_moshtari.AllowEdit = true;
			this.txt_moshtari.AllowNew = true;
			this.txt_moshtari.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_moshtari.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_moshtari.ButtonText = "...";
			this.txt_moshtari.CanEdit = true;
			this.txt_moshtari.DisplayMember = "moshtari_Name";
			this.txt_moshtari.Edit_Frm = null;
			this.txt_moshtari.ExtraData = 0L;
			this.txt_moshtari.FocusColor = true;
			this.txt_moshtari.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "مشتری";
			column2.Name = "moshtari_Name";
			column2.Size = 65;
			column3.Caption = "منطقه";
			column3.Name = "shahr";
			column3.Size = 20;
			this.txt_moshtari.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2,
				column3
			});
			global::System.Windows.Forms.Control arg_944_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(392, 50);
			arg_944_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			this.txt_moshtari.Nullable = false;
			this.txt_moshtari.NullToolTipText = "لطفا صاحب بار را مشخص فرمائید";
			this.txt_moshtari.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.txt_moshtari.SelectCommand = componentResourceManager.GetString("txt_moshtari.SelectCommand");
			this.txt_moshtari.SelectedRow = null;
			this.txt_moshtari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_9CF_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(188, 36);
			arg_9CF_0.Size = size;
			this.txt_moshtari.TabIndex = 1;
			this.txt_moshtari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_moshtari.Value = null;
			this.txt_moshtari.ValueMember = "ID";
			this.txt_moshtari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_tarikh.AcceptEnter = true;
			this.txt_tarikh.AllowEdit = true;
			this.txt_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tarikh.ButtonEnable = true;
			this.txt_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.txt_tarikh.FocusDatePart = 2;
			this.txt_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_AA2_0 = this.txt_tarikh;
			location = new global::System.Drawing.Point(657, 50);
			arg_AA2_0.Location = location;
			this.txt_tarikh.Mask = "0000/00/00";
			this.txt_tarikh.Name = "txt_tarikh";
			this.txt_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_AEE_0 = this.txt_tarikh;
			size = new global::System.Drawing.Size(135, 36);
			arg_AEE_0.Size = size;
			this.txt_tarikh.TabIndex = 0;
			this.txt_tarikh.Text = "1394/10/10";
			this.txt_tarikh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Center;
			this.txt_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(846, 453);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_FoctorFurush";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "فاکتور فروش";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04001051 RID: 4177
		private global::System.ComponentModel.IContainer components;
	}
}
