namespace FruitBox
{
	// Token: 0x02000113 RID: 275
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sud_Kharid_Sardkhane : global::System.Windows.Forms.Form
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x001E0314 File Offset: 0x001DE514
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

		// Token: 0x060027B8 RID: 10168 RVA: 0x001E0364 File Offset: 0x001DE564
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sud_Kharid_Sardkhane));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage");
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_darsad = new global::FruitBox.NumericBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txt_darsad2 = new global::FruitBox.NumericBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_darsad);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.txt_darsad2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_146_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_146_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_177_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(608, 316);
			arg_177_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_darsad.AcceptEnter = false;
			this.txt_darsad.AllowEdit = true;
			this.txt_darsad.AllowNew = true;
			this.txt_darsad.FixLength = 2;
			this.txt_darsad.FocusColor = false;
			global::System.Windows.Forms.Control arg_1EB_0 = this.txt_darsad;
			location = new global::System.Drawing.Point(13, 5);
			arg_1EB_0.Location = location;
			this.txt_darsad.MaxLength = 2;
			this.txt_darsad.Name = "txt_darsad";
			this.txt_darsad.Nullable = true;
			this.txt_darsad.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_darsad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_24E_0 = this.txt_darsad;
			size = new global::System.Drawing.Size(100, 23);
			arg_24E_0.Size = size;
			this.txt_darsad.TabIndex = 3;
			this.txt_darsad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad.Visible = false;
			this.txt_darsad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_39A_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 41);
			arg_39A_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_3E5_0 = this.GridEX1;
			size = new global::System.Drawing.Size(608, 275);
			arg_3E5_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4CF_0 = this.Label2;
			location = new global::System.Drawing.Point(491, 13);
			arg_4CF_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_4FA_0 = this.Label2;
			size = new global::System.Drawing.Size(108, 19);
			arg_4FA_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "درصد فروشنده";
			this.txt_darsad2.AcceptEnter = true;
			this.txt_darsad2.AllowEdit = false;
			this.txt_darsad2.AllowNew = true;
			this.txt_darsad2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_darsad2.FixLength = 2;
			this.txt_darsad2.FocusColor = true;
			this.txt_darsad2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5A5_0 = this.txt_darsad2;
			location = new global::System.Drawing.Point(385, 8);
			arg_5A5_0.Location = location;
			this.txt_darsad2.MaxLength = 2;
			this.txt_darsad2.Name = "txt_darsad2";
			this.txt_darsad2.Nullable = true;
			this.txt_darsad2.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_darsad2.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_608_0 = this.txt_darsad2;
			size = new global::System.Drawing.Size(100, 27);
			arg_608_0.Size = size;
			this.txt_darsad2.TabIndex = 1;
			this.txt_darsad2.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(608, 316);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sud_Kharid";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "درصد سود مشارکتی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F81 RID: 3969
		private global::System.ComponentModel.IContainer components;
	}
}
