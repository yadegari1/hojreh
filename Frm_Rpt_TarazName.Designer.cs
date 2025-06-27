namespace FruitBox
{
	// Token: 0x02000139 RID: 313
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Rpt_TarazName : global::System.Windows.Forms.Form
	{
		// Token: 0x06002D8C RID: 11660 RVA: 0x0021C6B4 File Offset: 0x0021A8B4
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

		// Token: 0x06002D8D RID: 11661 RVA: 0x0021C704 File Offset: 0x0021A904
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Rpt_TarazName));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.GridEX2 = new global::Janus.Windows.GridEX.GridEX();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Controls.Add(this.GridEX2);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_132_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_132_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_163_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(745, 545);
			arg_163_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_20B_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_20B_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_239_0 = this.Bar1;
			size = new global::System.Drawing.Size(745, 41);
			arg_239_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 18;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.disk;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "لیست خطاها";
			this.ButtonItem2.Visible = false;
			this.GridEX2.AcceptsEscape = false;
			this.GridEX2.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX2.AlternatingColors = true;
			this.GridEX2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.GridEX2.AutomaticSort = false;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX2_DesignTimeLayout.LayoutString");
			this.GridEX2.DesignTimeLayout = gridEXLayout;
			this.GridEX2.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX2.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX2.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX2.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_394_0 = this.GridEX2;
			location = new global::System.Drawing.Point(0, 47);
			arg_394_0.Location = location;
			this.GridEX2.Name = "GridEX2";
			this.GridEX2.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_3D2_0 = this.GridEX2;
			size = new global::System.Drawing.Size(352, 498);
			arg_3D2_0.Size = size;
			this.GridEX2.TabIndex = 2;
			this.GridEX2.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX2.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutomaticSort = false;
			gridEXLayout2.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout2;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_4D3_0 = this.GridEX1;
			location = new global::System.Drawing.Point(358, 47);
			arg_4D3_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_511_0 = this.GridEX1;
			size = new global::System.Drawing.Size(387, 498);
			arg_511_0.Size = size;
			this.GridEX1.TabIndex = 2;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.database_error1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "خطایابی";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(10f, 27f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(745, 545);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Rpt_TarazName";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ترازنامه";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040011B4 RID: 4532
		private global::System.ComponentModel.IContainer components;
	}
}
