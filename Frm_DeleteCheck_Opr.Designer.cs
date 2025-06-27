namespace FruitBox
{
	// Token: 0x020000EA RID: 234
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_DeleteCheck_Opr : global::System.Windows.Forms.Form
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x0011704C File Offset: 0x0011524C
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

		// Token: 0x060018A1 RID: 6305 RVA: 0x0011709C File Offset: 0x0011529C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_DeleteCheck_Opr));
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.Bar1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.Bar1.AntiAlias = true;
			this.Bar1.Controls.Add(this.Button1);
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem3
			});
			global::DevComponents.DotNetBar.Bar arg_143_0 = this.Bar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_143_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_171_0 = this.Bar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(639, 41);
			arg_171_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.Bar1.Visible = false;
			global::System.Windows.Forms.Control arg_1E1_0 = this.Button1;
			location = new global::System.Drawing.Point(748, 9);
			arg_1E1_0.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control arg_20C_0 = this.Button1;
			size = new global::System.Drawing.Size(75, 23);
			arg_20C_0.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.bin_closed;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "حذف آخرین عملیات";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_2FC_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 41);
			arg_2FC_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_32D_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(639, 338);
			arg_32D_0.Size = size;
			this.UiGroupBox1.TabIndex = 17;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_3EA_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 66);
			arg_3EA_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_442_0 = this.GridEX1;
			size = new global::System.Drawing.Size(639, 272);
			arg_442_0.Size = size;
			this.GridEX1.TabIndex = 15;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_4F1_0 = this.Label2;
			location = new global::System.Drawing.Point(260, 38);
			arg_4F1_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_51F_0 = this.Label2;
			size = new global::System.Drawing.Size(371, 14);
			arg_51F_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "- اگر مایل به حذف چک مورد نظر هستید تمامی عملیات زیر را حذف نمایید";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_586_0 = this.Label1;
			location = new global::System.Drawing.Point(372, 13);
			arg_586_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_5B4_0 = this.Label1;
			size = new global::System.Drawing.Size(259, 14);
			arg_5B4_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "- عملیات زیر بر روی چک مورد نظر انجام شده است";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(639, 379);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_DeleteCheck_Opr";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "عملیات چک";
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.Bar1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000997 RID: 2455
		private global::System.ComponentModel.IContainer components;
	}
}
