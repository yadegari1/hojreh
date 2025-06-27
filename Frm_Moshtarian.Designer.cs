namespace FruitBox
{
	// Token: 0x020000FF RID: 255
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Moshtarian : global::System.Windows.Forms.Form
	{
		// Token: 0x06002105 RID: 8453 RVA: 0x0018A334 File Offset: 0x00188534
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

		// Token: 0x06002106 RID: 8454 RVA: 0x0018A384 File Offset: 0x00188584
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Moshtarian));
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.MetroStatusBar1 = new global::DevComponents.DotNetBar.Metro.MetroStatusBar();
			this.LabelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.lbl_kol = new global::DevComponents.DotNetBar.LabelItem();
			this.LabelItem2 = new global::DevComponents.DotNetBar.LabelItem();
			this.lbl_jamCheck = new global::DevComponents.DotNetBar.LabelItem();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.txt_tarikhGrid = new global::FruitBox.DateBox2(this.components);
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			this.GridEX1.AutomaticSort = false;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_1E1_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 41);
			arg_1E1_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_21F_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1111, 379);
			arg_21F_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.MetroStatusBar1.BackgroundStyle.BackColor = global::System.Drawing.Color.SkyBlue;
			this.MetroStatusBar1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.MetroStatusBar1.ContainerControlProcessDialogKey = true;
			this.MetroStatusBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.MetroStatusBar1.DragDropSupport = true;
			this.MetroStatusBar1.Font = new global::System.Drawing.Font("Segoe UI", 10.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MetroStatusBar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.LabelItem1,
				this.lbl_kol,
				this.LabelItem2,
				this.lbl_jamCheck
			});
			global::System.Windows.Forms.Control arg_309_0 = this.MetroStatusBar1;
			location = new global::System.Drawing.Point(0, 420);
			arg_309_0.Location = location;
			this.MetroStatusBar1.Name = "MetroStatusBar1";
			global::System.Windows.Forms.Control arg_337_0 = this.MetroStatusBar1;
			size = new global::System.Drawing.Size(1111, 22);
			arg_337_0.Size = size;
			this.MetroStatusBar1.TabIndex = 2;
			this.MetroStatusBar1.Visible = false;
			this.LabelItem1.Name = "LabelItem1";
			this.LabelItem1.Text = "مبلغ کل";
			this.lbl_kol.Name = "lbl_kol";
			this.LabelItem2.Name = "LabelItem2";
			this.LabelItem2.Text = "                     جمع چکها";
			this.lbl_jamCheck.Name = "lbl_jamCheck";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2
			});
			global::DevComponents.DotNetBar.Bar arg_42D_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_42D_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_45B_0 = this.Bar1;
			size = new global::System.Drawing.Size(1111, 41);
			arg_45B_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 24;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.save;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.txt_tarikhGrid.AcceptEnter = false;
			this.txt_tarikhGrid.AllowEdit = true;
			this.txt_tarikhGrid.BorderStyle = global::Janus.Windows.GridEX.BorderStyle.None;
			this.txt_tarikhGrid.ButtonEnable = false;
			this.txt_tarikhGrid.ButtonEnabled = false;
			this.txt_tarikhGrid.FocusDatePart = 1;
			global::System.Windows.Forms.Control arg_54C_0 = this.txt_tarikhGrid;
			location = new global::System.Drawing.Point(12, 395);
			arg_54C_0.Location = location;
			this.txt_tarikhGrid.Mask = "0000/00/00";
			this.txt_tarikhGrid.Name = "txt_tarikhGrid";
			this.txt_tarikhGrid.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_595_0 = this.txt_tarikhGrid;
			size = new global::System.Drawing.Size(100, 19);
			arg_595_0.Size = size;
			this.txt_tarikhGrid.TabIndex = 23;
			this.txt_tarikhGrid.Text = "1393/05/28";
			this.txt_tarikhGrid.Visible = false;
			this.txt_tarikhGrid.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_mablagh.AcceptEnter = true;
			this.txt_mablagh.AllowEdit = true;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.FocusColor = false;
			global::System.Windows.Forms.Control arg_622_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(455, 186);
			arg_622_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_678_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(100, 21);
			arg_678_0.Size = size;
			this.txt_mablagh.TabIndex = 1;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			long? value;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Timer1.Enabled = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1111, 442);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.Bar1);
			this.Controls.Add(this.txt_tarikhGrid);
			this.Controls.Add(this.MetroStatusBar1);
			this.Controls.Add(this.txt_mablagh);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Moshtarian";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تعریف مشتریان";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000CD0 RID: 3280
		private global::System.ComponentModel.IContainer components;
	}
}
