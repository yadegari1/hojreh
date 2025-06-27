namespace FruitBox
{
	// Token: 0x0200013B RID: 315
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_ShowItem : global::System.Windows.Forms.Form
	{
		// Token: 0x06002DBD RID: 11709 RVA: 0x0021E4E0 File Offset: 0x0021C6E0
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

		// Token: 0x06002DBE RID: 11710 RVA: 0x0021E530 File Offset: 0x0021C730
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutomaticSort = false;
			gridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><TotalRow>True</TotalRow></RootTable></GridEXLayoutData>";
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_10E_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 32);
			arg_10E_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_14C_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(620, 350);
			arg_14C_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_21A_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_21A_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_24B_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(620, 382);
			arg_24B_0.Size = size;
			this.UiGroupBox1.TabIndex = 1;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.add;
			global::System.Windows.Forms.Control arg_28D_0 = this.UiButton1;
			location = new global::System.Drawing.Point(4, 3);
			arg_28D_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_2D6_0 = this.UiButton1;
			size = new global::System.Drawing.Size(102, 23);
			arg_2D6_0.Size = size;
			this.UiButton1.TabIndex = 2;
			this.UiButton1.Text = "جدید (Ins)";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_349_0 = this.Label1;
			location = new global::System.Drawing.Point(569, 9);
			arg_349_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_374_0 = this.Label1;
			size = new global::System.Drawing.Size(45, 14);
			arg_374_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "جستجو";
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			global::System.Windows.Forms.Control arg_3EC_0 = this.EditBox1;
			location = new global::System.Drawing.Point(112, 4);
			arg_3EC_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_445_0 = this.EditBox1;
			size = new global::System.Drawing.Size(451, 22);
			arg_445_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(620, 382);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.Name = "Frm_ShowItem";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040011C3 RID: 4547
		private global::System.ComponentModel.IContainer components;
	}
}
