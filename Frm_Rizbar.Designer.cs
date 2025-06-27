namespace FruitBox
{
	// Token: 0x02000105 RID: 261
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Rizbar : global::System.Windows.Forms.Form
	{
		// Token: 0x0600236D RID: 9069 RVA: 0x001A80E4 File Offset: 0x001A62E4
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

		// Token: 0x0600236E RID: 9070 RVA: 0x001A8134 File Offset: 0x001A6334
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Rizbar));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage");
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_kargari = new global::FruitBox.CurrencyBox(this.components);
			this.Grid_RizBar = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_RizBar).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.txt_kargari);
			this.UiGroupBox2.Controls.Add(this.Grid_RizBar);
			this.UiGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox2.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_FA_0 = this.UiGroupBox2;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_FA_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_12B_0 = this.UiGroupBox2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(659, 478);
			arg_12B_0.Size = size;
			this.UiGroupBox2.TabIndex = 1;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_kargari.AcceptEnter = true;
			this.txt_kargari.AllowEdit = true;
			this.txt_kargari.AllowNew = true;
			this.txt_kargari.FocusColor = false;
			global::System.Windows.Forms.Control arg_199_0 = this.txt_kargari;
			location = new global::System.Drawing.Point(279, 228);
			arg_199_0.Location = location;
			this.txt_kargari.Name = "txt_kargari";
			this.txt_kargari.Nullable = true;
			this.txt_kargari.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_kargari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_1EF_0 = this.txt_kargari;
			size = new global::System.Drawing.Size(100, 23);
			arg_1EF_0.Size = size;
			this.txt_kargari.TabIndex = 16;
			this.txt_kargari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_kargari.Value = value;
			this.txt_kargari.Visible = false;
			this.txt_kargari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Grid_RizBar.AcceptsEscape = false;
			this.Grid_RizBar.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.Grid_RizBar.AlternatingColors = true;
			this.Grid_RizBar.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Grid_RizBar_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Grid_RizBar_DesignTimeLayout_Reference_1.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("Grid_RizBar_DesignTimeLayout.LayoutString");
			this.Grid_RizBar.DesignTimeLayout = gridEXLayout;
			this.Grid_RizBar.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Grid_RizBar.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.Grid_RizBar.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.Grid_RizBar.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.Grid_RizBar.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.Grid_RizBar.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_349_0 = this.Grid_RizBar;
			location = new global::System.Drawing.Point(0, 0);
			arg_349_0.Location = location;
			this.Grid_RizBar.Name = "Grid_RizBar";
			this.Grid_RizBar.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.Grid_RizBar.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_394_0 = this.Grid_RizBar;
			size = new global::System.Drawing.Size(659, 478);
			arg_394_0.Size = size;
			this.Grid_RizBar.TabIndex = 0;
			this.Grid_RizBar.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.Grid_RizBar.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.Grid_RizBar.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(659, 478);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox2);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Rizbar";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ثبت ریز بار";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_RizBar).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000DCD RID: 3533
		private global::System.ComponentModel.IContainer components;
	}
}
