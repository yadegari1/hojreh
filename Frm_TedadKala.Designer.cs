namespace FruitBox
{
	// Token: 0x02000115 RID: 277
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_TedadKala : global::System.Windows.Forms.Form
	{
		// Token: 0x06002829 RID: 10281 RVA: 0x001E5698 File Offset: 0x001E3898
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

		// Token: 0x0600282A RID: 10282 RVA: 0x001E56E8 File Offset: 0x001E38E8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_TedadKala));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DataEntryGrid1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Grid_RizBar = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DataEntryGrid1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_RizBar).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiButton2);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.DataEntryGrid1);
			this.UiGroupBox1.Controls.Add(this.Grid_RizBar);
			this.UiGroupBox1.Controls.Add(this.PictureBox1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_1C8_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1C8_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1F9_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(621, 437);
			arg_1F9_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.save;
			global::System.Windows.Forms.Control arg_24F_0 = this.UiButton2;
			location = new global::System.Drawing.Point(342, 84);
			arg_24F_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton2.OfficeCustomColor = global::System.Drawing.Color.CornflowerBlue;
			global::System.Windows.Forms.Control arg_298_0 = this.UiButton2;
			size = new global::System.Drawing.Size(119, 35);
			arg_298_0.Size = size;
			this.UiButton2.TabIndex = 1;
			this.UiButton2.Text = "ثبت و ادامه";
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.delete;
			global::System.Windows.Forms.Control arg_2FF_0 = this.UiButton1;
			location = new global::System.Drawing.Point(467, 84);
			arg_2FF_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.CornflowerBlue;
			global::System.Windows.Forms.Control arg_34B_0 = this.UiButton1;
			size = new global::System.Drawing.Size(138, 35);
			arg_34B_0.Size = size;
			this.UiButton1.TabIndex = 0;
			this.UiButton1.Text = "برگشت جهت کنترل";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.PictureBox1.Image = global::FruitBox.My.Resources.Resources.warning;
			global::System.Windows.Forms.Control arg_3B2_0 = this.PictureBox1;
			location = new global::System.Drawing.Point(12, 12);
			arg_3B2_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control arg_3DD_0 = this.PictureBox1;
			size = new global::System.Drawing.Size(64, 64);
			arg_3DD_0.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Mitra", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_46F_0 = this.Label2;
			location = new global::System.Drawing.Point(271, 45);
			arg_46F_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_49D_0 = this.Label2;
			size = new global::System.Drawing.Size(340, 31);
			arg_49D_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "جهت ثبت اطلاعات موارد زیر را اصلاح فرمائید";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Mitra", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_526_0 = this.Label1;
			location = new global::System.Drawing.Point(171, 16);
			arg_526_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_554_0 = this.Label1;
			size = new global::System.Drawing.Size(446, 31);
			arg_554_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = " تعداد کالاهای زیر بیشتر از تعداد ثبت شده در ریز بار میباشد";
			this.DataEntryGrid1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.DataEntryGrid1.AlternatingColors = true;
			this.DataEntryGrid1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.DataEntryGrid1.AutomaticSort = false;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("DataEntryGrid1_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("DataEntryGrid1_DesignTimeLayout.LayoutString");
			this.DataEntryGrid1.DesignTimeLayout = gridEXLayout;
			this.DataEntryGrid1.Enabled = false;
			this.DataEntryGrid1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.DataEntryGrid1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.DataEntryGrid1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.DataEntryGrid1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.DataEntryGrid1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_67A_0 = this.DataEntryGrid1;
			location = new global::System.Drawing.Point(0, 285);
			arg_67A_0.Location = location;
			this.DataEntryGrid1.Name = "DataEntryGrid1";
			this.DataEntryGrid1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.DataEntryGrid1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			global::System.Windows.Forms.Control arg_6C5_0 = this.DataEntryGrid1;
			size = new global::System.Drawing.Size(621, 152);
			arg_6C5_0.Size = size;
			this.DataEntryGrid1.TabIndex = 3;
			this.DataEntryGrid1.TabStop = false;
			this.DataEntryGrid1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.DataEntryGrid1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Grid_RizBar.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.Grid_RizBar.AlternatingColors = true;
			this.Grid_RizBar.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Grid_RizBar.AutomaticSort = false;
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Grid_RizBar_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout2.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference2
			});
			gridEXLayout2.LayoutString = componentResourceManager.GetString("Grid_RizBar_DesignTimeLayout.LayoutString");
			this.Grid_RizBar.DesignTimeLayout = gridEXLayout2;
			this.Grid_RizBar.Enabled = false;
			this.Grid_RizBar.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.Grid_RizBar.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.Grid_RizBar.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Grid_RizBar.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.Grid_RizBar.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_7FE_0 = this.Grid_RizBar;
			location = new global::System.Drawing.Point(0, 125);
			arg_7FE_0.Location = location;
			this.Grid_RizBar.Name = "Grid_RizBar";
			this.Grid_RizBar.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.Grid_RizBar.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			global::System.Windows.Forms.Control arg_849_0 = this.Grid_RizBar;
			size = new global::System.Drawing.Size(621, 154);
			arg_849_0.Size = size;
			this.Grid_RizBar.TabIndex = 2;
			this.Grid_RizBar.TabStop = false;
			this.Grid_RizBar.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.Grid_RizBar.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(621, 437);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_TedadKala";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DataEntryGrid1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_RizBar).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000FB0 RID: 4016
		private global::System.ComponentModel.IContainer components;
	}
}
