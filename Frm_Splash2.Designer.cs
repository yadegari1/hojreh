namespace FruitBox
{
	// Token: 0x02000083 RID: 131
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Splash2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x00090D48 File Offset: 0x0008EF48
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

		// Token: 0x06000B8F RID: 2959 RVA: 0x00090D98 File Offset: 0x0008EF98
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lbl_ver = new global::System.Windows.Forms.Label();
			this.lbl_owner = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 5000;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Samim", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control arg_CD_0 = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(87, 575);
			arg_CD_0.Location = location;
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_108_0 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(267, 29);
			arg_108_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Samim", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control arg_185_0 = this.Label2;
			location = new global::System.Drawing.Point(292, 545);
			arg_185_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_1B0_0 = this.Label2;
			size = new global::System.Drawing.Size(56, 28);
			arg_1B0_0.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "نسخه";
			this.lbl_ver.BackColor = global::System.Drawing.Color.Transparent;
			this.lbl_ver.Font = new global::System.Drawing.Font("Samim", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_ver.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control arg_231_0 = this.lbl_ver;
			location = new global::System.Drawing.Point(151, 545);
			arg_231_0.Location = location;
			this.lbl_ver.Name = "lbl_ver";
			this.lbl_ver.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_26C_0 = this.lbl_ver;
			size = new global::System.Drawing.Size(135, 28);
			arg_26C_0.Size = size;
			this.lbl_ver.TabIndex = 1;
			this.lbl_owner.BackColor = global::System.Drawing.Color.Transparent;
			this.lbl_owner.Font = new global::System.Drawing.Font("Samim", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_owner.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control arg_2D9_0 = this.lbl_owner;
			location = new global::System.Drawing.Point(33, 505);
			arg_2D9_0.Location = location;
			this.lbl_owner.Name = "lbl_owner";
			this.lbl_owner.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_314_0 = this.lbl_owner;
			size = new global::System.Drawing.Size(315, 31);
			arg_314_0.Size = size;
			this.lbl_owner.TabIndex = 2;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FruitBox.My.Resources.Resources.fruit1;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			size = new global::System.Drawing.Size(461, 622);
			this.ClientSize = size;
			this.Controls.Add(this.lbl_owner);
			this.Controls.Add(this.lbl_ver);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Splash2";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frm_Splash";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400048F RID: 1167
		private global::System.ComponentModel.IContainer components;
	}
}
