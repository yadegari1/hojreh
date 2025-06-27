namespace FruitBox
{
	// Token: 0x020000D3 RID: 211
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Moshtari_kala : global::System.Windows.Forms.Form
	{
		// Token: 0x0600128D RID: 4749 RVA: 0x000C80C4 File Offset: 0x000C62C4
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

		// Token: 0x0600128E RID: 4750 RVA: 0x000C8114 File Offset: 0x000C6314
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Moshtari_kala));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.UiButton1 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton2 = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton3 = new global::Janus.Windows.EditControls.UIButton();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.DataEntryGrid1 = new global::FruitBox.DataEntryGrid(this.components);
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataEntryGrid1).BeginInit();
			this.SuspendLayout();
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_112_0 = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(395, 15);
			arg_112_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_13D_0 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(61, 19);
			arg_13D_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "جستجو";
			this.UiButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton1.Image = global::FruitBox.My.Resources.Resources.accept;
			global::System.Windows.Forms.Control arg_19A_0 = this.UiButton1;
			location = new global::System.Drawing.Point(374, 445);
			arg_19A_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			global::System.Windows.Forms.Control arg_1C5_0 = this.UiButton1;
			size = new global::System.Drawing.Size(75, 23);
			arg_1C5_0.Size = size;
			this.UiButton1.TabIndex = 3;
			this.UiButton1.Text = "تائید";
			this.UiButton1.Visible = false;
			this.UiButton1.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton2.Image = global::FruitBox.My.Resources.Resources.delete;
			global::System.Windows.Forms.Control arg_23C_0 = this.UiButton2;
			location = new global::System.Drawing.Point(293, 445);
			arg_23C_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			global::System.Windows.Forms.Control arg_267_0 = this.UiButton2;
			size = new global::System.Drawing.Size(75, 23);
			arg_267_0.Size = size;
			this.UiButton2.TabIndex = 3;
			this.UiButton2.Text = "انصراف";
			this.UiButton2.Visible = false;
			this.UiButton2.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiButton3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.UiButton3.Image = global::FruitBox.My.Resources.Resources.accept;
			global::System.Windows.Forms.Control arg_2F8_0 = this.UiButton3;
			location = new global::System.Drawing.Point(3, 7);
			arg_2F8_0.Location = location;
			this.UiButton3.Name = "UiButton3";
			this.UiButton3.OfficeColorScheme = global::Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton3.OfficeCustomColor = global::System.Drawing.Color.SteelBlue;
			global::System.Windows.Forms.Control arg_341_0 = this.UiButton3;
			size = new global::System.Drawing.Size(114, 36);
			arg_341_0.Size = size;
			this.UiButton3.TabIndex = 2;
			this.UiButton3.Text = "ثبت (F2)";
			this.UiButton3.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.DataEntryGrid1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.UiButton1);
			this.UiGroupBox1.Controls.Add(this.UiButton2);
			this.UiGroupBox1.Controls.Add(this.UiButton3);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_435_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_435_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_466_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(461, 476);
			arg_466_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.DataEntryGrid1.AllowEdit = global::Janus.Windows.GridEX.InheritableBoolean.False;
			this.DataEntryGrid1.AlternatingColors = true;
			this.DataEntryGrid1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			gridEXLayout.LayoutString = componentResourceManager.GetString("DataEntryGrid1_DesignTimeLayout.LayoutString");
			this.DataEntryGrid1.DesignTimeLayout = gridEXLayout;
			this.DataEntryGrid1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.DataEntryGrid1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.DataEntryGrid1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.DataEntryGrid1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.DataEntryGrid1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_536_0 = this.DataEntryGrid1;
			location = new global::System.Drawing.Point(1, 49);
			arg_536_0.Location = location;
			this.DataEntryGrid1.Name = "DataEntryGrid1";
			this.DataEntryGrid1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.DataEntryGrid1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_581_0 = this.DataEntryGrid1;
			size = new global::System.Drawing.Size(459, 427);
			arg_581_0.Size = size;
			this.DataEntryGrid1.TabIndex = 1;
			this.DataEntryGrid1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.DataEntryGrid1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_625_0 = this.EditBox1;
			location = new global::System.Drawing.Point(123, 7);
			arg_625_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_67E_0 = this.EditBox1;
			size = new global::System.Drawing.Size(270, 36);
			arg_67E_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(461, 476);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Moshtari_kala";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "انتخاب جنس";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataEntryGrid1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400072B RID: 1835
		private global::System.ComponentModel.IContainer components;
	}
}
