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
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000028 RID: 40
	[DesignerGenerated]
	public partial class Frm_Sud : Form
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000023F8 File Offset: 0x000005F8
		[DebuggerNonUserCode]
		public Frm_Sud()
		{
			base.Load += new EventHandler(this.Frm_Sud_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Sud_KeyDown);
			Frm_Sud.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0002F0D8 File Offset: 0x0002D2D8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sud.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sud.__ENCList.Count == Frm_Sud.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sud.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sud.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sud.__ENCList[num] = Frm_Sud.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sud.__ENCList.RemoveRange(num, Frm_Sud.__ENCList.Count - num);
						Frm_Sud.__ENCList.Capacity = Frm_Sud.__ENCList.Count;
					}
					Frm_Sud.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00031128 File Offset: 0x0002F328
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002438 File Offset: 0x00000638
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
				this._ButtonItem2 = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00031140 File Offset: 0x0002F340
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002442 File Offset: 0x00000642
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00031158 File Offset: 0x0002F358
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000244C File Offset: 0x0000064C
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00031170 File Offset: 0x0002F370
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002456 File Offset: 0x00000656
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00031188 File Offset: 0x0002F388
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002460 File Offset: 0x00000660
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000311A0 File Offset: 0x0002F3A0
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000246A File Offset: 0x0000066A
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000311B8 File Offset: 0x0002F3B8
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002474 File Offset: 0x00000674
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000311D0 File Offset: 0x0002F3D0
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000247E File Offset: 0x0000067E
		internal virtual Bar Bar2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar2 = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000311E8 File Offset: 0x0002F3E8
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00031200 File Offset: 0x0002F400
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value4 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.CellEdited -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.EndCustomEdit -= value4;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.CellEdited += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.EndCustomEdit += value4;
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000312B0 File Offset: 0x0002F4B0
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002488 File Offset: 0x00000688
		internal virtual Bar Bar3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar3 = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000312C8 File Offset: 0x0002F4C8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x000312E0 File Offset: 0x0002F4E0
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00031340 File Offset: 0x0002F540
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002492 File Offset: 0x00000692
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00031358 File Offset: 0x0002F558
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00031370 File Offset: 0x0002F570
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000313F8 File Offset: 0x0002F5F8
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000249C File Offset: 0x0000069C
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00031410 File Offset: 0x0002F610
		// (set) Token: 0x06000261 RID: 609 RVA: 0x000024A6 File Offset: 0x000006A6
		internal virtual DateBox2 txt_az_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_az_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_az_tarikh = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00031428 File Offset: 0x0002F628
		// (set) Token: 0x06000263 RID: 611 RVA: 0x000024B0 File Offset: 0x000006B0
		internal virtual CurrencyBox txt_sud
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sud;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sud = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00031440 File Offset: 0x0002F640
		// (set) Token: 0x06000265 RID: 613 RVA: 0x000024BA File Offset: 0x000006BA
		internal virtual CurrencyBox txt_hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hazine = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00031458 File Offset: 0x0002F658
		// (set) Token: 0x06000267 RID: 615 RVA: 0x000024C4 File Offset: 0x000006C4
		internal virtual CurrencyBox txt_daramad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_daramad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_daramad = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00031470 File Offset: 0x0002F670
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00031488 File Offset: 0x0002F688
		internal virtual ButtonItem ButtonItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem4_Click);
				bool flag = this._ButtonItem4 != null;
				if (flag)
				{
					this._ButtonItem4.Click -= value2;
				}
				this._ButtonItem4 = value;
				flag = (this._ButtonItem4 != null);
				if (flag)
				{
					this._ButtonItem4.Click += value2;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000314E8 File Offset: 0x0002F6E8
		// (set) Token: 0x0600026B RID: 619 RVA: 0x000024CE File Offset: 0x000006CE
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00031500 File Offset: 0x0002F700
		// (set) Token: 0x0600026D RID: 621 RVA: 0x000024D8 File Offset: 0x000006D8
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00031518 File Offset: 0x0002F718
		// (set) Token: 0x0600026F RID: 623 RVA: 0x000024E2 File Offset: 0x000006E2
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00031530 File Offset: 0x0002F730
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000024EC File Offset: 0x000006EC
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00031548 File Offset: 0x0002F748
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00031560 File Offset: 0x0002F760
		internal virtual ButtonItem ButtonItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem5_Click);
				bool flag = this._ButtonItem5 != null;
				if (flag)
				{
					this._ButtonItem5.Click -= value2;
				}
				this._ButtonItem5 = value;
				flag = (this._ButtonItem5 != null);
				if (flag)
				{
					this._ButtonItem5.Click += value2;
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000315C0 File Offset: 0x0002F7C0
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000024F6 File Offset: 0x000006F6
		internal virtual CurrencyBox txt_sukhte
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sukhte;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sukhte = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000315D8 File Offset: 0x0002F7D8
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002500 File Offset: 0x00000700
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000315F0 File Offset: 0x0002F7F0
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0000250A File Offset: 0x0000070A
		internal virtual CurrencyBox txt_kasrezafe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kasrezafe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kasrezafe = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00031608 File Offset: 0x0002F808
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002514 File Offset: 0x00000714
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00031620 File Offset: 0x0002F820
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00031638 File Offset: 0x0002F838
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00031698 File Offset: 0x0002F898
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000251E File Offset: 0x0000071E
		internal virtual CurrencyBox txt_barzamin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_barzamin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_barzamin = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000316B0 File Offset: 0x0002F8B0
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002528 File Offset: 0x00000728
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000316C8 File Offset: 0x0002F8C8
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002532 File Offset: 0x00000732
		internal virtual UICheckBox chk_sukhte
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chk_sukhte;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chk_sukhte = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000316E0 File Offset: 0x0002F8E0
		// (set) Token: 0x06000285 RID: 645 RVA: 0x000316F8 File Offset: 0x0002F8F8
		internal virtual DateBox2 txt_ta_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ta_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ta_tarikh_Validated);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.Validated -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.Validated += value2;
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00031758 File Offset: 0x0002F958
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000253C File Offset: 0x0000073C
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

		// Token: 0x06000288 RID: 648 RVA: 0x00031770 File Offset: 0x0002F970
		private void Frm_Sud_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F2);
				if (flag)
				{
				}
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000317A8 File Offset: 0x0002F9A8
		private void GetBarroyeZamin()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0) from sanad where codehesab_id=42"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum( Mablagh),0) AS Bed  FROM DaryaftPardakht WHERE     (dpType_ID = 28) and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( Jam_Kol),0) AS Bes  FROM Furush_Hag_Detail WHERE     (Moshtari_ID = - 2) and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))));
			long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bes),0) from sanad where codehesab_id=40 and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))));
			long num5 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0) from sanad where codehesab_id=41 and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))));
			long num6 = checked(num + num2 - num3 - num4 + num5);
			bool flag = num6 > 0L;
			if (flag)
			{
				this.Label8.Text = "+ بارروی زمین";
			}
			else
			{
				this.Label8.Text = "- بارروی زمین";
			}
			this.txt_barzamin.Text = Conversions.ToString(num6);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000318C4 File Offset: 0x0002FAC4
		private void Calc_sud()
		{
			Control arg_A4_0 = this.txt_sud;
			long? value = this.txt_daramad.Value;
			bool arg_2F_0 = value.HasValue;
			long? value2 = this.txt_barzamin.Value;
			checked
			{
				long? arg_57_0;
				if (!(arg_2F_0 & value2.HasValue))
				{
					arg_57_0 = null;
				}
				else
				{
					long? value3 = new long?(value.GetValueOrDefault() + value2.GetValueOrDefault());
					arg_57_0 = value3;
				}
				long? num = arg_57_0;
				bool arg_72_0 = num.HasValue;
				long? value4 = this.txt_hazine.Value;
				long? arg_9A_0;
				if (!(arg_72_0 & value4.HasValue))
				{
					arg_9A_0 = null;
				}
				else
				{
					long? num2 = new long?(num.GetValueOrDefault() - value4.GetValueOrDefault());
					arg_9A_0 = num2;
				}
				arg_A4_0.Text = Conversions.ToString((T)arg_9A_0);
				bool flag = this.chk_sukhte.Checked;
				if (flag)
				{
					CurrencyBox txt_sud = this.txt_sud;
					Control arg_13C_0 = txt_sud;
					double num3 = Conversions.ToDouble(txt_sud.Text);
					long? value3 = this.txt_sukhte.Value;
					double? arg_107_0;
					if (!value3.HasValue)
					{
						arg_107_0 = null;
					}
					else
					{
						double? num4 = new double?((double)value3.GetValueOrDefault());
						arg_107_0 = num4;
					}
					double? num5 = arg_107_0;
					double? arg_132_0;
					if (!num5.HasValue)
					{
						arg_132_0 = null;
					}
					else
					{
						double? num6 = new double?(unchecked(num3 - num5.GetValueOrDefault()));
						arg_132_0 = num6;
					}
					arg_13C_0.Text = Conversions.ToString((T)arg_132_0);
				}
				flag = (Operators.CompareString(this.Label7.Text, "-کسری صندوق", false) == 0);
				if (flag)
				{
					Control arg_1C5_0 = this.txt_sud;
					long? value3 = this.txt_sud.Value;
					bool arg_193_0 = value3.HasValue;
					value2 = this.txt_kasrezafe.Value;
					long? arg_1BB_0;
					if (!(arg_193_0 & value2.HasValue))
					{
						arg_1BB_0 = null;
					}
					else
					{
						value = new long?(value3.GetValueOrDefault() - value2.GetValueOrDefault());
						arg_1BB_0 = value;
					}
					arg_1C5_0.Text = Conversions.ToString((T)arg_1BB_0);
				}
				else
				{
					Control arg_22E_0 = this.txt_sud;
					long? value3 = this.txt_sud.Value;
					bool arg_1FC_0 = value3.HasValue;
					value2 = this.txt_kasrezafe.Value;
					long? arg_224_0;
					if (!(arg_1FC_0 & value2.HasValue))
					{
						arg_224_0 = null;
					}
					else
					{
						value = new long?(value3.GetValueOrDefault() + value2.GetValueOrDefault());
						arg_224_0 = value;
					}
					arg_22E_0.Text = Conversions.ToString((T)arg_224_0);
				}
				this.loadSharik();
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00031B10 File Offset: 0x0002FD10
		private void LoadData()
		{
			this.GetBarroyeZamin();
			this.txt_num.Value = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(max(num)+1,1) from sud"));
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum(Sanad.Bes),0)-isnull(sum(Sanad.Bed),0)  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     Code_Hesab.Grouh_ID=7 and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))));
			this.txt_daramad.Text = Conversions.ToString(value);
			long value2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Bed),0)-isnull(sum(Bes),0)  FROM Sanad where CodeHesab_ID in (select id from code_hesab where grouh_ID=5) and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))));
			long value3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( t.jam_bed),0) as jam_bed  FROM         (SELECT     SUM(Sanad.Bed - Sanad.Bes) AS jam_bed, Sanad.CodeHesab_ID     FROM         Sanad INNER JOIN      Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN      Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID     WHERE     (Code_Hesab.Grouh_ID = 2) AND (Moshtari.ID NOT IN     (SELECT     Moshtari_ID        FROM         Sharik)) AND (Moshtari.ID IN     (SELECT     Moshtari_ID        FROM         Moshtari_ListSiah where checked is null))     GROUP BY Sanad.CodeHesab_ID     HAVING      (SUM(Sanad.Bed - Sanad.Bes) > 0)) AS t INNER JOIN   Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID"));
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 isnull(tarikh_kasrezafe,'') from sud order by id desc"));
			string str = string.Empty;
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				str = "and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			}
			else
			{
				str = " AND tarikh>" + Public_Function.GetValue(text) + " and tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			}
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull(sum(mablagh),0)    FROM         DaryaftPardakht  WHERE     DaryaftPardakht.dpType_ID IN (5)" + str));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull(sum(mablagh),0)   FROM         DaryaftPardakht  WHERE     DaryaftPardakht.dpType_ID IN (16)" + str));
			flag = (num2 > num);
			checked
			{
				if (flag)
				{
					this.txt_kasrezafe.Text = Conversions.ToString(num2 - num);
					this.Label7.Text = "-کسری صندوق";
				}
				else
				{
					this.txt_kasrezafe.Text = Conversions.ToString(num - num2);
					this.Label7.Text = "+اضافی صندوق";
				}
				this.txt_hazine.Text = Conversions.ToString(value2);
				this.txt_sukhte.Text = Conversions.ToString(value3);
				this.Calc_sud();
				this.loadSharik();
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00031CF4 File Offset: 0x0002FEF4
		private void Frm_Sud_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.txt_num.NumericBox1.Font = this.txt_daramad.Font;
			this.txt_num.UiButton4.Visible = false;
			this.txt_num.UiButton2.Visible = false;
			this.txt_num.Height = 36;
			this.GridEX1.RootTable.Columns["mablagh"].EditType = EditType.Custom;
			this.LoadData();
			this.chk_sukhte.CheckedChanged += new EventHandler(this.chk_sukhte_CheckedChanged);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00031DAC File Offset: 0x0002FFAC
		private void LoadPreData(long num)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select id from sud where num=" + Conversions.ToString(num)));
			DataTable dataSource = Public_Function.FillData("SELECT     Sud_Detail.Moshtari_ID, Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name, Moshtari.CodeHesab_ID, Sud_Detail.Darsad, Sud_Detail.Mablagh  FROM         Sud_Detail INNER JOIN  Moshtari ON Sud_Detail.Moshtari_ID = Moshtari.ID where sud_id=" + Conversions.ToString(value));
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00031DFC File Offset: 0x0002FFFC
		private void loadSharik()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Sharik.Moshtari_ID, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name,Moshtari.CodeHesab_ID, Sharik.Darsad  FROM         Sharik INNER JOIN  Moshtari ON Sharik.Moshtari_ID = Moshtari.ID  where darsad>0");
			dataTable.Columns.Add("mablagh", typeof(long));
			this.GridEX1.DataSource = dataTable;
			decimal num = 0m;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					num = Conversions.ToDecimal(Operators.AddObject(num, dataRow["darsad"]));
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
			flag = (decimal.Compare(num, new decimal(100L)) != 0);
			if (flag)
			{
				this.UiGroupBox2.Visible = true;
			}
			else
			{
				this.UiGroupBox2.Visible = false;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						DataRow arg_18C_0 = dataRow2;
						string arg_18C_1 = "mablagh";
						double num2 = 100.0;
						long? value = this.txt_sud.Value;
						double? arg_14C_0;
						if (!value.HasValue)
						{
							arg_14C_0 = null;
						}
						else
						{
							double? num3 = new double?((double)value.GetValueOrDefault());
							arg_14C_0 = num3;
						}
						double? num4 = arg_14C_0;
						double? arg_177_0;
						if (!num4.HasValue)
						{
							arg_177_0 = null;
						}
						else
						{
							double? num5 = new double?(num4.GetValueOrDefault() / num2);
							arg_177_0 = num5;
						}
						arg_18C_0[arg_18C_1] = Operators.MultiplyObject(arg_177_0, dataRow2["darsad"]);
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

		// Token: 0x0600028F RID: 655 RVA: 0x00031FF0 File Offset: 0x000301F0
		private void Insert()
		{
			string text = "declare @daramad_id bigint,@hazine_id bigint,@sud_id int,@sanad_id bigint,@daramad_id2 bigint,@hazine_id2 bigint;";
			Sanad sanad = new Sanad();
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select top 1 tarikh from mande_sandugh order by tarikh desc"));
			string text2 = string.Empty;
			long num = (T)this.txt_daramad.Value;
			long num2 = (T)this.txt_hazine.Value;
			long num3 = 0L;
			long? value = this.txt_barzamin.Value;
			bool? arg_86_0;
			if (!value.HasValue)
			{
				arg_86_0 = null;
			}
			else
			{
				bool? flag = new bool?(value.GetValueOrDefault() != num3);
				arg_86_0 = flag;
			}
			bool? flag2 = arg_86_0;
			bool valueOrDefault = flag2.GetValueOrDefault();
			checked
			{
				bool flag5;
				if (valueOrDefault)
				{
					long num4 = 0L;
					long? value2 = this.txt_barzamin.Value;
					bool? arg_D3_0;
					if (!value2.HasValue)
					{
						arg_D3_0 = null;
					}
					else
					{
						bool? flag3 = new bool?(value2.GetValueOrDefault() > num4);
						arg_D3_0 = flag3;
					}
					bool? flag4 = arg_D3_0;
					flag5 = flag4.GetValueOrDefault();
					if (flag5)
					{
						long? value3 = this.txt_barzamin.Value;
						long? arg_11A_0;
						if (!value3.HasValue)
						{
							arg_11A_0 = null;
						}
						else
						{
							long? num5 = new long?(num + value3.GetValueOrDefault());
							arg_11A_0 = num5;
						}
						num = (T)arg_11A_0;
						text += sanad.InsertStr("40", "0", this.txt_barzamin.Value.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), "درآمد بارروی زمین", "@daramad_id2", Sanad.SanadType.@null);
						text2 = "@daramad_id2";
					}
					else
					{
						long num6 = (T)this.txt_barzamin.Value;
						num6 = Math.Abs(num6);
						num2 += num6;
						text += sanad.InsertStr("41", num6.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), "زیان بارروی زمین", "@hazine_id2", Sanad.SanadType.@null);
						text2 = "@hazine_id2";
					}
				}
				else
				{
					text2 = "null";
				}
				text += sanad.InsertStr("15", num.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), "محاسبه درآمد - شماره" + this.txt_num.Value, "@daramad_id", Sanad.SanadType.@null);
				text += sanad.InsertStr("16", "0", num2.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), "محاسبه درآمد - شماره" + this.txt_num.Value, "@hazine_id", Sanad.SanadType.@null);
				long num7 = Conversions.ToLong(this.txt_kasrezafe.Text);
				flag5 = (Operators.CompareString(this.Label7.Text, "-کسری صندوق", false) == 0);
				if (flag5)
				{
					num7 *= -1L;
				}
				text = string.Concat(new string[]
				{
					text,
					"INSERT INTO [Sud] ([Num],[Tarikh],[Tarikh_Fa],[DaramadSanad_ID],[HazineSanad_ID],mablagh_sukhte,tarikh_kasrezafe,Mablagh_Kasrezafe,barzamin_sanad_id,mablagh_barzamin,mablagh_sud,mablagh_hazine,calc_sukhte,ta_tarikh) VALUES(",
					this.txt_num.Value,
					",",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
					",",
					Public_Function.GetValue(this.txt_az_tarikh.Text),
					",@daramad_id,@hazine_id,",
					Public_Function.GetValueInt(Conversions.ToString((T)this.txt_sukhte.Value)),
					",",
					Public_Function.GetValue(Conversions.ToString(objectValue)),
					",",
					Conversions.ToString(num7),
					",",
					text2,
					",",
					Public_Function.GetValueInt(Conversions.ToString((T)this.txt_barzamin.Value)),
					",",
					Public_Function.GetValueInt(Conversions.ToString((T)this.txt_sud.Value)),
					",",
					Public_Function.GetValueInt(Conversions.ToString((T)this.txt_hazine.Value)),
					",",
					Public_Function.GetValueInt(Conversions.ToString(this.chk_sukhte.Checked)),
					",",
					Public_Function.GetValue(this.txt_ta_tarikh.Text),
					" );select @sud_id=Scope_Identity();"
				});
				try
				{
					IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag5 = Operators.ConditionalCompareObjectGreater(dataRow["mablagh"], 0, false);
						if (flag5)
						{
							text += sanad.InsertStr(Conversions.ToString(dataRow["codehesab_ID"]), "0", Conversions.ToString(dataRow["mablagh"]), Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("%", dataRow["darsad"]), " "), "از حق السهم شراکت")), "@sanad_id", Sanad.SanadType.@null);
						}
						else
						{
							string arg_5FC_0 = text;
							Sanad arg_5F7_0 = sanad;
							string arg_5F7_1 = Conversions.ToString(dataRow["codehesab_ID"]);
							object arg_586_0 = null;
							Type arg_586_1 = typeof(Math);
							string arg_586_2 = "Abs";
							object[] array = new object[1];
							object[] arg_56D_0 = array;
							int arg_56D_1 = 0;
							DataRow dataRow2 = dataRow;
							DataRow arg_563_0 = dataRow2;
							string columnName = "mablagh";
							arg_56D_0[arg_56D_1] = RuntimeHelpers.GetObjectValue(arg_563_0[columnName]);
							object[] array2 = array;
							object[] arg_586_3 = array2;
							string[] arg_586_4 = null;
							Type[] arg_586_5 = null;
							bool[] array3 = new bool[]
							{
								true
							};
							object arg_5A4_0 = NewLateBinding.LateGet(arg_586_0, arg_586_1, arg_586_2, arg_586_3, arg_586_4, arg_586_5, array3);
							if (array3[0])
							{
								dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array2[0]);
							}
							text = arg_5FC_0 + arg_5F7_0.InsertStr(arg_5F7_1, Conversions.ToString(arg_5A4_0), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("%", dataRow["darsad"]), " "), "از حق السهم شراکت"), " (ضرر) ")), "@sanad_id", Sanad.SanadType.@null);
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [Sud_Detail] ([Sud_ID],[Moshtari_ID],[Darsad],[Mablagh],[Sanad_ID]) values(@sud_id,", dataRow["moshtari_id"]), ","), dataRow["darsad"]), ","), dataRow["mablagh"]), ",@sanad_id);")));
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag5 = (enumerator is IDisposable);
					if (flag5)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				DataTable dataTable = Public_Function.FillData("select moshtari_id from moshtari_listsiah  where checked is null");
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator2.Current;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("insert into sud_sukhte (sud_id,moshtari_id) values(@sud_id,", dataRow3["moshtari_id"]), ");")));
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag5 = (enumerator2 is IDisposable);
					if (flag5)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				Public_Function.ExecuteNonQuery(text);
				Public_Function.ExecuteNonQuery("update moshtari_listsiah set checked=1 where checked is null");
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				this.txt_ta_tarikh.SetNew();
				this.LoadData();
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00032790 File Offset: 0x00030990
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			Frm_SahebSaham showFrm = new Frm_SahebSaham();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
			this.loadSharik();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000327C0 File Offset: 0x000309C0
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			long num = 0L;
			long? value = this.txt_sud.Value;
			bool? arg_39_0;
			if (!value.HasValue)
			{
				arg_39_0 = null;
			}
			else
			{
				bool? flag = new bool?(value.GetValueOrDefault() == num);
				arg_39_0 = flag;
			}
			bool? flag2 = arg_39_0;
			bool flag3 = flag2.GetValueOrDefault();
			if (!flag3)
			{
				DataTable dataTable = Public_Function.FillData("select * from sud where num=" + this.txt_num.Value);
				flag3 = (dataTable.Rows.Count > 0);
				if (!flag3)
				{
					this.Insert();
				}
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00032854 File Offset: 0x00030A54
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "mablagh", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_jam_kol;
				this.txt_jam_kol.Text = e.Value.ToString();
				this.txt_jam_kol.SelectAll();
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000328BC File Offset: 0x00030ABC
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "mablagh", false) == 0;
			if (flag)
			{
				bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (hasValue)
				{
					e.Value = ((CurrencyBox)e.EditControl).Value;
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0003292C File Offset: 0x00030B2C
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Row++;
					this.GridEX1.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00032970 File Offset: 0x00030B70
		private void LoadNumberData(int num)
		{
			DataTable dataTable = Public_Function.FillData("select * from sud where num=" + Conversions.ToString(num));
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				this.chk_sukhte.Enabled = false;
				this.txt_num.Value = Conversions.ToString(num);
				this.txt_az_tarikh.Text = Conversions.ToString(dataTable.Rows[0]["tarikh_fa"]);
				flag = (dataTable.Rows[0]["ta_tarikh"] == DBNull.Value);
				if (flag)
				{
					this.txt_ta_tarikh.Text = Conversions.ToString(dataTable.Rows[0]["tarikh_fa"]);
				}
				else
				{
					this.txt_ta_tarikh.Text = Conversions.ToString(dataTable.Rows[0]["ta_tarikh"]);
				}
				DataTable dataTable2 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from sanad where id in( ", dataTable.Rows[0]["DaramadSanad_ID"]), ","), dataTable.Rows[0]["HazineSanad_ID"]), ")")));
				flag = (dataTable2.Rows.Count > 0);
				if (flag)
				{
					this.txt_daramad.Text = Conversions.ToString(dataTable2.Rows[0]["bed"]);
					this.txt_hazine.Text = Conversions.ToString(dataTable2.Rows[1]["bes"]);
					flag = (dataTable.Rows[0]["mablagh_sukhte"] != DBNull.Value);
					if (flag)
					{
						this.txt_sukhte.Text = Conversions.ToString(dataTable.Rows[0]["mablagh_sukhte"]);
					}
					else
					{
						this.txt_sukhte.Text = Conversions.ToString(0);
					}
					flag = (dataTable.Rows[0]["calc_sukhte"] == DBNull.Value);
					if (flag)
					{
						this.chk_sukhte.Checked = true;
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["calc_sukhte"], 0, false);
						if (flag)
						{
							this.chk_sukhte.Checked = false;
						}
						else
						{
							this.chk_sukhte.Checked = true;
						}
					}
					flag = (dataTable.Rows[0]["mablagh_kasrezafe"] != DBNull.Value);
					bool flag2;
					if (flag)
					{
						flag2 = Operators.ConditionalCompareObjectLess(dataTable.Rows[0]["mablagh_kasrezafe"], 0, false);
						if (flag2)
						{
							this.txt_kasrezafe.Text = Conversions.ToString(Operators.MultiplyObject(dataTable.Rows[0]["mablagh_kasrezafe"], -1));
							this.Label7.Text = "-کسری صندوق";
						}
						else
						{
							this.txt_kasrezafe.Text = Conversions.ToString(dataTable.Rows[0]["mablagh_kasrezafe"]);
							this.Label7.Text = "+اضافی صندوق";
						}
					}
					else
					{
						this.txt_kasrezafe.Text = "0";
					}
					flag2 = (dataTable.Rows[0]["mablagh_barzamin"] != DBNull.Value);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectLess(dataTable.Rows[0]["mablagh_barzamin"], 0, false);
						if (flag)
						{
							this.txt_barzamin.Text = Conversions.ToString(dataTable.Rows[0]["mablagh_barzamin"]);
							this.Label8.Text = "- بارروی زمین";
						}
						else
						{
							this.txt_barzamin.Text = Conversions.ToString(dataTable.Rows[0]["mablagh_barzamin"]);
							this.Label8.Text = "+ بارروی زمین";
						}
					}
					else
					{
						this.txt_barzamin.Text = "0";
					}
					flag2 = (dataTable.Rows[0]["mablagh_hazine"] != DBNull.Value);
					if (flag2)
					{
						this.txt_hazine.Text = Conversions.ToString(dataTable.Rows[0]["mablagh_hazine"]);
					}
					else
					{
						this.txt_hazine.Text = "0";
					}
					flag2 = (dataTable.Rows[0]["mablagh_sud"] != DBNull.Value);
					if (flag2)
					{
						this.txt_sud.Text = Conversions.ToString(dataTable.Rows[0]["mablagh_sud"]);
					}
					else
					{
						this.txt_sud.Text = "0";
					}
					this.LoadPreData((long)num);
					this.GridEX1.RootTable.Columns["mablagh"].EditType = EditType.NoEdit;
				}
			}
			else
			{
				this.chk_sukhte.Enabled = true;
				this.Frm_Sud_Load(null, null);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00032EB4 File Offset: 0x000310B4
		private void txt_num_Previous_Click()
		{
			checked
			{
				long num = (long)Math.Round(unchecked(Conversions.ToDouble(this.txt_num.Value) - 1.0));
				this.LoadNumberData((int)num);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00032EF0 File Offset: 0x000310F0
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف محاسبات سود و زیان شماره " + this.txt_num.Value + " میباشید؟ ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, null) == DialogResult.Yes;
			if (flag)
			{
				DataTable dataTable = Public_Function.FillData("select * from sud where num=" + this.txt_num.Value);
				string text = "";
				string text2 = "";
				flag = (dataTable.Rows.Count > 0);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id in(", dataTable.Rows[0]["DaramadSanad_ID"]), ","), dataTable.Rows[0]["HazineSanad_ID"]), ")")));
					flag = (dataTable.Rows[0]["barzamin_sanad_id"] != DBNull.Value);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" delete from sanad where id= ", dataTable.Rows[0]["barzamin_sanad_id"])));
					}
					DataTable dt = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from sud_detail where sud_id=", dataTable.Rows[0]["ID"])));
					text2 += Public_Function.GetID(dt, "Sanad_ID", "");
					flag = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sud_detail where sud_id=", dataTable.Rows[0]["ID"]), ";")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("delete from sud where id =", dataTable.Rows[0]["ID"])));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update moshtari_listsiah set checked=null where moshtari_id in (select moshtari_id from sud_sukhte where sud_id=", dataTable.Rows[0]["ID"]), ")")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" delete from sud_sukhte where sud_id =", dataTable.Rows[0]["ID"])));
					Public_Function.ExecuteNonQuery(text);
					Public_Function.ShowMessage("اطلاعات مورد نظر حذف گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					this.Frm_Sud_Load(null, null);
				}
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0003316C File Offset: 0x0003136C
		private void txt_num_Next_Click()
		{
			checked
			{
				long num = (long)Math.Round(unchecked(Conversions.ToDouble(this.txt_num.Value) + 1.0));
				this.LoadNumberData((int)num);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000331A8 File Offset: 0x000313A8
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				long num = 0L;
				long? value = this.txt_sud.Value;
				bool? arg_5F_0;
				if (!value.HasValue)
				{
					arg_5F_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(value.GetValueOrDefault() == num);
					arg_5F_0 = flag2;
				}
				bool? flag3 = arg_5F_0;
				bool valueOrDefault = flag3.GetValueOrDefault();
				if (!valueOrDefault)
				{
					this.GridEX1.CurrentRow.BeginEdit();
					this.GridEX1.CurrentRow.Cells["darsad"].Value = decimal.Round(Conversions.ToDecimal(Operators.DivideObject(Operators.MultiplyObject(100, this.GridEX1.CurrentRow.Cells["mablagh"].Value), this.txt_sud.Value)), 2);
					this.GridEX1.CurrentRow.EndEdit();
				}
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002546 File Offset: 0x00000746
		private void chk_sukhte_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_sukhte.Enabled = this.chk_sukhte.Checked;
			this.Calc_sud();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002568 File Offset: 0x00000768
		private void txt_ta_tarikh_Validated(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x040000E5 RID: 229
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("Bar2")]
		private Bar _Bar2;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("Bar3")]
		private Bar _Bar3;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040000F6 RID: 246
		[AccessedThroughProperty("txt_sud")]
		private CurrencyBox _txt_sud;

		// Token: 0x040000F7 RID: 247
		[AccessedThroughProperty("txt_hazine")]
		private CurrencyBox _txt_hazine;

		// Token: 0x040000F8 RID: 248
		[AccessedThroughProperty("txt_daramad")]
		private CurrencyBox _txt_daramad;

		// Token: 0x040000F9 RID: 249
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040000FA RID: 250
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040000FB RID: 251
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040000FC RID: 252
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040000FD RID: 253
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040000FE RID: 254
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("txt_sukhte")]
		private CurrencyBox _txt_sukhte;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("txt_kasrezafe")]
		private CurrencyBox _txt_kasrezafe;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("txt_barzamin")]
		private CurrencyBox _txt_barzamin;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("chk_sukhte")]
		private UICheckBox _chk_sukhte;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("Label11")]
		private Label _Label11;
	}
}
