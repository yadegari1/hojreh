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
using DevComponents.DotNetBar.Validator;
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
	// Token: 0x020000FE RID: 254
	[DesignerGenerated]
	public partial class Frm_Kiosk_Furush : Form
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x00182584 File Offset: 0x00180784
		public Frm_Kiosk_Furush()
		{
			base.Resize += new EventHandler(this.Frm_Kiosk_Furush_Resize);
			base.KeyDown += new KeyEventHandler(this.Frm_Kiosk_Furush_KeyDown);
			base.Load += new EventHandler(this.Frm_Kiosk_Furush_Load);
			Frm_Kiosk_Furush.__ENCAddToList(this);
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
			this.InitializeComponent();
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00182648 File Offset: 0x00180848
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Kiosk_Furush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Kiosk_Furush.__ENCList.Count == Frm_Kiosk_Furush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Kiosk_Furush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Kiosk_Furush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Kiosk_Furush.__ENCList[num] = Frm_Kiosk_Furush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Kiosk_Furush.__ENCList.RemoveRange(num, Frm_Kiosk_Furush.__ENCList.Count - num);
						Frm_Kiosk_Furush.__ENCList.Capacity = Frm_Kiosk_Furush.__ENCList.Count;
					}
					Frm_Kiosk_Furush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00184284 File Offset: 0x00182484
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00008817 File Offset: 0x00006A17
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

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0018429C File Offset: 0x0018249C
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00008821 File Offset: 0x00006A21
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

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x001842B4 File Offset: 0x001824B4
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x0000882B File Offset: 0x00006A2B
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x001842CC File Offset: 0x001824CC
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x001842E4 File Offset: 0x001824E4
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

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00184344 File Offset: 0x00182544
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x0018435C File Offset: 0x0018255C
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

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x001843BC File Offset: 0x001825BC
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00008835 File Offset: 0x00006A35
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

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x001843D4 File Offset: 0x001825D4
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x0000883F File Offset: 0x00006A3F
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

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x001843EC File Offset: 0x001825EC
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00008849 File Offset: 0x00006A49
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

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x00184404 File Offset: 0x00182604
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00008853 File Offset: 0x00006A53
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

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0018441C File Offset: 0x0018261C
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x0000885D File Offset: 0x00006A5D
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

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00184434 File Offset: 0x00182634
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0018444C File Offset: 0x0018264C
		internal virtual DataEntryGrid GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EventHandler value3 = new EventHandler(this.GridEX1_RecordAdded);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value6 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				RowLoadEventHandler value7 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				EventHandler value8 = new EventHandler(this.GridEX1_SelectionChanged);
				EventHandler value9 = new EventHandler(this.GridEX1_GotFocus);
				EndCustomEditEventHandler value10 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyPress -= value2;
					this._GridEX1.RecordAdded -= value3;
					this._GridEX1.KeyDown -= value4;
					this._GridEX1.CellEdited -= value5;
					this._GridEX1.InitCustomEdit -= value6;
					this._GridEX1.LoadingRow -= value7;
					this._GridEX1.SelectionChanged -= value8;
					this._GridEX1.GotFocus -= value9;
					this._GridEX1.EndCustomEdit -= value10;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyPress += value2;
					this._GridEX1.RecordAdded += value3;
					this._GridEX1.KeyDown += value4;
					this._GridEX1.CellEdited += value5;
					this._GridEX1.InitCustomEdit += value6;
					this._GridEX1.LoadingRow += value7;
					this._GridEX1.SelectionChanged += value8;
					this._GridEX1.GotFocus += value9;
					this._GridEX1.EndCustomEdit += value10;
				}
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x00184600 File Offset: 0x00182800
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00184618 File Offset: 0x00182818
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
				EventHandler value2 = new EventHandler(this.ButtonItem15_Click);
				bool flag = this._ButtonItem15 != null;
				if (flag)
				{
					this._ButtonItem15.Click -= value2;
				}
				this._ButtonItem15 = value;
				flag = (this._ButtonItem15 != null);
				if (flag)
				{
					this._ButtonItem15.Click += value2;
				}
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x00184678 File Offset: 0x00182878
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00184690 File Offset: 0x00182890
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x001846F0 File Offset: 0x001828F0
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00184708 File Offset: 0x00182908
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

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x00184768 File Offset: 0x00182968
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00184780 File Offset: 0x00182980
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

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x001847E0 File Offset: 0x001829E0
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x001847F8 File Offset: 0x001829F8
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x00184858 File Offset: 0x00182A58
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00184870 File Offset: 0x00182A70
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_fee_KeyDown);
				bool flag = this._txt_fee != null;
				if (flag)
				{
					this._txt_fee.KeyDown -= value2;
				}
				this._txt_fee = value;
				flag = (this._txt_fee != null);
				if (flag)
				{
					this._txt_fee.KeyDown += value2;
				}
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x001848D0 File Offset: 0x00182AD0
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x001848E8 File Offset: 0x00182AE8
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x00184948 File Offset: 0x00182B48
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00184960 File Offset: 0x00182B60
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

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x001849C0 File Offset: 0x00182BC0
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00008867 File Offset: 0x00006A67
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x001849D8 File Offset: 0x00182BD8
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00008871 File Offset: 0x00006A71
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

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x001849F0 File Offset: 0x00182BF0
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0000887B File Offset: 0x00006A7B
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

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00184A08 File Offset: 0x00182C08
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00008885 File Offset: 0x00006A85
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

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00184A20 File Offset: 0x00182C20
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0000888F File Offset: 0x00006A8F
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

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00184A38 File Offset: 0x00182C38
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00008899 File Offset: 0x00006A99
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

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00184A50 File Offset: 0x00182C50
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x000088A3 File Offset: 0x00006AA3
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

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00184A68 File Offset: 0x00182C68
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x000088AD File Offset: 0x00006AAD
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

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00184A80 File Offset: 0x00182C80
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x000088B7 File Offset: 0x00006AB7
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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00184A98 File Offset: 0x00182C98
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00184AB0 File Offset: 0x00182CB0
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x00184B10 File Offset: 0x00182D10
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x00184B28 File Offset: 0x00182D28
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00184B88 File Offset: 0x00182D88
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00184BA0 File Offset: 0x00182DA0
		internal virtual DataEntryGrid gridex2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gridex2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				KeyEventHandler value4 = new KeyEventHandler(this.gridex2_KeyDown);
				InitCustomEditEventHandler value5 = new InitCustomEditEventHandler(this.GridEX2_InitCustomEdit);
				EventHandler value6 = new EventHandler(this.gridex2_GotFocus);
				RowLoadEventHandler value7 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				EndCustomEditEventHandler value8 = new EndCustomEditEventHandler(this.GridEX2_EndCustomEdit);
				EventHandler value9 = new EventHandler(this.GridEX2_SelectionChanged);
				bool flag = this._gridex2 != null;
				if (flag)
				{
					this._gridex2.KeyPress -= value2;
					this._gridex2.CellEdited -= value3;
					this._gridex2.KeyDown -= value4;
					this._gridex2.InitCustomEdit -= value5;
					this._gridex2.GotFocus -= value6;
					this._gridex2.LoadingRow -= value7;
					this._gridex2.EndCustomEdit -= value8;
					this._gridex2.SelectionChanged -= value9;
				}
				this._gridex2 = value;
				flag = (this._gridex2 != null);
				if (flag)
				{
					this._gridex2.KeyPress += value2;
					this._gridex2.CellEdited += value3;
					this._gridex2.KeyDown += value4;
					this._gridex2.InitCustomEdit += value5;
					this._gridex2.GotFocus += value6;
					this._gridex2.LoadingRow += value7;
					this._gridex2.EndCustomEdit += value8;
					this._gridex2.SelectionChanged += value9;
				}
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x00184D28 File Offset: 0x00182F28
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x000088C1 File Offset: 0x00006AC1
		internal virtual Highlighter Highlighter1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Highlighter1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Highlighter1 = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00184D40 File Offset: 0x00182F40
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00184D58 File Offset: 0x00182F58
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x00184DB8 File Offset: 0x00182FB8
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00184DD0 File Offset: 0x00182FD0
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x00184E30 File Offset: 0x00183030
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x000088CB File Offset: 0x00006ACB
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
				this._txt_tarikh = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x00184E48 File Offset: 0x00183048
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x000088D5 File Offset: 0x00006AD5
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

		// Token: 0x060020BD RID: 8381 RVA: 0x00184E60 File Offset: 0x00183060
		private DataTable GetDetail(int kind, string ID)
		{
			string empty = string.Empty;
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select id from furush_kiosk where tarikh= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = "-1";
			}
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_kiosk_Detail.ID, Furush_kiosk_Detail.Furush_kiosk_ID,  Furush_kiosk_Detail.Moshtari_ID, Furush_kiosk_Detail.Kala_ID,  Furush_kiosk_Detail.Insert_Detail_ID, Furush_kiosk_Detail.Tedad, Furush_kiosk_Detail.Vazn_Ba_Zarf, Furush_kiosk_Detail.Zarf, Furush_kiosk_Detail.Vazn_Kol,  Furush_kiosk_Detail.Jam_Kol, Furush_kiosk_Detail.Fee, Moshtari.Name+' '+ Moshtari.Family as moshtari_name, Kala.Name AS Kala_Name   FROM         Furush_kiosk_Detail INNER JOIN  Moshtari ON Furush_kiosk_Detail.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Furush_kiosk_Detail.Kala_ID = Kala.ID where Furush_kiosk_ID=" + text);
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

		// Token: 0x060020BE RID: 8382 RVA: 0x0014C988 File Offset: 0x0014AB88
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

		// Token: 0x060020BF RID: 8383 RVA: 0x0014D1A0 File Offset: 0x0014B3A0
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

		// Token: 0x060020C0 RID: 8384 RVA: 0x00185078 File Offset: 0x00183278
		public void Delete_AllLabels()
		{
			checked
			{
				for (int i = 0; i < this.UiGroupBox1.Controls.Count; i++)
				{
					Control control = this.UiGroupBox1.Controls[i];
					bool flag = control is Label;
					if (flag)
					{
						bool flag2 = control.Tag != null;
						if (flag2)
						{
							this.UiGroupBox1.Controls.RemoveAt(i);
							control.Dispose();
							continue;
						}
					}
				}
			}
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x001850F4 File Offset: 0x001832F4
		private void Get_Kasr_Automatic(object kind, object ID)
		{
			bool flag = Operators.ConditionalCompareObjectEqual(kind, 1, false);
			if (flag)
			{
				this.dt_kala_to_kala = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("SELECT     Kala_To_Kala_Furush.ID, Kala_To_Kala_Furush.Furush_ID, Kala_To_Kala_Furush.Parent_Kala_ID, Kala_To_Kala_Furush.Child_Kala_ID,Kala.Name as Kala_Name  FROM         Kala_To_Kala_Furush INNER JOIN  Kala ON Kala_To_Kala_Furush.Child_Kala_ID = Kala.ID where furush_id=", ID)));
			}
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00185134 File Offset: 0x00183334
		private void Select_Sanad()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Hag.ID, 'فروش / ' + CAST(MAX(Furush_Hag.Num) AS nvarchar(10)) AS num,MAX(Furush_Hag.Num) as nume, MAX(Furush_Hag.Tarikh_Vurud) AS Tarikh_Vurud, MAX(Moshtari.Name)  + ' ' + MAX(Moshtari.Family) AS Name,max(moshtari.id) as moshtari_id, 1 AS kind  FROM         Furush_Hag LEFT OUTER JOIN  Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  WHERE     (Furush_Hag.ID NOT IN  (SELECT     Furush_Hag_ID   FROM         Safi_Furush))  GROUP BY Furush_Hag.ID  ORDER BY Furush_Hag.ID");
			DataTable dataTable2 = Public_Function.FillData("SELECT     Furush_Hag_RizBar.Furush_Hag_ID, Furush_Hag_RizBar.Kala_ID, Kala.Name  FROM       Furush_Hag_RizBar INNER JOIN  Kala ON Furush_Hag_RizBar.Kala_ID = Kala.ID    where furush_hag_id not in (SELECT     Furush_Hag_ID   FROM         Safi_Furush)   order by furush_hag_id");
			dataTable.Columns.Add("kala_name", typeof(string));
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("furush_hag_id=", dataRow["ID"])));
					flag = (array.Length > 0);
					if (flag)
					{
						string iD = Public_Function.GetID(array, "name");
						dataRow["kala_name"] = iD;
					}
					else
					{
						dataRow["kala_name"] = string.Empty;
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
			Furush_Hag furush_Hag = new Furush_Hag();
			long newID = furush_Hag.GetNewID();
			DataRow dataRow2 = dataTable.NewRow();
			dataRow2["num"] = "فروش جدید/" + Conversions.ToString(newID);
			dataRow2["id"] = 0;
			dataRow2["nume"] = newID;
			dataRow2["kind"] = 1;
			dataTable.Rows.InsertAt(dataRow2, 0);
			flag = (this.frm.ShowDialog(dataTable, null, "انتخاب شماره سند") == DialogResult.OK);
			checked
			{
				if (flag)
				{
					this.id = Conversions.ToLong(this.frm.SelectedRow["id"]);
					this.num = Conversions.ToLong(this.frm.SelectedRow["nume"]);
					this.kind = Conversions.ToInteger(this.frm.SelectedRow["kind"]);
					flag = (this.gridex2.Col == this.gridex2.RootTable.Columns["sanad"].Position && this.gridex2.EditTextBox != null);
					if (flag)
					{
						this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["num"]);
						this.gridex2.GetRow().Cells["sanad"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["num"]);
						DataEntryGrid gridex = this.gridex2;
						gridex.Col++;
						object left = this.frm.SelectedRow["kind"];
						flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
						if (flag)
						{
							this.gridex2.GetRow().Cells["furush_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
						}
					}
					this.Calc_avg();
				}
			}
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0014DD50 File Offset: 0x0014BF50
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

		// Token: 0x060020C4 RID: 8388 RVA: 0x0014DDC8 File Offset: 0x0014BFC8
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

		// Token: 0x060020C5 RID: 8389 RVA: 0x0014DE34 File Offset: 0x0014C034
		private long GetKala_ID(string kala_name)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select kala.id from kala where name=" + Public_Function.GetValue(kala_name)));
			return (long)num;
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00185468 File Offset: 0x00183668
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
				this.Save();
				break;
			case Keys.F3:
				this.ButtonItem11_Click(null, null);
				break;
			case Keys.F5:
				this.ButtonItem3_Click(null, null);
				break;
			}
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x001854D4 File Offset: 0x001836D4
		private void Frm_Kiosk_Furush_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("num", "شماره سند", 15));
			itemCollection.Add(new Column("Name", "صاحب بار", 65));
			itemCollection.Add(new Column("kala_name", "جنس", 20));
			this.frm.items = itemCollection;
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection2.Add(new Column("Code", "کد", 15));
			itemCollection2.Add(new Column("Name", "عنوان", 65));
			itemCollection2.Add(new Column("shahr", "منطقه", 25));
			this.frm_kala_select.items = itemCollection2;
			this.frm_moshtari_nesie.items = itemCollection2;
			this.Load_Default_Nahve_Furush();
			DataTable detail = this.GetDetail(1, "-1");
			this.gridex2.DataSource = detail;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["show_avg"]);
			if (flag)
			{
				this.gridex2.RootTable.Columns["avg"].Visible = false;
			}
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00185610 File Offset: 0x00183810
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

		// Token: 0x060020C9 RID: 8393 RVA: 0x001856BC File Offset: 0x001838BC
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

		// Token: 0x060020CA RID: 8394 RVA: 0x0018577C File Offset: 0x0018397C
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

		// Token: 0x060020CB RID: 8395 RVA: 0x0018584C File Offset: 0x00183A4C
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

		// Token: 0x060020CC RID: 8396 RVA: 0x0018592C File Offset: 0x00183B2C
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

		// Token: 0x060020CD RID: 8397 RVA: 0x000088DF File Offset: 0x00006ADF
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00185AD8 File Offset: 0x00183CD8
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.gridex2.RootTable.Columns["zarf"].Visible = false;
			this.gridex2.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.gridex2.RootTable.Columns["tedad"].Visible = true;
			this.gridex2.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem16.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00185C1C File Offset: 0x00183E1C
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = false;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.gridex2.RootTable.Columns["tedad"].Visible = false;
			this.gridex2.RootTable.Columns["zarf"].Visible = false;
			this.gridex2.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.gridex2.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem17.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00185D60 File Offset: 0x00183F60
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = false;
			this.gridex2.RootTable.Columns["tedad"].Visible = true;
			this.gridex2.RootTable.Columns["zarf"].Visible = false;
			this.gridex2.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.gridex2.RootTable.Columns["vazn_kol"].Visible = false;
			this.uncheckmenu();
			this.ButtonItem18.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00185EA4 File Offset: 0x001840A4
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.gridex2.RootTable.Columns["tedad"].Visible = true;
			this.gridex2.RootTable.Columns["zarf"].Visible = true;
			this.gridex2.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.gridex2.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem19.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00185FE8 File Offset: 0x001841E8
		private void txt_feen_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					this.prevent_enter = true;
					e.SuppressKeyPress = true;
					DataEntryGrid gridex = this.gridex2;
					gridex.Col++;
				}
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0018602C File Offset: 0x0018422C
		private void txt_fee_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					this.prevent_enter = true;
					e.SuppressKeyPress = true;
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00186070 File Offset: 0x00184270
		private void txt_kargari_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					bool flag2 = this.prevent_enter;
					if (flag2)
					{
						this.prevent_enter = false;
					}
					else
					{
						flag2 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
						if (flag2)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row++;
							this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
						}
					}
				}
			}
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00186108 File Offset: 0x00184308
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
			GridEXRow[] rows = this.GridEX1.GetRows();
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

		// Token: 0x060020D6 RID: 8406 RVA: 0x00186268 File Offset: 0x00184468
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

		// Token: 0x060020D7 RID: 8407 RVA: 0x0018630C File Offset: 0x0018450C
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00008917 File Offset: 0x00006B17
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			this.gridex1focused = true;
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00186360 File Offset: 0x00184560
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.Row < -1;
			if (flag)
			{
				this.GridEX1.Row = -1;
			}
			this.Clean_Status();
			this.GetStatusInfo();
			checked
			{
				flag = (this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
				if (flag)
				{
					bool flag2 = this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value;
					if (flag2)
					{
						this.GridEX1.GetRow().Cells["Zarf"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value);
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Zarf"].Position);
						if (flag2)
						{
							flag = (this.GridEX1.EditTextBox != null);
							if (flag)
							{
								this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value);
							}
						}
					}
				}
			}
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00008922 File Offset: 0x00006B22
		private void gridex2_GotFocus(object sender, EventArgs e)
		{
			this.gridex1focused = false;
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x001864FC File Offset: 0x001846FC
		private void GridEX2_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.gridex2.Row < -1;
			if (flag)
			{
				this.gridex2.Row = -1;
			}
			flag = (this.gridex2.CurrentRow.Cells["moshtari_ID"].Value != DBNull.Value);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectGreater(this.gridex2.CurrentRow.Cells["moshtari_id"].Value, 0, false);
				if (flag2)
				{
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.gridex2.CurrentRow.Cells["Moshtari_ID"].Value);
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
				bool flag2 = this.gridex2.GetRow().Cells["Zarf"].Value == DBNull.Value && this.gridex2.Row - 1 >= 0;
				if (flag2)
				{
					flag = (this.gridex2.GetRows()[this.gridex2.Row - 1].Cells["Zarf"].Value != DBNull.Value);
					if (flag)
					{
						this.gridex2.GetRow().Cells["Zarf"].Value = RuntimeHelpers.GetObjectValue(this.gridex2.GetRows()[this.gridex2.Row - 1].Cells["Zarf"].Value);
						flag2 = (this.gridex2.Col == this.gridex2.RootTable.Columns["Zarf"].Position);
						if (flag2)
						{
							flag = (this.gridex2.EditTextBox != null);
							if (flag)
							{
								this.gridex2.EditTextBox.Text = Conversions.ToString(this.gridex2.GetRows()[this.gridex2.Row - 1].Cells["Zarf"].Value);
							}
						}
					}
				}
			}
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00186738 File Offset: 0x00184938
		private void txt_jam_koln_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
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
							this.gridex2.UpdateData();
							this.gridex2.Col = 0;
							this.gridex2.Row = -1;
							this.GridEX2_SelectionChanged(null, null);
						}
						else
						{
							DataEntryGrid gridex = this.gridex2;
							gridex.Col++;
						}
					}
				}
			}
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x001867D0 File Offset: 0x001849D0
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
						this.GridEX1.UpdateData();
						this.prevent_enter = true;
						this.GridEX1.Col = 0;
						this.GridEX1.Row = -1;
						this.GridEX1_SelectionChanged(null, null);
						flag2 = (Operators.CompareString(this.GridEX1.GetRow(this.GridEX1.RowCount - 1).Cells["zarf"].Value.ToString(), string.Empty, false) != 0);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["zarf"].Value = this.GridEX1.GetRow(this.GridEX1.RowCount - 1).Cells["zarf"].Value.ToString();
						}
					}
					else
					{
						this.prevent_enter = true;
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
				flag2 = (e.KeyCode == Keys.Left);
				if (flag2)
				{
					this.gridex2.Focus();
					this.gridex2.MoveToNewRecord();
					this.gridex2.Col = 0;
					this.gridex2.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00186958 File Offset: 0x00184B58
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

		// Token: 0x060020DF RID: 8415 RVA: 0x00186A48 File Offset: 0x00184C48
		private void Calc_Kargari()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				bool flag2 = this.GridEX1.GetRow().Cells["tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["tedad"].Value != null;
				if (flag2)
				{
					bool flag3 = this.GridEX1.GetRow().Cells["kala_id"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["kala_id"].Value != null;
					if (flag3)
					{
						DataRow[] array = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.GetRow().Cells["kala_id"].Value)));
						flag3 = (array.Length > 0);
						if (flag3)
						{
							flag2 = (array[0]["mablagh_kargari"] != DBNull.Value);
							if (flag2)
							{
								this.GridEX1.GetRow().Cells["kargari"].Value = Operators.MultiplyObject(array[0]["mablagh_kargari"], this.GridEX1.GetRow().Cells["tedad"].Value);
								flag3 = (this.GridEX1.GetRow().Cells["jam_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_kol"].Value != null);
								if (flag3)
								{
									flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.GetRow().Cells["jam_kol"].Value, 0, false);
									if (flag2)
									{
										this.GridEX1.GetRow().Cells["jamkol_ba_kargari"].Value = Operators.AddObject(this.GridEX1.GetRow().Cells["jam_kol"].Value, this.GridEX1.GetRow().Cells["kargari"].Value);
									}
									else
									{
										this.GridEX1.GetRow().Cells["jamkol_ba_kargari"].Value = 0;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00186CE4 File Offset: 0x00184EE4
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

		// Token: 0x060020E1 RID: 8417 RVA: 0x00186DCC File Offset: 0x00184FCC
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

		// Token: 0x060020E2 RID: 8418 RVA: 0x0018713C File Offset: 0x0018533C
		private void Calc_avg()
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
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

		// Token: 0x060020E3 RID: 8419 RVA: 0x0014FC68 File Offset: 0x0014DE68
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

		// Token: 0x060020E4 RID: 8420 RVA: 0x0014FDC4 File Offset: 0x0014DFC4
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

		// Token: 0x060020E5 RID: 8421 RVA: 0x00150234 File Offset: 0x0014E434
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

		// Token: 0x060020E6 RID: 8422 RVA: 0x00150234 File Offset: 0x0014E434
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x001872CC File Offset: 0x001854CC
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
					this.Calc((GridEX)sender);
					this.GetSum((GridEX)sender, "tedad", false);
					this.GetTotalZarf((GridEX)sender);
					this.update_avg((GridEX)sender);
				}
				else
				{
					flag = (Operators.CompareString(left, "vazn_ba_zarf", false) == 0);
					if (flag)
					{
						this.Calc((GridEX)sender);
						this.GetSum((GridEX)sender, "vazn_ba_zarf", false);
						this.update_avg((GridEX)sender);
					}
					else
					{
						flag = (Operators.CompareString(left, "vazn_kol", false) == 0);
						if (flag)
						{
							this.GetSum((GridEX)sender, "Vazn_Kol", false);
							this.CalcMablagh((GridEX)sender, true, false);
							flag = !gridEX.RootTable.Columns["vazn_ba_zarf"].Visible;
							if (flag)
							{
								decimal d = 0m;
								flag = (gridEX.CurrentRow.Cells["zarf"].Value != DBNull.Value);
								if (flag)
								{
									d = Conversions.ToDecimal(gridEX.CurrentRow.Cells["zarf"].Value);
								}
								decimal d2 = 0m;
								flag = (gridEX.CurrentRow.Cells["tedad"].Value != DBNull.Value);
								if (flag)
								{
									d2 = Conversions.ToDecimal(gridEX.CurrentRow.Cells["tedad"].Value);
								}
								flag = (gridEX.CurrentRow.Cells["vazn_kol"].Value != DBNull.Value);
								if (flag)
								{
									gridEX.CurrentRow.Cells["vazn_ba_zarf"].Value = Operators.AddObject(gridEX.CurrentRow.Cells["vazn_kol"].Value, decimal.Multiply(d2, d));
								}
								this.update_avg((GridEX)sender);
								this.GetSum((GridEX)sender, "vazn_ba_zarf", false);
							}
						}
						else
						{
							flag = (Operators.CompareString(left, "zarf", false) == 0);
							if (flag)
							{
								bool flag2 = gridEX.CurrentRow.Cells["zarf"].Value == DBNull.Value;
								if (flag2)
								{
									gridEX.CurrentRow.Cells["zarf"].Value = 0;
								}
								this.Calc((GridEX)sender);
								this.GetTotalZarf((GridEX)sender);
							}
							else
							{
								bool flag2 = Operators.CompareString(left, "fee", false) == 0;
								if (flag2)
								{
									this.CalcMablagh(gridEX, true, false);
								}
								else
								{
									flag2 = (Operators.CompareString(left, "jam_kol", false) == 0);
									if (flag2)
									{
										this.GetSum((GridEX)sender, "jam_Kol", true);
										this.CalcMablagh(gridEX, false, true);
									}
									else
									{
										flag2 = (Operators.CompareString(left, "kargari", false) == 0);
										if (flag2)
										{
											flag = (gridEX.GetRow().Cells["jam_kol"].Value != DBNull.Value && gridEX.GetRow().Cells["jam_kol"].Value != null);
											if (flag)
											{
												bool flag3 = Operators.ConditionalCompareObjectNotEqual(gridEX.GetRow().Cells["jam_kol"].Value, 0, false);
												if (flag3)
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

		// Token: 0x060020E8 RID: 8424 RVA: 0x00150D10 File Offset: 0x0014EF10
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

		// Token: 0x060020E9 RID: 8425 RVA: 0x00150DD0 File Offset: 0x0014EFD0
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

		// Token: 0x060020EA RID: 8426 RVA: 0x00187740 File Offset: 0x00185940
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
					this.GridEX1.GetTotalRow().Cells["fee"].Text = Public_Function.FormatPrice(Conversions.ToString(this.GetDecimalValue(Conversions.ToDecimal(Operators.DivideObject(e.Row.Cells["jam_kol"].Value, e.Row.Cells["vazn_kol"].Value)))));
				}
			}
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x001878C8 File Offset: 0x00185AC8
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

		// Token: 0x060020EC RID: 8428 RVA: 0x001879D4 File Offset: 0x00185BD4
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

		// Token: 0x060020ED RID: 8429 RVA: 0x001511CC File Offset: 0x0014F3CC
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

		// Token: 0x060020EE RID: 8430 RVA: 0x00187AE0 File Offset: 0x00185CE0
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
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
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

		// Token: 0x060020EF RID: 8431 RVA: 0x00187CB8 File Offset: 0x00185EB8
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.EditTextBox == null);
					bool flag3;
					if (flag)
					{
						bool flag2 = this.GridEX1.GetRow() != null;
						if (flag2)
						{
							flag3 = (this.GridEX1.GetRow().RowType == RowType.Record);
							if (flag3)
							{
								this.GridEX1.GetRow().BeginEdit();
							}
						}
					}
					flag3 = (e.KeyCode == Keys.Delete);
					if (flag3)
					{
						bool flag2 = this.GridEX1.EditTextBox != null;
						if (flag2)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["kala_name"].Position);
						if (flag3)
						{
							this.GridEX1.CurrentRow.Cells["Kala_ID"].Value = DBNull.Value;
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_name"].Position);
						if (flag3)
						{
							this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
						}
					}
					Keys keyData = e.KeyData;
					flag3 = (keyData == Keys.Tab);
					if (flag3)
					{
						this.gridex2.Focus();
						this.gridex2.Row = -1;
						this.gridex2.Col = 0;
						this.gridex2.EditMode = EditMode.EditOn;
					}
					else
					{
						flag3 = (keyData == Keys.Up);
						if (flag3)
						{
							bool flag2 = this.GridEX1.Row > 0;
							if (flag2)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Row--;
								e.SuppressKeyPress = true;
								return;
							}
						}
						else
						{
							flag3 = (keyData == Keys.Down);
							if (flag3)
							{
								bool flag2 = this.GridEX1.Row < this.GridEX1.RowCount - 1;
								if (flag2)
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Row++;
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
										this.GridEX1.EditMode = EditMode.EditOn;
										return;
									}
									flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
									if (flag3)
									{
										e.SuppressKeyPress = true;
										return;
									}
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
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
										flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
										if (flag3)
										{
											e.SuppressKeyPress = true;
											return;
										}
										flag3 = (this.GridEX1.Col > 0);
										if (flag3)
										{
											this.move_right(this.GridEX1);
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
						bool flag2 = this.GridEX1.EditTextBox == null;
						if (flag2)
						{
							this.GridEX1.EditMode = EditMode.EditOn;
						}
						int col = this.GridEX1.Col;
						flag3 = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
						if (flag3)
						{
							flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag2)
							{
								this.Moshtari_Select();
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
						else
						{
							flag3 = (col == this.GridEX1.RootTable.Columns["vazn_kol"].Position);
							if (flag3)
							{
								flag2 = this.prevent_enter;
								if (flag2)
								{
									this.prevent_enter = false;
								}
								else
								{
									this.GridEX1.Col = this.GridEX1.RootTable.Columns["jam_kol"].Position;
								}
							}
							else
							{
								flag3 = (col == this.GridEX1.RootTable.Columns["fee"].Position);
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
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x001881D8 File Offset: 0x001863D8
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			this.gridex2.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int i = 0;
			checked
			{
				while (i <= dataTable.Rows.Count - 1)
				{
					bool flag = dataTable.Rows[i].RowState == DataRowState.Deleted;
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
				GridEXRow[] rows = this.gridex2.GetRows();
				bool result;
				for (int j = 0; j < rows.Length; j++)
				{
					GridEXRow gridEXRow = rows[j];
					bool flag = gridEXRow.Cells["moshtari_name"].Value == DBNull.Value;
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.gridex2, gridEXRow, "Moshtari_Name", "خریدار را انتخاب نمایید");
						result = false;
						return result;
					}
				}
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["vazn_kol"] == DBNull.Value && this.GridEX1.RootTable.Columns["vazn_kol"].Visible;
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "vazn_kol", "وزن خالص را وارد نمایید");
							result = false;
							return result;
						}
						flag = !this.GridEX1.RootTable.Columns["vazn_kol"].Visible;
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
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "fee", "فی واحد را وارد نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["jam_kol"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "jam_kol", "قیمت کل را وارد نمایید");
							result = false;
							return result;
						}
						num++;
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
				DataTable dataTable2 = (DataTable)this.gridex2.DataSource;
				try
				{
					IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = dataRow2["fee"] == DBNull.Value;
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
					bool flag = enumerator2 is IDisposable;
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00151DF4 File Offset: 0x0014FFF4
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

		// Token: 0x060020F2 RID: 8434 RVA: 0x0018867C File Offset: 0x0018687C
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

		// Token: 0x060020F3 RID: 8435 RVA: 0x001525DC File Offset: 0x001507DC
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

		// Token: 0x060020F4 RID: 8436 RVA: 0x00188B6C File Offset: 0x00186D6C
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

		// Token: 0x060020F5 RID: 8437 RVA: 0x00188BD0 File Offset: 0x00186DD0
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

		// Token: 0x060020F6 RID: 8438 RVA: 0x00188E6C File Offset: 0x0018706C
		private void Save()
		{
			bool flag = !this.ValidateGridData();
			if (!flag)
			{
				object obj = null;
				string text = "declare @id bigint;";
				int num = this.kind;
				flag = (num == 1);
				long num2;
				if (flag)
				{
					num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(id,0) from furush_hag where num=" + Public_Function.GetValueInt(Conversions.ToString(this.num))));
					flag = (num2 == 0L);
					if (!flag)
					{
						Public_Function.ExecuteNonQuery("update furush_hag set nahve_furush=" + Conversions.ToString(this.GetNahve_Furush()) + " where id=" + Conversions.ToString(num2));
					}
					obj = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select id from furush_kiosk where furush_id=" + Conversions.ToString(num2)));
				}
				flag = (obj == null);
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						"insert into furush_kiosk (furush_id,nahve_furush) values(",
						Public_Function.GetValueInt(Conversions.ToString(num2)),
						",",
						Conversions.ToString(this.GetNahve_Furush()),
						");select @id=scope_identity();"
					});
				}
				else
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_kiosk set nahve_furush=" + Conversions.ToString(this.GetNahve_Furush()) + " where id=", obj), ";")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @id=", obj)));
				}
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["ID"] == DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into furush_kiosk_detail([Furush_kiosk_ID],[Tarikh],[Moshtari_ID],[Kala_ID],[Insert_Detail_ID],[Tedad],[Vazn_Ba_Zarf],[Zarf],[Vazn_Kol],[Fee],[Jam_Kol])   values(@id," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Public_Function.dict["today"])) + ",-1,", dataRow["kala_id"]), ",null,"), Public_Function.GetValueInt(dataRow["tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["vazn_ba_zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["vazn_kol"].ToString())), ","), Public_Function.GetValueInt(dataRow["fee"].ToString())), ","), Public_Function.GetValueInt(dataRow["jam_kol"].ToString())), ");")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Furush_kiosk_Detail SET [Furush_kiosk_ID] =@id     ,[Tarikh] = " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Public_Function.dict["today"])) + "    ,[Moshtari_ID] = -1 " + "    ,[Kala_ID] = ", dataRow["kala_id"]), "    ,[Tedad] = "), Public_Function.GetValueInt(dataRow["tedad"].ToString())), "    ,[Vazn_Ba_Zarf] = "), Public_Function.GetValueInt(dataRow["vazn_ba_zarf"].ToString())), "    ,[Zarf] = "), Public_Function.GetValueInt(dataRow["zarf"].ToString())), "    ,[Vazn_Kol] = "), Public_Function.GetValueInt(dataRow["vazn_kol"].ToString())), "    ,[Fee] =  "), Public_Function.GetValueInt(dataRow["fee"].ToString())), "    ,[Jam_Kol] = "), Public_Function.GetValueInt(dataRow["jam_kol"].ToString())), "  WHERE ID="), dataRow["ID"])));
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
				Public_Function.ExecuteNonQuery(text);
				this.RollBabk_Rizbar_furush(this.kind, this.id);
				this.sync_kala_to_kala(this.kind, this.id);
				this.Update_Furush_hag(this.kind, Public_Function.dict["today"], num2);
				int num3 = this.kind;
				flag = (num3 == 1);
				if (flag)
				{
					this.Update_FurushHag_Nesie(Conversions.ToString(num2), Conversions.ToString(this.num), Conversions.ToString(this.GetNahve_Furush()), Public_Function.dict["today"], (DataTable)this.gridex2.DataSource);
				}
				this.Commit_rizbar_furush(this.kind, this.id);
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				DataTable detail = this.GetDetail(this.kind, Conversions.ToString(this.id));
				this.gridex2.DataSource = detail;
				this.Calc_avg();
				this.kala_name.Clear();
				try
				{
					IEnumerator enumerator2 = detail.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag = !this.kala_name.ContainsKey(Conversions.ToString(dataRow2["kala_name"]));
						if (flag)
						{
							this.kala_name.Add(Conversions.ToString(dataRow2["kala_name"]), Conversions.ToString(dataRow2["kala_id"]));
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
				this.dt_rizbar = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("SELECT    kala.ID as kala_id, Kala.Name as kala_name FROM         Furush_Hag_RizBar INNER JOIN Kala ON Furush_Hag_RizBar.Kala_ID = Kala.ID where furush_hag_id=", this.frm.SelectedRow["ID"])));
				try
				{
					IEnumerator enumerator3 = this.dt_rizbar.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						flag = !this.kala_name.ContainsKey(Conversions.ToString(dataRow3["kala_name"]));
						if (flag)
						{
							this.kala_name.Add(Conversions.ToString(dataRow3["kala_name"]), Conversions.ToString(dataRow3["kala_id"]));
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
			}
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0000892D File Offset: 0x00006B2D
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Save();
			MyProject.Forms.Form_Main.Get_mande_furush();
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x001895C0 File Offset: 0x001877C0
		private void DeleteDetailByID()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					bool flag3 = ((DataRowView)this.GridEX1.CurrentRow.DataRow)["insert_detail_ID"] != DBNull.Value;
					if (flag3)
					{
						long value = Conversions.ToLong(((DataRowView)this.GridEX1.CurrentRow.DataRow)["insert_detail_ID"]);
						long value2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(daryaft_id,0) from furush_hag_Detail where id=" + Conversions.ToString(value)));
						string text = string.Empty;
						NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
						{
							Operators.ConcatenateObject(" delete from furush_kiosk_detail where id =", ((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"])
						}, null, null, null, true);
						this.GridEX1.CurrentRow.Delete();
						int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(count(id),0) from furush_kiosk_detail where insert_detail_id=" + Conversions.ToString(value)));
						flag3 = (num == 0);
						if (flag3)
						{
							text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
							text = text + "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id= " + Conversions.ToString(value2) + ";";
							text = text + "update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=" + Conversions.ToString(value2) + ";";
							text += "delete from sanad where id =@sanadbed_id;";
							text += "delete from sanad where id=@sanadbes_id;";
							text = text + " delete from furush_hag_detail where id=" + Conversions.ToString(value) + ";";
							text = text + "delete from daryaftpardakht where id=" + Conversions.ToString(value2) + ";";
							Public_Function.ExecuteNonQuery(text);
						}
						else
						{
							long iD = Conversions.ToLong(Public_Function.ExecuteScalar("select furush_hug_id from furush_hag_detail where id=" + Conversions.ToString(value)));
							this.Update_Furush_hag(1, Public_Function.dict["today"], iD);
						}
					}
					else
					{
						this.GridEX1.CurrentRow.Delete();
					}
				}
			}
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x001897DC File Offset: 0x001879DC
		private void DeleteNesie(long Detail_id)
		{
			int num = this.kind;
			bool flag = num == 1;
			if (flag)
			{
				long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(daryaft_id,0) from furush_hag_Detail where id=" + Conversions.ToString(Detail_id)));
				long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select furush_hug_id from furush_hag_detail where id=" + Conversions.ToString(Detail_id)));
				string text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
				text = text + "select @sanad_id=sanad_id , @daryaft_id=daryaft_id from furush_hag_detail where id=" + Conversions.ToString(Detail_id) + ";";
				text = text + "update furush_hag_detail set sanad_id=null,daryaft_id=null where id=" + Conversions.ToString(Detail_id) + ";";
				text += "delete from sanad where id=@sanad_id;";
				text = text + "delete from furush_hag_detail where id=" + Conversions.ToString(Detail_id) + ";";
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00189898 File Offset: 0x00187A98
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.gridex1focused;
			if (flag)
			{
				this.DeleteDetailByID();
			}
			else
			{
				flag = (this.gridex2.CurrentRow != null);
				if (flag)
				{
					bool flag2 = this.gridex2.CurrentRow.Cells["id"].Value != DBNull.Value;
					if (flag2)
					{
						this.DeleteNesie(Conversions.ToLong(this.gridex2.CurrentRow.Cells["id"].Value));
					}
					this.gridex2.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00189940 File Offset: 0x00187B40
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = !this.gridex1focused;
			if (flag)
			{
				bool flag2 = this.gridex2.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
				if (flag2)
				{
					bool flag3 = Operators.ConditionalCompareObjectNotEqual(this.gridex2.CurrentRow.Cells["moshtari_id"].Value, -1, false) && Operators.ConditionalCompareObjectNotEqual(this.gridex2.CurrentRow.Cells["moshtari_id"].Value, -3, false);
					if (flag3)
					{
						Frm_SuratHesab_Moshtari arg_DF_0 = frm_SuratHesab_Moshtari;
						object expr_CD = this.gridex2.CurrentRow.Cells["moshtari_id"].Value;
						int? num;
						arg_DF_0.Moshtari_id = ((expr_CD != null) ? ((int?)expr_CD) : num);
						frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.gridex2.CurrentRow.Cells["Moshtari_Name"].Value);
					}
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00008948 File Offset: 0x00006B48
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00189A74 File Offset: 0x00187C74
		private void Frm_Kiosk_Furush_Resize(object sender, EventArgs e)
		{
			bool flag = MyProject.Forms.Form_Main.WindowState == FormWindowState.Minimized;
			checked
			{
				if (!flag)
				{
					this.GridEX1.Height = this.RibbonStatusBar1.Top - 180;
					this.gridex2.Height = this.RibbonStatusBar1.Top - 180;
					this.gridex2.Width = (int)Math.Round((double)this.UiGroupBox1.Width / 2.0);
					this.gridex2.Left = 1;
					this.GridEX1.Left = this.gridex2.Right + 3;
					this.GridEX1.Width = this.gridex2.Width - 6;
				}
			}
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00189B44 File Offset: 0x00187D44
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
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

		// Token: 0x060020FF RID: 8447 RVA: 0x00189BE0 File Offset: 0x00187DE0
		private void gridex2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			bool flag2;
			if (flag)
			{
				flag2 = (this.gridex2.EditTextBox != null);
				if (flag2)
				{
					this.gridex2.EditTextBox.Text = string.Empty;
				}
				flag2 = (this.gridex2.Col == this.gridex2.RootTable.Columns["Moshtari_name"].Position);
				if (flag2)
				{
					this.gridex2.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
				}
				flag2 = (this.gridex2.Col == this.gridex2.RootTable.Columns["sanad"].Position);
				if (flag2)
				{
					this.gridex2.CurrentRow.Cells["sanad"].Value = DBNull.Value;
				}
			}
			Keys keyCode = e.KeyCode;
			flag2 = (keyCode == Keys.Tab);
			checked
			{
				if (flag2)
				{
					this.GridEX1.Focus();
					this.GridEX1.Row = -1;
					this.GridEX1.Col = 0;
					this.GridEX1.EditMode = EditMode.EditOn;
				}
				else
				{
					flag2 = (keyCode == Keys.Left);
					if (flag2)
					{
						DataEntryGrid gridex = this.gridex2;
						gridex.Col++;
						e.SuppressKeyPress = true;
					}
					else
					{
						flag2 = (keyCode == Keys.Right);
						if (flag2)
						{
							flag = (this.gridex2.Col > 0);
							if (flag)
							{
								this.move_right(this.gridex2);
								this.gridex2.EditMode = EditMode.EditOn;
								e.SuppressKeyPress = true;
							}
							else
							{
								this.gridex2.Focus();
								this.gridex2.MoveToNewRecord();
								this.gridex2.Col = 0;
								this.gridex2.EditMode = EditMode.EditOn;
							}
						}
						else
						{
							flag2 = (keyCode == Keys.Return);
							if (flag2)
							{
								flag = (this.gridex2.EditTextBox == null);
								if (flag)
								{
									this.gridex2.EditMode = EditMode.EditOn;
								}
								int col = this.gridex2.Col;
								flag2 = (col == this.gridex2.RootTable.Columns["moshtari_name"].Position);
								if (flag2)
								{
									flag = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
									if (flag)
									{
										this.Moshtari_Select_nesie();
									}
									else
									{
										DataEntryGrid gridex = this.gridex2;
										gridex.Col++;
									}
								}
								else
								{
									flag2 = (col == this.gridex2.RootTable.Columns["sanad"].Position);
									if (flag2)
									{
										flag = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
										if (flag)
										{
											this.Select_Sanad();
										}
										else
										{
											DataEntryGrid gridex = this.gridex2;
											gridex.Col++;
										}
									}
									else
									{
										flag2 = (col == this.gridex2.RootTable.Columns["vazn_kol"].Position);
										if (flag2)
										{
											flag = this.prevent_enter;
											if (flag)
											{
												this.prevent_enter = false;
											}
											else
											{
												DataEntryGrid gridex = this.gridex2;
												gridex.Col++;
											}
										}
										else
										{
											flag2 = (col == this.gridex2.RootTable.Columns["fee"].Position);
											if (flag2)
											{
												e.SuppressKeyPress = true;
											}
											else
											{
												flag2 = this.prevent_enter;
												if (flag2)
												{
													this.prevent_enter = false;
												}
												else
												{
													DataEntryGrid gridex = this.gridex2;
													gridex.Col++;
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

		// Token: 0x06002100 RID: 8448 RVA: 0x00189FB8 File Offset: 0x001881B8
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
					bool flag2 = this.gridex2.Col == this.gridex2.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null;
					if (flag2)
					{
						this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm_moshtari_nesie.SelectedRow["Name"]);
						this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm_moshtari_nesie.SelectedRow["ID"]);
						DataEntryGrid gridex = this.gridex2;
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

		// Token: 0x06002101 RID: 8449 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000C9A RID: 3226
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000C9C RID: 3228
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000C9D RID: 3229
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000C9E RID: 3230
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000C9F RID: 3231
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000CA0 RID: 3232
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000CA1 RID: 3233
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000CA2 RID: 3234
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000CA3 RID: 3235
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000CA4 RID: 3236
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x04000CA5 RID: 3237
		[AccessedThroughProperty("NumericBox1")]
		private NumericBox _NumericBox1;

		// Token: 0x04000CA6 RID: 3238
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000CA7 RID: 3239
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000CA8 RID: 3240
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000CA9 RID: 3241
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000CAA RID: 3242
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000CAB RID: 3243
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000CAC RID: 3244
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000CAD RID: 3245
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000CAE RID: 3246
		[AccessedThroughProperty("txt_kargari")]
		private CurrencyBox _txt_kargari;

		// Token: 0x04000CAF RID: 3247
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000CB0 RID: 3248
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000CB1 RID: 3249
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000CB2 RID: 3250
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000CB3 RID: 3251
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000CB4 RID: 3252
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000CB5 RID: 3253
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000CB6 RID: 3254
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000CB7 RID: 3255
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000CB8 RID: 3256
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000CB9 RID: 3257
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000CBA RID: 3258
		[AccessedThroughProperty("gridex2")]
		private DataEntryGrid _gridex2;

		// Token: 0x04000CBB RID: 3259
		[AccessedThroughProperty("Highlighter1")]
		private Highlighter _Highlighter1;

		// Token: 0x04000CBC RID: 3260
		[AccessedThroughProperty("txt_fee_n")]
		private CurrencyBox _txt_fee_n;

		// Token: 0x04000CBD RID: 3261
		[AccessedThroughProperty("txt_jamkol_n")]
		private CurrencyBox _txt_jamkol_n;

		// Token: 0x04000CBE RID: 3262
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04000CBF RID: 3263
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000CC0 RID: 3264
		private Frm_SelectItem frm;

		// Token: 0x04000CC1 RID: 3265
		private Frm_SelectItem frm_kala_select;

		// Token: 0x04000CC2 RID: 3266
		private Frm_SelectItem frm_moshtari_nesie;

		// Token: 0x04000CC3 RID: 3267
		private DataTable dt_rizbar;

		// Token: 0x04000CC4 RID: 3268
		private bool prevent_enter;

		// Token: 0x04000CC5 RID: 3269
		private bool prevent_close;

		// Token: 0x04000CC6 RID: 3270
		private bool prevent_right;

		// Token: 0x04000CC7 RID: 3271
		private bool prevent_left;

		// Token: 0x04000CC8 RID: 3272
		private bool gridex1focused;

		// Token: 0x04000CC9 RID: 3273
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000CCA RID: 3274
		private int kind;

		// Token: 0x04000CCB RID: 3275
		private long id;

		// Token: 0x04000CCC RID: 3276
		private long num;

		// Token: 0x04000CCD RID: 3277
		private Dictionary<string, string> kala_name;

		// Token: 0x04000CCE RID: 3278
		private DataTable dt_kala_to_kala;
	}
}
