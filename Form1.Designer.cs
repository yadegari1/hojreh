namespace FruitBox
{
	// Token: 0x020000BD RID: 189
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000EF0 RID: 3824 RVA: 0x000AA784 File Offset: 0x000A8984
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

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000AA7D4 File Offset: 0x000A89D4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Form1));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference3 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage");
			this.MetroTileItem4 = new global::DevComponents.DotNetBar.Metro.MetroTileItem();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.MetroTileItem4.GlobalItem = false;
			this.MetroTileItem4.Name = "MetroTileItem4";
			this.MetroTileItem4.SymbolColor = global::System.Drawing.Color.Empty;
			this.MetroTileItem4.TileColor = global::DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
			this.MetroTileItem4.TileStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"));
			janusLayoutReference3.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2,
				janusLayoutReference3
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_1F8_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1F8_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_250_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1452, 473);
			arg_250_0.Size = size;
			this.GridEX1.TabIndex = 14;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1452, 473);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Form1";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040005CA RID: 1482
		private global::System.ComponentModel.IContainer components;
	}
}
