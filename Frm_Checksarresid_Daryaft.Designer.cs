namespace FruitBox
{
	// Token: 0x0200011C RID: 284
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Checksarresid_Daryaft : global::System.Windows.Forms.Form
	{
		// Token: 0x060029B5 RID: 10677 RVA: 0x001F7920 File Offset: 0x001F5B20
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

		// Token: 0x060029B6 RID: 10678 RVA: 0x001F7970 File Offset: 0x001F5B70
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Checksarresid_Daryaft));
			this.GridEX2 = new global::Janus.Windows.GridEX.GridEX();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).BeginInit();
			this.SuspendLayout();
			this.GridEX2.AcceptsEscape = false;
			this.GridEX2.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX2.AlternatingColors = true;
			this.GridEX2.AutomaticSort = false;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX2_DesignTimeLayout.LayoutString");
			this.GridEX2.DesignTimeLayout = gridEXLayout;
			this.GridEX2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX2.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX2.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX2.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX2.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_FD_0 = this.GridEX2;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_FD_0.Location = location;
			this.GridEX2.Name = "GridEX2";
			this.GridEX2.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_13B_0 = this.GridEX2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(824, 359);
			arg_13B_0.Size = size;
			this.GridEX2.TabIndex = 3;
			this.GridEX2.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX2.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(824, 359);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX2);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Checksarresid_Daryaft";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "سررسید چک های دریافتی";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX2).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04001049 RID: 4169
		private global::System.ComponentModel.IContainer components;
	}
}
