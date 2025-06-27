namespace FruitBox
{
	// Token: 0x02000131 RID: 305
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_rpt_kasrezafesandug : global::System.Windows.Forms.Form
	{
		// Token: 0x06002C12 RID: 11282 RVA: 0x0020C24C File Offset: 0x0020A44C
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

		// Token: 0x06002C13 RID: 11283 RVA: 0x0020C29C File Offset: 0x0020A49C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_rpt_kasrezafesandug));
			global::FruitBox.Column column = new global::FruitBox.Column();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.txt_search = new global::FruitBox.EditBox(this.components);
			this.SelectItem1 = new global::FruitBox.SelectItem(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.AutomaticSort = false;
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_19B_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 47);
			arg_19B_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			global::System.Windows.Forms.Control arg_1D9_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1125, 343);
			arg_1D9_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_283_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_283_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_2B1_0 = this.Bar1;
			size = new global::System.Drawing.Size(1125, 41);
			arg_2B1_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 26;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_3BC_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 41);
			arg_3BC_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_3ED_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(1125, 390);
			arg_3ED_0.Size = size;
			this.UiGroupBox1.TabIndex = 27;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_473_0 = this.Label1;
			location = new global::System.Drawing.Point(1061, 13);
			arg_473_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_49E_0 = this.Label1;
			size = new global::System.Drawing.Size(61, 19);
			arg_49E_0.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "جستجو";
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_53C_0 = this.EditBox1;
			location = new global::System.Drawing.Point(853, 5);
			arg_53C_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_595_0 = this.EditBox1;
			size = new global::System.Drawing.Size(206, 36);
			arg_595_0.Size = size;
			this.EditBox1.TabIndex = 2;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_search.AcceptEnter = true;
			this.txt_search.AllowEdit = true;
			this.txt_search.AllowNew = true;
			this.txt_search.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_search.FocusColor = true;
			global::System.Windows.Forms.Control arg_60E_0 = this.txt_search;
			location = new global::System.Drawing.Point(391, 76);
			arg_60E_0.Location = location;
			this.txt_search.Name = "txt_search";
			this.txt_search.Nullable = true;
			this.txt_search.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_search.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_667_0 = this.txt_search;
			size = new global::System.Drawing.Size(166, 20);
			arg_667_0.Size = size;
			this.txt_search.TabIndex = 10;
			this.txt_search.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.SelectItem1.AcceptEnter = true;
			this.SelectItem1.AddNewForm = null;
			this.SelectItem1.AllowEdit = true;
			this.SelectItem1.AllowNew = true;
			this.SelectItem1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SelectItem1.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.SelectItem1.ButtonText = "...";
			this.SelectItem1.CanEdit = false;
			this.SelectItem1.DisplayMember = "Name";
			this.SelectItem1.Edit_Frm = null;
			this.SelectItem1.ExtraData = 0L;
			this.SelectItem1.FocusColor = true;
			column.Caption = "عنوان";
			column.Name = "Name";
			column.Size = 100;
			this.SelectItem1.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_784_0 = this.SelectItem1;
			location = new global::System.Drawing.Point(93, 47);
			arg_784_0.Location = location;
			this.SelectItem1.Name = "SelectItem1";
			this.SelectItem1.Nullable = true;
			this.SelectItem1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.SelectItem1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.SelectItem1.SelectCommand = "SELECT     1 as kind,ID, Name FROM         Grouh_Moshtari union all SELECT     2 as kind,ID, Name FROM         Grouh_Moshtari2";
			this.SelectItem1.SelectedRow = null;
			this.SelectItem1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_808_0 = this.SelectItem1;
			size = new global::System.Drawing.Size(161, 20);
			arg_808_0.Size = size;
			this.SelectItem1.TabIndex = 9;
			this.SelectItem1.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.SelectItem1.Value = null;
			this.SelectItem1.ValueMember = "ID";
			this.SelectItem1.Visible = false;
			this.SelectItem1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1125, 431);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_rpt_kasrezafesandug";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "کسر و اضافی صندوق";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x04001126 RID: 4390
		private global::System.ComponentModel.IContainer components;
	}
}
