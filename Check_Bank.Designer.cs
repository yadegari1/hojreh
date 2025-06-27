namespace FruitBox
{
	// Token: 0x020000DC RID: 220
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Check_Bank : global::System.Windows.Forms.Form
	{
		// Token: 0x060013DE RID: 5086 RVA: 0x000D255C File Offset: 0x000D075C
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

		// Token: 0x060013DF RID: 5087 RVA: 0x000D25AC File Offset: 0x000D07AC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Check_Bank));
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.Panel1 = new global::DevComponents.DotNetBar.PanelEx();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.txt_tarikh = new global::FruitBox.DateBox2(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2
			});
			global::DevComponents.DotNetBar.Bar arg_11A_0 = this.Bar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_11A_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_148_0 = this.Bar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(918, 41);
			arg_148_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 16;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.disk;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "اعلام وصول";
			this.Panel1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.Panel1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.Panel1.Controls.Add(this.UiButton1);
			this.Panel1.Controls.Add(this.txt_tarikh);
			this.Panel1.Controls.Add(this.Label2);
			global::System.Windows.Forms.Control arg_24E_0 = this.Panel1;
			location = new global::System.Drawing.Point(264, 92);
			arg_24E_0.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control arg_27F_0 = this.Panel1;
			size = new global::System.Drawing.Size(424, 195);
			arg_27F_0.Size = size;
			this.Panel1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.Panel1.Style.BackColor1.Color = global::System.Drawing.Color.White;
			this.Panel1.Style.BackColor2.Color = global::System.Drawing.Color.White;
			this.Panel1.Style.Border = global::DevComponents.DotNetBar.eBorderType.DoubleLine;
			this.Panel1.Style.BorderColor.Color = global::System.Drawing.Color.FromArgb(132, 157, 189);
			this.Panel1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.Panel1.Style.GradientAngle = 90;
			this.Panel1.TabIndex = 18;
			this.Panel1.Text = "PanelEx2";
			this.Panel1.Visible = false;
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.accept;
			global::System.Windows.Forms.Control arg_399_0 = this.UiButton1;
			location = new global::System.Drawing.Point(208, 153);
			arg_399_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_3C4_0 = this.UiButton1;
			size = new global::System.Drawing.Size(100, 27);
			arg_3C4_0.Size = size;
			this.UiButton1.TabIndex = 3;
			this.UiButton1.Text = "ثبت وصول";
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.txt_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tarikh.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			global::System.Windows.Forms.Control arg_427_0 = this.txt_tarikh;
			location = new global::System.Drawing.Point(208, 24);
			arg_427_0.Location = location;
			this.txt_tarikh.Mask = "0000/00/00";
			this.txt_tarikh.Name = "txt_tarikh";
			this.txt_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control arg_470_0 = this.txt_tarikh;
			size = new global::System.Drawing.Size(100, 21);
			arg_470_0.Size = size;
			this.txt_tarikh.TabIndex = 2;
			this.txt_tarikh.Text = "1392/10/02";
			this.txt_tarikh.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4F5_0 = this.Label2;
			location = new global::System.Drawing.Point(314, 31);
			arg_4F5_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_520_0 = this.Label2;
			size = new global::System.Drawing.Size(60, 14);
			arg_520_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "تاریخ وصول";
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_5EC_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 41);
			arg_5EC_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_651_0 = this.GridEX1;
			size = new global::System.Drawing.Size(918, 415);
			arg_651_0.Size = size;
			this.GridEX1.TabIndex = 17;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(918, 456);
			this.ClientSize = size;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.Bar1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Check_Bank";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "چک های نزد بانک";
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040007B3 RID: 1971
		private global::System.ComponentModel.IContainer components;
	}
}
