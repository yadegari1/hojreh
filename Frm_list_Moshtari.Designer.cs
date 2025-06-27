namespace FruitBox
{
	// Token: 0x020000CF RID: 207
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_list_Moshtari : global::System.Windows.Forms.Form
	{
		// Token: 0x0600118C RID: 4492 RVA: 0x000BEAD0 File Offset: 0x000BCCD0
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

		// Token: 0x0600118D RID: 4493 RVA: 0x000BEB20 File Offset: 0x000BCD20
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_list_Moshtari));
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem4 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem5 = new global::DevComponents.DotNetBar.ButtonItem();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2,
				this.ButtonItem3,
				this.ButtonItem1,
				this.ButtonItem4,
				this.ButtonItem5
			});
			global::DevComponents.DotNetBar.Bar arg_16C_0 = this.Bar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_16C_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_19A_0 = this.Bar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(759, 41);
			arg_19A_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 0;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.page;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "جدید";
			this.ButtonItem3.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem3.Image = global::FruitBox.My.Resources.Resources.page_edit;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Text = "ویرایش";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.bin_closed;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "حذف";
			this.ButtonItem4.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem4.Image = global::FruitBox.My.Resources.Resources.printer;
			this.ButtonItem4.Name = "ButtonItem4";
			this.ButtonItem4.Text = "چاپ";
			this.ButtonItem4.Visible = false;
			this.ButtonItem5.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem5.Image = global::FruitBox.My.Resources.Resources.application;
			this.ButtonItem5.Name = "ButtonItem5";
			this.ButtonItem5.Text = "صورتحساب";
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_3C8_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 89);
			arg_3C8_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_406_0 = this.GridEX1;
			size = new global::System.Drawing.Size(759, 329);
			arg_406_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4A1_0 = this.EditBox1;
			location = new global::System.Drawing.Point(447, 47);
			arg_4A1_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_4FA_0 = this.EditBox1;
			size = new global::System.Drawing.Size(233, 36);
			arg_4FA_0.Size = size;
			this.EditBox1.TabIndex = 2;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_57F_0 = this.Label1;
			location = new global::System.Drawing.Point(682, 56);
			arg_57F_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_5AA_0 = this.Label1;
			size = new global::System.Drawing.Size(61, 19);
			arg_5AA_0.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "جستجو";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_635_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_635_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_666_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(759, 418);
			arg_666_0.Size = size;
			this.UiGroupBox1.TabIndex = 4;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(759, 418);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.Bar1);
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_list_Moshtari";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "لیست مشتریان";
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040006B9 RID: 1721
		private global::System.ComponentModel.IContainer components;
	}
}
