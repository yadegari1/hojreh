namespace FruitBox
{
	// Token: 0x0200006B RID: 107
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Factor_Setting : global::System.Windows.Forms.Form
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00075314 File Offset: 0x00073514
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

		// Token: 0x06000837 RID: 2103 RVA: 0x00075364 File Offset: 0x00073564
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem = new global::Janus.Windows.EditControls.UIComboBoxItem();
			global::Janus.Windows.EditControls.UIComboBoxItem uIComboBoxItem2 = new global::Janus.Windows.EditControls.UIComboBoxItem();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.txt_factor_tedad_sefr = new global::Janus.Windows.EditControls.UICheckBox();
			this.txt_factor_furush_control_mojudi = new global::Janus.Windows.EditControls.UICheckBox();
			this.txt_nahve_kharid = new global::Janus.Windows.EditControls.UIComboBox();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.txt_show_sharik = new global::Janus.Windows.EditControls.UICheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).BeginInit();
			this.UiGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Controls.Add(this.Bar1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.FrameStyle = global::Janus.Windows.EditControls.FrameStyle.None;
			global::System.Windows.Forms.Control arg_13A_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_13A_0.Location = location;
			global::System.Windows.Forms.Control arg_154_0 = this.UiGroupBox1;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			arg_154_0.Margin = margin;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_185_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(509, 233);
			arg_185_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.UiGroupBox2.BackgroundStyle = global::Janus.Windows.EditControls.BackgroundStyle.Panel;
			this.UiGroupBox2.Controls.Add(this.txt_show_sharik);
			this.UiGroupBox2.Controls.Add(this.txt_factor_tedad_sefr);
			this.UiGroupBox2.Controls.Add(this.txt_factor_furush_control_mojudi);
			this.UiGroupBox2.Controls.Add(this.txt_nahve_kharid);
			this.UiGroupBox2.Controls.Add(this.Label12);
			this.UiGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control arg_244_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(0, 41);
			arg_244_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_275_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(509, 192);
			arg_275_0.Size = size;
			this.UiGroupBox2.TabIndex = 31;
			this.UiGroupBox2.VisualStyle = global::Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
			this.txt_factor_tedad_sefr.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_factor_tedad_sefr.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_2C8_0 = this.txt_factor_tedad_sefr;
			location = new global::System.Drawing.Point(99, 60);
			arg_2C8_0.Location = location;
			this.txt_factor_tedad_sefr.Name = "txt_factor_tedad_sefr";
			this.txt_factor_tedad_sefr.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_303_0 = this.txt_factor_tedad_sefr;
			size = new global::System.Drawing.Size(273, 23);
			arg_303_0.Size = size;
			this.txt_factor_tedad_sefr.TabIndex = 52;
			this.txt_factor_tedad_sefr.Text = "نمایش جنس های با تعداد صفر";
			this.txt_factor_furush_control_mojudi.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_factor_furush_control_mojudi.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_35A_0 = this.txt_factor_furush_control_mojudi;
			location = new global::System.Drawing.Point(99, 31);
			arg_35A_0.Location = location;
			this.txt_factor_furush_control_mojudi.Name = "txt_factor_furush_control_mojudi";
			this.txt_factor_furush_control_mojudi.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_395_0 = this.txt_factor_furush_control_mojudi;
			size = new global::System.Drawing.Size(273, 23);
			arg_395_0.Size = size;
			this.txt_factor_furush_control_mojudi.TabIndex = 51;
			this.txt_factor_furush_control_mojudi.Text = "کنترل موجودی در فاکتور فروش";
			this.txt_nahve_kharid.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_nahve_kharid.ComboStyle = global::Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.txt_nahve_kharid.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			uIComboBoxItem.FormatStyle.Alpha = 0;
			uIComboBoxItem.IsSeparator = false;
			uIComboBoxItem.Text = "سند و جنس باهم";
			uIComboBoxItem.Value = "0";
			uIComboBoxItem2.FormatStyle.Alpha = 0;
			uIComboBoxItem2.IsSeparator = false;
			uIComboBoxItem2.Text = "اول سند بعد جنس";
			uIComboBoxItem2.Value = "1";
			this.txt_nahve_kharid.Items.AddRange(new global::Janus.Windows.EditControls.UIComboBoxItem[]
			{
				uIComboBoxItem,
				uIComboBoxItem2
			});
			global::System.Windows.Forms.Control arg_48E_0 = this.txt_nahve_kharid;
			location = new global::System.Drawing.Point(84, 128);
			arg_48E_0.Location = location;
			this.txt_nahve_kharid.Name = "txt_nahve_kharid";
			global::System.Windows.Forms.Control arg_4BC_0 = this.txt_nahve_kharid;
			size = new global::System.Drawing.Size(288, 36);
			arg_4BC_0.Size = size;
			this.txt_nahve_kharid.TabIndex = 50;
			this.txt_nahve_kharid.VisualStyle = global::Janus.Windows.UI.VisualStyle.Office2010;
			this.Label12.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label12.AutoSize = true;
			this.Label12.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_522_0 = this.Label12;
			location = new global::System.Drawing.Point(374, 137);
			arg_522_0.Location = location;
			this.Label12.Name = "Label12";
			global::System.Windows.Forms.Control arg_54D_0 = this.Label12;
			size = new global::System.Drawing.Size(123, 19);
			arg_54D_0.Size = size;
			this.Label12.TabIndex = 49;
			this.Label12.Text = "نحوه انتخاب سند";
			this.Bar1.AntiAlias = true;
			this.Bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Bar1.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.Bar1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem2
			});
			global::DevComponents.DotNetBar.Bar arg_5EE_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_5EE_0.Location = location;
			global::System.Windows.Forms.Control arg_608_0 = this.Bar1;
			margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			arg_608_0.Margin = margin;
			this.Bar1.Name = "Bar1";
			global::DevComponents.DotNetBar.Bar arg_636_0 = this.Bar1;
			size = new global::System.Drawing.Size(509, 41);
			arg_636_0.Size = size;
			this.Bar1.Stretch = true;
			this.Bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.Bar1.TabIndex = 17;
			this.Bar1.TabStop = false;
			this.Bar1.Text = "Bar1";
			this.ButtonItem2.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.ButtonItem2.Image = global::FruitBox.My.Resources.Resources.disk;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Text = "ثبت (F2)";
			this.txt_show_sharik.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_show_sharik.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Windows.Forms.Control arg_6F4_0 = this.txt_show_sharik;
			location = new global::System.Drawing.Point(99, 89);
			arg_6F4_0.Location = location;
			this.txt_show_sharik.Name = "txt_show_sharik";
			this.txt_show_sharik.ShowFocusRectangle = false;
			global::System.Windows.Forms.Control arg_72F_0 = this.txt_show_sharik;
			size = new global::System.Drawing.Size(273, 23);
			arg_72F_0.Size = size;
			this.txt_show_sharik.TabIndex = 53;
			this.txt_show_sharik.Text = "نمایش شریک سند به جای صاحب بار";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(9f, 19f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(509, 233);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			margin = new global::System.Windows.Forms.Padding(4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Factor_Setting";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تنظیمات فاکتور فروش";
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UiGroupBox2).EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Bar1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000333 RID: 819
		private global::System.ComponentModel.IContainer components;
	}
}
