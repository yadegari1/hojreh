namespace FruitBox
{
	// Token: 0x02000069 RID: 105
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Error : global::System.Windows.Forms.Form
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x00070AA4 File Offset: 0x0006ECA4
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x00070AF4 File Offset: 0x0006ECF4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Error));
			global::FruitBox.GridColumn gridColumn = new global::FruitBox.GridColumn();
			this.Gridex1 = new global::Janus.Windows.GridEX.GridEX();
			this.GridSize1 = new global::FruitBox.GridSize(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.Gridex1).BeginInit();
			this.SuspendLayout();
			this.Gridex1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.Gridex1.BoundMode = global::Janus.Windows.GridEX.BoundMode.Unbound;
			gridEXLayout.LayoutString = componentResourceManager.GetString("Gridex1_DesignTimeLayout.LayoutString");
			this.Gridex1.DesignTimeLayout = gridEXLayout;
			this.Gridex1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Gridex1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_BE_0 = this.Gridex1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_BE_0.Location = location;
			this.Gridex1.Name = "Gridex1";
			this.Gridex1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_FC_0 = this.Gridex1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(522, 365);
			arg_FC_0.Size = size;
			this.Gridex1.TabIndex = 11;
			this.Gridex1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridSize1.Grid = this.Gridex1;
			gridColumn.Name = "Name";
			gridColumn.Size = 100;
			this.GridSize1.GridColumns.AddRange(new global::FruitBox.GridColumn[]
			{
				gridColumn
			});
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(522, 365);
			this.ClientSize = size;
			this.Controls.Add(this.Gridex1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Error";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "مشاهده خطا";
			((global::System.ComponentModel.ISupportInitialize)this.Gridex1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040002F5 RID: 757
		private global::System.ComponentModel.IContainer components;
	}
}
