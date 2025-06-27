using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006B RID: 107
	[DesignerGenerated]
	public partial class Frm_Factor_Setting : Form
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x000036BC File Offset: 0x000018BC
		[DebuggerNonUserCode]
		public Frm_Factor_Setting()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Amniat_Setting_KeyDown);
			base.Load += new EventHandler(this.Frm_Extra_Setting_Load);
			Frm_Factor_Setting.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00075210 File Offset: 0x00073410
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Factor_Setting.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Factor_Setting.__ENCList.Count == Frm_Factor_Setting.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Factor_Setting.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Factor_Setting.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Factor_Setting.__ENCList[num] = Frm_Factor_Setting.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Factor_Setting.__ENCList.RemoveRange(num, Frm_Factor_Setting.__ENCList.Count - num);
						Frm_Factor_Setting.__ENCList.Capacity = Frm_Factor_Setting.__ENCList.Count;
					}
					Frm_Factor_Setting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00075BD8 File Offset: 0x00073DD8
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x000036FC File Offset: 0x000018FC
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00075BF0 File Offset: 0x00073DF0
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00003706 File Offset: 0x00001906
		internal virtual Bar Bar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar1 = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00075C08 File Offset: 0x00073E08
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00075C20 File Offset: 0x00073E20
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00075C80 File Offset: 0x00073E80
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00003710 File Offset: 0x00001910
		internal virtual BackgroundWorker BackgroundWorker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BackgroundWorker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BackgroundWorker1 = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00075C98 File Offset: 0x00073E98
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x0000371A File Offset: 0x0000191A
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00075CB0 File Offset: 0x00073EB0
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00003724 File Offset: 0x00001924
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderBrowserDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00075CC8 File Offset: 0x00073EC8
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0000372E File Offset: 0x0000192E
		internal virtual UIComboBox txt_nahve_kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_nahve_kharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_nahve_kharid = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00075CE0 File Offset: 0x00073EE0
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00003738 File Offset: 0x00001938
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00075CF8 File Offset: 0x00073EF8
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00003742 File Offset: 0x00001942
		internal virtual UICheckBox txt_factor_furush_control_mojudi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_factor_furush_control_mojudi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_factor_furush_control_mojudi = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00075D10 File Offset: 0x00073F10
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0000374C File Offset: 0x0000194C
		internal virtual UICheckBox txt_factor_tedad_sefr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_factor_tedad_sefr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_factor_tedad_sefr = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00075D28 File Offset: 0x00073F28
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00003756 File Offset: 0x00001956
		internal virtual UICheckBox txt_show_sharik
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_show_sharik;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_show_sharik = value;
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00075D40 File Offset: 0x00073F40
		private void Frm_Amniat_Setting_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F2);
			if (flag)
			{
				bool visible = this.ButtonItem2.Visible;
				if (visible)
				{
					this.ButtonItem2_Click(null, null);
				}
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00075D90 File Offset: 0x00073F90
		private void LoadData()
		{
			bool flag = Public_Function.dict.ContainsKey("factor_Furush_show_tedad_sefr");
			bool flag2;
			if (flag)
			{
				flag2 = Conversions.ToBoolean(Public_Function.dict["factor_Furush_show_tedad_sefr"]);
				if (flag2)
				{
					this.txt_factor_tedad_sefr.Checked = true;
				}
				else
				{
					this.txt_factor_tedad_sefr.Checked = false;
				}
			}
			flag2 = Public_Function.dict.ContainsKey("factor_furush_control_mojudi");
			if (flag2)
			{
				flag = Conversions.ToBoolean(Public_Function.dict["factor_furush_control_mojudi"]);
				if (flag)
				{
					this.txt_factor_furush_control_mojudi.Checked = true;
				}
				else
				{
					this.txt_factor_furush_control_mojudi.Checked = false;
				}
			}
			flag2 = Public_Function.dict.ContainsKey("factor_furush_show_sharik");
			if (flag2)
			{
				flag = Conversions.ToBoolean(Public_Function.dict["factor_furush_show_sharik"]);
				if (flag)
				{
					this.txt_show_sharik.Checked = true;
				}
				else
				{
					this.txt_show_sharik.Checked = false;
				}
			}
			flag2 = Public_Function.dict.ContainsKey("factor_furush_sanad_kind");
			if (flag2)
			{
				flag = (Operators.CompareString(Public_Function.dict["factor_furush_sanad_kind"], "0", false) == 0);
				if (flag)
				{
					this.txt_nahve_kharid.SelectedIndex = 0;
				}
				else
				{
					this.txt_nahve_kharid.SelectedIndex = 1;
				}
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00075ED0 File Offset: 0x000740D0
		private void Save()
		{
			setting setting = new setting();
			setting.Update("factor_Furush_show_tedad_sefr", Conversions.ToString(this.txt_factor_tedad_sefr.Checked));
			Public_Function.dict["factor_Furush_show_tedad_sefr"] = Conversions.ToString(this.txt_factor_tedad_sefr.Checked);
			setting.Update("factor_furush_control_mojudi", Conversions.ToString(this.txt_factor_furush_control_mojudi.Checked));
			Public_Function.dict["factor_furush_control_mojudi"] = Conversions.ToString(this.txt_factor_furush_control_mojudi.Checked);
			setting.Update("factor_furush_sanad_kind", Conversions.ToString(this.txt_nahve_kharid.SelectedIndex));
			Public_Function.dict["factor_furush_sanad_kind"] = Conversions.ToString(this.txt_nahve_kharid.SelectedIndex);
			setting.Update("factor_furush_show_sharik", Conversions.ToString(this.txt_show_sharik.Checked));
			Public_Function.dict["factor_furush_show_sharik"] = Conversions.ToString(this.txt_show_sharik.Checked);
			Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.Close();
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00003760 File Offset: 0x00001960
		private void Frm_Extra_Setting_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000376B File Offset: 0x0000196B
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x04000332 RID: 818
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000334 RID: 820
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000335 RID: 821
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000336 RID: 822
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000337 RID: 823
		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x04000338 RID: 824
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000339 RID: 825
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x0400033A RID: 826
		[AccessedThroughProperty("txt_nahve_kharid")]
		private UIComboBox _txt_nahve_kharid;

		// Token: 0x0400033B RID: 827
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x0400033C RID: 828
		[AccessedThroughProperty("txt_factor_furush_control_mojudi")]
		private UICheckBox _txt_factor_furush_control_mojudi;

		// Token: 0x0400033D RID: 829
		[AccessedThroughProperty("txt_factor_tedad_sefr")]
		private UICheckBox _txt_factor_tedad_sefr;

		// Token: 0x0400033E RID: 830
		[AccessedThroughProperty("txt_show_sharik")]
		private UICheckBox _txt_show_sharik;
	}
}
