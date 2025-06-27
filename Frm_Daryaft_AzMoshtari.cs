using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Validator;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x020000E4 RID: 228
	[DesignerGenerated]
	public partial class Frm_Daryaft_AzMoshtari : Form
	{
		// Token: 0x06001522 RID: 5410 RVA: 0x000E43A8 File Offset: 0x000E25A8
		public Frm_Daryaft_AzMoshtari()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_Daryaft_AzMoshtari.__ENCAddToList(this);
			this.frm_hesabBanki = new Frm_SelectItem();
			this.frmCheck_Select = new Frm_SelectItem();
			string empty = string.Empty;
			this.Kart_be_Kart_ID = empty;
			this.dp = new DaryaftPardakht();
			this.sanad = new Sanad();
			this.prevent = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.notin = string.Empty;
			this.Notin_Pardakht = string.Empty;
			this.daryaft = new DaryaftPardakht();
			this.InitializeComponent();
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000E4478 File Offset: 0x000E2678
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Daryaft_AzMoshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Daryaft_AzMoshtari.__ENCList.Count == Frm_Daryaft_AzMoshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Daryaft_AzMoshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Daryaft_AzMoshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Daryaft_AzMoshtari.__ENCList[num] = Frm_Daryaft_AzMoshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Daryaft_AzMoshtari.__ENCList.RemoveRange(num, Frm_Daryaft_AzMoshtari.__ENCList.Count - num);
						Frm_Daryaft_AzMoshtari.__ENCList.Capacity = Frm_Daryaft_AzMoshtari.__ENCList.Count;
					}
					Frm_Daryaft_AzMoshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x000E6ED0 File Offset: 0x000E50D0
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x000E6EE8 File Offset: 0x000E50E8
		internal virtual GridEX GridEX1
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				EventHandler value3 = new EventHandler(this.gridex3_RecordAdded);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EventHandler value5 = new EventHandler(this.GridEX1_RecordAdded);
				KeyEventHandler value6 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.RecordAdded -= value3;
					this._GridEX1.KeyPress -= value4;
					this._GridEX1.RecordAdded -= value5;
					this._GridEX1.KeyDown -= value6;
					this._GridEX1.CellEdited -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.RecordAdded += value3;
					this._GridEX1.KeyPress += value4;
					this._GridEX1.RecordAdded += value5;
					this._GridEX1.KeyDown += value6;
					this._GridEX1.CellEdited += value7;
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x000E701C File Offset: 0x000E521C
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x00006A7A File Offset: 0x00004C7A
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
				this._txt_mablagh = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x000E7034 File Offset: 0x000E5234
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x000E704C File Offset: 0x000E524C
		internal virtual GridEX GridEX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				InitCustomEditEventHandler value2 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value3 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX2_KeyPress);
				EventHandler value5 = new EventHandler(this.gridex3_RecordAdded);
				EventHandler value6 = new EventHandler(this.GridEX1_RecordAdded);
				KeyEventHandler value7 = new KeyEventHandler(this.GridEX2_KeyDown);
				ColumnActionEventHandler value8 = new ColumnActionEventHandler(this.GridEX2_ColumnButtonClick);
				ColumnActionEventHandler value9 = new ColumnActionEventHandler(this.GridEX2_CellEdited);
				EventHandler value10 = new EventHandler(this.GridEX2_RecordAdded);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.InitCustomEdit -= value2;
					this._GridEX2.EndCustomEdit -= value3;
					this._GridEX2.KeyPress -= value4;
					this._GridEX2.RecordAdded -= value5;
					this._GridEX2.RecordAdded -= value6;
					this._GridEX2.KeyDown -= value7;
					this._GridEX2.ColumnButtonClick -= value8;
					this._GridEX2.CellEdited -= value9;
					this._GridEX2.RecordAdded -= value10;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.InitCustomEdit += value2;
					this._GridEX2.EndCustomEdit += value3;
					this._GridEX2.KeyPress += value4;
					this._GridEX2.RecordAdded += value5;
					this._GridEX2.RecordAdded += value6;
					this._GridEX2.KeyDown += value7;
					this._GridEX2.ColumnButtonClick += value8;
					this._GridEX2.CellEdited += value9;
					this._GridEX2.RecordAdded += value10;
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x000E7200 File Offset: 0x000E5400
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x00006A84 File Offset: 0x00004C84
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

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x000E7218 File Offset: 0x000E5418
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x000E7230 File Offset: 0x000E5430
		internal virtual DateBox2 txt_tarikhGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikhGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateBox2.OnRightEventHandler obj = new DateBox2.OnRightEventHandler(this.txt_tarikhGrid_OnRight);
				bool flag = this._txt_tarikhGrid != null;
				if (flag)
				{
					this._txt_tarikhGrid.OnRight -= obj;
				}
				this._txt_tarikhGrid = value;
				flag = (this._txt_tarikhGrid != null);
				if (flag)
				{
					this._txt_tarikhGrid.OnRight += obj;
				}
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000E7290 File Offset: 0x000E5490
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x00006A8E File Offset: 0x00004C8E
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x000E72A8 File Offset: 0x000E54A8
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x000E72C0 File Offset: 0x000E54C0
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

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000E7320 File Offset: 0x000E5520
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x00006A98 File Offset: 0x00004C98
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

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000E7338 File Offset: 0x000E5538
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00006AA2 File Offset: 0x00004CA2
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000E7350 File Offset: 0x000E5550
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x00006AAC File Offset: 0x00004CAC
		internal virtual LabelCommand lbl_jamcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_jamcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_jamcheck = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000E7368 File Offset: 0x000E5568
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00006AB6 File Offset: 0x00004CB6
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

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000E7380 File Offset: 0x000E5580
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x00006AC0 File Offset: 0x00004CC0
		internal virtual LabelCommand lbl_jamkol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_jamkol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_jamkol = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000E7398 File Offset: 0x000E5598
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x00006ACA File Offset: 0x00004CCA
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

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000E73B0 File Offset: 0x000E55B0
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x00006AD4 File Offset: 0x00004CD4
		internal virtual LabelCommand lbl_codem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_codem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_codem = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000E73C8 File Offset: 0x000E55C8
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x00006ADE File Offset: 0x00004CDE
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x000E73E0 File Offset: 0x000E55E0
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00006AE8 File Offset: 0x00004CE8
		internal virtual LabelCommand lbl_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_name = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000E73F8 File Offset: 0x000E55F8
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x00006AF2 File Offset: 0x00004CF2
		internal virtual LabelCommand LabelCommand9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand9 = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x000E7410 File Offset: 0x000E5610
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x00006AFC File Offset: 0x00004CFC
		internal virtual LabelCommand LabelCommand10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand10 = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x000E7428 File Offset: 0x000E5628
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00006B06 File Offset: 0x00004D06
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x000E7440 File Offset: 0x000E5640
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00006B10 File Offset: 0x00004D10
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

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x000E7458 File Offset: 0x000E5658
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x00006B1A File Offset: 0x00004D1A
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

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000E7470 File Offset: 0x000E5670
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x000E7488 File Offset: 0x000E5688
		internal virtual CurrencyBox txt_mablagh_BeMoshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh_BeMoshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_cart_ButtonClick);
				CancelEventHandler value3 = new CancelEventHandler(this.txt_cart_Validating);
				bool flag = this._txt_mablagh_BeMoshtari != null;
				if (flag)
				{
					this._txt_mablagh_BeMoshtari.ButtonClick -= value2;
					this._txt_mablagh_BeMoshtari.Validating -= value3;
				}
				this._txt_mablagh_BeMoshtari = value;
				flag = (this._txt_mablagh_BeMoshtari != null);
				if (flag)
				{
					this._txt_mablagh_BeMoshtari.ButtonClick += value2;
					this._txt_mablagh_BeMoshtari.Validating += value3;
				}
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x000E7510 File Offset: 0x000E5710
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x00006B24 File Offset: 0x00004D24
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000E7528 File Offset: 0x000E5728
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x00006B2E File Offset: 0x00004D2E
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

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000E7540 File Offset: 0x000E5740
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00006B38 File Offset: 0x00004D38
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

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000E7558 File Offset: 0x000E5758
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00006B42 File Offset: 0x00004D42
		internal virtual EditBox txt_babat_kart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_kart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_babat_kart = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000E7570 File Offset: 0x000E5770
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00006B4C File Offset: 0x00004D4C
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

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x000E7588 File Offset: 0x000E5788
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x00006B56 File Offset: 0x00004D56
		internal virtual EditBox txt_moshtari
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
				this._txt_moshtari = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x000E75A0 File Offset: 0x000E57A0
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00006B60 File Offset: 0x00004D60
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x000E75B8 File Offset: 0x000E57B8
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x000E75D0 File Offset: 0x000E57D0
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
				EventHandler value2 = new EventHandler(this.txt_naghd_ButtonClick);
				bool flag = this._txt_naghd != null;
				if (flag)
				{
					this._txt_naghd.ButtonClick -= value2;
				}
				this._txt_naghd = value;
				flag = (this._txt_naghd != null);
				if (flag)
				{
					this._txt_naghd.ButtonClick += value2;
				}
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x000E7630 File Offset: 0x000E5830
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00006B6A File Offset: 0x00004D6A
		internal virtual EditBox EditBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox2 = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000E7648 File Offset: 0x000E5848
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00006B74 File Offset: 0x00004D74
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

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x000E7660 File Offset: 0x000E5860
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00006B7E File Offset: 0x00004D7E
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x000E7678 File Offset: 0x000E5878
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00006B88 File Offset: 0x00004D88
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

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000E7690 File Offset: 0x000E5890
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00006B92 File Offset: 0x00004D92
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

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000E76A8 File Offset: 0x000E58A8
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00006B9C File Offset: 0x00004D9C
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

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000E76C0 File Offset: 0x000E58C0
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00006BA6 File Offset: 0x00004DA6
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

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000E76D8 File Offset: 0x000E58D8
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00006BB0 File Offset: 0x00004DB0
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

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000E76F0 File Offset: 0x000E58F0
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00006BBA File Offset: 0x00004DBA
		internal virtual GridEX GridEX3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEX3 = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x000E7708 File Offset: 0x000E5908
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00006BC4 File Offset: 0x00004DC4
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
				this._UiButton2 = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x000E7720 File Offset: 0x000E5920
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00006BCE File Offset: 0x00004DCE
		internal virtual GridEX GridEX4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEX4 = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x000E7738 File Offset: 0x000E5938
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00006BD8 File Offset: 0x00004DD8
		internal virtual DateBox2 DateBox21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateBox21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DateBox21 = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x000E7750 File Offset: 0x000E5950
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00006BE2 File Offset: 0x00004DE2
		internal virtual SelectItem txt_beMoshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_beMoshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_beMoshtari = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x000E7768 File Offset: 0x000E5968
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00006BEC File Offset: 0x00004DEC
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x000E7780 File Offset: 0x000E5980
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x00006BF6 File Offset: 0x00004DF6
		public string Tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tozih;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tozih = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x000E7798 File Offset: 0x000E5998
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x00006C00 File Offset: 0x00004E00
		public DataTable Pardakht_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Table = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x000E77B0 File Offset: 0x000E59B0
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x00006C0A File Offset: 0x00004E0A
		public List<listCheckDaryaft> ListDaryaft_Identity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListDaryaft_Identity;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ListDaryaft_Identity = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000E77C8 File Offset: 0x000E59C8
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x00006C14 File Offset: 0x00004E14
		public long Mablagh_Kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mablagh_Kol;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mablagh_Kol = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000E77E0 File Offset: 0x000E59E0
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x00006C1E File Offset: 0x00004E1E
		public int HazineKharid_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HazineKharid_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HazineKharid_ID = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x000E77F8 File Offset: 0x000E59F8
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x00006C28 File Offset: 0x00004E28
		public string HazineKharid_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HazineKharid_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HazineKharid_Name = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x000E7810 File Offset: 0x000E5A10
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x00006C32 File Offset: 0x00004E32
		public string Moshtari_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_Name = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000E7828 File Offset: 0x000E5A28
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x00006C3C File Offset: 0x00004E3C
		public string Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000E7840 File Offset: 0x000E5A40
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00006C46 File Offset: 0x00004E46
		public string Pardakht_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_ID = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000E7858 File Offset: 0x000E5A58
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00006C50 File Offset: 0x00004E50
		public string Kart_be_Kart_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kart_be_Kart_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kart_be_Kart_ID = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000E7870 File Offset: 0x000E5A70
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x00006C5A File Offset: 0x00004E5A
		public DataTable dt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt = value;
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000E7888 File Offset: 0x000E5A88
		private bool ValidateCurrentGridRow(int row)
		{
			bool flag = row == -1;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				flag = (Operators.CompareString(this.GridEX2.GetRow(row).Cells["mablagh"].Value.ToString(), string.Empty, false) == 0);
				if (flag)
				{
					Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Mablagh", "مبلغ چک را وارد کنید");
					result = false;
				}
				else
				{
					flag = (Operators.CompareString(this.GridEX2.GetRow(row).Cells["Sh_Check"].Value.ToString(), string.Empty, false) == 0);
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Sh_Check", "شماره چک را وارد کنید");
						result = false;
					}
					else
					{
						flag = (Operators.CompareString(this.GridEX2.GetRow(row).Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
							result = false;
						}
						else
						{
							flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(this.GridEX2.GetRow(row).Cells["Check_Sarresid_Fa"].Value));
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
								result = false;
							}
							else
							{
								flag = (this.GridEX2.GetRow(row).Cells["BankHesab_Id"].Value == DBNull.Value);
								if (flag)
								{
									Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "BankHesab_Name", "حساب بانکی را مشخص فرمائید");
									result = false;
								}
								else
								{
									result = true;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x000E7A78 File Offset: 0x000E5C78
		private bool ValidateGrid()
		{
			this.GridEX1.UpdateData();
			this.GridEX2.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX2.DataSource;
			int i = 0;
			bool flag = dataTable == null;
			checked
			{
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i].RowState == DataRowState.Deleted);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = (dataTable.Rows[i]["CheckBarg_ID"] == DBNull.Value && dataTable.Rows[i]["BankHesab_ID"] == DBNull.Value);
							if (flag)
							{
								dataTable.Rows[i].Delete();
								i--;
							}
							i++;
						}
					}
					dataTable.AcceptChanges();
					GridEXRow[] rows = this.GridEX2.GetRows();
					for (int j = 0; j < rows.Length; j++)
					{
						GridEXRow gridEXRow = rows[j];
						flag = (Operators.CompareString(gridEXRow.Cells["mablagh"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Mablagh", "مبلغ چک را وارد کنید");
							result = false;
							return result;
						}
						flag = (Operators.CompareString(gridEXRow.Cells["Sh_Check"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Sh_Check", "شماره چک را وارد کنید");
							result = false;
							return result;
						}
						flag = (Operators.CompareString(gridEXRow.Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
							result = false;
							return result;
						}
						flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(gridEXRow.Cells["Check_Sarresid_Fa"].Value));
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
							result = false;
							return result;
						}
						flag = (gridEXRow.Cells["BankHesab_Id"].Value == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "BankHesab_Name", "حساب بانکی را مشخص فرمائید");
							result = false;
							return result;
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		private bool Check_SayerAmaliyat(long id, string Tarikh)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from daryaftpardakht where pardakhtcheck_id=" + Conversions.ToString(id) + " and tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))));
			bool flag = num == 0;
			return !flag;
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000E7D10 File Offset: 0x000E5F10
		public long Sum_Mablagh()
		{
			long? value = this.txt_naghd.Value;
			bool hasValue = value.HasValue;
			checked
			{
				long? value3;
				long num;
				if (hasValue)
				{
					long? value2 = this.txt_naghd.Value;
					long? arg_4E_0;
					if (!value2.HasValue)
					{
						arg_4E_0 = null;
					}
					else
					{
						value3 = new long?(num + value2.GetValueOrDefault());
						arg_4E_0 = value3;
					}
					num = (T)arg_4E_0;
				}
				value3 = this.txt_mablagh_BeMoshtari.Value;
				hasValue = value3.HasValue;
				if (hasValue)
				{
					long? value2 = this.txt_mablagh_BeMoshtari.Value;
					long? arg_A2_0;
					if (!value2.HasValue)
					{
						arg_A2_0 = null;
					}
					else
					{
						value = new long?(num + value2.GetValueOrDefault());
						arg_A2_0 = value;
					}
					num = (T)arg_A2_0;
				}
				num = (long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "Mablagh"))));
				num = (long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX2.DataSource, "Mablagh"))));
				return num;
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000E7E20 File Offset: 0x000E6020
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT  DaryaftPardakht.*, Moshtari.Name+' '+ Moshtari.Family as Be_Moshtari_Name  FROM    DaryaftPardakht LEFT OUTER JOIN  Moshtari ON DaryaftPardakht.beMoshtari_ID = Moshtari.ID  WHERE  (DaryaftPardakht.Tarikh = ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				")  AND (DaryaftPardakht.Moshtari_ID = ",
				this.Moshtari_ID,
				") "
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 4, false);
					int? num;
					if (flag)
					{
						object expr_94 = dataRow["id"];
						this.Daryaft_Naghd_ID = ((expr_94 != null) ? ((int?)expr_94) : num);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 1, false);
					if (flag)
					{
						this.txt_naghd.Text = Conversions.ToString(dataRow["mablagh"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 39, false);
					if (flag)
					{
						object expr_111 = dataRow["id"];
						this.Pardakht_BeMoshtari_ID = ((expr_111 != null) ? ((int?)expr_111) : num);
						this.txt_mablagh_BeMoshtari.Text = Conversions.ToString(dataRow["mablagh"]);
						this.txt_beMoshtari.SetValue(Conversions.ToString(dataRow["Be_Moshtari_Name"]), RuntimeHelpers.GetObjectValue(dataRow["bemoshtari_id"]));
					}
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
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000E7FF0 File Offset: 0x000E61F0
		private bool Save_Daryafti()
		{
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @pardakht_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;declare @codehesab_id2 int;";
			bool arg_66_0;
			if (this.txt_naghd.Value.HasValue)
			{
				long num = 0L;
				long? value = this.txt_naghd.Value;
				bool? arg_57_0;
				if (!value.HasValue)
				{
					arg_57_0 = null;
				}
				else
				{
					bool? flag = new bool?(value.GetValueOrDefault() == num);
					arg_57_0 = flag;
				}
				bool? flag2 = arg_57_0;
				if (!flag2.GetValueOrDefault())
				{
					arg_66_0 = false;
					goto IL_65;
				}
			}
			arg_66_0 = true;
			IL_65:
			bool flag3 = arg_66_0;
			bool flag4;
			if (flag3)
			{
				flag4 = this.Daryaft_Naghd_ID.HasValue;
				if (flag4)
				{
					this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Daryaft_Naghd_ID), "", "", "");
				}
			}
			else
			{
				text += this.daryaft.AddRowStrNaghdMoshtari(this.Tarikh, this.Moshtari_ID, Conversions.ToString((T)this.txt_naghd.Value), "دریافت نقد", this.Daryaft_Naghd_ID.ToString());
			}
			Public_Function.ExecuteNonQuery(text);
			text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @pardakht_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;declare @codehesab_id2 int;";
			bool arg_162_0;
			if (this.txt_mablagh_BeMoshtari.Value.HasValue)
			{
				long num = 0L;
				long? value2 = this.txt_mablagh_BeMoshtari.Value;
				bool? arg_152_0;
				if (!value2.HasValue)
				{
					arg_152_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(value2.GetValueOrDefault() == num);
					arg_152_0 = flag2;
				}
				bool? flag = arg_152_0;
				if (!flag.GetValueOrDefault())
				{
					arg_162_0 = false;
					goto IL_161;
				}
			}
			arg_162_0 = true;
			IL_161:
			flag4 = arg_162_0;
			bool result;
			if (flag4)
			{
				flag3 = this.Pardakht_BeMoshtari_ID.HasValue;
				if (flag3)
				{
					this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Pardakht_BeMoshtari_ID), "", "", "");
				}
			}
			else
			{
				flag4 = (this.txt_beMoshtari.Value == null);
				if (flag4)
				{
					this.txt_beMoshtari.ShowTip("مشتری را وارد نمایید");
					result = false;
					return result;
				}
				text += this.daryaft.AddRowStr_Moshtari_beMoshtari(this.Tarikh, this.Moshtari_ID, Conversions.ToString(this.txt_beMoshtari.Value), Conversions.ToString((T)this.txt_mablagh_BeMoshtari.Value), "مشتری به مشتری", this.Pardakht_BeMoshtari_ID.ToString());
			}
			Public_Function.ExecuteNonQuery(text);
			result = true;
			return result;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000E8238 File Offset: 0x000E6438
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.Save_Daryafti();
			if (flag)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000E8260 File Offset: 0x000E6460
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.Check_Print();
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x000E829C File Offset: 0x000E649C
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.Text = this.Moshtari_Name;
			this.Text = this.Text + " " + this.Moshtari_Name;
			ItemCollection itemCollection = new ItemCollection();
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm_hesabBanki.items = itemCollection;
			itemCollection2.Add(new Column("Sh_Check", "شماره چک ", 15));
			itemCollection2.Add(new Column("Mablagh", "مبلغ", 15));
			itemCollection2.Add(new Column("Bank_Name", "بانک", 10));
			itemCollection2.Add(new Column("Check_Shobe", "شعبه", 15));
			itemCollection2.Add(new Column("Check_ShomareHesab", "شماره حساب", 15));
			itemCollection2.Add(new Column("Moshtari_Name", "پرداخت کننده", 20));
			itemCollection2.Add(new Column("Check_Sarresid_Fa", "سررسید", 10));
			this.frmCheck_Select.items = itemCollection2;
			this.LoadData();
			this.GetSum();
			this.GridEX2.MoveToNewRecord();
			this.GridEX2.Col = 0;
			this.GridEX2.EditMode = EditMode.EditOn;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000E83F4 File Offset: 0x000E65F4
		private object Contains_In_List(int Operation_ID, int PardakhtCheck_ID)
		{
			object result;
			try
			{
				List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
				while (enumerator.MoveNext())
				{
					listCheckDaryaft current = enumerator.Current;
					bool flag = current.Operation_id == Operation_ID && current.PardakhtCheck_ID == PardakhtCheck_ID;
					if (flag)
					{
						result = true;
						return result;
					}
				}
			}
			finally
			{
				List<listCheckDaryaft>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			result = false;
			return result;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000E8478 File Offset: 0x000E6678
		public void Check_Select()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
			text = Public_Function.RemoveLast(text);
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " AND DaryaftPardakht.ID NOT IN(" + text + ")";
			}
			DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=",
				Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
				text,
				this.notin,
				" order by DaryaftPardakht.Check_Sarresid"
			}));
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			flag = (this.frmCheck_Select.ShowDialog(dataTable2, null, "پرداخت چک - انتخاب چک") == DialogResult.OK);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectGreater(this.frmCheck_Select.SelectedRow["Mablagh"], this.txt_naghd.Value, false);
				if (flag2)
				{
					Public_Function.ShowMessage("مبلغ چک بیشتر از مبلغ کل میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				}
				else
				{
					this.prevent = true;
					flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null);
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
						this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
						this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
						this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
						this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
						this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
						this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["ID"]);
						this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
						flag2 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
						if (flag2)
						{
							flag = (this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value);
							if (flag)
							{
								this.ListDaryaft_Identity.Add(new listCheckDaryaft
								{
									Operation_id = 12,
									Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
								});
							}
							else
							{
								this.ListDaryaft_Identity.Add(new listCheckDaryaft
								{
									Operation_id = 12,
									PardakhtCheck_ID = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["PardakhtCheck_ID"])
								});
							}
						}
						this.GridEX1.UpdateData();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000E8940 File Offset: 0x000E6B40
		private void BankHesab_Select()
		{
			string command = "SELECT        Bank_Hesab.ID, Bank.Name + ' - ' + Bank_Hesab.Shobe AS Name  FROM            Bank_Hesab INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID";
			bool flag = this.frm_hesabBanki.ShowDialog(command, MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX2.Col == this.GridEX2.RootTable.Columns["BankHesab_Name"].Position && this.GridEX2.EditTextBox != null;
					if (flag2)
					{
						this.GridEX2.EditTextBox.Text = Conversions.ToString(this.frm_hesabBanki.SelectedRow["Name"]);
						this.GridEX2.GetRow().Cells["BankHesab_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm_hesabBanki.SelectedRow["ID"]);
						GridEX gridEX = this.GridEX2;
						gridEX.Col++;
						this.GridEX2.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000E8A48 File Offset: 0x000E6C48
		private void Shobe_Select()
		{
			DataTable dt = Public_Function.FillData("select distinct Check_shobe as name  from daryaftpardakht where Check_Shobe is not null");
			bool flag = this.frm_hesabBanki.ShowDialog(dt, null, "انتخاب شعبه") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm_hesabBanki.SelectedRow["Name"]);
						GridEX gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x000E8B04 File Offset: 0x000E6D04
		private void GetSum()
		{
			long num = 0L;
			int arg_13_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_13_0;
				while (true)
				{
					int arg_83_0 = num3;
					int num4 = num2;
					if (arg_83_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX1.GetRow(num3).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToLong(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells["Mablagh"].Value));
					}
					num3++;
				}
				int arg_95_0 = 0;
				int num5 = this.GridEX2.RowCount - 1;
				int num6 = arg_95_0;
				while (true)
				{
					int arg_106_0 = num6;
					int num4 = num5;
					if (arg_106_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX2.GetRow(num6).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToLong(Operators.AddObject(num, this.GridEX2.GetRow(num6).Cells["Mablagh"].Value));
					}
					num6++;
				}
				this.lbl_jamcheck.Text = Public_Function.ToFarsi(Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True));
			}
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000E8C3C File Offset: 0x000E6E3C
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "sh_check", false) == 0;
			if (flag)
			{
				this.GetSum();
				flag = (this.GridEX1.CurrentRow.Cells["mablagh"].Value != null);
				if (flag)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.SubtractObject(txt_naghd.Text, this.GridEX1.CurrentRow.Cells["mablagh"].Value));
				}
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000E8CDC File Offset: 0x000E6EDC
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 18,
				Daryaft_Identity = value
			});
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x000E8D10 File Offset: 0x000E6F10
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataRowView dataRowView = (DataRowView)row.DataRow;
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			if (flag)
			{
				string text = ((DataRowView)row.DataRow)["PardakhtCheck_ID"].ToString();
				string text2 = string.Empty;
				long value = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
				DataRow dataRow = Public_Function.FillDataRow("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + Conversions.ToString(value) + ")");
				text2 = text2 + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + Conversions.ToString(value) + ");";
				text2 = text2 + "delete from daryaftpardakht where id in(" + Conversions.ToString(value) + ");";
				flag = (dataRow["sanadbed_id"] != DBNull.Value);
				if (flag)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbed_id"]), ");")));
				}
				flag = (dataRow["sanadbes_id"] != DBNull.Value);
				if (flag)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbes_id"]), ");")));
				}
				Public_Function.ExecuteNonQuery(text2);
				flag = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag)
				{
					text2 = "declare @st int;";
					text2 = text2 + "select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=" + text + " order by id desc;";
					text2 += "if @st is null set @st=1;";
					text2 = text2 + "update daryaftpardakht set check_status=@st where id=" + text + ";";
					Public_Function.ExecuteNonQuery(text2);
				}
				try
				{
					IEnumerator enumerator = this.dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						flag = (dataRow2["ID"] != DBNull.Value);
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["ID"], NewLateBinding.LateIndexGet(row.DataRow, new object[]
							{
								"ID"
							}, null), false);
							if (flag2)
							{
								dataRow2.Delete();
								this.dt.AcceptChanges();
								break;
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
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0000205D File Offset: 0x0000025D
		private void GetChackeUsageInPardakhtForPardakht(GridEXRow row, DataTable dt2)
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000E8FB0 File Offset: 0x000E71B0
		private bool GetDasteCheckUsage(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = ((DataRowView)row.DataRow)["CheckBarg_ID"] != DBNull.Value;
			if (flag)
			{
				text = Conversions.ToString(((DataRowView)row.DataRow)["CheckBarg_ID"]);
			}
			else
			{
				text = "-1";
			}
			string text3 = string.Empty;
			flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
			if (flag)
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(" AND DaryaftPardakht.ID>", ((DataRowView)row.DataRow)["ID"]));
				text2 = Conversions.ToString(((DataRowView)row.DataRow)["ID"]);
			}
			else
			{
				text2 = "-1";
			}
			dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Sh_Check, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type=2 and DaryaftPardakht.CheckBarg_ID in(",
				text,
				") AND DaryaftPardakht.ID Not IN(",
				text2,
				")",
				text3
			}));
			flag = (dataTable.Rows.Count > 0);
			bool result;
			if (flag)
			{
				new Frm_DeleteDaryaftPardakht
				{
					ListDaryaft_Identity = this.ListDaryaft_Identity,
					dt_opr = dataTable
				}.ShowDialog();
				result = false;
			}
			else
			{
				this.DeletePardakhtRedif(row);
				result = true;
			}
			return result;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000E9128 File Offset: 0x000E7328
		private void GetCheckUsagePardakht(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = ((DataRowView)row.DataRow)["pardakhtcheck_id"] != DBNull.Value;
			if (flag)
			{
				text = Conversions.ToString(((DataRowView)row.DataRow)["pardakhtcheck_id"]);
			}
			else
			{
				text = "-1";
			}
			string text3 = string.Empty;
			flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
			if (flag)
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(" AND DaryaftPardakht.ID>", ((DataRowView)row.DataRow)["ID"]));
				text2 = Conversions.ToString(((DataRowView)row.DataRow)["ID"]);
			}
			else
			{
				text2 = "-1";
			}
			dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Sh_Check, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type=2 and DaryaftPardakht.pardakhtcheck_id in(",
				text,
				") AND DaryaftPardakht.ID Not IN(",
				text2,
				")",
				text3
			}));
			this.GetChackeUsageInPardakhtForPardakht(row, dataTable);
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				new Frm_DeleteDaryaftPardakht
				{
					ListDaryaft_Identity = this.ListDaryaft_Identity,
					dt_opr = dataTable
				}.ShowDialog();
			}
			else
			{
				flag = (Public_Function.ShowMessage("آیا مایل به حذف ردیف مورد نظر میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag)
				{
					this.DeletePardakhtRedif(row);
					flag = (this.GridEX1.CurrentRow.RowType == RowType.Record);
					if (flag)
					{
						bool flag2 = this.GridEX1.GetRow().Cells["daryaft_identity"].Value != DBNull.Value;
						if (flag2)
						{
							this.Delete_Listdaryaft(Conversions.ToInteger(this.GridEX1.GetRow().Cells["daryaft_identity"].Value));
						}
						this.Update_MablaghNaghd(this.GridEX1.CurrentRow);
						CurrencyBox txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX1.CurrentRow.Cells["mablagh"].Value));
						this.GridEX1.CurrentRow.Delete();
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						this.GetSum();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000E93D8 File Offset: 0x000E75D8
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				this.Check_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
				if (flag)
				{
					this.BankHesab_Select();
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["check_shobe"].Position);
					if (flag)
					{
						this.Shobe_Select();
					}
					else
					{
						flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
						if (flag)
						{
							bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
							if (flag2)
							{
								this.GetCheckUsagePardakht(this.GridEX1.CurrentRow);
							}
							flag2 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
							if (flag2)
							{
								this.GridEX1.CancelCurrentEdit();
								this.GetSum();
							}
						}
					}
				}
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000E9508 File Offset: 0x000E7708
		private void Daste_Check_Select()
		{
			Frm_SelectDasteCheck frm_SelectDasteCheck = new Frm_SelectDasteCheck();
			bool flag = this.GridEX2.CurrentRow.Cells["CheckBarg_ID"].Value != DBNull.Value;
			if (flag)
			{
				Frm_SelectDasteCheck arg_68_0 = frm_SelectDasteCheck;
				object expr_56 = this.GridEX2.CurrentRow.Cells["CheckBarg_ID"].Value;
				int? num;
				arg_68_0.ID = ((expr_56 != null) ? ((int?)expr_56) : num);
			}
			string text = string.Empty;
			GridEXRow[] rows = this.GridEX2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (gridEXRow.Cells["Checkbarg_id"].Value != DBNull.Value);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(gridEXRow.Cells["Checkbarg_id"].Value, ",")));
					}
				}
				text = Public_Function.RemoveLast(text);
				frm_SelectDasteCheck.Notin_Me = text;
				frm_SelectDasteCheck.Notin_Pardakht = this.Notin_Pardakht;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SelectDasteCheck);
				flag = (frm_SelectDasteCheck.ShomareBarg != null);
				if (flag)
				{
					this.GridEX2.CurrentRow.Cells["Sh_Check"].Value = frm_SelectDasteCheck.ShomareBarg;
					this.GridEX2.CurrentRow.Cells["CheckBarg_ID"].Value = frm_SelectDasteCheck.ID;
					this.GridEX2.CurrentRow.Cells["BankHesab_Name"].Value = frm_SelectDasteCheck.BankHesab_Name;
					this.GridEX2.CurrentRow.Cells["BankHesab_ID"].Value = frm_SelectDasteCheck.BankHesab_ID;
					GridEX gridEX = this.GridEX2;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000E9708 File Offset: 0x000E7908
		private void Update_MablaghNaghd(GridEXRow row)
		{
			bool flag = ((DataRowView)row.DataRow)["parent_id"] == DBNull.Value;
			if (!flag)
			{
				string text = "declare @id int;declare @sanadbed_id int;declare @mablagh bigint;";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" select @id=id,@sanadbed_id=sanadbed_id from daryaftpardakht  where parent_id=", ((DataRowView)row.DataRow)["parent_id"]), " and dptype_id=10;")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update daryaftpardakht set mablagh=mablagh+", row.Cells["mablagh"].Value), " where id=@id;")));
				text += "select @mablagh=mablagh from daryaftpardakht where id=@id;";
				text += " update sanad set bed=@mablagh where id=@sanadbed_id;";
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000E97CC File Offset: 0x000E79CC
		private void Update_MablaghNaghd(string Parent_id, string Mablagh)
		{
			string text = "declare @id int;declare @sanadbed_id int;declare @mablagh bigint;";
			text = text + " select @id=id,@sanadbed_id=sanadbed_id from daryaftpardakht  where parent_id=" + Parent_id + " and dptype_id=10;";
			text = text + " update daryaftpardakht set mablagh=mablagh+" + Mablagh + " where id=@id;";
			text += "select @mablagh=mablagh from daryaftpardakht where id=@id;";
			text += " update sanad set bed=@mablagh where id=@sanadbed_id;";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000E9824 File Offset: 0x000E7A24
		private void Del_CheckBarg()
		{
			int value = Conversions.ToInteger(((DataRowView)this.GridEX2.CurrentRow.DataRow)["ID"]);
			string text = "declare @sanadbed_id int,@sanadbes_id int;select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=" + Conversions.ToString(value) + ";";
			text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id=" + Conversions.ToString(value);
			text += "delete from sanad where id=@sanadbed_id;";
			text += "delete from sanad where id=@sanadbes_id;";
			text = text + "delete from daryaftpardakht where id=" + Conversions.ToString(value);
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000E98B4 File Offset: 0x000E7AB4
		private void Del_DasteCheck()
		{
			bool flag = this.GridEX2.CurrentRow.RowType == RowType.Record;
			bool flag2;
			if (flag)
			{
				flag2 = (((DataRowView)this.GridEX2.CurrentRow.DataRow)["ID"] == DBNull.Value);
				if (flag2)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
					this.GridEX2.CurrentRow.Delete();
					((DataTable)this.GridEX2.DataSource).AcceptChanges();
					this.GetSum();
					this.GridEX2.MoveToNewRecord();
					this.GridEX2.Col = 0;
					this.GridEX2.EditMode = EditMode.EditOn;
				}
				else
				{
					flag2 = (Public_Function.ShowMessage("آیا مایل به حذف پرداخت چک میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
					if (flag2)
					{
						flag = this.GetDasteCheckUsage(this.GridEX2.CurrentRow);
						if (flag)
						{
							this.Del_CheckBarg();
							this.Update_MablaghNaghd(this.GridEX2.CurrentRow);
							CurrencyBox txt_naghd = this.txt_naghd;
							txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
							this.GridEX2.CurrentRow.Delete();
							((DataTable)this.GridEX2.DataSource).AcceptChanges();
							this.GetSum();
							this.GridEX2.MoveToNewRecord();
							this.GridEX2.Col = 0;
							this.GridEX2.EditMode = EditMode.EditOn;
						}
					}
				}
			}
			flag2 = (this.GridEX2.CurrentRow.RowType == RowType.NewRecord);
			if (flag2)
			{
				flag = (this.GridEX2.CurrentRow.Cells["mablagh"].Value != null);
				if (flag)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
				}
				this.GridEX2.CancelCurrentEdit();
				this.GetSum();
				this.GridEX2.MoveToNewRecord();
				this.GridEX2.Col = this.GridEX2.RootTable.Columns["sh_check"].Position;
				this.GridEX2.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000E9B58 File Offset: 0x000E7D58
		private void Check_Print()
		{
			bool flag = this.GridEX2.CurrentRow == null;
			if (!flag)
			{
				flag = !this.ValidateCurrentGridRow(this.GridEX2.CurrentRow.Position);
				if (!flag)
				{
					Frm_Check_Print frm_Check_Print = new Frm_Check_Print();
					DataTable dataTable = ((DataTable)this.GridEX2.DataSource).Clone();
					dataTable.ImportRow(((DataRowView)this.GridEX2.CurrentRow.DataRow).Row);
					dataTable.Rows[0]["mablagh"] = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["mablagh"].Value);
					dataTable.Rows[0]["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["Check_Sarresid_Fa"].Value);
					flag = (dataTable.Rows[0]["tozih"] == DBNull.Value);
					if (flag)
					{
					}
					frm_Check_Print.dt = dataTable;
					frm_Check_Print.Tozih = dataTable.Rows[0]["tozih"].ToString();
					frm_Check_Print.Moshtari_Name = this.Moshtari_Name;
					MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Check_Print);
					this.GridEX2.CurrentRow.BeginEdit();
					this.GridEX2.CurrentRow.Cells["tozih"].Value = frm_Check_Print.EditBox1.Text;
					this.GridEX2.CurrentRow.EndEdit();
				}
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000E9D10 File Offset: 0x000E7F10
		private void gridex3_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["sh_check"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
				GridEXRow[] rows2 = this.GridEX1.GetRows();
				for (int j = 0; j < rows2.Length; j++)
				{
					GridEXRow gridEXRow2 = rows2[j];
					bool flag = gridEXRow2.Cells["sh_check"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow2.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000E9DCC File Offset: 0x000E7FCC
		private void GridEX2_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = this.GridEX2.CurrentRow.Cells["mablagh"].Value == DBNull.Value;
			if (!flag)
			{
				flag = (e.Column.Position == this.GridEX2.RootTable.Columns["mablagh"].Position);
				if (flag)
				{
					bool flag2 = this.GridEX2.CurrentRow.Cells["mablagh2"].Value != null;
					bool flag3;
					if (flag2)
					{
						flag3 = Operators.ConditionalCompareObjectGreater(this.GridEX2.CurrentRow.Cells["mablagh"].Value, this.txt_naghd.Value, false);
						CurrencyBox txt_naghd;
						if (flag3)
						{
							this.GridEX2.CurrentRow.Cells["Mablagh"].Value = DBNull.Value;
							this.GridEX2.Col = this.GridEX2.RootTable.Columns["mablagh"].Position;
							txt_naghd = this.txt_naghd;
							txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh2"].Value));
							this.GridEX2.CurrentRow.Cells["mablagh2"].Value = null;
							return;
						}
						txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh2"].Value));
						this.GridEX2.CurrentRow.Cells["mablagh2"].Value = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["mablagh"].Value);
					}
					else
					{
						flag3 = Operators.ConditionalCompareObjectGreater(this.GridEX2.CurrentRow.Cells["mablagh"].Value, this.txt_naghd.Value, false);
						if (flag3)
						{
							this.GridEX2.CurrentRow.Cells["Mablagh"].Value = DBNull.Value;
							this.GridEX2.Col = this.GridEX2.RootTable.Columns["mablagh"].Position;
							return;
						}
						this.GridEX2.CurrentRow.Cells["mablagh2"].Value = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["mablagh"].Value);
					}
					flag3 = (this.GridEX2.CurrentRow.Cells["mablagh"].Value != null);
					if (flag3)
					{
						CurrencyBox txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.SubtractObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
					}
				}
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000EA120 File Offset: 0x000E8320
		private void GridEX2_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX2.RootTable.Columns["Sh_Check"].Position;
			if (flag)
			{
				this.Daste_Check_Select();
			}
			else
			{
				flag = (position == this.GridEX2.RootTable.Columns["del"].Position);
				if (flag)
				{
					this.Del_DasteCheck();
				}
				else
				{
					flag = (position == this.GridEX2.RootTable.Columns["print"].Position);
					if (flag)
					{
						this.Check_Print();
					}
				}
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000EA1CC File Offset: 0x000E83CC
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "check_sarresid_fa", false) == 0;
			if (flag)
			{
				e.Value = ((DateBox2)e.EditControl).Text;
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
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

		// Token: 0x060015B3 RID: 5555 RVA: 0x000EA26C File Offset: 0x000E846C
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "check_sarresid_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				flag = (e.Value != null);
				if (flag)
				{
					this.txt_tarikhGrid.SetDate(e.Value.ToString());
				}
				else
				{
					this.txt_tarikhGrid.SetDate("");
				}
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_mablagh;
					flag = (e.Value != null);
					if (flag)
					{
						this.txt_mablagh.Text = e.Value.ToString();
					}
					else
					{
						this.txt_mablagh.Text = string.Empty;
					}
					this.txt_mablagh.SelectAll();
				}
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000EA358 File Offset: 0x000E8558
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.GridEX2.Focus();
				this.GridEX2.MoveToNewRecord();
				this.GridEX2.Col = 0;
				this.GridEX2.EditMode = EditMode.EditOn;
			}
			flag = (this.GridEX1.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False);
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX1.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox != null);
						if (flag)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["CheckBank_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Up:
						flag2 = (this.GridEX1.Row > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX1;
							gridEX.Row--;
							e.SuppressKeyPress = true;
							return;
						}
						this.GridEX2.Focus();
						this.GridEX2.Col = 0;
						this.GridEX2.EditMode = EditMode.EditOn;
						break;
					case Keys.Down:
						flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
						if (flag2)
						{
							GridEX gridEX = this.GridEX1;
							gridEX.Row++;
							e.SuppressKeyPress = true;
							return;
						}
						this.txt_naghd.Focus();
						break;
					}
					flag2 = (e.KeyCode == Keys.Return);
					if (flag2)
					{
						int col = this.GridEX1.Col;
						flag = (col == this.GridEX1.RootTable.Columns["sh_check"].Position);
						if (flag)
						{
							bool flag3 = this.GridEX1.EditTextBox == null;
							if (flag3)
							{
								this.GridEX1.GetRow().BeginEdit();
							}
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Check_Select();
							}
						}
					}
				}
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000EA614 File Offset: 0x000E8814
		private void MoveToNewRecord()
		{
			checked
			{
				bool flag = this.GridEX1.Row < this.GridEX1.RowCount - 1;
				if (flag)
				{
					this.GridEX1.Col = 0;
					GridEX gridEX = this.GridEX1;
					gridEX.Row++;
					this.GridEX1.Focus();
				}
			}
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000EA674 File Offset: 0x000E8874
		private void GridEX2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
			flag = (this.GridEX2.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False);
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX2.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX2.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX2.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX2.EditTextBox != null);
						if (flag)
						{
							this.GridEX2.EditTextBox.Text = string.Empty;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
						flag2 = this.prevent_left;
						if (flag2)
						{
							this.prevent_left = false;
							this.GridEX2.EditMode = EditMode.EditOn;
							return;
						}
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						GridEX gridEX = this.GridEX2;
						gridEX.Col++;
						e.SuppressKeyPress = true;
						this.GridEX2.EditMode = EditMode.EditOn;
						return;
					}
					case Keys.Up:
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Up));
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX2.Row > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX2;
							gridEX.Row--;
							this.GridEX2.EditMode = EditMode.EditOn;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					case Keys.Right:
						flag2 = this.prevent_right;
						if (flag2)
						{
							this.prevent_right = false;
							return;
						}
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX2.Col > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX2;
							gridEX.Col--;
							e.SuppressKeyPress = true;
							this.GridEX2.EditMode = EditMode.EditOn;
							return;
						}
						break;
					case Keys.Down:
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Down));
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX2.Row < this.GridEX2.RowCount - 1);
						if (flag2)
						{
							GridEX gridEX = this.GridEX2;
							gridEX.Row++;
							this.GridEX2.EditMode = EditMode.EditOn;
							e.SuppressKeyPress = true;
							return;
						}
						this.GridEX1.Focus();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
						break;
					}
					flag2 = (e.KeyCode == Keys.Return);
					if (flag2)
					{
						int col = this.GridEX2.Col;
						flag = (col == this.GridEX2.RootTable.Columns["Sh_Check"].Position);
						if (flag)
						{
							bool flag3 = this.GridEX2.EditTextBox == null;
							if (flag3)
							{
								this.GridEX2.GetRow().BeginEdit();
							}
							flag3 = (Operators.CompareString(this.GridEX2.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Daste_Check_Select();
							}
						}
						else
						{
							bool flag3 = col == this.GridEX2.RootTable.Columns["Check_Sarresid_Fa"].Position;
							if (flag3)
							{
								this.GridEX2.UpdateData();
								this.GridEX2.MoveToNewRecord();
								this.GridEX2.Col = 0;
								this.GridEX2.EditMode = EditMode.EditOn;
							}
							else
							{
								GridEX gridEX = this.GridEX2;
								gridEX.Col++;
								this.GridEX2.EditMode = EditMode.EditOn;
							}
						}
					}
				}
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000EAB68 File Offset: 0x000E8D68
		private void GridEX2_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX2.Col == this.GridEX2.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			else
			{
				flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000EABF0 File Offset: 0x000E8DF0
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			else
			{
				flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position);
				if (!flag)
				{
					flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
					if (flag)
					{
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000EACAC File Offset: 0x000E8EAC
		private void design_print()
		{
			StiReport stiReport = new StiReport();
			string str = Conversions.ToString(1);
			DataRow dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.Columns["sh_check"].ColumnName = "شماره_چک";
			dataTable2.Columns.Remove("ID");
			dataTable2.Columns.Remove("dptype_id");
			dataTable2.Columns.Remove("Tarikh");
			dataTable2.Columns.Remove("sanadbed_id");
			dataTable2.Columns.Remove("sanadbes_id");
			dataTable2.Columns.Remove("moshtari_id");
			dataTable2.Columns.Remove("sandug_id");
			dataTable2.Columns.Remove("bankhesab_id");
			dataTable2.Columns.Remove("tarikh_fa");
			dataTable2.Columns.Remove("checkbank_id");
			dataTable2.Columns.Remove("Parent_ID");
			dataTable2.Columns.Remove("dp_name");
			dataTable2.Columns.Remove("check_status");
			dataTable2.Columns.Remove("sh_fish");
			dataTable2.Columns.Remove("fishvariz");
			dataTable2.Columns.Remove("fishvariz_fa");
			dataTable2.Columns.Remove("hazine_ID");
			dataTable2.Columns.Remove("Hazine_Name");
			dataTable2.Columns.Remove("pardakhtcheck_ID");
			dataTable2.Columns.Remove("Tozih");
			dataTable2.Columns.Remove("check_sarresid");
			dataTable2.Columns.Remove("moshtari_name");
			dataTable2.Columns.Remove("checkbarg_id");
			dataTable2.Columns.Remove("daryaft_identity");
			dataTable2.Columns.Remove("is_child");
			dataTable2.Columns.Remove("identity");
			dataTable2.Columns.Remove("parent_identity");
			dataTable2.Columns.Remove("moshtari_id2");
			dataTable2.Columns.Remove("moshtari_name2");
			dataTable2.Columns["mablagh"].ColumnName = "مبلغ";
			dataTable2.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
			dataTable2.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
			dataTable2.Columns.Add(new DataColumn("shobe", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("huruf", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("تلفن", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("آدرس", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			try
			{
				IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator.Current;
					dataRow3["shobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["checkbank_name"], "/"), dataRow3["check_shobe"]);
					dataRow3["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow3["مبلغ"]), huruf.ConvertType.هیچکدام);
					dataRow3["تلفن"] = dataRow["tel"].ToString();
					dataRow3["آدرس"] = dataRow["address"].ToString();
					dataRow3["شماره_حساب"] = dataRow["sh_hesab"].ToString();
					dataRow3["صاحب_حساب"] = dataRow["sahebhesab"].ToString();
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
			dataTable2.Columns["shobe"].ColumnName = "بانک_چک";
			dataTable2.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
			dataTable2.Columns.Remove("checkbank_name");
			dataTable2.Columns.Remove("check_shobe");
			dataTable2.Columns.Remove("bankhesab_name");
			dataTable2.TableName = "data";
			stiReport.RegData(dataTable2);
			StiDataBand stiDataBand = new StiDataBand();
			stiDataBand.DataSourceName = "data";
			stiDataBand.Height = stiReport.Pages[0].Height;
			stiReport.Pages[0].Components.Add(stiDataBand);
			StiOptions.Designer.DontAskSaveReport = true;
			StiOptions.Designer.DontSaveDesignerConfig = true;
			StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
			StiOptions.Designer.AllowSaveStandaloneReport = false;
			StiOptions.Designer.CodeTabVisible = false;
			StiOptions.Designer.HtmlPreviewReportVisible = false;
			stiReport.Design();
			NewLateBinding.LateCall(stiReport, null, "Save", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow2["ID"]), ".mrt")
			}, null, null, null, true);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000EB2E0 File Offset: 0x000E94E0
		private void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			string text = Conversions.ToString(1);
			DataTable dataTable = (DataTable)this.GridEX2.DataSource;
			DataRow dataRow2;
			DataRow dataRow3;
			bool flag2;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					string str = Conversions.ToString(dataRow["bankhesab_id"]);
					dataRow2 = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
					dataRow3 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow2["bank_ID"])));
					bool flag = !File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow3["ID"]), ".mrt")));
					if (flag)
					{
						flag2 = (Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگ واگذاری به بانک ", dataRow3["Name"]), "  طراحی نگردیده است"), Environment.NewLine), "آیا مایل به طراحی برگ میباشید؟")), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes);
						if (flag2)
						{
							this.design_print();
							return;
						}
						return;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag2 = (enumerator is IDisposable);
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			NewLateBinding.LateCall(stiReport, null, "Load", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow3["ID"]), ".mrt")
			}, null, null, null, true);
			DataTable dataTable2 = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable3 = dataTable2.Copy();
			dataTable3.Columns["sh_check"].ColumnName = "شماره_چک";
			dataTable3.Columns.Remove("ID");
			dataTable3.Columns.Remove("dptype_id");
			dataTable3.Columns.Remove("Tarikh");
			dataTable3.Columns.Remove("sanadbed_id");
			dataTable3.Columns.Remove("sanadbes_id");
			dataTable3.Columns.Remove("moshtari_id");
			dataTable3.Columns.Remove("sandug_id");
			dataTable3.Columns.Remove("bankhesab_id");
			dataTable3.Columns.Remove("tarikh_fa");
			dataTable3.Columns.Remove("Parent_ID");
			dataTable3.Columns.Remove("dp_name");
			dataTable3.Columns.Remove("check_status");
			dataTable3.Columns.Remove("sh_fish");
			dataTable3.Columns.Remove("fishvariz");
			dataTable3.Columns.Remove("fishvariz_fa");
			dataTable3.Columns.Remove("hazine_ID");
			dataTable3.Columns.Remove("Hazine_Name");
			dataTable3.Columns.Remove("pardakhtcheck_ID");
			dataTable3.Columns.Remove("Tozih");
			dataTable3.Columns.Remove("check_sarresid");
			dataTable3.Columns.Remove("moshtari_name");
			dataTable3.Columns.Remove("checkbarg_id");
			dataTable3.Columns.Remove("daryaft_identity");
			dataTable3.Columns.Remove("is_child");
			dataTable3.Columns.Remove("identity");
			dataTable3.Columns.Remove("parent_identity");
			dataTable3.Columns.Remove("moshtari_id2");
			dataTable3.Columns.Remove("moshtari_name2");
			dataTable3.Columns["mablagh"].ColumnName = "مبلغ";
			dataTable3.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
			dataTable3.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
			dataTable3.Columns.Add(new DataColumn("shobe", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("huruf", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("تلفن", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("آدرس", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			try
			{
				IEnumerator enumerator2 = dataTable3.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator2.Current;
					dataRow4["shobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow4["checkbank_name"], "/"), dataRow4["check_shobe"]);
					dataRow4["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow4["مبلغ"]), huruf.ConvertType.هیچکدام);
					dataRow4["تلفن"] = dataRow2["tel"].ToString();
					dataRow4["آدرس"] = dataRow2["address"].ToString();
					dataRow4["شماره_حساب"] = dataRow2["sh_hesab"].ToString();
					dataRow4["صاحب_حساب"] = dataRow2["sahebhesab"].ToString();
				}
			}
			finally
			{
				IEnumerator enumerator2;
				flag2 = (enumerator2 is IDisposable);
				if (flag2)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			dataTable3.Columns["shobe"].ColumnName = "بانک_چک";
			dataTable3.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
			dataTable3.Columns.Remove("checkbank_name");
			dataTable3.Columns.Remove("check_shobe");
			dataTable3.Columns.Remove("bankhesab_name");
			dataTable3.TableName = "data";
			stiReport.RegData(dataTable3);
			flag2 = !Design;
			if (flag2)
			{
				stiReport.Show();
			}
			else
			{
				StiOptions.Designer.DontAskSaveReport = true;
				StiOptions.Designer.DontSaveDesignerConfig = true;
				StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
				StiOptions.Designer.AllowSaveStandaloneReport = false;
				StiOptions.Designer.CodeTabVisible = false;
				StiOptions.Designer.HtmlPreviewReportVisible = false;
				stiReport.Design();
				NewLateBinding.LateCall(stiReport, null, "Save", new object[]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow3["ID"]), ".mrt")
				}, null, null, null, true);
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00006C64 File Offset: 0x00004E64
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.ShowReport(false);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000EBA24 File Offset: 0x000E9C24
		private void GridEX2_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["bankhesab_id"].Value == DBNull.Value && gridEXRow.Cells["checkbarg_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00006C70 File Offset: 0x00004E70
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00006C7B File Offset: 0x00004E7B
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			this.GetSum();
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000EBAA4 File Offset: 0x000E9CA4
		private void txt_naghd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Down;
			if (flag)
			{
				this.txt_mablagh_BeMoshtari.Focus();
			}
			flag = (e.KeyCode == Keys.Up);
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0000205D File Offset: 0x0000025D
		private void txt_cart_Validating(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000EBB04 File Offset: 0x000E9D04
		private void txt_cart_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف کارت به کارت میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				bool hasValue = this.Pardakht_BeMoshtari_ID.HasValue;
				if (hasValue)
				{
					this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Pardakht_BeMoshtari_ID), "", "", "");
					this.txt_mablagh_BeMoshtari.SetNew();
				}
				else
				{
					this.txt_mablagh_BeMoshtari.SetNew();
				}
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000EBB80 File Offset: 0x000E9D80
		private void txt_naghd_ButtonClick(object sender, EventArgs e)
		{
			bool hasValue = this.Daryaft_Naghd_ID.HasValue;
			if (hasValue)
			{
				this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Daryaft_Naghd_ID), "", "", "");
				this.txt_naghd.SetNew();
			}
			else
			{
				this.txt_naghd.SetNew();
			}
		}

		// Token: 0x04000830 RID: 2096
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000832 RID: 2098
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000833 RID: 2099
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000834 RID: 2100
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x04000835 RID: 2101
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000836 RID: 2102
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000837 RID: 2103
		[AccessedThroughProperty("Highlighter1")]
		private Highlighter _Highlighter1;

		// Token: 0x04000838 RID: 2104
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000839 RID: 2105
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x0400083A RID: 2106
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x0400083B RID: 2107
		[AccessedThroughProperty("lbl_jamcheck")]
		private LabelCommand _lbl_jamcheck;

		// Token: 0x0400083C RID: 2108
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x0400083D RID: 2109
		[AccessedThroughProperty("lbl_jamkol")]
		private LabelCommand _lbl_jamkol;

		// Token: 0x0400083E RID: 2110
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x0400083F RID: 2111
		[AccessedThroughProperty("lbl_codem")]
		private LabelCommand _lbl_codem;

		// Token: 0x04000840 RID: 2112
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000841 RID: 2113
		[AccessedThroughProperty("lbl_name")]
		private LabelCommand _lbl_name;

		// Token: 0x04000842 RID: 2114
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x04000843 RID: 2115
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x04000844 RID: 2116
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000845 RID: 2117
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000846 RID: 2118
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000847 RID: 2119
		[AccessedThroughProperty("txt_mablagh_BeMoshtari")]
		private CurrencyBox _txt_mablagh_BeMoshtari;

		// Token: 0x04000848 RID: 2120
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000849 RID: 2121
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400084A RID: 2122
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400084B RID: 2123
		[AccessedThroughProperty("txt_babat_kart")]
		private EditBox _txt_babat_kart;

		// Token: 0x0400084C RID: 2124
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400084D RID: 2125
		[AccessedThroughProperty("txt_moshtari")]
		private EditBox _txt_moshtari;

		// Token: 0x0400084E RID: 2126
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400084F RID: 2127
		[AccessedThroughProperty("txt_naghd")]
		private CurrencyBox _txt_naghd;

		// Token: 0x04000850 RID: 2128
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x04000851 RID: 2129
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000852 RID: 2130
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000853 RID: 2131
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000854 RID: 2132
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000855 RID: 2133
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000856 RID: 2134
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000857 RID: 2135
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000858 RID: 2136
		[AccessedThroughProperty("GridEX3")]
		private GridEX _GridEX3;

		// Token: 0x04000859 RID: 2137
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400085A RID: 2138
		[AccessedThroughProperty("GridEX4")]
		private GridEX _GridEX4;

		// Token: 0x0400085B RID: 2139
		[AccessedThroughProperty("DateBox21")]
		private DateBox2 _DateBox21;

		// Token: 0x0400085C RID: 2140
		[AccessedThroughProperty("txt_beMoshtari")]
		private SelectItem _txt_beMoshtari;

		// Token: 0x0400085D RID: 2141
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x0400085E RID: 2142
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x0400085F RID: 2143
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000860 RID: 2144
		[CompilerGenerated]
		private string _Tozih;

		// Token: 0x04000861 RID: 2145
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x04000862 RID: 2146
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x04000863 RID: 2147
		[CompilerGenerated]
		private long _Mablagh_Kol;

		// Token: 0x04000864 RID: 2148
		[CompilerGenerated]
		private int _HazineKharid_ID;

		// Token: 0x04000865 RID: 2149
		[CompilerGenerated]
		private string _HazineKharid_Name;

		// Token: 0x04000866 RID: 2150
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x04000867 RID: 2151
		[CompilerGenerated]
		private string _Moshtari_ID;

		// Token: 0x04000868 RID: 2152
		[CompilerGenerated]
		private string _Pardakht_ID;

		// Token: 0x04000869 RID: 2153
		[CompilerGenerated]
		private string _Kart_be_Kart_ID;

		// Token: 0x0400086A RID: 2154
		private DaryaftPardakht dp;

		// Token: 0x0400086B RID: 2155
		private Sanad sanad;

		// Token: 0x0400086C RID: 2156
		private bool prevent;

		// Token: 0x0400086D RID: 2157
		private bool prevent_right;

		// Token: 0x0400086E RID: 2158
		private bool prevent_left;

		// Token: 0x0400086F RID: 2159
		private string notin;

		// Token: 0x04000870 RID: 2160
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000871 RID: 2161
		private int? Daryaft_Naghd_ID;

		// Token: 0x04000872 RID: 2162
		private int? Pardakht_BeMoshtari_ID;

		// Token: 0x04000873 RID: 2163
		private string Notin_Pardakht;

		// Token: 0x04000874 RID: 2164
		private DaryaftPardakht daryaft;
	}
}
