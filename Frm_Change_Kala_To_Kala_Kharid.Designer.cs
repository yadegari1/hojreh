namespace FruitBox
{
	// Token: 0x020000C5 RID: 197
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Change_Kala_To_Kala_Kharid : global::System.Windows.Forms.Form
	{
		// Token: 0x0600102D RID: 4141 RVA: 0x000B2C5C File Offset: 0x000B0E5C
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

		// Token: 0x0600102E RID: 4142 RVA: 0x000B2CAC File Offset: 0x000B0EAC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Change_Kala_To_Kala_Kharid));
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.Font = new global::System.Drawing.Font("Tahoma", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_D7_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_D7_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_108_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(528, 364);
			arg_108_0.Size = size;
			this.UiGroupBox1.TabIndex = 1;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_1E2_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 0);
			arg_1E2_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			global::System.Windows.Forms.Control arg_213_0 = this.GridEX1;
			size = new global::System.Drawing.Size(528, 364);
			arg_213_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(528, 364);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Change_Kala_To_Kala_Kharid";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "کسر اتوماتیک";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000625 RID: 1573
		private global::System.ComponentModel.IContainer components;
	}
}
