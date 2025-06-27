namespace FruitBox
{
	// Token: 0x02000130 RID: 304
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Rpt_Furush : global::System.Windows.Forms.Form
	{
		// Token: 0x06002BF7 RID: 11255 RVA: 0x0020B284 File Offset: 0x00209484
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

		// Token: 0x06002BF8 RID: 11256 RVA: 0x0020B2D4 File Offset: 0x002094D4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Rpt_Furush));
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.txt_moshtari = new global::FruitBox.SelectItem(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.txt_moshtari);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1A1_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1A1_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1D2_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(810, 473);
			arg_1D2_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Samim", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_257_0 = this.Label2;
			location = new global::System.Drawing.Point(728, 86);
			arg_257_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_282_0 = this.Label2;
			size = new global::System.Drawing.Size(58, 24);
			arg_282_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "جستجو";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Samim", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_30B_0 = this.Label1;
			location = new global::System.Drawing.Point(728, 53);
			arg_30B_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_336_0 = this.Label1;
			size = new global::System.Drawing.Size(75, 24);
			arg_336_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "صاحب بار";
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_3D5_0 = this.EditBox1;
			location = new global::System.Drawing.Point(464, 84);
			arg_3D5_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_42E_0 = this.EditBox1;
			size = new global::System.Drawing.Size(262, 27);
			arg_42E_0.Size = size;
			this.EditBox1.TabIndex = 1;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_4F8_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 122);
			arg_4F8_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_55D_0 = this.GridEX1;
			size = new global::System.Drawing.Size(810, 351);
			arg_55D_0.Size = size;
			this.GridEX1.TabIndex = 2;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_moshtari.AcceptEnter = true;
			this.txt_moshtari.AddNewForm = null;
			this.txt_moshtari.AllowEdit = true;
			this.txt_moshtari.AllowNew = true;
			this.txt_moshtari.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_moshtari.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_moshtari.ButtonText = "...";
			this.txt_moshtari.CanEdit = true;
			this.txt_moshtari.DisplayMember = "Name";
			this.txt_moshtari.Edit_Frm = null;
			this.txt_moshtari.ExtraData = 0L;
			this.txt_moshtari.FocusColor = true;
			this.txt_moshtari.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "مشتری";
			column2.Name = "Name";
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
			global::System.Windows.Forms.Control arg_737_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(464, 51);
			arg_737_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			this.txt_moshtari.Nullable = false;
			this.txt_moshtari.NullToolTipText = "لطفا صاحب بار را مشخص فرمائید";
			this.txt_moshtari.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.txt_moshtari.SelectCommand = componentResourceManager.GetString("txt_moshtari.SelectCommand");
			this.txt_moshtari.SelectedRow = null;
			this.txt_moshtari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7C2_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(262, 27);
			arg_7C2_0.Size = size;
			this.txt_moshtari.TabIndex = 0;
			this.txt_moshtari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			this.txt_moshtari.Value = null;
			this.txt_moshtari.ValueMember = "ID";
			this.txt_moshtari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_88A_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_88A_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_8B8_0 = this.Bar1;
			size = new global::System.Drawing.Size(810, 41);
			arg_8B8_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 21;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(810, 473);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Rpt_Furush";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "چاپ خرید و فروش";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400111C RID: 4380
		private global::System.ComponentModel.IContainer components;
	}
}
