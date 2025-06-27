namespace FruitBox
{
	// Token: 0x020000CE RID: 206
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_list_BankHesab : global::System.Windows.Forms.Form
	{
		// Token: 0x06001171 RID: 4465 RVA: 0x000BDED8 File Offset: 0x000BC0D8
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

		// Token: 0x06001172 RID: 4466 RVA: 0x000BDF28 File Offset: 0x000BC128
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_list_BankHesab));
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem4 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem5 = new global::DevComponents.DotNetBar.ButtonItem();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
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
			global::DevComponents.DotNetBar.Bar arg_11F_0 = this.Bar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_11F_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_14D_0 = this.Bar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(867, 41);
			arg_14D_0.Size = size;
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
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_37A_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 41);
			arg_37A_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_3C5_0 = this.GridEX1;
			size = new global::System.Drawing.Size(867, 406);
			arg_3C5_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(867, 447);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.Bar1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_list_BankHesab";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "لیست حساب بانکی";
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040006AF RID: 1711
		private global::System.ComponentModel.IContainer components;
	}
}
