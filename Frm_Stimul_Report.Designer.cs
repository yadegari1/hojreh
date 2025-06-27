namespace FruitBox
{
	// Token: 0x02000084 RID: 132
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Stimul_Report : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B9E RID: 2974 RVA: 0x000913A0 File Offset: 0x0008F5A0
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

		// Token: 0x06000B9F RID: 2975 RVA: 0x000913F0 File Offset: 0x0008F5F0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.StiViewerControl1 = new global::Stimulsoft.Report.Viewer.StiViewerControl();
			this.OfficeFormAdorner1 = new global::Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.OfficeFormAdorner1).BeginInit();
			this.SuspendLayout();
			this.StiViewerControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control arg_5B_0 = this.StiViewerControl1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_5B_0.Location = location;
			this.StiViewerControl1.Name = "StiViewerControl1";
			this.StiViewerControl1.Report = null;
			this.StiViewerControl1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.StiViewerControl1.ShowBookmarksPanel = false;
			this.StiViewerControl1.ShowZoom = true;
			global::System.Windows.Forms.Control arg_BF_0 = this.StiViewerControl1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1061, 567);
			arg_BF_0.Size = size;
			this.StiViewerControl1.TabIndex = 0;
			this.OfficeFormAdorner1.EnableGlassEffect = false;
			this.OfficeFormAdorner1.Form = this;
			this.OfficeFormAdorner1.VisualStyle = global::Janus.Windows.Ribbon.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1061, 567);
			this.ClientSize = size;
			this.Controls.Add(this.StiViewerControl1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.Name = "Frm_Stimul_Report";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Frm_Stimul_Report";
			this.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			((global::System.ComponentModel.ISupportInitialize)this.OfficeFormAdorner1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000496 RID: 1174
		private global::System.ComponentModel.IContainer components;
	}
}
