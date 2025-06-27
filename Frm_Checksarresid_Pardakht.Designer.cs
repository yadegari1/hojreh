namespace FruitBox
{
	// Token: 0x0200011D RID: 285
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Checksarresid_Pardakht : global::System.Windows.Forms.Form
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x001F7CE0 File Offset: 0x001F5EE0
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

		// Token: 0x060029C1 RID: 10689 RVA: 0x001F7D30 File Offset: 0x001F5F30
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Checksarresid_Pardakht));
			this.GridEX3 = new global::Janus.Windows.GridEX.GridEX();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX3).BeginInit();
			this.SuspendLayout();
			this.GridEX3.AcceptsEscape = false;
			this.GridEX3.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX3.AlternatingColors = true;
			this.GridEX3.AutomaticSort = false;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX3_DesignTimeLayout.LayoutString");
			this.GridEX3.DesignTimeLayout = gridEXLayout;
			this.GridEX3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX3.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX3.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX3.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX3.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_FD_0 = this.GridEX3;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_FD_0.Location = location;
			this.GridEX3.Name = "GridEX3";
			this.GridEX3.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_13B_0 = this.GridEX3;
			global::System.Drawing.Size size = new global::System.Drawing.Size(729, 386);
			arg_13B_0.Size = size;
			this.GridEX3.TabIndex = 4;
			this.GridEX3.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX3.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX3.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(729, 386);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX3);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Checksarresid_Pardakht";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "سررسید چک های پرداختنی";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX3).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400104D RID: 4173
		private global::System.ComponentModel.IContainer components;
	}
}
