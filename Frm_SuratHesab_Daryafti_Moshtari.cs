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
	// Token: 0x02000144 RID: 324
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Daryafti_Moshtari : Form
	{
		// Token: 0x06002F73 RID: 12147 RVA: 0x0022F2E0 File Offset: 0x0022D4E0
		public Frm_SuratHesab_Daryafti_Moshtari()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Moshtari_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Daryafti_Moshtari.__ENCAddToList(this);
			this.Moshtari_Info = new Moshtari_Info();
			this.Moshtari_Pic = new Moshtari_Pic();
			this.last_mande = 0L;
			this.last_stat = string.Empty;
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x0022F360 File Offset: 0x0022D560
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Daryafti_Moshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Count == Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Daryafti_Moshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Daryafti_Moshtari.__ENCList[num] = Frm_SuratHesab_Daryafti_Moshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Daryafti_Moshtari.__ENCList.RemoveRange(num, Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Count - num);
						Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Capacity = Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Count;
					}
					Frm_SuratHesab_Daryafti_Moshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00231DE4 File Offset: 0x0022FFE4
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x0000BE83 File Offset: 0x0000A083
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

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00231DFC File Offset: 0x0022FFFC
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x0000BE8D File Offset: 0x0000A08D
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

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x00231E14 File Offset: 0x00230014
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x00231E2C File Offset: 0x0023002C
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

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x00231F34 File Offset: 0x00230134
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x0000BE97 File Offset: 0x0000A097
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

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x00231F4C File Offset: 0x0023014C
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00231F64 File Offset: 0x00230164
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

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x00231FC4 File Offset: 0x002301C4
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x0000BEA1 File Offset: 0x0000A0A1
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

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00231FDC File Offset: 0x002301DC
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x0000BEAB File Offset: 0x0000A0AB
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

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x00231FF4 File Offset: 0x002301F4
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x0000BEB5 File Offset: 0x0000A0B5
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

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x0023200C File Offset: 0x0023020C
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x0000BEBF File Offset: 0x0000A0BF
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

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00232024 File Offset: 0x00230224
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x0000BEC9 File Offset: 0x0000A0C9
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x0023203C File Offset: 0x0023023C
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x0000BED3 File Offset: 0x0000A0D3
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

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x00232054 File Offset: 0x00230254
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x0000BEDD File Offset: 0x0000A0DD
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

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x0023206C File Offset: 0x0023026C
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x0000BEE7 File Offset: 0x0000A0E7
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

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00232084 File Offset: 0x00230284
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x0000BEF1 File Offset: 0x0000A0F1
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

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x0023209C File Offset: 0x0023029C
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x0000BEFB File Offset: 0x0000A0FB
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

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x002320B4 File Offset: 0x002302B4
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x0000BF05 File Offset: 0x0000A105
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

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x002320CC File Offset: 0x002302CC
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x0000BF0F File Offset: 0x0000A10F
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

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x002320E4 File Offset: 0x002302E4
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x0000BF19 File Offset: 0x0000A119
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

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x002320FC File Offset: 0x002302FC
		// (set) Token: 0x06002F9C RID: 12188 RVA: 0x0000BF23 File Offset: 0x0000A123
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

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x00232114 File Offset: 0x00230314
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x0000BF2D File Offset: 0x0000A12D
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

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x0023212C File Offset: 0x0023032C
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x0000BF37 File Offset: 0x0000A137
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

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x00232144 File Offset: 0x00230344
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x0023215C File Offset: 0x0023035C
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

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x002321BC File Offset: 0x002303BC
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x0000BF41 File Offset: 0x0000A141
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

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x002321D4 File Offset: 0x002303D4
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x0000BF4B File Offset: 0x0000A14B
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

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x002321EC File Offset: 0x002303EC
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x0000BF55 File Offset: 0x0000A155
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

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x00232204 File Offset: 0x00230404
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x0000BF5F File Offset: 0x0000A15F
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

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x0023221C File Offset: 0x0023041C
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0000BF69 File Offset: 0x0000A169
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

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x00232234 File Offset: 0x00230434
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x0000BF73 File Offset: 0x0000A173
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

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x0023224C File Offset: 0x0023044C
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x0000BF7D File Offset: 0x0000A17D
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

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x00232264 File Offset: 0x00230464
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x0000BF87 File Offset: 0x0000A187
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

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0023227C File Offset: 0x0023047C
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0000BF91 File Offset: 0x0000A191
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

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x00232294 File Offset: 0x00230494
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x002322AC File Offset: 0x002304AC
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

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x0023230C File Offset: 0x0023050C
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00232324 File Offset: 0x00230524
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

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x00232384 File Offset: 0x00230584
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x0023239C File Offset: 0x0023059C
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x002323FC File Offset: 0x002305FC
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x00232414 File Offset: 0x00230614
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

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x00232474 File Offset: 0x00230674
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x0023248C File Offset: 0x0023068C
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

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x002324EC File Offset: 0x002306EC
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x0000BF9B File Offset: 0x0000A19B
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

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x00232504 File Offset: 0x00230704
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x0023251C File Offset: 0x0023071C
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

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x0023257C File Offset: 0x0023077C
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x00232594 File Offset: 0x00230794
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

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x002325F4 File Offset: 0x002307F4
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x0000BFA5 File Offset: 0x0000A1A5
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

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x0023260C File Offset: 0x0023080C
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x0000BFAF File Offset: 0x0000A1AF
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

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x00232624 File Offset: 0x00230824
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x0000BFB9 File Offset: 0x0000A1B9
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

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x0023263C File Offset: 0x0023083C
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x00232654 File Offset: 0x00230854
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

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x002326B4 File Offset: 0x002308B4
		// (set) Token: 0x06002FCE RID: 12238 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
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

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x002326CC File Offset: 0x002308CC
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x0000BFCD File Offset: 0x0000A1CD
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

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x002326E4 File Offset: 0x002308E4
		// (set) Token: 0x06002FD2 RID: 12242 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
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

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x002326FC File Offset: 0x002308FC
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x00232714 File Offset: 0x00230914
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

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x00232774 File Offset: 0x00230974
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x0023278C File Offset: 0x0023098C
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

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x002327EC File Offset: 0x002309EC
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x0000BFE1 File Offset: 0x0000A1E1
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

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x00232804 File Offset: 0x00230A04
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x0023281C File Offset: 0x00230A1C
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

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x0023287C File Offset: 0x00230A7C
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x00232894 File Offset: 0x00230A94
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

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x002328F4 File Offset: 0x00230AF4
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x0000BFEB File Offset: 0x0000A1EB
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

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x0023290C File Offset: 0x00230B0C
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x00232924 File Offset: 0x00230B24
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

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x00232984 File Offset: 0x00230B84
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x0023299C File Offset: 0x00230B9C
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

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x002329FC File Offset: 0x00230BFC
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x0000BFF5 File Offset: 0x0000A1F5
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

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x00232A14 File Offset: 0x00230C14
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x0000BFFF File Offset: 0x0000A1FF
		internal virtual Label lbl_tedad_havale
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tedad_havale;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tedad_havale = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x00232A2C File Offset: 0x00230C2C
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x0000C009 File Offset: 0x0000A209
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

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x00232A44 File Offset: 0x00230C44
		// (set) Token: 0x06002FEA RID: 12266 RVA: 0x0000C013 File Offset: 0x0000A213
		internal virtual Label lbl_tedad_safi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tedad_safi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tedad_safi = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x00232A5C File Offset: 0x00230C5C
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x0000C01D File Offset: 0x0000A21D
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

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x00232A74 File Offset: 0x00230C74
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x0000C027 File Offset: 0x0000A227
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

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x00232A8C File Offset: 0x00230C8C
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x0000C031 File Offset: 0x0000A231
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

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00232AA4 File Offset: 0x00230CA4
		private long Refresh_Status()
		{
			this.LabelCommand2.Text = this.Moshtari_Info.LastTozih.ToString();
			this.LabelCommand1.Text = this.Moshtari_Info.Check_Status;
			this.LabelCommand3.Text = this.Moshtari_Info.Mande_Name;
			bool flag = this.Moshtari_Info.Mande == -1L;
			long result;
			if (flag)
			{
				this.LabelCommand4.Text = "";
				result = 0L;
			}
			else
			{
				flag = (this.Moshtari_Info.Mande != this.last_mande);
				if (flag)
				{
				}
				this.LabelCommand4.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(this.Moshtari_Info.Mande)));
				result = this.Moshtari_Info.Mande;
			}
			return result;
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x00223D44 File Offset: 0x00221F44
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

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00043BA4 File Offset: 0x00041DA4
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

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00232B78 File Offset: 0x00230D78
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

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00232C0C File Offset: 0x00230E0C
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

		// Token: 0x06002FF6 RID: 12278 RVA: 0x00224154 File Offset: 0x00222354
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

		// Token: 0x06002FF7 RID: 12279 RVA: 0x00043C30 File Offset: 0x00041E30
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

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0009DA70 File Offset: 0x0009BC70
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

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		private void addtedad(DataRow row, DataRow[] r)
		{
			row["tedad"] = RuntimeHelpers.GetObjectValue(r[0]["tedad"]);
			row["vazn_kol"] = RuntimeHelpers.GetObjectValue(r[0]["vazn_kol"]);
			row["fee"] = RuntimeHelpers.GetObjectValue(r[0]["fee"]);
			row["ba_zarf"] = RuntimeHelpers.GetObjectValue(r[0]["ba_zarf"]);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00232DA0 File Offset: 0x00230FA0
		private void loadJamFurushRuzane(DataTable dt, string codehesab_id)
		{
			bool flag = !this.txt_jamkharid.Checked;
			if (!flag)
			{
				string command = string.Concat(new string[]
				{
					"select * from ( SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc    FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype is null and Sanad.CodeHesab_ID = ",
					codehesab_id,
					"   UNION all   SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,   Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc   FROM         Kala INNER JOIN   Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID    WHERE sanad.arztype is null and Sanad.CodeHesab_ID = ",
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

		// Token: 0x06002FFB RID: 12283 RVA: 0x00232F04 File Offset: 0x00231104
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

		// Token: 0x06002FFC RID: 12284 RVA: 0x0000205D File Offset: 0x0000025D
		private void Delete_Ersalbar_duplicate()
		{
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0000205D File Offset: 0x0000025D
		private void Delete_invalid_row(DataTable dt)
		{
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00232FD0 File Offset: 0x002311D0
		private void Delete_Sanad_Invalid(DataTable dt, long codehesab_id)
		{
			string iD = Public_Function.GetID(dt, "id", "");
			bool flag = Operators.CompareString(iD, string.Empty, false) != 0;
			if (flag)
			{
				Public_Function.ExecuteNonQuery(string.Concat(new string[]
				{
					"delete from sanad where codehesab_id=",
					Conversions.ToString(codehesab_id),
					" and id not in(",
					iD,
					")"
				}));
			}
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00233044 File Offset: 0x00231244
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			if (!flag)
			{
				this.LoadMoshtariData(Conversions.ToString(this.txt_moshtari.Value));
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
				string text = string.Empty;
				text = text + " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, NULL AS Tedad, NULL AS Vazn_Kol, NULL AS Fee, NULL AS ba_zarf, 1 AS sanadtype, - 1 AS printcount, DaryaftPardakht.PardakhtCheck_ID,  DaryaftPardakht_1.ID AS Check_ID, 1 AS calc,0 as checked  FROM         Sanad LEFT OUTER JOIN  DaryaftPardakht ON Sanad.ID = DaryaftPardakht.SanadBed_ID LEFT OUTER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON Sanad.ID = DaryaftPardakht_1.SanadBes_ID  WHERE     ( sanad.arztype is null and Sanad.CodeHesab_ID = " + Conversions.ToString(num) + ")  AND ((Sanad.sanadtype is null) OR (sanad.sanadtype =1))   ORDER BY sanad.Tarikh,sanadtype ";
				DataTable dataTable = Public_Function.FillData(text);
				this.Delete_Tekrari(dataTable);
				this.Delete_invalid_row(dataTable);
				this.loadJamFurushRuzane(dataTable, Conversions.ToString(num));
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["kala_name"] != DBNull.Value);
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 1, false);
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
									DataRow arg_17F_0 = dataRow2;
									string columnName = "Tozih";
									arg_17F_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " / " + array[0]);
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
								DataRow arg_241_0 = dataRow2;
								string columnName = "Tozih";
								arg_241_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" / ", dataRow["kala_Name"]));
							}
						}
						else
						{
							string[] array = dataRow["Tozih"].ToString().Split(new char[]
							{
								'-'
							});
							bool flag2 = array.Length == 4;
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
					bool flag2 = enumerator is IDisposable;
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
						bool flag2 = dataRow3["checked"] == DBNull.Value;
						if (flag2)
						{
							dataRow3["checked"] = 0;
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
				dataTable.Columns.Add("mande", typeof(long));
				dataTable.Columns.Add("stat", typeof(string));
				dataTable.Columns.Add("rad", typeof(long));
				try
				{
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow4 = (DataRow)enumerator3.Current;
						long num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow4["bed"]));
						num2 = Conversions.ToLong(Operators.SubtractObject(num2, dataRow4["bes"]));
						dataRow4["mande"] = Math.Abs(num2);
						bool flag2 = num2 > 0L;
						if (flag2)
						{
							dataRow4["stat"] = "بد";
						}
						else
						{
							flag2 = (num2 < 0L);
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
					bool flag2 = enumerator3 is IDisposable;
					if (flag2)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				long num3 = 0L;
				bool flag3;
				checked
				{
					bool flag2;
					try
					{
						IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DataRow dataRow5 = (DataRow)enumerator4.Current;
							dataRow5["rad"] = num3;
							num3 += 1L;
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
					int num4 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select isnull(kind,0) from moshtari where id=", this.txt_moshtari.Value)
					}, null, null, null));
					bool arg_672_0;
					if (num4 != 1 && num4 != 3)
					{
						if (num4 != 5)
						{
							arg_672_0 = false;
							goto IL_671;
						}
					}
					arg_672_0 = true;
					IL_671:
					flag2 = arg_672_0;
					if (flag2)
					{
						int num5 = -1;
						int num6 = -1;
						string text2 = string.Empty;
						num5 = this.GetNextPosBed(num5, dataTable);
						num6 = this.GetNextPosBes(num6, dataTable);
						while (num5 != -1 && num6 != -1)
						{
							flag2 = Operators.ConditionalCompareObjectLess(dataTable.Rows[num6]["rembes"], dataTable.Rows[num5]["rembed"], false);
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
										dataRow2 = dataTable.Rows[num6];
										DataRow arg_755_0 = dataRow2;
										columnName = "Tozih";
										arg_755_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " ( تسویه تا " + text2 + " ) ");
									}
									text2 = string.Empty;
								}
								dataRow2 = dataTable.Rows[num5];
								DataRow arg_7A6_0 = dataRow2;
								columnName = "rembed";
								arg_7A6_0[columnName] = Operators.SubtractObject(dataRow2[columnName], dataTable.Rows[num6]["rembes"]);
								flag3 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num6]["stat"], "ت", false);
								if (flag3)
								{
									flag2 = Conversions.ToBoolean(Public_Function.dict["autosurat"]);
									if (flag2)
									{
										dataRow2 = dataTable.Rows[num6];
										DataRow arg_877_0 = dataRow2;
										columnName = "Tozih";
										arg_877_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( وجه به ", dataTable.Rows[num5]["Tarikh_Fa"]), " - مانده "), Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[num5]["rembed"]))), " ) "));
									}
								}
								num6 = this.GetNextPosBes(num6, dataTable);
							}
							else
							{
								long num7 = Conversions.ToLong(Operators.SubtractObject(dataTable.Rows[num6]["rembes"], dataTable.Rows[num5]["rembed"]));
								dataTable.Rows[num5]["rembed"] = 0;
								text2 = Conversions.ToString(dataTable.Rows[num5]["Tarikh_Fa"]);
								num5 = this.GetNextPosBed(num5, dataTable);
								dataTable.Rows[num6]["rembes"] = num7;
							}
						}
					}
					int num8 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					flag3 = (num8 > 0);
					if (flag3)
					{
						long value = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
						}, null, null, null));
						this.LabelCommand10.Text = "جمع " + Conversions.ToString(num8) + " فقره چک برگشتی " + Public_Function.FormatPrice(Conversions.ToString(value));
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
							object arg_AC3_0 = this.txt_az_tarikh;
							Type arg_AC3_1 = null;
							string arg_AC3_2 = "SetDate";
							object[] array2 = new object[1];
							object[] arg_AA9_0 = array2;
							int arg_AA9_1 = 0;
							DataRow dataRow2 = dataTable.Rows[0];
							DataRow arg_A9F_0 = dataRow2;
							string columnName = "tarikh_Fa";
							arg_AA9_0[arg_AA9_1] = RuntimeHelpers.GetObjectValue(arg_A9F_0[columnName]);
							object[] array3 = array2;
							object[] arg_AC3_3 = array3;
							string[] arg_AC3_4 = null;
							Type[] arg_AC3_5 = null;
							bool[] array4 = new bool[]
							{
								true
							};
							NewLateBinding.LateCall(arg_AC3_0, arg_AC3_1, arg_AC3_2, arg_AC3_3, arg_AC3_4, arg_AC3_5, array4, true);
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
								object arg_B7B_0 = this.txt_ta_tarikh;
								Type arg_B7B_1 = null;
								string arg_B7B_2 = "SetDate";
								object[] array3 = new object[1];
								object[] arg_B61_0 = array3;
								int arg_B61_1 = 0;
								DataRow dataRow2 = dataTable.Rows[dataTable.Rows.Count - 1];
								DataRow arg_B57_0 = dataRow2;
								string columnName = "tarikh_fa";
								arg_B61_0[arg_B61_1] = RuntimeHelpers.GetObjectValue(arg_B57_0[columnName]);
								object[] array2 = array3;
								object[] arg_B7B_3 = array2;
								string[] arg_B7B_4 = null;
								Type[] arg_B7B_5 = null;
								bool[] array4 = new bool[]
								{
									true
								};
								NewLateBinding.LateCall(arg_B7B_0, arg_B7B_1, arg_B7B_2, arg_B7B_3, arg_B7B_4, arg_B7B_5, array4, true);
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
					long num9 = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("SELECT      isnull(count(Safi_Furush.ID),0)   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					flag3 = (num9 == 0L);
					if (flag3)
					{
						this.ButtonCommand1.Visible = false;
					}
					else
					{
						this.ButtonCommand1.Visible = true;
						this.ButtonCommand1.Text = "تعداد " + Conversions.ToString(num9) + " صافی اعلام نشده وجود دارد";
					}
					this.show_tedad_safi(dataTable);
					long num10 = this.Refresh_Status();
					flag3 = (num10 != this.last_mande);
				}
				if (flag3)
				{
					this.Delete_Sanad_Invalid(dataTable, (long)num);
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.txt_moshtari.Value);
					this.Refresh_Status();
				}
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.SelectionLength = 0;
				this.txt_az_tarikh.SelectionStart = 5;
				this.txt_az_tarikh.SelectionLength = 2;
			}
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x002256E8 File Offset: 0x002238E8
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

		// Token: 0x06003001 RID: 12289 RVA: 0x00225828 File Offset: 0x00223A28
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

		// Token: 0x06003002 RID: 12290 RVA: 0x00233E80 File Offset: 0x00232080
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

		// Token: 0x06003003 RID: 12291 RVA: 0x00233FEC File Offset: 0x002321EC
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

		// Token: 0x06003004 RID: 12292 RVA: 0x00234138 File Offset: 0x00232338
		private void ExportReport()
		{
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StiReport stiReport = this.RenderReport(true);
				flag = (stiReport == null);
				if (!flag)
				{
					Public_Function.Sti_replace(stiReport, "Text1,Text48,Text5,Text45,Text36,Text30,Text32,Text46");
					StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
					flag = (stiText != null);
					if (flag)
					{
						stiText.Text = Public_Function.RenderDigitToPdf(stiText.Text);
					}
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

		// Token: 0x06003005 RID: 12293 RVA: 0x00234264 File Offset: 0x00232464
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

		// Token: 0x06003006 RID: 12294 RVA: 0x00234310 File Offset: 0x00232510
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

		// Token: 0x06003007 RID: 12295 RVA: 0x002344F4 File Offset: 0x002326F4
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

		// Token: 0x06003008 RID: 12296 RVA: 0x00234700 File Offset: 0x00232900
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

		// Token: 0x06003009 RID: 12297 RVA: 0x002263B8 File Offset: 0x002245B8
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

		// Token: 0x0600300A RID: 12298 RVA: 0x002264A4 File Offset: 0x002246A4
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

		// Token: 0x0600300B RID: 12299 RVA: 0x002347D0 File Offset: 0x002329D0
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

		// Token: 0x0600300C RID: 12300 RVA: 0x0023483C File Offset: 0x00232A3C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1_RowDoubleClick(null, null);
			}
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00234864 File Offset: 0x00232A64
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

		// Token: 0x0600300E RID: 12302 RVA: 0x00234958 File Offset: 0x00232B58
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Moshtari_Hesab showFrm = new Frm_Moshtari_Hesab
			{
				Moshtari_ID = Conversions.ToString(this.txt_moshtari.Value)
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00234998 File Offset: 0x00232B98
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

		// Token: 0x06003010 RID: 12304 RVA: 0x002349F8 File Offset: 0x00232BF8
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

		// Token: 0x06003011 RID: 12305 RVA: 0x00234A58 File Offset: 0x00232C58
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
				Public_Function.SetSti_text(stiReport, "Text31", Public_Function.ToFarsi(this.lbl_tel1.Text));
				Public_Function.SetSti_text(stiReport, "Text33", Public_Function.ToFarsi(this.lbl_tel2.Text));
				Public_Function.SetSti_text(stiReport, "Text37", Public_Function.ToFarsi(this.Label7.Text));
				Public_Function.SetSti_text(stiReport, "Text16", Public_Function.ToFarsi(this.lbl_addr.Text));
				Public_Function.SetSti_text(stiReport, "Text49", Public_Function.ToFarsi(this.lbl_code.Text));
				Public_Function.SetSti_text(stiReport, "txt_codemelli", Public_Function.ToFarsi(this.lbl_codemelli.Text));
				Public_Function.SetSti_text(stiReport, "Text47", Public_Function.ToFarsi(this.lbl_shahr.Text));
				Public_Function.SetSti_text(stiReport, "Text35", Public_Function.ToFarsi(Public_Function.MiladiToShamsi(DateAndTime.Now)));
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
				flag = (stiText != null);
				if (flag)
				{
					stiText.Text = "از تاریخ " + Public_Function.ToFarsi(this.txt_az_tarikh.Text) + "تا تاریخ " + Public_Function.ToFarsi(this.txt_ta_tarikh.Text);
				}
				else
				{
					stiText = (StiText)stiReport.GetComponentByName("txt_az_tarikh");
					stiText.Text = Public_Function.ToFarsi(this.txt_az_tarikh.Text);
					stiText = (StiText)stiReport.GetComponentByName("txt_ta_tarikh");
					stiText.Text = Public_Function.ToFarsi(this.txt_ta_tarikh.Text);
				}
				stiText = (StiText)stiReport.GetComponentByName("txt_mande");
				flag = (stiText != null);
				if (flag)
				{
					stiText.Text = huruf.ConvertToHuruf(Conversions.ToString(this.Moshtari_Info.Mande), huruf.ConvertType.ریال);
				}
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

		// Token: 0x06003012 RID: 12306 RVA: 0x00234F38 File Offset: 0x00233138
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport == null;
			if (!flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0000C03B File Offset: 0x0000A23B
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x00234F64 File Offset: 0x00233164
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
				this.show_tedad_safi(dataTable);
				this.GridEX1.MoveFirst();
				this.GridEX1.MoveLast();
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x0023523C File Offset: 0x0023343C
		private void show_tedad_safi(DataTable dt)
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				bool flag2;
				try
				{
					IEnumerator enumerator = dt.DefaultView.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRowView dataRowView = (DataRowView)enumerator.Current;
						bool flag = dataRowView["sanadtype"] == DBNull.Value;
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(dataRowView["sanadtype"], 4, false);
							if (flag)
							{
								num++;
							}
							flag = Operators.ConditionalCompareObjectGreater(dataRowView["bed"], 0, false);
							if (flag)
							{
								flag2 = dataRowView["tozih"].ToString().Contains("فروش");
								if (!flag2)
								{
									num2++;
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
				flag2 = (num > 0);
				if (flag2)
				{
					this.lbl_tedad_safi.Visible = true;
					this.lbl_tedad_havale.Visible = true;
					this.Label13.Visible = true;
					this.Label16.Visible = true;
					this.lbl_tedad_safi.Text = Conversions.ToString(num);
					this.lbl_tedad_havale.Text = Conversions.ToString(num2);
				}
				else
				{
					this.lbl_tedad_safi.Visible = false;
					this.lbl_tedad_havale.Visible = false;
					this.Label13.Visible = false;
					this.Label16.Visible = false;
				}
			}
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x002353CC File Offset: 0x002335CC
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0000C056 File Offset: 0x0000A256
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.PerformButtonClick();
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x002353F4 File Offset: 0x002335F4
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

		// Token: 0x06003019 RID: 12313 RVA: 0x00235454 File Offset: 0x00233654
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

		// Token: 0x0600301A RID: 12314 RVA: 0x00235504 File Offset: 0x00233704
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

		// Token: 0x0600301B RID: 12315 RVA: 0x0000C066 File Offset: 0x0000A266
		private void txt_jamkharid_CheckedChanged(object sender, EventArgs e)
		{
			this.SelectItem1_SelectedValueChanged(null, null);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x002271C8 File Offset: 0x002253C8
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

		// Token: 0x0600301D RID: 12317 RVA: 0x00235618 File Offset: 0x00233818
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

		// Token: 0x0600301E RID: 12318 RVA: 0x00235A44 File Offset: 0x00233C44
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

		// Token: 0x0600301F RID: 12319 RVA: 0x0000C073 File Offset: 0x0000A273
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			this.ExportReport();
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00235ACC File Offset: 0x00233CCC
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

		// Token: 0x06003021 RID: 12321 RVA: 0x002347D0 File Offset: 0x002329D0
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

		// Token: 0x06003022 RID: 12322 RVA: 0x00235C7C File Offset: 0x00233E7C
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

		// Token: 0x04001268 RID: 4712
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400126A RID: 4714
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400126B RID: 4715
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400126C RID: 4716
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400126D RID: 4717
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400126E RID: 4718
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x0400126F RID: 4719
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001270 RID: 4720
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04001271 RID: 4721
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04001272 RID: 4722
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001273 RID: 4723
		[AccessedThroughProperty("lbl_tel3")]
		private Label _lbl_tel3;

		// Token: 0x04001274 RID: 4724
		[AccessedThroughProperty("lbl_tel4")]
		private Label _lbl_tel4;

		// Token: 0x04001275 RID: 4725
		[AccessedThroughProperty("lbl_tel2")]
		private Label _lbl_tel2;

		// Token: 0x04001276 RID: 4726
		[AccessedThroughProperty("lbl_tel1")]
		private Label _lbl_tel1;

		// Token: 0x04001277 RID: 4727
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001278 RID: 4728
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04001279 RID: 4729
		[AccessedThroughProperty("lbl_codemelli")]
		private Label _lbl_codemelli;

		// Token: 0x0400127A RID: 4730
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400127B RID: 4731
		[AccessedThroughProperty("lbl_addr")]
		private Label _lbl_addr;

		// Token: 0x0400127C RID: 4732
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400127D RID: 4733
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400127E RID: 4734
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400127F RID: 4735
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04001280 RID: 4736
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04001281 RID: 4737
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04001282 RID: 4738
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04001283 RID: 4739
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04001284 RID: 4740
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04001285 RID: 4741
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04001286 RID: 4742
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04001287 RID: 4743
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04001288 RID: 4744
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001289 RID: 4745
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x0400128A RID: 4746
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x0400128B RID: 4747
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x0400128C RID: 4748
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400128D RID: 4749
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400128E RID: 4750
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x0400128F RID: 4751
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001290 RID: 4752
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001291 RID: 4753
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04001292 RID: 4754
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04001293 RID: 4755
		[AccessedThroughProperty("lbl_code")]
		private Label _lbl_code;

		// Token: 0x04001294 RID: 4756
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04001295 RID: 4757
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x04001296 RID: 4758
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x04001297 RID: 4759
		[AccessedThroughProperty("lbl_shahr")]
		private Label _lbl_shahr;

		// Token: 0x04001298 RID: 4760
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04001299 RID: 4761
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x0400129A RID: 4762
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x0400129B RID: 4763
		[AccessedThroughProperty("txt_jamkharid")]
		private UICheckBox _txt_jamkharid;

		// Token: 0x0400129C RID: 4764
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x0400129D RID: 4765
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x0400129E RID: 4766
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x0400129F RID: 4767
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x040012A0 RID: 4768
		[AccessedThroughProperty("ButtonCommand1")]
		private ButtonCommand _ButtonCommand1;

		// Token: 0x040012A1 RID: 4769
		[AccessedThroughProperty("lbl_tedad_havale")]
		private Label _lbl_tedad_havale;

		// Token: 0x040012A2 RID: 4770
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040012A3 RID: 4771
		[AccessedThroughProperty("lbl_tedad_safi")]
		private Label _lbl_tedad_safi;

		// Token: 0x040012A4 RID: 4772
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040012A5 RID: 4773
		private Moshtari_Info Moshtari_Info;

		// Token: 0x040012A6 RID: 4774
		[CompilerGenerated]
		private int? _Moshtari_id;

		// Token: 0x040012A7 RID: 4775
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x040012A8 RID: 4776
		private Moshtari_Pic Moshtari_Pic;

		// Token: 0x040012A9 RID: 4777
		private long last_mande;

		// Token: 0x040012AA RID: 4778
		private string last_stat;

		// Token: 0x040012AB RID: 4779
		private string mande;

		// Token: 0x02000145 RID: 325
		public enum bedbes
		{
			// Token: 0x040012AD RID: 4781
			bed,
			// Token: 0x040012AE RID: 4782
			bes
		}
	}
}
