namespace FruitBox
{
	// Token: 0x02000060 RID: 96
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Base : global::System.Windows.Forms.Form
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x00067058 File Offset: 0x00065258
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

		// Token: 0x0600069F RID: 1695 RVA: 0x000670A8 File Offset: 0x000652A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(529, 405);
			this.ClientSize = clientSize;
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Base";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.ResumeLayout(false);
		}

		// Token: 0x04000283 RID: 643
		public global::System.ComponentModel.IContainer components;
	}
}
