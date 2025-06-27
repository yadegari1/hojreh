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
	// Token: 0x02000101 RID: 257
	[DesignerGenerated]
	public partial class Frm_Pardakht_BeMoshtari : Form
	{
		// Token: 0x060021A1 RID: 8609 RVA: 0x001900CC File Offset: 0x0018E2CC
		public Frm_Pardakht_BeMoshtari()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_Pardakht_BeMoshtari.__ENCAddToList(this);
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

		// Token: 0x060021A2 RID: 8610 RVA: 0x0019019C File Offset: 0x0018E39C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Pardakht_BeMoshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Pardakht_BeMoshtari.__ENCList.Count == Frm_Pardakht_BeMoshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Pardakht_BeMoshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Pardakht_BeMoshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Pardakht_BeMoshtari.__ENCList[num] = Frm_Pardakht_BeMoshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Pardakht_BeMoshtari.__ENCList.RemoveRange(num, Frm_Pardakht_BeMoshtari.__ENCList.Count - num);
						Frm_Pardakht_BeMoshtari.__ENCList.Capacity = Frm_Pardakht_BeMoshtari.__ENCList.Count;
					}
					Frm_Pardakht_BeMoshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00192BBC File Offset: 0x00190DBC
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00192BD4 File Offset: 0x00190DD4
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

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00192D08 File Offset: 0x00190F08
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x00008B8A File Offset: 0x00006D8A
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

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00192D20 File Offset: 0x00190F20
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00192D38 File Offset: 0x00190F38
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

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00192EEC File Offset: 0x001910EC
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00008B94 File Offset: 0x00006D94
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

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00192F04 File Offset: 0x00191104
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00192F1C File Offset: 0x0019111C
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

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00192F7C File Offset: 0x0019117C
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00008B9E File Offset: 0x00006D9E
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00192F94 File Offset: 0x00191194
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00192FAC File Offset: 0x001911AC
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

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0019300C File Offset: 0x0019120C
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x00008BA8 File Offset: 0x00006DA8
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

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00193024 File Offset: 0x00191224
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x00008BB2 File Offset: 0x00006DB2
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

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0019303C File Offset: 0x0019123C
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x00008BBC File Offset: 0x00006DBC
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

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00193054 File Offset: 0x00191254
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x00008BC6 File Offset: 0x00006DC6
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0019306C File Offset: 0x0019126C
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00008BD0 File Offset: 0x00006DD0
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

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00193084 File Offset: 0x00191284
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00008BDA File Offset: 0x00006DDA
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

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0019309C File Offset: 0x0019129C
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x00008BE4 File Offset: 0x00006DE4
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

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x001930B4 File Offset: 0x001912B4
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x00008BEE File Offset: 0x00006DEE
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

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x001930CC File Offset: 0x001912CC
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x00008BF8 File Offset: 0x00006DF8
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

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x001930E4 File Offset: 0x001912E4
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x00008C02 File Offset: 0x00006E02
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

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x001930FC File Offset: 0x001912FC
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00008C0C File Offset: 0x00006E0C
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

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00193114 File Offset: 0x00191314
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x00008C16 File Offset: 0x00006E16
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x0019312C File Offset: 0x0019132C
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00008C20 File Offset: 0x00006E20
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

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x00193144 File Offset: 0x00191344
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00008C2A File Offset: 0x00006E2A
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

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x0019315C File Offset: 0x0019135C
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00193174 File Offset: 0x00191374
		internal virtual CurrencyBox txt_cart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_cart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_cart_ButtonClick);
				CancelEventHandler value3 = new CancelEventHandler(this.txt_cart_Validating);
				bool flag = this._txt_cart != null;
				if (flag)
				{
					this._txt_cart.ButtonClick -= value2;
					this._txt_cart.Validating -= value3;
				}
				this._txt_cart = value;
				flag = (this._txt_cart != null);
				if (flag)
				{
					this._txt_cart.ButtonClick += value2;
					this._txt_cart.Validating += value3;
				}
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x001931FC File Offset: 0x001913FC
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x00008C34 File Offset: 0x00006E34
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

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00193214 File Offset: 0x00191414
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00008C3E File Offset: 0x00006E3E
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

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0019322C File Offset: 0x0019142C
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00008C48 File Offset: 0x00006E48
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

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00193244 File Offset: 0x00191444
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00008C52 File Offset: 0x00006E52
		internal virtual SelectItem txt_kart_bankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kart_bankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kart_bankhesab = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0019325C File Offset: 0x0019145C
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00008C5C File Offset: 0x00006E5C
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

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x00193274 File Offset: 0x00191474
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x00008C66 File Offset: 0x00006E66
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

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0019328C File Offset: 0x0019148C
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x00008C70 File Offset: 0x00006E70
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

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x001932A4 File Offset: 0x001914A4
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00008C7A File Offset: 0x00006E7A
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x001932BC File Offset: 0x001914BC
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x001932D4 File Offset: 0x001914D4
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

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00193334 File Offset: 0x00191534
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x00008C84 File Offset: 0x00006E84
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0019334C File Offset: 0x0019154C
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x00008C8E File Offset: 0x00006E8E
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

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x00193364 File Offset: 0x00191564
		// (set) Token: 0x060021E8 RID: 8680 RVA: 0x00008C98 File Offset: 0x00006E98
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

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0019337C File Offset: 0x0019157C
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x00008CA2 File Offset: 0x00006EA2
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x00193394 File Offset: 0x00191594
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x00008CAC File Offset: 0x00006EAC
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

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x001933AC File Offset: 0x001915AC
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x00008CB6 File Offset: 0x00006EB6
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

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x001933C4 File Offset: 0x001915C4
		// (set) Token: 0x060021F0 RID: 8688 RVA: 0x00008CC0 File Offset: 0x00006EC0
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

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x001933DC File Offset: 0x001915DC
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00008CCA File Offset: 0x00006ECA
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

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x001933F4 File Offset: 0x001915F4
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00008CD4 File Offset: 0x00006ED4
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

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0019340C File Offset: 0x0019160C
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00008CDE File Offset: 0x00006EDE
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

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00193424 File Offset: 0x00191624
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00008CE8 File Offset: 0x00006EE8
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

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0019343C File Offset: 0x0019163C
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x00008CF2 File Offset: 0x00006EF2
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

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00193454 File Offset: 0x00191654
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x00008CFC File Offset: 0x00006EFC
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x0019346C File Offset: 0x0019166C
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x00008D06 File Offset: 0x00006F06
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

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00193484 File Offset: 0x00191684
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x00008D10 File Offset: 0x00006F10
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x0019349C File Offset: 0x0019169C
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x00008D1A File Offset: 0x00006F1A
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

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x001934B4 File Offset: 0x001916B4
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x00008D24 File Offset: 0x00006F24
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

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x001934CC File Offset: 0x001916CC
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00008D2E File Offset: 0x00006F2E
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

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x001934E4 File Offset: 0x001916E4
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x00008D38 File Offset: 0x00006F38
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

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x001934FC File Offset: 0x001916FC
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x00008D42 File Offset: 0x00006F42
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

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00193514 File Offset: 0x00191714
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00008D4C File Offset: 0x00006F4C
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

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0019352C File Offset: 0x0019172C
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x00008D56 File Offset: 0x00006F56
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

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00193544 File Offset: 0x00191744
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x00008D60 File Offset: 0x00006F60
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

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x0019355C File Offset: 0x0019175C
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x00008D6A File Offset: 0x00006F6A
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

		// Token: 0x06002213 RID: 8723 RVA: 0x00193574 File Offset: 0x00191774
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

		// Token: 0x06002214 RID: 8724 RVA: 0x00193764 File Offset: 0x00191964
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
					flag = (Operators.CompareString(this.txt_cart.Text, string.Empty, false) != 0);
					if (flag)
					{
						bool flag2 = this.txt_kart_bankhesab.Value == null;
						if (flag2)
						{
							Public_Function.ShowTip(this.txt_kart_bankhesab, "لطفا حساب بانکی را انتخاب فرمایید");
							result = false;
							return result;
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		private bool Check_SayerAmaliyat(long id, string Tarikh)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from daryaftpardakht where pardakhtcheck_id=" + Conversions.ToString(id) + " and tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))));
			bool flag = num == 0;
			return !flag;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00193A4C File Offset: 0x00191C4C
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
				value3 = this.txt_cart.Value;
				hasValue = value3.HasValue;
				if (hasValue)
				{
					long? value2 = this.txt_cart.Value;
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

		// Token: 0x06002217 RID: 8727 RVA: 0x00193B5C File Offset: 0x00191D5C
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT  DaryaftPardakht.*,dptype.[type],  Bank.Name+' '+ Bank_Hesab.Shobe+' - '+ Bank_Hesab.SahebHesab as bankname  FROM    Bank_Hesab LEFT OUTER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID RIGHT OUTER JOIN  DaryaftPardakht INNER JOIN  dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID  WHERE  (DaryaftPardakht.Tarikh = ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				")  AND (DaryaftPardakht.Moshtari_ID = ",
				this.Moshtari_ID,
				")  AND [type]=2"
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 13, false);
					int? num;
					if (flag)
					{
						object expr_95 = dataRow["id"];
						this.Pardakht_Naghd_ID = ((expr_95 != null) ? ((int?)expr_95) : num);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 10, false);
					if (flag)
					{
						this.txt_naghd.Text = Conversions.ToString(dataRow["mablagh"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 29, false);
					if (flag)
					{
						object expr_113 = dataRow["id"];
						this.Pardakht_Kart_ID = ((expr_113 != null) ? ((int?)expr_113) : num);
						this.txt_cart.Text = Conversions.ToString(dataRow["mablagh"]);
						this.txt_kart_bankhesab.SetValue(Conversions.ToString(dataRow["bankname"]), RuntimeHelpers.GetObjectValue(dataRow["bankhesab_id"]));
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

		// Token: 0x06002218 RID: 8728 RVA: 0x00193D30 File Offset: 0x00191F30
		private bool Save_Pardakhti()
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
				flag4 = this.Pardakht_Naghd_ID.HasValue;
				if (flag4)
				{
					this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Pardakht_Naghd_ID), "", "", "");
				}
			}
			else
			{
				text += this.daryaft.AddRowStrNaghd_Pardakht_Moshtari(this.Tarikh, this.Moshtari_ID, Conversions.ToString((T)this.txt_naghd.Value), "پرداخت نقد", this.Pardakht_Naghd_ID.ToString());
			}
			Public_Function.ExecuteNonQuery(text);
			text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @pardakht_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;declare @codehesab_id2 int;";
			bool arg_162_0;
			if (this.txt_cart.Value.HasValue)
			{
				long num = 0L;
				long? value2 = this.txt_cart.Value;
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
				flag3 = this.Pardakht_Kart_ID.HasValue;
				if (flag3)
				{
					this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Pardakht_Kart_ID), "", "", "");
				}
			}
			else
			{
				flag4 = (this.txt_kart_bankhesab.Value == null);
				if (flag4)
				{
					this.txt_kart_bankhesab.ShowTip("حساب بانکی را وارد نمایید");
					result = false;
					return result;
				}
				text += this.daryaft.AddRowStrKart_Pardakht_Moshtari(this.Tarikh, this.Moshtari_ID, Conversions.ToString(this.txt_kart_bankhesab.Value), Conversions.ToString((T)this.txt_cart.Value), "پرداخت کارت", this.Pardakht_Kart_ID.ToString());
			}
			Public_Function.ExecuteNonQuery(text);
			result = true;
			return result;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00193F78 File Offset: 0x00192178
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.Save_Pardakhti();
			if (flag)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00193FA0 File Offset: 0x001921A0
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

		// Token: 0x0600221B RID: 8731 RVA: 0x00193FDC File Offset: 0x001921DC
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

		// Token: 0x0600221C RID: 8732 RVA: 0x00194134 File Offset: 0x00192334
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

		// Token: 0x0600221D RID: 8733 RVA: 0x001941B8 File Offset: 0x001923B8
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

		// Token: 0x0600221E RID: 8734 RVA: 0x00194680 File Offset: 0x00192880
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

		// Token: 0x0600221F RID: 8735 RVA: 0x00194788 File Offset: 0x00192988
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

		// Token: 0x06002220 RID: 8736 RVA: 0x00194844 File Offset: 0x00192A44
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

		// Token: 0x06002221 RID: 8737 RVA: 0x0019497C File Offset: 0x00192B7C
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

		// Token: 0x06002222 RID: 8738 RVA: 0x00194A1C File Offset: 0x00192C1C
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 18,
				Daryaft_Identity = value
			});
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00194A50 File Offset: 0x00192C50
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

		// Token: 0x06002224 RID: 8740 RVA: 0x0000205D File Offset: 0x0000025D
		private void GetChackeUsageInPardakhtForPardakht(GridEXRow row, DataTable dt2)
		{
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00194CF0 File Offset: 0x00192EF0
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

		// Token: 0x06002226 RID: 8742 RVA: 0x00194E68 File Offset: 0x00193068
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

		// Token: 0x06002227 RID: 8743 RVA: 0x00195118 File Offset: 0x00193318
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

		// Token: 0x06002228 RID: 8744 RVA: 0x00195248 File Offset: 0x00193448
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

		// Token: 0x06002229 RID: 8745 RVA: 0x000E9708 File Offset: 0x000E7908
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

		// Token: 0x0600222A RID: 8746 RVA: 0x000E97CC File Offset: 0x000E79CC
		private void Update_MablaghNaghd(string Parent_id, string Mablagh)
		{
			string text = "declare @id int;declare @sanadbed_id int;declare @mablagh bigint;";
			text = text + " select @id=id,@sanadbed_id=sanadbed_id from daryaftpardakht  where parent_id=" + Parent_id + " and dptype_id=10;";
			text = text + " update daryaftpardakht set mablagh=mablagh+" + Mablagh + " where id=@id;";
			text += "select @mablagh=mablagh from daryaftpardakht where id=@id;";
			text += " update sanad set bed=@mablagh where id=@sanadbed_id;";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00195448 File Offset: 0x00193648
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

		// Token: 0x0600222C RID: 8748 RVA: 0x001954D8 File Offset: 0x001936D8
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

		// Token: 0x0600222D RID: 8749 RVA: 0x0019577C File Offset: 0x0019397C
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

		// Token: 0x0600222E RID: 8750 RVA: 0x00195934 File Offset: 0x00193B34
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

		// Token: 0x0600222F RID: 8751 RVA: 0x001959F0 File Offset: 0x00193BF0
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

		// Token: 0x06002230 RID: 8752 RVA: 0x00195D44 File Offset: 0x00193F44
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

		// Token: 0x06002231 RID: 8753 RVA: 0x000EA1CC File Offset: 0x000E83CC
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

		// Token: 0x06002232 RID: 8754 RVA: 0x00195DF0 File Offset: 0x00193FF0
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

		// Token: 0x06002233 RID: 8755 RVA: 0x00195EDC File Offset: 0x001940DC
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

		// Token: 0x06002234 RID: 8756 RVA: 0x00196198 File Offset: 0x00194398
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

		// Token: 0x06002235 RID: 8757 RVA: 0x001961F8 File Offset: 0x001943F8
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

		// Token: 0x06002236 RID: 8758 RVA: 0x001966EC File Offset: 0x001948EC
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

		// Token: 0x06002237 RID: 8759 RVA: 0x00196774 File Offset: 0x00194974
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

		// Token: 0x06002238 RID: 8760 RVA: 0x00196830 File Offset: 0x00194A30
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

		// Token: 0x06002239 RID: 8761 RVA: 0x00196E64 File Offset: 0x00195064
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

		// Token: 0x0600223A RID: 8762 RVA: 0x00008D74 File Offset: 0x00006F74
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.ShowReport(false);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x001975A8 File Offset: 0x001957A8
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

		// Token: 0x0600223C RID: 8764 RVA: 0x00008D80 File Offset: 0x00006F80
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00008D8B File Offset: 0x00006F8B
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			this.GetSum();
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00197628 File Offset: 0x00195828
		private void txt_naghd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Down;
			if (flag)
			{
				this.txt_cart.Focus();
			}
			flag = (e.KeyCode == Keys.Up);
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0000205D File Offset: 0x0000025D
		private void txt_cart_Validating(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00197688 File Offset: 0x00195888
		private void txt_cart_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف کارت به کارت میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				bool hasValue = this.Pardakht_Kart_ID.HasValue;
				if (hasValue)
				{
					this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Pardakht_Kart_ID), "", "", "");
					this.txt_cart.SetNew();
					this.txt_kart_bankhesab.SetNew();
				}
				else
				{
					this.txt_cart.SetNew();
					this.txt_kart_bankhesab.SetNew();
				}
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0019771C File Offset: 0x0019591C
		private void txt_naghd_ButtonClick(object sender, EventArgs e)
		{
			bool hasValue = this.Pardakht_Naghd_ID.HasValue;
			if (hasValue)
			{
				this.daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString((T)this.Pardakht_Naghd_ID), "", "", "");
				this.txt_naghd.SetNew();
			}
			else
			{
				this.txt_naghd.SetNew();
			}
		}

		// Token: 0x04000D18 RID: 3352
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000D1A RID: 3354
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000D1B RID: 3355
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000D1C RID: 3356
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x04000D1D RID: 3357
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000D1E RID: 3358
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000D1F RID: 3359
		[AccessedThroughProperty("Highlighter1")]
		private Highlighter _Highlighter1;

		// Token: 0x04000D20 RID: 3360
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000D21 RID: 3361
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000D22 RID: 3362
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000D23 RID: 3363
		[AccessedThroughProperty("lbl_jamcheck")]
		private LabelCommand _lbl_jamcheck;

		// Token: 0x04000D24 RID: 3364
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000D25 RID: 3365
		[AccessedThroughProperty("lbl_jamkol")]
		private LabelCommand _lbl_jamkol;

		// Token: 0x04000D26 RID: 3366
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000D27 RID: 3367
		[AccessedThroughProperty("lbl_codem")]
		private LabelCommand _lbl_codem;

		// Token: 0x04000D28 RID: 3368
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000D29 RID: 3369
		[AccessedThroughProperty("lbl_name")]
		private LabelCommand _lbl_name;

		// Token: 0x04000D2A RID: 3370
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x04000D2B RID: 3371
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x04000D2C RID: 3372
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000D2D RID: 3373
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000D2E RID: 3374
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000D2F RID: 3375
		[AccessedThroughProperty("txt_cart")]
		private CurrencyBox _txt_cart;

		// Token: 0x04000D30 RID: 3376
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000D31 RID: 3377
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000D32 RID: 3378
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000D33 RID: 3379
		[AccessedThroughProperty("txt_kart_bankhesab")]
		private SelectItem _txt_kart_bankhesab;

		// Token: 0x04000D34 RID: 3380
		[AccessedThroughProperty("txt_babat_kart")]
		private EditBox _txt_babat_kart;

		// Token: 0x04000D35 RID: 3381
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000D36 RID: 3382
		[AccessedThroughProperty("txt_moshtari")]
		private EditBox _txt_moshtari;

		// Token: 0x04000D37 RID: 3383
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000D38 RID: 3384
		[AccessedThroughProperty("txt_naghd")]
		private CurrencyBox _txt_naghd;

		// Token: 0x04000D39 RID: 3385
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x04000D3A RID: 3386
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000D3B RID: 3387
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000D3C RID: 3388
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000D3D RID: 3389
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000D3E RID: 3390
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000D3F RID: 3391
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000D40 RID: 3392
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000D41 RID: 3393
		[AccessedThroughProperty("GridEX3")]
		private GridEX _GridEX3;

		// Token: 0x04000D42 RID: 3394
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000D43 RID: 3395
		[AccessedThroughProperty("GridEX4")]
		private GridEX _GridEX4;

		// Token: 0x04000D44 RID: 3396
		[AccessedThroughProperty("DateBox21")]
		private DateBox2 _DateBox21;

		// Token: 0x04000D45 RID: 3397
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x04000D46 RID: 3398
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x04000D47 RID: 3399
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000D48 RID: 3400
		[CompilerGenerated]
		private string _Tozih;

		// Token: 0x04000D49 RID: 3401
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x04000D4A RID: 3402
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x04000D4B RID: 3403
		[CompilerGenerated]
		private long _Mablagh_Kol;

		// Token: 0x04000D4C RID: 3404
		[CompilerGenerated]
		private int _HazineKharid_ID;

		// Token: 0x04000D4D RID: 3405
		[CompilerGenerated]
		private string _HazineKharid_Name;

		// Token: 0x04000D4E RID: 3406
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x04000D4F RID: 3407
		[CompilerGenerated]
		private string _Moshtari_ID;

		// Token: 0x04000D50 RID: 3408
		[CompilerGenerated]
		private string _Pardakht_ID;

		// Token: 0x04000D51 RID: 3409
		[CompilerGenerated]
		private string _Kart_be_Kart_ID;

		// Token: 0x04000D52 RID: 3410
		private DaryaftPardakht dp;

		// Token: 0x04000D53 RID: 3411
		private Sanad sanad;

		// Token: 0x04000D54 RID: 3412
		private bool prevent;

		// Token: 0x04000D55 RID: 3413
		private bool prevent_right;

		// Token: 0x04000D56 RID: 3414
		private bool prevent_left;

		// Token: 0x04000D57 RID: 3415
		private string notin;

		// Token: 0x04000D58 RID: 3416
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000D59 RID: 3417
		private int? Pardakht_Naghd_ID;

		// Token: 0x04000D5A RID: 3418
		private int? Pardakht_Kart_ID;

		// Token: 0x04000D5B RID: 3419
		private string Notin_Pardakht;

		// Token: 0x04000D5C RID: 3420
		private DaryaftPardakht daryaft;
	}
}
