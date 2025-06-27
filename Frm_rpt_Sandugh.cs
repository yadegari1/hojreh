using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
	// Token: 0x02000138 RID: 312
	[DesignerGenerated]
	public partial class Frm_rpt_Sandugh : Form
	{
		// Token: 0x06002D0D RID: 11533 RVA: 0x002178A8 File Offset: 0x00215AA8
		public Frm_rpt_Sandugh()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_Sandugh_KeyDown);
			base.Load += new EventHandler(this.Frm_rpt_Sandugh_Load);
			Frm_rpt_Sandugh.__ENCAddToList(this);
			string empty = string.Empty;
			this.tarikh = empty;
			this.InitializeComponent();
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00217904 File Offset: 0x00215B04
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_Sandugh.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_Sandugh.__ENCList.Count == Frm_rpt_Sandugh.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_Sandugh.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_Sandugh.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_Sandugh.__ENCList[num] = Frm_rpt_Sandugh.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_Sandugh.__ENCList.RemoveRange(num, Frm_rpt_Sandugh.__ENCList.Count - num);
						Frm_rpt_Sandugh.__ENCList.Capacity = Frm_rpt_Sandugh.__ENCList.Count;
					}
					Frm_rpt_Sandugh.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x0021ABD4 File Offset: 0x00218DD4
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x0000B5E9 File Offset: 0x000097E9
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

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x0021ABEC File Offset: 0x00218DEC
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x0021AC04 File Offset: 0x00218E04
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
				KeyEventHandler value2 = new KeyEventHandler(this.DateBox21_KeyDown);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.KeyDown -= value2;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x0021AC64 File Offset: 0x00218E64
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x0000B5F3 File Offset: 0x000097F3
		internal virtual EditBox txt_ruzegabl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ruzegabl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_ruzegabl = value;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x0021AC7C File Offset: 0x00218E7C
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x0000B5FD File Offset: 0x000097FD
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x0021AC94 File Offset: 0x00218E94
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x0000B607 File Offset: 0x00009807
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

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x0021ACAC File Offset: 0x00218EAC
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x0000B611 File Offset: 0x00009811
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

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x0021ACC4 File Offset: 0x00218EC4
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x0000B61B File Offset: 0x0000981B
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

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x0021ACDC File Offset: 0x00218EDC
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x0021ACF4 File Offset: 0x00218EF4
		internal virtual EditBox txt_daryaftnaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_daryaftnaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_daryaftnaghd_ButtonClick);
				bool flag = this._txt_daryaftnaghd != null;
				if (flag)
				{
					this._txt_daryaftnaghd.ButtonClick -= value2;
				}
				this._txt_daryaftnaghd = value;
				flag = (this._txt_daryaftnaghd != null);
				if (flag)
				{
					this._txt_daryaftnaghd.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x0021AD54 File Offset: 0x00218F54
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x0021AD6C File Offset: 0x00218F6C
		internal virtual EditBox txt_furushnaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_furushnaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_furushnaghd_ButtonClick);
				bool flag = this._txt_furushnaghd != null;
				if (flag)
				{
					this._txt_furushnaghd.ButtonClick -= value2;
				}
				this._txt_furushnaghd = value;
				flag = (this._txt_furushnaghd != null);
				if (flag)
				{
					this._txt_furushnaghd.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x0021ADCC File Offset: 0x00218FCC
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0000B625 File Offset: 0x00009825
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

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x0021ADE4 File Offset: 0x00218FE4
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x0000B62F File Offset: 0x0000982F
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x0021ADFC File Offset: 0x00218FFC
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x0021AE14 File Offset: 0x00219014
		internal virtual EditBox txt_daramad
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
				EventHandler value2 = new EventHandler(this.txt_daramad_ButtonClick);
				bool flag = this._txt_daramad != null;
				if (flag)
				{
					this._txt_daramad.ButtonClick -= value2;
				}
				this._txt_daramad = value;
				flag = (this._txt_daramad != null);
				if (flag)
				{
					this._txt_daramad.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x0021AE74 File Offset: 0x00219074
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x0021AE8C File Offset: 0x0021908C
		internal virtual EditBox txt_naghdkardancheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_naghdkardancheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_naghdkardancheck_ButtonClick);
				bool flag = this._txt_naghdkardancheck != null;
				if (flag)
				{
					this._txt_naghdkardancheck.ButtonClick -= value2;
				}
				this._txt_naghdkardancheck = value;
				flag = (this._txt_naghdkardancheck != null);
				if (flag)
				{
					this._txt_naghdkardancheck.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x0021AEEC File Offset: 0x002190EC
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x0000B639 File Offset: 0x00009839
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

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x0021AF04 File Offset: 0x00219104
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x0000B643 File Offset: 0x00009843
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

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x0021AF1C File Offset: 0x0021911C
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x0000B64D File Offset: 0x0000984D
		internal virtual EditBox txt_jamdaryaft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jamdaryaft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jamdaryaft = value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x0021AF34 File Offset: 0x00219134
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x0000B657 File Offset: 0x00009857
		internal virtual UIGroupBox UiGroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox3 = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x0021AF4C File Offset: 0x0021914C
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x0000B661 File Offset: 0x00009861
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

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x0021AF64 File Offset: 0x00219164
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x0000B66B File Offset: 0x0000986B
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

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x0021AF7C File Offset: 0x0021917C
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0000B675 File Offset: 0x00009875
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

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x0021AF94 File Offset: 0x00219194
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x0000B67F File Offset: 0x0000987F
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

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x0021AFAC File Offset: 0x002191AC
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x0021AFC4 File Offset: 0x002191C4
		internal virtual EditBox txt_entegalvajh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_entegalvajh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_entegalvajh_ButtonClick);
				bool flag = this._txt_entegalvajh != null;
				if (flag)
				{
					this._txt_entegalvajh.ButtonClick -= value2;
				}
				this._txt_entegalvajh = value;
				flag = (this._txt_entegalvajh != null);
				if (flag)
				{
					this._txt_entegalvajh.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x0021B024 File Offset: 0x00219224
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x0021B03C File Offset: 0x0021923C
		internal virtual EditBox txt_pardakhthazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pardakhthazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_pardakhthazine_ButtonClick);
				bool flag = this._txt_pardakhthazine != null;
				if (flag)
				{
					this._txt_pardakhthazine.ButtonClick -= value2;
				}
				this._txt_pardakhthazine = value;
				flag = (this._txt_pardakhthazine != null);
				if (flag)
				{
					this._txt_pardakhthazine.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0021B09C File Offset: 0x0021929C
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x0021B0B4 File Offset: 0x002192B4
		internal virtual EditBox txt_pardakhtkeraye
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pardakhtkeraye;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_pardakhtkeraye_ButtonClick);
				bool flag = this._txt_pardakhtkeraye != null;
				if (flag)
				{
					this._txt_pardakhtkeraye.ButtonClick -= value2;
				}
				this._txt_pardakhtkeraye = value;
				flag = (this._txt_pardakhtkeraye != null);
				if (flag)
				{
					this._txt_pardakhtkeraye.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0021B114 File Offset: 0x00219314
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x0021B12C File Offset: 0x0021932C
		internal virtual EditBox txt_pardakhtnaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pardakhtnaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_pardakhtnaghd_ButtonClick);
				bool flag = this._txt_pardakhtnaghd != null;
				if (flag)
				{
					this._txt_pardakhtnaghd.ButtonClick -= value2;
				}
				this._txt_pardakhtnaghd = value;
				flag = (this._txt_pardakhtnaghd != null);
				if (flag)
				{
					this._txt_pardakhtnaghd.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x0021B18C File Offset: 0x0021938C
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x0000B689 File Offset: 0x00009889
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

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0021B1A4 File Offset: 0x002193A4
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x0000B693 File Offset: 0x00009893
		internal virtual EditBox txt_jampardakhti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jampardakhti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jampardakhti = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x0021B1BC File Offset: 0x002193BC
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x0000B69D File Offset: 0x0000989D
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x0021B1D4 File Offset: 0x002193D4
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x0000B6A7 File Offset: 0x000098A7
		internal virtual Label lbl_kasrezafe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_kasrezafe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_kasrezafe = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x0021B1EC File Offset: 0x002193EC
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x0000B6B1 File Offset: 0x000098B1
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

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x0021B204 File Offset: 0x00219404
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x0000B6BB File Offset: 0x000098BB
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

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x0021B21C File Offset: 0x0021941C
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x0000B6C5 File Offset: 0x000098C5
		internal virtual EditBox txt_kasrezafe
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

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x0021B234 File Offset: 0x00219434
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x0000B6CF File Offset: 0x000098CF
		internal virtual EditBox txt_mojod
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mojod;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mojod = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x0021B24C File Offset: 0x0021944C
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x0000B6D9 File Offset: 0x000098D9
		internal virtual EditBox txt_mande
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mande;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mande = value;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x0021B264 File Offset: 0x00219464
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0000B6E3 File Offset: 0x000098E3
		internal virtual Label lbl_ruzegabl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_ruzegabl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_ruzegabl = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x0021B27C File Offset: 0x0021947C
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x0000B6ED File Offset: 0x000098ED
		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x0021B294 File Offset: 0x00219494
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0021B2AC File Offset: 0x002194AC
		internal virtual EditBox txt_furushbar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_furushbar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_furushbar_ButtonClick);
				bool flag = this._txt_furushbar != null;
				if (flag)
				{
					this._txt_furushbar.ButtonClick -= value2;
				}
				this._txt_furushbar = value;
				flag = (this._txt_furushbar != null);
				if (flag)
				{
					this._txt_furushbar.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x0021B30C File Offset: 0x0021950C
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x0021B324 File Offset: 0x00219524
		internal virtual EditBox txt_kartkhan
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kartkhan;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_kartkhan_ButtonClick);
				bool flag = this._txt_kartkhan != null;
				if (flag)
				{
					this._txt_kartkhan.ButtonClick -= value2;
				}
				this._txt_kartkhan = value;
				flag = (this._txt_kartkhan != null);
				if (flag)
				{
					this._txt_kartkhan.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x0021B384 File Offset: 0x00219584
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x0000B6F7 File Offset: 0x000098F7
		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x0021B39C File Offset: 0x0021959C
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x0000B701 File Offset: 0x00009901
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

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x0021B3B4 File Offset: 0x002195B4
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x0021B3CC File Offset: 0x002195CC
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x0021B42C File Offset: 0x0021962C
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x0000B70B File Offset: 0x0000990B
		internal virtual DataEntryGrid GridEx1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEx1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEx1 = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x0021B444 File Offset: 0x00219644
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x0000B715 File Offset: 0x00009915
		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x0021B45C File Offset: 0x0021965C
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x0021B474 File Offset: 0x00219674
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

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x0021B4D4 File Offset: 0x002196D4
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x0000B71F File Offset: 0x0000991F
		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x0021B4EC File Offset: 0x002196EC
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x0021B504 File Offset: 0x00219704
		internal virtual EditBox txt_bank_be_sandugh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank_be_sandugh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_bank_be_sandugh_TextChanged);
				bool flag = this._txt_bank_be_sandugh != null;
				if (flag)
				{
					this._txt_bank_be_sandugh.ButtonClick -= value2;
				}
				this._txt_bank_be_sandugh = value;
				flag = (this._txt_bank_be_sandugh != null);
				if (flag)
				{
					this._txt_bank_be_sandugh.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x0021B564 File Offset: 0x00219764
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x0000B729 File Offset: 0x00009929
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x0021B57C File Offset: 0x0021977C
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x0021B594 File Offset: 0x00219794
		internal virtual EditBox txt_checknaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_checknaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_daramad_ButtonClick);
				bool flag = this._txt_checknaghd != null;
				if (flag)
				{
					this._txt_checknaghd.ButtonClick -= value2;
				}
				this._txt_checknaghd = value;
				flag = (this._txt_checknaghd != null);
				if (flag)
				{
					this._txt_checknaghd.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x0021B5F4 File Offset: 0x002197F4
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x0000B733 File Offset: 0x00009933
		public string tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._tarikh = value;
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0021B60C File Offset: 0x0021980C
		private void LoadData(string tarikh)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select top 1 isnull(mande,0) from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " order by tarikh desc "));
			bool flag = num != 0L;
			if (flag)
			{
				this.txt_ruzegabl.Text = Public_Function.FormatPrice(Conversions.ToString(num));
				this.lbl_ruzegabl.Text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 isnull(tarikh_fa,0) from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " order by tarikh desc "));
			}
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(-1)"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(1)"));
			long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(6)"));
			long num5 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(26)"));
			long num6 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(28) and moshtari_id=-1"));
			long num7 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(27)"));
			long num8 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(40)"));
			long num9 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(42)"));
			this.txt_furushnaghd.Text = Public_Function.FormatPrice(Conversions.ToString(num2));
			this.txt_daryaftnaghd.Text = Public_Function.FormatPrice(Conversions.ToString(num3));
			this.txt_daramad.Text = Public_Function.FormatPrice(Conversions.ToString(num4));
			this.txt_naghdkardancheck.Text = Public_Function.FormatPrice(Conversions.ToString(num5));
			this.txt_furushbar.Text = Public_Function.FormatPrice(Conversions.ToString(num6));
			this.txt_kartkhan.Text = Public_Function.FormatPrice(Conversions.ToString(num7));
			this.txt_bank_be_sandugh.Text = Public_Function.FormatPrice(Conversions.ToString(num8));
			this.txt_checknaghd.Text = Public_Function.FormatPrice(Conversions.ToString(num9));
			checked
			{
				long num10 = num2 + num3 + num4 + num5 + num6 + num8 - num9 - num7;
				this.txt_jamdaryaft.Text = Public_Function.FormatPrice(Conversions.ToString(num10));
				long num11 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(10)"));
				long num12 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(-2,-3)"));
				long num13 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(15) and sh_check is null and bankhesab_id is null "));
				long num14 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(14)"));
				this.txt_pardakhtnaghd.Text = Public_Function.FormatPrice(Conversions.ToString(num11));
				this.txt_pardakhtkeraye.Text = Public_Function.FormatPrice(Conversions.ToString(num12));
				this.txt_pardakhthazine.Text = Public_Function.FormatPrice(Conversions.ToString(num13));
				this.txt_entegalvajh.Text = Public_Function.FormatPrice(Conversions.ToString(num14));
				long num15 = num11 + num12 + num13 + num14;
				this.txt_jampardakhti.Text = Public_Function.FormatPrice(Conversions.ToString(num15));
				long num16 = num + num10 - num15;
				this.txt_mojod.Text = Public_Function.FormatPrice(Conversions.ToString(num16));
				flag = Operators.ConditionalCompareObjectGreater(Public_Function.ExecuteScalar("select count(mande) from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh))), 0, false);
				if (flag)
				{
					long num17 = Conversions.ToLong(Public_Function.ExecuteScalar("select mande from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh))));
					this.txt_mande.Text = Public_Function.FormatPrice(Conversions.ToString(num17));
					flag = (num17 == num16);
					if (!flag)
					{
						flag = (num17 > num16);
						if (flag)
						{
							this.txt_kasrezafe.Text = Public_Function.FormatPrice(Conversions.ToString(num17 - num16));
							this.lbl_kasrezafe.Text = "اضافی صندوق";
						}
						else
						{
							this.txt_kasrezafe.Text = Public_Function.FormatPrice(Conversions.ToString(num16 - num17));
							this.lbl_kasrezafe.Text = "کسری صندوق";
						}
					}
				}
				else
				{
					this.txt_kasrezafe.Text = string.Empty;
					this.txt_mande.Text = string.Empty;
				}
			}
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x0021BAF8 File Offset: 0x00219CF8
		private void LoadDetail(string dptype_id)
		{
			this.GridEx1.RootTable.Columns["moshtari_name"].Visible = true;
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Mablagh AS Mablagh2,isnull(DaryaftPardakht.Tozih,' ') AS Tozih,         DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab,   DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" AND dpType_id in(",
				dptype_id,
				") order by DaryaftPardakht.ID"
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -1, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 6, false);
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_Name"]);
					}
					flag = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 27, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 40, false));
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false))
					{
						goto IL_1E3;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false))
					{
						goto IL_1E3;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_1FF;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false))
					{
						goto IL_21E;
					}
					bool arg_220_0 = false;
					IL_21F:
					flag = arg_220_0;
					bool flag2;
					if (flag)
					{
						flag2 = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag2)
						{
							dataRow["Tozih"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )");
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_316_0 = dataRow2;
							string columnName = "Tozih";
							arg_316_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )"));
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag)
						{
							dataRow["tozih"] = RuntimeHelpers.GetObjectValue(dataRow["sh_check"]);
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_3B2_0 = dataRow2;
							string columnName = "tozih";
							arg_3B2_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(" (", dataRow["sh_check"]), " )"));
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 14, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false));
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 30, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
					}
					continue;
					IL_21E:
					arg_220_0 = true;
					goto IL_21F;
					IL_1FF:
					goto IL_21E;
					IL_1E3:
					goto IL_1FF;
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
			this.Addfilter(dataTable, this.GridEx1);
			this.GridEx1.DataSource = dataTable;
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x0021C038 File Offset: 0x0021A238
		private void LoadCheckDetail()
		{
			this.GridEx1.RootTable.Columns["moshtari_name"].Visible = true;
			string text = string.Empty;
			DataTable dt = Public_Function.FillData("select pardakhtcheck_id from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " and dptype_id=26");
			text = Public_Function.GetID(dt, "pardakhtcheck_id", "");
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				this.GridEx1.DataSource = null;
			}
			else
			{
				DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh,isnull( DaryaftPardakht.Tozih,' ') AS Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS CheckBank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99) And check_Status in (3) and DaryaftPardakht.id in(" + text + ") order by DaryaftPardakht.ID");
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag)
						{
							dataRow["Tozih"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )");
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_1AF_0 = dataRow2;
							string columnName = "Tozih";
							arg_1AF_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )"));
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
				this.Addfilter(dataTable, this.GridEx1);
				this.GridEx1.DataSource = dataTable;
			}
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x0021C26C File Offset: 0x0021A46C
		private void LoadKeraye()
		{
			this.GridEx1.RootTable.Columns["moshtari_name"].Visible = true;
			DataTable dataTable = Public_Function.FillData("SELECT     'فروش سند شماره ' + CAST(Furush_Hag.Num AS nvarchar(100)) AS Moshtari_Name, Furush_Keraye.Keraye AS Mablagh, Hazine_Kharid.Name AS Hazine_Name,'' as Tozih,   Kala.Name AS Kala_Name   FROM         Furush_Keraye INNER JOIN  Hazine_Kharid ON Furush_Keraye.HazineKharid_ID = Hazine_Kharid.ID INNER JOIN  Furush_Hag ON Furush_Keraye.Furush_ID = Furush_Hag.ID LEFT OUTER JOIN  Kala ON Furush_Keraye.Kala_ID = Kala.ID  where Furush_Keraye.Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " union all  SELECT     'خرید سند شماره ' + CAST(Kharid.Num AS nvarchar(10)) AS Moshtari_Name, Kharid_Keraye.Keraye AS Mablagh, Hazine_Kharid.Name AS Hazine_Name,'' as Tozih,   Kala.Name AS Kala_Name  FROM         Kharid_Keraye LEFT OUTER JOIN  Kala ON Kharid_Keraye.Kala_ID = Kala.ID INNER JOIN  Kharid ON Kharid_Keraye.Kharid_ID = Kharid.ID INNER JOIN  Hazine_Kharid ON Kharid_Keraye.HazineKharid_ID = Hazine_Kharid.ID where Kharid_Keraye.Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_Name"]);
					bool flag = dataRow["Kala_Name"] != null;
					if (flag)
					{
						DataRow dataRow2 = dataRow;
						DataRow arg_DD_0 = dataRow2;
						string columnName = "Tozih";
						arg_DD_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" - ", dataRow["kala_Name"]));
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
			this.Addfilter(dataTable, this.GridEx1);
			this.GridEx1.DataSource = dataTable;
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00214E78 File Offset: 0x00213078
		private void Addfilter(DataTable dt, GridEX Grid)
		{
			string text = string.Empty;
			DataColumn dataColumn = new DataColumn("filter", typeof(string));
			bool flag = !dt.Columns.Contains("filter");
			if (flag)
			{
				dt.Columns.Add(dataColumn);
			}
			try
			{
				IEnumerator enumerator = Grid.RootTable.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
					flag = gridEXColumn.Visible;
					if (flag)
					{
						text = text + gridEXColumn.DataMember + "+";
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
			text = Public_Function.RemoveLast(text);
			dataColumn.Expression = text;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x0000B73D File Offset: 0x0000993D
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEx1, this.EditBox1.Text);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_rpt_Sandugh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x0021C3BC File Offset: 0x0021A5BC
		private void Frm_rpt_Sandugh_Load(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.tarikh, string.Empty, false) == 0;
			if (flag)
			{
				this.LoadData(Public_Function.MiladiToShamsi(DateAndTime.Now));
				this.txt_tarikh.SetNew();
			}
			else
			{
				this.LoadData(this.tarikh);
				this.txt_tarikh.SetDate(this.tarikh);
			}
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x0000B758 File Offset: 0x00009958
		private void DateBox21_KeyDown(object sender, KeyEventArgs e)
		{
			this.LoadData(this.txt_tarikh.Text);
			this.GridEx1.DataSource = null;
			this.Label16.Text = string.Empty;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x0000B78C File Offset: 0x0000998C
		private void txt_furushnaghd_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(-1));
			this.Label16.Text = this.Label3.Text;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x0000B7B4 File Offset: 0x000099B4
		private void txt_daryaftnaghd_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(1));
			this.Label16.Text = this.Label4.Text;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x0000B7DC File Offset: 0x000099DC
		private void txt_furushbar_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(28));
			this.Label16.Text = this.Label17.Text;
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x0000B805 File Offset: 0x00009A05
		private void txt_naghdkardancheck_ButtonClick(object sender, EventArgs e)
		{
			this.LoadCheckDetail();
			this.Label16.Text = this.Label5.Text;
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x0000B827 File Offset: 0x00009A27
		private void txt_pardakhtnaghd_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(10));
			this.Label16.Text = this.Label8.Text;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x0000B850 File Offset: 0x00009A50
		private void txt_pardakhtkeraye_ButtonClick(object sender, EventArgs e)
		{
			this.LoadKeraye();
			this.Label16.Text = this.Label9.Text;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0000B872 File Offset: 0x00009A72
		private void txt_pardakhthazine_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(15));
			this.Label16.Text = this.Label11.Text;
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x0000B89B File Offset: 0x00009A9B
		private void txt_entegalvajh_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(14));
			this.Label16.Text = this.Label12.Text;
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		private void txt_kartkhan_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(27));
			this.Label16.Text = this.Label18.Text;
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x0021C424 File Offset: 0x0021A624
		private void LoadDaramadDetail()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT   isnull(Sanad.Bes-Sanad.Bed,0) AS Mablagh, Sanad.CodeHesab_ID, Sanad.Tozih, Sanad.Tarikh, Sanad.Tarikh_Fa   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID   WHERE     (Code_Hesab.Grouh_ID = 7) AND (Code_Hesab.ID = 11) AND Sanad.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" UNION ALL SELECT   isnull(Sanad.Bes-Sanad.Bed,0) AS Mablagh, Sanad.CodeHesab_ID, Sanad.Tozih, Sanad.Tarikh, Sanad.Tarikh_Fa   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID   WHERE     (Code_Hesab.Grouh_ID = 7) AND (Code_Hesab.ID = 12) AND Sanad.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" UNION ALL SELECT     isnull(Sanad.Bes-Sanad.Bed,0) AS Mablagh, Sanad.CodeHesab_ID, Sanad.Tozih, Sanad.Tarikh, Sanad.Tarikh_Fa   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID   WHERE     (Code_Hesab.Grouh_ID = 7) AND (Code_Hesab.ID = 13) AND Sanad.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))
			}));
			this.GridEx1.RootTable.Columns["moshtari_name"].Visible = false;
			this.Addfilter(dataTable, this.GridEx1);
			this.GridEx1.DataSource = dataTable;
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0000B8ED File Offset: 0x00009AED
		private void txt_daramad_ButtonClick(object sender, EventArgs e)
		{
			this.LoadDaramadDetail();
			this.Label16.Text = this.Label6.Text;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0021C4E8 File Offset: 0x0021A6E8
		private void UiButton2_Click(object sender, EventArgs e)
		{
			GridPrint gridPrint = new GridPrint();
			gridPrint.PrintGrid(this.GridEx1, "گزارش " + this.Label16.Text + " مورخه " + this.txt_tarikh.Text);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x0000B90F File Offset: 0x00009B0F
		private void txt_bank_be_sandugh_TextChanged(object sender, EventArgs e)
		{
			this.LoadDetail(Conversions.ToString(40));
			this.Label16.Text = this.Label19.Text;
		}

		// Token: 0x04001180 RID: 4480
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001182 RID: 4482
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001183 RID: 4483
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04001184 RID: 4484
		[AccessedThroughProperty("txt_ruzegabl")]
		private EditBox _txt_ruzegabl;

		// Token: 0x04001185 RID: 4485
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001186 RID: 4486
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001187 RID: 4487
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001188 RID: 4488
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001189 RID: 4489
		[AccessedThroughProperty("txt_daryaftnaghd")]
		private EditBox _txt_daryaftnaghd;

		// Token: 0x0400118A RID: 4490
		[AccessedThroughProperty("txt_furushnaghd")]
		private EditBox _txt_furushnaghd;

		// Token: 0x0400118B RID: 4491
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400118C RID: 4492
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400118D RID: 4493
		[AccessedThroughProperty("txt_daramad")]
		private EditBox _txt_daramad;

		// Token: 0x0400118E RID: 4494
		[AccessedThroughProperty("txt_naghdkardancheck")]
		private EditBox _txt_naghdkardancheck;

		// Token: 0x0400118F RID: 4495
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04001190 RID: 4496
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04001191 RID: 4497
		[AccessedThroughProperty("txt_jamdaryaft")]
		private EditBox _txt_jamdaryaft;

		// Token: 0x04001192 RID: 4498
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x04001193 RID: 4499
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04001194 RID: 4500
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04001195 RID: 4501
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04001196 RID: 4502
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04001197 RID: 4503
		[AccessedThroughProperty("txt_entegalvajh")]
		private EditBox _txt_entegalvajh;

		// Token: 0x04001198 RID: 4504
		[AccessedThroughProperty("txt_pardakhthazine")]
		private EditBox _txt_pardakhthazine;

		// Token: 0x04001199 RID: 4505
		[AccessedThroughProperty("txt_pardakhtkeraye")]
		private EditBox _txt_pardakhtkeraye;

		// Token: 0x0400119A RID: 4506
		[AccessedThroughProperty("txt_pardakhtnaghd")]
		private EditBox _txt_pardakhtnaghd;

		// Token: 0x0400119B RID: 4507
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x0400119C RID: 4508
		[AccessedThroughProperty("txt_jampardakhti")]
		private EditBox _txt_jampardakhti;

		// Token: 0x0400119D RID: 4509
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x0400119E RID: 4510
		[AccessedThroughProperty("lbl_kasrezafe")]
		private Label _lbl_kasrezafe;

		// Token: 0x0400119F RID: 4511
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040011A0 RID: 4512
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040011A1 RID: 4513
		[AccessedThroughProperty("txt_kasrezafe")]
		private EditBox _txt_kasrezafe;

		// Token: 0x040011A2 RID: 4514
		[AccessedThroughProperty("txt_mojod")]
		private EditBox _txt_mojod;

		// Token: 0x040011A3 RID: 4515
		[AccessedThroughProperty("txt_mande")]
		private EditBox _txt_mande;

		// Token: 0x040011A4 RID: 4516
		[AccessedThroughProperty("lbl_ruzegabl")]
		private Label _lbl_ruzegabl;

		// Token: 0x040011A5 RID: 4517
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x040011A6 RID: 4518
		[AccessedThroughProperty("txt_furushbar")]
		private EditBox _txt_furushbar;

		// Token: 0x040011A7 RID: 4519
		[AccessedThroughProperty("txt_kartkhan")]
		private EditBox _txt_kartkhan;

		// Token: 0x040011A8 RID: 4520
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x040011A9 RID: 4521
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040011AA RID: 4522
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040011AB RID: 4523
		[AccessedThroughProperty("GridEx1")]
		private DataEntryGrid _GridEx1;

		// Token: 0x040011AC RID: 4524
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040011AD RID: 4525
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040011AE RID: 4526
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x040011AF RID: 4527
		[AccessedThroughProperty("txt_bank_be_sandugh")]
		private EditBox _txt_bank_be_sandugh;

		// Token: 0x040011B0 RID: 4528
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x040011B1 RID: 4529
		[AccessedThroughProperty("txt_checknaghd")]
		private EditBox _txt_checknaghd;

		// Token: 0x040011B2 RID: 4530
		[CompilerGenerated]
		private string _tarikh;
	}
}
