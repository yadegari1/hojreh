using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000076 RID: 118
	[DesignerGenerated]
	public partial class Frm_Register2 : Form
	{
		// Token: 0x0600096F RID: 2415 RVA: 0x0007E0EC File Offset: 0x0007C2EC
		public Frm_Register2()
		{
			base.Load += new EventHandler(this.Frm_Register2_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Secure_FormClosing);
			Frm_Register2.__ENCAddToList(this);
			int days = -1;
			this.days = days;
			bool continueto = false;
			this.continueto = continueto;
			this.lic_dict = new Dictionary<string, bool>();
			this.b = true;
			this.InitializeComponent();
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0007E160 File Offset: 0x0007C360
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Register2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Register2.__ENCList.Count == Frm_Register2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Register2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Register2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Register2.__ENCList[num] = Frm_Register2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Register2.__ENCList.RemoveRange(num, Frm_Register2.__ENCList.Count - num);
						Frm_Register2.__ENCList.Capacity = Frm_Register2.__ENCList.Count;
					}
					Frm_Register2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0007F598 File Offset: 0x0007D798
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00003C9B File Offset: 0x00001E9B
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0007F5B0 File Offset: 0x0007D7B0
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x0007F5C8 File Offset: 0x0007D7C8
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
				EventHandler value2 = new EventHandler(this.UiGroupBox2_Click);
				bool flag = this._UiGroupBox2 != null;
				if (flag)
				{
					this._UiGroupBox2.Click -= value2;
				}
				this._UiGroupBox2 = value;
				flag = (this._UiGroupBox2 != null);
				if (flag)
				{
					this._UiGroupBox2.Click += value2;
				}
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0007F628 File Offset: 0x0007D828
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00003CA5 File Offset: 0x00001EA5
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0007F640 File Offset: 0x0007D840
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00003CAF File Offset: 0x00001EAF
		internal virtual Label txt_days
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_days;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_days = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0007F658 File Offset: 0x0007D858
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00003CB9 File Offset: 0x00001EB9
		internal virtual Label txt_days0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_days0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_days0 = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0007F670 File Offset: 0x0007D870
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x0007F688 File Offset: 0x0007D888
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

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x0007F700 File Offset: 0x0007D900
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0007F760 File Offset: 0x0007D960
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00003CC3 File Offset: 0x00001EC3
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0007F778 File Offset: 0x0007D978
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x00003CCD File Offset: 0x00001ECD
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0007F790 File Offset: 0x0007D990
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x00003CD7 File Offset: 0x00001ED7
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0007F7A8 File Offset: 0x0007D9A8
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00003CE1 File Offset: 0x00001EE1
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0007F7C0 File Offset: 0x0007D9C0
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00003CEB File Offset: 0x00001EEB
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0007F7D8 File Offset: 0x0007D9D8
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00003CF5 File Offset: 0x00001EF5
		internal virtual Label txt_precode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_precode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_precode = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0007F7F0 File Offset: 0x0007D9F0
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0007F808 File Offset: 0x0007DA08
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0007F868 File Offset: 0x0007DA68
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00003CFF File Offset: 0x00001EFF
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0007F880 File Offset: 0x0007DA80
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00003D09 File Offset: 0x00001F09
		internal virtual Label txt_installdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_installdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_installdate = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0007F898 File Offset: 0x0007DA98
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00003D13 File Offset: 0x00001F13
		internal virtual EditBox txt_code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_code = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0007F8B0 File Offset: 0x0007DAB0
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00003D1D File Offset: 0x00001F1D
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

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0007F8C8 File Offset: 0x0007DAC8
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00003D27 File Offset: 0x00001F27
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0007F8E0 File Offset: 0x0007DAE0
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00003D31 File Offset: 0x00001F31
		internal virtual Label txt_owner
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_owner;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_owner = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0007F8F8 File Offset: 0x0007DAF8
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00003D3B File Offset: 0x00001F3B
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0007F910 File Offset: 0x0007DB10
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00003D45 File Offset: 0x00001F45
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0007F928 File Offset: 0x0007DB28
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x0007F940 File Offset: 0x0007DB40
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00003D4F File Offset: 0x00001F4F
		public int days
		{
			[DebuggerNonUserCode]
			get
			{
				return this._days;
			}
			[DebuggerNonUserCode]
			set
			{
				this._days = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0007F9B8 File Offset: 0x0007DBB8
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00003D59 File Offset: 0x00001F59
		private bool continueto
		{
			[DebuggerNonUserCode]
			get
			{
				return this._continueto;
			}
			[DebuggerNonUserCode]
			set
			{
				this._continueto = value;
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00003C84 File Offset: 0x00001E84
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton2_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0007F9D0 File Offset: 0x0007DBD0
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_code.Text, string.Empty, false) == 0;
			if (!flag)
			{
				fp fp = new fp();
				string text = string.Empty;
				try
				{
					Dictionary<string, bool>.Enumerator enumerator = this.lic_dict.GetEnumerator();
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, bool> current = enumerator.Current;
						flag = !current.Value;
						if (flag)
						{
							text = current.Key;
							break;
						}
					}
				}
				finally
				{
					Dictionary<string, bool>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				string text2 = this.txt_code.Text.ToUpper();
				text2 = text2.Replace("_", "-");
				flag = fp.Check_licy(text, text2);
				if (flag)
				{
					try
					{
						File.AppendAllText(Application.StartupPath + "\\fr3.snk", text + ":" + text2 + Environment.NewLine);
						Application.Restart();
					}
					catch (Exception expr_E6)
					{
						ProjectData.SetProjectError(expr_E6);
						Frm_RegHelp frm_RegHelp = new Frm_RegHelp();
						frm_RegHelp.ShowDialog();
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0007FB04 File Offset: 0x0007DD04
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Frm_Secure_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.continueto;
			if (flag)
			{
				ProjectData.EndApp();
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0007FB28 File Offset: 0x0007DD28
		private void Frm_Register2_Load(object sender, EventArgs e)
		{
			this.txt_owner.Text = Public_Function.dict["owner"];
			this.txt_installdate.Text = Public_Function.MiladiToShamsi(Conversions.ToDate(Public_Function.dict["installdate"]));
			fp fp = new fp();
			string str = string.Empty;
			bool flag;
			try
			{
				Dictionary<string, bool>.Enumerator enumerator = this.lic_dict.GetEnumerator();
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, bool> current = enumerator.Current;
					flag = !current.Value;
					if (flag)
					{
						str = current.Key;
						break;
					}
				}
			}
			finally
			{
				Dictionary<string, bool>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.txt_precode.Text = fp.GetPreCode() + "-" + str;
			flag = (this.days != -1);
			if (flag)
			{
				this.txt_days.Text = Conversions.ToString(this.days);
				this.UiButton3.Visible = true;
			}
			else
			{
				this.txt_days.Visible = false;
				this.txt_days0.Visible = false;
				this.UiButton3.Visible = false;
				flag = (this.lic_dict.Count == 1);
				if (flag)
				{
				}
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00003D63 File Offset: 0x00001F63
		private void UiButton3_Click(object sender, EventArgs e)
		{
			this.continueto = true;
			this.Close();
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0000205D File Offset: 0x0000025D
		private void UiGroupBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0007FC7C File Offset: 0x0007DE7C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.b;
			if (flag)
			{
				this.Label7.ForeColor = Color.Red;
				this.b = false;
			}
			else
			{
				this.b = true;
				this.Label7.ForeColor = Color.Black;
			}
		}

		// Token: 0x040003B8 RID: 952
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003BA RID: 954
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040003BB RID: 955
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040003BC RID: 956
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040003BD RID: 957
		[AccessedThroughProperty("txt_days")]
		private Label _txt_days;

		// Token: 0x040003BE RID: 958
		[AccessedThroughProperty("txt_days0")]
		private Label _txt_days0;

		// Token: 0x040003BF RID: 959
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040003C0 RID: 960
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040003C1 RID: 961
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040003C2 RID: 962
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040003C3 RID: 963
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040003C4 RID: 964
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040003C5 RID: 965
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040003C6 RID: 966
		[AccessedThroughProperty("txt_precode")]
		private Label _txt_precode;

		// Token: 0x040003C7 RID: 967
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040003C8 RID: 968
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040003C9 RID: 969
		[AccessedThroughProperty("txt_installdate")]
		private Label _txt_installdate;

		// Token: 0x040003CA RID: 970
		[AccessedThroughProperty("txt_code")]
		private EditBox _txt_code;

		// Token: 0x040003CB RID: 971
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003CC RID: 972
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003CD RID: 973
		[AccessedThroughProperty("txt_owner")]
		private Label _txt_owner;

		// Token: 0x040003CE RID: 974
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040003CF RID: 975
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040003D0 RID: 976
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040003D1 RID: 977
		[CompilerGenerated]
		private int _days;

		// Token: 0x040003D2 RID: 978
		[CompilerGenerated]
		private bool _continueto;

		// Token: 0x040003D3 RID: 979
		public Dictionary<string, bool> lic_dict;

		// Token: 0x040003D4 RID: 980
		private bool b;
	}
}
