namespace FruitBox
{
	// Token: 0x02000064 RID: 100
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_cmd : global::System.Windows.Forms.Form
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x0006BED8 File Offset: 0x0006A0D8
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

		// Token: 0x0600070C RID: 1804 RVA: 0x0006BF28 File Offset: 0x0006A128
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.TextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.TextBox1.Font = new global::System.Drawing.Font("Verdana", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control arg_5D_0 = this.TextBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(-1, 1);
			arg_5D_0.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control arg_9A_0 = this.TextBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(631, 203);
			arg_9A_0.Size = size;
			this.TextBox1.TabIndex = 0;
			this.Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			global::System.Windows.Forms.Control arg_D0_0 = this.Button1;
			location = new global::System.Drawing.Point(12, 210);
			arg_D0_0.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control arg_FA_0 = this.Button1;
			size = new global::System.Drawing.Size(75, 23);
			arg_FA_0.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Run";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(630, 235);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_cmd";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CMD";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040002AE RID: 686
		private global::System.ComponentModel.IContainer components;
	}
}
