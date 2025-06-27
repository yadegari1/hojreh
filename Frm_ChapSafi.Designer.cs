namespace FruitBox
{
	// Token: 0x0200011A RID: 282
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_ChapSafi : global::System.Windows.Forms.Form
	{
		// Token: 0x06002984 RID: 10628 RVA: 0x001F6204 File Offset: 0x001F4404
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

		// Token: 0x06002985 RID: 10629 RVA: 0x001F6254 File Offset: 0x001F4454
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::FruitBox.Column column = new global::FruitBox.Column();
			global::FruitBox.Column column2 = new global::FruitBox.Column();
			global::FruitBox.Column column3 = new global::FruitBox.Column();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_ChapSafi));
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_moshtari = new global::FruitBox.SelectItem(this.components);
			this.Gridex1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Gridex1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_moshtari);
			this.UiGroupBox1.Controls.Add(this.Gridex1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_155_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_155_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_186_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(765, 456);
			arg_186_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_moshtari.AcceptEnter = true;
			this.txt_moshtari.AddNewForm = null;
			this.txt_moshtari.AllowEdit = true;
			this.txt_moshtari.AllowNew = true;
			this.txt_moshtari.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_moshtari.ButtonStyle = global::Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.txt_moshtari.ButtonText = "...";
			this.txt_moshtari.CanEdit = true;
			this.txt_moshtari.DisplayMember = "Name";
			this.txt_moshtari.Edit_Frm = null;
			this.txt_moshtari.ExtraData = 0L;
			this.txt_moshtari.FocusColor = true;
			this.txt_moshtari.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			column.Caption = "کد";
			column.Name = "ID";
			column.Size = 15;
			column2.Caption = "مشتری";
			column2.Name = "Name";
			column2.Size = 65;
			column3.Caption = "منطقه";
			column3.Name = "shahr";
			column3.Size = 20;
			this.txt_moshtari.Items.AddRange(new global::FruitBox.Column[]
			{
				column,
				column2,
				column3
			});
			global::System.Windows.Forms.Control arg_315_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(494, 47);
			arg_315_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			this.txt_moshtari.Nullable = false;
			this.txt_moshtari.NullToolTipText = "لطفا صاحب بار را مشخص فرمائید";
			this.txt_moshtari.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.txt_moshtari.SelectCommand = componentResourceManager.GetString("txt_moshtari.SelectCommand");
			this.txt_moshtari.SelectedRow = null;
			this.txt_moshtari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3A0_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(200, 27);
			arg_3A0_0.Size = size;
			this.txt_moshtari.TabIndex = 0;
			this.txt_moshtari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_moshtari.Value = null;
			this.txt_moshtari.ValueMember = "ID";
			this.txt_moshtari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Gridex1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.Gridex1.AlternatingColors = true;
			this.Gridex1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("Gridex1_DesignTimeLayout.LayoutString");
			this.Gridex1.DesignTimeLayout = gridEXLayout;
			this.Gridex1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.Gridex1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.Gridex1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.Gridex1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.Gridex1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_495_0 = this.Gridex1;
			location = new global::System.Drawing.Point(0, 80);
			arg_495_0.Location = location;
			this.Gridex1.Name = "Gridex1";
			this.Gridex1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.Gridex1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_4E0_0 = this.Gridex1;
			size = new global::System.Drawing.Size(765, 376);
			arg_4E0_0.Size = size;
			this.Gridex1.TabIndex = 34;
			this.Gridex1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.Gridex1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_573_0 = this.Label1;
			location = new global::System.Drawing.Point(700, 52);
			arg_573_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_59E_0 = this.Label1;
			size = new global::System.Drawing.Size(61, 19);
			arg_59E_0.Size = size;
			this.Label1.TabIndex = 27;
			this.Label1.Text = "مشتری";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1
			});
			global::DevComponents.DotNetBar.Bar arg_640_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_640_0.Location = location;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_66E_0 = this.Bar1;
			size = new global::System.Drawing.Size(765, 41);
			arg_66E_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.Bar1.TabIndex = 25;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem1.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem1.Image = global::FruitBox.My.Resources.Resources.print1;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Text = "چاپ (F4)";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(765, 456);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_ChapSafi";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.Text = "چاپ صافی";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Gridex1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04001035 RID: 4149
		private global::System.ComponentModel.IContainer components;
	}
}
