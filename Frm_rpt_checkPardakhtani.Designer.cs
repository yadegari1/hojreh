namespace FruitBox
{
	// Token: 0x0200012A RID: 298
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_rpt_checkPardakhtani : global::System.Windows.Forms.Form
	{
		// Token: 0x06002B44 RID: 11076 RVA: 0x002052C8 File Offset: 0x002034C8
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

		// Token: 0x06002B45 RID: 11077 RVA: 0x00205318 File Offset: 0x00203518
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_rpt_checkPardakhtani));
			global::FruitBox.Column column = new global::FruitBox.Column();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txt_moshtari = new global::FruitBox.SelectItem(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
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
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_17C_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 73);
			arg_17C_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.NewRowPosition = global::Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.GridEX1.RowHeaderContent = global::Janus.Windows.GridEX.RowHeaderContent.RowPosition;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_1D4_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(990, 284);
			arg_1D4_0.Size = size;
			this.GridEX1.TabIndex = 1;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.txt_moshtari);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_2A3_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_2A3_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_2D4_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(990, 357);
			arg_2D4_0.Size = size;
			this.UiGroupBox1.TabIndex = 2;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_36F_0 = this.EditBox1;
			location = new global::System.Drawing.Point(605, 40);
			arg_36F_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_3C8_0 = this.EditBox1;
			size = new global::System.Drawing.Size(317, 27);
			arg_3C8_0.Size = size;
			this.EditBox1.TabIndex = 27;
			this.EditBox1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_44E_0 = this.Label2;
			location = new global::System.Drawing.Point(924, 45);
			arg_44E_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_479_0 = this.Label2;
			size = new global::System.Drawing.Size(61, 19);
			arg_479_0.Size = size;
			this.Label2.TabIndex = 26;
			this.Label2.Text = "جستجو";
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
			column.Caption = "مشتری";
			column.Name = "Name";
			column.Size = 100;
			this.txt_moshtari.Items.AddRange(new global::FruitBox.Column[]
			{
				column
			});
			global::System.Windows.Forms.Control arg_5BE_0 = this.txt_moshtari;
			location = new global::System.Drawing.Point(705, 7);
			arg_5BE_0.Location = location;
			this.txt_moshtari.Name = "txt_moshtari";
			this.txt_moshtari.Nullable = false;
			this.txt_moshtari.NullToolTipText = "لطفا صاحب بار را مشخص فرمائید";
			this.txt_moshtari.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.txt_moshtari.SelectCommand = "select Id,name + ' ' + Family as Name From Moshtari where id <> -1";
			this.txt_moshtari.SelectedRow = null;
			this.txt_moshtari.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_642_0 = this.txt_moshtari;
			size = new global::System.Drawing.Size(217, 27);
			arg_642_0.Size = size;
			this.txt_moshtari.TabIndex = 2;
			this.txt_moshtari.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_moshtari.Value = null;
			this.txt_moshtari.ValueMember = "ID";
			this.txt_moshtari.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_6F2_0 = this.Label1;
			location = new global::System.Drawing.Point(924, 12);
			arg_6F2_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_71D_0 = this.Label1;
			size = new global::System.Drawing.Size(61, 19);
			arg_71D_0.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "مشتری";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(990, 357);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX1);
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_rpt_checkPardakhtani";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "لیست چک های پرداختی به مشتری";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040010D8 RID: 4312
		private global::System.ComponentModel.IContainer components;
	}
}
