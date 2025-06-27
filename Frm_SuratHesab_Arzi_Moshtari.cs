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
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI.Dock;
using Kavenegar.SDK;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Export;

namespace FruitBox
{
	// Token: 0x0200013D RID: 317
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Arzi_Moshtari : Form
	{
		// Token: 0x06002E13 RID: 11795 RVA: 0x002209C4 File Offset: 0x0021EBC4
		public Frm_SuratHesab_Arzi_Moshtari()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Moshtari_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Arzi_Moshtari.__ENCAddToList(this);
			this.Moshtari_Info = new Moshtari_Info();
			this.Moshtari_Pic = new Moshtari_Pic();
			this.last_mande = 0L;
			this.last_stat = string.Empty;
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00220A44 File Offset: 0x0021EC44
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Arzi_Moshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Arzi_Moshtari.__ENCList.Count == Frm_SuratHesab_Arzi_Moshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Arzi_Moshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Arzi_Moshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Arzi_Moshtari.__ENCList[num] = Frm_SuratHesab_Arzi_Moshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Arzi_Moshtari.__ENCList.RemoveRange(num, Frm_SuratHesab_Arzi_Moshtari.__ENCList.Count - num);
						Frm_SuratHesab_Arzi_Moshtari.__ENCList.Capacity = Frm_SuratHesab_Arzi_Moshtari.__ENCList.Count;
					}
					Frm_SuratHesab_Arzi_Moshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x0022303C File Offset: 0x0022123C
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x0000BA7C File Offset: 0x00009C7C
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

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x00223054 File Offset: 0x00221254
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x0000BA86 File Offset: 0x00009C86
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

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x0022306C File Offset: 0x0022126C
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x00223084 File Offset: 0x00221284
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				RowLoadEventHandler value5 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_CellValueChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.LoadingRow -= value5;
					this._GridEX1.CellValueChanged -= value6;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.LoadingRow += value5;
					this._GridEX1.CellValueChanged += value6;
				}
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0022318C File Offset: 0x0022138C
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x0000BA90 File Offset: 0x00009C90
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x002231A4 File Offset: 0x002213A4
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x002231BC File Offset: 0x002213BC
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x0022321C File Offset: 0x0022141C
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0000BA9A File Offset: 0x00009C9A
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

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00223234 File Offset: 0x00221434
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x0000BAA4 File Offset: 0x00009CA4
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x0022324C File Offset: 0x0022144C
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0000BAAE File Offset: 0x00009CAE
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00223264 File Offset: 0x00221464
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x0000BAB8 File Offset: 0x00009CB8
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

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x0022327C File Offset: 0x0022147C
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0000BAC2 File Offset: 0x00009CC2
		internal virtual Label lbl_tel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel3 = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x00223294 File Offset: 0x00221494
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x0000BACC File Offset: 0x00009CCC
		internal virtual Label lbl_tel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel4 = value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x002232AC File Offset: 0x002214AC
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x0000BAD6 File Offset: 0x00009CD6
		internal virtual Label lbl_tel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel2 = value;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x002232C4 File Offset: 0x002214C4
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		internal virtual Label lbl_tel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel1 = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x002232DC File Offset: 0x002214DC
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x0000BAEA File Offset: 0x00009CEA
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

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x002232F4 File Offset: 0x002214F4
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x0000BAF4 File Offset: 0x00009CF4
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

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x0022330C File Offset: 0x0022150C
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x0000BAFE File Offset: 0x00009CFE
		internal virtual Label lbl_codemelli
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_codemelli;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_codemelli = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x00223324 File Offset: 0x00221524
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x0000BB08 File Offset: 0x00009D08
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

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x0022333C File Offset: 0x0022153C
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x0000BB12 File Offset: 0x00009D12
		internal virtual Label lbl_addr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_addr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_addr = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00223354 File Offset: 0x00221554
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x0000BB1C File Offset: 0x00009D1C
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x0022336C File Offset: 0x0022156C
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x0000BB26 File Offset: 0x00009D26
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

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x00223384 File Offset: 0x00221584
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x0000BB30 File Offset: 0x00009D30
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

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0022339C File Offset: 0x0022159C
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x002233B4 File Offset: 0x002215B4
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
				CommandEventHandler value2 = new CommandEventHandler(this.RibbonStatusBar1_CommandClick);
				bool flag = this._RibbonStatusBar1 != null;
				if (flag)
				{
					this._RibbonStatusBar1.CommandClick -= value2;
				}
				this._RibbonStatusBar1 = value;
				flag = (this._RibbonStatusBar1 != null);
				if (flag)
				{
					this._RibbonStatusBar1.CommandClick += value2;
				}
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00223414 File Offset: 0x00221614
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x0000BB3A File Offset: 0x00009D3A
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

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x0022342C File Offset: 0x0022162C
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x0000BB44 File Offset: 0x00009D44
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

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x00223444 File Offset: 0x00221644
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x0000BB4E File Offset: 0x00009D4E
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

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x0022345C File Offset: 0x0022165C
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x0000BB58 File Offset: 0x00009D58
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

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00223474 File Offset: 0x00221674
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x0000BB62 File Offset: 0x00009D62
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

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x0022348C File Offset: 0x0022168C
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x0000BB6C File Offset: 0x00009D6C
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

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x002234A4 File Offset: 0x002216A4
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x0000BB76 File Offset: 0x00009D76
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x002234BC File Offset: 0x002216BC
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x0000BB80 File Offset: 0x00009D80
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

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x002234D4 File Offset: 0x002216D4
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x0000BB8A File Offset: 0x00009D8A
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x002234EC File Offset: 0x002216EC
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00223504 File Offset: 0x00221704
		internal virtual ButtonItem ButtonItem7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem7_Click);
				bool flag = this._ButtonItem7 != null;
				if (flag)
				{
					this._ButtonItem7.Click -= value2;
				}
				this._ButtonItem7 = value;
				flag = (this._ButtonItem7 != null);
				if (flag)
				{
					this._ButtonItem7.Click += value2;
				}
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00223564 File Offset: 0x00221764
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x0022357C File Offset: 0x0022177C
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

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x002235DC File Offset: 0x002217DC
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x002235F4 File Offset: 0x002217F4
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

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00223654 File Offset: 0x00221854
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x0022366C File Offset: 0x0022186C
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
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.Click -= value2;
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x002236CC File Offset: 0x002218CC
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x002236E4 File Offset: 0x002218E4
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

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x00223744 File Offset: 0x00221944
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x0000BB94 File Offset: 0x00009D94
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

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x0022375C File Offset: 0x0022195C
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x00223774 File Offset: 0x00221974
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x002237D4 File Offset: 0x002219D4
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x002237EC File Offset: 0x002219EC
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.KeyDown -= value2;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x0022384C File Offset: 0x00221A4C
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x0000BB9E File Offset: 0x00009D9E
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

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00223864 File Offset: 0x00221A64
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x0000BBA8 File Offset: 0x00009DA8
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

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x0022387C File Offset: 0x00221A7C
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x0000BBB2 File Offset: 0x00009DB2
		internal virtual Label lbl_code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_code = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00223894 File Offset: 0x00221A94
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x002238AC File Offset: 0x00221AAC
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

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x0022390C File Offset: 0x00221B0C
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x0000BBBC File Offset: 0x00009DBC
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00223924 File Offset: 0x00221B24
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x0000BBC6 File Offset: 0x00009DC6
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

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x0022393C File Offset: 0x00221B3C
		// (set) Token: 0x06002E72 RID: 11890 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		internal virtual Label lbl_shahr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_shahr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_shahr = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x00223954 File Offset: 0x00221B54
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x0022396C File Offset: 0x00221B6C
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

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x002239CC File Offset: 0x00221BCC
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x002239E4 File Offset: 0x00221BE4
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

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00223A44 File Offset: 0x00221C44
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x0000BBDA File Offset: 0x00009DDA
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

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00223A5C File Offset: 0x00221C5C
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x00223A74 File Offset: 0x00221C74
		internal virtual UICheckBox txt_jamkharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jamkharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_jamkharid_CheckedChanged);
				bool flag = this._txt_jamkharid != null;
				if (flag)
				{
					this._txt_jamkharid.CheckedChanged -= value2;
				}
				this._txt_jamkharid = value;
				flag = (this._txt_jamkharid != null);
				if (flag)
				{
					this._txt_jamkharid.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x00223AD4 File Offset: 0x00221CD4
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x00223AEC File Offset: 0x00221CEC
		internal virtual ButtonItem ButtonItem6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem6_Click);
				bool flag = this._ButtonItem6 != null;
				if (flag)
				{
					this._ButtonItem6.Click -= value2;
				}
				this._ButtonItem6 = value;
				flag = (this._ButtonItem6 != null);
				if (flag)
				{
					this._ButtonItem6.Click += value2;
				}
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x00223B4C File Offset: 0x00221D4C
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x0000BBE4 File Offset: 0x00009DE4
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

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x00223B64 File Offset: 0x00221D64
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x00223B7C File Offset: 0x00221D7C
		internal virtual ButtonItem ButtonItem8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem8_Click);
				bool flag = this._ButtonItem8 != null;
				if (flag)
				{
					this._ButtonItem8.Click -= value2;
				}
				this._ButtonItem8 = value;
				flag = (this._ButtonItem8 != null);
				if (flag)
				{
					this._ButtonItem8.Click += value2;
				}
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x00223BDC File Offset: 0x00221DDC
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x00223BF4 File Offset: 0x00221DF4
		internal virtual ButtonItem ButtonItem9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem9_Click);
				bool flag = this._ButtonItem9 != null;
				if (flag)
				{
					this._ButtonItem9.Click -= value2;
				}
				this._ButtonItem9 = value;
				flag = (this._ButtonItem9 != null);
				if (flag)
				{
					this._ButtonItem9.Click += value2;
				}
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x00223C54 File Offset: 0x00221E54
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x0000BBEE File Offset: 0x00009DEE
		internal virtual ButtonCommand ButtonCommand1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCommand1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonCommand1 = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00223C6C File Offset: 0x00221E6C
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public int? Moshtari_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_id = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00223C84 File Offset: 0x00221E84
		// (set) Token: 0x06002E88 RID: 11912 RVA: 0x0000BC02 File Offset: 0x00009E02
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

		// Token: 0x06002E89 RID: 11913 RVA: 0x00223C9C File Offset: 0x00221E9C
		private void Refresh_Status()
		{
			this.LabelCommand2.Text = this.Moshtari_Info.LastTozih.ToString();
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

		// Token: 0x06002E8A RID: 11914 RVA: 0x00223D44 File Offset: 0x00221F44
		private int GetNextPosBed(int pos, DataTable dt)
		{
			long num = 0L;
			checked
			{
				int arg_16_0 = pos + 1;
				int num2 = dt.Rows.Count - 1;
				int num3 = arg_16_0;
				int num5;
				while (true)
				{
					int arg_1D1_0 = num3;
					int num4 = num2;
					if (arg_1D1_0 > num4)
					{
						goto Block_6;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dt.Rows[num3]["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num3]["calc"], 1, false);
					if (flag)
					{
						bool flag2 = num5 + 1 > dt.Rows.Count - 1;
						if (flag2)
						{
							break;
						}
						num5 = num3;
						num = Conversions.ToLong(dt.Rows[num3]["rembed"]);
						DateTime dateTime = Conversions.ToDate(dt.Rows[num3]["tarikh"]);
						int arg_101_0 = num5 + 1;
						int num6 = dt.Rows.Count - 1;
						int num7 = arg_101_0;
						while (true)
						{
							int arg_1BC_0 = num7;
							num4 = num6;
							if (arg_1BC_0 > num4)
							{
								break;
							}
							flag2 = (Operators.ConditionalCompareObjectEqual(dt.Rows[num7]["tarikh"], dateTime, false) && Operators.ConditionalCompareObjectGreater(dt.Rows[num7]["bed"], 0, false));
							if (!flag2)
							{
								goto IL_18A;
							}
							num5 = num7;
							num = Conversions.ToLong(Operators.AddObject(num, dt.Rows[num7]["rembed"]));
							num7++;
						}
					}
					num3++;
				}
				dt.Rows[num5]["rembed"] = num;
				int result = num5;
				return result;
				IL_18A:
				dt.Rows[num5]["rembed"] = num;
				result = num5;
				return result;
				Block_6:
				result = -1;
				return result;
			}
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00043BA4 File Offset: 0x00041DA4
		private int GetNextPosBes(int pos, DataTable dt)
		{
			checked
			{
				int arg_12_0 = pos + 1;
				int num = dt.Rows.Count - 1;
				int num2 = arg_12_0;
				while (true)
				{
					int arg_76_0 = num2;
					int num3 = num;
					if (arg_76_0 > num3)
					{
						goto Block_3;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bes"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["calc"], 1, false);
					if (flag)
					{
						break;
					}
					num2++;
				}
				int result = num2;
				return result;
				Block_3:
				result = -1;
				return result;
			}
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00223F2C File Offset: 0x0022212C
		private void LoadPic(DataRow dr)
		{
			bool flag = dr == null;
			if (flag)
			{
				this.PictureBox1.Image = null;
			}
			else
			{
				flag = (dr["PicData"] != DBNull.Value);
				if (flag)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write((byte[])dr["Picdata"], 0, ((byte[])dr["Picdata"]).Length);
					this.PictureBox1.Image = Image.FromStream(memoryStream);
				}
				else
				{
					this.PictureBox1.Image = null;
				}
			}
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00223FC0 File Offset: 0x002221C0
		private void LoadMoshtariData(string id)
		{
			DataRow dataRow = Public_Function.FillDataRow("SELECT     Grouh_Moshtari.Name AS Shahr1, Grouh_Moshtari2.Name AS Shahr2, Moshtari.*  FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID where Moshtari.id=" + id);
			bool flag = dataRow != null;
			if (flag)
			{
				this.lbl_shahr.Text = string.Empty;
				this.lbl_code.Text = id;
				this.Label7.Text = dataRow["moaref"].ToString();
				this.lbl_tel1.Text = dataRow["tel1"].ToString();
				this.lbl_tel2.Text = dataRow["tel2"].ToString();
				this.lbl_tel3.Text = dataRow["tel3"].ToString();
				this.lbl_tel4.Text = dataRow["tel4"].ToString();
				this.lbl_addr.Text = dataRow["address"].ToString();
				this.lbl_codemelli.Text = dataRow["codemelli"].ToString();
				flag = (dataRow["shahr1"] != DBNull.Value);
				if (flag)
				{
					this.lbl_shahr.Text = Conversions.ToString(dataRow["shahr1"]);
				}
				flag = (dataRow["shahr2"] != DBNull.Value);
				if (flag)
				{
					this.lbl_shahr.Text = Conversions.ToString(dataRow["shahr2"]);
				}
				DataRow byID = this.Moshtari_Pic.GetByID(id);
				this.LoadPic(byID);
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00224154 File Offset: 0x00222354
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_kol"]));
					}
					flag = (dataRow["ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["ba_zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["ba_zarf"]));
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

		// Token: 0x06002E8F RID: 11919 RVA: 0x00043C30 File Offset: 0x00041E30
		private void Disablecheckbargasht(DataTable dt)
		{
			DataRow[] array = dt.Select("pardakhtcheck_id is not null");
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						DataRow[] array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("check_id=", dataRow["pardakhtcheck_id"])));
						flag = (array3.Length > 0);
						if (flag)
						{
							dataRow["calc"] = 0;
							array3[0]["calc"] = 0;
						}
					}
				}
			}
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x0009DA70 File Offset: 0x0009BC70
		private string getkalaname(DataRow[] r)
		{
			string text = "خرید ";
			checked
			{
				for (int i = 0; i < r.Length; i++)
				{
					DataRow dataRow = r[i];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["kala_name"], " , ")));
				}
				return text.Remove(text.Length - 3, 3);
			}
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		private void addtedad(DataRow row, DataRow[] r)
		{
			row["tedad"] = RuntimeHelpers.GetObjectValue(r[0]["tedad"]);
			row["vazn_kol"] = RuntimeHelpers.GetObjectValue(r[0]["vazn_kol"]);
			row["fee"] = RuntimeHelpers.GetObjectValue(r[0]["fee"]);
			row["ba_zarf"] = RuntimeHelpers.GetObjectValue(r[0]["ba_zarf"]);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00224280 File Offset: 0x00222480
		private void loadJamFurushRuzane(DataTable dt, string codehesab_id)
		{
			bool flag = !this.txt_jamkharid.Checked;
			if (!flag)
			{
				string command = string.Concat(new string[]
				{
					"select * from ( SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc    FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype =1 and Sanad.CodeHesab_ID = ",
					codehesab_id,
					"   UNION all   SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,   Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc   FROM         Kala INNER JOIN   Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID    WHERE sanad.arztype =1 and Sanad.CodeHesab_ID = ",
					codehesab_id,
					")t  order by sanadtype,tarikh"
				});
				DataTable dataTable = Public_Function.FillData(command);
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 3, false));
						if (flag)
						{
							DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("tarikh='", dataRow["tarikh"]), "'")));
							dataRow["Tozih"] = this.getkalaname(array);
							flag = (array.Length == 1);
							if (flag)
							{
								this.addtedad(dataRow, array);
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
			}
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x002243E4 File Offset: 0x002225E4
		private void Delete_Tekrari(DataTable dt)
		{
			long num = -1L;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["id"] == DBNull.Value;
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["id"], num, false);
						if (flag)
						{
							dataRow.Delete();
							dt.AcceptChanges();
							this.Delete_Tekrari(dt);
							break;
						}
						num = Conversions.ToLong(dataRow["id"]);
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

		// Token: 0x06002E94 RID: 11924 RVA: 0x0000205D File Offset: 0x0000025D
		private void Delete_Ersalbar_duplicate()
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x0000205D File Offset: 0x0000025D
		private void Delete_invalid_row(DataTable dt)
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x002244B0 File Offset: 0x002226B0
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			checked
			{
				if (!flag)
				{
					this.LoadMoshtariData(Conversions.ToString(this.txt_moshtari.Value));
					int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
					}, null, null, null));
					string text = string.Empty;
					flag = !this.txt_jamkharid.Checked;
					if (flag)
					{
						text = " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked    FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype =1 and Sanad.CodeHesab_ID = " + Conversions.ToString(value) + "   UNION all ";
					}
					else
					{
						text = "SELECT    null as ID, max(Sanad.CodeHesab_ID) as CodeHesab_ID,sum( Sanad.Bed) AS Bed,sum ( Sanad.Bes) AS Bes,Sanad.Tarikh ,max( Sanad.Tarikh_Fa) AS Tarikh_Fa,null as  Tozih,cast(  null  AS nvarchar(50))  AS Kala_Name, sum( Sanad.Bed) AS rembed,sum( Sanad.Bes) AS rembes,null as  Tedad, null as Vazn_Kol, null as Fee, null AS ba_zarf,2 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked  FROM         Kala INNER JOIN Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID  WHERE sanad.arztype =1 and Sanad.CodeHesab_ID = " + Conversions.ToString(value) + " group by Sanad.Tarikh   UNION all ";
					}
					flag = !this.txt_jamkharid.Checked;
					if (flag)
					{
						text = text + "  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,   Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked   FROM         Kala INNER JOIN   Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID    WHERE sanad.arztype =1 and Sanad.CodeHesab_ID = " + Conversions.ToString(value) + "   union all ";
					}
					else
					{
						text = text + "  SELECT     null as ID,max ( Sanad.CodeHesab_ID) AS CodeHesab_ID,sum ( Sanad.Bed) AS Bed,sum( Sanad.Bes) AS Bes, Sanad.Tarikh,max( Sanad.Tarikh_Fa) as Tarikh_Fa, null as Tozih, cast(  null  AS nvarchar(50))  AS Kala_Name,sum( Sanad.Bed ) AS rembed,   sum(  Sanad.Bes) AS rembes, null as Tedad, null as Vazn_Kol, null as Fee, null  AS ba_zarf, 3 AS sanadtype,     - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked   FROM         Kala INNER JOIN     Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN     Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID   WHERE sanad.arztype =1 and Sanad.CodeHesab_ID =" + Conversions.ToString(value) + "  group by  Sanad.Tarikh   UNION ALL ";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, NULL AS Tedad, NULL AS Vazn_Kol, NULL AS Fee, NULL AS ba_zarf, 1 AS sanadtype, - 1 AS printcount, DaryaftPardakht.PardakhtCheck_ID,  DaryaftPardakht_1.ID AS Check_ID, 1 AS calc,0 as checked  FROM         Sanad LEFT OUTER JOIN  DaryaftPardakht ON Sanad.ID = DaryaftPardakht.SanadBed_ID LEFT OUTER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON Sanad.ID = DaryaftPardakht_1.SanadBes_ID  WHERE     ( sanad.arztype =1 and Sanad.CodeHesab_ID = " + Conversions.ToString(value) + ")  AND ((Sanad.sanadtype is null) OR (sanad.sanadtype =1)) " + "  union all" + "  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS kala_name, Sanad.Bed AS rembed, " + " Sanad.Bes AS rembes, t.Tedad, t.vazn_kol, NULL AS Fee,t.ba_zarf as ba_zarf,4 as SanadType,Safi_Furush_1.printcount " + " ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc,sanad.checked as checked  " + " FROM         Safi_Furush AS Safi_Furush_1 INNER JOIN " + " Sanad ON Safi_Furush_1.Sanad_ID = Sanad.ID INNER JOIN " + " (SELECT     Safi_Furush.ID, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Kol) AS vazn_kol,SUM(Furush_Hag_Detail.vazn_ba_zarf) AS ba_zarf " + " FROM         Safi_Furush INNER JOIN " + " Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN " + " Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID " + " WHERE Furush_Hag.Moshtari_ID = ", this.txt_moshtari.Value), "  GROUP BY Safi_Furush.ID) AS t ON Safi_Furush_1.ID = t.ID "), "  where sanad.arztype =1 "), " union all "), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, Kharid_Detail.Tedad, Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee, Kharid_Detail.Vazn_Ba_Zarf AS ba_zarf, 5 AS sanadtype,  "), " - 1 AS printcount "), " ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked "), " FROM         Sanad INNER JOIN "), " Kharid_Detail ON Sanad.ID = Kharid_Detail.sanad_id INNER JOIN "), " Kala ON Kharid_Detail.Kala_ID = Kala.ID INNER JOIN "), " Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID "), "  where sanad.arztype =1 and Moshtari_id = "), this.txt_moshtari.Value), " union all "), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Sardkhane_Detail.Tedad, Kharid_Sardkhane_Detail.Vazn_Kol, Kharid_Sardkhane_Detail.Fee, Kharid_Sardkhane_Detail.Vazn_Ba_Zarf AS ba_zarf, 6 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc , 0 as checked  FROM         Sanad INNER JOIN  Kharid_Sardkhane_Detail ON Sanad.ID = Kharid_Sardkhane_Detail.sanad_id INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID INNER JOIN  Kharid_Sardkhane ON Kharid_Sardkhane_Detail.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where sanad.arztype =1 and Moshtari_id = "), this.txt_moshtari.Value.ToString()), " union all"), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Sardkhane_Detail.Tedad, Furush_Sardkhane_Detail.Vazn_Kol,Furush_Sardkhane_Detail.fee,vazn_ba_zarf as ba_zarf,7 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked    FROM         Kala INNER JOIN    Furush_Sardkhane_Detail ON Kala.ID = Furush_Sardkhane_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Sardkhane_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype =1 and Sanad.CodeHesab_ID = "), value.ToString()), " union all"), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, ErsalBar_Detail.Tedad, ErsalBar_Detail.Vazn_Kol, ErsalBar_Detail.Fee, "), " ErsalBar_Detail.Vazn_Ba_Zarf AS ba_zarf, 8 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked "), " FROM         Kala INNER JOIN "), " ErsalBar_Detail ON Kala.ID = ErsalBar_Detail.Kala_ID INNER JOIN "), " Sanad ON ErsalBar_Detail.Sanad_ID = Sanad.ID "), " WHERE     ( sanad.arztype =1 and Sanad.CodeHesab_ID = "), value.ToString()), ") "), " UNION ALL "), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, t.Kala_Name,Sanad.Bed AS rembed, Sanad.Bes AS rembes, t.Tedad,"), "  null as vazn_kol,null as fee,t.Vazn_Ba_Zarf as ba_zarf,9 AS sanadtype, "), " - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked "), " FROM         (SELECT     ErsalBar.ID, dbo.getersalbar_kala(ErsalBar.ID) AS Kala_Name, SUM(ErsalBar_Detail.Tedad) AS Tedad, SUM(ErsalBar_Detail.Vazn_Ba_Zarf) "), "  AS Vazn_Ba_Zarf "), "  FROM         ErsalBar_Detail RIGHT OUTER JOIN "), "  ErsalBar ON ErsalBar_Detail.ErsalBar_ID = ErsalBar.ID "), "  WHERE ErsalBar.Moshtari_ID = "), this.txt_moshtari.Value.ToString()), "  GROUP BY ErsalBar.ID) AS t INNER JOIN "), " ErsalBar AS ErsalBar_1 ON t.ID = ErsalBar_1.ID INNER JOIN "), " Sanad ON ErsalBar_1.safi_dolar_sanad_id = Sanad.ID "), " where sanad.arztype =1 "), " union all"), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, KhordeFurushi_Detail.Tedad, KhordeFurushi_Detail.Vazn_Kol, KhordeFurushi_Detail.Fee, KhordeFurushi_Detail.Vazn_Ba_Zarf AS ba_zarf,  "), " 10 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked "), " FROM         KhordeFurushi_Detail INNER JOIN    Kala ON KhordeFurushi_Detail.Kala_ID = Kala.ID INNER JOIN"), " Sanad ON KhordeFurushi_Detail.Moshtari_Sanad_ID = Sanad.ID  where (sanad.arztype =1 and Sanad.CodeHesab_ID = "), value.ToString()), ") "), "  ORDER BY sanad.Tarikh,sanadtype ")));
					DataTable dataTable = Public_Function.FillData(text);
					this.Delete_Tekrari(dataTable);
					this.Delete_invalid_row(dataTable);
					this.loadJamFurushRuzane(dataTable, Conversions.ToString(value));
					bool flag2;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag = (dataRow["kala_name"] != DBNull.Value);
							if (flag)
							{
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 1, false);
								if (flag2)
								{
									string[] array = dataRow["Kala_Name"].ToString().Split(new char[]
									{
										'-'
									});
									flag2 = (array.Length == 3);
									if (flag2)
									{
										DataRow dataRow2 = dataRow;
										DataRow arg_4C6_0 = dataRow2;
										string columnName = "Tozih";
										arg_4C6_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " / " + array[0]);
										flag2 = (Operators.CompareString(array[1], string.Empty, false) != 0);
										if (flag2)
										{
											dataRow["Tedad"] = array[1].ToString();
										}
										flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
										if (flag2)
										{
											dataRow["Vazn_Kol"] = array[2].ToString();
										}
										continue;
									}
								}
								flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["sanadtype"], 5, false);
								if (flag2)
								{
									DataRow dataRow2 = dataRow;
									DataRow arg_588_0 = dataRow2;
									string columnName = "Tozih";
									arg_588_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" / ", dataRow["kala_Name"]));
								}
							}
							else
							{
								string[] array = dataRow["Tozih"].ToString().Split(new char[]
								{
									'-'
								});
								flag2 = (array.Length == 4);
								if (flag2)
								{
									dataRow["Tozih"] = array[0] + " - " + array[1];
									dataRow["Kala_Name"] = array[1].ToString();
									flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
									if (flag2)
									{
										flag = Versioned.IsNumeric(array[2].ToString());
										if (flag)
										{
											dataRow["Tedad"] = array[2].ToString();
										}
									}
									flag2 = Versioned.IsNumeric(array[3].ToString());
									if (flag2)
									{
										flag = (Operators.CompareString(array[3], string.Empty, false) != 0);
										if (flag)
										{
											dataRow["Vazn_Kol"] = array[3].ToString();
										}
									}
									flag2 = (dataRow["Vazn_Kol"] != DBNull.Value);
									if (flag2)
									{
										dataRow["fee"] = Operators.DivideObject(dataRow["bed"], dataRow["Vazn_Kol"]);
									}
								}
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
					this.Disablecheckbargasht(dataTable);
					this.RemoveZero(dataTable);
					try
					{
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator2.Current;
							flag2 = (dataRow3["checked"] == DBNull.Value);
							if (flag2)
							{
								dataRow3["checked"] = 0;
							}
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
					dataTable.Columns.Add("mande", typeof(long));
					dataTable.Columns.Add("stat", typeof(string));
					dataTable.Columns.Add("rad", typeof(long));
					try
					{
						IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow4 = (DataRow)enumerator3.Current;
							long num = Conversions.ToLong(Operators.AddObject(num, dataRow4["bed"]));
							num = Conversions.ToLong(Operators.SubtractObject(num, dataRow4["bes"]));
							dataRow4["mande"] = Math.Abs(num);
							flag2 = (num > 0L);
							if (flag2)
							{
								dataRow4["stat"] = "بد";
							}
							else
							{
								flag2 = (num < 0L);
								if (flag2)
								{
									dataRow4["stat"] = "بس";
								}
								else
								{
									dataRow4["stat"] = "ت";
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
					long num2 = 0L;
					try
					{
						IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DataRow dataRow5 = (DataRow)enumerator4.Current;
							dataRow5["rad"] = num2;
							num2 += 1L;
						}
					}
					finally
					{
						IEnumerator enumerator4;
						flag2 = (enumerator4 is IDisposable);
						if (flag2)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					int num3 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select isnull(kind,0) from moshtari where id=", this.txt_moshtari.Value)
					}, null, null, null));
					bool arg_9B9_0;
					if (num3 != 1 && num3 != 3)
					{
						if (num3 != 5)
						{
							arg_9B9_0 = false;
							goto IL_9B8;
						}
					}
					arg_9B9_0 = true;
					IL_9B8:
					flag2 = arg_9B9_0;
					bool flag3;
					if (flag2)
					{
						int num4 = -1;
						int num5 = -1;
						string text2 = string.Empty;
						num4 = this.GetNextPosBed(num4, dataTable);
						num5 = this.GetNextPosBes(num5, dataTable);
						while (num4 != -1 && num5 != -1)
						{
							flag2 = Operators.ConditionalCompareObjectLess(dataTable.Rows[num5]["rembes"], dataTable.Rows[num4]["rembed"], false);
							if (flag2)
							{
								flag = (Operators.CompareString(text2, string.Empty, false) != 0);
								DataRow dataRow2;
								string columnName;
								if (flag)
								{
									flag3 = Conversions.ToBoolean(Public_Function.dict["autosurat"]);
									if (flag3)
									{
										dataRow2 = dataTable.Rows[num5];
										DataRow arg_A9C_0 = dataRow2;
										columnName = "Tozih";
										arg_A9C_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " ( تسویه تا " + text2 + " ) ");
									}
									text2 = string.Empty;
								}
								dataRow2 = dataTable.Rows[num4];
								DataRow arg_AED_0 = dataRow2;
								columnName = "rembed";
								arg_AED_0[columnName] = Operators.SubtractObject(dataRow2[columnName], dataTable.Rows[num5]["rembes"]);
								flag3 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num5]["stat"], "ت", false);
								if (flag3)
								{
									flag2 = Conversions.ToBoolean(Public_Function.dict["autosurat"]);
									if (flag2)
									{
										dataRow2 = dataTable.Rows[num5];
										DataRow arg_BBE_0 = dataRow2;
										columnName = "Tozih";
										arg_BBE_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( وجه به ", dataTable.Rows[num4]["Tarikh_Fa"]), " - مانده "), Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[num4]["rembed"]))), " ) "));
									}
								}
								num5 = this.GetNextPosBes(num5, dataTable);
							}
							else
							{
								long num6 = Conversions.ToLong(Operators.SubtractObject(dataTable.Rows[num5]["rembes"], dataTable.Rows[num4]["rembed"]));
								dataTable.Rows[num4]["rembed"] = 0;
								text2 = Conversions.ToString(dataTable.Rows[num4]["Tarikh_Fa"]);
								num4 = this.GetNextPosBed(num4, dataTable);
								dataTable.Rows[num5]["rembes"] = num6;
							}
						}
					}
					int num7 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					flag3 = (num7 > 0);
					if (flag3)
					{
						long value2 = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
						}, null, null, null));
						this.LabelCommand10.Text = "جمع " + Conversions.ToString(num7) + " فقره چک برگشتی " + Public_Function.FormatPrice(Conversions.ToString(value2));
					}
					else
					{
						this.LabelCommand10.Text = string.Empty;
					}
					this.GridEX1.DataSource = dataTable;
					this.GridEX1.Refresh();
					flag3 = (dataTable.Rows.Count > 0);
					if (flag3)
					{
						string text3 = this.get_Tasvie_Tarikh(dataTable);
						flag3 = (Operators.CompareString(text3, string.Empty, false) == 0);
						if (flag3)
						{
							object arg_E0A_0 = this.txt_az_tarikh;
							Type arg_E0A_1 = null;
							string arg_E0A_2 = "SetDate";
							object[] array2 = new object[1];
							object[] arg_DF0_0 = array2;
							int arg_DF0_1 = 0;
							DataRow dataRow2 = dataTable.Rows[0];
							DataRow arg_DE6_0 = dataRow2;
							string columnName = "tarikh_Fa";
							arg_DF0_0[arg_DF0_1] = RuntimeHelpers.GetObjectValue(arg_DE6_0[columnName]);
							object[] array3 = array2;
							object[] arg_E0A_3 = array3;
							string[] arg_E0A_4 = null;
							Type[] arg_E0A_5 = null;
							bool[] array4 = new bool[]
							{
								true
							};
							NewLateBinding.LateCall(arg_E0A_0, arg_E0A_1, arg_E0A_2, arg_E0A_3, arg_E0A_4, arg_E0A_5, array4, true);
							if (array4[0])
							{
								dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
							}
						}
						else
						{
							this.txt_az_tarikh.SetDate(text3);
							flag3 = (Operators.CompareString(this.txt_ta_tarikh.Text, this.txt_az_tarikh.Text, false) < 0);
							if (flag3)
							{
								object arg_EC2_0 = this.txt_ta_tarikh;
								Type arg_EC2_1 = null;
								string arg_EC2_2 = "SetDate";
								object[] array3 = new object[1];
								object[] arg_EA8_0 = array3;
								int arg_EA8_1 = 0;
								DataRow dataRow2 = dataTable.Rows[dataTable.Rows.Count - 1];
								DataRow arg_E9E_0 = dataRow2;
								string columnName = "tarikh_fa";
								arg_EA8_0[arg_EA8_1] = RuntimeHelpers.GetObjectValue(arg_E9E_0[columnName]);
								object[] array2 = array3;
								object[] arg_EC2_3 = array2;
								string[] arg_EC2_4 = null;
								Type[] arg_EC2_5 = null;
								bool[] array4 = new bool[]
								{
									true
								};
								NewLateBinding.LateCall(arg_EC2_0, arg_EC2_1, arg_EC2_2, arg_EC2_3, arg_EC2_4, arg_EC2_5, array4, true);
								if (array4[0])
								{
									dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array2[0]);
								}
							}
						}
						this.last_mande = Conversions.ToLong(dataTable.Rows[dataTable.Rows.Count - 1]["mande"]);
						this.last_stat = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["stat"]);
					}
					else
					{
						this.last_mande = 0L;
						this.last_stat = string.Empty;
					}
					this.mande = string.Empty;
					try
					{
						IEnumerator enumerator5 = dataTable.Rows.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							DataRow dataRow6 = (DataRow)enumerator5.Current;
							flag3 = (dataRow6["Kala_Name"] == DBNull.Value);
							if (flag3)
							{
								dataRow6["kala_Name"] = string.Empty;
							}
							flag3 = (Operators.ConditionalCompareObjectEqual(dataRow6["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(dataRow6["bes"], 0, false));
							if (flag3)
							{
								this.mande = "مبلغ تاریخ " + dataRow6["tarikh_fa"].ToString() + " مانده است";
							}
						}
					}
					finally
					{
						IEnumerator enumerator5;
						flag3 = (enumerator5 is IDisposable);
						if (flag3)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
					this.Add();
					string rowFilter = string.Empty;
					flag3 = Conversions.ToBoolean(Public_Function.dict["surathesab_tasvie"]);
					if (flag3)
					{
						string text4 = this.get_Tasvie_radif((DataTable)this.GridEX1.DataSource);
						flag3 = (Operators.CompareString(text4, string.Empty, false) != 0);
						if (flag3)
						{
							rowFilter = "rad>" + text4;
							dataTable.DefaultView.RowFilter = rowFilter;
						}
					}
					this.GridEX1.MoveLast();
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.txt_moshtari.Value);
					long num8 = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("SELECT      isnull(count(Safi_Furush.ID),0)   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					flag3 = (num8 == 0L);
					if (flag3)
					{
						this.ButtonCommand1.Visible = false;
					}
					else
					{
						this.ButtonCommand1.Visible = true;
						this.ButtonCommand1.Text = "تعداد " + Conversions.ToString(num8) + " صافی اعلام نشده وجود دارد";
					}
					this.Refresh_Status();
					this.txt_az_tarikh.Focus();
					this.txt_az_tarikh.SelectionLength = 0;
					this.txt_az_tarikh.SelectionStart = 5;
					this.txt_az_tarikh.SelectionLength = 2;
				}
			}
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x002256E8 File Offset: 0x002238E8
		public string get_Tasvie_Tarikh(DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["stat"], "ت", false);
					if (flag)
					{
						text = Conversions.ToString(dt.Rows.IndexOf(dataRow));
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			string result;
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(text) + 1.0 < (double)dt.Rows.Count;
				if (flag2)
				{
					result = Conversions.ToString(dt.Rows[checked((int)Math.Round(unchecked(Conversions.ToDouble(text) + 1.0)))]["tarikh_Fa"]);
				}
				else
				{
					result = Conversions.ToString(dt.Rows[Conversions.ToInteger(text)]["tarikh_fa"]);
				}
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00225828 File Offset: 0x00223A28
		public string get_Tasvie_radif(DataTable dt)
		{
			string result = string.Empty;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["stat"], "ت", false);
					if (flag)
					{
						result = Conversions.ToString(dataRow["rad"]);
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
			return result;
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x002258CC File Offset: 0x00223ACC
		public void Add()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				flag = !dataTable.Columns.Contains("Filter");
				if (flag)
				{
					dataTable.Columns.Add("Filter", typeof(string));
				}
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						try
						{
							IEnumerator enumerator2 = this.GridEX1.RootTable.Columns.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GridEXColumn gridEXColumn = (GridEXColumn)enumerator2.Current;
								text += dataRow[gridEXColumn.DataMember].ToString();
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
						dataRow["filter"] = text;
						text = string.Empty;
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
			}
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00225A38 File Offset: 0x00223C38
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			bool hasValue = this.Moshtari_id.HasValue;
			if (hasValue)
			{
				string arg_7E_0 = "select count(moshtari_id) from sharik where moshtari_id=";
				int? moshtari_id = this.Moshtari_id;
				bool flag = Operators.ConditionalCompareObjectEqual(Public_Function.ExecuteScalar(arg_7E_0 + (moshtari_id.HasValue ? Conversions.ToString(moshtari_id.GetValueOrDefault()) : null)), 1, false);
				if (flag)
				{
					return;
				}
				this.Moshtari_Info.Moshtari_ID = (T)this.Moshtari_id;
				this.txt_moshtari.SetValue(this.Moshtari_Name, this.Moshtari_id);
				this.SelectItem1_SelectedValueChanged(null, null);
				this.Refresh_Status();
				this.txt_az_tarikh.TabIndex = 0;
				this.txt_ta_tarikh.TabIndex = 1;
				this.txt_moshtari.TabIndex = 4;
			}
			this.txt_az_tarikh.Focus();
			this.txt_az_tarikh.SelectionLength = 0;
			this.txt_az_tarikh.SelectionStart = 5;
			this.txt_az_tarikh.SelectionLength = 2;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00225B84 File Offset: 0x00223D84
		private void ExportReport()
		{
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StiReport stiReport = this.RenderReport(true);
				flag = (stiReport == null);
				if (!flag)
				{
					StiText stiText = (StiText)stiReport.GetComponentByName("Text1");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text48");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text5");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text45");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text36");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text30");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text32");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text46");
					stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					stiText = (StiText)stiReport.GetComponentByName("Text2");
					stiText.Text = Public_Function.RenderDigitToPdf(stiText.Text);
					StiPdfExportService stiPdfExportService = new StiPdfExportService();
					StiJpegExportSettings stiJpegExportSettings = new StiJpegExportSettings();
					stiPdfExportService.MultipleFiles = true;
					stiReport.Render(true);
					string text = Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "");
					stiPdfExportService.ExportPdf(stiReport, string.Concat(new string[]
					{
						this.FolderBrowserDialog1.SelectedPath,
						"\\",
						this.txt_moshtari.Text,
						"-",
						text,
						".pdf"
					}));
					Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00225E4C File Offset: 0x0022404C
		private void Frm_SuratHesab_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F6);
				if (flag)
				{
					this.ButtonItem4_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F7);
					if (flag)
					{
						this.ButtonItem7_Click(null, null);
					}
				}
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.txt_moshtari.PerformButtonClick();
			}
			flag = (e.Shift && e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ExportReport();
			}
			else
			{
				flag = (e.KeyCode == Keys.F4);
				if (flag)
				{
					this.ButtonItem1_Click(null, null);
				}
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00225EF8 File Offset: 0x002240F8
		private void showkharid(DataRowView row)
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Kharid.Num  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID where sanad_id=", row["id"])
			}, null, null, null));
			Frm_Kharid_Furush frm_Kharid_Furush = new Frm_Kharid_Furush();
			frm_Kharid_Furush.Num = num;
			bool flag = Operators.ConditionalCompareObjectEqual(row["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(row["bes"], 0, false);
			if (flag)
			{
				DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     kharid_furush.ID, Kala.Name FROM kharid_furush INNER JOIN Kala ON kharid_furush.Kala_ID = Kala.ID where moshtari_id=", this.txt_moshtari.Value), " and tarikh_fa= "), Public_Function.GetValue(Conversions.ToString(row["tarikh_fa"])))));
				flag = (dataTable != null);
				if (flag)
				{
					bool flag2 = dataTable.Rows.Count == 1;
					if (flag2)
					{
						frm_Kharid_Furush.GotoLineID = Conversions.ToInteger(dataTable.Rows[0]["id"]);
					}
					else
					{
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow["name"], row["kala_name"], false);
								if (flag2)
								{
									frm_Kharid_Furush.GotoLineID = Conversions.ToInteger(dataRow["id"]);
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
					}
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Kharid_Furush);
			this.SelectItem1_SelectedValueChanged(null, null);
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x002260DC File Offset: 0x002242DC
		private void ShowFurush(DataRowView row)
		{
			bool flag = row["id"] == DBNull.Value;
			if (!flag)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT     Furush_Hag.Num  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID where sanad_id=", row["id"])
				}, null, null, null));
				frm_Frush_hag frm_Frush_hag = new frm_Frush_hag();
				frm_Frush_hag.Show_Preview = true;
				frm_Frush_hag.Num = num;
				flag = (Operators.ConditionalCompareObjectEqual(row["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(row["bes"], 0, false));
				if (flag)
				{
					DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     Furush_Hag_Detail.ID, Kala.Name FROM Furush_Hag_Detail INNER JOIN Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID where moshtari_id=", this.txt_moshtari.Value), " and tarikh_fa= "), Public_Function.GetValue(Conversions.ToString(row["tarikh_fa"])))));
					flag = (dataTable != null);
					if (flag)
					{
						bool flag2 = dataTable.Rows.Count == 1;
						if (flag2)
						{
							frm_Frush_hag.GotoLineID = Conversions.ToInteger(dataTable.Rows[0]["id"]);
						}
						else
						{
							try
							{
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow["name"], row["kala_name"], false);
									if (flag2)
									{
										frm_Frush_hag.GotoLineID = Conversions.ToInteger(dataRow["id"]);
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
						}
					}
				}
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Frush_hag);
				this.SelectItem1_SelectedValueChanged(null, null);
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x002262E8 File Offset: 0x002244E8
		private void ShowSafi(DataRowView row)
		{
			DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from safi_furush where sanad_id=", row["ID"])));
			Frm_Safi frm_Safi = new Frm_Safi();
			frm_Safi.Furush_ID = Conversions.ToLong(dataRow["furush_hag_id"]);
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Safi);
			dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from safi_furush where sanad_id=", row["ID"])));
			bool flag = dataRow["printcount"] != DBNull.Value;
			if (flag)
			{
				this.GridEX1.CurrentRow.Cells["printcount"].Value = 1;
				this.GridEX1.Refresh();
			}
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x002263B8 File Offset: 0x002245B8
		private void ShowDaryaftPardakht(DataRowView row)
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Tarikh  FROM DaryaftPardakht  where sanadbed_id=", row["id"])
			}, null, null, null));
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT     Tarikh  FROM DaryaftPardakht  where sanadbes_id=", row["id"])
				}, null, null, null));
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				Frm_DaryaftPardakht frm_DaryaftPardakht = new Frm_DaryaftPardakht();
				frm_DaryaftPardakht.PreviewTarikh = Public_Function.MiladiToShamsi(Conversions.ToDate(text));
				frm_DaryaftPardakht.ShowPreview = true;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_DaryaftPardakht);
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x002264A4 File Offset: 0x002246A4
		private void ShowrizKharid(DataRowView row)
		{
			long num = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("select kharid_id from kharid_detail where sanad_id=", row["id"])
			}, null, null, null));
			Frm_RizKharid frm_RizKharid = new Frm_RizKharid
			{
				Kharid_ID = num,
				Preview = true
			};
			Kharid_Detail kharid_Detail = new Kharid_Detail();
			DataTable byID = kharid_Detail.GetByID(checked((int)num));
			frm_RizKharid.dt_Kharid = byID;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_RizKharid);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x0022653C File Offset: 0x0022473C
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "checked", false) == 0;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["sanadtype"].Value, 4, false);
				if (flag2)
				{
					this.GridEX1.CancelCurrentEdit();
				}
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x002265A8 File Offset: 0x002247A8
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1_RowDoubleClick(null, null);
			}
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x002265D0 File Offset: 0x002247D0
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
				flag = (dataRowView["sanadtype"] == DBNull.Value);
				if (!flag)
				{
					object left = dataRowView["sanadtype"];
					flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
					if (flag)
					{
						this.ShowDaryaftPardakht(dataRowView);
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
						if (flag)
						{
							this.showkharid(dataRowView);
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
							if (flag)
							{
								this.ShowFurush(dataRowView);
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
								if (flag)
								{
									this.ShowSafi(dataRowView);
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left, 5, false);
									if (flag)
									{
										this.ShowrizKharid(dataRowView);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x002266C4 File Offset: 0x002248C4
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Moshtari_Hesab showFrm = new Frm_Moshtari_Hesab
			{
				Moshtari_ID = Conversions.ToString(this.txt_moshtari.Value)
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00226704 File Offset: 0x00224904
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkDaryafti frm_rpt_checkDaryafti = new Frm_rpt_checkDaryafti();
			Frm_rpt_checkDaryafti arg_25_0 = frm_rpt_checkDaryafti;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checkDaryafti.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checkDaryafti showFrm = frm_rpt_checkDaryafti;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00226764 File Offset: 0x00224964
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_rpt_checksearchMoshtari frm_rpt_checksearchMoshtari = new Frm_rpt_checksearchMoshtari();
			Frm_rpt_checksearchMoshtari arg_25_0 = frm_rpt_checksearchMoshtari;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checksearchMoshtari.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checksearchMoshtari showFrm = frm_rpt_checksearchMoshtari;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x002267C4 File Offset: 0x002249C4
		private StiReport RenderReport(bool pdf)
		{
			bool flag = this.GridEX1.DataSource == null;
			StiReport result;
			if (flag)
			{
				result = null;
			}
			else
			{
				StiReport stiReport = new StiReport();
				stiReport.Load(Application.StartupPath + "\\reports\\surathesab.mrt");
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataTable dataTable2 = dataTable.Copy();
				DataTable dataTable3 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from moshtari_pic  where moshtari_id=", this.txt_moshtari.Value)));
				dataTable3.TableName = "pic";
				if (pdf)
				{
					Public_Function.RenderDigitToPdf(dataTable2);
				}
				dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
				stiReport.RegData(dataTable2.DefaultView);
				stiReport.RegData(dataTable3);
				Public_Function.SetHeader(stiReport, pdf);
				StiText stiText = (StiText)stiReport.GetComponentByName("Text13");
				stiText.Text = this.txt_moshtari.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text31");
				stiText.Text = Public_Function.ToFarsi(this.lbl_tel1.Text);
				stiText = (StiText)stiReport.GetComponentByName("Text33");
				stiText.Text = Public_Function.ToFarsi(this.lbl_tel2.Text);
				stiText = (StiText)stiReport.GetComponentByName("Text37");
				stiText.Text = Public_Function.ToFarsi(this.Label7.Text);
				stiText = (StiText)stiReport.GetComponentByName("Text16");
				stiText.Text = Public_Function.ToFarsi(this.lbl_addr.Text);
				stiText = (StiText)stiReport.GetComponentByName("Text49");
				stiText.Text = Public_Function.ToFarsi(this.lbl_code.Text);
				stiText = (StiText)stiReport.GetComponentByName("txt_codemelli");
				stiText.Text = Public_Function.ToFarsi(this.lbl_codemelli.Text);
				stiText = (StiText)stiReport.GetComponentByName("Text47");
				stiText.Text = this.lbl_shahr.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text35");
				stiText.Text = Public_Function.ToFarsi(Public_Function.MiladiToShamsi(DateAndTime.Now));
				stiText = (StiText)stiReport.GetComponentByName("Text40");
				if (pdf)
				{
					stiText.Text = Public_Function.RenderDigitToPdf(this.Moshtari_Info.LastTozih);
				}
				else
				{
					stiText.Text = this.Moshtari_Info.LastTozih;
				}
				stiText = (StiText)stiReport.GetComponentByName("Text41");
				if (pdf)
				{
					stiText.Text = Public_Function.RenderDigitToPdf(this.Moshtari_Info.Check_Status);
				}
				else
				{
					stiText.Text = this.Moshtari_Info.Check_Status;
				}
				stiText = (StiText)stiReport.GetComponentByName("Text2");
				stiText.Text = "از تاریخ " + Public_Function.ToFarsi(this.txt_az_tarikh.Text) + "تا تاریخ " + Public_Function.ToFarsi(this.txt_ta_tarikh.Text);
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
				}, null, null, null));
				flag = (num > 0);
				if (flag)
				{
					long value = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					stiText = (StiText)stiReport.GetComponentByName("Text42");
					if (pdf)
					{
						stiText.Text = Public_Function.RenderDigitToPdf("جمع " + Public_Function.ToFarsi(Conversions.ToString(num)) + " فقره چک برگشتی " + Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(value))));
					}
					else
					{
						stiText.Text = "جمع " + Public_Function.ToFarsi(Conversions.ToString(num)) + " فقره چک برگشتی " + Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(value)));
					}
				}
				Public_Function.AddTazminText(stiReport, true, pdf);
				Public_Function.SetReport_MarginTop(stiReport);
				Public_Function.setReportFont(stiReport, "Text14,Text17,Text39,Text19,Text18,Text20,Text21,Text22,Text24,Text25,Text28");
				result = stiReport;
			}
			return result;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00226C80 File Offset: 0x00224E80
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport == null;
			if (!flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x0000BC0C File Offset: 0x00009E0C
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00226CAC File Offset: 0x00224EAC
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
				DataRow dataRow = Public_Function.FillDataRow("  SELECT     null as ID, null as CodeHesab_ID,isnull(sum( Sanad.Bed),0) as Bed,isnull(sum( Sanad.Bes),0) as Bes,max(tarikh) as Tarikh, null as Tarikh_Fa, '' as Tozih,null AS Kala_Name,null AS rembed,   null AS rembes, null as Tedad,null as  Vazn_Kol,NULL AS Fee,NULL as ba_zarf,-1 as sanadtype,-1 as printcount    FROM Sanad    WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + " and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
				dataRow["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text);
				dataRow["Tozih"] = "مانده از قبل";
				DataRow dataRow2 = dataTable.NewRow();
				flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], dataRow["bes"], false);
				if (flag)
				{
					dataRow2["mande"] = Operators.SubtractObject(dataRow["bed"], dataRow["bes"]);
					dataRow2["stat"] = "بد";
				}
				else
				{
					dataRow2["mande"] = Operators.SubtractObject(dataRow["bes"], dataRow["bed"]);
					dataRow2["stat"] = "بس";
				}
				flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["mande"], 0, false);
				if (flag)
				{
					bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
					if (flag2)
					{
						dataTable.Rows[0].Delete();
					}
					dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
					dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
					dataRow2["tozih"] = "مانده از قبل";
					dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
					dataRow2["printcount"] = -1;
					dataTable.Rows.InsertAt(dataRow2, 0);
				}
				dataTable.DefaultView.RowFilter = string.Concat(new string[]
				{
					"tarikh >= '",
					Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
					"' AND tarikh<='",
					Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
					"'"
				});
				this.GridEX1.MoveFirst();
				this.GridEX1.MoveLast();
			}
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00226F7C File Offset: 0x0022517C
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x0000BC27 File Offset: 0x00009E27
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.PerformButtonClick();
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00226FA4 File Offset: 0x002251A4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			if (!flag)
			{
				Frm_Rpt_Furush frm_Rpt_Furush = new Frm_Rpt_Furush();
				frm_Rpt_Furush.txt_moshtari.SetValue(this.txt_moshtari.Text, RuntimeHelpers.GetObjectValue(this.txt_moshtari.Value));
				frm_Rpt_Furush.loaddata();
				frm_Rpt_Furush.ShowDialog();
			}
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00227004 File Offset: 0x00225204
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
				Frm_Moshtari arg_3D_0 = frm_Moshtari;
				object expr_2B = this.txt_moshtari.Value;
				int? num;
				arg_3D_0.ID = ((expr_2B != null) ? ((int?)expr_2B) : num);
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Moshtari);
				this.txt_moshtari.Text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select name+' '+family from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
			}
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x002270B4 File Offset: 0x002252B4
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(Conversions.ToString(this.last_mande));
				e.Row.Cells["stat"].Text = this.last_stat;
				e.Row.Cells["Tozih"].Text = this.mande;
				flag = (Operators.CompareString(this.mande, string.Empty, false) != 0);
				if (flag)
				{
					e.Row.Cells["Tozih"].FormatStyle = new GridEXFormatStyle();
					e.Row.Cells["Tozih"].FormatStyle.BackColor = Color.LightCoral;
					e.Row.Cells["Tozih"].FormatStyle.BackgroundGradientMode = BackgroundGradientMode.Solid;
				}
			}
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x0000BC37 File Offset: 0x00009E37
		private void txt_jamkharid_CheckedChanged(object sender, EventArgs e)
		{
			this.SelectItem1_SelectedValueChanged(null, null);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x002271C8 File Offset: 0x002253C8
		private void SendMessage(string msg, string tel)
		{
			try
			{
				new KavenegarApi(Public_Function.dict["sms_apikey"]).Send(Public_Function.dict["sms_number"], tel, msg);
				MessageBox.Show("پیامک ارسال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show("خطا در ارسال پیامک:\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00227248 File Offset: 0x00225448
		private string GetMessage(GridEXRow row)
		{
			string text = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(row.Cells["Tarikh_Fa"].Value, Environment.NewLine)));
			bool flag = Operators.ConditionalCompareObjectEqual(row.Cells["Tozih"].Value, "مانده از قبل", false);
			checked
			{
				string result;
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						"مانده قبل از ",
						this.txt_az_tarikh.Text,
						":",
						Public_Function.FormatPrice(Conversions.ToString(row.Cells["mande"].Value))
					});
					result = text;
				}
				else
				{
					flag = row.Cells["Tozih"].Value.ToString().Contains(")");
					if (flag)
					{
						int num = row.Cells["Tozih"].Value.ToString().IndexOf("(");
						int num2 = row.Cells["Tozih"].Value.ToString().IndexOf(")");
						text = row.Cells["Tozih"].Value.ToString().Remove(num, num2 - num + 2);
						num = text.ToString().IndexOf("(");
						flag = (num > 0);
						if (flag)
						{
							num2 = text.ToString().IndexOf(")");
							text = text.ToString().Remove(num, num2 - num + 2);
						}
						text += Environment.NewLine;
					}
					else
					{
						text = text + row.Cells["Tozih"].Value.ToString() + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["tedad"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "تعداد:" + row.Cells["tedad"].Value.ToString() + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["vazn_kol"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "خالص:" + row.Cells["vazn_kol"].Value.ToString() + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["fee"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "فی:" + row.Cells["fee"].Value.ToString().Replace(".0", "") + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["bed"].Value.ToString(), "0", false) != 0);
					if (flag)
					{
						text = text + "مبلغ:" + Public_Function.FormatPrice(row.Cells["bed"].Value.ToString()) + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["bes"].Value.ToString(), "0", false) != 0);
					if (flag)
					{
						text = text + "مبلغ:" + Public_Function.FormatPrice(row.Cells["bes"].Value.ToString()) + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["mande"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "مانده:" + Public_Function.FormatPrice(row.Cells["mande"].Value.ToString());
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00227674 File Offset: 0x00225874
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lbl_tel2.Text, string.Empty, false) == 0;
			checked
			{
				if (flag)
				{
					Public_Function.ShowMessage("شماره موبایل در مشخصات مشتری ثبت نگردیده است", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
				}
				else
				{
					string msg = string.Empty;
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow row = rows[i];
						msg = this.GetMessage(row);
						this.SendMessage(msg, this.lbl_tel2.Text);
					}
				}
			}
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x0000BC44 File Offset: 0x00009E44
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			this.ExportReport();
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x002276FC File Offset: 0x002258FC
		private void ButtonItem9_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			checked
			{
				if (!flag)
				{
					DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("SELECT      Safi_Furush.ID, Safi_Furush.printcount, Furush_Hag.Num, Furush_Hag.Moshtari_ID,Furush_Hag.ID AS Furush_ID   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)));
					string text = string.Empty;
					flag = (dataTable.Rows.Count > 0);
					if (flag)
					{
						Frm_Safi frm_Safi = new Frm_Safi();
						frm_Safi.WindowState = FormWindowState.Minimized;
						frm_Safi.ShowInTaskbar = false;
						frm_Safi.Show();
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								frm_Safi.Furush_ID = Conversions.ToLong(dataRow["furush_id"]);
								frm_Safi.Frm_Safi_Load(null, null);
								frm_Safi.ButtonItem4_Click(null, null);
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" update safi_furush set printcount=1 where id= ", dataRow["ID"])));
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
						frm_Safi.Close();
					}
					flag = (text.Length > 0);
					if (flag)
					{
						Public_Function.ExecuteNonQuery(text);
					}
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow gridEXRow = rows[i];
						gridEXRow.BeginEdit();
						gridEXRow.Cells["printcount"].Value = 1;
						gridEXRow.EndEdit();
					}
				}
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x0022653C File Offset: 0x0022473C
		private void GridEX1_CellValueChanged(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "checked", false) == 0;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["sanadtype"].Value, 4, false);
				if (flag2)
				{
					this.GridEX1.CancelCurrentEdit();
				}
			}
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x002278AC File Offset: 0x00225AAC
		private void RibbonStatusBar1_CommandClick(object sender, CommandEventArgs e)
		{
			bool flag = Operators.CompareString(e.Command.Key.ToLower(), "buttoncommand1", false) == 0;
			if (flag)
			{
				Frm_Rpt_SafiMande frm_Rpt_SafiMande = new Frm_Rpt_SafiMande();
				frm_Rpt_SafiMande.Moshtari_id = Conversions.ToLong(this.txt_moshtari.Value);
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Rpt_SafiMande);
				long num = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT      isnull(count(Safi_Furush.ID),0)   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)
				}, null, null, null));
				flag = (num == 0L);
				if (flag)
				{
					this.ButtonCommand1.Visible = false;
				}
				else
				{
					this.ButtonCommand1.Visible = true;
					this.ButtonCommand1.Text = "تعداد " + Conversions.ToString(num) + " صافی اعلام نشده وجود دارد";
				}
			}
		}

		// Token: 0x040011E0 RID: 4576
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040011E2 RID: 4578
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040011E3 RID: 4579
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040011E4 RID: 4580
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040011E5 RID: 4581
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040011E6 RID: 4582
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040011E7 RID: 4583
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040011E8 RID: 4584
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040011E9 RID: 4585
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040011EA RID: 4586
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040011EB RID: 4587
		[AccessedThroughProperty("lbl_tel3")]
		private Label _lbl_tel3;

		// Token: 0x040011EC RID: 4588
		[AccessedThroughProperty("lbl_tel4")]
		private Label _lbl_tel4;

		// Token: 0x040011ED RID: 4589
		[AccessedThroughProperty("lbl_tel2")]
		private Label _lbl_tel2;

		// Token: 0x040011EE RID: 4590
		[AccessedThroughProperty("lbl_tel1")]
		private Label _lbl_tel1;

		// Token: 0x040011EF RID: 4591
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040011F0 RID: 4592
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040011F1 RID: 4593
		[AccessedThroughProperty("lbl_codemelli")]
		private Label _lbl_codemelli;

		// Token: 0x040011F2 RID: 4594
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040011F3 RID: 4595
		[AccessedThroughProperty("lbl_addr")]
		private Label _lbl_addr;

		// Token: 0x040011F4 RID: 4596
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040011F5 RID: 4597
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040011F6 RID: 4598
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040011F7 RID: 4599
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x040011F8 RID: 4600
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x040011F9 RID: 4601
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x040011FA RID: 4602
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x040011FB RID: 4603
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x040011FC RID: 4604
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x040011FD RID: 4605
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x040011FE RID: 4606
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x040011FF RID: 4607
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04001200 RID: 4608
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001201 RID: 4609
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04001202 RID: 4610
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04001203 RID: 4611
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04001204 RID: 4612
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001205 RID: 4613
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001206 RID: 4614
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04001207 RID: 4615
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001208 RID: 4616
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001209 RID: 4617
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x0400120A RID: 4618
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x0400120B RID: 4619
		[AccessedThroughProperty("lbl_code")]
		private Label _lbl_code;

		// Token: 0x0400120C RID: 4620
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400120D RID: 4621
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x0400120E RID: 4622
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x0400120F RID: 4623
		[AccessedThroughProperty("lbl_shahr")]
		private Label _lbl_shahr;

		// Token: 0x04001210 RID: 4624
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04001211 RID: 4625
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04001212 RID: 4626
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04001213 RID: 4627
		[AccessedThroughProperty("txt_jamkharid")]
		private UICheckBox _txt_jamkharid;

		// Token: 0x04001214 RID: 4628
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04001215 RID: 4629
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x04001216 RID: 4630
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04001217 RID: 4631
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04001218 RID: 4632
		[AccessedThroughProperty("ButtonCommand1")]
		private ButtonCommand _ButtonCommand1;

		// Token: 0x04001219 RID: 4633
		private Moshtari_Info Moshtari_Info;

		// Token: 0x0400121A RID: 4634
		[CompilerGenerated]
		private int? _Moshtari_id;

		// Token: 0x0400121B RID: 4635
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x0400121C RID: 4636
		private Moshtari_Pic Moshtari_Pic;

		// Token: 0x0400121D RID: 4637
		private long last_mande;

		// Token: 0x0400121E RID: 4638
		private string last_stat;

		// Token: 0x0400121F RID: 4639
		private string mande;

		// Token: 0x0200013E RID: 318
		public enum bedbes
		{
			// Token: 0x04001221 RID: 4641
			bed,
			// Token: 0x04001222 RID: 4642
			bes
		}
	}
}
