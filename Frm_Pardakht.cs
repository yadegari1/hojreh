using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000100 RID: 256
	[DesignerGenerated]
	public partial class Frm_Pardakht : Form
	{
		// Token: 0x0600212D RID: 8493 RVA: 0x0018B608 File Offset: 0x00189808
		public Frm_Pardakht()
		{
			base.Load += new EventHandler(this.Frm_DaryaftPardakht_Load);
			Frm_Pardakht.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.frm = new Frm_SelectItem();
			this.Sanad = new Sanad();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0018B668 File Offset: 0x00189868
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Pardakht.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Pardakht.__ENCList.Count == Frm_Pardakht.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Pardakht.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Pardakht.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Pardakht.__ENCList[num] = Frm_Pardakht.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Pardakht.__ENCList.RemoveRange(num, Frm_Pardakht.__ENCList.Count - num);
						Frm_Pardakht.__ENCList.Capacity = Frm_Pardakht.__ENCList.Count;
					}
					Frm_Pardakht.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x0018E0F0 File Offset: 0x0018C2F0
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0018E108 File Offset: 0x0018C308
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
				KeyEventHandler value3 = new KeyEventHandler(this.txt_tarikh_KeyDown);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.Validated -= value2;
					this._txt_tarikh.KeyDown -= value3;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.Validated += value2;
					this._txt_tarikh.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0018E190 File Offset: 0x0018C390
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x00008A13 File Offset: 0x00006C13
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

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0018E1A8 File Offset: 0x0018C3A8
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x00008A1D File Offset: 0x00006C1D
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

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0018E1C0 File Offset: 0x0018C3C0
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x00008A27 File Offset: 0x00006C27
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

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x0018E1D8 File Offset: 0x0018C3D8
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0018E1F0 File Offset: 0x0018C3F0
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
				InitCustomEditEventHandler value2 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value3 = new EventHandler(this.GridEX1_SelectionChanged);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				EndCustomEditEventHandler value5 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				EditingCellEventHandler value6 = new EditingCellEventHandler(this.GridEX1_EditingCell);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.InitCustomEdit -= value2;
					this._GridEX1.SelectionChanged -= value3;
					this._GridEX1.KeyDown -= value4;
					this._GridEX1.EndCustomEdit -= value5;
					this._GridEX1.EditingCell -= value6;
					this._GridEX1.ColumnButtonClick -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.InitCustomEdit += value2;
					this._GridEX1.SelectionChanged += value3;
					this._GridEX1.KeyDown += value4;
					this._GridEX1.EndCustomEdit += value5;
					this._GridEX1.EditingCell += value6;
					this._GridEX1.ColumnButtonClick += value7;
				}
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x0018E324 File Offset: 0x0018C524
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x00008A31 File Offset: 0x00006C31
		internal virtual UIGroupBox group_dnaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_dnaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_dnaghd = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0018E33C File Offset: 0x0018C53C
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x00008A3B File Offset: 0x00006C3B
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

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0018E354 File Offset: 0x0018C554
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x0018E36C File Offset: 0x0018C56C
		internal virtual EditBox txt_babat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_babat_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_babat != null;
				if (flag)
				{
					this._txt_babat.KeyDown -= value2;
					this._txt_babat.Validated -= value3;
				}
				this._txt_babat = value;
				flag = (this._txt_babat != null);
				if (flag)
				{
					this._txt_babat.KeyDown += value2;
					this._txt_babat.Validated += value3;
				}
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x0018E3F4 File Offset: 0x0018C5F4
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x00008A45 File Offset: 0x00006C45
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

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x0018E40C File Offset: 0x0018C60C
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x00008A4F File Offset: 0x00006C4F
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

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x0018E424 File Offset: 0x0018C624
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x0018E43C File Offset: 0x0018C63C
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

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x0018E49C File Offset: 0x0018C69C
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x00008A59 File Offset: 0x00006C59
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
				this._ButtonItem3 = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x0018E4B4 File Offset: 0x0018C6B4
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0018E4CC File Offset: 0x0018C6CC
		internal virtual CurrencyBox txt_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_mablagh_KeyDown);
				bool flag = this._txt_mablagh != null;
				if (flag)
				{
					this._txt_mablagh.KeyDown -= value2;
				}
				this._txt_mablagh = value;
				flag = (this._txt_mablagh != null);
				if (flag)
				{
					this._txt_mablagh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x0018E52C File Offset: 0x0018C72C
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00008A63 File Offset: 0x00006C63
		internal virtual GridSize GridSize1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridSize1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridSize1 = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0018E544 File Offset: 0x0018C744
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00008A6D File Offset: 0x00006C6D
		internal virtual PanelEx Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0018E55C File Offset: 0x0018C75C
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x00008A77 File Offset: 0x00006C77
		internal virtual UIGroupBox group_checkmoshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_checkmoshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_checkmoshtari = value;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x0018E574 File Offset: 0x0018C774
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x0018E58C File Offset: 0x0018C78C
		internal virtual DateBox2 txt_sarresid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sarresid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_sarresid != null;
				if (flag)
				{
					this._txt_sarresid.Validated -= value2;
				}
				this._txt_sarresid = value;
				flag = (this._txt_sarresid != null);
				if (flag)
				{
					this._txt_sarresid.Validated += value2;
				}
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x0018E5EC File Offset: 0x0018C7EC
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x00008A81 File Offset: 0x00006C81
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

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x0018E604 File Offset: 0x0018C804
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x00008A8B File Offset: 0x00006C8B
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

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x0018E61C File Offset: 0x0018C81C
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x00008A95 File Offset: 0x00006C95
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

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x0018E634 File Offset: 0x0018C834
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x0018E64C File Offset: 0x0018C84C
		internal virtual EditBox txt_babatcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babatcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_babat_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_babatcheck != null;
				if (flag)
				{
					this._txt_babatcheck.KeyDown -= value2;
					this._txt_babatcheck.Validated -= value3;
				}
				this._txt_babatcheck = value;
				flag = (this._txt_babatcheck != null);
				if (flag)
				{
					this._txt_babatcheck.KeyDown += value2;
					this._txt_babatcheck.Validated += value3;
				}
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x0018E6D4 File Offset: 0x0018C8D4
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00008A9F File Offset: 0x00006C9F
		internal virtual UIGroupBox group_dfish
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_dfish;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_dfish = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x0018E6EC File Offset: 0x0018C8EC
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x0018E704 File Offset: 0x0018C904
		internal virtual NumericBox txt_shfish
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shfish;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_shfish != null;
				if (flag)
				{
					this._txt_shfish.Validated -= value2;
				}
				this._txt_shfish = value;
				flag = (this._txt_shfish != null);
				if (flag)
				{
					this._txt_shfish.Validated += value2;
				}
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x0018E764 File Offset: 0x0018C964
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x00008AA9 File Offset: 0x00006CA9
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

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x0018E77C File Offset: 0x0018C97C
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00008AB3 File Offset: 0x00006CB3
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x0018E794 File Offset: 0x0018C994
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x0018E7AC File Offset: 0x0018C9AC
		internal virtual EditBox txt_fishbabat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fishbabat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_fishbabat != null;
				if (flag)
				{
					this._txt_fishbabat.Validated -= value2;
				}
				this._txt_fishbabat = value;
				flag = (this._txt_fishbabat != null);
				if (flag)
				{
					this._txt_fishbabat.Validated += value2;
				}
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0018E80C File Offset: 0x0018CA0C
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x0018E824 File Offset: 0x0018CA24
		internal virtual SelectItem txt_fishbank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fishbank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_fishbank_Validated);
				bool flag = this._txt_fishbank != null;
				if (flag)
				{
					this._txt_fishbank.Validated -= value2;
				}
				this._txt_fishbank = value;
				flag = (this._txt_fishbank != null);
				if (flag)
				{
					this._txt_fishbank.Validated += value2;
				}
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x0018E884 File Offset: 0x0018CA84
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x0018E89C File Offset: 0x0018CA9C
		internal virtual DateBox2 txt_fishtarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fishtarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_fishtarikh != null;
				if (flag)
				{
					this._txt_fishtarikh.Validated -= value2;
				}
				this._txt_fishtarikh = value;
				flag = (this._txt_fishtarikh != null);
				if (flag)
				{
					this._txt_fishtarikh.Validated += value2;
				}
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x0018E8FC File Offset: 0x0018CAFC
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x0018E914 File Offset: 0x0018CB14
		internal virtual SelectItem txt_fishbankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fishbankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_fishbankhesab_Validated);
				bool flag = this._txt_fishbankhesab != null;
				if (flag)
				{
					this._txt_fishbankhesab.Validated -= value2;
				}
				this._txt_fishbankhesab = value;
				flag = (this._txt_fishbankhesab != null);
				if (flag)
				{
					this._txt_fishbankhesab.Validated += value2;
				}
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x0018E974 File Offset: 0x0018CB74
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x00008ABD File Offset: 0x00006CBD
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

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x0018E98C File Offset: 0x0018CB8C
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x00008AC7 File Offset: 0x00006CC7
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

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x0018E9A4 File Offset: 0x0018CBA4
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x00008AD1 File Offset: 0x00006CD1
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x0018E9BC File Offset: 0x0018CBBC
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x0018E9D4 File Offset: 0x0018CBD4
		internal virtual SelectItem txt_shCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_shCheck_Validated);
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_shCheck_SelectedValueChanged);
				bool flag = this._txt_shCheck != null;
				if (flag)
				{
					this._txt_shCheck.Validated -= value2;
					this._txt_shCheck.SelectedValueChanged -= obj;
				}
				this._txt_shCheck = value;
				flag = (this._txt_shCheck != null);
				if (flag)
				{
					this._txt_shCheck.Validated += value2;
					this._txt_shCheck.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x0018EA5C File Offset: 0x0018CC5C
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00008ADB File Offset: 0x00006CDB
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

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x0018EA74 File Offset: 0x0018CC74
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x00008AE5 File Offset: 0x00006CE5
		internal virtual SelectItem txt_checkHesabBanki
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_checkHesabBanki;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_checkHesabBanki = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x0018EA8C File Offset: 0x0018CC8C
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x00008AEF File Offset: 0x00006CEF
		internal virtual Label lbl_sarresid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_sarresid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_sarresid = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0018EAA4 File Offset: 0x0018CCA4
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00008AF9 File Offset: 0x00006CF9
		internal virtual UIGroupBox Group_Dastecheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Dastecheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Dastecheck = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x0018EABC File Offset: 0x0018CCBC
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x00008B03 File Offset: 0x00006D03
		internal virtual EditBox txt_babatcheckd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babatcheckd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_babatcheckd = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x0018EAD4 File Offset: 0x0018CCD4
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00008B0D File Offset: 0x00006D0D
		internal virtual CurrencyBox txt_mablaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mablaghd = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x0018EAEC File Offset: 0x0018CCEC
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00008B17 File Offset: 0x00006D17
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x0018EB04 File Offset: 0x0018CD04
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x00008B21 File Offset: 0x00006D21
		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x0018EB1C File Offset: 0x0018CD1C
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00008B2B File Offset: 0x00006D2B
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

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x0018EB34 File Offset: 0x0018CD34
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x00008B35 File Offset: 0x00006D35
		internal virtual NumericBox txt_shdcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shdcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shdcheck = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x0018EB4C File Offset: 0x0018CD4C
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00008B3F File Offset: 0x00006D3F
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

		// Token: 0x06002189 RID: 8585 RVA: 0x0018EB64 File Offset: 0x0018CD64
		private void GetData()
		{
			DataTable pardakhtByDate = this.dp.GetPardakhtByDate(this.txt_tarikh.Text);
			this.GridEX1.DataSource = pardakhtByDate;
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0018EB98 File Offset: 0x0018CD98
		private void dp_select()
		{
			DataTable dt = Public_Function.FillData("select id,Name  from dptype where type=2");
			bool flag = this.frm.ShowDialog(dt, null, "") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["dp_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["dptype_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						this.group_checkmoshtari.Visible = false;
						this.Group_Dastecheck.Visible = false;
						this.group_dfish.Visible = false;
						this.group_dnaghd.Visible = false;
						object left = this.frm.SelectedRow["ID"];
						flag2 = Operators.ConditionalCompareObjectEqual(left, 10, false);
						if (flag2)
						{
							this.group_dnaghd.Visible = true;
							this.group_dnaghd.BringToFront();
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(left, 11, false);
							if (flag2)
							{
								this.Group_Dastecheck.Visible = true;
								this.Group_Dastecheck.BringToFront();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, 12, false);
								if (flag2)
								{
									this.group_checkmoshtari.Visible = true;
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left, 13, false);
									if (flag2)
									{
										this.group_dfish.Visible = true;
										this.group_dfish.BringToFront();
									}
								}
							}
						}
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0018ED94 File Offset: 0x0018CF94
		private void Moshtari_select()
		{
			DataTable dt = Public_Function.FillData("select id,Name + ' ' + Family as Name from moshtari where id<>-1");
			bool flag = this.frm.ShowDialog(dt, null, "") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.GetRow().Cells["dptype_id"].Value, 12, false);
						if (flag2)
						{
							this.txt_shCheck.Focus();
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

		// Token: 0x0600218C RID: 8588 RVA: 0x0018EECC File Offset: 0x0018D0CC
		private void SetRowValue(string column, string value)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				((DataRowView)this.GridEX1.GetRow().DataRow)[column] = value;
			}
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0018EF18 File Offset: 0x0018D118
		private void Frm_DaryaftPardakht_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.txt_tarikh.SetNew();
			this.GetData();
			this.GridSize1.GridColumns.Add(new GridColumn("dp_name", 30));
			this.GridSize1.GridColumns.Add(new GridColumn("moshtari_name", 50));
			this.GridSize1.GridColumns.Add(new GridColumn("mablagh", 20));
			this.GridSize1.Grid_Resize(this, null);
			this.txt_shCheck.SelectCommand = "SELECT     Sh_Check, Mablagh, ID,Check_Sarresid_Fa FROM DaryaftPardakht  WHERE     (dpType_ID = 2) AND (Check_Status = 1)";
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0018EFDC File Offset: 0x0018D1DC
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["dp_name"].Position;
			if (flag)
			{
				this.dp_select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
				if (flag)
				{
					this.Moshtari_select();
				}
			}
			flag = (this.GridEX1.GetRow().Cells["dptype_id"].Value != DBNull.Value);
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)this.GridEX1.GetRow().DataRow;
				object value = this.GridEX1.GetRow().Cells["dptype_id"].Value;
				flag = Operators.ConditionalCompareObjectEqual(value, 2, false);
				if (flag)
				{
					this.SetRowValue("Check_Sarresid_Fa", this.txt_sarresid.Text);
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(value, 3, false);
					if (flag)
					{
						this.SetRowValue("FishVariz_Fa", this.txt_fishtarikh.Text);
					}
				}
			}
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0000205D File Offset: 0x0000025D
		private void GridEX1_EditingCell(object sender, EditingCellEventArgs e)
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0018F114 File Offset: 0x0018D314
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			bool flag = e.EditControl == null;
			if (!flag)
			{
				flag = (Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0);
				if (flag)
				{
					bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (hasValue)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
				}
			}
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0018F190 File Offset: 0x0018D390
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_mablagh;
				this.txt_mablagh.Text = e.Value.ToString();
				this.txt_mablagh.SelectAll();
				flag = (this.GridEX1.GetRow().Cells["dptype_id"].Value != DBNull.Value && Operators.ConditionalCompareObjectEqual(this.GridEX1.GetRow().Cells["dptype_id"].Value, 12, false));
				if (flag)
				{
					this.txt_mablagh.Enabled = false;
				}
				else
				{
					this.txt_mablagh.Enabled = true;
				}
			}
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0018F270 File Offset: 0x0018D470
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			if (flag)
			{
				bool flag2 = this.GridEX1.EditTextBox != null;
				if (flag2)
				{
					this.GridEX1.EditTextBox.Text = string.Empty;
				}
			}
			checked
			{
				bool flag2;
				switch (e.KeyData)
				{
				case Keys.Left:
				{
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
					e.SuppressKeyPress = true;
					return;
				}
				case Keys.Up:
					flag2 = (this.GridEX1.Row > 0);
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row--;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Right:
					flag2 = (this.GridEX1.Col > 0);
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col--;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Down:
					flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				}
				flag2 = (e.KeyCode == Keys.Return);
				bool flag3;
				if (flag2)
				{
					int col = this.GridEX1.Col;
					flag = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
					if (flag)
					{
						flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
						if (flag3)
						{
							this.Moshtari_select();
						}
						else
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col++;
						}
					}
					else
					{
						flag3 = (col == this.GridEX1.RootTable.Columns["dp_Name"].Position);
						if (flag3)
						{
							flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag2)
							{
								this.dp_select();
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
						else
						{
							flag3 = (col == this.GridEX1.RootTable.Columns["mablagh"].Position);
							if (!flag3)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
					}
				}
				flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["dp_name"].Position || this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
				if (flag3)
				{
					e.SuppressKeyPress = true;
				}
			}
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x0018F580 File Offset: 0x0018D780
		private void txt_mablagh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.GridEX1.GetRow().Cells["dptype_id"].Value == DBNull.Value;
				if (flag2)
				{
					this.GridEX1.Col = this.GridEX1.RootTable.Columns["dp_name"].Position;
				}
				else
				{
					object value = this.GridEX1.GetRow().Cells["dptype_ID"].Value;
					flag2 = Operators.ConditionalCompareObjectEqual(value, 10, false);
					if (flag2)
					{
						this.txt_babat.Focus();
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(value, 11, false);
						if (flag2)
						{
							this.txt_checkHesabBanki.Focus();
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(value, 12, false);
							if (flag2)
							{
								this.txt_shCheck.Focus();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(value, 3, false);
								if (flag2)
								{
									this.txt_shfish.Focus();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00008B49 File Offset: 0x00006D49
		private void MoveToNewRecord()
		{
			this.GridEX1.Col = 0;
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Focus();
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0018F6A0 File Offset: 0x0018D8A0
		private void txt_babat_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)this.GridEX1.GetRow().DataRow;
				dataRowView["Tozih"] = this.txt_babat.Text;
				this.txt_babat.Text = string.Empty;
				this.MoveToNewRecord();
			}
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0018F704 File Offset: 0x0018D904
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			this.group_dnaghd.Visible = false;
			this.group_checkmoshtari.Visible = false;
			this.group_dfish.Visible = false;
			Public_Function.SetNew(this.group_dfish);
			Public_Function.SetNew(this.group_dnaghd);
			Public_Function.SetNew(this.group_checkmoshtari);
			bool flag = this.GridEX1.GetRow().RowType == RowType.Record;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)this.GridEX1.GetRow().DataRow;
				flag = (dataRowView != null && dataRowView["dptype_ID"] != DBNull.Value);
				if (flag)
				{
					object left = dataRowView["dptype_ID"];
					bool flag2 = Operators.ConditionalCompareObjectEqual(left, 10, false);
					if (flag2)
					{
						this.group_dnaghd.Visible = true;
						this.txt_babat.Text = dataRowView["Tozih"].ToString();
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(left, 11, false);
						if (!flag2)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(left, 12, false);
							if (flag2)
							{
								this.group_checkmoshtari.Visible = true;
								this.group_checkmoshtari.Visible = true;
								flag2 = (dataRowView["Check_Sarresid_Fa"] != DBNull.Value);
								if (flag2)
								{
									this.txt_sarresid.Text = dataRowView["Check_Sarresid_Fa"].ToString();
								}
								else
								{
									this.txt_sarresid.SetNew();
								}
								this.txt_babatcheck.Text = dataRowView["Tozih"].ToString();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, 13, false);
								if (flag2)
								{
									this.group_dfish.Visible = true;
									this.txt_fishbabat.Text = dataRowView["Tozih"].ToString();
									this.txt_shfish.Text = dataRowView["Sh_Fish"].ToString();
									flag2 = (dataRowView["FishVariz_Fa"] != DBNull.Value);
									if (flag2)
									{
										this.txt_fishtarikh.Text = dataRowView["Fishvariz_fa"].ToString();
									}
									else
									{
										this.txt_fishtarikh.SetNew();
									}
									flag2 = (dataRowView["CheckBank_ID"] != DBNull.Value);
									if (flag2)
									{
										this.txt_fishbank.SetValue(Conversions.ToString(dataRowView["CheckBank_Name"]), RuntimeHelpers.GetObjectValue(dataRowView["CheckBank_ID"]));
									}
									else
									{
										this.txt_fishbank.SetNew();
									}
									flag2 = (dataRowView["Bank_ID"] != DBNull.Value);
									if (flag2)
									{
										this.txt_fishbankhesab.SetValue(Conversions.ToString(dataRowView["BankHesab_Name"]), RuntimeHelpers.GetObjectValue(dataRowView["Bank_ID"]));
									}
									else
									{
										this.txt_fishbankhesab.SetNew();
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0018F9F8 File Offset: 0x0018DBF8
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			GridEXRow[] rows = this.GridEX1.GetRows();
			int i = 0;
			checked
			{
				while (i < rows.Length)
				{
					GridEXRow gridEXRow = rows[i];
					DataRowView dataRowView = (DataRowView)gridEXRow.DataRow;
					bool flag = gridEXRow.Cells["dptype_id"].Value == DBNull.Value;
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "dp_name", "نوع دریافت را مشخص فرمائید");
					}
					else
					{
						flag = (gridEXRow.Cells["Moshtari_id"].Value == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "moshtari_name", "مشتری مورد نظر را انتخاب فرمائید");
						}
						else
						{
							flag = (gridEXRow.Cells["mablagh"].Value == DBNull.Value);
							if (!flag)
							{
								flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 2, false);
								bool flag2;
								if (flag)
								{
									flag2 = (dataRowView["sh_check"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["sh_check"], string.Empty, false));
									if (flag2)
									{
										this.GridEX1.MoveTo(gridEXRow);
										return;
									}
									flag2 = (dataRowView["CheckBank_ID"] == DBNull.Value);
									if (flag2)
									{
										this.GridEX1.MoveTo(gridEXRow);
										return;
									}
									flag2 = (dataRowView["Check_Shobe"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["Check_Shobe"], string.Empty, false));
									if (flag2)
									{
										this.GridEX1.MoveTo(gridEXRow);
										return;
									}
								}
								flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 3, false);
								if (flag2)
								{
									flag = (dataRowView["sh_fish"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["sh_fish"], string.Empty, false));
									if (flag)
									{
										this.GridEX1.MoveTo(gridEXRow);
										this.txt_shfish.ShowTip("شماره فیش را وارد نمائید");
										return;
									}
									flag2 = (dataRowView["Bank_ID"] == DBNull.Value);
									if (flag2)
									{
										this.GridEX1.MoveTo(gridEXRow);
										this.txt_fishbankhesab.ShowTip("شماره حساب بانک را انتخاب فرمائید");
										return;
									}
								}
								i++;
								continue;
							}
							Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "mablagh", "مبلغ مورد نظر را وارد نمائید");
						}
					}
					return;
				}
				this.dp.UpdatePardakht(this.txt_tarikh.Text, (DataTable)this.GridEX1.DataSource);
				Public_Function.ConfirmInsert();
				this.GetData();
				this.MoveToNewRecord();
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0018FD04 File Offset: 0x0018DF04
		private void txt_babat_Validated(object sender, EventArgs e)
		{
			bool flag = sender.Equals(this.txt_babat);
			if (flag)
			{
				this.SetRowValue("Tozih", this.txt_babat.Text);
			}
			flag = sender.Equals(this.txt_sarresid);
			if (flag)
			{
				this.SetRowValue("Check_Sarresid_Fa", this.txt_sarresid.Text);
			}
			flag = sender.Equals(this.txt_babatcheck);
			if (flag)
			{
				this.SetRowValue("Tozih", this.txt_babatcheck.Text);
			}
			flag = sender.Equals(this.txt_fishbabat);
			if (flag)
			{
				this.SetRowValue("Tozih", this.txt_fishbabat.Text);
			}
			flag = sender.Equals(this.txt_shfish);
			if (flag)
			{
				this.SetRowValue("Sh_Fish", this.txt_shfish.Text);
			}
			flag = sender.Equals(this.txt_fishtarikh);
			if (flag)
			{
				this.SetRowValue("FishVariz_Fa", this.txt_fishtarikh.Text);
			}
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0018FE04 File Offset: 0x0018E004
		private void txt_bank_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
			}
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0018FE34 File Offset: 0x0018E034
		private void txt_fishbank_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_fishbank.Value != null;
				if (flag2)
				{
					((DataRowView)this.GridEX1.GetRow().DataRow)["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(this.txt_fishbank.Value);
					((DataRowView)this.GridEX1.GetRow().DataRow)["CheckBank_Name"] = this.txt_fishbank.Text;
				}
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0018FED4 File Offset: 0x0018E0D4
		private void txt_fishbankhesab_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_fishbankhesab.Value != null;
				if (flag2)
				{
					((DataRowView)this.GridEX1.GetRow().DataRow)["Bank_ID"] = RuntimeHelpers.GetObjectValue(this.txt_fishbankhesab.Value);
					((DataRowView)this.GridEX1.GetRow().DataRow)["BankHesab_Name"] = this.txt_fishbankhesab.Text;
				}
			}
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0018FF74 File Offset: 0x0018E174
		private void txt_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GetData();
				this.MoveToNewRecord();
			}
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00008B72 File Offset: 0x00006D72
		private void txt_tarikh_Validated(object sender, EventArgs e)
		{
			this.GetData();
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0018FFA0 File Offset: 0x0018E1A0
		private void txt_shCheck_SelectedValueChanged(object sender, EventArgs e)
		{
			this.GridEX1.GetRow().Cells["mablagh"].Value = RuntimeHelpers.GetObjectValue(this.txt_shCheck.SelectedRow["Mablagh"]);
			this.GridEX1.GetRow().Cells["mablagh"].Text = Strings.FormatNumber(RuntimeHelpers.GetObjectValue(this.txt_shCheck.SelectedRow["Mablagh"]), 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0019002C File Offset: 0x0018E22C
		private void txt_shCheck_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_shCheck.Value != null;
				if (flag2)
				{
					((DataRowView)this.GridEX1.GetRow().DataRow)[""] = this.txt_shCheck.Text;
					((DataRowView)this.GridEX1.GetRow().DataRow)[""] = RuntimeHelpers.GetObjectValue(this.txt_shCheck.Value);
				}
			}
		}

		// Token: 0x04000CE6 RID: 3302
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000CE8 RID: 3304
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04000CE9 RID: 3305
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000CEA RID: 3306
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000CEB RID: 3307
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000CEC RID: 3308
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000CED RID: 3309
		[AccessedThroughProperty("group_dnaghd")]
		private UIGroupBox _group_dnaghd;

		// Token: 0x04000CEE RID: 3310
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000CEF RID: 3311
		[AccessedThroughProperty("txt_babat")]
		private EditBox _txt_babat;

		// Token: 0x04000CF0 RID: 3312
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000CF1 RID: 3313
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000CF2 RID: 3314
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000CF3 RID: 3315
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000CF4 RID: 3316
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000CF5 RID: 3317
		[AccessedThroughProperty("GridSize1")]
		private GridSize _GridSize1;

		// Token: 0x04000CF6 RID: 3318
		[AccessedThroughProperty("Panel1")]
		private PanelEx _Panel1;

		// Token: 0x04000CF7 RID: 3319
		[AccessedThroughProperty("group_checkmoshtari")]
		private UIGroupBox _group_checkmoshtari;

		// Token: 0x04000CF8 RID: 3320
		[AccessedThroughProperty("txt_sarresid")]
		private DateBox2 _txt_sarresid;

		// Token: 0x04000CF9 RID: 3321
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000CFA RID: 3322
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000CFB RID: 3323
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000CFC RID: 3324
		[AccessedThroughProperty("txt_babatcheck")]
		private EditBox _txt_babatcheck;

		// Token: 0x04000CFD RID: 3325
		[AccessedThroughProperty("group_dfish")]
		private UIGroupBox _group_dfish;

		// Token: 0x04000CFE RID: 3326
		[AccessedThroughProperty("txt_shfish")]
		private NumericBox _txt_shfish;

		// Token: 0x04000CFF RID: 3327
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000D00 RID: 3328
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000D01 RID: 3329
		[AccessedThroughProperty("txt_fishbabat")]
		private EditBox _txt_fishbabat;

		// Token: 0x04000D02 RID: 3330
		[AccessedThroughProperty("txt_fishbank")]
		private SelectItem _txt_fishbank;

		// Token: 0x04000D03 RID: 3331
		[AccessedThroughProperty("txt_fishtarikh")]
		private DateBox2 _txt_fishtarikh;

		// Token: 0x04000D04 RID: 3332
		[AccessedThroughProperty("txt_fishbankhesab")]
		private SelectItem _txt_fishbankhesab;

		// Token: 0x04000D05 RID: 3333
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000D06 RID: 3334
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000D07 RID: 3335
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000D08 RID: 3336
		[AccessedThroughProperty("txt_shCheck")]
		private SelectItem _txt_shCheck;

		// Token: 0x04000D09 RID: 3337
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000D0A RID: 3338
		[AccessedThroughProperty("txt_checkHesabBanki")]
		private SelectItem _txt_checkHesabBanki;

		// Token: 0x04000D0B RID: 3339
		[AccessedThroughProperty("lbl_sarresid")]
		private Label _lbl_sarresid;

		// Token: 0x04000D0C RID: 3340
		[AccessedThroughProperty("Group_Dastecheck")]
		private UIGroupBox _Group_Dastecheck;

		// Token: 0x04000D0D RID: 3341
		[AccessedThroughProperty("txt_babatcheckd")]
		private EditBox _txt_babatcheckd;

		// Token: 0x04000D0E RID: 3342
		[AccessedThroughProperty("txt_mablaghd")]
		private CurrencyBox _txt_mablaghd;

		// Token: 0x04000D0F RID: 3343
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000D10 RID: 3344
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000D11 RID: 3345
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000D12 RID: 3346
		[AccessedThroughProperty("txt_shdcheck")]
		private NumericBox _txt_shdcheck;

		// Token: 0x04000D13 RID: 3347
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000D14 RID: 3348
		private DaryaftPardakht dp;

		// Token: 0x04000D15 RID: 3349
		private Frm_SelectItem frm;

		// Token: 0x04000D16 RID: 3350
		private Sanad Sanad;

		// Token: 0x04000D17 RID: 3351
		private bool prevent;
	}
}
