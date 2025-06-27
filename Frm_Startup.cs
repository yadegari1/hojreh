using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000DB RID: 219
	[DesignerGenerated]
	public partial class Frm_Startup : Form
	{
		// Token: 0x060013B0 RID: 5040 RVA: 0x000D111C File Offset: 0x000CF31C
		[DebuggerNonUserCode]
		public Frm_Startup()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Startup_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Startup_KeyDown);
			base.Load += new EventHandler(this.Frm_Startup_Load);
			Frm_Startup.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000D117C File Offset: 0x000CF37C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Startup.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Startup.__ENCList.Count == Frm_Startup.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Startup.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Startup.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Startup.__ENCList[num] = Frm_Startup.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Startup.__ENCList.RemoveRange(num, Frm_Startup.__ENCList.Count - num);
						Frm_Startup.__ENCList.Capacity = Frm_Startup.__ENCList.Count;
					}
					Frm_Startup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x000D1F68 File Offset: 0x000D0168
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0000662E File Offset: 0x0000482E
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x000D1F80 File Offset: 0x000D0180
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00006638 File Offset: 0x00004838
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x000D1F98 File Offset: 0x000D0198
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00006642 File Offset: 0x00004842
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x000D1FB0 File Offset: 0x000D01B0
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x000D1FC8 File Offset: 0x000D01C8
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x000D2028 File Offset: 0x000D0228
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x000D2040 File Offset: 0x000D0240
		internal virtual UIButton UiButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton6_Click);
				bool flag = this._UiButton6 != null;
				if (flag)
				{
					this._UiButton6.Click -= value2;
				}
				this._UiButton6 = value;
				flag = (this._UiButton6 != null);
				if (flag)
				{
					this._UiButton6.Click += value2;
				}
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x000D20A0 File Offset: 0x000D02A0
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x000D20B8 File Offset: 0x000D02B8
		internal virtual UIButton UiButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton5_Click);
				bool flag = this._UiButton5 != null;
				if (flag)
				{
					this._UiButton5.Click -= value2;
				}
				this._UiButton5 = value;
				flag = (this._UiButton5 != null);
				if (flag)
				{
					this._UiButton5.Click += value2;
				}
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x000D2118 File Offset: 0x000D0318
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x000D2130 File Offset: 0x000D0330
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000D2190 File Offset: 0x000D0390
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x000D21A8 File Offset: 0x000D03A8
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000D2208 File Offset: 0x000D0408
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x000D2220 File Offset: 0x000D0420
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x000D2280 File Offset: 0x000D0480
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0000664C File Offset: 0x0000484C
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x000D2298 File Offset: 0x000D0498
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00006656 File Offset: 0x00004856
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x000D22B0 File Offset: 0x000D04B0
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00006660 File Offset: 0x00004860
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x000D22C8 File Offset: 0x000D04C8
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x0000666A File Offset: 0x0000486A
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x000D22E0 File Offset: 0x000D04E0
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00006674 File Offset: 0x00004874
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000D22F8 File Offset: 0x000D04F8
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0000667E File Offset: 0x0000487E
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x000D2310 File Offset: 0x000D0510
		private void UiButton1_Click(object sender, EventArgs e)
		{
			Frm_Moshtari showFrm = new Frm_Moshtari();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x000D2338 File Offset: 0x000D0538
		private void UiButton2_Click(object sender, EventArgs e)
		{
			Frm_Bank_Hesab showFrm = new Frm_Bank_Hesab();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000D2360 File Offset: 0x000D0560
		private void UiButton3_Click(object sender, EventArgs e)
		{
			Frm_SahebSaham showFrm = new Frm_SahebSaham();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000D2388 File Offset: 0x000D0588
		private void UiButton4_Click(object sender, EventArgs e)
		{
			Frm_DasteCheck showFrm = new Frm_DasteCheck();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000D23B0 File Offset: 0x000D05B0
		private void UiButton5_Click(object sender, EventArgs e)
		{
			Frm_Moshtarian showFrm = new Frm_Moshtarian();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000D23D8 File Offset: 0x000D05D8
		private void UiButton6_Click(object sender, EventArgs e)
		{
			Frm_PardakhtCheck_Avaldore showFrm = new Frm_PardakhtCheck_Avaldore();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x000D2400 File Offset: 0x000D0600
		private void Frm_Startup_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			setting.Update("startup", Conversions.ToString(!this.UiCheckBox1.Checked));
			Public_Function.dict["startup"] = Conversions.ToString(!this.UiCheckBox1.Checked);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Startup_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00006688 File Offset: 0x00004888
		private void Frm_Startup_Load(object sender, EventArgs e)
		{
			this.UiCheckBox1.Checked = !Conversions.ToBoolean(Public_Function.dict["startup"]);
		}

		// Token: 0x040007A1 RID: 1953
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007A3 RID: 1955
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040007A4 RID: 1956
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x040007A5 RID: 1957
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x040007A6 RID: 1958
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040007A7 RID: 1959
		[AccessedThroughProperty("UiButton6")]
		private UIButton _UiButton6;

		// Token: 0x040007A8 RID: 1960
		[AccessedThroughProperty("UiButton5")]
		private UIButton _UiButton5;

		// Token: 0x040007A9 RID: 1961
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x040007AA RID: 1962
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040007AB RID: 1963
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040007AC RID: 1964
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040007AD RID: 1965
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040007AE RID: 1966
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040007AF RID: 1967
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040007B0 RID: 1968
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040007B1 RID: 1969
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
	}
}
