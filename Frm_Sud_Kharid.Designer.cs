namespace FruitBox
{
	// Token: 0x02000112 RID: 274
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Sud_Kharid : global::System.Windows.Forms.Form
	{
		// Token: 0x06002785 RID: 10117 RVA: 0x001DE28C File Offset: 0x001DC48C
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

		// Token: 0x06002786 RID: 10118 RVA: 0x001DE2DC File Offset: 0x001DC4DC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Sud_Kharid));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage");
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_darsad = new global::FruitBox.NumericBox(this.components);
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txt_darsad2 = new global::FruitBox.NumericBox(this.components);
			this.txt_sanad = new global::FruitBox.NumericBox(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txt_jam = new global::FruitBox.NumericBox(this.components);
			this.txt_mande = new global::FruitBox.CurrencyBox(this.components);
			this.Label4 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.txt_mande);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.txt_jam);
			this.UiGroupBox1.Controls.Add(this.txt_sanad);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.txt_darsad);
			this.UiGroupBox1.Controls.Add(this.GridEX1);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.txt_darsad2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_22A_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_22A_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_25B_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(608, 412);
			arg_25B_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_darsad.AcceptEnter = false;
			this.txt_darsad.AllowEdit = true;
			this.txt_darsad.AllowNew = true;
			this.txt_darsad.FixLength = 2;
			this.txt_darsad.FocusColor = false;
			global::System.Windows.Forms.Control arg_2CF_0 = this.txt_darsad;
			location = new global::System.Drawing.Point(13, 5);
			arg_2CF_0.Location = location;
			this.txt_darsad.MaxLength = 2;
			this.txt_darsad.Name = "txt_darsad";
			this.txt_darsad.Nullable = true;
			this.txt_darsad.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_darsad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_332_0 = this.txt_darsad;
			size = new global::System.Drawing.Size(100, 23);
			arg_332_0.Size = size;
			this.txt_darsad.TabIndex = 3;
			this.txt_darsad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad.Visible = false;
			this.txt_darsad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.GridEX1.AcceptsEscape = false;
			this.GridEX1.AllowAddNew = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.AlternatingColors = true;
			this.GridEX1.AutoEdit = true;
			janusLayoutReference.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"));
			janusLayoutReference2.Instance = global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"));
			gridEXLayout.LayoutReferences.AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2
			});
			gridEXLayout.LayoutString = componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString");
			this.GridEX1.DesignTimeLayout = gridEXLayout;
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GridEX1.EnterKeyBehavior = global::Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.GridEX1.FocusStyle = global::Janus.Windows.GridEX.FocusStyle.Solid;
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.GridEX1.GridLineStyle = global::Janus.Windows.GridEX.GridLineStyle.Solid;
			this.GridEX1.GroupByBoxVisible = false;
			global::System.Windows.Forms.Control arg_47E_0 = this.GridEX1;
			location = new global::System.Drawing.Point(0, 96);
			arg_47E_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.OfficeColorScheme = global::Janus.Windows.GridEX.OfficeColorScheme.Blue;
			this.GridEX1.RowHeaders = global::Janus.Windows.GridEX.InheritableBoolean.True;
			global::System.Windows.Forms.Control arg_4C9_0 = this.GridEX1;
			size = new global::System.Drawing.Size(608, 316);
			arg_4C9_0.Size = size;
			this.GridEX1.TabIndex = 0;
			this.GridEX1.TotalRow = global::Janus.Windows.GridEX.InheritableBoolean.True;
			this.GridEX1.TotalRowFormatStyle.BackColor = global::System.Drawing.Color.AliceBlue;
			this.GridEX1.TotalRowFormatStyle.BackColorGradient = global::System.Drawing.Color.DarkTurquoise;
			this.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = global::Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
			this.GridEX1.TotalRowPosition = global::Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.GridEX1.UpdateMode = global::Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.GridEX1.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5B3_0 = this.Label2;
			location = new global::System.Drawing.Point(487, 64);
			arg_5B3_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_5DE_0 = this.Label2;
			size = new global::System.Drawing.Size(82, 19);
			arg_5DE_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "درصد مانده";
			this.txt_darsad2.AcceptEnter = true;
			this.txt_darsad2.AllowEdit = false;
			this.txt_darsad2.AllowNew = true;
			this.txt_darsad2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_darsad2.FixLength = 2;
			this.txt_darsad2.FocusColor = true;
			this.txt_darsad2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_68A_0 = this.txt_darsad2;
			location = new global::System.Drawing.Point(385, 54);
			arg_68A_0.Location = location;
			this.txt_darsad2.MaxLength = 2;
			this.txt_darsad2.Name = "txt_darsad2";
			this.txt_darsad2.Nullable = true;
			this.txt_darsad2.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_darsad2.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_6ED_0 = this.txt_darsad2;
			size = new global::System.Drawing.Size(100, 36);
			arg_6ED_0.Size = size;
			this.txt_darsad2.TabIndex = 1;
			this.txt_darsad2.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_darsad2.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_sanad.AcceptEnter = true;
			this.txt_sanad.AllowEdit = false;
			this.txt_sanad.AllowNew = true;
			this.txt_sanad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_sanad.FocusColor = true;
			this.txt_sanad.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_795_0 = this.txt_sanad;
			location = new global::System.Drawing.Point(385, 12);
			arg_795_0.Location = location;
			this.txt_sanad.Name = "txt_sanad";
			this.txt_sanad.Nullable = true;
			this.txt_sanad.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_sanad.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_7EB_0 = this.txt_sanad;
			size = new global::System.Drawing.Size(100, 36);
			arg_7EB_0.Size = size;
			this.txt_sanad.TabIndex = 17;
			this.txt_sanad.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_sanad.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_87E_0 = this.Label1;
			location = new global::System.Drawing.Point(487, 20);
			arg_87E_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_8A9_0 = this.Label1;
			size = new global::System.Drawing.Size(90, 19);
			arg_8A9_0.Size = size;
			this.Label1.TabIndex = 16;
			this.Label1.Text = "شماره سند";
			this.Label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Transparent;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_933_0 = this.Label3;
			location = new global::System.Drawing.Point(251, 20);
			arg_933_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_95E_0 = this.Label3;
			size = new global::System.Drawing.Size(78, 19);
			arg_95E_0.Size = size;
			this.Label3.TabIndex = 19;
			this.Label3.Text = "جمع درآمد";
			this.txt_jam.AcceptEnter = true;
			this.txt_jam.AllowEdit = false;
			this.txt_jam.AllowNew = true;
			this.txt_jam.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_jam.FixLength = 2;
			this.txt_jam.FocusColor = true;
			this.txt_jam.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_A08_0 = this.txt_jam;
			location = new global::System.Drawing.Point(93, 12);
			arg_A08_0.Location = location;
			this.txt_jam.MaxLength = 2;
			this.txt_jam.Name = "txt_jam";
			this.txt_jam.Nullable = true;
			this.txt_jam.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_jam.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_A6E_0 = this.txt_jam;
			size = new global::System.Drawing.Size(156, 36);
			arg_A6E_0.Size = size;
			this.txt_jam.TabIndex = 18;
			this.txt_jam.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			this.txt_jam.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.txt_mande.AcceptEnter = true;
			this.txt_mande.AllowEdit = false;
			this.txt_mande.AllowNew = true;
			this.txt_mande.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_mande.FocusColor = true;
			this.txt_mande.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_B14_0 = this.txt_mande;
			location = new global::System.Drawing.Point(93, 54);
			arg_B14_0.Location = location;
			this.txt_mande.Name = "txt_mande";
			this.txt_mande.Nullable = true;
			this.txt_mande.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.txt_mande.ShortcutsEnabled = false;
			global::System.Windows.Forms.Control arg_B6D_0 = this.txt_mande;
			size = new global::System.Drawing.Size(156, 36);
			arg_B6D_0.Size = size;
			this.txt_mande.TabIndex = 21;
			this.txt_mande.TextAlignment = global::Janus.Windows.GridEX.TextAlignment.Far;
			long? value;
			this.txt_mande.Value = value;
			this.txt_mande.VisualStyle = global::Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Transparent;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_C0E_0 = this.Label4;
			location = new global::System.Drawing.Point(255, 62);
			arg_C0E_0.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control arg_C39_0 = this.Label4;
			size = new global::System.Drawing.Size(89, 19);
			arg_C39_0.Size = size;
			this.Label4.TabIndex = 20;
			this.Label4.Text = "کارمزد مانده";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(608, 412);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Sud_Kharid";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "درصد مشارکت";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000F6D RID: 3949
		private global::System.ComponentModel.IContainer components;
	}
}
