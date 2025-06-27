namespace FruitBox
{
	// Token: 0x0200006C RID: 108
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Help : global::System.Windows.Forms.Form
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x000760F0 File Offset: 0x000742F0
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

		// Token: 0x06000857 RID: 2135 RVA: 0x00076140 File Offset: 0x00074340
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			global::System.Windows.Forms.Control arg_2A_0 = this.Button1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(188, 100);
			arg_2A_0.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control arg_54_0 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(75, 23);
			arg_54_0.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkKhaki;
			size = new global::System.Drawing.Size(656, 411);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Name = "Frm_Help";
			this.Text = "Frm_Help";
			this.ResumeLayout(false);
		}

		// Token: 0x04000340 RID: 832
		private global::System.ComponentModel.IContainer components;
	}
}
