namespace FruitBox
{
	// Token: 0x02000110 RID: 272
	public partial class Frm_sms_ruzane : global::System.Windows.Forms.Form
	{
		// Token: 0x0600271E RID: 10014 RVA: 0x001DA1DC File Offset: 0x001D83DC
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

		// Token: 0x0600271F RID: 10015 RVA: 0x001DA22C File Offset: 0x001D842C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_sms_ruzane));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem7 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_tarikh_vurud = new global::FruitBox.DateBox2(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.txt_tarikh_vurud);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1A5_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1A5_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1D6_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1021, 545);
			arg_1D6_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_2EF_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 100);
			arg_2EF_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_347_0 = this.GridEX1;
			size = new global::System.Drawing.Size(1021, 445);
			arg_347_0.Size = size;
			this.GridEX1.TabIndex = 15;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem7,
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_455_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_455_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_483_0 = this.Bar1;
			size = new global::System.Drawing.Size(1021, 41);
			arg_483_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 14;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem7.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem7.Image = global::FruitBox.My.Resources.Resources.comment;
			this.ButtonItem7.Name = "ButtonItem7";
			this.ButtonItem7.Text = "ارسال پیامک";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ButtonItem1.Image");
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "ثبت شماره موبایل";
			this.txt_tarikh_vurud.AcceptEnter = true;
			this.txt_tarikh_vurud.AllowEdit = true;
			this.txt_tarikh_vurud.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tarikh_vurud.ButtonEnable = false;
			this.txt_tarikh_vurud.FocusDatePart = 2;
			this.txt_tarikh_vurud.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5D5_0 = this.txt_tarikh_vurud;
			location = new global::System.Drawing.Point(770, 58);
			arg_5D5_0.Location = location;
			this.txt_tarikh_vurud.Mask = "0000/00/00";
			this.txt_tarikh_vurud.Name = "txt_tarikh_vurud";
			this.txt_tarikh_vurud.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_621_0 = this.txt_tarikh_vurud;
			size = new global::System.Drawing.Size(197, 36);
			arg_621_0.Size = size;
			this.txt_tarikh_vurud.TabIndex = 5;
			this.txt_tarikh_vurud.Text = "1392/07/08";
			this.txt_tarikh_vurud.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_6B7_0 = this.Label1;
			location = new global::System.Drawing.Point(969, 69);
			arg_6B7_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_6E2_0 = this.Label1;
			size = new global::System.Drawing.Size(39, 19);
			arg_6E2_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "تاریخ";
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_781_0 = this.EditBox1;
			location = new global::System.Drawing.Point(350, 57);
			arg_781_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7DA_0 = this.EditBox1;
			size = new global::System.Drawing.Size(317, 36);
			arg_7DA_0.Size = size;
			this.EditBox1.TabIndex = 25;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_860_0 = this.Label2;
			location = new global::System.Drawing.Point(669, 68);
			arg_860_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_88B_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_88B_0.Size = size;
			this.Label2.TabIndex = 26;
			this.Label2.Text = "جستجو";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1021, 545);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_sms_ruzane";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "پیامک فروش روزانه";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F46 RID: 3910
		private global::System.ComponentModel.IContainer components;
	}
}
