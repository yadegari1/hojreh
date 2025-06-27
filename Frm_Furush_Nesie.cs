using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000F4 RID: 244
	[DesignerGenerated]
	public partial class Frm_Furush_Nesie : Form
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x00149564 File Offset: 0x00147764
		public Frm_Furush_Nesie()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Kiosk_Furush_KeyDown);
			base.Load += new EventHandler(this.Frm_Kiosk_Furush_Load);
			Frm_Furush_Nesie.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.frm_kala_select = new Frm_SelectItem();
			this.frm_moshtari_nesie = new Frm_SelectItem();
			this.prevent_enter = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.Moshtari_Info = new Moshtari_Info();
			this.kind = 0;
			this.id = 0L;
			this.num = 0L;
			this.kala_name = new Dictionary<string, string>();
			this.Sanad = new Sanad();
			this.tarikh = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00149628 File Offset: 0x00147828
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Furush_Nesie.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Furush_Nesie.__ENCList.Count == Frm_Furush_Nesie.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Furush_Nesie.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Furush_Nesie.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Furush_Nesie.__ENCList[num] = Frm_Furush_Nesie.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Furush_Nesie.__ENCList.RemoveRange(num, Frm_Furush_Nesie.__ENCList.Count - num);
						Frm_Furush_Nesie.__ENCList.Capacity = Frm_Furush_Nesie.__ENCList.Count;
					}
					Frm_Furush_Nesie.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0014BB00 File Offset: 0x00149D00
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x00007DD9 File Offset: 0x00005FD9
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

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0014BB18 File Offset: 0x00149D18
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00007DE3 File Offset: 0x00005FE3
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

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0014BB30 File Offset: 0x00149D30
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00007DED File Offset: 0x00005FED
		internal virtual ButtonItem ButtonItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem1 = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0014BB48 File Offset: 0x00149D48
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0014BB60 File Offset: 0x00149D60
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

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0014BBC0 File Offset: 0x00149DC0
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0014BBD8 File Offset: 0x00149DD8
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem3_Click);
				bool flag = this._ButtonItem3 != null;
				if (flag)
				{
					this._ButtonItem3.Click -= value2;
				}
				this._ButtonItem3 = value;
				flag = (this._ButtonItem3 != null);
				if (flag)
				{
					this._ButtonItem3.Click += value2;
				}
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0014BC38 File Offset: 0x00149E38
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00007DF7 File Offset: 0x00005FF7
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

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0014BC50 File Offset: 0x00149E50
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00007E01 File Offset: 0x00006001
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

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0014BC68 File Offset: 0x00149E68
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00007E0B File Offset: 0x0000600B
		internal virtual CurrencyBox txt_makharej
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_makharej;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_makharej = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0014BC80 File Offset: 0x00149E80
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x00007E15 File Offset: 0x00006015
		internal virtual EditBox txt_sh_mashin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sh_mashin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sh_mashin = value;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0014BC98 File Offset: 0x00149E98
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x00007E1F File Offset: 0x0000601F
		internal virtual NumericBox NumericBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericBox1 = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0014BCB0 File Offset: 0x00149EB0
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x00007E29 File Offset: 0x00006029
		internal virtual ButtonItem ButtonItem15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem15 = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0014BCC8 File Offset: 0x00149EC8
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0014BCE0 File Offset: 0x00149EE0
		internal virtual ButtonItem ButtonItem16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem16_Click);
				bool flag = this._ButtonItem16 != null;
				if (flag)
				{
					this._ButtonItem16.Click -= value2;
				}
				this._ButtonItem16 = value;
				flag = (this._ButtonItem16 != null);
				if (flag)
				{
					this._ButtonItem16.Click += value2;
				}
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0014BD40 File Offset: 0x00149F40
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x0014BD58 File Offset: 0x00149F58
		internal virtual ButtonItem ButtonItem17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem17_Click);
				bool flag = this._ButtonItem17 != null;
				if (flag)
				{
					this._ButtonItem17.Click -= value2;
				}
				this._ButtonItem17 = value;
				flag = (this._ButtonItem17 != null);
				if (flag)
				{
					this._ButtonItem17.Click += value2;
				}
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0014BDB8 File Offset: 0x00149FB8
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0014BDD0 File Offset: 0x00149FD0
		internal virtual ButtonItem ButtonItem18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem18_Click);
				bool flag = this._ButtonItem18 != null;
				if (flag)
				{
					this._ButtonItem18.Click -= value2;
				}
				this._ButtonItem18 = value;
				flag = (this._ButtonItem18 != null);
				if (flag)
				{
					this._ButtonItem18.Click += value2;
				}
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0014BE30 File Offset: 0x0014A030
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0014BE48 File Offset: 0x0014A048
		internal virtual ButtonItem ButtonItem19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem19_Click);
				bool flag = this._ButtonItem19 != null;
				if (flag)
				{
					this._ButtonItem19.Click -= value2;
				}
				this._ButtonItem19 = value;
				flag = (this._ButtonItem19 != null);
				if (flag)
				{
					this._ButtonItem19.Click += value2;
				}
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0014BEA8 File Offset: 0x0014A0A8
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00007E33 File Offset: 0x00006033
		internal virtual CurrencyBox txt_fee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_fee = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0014BEC0 File Offset: 0x0014A0C0
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0014BED8 File Offset: 0x0014A0D8
		internal virtual CurrencyBox txt_jam_kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam_kol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_jam_kol_KeyDown);
				bool flag = this._txt_jam_kol != null;
				if (flag)
				{
					this._txt_jam_kol.KeyDown -= value2;
				}
				this._txt_jam_kol = value;
				flag = (this._txt_jam_kol != null);
				if (flag)
				{
					this._txt_jam_kol.KeyDown += value2;
				}
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0014BF38 File Offset: 0x0014A138
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0014BF50 File Offset: 0x0014A150
		internal virtual CurrencyBox txt_kargari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kargari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_kargari_KeyDown);
				bool flag = this._txt_kargari != null;
				if (flag)
				{
					this._txt_kargari.KeyDown -= value2;
				}
				this._txt_kargari = value;
				flag = (this._txt_kargari != null);
				if (flag)
				{
					this._txt_kargari.KeyDown += value2;
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0014BFB0 File Offset: 0x0014A1B0
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x00007E3D File Offset: 0x0000603D
		internal virtual RibbonStatusBar RibbonStatusBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonStatusBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonStatusBar1 = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0014BFC8 File Offset: 0x0014A1C8
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x00007E47 File Offset: 0x00006047
		internal virtual LabelCommand LabelCommand5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand5 = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0014BFE0 File Offset: 0x0014A1E0
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00007E51 File Offset: 0x00006051
		internal virtual LabelCommand LabelCommand6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand6 = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0014BFF8 File Offset: 0x0014A1F8
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x00007E5B File Offset: 0x0000605B
		internal virtual LabelCommand LabelCommand7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand7 = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0014C010 File Offset: 0x0014A210
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x00007E65 File Offset: 0x00006065
		internal virtual LabelCommand LabelCommand8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand8 = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0014C028 File Offset: 0x0014A228
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x00007E6F File Offset: 0x0000606F
		internal virtual LabelCommand LabelCommand1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand1 = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0014C040 File Offset: 0x0014A240
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x00007E79 File Offset: 0x00006079
		internal virtual LabelCommand LabelCommand2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand2 = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0014C058 File Offset: 0x0014A258
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x00007E83 File Offset: 0x00006083
		internal virtual LabelCommand LabelCommand3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand3 = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0014C070 File Offset: 0x0014A270
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00007E8D File Offset: 0x0000608D
		internal virtual LabelCommand LabelCommand4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand4 = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0014C088 File Offset: 0x0014A288
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0014C0A0 File Offset: 0x0014A2A0
		internal virtual ButtonItem ButtonItem11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem11_Click);
				bool flag = this._ButtonItem11 != null;
				if (flag)
				{
					this._ButtonItem11.Click -= value2;
				}
				this._ButtonItem11 = value;
				flag = (this._ButtonItem11 != null);
				if (flag)
				{
					this._ButtonItem11.Click += value2;
				}
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0014C100 File Offset: 0x0014A300
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0014C118 File Offset: 0x0014A318
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

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x0014C178 File Offset: 0x0014A378
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x0014C190 File Offset: 0x0014A390
		internal virtual DataEntryGrid gridex1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gridex1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyEventHandler value3 = new KeyEventHandler(this.gridex2_KeyDown);
				InitCustomEditEventHandler value4 = new InitCustomEditEventHandler(this.GridEX2_InitCustomEdit);
				EventHandler value5 = new EventHandler(this.gridex2_GotFocus);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.gridex1_ColumnButtonClick);
				EndCustomEditEventHandler value7 = new EndCustomEditEventHandler(this.GridEX2_EndCustomEdit);
				EventHandler value8 = new EventHandler(this.GridEX2_SelectionChanged);
				KeyPressEventHandler value9 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				ColumnActionEventHandler value10 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._gridex1 != null;
				if (flag)
				{
					this._gridex1.LoadingRow -= value2;
					this._gridex1.KeyDown -= value3;
					this._gridex1.InitCustomEdit -= value4;
					this._gridex1.GotFocus -= value5;
					this._gridex1.ColumnButtonClick -= value6;
					this._gridex1.EndCustomEdit -= value7;
					this._gridex1.SelectionChanged -= value8;
					this._gridex1.KeyPress -= value9;
					this._gridex1.CellEdited -= value10;
				}
				this._gridex1 = value;
				flag = (this._gridex1 != null);
				if (flag)
				{
					this._gridex1.LoadingRow += value2;
					this._gridex1.KeyDown += value3;
					this._gridex1.InitCustomEdit += value4;
					this._gridex1.GotFocus += value5;
					this._gridex1.ColumnButtonClick += value6;
					this._gridex1.EndCustomEdit += value7;
					this._gridex1.SelectionChanged += value8;
					this._gridex1.KeyPress += value9;
					this._gridex1.CellEdited += value10;
				}
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x0014C344 File Offset: 0x0014A544
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0014C35C File Offset: 0x0014A55C
		internal virtual CurrencyBox txt_fee_n
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fee_n;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_feen_KeyDown);
				bool flag = this._txt_fee_n != null;
				if (flag)
				{
					this._txt_fee_n.KeyDown -= value2;
				}
				this._txt_fee_n = value;
				flag = (this._txt_fee_n != null);
				if (flag)
				{
					this._txt_fee_n.KeyDown += value2;
				}
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x0014C3BC File Offset: 0x0014A5BC
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x0014C3D4 File Offset: 0x0014A5D4
		internal virtual CurrencyBox txt_jamkol_n
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jamkol_n;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_jam_koln_KeyDown);
				bool flag = this._txt_jamkol_n != null;
				if (flag)
				{
					this._txt_jamkol_n.KeyDown -= value2;
				}
				this._txt_jamkol_n = value;
				flag = (this._txt_jamkol_n != null);
				if (flag)
				{
					this._txt_jamkol_n.KeyDown += value2;
				}
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x0014C434 File Offset: 0x0014A634
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x0014C44C File Offset: 0x0014A64C
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_tarikh_Validated);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.Validated -= value2;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.Validated += value2;
				}
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x0014C4AC File Offset: 0x0014A6AC
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00007E97 File Offset: 0x00006097
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

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0014C4C4 File Offset: 0x0014A6C4
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x00007EA1 File Offset: 0x000060A1
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

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0014C4DC File Offset: 0x0014A6DC
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0014C4F4 File Offset: 0x0014A6F4
		internal virtual SelectItem txt_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged -= obj;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0014C554 File Offset: 0x0014A754
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0014C56C File Offset: 0x0014A76C
		internal virtual DataEntryGrid grid_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._grid_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowActionEventHandler value2 = new RowActionEventHandler(this.grid_moshtari_RowDoubleClick);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.grid_moshtari_ColumnButtonClick);
				bool flag = this._grid_moshtari != null;
				if (flag)
				{
					this._grid_moshtari.RowDoubleClick -= value2;
					this._grid_moshtari.ColumnButtonClick -= value3;
				}
				this._grid_moshtari = value;
				flag = (this._grid_moshtari != null);
				if (flag)
				{
					this._grid_moshtari.RowDoubleClick += value2;
					this._grid_moshtari.ColumnButtonClick += value3;
				}
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x0014C5F4 File Offset: 0x0014A7F4
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x00007EAB File Offset: 0x000060AB
		internal virtual CurrencyBox txt_naghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_naghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_naghd = value;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0014C60C File Offset: 0x0014A80C
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x00007EB5 File Offset: 0x000060B5
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

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0014C624 File Offset: 0x0014A824
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x00007EBF File Offset: 0x000060BF
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

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0014C63C File Offset: 0x0014A83C
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00007EC9 File Offset: 0x000060C9
		internal virtual NumericBox object_f9b79304_ca6f_46b8_84fb_aeebc487606e
		{
			[DebuggerNonUserCode]
			get
			{
				return this._object_f9b79304_ca6f_46b8_84fb_aeebc487606e;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._object_f9b79304_ca6f_46b8_84fb_aeebc487606e = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0014C654 File Offset: 0x0014A854
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00007ED3 File Offset: 0x000060D3
		internal virtual NumericBox object_8574e8dd_4059_400c_bbfc_de488f785574
		{
			[DebuggerNonUserCode]
			get
			{
				return this._object_8574e8dd_4059_400c_bbfc_de488f785574;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._object_8574e8dd_4059_400c_bbfc_de488f785574 = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0014C66C File Offset: 0x0014A86C
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x0014C684 File Offset: 0x0014A884
		internal virtual NavBox txt_num
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_num;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				NavBox.Previous_ClickEventHandler obj = new NavBox.Previous_ClickEventHandler(this.txt_num_Previous_Click);
				NavBox.Next_ClickEventHandler obj2 = new NavBox.Next_ClickEventHandler(this.txt_num_Next_Click);
				bool flag = this._txt_num != null;
				if (flag)
				{
					this._txt_num.Previous_Click -= obj;
					this._txt_num.Next_Click -= obj2;
				}
				this._txt_num = value;
				flag = (this._txt_num != null);
				if (flag)
				{
					this._txt_num.Previous_Click += obj;
					this._txt_num.Next_Click += obj2;
				}
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x0014C70C File Offset: 0x0014A90C
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00007EDD File Offset: 0x000060DD
		private DataTable dt_sanad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_sanad;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_sanad = value;
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0014C724 File Offset: 0x0014A924
		private DataTable GetDetail(string moshtari_id, string tarikh, string Factor_Num)
		{
			string text = string.Empty;
			bool flag = Operators.CompareString(Factor_Num, string.Empty, false) != 0;
			if (flag)
			{
				text = " AND Factor_Num=" + Factor_Num;
			}
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				" SELECT 2 as kind, 'خرید /'+cast( Kharid.num as nvarchar(10)) as sanad,Kharid.num as num,   Kharid_Furush.ID, Kharid_Furush.Kharid_ID AS Kharid_Furush_ID, Kharid_Furush.Moshtari_ID, Kharid_Furush.Kala_ID, Kharid_Furush.Tarikh,    Kharid_Furush.Tarikh_Fa, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Ba_Zarf, Kharid_Furush.Zarf, Kharid_Furush.Vazn_Kol,    Kharid_Furush.Fee, Kharid_Furush.Jam_Kol,Kharid_Furush.Sanad_ID,Kharid_Furush.kargari,Kharid_Furush.jamkol_ba_kargari, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,     Kharid_Furush.Daryaft_ID  FROM         Kharid_Furush INNER JOIN    Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON Kharid_Furush.Kala_ID = Kala.ID INNER JOIN   Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID  where Kharid_Furush.Moshtari_ID= ",
				moshtari_id,
				" AND Kharid_Furush.Tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				text,
				"  UNION ALL   SELECT 1 as kind, 'حق العمل /'+cast( Furush_Hag.num as nvarchar(10)) as sanad, Furush_Hag.num as num,  Furush_Hag_Detail.ID, Furush_Hag_Detail.Furush_Hug_ID AS Kharid_Furush_ID, Furush_Hag_Detail.Moshtari_ID, Furush_Hag_Detail.Kala_ID, Furush_Hag_Detail.Tarikh,   Furush_Hag_Detail.Tarikh_Fa, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf, Furush_Hag_Detail.Zarf, Furush_Hag_Detail.Vazn_Kol,  Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol,Furush_Hag_Detail.Sanad_ID,Furush_Hag_Detail.kargari,Furush_Hag_Detail.jamkol_ba_kargari, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name   ,Furush_Hag_Detail.Daryaft_ID  FROM         Furush_Hag_Detail INNER JOIN  Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID  where Furush_Hag_Detail.Moshtari_ID= ",
				moshtari_id,
				" AND Furush_Hag_Detail.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				text
			}));
			dataTable.Columns.Add("avg", typeof(decimal));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["tedad"] != DBNull.Value);
					if (flag)
					{
						dataRow["tedad"] = this.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
					}
					flag = (dataRow["Vazn_Ba_Zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Ba_Zarf"] = this.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_Ba_Zarf"]));
					}
					flag = (dataRow["Zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["Zarf"] = this.GetDecimalValue(Conversions.ToDecimal(dataRow["Zarf"]));
					}
					flag = (dataRow["Vazn_Kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Kol"] = this.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_Kol"]));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0014C988 File Offset: 0x0014AB88
		private void Update_FurushHag_Nesie(string ID, string Num, string nahve_furush, string Tarikh, DataTable dt)
		{
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			string right = string.Empty;
			Sanad sanad = new Sanad();
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["ID"] == DBNull.Value;
					bool flag2;
					if (!flag)
					{
						flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false));
						if (!flag2)
						{
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
							{
								goto IL_546;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_546;
							}
							bool arg_548_0 = false;
							IL_547:
							flag2 = arg_548_0;
							if (flag2)
							{
								flag = (dataRow["sanad_id"] != DBNull.Value);
								if (flag)
								{
									string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set sanad_id=null where id=", dataRow["ID"]), ";"));
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text2);
								}
								goto IL_5C8;
							}
							goto IL_5C8;
							IL_546:
							arg_548_0 = true;
							goto IL_547;
						}
						tozih = " فروش سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = (dataRow["Sanad_ID"] != DBNull.Value);
						if (flag2)
						{
							flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag)
							{
								text += sanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(0), Tarikh, tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_حق_العمل);
							}
							else
							{
								text += sanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(0), Tarikh, tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_حق_العمل);
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Sanad_ID"])));
						}
						else
						{
							flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += sanad.InsertStr("@codehesab_id", Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(0), Tarikh, tozih, Sanad.SanadType.@null);
							}
							else
							{
								text += sanad.InsertStr("@codehesab_id", Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(0), Tarikh, tozih, Sanad.SanadType.@null);
							}
							text += "Select @Sanad_id=Scope_Identity();";
						}
						IL_5C8:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_61E;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_61E;
						}
						bool arg_620_0 = false;
						IL_61F:
						flag2 = arg_620_0;
						if (flag2)
						{
							right = "NULL";
						}
						else
						{
							right = "@sanad_ID";
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Hag_Detail SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), dataRow["Fee"]), " ,Jam_Kol="), dataRow["Jam_Kol"]), " , Sanad_ID="), right), " , kargari=null"), " , jamkol_ba_kargari=null"), " Where ID="), dataRow["ID"]), ";")));
						continue;
						IL_61E:
						arg_620_0 = true;
						goto IL_61F;
					}
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false));
					if (flag2)
					{
						tozih = " فروش سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
						if (flag2)
						{
							text += sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", Tarikh, tozih, Sanad.SanadType.فروش_حق_العمل);
						}
						else
						{
							text += sanad.InsertStr("@codehesab_id", dataRow["JamKol_ba_kargari"].ToString(), "0", Tarikh, tozih, Sanad.SanadType.فروش_حق_العمل);
						}
						text += "Select @Sanad_id=Scope_Identity();";
						right = "@sanad_id";
					}
					else
					{
						right = "NULL";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Hag_Detail(Furush_Hug_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,kargari,jamkol_ba_kargari) VALUES(" + ID + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ",null,null);")));
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0014D1A0 File Offset: 0x0014B3A0
		private DataTable GetNesieDetail(int kind, string ID)
		{
			string empty = string.Empty;
			bool flag = kind == 1;
			DataTable result;
			if (flag)
			{
				result = Public_Function.FillData("SELECT     Furush_Hag_Detail.ID, Furush_Hag_Detail.Moshtari_ID, Furush_Hag_Detail.Kala_ID, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf,   Furush_Hag_Detail.Zarf, Furush_Hag_Detail.Vazn_Kol, Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol, Furush_Hag_Detail.Sanad_ID,   Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name, Kala.Name as kala_name   FROM         Furush_Hag_Detail INNER JOIN   Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID where furush_hug_id=" + ID + " AND Furush_Hag_Detail.Moshtari_id>0  AND Furush_Hag_Detail.Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Public_Function.dict["today"])));
			}
			return result;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0014D1F8 File Offset: 0x0014B3F8
		private void Get_Kasr_Automatic(object kind, object ID)
		{
			bool flag = Operators.ConditionalCompareObjectEqual(kind, 1, false);
			if (flag)
			{
				this.dt_kala_to_kala = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("SELECT     Kala_To_Kala_Furush.ID, Kala_To_Kala_Furush.Furush_ID, Kala_To_Kala_Furush.Parent_Kala_ID, Kala_To_Kala_Furush.Child_Kala_ID,Kala.Name as Kala_Name  FROM         Kala_To_Kala_Furush INNER JOIN  Kala ON Kala_To_Kala_Furush.Child_Kala_ID = Kala.ID where furush_id=", ID)));
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0014D238 File Offset: 0x0014B438
		private void Kala_Select()
		{
			bool flag = this.gridex1.CurrentRow.Cells["kind"].Value == DBNull.Value;
			checked
			{
				if (flag)
				{
					Public_Function.GridRaiseSoftError(this.gridex1, this.gridex1.CurrentRow, "sanad", "لطفا سند را انتخاب فرمائید");
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(this.gridex1.CurrentRow.Cells["kind"].Value, 1, false);
					if (flag)
					{
						this.dt_kala = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        vazn_kol.Kala_ID, Kala.Name as kala_name,case vazn_kol.vazn_kol  when 0 then null else  vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) end AS vazn_mande  ,case vazn_kol.tedad  when 0 then null else  vazn_kol.tedad - ISNULL(vazn_furush.tedad_furush, 0) end AS tedad_mande  FROM            (SELECT        Furush_Hag_ID, Kala_ID, ISNULL(SUM(Vazn), 0) AS vazn_kol,ISNULL(SUM(Tedad), 0) AS tedad  FROM Furush_Hag_RizBar   WHERE Furush_Hag_ID =", this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), " GROUP BY Furush_Hag_ID, Kala_ID)"), " AS vazn_kol left outer JOIN  (SELECT        Furush_Hug_ID, Kala_ID, ISNULL(SUM(Vazn_Kol), 0) AS vazn_furush,ISNULL(SUM(Tedad), 0) AS tedad_furush   "), " FROM Furush_Hag_Detail where Furush_Hug_ID="), this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), " GROUP BY Furush_Hug_ID, Kala_ID)  "), " AS vazn_furush "), " ON vazn_kol.Furush_Hag_ID = vazn_furush.Furush_Hug_ID  and vazn_kol.Kala_ID=vazn_furush.Kala_ID  INNER Join  Kala ON vazn_kol.Kala_ID = Kala.ID   INNER Join  Furush_Hag ON vazn_kol.Furush_Hag_ID = Furush_Hag.ID  inner join Moshtari  on Furush_Hag.Moshtari_ID=Moshtari.ID WHERE(vazn_furush.vazn_furush is null or  vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) <> 0) ")));
					}
					else
					{
						this.dt_kala = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        vazn_kol.Kala_ID, Kala.Name as kala_name ,case vazn_kol.tedad  when 0 then null else  vazn_kol.tedad - ISNULL(vazn_furush.tedad_furush, 0) end AS tedad_mande,case vazn_kol.vazn_kol when 0 then null else vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) end  AS vazn_mande   FROM     (SELECT        Kharid.ID as kharid_id,max(Kharid.Num) as Num, Kala_ID, ISNULL(SUM(Vazn_Kol), 0) AS vazn_kol,ISNULL(SUM(Tedad), 0) AS tedad  FROM            Kharid_Detail  inner join Kharid  on Kharid_Detail.Kharid_ID=Kharid.ID  WHERE        Kharid.ID=", this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), "GROUP BY Kharid.ID, Kala_ID) AS vazn_kol  left outer JOIN  (SELECT        Kharid_ID, Kala_ID, ISNULL(SUM(Vazn_Kol), 0) AS vazn_furush,ISNULL(SUM(Tedad), 0) AS tedad_furush  FROM            Kharid_Furush "), " where Kharid_ID = "), this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), " GROUP BY Kharid_ID, Kala_ID) AS vazn_furush ON vazn_kol.kharid_id = vazn_furush.Kharid_ID  and vazn_kol.Kala_ID=vazn_furush.Kala_ID  INNER JOIN  Kala ON vazn_kol.Kala_ID = Kala.ID   WHERE        (vazn_furush.vazn_furush is null or vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) <> 0)  ORDER BY Num")));
					}
					flag = (this.frm.ShowDialog(this.dt_kala, null, "انتخاب جنس") == DialogResult.OK);
					if (flag)
					{
						bool flag2 = this.gridex1.Col == this.gridex1.RootTable.Columns["kala_name"].Position && this.gridex1.EditTextBox != null;
						if (flag2)
						{
							this.gridex1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["kala_name"]);
							this.gridex1.GetRow().Cells["kala_name"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_name"]);
							this.gridex1.GetRow().Cells["kala_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_id"]);
							DataEntryGrid gridex = this.gridex1;
							gridex.Col++;
							this.gridex1.EditMode = EditMode.EditOn;
						}
						this.Calc_avg();
					}
				}
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0014D514 File Offset: 0x0014B714
		private void Load_Sanad()
		{
			bool flag = Operators.CompareString(Public_Function.dict["factor_furush_sanad_kind"], "0", false) == 0;
			checked
			{
				if (flag)
				{
					string str = string.Empty;
					flag = !Conversions.ToBoolean(Public_Function.dict["factor_Furush_show_tedad_sefr"]);
					if (flag)
					{
						str = " where (t.tedad_mande is null or tedad_mande<>0) ";
					}
					this.dt_sanad = Public_Function.FillData("select * from (SELECT        vazn_kol.Furush_Hag_ID as id,1 as kind,N'حق العمل - ' + cast( Furush_Hag.Num as nvarchar(10)) as Nume,Furush_Hag.Num,Moshtari.Name +' '+Moshtari.Family as moshtari_name, vazn_kol.Kala_ID, Kala.Name as kala_name,vazn_kol.vazn_kol,vazn_furush.vazn_furush  ,case vazn_kol.vazn_kol  when 0 then null else  vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) end AS vazn_mande  ,case vazn_kol.tedad  when 0 then null else  vazn_kol.tedad - ISNULL(vazn_furush.tedad_furush, 0) end AS tedad_mande  FROM            (SELECT        Furush_Hag_ID, Kala_ID, ISNULL(SUM(Vazn), 0) AS vazn_kol,ISNULL(SUM(Tedad), 0) AS tedad  FROM Furush_Hag_RizBar  WHERE        (Furush_Hag_ID NOT IN  (SELECT        Furush_Hag_ID  FROM            Safi_Furush))  GROUP BY Furush_Hag_ID, Kala_ID) AS vazn_kol left outer JOIN  (SELECT        Furush_Hug_ID, Kala_ID, ISNULL(SUM(Vazn_Kol), 0) AS vazn_furush,ISNULL(SUM(Tedad), 0) AS tedad_furush  FROM Furush_Hag_Detail  GROUP BY Furush_Hug_ID, Kala_ID) AS vazn_furush ON vazn_kol.Furush_Hag_ID = vazn_furush.Furush_Hug_ID  and vazn_kol.Kala_ID=vazn_furush.Kala_ID  INNER Join  Kala ON vazn_kol.Kala_ID = Kala.ID   INNER Join  Furush_Hag ON vazn_kol.Furush_Hag_ID = Furush_Hag.ID  inner join Moshtari  on Furush_Hag.Moshtari_ID=Moshtari.ID WHERE(vazn_furush.vazn_furush is null or vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) <> 0)  union all  SELECT        vazn_kol.kharid_id as id,2 as kind,N'خرید - ' +cast( vazn_kol.Num as nvarchar(10)) as nume,vazn_kol.Num,'' as moshtari_name, vazn_kol.Kala_ID, Kala.Name as kala_name,vazn_kol.vazn_kol,vazn_furush.vazn_furush  ,case vazn_kol.vazn_kol when 0 then null else vazn_kol.vazn_kol - ISNULL(vazn_furush.vazn_furush, 0) end  AS vazn_mande  ,case vazn_kol.tedad  when 0 then null else  vazn_kol.tedad - ISNULL(vazn_furush.tedad_furush, 0) end AS tedad_mande  FROM     (SELECT        Kharid.ID as kharid_id,max(Kharid.Num) as Num, Kala_ID, ISNULL(SUM(Vazn_Kol), 0) AS vazn_kol,ISNULL(SUM(Tedad), 0) AS tedad  FROM            Kharid_Detail  inner join Kharid  on Kharid_Detail.Kharid_ID=Kharid.ID  WHERE        Kharid.Daramad_Sanad_ID is null  GROUP BY Kharid.ID, Kala_ID) AS vazn_kol  left outer JOIN  (SELECT        Kharid_ID, Kala_ID, ISNULL(SUM(Vazn_Kol), 0) AS vazn_furush,ISNULL(SUM(Tedad), 0) AS tedad_furush  FROM            Kharid_Furush  GROUP BY Kharid_ID, Kala_ID) AS vazn_furush ON vazn_kol.kharid_id = vazn_furush.Kharid_ID  and vazn_kol.Kala_ID=vazn_furush.Kala_ID  INNER JOIN  Kala ON vazn_kol.Kala_ID = Kala.ID   ) as t " + str + " ORDER BY Num");
					DataTable dataTable = Public_Function.FillData("select distinct Kharid_ID,Name +' '+ Family as moshtari_name,Kala_ID from Kharid  inner join Kharid_Detail  on Kharid.ID=Kharid_Detail.Kharid_ID  inner join Moshtari  on Kharid_Detail.moshtari_id=Moshtari.ID  where Daramad_Sanad_ID is null");
					string text = string.Empty;
					try
					{
						IEnumerator enumerator = this.dt_sanad.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag = Operators.ConditionalCompareObjectEqual(dataRow["kind"], 2, false);
							if (flag)
							{
								DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("kharid_id=", dataRow["ID"]), " and kala_id="), dataRow["kala_id"])));
								flag = (array.Length > 0);
								if (flag)
								{
									text = string.Empty;
									DataRow[] array2 = array;
									for (int i = 0; i < array2.Length; i++)
									{
										DataRow dataRow2 = array2[i];
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow2["moshtari_name"], ",")));
									}
									text = Public_Function.RemoveLast(text);
									dataRow["moshtari_name"] = text;
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag = (enumerator is IDisposable);
						if (flag)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					flag = Conversions.ToBoolean(Public_Function.dict["factor_furush_show_sharik"]);
					if (flag)
					{
						DataTable dataTable2 = Public_Function.FillData("select Kharid.id,Moshtari.Name+' '+ Family as sharik_name  from Kharid inner join Kharid_Darsad on Kharid.id=Kharid_ID  inner join Moshtari on Kharid_Darsad.Moshtari_ID=Moshtari.ID  WHERE        Kharid.Daramad_Sanad_ID is null");
						try
						{
							IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow3 = (DataRow)enumerator2.Current;
								DataRow[] array = this.dt_sanad.Select(Conversions.ToString(Operators.ConcatenateObject("kind=2 and id=", dataRow3["id"])));
								flag = (array.Length > 0);
								if (flag)
								{
									DataRow[] array3 = array;
									for (int j = 0; j < array3.Length; j++)
									{
										DataRow dataRow4 = array3[j];
										dataRow4["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow3["sharik_name"]);
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
				}
				else
				{
					this.dt_sanad = Public_Function.FillData("SELECT        Furush_Hag.ID as id,1 as kind,N'حق العمل - ' + cast( Furush_Hag.Num as nvarchar(10)) as Nume,Furush_Hag.Num,Moshtari.Name +' '+Moshtari.Family as moshtari_name  from  Furush_Hag   inner join Moshtari  on Furush_Hag.Moshtari_ID=Moshtari.ID   WHERE        ( Furush_Hag.ID  NOT IN  (SELECT        Furush_Hag_ID  FROM            Safi_Furush))   union all   select id,2,N'خرید - ' +cast( Num as nvarchar(10)) as nume,Num,'' as moshtari_name from Kharid   WHERE        Kharid.Daramad_Sanad_ID is null");
					DataTable dataTable3 = Public_Function.FillData("select distinct Kharid.id,Kharid_Detail.moshtari_id,name +' '+family as moshtari_name  from Kharid  inner join Kharid_Detail  on Kharid.id=Kharid_Detail.Kharid_ID  inner join Moshtari  on Kharid_Detail.moshtari_id=Moshtari.ID WHERE        Kharid.Daramad_Sanad_ID is null");
					string text2 = string.Empty;
					try
					{
						IEnumerator enumerator3 = this.dt_sanad.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow5 = (DataRow)enumerator3.Current;
							flag = Operators.ConditionalCompareObjectEqual(dataRow5["kind"], 2, false);
							if (flag)
							{
								DataRow[] array4 = dataTable3.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow5["ID"])));
								flag = (array4.Length > 0);
								if (flag)
								{
									text2 = string.Empty;
									DataRow[] array5 = array4;
									for (int k = 0; k < array5.Length; k++)
									{
										DataRow dataRow6 = array5[k];
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow6["moshtari_name"], ",")));
									}
									text2 = Public_Function.RemoveLast(text2);
									dataRow5["moshtari_name"] = text2;
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator3;
						flag = (enumerator3 is IDisposable);
						if (flag)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					flag = Conversions.ToBoolean(Public_Function.dict["factor_furush_show_sharik"]);
					if (flag)
					{
						DataTable dataTable4 = Public_Function.FillData("select Kharid.id,Moshtari.Name+' '+ Family as sharik_name  from Kharid inner join Kharid_Darsad on Kharid.id=Kharid_ID  inner join Moshtari on Kharid_Darsad.Moshtari_ID=Moshtari.ID  WHERE        Kharid.Daramad_Sanad_ID is null");
						try
						{
							IEnumerator enumerator4 = dataTable4.Rows.GetEnumerator();
							while (enumerator4.MoveNext())
							{
								DataRow dataRow7 = (DataRow)enumerator4.Current;
								DataRow[] array4 = this.dt_sanad.Select(Conversions.ToString(Operators.ConcatenateObject("kind=2 and id=", dataRow7["id"])));
								flag = (array4.Length > 0);
								if (flag)
								{
									array4[0]["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow7["sharik_name"]);
								}
							}
						}
						finally
						{
							IEnumerator enumerator4;
							flag = (enumerator4 is IDisposable);
							if (flag)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0014DA3C File Offset: 0x0014BC3C
		private void Select_Sanad()
		{
			bool flag = this.frm.ShowDialog(this.dt_sanad, null, "انتخاب شماره سند") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					this.id = Conversions.ToLong(this.frm.SelectedRow["id"]);
					this.num = Conversions.ToLong(this.frm.SelectedRow["num"]);
					this.kind = Conversions.ToInteger(this.frm.SelectedRow["kind"]);
					flag = (this.gridex1.Col == this.gridex1.RootTable.Columns["sanad"].Position && this.gridex1.EditTextBox != null);
					if (flag)
					{
						this.gridex1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["num"]);
						this.gridex1.GetRow().Cells["sanad"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["num"]);
						this.gridex1.GetRow().Cells["num"].Value = this.num;
						this.gridex1.GetRow().Cells["kharid_furush_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
						this.gridex1.GetRow().Cells["kind"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kind"]);
						flag = (Conversions.ToDouble(Public_Function.dict["factor_furush_sanad_kind"]) == 0.0);
						if (flag)
						{
							bool flag2 = this.frm.SelectedRow["kala_id"] != DBNull.Value;
							if (flag2)
							{
								this.gridex1.GetRow().Cells["kala_name"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_name"]);
								this.gridex1.GetRow().Cells["kala_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_id"]);
								DataEntryGrid gridex = this.gridex1;
								gridex.Col += 2;
								this.gridex1.EditMode = EditMode.EditOn;
							}
							else
							{
								DataEntryGrid gridex = this.gridex1;
								gridex.Col++;
								this.gridex1.EditMode = EditMode.EditOn;
							}
						}
						else
						{
							DataEntryGrid gridex = this.gridex1;
							gridex.Col++;
							this.gridex1.EditMode = EditMode.EditOn;
						}
					}
					this.Calc_avg();
				}
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0014DD50 File Offset: 0x0014BF50
		private int KeyIndexOfDictionary(Dictionary<string, string> dic, string key)
		{
			int num = 0;
			checked
			{
				try
				{
					Dictionary<string, string>.Enumerator enumerator = dic.GetEnumerator();
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.Current;
						bool flag = Operators.CompareString(current.Key, key, false) == 0;
						if (flag)
						{
							break;
						}
						num++;
					}
				}
				finally
				{
					Dictionary<string, string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return num;
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0014DDC8 File Offset: 0x0014BFC8
		private KeyValuePair<string, string> IndexOfDictionary(Dictionary<string, string> dic, int pos)
		{
			int num = 0;
			checked
			{
				KeyValuePair<string, string> result;
				try
				{
					Dictionary<string, string>.Enumerator enumerator = dic.GetEnumerator();
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.Current;
						bool flag = num == pos;
						if (flag)
						{
							result = current;
							return result;
						}
						num++;
					}
				}
				finally
				{
					Dictionary<string, string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				KeyValuePair<string, string> keyValuePair;
				result = keyValuePair;
				return result;
			}
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0014DE34 File Offset: 0x0014C034
		private long GetKala_ID(string kala_name)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select kala.id from kala where name=" + Public_Function.GetValue(kala_name)));
			return (long)num;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0014DE64 File Offset: 0x0014C064
		private void Frm_Kiosk_Furush_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			switch (e.KeyCode)
			{
			case Keys.F2:
				this.ButtonItem2_Click(null, null);
				break;
			case Keys.F3:
				this.ButtonItem11_Click(null, null);
				break;
			case Keys.F5:
				this.ButtonItem3_Click(null, null);
				break;
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0014DED0 File Offset: 0x0014C0D0
		private void Load_furush()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"declare @kind as int=1;   select moshtari_id,sum(tedad) as tedad ,min(moshtari_name) as moshtari_name,sum(mablagh) as mablagh,factor_num from (  SELECT  max(Moshtari.ID) as moshtari_id,count(Factor_Num) as tedad,max(Moshtari.Name) + ' '+max(Moshtari.Family) + ' - ' + isnull(cast(Factor_Num as nvarchar(10)),'') as moshtari_name  ,CASE @kind WHEN 1 THEN sum(Furush_Hag_Detail.Jam_Kol) WHEN 2 THEN sum(Furush_Hag_Detail.jamkol_ba_kargari) END AS mablagh,Factor_Num   FROM    Furush_Hag INNER JOIN  Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID INNER JOIN  Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID  WHERE   Furush_Hag_Detail.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" and factor_num is not null  group by Furush_Hag_Detail.Factor_Num   union all    SELECT  max(Moshtari.ID) as moshtari_id,count(Factor_Num) as tedad,max(Moshtari.Name) + ' '+max(Moshtari.Family) + ' - ' + isnull(cast(Factor_Num as nvarchar(10)),'') as moshtari_name  ,CASE @kind WHEN 1 THEN sum(Kharid_Furush.Jam_Kol) WHEN 2 THEN sum(Kharid_Furush.jamkol_ba_kargari) END AS mablagh,Factor_Num  FROM    Kharid INNER JOIN  Kharid_Furush ON Kharid.ID = Kharid_Furush.Kharid_ID INNER JOIN  Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID  WHERE   Kharid_Furush.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"  and factor_num is not null group by Kharid_Furush.Factor_Num  ) as t   group by moshtari_id,Factor_Num"
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["mablagh"] = this.GetDecimalValue(Conversions.ToDecimal(dataRow["mablagh"]));
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.grid_moshtari.DataSource = dataTable;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0014DFD0 File Offset: 0x0014C1D0
		private void Frm_Kiosk_Furush_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
			this.tarikh = this.txt_tarikh.Text;
			this.txt_moshtari.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("nume", "شماره سند", 15));
			itemCollection.Add(new Column("moshtari_name", "صاحب بار", 65));
			itemCollection.Add(new Column("kala_name", "جنس", 20));
			itemCollection.Add(new Column("vazn_mande", "وزن مانده", 10));
			itemCollection.Add(new Column("tedad_mande", "تعداد مانده", 10));
			this.frm.items = itemCollection;
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection2.Add(new Column("Code", "کد", 15));
			itemCollection2.Add(new Column("Name", "عنوان", 65));
			itemCollection2.Add(new Column("shahr", "منطقه", 25));
			this.frm_kala_select.items = itemCollection2;
			this.frm_moshtari_nesie.items = itemCollection2;
			this.Load_Default_Nahve_Furush();
			DataTable detail = this.GetDetail(Conversions.ToString(-100), "-1", "");
			this.gridex1.DataSource = detail;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["show_avg"]);
			if (flag)
			{
				this.gridex1.RootTable.Columns["avg"].Visible = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				this.gridex1.RootTable.Columns["kargari"].Visible = true;
				this.gridex1.RootTable.Columns["jamkol_ba_kargari"].Visible = true;
			}
			else
			{
				this.gridex1.RootTable.Columns["kargari"].Visible = false;
				this.gridex1.RootTable.Columns["jamkol_ba_kargari"].Visible = false;
			}
			this.Load_furush();
			this.txt_num.Value = Conversions.ToString(this.Get_Factor_Num());
			this.Load_Sanad();
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0014E240 File Offset: 0x0014C440
		private void Clearlbl()
		{
			try
			{
				IEnumerator enumerator = this.UiGroupBox1.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is Label;
					if (flag)
					{
						bool flag2 = control.Tag != null;
						if (flag2)
						{
							control.BackColor = Color.White;
							((Label)control).BorderStyle = System.Windows.Forms.BorderStyle.None;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0014E2EC File Offset: 0x0014C4EC
		private void ActiveLbl(string text)
		{
			try
			{
				IEnumerator enumerator = this.UiGroupBox1.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is Label;
					if (flag)
					{
						bool flag2 = control.Tag != null;
						if (flag2)
						{
							bool flag3 = Operators.CompareString(control.Text, text, false) == 0;
							if (flag3)
							{
								((Label)control).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
								control.BackColor = Color.MediumTurquoise;
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag3 = enumerator is IDisposable;
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0014E3AC File Offset: 0x0014C5AC
		private int GetLeft()
		{
			checked
			{
				int num = this.UiGroupBox1.Width - 3;
				try
				{
					IEnumerator enumerator = this.UiGroupBox1.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						bool flag = control is Label;
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(control.Tag, "2", false);
							if (flag2)
							{
								bool flag3 = control.Left < num;
								if (flag3)
								{
									num = control.Left - 3;
									control.Tag = "2";
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag3 = enumerator is IDisposable;
					if (flag3)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				return num;
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0014E47C File Offset: 0x0014C67C
		private void Load_Default_Nahve_Furush()
		{
			this.uncheckmenu();
			string left = Public_Function.dict["nahve_furush"];
			bool flag = Operators.CompareString(left, Conversions.ToString(1), false) == 0;
			if (flag)
			{
				this.ButtonItem16.Checked = true;
				this.ButtonItem16_Click(null, null);
			}
			else
			{
				flag = (Operators.CompareString(left, Conversions.ToString(2), false) == 0);
				if (flag)
				{
					this.ButtonItem17.Checked = true;
					this.ButtonItem17_Click(null, null);
				}
				else
				{
					flag = (Operators.CompareString(left, Conversions.ToString(3), false) == 0);
					if (flag)
					{
						this.ButtonItem18.Checked = true;
						this.ButtonItem18_Click(null, null);
					}
					else
					{
						flag = (Operators.CompareString(left, Conversions.ToString(4), false) == 0);
						if (flag)
						{
							this.ButtonItem19.Checked = true;
							this.ButtonItem19_Click(null, null);
						}
					}
				}
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0014E55C File Offset: 0x0014C75C
		private void LoadNahve_Furush(int kind, long id)
		{
			string str = string.Empty;
			bool flag = kind == 1;
			if (flag)
			{
				str = " tarikh=" + Public_Function.ShamsiToMiladi(Public_Function.GetValue(this.txt_tarikh.Text));
			}
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select id from furush_kiosk where " + str));
			flag = (text == null);
			if (flag)
			{
				this.Load_Default_Nahve_Furush();
			}
			else
			{
				DataRow dataRow = Public_Function.FillDataRow("select * from furush_kiosk where id=" + text);
				flag = (dataRow == null);
				if (flag)
				{
					this.Load_Default_Nahve_Furush();
				}
				else
				{
					flag = (dataRow["nahve_furush"] == DBNull.Value);
					if (flag)
					{
						this.uncheckmenu();
						this.ButtonItem16.Checked = true;
						this.ButtonItem16_Click(null, null);
					}
					else
					{
						object objectValue = RuntimeHelpers.GetObjectValue(dataRow["nahve_furush"]);
						this.uncheckmenu();
						object left = objectValue;
						flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
						if (flag)
						{
							this.ButtonItem16.Checked = true;
							this.ButtonItem16_Click(null, null);
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
							if (flag)
							{
								this.ButtonItem17.Checked = true;
								this.ButtonItem17_Click(null, null);
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
								if (flag)
								{
									this.ButtonItem18.Checked = true;
									this.ButtonItem18_Click(null, null);
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
									if (flag)
									{
										this.ButtonItem19.Checked = true;
										this.ButtonItem19_Click(null, null);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00007EE7 File Offset: 0x000060E7
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0014E708 File Offset: 0x0014C908
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			this.gridex1.RootTable.Columns["zarf"].Visible = false;
			this.gridex1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.gridex1.RootTable.Columns["tedad"].Visible = true;
			this.gridex1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem16.Checked = true;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0014E7B0 File Offset: 0x0014C9B0
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			this.gridex1.RootTable.Columns["tedad"].Visible = false;
			this.gridex1.RootTable.Columns["zarf"].Visible = false;
			this.gridex1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.gridex1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem17.Checked = true;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0014E858 File Offset: 0x0014CA58
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			this.gridex1.RootTable.Columns["tedad"].Visible = true;
			this.gridex1.RootTable.Columns["zarf"].Visible = false;
			this.gridex1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.gridex1.RootTable.Columns["vazn_kol"].Visible = false;
			this.uncheckmenu();
			this.ButtonItem18.Checked = true;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0014E900 File Offset: 0x0014CB00
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			this.gridex1.RootTable.Columns["tedad"].Visible = true;
			this.gridex1.RootTable.Columns["zarf"].Visible = true;
			this.gridex1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.gridex1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem19.Checked = true;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0014E9A8 File Offset: 0x0014CBA8
		private void txt_feen_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					this.prevent_enter = true;
					e.SuppressKeyPress = true;
					DataEntryGrid gridex = this.gridex1;
					gridex.Col++;
					this.gridex1.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0014E9F8 File Offset: 0x0014CBF8
		private void txt_kargari_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.prevent_enter;
				if (flag2)
				{
					this.prevent_enter = false;
				}
				else
				{
					this.gridex1.MoveToNewRecord();
					this.gridex1.Col = 0;
					this.gridex1.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0014EA54 File Offset: 0x0014CC54
		private void GetStatusInfo()
		{
			long num = 0L;
			long num2 = 0L;
			string columnKey = "jam_kol";
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				columnKey = "jamkol_ba_kargari";
			}
			GridEXRow[] rows = this.gridex1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (gridEXRow.Cells["Moshtari_ID"].Value == DBNull.Value);
					if (!flag)
					{
						flag = (gridEXRow.Cells[columnKey].Value == DBNull.Value);
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["Moshtari_ID"].Value, -1, false);
							if (flag)
							{
								num = Conversions.ToLong(Operators.AddObject(num, gridEXRow.Cells[columnKey].Value));
							}
							else
							{
								num2 = Conversions.ToLong(Operators.AddObject(num2, gridEXRow.Cells[columnKey].Value));
							}
						}
					}
				}
				this.LabelCommand7.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num)));
				this.LabelCommand5.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num2)));
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0014EBB4 File Offset: 0x0014CDB4
		private void Refresh_Status()
		{
			this.LabelCommand2.Text = this.Moshtari_Info.LastTozih;
			this.LabelCommand1.Text = this.Moshtari_Info.Check_Status;
			this.LabelCommand3.Text = this.Moshtari_Info.Mande_Name;
			bool flag = this.Moshtari_Info.Mande == -1L;
			if (flag)
			{
				this.LabelCommand4.Text = "";
			}
			else
			{
				this.LabelCommand4.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(this.Moshtari_Info.Mande)));
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0014EC58 File Offset: 0x0014CE58
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00007F1F File Offset: 0x0000611F
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			this.gridex1focused = true;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0014ECAC File Offset: 0x0014CEAC
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.gridex1.Row < -1;
			if (flag)
			{
				this.gridex1.Row = -1;
			}
			this.Clean_Status();
			this.GetStatusInfo();
			checked
			{
				flag = (this.gridex1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.gridex1.Row - 1 >= 0);
				if (flag)
				{
					bool flag2 = this.gridex1.GetRows()[this.gridex1.Row - 1].Cells["Zarf"].Value != DBNull.Value;
					if (flag2)
					{
						this.gridex1.GetRow().Cells["Zarf"].Value = RuntimeHelpers.GetObjectValue(this.gridex1.GetRows()[this.gridex1.Row - 1].Cells["Zarf"].Value);
						flag2 = (this.gridex1.Col == this.gridex1.RootTable.Columns["Zarf"].Position);
						if (flag2)
						{
							flag = (this.gridex1.EditTextBox != null);
							if (flag)
							{
								this.gridex1.EditTextBox.Text = Conversions.ToString(this.gridex1.GetRows()[this.gridex1.Row - 1].Cells["Zarf"].Value);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00007F2A File Offset: 0x0000612A
		private void gridex2_GotFocus(object sender, EventArgs e)
		{
			this.gridex1focused = false;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0014EE48 File Offset: 0x0014D048
		private void GridEX2_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.gridex1.Row < -1;
			if (flag)
			{
				this.gridex1.Row = -1;
			}
			flag = (this.gridex1.CurrentRow.Cells["moshtari_ID"].Value != DBNull.Value);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectGreater(this.gridex1.CurrentRow.Cells["moshtari_id"].Value, 0, false);
				if (flag2)
				{
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.gridex1.CurrentRow.Cells["Moshtari_ID"].Value);
					this.Refresh_Status();
				}
				else
				{
					this.Clean_Status();
				}
			}
			else
			{
				this.Clean_Status();
			}
			this.GetStatusInfo();
			checked
			{
				bool flag2 = this.gridex1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.gridex1.Row - 1 >= 0;
				if (flag2)
				{
					flag = (this.gridex1.GetRows()[this.gridex1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
					if (flag)
					{
						this.gridex1.GetRow().Cells["Zarf"].Value = RuntimeHelpers.GetObjectValue(this.gridex1.GetRows()[this.gridex1.Row - 1].Cells["Zarf"].Value);
						flag2 = (this.gridex1.Col == this.gridex1.RootTable.Columns["Zarf"].Position);
						if (flag2)
						{
							flag = (this.gridex1.EditTextBox != null);
							if (flag)
							{
								this.gridex1.EditTextBox.Text = Conversions.ToString(this.gridex1.GetRows()[this.gridex1.Row - 1].Cells["Zarf"].Value);
							}
						}
					}
				}
				flag2 = (this.gridex1.GetRow().RowType == RowType.Record);
				if (flag2)
				{
					this.gridex1.GetRow().Cells["sanad"].EditType = EditType.NoEdit;
					this.gridex1.GetRow().Cells["sanad"].ButtonEnabled = false;
					this.gridex1.GetRow().Cells["sanad"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
				}
			}
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0014F100 File Offset: 0x0014D300
		private void txt_jam_koln_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.prevent_enter;
				if (flag2)
				{
					this.prevent_enter = false;
				}
				else
				{
					flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag2)
					{
						this.gridex1.UpdateData();
						this.gridex1.Col = 0;
						this.gridex1.Row = -1;
						this.gridex1.EditMode = EditMode.EditOn;
						this.GridEX2_SelectionChanged(null, null);
					}
					else
					{
						this.gridex1.MoveToNewRecord();
						this.gridex1.Col = 0;
						this.gridex1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0014F1BC File Offset: 0x0014D3BC
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				bool flag2;
				if (flag)
				{
					flag2 = this.prevent_enter;
					if (flag2)
					{
						this.prevent_enter = false;
						return;
					}
					flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag2)
					{
						this.gridex1.UpdateData();
						this.prevent_enter = true;
						this.gridex1.Col = 0;
						this.gridex1.Row = -1;
						this.gridex1.EditMode = EditMode.EditOn;
						this.GridEX1_SelectionChanged(null, null);
						flag2 = (Operators.CompareString(this.gridex1.GetRow(this.gridex1.RowCount - 1).Cells["zarf"].Value.ToString(), string.Empty, false) != 0);
						if (flag2)
						{
							this.gridex1.CurrentRow.Cells["zarf"].Value = this.gridex1.GetRow(this.gridex1.RowCount - 1).Cells["zarf"].Value.ToString();
						}
					}
					else
					{
						this.prevent_enter = true;
						DataEntryGrid gridex = this.gridex1;
						gridex.Col++;
					}
				}
				flag2 = (e.KeyCode == Keys.Left);
				if (flag2)
				{
					this.gridex1.Focus();
					this.gridex1.MoveToNewRecord();
					this.gridex1.Col = 0;
					this.gridex1.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0014F350 File Offset: 0x0014D550
		private void GetTotalZarf(GridEX Grid)
		{
			decimal num = 0m;
			GridEXRow[] rows = Grid.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["tedad"].Value != DBNull.Value;
					if (flag)
					{
						bool flag2 = gridEXRow.Cells["zarf"].Value != DBNull.Value;
						if (flag2)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, Operators.MultiplyObject(gridEXRow.Cells["tedad"].Value, gridEXRow.Cells["zarf"].Value)));
						}
					}
				}
				Grid.GetTotalRow().Cells["zarf"].Text = Conversions.ToString(this.GetDecimalValue(num));
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0014F440 File Offset: 0x0014D640
		private void Calc_Kargari()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(Public_Function.dict["kargari_kind"]) == 1.0;
				if (!flag2)
				{
					flag2 = (Public_Function.dict["kargari_fee"] != DBNull.Value && Public_Function.dict["kargari_fee"] != null);
					if (flag2)
					{
						flag = (this.gridex1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.gridex1.GetRow().Cells["vazn_kol"].Value != null);
						if (flag)
						{
							this.gridex1.GetRow().Cells["kargari"].Value = Operators.MultiplyObject(Public_Function.dict["kargari_fee"], this.gridex1.GetRow().Cells["vazn_kol"].Value);
							flag2 = (this.gridex1.GetRow().Cells["jam_kol"].Value != DBNull.Value && this.gridex1.GetRow().Cells["jam_kol"].Value != null);
							if (flag2)
							{
								flag = Operators.ConditionalCompareObjectNotEqual(this.gridex1.GetRow().Cells["jam_kol"].Value, 0, false);
								if (flag)
								{
									this.gridex1.GetRow().Cells["jamkol_ba_kargari"].Value = Operators.AddObject(this.gridex1.GetRow().Cells["jam_kol"].Value, this.gridex1.GetRow().Cells["kargari"].Value);
								}
								else
								{
									this.gridex1.GetRow().Cells["jamkol_ba_kargari"].Value = 0;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0014F680 File Offset: 0x0014D880
		private void GetSum(GridEX Grid, string key, bool GroupDigit = false)
		{
			decimal num = 0m;
			int arg_13_0 = -1;
			checked
			{
				int num2 = Grid.RowCount - 1;
				int num3 = arg_13_0;
				bool flag;
				while (true)
				{
					int arg_82_0 = num3;
					int num4 = num2;
					if (arg_82_0 > num4)
					{
						break;
					}
					flag = (Grid.GetRow(num3).RowType == RowType.TotalRow);
					if (!flag)
					{
						flag = (Grid.GetRow(num3).Cells[key].Value == DBNull.Value);
						if (!flag)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, Grid.GetRow(num3).Cells[key].Value));
						}
					}
					num3++;
				}
				flag = !GroupDigit;
				if (flag)
				{
					Grid.GetTotalRow().Cells[key].Text = Conversions.ToString(this.GetDecimalValue(num));
				}
				else
				{
					Grid.GetTotalRow().Cells[key].Text = Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
				}
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0014F768 File Offset: 0x0014D968
		private void Calc(GridEX Grid)
		{
			bool flag = Grid.GetRow().Cells["Tedad"].Value != DBNull.Value && Grid.GetRow().Cells["Tedad"].Value != null;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				object expr_63 = Grid.GetRow().Cells["Tedad"].Value;
				num = ((expr_63 != null) ? ((decimal?)expr_63) : num2);
			}
			flag = (Grid.GetRow().Cells["Zarf"].Value != DBNull.Value && Grid.GetRow().Cells["Zarf"].Value != null);
			decimal? num3;
			if (flag)
			{
				num3 = Conversions.ToDecimal(Grid.GetRow().Cells["Zarf"].Value);
			}
			flag = (Grid.GetRow().Cells["vazn_ba_zarf"].Value != DBNull.Value && Grid.GetRow().Cells["vazn_ba_zarf"].Value != null);
			decimal? num4;
			if (flag)
			{
				object expr_147 = Grid.GetRow().Cells["vazn_ba_zarf"].Value;
				num4 = ((expr_147 != null) ? ((decimal?)expr_147) : num2);
			}
			flag = (num.HasValue && num4.HasValue && num3.HasValue);
			bool flag4;
			if (flag)
			{
				decimal? arg_1BE_0;
				if (!(num3.HasValue & num.HasValue))
				{
					arg_1BE_0 = null;
				}
				else
				{
					decimal? num5 = new decimal?(decimal.Multiply(num3.GetValueOrDefault(), num.GetValueOrDefault()));
					arg_1BE_0 = num5;
				}
				decimal? num6 = arg_1BE_0;
				bool? arg_200_0;
				if (!(num6.HasValue & num4.HasValue))
				{
					arg_200_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(decimal.Compare(num6.GetValueOrDefault(), num4.GetValueOrDefault()) >= 0);
					arg_200_0 = flag2;
				}
				bool? flag3 = arg_200_0;
				flag4 = flag3.GetValueOrDefault();
				if (flag4)
				{
					Grid.CurrentRow.Cells["Zarf"].Value = DBNull.Value;
					Grid.CurrentRow.Cells["vazn_kol"].Value = num4;
					this.GetSum(Grid, "zarf", false);
				}
				else
				{
					GridEXCell arg_2FF_0 = Grid.CurrentRow.Cells["vazn_kol"];
					bool arg_2C4_0 = num4.HasValue;
					decimal? arg_2BB_0;
					if (!(num.HasValue & num3.HasValue))
					{
						arg_2BB_0 = null;
					}
					else
					{
						decimal? num7 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
						arg_2BB_0 = num7;
					}
					decimal? num5 = arg_2BB_0;
					decimal? arg_2F0_0;
					if (!(arg_2C4_0 & num5.HasValue))
					{
						arg_2F0_0 = null;
					}
					else
					{
						num6 = new decimal?(decimal.Subtract(num4.GetValueOrDefault(), num5.GetValueOrDefault()));
						arg_2F0_0 = num6;
					}
					arg_2FF_0.Value = this.GetDecimalValue((T)arg_2F0_0);
				}
			}
			flag4 = (!num.HasValue || !num3.HasValue);
			if (flag4)
			{
				flag = num4.HasValue;
				if (flag)
				{
					Grid.CurrentRow.Cells["vazn_kol"].Value = num4;
				}
			}
			this.GetSum(Grid, "vazn_kol", false);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0014FAD8 File Offset: 0x0014DCD8
		private void Calc_avg()
		{
			GridEXRow[] rows = this.gridex1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["tedad"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.BeginEdit();
						gridEXRow.Cells["avg"].Value = DBNull.Value;
						gridEXRow.EndEdit();
						break;
					}
					flag = (gridEXRow.Cells["vazn_ba_zarf"].Value == DBNull.Value);
					if (flag)
					{
						gridEXRow.BeginEdit();
						gridEXRow.Cells["avg"].Value = DBNull.Value;
						gridEXRow.EndEdit();
						break;
					}
					flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["tedad"].Value, 0, false);
					if (flag)
					{
						gridEXRow.BeginEdit();
						gridEXRow.Cells["avg"].Value = DBNull.Value;
						gridEXRow.EndEdit();
						break;
					}
					gridEXRow.BeginEdit();
					gridEXRow.Cells["avg"].Value = decimal.Round(Conversions.ToDecimal(Operators.DivideObject(gridEXRow.Cells["vazn_ba_zarf"].Value, gridEXRow.Cells["tedad"].Value)), 2);
					gridEXRow.EndEdit();
				}
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0014FC68 File Offset: 0x0014DE68
		private void update_avg(GridEX Grid)
		{
			bool flag = Grid.CurrentRow.Cells["tedad"].Value == DBNull.Value;
			if (flag)
			{
				Grid.CurrentRow.Cells["avg"].Value = DBNull.Value;
			}
			else
			{
				flag = (Grid.CurrentRow.Cells["vazn_ba_zarf"].Value == DBNull.Value);
				if (flag)
				{
					Grid.CurrentRow.Cells["avg"].Value = DBNull.Value;
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(Grid.CurrentRow.Cells["tedad"].Value, 0, false);
					if (flag)
					{
						Grid.CurrentRow.Cells["avg"].Value = DBNull.Value;
					}
					else
					{
						Grid.CurrentRow.Cells["avg"].Value = decimal.Round(Conversions.ToDecimal(Operators.DivideObject(Grid.CurrentRow.Cells["vazn_ba_zarf"].Value, Grid.CurrentRow.Cells["tedad"].Value)), 2);
					}
				}
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0014FDC4 File Offset: 0x0014DFC4
		private void CalcMablagh(GridEX Grid, bool calc_jam_kol, bool calc_fee)
		{
			bool flag = Grid.RootTable.Columns["vazn_kol"].Visible;
			bool flag2;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				flag2 = (Grid.GetRow().Cells["vazn_kol"].Value != DBNull.Value && Grid.GetRow().Cells["vazn_kol"].Value != null);
				if (flag2)
				{
					object expr_83 = Grid.GetRow().Cells["vazn_kol"].Value;
					num = ((expr_83 != null) ? ((decimal?)expr_83) : num2);
				}
			}
			else
			{
				flag2 = (Grid.GetRow().Cells["tedad"].Value != DBNull.Value && Grid.GetRow().Cells["tedad"].Value != null);
				if (flag2)
				{
					object expr_FD = Grid.GetRow().Cells["tedad"].Value;
					num = ((expr_FD != null) ? ((decimal?)expr_FD) : num2);
				}
			}
			flag2 = (Grid.GetRow().Cells["fee"].Value != DBNull.Value && Grid.GetRow().Cells["fee"].Value != null);
			decimal? num3;
			if (flag2)
			{
				object expr_175 = Grid.GetRow().Cells["fee"].Value;
				num3 = ((expr_175 != null) ? ((decimal?)expr_175) : num2);
			}
			flag2 = (Grid.GetRow().Cells["jam_Kol"].Value != DBNull.Value && Grid.GetRow().Cells["jam_Kol"].Value != null);
			decimal? num4;
			if (flag2)
			{
				object expr_1EC = Grid.GetRow().Cells["jam_Kol"].Value;
				num4 = ((expr_1EC != null) ? ((decimal?)expr_1EC) : num2);
			}
			if (calc_jam_kol)
			{
				flag = (num.HasValue && num3.HasValue);
				if (flag)
				{
					bool flag3 = Grid.CurrentRow.Cells["jam_kol"].Value == DBNull.Value;
					if (flag3)
					{
						GridEXCell arg_2A6_0 = Grid.CurrentRow.Cells["jam_kol"];
						decimal? arg_2A1_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_2A1_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_2A1_0 = num5;
						}
						arg_2A6_0.Value = arg_2A1_0;
					}
					else
					{
						decimal? arg_2EC_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_2EC_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_2EC_0 = num5;
						}
						decimal value = Conversions.ToDecimal(Operators.SubtractObject(arg_2EC_0, Grid.CurrentRow.Cells["jam_kol"].Value));
						flag3 = (decimal.Compare(Math.Abs(value), new decimal(100L)) > 0);
						if (flag3)
						{
							GridEXCell arg_387_0 = Grid.CurrentRow.Cells["jam_kol"];
							decimal? arg_382_0;
							if (!(num.HasValue & num3.HasValue))
							{
								arg_382_0 = null;
							}
							else
							{
								decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
								arg_382_0 = num5;
							}
							arg_387_0.Value = arg_382_0;
						}
					}
				}
			}
			if (calc_fee)
			{
				flag2 = (num.HasValue && num4.HasValue);
				if (flag2)
				{
					decimal zero = decimal.Zero;
					bool? arg_3F2_0;
					if (!num.HasValue)
					{
						arg_3F2_0 = null;
					}
					else
					{
						bool? flag4 = new bool?(decimal.Compare(num.GetValueOrDefault(), zero) == 0);
						arg_3F2_0 = flag4;
					}
					bool? flag5 = arg_3F2_0;
					flag = flag5.GetValueOrDefault();
					if (!flag)
					{
						GridEXCell arg_458_0 = Grid.CurrentRow.Cells["fee"];
						decimal? arg_453_0;
						if (!(num4.HasValue & num.HasValue))
						{
							arg_453_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Divide(num4.GetValueOrDefault(), num.GetValueOrDefault()));
							arg_453_0 = num5;
						}
						arg_458_0.Value = arg_453_0;
					}
				}
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00150234 File Offset: 0x0014E434
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "fee", false) == 0;
			if (flag)
			{
				bool flag2 = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (flag2)
				{
					e.Value = ((CurrencyBox)e.EditControl).Value;
				}
			}
			else
			{
				bool flag2 = Operators.CompareString(left, "jam_kol", false) == 0;
				if (flag2)
				{
					flag = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (flag)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
				}
				else
				{
					flag2 = (Operators.CompareString(left, "kargari", false) == 0);
					if (flag2)
					{
						flag = ((CurrencyBox)e.EditControl).Value.HasValue;
						if (flag)
						{
							e.Value = ((CurrencyBox)e.EditControl).Value;
						}
					}
				}
			}
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00150234 File Offset: 0x0014E434
		private void GridEX2_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "fee", false) == 0;
			if (flag)
			{
				bool flag2 = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (flag2)
				{
					e.Value = ((CurrencyBox)e.EditControl).Value;
				}
			}
			else
			{
				bool flag2 = Operators.CompareString(left, "jam_kol", false) == 0;
				if (flag2)
				{
					flag = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (flag)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
				}
				else
				{
					flag2 = (Operators.CompareString(left, "kargari", false) == 0);
					if (flag2)
					{
						flag = ((CurrencyBox)e.EditControl).Value.HasValue;
						if (flag)
						{
							e.Value = ((CurrencyBox)e.EditControl).Value;
						}
					}
				}
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00150348 File Offset: 0x0014E548
		private object GetMande(string kind, string id, string kala_id, int type)
		{
			bool flag = Operators.CompareString(Public_Function.dict["factor_furush_sanad_kind"], "0", false) == 0;
			object result;
			if (flag)
			{
				DataRow[] array = this.dt_sanad.Select(string.Concat(new string[]
				{
					"kind=",
					kind,
					" AND id=",
					id,
					" AND kala_id=",
					kala_id
				}));
				flag = (array.Length > 0);
				if (flag)
				{
					bool flag2 = type == 0;
					if (flag2)
					{
						result = array[0]["vazn_mande"];
						return result;
					}
					result = array[0]["tedad_mande"];
					return result;
				}
			}
			else
			{
				DataRow[] array2 = this.dt_kala.Select("kala_id=" + kala_id);
				bool flag2 = array2.Length > 0;
				if (flag2)
				{
					flag = (type == 0);
					if (flag)
					{
						result = array2[0]["vazn_mande"];
						return result;
					}
					result = array2[0]["tedad_mande"];
					return result;
				}
			}
			result = DBNull.Value;
			return result;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0015045C File Offset: 0x0014E65C
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			GridEX gridEX = (GridEX)sender;
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "kala_name", false) == 0;
			if (!flag)
			{
				flag = (Operators.CompareString(left, "tedad", false) == 0);
				if (flag)
				{
					bool flag2 = Conversions.ToBoolean(Public_Function.dict["factor_furush_control_mojudi"]);
					if (flag2)
					{
						bool flag3 = gridEX.CurrentRow.Cells["tedad"].Value != DBNull.Value;
						if (flag3)
						{
							bool flag4 = this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value != DBNull.Value;
							if (flag4)
							{
								bool flag5 = this.gridex1.CurrentRow.Cells["kala_id"].Value != DBNull.Value;
								if (flag5)
								{
									bool flag6 = this.GetMande(Conversions.ToString(this.gridex1.CurrentRow.Cells["kind"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kala_id"].Value), 1) != DBNull.Value;
									if (flag6)
									{
										bool flag7 = Operators.ConditionalCompareObjectLess(Operators.SubtractObject(this.GetMande(Conversions.ToString(this.gridex1.CurrentRow.Cells["kind"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kala_id"].Value), 1), gridEX.CurrentRow.Cells["tedad"].Value), 0, false);
										if (flag7)
										{
											Public_Function.ShowMessage("موجودی جنس مورد نظر در فاکتور انتخابی کمتر از مقدار وارد شده است", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
											gridEX.CurrentRow.Cells["tedad"].Value = 0;
											return;
										}
									}
								}
							}
						}
					}
					this.Calc((GridEX)sender);
					this.GetSum((GridEX)sender, "tedad", false);
					this.GetTotalZarf((GridEX)sender);
					this.update_avg((GridEX)sender);
				}
				else
				{
					bool flag7 = Operators.CompareString(left, "vazn_ba_zarf", false) == 0;
					if (flag7)
					{
						this.Calc((GridEX)sender);
						this.GetSum((GridEX)sender, "vazn_ba_zarf", false);
						this.update_avg((GridEX)sender);
					}
					else
					{
						flag7 = (Operators.CompareString(left, "vazn_kol", false) == 0);
						if (flag7)
						{
							bool flag6 = Conversions.ToBoolean(Public_Function.dict["factor_furush_control_mojudi"]);
							if (flag6)
							{
								bool flag5 = gridEX.CurrentRow.Cells["vazn_kol"].Value != DBNull.Value;
								if (flag5)
								{
									bool flag4 = this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value != DBNull.Value;
									if (flag4)
									{
										bool flag3 = this.gridex1.CurrentRow.Cells["kala_id"].Value != DBNull.Value;
										if (flag3)
										{
											bool flag2 = this.GetMande(Conversions.ToString(this.gridex1.CurrentRow.Cells["kind"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kala_id"].Value), 0) != DBNull.Value;
											if (flag2)
											{
												flag = Operators.ConditionalCompareObjectLess(Operators.SubtractObject(this.GetMande(Conversions.ToString(this.gridex1.CurrentRow.Cells["kind"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kharid_furush_id"].Value), Conversions.ToString(this.gridex1.CurrentRow.Cells["kala_id"].Value), 0), gridEX.CurrentRow.Cells["vazn_kol"].Value), 0, false);
												if (flag)
												{
													Public_Function.ShowMessage("موجودی جنس مورد نظر در فاکتور انتخابی کمتر از مقدار وارد شده است", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
													gridEX.CurrentRow.Cells["vazn_kol"].Value = 0;
													return;
												}
											}
										}
									}
								}
							}
							this.GetSum((GridEX)sender, "Vazn_Kol", false);
							this.CalcMablagh((GridEX)sender, true, false);
							this.Calc_Kargari();
							flag7 = !gridEX.RootTable.Columns["vazn_ba_zarf"].Visible;
							if (flag7)
							{
								decimal d = 0m;
								flag7 = (gridEX.CurrentRow.Cells["zarf"].Value != DBNull.Value);
								if (flag7)
								{
									d = Conversions.ToDecimal(gridEX.CurrentRow.Cells["zarf"].Value);
								}
								decimal d2 = 0m;
								flag7 = (gridEX.CurrentRow.Cells["tedad"].Value != DBNull.Value);
								if (flag7)
								{
									d2 = Conversions.ToDecimal(gridEX.CurrentRow.Cells["tedad"].Value);
								}
								flag7 = (gridEX.CurrentRow.Cells["vazn_kol"].Value != DBNull.Value);
								if (flag7)
								{
									gridEX.CurrentRow.Cells["vazn_ba_zarf"].Value = Operators.AddObject(gridEX.CurrentRow.Cells["vazn_kol"].Value, decimal.Multiply(d2, d));
								}
								this.update_avg((GridEX)sender);
								this.GetSum((GridEX)sender, "vazn_ba_zarf", false);
							}
						}
						else
						{
							flag7 = (Operators.CompareString(left, "zarf", false) == 0);
							if (flag7)
							{
								bool flag6 = gridEX.CurrentRow.Cells["zarf"].Value == DBNull.Value;
								if (flag6)
								{
									gridEX.CurrentRow.Cells["zarf"].Value = 0;
								}
								this.Calc((GridEX)sender);
								this.GetTotalZarf((GridEX)sender);
							}
							else
							{
								flag7 = (Operators.CompareString(left, "fee", false) == 0);
								if (flag7)
								{
									this.CalcMablagh(gridEX, true, false);
									this.Calc_Kargari();
								}
								else
								{
									flag7 = (Operators.CompareString(left, "jam_kol", false) == 0);
									if (flag7)
									{
										this.GetSum((GridEX)sender, "jam_Kol", true);
										this.CalcMablagh(gridEX, false, true);
										this.Calc_Kargari();
									}
									else
									{
										flag7 = (Operators.CompareString(left, "kargari", false) == 0);
										if (flag7)
										{
											bool flag6 = gridEX.GetRow().Cells["jam_kol"].Value != DBNull.Value && gridEX.GetRow().Cells["jam_kol"].Value != null;
											if (flag6)
											{
												bool flag5 = Operators.ConditionalCompareObjectNotEqual(gridEX.GetRow().Cells["jam_kol"].Value, 0, false);
												if (flag5)
												{
													bool flag4 = gridEX.GetRow().Cells["kargari"].Value != DBNull.Value;
													if (flag4)
													{
														gridEX.GetRow().Cells["jamkol_ba_kargari"].Value = Operators.AddObject(gridEX.GetRow().Cells["jam_kol"].Value, gridEX.GetRow().Cells["kargari"].Value);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00150D10 File Offset: 0x0014EF10
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			GridEX gridEX = (GridEX)sender;
			bool flag = gridEX.Col == gridEX.RootTable.Columns["moshtari_Name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			flag = (gridEX.Col == gridEX.RootTable.Columns["kala_Name"].Position);
			if (flag)
			{
				e.Handled = true;
			}
			flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0 && Strings.Asc(e.KeyChar) != 8);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00150DD0 File Offset: 0x0014EFD0
		private decimal GetDecimalValue(decimal d)
		{
			decimal d2 = decimal.Truncate(d);
			bool flag = decimal.Compare(decimal.Subtract(d, d2), decimal.Zero) > 0;
			decimal result;
			if (flag)
			{
				result = Conversions.ToDecimal(decimal.Parse(d.ToString()).ToString("G29"));
			}
			else
			{
				result = decimal.Truncate(d);
			}
			return result;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00150E2C File Offset: 0x0014F02C
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf((GridEX)sender);
				flag = (e.Row.Cells["vazn_kol"].Value != DBNull.Value);
				if (flag)
				{
					e.Row.Cells["vazn_kol"].Value = this.GetDecimalValue(Conversions.ToDecimal(e.Row.Cells["vazn_kol"].Value));
				}
				flag = (e.Row.Cells["vazn_kol"].Value != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(e.Row.Cells["vazn_kol"].Value, 0, false));
				if (flag)
				{
					e.Row.Cells["fee"].Value = 0;
					this.gridex1.GetTotalRow().Cells["fee"].Text = Public_Function.FormatPrice(Conversions.ToString(this.GetDecimalValue(Conversions.ToDecimal(Operators.DivideObject(e.Row.Cells["jam_kol"].Value, e.Row.Cells["vazn_kol"].Value)))));
				}
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00150FB4 File Offset: 0x0014F1B4
		private void GridEX2_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "fee", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_fee_n;
				this.txt_fee_n.Text = e.Value.ToString();
				this.txt_fee_n.SelectAll();
			}
			else
			{
				flag = (Operators.CompareString(left, "jam_kol", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_jamkol_n;
					this.txt_jamkol_n.Text = e.Value.ToString();
					this.txt_jamkol_n.SelectAll();
				}
				else
				{
					flag = (Operators.CompareString(left, "kargari", false) == 0);
					if (flag)
					{
						e.EditControl = this.txt_kargari;
						flag = (e.Value != null);
						if (flag)
						{
							this.txt_kargari.Text = e.Value.ToString();
							this.txt_kargari.SelectAll();
						}
					}
				}
			}
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x001510C0 File Offset: 0x0014F2C0
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "fee", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_fee;
				this.txt_fee.Text = e.Value.ToString();
				this.txt_fee.SelectAll();
			}
			else
			{
				flag = (Operators.CompareString(left, "jam_kol", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_jam_kol;
					this.txt_jam_kol.Text = e.Value.ToString();
					this.txt_jam_kol.SelectAll();
				}
				else
				{
					flag = (Operators.CompareString(left, "kargari", false) == 0);
					if (flag)
					{
						e.EditControl = this.txt_kargari;
						flag = (e.Value != null);
						if (flag)
						{
							this.txt_kargari.Text = e.Value.ToString();
							this.txt_kargari.SelectAll();
						}
					}
				}
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x001511CC File Offset: 0x0014F3CC
		private void move_right(GridEX grid)
		{
			int col = grid.Col;
			checked
			{
				grid.Col--;
				bool flag = col == grid.Col;
				if (flag)
				{
					int num = 2;
					while (grid.Col >= col)
					{
						grid.Col -= num;
						num++;
					}
				}
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0015122C File Offset: 0x0014F42C
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.CanDelete = false;
			this.frm.Edit_Frm = this.frm_moshtari_nesie;
			string text = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				text = " where moshtari.id not in (-3";
			}
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			if (flag)
			{
				text = " where moshtari.id not in (-4,-5)";
			}
			else
			{
				text += " ,-4,-5)";
			}
			flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ", this.frm_moshtari_nesie, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.gridex1.Col == this.gridex1.RootTable.Columns["moshtari_Name"].Position && this.gridex1.EditTextBox != null;
					if (flag2)
					{
						this.gridex1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.gridex1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridex = this.gridex1;
						gridex.Col++;
						flag2 = Operators.ConditionalCompareObjectGreater(this.frm.SelectedRow["ID"], 0, false);
						if (flag2)
						{
							this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.frm.SelectedRow["ID"]);
							this.Refresh_Status();
						}
						else
						{
							this.Clean_Status();
						}
					}
				}
			}
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00151404 File Offset: 0x0014F604
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.gridex1.AllowEdit == InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.gridex1.EditTextBox == null);
					bool flag3;
					if (flag)
					{
						bool flag2 = this.gridex1.GetRow() != null;
						if (flag2)
						{
							flag3 = (this.gridex1.GetRow().RowType == RowType.Record);
							if (flag3)
							{
								this.gridex1.GetRow().BeginEdit();
							}
						}
					}
					flag3 = (e.KeyCode == Keys.Delete);
					if (flag3)
					{
						bool flag2 = this.gridex1.EditTextBox != null;
						if (flag2)
						{
							this.gridex1.EditTextBox.Text = string.Empty;
						}
						flag3 = (this.gridex1.Col == this.gridex1.RootTable.Columns["kala_name"].Position);
						if (flag3)
						{
							this.gridex1.CurrentRow.Cells["Kala_ID"].Value = DBNull.Value;
						}
						flag3 = (this.gridex1.Col == this.gridex1.RootTable.Columns["Moshtari_name"].Position);
						if (flag3)
						{
							this.gridex1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
						}
					}
					Keys keyData = e.KeyData;
					flag3 = (keyData == Keys.Tab);
					if (flag3)
					{
						this.gridex1.Focus();
						this.gridex1.Row = -1;
						this.gridex1.Col = 0;
						this.gridex1.EditMode = EditMode.EditOn;
					}
					else
					{
						flag3 = (keyData == Keys.Up);
						if (flag3)
						{
							bool flag2 = this.gridex1.Row > 0;
							if (flag2)
							{
								DataEntryGrid gridex = this.gridex1;
								gridex.Row--;
								e.SuppressKeyPress = true;
								return;
							}
						}
						else
						{
							flag3 = (keyData == Keys.Down);
							if (flag3)
							{
								bool flag2 = this.gridex1.Row < this.gridex1.RowCount - 1;
								if (flag2)
								{
									DataEntryGrid gridex = this.gridex1;
									gridex.Row++;
									e.SuppressKeyPress = true;
									return;
								}
							}
							else
							{
								flag3 = (keyData == Keys.Left);
								if (flag3)
								{
									bool flag2 = this.prevent_left;
									if (flag2)
									{
										this.prevent_left = false;
										this.gridex1.EditMode = EditMode.EditOn;
										return;
									}
									flag3 = (this.gridex1.Col == this.gridex1.RootTable.Columns["tarikh_fa"].Position);
									if (flag3)
									{
										e.SuppressKeyPress = true;
										return;
									}
									DataEntryGrid gridex = this.gridex1;
									gridex.Col++;
									e.SuppressKeyPress = true;
									return;
								}
								else
								{
									flag3 = (keyData == Keys.Right);
									if (flag3)
									{
										bool flag2 = this.prevent_right;
										if (flag2)
										{
											this.prevent_right = false;
											return;
										}
										flag3 = (this.gridex1.Col == this.gridex1.RootTable.Columns["tarikh_fa"].Position);
										if (flag3)
										{
											e.SuppressKeyPress = true;
											return;
										}
										flag3 = (this.gridex1.Col > 0);
										if (flag3)
										{
											this.move_right(this.gridex1);
											e.SuppressKeyPress = true;
											return;
										}
									}
								}
							}
						}
					}
					flag3 = (e.KeyCode == Keys.Return);
					if (flag3)
					{
						bool flag2 = this.gridex1.EditTextBox == null;
						if (flag2)
						{
							this.gridex1.EditMode = EditMode.EditOn;
						}
						int col = this.gridex1.Col;
						flag3 = (col == this.gridex1.RootTable.Columns["Moshtari_Name"].Position);
						if (flag3)
						{
							flag2 = (Operators.CompareString(this.gridex1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag2)
							{
								this.Moshtari_Select();
							}
							else
							{
								DataEntryGrid gridex = this.gridex1;
								gridex.Col++;
							}
						}
						else
						{
							flag3 = (col == this.gridex1.RootTable.Columns["vazn_kol"].Position);
							if (flag3)
							{
								flag2 = this.prevent_enter;
								if (flag2)
								{
									this.prevent_enter = false;
								}
								else
								{
									this.gridex1.Col = this.gridex1.RootTable.Columns["jam_kol"].Position;
								}
							}
							else
							{
								flag3 = (col == this.gridex1.RootTable.Columns["fee"].Position);
								if (flag3)
								{
									e.SuppressKeyPress = true;
								}
								else
								{
									flag3 = this.prevent_enter;
									if (flag3)
									{
										this.prevent_enter = false;
									}
									else
									{
										DataEntryGrid gridex = this.gridex1;
										gridex.Col++;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00151924 File Offset: 0x0014FB24
		private bool ValidateGridData()
		{
			this.gridex1.UpdateData();
			this.gridex1.UpdateData();
			DataTable dataTable = (DataTable)this.gridex1.DataSource;
			bool flag = dataTable == null;
			checked
			{
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					int i = 0;
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i].RowState == DataRowState.Deleted);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = (dataTable.Rows[i]["Moshtari_Name"] == DBNull.Value && dataTable.Rows[i]["Vazn_Kol"] == DBNull.Value && dataTable.Rows[i]["fee"] == DBNull.Value && dataTable.Rows[i]["jam_kol"] == DBNull.Value);
							if (flag)
							{
								dataTable.Rows[i].Delete();
								i--;
							}
							i++;
						}
					}
					dataTable.AcceptChanges();
					int num = 0;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag = (dataRow["sanad"] == DBNull.Value);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.gridex1, this.gridex1.GetRows()[num], "sanad", "شماره سند را انتخاب فرمایید");
								result = false;
								return result;
							}
							flag = (dataRow["Kala_ID"] == DBNull.Value);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.gridex1, this.gridex1.GetRows()[num], "kala_Name", "جنس را انتخاب نمایید");
								result = false;
								return result;
							}
							flag = (dataRow["vazn_kol"] == DBNull.Value && this.gridex1.RootTable.Columns["vazn_kol"].Visible);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.gridex1, this.gridex1.GetRows()[num], "vazn_kol", "وزن خالص را وارد نمایید");
								result = false;
								return result;
							}
							flag = !this.gridex1.RootTable.Columns["vazn_kol"].Visible;
							if (flag)
							{
								dataRow["vazn_kol"] = 0;
							}
							flag = (dataRow["fee"] == DBNull.Value && dataRow["jam_kol"] == DBNull.Value);
							if (flag)
							{
								dataRow["fee"] = 0;
								dataRow["jam_kol"] = 0;
							}
							flag = (dataRow["fee"] == DBNull.Value);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.gridex1, this.gridex1.GetRows()[num], "fee", "فی واحد را وارد نمایید");
								result = false;
								return result;
							}
							flag = (dataRow["jam_kol"] == DBNull.Value);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.gridex1, this.gridex1.GetRows()[num], "jam_kol", "قیمت کل را وارد نمایید");
								result = false;
								return result;
							}
							num++;
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag = (enumerator is IDisposable);
						if (flag)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					DataTable dataTable2 = (DataTable)this.gridex1.DataSource;
					try
					{
						IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag = (dataRow2["fee"] == DBNull.Value);
							if (flag)
							{
								dataRow2["fee"] = 0;
							}
							flag = (dataRow2["vazn_kol"] == DBNull.Value);
							if (flag)
							{
								dataRow2["vazn_kol"] = 0;
							}
							flag = (dataRow2["jam_kol"] == DBNull.Value);
							if (flag)
							{
								dataRow2["jam_kol"] = 0;
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						flag = (enumerator2 is IDisposable);
						if (flag)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00151DF4 File Offset: 0x0014FFF4
		private void RollBabk_Rizbar_furush(int kind, long ID)
		{
			DataTable dataTable = Public_Function.FillData("select * from Furush_Hag_RizBar where furush_hag_id=" + Conversions.ToString(ID));
			DataTable dataTable2 = Public_Function.FillData("select * from Kala_To_Kala_Furush where furush_id=" + Conversions.ToString(ID));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["auto"] != DBNull.Value;
					if (flag)
					{
						DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("child_kala_id=", dataRow["kala_id"])));
						flag = (array.Length > 0);
						if (flag)
						{
							DataRow[] array2 = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", array[0]["parent_kala_id"])));
							flag = (array2.Length > 0);
							if (flag)
							{
								bool flag2 = dataRow["tedad"] != DBNull.Value;
								if (flag2)
								{
									DataRow[] array3 = array2;
									DataRow[] arg_F6_0 = array3;
									int num = 0;
									DataRow arg_11D_0 = arg_F6_0[num];
									string columnName = "Tedad";
									arg_11D_0[columnName] = Operators.AddObject(array3[num][columnName], dataRow["Tedad"]);
								}
								flag2 = (dataRow["vazn"] != DBNull.Value);
								if (flag2)
								{
									DataRow[] array3 = array2;
									DataRow[] arg_14A_0 = array3;
									int num = 0;
									DataRow arg_171_0 = arg_14A_0[num];
									string columnName = "vazn";
									arg_171_0[columnName] = Operators.AddObject(array3[num][columnName], dataRow["vazn"]);
								}
								dataRow["tedad"] = 0;
								dataRow["vazn"] = 0;
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			string text = string.Empty;
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_hag_rizbar set tedad=" + Public_Function.GetValueInt(Conversions.ToString(dataRow2["Tedad"])) + ", vazn=" + Public_Function.GetValueInt(Conversions.ToString(dataRow2["vazn"])) + " where id=", dataRow2["ID"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag2 = enumerator2 is IDisposable;
				if (flag2)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x001520EC File Offset: 0x001502EC
		private void Commit_rizbar_furush(int kind, long id)
		{
			DataTable dataTable = Public_Function.FillData("select * from Furush_Hag_RizBar where furush_hag_id=" + Conversions.ToString(id));
			bool flag = dataTable.Rows.Count == 0;
			if (!flag)
			{
				DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
				{
					"select kala_id,sum(tedad) as Tedad,sum(vazn_ba_zarf) as vazn_ba_zarf,sum(vazn_kol) as vazn_kol from furush_hag_detail where kala_id in (select child_kala_id from kala_to_kala_furush where furush_id=",
					Conversions.ToString(id),
					") and furush_hug_id=",
					Conversions.ToString(id),
					"  group by kala_id"
				}));
				DataTable dataTable3 = Public_Function.FillData("select * from Kala_To_Kala_Furush where furush_id=" + Conversions.ToString(id));
				string text = string.Empty;
				int nahve_Furush = this.GetNahve_Furush();
				string columnName = "vazn_kol";
				flag = (nahve_Furush == 4);
				if (flag)
				{
					columnName = "vazn_ba_zarf";
				}
				try
				{
					IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow["kala_id"])));
						flag = (array.Length == 0);
						if (flag)
						{
							DataRow dataRow2 = dataTable.NewRow();
							dataRow2["kala_id"] = RuntimeHelpers.GetObjectValue(dataRow["kala_id"]);
							dataRow2["Tedad"] = RuntimeHelpers.GetObjectValue(dataRow["Tedad"]);
							dataRow2["vazn"] = RuntimeHelpers.GetObjectValue(dataRow["vazn_kol"]);
							dataTable.Rows.Add(dataRow2);
						}
						else
						{
							array[0]["Tedad"] = RuntimeHelpers.GetObjectValue(dataRow["Tedad"]);
							array[0]["Vazn"] = RuntimeHelpers.GetObjectValue(dataRow[columnName]);
						}
						array = dataTable3.Select(Conversions.ToString(Operators.ConcatenateObject("child_kala_id=", dataRow["kala_id"])));
						flag = (array.Length > 0);
						if (flag)
						{
							array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", array[0]["parent_kala_id"])));
							flag = (array.Length > 0);
							if (flag)
							{
								bool flag2 = array[0]["Tedad"] != DBNull.Value;
								bool flag3;
								if (flag2)
								{
									flag3 = (dataRow["tedad"] != DBNull.Value);
									if (flag3)
									{
										DataRow[] array2 = array;
										DataRow[] arg_25E_0 = array2;
										int num = 0;
										DataRow arg_285_0 = arg_25E_0[num];
										string columnName2 = "Tedad";
										arg_285_0[columnName2] = Operators.SubtractObject(array2[num][columnName2], dataRow["Tedad"]);
									}
								}
								flag3 = (array[0]["vazn"] != DBNull.Value);
								if (flag3)
								{
									flag2 = (dataRow[columnName] != DBNull.Value);
									if (flag2)
									{
										DataRow[] array2 = array;
										DataRow[] arg_2CD_0 = array2;
										int num = 0;
										DataRow arg_2F1_0 = arg_2CD_0[num];
										string columnName2 = "Vazn";
										arg_2F1_0[columnName2] = Operators.SubtractObject(array2[num][columnName2], dataRow[columnName]);
									}
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag3 = enumerator is IDisposable;
					if (flag3)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator2.Current;
						bool flag3 = dataRow3["ID"] == DBNull.Value;
						if (flag3)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Furush_Hag_RizBar(furush_hag_id,kala_id,Tedad,Vazn,auto) values(" + Conversions.ToString(id) + ",", dataRow3["kala_id"]), ","), Public_Function.GetValueInt(dataRow3["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow3["vazn"].ToString())), ",1)")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("update furush_hag_rizbar set tedad=" + Public_Function.GetValueInt(dataRow3["Tedad"].ToString()) + ",vazn=" + Public_Function.GetValueInt(dataRow3["vazn"].ToString()) + " where id=", dataRow3["id"])));
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					bool flag3 = enumerator2 is IDisposable;
					if (flag3)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x001525DC File Offset: 0x001507DC
		private void Update_Furush_hag(int kind, string Tarikh, long ID)
		{
			string text = string.Concat(new string[]
			{
				"SELECT       [Kala_ID],sum([Tedad]) as Tedad,sum([Vazn_Ba_Zarf]) as Vazn_Ba_zarf,0 as Zarf,sum([Vazn_Kol]) as Vazn_kol,0 as Fee,sum([Jam_Kol]) as Jam_Kol FROM Furush_kiosk_Detail  INNER JOIN Furush_kiosk ON  Furush_kiosk_Detail.furush_kiosk_id=Furush_kiosk.ID where furush_id=",
				Conversions.ToString(ID),
				" AND  moshtari_id = -1 AND Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				" group by kala_id"
			});
			DataTable dataTable = Public_Function.FillData(text);
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["fee"] = Operators.DivideObject(dataRow["jam_kol"], dataRow["vazn_kol"]);
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			string str = string.Empty;
			flag = (kind == 1);
			if (flag)
			{
				str = " furush_id=" + Conversions.ToString(ID);
			}
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select id from furush_kiosk where " + str));
			flag = (Operators.CompareString(text2, string.Empty, false) == 0);
			if (flag)
			{
				text2 = "-1";
			}
			DataTable dataTable2 = Public_Function.FillData("SELECT     Furush_kiosk_Detail.ID, Furush_kiosk_Detail.Furush_kiosk_ID, Furush_kiosk_Detail.Tarikh, Furush_kiosk_Detail.Moshtari_ID, Furush_kiosk_Detail.Kala_ID,  Furush_kiosk_Detail.Insert_Detail_ID, Furush_kiosk_Detail.Tedad, Furush_kiosk_Detail.Vazn_Ba_Zarf, Furush_kiosk_Detail.Zarf, Furush_kiosk_Detail.Vazn_Kol,  Furush_kiosk_Detail.Jam_Kol, Furush_kiosk_Detail.Fee, Moshtari.Name+' '+ Moshtari.Family as moshtari_name, Kala.Name AS Kala_Name   FROM         Furush_kiosk_Detail INNER JOIN  Moshtari ON Furush_kiosk_Detail.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Furush_kiosk_Detail.Kala_ID = Kala.ID where Furush_kiosk_ID=" + text2 + " AND Furush_kiosk_Detail.Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)));
			text = "declare @id bigint;";
			checked
			{
				bool flag3;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow2["kala_id"])));
						bool flag2 = false;
						DataRow[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							DataRow dataRow3 = array2[i];
							flag = (dataRow3["Insert_Detail_ID"] != DBNull.Value);
							if (flag)
							{
								flag2 = true;
								break;
							}
						}
						flag = flag2;
						if (flag)
						{
							flag3 = (array.Length > 0);
							if (flag3)
							{
								int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
								{
									Operators.ConcatenateObject("select count(id) from furush_hag_detail where id=", array[0]["insert_detail_id"])
								}, null, null, null));
								flag3 = (num == 0);
								if (flag3)
								{
									flag2 = false;
								}
							}
						}
						flag3 = !flag2;
						if (flag3)
						{
							flag = (kind == 1);
							if (flag)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [Furush_Hag_Detail] ([Furush_Hug_ID],[Moshtari_ID],[Kala_ID],[Tarikh],[Tarikh_Fa],[Tedad],[Vazn_Ba_Zarf],[Zarf]  ,[Vazn_Kol],[Fee],[Jam_Kol])  VALUES(" + Conversions.ToString(ID) + ",-1,", dataRow2["kala_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValueInt(dataRow2["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow2["vazn_ba_zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow2["zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow2["vazn_kol"].ToString())), ","), dataRow2["fee"]), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow2["jam_kol"]))), ");select @id=scope_identity();")));
								text = text + "update furush_kiosk_detail set insert_detail_id=@id where id in (" + Public_Function.GetID(array, "ID") + ");";
							}
						}
						else
						{
							flag3 = (kind == 1);
							if (flag3)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Furush_Hag_Detail SET [Furush_Hug_ID] =" + Conversions.ToString(ID) + "    ,[Moshtari_ID] = -1" + "    ,[Kala_ID] = ", dataRow2["Kala_ID"]), "    ,[Tarikh] = "), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), "    ,[Tarikh_Fa] ="), Public_Function.GetValue(Tarikh)), "    ,[Tedad] = "), Public_Function.GetValueInt(dataRow2["Tedad"].ToString())), "    ,[Vazn_Ba_Zarf] = "), Public_Function.GetValueInt(dataRow2["vazn_ba_zarf"].ToString())), "    ,[Zarf] = "), Public_Function.GetValueInt(dataRow2["Zarf"].ToString())), "    ,[Vazn_Kol] = "), Public_Function.GetValueInt(dataRow2["Vazn_Kol"].ToString())), "    ,[Fee] = "), dataRow2["fee"]), "    ,[Jam_Kol] = "), Public_Function.GetValueInt(Conversions.ToString(dataRow2["jam_kol"]))), "   where ID = "), array[0]["Insert_Detail_ID"]), ";")));
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_kiosk_detail set insert_detail_id=", array[0]["Insert_Detail_ID"]), " where id in ("), Public_Function.GetID(array, "ID")), ");")));
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag3 = (enumerator2 is IDisposable);
					if (flag3)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				flag3 = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag3)
				{
					Public_Function.ExecuteNonQuery(text);
					flag3 = (kind == 1);
					if (flag3)
					{
						Furush_Hag furush_Hag = new Furush_Hag();
						furush_Hag.UpdateSanadFurushNaghdByID(ID);
					}
				}
			}
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00152C38 File Offset: 0x00150E38
		private int GetNahve_Furush()
		{
			bool @checked = this.ButtonItem16.Checked;
			int result;
			if (@checked)
			{
				result = 1;
			}
			else
			{
				@checked = this.ButtonItem17.Checked;
				if (@checked)
				{
					result = 2;
				}
				else
				{
					@checked = this.ButtonItem18.Checked;
					if (@checked)
					{
						result = 3;
					}
					else
					{
						@checked = this.ButtonItem19.Checked;
						if (@checked)
						{
							result = 4;
						}
						else
						{
							result = 4;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00152C9C File Offset: 0x00150E9C
		private void sync_kala_to_kala(object kind, object id)
		{
			bool flag = !Conversions.ToBoolean(Public_Function.dict["kiosk_auto_kasr"]);
			if (!flag)
			{
				try
				{
					Dictionary<string, string>.Enumerator enumerator = this.kala_name.GetEnumerator();
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.Current;
						DataRow[] array = this.dt_kala_to_kala.Select("child_kala_id=" + current.Value);
						flag = (array.Length == 0);
						if (flag)
						{
							DataRow dataRow = this.dt_kala_to_kala.NewRow();
							flag = (this.dt_kala_to_kala.Rows.Count > 0);
							if (flag)
							{
								dataRow["parent_kala_id"] = RuntimeHelpers.GetObjectValue(this.dt_kala_to_kala.Rows[0]["parent_kala_id"]);
							}
							else
							{
								dataRow["parent_kala_id"] = this.IndexOfDictionary(this.kala_name, 0).Value;
							}
							dataRow["child_kala_id"] = current.Value;
							dataRow["furush_id"] = RuntimeHelpers.GetObjectValue(id);
							flag = Operators.ConditionalCompareObjectEqual(dataRow["parent_kala_id"], dataRow["child_kala_id"], false);
							if (!flag)
							{
								this.dt_kala_to_kala.Rows.Add(dataRow);
							}
						}
					}
				}
				finally
				{
					Dictionary<string, string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				string text = string.Empty;
				try
				{
					IEnumerator enumerator2 = this.dt_kala_to_kala.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag = (dataRow2["ID"] == DBNull.Value);
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(kind, 1, false);
							if (flag2)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into kala_to_kala_furush (furush_id,child_kala_id,parent_kala_id) values(", id), ","), dataRow2["child_kala_id"]), ","), dataRow2["parent_kala_id"]), ");")));
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					bool flag2 = enumerator2 is IDisposable;
					if (flag2)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00152F38 File Offset: 0x00151138
		private string Furush_insert(DataRow row)
		{
			string tozih = string.Empty;
			string text = string.Empty;
			string empty = string.Empty;
			string text2 = string.Empty;
			tozih = Conversions.ToString(Operators.ConcatenateObject(" فروش سند ", row["num"]));
			bool flag = Operators.ConditionalCompareObjectNotEqual(row["moshtari_id"], -1, false);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
				if (flag2)
				{
					text += this.Sanad.InsertStr("@codehesab_id", row["Jam_Kol"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_حق_العمل);
				}
				else
				{
					text += this.Sanad.InsertStr("@codehesab_id", row["Jamkol_ba_kargari"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_حق_العمل);
				}
				text += "Select @Sanad_id=Scope_Identity();";
			}
			else
			{
				text += " Select @Sanad_id=NULL ";
				text2 = "," + this.txt_num.Value;
			}
			return Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Hag_Detail(Furush_Hug_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id,kargari,jamkol_ba_kargari,Factor_Num ) VALUES(", row["kharid_furush_id"]), ","), this.txt_moshtari.Value), ","), row["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValueInt(row["Tedad"].ToString())), ","), Public_Function.GetValueInt(row["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(row["Zarf"].ToString())), ","), row["Vazn_Kol"]), ","), row["Fee"]), ","), row["Jam_Kol"]), ","), "@sanad_id"), ","), "NULL"), ","), Public_Function.GetValueInt(row["kargari"].ToString())), ","), Public_Function.GetValueInt(row["jamkol_ba_kargari"].ToString())), ","), this.txt_num.Value), ");")));
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00153254 File Offset: 0x00151454
		private string Furush_Update(DataRow row)
		{
			string tozih = string.Empty;
			string text = string.Empty;
			tozih = Conversions.ToString(Operators.ConcatenateObject(" فروش سند ", row["num"]));
			bool flag = Operators.ConditionalCompareObjectNotEqual(row["moshtari_id"], -1, false);
			if (flag)
			{
				bool flag2 = row["Sanad_ID"] != DBNull.Value;
				if (flag2)
				{
					bool flag3 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag3)
					{
						text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(row["Jam_Kol"]), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Conversions.ToString(row["Sanad_ID"]), Sanad.SanadType.فروش_حق_العمل);
					}
					else
					{
						text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(row["JamKol_ba_kargari"]), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Conversions.ToString(row["Sanad_ID"]), Sanad.SanadType.فروش_حق_العمل);
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" select @sanad_id=", row["Sanad_ID"])));
				}
				else
				{
					bool flag3 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag3)
					{
						text += this.Sanad.InsertStr("@codehesab_id", row["Jam_Kol"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_حق_العمل);
					}
					else
					{
						text += this.Sanad.InsertStr("@codehesab_id", row["JamKol_ba_kargari"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_حق_العمل);
					}
					text += " Select @Sanad_id=Scope_Identity();";
				}
			}
			else
			{
				text += " Select @Sanad_id=NULL ";
			}
			return Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Hag_Detail SET Moshtari_ID=", row["Moshtari_ID"]), " ,Kala_ID="), row["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))), " ,Tarikh_Fa="), Public_Function.GetValue(this.txt_tarikh.Text)), " ,Tedad="), Public_Function.GetValueInt(row["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(row["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(row["Zarf"].ToString())), " ,Vazn_Kol="), row["Vazn_Kol"]), " ,Fee="), row["Fee"]), " ,Jam_Kol="), row["Jam_Kol"]), " , Sanad_ID="), "@Sanad_id"), " , kargari="), Public_Function.GetValueInt(row["kargari"].ToString())), " , jamkol_ba_kargari="), Public_Function.GetValueInt(row["jamkol_ba_kargari"].ToString())), " Where ID="), row["ID"]), ";")));
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00153610 File Offset: 0x00151810
		private string Kharid_Update(DataRow row)
		{
			string tozih = Conversions.ToString(Operators.ConcatenateObject(" خرید سند ", row["num"]));
			string text = string.Empty;
			bool flag = Operators.ConditionalCompareObjectNotEqual(row["moshtari_id"], -1, false);
			if (flag)
			{
				bool flag2 = row["Sanad_ID"] != DBNull.Value;
				if (flag2)
				{
					bool flag3 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag3)
					{
						text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(row["Jam_Kol"]), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Conversions.ToString(row["Sanad_ID"]), Sanad.SanadType.فروش_خرید);
					}
					else
					{
						text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(row["JamKol_ba_kargari"]), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Conversions.ToString(row["Sanad_ID"]), Sanad.SanadType.فروش_خرید);
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", row["Sanad_ID"])));
				}
				else
				{
					bool flag3 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag3)
					{
						text += this.Sanad.InsertStr("@codehesab_id", row["Jam_Kol"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_خرید);
					}
					else
					{
						text += this.Sanad.InsertStr("@codehesab_id", row["JamKol_ba_kargari"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_خرید);
					}
					text += "Select @Sanad_id=Scope_Identity();";
				}
			}
			else
			{
				text += " Select @Sanad_id=null; ";
			}
			return Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Furush SET Moshtari_ID=", row["Moshtari_ID"]), " ,Kala_ID="), row["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))), " ,Tarikh_Fa="), Public_Function.GetValue(this.txt_tarikh.Text)), " ,Tedad="), Public_Function.GetValueInt(row["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(row["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(row["Zarf"].ToString())), " ,Vazn_Kol="), row["Vazn_Kol"]), " ,Fee="), row["Fee"]), " ,Jam_Kol="), row["Jam_Kol"]), " , Sanad_ID="), "@sanad_id"), " , kargari="), Public_Function.GetValueInt(row["kargari"].ToString())), " , jamkol_ba_kargari="), Public_Function.GetValueInt(row["jamkol_ba_kargari"].ToString())), " Where ID="), row["ID"]), ";")));
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x001539C4 File Offset: 0x00151BC4
		private string Kharid_Insert(DataRow row)
		{
			string tozih = Conversions.ToString(Operators.ConcatenateObject(" خرید سند ", row["num"]));
			string text = string.Empty;
			string empty = string.Empty;
			string text2 = string.Empty;
			bool flag = Operators.ConditionalCompareObjectNotEqual(row["moshtari_id"], -1, false);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
				if (flag2)
				{
					text += this.Sanad.InsertStr("@codehesab_id", row["Jam_Kol"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_خرید);
				}
				else
				{
					text += this.Sanad.InsertStr("@codehesab_id", row["JamKol_ba_kargari"].ToString(), "0", this.txt_tarikh.Text, tozih, Sanad.SanadType.فروش_خرید);
				}
				text += "Select @Sanad_id=Scope_Identity();";
			}
			else
			{
				text += " Select @Sanad_id=NULL ";
				text2 = "," + this.txt_num.Value;
			}
			return Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Furush(Kharid_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id,kargari,jamkol_ba_kargari,Factor_Num) VALUES(", row["kharid_furush_id"]), ","), this.txt_moshtari.Value), ","), row["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValueInt(row["Tedad"].ToString())), ","), Public_Function.GetValueInt(row["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(row["Zarf"].ToString())), ","), row["Vazn_Kol"]), ","), row["Fee"]), ","), row["Jam_Kol"]), ","), "@sanad_id"), ","), "NULL"), ","), Public_Function.GetValueInt(row["kargari"].ToString())), ","), Public_Function.GetValueInt(row["jamkol_ba_kargari"].ToString())), ","), this.txt_num.Value), ");")));
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00153CD8 File Offset: 0x00151ED8
		private void Update_Daryaft_Naghd()
		{
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			string daryaft_id = string.Empty;
			bool flag = this.row_daryafti != null;
			if (flag)
			{
				daryaft_id = this.row_daryafti["Naghd_Daryaft_ID"].ToString();
			}
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			bool arg_9C_0;
			if (this.txt_naghd.Value.HasValue)
			{
				long num = 0L;
				long? value = this.txt_naghd.Value;
				bool? arg_8C_0;
				if (!value.HasValue)
				{
					arg_8C_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(value.GetValueOrDefault() == num);
					arg_8C_0 = flag2;
				}
				bool? flag3 = arg_8C_0;
				if (!flag3.GetValueOrDefault())
				{
					arg_9C_0 = false;
					goto IL_9B;
				}
			}
			arg_9C_0 = true;
			IL_9B:
			flag = arg_9C_0;
			bool flag4;
			if (flag)
			{
				flag4 = (this.row_daryafti != null);
				if (flag4)
				{
					daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(this.row_daryafti["Naghd_Daryaft_ID"].ToString(), "sabt_factor_furush", "Naghd_Daryaft_ID", Conversions.ToString(this.row_daryafti["id"]));
				}
			}
			else
			{
				text += daryaftPardakht.AddRowStrNaghdMoshtari(this.txt_tarikh.Text, Conversions.ToString(this.txt_moshtari.Value), Conversions.ToString((T)this.txt_naghd.Value), "دریافت نقد", daryaft_id);
			}
			flag4 = (this.row_daryafti == null);
			if (flag4)
			{
				flag = (Operators.CompareString(this.txt_naghd.Text, string.Empty, false) != 0);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" insert into sabt_factor_furush(moshtari_id,tarikh,tarikh_fa,Naghd_Daryaft_ID) values(", this.txt_moshtari.Value), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ",@daryaft_id ) ")));
				}
			}
			else
			{
				flag4 = (Operators.CompareString(this.txt_naghd.Text, string.Empty, false) != 0);
				if (flag4)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" update sabt_factor_furush set Naghd_Daryaft_ID=@daryaft_id where id=", this.row_daryafti["id"])));
				}
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0000205D File Offset: 0x0000025D
		private void Update_Daryaft_Kart()
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00153F14 File Offset: 0x00152114
		private bool Save(bool reload_data)
		{
			bool flag = this.txt_moshtari.Value == null && this.gridex1.RowCount == 0;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				flag = !this.ValidateGridData();
				if (flag)
				{
					result = false;
				}
				else
				{
					flag = (this.gridex1.RowCount > 0 && this.txt_moshtari.Value == null);
					if (flag)
					{
						Public_Function.ShowMessage("لطفا مشتری را انتخاب فرمایید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
						result = false;
					}
					else
					{
						this.gridex1.UpdateData();
						try
						{
							IEnumerator enumerator = ((DataTable)this.gridex1.DataSource).Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								dataRow["moshtari_id"] = RuntimeHelpers.GetObjectValue(this.txt_moshtari.Value);
							}
						}
						finally
						{
							IEnumerator enumerator;
							flag = (enumerator is IDisposable);
							if (flag)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						this.Update_Daryaft_Naghd();
						string text = string.Empty;
						text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
						flag = Operators.ConditionalCompareObjectNotEqual(this.txt_moshtari.Value, -1, false);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" select @codehesab_id=Codehesab_id from Moshtari where id=", this.txt_moshtari.Value), ";")));
						}
						else
						{
							text += " select @codehesab_id=null; ";
						}
						DataTable dataTable = (DataTable)this.gridex1.DataSource;
						try
						{
							IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								flag = (dataRow2["JamKol_ba_kargari"] == DBNull.Value);
								if (flag)
								{
									dataRow2["JamKol_ba_kargari"] = RuntimeHelpers.GetObjectValue(dataRow2["jam_kol"]);
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						bool flag2;
						try
						{
							IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								DataRow dataRow3 = (DataRow)enumerator3.Current;
								flag = (dataRow3["id"] == DBNull.Value);
								if (flag)
								{
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow3["kind"], 1, false);
									if (flag2)
									{
										text += this.Furush_insert(dataRow3);
									}
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow3["kind"], 2, false);
									if (flag2)
									{
										text += this.Kharid_Insert(dataRow3);
									}
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow3["kind"], 1, false);
									if (flag2)
									{
										text += this.Furush_Update(dataRow3);
									}
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow3["kind"], 2, false);
									if (flag2)
									{
										text += this.Kharid_Update(dataRow3);
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator3;
							flag2 = (enumerator3 is IDisposable);
							if (flag2)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
						flag2 = (dataTable.Rows.Count > 0);
						if (flag2)
						{
							Public_Function.ExecuteNonQuery(text);
							Kharid kharid = new Kharid();
							kharid.UpdateSanadNaghd_FactorFurush(this.txt_tarikh.Text);
							Furush_Hag furush_Hag = new Furush_Hag();
							furush_Hag.UpdateSanadNaghd_FactorFurush(this.txt_tarikh.Text);
							Sandugh sandugh = new Sandugh();
							sandugh.SynckasrEzafe(this.txt_tarikh.Text);
							if (reload_data)
							{
								this.txt_moshtari_SelectedValueChanged(null, null);
							}
						}
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00154328 File Offset: 0x00152528
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Save(true);
			this.Load_furush();
			MyProject.Forms.Form_Main.Get_mande_furush();
			this.gridex1.DataSource = null;
			this.txt_moshtari.SetNew();
			this.txt_naghd.SetNew();
			this.Label6.Visible = false;
			this.txt_moshtari.PerformButtonClick();
			this.Load_Sanad();
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0015439C File Offset: 0x0015259C
		private void DeleteNesie(DataRow row)
		{
			object left = row["kind"];
			bool flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
			if (flag)
			{
				string text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_hag_detail set sanad_id=null,daryaft_id=null where id=", row["id"]), ";")));
				flag = (row["sanad_id"] != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", row["sanad_id"]), ";")));
				}
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from furush_hag_detail where id=", row["id"]), ";")));
				Public_Function.ExecuteNonQuery(text);
			}
			else
			{
				flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
				if (flag)
				{
					string text2 = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @sanad_id=sanad_id  from Kharid_Furush where id=", row["id"]), ";")));
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set sanad_id=null,daryaft_id=null where id=", row["id"]), ";")));
					flag = (row["sanad_id"] != DBNull.Value);
					if (flag)
					{
						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", row["sanad_id"]), ";")));
					}
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from Kharid_Furush where id=", row["id"]), ";")));
					Public_Function.ExecuteNonQuery(text2);
				}
			}
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00154564 File Offset: 0x00152764
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.gridex1.CurrentRow != null && this.gridex1.CurrentRow.RowType == RowType.Record;
			bool flag2;
			if (flag)
			{
				flag2 = (this.gridex1.CurrentRow.Cells["id"].Value != DBNull.Value);
				if (flag2)
				{
					this.DeleteNesie(((DataRowView)this.gridex1.CurrentRow.DataRow).Row);
					this.Load_furush();
				}
				this.gridex1.CurrentRow.Delete();
			}
			flag2 = (this.gridex1.CurrentRow != null);
			if (flag2)
			{
				flag = (this.gridex1.CurrentRow.RowType == RowType.NewRecord);
				if (flag)
				{
					this.gridex1.CancelCurrentEdit();
					this.gridex1.Col = 0;
					this.gridex1.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00154658 File Offset: 0x00152858
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = !this.gridex1focused;
			if (flag)
			{
				bool flag2 = this.txt_moshtari.Value != null;
				if (flag2)
				{
					Frm_SuratHesab_Moshtari arg_47_0 = frm_SuratHesab_Moshtari;
					object expr_35 = this.txt_moshtari.Value;
					int? num;
					arg_47_0.Moshtari_id = ((expr_35 != null) ? ((int?)expr_35) : num);
					frm_SuratHesab_Moshtari.Moshtari_Name = this.txt_moshtari.Text;
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00007F35 File Offset: 0x00006135
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x001546D8 File Offset: 0x001528D8
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.gridex1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["tedad"].Value == DBNull.Value && gridEXRow.Cells["vazn_kol"].Value == DBNull.Value && gridEXRow.Cells["jam_kol"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00154774 File Offset: 0x00152974
		private void gridex2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			bool flag2;
			if (flag)
			{
				flag2 = (this.gridex1.EditTextBox != null);
				if (flag2)
				{
					this.gridex1.EditTextBox.Text = string.Empty;
				}
				flag2 = (this.gridex1.Col == this.gridex1.RootTable.Columns["Moshtari_name"].Position);
				if (flag2)
				{
					this.gridex1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
				}
				flag2 = (this.gridex1.Col == this.gridex1.RootTable.Columns["sanad"].Position);
				if (flag2)
				{
					this.gridex1.CurrentRow.Cells["sanad"].Value = DBNull.Value;
				}
				flag2 = (this.gridex1.Col == this.gridex1.RootTable.Columns["kala_name"].Position);
				if (flag2)
				{
					this.gridex1.CurrentRow.Cells["kala_name"].Value = DBNull.Value;
					this.gridex1.CurrentRow.Cells["kala_id"].Value = DBNull.Value;
					this.Kala_Select();
				}
			}
			Keys keyCode = e.KeyCode;
			flag2 = (keyCode == Keys.Tab);
			checked
			{
				if (flag2)
				{
					this.gridex1.Focus();
					this.gridex1.Row = -1;
					this.gridex1.Col = 0;
					this.gridex1.EditMode = EditMode.EditOn;
				}
				else
				{
					flag2 = (keyCode == Keys.Left);
					if (flag2)
					{
						DataEntryGrid gridex = this.gridex1;
						gridex.Col++;
						this.gridex1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
					}
					else
					{
						flag2 = (keyCode == Keys.Right);
						if (flag2)
						{
							flag = (this.gridex1.Col > 0);
							if (flag)
							{
								this.move_right(this.gridex1);
								this.gridex1.EditMode = EditMode.EditOn;
								e.SuppressKeyPress = true;
							}
							else
							{
								this.gridex1.Focus();
								this.gridex1.MoveToNewRecord();
								this.gridex1.Col = 0;
								this.gridex1.EditMode = EditMode.EditOn;
							}
						}
						else
						{
							flag2 = (keyCode == Keys.Return);
							if (flag2)
							{
								flag = (this.gridex1.EditTextBox == null);
								if (flag)
								{
									this.gridex1.EditMode = EditMode.EditOn;
								}
								int col = this.gridex1.Col;
								flag2 = (col == this.gridex1.RootTable.Columns["moshtari_name"].Position);
								if (flag2)
								{
									flag = (Operators.CompareString(this.gridex1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag)
									{
										this.Moshtari_Select_nesie();
									}
									else
									{
										DataEntryGrid gridex = this.gridex1;
										gridex.Col++;
									}
								}
								else
								{
									flag2 = (col == this.gridex1.RootTable.Columns["sanad"].Position);
									if (flag2)
									{
										flag = (this.gridex1.CurrentRow.RowType == RowType.NewRecord);
										if (flag)
										{
											bool flag3 = Operators.CompareString(this.gridex1.EditTextBox.Text, string.Empty, false) == 0;
											if (flag3)
											{
												this.Select_Sanad();
											}
										}
										else
										{
											DataEntryGrid gridex = this.gridex1;
											gridex.Col++;
											this.gridex1.EditMode = EditMode.EditOn;
										}
									}
									else
									{
										bool flag3 = col == this.gridex1.RootTable.Columns["kala_name"].Position;
										if (flag3)
										{
											flag2 = (this.gridex1.CurrentRow.RowType == RowType.NewRecord);
											if (flag2)
											{
												flag = (Operators.CompareString(this.gridex1.EditTextBox.Text, string.Empty, false) == 0);
												if (flag)
												{
													this.Kala_Select();
												}
											}
											else
											{
												DataEntryGrid gridex = this.gridex1;
												gridex.Col++;
												this.gridex1.EditMode = EditMode.EditOn;
											}
										}
										else
										{
											flag3 = (col == this.gridex1.RootTable.Columns["vazn_kol"].Position);
											if (flag3)
											{
												flag2 = this.prevent_enter;
												if (flag2)
												{
													this.prevent_enter = false;
												}
												else
												{
													DataEntryGrid gridex = this.gridex1;
													gridex.Col++;
													this.gridex1.EditMode = EditMode.EditOn;
												}
											}
											else
											{
												flag3 = (col == this.gridex1.RootTable.Columns["fee"].Position);
												if (flag3)
												{
													this.gridex1.EditMode = EditMode.EditOn;
												}
												else
												{
													flag3 = this.prevent_enter;
													if (flag3)
													{
														this.prevent_enter = false;
													}
													else
													{
														DataEntryGrid gridex = this.gridex1;
														gridex.Col++;
														this.gridex1.EditMode = EditMode.EditOn;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00154CC0 File Offset: 0x00152EC0
		private void Moshtari_Select_nesie()
		{
			this.frm_moshtari_nesie.CanEdit = true;
			this.frm_moshtari_nesie.CanDelete = false;
			this.frm_moshtari_nesie.Edit_Frm = this.frm_moshtari_nesie;
			string text = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				text = " where moshtari.id not in (-1,-3";
			}
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			if (flag)
			{
				text = " where moshtari.id not in (-1,-4,-5)";
			}
			else
			{
				text += " ,-4,-5)";
			}
			flag = (this.frm_moshtari_nesie.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.gridex1.Col == this.gridex1.RootTable.Columns["moshtari_Name"].Position && this.gridex1.EditTextBox != null;
					if (flag2)
					{
						this.gridex1.EditTextBox.Text = Conversions.ToString(this.frm_moshtari_nesie.SelectedRow["Name"]);
						this.gridex1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm_moshtari_nesie.SelectedRow["ID"]);
						DataEntryGrid gridex = this.gridex1;
						gridex.Col++;
						flag2 = Operators.ConditionalCompareObjectGreater(this.frm_moshtari_nesie.SelectedRow["ID"], 0, false);
						if (flag2)
						{
							this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.frm_moshtari_nesie.SelectedRow["ID"]);
							this.Refresh_Status();
						}
						else
						{
							this.Clean_Status();
						}
					}
				}
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00154E9C File Offset: 0x0015309C
		private void Get_Daryafti()
		{
			string command = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT  Sabt_Factor_Furush.ID, Sabt_Factor_Furush.Naghd_Daryaft_ID, DaryaftPardakht.Mablagh AS Mablagh_Naghd, Sabt_Factor_Furush.Kart_Daryaft_ID, DaryaftPardakht_1.Mablagh AS Mablagh_Kart  FROM    Sabt_Factor_Furush LEFT OUTER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON Sabt_Factor_Furush.Kart_Daryaft_ID = DaryaftPardakht_1.ID LEFT OUTER JOIN  DaryaftPardakht ON Sabt_Factor_Furush.Naghd_Daryaft_ID = DaryaftPardakht.ID where Sabt_Factor_Furush.moshtari_id= ", this.txt_moshtari.Value), " and Sabt_Factor_Furush.tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			this.row_daryafti = Public_Function.FillDataRow(command);
			bool flag = this.row_daryafti != null;
			if (flag)
			{
				bool flag2 = this.row_daryafti["mablagh_naghd"] != DBNull.Value;
				if (flag2)
				{
					this.txt_naghd.Text = Conversions.ToString(this.row_daryafti["mablagh_naghd"]);
				}
				else
				{
					this.txt_naghd.Text = string.Empty;
				}
			}
			else
			{
				this.txt_naghd.Text = string.Empty;
			}
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00154F70 File Offset: 0x00153170
		private object Get_Factor_Num()
		{
			string command = string.Concat(new string[]
			{
				"declare @a as int,@b as int  select @a=isnull(max(Factor_Num),0)+1 from Furush_Hag_Detail  where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" select @b=isnull(max(Factor_Num),0)+1 from Kharid_Furush  where Tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" if @a>@b select @a  else select @b"
			});
			return Public_Function.ExecuteScalar(command);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00154FE4 File Offset: 0x001531E4
		private void LoadData(string Naghd_Factor_Num)
		{
			this.txt_num.Value = Naghd_Factor_Num;
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				bool flag2 = Operators.CompareString(Naghd_Factor_Num, string.Empty, false) == 0;
				if (flag2)
				{
					Naghd_Factor_Num = Conversions.ToString(this.Get_Factor_Num());
					this.txt_num.Value = Naghd_Factor_Num;
				}
				flag2 = Operators.ConditionalCompareObjectNotEqual(this.txt_moshtari.Value, -1, false);
				if (flag2)
				{
					this.Get_Daryafti();
				}
				DataTable detail = this.GetDetail(Conversions.ToString(this.txt_moshtari.Value), this.txt_tarikh.Text, Naghd_Factor_Num);
				this.gridex1.DataSource = detail;
				this.gridex1.Focus();
				this.gridex1.MoveToNewRecord();
				this.gridex1.Col = 0;
				this.gridex1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00007F46 File Offset: 0x00006146
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData(string.Empty);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x001550CC File Offset: 0x001532CC
		private void gridex1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "sanad", false) == 0;
			if (flag)
			{
				this.Select_Sanad();
			}
			flag = (Operators.CompareString(e.Column.Key.ToLower(), "kala_name", false) == 0);
			if (flag)
			{
				this.Kala_Select();
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00155130 File Offset: 0x00153330
		private void grid_moshtari_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = !this.Save(false);
			if (!flag)
			{
				this.txt_moshtari.SetValue(Conversions.ToString(this.grid_moshtari.CurrentRow.Cells["moshtari_name"].Value), RuntimeHelpers.GetObjectValue(this.grid_moshtari.CurrentRow.Cells["moshtari_id"].Value));
				this.LoadData(this.grid_moshtari.CurrentRow.Cells["Factor_Num"].Value.ToString());
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x001551D4 File Offset: 0x001533D4
		private void grid_moshtari_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.txt_moshtari.SetValue(Conversions.ToString(this.grid_moshtari.CurrentRow.Cells["moshtari_name"].Value), RuntimeHelpers.GetObjectValue(this.grid_moshtari.CurrentRow.Cells["moshtari_id"].Value));
			this.LoadData(this.grid_moshtari.CurrentRow.Cells["Factor_Num"].Value.ToString());
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00155264 File Offset: 0x00153464
		private void txt_tarikh_Validated(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_tarikh.Text, this.tarikh, false) != 0;
			if (flag)
			{
				this.tarikh = this.txt_tarikh.Text;
				flag = (this.txt_moshtari.Value != null);
				if (flag)
				{
					DataTable detail = this.GetDetail(Conversions.ToString(this.txt_moshtari.Value), this.txt_tarikh.Text, string.Empty);
					this.Get_Daryafti();
					this.gridex1.DataSource = detail;
				}
				this.Load_furush();
				this.txt_num.Value = Conversions.ToString(this.Get_Factor_Num());
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00155318 File Offset: 0x00153518
		private void txt_num_Next_Click()
		{
			string command = string.Concat(new string[]
			{
				"declare @a as int,@b as int  select @a=isnull(min(Factor_Num),0) from Furush_Hag_Detail  where factor_num> ",
				this.txt_num.Value,
				" AND Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" select @b=isnull(min(Factor_Num),0) from Kharid_Furush  where factor_num> ",
				this.txt_num.Value,
				" AND Tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"if @a>@b begin select @b   End  else begin  if @a <> 0  select @a  else  select @b  end"
			});
			string text = Conversions.ToString(Public_Function.ExecuteScalar(command));
			bool flag = Conversions.ToDouble(text) == 0.0;
			if (!flag)
			{
				DataRow dataRow = Public_Function.FillDataRow(string.Concat(new string[]
				{
					" select top 1  moshtari_id,Name +' '+ Family as name from Furush_Hag_Detail  inner join Moshtari on Moshtari_ID=Moshtari.ID   where Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					" and Factor_Num= ",
					text,
					" union all  select top 1  moshtari_id,Name+' '+ Family as name from Kharid_Furush  inner join Moshtari on Moshtari_ID=Moshtari.ID  where Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					" and Factor_Num=",
					text
				}));
				this.txt_moshtari.SetValue(Conversions.ToString(dataRow["name"]), RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]));
				this.LoadData(text);
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00155484 File Offset: 0x00153684
		private void txt_num_Previous_Click()
		{
			string command = string.Concat(new string[]
			{
				"declare @a as int,@b as int  select @a=isnull(max(Factor_Num),0) from Furush_Hag_Detail  where factor_num< ",
				this.txt_num.Value,
				" AND Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" select @b=isnull(max(Factor_Num),0) from Kharid_Furush  where factor_num< ",
				this.txt_num.Value,
				" AND Tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" if @a>@b select @a  else select @b"
			});
			string text = Conversions.ToString(Public_Function.ExecuteScalar(command));
			bool flag = Conversions.ToDouble(text) == 0.0;
			if (!flag)
			{
				DataRow dataRow = Public_Function.FillDataRow(string.Concat(new string[]
				{
					" select top 1  moshtari_id,Name +' '+ Family as name from Furush_Hag_Detail  inner join Moshtari on Moshtari_ID=Moshtari.ID   where Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					" and Factor_Num= ",
					text,
					" union all  select top 1  moshtari_id,Name+' '+ Family as name from Kharid_Furush  inner join Moshtari on Moshtari_ID=Moshtari.ID  where Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					" and Factor_Num=",
					text
				}));
				this.txt_moshtari.SetValue(Conversions.ToString(dataRow["name"]), RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]));
				this.LoadData(text);
			}
		}

		// Token: 0x04000AFA RID: 2810
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000AFC RID: 2812
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000AFD RID: 2813
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000AFE RID: 2814
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000AFF RID: 2815
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000B00 RID: 2816
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000B01 RID: 2817
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000B02 RID: 2818
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000B03 RID: 2819
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000B04 RID: 2820
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x04000B05 RID: 2821
		[AccessedThroughProperty("NumericBox1")]
		private NumericBox _NumericBox1;

		// Token: 0x04000B06 RID: 2822
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000B07 RID: 2823
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000B08 RID: 2824
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000B09 RID: 2825
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000B0A RID: 2826
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000B0B RID: 2827
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000B0C RID: 2828
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000B0D RID: 2829
		[AccessedThroughProperty("txt_kargari")]
		private CurrencyBox _txt_kargari;

		// Token: 0x04000B0E RID: 2830
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000B0F RID: 2831
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000B10 RID: 2832
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000B11 RID: 2833
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000B12 RID: 2834
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000B13 RID: 2835
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000B14 RID: 2836
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000B15 RID: 2837
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000B16 RID: 2838
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000B17 RID: 2839
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000B18 RID: 2840
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000B19 RID: 2841
		[AccessedThroughProperty("gridex1")]
		private DataEntryGrid _gridex1;

		// Token: 0x04000B1A RID: 2842
		[AccessedThroughProperty("txt_fee_n")]
		private CurrencyBox _txt_fee_n;

		// Token: 0x04000B1B RID: 2843
		[AccessedThroughProperty("txt_jamkol_n")]
		private CurrencyBox _txt_jamkol_n;

		// Token: 0x04000B1C RID: 2844
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04000B1D RID: 2845
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000B1E RID: 2846
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000B1F RID: 2847
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04000B20 RID: 2848
		[AccessedThroughProperty("grid_moshtari")]
		private DataEntryGrid _grid_moshtari;

		// Token: 0x04000B21 RID: 2849
		[AccessedThroughProperty("txt_naghd")]
		private CurrencyBox _txt_naghd;

		// Token: 0x04000B22 RID: 2850
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000B23 RID: 2851
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000B24 RID: 2852
		[AccessedThroughProperty("object_f9b79304_ca6f_46b8_84fb_aeebc487606e")]
		private NumericBox _object_f9b79304_ca6f_46b8_84fb_aeebc487606e;

		// Token: 0x04000B25 RID: 2853
		[AccessedThroughProperty("object_8574e8dd_4059_400c_bbfc_de488f785574")]
		private NumericBox _object_8574e8dd_4059_400c_bbfc_de488f785574;

		// Token: 0x04000B26 RID: 2854
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000B27 RID: 2855
		private Frm_SelectItem frm;

		// Token: 0x04000B28 RID: 2856
		private Frm_SelectItem frm_kala_select;

		// Token: 0x04000B29 RID: 2857
		private Frm_SelectItem frm_moshtari_nesie;

		// Token: 0x04000B2A RID: 2858
		private DataTable dt_rizbar;

		// Token: 0x04000B2B RID: 2859
		private bool prevent_enter;

		// Token: 0x04000B2C RID: 2860
		private bool prevent_close;

		// Token: 0x04000B2D RID: 2861
		private bool prevent_right;

		// Token: 0x04000B2E RID: 2862
		private bool prevent_left;

		// Token: 0x04000B2F RID: 2863
		private bool gridex1focused;

		// Token: 0x04000B30 RID: 2864
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000B31 RID: 2865
		private int kind;

		// Token: 0x04000B32 RID: 2866
		private long id;

		// Token: 0x04000B33 RID: 2867
		private long num;

		// Token: 0x04000B34 RID: 2868
		private Dictionary<string, string> kala_name;

		// Token: 0x04000B35 RID: 2869
		private DataRow row_daryafti;

		// Token: 0x04000B36 RID: 2870
		private DataTable dt_kala_to_kala;

		// Token: 0x04000B37 RID: 2871
		private Sanad Sanad;

		// Token: 0x04000B38 RID: 2872
		private string tarikh;

		// Token: 0x04000B39 RID: 2873
		[CompilerGenerated]
		private DataTable _dt_sanad;

		// Token: 0x04000B3A RID: 2874
		private DataTable dt_kala;
	}
}
