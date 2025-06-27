namespace FruitBox
{
	// Token: 0x020000E5 RID: 229
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_DaryaftCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x060015C6 RID: 5574 RVA: 0x000EBDC4 File Offset: 0x000E9FC4
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

		// Token: 0x060015C7 RID: 5575 RVA: 0x000EBE14 File Offset: 0x000EA014
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_DaryaftCheck));
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.RibbonStatusBar1 = new global::Janus.Windows.Ribbon.RibbonStatusBar();
			this.lbl_code = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_check = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand4 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_jam = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand6 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_codem = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand2 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.lbl_name = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand3 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.LabelCommand1 = new global::Janus.Windows.Ribbon.LabelCommand();
			this.txt_tarikhGrid = new global::FruitBox.DateBox2(this.components);
			this.txt_mablagh = new global::FruitBox.CurrencyBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
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
			global::System.Windows.Forms.Control arg_1F2_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1F2_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_230_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1106, 442);
			arg_230_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.RibbonStatusBar1.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.RibbonStatusBar1.LeftPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.lbl_code,
				this.lbl_check,
				this.LabelCommand4,
				this.lbl_jam,
				this.LabelCommand6
			});
			global::System.Windows.Forms.Control arg_2DA_0 = this.RibbonStatusBar1;
			location = new global::System.Drawing.Point(0, 419);
			arg_2DA_0.Location = location;
			this.RibbonStatusBar1.Name = "RibbonStatusBar1";
			this.RibbonStatusBar1.RightPanelCommands.AddRange(new global::Janus.Windows.Ribbon.CommandBase[]
			{
				this.lbl_codem,
				this.LabelCommand2,
				this.lbl_name,
				this.LabelCommand3,
				this.LabelCommand1
			});
			this.RibbonStatusBar1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_367_0 = this.RibbonStatusBar1;
			size = new global::System.Drawing.Size(1106, 23);
			arg_367_0.Size = size;
			this.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
			this.RibbonStatusBar1.SuperTipComponent.ImageList = null;
			this.RibbonStatusBar1.TabIndex = 24;
			this.RibbonStatusBar1.Text = "RibbonStatusBar1";
			this.RibbonStatusBar1.VisualStyle = global::Janus.Windows.Ribbon.VisualStyle.Office2010;
			this.lbl_code.Key = "LabelCommand2";
			this.lbl_code.Name = "lbl_code";
			this.lbl_check.Key = "LabelCommand1";
			this.lbl_check.Name = "lbl_check";
			this.lbl_check.Style = global::Janus.Windows.Ribbon.CommandStyle.Text;
			this.LabelCommand4.Key = "LabelCommand4";
			this.LabelCommand4.Name = "LabelCommand4";
			this.LabelCommand4.Text = "جمع چک ها";
			this.lbl_jam.Key = "LabelCommand5";
			this.lbl_jam.Name = "lbl_jam";
			this.LabelCommand6.Key = "LabelCommand6";
			this.LabelCommand6.Name = "LabelCommand6";
			this.LabelCommand6.Text = "جمع کل دریافتی";
			this.lbl_codem.Key = "LabelCommand1";
			this.lbl_codem.Name = "lbl_codem";
			this.LabelCommand2.Key = "LabelCommand2";
			this.LabelCommand2.Name = "LabelCommand2";
			this.LabelCommand2.Text = "کد مشتری";
			this.lbl_name.Key = "LabelCommand1";
			this.lbl_name.Name = "lbl_name";
			this.LabelCommand3.Key = "LabelCommand3";
			this.LabelCommand3.Name = "LabelCommand3";
			this.LabelCommand3.Style = global::Janus.Windows.Ribbon.CommandStyle.ImageAndText;
			this.LabelCommand3.Text = "نام مشتری";
			this.LabelCommand1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LabelCommand1.Image");
			this.LabelCommand1.Key = "LabelCommand1";
			this.LabelCommand1.Name = "LabelCommand1";
			this.txt_tarikhGrid.AcceptEnter = false;
			this.txt_tarikhGrid.AllowEdit = true;
			this.txt_tarikhGrid.BorderStyle = global::Janus.Windows.GridEX.BorderStyle.None;
			this.txt_tarikhGrid.ButtonEnable = false;
			this.txt_tarikhGrid.ButtonEnabled = false;
			this.txt_tarikhGrid.FocusDatePart = 1;
			global::System.Windows.Forms.Control arg_5F4_0 = this.txt_tarikhGrid;
			location = new global::System.Drawing.Point(12, 395);
			arg_5F4_0.Location = location;
			this.txt_tarikhGrid.Mask = "0000/00/00";
			this.txt_tarikhGrid.Name = "txt_tarikhGrid";
			this.txt_tarikhGrid.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_63D_0 = this.txt_tarikhGrid;
			size = new global::System.Drawing.Size(100, 19);
			arg_63D_0.Size = size;
			this.txt_tarikhGrid.TabIndex = 23;
			this.txt_tarikhGrid.Text = "1393/05/28";
			this.txt_tarikhGrid.Visible = false;
			this.txt_tarikhGrid.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_mablagh.AcceptEnter = true;
			this.txt_mablagh.AllowEdit = true;
			this.txt_mablagh.AllowNew = true;
			this.txt_mablagh.FocusColor = false;
			global::System.Windows.Forms.Control arg_6CA_0 = this.txt_mablagh;
			location = new global::System.Drawing.Point(455, 186);
			arg_6CA_0.Location = location;
			this.txt_mablagh.Name = "txt_mablagh";
			this.txt_mablagh.Nullable = true;
			this.txt_mablagh.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mablagh.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_720_0 = this.txt_mablagh;
			size = new global::System.Drawing.Size(100, 21);
			arg_720_0.Size = size;
			this.txt_mablagh.TabIndex = 1;
			this.txt_mablagh.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Near;
			long? value;
			this.txt_mablagh.Value = value;
			this.txt_mablagh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1106, 442);
			this.ClientSize = size;
			this.Controls.Add(this.RibbonStatusBar1);
			this.Controls.Add(this.txt_tarikhGrid);
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.txt_mablagh);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_DaryaftCheck";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "دریافت چک - حذف ردیف=F5";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000876 RID: 2166
		private global::System.ComponentModel.IContainer components;
	}
}
