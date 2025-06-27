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
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Validator;
using FruitBox.My;
using FruitBox.My.Resources;
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
	// Token: 0x020000E8 RID: 232
	[DesignerGenerated]
	public partial class Frm_DaryaftPardakht : Form
	{
		// Token: 0x060016A8 RID: 5800 RVA: 0x000F5EC8 File Offset: 0x000F40C8
		public Frm_DaryaftPardakht()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftPardakht_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftPardakht_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftPardakht_Load);
			base.Resize += new EventHandler(this.Frm_DaryaftPardakht_Resize);
			Frm_DaryaftPardakht.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.frm = new Frm_SelectItem();
			this.Sanad = new Sanad();
			this.Sandug = new Sandugh();
			this.prevent = false;
			this.ListDaryaft_Identity = new List<listCheckDaryaft>();
			this.dt_search1 = new DataTable();
			this.dt_search2 = new DataTable();
			this.historyLog = new HistoryLog();
			this.change = new List<TableItemChange>();
			this.Moshtari_Info = new Moshtari_Info();
			this.prevent_close = false;
			this.prevent_mablagh = false;
			this.f2_click = false;
			this.home_clicked = false;
			this.vagozari_bankhesab_Name = string.Empty;
			bool showPreview = false;
			this.ShowPreview = showPreview;
			string empty = string.Empty;
			this.PreviewTarikh = empty;
			this.InitializeComponent();
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000F5FF0 File Offset: 0x000F41F0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DaryaftPardakht.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DaryaftPardakht.__ENCList.Count == Frm_DaryaftPardakht.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DaryaftPardakht.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DaryaftPardakht.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DaryaftPardakht.__ENCList[num] = Frm_DaryaftPardakht.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DaryaftPardakht.__ENCList.RemoveRange(num, Frm_DaryaftPardakht.__ENCList.Count - num);
						Frm_DaryaftPardakht.__ENCList.Capacity = Frm_DaryaftPardakht.__ENCList.Count;
					}
					Frm_DaryaftPardakht.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x0010062C File Offset: 0x000FE82C
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x00100644 File Offset: 0x000FE844
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
				EventHandler value4 = new EventHandler(this.txt_tarikh_Click);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.Validated -= value2;
					this._txt_tarikh.KeyDown -= value3;
					this._txt_tarikh.Click -= value4;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.Validated += value2;
					this._txt_tarikh.KeyDown += value3;
					this._txt_tarikh.Click += value4;
				}
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x001006F4 File Offset: 0x000FE8F4
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00006F0A File Offset: 0x0000510A
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

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0010070C File Offset: 0x000FE90C
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x00006F14 File Offset: 0x00005114
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

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00100724 File Offset: 0x000FE924
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00006F1E File Offset: 0x0000511E
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

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0010073C File Offset: 0x000FE93C
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00100754 File Offset: 0x000FE954
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
				EventHandler value4 = new EventHandler(this.GridEX1_GotFocus);
				EndCustomEditEventHandler value5 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				EditingCellEventHandler value6 = new EditingCellEventHandler(this.GridEX1_EditingCell);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyEventHandler value8 = new KeyEventHandler(this.GridEX1_KeyDown);
				EventHandler value9 = new EventHandler(this.gridex2_RecordAdded);
				ColumnActionEventHandler value10 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.InitCustomEdit -= value2;
					this._GridEX1.SelectionChanged -= value3;
					this._GridEX1.GotFocus -= value4;
					this._GridEX1.EndCustomEdit -= value5;
					this._GridEX1.EditingCell -= value6;
					this._GridEX1.ColumnButtonClick -= value7;
					this._GridEX1.KeyDown -= value8;
					this._GridEX1.RecordAdded -= value9;
					this._GridEX1.CellEdited -= value10;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.InitCustomEdit += value2;
					this._GridEX1.SelectionChanged += value3;
					this._GridEX1.GotFocus += value4;
					this._GridEX1.EndCustomEdit += value5;
					this._GridEX1.EditingCell += value6;
					this._GridEX1.ColumnButtonClick += value7;
					this._GridEX1.KeyDown += value8;
					this._GridEX1.RecordAdded += value9;
					this._GridEX1.CellEdited += value10;
				}
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00100908 File Offset: 0x000FEB08
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x00006F28 File Offset: 0x00005128
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

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00100920 File Offset: 0x000FEB20
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00006F32 File Offset: 0x00005132
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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00100938 File Offset: 0x000FEB38
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00100950 File Offset: 0x000FEB50
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
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat != null;
				if (flag)
				{
					this._txt_babat.Validated -= value2;
					this._txt_babat.KeyDown -= value3;
				}
				this._txt_babat = value;
				flag = (this._txt_babat != null);
				if (flag)
				{
					this._txt_babat.Validated += value2;
					this._txt_babat.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x001009D8 File Offset: 0x000FEBD8
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x001009F0 File Offset: 0x000FEBF0
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
				EventHandler value2 = new EventHandler(this.Bar1_ItemClick);
				bool flag = this._Bar1 != null;
				if (flag)
				{
					this._Bar1.ItemClick -= value2;
				}
				this._Bar1 = value;
				flag = (this._Bar1 != null);
				if (flag)
				{
					this._Bar1.ItemClick += value2;
				}
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x00100A50 File Offset: 0x000FEC50
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x00006F3C File Offset: 0x0000513C
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

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00100A68 File Offset: 0x000FEC68
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00100A80 File Offset: 0x000FEC80
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00100AE0 File Offset: 0x000FECE0
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x00100AF8 File Offset: 0x000FECF8
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

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x00100B58 File Offset: 0x000FED58
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x00100B70 File Offset: 0x000FED70
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00100BD0 File Offset: 0x000FEDD0
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x00006F46 File Offset: 0x00005146
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

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00100BE8 File Offset: 0x000FEDE8
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00006F50 File Offset: 0x00005150
		internal virtual UIGroupBox group_dcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_dcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_dcheck = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00100C00 File Offset: 0x000FEE00
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00100C18 File Offset: 0x000FEE18
		internal virtual EditBox txt_shobe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shobe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_shobe != null;
				if (flag)
				{
					this._txt_shobe.Validated -= value2;
				}
				this._txt_shobe = value;
				flag = (this._txt_shobe != null);
				if (flag)
				{
					this._txt_shobe.Validated += value2;
				}
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x00100C78 File Offset: 0x000FEE78
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00100C90 File Offset: 0x000FEE90
		internal virtual SelectItem txt_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_bank_Validated);
				bool flag = this._txt_bank != null;
				if (flag)
				{
					this._txt_bank.Validated -= value2;
				}
				this._txt_bank = value;
				flag = (this._txt_bank != null);
				if (flag)
				{
					this._txt_bank.Validated += value2;
				}
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x00100CF0 File Offset: 0x000FEEF0
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00100D08 File Offset: 0x000FEF08
		internal virtual NumericBox txt_shcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				bool flag = this._txt_shcheck != null;
				if (flag)
				{
					this._txt_shcheck.Validated -= value2;
				}
				this._txt_shcheck = value;
				flag = (this._txt_shcheck != null);
				if (flag)
				{
					this._txt_shcheck.Validated += value2;
				}
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00100D68 File Offset: 0x000FEF68
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00006F5A File Offset: 0x0000515A
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00100D80 File Offset: 0x000FEF80
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00006F64 File Offset: 0x00005164
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00100D98 File Offset: 0x000FEF98
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00006F6E File Offset: 0x0000516E
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00100DB0 File Offset: 0x000FEFB0
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00006F78 File Offset: 0x00005178
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

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00100DC8 File Offset: 0x000FEFC8
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x00006F82 File Offset: 0x00005182
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

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00100DE0 File Offset: 0x000FEFE0
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00100DF8 File Offset: 0x000FEFF8
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
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babatcheck != null;
				if (flag)
				{
					this._txt_babatcheck.Validated -= value2;
					this._txt_babatcheck.KeyDown -= value3;
				}
				this._txt_babatcheck = value;
				flag = (this._txt_babatcheck != null);
				if (flag)
				{
					this._txt_babatcheck.Validated += value2;
					this._txt_babatcheck.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00100E80 File Offset: 0x000FF080
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00006F8C File Offset: 0x0000518C
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

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00100E98 File Offset: 0x000FF098
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00006F96 File Offset: 0x00005196
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

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00100EB0 File Offset: 0x000FF0B0
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x00100EC8 File Offset: 0x000FF0C8
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
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_fishbabat != null;
				if (flag)
				{
					this._txt_fishbabat.Validated -= value2;
					this._txt_fishbabat.KeyDown -= value3;
				}
				this._txt_fishbabat = value;
				flag = (this._txt_fishbabat != null);
				if (flag)
				{
					this._txt_fishbabat.Validated += value2;
					this._txt_fishbabat.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00100F50 File Offset: 0x000FF150
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x00100F68 File Offset: 0x000FF168
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00100FC8 File Offset: 0x000FF1C8
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x00006FA0 File Offset: 0x000051A0
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00100FE0 File Offset: 0x000FF1E0
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00100FF8 File Offset: 0x000FF1F8
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
				EndCustomEditEventHandler value2 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX2_KeyDown);
				InitCustomEditEventHandler value4 = new InitCustomEditEventHandler(this.gridex2_InitCustomEdit);
				EventHandler value5 = new EventHandler(this.gridex2_GotFocus);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.gridex2_ColumnButtonClick);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX2_CellEdited);
				EventHandler value8 = new EventHandler(this.gridex2_SelectionChanged);
				EventHandler value9 = new EventHandler(this.gridex2_RecordAdded);
				bool flag = this._gridex2 != null;
				if (flag)
				{
					this._gridex2.EndCustomEdit -= value2;
					this._gridex2.KeyDown -= value3;
					this._gridex2.InitCustomEdit -= value4;
					this._gridex2.GotFocus -= value5;
					this._gridex2.ColumnButtonClick -= value6;
					this._gridex2.CellEdited -= value7;
					this._gridex2.SelectionChanged -= value8;
					this._gridex2.RecordAdded -= value9;
				}
				this._gridex2 = value;
				flag = (this._gridex2 != null);
				if (flag)
				{
					this._gridex2.EndCustomEdit += value2;
					this._gridex2.KeyDown += value3;
					this._gridex2.InitCustomEdit += value4;
					this._gridex2.GotFocus += value5;
					this._gridex2.ColumnButtonClick += value6;
					this._gridex2.CellEdited += value7;
					this._gridex2.SelectionChanged += value8;
					this._gridex2.RecordAdded += value9;
				}
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00101180 File Offset: 0x000FF380
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00006FAA File Offset: 0x000051AA
		internal virtual UIGroupBox Group_DnaghdCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_DnaghdCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_DnaghdCheck = value;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00101198 File Offset: 0x000FF398
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x00006FB4 File Offset: 0x000051B4
		internal virtual CurrencyBox CurrencyBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CurrencyBox1 = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x001011B0 File Offset: 0x000FF3B0
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x00006FBE File Offset: 0x000051BE
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x001011C8 File Offset: 0x000FF3C8
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x001011E0 File Offset: 0x000FF3E0
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

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00101240 File Offset: 0x000FF440
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x00101258 File Offset: 0x000FF458
		internal virtual EditBox txt_dbabatnc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_dbabatnc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_dbabatnc != null;
				if (flag)
				{
					this._txt_dbabatnc.Validated -= value2;
					this._txt_dbabatnc.KeyDown -= value3;
				}
				this._txt_dbabatnc = value;
				flag = (this._txt_dbabatnc != null);
				if (flag)
				{
					this._txt_dbabatnc.Validated += value2;
					this._txt_dbabatnc.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x001012E0 File Offset: 0x000FF4E0
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x00006FC8 File Offset: 0x000051C8
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x001012F8 File Offset: 0x000FF4F8
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00006FD2 File Offset: 0x000051D2
		internal virtual UIGroupBox Group_Letf
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Letf;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Letf = value;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00101310 File Offset: 0x000FF510
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x00006FDC File Offset: 0x000051DC
		internal virtual UIGroupBox Group_Right
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Right;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Right = value;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00101328 File Offset: 0x000FF528
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x00006FE6 File Offset: 0x000051E6
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

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00101340 File Offset: 0x000FF540
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00006FF0 File Offset: 0x000051F0
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

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00101358 File Offset: 0x000FF558
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00101370 File Offset: 0x000FF570
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

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x001013D0 File Offset: 0x000FF5D0
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x001013E8 File Offset: 0x000FF5E8
		internal virtual CurrencyBox txt_mablaghpardakht
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablaghpardakht;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_mablaghpardakht_KeyDown);
				bool flag = this._txt_mablaghpardakht != null;
				if (flag)
				{
					this._txt_mablaghpardakht.KeyDown -= value2;
				}
				this._txt_mablaghpardakht = value;
				flag = (this._txt_mablaghpardakht != null);
				if (flag)
				{
					this._txt_mablaghpardakht.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x00101448 File Offset: 0x000FF648
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x00006FFA File Offset: 0x000051FA
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

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00101460 File Offset: 0x000FF660
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x00101478 File Offset: 0x000FF678
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x001014D8 File Offset: 0x000FF6D8
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x00007004 File Offset: 0x00005204
		internal virtual UIGroupBox Group_VarizCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_VarizCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_VarizCheck = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x001014F0 File Offset: 0x000FF6F0
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x00101508 File Offset: 0x000FF708
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

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x00101568 File Offset: 0x000FF768
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00101580 File Offset: 0x000FF780
		internal virtual EditBox txt_babatvariz
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babatvariz;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babatvariz != null;
				if (flag)
				{
					this._txt_babatvariz.Validated -= value2;
					this._txt_babatvariz.KeyDown -= value3;
				}
				this._txt_babatvariz = value;
				flag = (this._txt_babatvariz != null);
				if (flag)
				{
					this._txt_babatvariz.Validated += value2;
					this._txt_babatvariz.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00101608 File Offset: 0x000FF808
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0000700E File Offset: 0x0000520E
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

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00101620 File Offset: 0x000FF820
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x00101638 File Offset: 0x000FF838
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00101698 File Offset: 0x000FF898
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x00007018 File Offset: 0x00005218
		internal virtual MetroStatusBar Metro_Right
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Metro_Right;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Metro_Right = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x001016B0 File Offset: 0x000FF8B0
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x00007022 File Offset: 0x00005222
		internal virtual LabelItem LabelItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem1 = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x001016C8 File Offset: 0x000FF8C8
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0000702C File Offset: 0x0000522C
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

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x001016E0 File Offset: 0x000FF8E0
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00007036 File Offset: 0x00005236
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

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x001016F8 File Offset: 0x000FF8F8
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00101710 File Offset: 0x000FF910
		internal virtual ButtonItem ButtonItem10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem10_Click);
				bool flag = this._ButtonItem10 != null;
				if (flag)
				{
					this._ButtonItem10.Click -= value2;
				}
				this._ButtonItem10 = value;
				flag = (this._ButtonItem10 != null);
				if (flag)
				{
					this._ButtonItem10.Click += value2;
				}
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00101770 File Offset: 0x000FF970
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00007040 File Offset: 0x00005240
		internal virtual LabelItem lbl_daryafti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_daryafti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_daryafti = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00101788 File Offset: 0x000FF988
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000704A File Offset: 0x0000524A
		internal virtual LabelItem LabelItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem4 = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x001017A0 File Offset: 0x000FF9A0
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00007054 File Offset: 0x00005254
		internal virtual LabelItem lbl_pardakhti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_pardakhti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_pardakhti = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x001017B8 File Offset: 0x000FF9B8
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0000705E File Offset: 0x0000525E
		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x001017D0 File Offset: 0x000FF9D0
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00007068 File Offset: 0x00005268
		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x001017E8 File Offset: 0x000FF9E8
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00007072 File Offset: 0x00005272
		internal virtual UIGroupBox Group_NaghdCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_NaghdCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_NaghdCheck = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00101800 File Offset: 0x000FFA00
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00101818 File Offset: 0x000FFA18
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

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00101878 File Offset: 0x000FFA78
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000707C File Offset: 0x0000527C
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

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00101890 File Offset: 0x000FFA90
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00007086 File Offset: 0x00005286
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

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x001018A8 File Offset: 0x000FFAA8
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x00007090 File Offset: 0x00005290
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

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x001018C0 File Offset: 0x000FFAC0
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000709A File Offset: 0x0000529A
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

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x001018D8 File Offset: 0x000FFAD8
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x000070A4 File Offset: 0x000052A4
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x001018F0 File Offset: 0x000FFAF0
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x000070AE File Offset: 0x000052AE
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00101908 File Offset: 0x000FFB08
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x000070B8 File Offset: 0x000052B8
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00101920 File Offset: 0x000FFB20
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x000070C2 File Offset: 0x000052C2
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

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00101938 File Offset: 0x000FFB38
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x000070CC File Offset: 0x000052CC
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

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00101950 File Offset: 0x000FFB50
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00101968 File Offset: 0x000FFB68
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x001019C8 File Offset: 0x000FFBC8
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x000070D6 File Offset: 0x000052D6
		internal virtual UIGroupBox GroupKartkhan
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupKartkhan;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupKartkhan = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x001019E0 File Offset: 0x000FFBE0
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x000070E0 File Offset: 0x000052E0
		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x001019F8 File Offset: 0x000FFBF8
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00101A10 File Offset: 0x000FFC10
		internal virtual EditBox txt_shtarakonesh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shtarakonesh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_shtarakonesh != null;
				if (flag)
				{
					this._txt_shtarakonesh.Validated -= value2;
					this._txt_shtarakonesh.KeyDown -= value3;
				}
				this._txt_shtarakonesh = value;
				flag = (this._txt_shtarakonesh != null);
				if (flag)
				{
					this._txt_shtarakonesh.Validated += value2;
					this._txt_shtarakonesh.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00101A98 File Offset: 0x000FFC98
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00101AB0 File Offset: 0x000FFCB0
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00101B10 File Offset: 0x000FFD10
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x000070EA File Offset: 0x000052EA
		internal virtual UIGroupBox Group_BankVajh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_BankVajh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_BankVajh = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00101B28 File Offset: 0x000FFD28
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00101B40 File Offset: 0x000FFD40
		internal virtual EditBox txt_vajhbank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_vajhbank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_vajhbank != null;
				if (flag)
				{
					this._txt_vajhbank.Validated -= value2;
					this._txt_vajhbank.KeyDown -= value3;
				}
				this._txt_vajhbank = value;
				flag = (this._txt_vajhbank != null);
				if (flag)
				{
					this._txt_vajhbank.Validated += value2;
					this._txt_vajhbank.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00101BC8 File Offset: 0x000FFDC8
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x000070F4 File Offset: 0x000052F4
		internal virtual Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x00101BE0 File Offset: 0x000FFDE0
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x00101BF8 File Offset: 0x000FFDF8
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00101C58 File Offset: 0x000FFE58
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x00101C70 File Offset: 0x000FFE70
		internal virtual UIButton UiButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton5_Click);
				bool flag = this._UiButton5 != null;
				if (flag)
				{
					this._UiButton5.Click -= value2;
				}
				this._UiButton5 = value;
				flag = (this._UiButton5 != null);
				if (flag)
				{
					this._UiButton5.Click += value2;
				}
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00101CD0 File Offset: 0x000FFED0
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x00101CE8 File Offset: 0x000FFEE8
		internal virtual SelectItem txt_moshtariHesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtariHesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_moshtariHesab_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtariHesab_SelectedValueChanged);
				EventHandler value2 = new EventHandler(this.txt_moshtariHesab_GotFocus);
				bool flag = this._txt_moshtariHesab != null;
				if (flag)
				{
					this._txt_moshtariHesab.ValueDeleted -= obj;
					this._txt_moshtariHesab.SelectedValueChanged -= obj2;
					this._txt_moshtariHesab.GotFocus -= value2;
				}
				this._txt_moshtariHesab = value;
				flag = (this._txt_moshtariHesab != null);
				if (flag)
				{
					this._txt_moshtariHesab.ValueDeleted += obj;
					this._txt_moshtariHesab.SelectedValueChanged += obj2;
					this._txt_moshtariHesab.GotFocus += value2;
				}
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00101D98 File Offset: 0x000FFF98
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x000070FE File Offset: 0x000052FE
		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x00101DB0 File Offset: 0x000FFFB0
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x00101DC8 File Offset: 0x000FFFC8
		internal virtual UIButton UiButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton6_Click);
				bool flag = this._UiButton6 != null;
				if (flag)
				{
					this._UiButton6.Click -= value2;
				}
				this._UiButton6 = value;
				flag = (this._UiButton6 != null);
				if (flag)
				{
					this._UiButton6.Click += value2;
				}
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00101E28 File Offset: 0x00100028
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x00007108 File Offset: 0x00005308
		internal virtual UIGroupBox Group_kart_be_Kart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_kart_be_Kart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_kart_be_Kart = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x00101E40 File Offset: 0x00100040
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x00007112 File Offset: 0x00005312
		internal virtual Label Label27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label27 = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00101E58 File Offset: 0x00100058
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x00101E70 File Offset: 0x00100070
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
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat_kart != null;
				if (flag)
				{
					this._txt_babat_kart.Validated -= value2;
					this._txt_babat_kart.KeyDown -= value3;
				}
				this._txt_babat_kart = value;
				flag = (this._txt_babat_kart != null);
				if (flag)
				{
					this._txt_babat_kart.Validated += value2;
					this._txt_babat_kart.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x00101EF8 File Offset: 0x001000F8
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0000711C File Offset: 0x0000531C
		internal virtual Label Label28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label28 = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x00101F10 File Offset: 0x00100110
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x00101F28 File Offset: 0x00100128
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_kart_bankhesab_KeyDown);
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_kart_bankhesab_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._txt_kart_bankhesab != null;
				if (flag)
				{
					this._txt_kart_bankhesab.KeyDown -= value2;
					this._txt_kart_bankhesab.ValueDeleted -= obj;
					this._txt_kart_bankhesab.SelectedValueChanged -= obj2;
				}
				this._txt_kart_bankhesab = value;
				flag = (this._txt_kart_bankhesab != null);
				if (flag)
				{
					this._txt_kart_bankhesab.KeyDown += value2;
					this._txt_kart_bankhesab.ValueDeleted += obj;
					this._txt_kart_bankhesab.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x00101FD8 File Offset: 0x001001D8
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x00007126 File Offset: 0x00005326
		internal virtual UIGroupBox Group_Bank_Hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Bank_Hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Bank_Hazine = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x00101FF0 File Offset: 0x001001F0
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x00102008 File Offset: 0x00100208
		internal virtual EditBox txt_babat_hazine_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_hazine_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat_hazine_bank != null;
				if (flag)
				{
					this._txt_babat_hazine_bank.Validated -= value2;
					this._txt_babat_hazine_bank.KeyDown -= value3;
				}
				this._txt_babat_hazine_bank = value;
				flag = (this._txt_babat_hazine_bank != null);
				if (flag)
				{
					this._txt_babat_hazine_bank.Validated += value2;
					this._txt_babat_hazine_bank.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00102090 File Offset: 0x00100290
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x001020A8 File Offset: 0x001002A8
		internal virtual SelectItem txt_bank_hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank_hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_bank_hazine_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_bank_hazine_SelectedValueChanged);
				bool flag = this._txt_bank_hazine != null;
				if (flag)
				{
					this._txt_bank_hazine.ValueDeleted -= obj;
					this._txt_bank_hazine.SelectedValueChanged -= obj2;
				}
				this._txt_bank_hazine = value;
				flag = (this._txt_bank_hazine != null);
				if (flag)
				{
					this._txt_bank_hazine.ValueDeleted += obj;
					this._txt_bank_hazine.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x00102130 File Offset: 0x00100330
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x00007130 File Offset: 0x00005330
		internal virtual Label Label29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label29 = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x00102148 File Offset: 0x00100348
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x0000713A File Offset: 0x0000533A
		internal virtual Label Label30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x00102160 File Offset: 0x00100360
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x00007144 File Offset: 0x00005344
		internal virtual UIGroupBox Group_Bank_To_Bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Bank_To_Bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Bank_To_Bank = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00102178 File Offset: 0x00100378
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x00102190 File Offset: 0x00100390
		internal virtual SelectItem txt_bank_shcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank_shcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_bank_shcheck_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_bank_shcheck_ButtonClick);
				bool flag = this._txt_bank_shcheck != null;
				if (flag)
				{
					this._txt_bank_shcheck.KeyDown -= value2;
					this._txt_bank_shcheck.ButtonClick -= value3;
				}
				this._txt_bank_shcheck = value;
				flag = (this._txt_bank_shcheck != null);
				if (flag)
				{
					this._txt_bank_shcheck.KeyDown += value2;
					this._txt_bank_shcheck.ButtonClick += value3;
				}
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00102218 File Offset: 0x00100418
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x00102230 File Offset: 0x00100430
		internal virtual SelectItem txt_bank_bankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank_bankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_bank_bankhesab_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_bank_bankhesab_SelectedValueChanged);
				EventHandler value2 = new EventHandler(this.txt_bank_bankhesab_GotFocus);
				bool flag = this._txt_bank_bankhesab != null;
				if (flag)
				{
					this._txt_bank_bankhesab.ValueDeleted -= obj;
					this._txt_bank_bankhesab.SelectedValueChanged -= obj2;
					this._txt_bank_bankhesab.GotFocus -= value2;
				}
				this._txt_bank_bankhesab = value;
				flag = (this._txt_bank_bankhesab != null);
				if (flag)
				{
					this._txt_bank_bankhesab.ValueDeleted += obj;
					this._txt_bank_bankhesab.SelectedValueChanged += obj2;
					this._txt_bank_bankhesab.GotFocus += value2;
				}
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x001022E0 File Offset: 0x001004E0
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0000714E File Offset: 0x0000534E
		internal virtual Label Label32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label32 = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x001022F8 File Offset: 0x001004F8
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00007158 File Offset: 0x00005358
		internal virtual Label Label31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label31 = value;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00102310 File Offset: 0x00100510
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00102328 File Offset: 0x00100528
		internal virtual EditBox txt_bank_babat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank_babat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_bank_babat != null;
				if (flag)
				{
					this._txt_bank_babat.Validated -= value2;
					this._txt_bank_babat.KeyDown -= value3;
				}
				this._txt_bank_babat = value;
				flag = (this._txt_bank_babat != null);
				if (flag)
				{
					this._txt_bank_babat.Validated += value2;
					this._txt_bank_babat.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x001023B0 File Offset: 0x001005B0
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x00007162 File Offset: 0x00005362
		internal virtual Label Label33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label33 = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x001023C8 File Offset: 0x001005C8
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0000716C File Offset: 0x0000536C
		internal virtual UIGroupBox Group_Hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Hazine = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x001023E0 File Offset: 0x001005E0
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x001023F8 File Offset: 0x001005F8
		internal virtual EditBox txt_babat_hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat_hazine != null;
				if (flag)
				{
					this._txt_babat_hazine.Validated -= value2;
					this._txt_babat_hazine.KeyDown -= value3;
				}
				this._txt_babat_hazine = value;
				flag = (this._txt_babat_hazine != null);
				if (flag)
				{
					this._txt_babat_hazine.Validated += value2;
					this._txt_babat_hazine.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00102480 File Offset: 0x00100680
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00007176 File Offset: 0x00005376
		internal virtual Label Label35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label35 = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00102498 File Offset: 0x00100698
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00007180 File Offset: 0x00005380
		internal virtual Label Label34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label34 = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x001024B0 File Offset: 0x001006B0
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x001024C8 File Offset: 0x001006C8
		internal virtual SelectItem txt_hazine_shcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazine_shcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_hazine_shcheck_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_hazine_shcheck_ButtonClick);
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_nahvePardakht_ValueDeleted);
				bool flag = this._txt_hazine_shcheck != null;
				if (flag)
				{
					this._txt_hazine_shcheck.KeyDown -= value2;
					this._txt_hazine_shcheck.ButtonClick -= value3;
					this._txt_hazine_shcheck.ValueDeleted -= obj;
				}
				this._txt_hazine_shcheck = value;
				flag = (this._txt_hazine_shcheck != null);
				if (flag)
				{
					this._txt_hazine_shcheck.KeyDown += value2;
					this._txt_hazine_shcheck.ButtonClick += value3;
					this._txt_hazine_shcheck.ValueDeleted += obj;
				}
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00102578 File Offset: 0x00100778
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x00102590 File Offset: 0x00100790
		internal virtual SelectItem txt_nahvePardakht
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_nahvePardakht;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_nahvePardakht_KeyDown);
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_nahvePardakht_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_nahvePardakht_SelectedValueChanged);
				bool flag = this._txt_nahvePardakht != null;
				if (flag)
				{
					this._txt_nahvePardakht.KeyDown -= value2;
					this._txt_nahvePardakht.ValueDeleted -= obj;
					this._txt_nahvePardakht.SelectedValueChanged -= obj2;
				}
				this._txt_nahvePardakht = value;
				flag = (this._txt_nahvePardakht != null);
				if (flag)
				{
					this._txt_nahvePardakht.KeyDown += value2;
					this._txt_nahvePardakht.ValueDeleted += obj;
					this._txt_nahvePardakht.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00102640 File Offset: 0x00100840
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0000718A File Offset: 0x0000538A
		internal virtual Label Label36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label36 = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x00102658 File Offset: 0x00100858
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x00102670 File Offset: 0x00100870
		internal virtual DateBox2 txt_hazine_sarresid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazine_sarresid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_hazine_sarresid_Validated);
				bool flag = this._txt_hazine_sarresid != null;
				if (flag)
				{
					this._txt_hazine_sarresid.Validated -= value2;
				}
				this._txt_hazine_sarresid = value;
				flag = (this._txt_hazine_sarresid != null);
				if (flag)
				{
					this._txt_hazine_sarresid.Validated += value2;
				}
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x001026D0 File Offset: 0x001008D0
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x00007194 File Offset: 0x00005394
		internal virtual Label Label37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label37 = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x001026E8 File Offset: 0x001008E8
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0000719E File Offset: 0x0000539E
		internal virtual UIGroupBox Group_barzamin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_barzamin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_barzamin = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00102700 File Offset: 0x00100900
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x00102718 File Offset: 0x00100918
		internal virtual NumericBox txt_vazn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_vazn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_jens_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_vazn != null;
				if (flag)
				{
					this._txt_vazn.Validated -= value2;
					this._txt_vazn.KeyDown -= value3;
				}
				this._txt_vazn = value;
				flag = (this._txt_vazn != null);
				if (flag)
				{
					this._txt_vazn.Validated += value2;
					this._txt_vazn.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x001027A0 File Offset: 0x001009A0
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x001027B8 File Offset: 0x001009B8
		internal virtual NumericBox txt_tedad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tedad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_jens_Validated);
				bool flag = this._txt_tedad != null;
				if (flag)
				{
					this._txt_tedad.Validated -= value2;
				}
				this._txt_tedad = value;
				flag = (this._txt_tedad != null);
				if (flag)
				{
					this._txt_tedad.Validated += value2;
				}
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x00102818 File Offset: 0x00100A18
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x00102830 File Offset: 0x00100A30
		internal virtual SelectItem txt_jens
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jens;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_jens_Validated);
				bool flag = this._txt_jens != null;
				if (flag)
				{
					this._txt_jens.Validated -= value2;
				}
				this._txt_jens = value;
				flag = (this._txt_jens != null);
				if (flag)
				{
					this._txt_jens.Validated += value2;
				}
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00102890 File Offset: 0x00100A90
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x000071A8 File Offset: 0x000053A8
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

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x001028A8 File Offset: 0x00100AA8
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x000071B2 File Offset: 0x000053B2
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

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x001028C0 File Offset: 0x00100AC0
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x000071BC File Offset: 0x000053BC
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

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x001028D8 File Offset: 0x00100AD8
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x001028F0 File Offset: 0x00100AF0
		internal virtual EditBox txt_search2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_search2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_search2_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_search2_ButtonClick);
				bool flag = this._txt_search2 != null;
				if (flag)
				{
					this._txt_search2.KeyDown -= value2;
					this._txt_search2.ButtonClick -= value3;
				}
				this._txt_search2 = value;
				flag = (this._txt_search2 != null);
				if (flag)
				{
					this._txt_search2.KeyDown += value2;
					this._txt_search2.ButtonClick += value3;
				}
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00102978 File Offset: 0x00100B78
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x00102990 File Offset: 0x00100B90
		internal virtual EditBox txt_search1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_search1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_search1_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_search1_ButtonClick);
				bool flag = this._txt_search1 != null;
				if (flag)
				{
					this._txt_search1.KeyDown -= value2;
					this._txt_search1.ButtonClick -= value3;
				}
				this._txt_search1 = value;
				flag = (this._txt_search1 != null);
				if (flag)
				{
					this._txt_search1.KeyDown += value2;
					this._txt_search1.ButtonClick += value3;
				}
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00102A18 File Offset: 0x00100C18
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x00102A30 File Offset: 0x00100C30
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
				EventHandler value2 = new EventHandler(this.ButtonItem4_Click_1);
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

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00102A90 File Offset: 0x00100C90
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x00102AA8 File Offset: 0x00100CA8
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
				EventHandler value2 = new EventHandler(this.ButtonItem5_Click_1);
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00102B08 File Offset: 0x00100D08
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x000071C6 File Offset: 0x000053C6
		internal virtual UIGroupBox Group_Gest
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Gest;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Gest = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00102B20 File Offset: 0x00100D20
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x00102B38 File Offset: 0x00100D38
		internal virtual SelectItem txt_nahvepardakht_agsat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_nahvepardakht_agsat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_nahvepardakht_agsat_SelectedValueChanged);
				bool flag = this._txt_nahvepardakht_agsat != null;
				if (flag)
				{
					this._txt_nahvepardakht_agsat.SelectedValueChanged -= obj;
				}
				this._txt_nahvepardakht_agsat = value;
				flag = (this._txt_nahvepardakht_agsat != null);
				if (flag)
				{
					this._txt_nahvepardakht_agsat.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00102B98 File Offset: 0x00100D98
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00102BB0 File Offset: 0x00100DB0
		internal virtual EditBox txt_babat_agsat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_agsat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat_agsat != null;
				if (flag)
				{
					this._txt_babat_agsat.Validated -= value2;
					this._txt_babat_agsat.KeyDown -= value3;
				}
				this._txt_babat_agsat = value;
				flag = (this._txt_babat_agsat != null);
				if (flag)
				{
					this._txt_babat_agsat.Validated += value2;
					this._txt_babat_agsat.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00102C38 File Offset: 0x00100E38
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x000071D0 File Offset: 0x000053D0
		internal virtual Label Label38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label38 = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00102C50 File Offset: 0x00100E50
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x000071DA File Offset: 0x000053DA
		internal virtual Label Label39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label39 = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00102C68 File Offset: 0x00100E68
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x000071E4 File Offset: 0x000053E4
		internal virtual UIGroupBox Group_PardakhtTankhah
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_PardakhtTankhah;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_PardakhtTankhah = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00102C80 File Offset: 0x00100E80
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x00102C98 File Offset: 0x00100E98
		internal virtual SelectItem txt_nahvePardakhtTankhah
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_nahvePardakhtTankhah;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_nahvedaryafttankhah_KeyDown);
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_nahvedaryafttankhah_SelectedValueChanged);
				bool flag = this._txt_nahvePardakhtTankhah != null;
				if (flag)
				{
					this._txt_nahvePardakhtTankhah.KeyDown -= value2;
					this._txt_nahvePardakhtTankhah.SelectedValueChanged -= obj;
				}
				this._txt_nahvePardakhtTankhah = value;
				flag = (this._txt_nahvePardakhtTankhah != null);
				if (flag)
				{
					this._txt_nahvePardakhtTankhah.KeyDown += value2;
					this._txt_nahvePardakhtTankhah.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00102D20 File Offset: 0x00100F20
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x000071EE File Offset: 0x000053EE
		internal virtual Label Label40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label40 = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00102D38 File Offset: 0x00100F38
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x000071F8 File Offset: 0x000053F8
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

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00102D50 File Offset: 0x00100F50
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x00007202 File Offset: 0x00005402
		internal virtual Label Label26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label26 = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00102D68 File Offset: 0x00100F68
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x00102D80 File Offset: 0x00100F80
		internal virtual EditBox txt_babattankhah
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babattankhah;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babattankhah != null;
				if (flag)
				{
					this._txt_babattankhah.Validated -= value2;
					this._txt_babattankhah.KeyDown -= value3;
				}
				this._txt_babattankhah = value;
				flag = (this._txt_babattankhah != null);
				if (flag)
				{
					this._txt_babattankhah.Validated += value2;
					this._txt_babattankhah.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00102E08 File Offset: 0x00101008
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x00102E20 File Offset: 0x00101020
		internal virtual SelectItem txt_tankhah_hesabbanki
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tankhah_hesabbanki;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_tankhah_hesabbanki_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_tankhah_hesabbanki_SelectedValueChanged);
				bool flag = this._txt_tankhah_hesabbanki != null;
				if (flag)
				{
					this._txt_tankhah_hesabbanki.ValueDeleted -= obj;
					this._txt_tankhah_hesabbanki.SelectedValueChanged -= obj2;
				}
				this._txt_tankhah_hesabbanki = value;
				flag = (this._txt_tankhah_hesabbanki != null);
				if (flag)
				{
					this._txt_tankhah_hesabbanki.ValueDeleted += obj;
					this._txt_tankhah_hesabbanki.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00102EA8 File Offset: 0x001010A8
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000720C File Offset: 0x0000540C
		internal virtual Label Label41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label41 = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00102EC0 File Offset: 0x001010C0
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x00102ED8 File Offset: 0x001010D8
		internal virtual SelectItem txt_hazine_kartbekart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazine_kartbekart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_hazine_kartbekart_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_hazine_kartbekart_SelectedValueChanged);
				KeyEventHandler value2 = new KeyEventHandler(this.txt_hazine_kartbekart_KeyDown);
				bool flag = this._txt_hazine_kartbekart != null;
				if (flag)
				{
					this._txt_hazine_kartbekart.ValueDeleted -= obj;
					this._txt_hazine_kartbekart.SelectedValueChanged -= obj2;
					this._txt_hazine_kartbekart.KeyDown -= value2;
				}
				this._txt_hazine_kartbekart = value;
				flag = (this._txt_hazine_kartbekart != null);
				if (flag)
				{
					this._txt_hazine_kartbekart.ValueDeleted += obj;
					this._txt_hazine_kartbekart.SelectedValueChanged += obj2;
					this._txt_hazine_kartbekart.KeyDown += value2;
				}
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x00102F88 File Offset: 0x00101188
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00102FA0 File Offset: 0x001011A0
		internal virtual SelectItem txt_hazinetankhah
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazinetankhah;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_hazine_kartbekart_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_hazine_kartbekart_SelectedValueChanged);
				KeyEventHandler value2 = new KeyEventHandler(this.txt_hazine_kartbekart_KeyDown);
				bool flag = this._txt_hazinetankhah != null;
				if (flag)
				{
					this._txt_hazinetankhah.ValueDeleted -= obj;
					this._txt_hazinetankhah.SelectedValueChanged -= obj2;
					this._txt_hazinetankhah.KeyDown -= value2;
				}
				this._txt_hazinetankhah = value;
				flag = (this._txt_hazinetankhah != null);
				if (flag)
				{
					this._txt_hazinetankhah.ValueDeleted += obj;
					this._txt_hazinetankhah.SelectedValueChanged += obj2;
					this._txt_hazinetankhah.KeyDown += value2;
				}
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00103050 File Offset: 0x00101250
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x00007216 File Offset: 0x00005416
		internal virtual Label Label42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label42 = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00103068 File Offset: 0x00101268
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x00007220 File Offset: 0x00005420
		internal virtual UIGroupBox group_moshtari_be_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_moshtari_be_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_moshtari_be_moshtari = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00103080 File Offset: 0x00101280
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x00103098 File Offset: 0x00101298
		internal virtual SelectItem txt_be_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_be_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_be_moshtari_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_be_moshtari_SelectedValueChanged);
				bool flag = this._txt_be_moshtari != null;
				if (flag)
				{
					this._txt_be_moshtari.ValueDeleted -= obj;
					this._txt_be_moshtari.SelectedValueChanged -= obj2;
				}
				this._txt_be_moshtari = value;
				flag = (this._txt_be_moshtari != null);
				if (flag)
				{
					this._txt_be_moshtari.ValueDeleted += obj;
					this._txt_be_moshtari.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00103120 File Offset: 0x00101320
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00103138 File Offset: 0x00101338
		internal virtual EditBox txt_babat_moshtari_be_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_moshtari_be_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat_moshtari_be_moshtari != null;
				if (flag)
				{
					this._txt_babat_moshtari_be_moshtari.Validated -= value2;
					this._txt_babat_moshtari_be_moshtari.KeyDown -= value3;
				}
				this._txt_babat_moshtari_be_moshtari = value;
				flag = (this._txt_babat_moshtari_be_moshtari != null);
				if (flag)
				{
					this._txt_babat_moshtari_be_moshtari.Validated += value2;
					this._txt_babat_moshtari_be_moshtari.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x001031C0 File Offset: 0x001013C0
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0000722A File Offset: 0x0000542A
		internal virtual Label Label43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label43 = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x001031D8 File Offset: 0x001013D8
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00007234 File Offset: 0x00005434
		internal virtual Label Label44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label44 = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x001031F0 File Offset: 0x001013F0
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000723E File Offset: 0x0000543E
		internal virtual UIGroupBox group_bank_be_sandugh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_bank_be_sandugh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_bank_be_sandugh = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00103208 File Offset: 0x00101408
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00103220 File Offset: 0x00101420
		internal virtual SelectItem txt_bs_shCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bs_shCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_bs_shCheck_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_bs_shCheck_ButtonClick);
				bool flag = this._txt_bs_shCheck != null;
				if (flag)
				{
					this._txt_bs_shCheck.KeyDown -= value2;
					this._txt_bs_shCheck.ButtonClick -= value3;
				}
				this._txt_bs_shCheck = value;
				flag = (this._txt_bs_shCheck != null);
				if (flag)
				{
					this._txt_bs_shCheck.KeyDown += value2;
					this._txt_bs_shCheck.ButtonClick += value3;
				}
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x001032A8 File Offset: 0x001014A8
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00007248 File Offset: 0x00005448
		internal virtual Label Label46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label46 = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x001032C0 File Offset: 0x001014C0
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00007252 File Offset: 0x00005452
		internal virtual Label Label45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label45 = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x001032D8 File Offset: 0x001014D8
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x001032F0 File Offset: 0x001014F0
		internal virtual EditBox txt_bs_babat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bs_babat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_bs_babat != null;
				if (flag)
				{
					this._txt_bs_babat.Validated -= value2;
					this._txt_bs_babat.KeyDown -= value3;
				}
				this._txt_bs_babat = value;
				flag = (this._txt_bs_babat != null);
				if (flag)
				{
					this._txt_bs_babat.Validated += value2;
					this._txt_bs_babat.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00103378 File Offset: 0x00101578
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00103390 File Offset: 0x00101590
		internal virtual SelectItem txt_bankhesab_gest
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bankhesab_gest;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_bankhesab_gest_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_bankhesab_gest_SelectedValueChanged);
				bool flag = this._txt_bankhesab_gest != null;
				if (flag)
				{
					this._txt_bankhesab_gest.ValueDeleted -= obj;
					this._txt_bankhesab_gest.SelectedValueChanged -= obj2;
				}
				this._txt_bankhesab_gest = value;
				flag = (this._txt_bankhesab_gest != null);
				if (flag)
				{
					this._txt_bankhesab_gest.ValueDeleted += obj;
					this._txt_bankhesab_gest.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00103418 File Offset: 0x00101618
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000725C File Offset: 0x0000545C
		internal virtual Label Label47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label47 = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00103430 File Offset: 0x00101630
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00007266 File Offset: 0x00005466
		internal virtual UIGroupBox Group_checkNaghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_checkNaghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_checkNaghd = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00103448 File Offset: 0x00101648
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00103460 File Offset: 0x00101660
		internal virtual UIButton UiButton7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton7_Click);
				bool flag = this._UiButton7 != null;
				if (flag)
				{
					this._UiButton7.Click -= value2;
				}
				this._UiButton7 = value;
				flag = (this._UiButton7 != null);
				if (flag)
				{
					this._UiButton7.Click += value2;
				}
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x001034C0 File Offset: 0x001016C0
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x001034D8 File Offset: 0x001016D8
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
				EventHandler value2 = new EventHandler(this.ButtonItem8_Click_1);
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x00103538 File Offset: 0x00101738
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x00007270 File Offset: 0x00005470
		internal virtual UIGroupBox group_havale_arzi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_havale_arzi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_havale_arzi = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x00103550 File Offset: 0x00101750
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0000727A File Offset: 0x0000547A
		internal virtual Label Label48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label48 = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00103568 File Offset: 0x00101768
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x00103580 File Offset: 0x00101780
		internal virtual EditBox txt_havale_babat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_havale_babat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_havale_babat != null;
				if (flag)
				{
					this._txt_havale_babat.Validated -= value2;
					this._txt_havale_babat.KeyDown -= value3;
				}
				this._txt_havale_babat = value;
				flag = (this._txt_havale_babat != null);
				if (flag)
				{
					this._txt_havale_babat.Validated += value2;
					this._txt_havale_babat.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00103608 File Offset: 0x00101808
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00103620 File Offset: 0x00101820
		internal virtual SelectItem txt_havale_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_havale_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_havale_bank_Validated);
				bool flag = this._txt_havale_bank != null;
				if (flag)
				{
					this._txt_havale_bank.Validated -= value2;
				}
				this._txt_havale_bank = value;
				flag = (this._txt_havale_bank != null);
				if (flag)
				{
					this._txt_havale_bank.Validated += value2;
				}
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00103680 File Offset: 0x00101880
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x00007284 File Offset: 0x00005484
		internal virtual Label Label49
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label49;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label49 = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00103698 File Offset: 0x00101898
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x001036B0 File Offset: 0x001018B0
		internal virtual CurrencyBox txt_fee_dolar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fee_dolar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_fee_dolar_Validated);
				bool flag = this._txt_fee_dolar != null;
				if (flag)
				{
					this._txt_fee_dolar.Validated -= value2;
				}
				this._txt_fee_dolar = value;
				flag = (this._txt_fee_dolar != null);
				if (flag)
				{
					this._txt_fee_dolar.Validated += value2;
				}
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00103710 File Offset: 0x00101910
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000728E File Offset: 0x0000548E
		internal virtual Label Label50
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label50;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label50 = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00103728 File Offset: 0x00101928
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00007298 File Offset: 0x00005498
		internal virtual UIGroupBox group_phavale_arzi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_phavale_arzi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_phavale_arzi = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00103740 File Offset: 0x00101940
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x00103758 File Offset: 0x00101958
		internal virtual CurrencyBox txt_pfee_dolar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pfee_dolar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_pfee_dolar_Validated);
				bool flag = this._txt_pfee_dolar != null;
				if (flag)
				{
					this._txt_pfee_dolar.Validated -= value2;
				}
				this._txt_pfee_dolar = value;
				flag = (this._txt_pfee_dolar != null);
				if (flag)
				{
					this._txt_pfee_dolar.Validated += value2;
				}
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x001037B8 File Offset: 0x001019B8
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x000072A2 File Offset: 0x000054A2
		internal virtual Label Label51
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label51;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label51 = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x001037D0 File Offset: 0x001019D0
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x001037E8 File Offset: 0x001019E8
		internal virtual EditBox txt_phavale_babat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_phavale_babat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_phavale_babat != null;
				if (flag)
				{
					this._txt_phavale_babat.Validated -= value2;
					this._txt_phavale_babat.KeyDown -= value3;
				}
				this._txt_phavale_babat = value;
				flag = (this._txt_phavale_babat != null);
				if (flag)
				{
					this._txt_phavale_babat.Validated += value2;
					this._txt_phavale_babat.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00103870 File Offset: 0x00101A70
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00103888 File Offset: 0x00101A88
		internal virtual SelectItem txt_phavale_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_phavale_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_phavale_bank_Validated);
				bool flag = this._txt_phavale_bank != null;
				if (flag)
				{
					this._txt_phavale_bank.Validated -= value2;
				}
				this._txt_phavale_bank = value;
				flag = (this._txt_phavale_bank != null);
				if (flag)
				{
					this._txt_phavale_bank.Validated += value2;
				}
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x001038E8 File Offset: 0x00101AE8
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x000072AC File Offset: 0x000054AC
		internal virtual Label Label53
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label53;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label53 = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00103900 File Offset: 0x00101B00
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x000072B6 File Offset: 0x000054B6
		internal virtual Label Label54
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label54;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label54 = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00103918 File Offset: 0x00101B18
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00103930 File Offset: 0x00101B30
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00103990 File Offset: 0x00101B90
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x000072C0 File Offset: 0x000054C0
		internal virtual UIGroupBox Group_Takhfif
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Takhfif;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Group_Takhfif = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x001039A8 File Offset: 0x00101BA8
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x000072CA File Offset: 0x000054CA
		internal virtual Label Label52
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label52;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label52 = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x001039C0 File Offset: 0x00101BC0
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x001039D8 File Offset: 0x00101BD8
		internal virtual EditBox txt_babat_takhfif
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_takhfif;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_babat_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_babat_KeyDown);
				bool flag = this._txt_babat_takhfif != null;
				if (flag)
				{
					this._txt_babat_takhfif.Validated -= value2;
					this._txt_babat_takhfif.KeyDown -= value3;
				}
				this._txt_babat_takhfif = value;
				flag = (this._txt_babat_takhfif != null);
				if (flag)
				{
					this._txt_babat_takhfif.Validated += value2;
					this._txt_babat_takhfif.KeyDown += value3;
				}
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00103A60 File Offset: 0x00101C60
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x000072D4 File Offset: 0x000054D4
		public bool ShowPreview
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShowPreview;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ShowPreview = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00103A78 File Offset: 0x00101C78
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x000072DE File Offset: 0x000054DE
		public string PreviewTarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PreviewTarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._PreviewTarikh = value;
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00103A90 File Offset: 0x00101C90
		public void RefreshVusul(DataTable dt)
		{
			bool flag = this.gridex2.DataSource == null;
			checked
			{
				if (!flag)
				{
					flag = Operators.ConditionalCompareObjectNotEqual(dt.Rows[0]["tarikh_Fa"], this.txt_tarikh.Text, false);
					if (!flag)
					{
						DataTable dataTable = (DataTable)this.gridex2.DataSource;
						dataTable.ImportRow(dt.Rows[0]);
						dataTable.ImportRow(dt.Rows[1]);
						dataTable.Rows[dataTable.Rows.Count - 2]["identity"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[dataTable.Rows.Count - 2]["id"]);
						dataTable.Rows[dataTable.Rows.Count - 1]["parent_identity"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[dataTable.Rows.Count - 2]["identity"]);
					}
				}
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00103BB8 File Offset: 0x00101DB8
		public void RefreshVusulDaryaft(DataTable dt)
		{
			bool flag = this.GridEX1.DataSource == null;
			checked
			{
				if (!flag)
				{
					flag = Operators.ConditionalCompareObjectNotEqual(dt.Rows[0]["tarikh_Fa"], this.txt_tarikh.Text, false);
					if (!flag)
					{
						DataTable dataTable = (DataTable)this.GridEX1.DataSource;
						dataTable.ImportRow(dt.Rows[0]);
						dataTable.ImportRow(dt.Rows[1]);
						dataTable.Rows[dataTable.Rows.Count - 2]["identity"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[dataTable.Rows.Count - 2]["id"]);
						dataTable.Rows[dataTable.Rows.Count - 1]["parent_identity"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[dataTable.Rows.Count - 2]["identity"]);
					}
				}
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00103CE0 File Offset: 0x00101EE0
		private void LoadToSearchdt(DataTable dt, DataTable dt_search)
		{
			dt_search.Clear();
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["dptype_id"] != DBNull.Value;
					if (flag)
					{
						bool flag2 = Conversions.ToBoolean(Operators.OrObject((Conversions.ToBoolean(Operators.CompareObjectEqual(dataRow["dptype_id"], 4, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(dataRow["dptype_id"], 13, false))) ? true : false, Operators.CompareObjectEqual(dataRow["dptype_id"], 32, false)));
						if (flag2)
						{
							bool flag3 = dt_search.Columns.Contains("ID");
							if (flag3)
							{
								dt_search.Rows.Add(new object[]
								{
									RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]),
									RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"])
								});
							}
							else
							{
								dt_search.Rows.Add(new object[]
								{
									RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"])
								});
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

		// Token: 0x06001805 RID: 6149 RVA: 0x00103E74 File Offset: 0x00102074
		private void GetDataDaryaft()
		{
			DataTable daryaftByDate = this.dp.GetDaryaftByDate(this.txt_tarikh.Text);
			daryaftByDate.Columns.Add("is_child", typeof(bool));
			daryaftByDate.Columns["is_child"].AllowDBNull = true;
			daryaftByDate.Columns.Add("identity", typeof(int));
			daryaftByDate.Columns["identity"].AutoIncrement = true;
			daryaftByDate.Columns.Add("parent_identity", typeof(int));
			bool flag;
			try
			{
				IEnumerator enumerator = daryaftByDate.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["identity"] = RuntimeHelpers.GetObjectValue(dataRow["id"]);
					dataRow["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["parent_id"]);
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
			this.origin_daryaft = daryaftByDate.Copy();
			daryaftByDate.AcceptChanges();
			this.GridEX1.DataSource = daryaftByDate;
			long num = this.Sandug.DaryaftNaghd(this.txt_tarikh.Text);
			flag = (num == 0L);
			if (flag)
			{
				this.lbl_daryafti.Text = Public_Function.ToFarsi(Conversions.ToString(0));
			}
			else
			{
				this.lbl_daryafti.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num)));
			}
			this.LoadToSearchdt(daryaftByDate, this.dt_search1);
			this.Metro_Right.Refresh();
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00104040 File Offset: 0x00102240
		private void dpchenge(GridEX Grid)
		{
			bool flag = Grid.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					flag = (Grid.Row == -1);
					if (!flag)
					{
						DataTable dataTable = (DataTable)Grid.DataSource;
						DataRowView dataRowView = (DataRowView)Grid.CurrentRow.DataRow;
						flag = (dataRowView == null);
						if (!flag)
						{
							int i = dataTable.Rows.IndexOf(dataRowView.Row);
							flag = (i == -1);
							if (!flag)
							{
								flag = (dataRowView["ID"] != DBNull.Value);
								int? num;
								if (flag)
								{
									object expr_A0 = dataRowView["id"];
									int? num2;
									num = ((expr_A0 != null) ? ((int?)expr_A0) : num2);
								}
								i++;
								flag = (i >= dataTable.Rows.Count);
								if (!flag)
								{
									while (i <= dataTable.Rows.Count - 1)
									{
										flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
										if (flag)
										{
											i++;
										}
										else
										{
											flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
											if (flag)
											{
												dataTable.Rows[i].Delete();
												dataTable.AcceptChanges();
											}
											else
											{
												i++;
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

		// Token: 0x06001807 RID: 6151 RVA: 0x001041B8 File Offset: 0x001023B8
		private void dp_select_Daryaft()
		{
			bool flag = this.GridEX1.GetRow().Cells["dptype_Id"].Value != DBNull.Value;
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.GetRow().Cells["dptype_Id"].Value, -1, false);
				if (flag2)
				{
					return;
				}
			}
			flag2 = this.prevent_mablagh;
			checked
			{
				if (flag2)
				{
					this.prevent_mablagh = false;
				}
				else
				{
					this.prevent = true;
					bool flag3 = false;
					flag2 = (this.GridEX1.GetRow().Cells["dptype_Id"].Value != DBNull.Value);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectEqual(this.GridEX1.GetRow().Cells["dptype_Id"].Value, 4, false);
						if (flag)
						{
							flag3 = true;
						}
					}
					DataTable dt = Public_Function.FillData("select id,Code,Name  from dptype where type=1 and visible=1 order by code");
					((ItemCollection)this.frm.items)[0].Name = "code";
					flag2 = (this.frm.ShowDialog(dt, null, "انتخاب نوع دریافت") == DialogResult.OK);
					if (flag2)
					{
						this.group_dcheck.Visible = false;
						this.group_dfish.Visible = false;
						this.group_dnaghd.Visible = false;
						this.Group_DnaghdCheck.Visible = false;
						this.Group_VarizCheck.Visible = false;
						this.group_bank_be_sandugh.Visible = false;
						this.Group_checkNaghd.Visible = false;
						this.group_havale_arzi.Visible = false;
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["dp_Name"].Position);
						if (flag2)
						{
							flag = (Operators.ConditionalCompareObjectNotEqual(this.frm.SelectedRow["ID"], 4, false) && flag3);
							if (flag)
							{
								this.dpchenge(this.GridEX1);
							}
							this.GridEX1.EditMode = EditMode.EditOn;
							this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
							this.GridEX1.GetRow().Cells["dptype_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							object left = this.frm.SelectedRow["ID"];
							flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 8, false))) ? true : false);
							DataEntryGrid gridEX;
							if (flag2)
							{
								this.group_dnaghd.Visible = true;
								this.group_dnaghd.BringToFront();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, 28, false);
								if (flag2)
								{
									this.Group_barzamin.Visible = true;
									this.Group_barzamin.BringToFront();
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left, 2, false);
									if (flag2)
									{
										this.group_dcheck.Visible = true;
										this.group_dcheck.BringToFront();
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(left, 3, false);
										if (flag2)
										{
											this.group_dfish.Visible = true;
											this.group_dfish.BringToFront();
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left, 43, false);
											if (flag2)
											{
												this.group_havale_arzi.Visible = true;
												this.group_havale_arzi.BringToFront();
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left, 4, false);
												if (flag2)
												{
													this.Label25.Visible = false;
													this.txt_moshtariHesab.Visible = false;
													this.UiButton6.Visible = false;
													this.Group_DnaghdCheck.Visible = true;
													this.Group_DnaghdCheck.BringToFront();
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left, 5, false);
													if (flag2)
													{
														this.group_dnaghd.Visible = true;
														this.group_dnaghd.BringToFront();
													}
													else
													{
														flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 6, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 33, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 34, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 36, false))) ? true : false);
														if (flag2)
														{
															this.group_dnaghd.Visible = true;
															this.group_dnaghd.BringToFront();
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left, 25, false);
															if (flag2)
															{
																this.Group_NaghdCheck.Visible = true;
																this.Group_NaghdCheck.BringToFront();
																this.GridEX1.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left, 41, false);
																if (flag2)
																{
																	this.Group_checkNaghd.Visible = true;
																	this.Group_checkNaghd.BringToFront();
																	this.GridEX1.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
																	this.GridEX1.CurrentRow.Cells["Moshtari_Name"].EditType = EditType.NoEdit;
																	this.UiButton7.Focus();
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left, 27, false);
																	if (flag2)
																	{
																		this.GroupKartkhan.Visible = true;
																		this.GroupKartkhan.BringToFront();
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left, 35, false);
																		if (flag2)
																		{
																			this.group_dnaghd.Visible = true;
																			this.group_dnaghd.BringToFront();
																			gridEX = this.GridEX1;
																			gridEX.Col += 2;
																			this.GridEX1.EditMode = EditMode.EditOn;
																			this.GridEX1.GetRow().BeginEdit();
																			((ItemCollection)this.frm.items)[0].Name = "ID";
																			return;
																		}
																		flag2 = Operators.ConditionalCompareObjectEqual(left, 40, false);
																		if (flag2)
																		{
																			this.group_bank_be_sandugh.Visible = true;
																			this.group_bank_be_sandugh.BringToFront();
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
							gridEX = this.GridEX1;
							gridEX.Col++;
							this.GridEX1.EditMode = EditMode.EditOn;
							this.GridEX1.GetRow().BeginEdit();
						}
					}
					((ItemCollection)this.frm.items)[0].Name = "ID";
				}
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x001048C0 File Offset: 0x00102AC0
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow == null;
				if (!flag2)
				{
					flag2 = (this.GridEX1.CurrentRow.Cells["dptype_id"].Value == DBNull.Value);
					if (!flag2)
					{
						flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 4, false);
						if (flag2)
						{
							flag = (this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value == DBNull.Value);
							if (!flag)
							{
								flag2 = (Operators.CompareString(this.GridEX1.CurrentRow.Cells["Mablagh"].Value.ToString(), string.Empty, false) == 0);
								if (!flag2)
								{
									int sum_Check = this.GetSum_Check();
									flag2 = Operators.ConditionalCompareObjectGreater(sum_Check, this.GridEX1.CurrentRow.Cells["Mablagh"].Value, false);
									if (flag2)
									{
										Public_Function.ShowMessage("مبلغ وارد شده کمتر از مبلغ چک ها میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
										this.GridEX1.CurrentRow.CancelEdit();
									}
									else
									{
										this.CurrencyBox1.Text = Conversions.ToString(Operators.SubtractObject(this.GridEX1.CurrentRow.Cells["Mablagh"].Value, sum_Check));
										this.CurrencyBox1_Validating(this.CurrencyBox1, null);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00104A84 File Offset: 0x00102C84
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["dp_name"].Position;
			if (flag)
			{
				this.dp_select_Daryaft();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
				if (flag)
				{
					this.Moshtari_select(this.GridEX1);
				}
			}
			this.prevent = false;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0000205D File Offset: 0x0000025D
		private void GridEX1_EditingCell(object sender, EditingCellEventArgs e)
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00104B0C File Offset: 0x00102D0C
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				bool flag2 = e.EditControl == null;
				if (!flag2)
				{
					flag2 = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (flag2)
					{
						flag = (e.Row.DataRow == null);
						if (!flag)
						{
							e.Row.Cells["Mablagh"].Value = ((CurrencyBox)e.EditControl).Value;
							long? value;
							((CurrencyBox)e.EditControl).Value = value;
						}
					}
				}
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00104BC8 File Offset: 0x00102DC8
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.RowType == RowType.NewRecord & !this.prevent;
			if (flag)
			{
				this.group_dnaghd.Visible = false;
				this.group_dcheck.Visible = false;
				this.group_dfish.Visible = false;
				this.Group_DnaghdCheck.Visible = false;
				this.Group_VarizCheck.Visible = false;
				this.Group_NaghdCheck.Visible = false;
				this.Group_BankVajh.Visible = false;
				this.group_havale_arzi.Visible = false;
			}
			flag = !this.prevent;
			if (flag)
			{
				this.GridEX1_SelectionChanged(null, null);
			}
			this.Group_NaghdCheck.Parent = this.Group_Right;
			this.Group_DnaghdCheck.Parent = this.Group_Right;
			this.group_dnaghd.Parent = this.Group_Right;
			this.group_dcheck.Parent = this.Group_Right;
			this.Group_VarizCheck.Parent = this.Group_Right;
			this.group_dfish.Parent = this.Group_Right;
			this.group_havale_arzi.Parent = this.Group_Right;
			this.gridex1focused = true;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00104D0C File Offset: 0x00102F0C
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_mablagh;
				this.txt_mablagh.Text = e.Value.ToString();
				this.txt_mablagh.SelectAll();
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00104D70 File Offset: 0x00102F70
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.GridEX1.Row == -1;
				if (flag2)
				{
					flag3 = (this.GridEX1.EditTextBox != null);
					if (flag3)
					{
						this.GridEX1.EditTextBox.Text = string.Empty;
					}
				}
				else
				{
					flag3 = (this.GridEX1.Col == 0);
					if (flag3)
					{
						e.SuppressKeyPress = true;
					}
					else
					{
						flag3 = (this.GridEX1.CurrentRow.Cells["dptype_id"].Value != DBNull.Value);
						if (flag3)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 25, false);
							if (flag2)
							{
								this.GridEX1.CurrentRow.Cells["moshtari_id"].Value = DBNull.Value;
								this.GridEX1.CurrentRow.Cells["moshtari_name"].Value = DBNull.Value;
							}
						}
						flag3 = (this.GridEX1.EditTextBox != null);
						if (flag3)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
					}
				}
			}
			Keys keyData = e.KeyData;
			flag3 = (keyData == Keys.Tab);
			checked
			{
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
							this.GridEX1.EditMode = EditMode.EditOn;
							e.SuppressKeyPress = true;
							return;
						}
						flag3 = (this.GridEX1.Row == -1);
						if (flag3)
						{
							this.txt_tarikh.FocusDatePart = 2;
							this.txt_tarikh.Focus();
							this.txt_tarikh.Focus();
							return;
						}
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
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
								this.GridEX1.EditMode = EditMode.EditOn;
								e.SuppressKeyPress = true;
								return;
							}
						}
						else
						{
							flag3 = (keyData == Keys.Left);
							if (flag3)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
								e.SuppressKeyPress = true;
								return;
							}
							flag3 = (keyData == Keys.Right);
							if (flag3)
							{
								bool flag2 = this.GridEX1.Col > 0;
								if (flag2)
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col--;
									this.GridEX1.EditMode = EditMode.EditOn;
									e.SuppressKeyPress = true;
									return;
								}
							}
						}
					}
				}
				flag3 = (e.KeyCode == Keys.Return);
				if (flag3)
				{
					int col = this.GridEX1.Col;
					bool flag2 = col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox == null);
						if (flag)
						{
							return;
						}
						flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
						if (flag3)
						{
							flag2 = (this.GridEX1.CurrentRow.Cells["dp_name"].Value == DBNull.Value);
							if (flag2)
							{
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["dp_name"].Position;
								this.GridEX1.EditMode = EditMode.EditOn;
								return;
							}
							this.Moshtari_select(this.GridEX1);
							this.prevent = false;
						}
						else
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col++;
							this.GridEX1.EditMode = EditMode.EditOn;
						}
					}
					else
					{
						flag3 = (col == this.GridEX1.RootTable.Columns["dp_Name"].Position);
						if (flag3)
						{
							flag2 = (this.GridEX1.EditTextBox == null);
							if (flag2)
							{
								return;
							}
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.dp_select_Daryaft();
								this.GridEX1.EditMode = EditMode.EditOn;
								this.prevent = false;
								flag3 = (this.GridEX1.EditTextBox == null);
								if (flag3)
								{
									return;
								}
								flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag3)
								{
									flag2 = (this.GridEX1.CurrentRow.Cells["dp_name"].Value == DBNull.Value);
									if (flag2)
									{
										this.GridEX1.Col = this.GridEX1.RootTable.Columns["dp_name"].Position;
										this.GridEX1.EditMode = EditMode.EditOn;
										return;
									}
									this.Moshtari_select(this.GridEX1);
									this.prevent = false;
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
									this.GridEX1.EditMode = EditMode.EditOn;
								}
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
						else
						{
							flag3 = (col == this.GridEX1.RootTable.Columns["mablagh"].Position);
							if (!flag3)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
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

		// Token: 0x0600180F RID: 6159 RVA: 0x00105470 File Offset: 0x00103670
		private void AddAutoPardakht()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["no_bed_alert"]);
			checked
			{
				if (!flag)
				{
					flag = (NewLateBinding.LateIndexGet(this.GridEX1.GetRow().DataRow, new object[]
					{
						"ID"
					}, null) == DBNull.Value);
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.GetRow().Cells["dptype_ID"].Value, 4, false);
						if (flag2)
						{
							bool flag3 = this.GridEX1.GetRow().Cells["moshtari_ID"].Value != DBNull.Value;
							if (flag3)
							{
								bool flag4 = this.GridEX1.GetRow().Cells["mablagh"].Value != DBNull.Value;
								if (flag4)
								{
									bool flag5 = Operators.ConditionalCompareObjectGreater(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande, false);
									if (flag5)
									{
										bool flag6 = Operators.CompareString(this.Moshtari_Info.Mande_Name, "بدهکار", false) == 0;
										if (flag6)
										{
											bool flag7 = this.CurrencyBox1.Value.HasValue;
											if (flag7)
											{
												DataTable dataTable = (DataTable)this.gridex2.DataSource;
												DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id is null and dptype_id=13 and moshtari_id=", this.GridEX1.GetRow().Cells["moshtari_id"].Value)));
												flag7 = (array.Length > 0);
												if (flag7)
												{
													long num = this.Moshtari_Info.Mande;
													DataRow[] array2 = array;
													for (int i = 0; i < array2.Length; i++)
													{
														DataRow dataRow = array2[i];
														num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
													}
													flag7 = Operators.ConditionalCompareObjectEqual(Operators.SubtractObject(this.GridEX1.GetRow().Cells["mablagh"].Value, num), 0, false);
													if (flag7)
													{
														return;
													}
													flag7 = Operators.ConditionalCompareObjectGreater(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande, false);
													if (flag7)
													{
														DataRow[] array3 = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("parent_identity=", array[0]["identity"])));
														flag7 = (array3.Length > 0);
														if (flag7)
														{
															flag6 = Operators.ConditionalCompareObjectEqual(array[0]["mablagh"], array3[0]["mablagh"], false);
															if (flag6)
															{
																array[0]["mablagh"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Abs", new object[]
																{
																	Operators.SubtractObject(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande)
																}, null, null, null));
																array3[0]["mablagh"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Abs", new object[]
																{
																	Operators.SubtractObject(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande)
																}, null, null, null));
																return;
															}
														}
													}
												}
												long num2 = 0L;
												long? value = this.CurrencyBox1.Value;
												bool? arg_415_0;
												if (!value.HasValue)
												{
													arg_415_0 = null;
												}
												else
												{
													bool? flag8 = new bool?(value.GetValueOrDefault() > num2);
													arg_415_0 = flag8;
												}
												bool? flag9 = arg_415_0;
												flag7 = flag9.GetValueOrDefault();
												if (flag7)
												{
													flag6 = (Public_Function.ShowMessage("مبلغ دریافتی بیشتر از بدهکاری میباشد" + Environment.NewLine + Environment.NewLine + "آیا مایل به تسویه حساب میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
													if (flag6)
													{
														DataRow dataRow2 = dataTable.NewRow();
														object expr_47C = this.GridEX1.GetRow().Cells["moshtari_ID"].Value;
														int? num4;
														int? num3 = (expr_47C != null) ? ((int?)expr_47C) : num4;
														string value2 = Conversions.ToString(this.GridEX1.GetRow().Cells["moshtari_name"].Value);
														dataRow2["Moshtari_Name"] = value2;
														dataRow2["Moshtari_ID"] = num3;
														dataRow2["Mablagh"] = Operators.SubtractObject(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande);
														dataRow2["dp_name"] = "پرداخت نقد و چک";
														dataRow2["dptype_id"] = 13;
														dataTable.Rows.Add(dataRow2);
														DataRow dataRow3 = dataTable.NewRow();
														object expr_576 = this.GridEX1.GetRow().Cells["moshtari_ID"].Value;
														int? num5 = (expr_576 != null) ? ((int?)expr_576) : num4;
														string value3 = Conversions.ToString(this.GridEX1.GetRow().Cells["moshtari_name"].Value);
														dataRow3["Moshtari_Name"] = value3;
														dataRow3["Moshtari_ID"] = num5;
														dataRow3["Mablagh"] = Operators.SubtractObject(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande);
														dataRow3["dp_name"] = "پرداخت نقد";
														dataRow3["dptype_id"] = 10;
														dataRow3["is_child"] = true;
														dataRow3["parent_identity"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[dataTable.Rows.Count - 1]["identity"]);
														dataTable.Rows.Add(dataRow3);
														this.gridex2_RecordAdded(null, null);
													}
												}
											}
										}
									}
									else
									{
										bool flag7 = Operators.ConditionalCompareObjectLessEqual(this.GridEX1.GetRow().Cells["mablagh"].Value, this.Moshtari_Info.Mande, false);
										if (flag7)
										{
											DataTable dataTable2 = (DataTable)this.gridex2.DataSource;
											DataRow[] array4 = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("id is null and dptype_id=13 and moshtari_id=", this.GridEX1.GetRow().Cells["moshtari_id"].Value)));
											flag7 = (array4.Length > 0);
											if (flag7)
											{
												DataRow[] array5 = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("parent_identity=", array4[0]["identity"])));
												flag7 = (array5.Length > 0);
												if (flag7)
												{
													array5[0].Delete();
													flag7 = (array5.Length == 2);
													if (flag7)
													{
														array5[1].Delete();
													}
												}
												array4[0].Delete();
												dataTable2.AcceptChanges();
												this.gridex2_RecordAdded(null, null);
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

		// Token: 0x06001810 RID: 6160 RVA: 0x00105C30 File Offset: 0x00103E30
		private void txt_mablagh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			bool flag2;
			if (flag)
			{
				flag2 = (this.GridEX1.GetRow().Cells["dptype_id"].Value == DBNull.Value);
				if (flag2)
				{
					this.GridEX1.Col = this.GridEX1.RootTable.Columns["dp_name"].Position;
					this.GridEX1.EditMode = EditMode.EditOn;
					this.prevent_mablagh = true;
					e.SuppressKeyPress = true;
					return;
				}
				flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.GetRow().Cells["dptype_ID"].Value, 4, false);
				if (flag2)
				{
					int sum_Check = this.GetSum_Check();
					flag2 = (Operators.CompareString(this.txt_mablagh.Text, string.Empty, false) != 0);
					if (flag2)
					{
						this.CurrencyBox1.Text = Conversions.ToString(checked(Conversions.ToLong(this.txt_mablagh.Text.Replace(",", "")) - unchecked((long)sum_Check)));
						this.CurrencyBox1_Validating(this.CurrencyBox1, null);
						this.AddAutoPardakht();
					}
				}
				object value = this.GridEX1.GetRow().Cells["dptype_ID"].Value;
				flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(value, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 6, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 8, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 33, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 34, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 35, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 36, false))) ? true : false);
				if (flag2)
				{
					this.txt_babat.Focus();
				}
				else
				{
					flag2 = Operators.ConditionalCompareObjectEqual(value, 28, false);
					if (flag2)
					{
						this.txt_jens.Focus();
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(value, 2, false);
						if (flag2)
						{
							this.txt_shcheck.Focus();
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(value, 3, false);
							if (flag2)
							{
								this.txt_fishbankhesab.Focus();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(value, 43, false);
								if (flag2)
								{
									this.txt_havale_bank.Focus();
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(value, 4, false);
									if (flag2)
									{
										this.txt_dbabatnc.Focus();
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(value, 27, false);
										if (flag2)
										{
											this.txt_shtarakonesh.Focus();
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(value, 38, false);
											if (flag2)
											{
												this.txt_nahvePardakhtTankhah.Focus();
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(value, 39, false);
												if (flag2)
												{
													this.txt_be_moshtari.Focus();
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(value, 40, false);
													if (flag2)
													{
														this.txt_bs_shCheck.Focus();
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
			flag2 = (e.KeyCode == Keys.Left);
			if (flag2)
			{
				this.gridex2.Focus();
				this.gridex2.MoveToNewRecord();
				this.gridex2.Col = 0;
				this.gridex2.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00105FBC File Offset: 0x001041BC
		private void txt_babat_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Up;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.Group_DnaghdCheck.Parent == this.Group_Letf;
				if (flag2)
				{
					flag3 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 13, false);
					if (flag3)
					{
						this.UiButton1.Focus();
						return;
					}
				}
				flag3 = (this.Group_DnaghdCheck.Parent == this.Group_Letf);
				if (flag3)
				{
					flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 15, false);
					if (flag2)
					{
						this.txt_nahvePardakht.Focus();
						return;
					}
				}
				else
				{
					flag3 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 4, false);
					if (flag3)
					{
						this.UiButton1.Focus();
						return;
					}
				}
			}
			flag3 = (e.KeyCode == Keys.Return);
			checked
			{
				if (flag3)
				{
					this.txt_babat_Validated(RuntimeHelpers.GetObjectValue(sender), null);
					flag3 = (this.Group_DnaghdCheck.Parent == this.Group_Right);
					GridEX gridEX;
					if (flag3)
					{
						gridEX = this.GridEX1;
					}
					else
					{
						gridEX = this.gridex2;
					}
					gridEX.Col = 0;
					gridEX.MoveToNewRecord();
					gridEX.Focus();
					gridEX.EditMode = EditMode.EditOn;
					flag3 = (this.Group_DnaghdCheck.Parent == this.Group_Right);
					if (flag3)
					{
						bool flag2 = this.GridEX1.EditTextBox == null;
						if (!flag2)
						{
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.dp_select_Daryaft();
								this.GridEX1.EditMode = EditMode.EditOn;
								this.prevent = false;
								flag3 = (this.GridEX1.EditTextBox == null);
								if (!flag3)
								{
									flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag3)
									{
										flag2 = (this.GridEX1.CurrentRow.Cells["dp_name"].Value == DBNull.Value);
										if (flag2)
										{
											this.GridEX1.Col = this.GridEX1.RootTable.Columns["dp_name"].Position;
											this.GridEX1.EditMode = EditMode.EditOn;
										}
										else
										{
											this.Moshtari_select(this.GridEX1);
											this.prevent = false;
										}
									}
									else
									{
										DataEntryGrid dataEntryGrid = this.GridEX1;
										dataEntryGrid.Col++;
										this.GridEX1.EditMode = EditMode.EditOn;
									}
								}
							}
							else
							{
								DataEntryGrid dataEntryGrid = this.GridEX1;
								dataEntryGrid.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
					}
					else
					{
						flag3 = (this.gridex2.EditTextBox == null);
						if (!flag3)
						{
							flag3 = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.dp_select_Pardakht();
								this.prevent = false;
								flag3 = (this.gridex2.EditTextBox == null);
								if (!flag3)
								{
									flag3 = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
									if (flag3)
									{
										bool flag2 = this.gridex2.CurrentRow.Cells["dp_name"].Value == DBNull.Value;
										if (flag2)
										{
											this.gridex2.Col = this.gridex2.RootTable.Columns["dp_name"].Position;
											this.gridex2.EditMode = EditMode.EditOn;
										}
										else
										{
											this.Moshtari_selectPardakht();
											this.prevent = false;
										}
									}
									else
									{
										flag3 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 17, false);
										if (flag3)
										{
											this.UiButton2.Focus();
										}
										else
										{
											DataEntryGrid dataEntryGrid = this.gridex2;
											dataEntryGrid.Col++;
											this.gridex2.EditMode = EditMode.EditOn;
										}
									}
								}
							}
							else
							{
								flag3 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 21, false);
								if (flag3)
								{
									this.UiButton2.Focus();
								}
								else
								{
									DataEntryGrid dataEntryGrid = this.gridex2;
									dataEntryGrid.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x001064A8 File Offset: 0x001046A8
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			this.group_dnaghd.Visible = false;
			this.group_dcheck.Visible = false;
			this.group_dfish.Visible = false;
			this.Group_DnaghdCheck.Visible = false;
			this.Group_VarizCheck.Visible = false;
			this.Group_NaghdCheck.Visible = false;
			this.GroupKartkhan.Visible = false;
			this.Group_barzamin.Visible = false;
			this.group_bank_be_sandugh.Visible = false;
			this.Group_checkNaghd.Visible = false;
			this.group_havale_arzi.Visible = false;
			Public_Function.SetNew(this.group_dfish);
			Public_Function.SetNew(this.group_dnaghd);
			Public_Function.SetNew(this.group_dcheck);
			Public_Function.SetNew(this.Group_DnaghdCheck);
			Public_Function.SetNew(this.Group_VarizCheck);
			Public_Function.SetNew(this.GroupKartkhan);
			Public_Function.SetNew(this.Group_barzamin);
			Public_Function.SetNew(this.group_bank_be_sandugh);
			Public_Function.SetNew(this.group_havale_arzi);
			bool flag = this.GridEX1.GetRow() == null;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.GetRow().RowType == RowType.Record);
					if (flag)
					{
						this.GridEX1.GetRow().Cells["dp_name"].EditType = EditType.NoEdit;
						this.GridEX1.GetRow().Cells["dp_name"].ButtonEnabled = false;
						this.GridEX1.GetRow().Cells["dp_name"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
						DataRowView dataRowView = (DataRowView)this.GridEX1.GetRow().DataRow;
						flag = (dataRowView != null && dataRowView["dptype_ID"] != DBNull.Value);
						if (flag)
						{
							bool flag2 = dataRowView["moshtari_ID"] != DBNull.Value;
							bool flag4;
							if (flag2)
							{
								bool arg_293_0;
								if (!Operators.ConditionalCompareObjectEqual(dataRowView["dptype_ID"], 4, false) && !Operators.ConditionalCompareObjectEqual(dataRowView["dptype_ID"], 8, false))
								{
									if (!Operators.ConditionalCompareObjectEqual(dataRowView["dptype_ID"], 28, false))
									{
										if (!Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 3, false))
										{
											if (!Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 34, false))
											{
												if (!Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 43, false))
												{
													arg_293_0 = false;
													goto IL_292;
												}
											}
										}
									}
								}
								arg_293_0 = true;
								IL_292:
								bool flag3 = arg_293_0;
								if (flag3)
								{
									flag4 = Operators.ConditionalCompareObjectNotEqual(dataRowView["moshtari_ID"], -1, false);
									if (flag4)
									{
										this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(dataRowView["Moshtari_ID"]);
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
							}
							else
							{
								this.Clean_Status();
							}
							object left = dataRowView["dptype_ID"];
							flag4 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, -1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 5, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 35, false))) ? true : false);
							if (flag4)
							{
								this.GridEX1.GetRow().Cells["dp_name"].EditType = EditType.NoEdit;
								this.GridEX1.GetRow().Cells["moshtari_name"].EditType = EditType.NoEdit;
								this.GridEX1.GetRow().Cells["mablagh"].EditType = EditType.NoEdit;
								flag4 = Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 5, false);
								if (flag4)
								{
									this.group_dnaghd.Visible = true;
									this.txt_babat.Text = dataRowView["Tozih"].ToString();
								}
							}
							else
							{
								flag4 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 6, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 8, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 33, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 34, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 36, false))) ? true : false);
								if (flag4)
								{
									this.group_dnaghd.Visible = true;
									this.txt_babat.Text = dataRowView["Tozih"].ToString();
								}
								else
								{
									flag4 = Operators.ConditionalCompareObjectEqual(left, 40, false);
									if (flag4)
									{
										this.group_bank_be_sandugh.Visible = true;
										this.txt_bs_babat.Text = dataRowView["Tozih"].ToString();
										flag4 = (dataRowView["sh_check"] != DBNull.Value);
										if (flag4)
										{
											bool flag3 = dataRowView["checkbarg_id"] != DBNull.Value;
											if (flag3)
											{
												this.txt_bs_shCheck.SetValue(Conversions.ToString(dataRowView["sh_check"]), RuntimeHelpers.GetObjectValue(dataRowView["checkbarg_id"]));
											}
										}
									}
									else
									{
										flag4 = Operators.ConditionalCompareObjectEqual(left, 28, false);
										if (flag4)
										{
											this.Group_barzamin.Visible = true;
											string[] array = dataRowView["Tozih"].ToString().Split(new char[]
											{
												'-'
											});
											flag4 = (array.Length == 3);
											if (flag4)
											{
												this.txt_jens.Text = array[0];
												this.txt_tedad.Text = array[1];
												this.txt_vazn.Text = array[2];
											}
										}
										else
										{
											flag4 = Operators.ConditionalCompareObjectEqual(left, 25, false);
											if (flag4)
											{
												this.Group_NaghdCheck.Visible = true;
												this.GridEX1.GetRow().Cells["mablagh"].EditType = EditType.NoEdit;
											}
											else
											{
												flag4 = Operators.ConditionalCompareObjectEqual(left, 41, false);
												if (flag4)
												{
													this.Group_checkNaghd.Visible = true;
													this.GridEX1.GetRow().Cells["moshtari_name"].EditType = EditType.NoEdit;
													this.GridEX1.GetRow().Cells["mablagh"].EditType = EditType.NoEdit;
												}
												else
												{
													flag4 = Operators.ConditionalCompareObjectEqual(left, 27, false);
													if (flag4)
													{
														this.GroupKartkhan.Visible = true;
														this.GridEX1.GetRow().Cells["moshtari_name"].EditType = EditType.NoEdit;
														this.txt_shtarakonesh.Text = dataRowView["Tozih"].ToString();
													}
													else
													{
														flag4 = Operators.ConditionalCompareObjectEqual(left, 2, false);
														if (flag4)
														{
															this.group_dcheck.Visible = true;
															this.txt_shcheck.Text = dataRowView["Sh_Check"].ToString();
															flag4 = (dataRowView["CheckBank_ID"] != DBNull.Value);
															if (flag4)
															{
																this.txt_bank.SetValue(Conversions.ToString(dataRowView["CheckBank_Name"]), RuntimeHelpers.GetObjectValue(dataRowView["CheckBank_ID"]));
															}
															else
															{
																this.txt_bank.SetNew();
															}
															this.txt_shobe.Text = dataRowView["Check_Shobe"].ToString();
															flag4 = (dataRowView["Check_Sarresid_Fa"] != DBNull.Value);
															if (flag4)
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
															flag4 = Operators.ConditionalCompareObjectEqual(left, 3, false);
															if (flag4)
															{
																this.group_dfish.Visible = true;
																this.txt_fishbabat.Text = dataRowView["Tozih"].ToString();
																flag4 = (dataRowView["BankHesab_ID"] != DBNull.Value);
																if (flag4)
																{
																	this.txt_fishbankhesab.SetValue(Conversions.ToString(dataRowView["BankHesab_Name"]), RuntimeHelpers.GetObjectValue(dataRowView["BankHesab_ID"]));
																}
																else
																{
																	this.txt_fishbankhesab.SetNew();
																}
															}
															else
															{
																flag4 = Operators.ConditionalCompareObjectEqual(left, 43, false);
																if (flag4)
																{
																	this.group_havale_arzi.Visible = true;
																	this.txt_havale_babat.Text = dataRowView["Tozih"].ToString();
																	flag4 = (dataRowView["fishvariz_fa"] != DBNull.Value);
																	if (flag4)
																	{
																		this.txt_fee_dolar.Text = dataRowView["fishvariz_fa"].ToString();
																	}
																	else
																	{
																		this.txt_fee_dolar.SetNew();
																	}
																	flag4 = (dataRowView["beMoshtari_id"] != DBNull.Value);
																	if (flag4)
																	{
																		this.txt_havale_bank.SetValue(Conversions.ToString(dataRowView["bemoshtari_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bemoshtari_id"]));
																	}
																	else
																	{
																		this.txt_havale_bank.SetNew();
																	}
																}
																else
																{
																	flag4 = Operators.ConditionalCompareObjectEqual(left, 4, false);
																	if (flag4)
																	{
																		this.Group_DnaghdCheck.Visible = true;
																		this.Label25.Visible = false;
																		this.UiButton6.Visible = false;
																		this.txt_moshtariHesab.Visible = false;
																		this.txt_dbabatnc.Text = dataRowView["Tozih"].ToString();
																		int i = ((DataTable)this.GridEX1.DataSource).Rows.IndexOf(((DataRowView)this.GridEX1.CurrentRow.DataRow).Row);
																		DataTable dataTable = (DataTable)this.GridEX1.DataSource;
																		int num = Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["identity"]);
																		flag4 = (this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value == DBNull.Value);
																		if (!flag4)
																		{
																			flag4 = (Operators.CompareString(this.GridEX1.CurrentRow.Cells["Mablagh"].Value.ToString(), string.Empty, false) == 0);
																			if (!flag4)
																			{
																				this.CurrencyBox1.Text = Conversions.ToString(dataTable.Rows[i]["mablagh"]);
																				flag4 = (i < dataTable.Rows.Count - 1);
																				if (flag4)
																				{
																					bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i + 1]["dptype_id"], 1, false) && Operators.ConditionalCompareObjectEqual(dataTable.Rows[i + 1]["parent_identity"], dataTable.Rows[i]["identity"], false);
																					if (flag3)
																					{
																						this.CurrencyBox1.Text = dataTable.Rows[i + 1]["Mablagh"].ToString();
																						this.CurrencyBox1.Value = Conversions.ToLong(dataTable.Rows[i + 1]["Mablagh"].ToString());
																						return;
																					}
																				}
																				i++;
																				while (i <= dataTable.Rows.Count - 1)
																				{
																					flag4 = (dataTable.Rows[i].RowState == DataRowState.Deleted);
																					if (flag4)
																					{
																						i++;
																					}
																					else
																					{
																						flag4 = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
																						if (flag4)
																						{
																							i++;
																						}
																						else
																						{
																							flag4 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
																							if (flag4)
																							{
																								bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 1, false);
																								if (flag3)
																								{
																									this.CurrencyBox1.Text = dataTable.Rows[i]["Mablagh"].ToString();
																									this.CurrencyBox1.Value = Conversions.ToLong(dataTable.Rows[i]["Mablagh"].ToString());
																									return;
																								}
																							}
																							i++;
																						}
																					}
																				}
																				this.CurrencyBox1.Text = Conversions.ToString(0);
																				this.CurrencyBox1.Value = 0L;
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
							}
						}
					}
					else
					{
						this.Clean_Status();
					}
				}
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00107244 File Offset: 0x00105444
		private bool ValidateGrid()
		{
			this.prevent = true;
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Focus();
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			GridEXRow[] rows = this.GridEX1.GetRows();
			int i = 0;
			checked
			{
				bool result;
				while (i < rows.Length)
				{
					GridEXRow gridEXRow = rows[i];
					DataRowView dataRowView = (DataRowView)gridEXRow.DataRow;
					bool flag = gridEXRow.Cells["dptype_id"].Value == DBNull.Value;
					if (!flag)
					{
						flag = Conversions.ToBoolean(Operators.AndObject((!Conversions.ToBoolean(Operators.CompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, 25, false)) || !Conversions.ToBoolean(Operators.CompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, 26, false)) || !Conversions.ToBoolean(Operators.CompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, 35, false)) || !Conversions.ToBoolean(Operators.CompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, 41, false))) ? false : true, Operators.CompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, -6, false)));
						bool flag2;
						if (flag)
						{
							flag2 = (gridEXRow.Cells["Moshtari_id"].Value == DBNull.Value);
							if (flag2)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "moshtari_name", "مشتری مورد نظر را انتخاب فرمائید");
								result = false;
								return result;
							}
						}
						flag2 = (gridEXRow.Cells["mablagh"].Value == DBNull.Value);
						if (flag2)
						{
							flag = Operators.ConditionalCompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, 28, false);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "mablagh", "مبلغ مورد نظر را وارد نمائید");
								result = false;
								return result;
							}
							flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["Moshtari_ID"].Value, 0, false);
							if (flag2)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "mablagh", "مبلغ مورد نظر را وارد نمائید");
								result = false;
								return result;
							}
							gridEXRow.Cells["mablagh"].Value = 0;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["mablagh"].Value, 0, false);
						if (flag2)
						{
							flag = Operators.ConditionalCompareObjectNotEqual(gridEXRow.Cells["dptype_id"].Value, 28, false);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "mablagh", "مبلغ مورد نظر را وارد نمائید");
								result = false;
								return result;
							}
							flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["Moshtari_ID"].Value, -1, false);
							if (flag2)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "mablagh", "مبلغ مورد نظر را وارد نمائید");
								result = false;
								return result;
							}
							gridEXRow.Cells["mablagh"].Value = 0;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 2, false);
						if (flag2)
						{
							flag = (dataRowView["sh_check"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["sh_check"], string.Empty, false));
							if (flag)
							{
								this.GridEX1.MoveTo(gridEXRow);
								this.txt_shcheck.ShowTip("شماره چک را وارد نمائید");
								result = false;
								return result;
							}
							flag2 = (dataRowView["CheckBank_ID"] == DBNull.Value);
							if (flag2)
							{
								this.GridEX1.MoveTo(gridEXRow);
								this.txt_bank.ShowTip("بانک صادرکننده چک را انتخاب فرمائید ");
								result = false;
								return result;
							}
							flag2 = (dataRowView["Check_Shobe"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["Check_Shobe"], string.Empty, false));
							if (flag2)
							{
								this.GridEX1.MoveTo(gridEXRow);
								this.txt_shobe.ShowTip("شعبه صادرکننده چک را انتخاب فرمائید ");
								result = false;
								return result;
							}
						}
						flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 3, false);
						if (flag2)
						{
							flag = (dataRowView["BankHesab_ID"] == DBNull.Value);
							if (flag)
							{
								this.GridEX1.MoveTo(gridEXRow);
								this.txt_fishbankhesab.ShowTip("شماره حساب بانک را انتخاب فرمائید");
								result = false;
								return result;
							}
						}
						flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 43, false);
						if (flag2)
						{
							flag = (dataRowView["beMoshtari_id"] == DBNull.Value);
							if (flag)
							{
								this.GridEX1.MoveTo(gridEXRow);
								this.GridEX1_SelectionChanged(null, null);
								this.txt_havale_bank.ShowTip("مشتری را انتخاب فرمائید");
								result = false;
								return result;
							}
							flag2 = (dataRowView["fishvariz_fa"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["fishvariz_fa"], string.Empty, false));
							if (flag2)
							{
								this.GridEX1.MoveTo(gridEXRow);
								this.GridEX1_SelectionChanged(null, null);
								this.txt_fee_dolar.ShowTip("فی دلار را وارد نمایید");
								result = false;
								return result;
							}
						}
						i++;
						continue;
					}
					Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "dp_name", "نوع دریافت را مشخص فرمائید");
					result = false;
					return result;
				}
				this.prevent = true;
				this.gridex2.MoveToNewRecord();
				this.gridex2.Focus();
				this.gridex2.UpdateData();
				dataTable = (DataTable)this.gridex2.DataSource;
				GridEXRow[] rows2 = this.gridex2.GetRows();
				for (int j = 0; j < rows2.Length; j++)
				{
					GridEXRow gridEXRow2 = rows2[j];
					DataRowView dataRowView = (DataRowView)gridEXRow2.DataRow;
					bool flag2 = gridEXRow2.Cells["dptype_id"].Value == DBNull.Value;
					if (flag2)
					{
						Public_Function.GridRaiseSoftError(this.gridex2, gridEXRow2, "dp_name", "نوع پرداخت را مشخص فرمائید");
						result = false;
						return result;
					}
					flag2 = (Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, 21, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, 22, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, 19, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, 20, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, 30, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, -2, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, -5, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, -4, false) && Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_ID"].Value, -7, false));
					bool flag3;
					if (flag2)
					{
						bool flag = gridEXRow2.Cells["Moshtari_id"].Value == DBNull.Value;
						if (flag)
						{
							flag3 = Operators.ConditionalCompareObjectNotEqual(gridEXRow2.Cells["dptype_id"].Value, 29, false);
							if (flag3)
							{
								Public_Function.GridRaiseSoftError(this.gridex2, gridEXRow2, "moshtari_name", "مشتری مورد نظر را انتخاب فرمائید");
								result = false;
								return result;
							}
							flag3 = (dataRowView["hazine_id"] == DBNull.Value);
							if (flag3)
							{
								Public_Function.GridRaiseSoftError(this.gridex2, gridEXRow2, "moshtari_name", "مشتری مورد نظر را انتخاب فرمائید");
								result = false;
								return result;
							}
						}
					}
					flag3 = (gridEXRow2.Cells["mablagh"].Value == DBNull.Value);
					if (flag3)
					{
						Public_Function.GridRaiseSoftError(this.gridex2, gridEXRow2, "mablagh", "مبلغ مورد نظر را وارد نمائید");
						result = false;
						return result;
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["mablagh"].Value, 0, false);
					if (flag3)
					{
						Public_Function.GridRaiseSoftError(this.gridex2, gridEXRow2, "mablagh", "مبلغ مورد نظر را وارد نمائید");
						result = false;
						return result;
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["dptype_id"].Value, 31, false);
					if (flag3)
					{
						flag2 = (dataRowView["bankhesab_id"] == DBNull.Value);
						if (flag2)
						{
							this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
							this.gridex2.Focus();
							this.gridex2.Row = gridEXRow2.Position;
							this.txt_bank_bankhesab.ShowTip("حساب بانکی مورد نظر را انتخاب فرمائید");
							this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
							result = false;
							return result;
						}
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["dptype_id"].Value, 29, false);
					if (flag3)
					{
						flag2 = (dataRowView["bankhesab_id"] == DBNull.Value);
						if (flag2)
						{
							this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
							this.gridex2.Focus();
							this.gridex2.Row = gridEXRow2.Position;
							this.txt_kart_bankhesab.ShowTip("حساب بانکی مورد نظر را انتخاب فرمائید");
							this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
							result = false;
							return result;
						}
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["dptype_id"].Value, 15, false);
					if (flag3)
					{
						flag2 = (dataRowView["moshtari_id2"] == DBNull.Value);
						if (flag2)
						{
							this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
							this.gridex2.Focus();
							this.gridex2.Row = gridEXRow2.Position;
							this.txt_nahvePardakht.ShowTip("نحوه پرداخت را مشخص نمائید");
							this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
							result = false;
							return result;
						}
						flag3 = (Operators.ConditionalCompareObjectEqual(dataRowView["moshtari_id2"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRowView["moshtari_id2"], 3, false));
						if (flag3)
						{
							flag2 = (dataRowView["sh_check"] == DBNull.Value);
							if (flag2)
							{
								this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
								this.gridex2.Focus();
								this.gridex2.Row = gridEXRow2.Position;
								this.txt_hazine_shcheck.ShowTip("شماره چک را وارد نمائید");
								this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
								result = false;
								return result;
							}
						}
						flag3 = Operators.ConditionalCompareObjectEqual(dataRowView["moshtari_id2"], 4, false);
						if (flag3)
						{
							flag2 = (dataRowView["bankhesab_id"] == DBNull.Value);
							if (flag2)
							{
								this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
								this.gridex2.Focus();
								this.gridex2.Row = gridEXRow2.Position;
								this.txt_hazine_kartbekart.ShowTip("حساب بانکی را وارد نمائید");
								this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
								result = false;
								return result;
							}
						}
						flag3 = Operators.ConditionalCompareObjectEqual(dataRowView["moshtari_id2"], 5, false);
						if (flag3)
						{
							flag2 = (dataRowView["hazine_id"] == DBNull.Value);
							if (flag2)
							{
								this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
								this.gridex2.Focus();
								this.gridex2.Row = gridEXRow2.Position;
								this.txt_hazinetankhah.ShowTip("تنخواه گردان را وارد نمائید");
								this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
								result = false;
								return result;
							}
						}
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["dptype_id"].Value, 38, false);
					if (flag3)
					{
						flag2 = (dataRowView["moshtari_id2"] == DBNull.Value);
						if (flag2)
						{
							this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
							this.gridex2.Focus();
							this.gridex2.Row = gridEXRow2.Position;
							this.Group_PardakhtTankhah.Visible = true;
							this.txt_nahvePardakhtTankhah.ShowTip("نحوه پرداخت را مشخص نمائید");
							this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
							result = false;
							return result;
						}
						flag3 = Operators.ConditionalCompareObjectNotEqual(dataRowView["moshtari_id2"], 1, false);
						if (flag3)
						{
							flag2 = (dataRowView["bankhesab_id"] == DBNull.Value);
							if (flag2)
							{
								this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
								this.gridex2.Focus();
								this.gridex2.Row = gridEXRow2.Position;
								this.Group_PardakhtTankhah.Visible = true;
								this.txt_tankhah_hesabbanki.ShowTip("حساب بانکی را مشخص فرمائید");
								this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
								result = false;
								return result;
							}
						}
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["dptype_id"].Value, 39, false);
					if (flag3)
					{
						flag2 = (dataRowView["beMoshtari_id"] == DBNull.Value);
						if (flag2)
						{
							this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
							this.gridex2.Focus();
							this.gridex2.Row = gridEXRow2.Position;
							this.txt_be_moshtari.ShowTip("حساب بانکی مورد نظر را انتخاب فرمائید");
							this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
							result = false;
							return result;
						}
					}
					flag3 = Operators.ConditionalCompareObjectEqual(gridEXRow2.Cells["dptype_id"].Value, 44, false);
					if (flag3)
					{
						flag2 = (dataRowView["bemoshtari_id"] == DBNull.Value);
						if (flag2)
						{
							this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
							this.gridex2.Focus();
							this.gridex2.Row = gridEXRow2.Position;
							this.txt_be_moshtari.ShowTip("مشتری مورد نظر را انتخاب فرمائید");
							this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
							result = false;
							return result;
						}
						flag3 = (dataRowView["fishvariz_fa"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRowView["fishvariz_fa"], string.Empty, false));
						if (flag3)
						{
							this.gridex2.MoveTo(gridEXRow2);
							this.gridex2_SelectionChanged(null, null);
							this.txt_fee_dolar.ShowTip("فی دلار را وارد نمایید");
							result = false;
							return result;
						}
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x001082EC File Offset: 0x001064EC
		private void GetDaryaftChecks()
		{
			bool flag = this.ListDaryaft_Identity.Count == 0;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				try
				{
					List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
					while (enumerator.MoveNext())
					{
						listCheckDaryaft current = enumerator.Current;
						flag = (current.Operation_id == 26);
						if (!flag)
						{
							DataRow[] array = dataTable.Select("identity=" + Conversions.ToString(current.Daryaft_Identity));
							flag = (array.Length > 0);
							if (flag)
							{
								current.Bank_ID = Conversions.ToInteger(array[0]["CheckBank_ID"]);
								current.Mablagh = Conversions.ToLong(array[0]["Mablagh"]);
								current.Moshtari_id = Conversions.ToInteger(array[0]["Moshtari_ID"]);
								current.sh_check = Conversions.ToString(array[0]["sh_check"]);
							}
						}
					}
				}
				finally
				{
					List<listCheckDaryaft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00108418 File Offset: 0x00106618
		private void SetPardakhtChecks()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = (DataTable)this.gridex2.DataSource;
			checked
			{
				try
				{
					List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
					while (enumerator.MoveNext())
					{
						listCheckDaryaft current = enumerator.Current;
						DataRow[] array = dataTable.Select(string.Concat(new string[]
						{
							"moshtari_id=",
							Conversions.ToString(current.Moshtari_id),
							" and CheckBank_ID=",
							Conversions.ToString(current.Bank_ID),
							" and mablagh=",
							Conversions.ToString(current.Mablagh),
							" and sh_check='",
							current.sh_check,
							"'"
						}));
						bool flag = array.Length > 0;
						if (flag)
						{
							DataRow[] array2 = dataTable2.Select("daryaft_identity=" + Conversions.ToString(current.Daryaft_Identity) + " and pardakhtcheck_id=0");
							flag = (array2.Length > 0);
							if (flag)
							{
								DataRow[] array3 = array2;
								for (int i = 0; i < array3.Length; i++)
								{
									DataRow dataRow = array3[i];
									dataRow["Pardakhtcheck_id"] = RuntimeHelpers.GetObjectValue(array[0]["id"]);
								}
							}
						}
					}
				}
				finally
				{
					List<listCheckDaryaft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x001085AC File Offset: 0x001067AC
		private void SetPardakhtChecksByGridPardakht()
		{
			DataTable dataTable = (DataTable)this.gridex2.DataSource;
			try
			{
				List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
				while (enumerator.MoveNext())
				{
					listCheckDaryaft current = enumerator.Current;
					bool flag = current.Operation_id == 20;
					if (flag)
					{
						DataRow[] array = dataTable.Select("daryaft_identity=" + Conversions.ToString(current.Daryaft_Identity));
						flag = (array.Length > 0);
						if (flag)
						{
						}
					}
				}
			}
			finally
			{
				List<listCheckDaryaft>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00108654 File Offset: 0x00106854
		private void SetCehckMoshtari(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["dptype_id"] == DBNull.Value || dataRow["dptype_id"] == null;
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false);
						if (flag)
						{
							DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("SELECT     DaryaftPardakht.Moshtari_ID, Moshtari.Name + ' ' + Moshtari.Family AS name   FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID where DaryaftPardakht.id=", dataRow["Pardakhtcheck_id"])));
							dataRow["Moshtari_id"] = RuntimeHelpers.GetObjectValue(dataRow2["Moshtari_id"]);
							dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["Name"]);
							flag = (dataRow["BankHesab_ID"] == DBNull.Value);
							if (flag)
							{
								dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     DaryaftPardakht.Moshtari_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name    FROM         DaryaftPardakht LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID where pardakhtcheck_id=", dataRow["Pardakhtcheck_id"]), " and dptype_id=12")));
								flag = (dataRow2 != null);
								if (flag)
								{
									dataRow["Moshtari_id2"] = RuntimeHelpers.GetObjectValue(dataRow2["Moshtari_id"]);
									dataRow["Moshtari_Name2"] = RuntimeHelpers.GetObjectValue(dataRow2["Moshtari_Name"]);
								}
							}
						}
						flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false);
						if (flag)
						{
							DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT   Top 1  DaryaftPardakht.BankHesab_ID, Bank.Name+' - '+ Bank_Hesab.Shobe AS BankHesab_Name  FROM         Bank_Hesab INNER JOIN  DaryaftPardakht ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID where DaryaftPardakht.PardakhtCheck_ID=", dataRow["Pardakhtcheck_id"]), " AND check_status=2 order by tarikh desc")));
							flag = (dataRow2 != null);
							if (flag)
							{
								dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["BankHesab_ID"]);
								dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["BankHesab_Name"]);
								dataRow["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["BankHesab_ID"]);
								dataRow["BankHesab_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["BankHesab_Name"]);
							}
							else
							{
								DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("PardakhtCheck_ID=", dataRow["PardakhtCheck_ID"]), " AND dptype_ID=18")));
								flag = (array.Length > 0);
								if (flag)
								{
									dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_ID"]);
									dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_Name"]);
									dataRow["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_ID"]);
									dataRow["BankHesab_Name"] = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_Name"]);
								}
							}
						}
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

		// Token: 0x06001818 RID: 6168 RVA: 0x00108984 File Offset: 0x00106B84
		private void GetChenges()
		{
			Public_Function.CurrentData.Username = "admin";
			this.change.Clear();
			this.change.Add(new TableItemChange
			{
				column = "Mablagh",
				caption = "مبلغ"
			});
			this.change.Add(new TableItemChange
			{
				column = "Tozih",
				caption = "توضیح"
			});
			DataTable changedTable = ((DataTable)this.GridEX1.DataSource).Copy();
			this.historyLog.TableName = "daryaftpardakht";
			this.historyLog.Pkey = this.txt_tarikh.Text;
			this.historyLog.Ext1ColumnName = "moshtari_Name";
			this.historyLog.Ext2ColumnName = "dp_name";
			this.historyLog.TableItems = this.change;
			this.historyLog.GetChenges(this.origin_daryaft, changedTable);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00108A88 File Offset: 0x00106C88
		private void CheckForMax_bedBes()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["no_bed_alert"]);
			checked
			{
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					dataTable.AcceptChanges();
					string text = string.Empty;
					int num = 0;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 4, false);
							if (flag)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["moshtari_id"], ",")));
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
					flag = (text.Length > 0);
					bool flag2;
					if (flag)
					{
						DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
						{
							"SELECT     t.Bed, t.Bes, t.CodeHesab_ID, Moshtari.ID, Moshtari.Name+' '+ Moshtari.Family  as Moshtari_Name  FROM         (SELECT     SUM(Bed) AS Bed, SUM(Bes) AS Bes, CodeHesab_ID   FROM Sanad  WHERE     CodeHesab_ID IN (select codehesab_id from moshtari where id in(",
							text,
							")) and tarikh <> ",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
							" GROUP BY CodeHesab_ID    HAVING      (SUM(Bed) - SUM(Bes) >= 0)) AS t INNER JOIN  Moshtari ON t.CodeHesab_ID = Moshtari.CodeHesab_ID"
						}));
						try
						{
							IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								try
								{
									IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										DataRow dataRow3 = (DataRow)enumerator3.Current;
										flag = (dataRow3["id"] != DBNull.Value);
										if (!flag)
										{
											flag = (dataRow3["moshtari_id"] == DBNull.Value);
											if (!flag)
											{
												flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["dptype_id"], 4, false), Operators.CompareObjectEqual(dataRow3["moshtari_id"], dataRow2["id"], false)));
												if (flag)
												{
													flag2 = Operators.ConditionalCompareObjectLess(Operators.SubtractObject(dataRow2["bed"], dataRow2["bes"]), dataRow3["mablagh"], false);
													if (flag2)
													{
														Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("مبلغ دریافتی از ", dataRow2["moshtari_name"]), " بیشتر از میزان بدهکاری است ")), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
													}
													else
													{
														DataRow dataRow4 = dataRow2;
														DataRow arg_29A_0 = dataRow4;
														string columnName = "bes";
														arg_29A_0[columnName] = Operators.AddObject(dataRow4[columnName], dataRow3["mablagh"]);
													}
												}
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
								num++;
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
					}
					dataTable = (DataTable)this.gridex2.DataSource;
					dataTable.AcceptChanges();
					text = string.Empty;
					try
					{
						IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DataRow dataRow5 = (DataRow)enumerator4.Current;
							flag2 = (dataRow5["dptype_id"] == DBNull.Value);
							if (!flag2)
							{
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow5["dptype_id"], 13, false);
								if (flag2)
								{
									flag = (dataRow5["moshtari_id"] != DBNull.Value);
									if (flag)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow5["moshtari_id"], ",")));
									}
								}
							}
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
					text = Public_Function.RemoveLast(text);
					flag2 = (text.Length > 0);
					if (flag2)
					{
						DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
						{
							"SELECT     t.Bed, t.Bes, t.CodeHesab_ID, Moshtari.ID, Moshtari.Name+' '+ Moshtari.Family  as Moshtari_Name  FROM         (SELECT     SUM(Bed) AS Bed, SUM(Bes) AS Bes, CodeHesab_ID   FROM Sanad  WHERE     CodeHesab_ID IN (select codehesab_id from moshtari where id in(",
							text,
							")) and tarikh <>  ",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
							" GROUP BY CodeHesab_ID  HAVING      (SUM(Bes) - SUM(Bed) >= 0)) AS t INNER JOIN  Moshtari ON t.CodeHesab_ID = Moshtari.CodeHesab_ID"
						}));
						try
						{
							IEnumerator enumerator5 = dataTable2.Rows.GetEnumerator();
							while (enumerator5.MoveNext())
							{
								DataRow dataRow6 = (DataRow)enumerator5.Current;
								try
								{
									IEnumerator enumerator6 = dataTable.Rows.GetEnumerator();
									while (enumerator6.MoveNext())
									{
										DataRow dataRow7 = (DataRow)enumerator6.Current;
										flag2 = (dataRow7["id"] != DBNull.Value);
										if (!flag2)
										{
											flag2 = (dataRow7["moshtari_id"] == DBNull.Value);
											if (!flag2)
											{
												flag2 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow7["dptype_id"], 13, false), Operators.CompareObjectEqual(dataRow7["moshtari_id"], dataRow6["id"], false)));
												if (flag2)
												{
													flag = Operators.ConditionalCompareObjectLess(Operators.SubtractObject(dataRow6["bes"], dataRow6["bed"]), dataRow7["mablagh"], false);
													if (flag)
													{
														Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("مبلغ پرداختی به ", dataRow6["moshtari_name"]), " بیشتر از میزان بستانکاری است ")), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
													}
													else
													{
														DataRow dataRow4 = dataRow6;
														DataRow arg_5CA_0 = dataRow4;
														string columnName = "bed";
														arg_5CA_0[columnName] = Operators.AddObject(dataRow4[columnName], dataRow7["mablagh"]);
													}
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator6;
									flag2 = (enumerator6 is IDisposable);
									if (flag2)
									{
										(enumerator6 as IDisposable).Dispose();
									}
								}
								num++;
							}
						}
						finally
						{
							IEnumerator enumerator5;
							flag2 = (enumerator5 is IDisposable);
							if (flag2)
							{
								(enumerator5 as IDisposable).Dispose();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00109170 File Offset: 0x00107370
		private void updatebabat()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			bool flag4;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.DataRow != null;
				if (flag2)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["dptype_id"].Value != DBNull.Value;
					if (flag3)
					{
						object value = this.GridEX1.CurrentRow.Cells["dptype_id"].Value;
						flag4 = Operators.ConditionalCompareObjectEqual(value, 3, false);
						if (flag4)
						{
							this.txt_babat_Validated(this.txt_fishbabat, null);
						}
						else
						{
							flag4 = Operators.ConditionalCompareObjectEqual(value, 4, false);
							if (flag4)
							{
								this.txt_babat_Validated(this.txt_dbabatnc, null);
							}
						}
					}
				}
			}
			flag4 = (this.gridex2.CurrentRow != null);
			if (flag4)
			{
				bool flag3 = this.gridex2.CurrentRow.DataRow != null;
				if (flag3)
				{
					bool flag2 = this.gridex2.CurrentRow.Cells["dptype_id"].Value != DBNull.Value;
					if (flag2)
					{
						object value2 = this.gridex2.CurrentRow.Cells["dptype_id"].Value;
						flag = Operators.ConditionalCompareObjectEqual(value2, 13, false);
						if (flag)
						{
							this.txt_babat_Validated(this.txt_dbabatnc, null);
						}
					}
				}
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x001092F8 File Offset: 0x001074F8
		private bool Save(bool silent)
		{
			this.GridEX1.CellEdited -= new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.ColumnButtonClick -= new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
			this.GridEX1.EditingCell -= new EditingCellEventHandler(this.GridEX1_EditingCell);
			this.GridEX1.EndCustomEdit -= new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.GotFocus -= new EventHandler(this.GridEX1_GotFocus);
			this.GridEX1.InitCustomEdit -= new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
			this.GridEX1.KeyDown -= new KeyEventHandler(this.GridEX1_KeyDown);
			this.GridEX1.SelectionChanged -= new EventHandler(this.GridEX1_SelectionChanged);
			this.gridex2.CellEdited -= new ColumnActionEventHandler(this.GridEX2_CellEdited);
			this.gridex2.ColumnButtonClick -= new ColumnActionEventHandler(this.gridex2_ColumnButtonClick);
			this.gridex2.EditingCell -= new EditingCellEventHandler(this.GridEX1_EditingCell);
			this.gridex2.EndCustomEdit -= new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.gridex2.GotFocus -= new EventHandler(this.gridex2_GotFocus);
			this.gridex2.InitCustomEdit -= new InitCustomEditEventHandler(this.gridex2_InitCustomEdit);
			this.gridex2.KeyDown -= new KeyEventHandler(this.GridEX2_KeyDown);
			this.gridex2.SelectionChanged -= new EventHandler(this.gridex2_SelectionChanged);
			this.updatebabat();
			bool flag = !this.ValidateGrid();
			bool result;
			if (flag)
			{
				this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
				this.GridEX1.ColumnButtonClick += new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				this.GridEX1.EditingCell += new EditingCellEventHandler(this.GridEX1_EditingCell);
				this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				this.GridEX1.GotFocus += new EventHandler(this.GridEX1_GotFocus);
				this.GridEX1.InitCustomEdit += new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				this.GridEX1.KeyDown += new KeyEventHandler(this.GridEX1_KeyDown);
				this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
				this.gridex2.CellEdited += new ColumnActionEventHandler(this.GridEX2_CellEdited);
				this.gridex2.ColumnButtonClick += new ColumnActionEventHandler(this.gridex2_ColumnButtonClick);
				this.gridex2.EditingCell += new EditingCellEventHandler(this.GridEX1_EditingCell);
				this.gridex2.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				this.gridex2.GotFocus += new EventHandler(this.gridex2_GotFocus);
				this.gridex2.InitCustomEdit += new InitCustomEditEventHandler(this.gridex2_InitCustomEdit);
				this.gridex2.KeyDown += new KeyEventHandler(this.GridEX2_KeyDown);
				this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
				result = false;
			}
			else
			{
				this.CheckForMax_bedBes();
				this.dp.DeleteKeraye(this.txt_tarikh.Text);
				List<long> lst = new List<long>();
				this.GetDaryaftChecks();
				this.dp.UpdateDaryaft(this.txt_tarikh.Text, (DataTable)this.GridEX1.DataSource, lst);
				this.GetDataDaryaft();
				this.SetPardakhtChecks();
				this.SetCehckMoshtari((DataTable)this.gridex2.DataSource);
				this.dp.UpdatePardakht(this.txt_tarikh.Text, (DataTable)this.gridex2.DataSource);
				this.dp.EslahJamKol(lst);
				this.Sandug.SynckasrEzafe(this.txt_tarikh.Text);
				this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
				this.GridEX1.ColumnButtonClick += new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				this.GridEX1.EditingCell += new EditingCellEventHandler(this.GridEX1_EditingCell);
				this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				this.GridEX1.GotFocus += new EventHandler(this.GridEX1_GotFocus);
				this.GridEX1.InitCustomEdit += new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				this.GridEX1.KeyDown += new KeyEventHandler(this.GridEX1_KeyDown);
				this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
				this.gridex2.CellEdited += new ColumnActionEventHandler(this.GridEX2_CellEdited);
				this.gridex2.ColumnButtonClick += new ColumnActionEventHandler(this.gridex2_ColumnButtonClick);
				this.gridex2.EditingCell += new EditingCellEventHandler(this.GridEX1_EditingCell);
				this.gridex2.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				this.gridex2.GotFocus += new EventHandler(this.gridex2_GotFocus);
				this.gridex2.InitCustomEdit += new InitCustomEditEventHandler(this.gridex2_InitCustomEdit);
				this.gridex2.KeyDown += new KeyEventHandler(this.GridEX2_KeyDown);
				this.gridex2.SelectionChanged += new EventHandler(this.gridex2_SelectionChanged);
				flag = !silent;
				if (flag)
				{
					MyProject.Forms.Form_Main.addautoVusul();
					Public_Function.ConfirmInsert();
					this.GetDataDaryaft();
					this.GetDataPardakht();
					this.ListDaryaft_Identity.Clear();
					this.GridEX1.Focus();
					this.GridEX1.MoveToNewRecord();
					this.gridex2.MoveToNewRecord();
					this.GridEX1.Col = 0;
					this.GridEX1.CurrentRow.BeginEdit();
					this.GridEX1.EditMode = EditMode.EditOn;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00109928 File Offset: 0x00107B28
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = !this.f2_click;
			if (flag)
			{
				this.f2_click = true;
				this.Save(false);
				MyProject.Forms.Form_Main.Get_Sarresid();
				MyProject.Forms.Form_Main.Get_sarresid_Pardakht();
				this.f2_click = false;
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0010997C File Offset: 0x00107B7C
		private void txt_babat_Validated(object sender, EventArgs e)
		{
			bool flag = (UIGroupBox)this.group_dcheck.Parent == this.Group_Right;
			GridEX gridEX;
			if (flag)
			{
				gridEX = this.GridEX1;
			}
			else
			{
				gridEX = this.gridex2;
			}
			flag = (gridEX.CurrentRow == null);
			if (!flag)
			{
				flag = (gridEX.CurrentRow.Cells["dptype_id"].Value != DBNull.Value);
				bool flag2;
				if (flag)
				{
					flag2 = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 2, false);
					if (flag2)
					{
						this.SetRowValue(gridEX, "Check_Sarresid_Fa", this.txt_sarresid.Text);
					}
				}
				flag2 = sender.Equals(this.txt_bs_babat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_bs_babat.Text);
				}
				flag2 = sender.Equals(this.txt_babat_moshtari_be_moshtari);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babat_moshtari_be_moshtari.Text);
				}
				flag2 = sender.Equals(this.txt_havale_babat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_havale_babat.Text);
				}
				flag2 = sender.Equals(this.txt_phavale_babat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_phavale_babat.Text);
				}
				flag2 = sender.Equals(this.txt_babattankhah);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babattankhah.Text);
				}
				flag2 = sender.Equals(this.txt_babat_hazine);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babat_hazine.Text);
				}
				flag2 = sender.Equals(this.txt_babat_agsat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babat_agsat.Text);
				}
				flag2 = sender.Equals(this.txt_babat_hazine_bank);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babat_hazine_bank.Text);
				}
				flag2 = sender.Equals(this.txt_bank_babat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_bank_babat.Text);
				}
				flag2 = sender.Equals(this.txt_babat_kart);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babat_kart.Text);
				}
				flag2 = sender.Equals(this.txt_shtarakonesh);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_shtarakonesh.Text);
				}
				flag2 = sender.Equals(this.txt_vajhbank);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_vajhbank.Text);
				}
				flag2 = sender.Equals(this.txt_babat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babat.Text);
				}
				flag2 = sender.Equals(this.txt_shcheck);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Sh_Check", this.txt_shcheck.Text);
				}
				flag2 = sender.Equals(this.txt_shobe);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Check_Shobe", this.txt_shobe.Text);
				}
				flag2 = sender.Equals(this.txt_sarresid);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Check_Sarresid_Fa", this.txt_sarresid.Text);
				}
				flag2 = sender.Equals(this.txt_babatcheck);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_babatcheck.Text);
				}
				flag2 = sender.Equals(this.txt_fishbabat);
				if (flag2)
				{
					this.SetRowValue(gridEX, "Tozih", this.txt_fishbabat.Text);
				}
				flag2 = sender.Equals(this.txt_dbabatnc);
				if (flag2)
				{
					this.SetRowValue(gridEX, "tozih", this.txt_dbabatnc.Text);
				}
				flag2 = sender.Equals(this.txt_babatvariz);
				if (flag2)
				{
					this.SetRowValue(gridEX, "tozih", this.txt_babatvariz.Text);
				}
				flag2 = sender.Equals(this.txt_babat_takhfif);
				if (flag2)
				{
					this.SetRowValue(gridEX, "tozih", this.txt_babat_takhfif.Text);
				}
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00109D98 File Offset: 0x00107F98
		private void txt_bank_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_bank.Value != null;
				if (flag2)
				{
					((DataRowView)this.GridEX1.GetRow().DataRow)["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(this.txt_bank.Value);
					((DataRowView)this.GridEX1.GetRow().DataRow)["CheckBank_Name"] = this.txt_bank.Text;
				}
			}
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00109E38 File Offset: 0x00108038
		private void txt_fishbankhesab_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_fishbankhesab.Value != null;
				if (flag2)
				{
					((DataRowView)this.GridEX1.GetRow().DataRow)["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(this.txt_fishbankhesab.Value);
					((DataRowView)this.GridEX1.GetRow().DataRow)["BankHesab_Name"] = this.txt_fishbankhesab.Text;
				}
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00109ED8 File Offset: 0x001080D8
		private void txt_havale_bank_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.GridEX1.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_havale_bank.Value != null;
				if (flag2)
				{
					((DataRowView)this.GridEX1.GetRow().DataRow)["bemoshtari_id"] = RuntimeHelpers.GetObjectValue(this.txt_havale_bank.Value);
					((DataRowView)this.GridEX1.GetRow().DataRow)["beMoshtari_Name"] = this.txt_havale_bank.Text;
				}
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00109F78 File Offset: 0x00108178
		private void txt_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_tarikh_Validated(null, null);
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00109FA0 File Offset: 0x001081A0
		private void LoadData()
		{
			this.Sandug.SynckasrEzafe(this.txt_tarikh.Text);
			this.GetDataDaryaft();
			this.GetDataPardakht();
			this.ListDaryaft_Identity.Clear();
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(tarikh) from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			bool flag = num == 0;
			if (flag)
			{
				this.ButtonItem9.Visible = true;
				this.Label20.Text = string.Empty;
			}
			else
			{
				this.ButtonItem9.Visible = false;
				this.Label20.Text = Public_Function.FormatPrice(Conversions.ToString(Public_Function.ExecuteScalar("select mande from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)))));
			}
			DataRow dataRow = Public_Function.FillDataRow("select top 1 mande,Tarikh_Fa from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " order by tarikh desc ");
			flag = (dataRow != null);
			if (flag)
			{
				this.Label17.Text = Public_Function.FormatPrice(Conversions.ToString(dataRow["mande"]));
				this.Label16.Text = Conversions.ToString(Operators.ConcatenateObject("موجودی صندوق در تاریخ ", dataRow["tarikh_fa"]));
			}
			else
			{
				DataRow dataRow2 = Public_Function.FillDataRow("select bed from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				flag = (dataRow2 != null);
				if (flag)
				{
					this.Label17.Text = Public_Function.FormatPrice(Conversions.ToString(dataRow2["bed"]));
					this.Label16.Text = "موجودی اول دوره صندوق  ";
				}
				else
				{
					this.Label16.Text = string.Empty;
					this.Label17.Text = string.Empty;
				}
			}
			this.GridEX1.MoveLast();
			this.gridex2.MoveLast();
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0010A198 File Offset: 0x00108398
		private void load_tarikh()
		{
			this.tarikhemroz = this.txt_tarikh.Text;
			this.LoadData();
			bool flag = !this.home_clicked;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
			else
			{
				this.home_clicked = false;
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0010A20C File Offset: 0x0010840C
		private void txt_tarikh_Validated(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_tarikh.Text, this.tarikhemroz, false) != 0;
			if (flag)
			{
				bool flag2 = this.GridEX1.RowCount > 0 || this.gridex2.RowCount > 0;
				bool flag3;
				if (flag2)
				{
					flag3 = (Public_Function.ShowMessage("آیا مایل به ثبت اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
					if (flag3)
					{
						string text = this.txt_tarikh.Text;
						this.txt_tarikh.Text = this.tarikhemroz;
						this.ButtonItem2_Click(null, null);
						this.txt_tarikh.Text = text;
					}
				}
				flag3 = !this.Sandug.IsSandughBaste(this.txt_tarikh.Text);
				if (flag3)
				{
					this.load_tarikh();
				}
				else
				{
					flag3 = (this.Sandug.IsSandughBaste(this.txt_tarikh.Text) && (!Public_Function.dict.ContainsKey("sandugh_baste") || Conversions.ToDouble(Public_Function.dict["sandugh_baste"]) == 1.0));
					if (flag3)
					{
						this.load_tarikh();
					}
					else
					{
						flag3 = (this.Sandug.IsSandughBaste(this.txt_tarikh.Text) && Public_Function.dict.ContainsKey("sandugh_baste") && Conversions.ToDouble(Public_Function.dict["sandugh_baste"]) == 3.0);
						if (flag3)
						{
							flag3 = (new Frm_Password
							{
								Auth_type = 2
							}.ShowDialog() == DialogResult.OK);
							if (flag3)
							{
								this.load_tarikh();
							}
							else
							{
								this.txt_tarikh.Text = this.tarikhemroz;
							}
						}
					}
				}
			}
			else
			{
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0010A408 File Offset: 0x00108608
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = (UIGroupBox)this.Group_DnaghdCheck.Parent == this.Group_Letf;
			GridEX gridEX;
			if (flag)
			{
				gridEX = this.gridex2;
			}
			else
			{
				gridEX = this.GridEX1;
			}
			flag = (gridEX.CurrentRow.Cells["Moshtari_ID"].Value == DBNull.Value);
			checked
			{
				if (flag)
				{
					Public_Function.GridRaiseSoftError(gridEX, gridEX.CurrentRow, "Moshtari_Name", "مشتری را انتخاب نمایید");
				}
				else
				{
					flag = (Operators.CompareString(gridEX.CurrentRow.Cells["Mablagh"].Value.ToString(), string.Empty, false) == 0);
					if (flag)
					{
						Public_Function.GridRaiseSoftError(gridEX, gridEX.CurrentRow, "Mablagh", "مبلغ کل را وارد نمایید");
					}
					else
					{
						flag = ((UIGroupBox)this.Group_DnaghdCheck.Parent == this.Group_Letf);
						if (flag)
						{
							Frm_PardakhtCheck frm_PardakhtCheck = new Frm_PardakhtCheck();
							frm_PardakhtCheck.dt_daryaft = (DataTable)this.GridEX1.DataSource;
							frm_PardakhtCheck.ListDaryaft_Identity = this.ListDaryaft_Identity;
							frm_PardakhtCheck.Tarikh = this.txt_tarikh.Text;
							int position = gridEX.CurrentRow.Position;
							frm_PardakhtCheck.Mablagh_Kol = Conversions.ToLong(gridEX.CurrentRow.Cells["Mablagh"].Value);
							frm_PardakhtCheck.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
							frm_PardakhtCheck.Pardakht_Table = (DataTable)this.gridex2.DataSource;
							frm_PardakhtCheck.Moshtari_Name = Conversions.ToString(gridEX.CurrentRow.Cells["moshtari_name"].Value);
							frm_PardakhtCheck.lbl_codem.Text = Public_Function.ToFarsi(Conversions.ToString(gridEX.CurrentRow.Cells["Moshtari_ID"].Value));
							frm_PardakhtCheck.lbl_name.Text = Conversions.ToString(gridEX.CurrentRow.Cells["moshtari_name"].Value);
							MyProject.Forms.Form_Main.Dialog_ShowForm(frm_PardakhtCheck);
							gridEX.Row = position;
							this.CurrencyBox1.Text = Conversions.ToString(Operators.SubtractObject(gridEX.CurrentRow.Cells["Mablagh"].Value, frm_PardakhtCheck.sum_mablagh));
							this.CurrencyBox1_Validating(this.CurrencyBox1, null);
							this.txt_dbabatnc.Focus();
						}
						else
						{
							Frm_DaryaftCheck frm_DaryaftCheck = new Frm_DaryaftCheck();
							frm_DaryaftCheck.lbl_codem.Text = Public_Function.ToFarsi(Conversions.ToString(gridEX.CurrentRow.Cells["Moshtari_ID"].Value));
							frm_DaryaftCheck.lbl_name.Text = Conversions.ToString(gridEX.CurrentRow.Cells["moshtari_name"].Value);
							frm_DaryaftCheck.ListDaryaft_Identity = this.ListDaryaft_Identity;
							int position2 = gridEX.CurrentRow.Position;
							frm_DaryaftCheck.Pardakht_Table = (DataTable)this.gridex2.DataSource;
							frm_DaryaftCheck.Daryaft_Table = (DataTable)this.GridEX1.DataSource;
							frm_DaryaftCheck.Pardakht_Grid = this.gridex2;
							frm_DaryaftCheck.Mablagh_Kol = Conversions.ToLong(gridEX.CurrentRow.Cells["Mablagh"].Value);
							frm_DaryaftCheck.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
							List<int> list = new List<int>();
							frm_DaryaftCheck.del_lst = list;
							MyProject.Forms.Form_Main.Dialog_ShowForm(frm_DaryaftCheck);
							int num = 0;
							flag = (list.Count > 0);
							if (flag)
							{
								try
								{
									List<int>.Enumerator enumerator = list.GetEnumerator();
									while (enumerator.MoveNext())
									{
										int current = enumerator.Current;
										this.gridex2.GetRows()[current - num].Delete();
										num++;
									}
								}
								finally
								{
									List<int>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								((DataTable)this.gridex2.DataSource).AcceptChanges();
								this.gridex2.UpdateData();
							}
							gridEX.Row = position2;
							this.CurrencyBox1.Text = Conversions.ToString(Operators.SubtractObject(gridEX.CurrentRow.Cells["Mablagh"].Value, frm_DaryaftCheck.sum_mablagh));
							this.CurrencyBox1_Validating(this.CurrencyBox1, null);
							this.GridEX1_SelectionChanged(null, null);
							this.txt_dbabatnc.Focus();
						}
					}
				}
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0010A8B8 File Offset: 0x00108AB8
		private long GetJamKol()
		{
			int i = ((DataTable)this.GridEX1.DataSource).Rows.IndexOf(((DataRowView)this.GridEX1.CurrentRow.DataRow).Row);
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int num = Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["identity"]);
			long num2 = 0L;
			bool flag = Operators.CompareString(this.GridEX1.CurrentRow.Cells["Mablagh"].Value.ToString(), string.Empty, false) == 0;
			checked
			{
				long result;
				if (flag)
				{
					result = 0L;
				}
				else
				{
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
							if (flag)
							{
								num2 = (long)Math.Round(unchecked((double)num2 + Conversions.ToDouble(dataTable.Rows[i]["Mablagh"].ToString())));
							}
							i++;
						}
					}
					result = num2;
				}
				return result;
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0010AA24 File Offset: 0x00108C24
		private void CurrencyBox1_Validating(object sender, CancelEventArgs e)
		{
			bool flag = (UIGroupBox)this.Group_DnaghdCheck.Parent == this.Group_Right;
			GridEX gridEX;
			if (flag)
			{
				gridEX = this.GridEX1;
			}
			else
			{
				gridEX = this.gridex2;
			}
			flag = this.CurrencyBox1.Value.HasValue;
			checked
			{
				if (flag)
				{
					int i = ((DataTable)gridEX.DataSource).Rows.IndexOf(((DataRowView)gridEX.CurrentRow.DataRow).Row);
					flag = (i == -1);
					if (!flag)
					{
						DataTable dataTable = (DataTable)gridEX.DataSource;
						int num = Conversions.ToInteger(((DataRowView)gridEX.CurrentRow.DataRow)["identity"]);
						long num2 = 0L;
						long? value = this.CurrencyBox1.Value;
						bool? arg_F0_0;
						if (!value.HasValue)
						{
							arg_F0_0 = null;
						}
						else
						{
							bool? flag2 = new bool?(value.GetValueOrDefault() > num2);
							arg_F0_0 = flag2;
						}
						bool? flag3 = arg_F0_0;
						flag = flag3.GetValueOrDefault();
						if (flag)
						{
							i++;
							bool flag4;
							while (i <= dataTable.Rows.Count - 1)
							{
								flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
								if (flag)
								{
									i++;
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
									if (flag)
									{
										flag4 = (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 1, false) || Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 10, false));
										if (flag4)
										{
											dataTable.Rows[i]["mablagh"] = this.CurrencyBox1.Value;
											return;
										}
									}
									i++;
								}
							}
							i = ((DataTable)gridEX.DataSource).Rows.IndexOf(((DataRowView)gridEX.CurrentRow.DataRow).Row);
							i++;
							DataRow dataRow = dataTable.NewRow();
							object expr_256 = dataTable.Rows[i - 1]["Moshtari_ID"];
							int? num4;
							int? num3 = (expr_256 != null) ? ((int?)expr_256) : num4;
							string value2 = Conversions.ToString(dataTable.Rows[i - 1]["Moshtari_Name"]);
							dataRow["Moshtari_Name"] = value2;
							dataRow["Moshtari_ID"] = num3;
							dataRow["Mablagh"] = this.CurrencyBox1.Value;
							flag4 = (gridEX == this.GridEX1);
							if (flag4)
							{
								dataRow["dp_Name"] = "دریافت نقدی";
								dataRow["dptype_id"] = 1;
							}
							else
							{
								dataRow["dp_name"] = "پرداخت نقدی";
								dataRow["dptype_id"] = 10;
							}
							dataRow["is_child"] = true;
							dataRow["parent_identity"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i - 1]["identity"]);
							dataTable.Rows.InsertAt(dataRow, i);
						}
						else
						{
							i++;
							while (i <= dataTable.Rows.Count - 1)
							{
								bool flag4 = dataTable.Rows[i]["parent_identity"] == DBNull.Value;
								if (flag4)
								{
									i++;
								}
								else
								{
									flag4 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
									if (flag4)
									{
										flag = (gridEX == this.GridEX1);
										if (flag)
										{
											bool flag5 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 1, false);
											if (flag5)
											{
												dataTable.Rows[i].Delete();
												dataTable.AcceptChanges();
											}
										}
										else
										{
											bool flag5 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 10, false);
											if (flag5)
											{
												dataTable.Rows[i].Delete();
												dataTable.AcceptChanges();
											}
										}
									}
									i++;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0010AECC File Offset: 0x001090CC
		private void GetPardakhtCheck_IDs(GridEXRow row, ref string PardakhtCheckIDS, ref string IDS)
		{
			DataTable dataTable = (DataTable)this.gridex2.DataSource;
			DataRowView dataRowView = (DataRowView)this.gridex2.CurrentRow.DataRow;
			int i = dataTable.Rows.IndexOf(dataRowView.Row);
			bool flag = ((DataRowView)row.DataRow)["ID"] == DBNull.Value;
			checked
			{
				if (!flag)
				{
					long num = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
					IDS = IDS + Conversions.ToString(num) + ",";
					flag = (i >= dataTable.Rows.Count);
					if (!flag)
					{
						string text = string.Empty;
						while (i <= dataTable.Rows.Count - 1)
						{
							flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
							if (flag)
							{
								i++;
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
								if (flag)
								{
									bool flag2 = dataTable.Rows[i]["PardakhtCheck_ID"] != DBNull.Value;
									if (flag2)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataTable.Rows[i]["PardakhtCheck_ID"], ",")));
										IDS = Conversions.ToString(Operators.ConcatenateObject(IDS, Operators.ConcatenateObject(dataTable.Rows[i]["ID"], ",")));
									}
								}
								i++;
							}
						}
						text = Public_Function.RemoveLast(text);
						IDS = Public_Function.RemoveLast(IDS);
						PardakhtCheckIDS = text;
					}
				}
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0010B0A8 File Offset: 0x001092A8
		private string GetCheckIDs(GridEXRow row)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			int i = dataTable.Rows.IndexOf(dataRowView.Row);
			bool flag = ((DataRowView)row.DataRow)["ID"] == DBNull.Value;
			checked
			{
				string result;
				if (flag)
				{
					result = string.Empty;
				}
				else
				{
					long num = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
					flag = (i >= dataTable.Rows.Count);
					if (flag)
					{
						result = string.Empty;
					}
					else
					{
						string text = string.Empty;
						while (i <= dataTable.Rows.Count - 1)
						{
							flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
							if (flag)
							{
								i++;
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
								if (flag)
								{
									bool flag2 = dataTable.Rows[i]["ID"] != DBNull.Value;
									if (flag2)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataTable.Rows[i]["id"], ",")));
									}
								}
								i++;
							}
						}
						text = Public_Function.RemoveLast(text);
						result = text;
					}
				}
				return result;
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0010B24C File Offset: 0x0010944C
		private void GetChackeUsageInPardakhtForDaryaft(GridEXRow row, DataTable dt2)
		{
			long num = Conversions.ToLong(((DataRowView)row.DataRow)["Identity"]);
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			DataTable dataTable = (DataTable)row.GridEX.DataSource;
			DataTable dataTable2 = (DataTable)this.gridex2.DataSource;
			int i = dataTable.Rows.IndexOf(dataRowView.Row);
			bool flag = i >= dataTable.Rows.Count;
			checked
			{
				if (!flag)
				{
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
							if (flag)
							{
								bool flag2 = dataTable.Rows[i]["ID"] != DBNull.Value;
								DataRow[] array;
								if (flag2)
								{
									array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("pardakhtcheck_id=", dataTable.Rows[i]["ID"]), " AND ID IS NULL")));
								}
								else
								{
									array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("daryaft_identity=", dataTable.Rows[i]["identity"]), " AND ID IS NULL")));
								}
								DataRow[] array2 = array;
								for (int j = 0; j < array2.Length; j++)
								{
									DataRow dataRow = array2[j];
									DataRow dataRow2 = dt2.NewRow();
									dataRow2["sh_check"] = RuntimeHelpers.GetObjectValue(dataRow["sh_Check"]);
									dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
									dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh_Fa"]);
									dataRow2["opr_name"] = RuntimeHelpers.GetObjectValue(dataRow["dp_name"]);
									dataRow2["Pardakht_identity"] = RuntimeHelpers.GetObjectValue(dataRow["identity"]);
									dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_identity"]);
									dt2.Rows.Add(dataRow2);
								}
							}
							i++;
						}
					}
				}
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0010B4F8 File Offset: 0x001096F8
		private void GetChackeUsageInPardakhtForPardakht(GridEXRow row, DataTable dt2)
		{
			long num = Conversions.ToLong(((DataRowView)row.DataRow)["Identity"]);
			DataRowView dataRowView = (DataRowView)this.gridex2.CurrentRow.DataRow;
			DataTable dataTable = (DataTable)this.gridex2.DataSource;
			int i = dataTable.Rows.IndexOf(dataRowView.Row);
			bool flag = i >= dataTable.Rows.Count;
			checked
			{
				if (!flag)
				{
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
							if (flag)
							{
								bool flag2 = dataTable.Rows[i]["pardakhtcheck_id"] != DBNull.Value;
								bool flag3;
								DataRow[] array;
								if (flag2)
								{
									flag3 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[i]["pardakhtcheck_id"], 0, false);
									if (flag3)
									{
										array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("pardakhtcheck_id=", dataTable.Rows[i]["pardakhtcheck_id"]), " and dptype_id<>"), dataTable.Rows[i]["dptype_id"]), " AND ID IS NULL")));
									}
									else
									{
										array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("daryaft_identity=", dataTable.Rows[i]["daryaft_identity"]), " and dptype_id<>"), dataTable.Rows[i]["dptype_id"]), " AND ID IS NULL")));
									}
								}
								flag3 = (array != null);
								if (flag3)
								{
									DataRow[] array2 = array;
									for (int j = 0; j < array2.Length; j++)
									{
										DataRow dataRow = array2[j];
										flag2 = (dataTable.Rows.IndexOf(dataRow) > i);
										if (flag2)
										{
											DataRow dataRow2 = dt2.NewRow();
											dataRow2["sh_check"] = RuntimeHelpers.GetObjectValue(dataRow["sh_Check"]);
											dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
											dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh_Fa"]);
											dataRow2["opr_name"] = RuntimeHelpers.GetObjectValue(dataRow["dp_name"]);
											dataRow2["Pardakht_identity"] = RuntimeHelpers.GetObjectValue(dataRow["identity"]);
											dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_identity"]);
											dt2.Rows.Add(dataRow2);
										}
									}
								}
							}
							i++;
						}
					}
				}
			}
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0010B838 File Offset: 0x00109A38
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataTable dataTable = (DataTable)this.gridex2.DataSource;
			DataRowView dataRowView = (DataRowView)this.gridex2.CurrentRow.DataRow;
			int i = dataTable.Rows.IndexOf(dataRowView.Row);
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			checked
			{
				if (flag)
				{
					List<string> list = new List<string>();
					string text = string.Empty;
					string text2 = string.Empty;
					long num = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
					text2 = Conversions.ToString(num) + ",";
					flag = (dataRowView["dptype_id"] != DBNull.Value);
					bool flag3;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 15, false);
						if (flag2)
						{
							flag3 = (dataRowView["pardakhtcheck_id"] != DBNull.Value);
							if (flag3)
							{
								list.Add(Conversions.ToString(dataRowView["pardakhtcheck_id"]));
							}
						}
					}
					dataTable.Rows[i].Delete();
					dataTable.AcceptChanges();
					while (i <= dataTable.Rows.Count - 1)
					{
						flag3 = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
						if (flag3)
						{
							i++;
						}
						else
						{
							flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
							if (flag3)
							{
								bool flag2 = dataTable.Rows[i]["id"] != DBNull.Value;
								if (flag2)
								{
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataTable.Rows[i]["id"], ",")));
								}
								flag3 = (dataTable.Rows[i]["Pardakhtcheck_ID"] != DBNull.Value);
								if (flag3)
								{
									list.Add(Conversions.ToString(dataTable.Rows[i]["PardakhtCheck_ID"]));
								}
								dataTable.Rows[i].Delete();
								dataTable.AcceptChanges();
							}
							else
							{
								i++;
							}
						}
					}
					text2 = Public_Function.RemoveLast(text2);
					DataTable dt = Public_Function.FillData("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + text2 + ")");
					text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + text2 + ");";
					text = text + "delete from daryaftpardakht where id in(" + text2 + ");";
					text2 = Public_Function.GetID(dt, "sanadbed_id", "");
					flag3 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag3)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text2 = Public_Function.GetID(dt, "sanadbes_id", "");
					flag3 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag3)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					Public_Function.ExecuteNonQuery(text);
					try
					{
						List<string>.Enumerator enumerator = list.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							text = string.Concat(new string[]
							{
								"   declare @st int;    declare @barg_id int;    select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=",
								current,
								" order by id desc;  if @st is null begin   select top 1  @barg_id=checkbarg_id from daryaftpardakht where id=",
								current,
								" ;   if @barg_id is null  set @st=1;    else  set @st=5;   End  update daryaftpardakht set check_status=@st where id=",
								current,
								";"
							});
							Public_Function.ExecuteNonQuery(text);
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				else
				{
					long num = Conversions.ToLong(((DataRowView)row.DataRow)["Identity"]);
					dataTable.Rows[i].Delete();
					dataTable.AcceptChanges();
					bool flag3 = i >= dataTable.Rows.Count;
					if (!flag3)
					{
						while (i <= dataTable.Rows.Count - 1)
						{
							flag3 = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
							if (flag3)
							{
								i++;
							}
							else
							{
								flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
								if (flag3)
								{
									dataTable.Rows[i].Delete();
									dataTable.AcceptChanges();
								}
								else
								{
									i++;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0010BD0C File Offset: 0x00109F0C
		private void DeleteDaryaftRadif(GridEXRow row)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			int i = dataTable.Rows.IndexOf(dataRowView.Row);
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			checked
			{
				if (flag)
				{
					string text = string.Empty;
					string text2 = string.Empty;
					long num = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
					text2 = Conversions.ToString(num) + ",";
					dataTable.Rows[i].Delete();
					dataTable.AcceptChanges();
					bool flag2;
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
							if (flag)
							{
								flag2 = (dataTable.Rows[i]["id"] != DBNull.Value);
								if (flag2)
								{
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataTable.Rows[i]["id"], ",")));
									flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 26, false);
									if (flag2)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("update daryaftpardakht set check_status=1 where id=", dataTable.Rows[i]["pardakhtcheck_id"])));
									}
								}
								dataTable.Rows[i].Delete();
								dataTable.AcceptChanges();
							}
							else
							{
								i++;
							}
						}
					}
					text2 = Public_Function.RemoveLast(text2);
					DataTable dt = Public_Function.FillData("select sanadbed_id,sanadbes_id,sh_fish from daryaftpardakht where id in(" + text2 + ")");
					text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + text2 + ");";
					text = text + "delete from daryaftpardakht where id in(" + text2 + ");";
					text2 = Public_Function.GetID(dt, "sanadbed_id", "");
					flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag2)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text2 = Public_Function.GetID(dt, "sanadbes_id", "");
					flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag2)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text2 = Public_Function.GetID(dt, "sh_fish", "");
					flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag2)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					Public_Function.ExecuteNonQuery(text);
				}
				else
				{
					long num = Conversions.ToLong(((DataRowView)row.DataRow)["Identity"]);
					dataTable.Rows[i].Delete();
					dataTable.AcceptChanges();
					bool flag2 = i >= dataTable.Rows.Count;
					if (!flag2)
					{
						while (i <= dataTable.Rows.Count - 1)
						{
							flag2 = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
							if (flag2)
							{
								i++;
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
								if (flag2)
								{
									dataTable.Rows[i].Delete();
									dataTable.AcceptChanges();
								}
								else
								{
									i++;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0010C120 File Offset: 0x0010A320
		private void GetCheckUsagePardakht(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			string text = string.Empty;
			string text2 = string.Empty;
			this.GetPardakhtCheck_IDs(row, ref text, ref text2);
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = "-1";
			}
			flag = (Operators.CompareString(text2, string.Empty, false) == 0);
			if (flag)
			{
				text2 = "-1";
			}
			string text3 = string.Empty;
			flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
			if (flag)
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(" AND DaryaftPardakht.ID>", ((DataRowView)row.DataRow)["ID"]));
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
			DataTable dataTable2 = (DataTable)this.gridex2.DataSource;
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
					MyProject.Forms.Form_Main.Get_sarresid_Pardakht();
					MyProject.Forms.Form_Main.Get_Sarresid();
					long num = this.Sandug.SynckasrEzafe(this.txt_tarikh.Text);
					DataRow[] array = ((DataTable)this.GridEX1.DataSource).Select("dptype_id=5");
					DataRow[] array2 = ((DataTable)this.gridex2.DataSource).Select("dptype_id=16");
					flag = (num == 0L);
					bool flag2;
					if (flag)
					{
						flag2 = (array.Length > 0);
						if (flag2)
						{
							array[0].Delete();
							array[0].Table.AcceptChanges();
						}
						flag2 = (array2.Length > 0);
						if (flag2)
						{
							array2[0].Delete();
							array2[0].Table.AcceptChanges();
						}
					}
					flag2 = (num > 0L);
					if (flag2)
					{
						flag = (array2.Length > 0);
						if (flag)
						{
							array2[0].Delete();
							array2[0].Table.AcceptChanges();
						}
						flag2 = (array.Length > 0);
						if (flag2)
						{
							array[0]["Mablagh"] = num;
							array[0].AcceptChanges();
						}
						else
						{
							DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
							dataRow["dptype_id"] = 5;
							dataRow["Mablagh"] = num;
							dataRow["Moshtari_id"] = -1;
							dataRow["Sandug_ID"] = 1;
							dataRow["Moshtari_Name"] = "نقدی";
							dataRow["dp_name"] = "افزایش صندوق";
							((DataTable)this.GridEX1.DataSource).Rows.Add(dataRow);
						}
					}
					flag2 = (num < 0L);
					if (flag2)
					{
						flag = (array.Length > 0);
						if (flag)
						{
							array[0].Delete();
							array[0].Table.AcceptChanges();
						}
						flag2 = (array2.Length > 0);
						if (flag2)
						{
							array2[0]["Mablagh"] = Math.Abs(num);
							array2[0].AcceptChanges();
						}
						else
						{
							DataRow dataRow2 = ((DataTable)this.gridex2.DataSource).NewRow();
							dataRow2["dptype_id"] = 16;
							dataRow2["Mablagh"] = Math.Abs(num);
							dataRow2["Moshtari_id"] = -1;
							dataRow2["Sandug_ID"] = 1;
							dataRow2["Moshtari_Name"] = "نقدی";
							dataRow2["dp_name"] = "کاهش صندوق";
							((DataTable)this.gridex2.DataSource).Rows.Add(dataRow2);
						}
					}
				}
			}
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0010C594 File Offset: 0x0010A794
		private void GetCheckUsage(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			bool flag = ((DataRowView)row.DataRow)["ID"] == DBNull.Value;
			if (!flag)
			{
				long num = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
			}
			string text = this.GetCheckIDs(row);
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			if (flag)
			{
				text = "-1";
			}
			dataTable = Public_Function.FillData("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Sh_Check, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type in(2,-99) and DaryaftPardakht.pardakhtcheck_id in(" + text + ")");
			DataTable dataTable2 = (DataTable)this.gridex2.DataSource;
			this.GetChackeUsageInPardakhtForDaryaft(row, dataTable);
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
					this.DeleteDaryaftRadif(row);
					long num2 = this.Sandug.SynckasrEzafe(this.txt_tarikh.Text);
					DataRow[] array = ((DataTable)this.GridEX1.DataSource).Select("dptype_id=5");
					DataRow[] array2 = ((DataTable)this.gridex2.DataSource).Select("dptype_id=16");
					flag = (num2 == 0L);
					bool flag2;
					if (flag)
					{
						flag2 = (array.Length > 0);
						if (flag2)
						{
							array[0].Delete();
							array[0].Table.AcceptChanges();
						}
						flag2 = (array2.Length > 0);
						if (flag2)
						{
							array2[0].Delete();
							array2[0].Table.AcceptChanges();
						}
					}
					flag2 = (num2 > 0L);
					if (flag2)
					{
						flag = (array2.Length > 0);
						if (flag)
						{
							array2[0].Delete();
							array2[0].Table.AcceptChanges();
						}
						flag2 = (array.Length > 0);
						if (flag2)
						{
							array[0]["Mablagh"] = num2;
							array[0].AcceptChanges();
						}
						else
						{
							DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
							dataRow["dptype_id"] = 5;
							dataRow["Mablagh"] = num2;
							dataRow["Moshtari_id"] = -1;
							dataRow["Sandug_ID"] = 1;
							dataRow["Moshtari_Name"] = "نقدی";
							dataRow["dp_name"] = "افزایش صندوق";
							((DataTable)this.GridEX1.DataSource).Rows.Add(dataRow);
						}
					}
					flag2 = (num2 < 0L);
					if (flag2)
					{
						flag = (array.Length > 0);
						if (flag)
						{
							array[0].Delete();
							array[0].Table.AcceptChanges();
						}
						flag2 = (array2.Length > 0);
						if (flag2)
						{
							array2[0]["Mablagh"] = Math.Abs(num2);
							array2[0].AcceptChanges();
						}
						else
						{
							DataRow dataRow2 = ((DataTable)this.gridex2.DataSource).NewRow();
							dataRow2["dptype_id"] = 16;
							dataRow2["Mablagh"] = Math.Abs(num2);
							dataRow2["Moshtari_id"] = -1;
							dataRow2["Sandug_ID"] = 1;
							dataRow2["Moshtari_Name"] = "نقدی";
							dataRow2["dp_name"] = "کاهش صندوق";
							((DataTable)this.gridex2.DataSource).Rows.Add(dataRow2);
						}
					}
				}
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0010C97C File Offset: 0x0010AB7C
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			if (!flag)
			{
				flag = (this.GridEX1.Row == -1);
				if (flag)
				{
					this.GridEX1.CancelCurrentEdit();
					this.GridEX1.Focus();
					this.GridEX1.MoveToNewRecord();
					this.GridEX1.Col = 0;
					this.GridEX1.EditMode = EditMode.EditOn;
				}
				else
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
					flag = (dataRowView == null);
					if (!flag)
					{
						int num = dataTable.Rows.IndexOf(dataRowView.Row);
						flag = (num == -1);
						if (!flag)
						{
							flag = (dataRowView["dptype_id"] != DBNull.Value);
							bool flag2;
							if (flag)
							{
								flag2 = Operators.ConditionalCompareObjectLess(dataRowView["dptype_id"], 0, false);
								if (flag2)
								{
									return;
								}
								flag2 = Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 5, false);
								if (flag2)
								{
									return;
								}
							}
							this.GetCheckUsage(this.GridEX1.CurrentRow);
							flag2 = (this.GridEX1.Row == -1);
							if (flag2)
							{
								this.GridEX1.CancelCurrentEdit();
								this.GridEX1.Focus();
								this.GridEX1.MoveToNewRecord();
								this.GridEX1.Col = 0;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
							else
							{
								this.GridEX1.Col = 2;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0010CB34 File Offset: 0x0010AD34
		private void dp_select_Pardakht()
		{
			bool flag = this.gridex2.GetRow().Cells["dptype_Id"].Value != DBNull.Value;
			bool flag2;
			if (flag)
			{
				bool arg_C4_0;
				if (!Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_Id"].Value, -2, false) && !Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_Id"].Value, -3, false))
				{
					if (!Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_Id"].Value, 16, false))
					{
						arg_C4_0 = false;
						goto IL_C3;
					}
				}
				arg_C4_0 = true;
				IL_C3:
				flag2 = arg_C4_0;
				if (flag2)
				{
					return;
				}
			}
			flag2 = this.prevent_mablagh;
			checked
			{
				if (flag2)
				{
					this.prevent_mablagh = false;
				}
				else
				{
					this.prevent = true;
					bool flag3 = false;
					flag2 = (this.gridex2.GetRow().Cells["dptype_Id"].Value != DBNull.Value);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_Id"].Value, 13, false);
						if (flag)
						{
							flag3 = true;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_Id"].Value, 17, false);
						if (flag2)
						{
							flag3 = true;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_Id"].Value, 19, false);
						if (flag2)
						{
							flag3 = true;
						}
					}
					DataTable dt = Public_Function.FillData("select id,Code,Name  from dptype where type=2 and visible=1 order by code");
					((ItemCollection)this.frm.items)[0].Name = "code";
					flag2 = (this.frm.ShowDialog(dt, null, "انتخاب نوع پرداخت") == DialogResult.OK);
					if (flag2)
					{
						this.group_dcheck.Visible = false;
						this.group_dfish.Visible = false;
						this.group_dnaghd.Visible = false;
						this.Group_DnaghdCheck.Visible = false;
						this.Group_VarizCheck.Visible = false;
						this.Group_kart_be_Kart.Visible = false;
						this.Group_Bank_Hazine.Visible = false;
						this.Group_Gest.Visible = false;
						this.Group_Hazine.Visible = false;
						this.Group_Takhfif.Visible = false;
						this.group_moshtari_be_moshtari.Visible = false;
						this.group_phavale_arzi.Visible = false;
						flag2 = (this.gridex2.Col == this.gridex2.RootTable.Columns["dp_Name"].Position);
						if (flag2)
						{
							flag = (Operators.ConditionalCompareObjectNotEqual(this.frm.SelectedRow["ID"], 13, false) && flag3);
							if (flag)
							{
								this.dpchenge(this.gridex2);
							}
							flag2 = (Operators.ConditionalCompareObjectNotEqual(this.frm.SelectedRow["ID"], 17, false) && flag3);
							if (flag2)
							{
								this.dpchenge(this.gridex2);
							}
							flag2 = (Operators.ConditionalCompareObjectNotEqual(this.frm.SelectedRow["ID"], 19, false) && flag3);
							if (flag2)
							{
								this.dpchenge(this.gridex2);
							}
							flag2 = (Operators.ConditionalCompareObjectNotEqual(this.frm.SelectedRow["ID"], 21, false) && flag3);
							if (flag2)
							{
								this.dpchenge(this.gridex2);
							}
							this.gridex2.EditMode = EditMode.EditOn;
							this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
							this.gridex2.GetRow().Cells["dptype_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.Custom;
							object left = this.frm.SelectedRow["ID"];
							flag2 = Operators.ConditionalCompareObjectEqual(left, 10, false);
							DataEntryGrid gridex;
							if (flag2)
							{
								this.group_dnaghd.Visible = true;
								this.group_dnaghd.BringToFront();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, 15, false);
								if (flag2)
								{
									this.Group_Hazine.Visible = true;
									this.Group_Hazine.BringToFront();
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left, 29, false);
									if (flag2)
									{
										this.Group_kart_be_Kart.Visible = true;
										this.Group_kart_be_Kart.BringToFront();
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(left, 14, false);
										if (flag2)
										{
											this.Group_BankVajh.Visible = true;
											this.Group_BankVajh.BringToFront();
										}
										else
										{
											flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 11, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 12, false))) ? true : false);
											if (flag2)
											{
												this.group_dcheck.Visible = true;
												this.group_dcheck.BringToFront();
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left, 13, false);
												if (flag2)
												{
													this.Group_DnaghdCheck.Visible = true;
													this.Group_DnaghdCheck.BringToFront();
													this.Label25.Visible = true;
													this.txt_moshtariHesab.Visible = true;
													this.UiButton6.Visible = true;
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left, 17, false);
													if (flag2)
													{
														this.Group_VarizCheck.Visible = true;
														this.Group_VarizCheck.BringToFront();
														this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
														flag2 = (Operators.CompareString(this.vagozari_bankhesab_Name, string.Empty, false) != 0);
														if (flag2)
														{
															gridex = this.gridex2;
															gridex.Col++;
															this.gridex2.EditMode = EditMode.EditOn;
															this.gridex2.EditTextBox.Text = this.vagozari_bankhesab_Name;
															this.gridex2.CurrentRow.Cells["moshtari_name"].Text = this.vagozari_bankhesab_Name;
															this.gridex2.CurrentRow.Cells["moshtari_id"].Value = this.vagozari_bankhesab_id;
															this.UiButton2.Focus();
															this.frm.CanEdit = false;
															this.frm.Edit_Frm = null;
															this.UiButton2_Click(null, null);
															return;
														}
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left, 19, false);
														if (flag2)
														{
															this.Group_VarizCheck.Visible = true;
															this.Group_VarizCheck.BringToFront();
															this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
															this.gridex2.CurrentRow.Cells["Moshtari_Name"].EditType = EditType.NoEdit;
															this.UiButton2.Focus();
															this.UiButton2_Click(null, null);
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left, 21, false);
															if (flag2)
															{
																this.Group_VarizCheck.Visible = true;
																this.Group_VarizCheck.BringToFront();
																this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
																this.gridex2.CurrentRow.Cells["Moshtari_Name"].EditType = EditType.NoEdit;
																this.UiButton2.Focus();
																this.UiButton2_Click(null, null);
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left, 30, false);
																if (flag2)
																{
																	this.Group_Bank_Hazine.Visible = true;
																	this.Group_Bank_Hazine.BringToFront();
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left, 31, false);
																	if (flag2)
																	{
																		this.Group_Bank_To_Bank.Visible = true;
																		this.Group_Bank_To_Bank.BringToFront();
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left, 32, false);
																		if (flag2)
																		{
																			this.group_dnaghd.Visible = true;
																			this.group_dnaghd.BringToFront();
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(left, 37, false);
																			if (flag2)
																			{
																				this.Group_Gest.Visible = true;
																				this.Group_Gest.BringToFront();
																			}
																			else
																			{
																				flag2 = Operators.ConditionalCompareObjectEqual(left, 38, false);
																				if (flag2)
																				{
																					this.Group_PardakhtTankhah.Visible = true;
																					this.Group_PardakhtTankhah.BringToFront();
																				}
																				else
																				{
																					flag2 = Operators.ConditionalCompareObjectEqual(left, 39, false);
																					if (flag2)
																					{
																						this.group_moshtari_be_moshtari.Visible = true;
																						this.group_moshtari_be_moshtari.BringToFront();
																					}
																					else
																					{
																						flag2 = Operators.ConditionalCompareObjectEqual(left, 44, false);
																						if (flag2)
																						{
																							this.group_phavale_arzi.Visible = true;
																							this.group_phavale_arzi.BringToFront();
																						}
																						else
																						{
																							flag2 = Operators.ConditionalCompareObjectEqual(left, 45, false);
																							if (flag2)
																							{
																								this.Group_Takhfif.Visible = true;
																								this.Group_Takhfif.BringToFront();
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
											}
										}
									}
								}
							}
							gridex = this.gridex2;
							gridex.Col++;
							this.gridex2.EditMode = EditMode.EditOn;
						}
					}
					((ItemCollection)this.frm.items)[0].Name = "ID";
				}
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0010D578 File Offset: 0x0010B778
		private void GetDataPardakht()
		{
			DataTable pardakhtByDate = this.dp.GetPardakhtByDate(this.txt_tarikh.Text);
			pardakhtByDate.Columns.Add("is_child", typeof(bool));
			pardakhtByDate.Columns["is_child"].AllowDBNull = true;
			pardakhtByDate.Columns.Add("identity", typeof(int));
			pardakhtByDate.Columns["identity"].AutoIncrement = true;
			pardakhtByDate.Columns.Add("parent_identity", typeof(int));
			bool flag;
			try
			{
				IEnumerator enumerator = pardakhtByDate.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["identity"] = RuntimeHelpers.GetObjectValue(dataRow["id"]);
					dataRow["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["parent_id"]);
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
			this.origin_pardakht = pardakhtByDate.Copy();
			pardakhtByDate.AcceptChanges();
			this.gridex2.DataSource = pardakhtByDate;
			long num = this.Sandug.PardakhtNaghd(this.txt_tarikh.Text);
			flag = (num == 0L);
			if (flag)
			{
				this.lbl_pardakhti.Text = Public_Function.ToFarsi(Conversions.ToString(0));
			}
			else
			{
				this.lbl_pardakhti.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num)));
			}
			this.LoadToSearchdt(pardakhtByDate, this.dt_search2);
			this.Metro_Right.Refresh();
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0010D744 File Offset: 0x0010B944
		private void gridex2_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.gridex2.RootTable.Columns["dp_name"].Position;
			if (flag)
			{
				this.dp_select_Pardakht();
			}
			else
			{
				flag = (position == this.gridex2.RootTable.Columns["Moshtari_Name"].Position);
				if (flag)
				{
					this.Moshtari_selectPardakht();
				}
			}
			this.prevent = false;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0010D7C8 File Offset: 0x0010B9C8
		private void GridEX2_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				bool flag2 = this.gridex2.CurrentRow == null;
				if (!flag2)
				{
					flag2 = (this.gridex2.CurrentRow.Cells["dptype_id"].Value == DBNull.Value);
					if (!flag2)
					{
						flag2 = (this.gridex2.CurrentRow.Cells["mablagh"].Value == DBNull.Value);
						if (!flag2)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 13, false);
							if (flag2)
							{
								int sum_Check = this.GetSum_Check();
								flag2 = Operators.ConditionalCompareObjectGreater(sum_Check, this.gridex2.CurrentRow.Cells["Mablagh"].Value, false);
								if (flag2)
								{
									Public_Function.ShowMessage("مبلغ وارد شده کمتر از مبلغ چک ها میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
									this.gridex2.CurrentRow.CancelEdit();
								}
								else
								{
									this.CurrencyBox1.Text = Operators.SubtractObject(this.gridex2.CurrentRow.Cells["Mablagh"].Value, sum_Check).ToString();
									this.CurrencyBox1.Value = Conversions.ToLong(Operators.SubtractObject(this.gridex2.CurrentRow.Cells["Mablagh"].Value, sum_Check).ToString());
									this.CurrencyBox1.Refresh();
									this.CurrencyBox1.Update();
									this.CurrencyBox1_Validating(this.CurrencyBox1, null);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0010D9AC File Offset: 0x0010BBAC
		private void GridEX2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.gridex2.Row == -1;
				if (flag2)
				{
					flag3 = (this.gridex2.EditTextBox != null);
					if (flag3)
					{
						this.gridex2.EditTextBox.Text = string.Empty;
					}
				}
				else
				{
					flag3 = (this.gridex2.Col == 0);
					if (flag3)
					{
						e.SuppressKeyPress = true;
					}
					else
					{
						flag3 = (this.gridex2.EditTextBox != null);
						if (flag3)
						{
							this.gridex2.EditTextBox.Text = string.Empty;
						}
					}
				}
			}
			Keys keyData = e.KeyData;
			flag3 = (keyData == Keys.Tab);
			checked
			{
				if (flag3)
				{
					this.GridEX1.Focus();
					this.GridEX1.Row = -1;
					this.GridEX1.Col = 0;
					this.GridEX1.EditMode = EditMode.EditOn;
				}
				else
				{
					flag3 = (keyData == Keys.Up);
					if (flag3)
					{
						bool flag2 = this.gridex2.Row > 0;
						if (flag2)
						{
							DataEntryGrid gridex = this.gridex2;
							gridex.Row--;
							this.gridex2.EditMode = EditMode.EditOn;
							e.SuppressKeyPress = true;
							return;
						}
						this.gridex2.MoveToNewRecord();
						this.gridex2.Col = 0;
						this.gridex2.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
					}
					else
					{
						flag3 = (keyData == Keys.Down);
						if (flag3)
						{
							bool flag2 = this.gridex2.Row < this.gridex2.RowCount - 1;
							if (flag2)
							{
								DataEntryGrid gridex = this.gridex2;
								gridex.Row++;
								this.gridex2.EditMode = EditMode.EditOn;
								e.SuppressKeyPress = true;
								return;
							}
						}
						else
						{
							flag3 = (keyData == Keys.Left);
							if (flag3)
							{
								DataEntryGrid gridex = this.gridex2;
								gridex.Col++;
								this.gridex2.EditMode = EditMode.EditOn;
								e.SuppressKeyPress = true;
								return;
							}
							flag3 = (keyData == Keys.Right);
							if (flag3)
							{
								bool flag2 = this.gridex2.Col > 0;
								if (flag2)
								{
									DataEntryGrid gridex = this.gridex2;
									gridex.Col--;
									this.gridex2.EditMode = EditMode.EditOn;
									e.SuppressKeyPress = true;
									return;
								}
								this.GridEX1.Focus();
								this.GridEX1.MoveToNewRecord();
								this.GridEX1.Col = 0;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
					}
				}
				flag3 = (e.KeyCode == Keys.Return);
				if (flag3)
				{
					int col = this.gridex2.Col;
					bool flag2 = col == this.gridex2.RootTable.Columns["Moshtari_Name"].Position;
					if (flag2)
					{
						flag = (this.gridex2.EditTextBox == null);
						if (flag)
						{
							return;
						}
						flag3 = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
						if (flag3)
						{
							flag2 = (this.gridex2.CurrentRow.Cells["dp_name"].Value == DBNull.Value);
							if (flag2)
							{
								this.gridex2.Col = this.gridex2.RootTable.Columns["dp_name"].Position;
								this.gridex2.EditMode = EditMode.EditOn;
								return;
							}
							this.Moshtari_selectPardakht();
							this.prevent = false;
						}
						else
						{
							flag3 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 17, false);
							if (flag3)
							{
								this.UiButton2.Focus();
							}
							else
							{
								DataEntryGrid gridex = this.gridex2;
								gridex.Col++;
								this.gridex2.EditMode = EditMode.EditOn;
							}
						}
					}
					else
					{
						flag3 = (col == this.gridex2.RootTable.Columns["dp_Name"].Position);
						if (flag3)
						{
							flag2 = (this.gridex2.EditTextBox == null);
							if (flag2)
							{
								return;
							}
							flag3 = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.dp_select_Pardakht();
								this.prevent = false;
								flag3 = (this.gridex2.EditTextBox == null);
								if (flag3)
								{
									return;
								}
								flag3 = (Operators.CompareString(this.gridex2.EditTextBox.Text, string.Empty, false) == 0);
								if (flag3)
								{
									flag2 = (this.gridex2.CurrentRow.Cells["dp_name"].Value == DBNull.Value);
									if (flag2)
									{
										this.gridex2.Col = this.gridex2.RootTable.Columns["dp_name"].Position;
										this.gridex2.EditMode = EditMode.EditOn;
										return;
									}
									this.Moshtari_selectPardakht();
									this.prevent = false;
								}
								else
								{
									flag3 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 17, false);
									if (flag3)
									{
										this.UiButton2.Focus();
									}
									else
									{
										DataEntryGrid gridex = this.gridex2;
										gridex.Col++;
										this.gridex2.EditMode = EditMode.EditOn;
									}
								}
							}
							else
							{
								flag3 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 21, false);
								if (flag3)
								{
									this.UiButton2.Focus();
								}
								else
								{
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
						}
						else
						{
							flag3 = (col == this.gridex2.RootTable.Columns["mablagh"].Position);
							if (!flag3)
							{
								DataEntryGrid gridex = this.gridex2;
								gridex.Col++;
								this.gridex2.EditMode = EditMode.EditOn;
							}
						}
					}
				}
				flag3 = (this.gridex2.Col == this.gridex2.RootTable.Columns["dp_name"].Position || this.gridex2.Col == this.gridex2.RootTable.Columns["Moshtari_Name"].Position);
				if (flag3)
				{
					e.SuppressKeyPress = true;
				}
			}
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0010E094 File Offset: 0x0010C294
		private void txt_mablaghpardakht_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.gridex2.GetRow().Cells["dptype_id"].Value == DBNull.Value;
				if (flag2)
				{
					this.gridex2.Col = this.gridex2.RootTable.Columns["dp_name"].Position;
					this.gridex2.EditMode = EditMode.EditOn;
					this.prevent_mablagh = true;
				}
				else
				{
					flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_ID"].Value, 13, false);
					if (flag2)
					{
						int sum_Check = this.GetSum_Check();
						flag2 = (Operators.CompareString(this.txt_mablaghpardakht.Text, string.Empty, false) != 0);
						if (flag2)
						{
							this.CurrencyBox1.Text = Conversions.ToString(checked(Conversions.ToLong(this.txt_mablaghpardakht.Text.Replace(",", "")) - unchecked((long)sum_Check)));
							this.CurrencyBox1_Validating(this.CurrencyBox1, null);
						}
					}
					object value = this.gridex2.GetRow().Cells["dptype_ID"].Value;
					flag2 = Operators.ConditionalCompareObjectEqual(value, 10, false);
					if (flag2)
					{
						this.txt_babat.Focus();
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(value, 15, false);
						if (flag2)
						{
							flag = (((DataRowView)this.gridex2.CurrentRow.DataRow)["id"] == DBNull.Value);
							if (flag)
							{
								this.txt_nahvePardakht.SetValue("نقد", 1);
								this.SetRowValue(this.gridex2, "moshtari_id2", Conversions.ToString(this.txt_nahvePardakht.Value));
							}
							this.txt_babat_hazine.Focus();
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(value, 29, false);
							if (flag2)
							{
								this.txt_kart_bankhesab.Focus();
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(value, 30, false);
								if (flag2)
								{
									this.txt_bank_hazine.Focus();
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(value, 14, false);
									if (flag2)
									{
										this.txt_vajhbank.Focus();
									}
									else
									{
										flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(value, 11, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, 12, false))) ? true : false);
										if (flag2)
										{
											this.txt_shcheck.Focus();
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(value, 13, false);
											if (flag2)
											{
												this.txt_dbabatnc.Focus();
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(value, 17, false);
												if (flag2)
												{
													this.UiButton2.Focus();
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(value, 31, false);
													if (flag2)
													{
														this.txt_bank_bankhesab.Focus();
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(value, 32, false);
														if (flag2)
														{
															this.txt_babat.Focus();
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(value, 37, false);
															if (flag2)
															{
																this.txt_nahvepardakht_agsat.Focus();
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(value, 38, false);
																if (flag2)
																{
																	this.txt_nahvePardakhtTankhah.Focus();
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(value, 39, false);
																	if (flag2)
																	{
																		this.txt_be_moshtari.Focus();
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(value, 44, false);
																		if (flag2)
																		{
																			this.txt_phavale_bank.Focus();
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(value, 45, false);
																			if (flag2)
																			{
																				this.txt_babat_takhfif.Focus();
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
							}
						}
					}
				}
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0010E484 File Offset: 0x0010C684
		private void gridex2_SelectionChanged(object sender, EventArgs e)
		{
			this.group_dnaghd.Visible = false;
			this.group_dcheck.Visible = false;
			this.group_dfish.Visible = false;
			this.Group_DnaghdCheck.Visible = false;
			this.Group_VarizCheck.Visible = false;
			this.Group_BankVajh.Visible = false;
			this.Group_kart_be_Kart.Visible = false;
			this.Group_Bank_Hazine.Visible = false;
			this.Group_Bank_To_Bank.Visible = false;
			this.Group_Hazine.Visible = false;
			this.Group_Gest.Visible = false;
			this.Group_PardakhtTankhah.Visible = false;
			this.group_moshtari_be_moshtari.Visible = false;
			this.group_phavale_arzi.Visible = false;
			this.Group_Takhfif.Visible = false;
			Public_Function.SetNew(this.Group_Bank_To_Bank);
			Public_Function.SetNew(this.Group_Bank_Hazine);
			Public_Function.SetNew(this.Group_kart_be_Kart);
			Public_Function.SetNew(this.group_dfish);
			Public_Function.SetNew(this.group_dnaghd);
			Public_Function.SetNew(this.group_dcheck);
			Public_Function.SetNew(this.Group_DnaghdCheck);
			Public_Function.SetNew(this.Group_VarizCheck);
			Public_Function.SetNew(this.Group_BankVajh);
			Public_Function.SetNew(this.Group_Hazine);
			Public_Function.SetNew(this.Group_Gest);
			Public_Function.SetNew(this.Group_PardakhtTankhah);
			Public_Function.SetNew(this.group_moshtari_be_moshtari);
			Public_Function.SetNew(this.group_phavale_arzi);
			Public_Function.SetNew(this.Group_Takhfif);
			bool flag = this.gridex2.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					this.gridex2.GetRow().BeginEdit();
					flag = (this.gridex2.GetRow().RowType == RowType.Record);
					if (flag)
					{
						this.gridex2.GetRow().Cells["dp_name"].EditType = EditType.NoEdit;
						this.gridex2.GetRow().Cells["dp_name"].ButtonEnabled = false;
						this.gridex2.GetRow().Cells["dp_name"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
						DataRowView dataRowView = (DataRowView)this.gridex2.GetRow().DataRow;
						flag = (dataRowView["moshtari_ID"] != DBNull.Value);
						bool flag2;
						if (flag)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(dataRowView["dptype_ID"], 13, false);
							if (flag2)
							{
								this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(dataRowView["Moshtari_ID"]);
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
						flag2 = (dataRowView != null && dataRowView["dptype_ID"] != DBNull.Value);
						if (flag2)
						{
							object left = dataRowView["dptype_ID"];
							flag = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, -2, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, -3, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, -4, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 16, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, -5, false))) ? true : false);
							if (flag)
							{
								this.gridex2.GetRow().Cells["dp_name"].EditType = EditType.NoEdit;
								this.gridex2.GetRow().Cells["moshtari_name"].EditType = EditType.NoEdit;
								this.gridex2.GetRow().Cells["mablagh"].EditType = EditType.NoEdit;
								this.group_dnaghd.Visible = true;
								this.txt_babat.Text = dataRowView["Tozih"].ToString();
							}
							else
							{
								flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 10, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 32, false))) ? true : false);
								if (flag2)
								{
									this.group_dnaghd.Visible = true;
									this.txt_babat.Text = dataRowView["Tozih"].ToString();
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left, 15, false);
									if (flag2)
									{
										this.Group_Hazine.Visible = true;
										this.txt_babat_hazine.Text = dataRowView["Tozih"].ToString();
										flag2 = (dataRowView["sh_check"] != DBNull.Value);
										if (flag2)
										{
											flag = (dataRowView["checkbarg_id"] != DBNull.Value);
											if (flag)
											{
												this.txt_hazine_shcheck.SetValue(Conversions.ToString(dataRowView["sh_check"]), RuntimeHelpers.GetObjectValue(dataRowView["checkbarg_id"]));
											}
											else
											{
												this.txt_hazine_shcheck.SetValue(Conversions.ToString(dataRowView["sh_check"]), RuntimeHelpers.GetObjectValue(dataRowView["Pardakhtcheck_id"]));
											}
										}
										flag2 = (dataRowView["moshtari_id2"] != DBNull.Value);
										if (flag2)
										{
											object left2 = dataRowView["moshtari_id2"];
											flag = Operators.ConditionalCompareObjectEqual(left2, 1, false);
											if (flag)
											{
												this.txt_nahvePardakht.SetValue("نقد", 1);
												this.txt_hazine_sarresid.Visible = false;
												this.Label37.Visible = false;
												this.txt_hazine_shcheck.Visible = false;
												this.Label36.Visible = false;
												this.txt_hazine_kartbekart.Visible = false;
												this.Label41.Visible = false;
												this.Label42.Visible = false;
												this.txt_hazinetankhah.Visible = false;
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left2, 2, false);
												if (flag2)
												{
													this.txt_nahvePardakht.SetValue("دسته چک", 2);
													this.txt_hazine_shcheck.Visible = true;
													this.txt_hazine_sarresid.Visible = true;
													flag2 = (dataRowView["check_sarresid_fa"] != DBNull.Value);
													if (flag2)
													{
														this.txt_hazine_sarresid.Text = Conversions.ToString(dataRowView["check_sarresid_fa"]);
													}
													this.Label37.Visible = true;
													this.Label36.Visible = true;
													this.txt_hazine_kartbekart.Visible = false;
													this.Label41.Visible = false;
													this.Label42.Visible = false;
													this.txt_hazinetankhah.Visible = false;
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left2, 3, false);
													if (flag2)
													{
														this.txt_nahvePardakht.SetValue("چک مشتری", 3);
														this.txt_hazine_shcheck.Visible = true;
														this.Label36.Visible = true;
														this.txt_hazine_sarresid.Visible = false;
														this.Label37.Visible = false;
														this.txt_hazine_kartbekart.Visible = false;
														this.Label41.Visible = false;
														this.Label42.Visible = false;
														this.txt_hazinetankhah.Visible = false;
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left2, 4, false);
														if (flag2)
														{
															this.txt_nahvePardakht.SetValue("کارت به کارت", 4);
															this.Label42.Visible = false;
															this.txt_hazinetankhah.Visible = false;
															this.txt_hazine_sarresid.Visible = false;
															this.Label37.Visible = false;
															this.txt_hazine_shcheck.Visible = false;
															this.Label36.Visible = false;
															this.txt_hazine_kartbekart.Visible = true;
															this.Label41.Visible = true;
															flag2 = (dataRowView["bankhesab_id"] != DBNull.Value);
															if (flag2)
															{
																this.txt_hazine_kartbekart.SetValue(Conversions.ToString(dataRowView["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bankhesab_id"]));
															}
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left2, 5, false);
															if (flag2)
															{
																this.txt_nahvePardakht.SetValue("پرداخت از تنخواه", 5);
																this.txt_hazine_sarresid.Visible = false;
																this.Label37.Visible = false;
																this.txt_hazine_shcheck.Visible = false;
																this.Label36.Visible = false;
																this.txt_hazine_kartbekart.Visible = false;
																this.Label41.Visible = false;
																this.Label42.Visible = true;
																this.txt_hazinetankhah.Visible = true;
																flag2 = (dataRowView["hazine_id"] != DBNull.Value);
																if (flag2)
																{
																	this.txt_hazinetankhah.SetValue(Conversions.ToString(dataRowView["hazine_name"]), RuntimeHelpers.GetObjectValue(dataRowView["hazine_id"]));
																}
															}
														}
													}
												}
											}
										}
										else
										{
											this.txt_hazine_sarresid.Visible = false;
											this.Label37.Visible = false;
										}
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(left, 37, false);
										if (flag2)
										{
											this.Group_Gest.Visible = true;
											this.txt_babat_agsat.Text = dataRowView["Tozih"].ToString();
											flag2 = (dataRowView["moshtari_id2"] != DBNull.Value);
											if (flag2)
											{
												object left3 = dataRowView["moshtari_id2"];
												flag = Operators.ConditionalCompareObjectEqual(left3, 1, false);
												if (flag)
												{
													this.txt_nahvepardakht_agsat.SetValue("صندوق", 1);
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left3, 2, false);
													if (flag2)
													{
														this.txt_nahvepardakht_agsat.SetValue("حساب بانکی", 2);
														this.Label47.Visible = true;
														this.txt_bankhesab_gest.Visible = true;
														this.txt_bankhesab_gest.SetValue(Conversions.ToString(dataRowView["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bankhesab_id"]));
														this.Label37.Visible = true;
													}
												}
											}
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left, 29, false);
											if (flag2)
											{
												this.Group_kart_be_Kart.Visible = true;
												this.txt_babat_kart.Text = dataRowView["Tozih"].ToString();
												flag2 = (dataRowView["bankhesab_id"] != DBNull.Value);
												if (flag2)
												{
													this.txt_kart_bankhesab.SetValue(Conversions.ToString(dataRowView["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bankhesab_id"]));
												}
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left, 30, false);
												if (flag2)
												{
													this.Group_Bank_Hazine.Visible = true;
													this.txt_babat_hazine_bank.Text = dataRowView["Tozih"].ToString();
													flag2 = (dataRowView["bankhesab_id"] != DBNull.Value);
													if (flag2)
													{
														this.txt_bank_hazine.SetValue(Conversions.ToString(dataRowView["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bankhesab_id"]));
													}
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left, 31, false);
													if (flag2)
													{
														this.Group_Bank_To_Bank.Visible = true;
														this.txt_bank_babat.Text = dataRowView["Tozih"].ToString();
														flag2 = (dataRowView["bankhesab_id"] != DBNull.Value);
														if (flag2)
														{
															this.txt_bank_bankhesab.SetValue(Conversions.ToString(dataRowView["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bankhesab_id"]));
														}
														flag2 = (dataRowView["checkbarg_id"] != DBNull.Value);
														if (flag2)
														{
															this.txt_bank_shcheck.SetValue(Conversions.ToString(dataRowView["sh_check"]), RuntimeHelpers.GetObjectValue(dataRowView["checkbarg_id"]));
														}
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left, 14, false);
														if (flag2)
														{
															this.Group_BankVajh.Visible = true;
															this.txt_vajhbank.Text = dataRowView["Tozih"].ToString();
														}
														else
														{
															flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 11, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 12, false))) ? true : false);
															if (flag2)
															{
																this.group_dcheck.Visible = true;
																this.txt_shcheck.Text = dataRowView["Sh_Check"].ToString();
																flag2 = (dataRowView["CheckBank_ID"] != DBNull.Value);
																if (flag2)
																{
																	this.txt_bank.SetValue(Conversions.ToString(dataRowView["CheckBank_Name"]), RuntimeHelpers.GetObjectValue(dataRowView["CheckBank_ID"]));
																}
																else
																{
																	this.txt_bank.SetNew();
																}
																this.txt_shobe.Text = dataRowView["Check_Shobe"].ToString();
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
																	this.Group_DnaghdCheck.Visible = true;
																	this.txt_moshtariHesab.Visible = true;
																	this.Label25.Visible = true;
																	this.UiButton6.Visible = true;
																	this.txt_dbabatnc.Text = dataRowView["Tozih"].ToString();
																	int i = ((DataTable)this.gridex2.DataSource).Rows.IndexOf(((DataRowView)this.gridex2.CurrentRow.DataRow).Row);
																	DataTable dataTable = (DataTable)this.gridex2.DataSource;
																	int num = Conversions.ToInteger(((DataRowView)this.gridex2.CurrentRow.DataRow)["identity"]);
																	flag2 = (((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtarihesab_id"] != DBNull.Value);
																	if (flag2)
																	{
																		this.txt_moshtariHesab.SetValue(Conversions.ToString(((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtarihesab_name"]), RuntimeHelpers.GetObjectValue(((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtarihesab_id"]));
																	}
																	flag2 = (this.gridex2.CurrentRow.Cells["Moshtari_ID"].Value == DBNull.Value);
																	if (!flag2)
																	{
																		flag2 = (Operators.CompareString(this.gridex2.CurrentRow.Cells["Mablagh"].Value.ToString(), string.Empty, false) == 0);
																		if (!flag2)
																		{
																			this.CurrencyBox1.Text = dataTable.Rows[i]["mablagh"].ToString();
																			flag2 = (i < dataTable.Rows.Count - 1);
																			if (flag2)
																			{
																				flag = (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i + 1]["dptype_id"], 10, false) && Operators.ConditionalCompareObjectEqual(dataTable.Rows[i + 1]["parent_identity"], dataTable.Rows[i]["identity"], false));
																				if (flag)
																				{
																					this.CurrencyBox1.Text = dataTable.Rows[i + 1]["Mablagh"].ToString();
																					this.CurrencyBox1.Value = Conversions.ToLong(dataTable.Rows[i + 1]["Mablagh"].ToString());
																					return;
																				}
																			}
																			i++;
																			while (i <= dataTable.Rows.Count - 1)
																			{
																				flag2 = (dataTable.Rows[i].RowState == DataRowState.Deleted);
																				if (flag2)
																				{
																					i++;
																				}
																				else
																				{
																					flag2 = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
																					if (flag2)
																					{
																						i++;
																					}
																					else
																					{
																						flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
																						if (flag2)
																						{
																							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 10, false);
																							if (flag)
																							{
																								this.CurrencyBox1.Text = dataTable.Rows[i]["Mablagh"].ToString();
																								this.CurrencyBox1.Value = Conversions.ToLong(dataTable.Rows[i]["Mablagh"].ToString());
																								return;
																							}
																						}
																						i++;
																					}
																				}
																			}
																			this.CurrencyBox1.Text = Conversions.ToString(0);
																			this.CurrencyBox1.Value = 0L;
																		}
																	}
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left, 17, false);
																	if (flag2)
																	{
																		this.Group_VarizCheck.Visible = true;
																		this.Group_VarizCheck.BringToFront();
																		this.txt_babatvariz.Text = dataRowView["Tozih"].ToString();
																		this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left, 19, false);
																		if (flag2)
																		{
																			this.Group_VarizCheck.Visible = true;
																			this.Group_VarizCheck.BringToFront();
																			this.txt_babatvariz.Text = dataRowView["tozih"].ToString();
																			this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
																			this.gridex2.CurrentRow.Cells["Moshtari_Name"].EditType = EditType.NoEdit;
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(left, 21, false);
																			if (flag2)
																			{
																				this.Group_VarizCheck.Visible = true;
																				this.Group_VarizCheck.BringToFront();
																				this.txt_babatvariz.Text = dataRowView["Tozih"].ToString();
																				this.gridex2.CurrentRow.Cells["Mablagh"].EditType = EditType.NoEdit;
																				this.gridex2.CurrentRow.Cells["Moshtari_Name"].EditType = EditType.NoEdit;
																			}
																			else
																			{
																				flag2 = Operators.ConditionalCompareObjectEqual(left, 38, false);
																				if (flag2)
																				{
																					this.Group_PardakhtTankhah.Visible = true;
																					this.txt_babattankhah.Text = dataRowView["Tozih"].ToString();
																					flag2 = (dataRowView["moshtari_id2"] != DBNull.Value);
																					if (flag2)
																					{
																						object left4 = dataRowView["moshtari_id2"];
																						flag = Operators.ConditionalCompareObjectEqual(left4, 1, false);
																						if (flag)
																						{
																							this.txt_nahvePardakhtTankhah.SetValue("صندوق", 1);
																						}
																						else
																						{
																							flag2 = Operators.ConditionalCompareObjectEqual(left4, 2, false);
																							if (flag2)
																							{
																								this.txt_nahvePardakhtTankhah.SetValue("حساب بانکی", 2);
																								flag2 = (dataRowView["bankhesab_id"] != DBNull.Value);
																								if (flag2)
																								{
																									this.txt_tankhah_hesabbanki.SetValue(Conversions.ToString(dataRowView["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bankhesab_id"]));
																								}
																							}
																						}
																					}
																				}
																				else
																				{
																					flag2 = Operators.ConditionalCompareObjectEqual(left, 39, false);
																					if (flag2)
																					{
																						this.group_moshtari_be_moshtari.Visible = true;
																						this.txt_babat_moshtari_be_moshtari.Text = dataRowView["Tozih"].ToString();
																						flag2 = (dataRowView["bemoshtari_id"] != DBNull.Value);
																						if (flag2)
																						{
																							this.txt_be_moshtari.SetValue(Conversions.ToString(dataRowView["bemoshtari_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bemoshtari_id"]));
																						}
																					}
																					else
																					{
																						flag2 = Operators.ConditionalCompareObjectEqual(left, 44, false);
																						if (flag2)
																						{
																							this.group_phavale_arzi.Visible = true;
																							this.txt_phavale_babat.Text = dataRowView["Tozih"].ToString();
																							flag2 = (dataRowView["bemoshtari_id"] != DBNull.Value);
																							if (flag2)
																							{
																								this.txt_phavale_bank.SetValue(Conversions.ToString(dataRowView["bemoshtari_name"]), RuntimeHelpers.GetObjectValue(dataRowView["bemoshtari_id"]));
																							}
																							flag2 = (dataRowView["fishvariz_fa"] != DBNull.Value);
																							if (flag2)
																							{
																								this.txt_pfee_dolar.Text = dataRowView["fishvariz_fa"].ToString();
																							}
																							else
																							{
																								this.txt_pfee_dolar.SetNew();
																							}
																						}
																						else
																						{
																							flag2 = Operators.ConditionalCompareObjectEqual(left, 45, false);
																							if (flag2)
																							{
																								this.Group_Takhfif.Visible = true;
																								this.txt_babat_takhfif.Text = dataRowView["Tozih"].ToString();
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
											}
										}
									}
								}
							}
						}
					}
					else
					{
						this.Clean_Status();
					}
				}
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0010FB1C File Offset: 0x0010DD1C
		private void gridex2_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.gridex2.CurrentRow.RowType == RowType.NewRecord & !this.prevent;
			if (flag)
			{
				this.group_dnaghd.Visible = false;
				this.group_dcheck.Visible = false;
				this.group_dfish.Visible = false;
				this.Group_DnaghdCheck.Visible = false;
				this.Group_VarizCheck.Visible = false;
				this.Group_NaghdCheck.Visible = false;
				this.Group_Bank_To_Bank.Visible = false;
				this.Group_checkNaghd.Visible = false;
			}
			flag = !this.prevent;
			if (flag)
			{
				this.gridex2_SelectionChanged(null, null);
			}
			this.Group_DnaghdCheck.Parent = this.Group_Letf;
			this.group_dnaghd.Parent = this.Group_Letf;
			this.group_dcheck.Parent = this.Group_Letf;
			this.Group_VarizCheck.Parent = this.Group_Letf;
			this.gridex1focused = false;
			this.gridex2.Row = this.gridex2.Row;
			this.gridex2.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0010FC40 File Offset: 0x0010DE40
		private void gridex2_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_mablaghpardakht;
				this.txt_mablaghpardakht.Text = e.Value.ToString();
				this.txt_mablaghpardakht.SelectAll();
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0010FCA4 File Offset: 0x0010DEA4
		private int GetSum_Check()
		{
			bool flag = this.Group_DnaghdCheck.Parent == this.Group_Letf;
			GridEX gridEX;
			if (flag)
			{
				gridEX = this.gridex2;
			}
			else
			{
				gridEX = this.GridEX1;
			}
			int i = ((DataTable)gridEX.DataSource).Rows.IndexOf(((DataRowView)gridEX.CurrentRow.DataRow).Row);
			DataTable dataTable = (DataTable)gridEX.DataSource;
			int num = Conversions.ToInteger(((DataRowView)gridEX.CurrentRow.DataRow)["identity"]);
			int num2 = 0;
			checked
			{
				i++;
				while (i <= dataTable.Rows.Count - 1)
				{
					flag = (dataTable.Rows[i]["parent_identity"] == DBNull.Value);
					if (flag)
					{
						i++;
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["parent_identity"], num, false);
						if (flag)
						{
							if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 2, false) || Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 11, false))
							{
								goto IL_164;
							}
							if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["dptype_id"], 12, false))
							{
								goto IL_164;
							}
							bool arg_166_0 = false;
							IL_165:
							bool flag2 = arg_166_0;
							if (flag2)
							{
								num2 = Conversions.ToInteger(Operators.AddObject(num2, dataTable.Rows[i]["Mablagh"]));
							}
							goto IL_197;
							IL_164:
							arg_166_0 = true;
							goto IL_165;
						}
						IL_197:
						i++;
					}
				}
				return num2;
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0010FE74 File Offset: 0x0010E074
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

		// Token: 0x0600183C RID: 6204 RVA: 0x0010FF18 File Offset: 0x0010E118
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0010FF6C File Offset: 0x0010E16C
		private void Moshtari_select(GridEX grid)
		{
			bool flag = this.GridEX1.CurrentRow.Cells["dptype_id"].Value != DBNull.Value;
			checked
			{
				if (flag)
				{
					this.prevent = true;
					bool arg_186_0;
					if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 4, false) && !Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 8, false))
					{
						if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 3, false))
						{
							if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 34, false))
							{
								if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 38, false))
								{
									if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 43, false))
									{
										if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 44, false))
										{
											arg_186_0 = false;
											goto IL_185;
										}
									}
								}
							}
						}
					}
					arg_186_0 = true;
					IL_185:
					flag = arg_186_0;
					bool flag2;
					if (flag)
					{
						this.frm.CanEdit = true;
						this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
						this.frm.Text = "انتخاب مشتری";
						((ItemCollection)this.frm.items)[0].Name = "code";
						flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > 0) order by moshtari.code", MyProject.Forms.Frm_Moshtari, 650) == DialogResult.OK);
						if (flag)
						{
							flag2 = (grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null);
							if (flag2)
							{
								grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
								this.dt_search1.Rows.Add(new object[]
								{
									RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]),
									RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"])
								});
								this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.frm.SelectedRow["ID"]);
								this.Refresh_Status();
								grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
								grid.Col++;
								grid.EditMode = EditMode.EditOn;
							}
						}
						((ItemCollection)this.frm.items)[0].Name = "ID";
						this.frm.CanEdit = false;
						this.frm.Edit_Frm = null;
					}
					flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 6, false);
					if (flag2)
					{
						this.frm.CanEdit = true;
						this.frm.Edit_Frm = MyProject.Forms.Frm_Daramad;
						this.frm.Text = "انتخاب درآمد";
						flag2 = (this.frm.ShowDialog("select id,Name  from daramad ", MyProject.Forms.Frm_Daramad, 0) == DialogResult.OK);
						if (flag2)
						{
							flag = (grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null);
							if (flag)
							{
								grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
								grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
								grid.Col++;
								grid.EditMode = EditMode.EditOn;
							}
						}
						this.frm.CanEdit = false;
						this.frm.Edit_Frm = null;
					}
					flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 25, false);
					if (flag2)
					{
						this.frm.CanEdit = true;
						this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
						this.frm.Text = "انتخاب حساب بانکی";
						flag2 = (this.frm.ShowDialog("SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where visible is null ", MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK);
						if (flag2)
						{
							flag = (grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null);
							if (flag)
							{
								grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
								grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							}
						}
						this.frm.CanEdit = false;
						this.frm.Edit_Frm = null;
						this.UiButton3.Focus();
						this.UiButton3_Click(null, null);
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 27, false);
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
							this.frm.Text = "انتخاب حساب بانکی";
							flag2 = (this.frm.ShowDialog("SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where kartkhan=1 and visible is null", MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null);
								if (flag)
								{
									grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									grid.Col++;
									grid.EditMode = EditMode.EditOn;
								}
							}
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
						bool arg_7F7_0;
						if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 33, false) && !Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 36, false))
						{
							if (!Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 40, false))
							{
								arg_7F7_0 = false;
								goto IL_7F6;
							}
						}
						arg_7F7_0 = true;
						IL_7F6:
						flag2 = arg_7F7_0;
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
							this.frm.Text = "انتخاب حساب بانکی";
							flag2 = (this.frm.ShowDialog("SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where visible is null ", MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null);
								if (flag)
								{
									grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									grid.Col++;
									grid.EditMode = EditMode.EditOn;
								}
							}
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 28, false);
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
							this.frm.Text = "انتخاب مشتری";
							((ItemCollection)this.frm.items)[0].Name = "code";
							flag2 = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > -2) order by moshtari.code", MyProject.Forms.Frm_Moshtari, 650) == DialogResult.OK);
							if (flag2)
							{
								flag = (grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null);
								if (flag)
								{
									grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									grid.Col++;
									grid.EditMode = EditMode.EditOn;
								}
							}
							((ItemCollection)this.frm.items)[0].Name = "ID";
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
					}
				}
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00110A2C File Offset: 0x0010EC2C
		private void Moshtari_selectPardakht()
		{
			bool flag = this.gridex2.GetRow().Cells["dptype_id"].Value == DBNull.Value;
			checked
			{
				if (!flag)
				{
					flag = (this.gridex2.GetRow().Cells["dptype_id"].Value != null);
					if (flag)
					{
						this.prevent = true;
						flag = (Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 13, false) || Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 32, false));
						bool flag2;
						if (flag)
						{
							string str = ",-4";
							flag = Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
							if (flag)
							{
								str = ",-99";
							}
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
							this.frm.Text = "انتخاب مشتری";
							((ItemCollection)this.frm.items)[0].Name = "code";
							flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID not in (-1,-2,-3,-5,-6 " + str + ")) order by moshtari.code", MyProject.Forms.Frm_Moshtari, 650) == DialogResult.OK);
							if (flag)
							{
								flag2 = (this.gridex2.Col == this.gridex2.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag2)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.frm.SelectedRow["ID"]);
									this.Refresh_Status();
									this.dt_search2.Rows.Add(new object[]
									{
										RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"])
									});
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
							((ItemCollection)this.frm.items)[0].Name = "ID";
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
						flag2 = (Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 30, false) || Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 29, false));
						if (flag2)
						{
							((ItemCollection)this.frm.items)[0].Name = "code";
							this.frm.Text = "انتخاب مشتری";
							flag2 = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr, 1 as kind2 FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > 0) Union select id,id as code,name,' ' as shahr,2 as kind2 from hazine order by code", null, 650) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.gridex2.Col == this.gridex2.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									flag2 = Operators.ConditionalCompareObjectEqual(this.frm.SelectedRow["kind2"], 1, false);
									if (flag2)
									{
										this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
										this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.frm.SelectedRow["ID"]);
										((DataRowView)this.gridex2.GetRow().DataRow)["hazine_id"] = DBNull.Value;
										this.Refresh_Status();
									}
									else
									{
										((DataRowView)this.gridex2.GetRow().DataRow)["hazine_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
										this.Clean_Status();
									}
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
							((ItemCollection)this.frm.items)[0].Name = "ID";
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 15, false);
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Hazine;
							this.frm.Text = "انتخاب هزینه";
							flag2 = (this.frm.ShowDialog("select id,Name from Hazine ", MyProject.Forms.Frm_Hazine, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.gridex2.Col == this.gridex2.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 31, false);
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
							this.frm.Text = "انتخاب بانک";
							flag2 = (this.frm.ShowDialog("SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID  where visible is null", MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.gridex2.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 37, false);
						if (flag2)
						{
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
							this.frm.Text = "انتخاب بانک";
							((ItemCollection)this.frm.items)[2].Caption = "حساب بانکی";
							((ItemCollection)this.frm.items)[2].Name = "bankhesab_name";
							((ItemCollection)this.frm.items)[1].Caption = "مشخصات تسهیلات";
							flag2 = (this.frm.ShowDialog("SELECT     DaryaftPardakht.Tarikh_Fa+' - '+cast( DaryaftPardakht.Mablagh as nvarchar(20)) as name, DaryaftPardakht.ID, Bank.Name +' '+ Bank_Hesab.Shobe+' '+Bank_Hesab.SahebHesab as bankhesab_name   FROM         DaryaftPardakht INNER JOIN  Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID  WHERE     (DaryaftPardakht.dpType_ID = 33)", null, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.gridex2.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
							((ItemCollection)this.frm.items)[1].Caption = "عنوان";
							((ItemCollection)this.frm.items)[2].Caption = "منطقه";
							((ItemCollection)this.frm.items)[2].Name = "shahr";
						}
						flag2 = (Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 14, false) || Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 17, false));
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
							this.frm.Text = "انتخاب بانک";
							flag2 = (this.frm.ShowDialog("SELECT     Bank_Hesab.ID,Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID  where visible is null", MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.gridex2.Col == this.gridex2.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.GetRow().Cells["dptype_id"].Value, 17, false);
									if (flag2)
									{
										this.UiButton2.Focus();
										this.frm.CanEdit = false;
										this.frm.Edit_Frm = null;
										this.UiButton2_Click(null, null);
										return;
									}
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
								this.frm.CanEdit = false;
								this.frm.Edit_Frm = null;
							}
						}
						bool arg_D5F_0;
						if (!Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 38, false) && !Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 39, false))
						{
							if (!Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 44, false))
							{
								if (!Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 45, false))
								{
									arg_D5F_0 = false;
									goto IL_D5E;
								}
							}
						}
						arg_D5F_0 = true;
						IL_D5E:
						flag2 = arg_D5F_0;
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
							this.frm.Text = "انتخاب مشتری";
							((ItemCollection)this.frm.items)[0].Name = "code";
							flag2 = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > 0) order by moshtari.code", MyProject.Forms.Frm_Moshtari, 650) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.gridex2.Col == this.gridex2.RootTable.Columns["moshtari_Name"].Position && this.gridex2.EditTextBox != null);
								if (flag)
								{
									this.gridex2.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.dt_search1.Rows.Add(new object[]
									{
										RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]),
										RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"])
									});
									this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.frm.SelectedRow["ID"]);
									this.Refresh_Status();
									this.gridex2.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									DataEntryGrid gridex = this.gridex2;
									gridex.Col++;
									this.gridex2.EditMode = EditMode.EditOn;
								}
							}
							((ItemCollection)this.frm.items)[0].Name = "ID";
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
					}
				}
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x001119B0 File Offset: 0x0010FBB0
		private void SetRowValue(GridEX grid, string column, string value)
		{
			bool flag = (DataRowView)grid.GetRow().DataRow != null;
			if (flag)
			{
				((DataRowView)grid.GetRow().DataRow)[column] = value;
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x001119F4 File Offset: 0x0010FBF4
		private void Frm_DaryaftPardakht_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.prevent_close;
			if (flag)
			{
				this.prevent_close = false;
			}
			else
			{
				switch (Public_Function.ShowMessage("آیا مایل به ذخیره اطلاعات میباشید؟", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, null))
				{
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
				case DialogResult.Yes:
					flag = this.Save(true);
					if (!flag)
					{
						e.Cancel = true;
					}
					break;
				}
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00111A6C File Offset: 0x0010FC6C
		private void delete_sandugh()
		{
			bool flag = !this.Sandug.IsSandughBaste(this.txt_tarikh.Text);
			if (!flag)
			{
				flag = (Public_Function.ShowMessage("آیا مایل به حذف مانده صندوق میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, null) == DialogResult.Yes);
				if (flag)
				{
					bool flag2 = !Public_Function.dict.ContainsKey("sandugh_baz") || Conversions.ToDouble(Public_Function.dict["sandugh_baz"]) == 1.0;
					if (flag2)
					{
						string text = "delete from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.tarikhemroz)) + ";";
						text = text + "delete from daryaftpardakht where dptype_id in (5,16) and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.tarikhemroz));
						Public_Function.ExecuteNonQuery(text);
						this.Sandug.SynckasrEzafe(this.tarikhemroz);
						Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					}
					else
					{
						flag2 = (Conversions.ToDouble(Public_Function.dict["sandugh_baz"]) == 3.0);
						if (flag2)
						{
							flag2 = (new Frm_Password
							{
								Auth_type = 2
							}.ShowDialog() == DialogResult.OK);
							if (flag2)
							{
								string text2 = "delete from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.tarikhemroz)) + ";";
								text2 = text2 + "delete from daryaftpardakht where dptype_id in (5,16) and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.tarikhemroz));
								Public_Function.ExecuteNonQuery(text2);
								this.Sandug.SynckasrEzafe(this.tarikhemroz);
								Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00111C0C File Offset: 0x0010FE0C
		private void Frm_DaryaftPardakht_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.Control && e.Shift && e.KeyCode == Keys.X;
			if (flag)
			{
				this.delete_sandugh();
			}
			Keys keyCode = e.KeyCode;
			flag = (keyCode == Keys.Home);
			if (flag)
			{
				this.home_clicked = true;
				flag = this.gridex1focused;
				if (flag)
				{
					this.txt_search1.Focus();
				}
				else
				{
					this.txt_search2.Focus();
				}
			}
			else
			{
				flag = (keyCode == Keys.F2);
				if (flag)
				{
					bool flag2 = this.ButtonItem2.Visible;
					if (flag2)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
				else
				{
					bool flag2 = keyCode == Keys.F3;
					if (flag2)
					{
						flag = this.ButtonItem6.Visible;
						if (flag)
						{
							this.ButtonItem6_Click(null, null);
						}
					}
					else
					{
						flag2 = (keyCode == Keys.F4);
						if (flag2)
						{
							this.ButtonItem7_Click(null, null);
						}
						else
						{
							flag2 = (keyCode == Keys.F5);
							if (flag2)
							{
								flag = this.ButtonItem3.Visible;
								if (flag)
								{
									this.ButtonItem3_Click(null, null);
								}
							}
							else
							{
								flag2 = (keyCode == Keys.F6);
								if (flag2)
								{
									flag = this.ButtonItem4.Visible;
									if (flag)
									{
										this.ButtonItem4_Click_1(null, null);
									}
								}
								else
								{
									flag2 = (keyCode == Keys.F7);
									if (flag2)
									{
										flag = this.ButtonItem5.Visible;
										if (flag)
										{
											this.ButtonItem5_Click_1(null, null);
										}
									}
									else
									{
										flag2 = (keyCode == Keys.Insert);
										if (flag2)
										{
											this.txt_tarikh.DatePart = 2;
											this.txt_tarikh.FocusDatePart = 2;
											this.txt_tarikh.Focus();
											this.txt_tarikh.Focus();
										}
										else
										{
											flag2 = (keyCode == Keys.Escape);
											if (flag2)
											{
												this.prevent_close = true;
												switch (Public_Function.ShowMessage("آیا مایل به ذخیره اطلاعات میباشید؟", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, null))
												{
												case DialogResult.Yes:
													flag2 = this.Save(true);
													if (flag2)
													{
														this.Close();
													}
													break;
												case DialogResult.No:
													this.Close();
													break;
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

		// Token: 0x06001843 RID: 6211 RVA: 0x00111DFC File Offset: 0x0010FFFC
		private void Frm_DaryaftPardakht_Load(object sender, EventArgs e)
		{
			this.txt_mablagh.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.Group_Takhfif.Parent = this.Group_Letf;
			this.Group_Hazine.Parent = this.Group_Letf;
			this.Group_Bank_To_Bank.Parent = this.Group_Letf;
			this.Group_Bank_Hazine.Parent = this.Group_Letf;
			this.Group_BankVajh.Parent = this.Group_Letf;
			this.Group_DnaghdCheck.Parent = this.Group_Right;
			this.group_dfish.Parent = this.Group_Right;
			this.GroupKartkhan.Parent = this.Group_Right;
			this.Group_barzamin.Parent = this.Group_Right;
			this.Group_kart_be_Kart.Parent = this.Group_Letf;
			this.Group_Gest.Parent = this.Group_Letf;
			this.Group_PardakhtTankhah.Parent = this.Group_Letf;
			this.group_moshtari_be_moshtari.Parent = this.Group_Letf;
			this.Group_checkNaghd.Parent = this.Group_Right;
			this.Group_NaghdCheck.Parent = this.Group_Right;
			this.group_havale_arzi.Parent = this.Group_Right;
			this.group_phavale_arzi.Parent = this.Group_Letf;
			this.txt_kart_bankhesab.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_kart_bankhesab.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_kart_bankhesab.CanEdit = true;
			this.txt_moshtariHesab.AddNewForm = MyProject.Forms.Frm_Moshtari_Hesab;
			this.txt_fishbankhesab.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_fishbankhesab.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_fishbankhesab.CanEdit = true;
			this.txt_havale_bank.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_havale_bank.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_havale_bank.CanEdit = true;
			this.txt_phavale_bank.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_phavale_bank.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.txt_phavale_bank.CanEdit = true;
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("ID", "کد", 15));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 20));
			this.frm.items = itemCollection;
			this.txt_search1.AllowEdit = true;
			this.txt_search1.AllowNew = true;
			this.dt_search1.Columns.Add("ID", typeof(int));
			this.dt_search1.Columns.Add("name", typeof(string));
			this.dt_search2.Columns.Add("name", typeof(string));
			bool flag = !this.ShowPreview;
			if (flag)
			{
				this.txt_tarikh.SetNew();
			}
			else
			{
				this.txt_tarikh.Text = this.PreviewTarikh;
			}
			this.tarikhemroz = this.txt_tarikh.Text;
			Initdb initdb = new Initdb();
			initdb.Update_checkStatus();
			this.dp.DeleteKeraye(this.txt_tarikh.Text);
			this.GetDataDaryaft();
			this.GetDataPardakht();
			flag = Public_Function.dict.ContainsKey("vagozari_bankhesab");
			if (flag)
			{
				this.vagozari_bankhesab_id = Conversions.ToLong(Public_Function.dict["vagozari_bankhesab"]);
				this.vagozari_bankhesab_Name = Conversions.ToString(Public_Function.ExecuteScalar("SELECT     Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab  FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where bank_hesab.id=" + Public_Function.dict["vagozari_bankhesab"]));
			}
			DataRow dataRow = Public_Function.FillDataRow("select top 1 mande,Tarikh_Fa from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " order by tarikh desc ");
			flag = (dataRow != null);
			if (flag)
			{
				this.Label17.Text = Public_Function.FormatPrice(Conversions.ToString(dataRow["mande"]));
				this.Label16.Text = Conversions.ToString(Operators.ConcatenateObject("موجودی صندوق در تاریخ ", dataRow["tarikh_fa"]));
			}
			else
			{
				DataRow dataRow2 = Public_Function.FillDataRow("select bed from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				flag = (dataRow2 != null);
				if (flag)
				{
					this.Label17.Text = Public_Function.FormatPrice(Conversions.ToString(dataRow2["bed"]));
					this.Label16.Text = "موجودی اول دوره صندوق  ";
				}
				else
				{
					this.Label16.Text = string.Empty;
					this.Label17.Text = string.Empty;
				}
			}
			flag = (Public_Function.AppType == 1 | Public_Function.AppType == 3);
			if (flag)
			{
				this.ButtonItem4.Visible = false;
				this.ButtonItem5.Visible = false;
			}
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(tarikh) from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			flag = (num == 0);
			if (flag)
			{
				this.ButtonItem9.Visible = true;
				this.Label20.Text = string.Empty;
			}
			else
			{
				this.ButtonItem9.Visible = false;
				this.Label20.Text = Public_Function.FormatPrice(Conversions.ToString(Public_Function.ExecuteScalar("select mande from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)))));
			}
			try
			{
				IEnumerator enumerator = this.Group_Right.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					flag = (Operators.CompareString(control.Name, "Metro_Right", false) == 0);
					if (!flag)
					{
						control.Visible = false;
						control.Dock = DockStyle.Fill;
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
			try
			{
				IEnumerator enumerator2 = this.Group_Letf.Controls.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Control control2 = (Control)enumerator2.Current;
					flag = (Operators.CompareString(control2.Name, "Metro_Left", false) == 0);
					if (!flag)
					{
						control2.Visible = false;
						control2.Dock = DockStyle.Fill;
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
			this.gridex1focused = true;
			flag = this.ShowPreview;
			if (flag)
			{
				this.Bar1.Visible = false;
				this.GridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
				this.gridex2.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
				this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				this.gridex2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0011253C File Offset: 0x0011073C
		private void Frm_DaryaftPardakht_Resize(object sender, EventArgs e)
		{
			bool flag = MyProject.Forms.Form_Main.WindowState == FormWindowState.Minimized;
			checked
			{
				if (!flag)
				{
					this.GridEX1.Height = this.UiGroupBox2.Top - this.UiGroupBox2.Height - this.RibbonStatusBar1.Height - 10;
					this.gridex2.Height = this.UiGroupBox2.Top - this.UiGroupBox2.Height - this.RibbonStatusBar1.Height - 10;
					this.gridex2.Width = (int)Math.Round((double)this.UiGroupBox1.Width / 2.0);
					this.gridex2.Left = 1;
					this.GridEX1.Left = this.gridex2.Right + 3;
					this.GridEX1.Width = this.gridex2.Width - 6;
					this.Group_Letf.Width = this.gridex2.Width;
					this.txt_search2.Left = this.gridex2.Right - this.txt_search2.Width - 60;
					this.Label22.Left = this.txt_search2.Right + 5;
				}
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0011268C File Offset: 0x0011088C
		public void shomarehesab_chenged(DataRow dr)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["Check_ShomareHesab"] == DBNull.Value);
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["Check_ShomareHesab"], dr["prevshomarehesab"], false);
						if (flag)
						{
							dataRow["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dr["shomarehesab"]);
							dataRow["checkbank_Name"] = RuntimeHelpers.GetObjectValue(dr["bank_name"]);
							dataRow["checkbank_id"] = RuntimeHelpers.GetObjectValue(dr["bank_Id"]);
							dataRow["check_shobe"] = RuntimeHelpers.GetObjectValue(dr["shobe_Name"]);
							flag = (Operators.CompareString(text, string.Empty, false) == 0);
							if (flag)
							{
								text = string.Concat(new string[]
								{
									text,
									"update daryaftpardakht set check_shomarehesab=",
									Public_Function.GetValue(Conversions.ToString(dr["shomarehesab"])),
									",checkbank_id=",
									Public_Function.GetValue(Conversions.ToString(dr["bank_id"])),
									",check_shobe=",
									Public_Function.GetValue(Conversions.ToString(dr["shobe_Name"])),
									" where check_shomarehesab=",
									Public_Function.GetValue(Conversions.ToString(dr["prevshomarehesab"])),
									";"
								});
							}
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
			try
			{
				IEnumerator enumerator2 = ((DataTable)this.gridex2.DataSource).Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag = (dataRow2["Check_ShomareHesab"] == DBNull.Value);
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow2["Check_ShomareHesab"], dr["prevshomarehesab"], false);
						if (flag)
						{
							dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dr["shomarehesab"]);
							dataRow2["checkbank_Name"] = RuntimeHelpers.GetObjectValue(dr["bank_name"]);
							dataRow2["checkbank_id"] = RuntimeHelpers.GetObjectValue(dr["bank_Id"]);
							dataRow2["check_shobe"] = RuntimeHelpers.GetObjectValue(dr["shobe_Name"]);
							flag = (Operators.CompareString(text, string.Empty, false) == 0);
							if (flag)
							{
								text = string.Concat(new string[]
								{
									text,
									"update daryaftpardakht set check_shomarehesab=",
									Public_Function.GetValue(Conversions.ToString(dr["shomarehesab"])),
									",checkbank_id=",
									Public_Function.GetValue(Conversions.ToString(dr["bank_id"])),
									",check_shobe=",
									Public_Function.GetValue(Conversions.ToString(dr["shobe_Name"])),
									" where check_shomarehesab=",
									Public_Function.GetValue(Conversions.ToString(dr["prevshomarehesab"])),
									";"
								});
							}
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00112AB8 File Offset: 0x00110CB8
		private void gridex2_RecordAdded(object sender, EventArgs e)
		{
			this.CurrencyBox1_Validating(null, null);
			GridEXRow[] rows = this.gridex2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["dptype_id"].Value == DBNull.Value;
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
					bool flag = gridEXRow2.Cells["dptype_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow2.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000072E8 File Offset: 0x000054E8
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Highlighter1.SetHighlightOnFocus(this.GridEX1, true);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00112B7C File Offset: 0x00110D7C
		private void UiButton2_Click(object sender, EventArgs e)
		{
			bool flag = (UIGroupBox)this.Group_DnaghdCheck.Parent == this.Group_Letf;
			GridEX gridEX;
			if (flag)
			{
				gridEX = this.gridex2;
			}
			else
			{
				gridEX = this.GridEX1;
			}
			flag = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 17, false);
			bool flag2;
			if (flag)
			{
				flag2 = (gridEX.CurrentRow.Cells["Moshtari_ID"].Value == DBNull.Value);
				if (flag2)
				{
					Public_Function.GridRaiseSoftError(gridEX, gridEX.CurrentRow, "Moshtari_Name", "حساب بانکی را انتخاب نمایید");
					return;
				}
			}
			flag2 = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 17, false);
			if (flag2)
			{
				Frm_CheckVariz frm_CheckVariz = new Frm_CheckVariz();
				frm_CheckVariz.dt_daryaft = (DataTable)this.GridEX1.DataSource;
				frm_CheckVariz.ListDaryaft_Identity = this.ListDaryaft_Identity;
				int position = gridEX.CurrentRow.Position;
				frm_CheckVariz.Pardakht_Table = (DataTable)this.gridex2.DataSource;
				frm_CheckVariz.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
				frm_CheckVariz.Tarikh = this.txt_tarikh.Text;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_CheckVariz);
				this.gridex2.UpdateData();
				gridEX.Row = position;
				gridEX.CurrentRow.Cells["Mablagh"].Value = frm_CheckVariz.sum_mablagh;
				this.txt_babatvariz.Focus();
			}
			flag2 = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 19, false);
			if (flag2)
			{
				Frm_CheckVusul frm_CheckVusul = new Frm_CheckVusul();
				frm_CheckVusul.dt_daryaft = (DataTable)this.gridex2.DataSource;
				frm_CheckVusul.ListDaryaft_Identity = this.ListDaryaft_Identity;
				frm_CheckVusul.Pardakht_Table = (DataTable)this.gridex2.DataSource;
				frm_CheckVusul.Tarikh = this.txt_tarikh.Text;
				int position2 = gridEX.CurrentRow.Position;
				frm_CheckVusul.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_CheckVusul);
				gridEX.Row = position2;
				gridEX.CurrentRow.Cells["Mablagh"].Value = frm_CheckVusul.sum_mablagh;
				this.txt_babatvariz.Focus();
			}
			else
			{
				flag2 = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 21, false);
				if (flag2)
				{
					Frm_CheckBargasht frm_CheckBargasht = new Frm_CheckBargasht();
					frm_CheckBargasht.dt_daryaft = (DataTable)this.gridex2.DataSource;
					frm_CheckBargasht.ListDaryaft_Identity = this.ListDaryaft_Identity;
					frm_CheckBargasht.Pardakht_Table = (DataTable)this.gridex2.DataSource;
					frm_CheckBargasht.Tarikh = this.txt_tarikh.Text;
					int position3 = gridEX.CurrentRow.Position;
					frm_CheckBargasht.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
					MyProject.Forms.Form_Main.Dialog_ShowForm(frm_CheckBargasht);
					gridEX.Row = position3;
					gridEX.CurrentRow.Cells["Mablagh"].Value = frm_CheckBargasht.sum_mablagh;
					this.txt_babatvariz.Focus();
				}
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00112F34 File Offset: 0x00111134
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			bool flag = this.gridex1focused;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.Cells["dptype_id"].Value != DBNull.Value;
				if (flag2)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
					if (flag3)
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 4, false);
						if (flag4)
						{
							Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
							Frm_SuratHesab_Moshtari arg_DB_0 = frm_SuratHesab_Moshtari;
							object expr_C9 = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value;
							int? num;
							arg_DB_0.Moshtari_id = ((expr_C9 != null) ? ((int?)expr_C9) : num);
							frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
							frm_SuratHesab_Moshtari.ShowDialog();
						}
					}
				}
			}
			else
			{
				bool flag4 = this.gridex2.CurrentRow.Cells["dptype_id"].Value != DBNull.Value;
				if (flag4)
				{
					bool flag3 = this.gridex2.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
					if (flag3)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 13, false);
						if (flag2)
						{
							Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari2 = new Frm_SuratHesab_Moshtari();
							Frm_SuratHesab_Moshtari arg_1EA_0 = frm_SuratHesab_Moshtari2;
							object expr_1D8 = this.gridex2.CurrentRow.Cells["moshtari_id"].Value;
							int? num;
							arg_1EA_0.Moshtari_id = ((expr_1D8 != null) ? ((int?)expr_1D8) : num);
							frm_SuratHesab_Moshtari2.Moshtari_Name = Conversions.ToString(this.gridex2.CurrentRow.Cells["Moshtari_Name"].Value);
							frm_SuratHesab_Moshtari2.ShowDialog();
						}
					}
				}
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00113168 File Offset: 0x00111368
		private void ButtonItem9_Click(object sender, EventArgs e)
		{
			this.Save(true);
			MyProject.Forms.Form_Main.Get_Sarresid();
			MyProject.Forms.Form_Main.Get_sarresid_Pardakht();
			new Frm_BastanSandug
			{
				Tarikh = this.txt_tarikh.Text
			}.ShowDialog();
			this.LoadData();
			this.GridEX1.Focus();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x001131F8 File Offset: 0x001113F8
		private void ButtonItem10_Click(object sender, EventArgs e)
		{
			frm_historyLog frm_historyLog = new frm_historyLog
			{
				TableName = "daryaftpardakht",
				Pkey = this.txt_tarikh.Text,
				ExtColumnNames = new List<string>()
			};
			frm_historyLog.TableItems = new List<TableItemChange>
			{
				new TableItemChange
				{
					column = "Mablagh",
					caption = "مبلغ"
				},
				new TableItemChange
				{
					column = "Tozih",
					caption = "توضیح"
				}
			};
			frm_historyLog.ExtColumnNames.AddRange(new string[]
			{
				"مشتری",
				"نوع دریافت / پرداخت"
			});
			frm_historyLog.ShowDialog();
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x001132C0 File Offset: 0x001114C0
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = this.gridex2.CurrentRow == null;
			if (!flag)
			{
				flag = (this.gridex2.Row == -1);
				if (flag)
				{
					this.gridex2.CancelCurrentEdit();
					this.gridex2.Focus();
					this.gridex2.MoveToNewRecord();
					this.gridex2.Col = 0;
					this.gridex2.EditMode = EditMode.EditOn;
				}
				else
				{
					DataTable dataTable = (DataTable)this.gridex2.DataSource;
					DataRowView dataRowView = (DataRowView)this.gridex2.CurrentRow.DataRow;
					flag = (dataRowView == null);
					if (!flag)
					{
						int num = dataTable.Rows.IndexOf(dataRowView.Row);
						flag = (num == -1);
						if (!flag)
						{
							flag = (dataRowView["dptype_id"] != DBNull.Value);
							bool flag2;
							if (flag)
							{
								flag2 = Operators.ConditionalCompareObjectLess(dataRowView["dptype_id"], 0, false);
								if (flag2)
								{
									return;
								}
								flag2 = Operators.ConditionalCompareObjectEqual(dataRowView["dptype_id"], 16, false);
								if (flag2)
								{
									return;
								}
							}
							this.GetCheckUsagePardakht(this.gridex2.CurrentRow);
							flag2 = (this.gridex2.Row == -1);
							if (flag2)
							{
								this.gridex2.CancelCurrentEdit();
								this.gridex2.Focus();
								this.gridex2.MoveToNewRecord();
								this.gridex2.Col = 0;
								this.gridex2.EditMode = EditMode.EditOn;
							}
							else
							{
								this.gridex2.Col = 2;
								this.gridex2.EditMode = EditMode.EditOn;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0011347C File Offset: 0x0011167C
		private void UiComboBox1_GotFocus(object sender, EventArgs e)
		{
			((UIComboBox)sender).BackColor = Color.LightBlue;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0011349C File Offset: 0x0011169C
		private void UiComboBox1_LostFocus(object sender, EventArgs e)
		{
			((UIComboBox)sender).BackColor = Color.White;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x001134BC File Offset: 0x001116BC
		private void UiButton3_Click(object sender, EventArgs e)
		{
			bool flag = (UIGroupBox)this.Group_NaghdCheck.Parent == this.Group_Letf;
			GridEX gridEX;
			if (flag)
			{
				gridEX = this.gridex2;
			}
			else
			{
				gridEX = this.GridEX1;
			}
			flag = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 25, false);
			if (flag)
			{
				Frm_CheckNaghd frm_CheckNaghd = new Frm_CheckNaghd();
				frm_CheckNaghd.dt_daryaft = (DataTable)this.GridEX1.DataSource;
				frm_CheckNaghd.ListDaryaft_Identity = this.ListDaryaft_Identity;
				int position = gridEX.CurrentRow.Position;
				frm_CheckNaghd.Pardakht_Table = (DataTable)this.GridEX1.DataSource;
				frm_CheckNaghd.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
				frm_CheckNaghd.Tarikh = this.txt_tarikh.Text;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_CheckNaghd);
				this.GridEX1.UpdateData();
				gridEX.Row = position;
				gridEX.CurrentRow.Cells["Mablagh"].Value = frm_CheckNaghd.sum_mablagh;
				gridEX.Focus();
				gridEX.MoveToNewRecord();
				gridEX.Col = 0;
				gridEX.EditMode = EditMode.EditOn;
				gridEX.CurrentRow.BeginEdit();
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00113618 File Offset: 0x00111818
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			GridEX gridEX = new GridEX();
			bool flag = false;
			bool flag2 = this.gridex1focused;
			if (flag2)
			{
				gridEX = this.GridEX1;
				flag2 = (this.GridEX1.CurrentRow.Cells["dptype_id"].Value == DBNull.Value);
				if (flag2)
				{
					flag = true;
				}
				else
				{
					flag2 = (Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 4, false) && Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 8, false) && Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 3, false) && Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 34, false) && Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 43, false) && Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["dptype_id"].Value, 44, false));
					if (flag2)
					{
						flag = true;
					}
				}
			}
			else
			{
				gridEX = this.gridex2;
				flag2 = (this.gridex2.CurrentRow.Cells["dptype_id"].Value == DBNull.Value);
				if (flag2)
				{
					flag = true;
				}
				else
				{
					flag2 = (Operators.ConditionalCompareObjectNotEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 13, false) && Operators.ConditionalCompareObjectNotEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 29, false) && Operators.ConditionalCompareObjectNotEqual(this.gridex2.CurrentRow.Cells["dptype_id"].Value, 32, false));
					if (flag2)
					{
						flag = true;
					}
				}
			}
			flag2 = !flag;
			if (flag2)
			{
				bool flag3 = gridEX.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
				if (flag3)
				{
					bool flag4 = Operators.ConditionalCompareObjectNotEqual(gridEX.CurrentRow.Cells["moshtari_id"].Value, -1, false);
					if (flag4)
					{
						Frm_SuratHesab_Moshtari arg_2F0_0 = frm_SuratHesab_Moshtari;
						object expr_2DE = gridEX.CurrentRow.Cells["moshtari_id"].Value;
						int? num;
						arg_2F0_0.Moshtari_id = ((expr_2DE != null) ? ((int?)expr_2DE) : num);
						frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(gridEX.CurrentRow.Cells["Moshtari_Name"].Value);
					}
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00113958 File Offset: 0x00111B58
		private void SetHeader(StiReport rpt)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
				stiText.Font = new Font("times new roman", 12f);
			}
			stiText = (StiText)rpt.GetComponentByName("head2");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head2"];
			}
			stiText = (StiText)rpt.GetComponentByName("tarikh");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			}
			flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag2)
				{
					rpt.Pages[0].Watermark.Angle = 45f;
					rpt.Pages[0].Watermark.Text = "آزمایشی";
				}
			}
			else
			{
				rpt.Pages[0].Watermark = null;
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00113A9C File Offset: 0x00111C9C
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\daryaftpardakht.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Clone();
			dataTable2.TableName = "daryaft";
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 1, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false))
					{
						goto IL_B5;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false))
					{
						goto IL_B5;
					}
					bool arg_B7_0 = false;
					IL_B6:
					bool flag = arg_B7_0;
					if (!flag)
					{
						dataTable2.ImportRow(dataRow);
					}
					continue;
					IL_B5:
					arg_B7_0 = true;
					goto IL_B6;
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
			DataTable dataTable3 = (DataTable)this.gridex2.DataSource;
			DataTable dataTable4 = dataTable3.Clone();
			try
			{
				IEnumerator enumerator2 = dataTable3.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					if (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 10, false) || Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 11, false))
					{
						goto IL_18B;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 12, false))
					{
						goto IL_18B;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 18, false))
					{
						goto IL_1A8;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 20, false))
					{
						goto IL_1C5;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 22, false))
					{
						goto IL_1E5;
					}
					bool arg_1E7_0 = false;
					IL_1E6:
					bool flag = arg_1E7_0;
					if (!flag)
					{
						dataTable4.ImportRow(dataRow2);
					}
					continue;
					IL_1E5:
					arg_1E7_0 = true;
					goto IL_1E6;
					IL_1C5:
					goto IL_1E5;
					IL_1A8:
					goto IL_1C5;
					IL_18B:
					goto IL_1A8;
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
			dataTable4.TableName = "pardakht";
			stiReport.RegData(dataTable2);
			stiReport.RegData(dataTable4);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text15");
			stiText.Text.Value = this.txt_tarikh.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text18");
			stiText.Text.Value = this.lbl_daryafti.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text19");
			stiText.Text.Value = this.lbl_pardakhti.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text21");
			stiText.Text.Value = this.Label20.Text;
			this.SetHeader(stiReport);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text9,Text12,Text18,Text19");
			stiReport.Print(false);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00113DF8 File Offset: 0x00111FF8
		private void UiButton4_Click(object sender, EventArgs e)
		{
			bool flag = this.gridex2.CurrentRow.Cells["moshtari_id"].Value == DBNull.Value;
			if (flag)
			{
				Public_Function.GridRaiseSoftError(this.gridex2, this.gridex2.CurrentRow, "moshtari_name", "حساب بانکی را وارد نمائید");
			}
			else
			{
				varizprint varizprint = new varizprint();
				DataTable dataTable = ((DataTable)this.gridex2.DataSource).Clone();
				dataTable.ImportRow(((DataRowView)this.gridex2.CurrentRow.DataRow).Row);
				varizprint.dt = dataTable;
				varizprint.ShowReport(false);
				flag = (this.Group_DnaghdCheck.Parent == this.Group_Right);
				GridEX gridEX;
				if (flag)
				{
					gridEX = this.GridEX1;
				}
				else
				{
					gridEX = this.gridex2;
				}
				gridEX.Col = 0;
				gridEX.MoveToNewRecord();
				gridEX.Focus();
				gridEX.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00113EF0 File Offset: 0x001120F0
		private void UiButton5_Click(object sender, EventArgs e)
		{
			varizprint varizprint = new varizprint();
			DataTable dataTable = ((DataTable)this.gridex2.DataSource).Clone();
			dataTable.ImportRow(((DataRowView)this.gridex2.CurrentRow.DataRow).Row);
			varizprint.dt = dataTable;
			varizprint.ShowReport(true);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00113F4C File Offset: 0x0011214C
		private void txt_moshtariHesab_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.gridex2.CurrentRow.Cells["moshtari_id"].Value == DBNull.Value;
			if (!flag)
			{
				this.txt_moshtariHesab.SelectCommand = Conversions.ToString(Operators.ConcatenateObject("SELECT     Moshtari_Hesab.ID, Bank.Name + '-' + Moshtari_Hesab.Bank_Hesab AS Name  FROM         Moshtari_Hesab INNER JOIN   Bank ON Moshtari_Hesab.Bank_ID = Bank.ID where moshtari_id=", this.gridex2.CurrentRow.Cells["moshtari_id"].Value));
				this.txt_moshtariHesab.ExtraData = Conversions.ToLong(this.gridex2.CurrentRow.Cells["moshtari_id"].Value);
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00113FF4 File Offset: 0x001121F4
		private void txt_moshtariHesab_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "moshtarihesab_id", Conversions.ToString(this.txt_moshtariHesab.Value));
			this.SetRowValue(this.gridex2, "moshtarihesab_name", this.txt_moshtariHesab.Text);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00114044 File Offset: 0x00112244
		private void txt_moshtariHesab_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtarihesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtarihesab_name"] = DBNull.Value;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x001140A0 File Offset: 0x001122A0
		private void UiButton6_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtariHesab.Value == null;
			if (flag)
			{
				this.txt_moshtariHesab.RaiseSoftError();
			}
			else
			{
				varizprint varizprint = new varizprint();
				DataTable dataTable = ((DataTable)this.gridex2.DataSource).Clone();
				dataTable.ImportRow(((DataRowView)this.gridex2.CurrentRow.DataRow).Row);
				dataTable.Rows[0]["moshtarihesab_name"] = this.txt_moshtariHesab.Text;
				dataTable.Rows[0]["moshtarihesab_id"] = RuntimeHelpers.GetObjectValue(this.txt_moshtariHesab.Value);
				dataTable.Rows[0]["mablagh"] = this.CurrencyBox1.Value;
				varizprint.dt = dataTable;
				varizprint.ShowReport(false);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00114194 File Offset: 0x00112394
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "bankhesab_id", Conversions.ToString(this.txt_kart_bankhesab.Value));
			this.SetRowValue(this.gridex2, "bankhesab_name", this.txt_kart_bankhesab.Text);
			this.txt_babat_kart.Focus();
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x001141F0 File Offset: 0x001123F0
		private void txt_kart_bankhesab_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0011424C File Offset: 0x0011244C
		private void txt_kart_bankhesab_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_babat_kart.Focus();
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00114278 File Offset: 0x00112478
		private void txt_bank_hazine_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "bankhesab_id", Conversions.ToString(this.txt_bank_hazine.Value));
			this.SetRowValue(this.gridex2, "bankhesab_name", this.txt_bank_hazine.Text);
			this.txt_babat_hazine_bank.Focus();
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x001141F0 File Offset: 0x001123F0
		private void txt_bank_hazine_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x001142D4 File Offset: 0x001124D4
		private void txt_bank_shcheck_ButtonClick(object sender, EventArgs e)
		{
			Frm_SelectDasteCheck frm_SelectDasteCheck = new Frm_SelectDasteCheck();
			bool flag = this.txt_bank_bankhesab.Value != null;
			if (flag)
			{
				frm_SelectDasteCheck.BankHesab_ID = Conversions.ToInteger(this.txt_bank_bankhesab.Value);
				frm_SelectDasteCheck.BankHesab_Name = this.txt_bank_bankhesab.Text;
			}
			frm_SelectDasteCheck.Pardakht_Table = (DataTable)this.gridex2.DataSource;
			frm_SelectDasteCheck.ShowDialog();
			flag = (frm_SelectDasteCheck.ShomareBarg != null);
			if (flag)
			{
				this.txt_bank_shcheck.SetValue(frm_SelectDasteCheck.ShomareBarg, frm_SelectDasteCheck.ID);
				this.SetRowValue(this.gridex2, "checkbarg_id", Conversions.ToString(this.txt_bank_shcheck.Value));
				this.SetRowValue(this.gridex2, "sh_check", this.txt_bank_shcheck.Text);
			}
			this.txt_bank_babat.Focus();
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x001143C0 File Offset: 0x001125C0
		private void txt_bank_bankhesab_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.gridex2.CurrentRow == null;
			if (!flag)
			{
				flag = (((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtari_id"] == DBNull.Value);
				if (flag)
				{
					Public_Function.GridRaiseSoftError(this.gridex2, this.gridex2.CurrentRow, "moshtari_name", "لطفا بانک مقصد را انتخاب فرمائید");
				}
				else
				{
					this.txt_bank_bankhesab.SelectCommand = Conversions.ToString(Operators.ConcatenateObject("SELECT     Bank_Hesab.ID,Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where visible is null and bank_hesab.id<>", ((DataRowView)this.gridex2.CurrentRow.DataRow)["moshtari_id"]));
				}
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00114474 File Offset: 0x00112674
		private void txt_bank_bankhesab_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "bankhesab_id", Conversions.ToString(this.txt_bank_bankhesab.Value));
			this.SetRowValue(this.gridex2, "bankhesab_name", this.txt_bank_bankhesab.Text);
			this.txt_bank_shcheck.Focus();
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x001144D0 File Offset: 0x001126D0
		private void txt_bank_bankhesab_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["checkbarg_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["sh_check"] = DBNull.Value;
			this.txt_bank_shcheck.Text = string.Empty;
			this.txt_bank_shcheck.Value = null;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00114594 File Offset: 0x00112794
		private void txt_bank_shcheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_bank_shcheck_ButtonClick(null, null);
			}
			flag = (e.KeyCode == Keys.Delete);
			if (flag)
			{
				((DataRowView)this.gridex2.CurrentRow.DataRow)["checkbarg_id"] = DBNull.Value;
				((DataRowView)this.gridex2.CurrentRow.DataRow)["sh_check"] = DBNull.Value;
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00114614 File Offset: 0x00112814
		private void txt_nahvePardakht_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = ((DataRowView)this.gridex2.GetRow().DataRow)["moshtari_id2"] != DBNull.Value;
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectNotEqual(((DataRowView)this.gridex2.GetRow().DataRow)["moshtari_id2"], this.txt_nahvePardakht.Value, false);
				if (flag2)
				{
					this.txt_nahvePardakht_ValueDeleted(this.txt_nahvePardakht, null);
				}
			}
			this.SetRowValue(this.gridex2, "moshtari_id2", Conversions.ToString(this.txt_nahvePardakht.Value));
			this.Label36.Visible = false;
			this.txt_hazine_shcheck.Visible = false;
			this.Label37.Visible = false;
			this.txt_hazine_sarresid.Visible = false;
			this.Label41.Visible = false;
			this.txt_hazine_kartbekart.Visible = false;
			object value = this.txt_nahvePardakht.Value;
			flag2 = Operators.ConditionalCompareObjectEqual(value, 1, false);
			if (flag2)
			{
				this.Label36.Visible = false;
				this.txt_hazine_shcheck.Visible = false;
				this.Label37.Visible = false;
				this.txt_hazine_sarresid.Visible = false;
				this.Label42.Visible = false;
				this.txt_hazinetankhah.Visible = false;
				this.Label41.Visible = false;
				this.txt_hazine_kartbekart.Visible = false;
				this.txt_babat_hazine.Focus();
			}
			else
			{
				flag2 = Operators.ConditionalCompareObjectEqual(value, 2, false);
				if (flag2)
				{
					this.Label36.Visible = true;
					this.txt_hazine_shcheck.Visible = true;
					this.Label37.Visible = true;
					this.txt_hazine_sarresid.Visible = true;
					this.Label42.Visible = false;
					this.txt_hazinetankhah.Visible = false;
					this.Label41.Visible = false;
					this.txt_hazine_kartbekart.Visible = false;
					this.txt_hazine_shcheck.Focus();
				}
				else
				{
					flag2 = Operators.ConditionalCompareObjectEqual(value, 3, false);
					if (flag2)
					{
						this.Label36.Visible = true;
						this.txt_hazine_shcheck.Visible = true;
						this.Label42.Visible = false;
						this.txt_hazinetankhah.Visible = false;
						this.Label41.Visible = false;
						this.txt_hazine_kartbekart.Visible = false;
						this.txt_hazine_shcheck.Focus();
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(value, 4, false);
						if (flag2)
						{
							this.Label36.Visible = false;
							this.txt_hazine_shcheck.Visible = false;
							this.Label37.Visible = false;
							this.txt_hazine_sarresid.Visible = false;
							this.Label42.Visible = false;
							this.txt_hazinetankhah.Visible = false;
							this.Label41.Visible = true;
							this.txt_hazine_kartbekart.Visible = true;
							this.txt_hazine_kartbekart.Focus();
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(value, 5, false);
							if (flag2)
							{
								this.Label36.Visible = false;
								this.txt_hazine_shcheck.Visible = false;
								this.Label37.Visible = false;
								this.txt_hazine_sarresid.Visible = false;
								this.Label41.Visible = false;
								this.txt_hazine_kartbekart.Visible = false;
								this.Label42.Visible = true;
								this.txt_hazinetankhah.Visible = true;
								this.txt_hazinetankhah.Focus();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x001149AC File Offset: 0x00112BAC
		private void Sync_Check_Info(DataTable dt)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false) && dataRow["id"] != DBNull.Value && dataRow.RowState == DataRowState.Added;
					if (flag)
					{
						DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject("ID=", dataRow["ID"])));
						flag = (array.Length > 0);
						if (flag)
						{
							array[0]["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh"]);
							array[0]["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Moshtari_ID"]);
							array[0]["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
							array[0]["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow["Tozih"]);
							array[0]["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh_Fa"]);
							array[0]["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
							array[0]["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
							array[0]["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
							array[0]["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
							array[0]["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Moshtari_Name"]);
							array[0]["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
						}
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

		// Token: 0x06001865 RID: 6245 RVA: 0x00114BF8 File Offset: 0x00112DF8
		public void Check_Select()
		{
			Frm_SelectItem frm_SelectItem = new Frm_SelectItem();
			frm_SelectItem.items = new ItemCollection
			{
				new Column("Sh_Check", "شماره چک ", 20),
				new Column("Mablagh", "مبلغ", 20),
				new Column("Bank_Name", "بانک", 10),
				new Column("Check_Shobe", "شعبه", 20),
				new Column("Check_Sarresid_Fa", "سررسید", 15),
				new Column("Tarikh_fa", "تاریخ دریافت", 15)
			};
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " AND DaryaftPardakht.ID NOT IN(" + text + ")";
			}
			DataTable dataTable2 = Public_Function.FillData("SELECT   DaryaftPardakht.dptype_id,DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe,DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + text + " order by check_sarresid_Fa");
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			try
			{
				IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], -99, false);
					if (flag)
					{
						dataRow2["tarikh_fa"] = "اول دوره";
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
			this.Sync_Check_Info(dataTable2);
			flag = (frm_SelectItem.ShowDialog(dataTable2, null, "انتخاب چک") == DialogResult.OK);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(frm_SelectItem.SelectedRow["ID"], 0, false);
				if (flag2)
				{
					this.txt_hazine_shcheck.SetValue(Conversions.ToString(frm_SelectItem.SelectedRow["sh_check"]), RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow["ID"]));
				}
				else
				{
					this.txt_hazine_shcheck.SetValue(Conversions.ToString(frm_SelectItem.SelectedRow["sh_check"]), RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow["daryaft_identity"]));
				}
				this.SetRowValue(this.gridex2, "sh_check", this.txt_hazine_shcheck.Text);
				this.SetRowValue(this.gridex2, "Mablagh", Conversions.ToString(frm_SelectItem.SelectedRow["Mablagh"]));
				flag2 = (frm_SelectItem.SelectedRow["CheckBank_ID"] != DBNull.Value);
				if (flag2)
				{
					this.SetRowValue(this.gridex2, "CheckBank_ID", Conversions.ToString(frm_SelectItem.SelectedRow["CheckBank_ID"]));
				}
				this.SetRowValue(this.gridex2, "Check_Sarresid_Fa", Conversions.ToString(frm_SelectItem.SelectedRow["Check_Sarresid_Fa"]));
				this.SetRowValue(this.gridex2, "Check_Shobe", Conversions.ToString(frm_SelectItem.SelectedRow["Check_Shobe"]));
				flag2 = (frm_SelectItem.SelectedRow["ID"] != DBNull.Value);
				if (flag2)
				{
					this.SetRowValue(this.gridex2, "PardakhtCheck_ID", Conversions.ToString(frm_SelectItem.SelectedRow["ID"]));
				}
				flag2 = (frm_SelectItem.SelectedRow["daryaft_identity"] != DBNull.Value);
				if (flag2)
				{
					this.SetRowValue(this.gridex2, "daryaft_identity", Conversions.ToString(frm_SelectItem.SelectedRow["daryaft_identity"]));
				}
				flag2 = (frm_SelectItem.SelectedRow["Check_ShomareHesab"] != DBNull.Value);
				if (flag2)
				{
					this.SetRowValue(this.gridex2, "Check_ShomareHesab", Conversions.ToString(frm_SelectItem.SelectedRow["Check_ShomareHesab"]));
				}
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x001150E0 File Offset: 0x001132E0
		private void txt_hazine_shcheck_ButtonClick(object sender, EventArgs e)
		{
			object value = this.txt_nahvePardakht.Value;
			bool flag = Operators.ConditionalCompareObjectEqual(value, 1, false);
			if (!flag)
			{
				flag = Operators.ConditionalCompareObjectEqual(value, 2, false);
				if (flag)
				{
					Frm_SelectDasteCheck frm_SelectDasteCheck = new Frm_SelectDasteCheck();
					frm_SelectDasteCheck.Pardakht_Table = (DataTable)this.gridex2.DataSource;
					frm_SelectDasteCheck.ShowDialog();
					flag = (frm_SelectDasteCheck.ShomareBarg != null);
					if (flag)
					{
						this.txt_hazine_shcheck.SetValue(frm_SelectDasteCheck.ShomareBarg, frm_SelectDasteCheck.ID);
						this.SetRowValue(this.gridex2, "checkbarg_id", Conversions.ToString(this.txt_hazine_shcheck.Value));
						this.SetRowValue(this.gridex2, "sh_check", this.txt_hazine_shcheck.Text);
						this.SetRowValue(this.gridex2, "BankHesab_ID", Conversions.ToString(frm_SelectDasteCheck.BankHesab_ID));
						this.txt_hazine_sarresid.Focus();
					}
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(value, 3, false);
					if (flag)
					{
						this.Check_Select();
						this.txt_babat_hazine.Focus();
					}
				}
			}
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00115210 File Offset: 0x00113410
		private void txt_hazine_shcheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_hazine_shcheck_ButtonClick(null, null);
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000072FF File Offset: 0x000054FF
		private void txt_hazine_sarresid_Validated(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "check_sarresid_fa", this.txt_hazine_sarresid.Text);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00115238 File Offset: 0x00113438
		private void txt_nahvePardakht_ValueDeleted(object sender, EventArgs e)
		{
			this.txt_hazine_shcheck.SetNew();
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["checkbarg_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["sh_check"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["check_sarresid_fa"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["CheckBank_ID"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["Check_Shobe"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["daryaft_identity"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["Check_ShomareHesab"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["PardakhtCheck_ID"] = DBNull.Value;
			bool flag = sender.Equals(this.txt_nahvePardakht);
			if (flag)
			{
				this.Label37.Visible = false;
				this.Label36.Visible = false;
				this.Label41.Visible = false;
				this.Label42.Visible = false;
				this.txt_hazine_sarresid.Visible = false;
				this.txt_hazine_shcheck.Visible = false;
				this.txt_hazine_kartbekart.Visible = false;
				this.txt_hazinetankhah.Visible = false;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00115440 File Offset: 0x00113640
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.gridex1focused;
			if (flag)
			{
				this.ButtonItem4_Click(null, null);
			}
			else
			{
				this.ButtonItem5_Click(null, null);
			}
			this.gridex2_RecordAdded(null, null);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00115478 File Offset: 0x00113678
		private void txt_jens_Validated(object sender, EventArgs e)
		{
			((DataRowView)this.GridEX1.CurrentRow.DataRow)["Tozih"] = string.Concat(new string[]
			{
				this.txt_jens.Text,
				"-",
				this.txt_tedad.Text,
				"-",
				this.txt_vazn.Text
			});
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x001154F4 File Offset: 0x001136F4
		private void txt_search1_ButtonClick(object sender, EventArgs e)
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			checked
			{
				while (this.frm.ShowDialog(this.dt_search1, null, "جستجوی دریافت") != DialogResult.Cancel)
				{
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow gridEXRow = rows[i];
						bool flag = gridEXRow.Cells["moshtari_Name"].Value == DBNull.Value;
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["moshtari_Name"].Value, this.frm.SelectedRow["name"], false);
							if (flag)
							{
								bool flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 4, false);
								if (flag2)
								{
									this.GridEX1.Focus();
									this.GridEX1.Row = gridEXRow.Position;
									this.GridEX1.Focus();
									this.UiButton1.PerformClick();
								}
							}
						}
					}
				}
				this.frm.CanEdit = false;
				this.frm.Edit_Frm = null;
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00115684 File Offset: 0x00113884
		private void txt_search1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_search1_ButtonClick(null, null);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x001156AC File Offset: 0x001138AC
		private void txt_search2_ButtonClick(object sender, EventArgs e)
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			checked
			{
				while (this.frm.ShowDialog(this.dt_search2, null, "جستجوی پرداخت") != DialogResult.Cancel)
				{
					GridEXRow[] rows = this.gridex2.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow gridEXRow = rows[i];
						bool flag = gridEXRow.Cells["moshtari_Name"].Value == DBNull.Value;
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["moshtari_Name"].Value, this.frm.SelectedRow["name"], false);
							if (flag)
							{
								bool flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["dptype_id"].Value, 13, false);
								if (flag2)
								{
									this.gridex2.Focus();
									this.gridex2.Row = gridEXRow.Position;
									this.gridex2.Focus();
									this.UiButton1.PerformClick();
								}
							}
						}
					}
				}
				this.frm.CanEdit = false;
				this.frm.Edit_Frm = null;
				this.gridex2.Focus();
				this.gridex2.MoveToNewRecord();
				this.gridex2.Col = 0;
				this.gridex2.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0011583C File Offset: 0x00113A3C
		private void txt_search2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_search2_ButtonClick(null, null);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0000205D File Offset: 0x0000025D
		private void txt_tarikh_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0000205D File Offset: 0x0000025D
		private void Bar1_ItemClick(object sender, EventArgs e)
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00007320 File Offset: 0x00005520
		public void ShowFurushRuzane(object tarikh)
		{
			this.ShowFurush_Ruzane(Conversions.ToString(tarikh));
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00115864 File Offset: 0x00113A64
		private void ButtonItem4_Click_1(object sender, EventArgs e)
		{
			Frm_KhordeFurushi frm_KhordeFurushi = new Frm_KhordeFurushi();
			frm_KhordeFurushi.tarikh = this.txt_tarikh.Text;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_KhordeFurushi);
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			DataTable pardakhtRefresh = daryaftPardakht.GetPardakhtRefresh(this.txt_tarikh.Text);
			DataTable dataTable = (DataTable)this.gridex2.DataSource;
			try
			{
				IEnumerator enumerator = pardakhtRefresh.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
					}
					else
					{
						dataTable.ImportRow(dataRow);
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
			dataTable.AcceptChanges();
			int arg_118_0 = 0;
			checked
			{
				int num = dataTable.Rows.Count - 1;
				int num2 = arg_118_0;
				bool flag;
				while (true)
				{
					int arg_1C0_0 = num2;
					int num3 = num;
					if (arg_1C0_0 > num3)
					{
						break;
					}
					flag = (num2 > dataTable.Rows.Count - 1);
					if (flag)
					{
						break;
					}
					flag = (dataTable.Rows[num2]["ID"] == DBNull.Value);
					if (!flag)
					{
						DataRow[] array = pardakhtRefresh.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataTable.Rows[num2]["ID"])));
						flag = (array.Length == 0);
						if (flag)
						{
							dataTable.Rows[num2].Delete();
						}
					}
					num2++;
				}
				dataTable.AcceptChanges();
				this.gridex2_RecordAdded(null, null);
				this.gridex2.Refresh();
				long num4 = this.Sandug.PardakhtNaghd(this.txt_tarikh.Text);
				flag = (num4 == 0L);
				if (flag)
				{
					this.lbl_pardakhti.Text = Public_Function.ToFarsi(Conversions.ToString(0));
				}
				else
				{
					this.lbl_pardakhti.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num4)));
				}
				flag = this.gridex1focused;
				if (flag)
				{
					this.GridEX1.EditMode = EditMode.EditOn;
				}
				else
				{
					this.gridex2.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00115AEC File Offset: 0x00113CEC
		public void Refresh_Keraye()
		{
			DataTable keraye = this.dp.GetKeraye(this.txt_tarikh.Text);
			DataTable dataTable = (DataTable)this.gridex2.DataSource;
			try
			{
				IEnumerator enumerator = keraye.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
					}
					else
					{
						dataTable.ImportRow(dataRow);
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
			dataTable.AcceptChanges();
			int arg_EB_0 = 0;
			checked
			{
				int num = dataTable.Rows.Count - 1;
				int num2 = arg_EB_0;
				bool flag;
				while (true)
				{
					int arg_1EA_0 = num2;
					int num3 = num;
					if (arg_1EA_0 > num3)
					{
						break;
					}
					flag = (num2 > dataTable.Rows.Count - 1);
					if (flag)
					{
						break;
					}
					flag = (dataTable.Rows[num2]["ID"] == DBNull.Value);
					if (!flag)
					{
						flag = (dataTable.Rows[num2]["dptype_id"] == DBNull.Value);
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num2]["dptype_id"], -2, false);
							if (!flag)
							{
								DataRow[] array = keraye.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataTable.Rows[num2]["ID"])));
								flag = (array.Length == 0);
								if (flag)
								{
									dataTable.Rows[num2].Delete();
								}
							}
						}
					}
					num2++;
				}
				dataTable.AcceptChanges();
				this.gridex2_RecordAdded(null, null);
				this.gridex2.Refresh();
				long num4 = this.Sandug.PardakhtNaghd(this.txt_tarikh.Text);
				flag = (num4 == 0L);
				if (flag)
				{
					this.lbl_pardakhti.Text = Public_Function.ToFarsi(Conversions.ToString(0));
				}
				else
				{
					this.lbl_pardakhti.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num4)));
				}
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00115D70 File Offset: 0x00113F70
		public void Refresh_Furush_Naghd()
		{
			DataTable furushNaghd = this.dp.GetFurushNaghd(this.txt_tarikh.Text);
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			try
			{
				IEnumerator enumerator = furushNaghd.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
					}
					else
					{
						dataTable.ImportRow(dataRow);
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
			dataTable.AcceptChanges();
			int arg_EB_0 = 0;
			checked
			{
				int num = dataTable.Rows.Count - 1;
				int num2 = arg_EB_0;
				bool flag;
				while (true)
				{
					int arg_1E9_0 = num2;
					int num3 = num;
					if (arg_1E9_0 > num3)
					{
						break;
					}
					flag = (num2 > dataTable.Rows.Count - 1);
					if (flag)
					{
						break;
					}
					flag = (dataTable.Rows[num2]["dptype_id"] == DBNull.Value);
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num2]["dptype_id"], -1, false);
						if (!flag)
						{
							flag = (dataTable.Rows[num2]["ID"] == DBNull.Value);
							if (!flag)
							{
								DataRow[] array = furushNaghd.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataTable.Rows[num2]["ID"])));
								flag = (array.Length == 0);
								if (flag)
								{
									dataTable.Rows[num2].Delete();
								}
							}
						}
					}
					num2++;
				}
				dataTable.AcceptChanges();
				this.gridex2_RecordAdded(null, null);
				this.GridEX1.Refresh();
				this.GridEX1.UpdateData();
				long num4 = this.Sandug.DaryaftNaghd(this.txt_tarikh.Text);
				flag = (num4 == 0L);
				if (flag)
				{
					this.lbl_daryafti.Text = Public_Function.ToFarsi(Conversions.ToString(0));
				}
				else
				{
					this.lbl_daryafti.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num4)));
				}
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00116000 File Offset: 0x00114200
		private void ShowFurush_Ruzane(string tarikh)
		{
			new Frm_FurushRuzane
			{
				Tarikh = tarikh
			}.ShowDialog();
			DataTable daryaftRefresh = this.dp.GetDaryaftRefresh(this.txt_tarikh.Text);
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			try
			{
				IEnumerator enumerator = daryaftRefresh.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
					}
					else
					{
						dataTable.ImportRow(dataRow);
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
			dataTable.AcceptChanges();
			int arg_100_0 = 0;
			checked
			{
				int num = dataTable.Rows.Count - 1;
				int num2 = arg_100_0;
				bool flag;
				while (true)
				{
					int arg_1A8_0 = num2;
					int num3 = num;
					if (arg_1A8_0 > num3)
					{
						break;
					}
					flag = (num2 > dataTable.Rows.Count - 1);
					if (flag)
					{
						break;
					}
					flag = (dataTable.Rows[num2]["ID"] == DBNull.Value);
					if (!flag)
					{
						DataRow[] array = daryaftRefresh.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataTable.Rows[num2]["ID"])));
						flag = (array.Length == 0);
						if (flag)
						{
							dataTable.Rows[num2].Delete();
						}
					}
					num2++;
				}
				dataTable.AcceptChanges();
				this.gridex2_RecordAdded(null, null);
				this.gridex2.Refresh();
				long num4 = this.Sandug.PardakhtNaghd(this.txt_tarikh.Text);
				flag = (num4 == 0L);
				if (flag)
				{
					this.lbl_pardakhti.Text = Public_Function.ToFarsi(Conversions.ToString(0));
				}
				else
				{
					this.lbl_pardakhti.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num4)));
				}
				flag = this.gridex1focused;
				if (flag)
				{
					this.GridEX1.EditMode = EditMode.EditOn;
				}
				else
				{
					this.gridex2.EditMode = EditMode.EditOn;
				}
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00007331 File Offset: 0x00005531
		private void ButtonItem5_Click_1(object sender, EventArgs e)
		{
			this.ShowFurush_Ruzane(this.txt_tarikh.Text);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00116270 File Offset: 0x00114470
		private void txt_nahvepardakht_agsat_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "moshtari_id2", Conversions.ToString(this.txt_nahvepardakht_agsat.Value));
			bool flag = Operators.ConditionalCompareObjectEqual(this.txt_nahvepardakht_agsat.Value, 1, false);
			if (flag)
			{
				this.Label47.Visible = false;
				this.txt_bankhesab_gest.Visible = false;
				this.txt_babat_agsat.Focus();
			}
			else
			{
				this.Label47.Visible = true;
				this.txt_bankhesab_gest.Visible = true;
				this.txt_bankhesab_gest.Focus();
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0011630C File Offset: 0x0011450C
		private void txt_nahvedaryafttankhah_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "moshtari_id2", Conversions.ToString(this.txt_nahvePardakhtTankhah.Value));
			bool flag = Operators.ConditionalCompareObjectEqual(this.txt_nahvePardakhtTankhah.Value, 1, false);
			if (flag)
			{
				this.txt_tankhah_hesabbanki.SetNew();
				this.txt_tankhah_hesabbanki.AllowEdit = false;
			}
			else
			{
				this.txt_tankhah_hesabbanki.AllowEdit = true;
			}
			flag = Operators.ConditionalCompareObjectEqual(this.txt_nahvePardakhtTankhah.Value, 1, false);
			if (flag)
			{
				this.txt_babattankhah.Focus();
			}
			else
			{
				this.txt_tankhah_hesabbanki.Focus();
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x001163BC File Offset: 0x001145BC
		private void txt_tankhah_hesabbanki_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "bankhesab_id", Conversions.ToString(this.txt_tankhah_hesabbanki.Value));
			this.SetRowValue(this.gridex2, "bankhesab_name", this.txt_tankhah_hesabbanki.Text);
			this.txt_babattankhah.Focus();
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x001141F0 File Offset: 0x001123F0
		private void txt_tankhah_hesabbanki_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00116418 File Offset: 0x00114618
		private void txt_nahvedaryafttankhah_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.txt_nahvePardakhtTankhah.Value != null;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.txt_nahvePardakhtTankhah.Value, 1, false);
				if (flag2)
				{
					this.txt_babattankhah.Focus();
				}
				else
				{
					this.txt_tankhah_hesabbanki.Focus();
				}
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00116474 File Offset: 0x00114674
		private void txt_nahvePardakht_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.txt_nahvePardakht.Value != null;
				if (flag2)
				{
					object value = this.txt_nahvePardakht.Value;
					bool flag3 = Operators.ConditionalCompareObjectEqual(value, 1, false);
					if (flag3)
					{
						this.txt_babat_hazine.Focus();
					}
					else
					{
						flag3 = Operators.ConditionalCompareObjectEqual(value, 2, false);
						if (flag3)
						{
							this.txt_hazine_shcheck.Focus();
						}
						else
						{
							flag3 = Operators.ConditionalCompareObjectEqual(value, 3, false);
							if (flag3)
							{
								this.txt_hazine_shcheck.Focus();
							}
							else
							{
								flag3 = Operators.ConditionalCompareObjectEqual(value, 4, false);
								if (flag3)
								{
									this.txt_hazine_kartbekart.Focus();
								}
								else
								{
									flag3 = Operators.ConditionalCompareObjectEqual(value, 5, false);
									if (flag3)
									{
										this.txt_hazine_kartbekart.Focus();
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0011655C File Offset: 0x0011475C
		private void txt_hazine_kartbekart_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_babat_hazine.Focus();
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00116588 File Offset: 0x00114788
		private void txt_hazine_kartbekart_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = sender.Equals(this.txt_hazine_kartbekart);
			if (flag)
			{
				this.SetRowValue(this.gridex2, "bankhesab_id", Conversions.ToString(this.txt_hazine_kartbekart.Value));
				this.SetRowValue(this.gridex2, "bankhesab_name", this.txt_hazine_kartbekart.Text);
			}
			flag = sender.Equals(this.txt_hazinetankhah);
			if (flag)
			{
				this.SetRowValue(this.gridex2, "hazine_id", Conversions.ToString(this.txt_hazinetankhah.Value));
				this.SetRowValue(this.gridex2, "hazine_name", this.txt_hazinetankhah.Text);
			}
			this.txt_babat_hazine.Focus();
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00116644 File Offset: 0x00114844
		private void txt_hazine_kartbekart_ValueDeleted(object sender, EventArgs e)
		{
			bool flag = sender.Equals(this.txt_hazine_kartbekart);
			if (flag)
			{
				((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
				((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
			}
			flag = sender.Equals(this.txt_hazinetankhah);
			if (flag)
			{
				((DataRowView)this.gridex2.CurrentRow.DataRow)["hazine_id"] = DBNull.Value;
				((DataRowView)this.gridex2.CurrentRow.DataRow)["hazine_name"] = DBNull.Value;
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0011670C File Offset: 0x0011490C
		private void txt_be_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "bemoshtari_id", Conversions.ToString(this.txt_be_moshtari.Value));
			this.SetRowValue(this.gridex2, "bemoshtari_name", this.txt_be_moshtari.Text);
			this.txt_babat_moshtari_be_moshtari.Focus();
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00116768 File Offset: 0x00114968
		private void txt_be_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bemoshtari_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bemoshtari_name"] = DBNull.Value;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x001167C4 File Offset: 0x001149C4
		private void txt_bs_shCheck_ButtonClick(object sender, EventArgs e)
		{
			Frm_SelectDasteCheck frm_SelectDasteCheck = new Frm_SelectDasteCheck();
			frm_SelectDasteCheck.Pardakht_Table = (DataTable)this.GridEX1.DataSource;
			frm_SelectDasteCheck.ShowDialog();
			bool flag = frm_SelectDasteCheck.ShomareBarg != null;
			if (flag)
			{
				this.txt_bs_shCheck.SetValue(frm_SelectDasteCheck.ShomareBarg, frm_SelectDasteCheck.ID);
				this.SetRowValue(this.GridEX1, "checkbarg_id", Conversions.ToString(this.txt_bs_shCheck.Value));
				this.SetRowValue(this.GridEX1, "sh_check", this.txt_bs_shCheck.Text);
				this.SetRowValue(this.GridEX1, "BankHesab_ID", Conversions.ToString(frm_SelectDasteCheck.BankHesab_ID));
			}
			this.txt_bs_babat.Focus();
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00116890 File Offset: 0x00114A90
		private void txt_bs_shCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_bs_shCheck_ButtonClick(null, null);
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x001168B8 File Offset: 0x00114AB8
		private void txt_bankhesab_gest_SelectedValueChanged(object sender, EventArgs e)
		{
			this.SetRowValue(this.gridex2, "bankhesab_id", Conversions.ToString(this.txt_bankhesab_gest.Value));
			this.SetRowValue(this.gridex2, "bankhesab_name", this.txt_bankhesab_gest.Text);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x001141F0 File Offset: 0x001123F0
		private void txt_bankhesab_gest_ValueDeleted(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_id"] = DBNull.Value;
			((DataRowView)this.gridex2.CurrentRow.DataRow)["bankhesab_name"] = DBNull.Value;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00116908 File Offset: 0x00114B08
		private void UiButton7_Click(object sender, EventArgs e)
		{
			GridEX gridEX = this.GridEX1;
			bool flag = Operators.ConditionalCompareObjectEqual(gridEX.CurrentRow.Cells["dptype_id"].Value, 41, false);
			if (flag)
			{
				Frm_DaryaftCheck_naghd frm_DaryaftCheck_naghd = new Frm_DaryaftCheck_naghd();
				frm_DaryaftCheck_naghd.dt_daryaft = (DataTable)this.GridEX1.DataSource;
				frm_DaryaftCheck_naghd.ListDaryaft_Identity = this.ListDaryaft_Identity;
				int position = gridEX.CurrentRow.Position;
				frm_DaryaftCheck_naghd.Pardakht_Table = (DataTable)this.GridEX1.DataSource;
				frm_DaryaftCheck_naghd.ParentDatarow = ((DataRowView)gridEX.CurrentRow.DataRow).Row;
				frm_DaryaftCheck_naghd.Tarikh = this.txt_tarikh.Text;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_DaryaftCheck_naghd);
				this.GridEX1.UpdateData();
				gridEX.Row = position;
				gridEX.CurrentRow.Cells["Mablagh"].Value = frm_DaryaftCheck_naghd.sum_mablagh;
				gridEX.Focus();
				gridEX.MoveToNewRecord();
				gridEX.Col = 0;
				gridEX.EditMode = EditMode.EditOn;
				gridEX.CurrentRow.BeginEdit();
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00116A40 File Offset: 0x00114C40
		private void ButtonItem8_Click_1(object sender, EventArgs e)
		{
			Frm_Sanad_Dasti frm_Sanad_Dasti = new Frm_Sanad_Dasti();
			frm_Sanad_Dasti.Tarikh = this.txt_tarikh.Text;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Sanad_Dasti);
			string daryaftpardakht_ID = frm_Sanad_Dasti.Daryaftpardakht_ID;
			bool dorp = frm_Sanad_Dasti.dorp;
			bool flag = Operators.CompareString(daryaftpardakht_ID, string.Empty, false) == 0;
			if (flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataRow[] array = dataTable.Select("dptype_id=-6");
				flag = (array.Length > 0);
				if (flag)
				{
					array[0].Delete();
					dataTable.AcceptChanges();
				}
				dataTable = (DataTable)this.gridex2.DataSource;
				array = dataTable.Select("dptype_id=-7");
				flag = (array.Length > 0);
				if (flag)
				{
					array[0].Delete();
					dataTable.AcceptChanges();
				}
			}
			flag = (Operators.CompareString(daryaftpardakht_ID, string.Empty, false) != 0);
			if (flag)
			{
				bool flag2 = dorp;
				if (flag2)
				{
					DataRow[] array2 = ((DataTable)this.GridEX1.DataSource).Select("dptype_id=-6");
					flag2 = (array2.Length > 0);
					if (flag2)
					{
						array2[0]["mablagh"] = frm_Sanad_Dasti.Mablagh;
						array2[0]["tozih"] = frm_Sanad_Dasti.Tozih;
						array2[0]["moshtari_name"] = frm_Sanad_Dasti.Tozih;
						this.GridEX1.UpdateData();
					}
					else
					{
						DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
						dataRow["dptype_id"] = -6;
						dataRow["dp_name"] = "سند دستی";
						dataRow["mablagh"] = frm_Sanad_Dasti.Mablagh;
						dataRow["tozih"] = frm_Sanad_Dasti.Tozih;
						dataRow["moshtari_name"] = frm_Sanad_Dasti.Tozih;
						((DataTable)this.GridEX1.DataSource).Rows.Add(dataRow);
					}
				}
				else
				{
					DataRow[] array3 = ((DataTable)this.gridex2.DataSource).Select("dptype_id=-7");
					flag2 = (array3.Length > 0);
					if (flag2)
					{
						array3[0]["mablagh"] = frm_Sanad_Dasti.Mablagh;
						array3[0]["tozih"] = frm_Sanad_Dasti.Tozih;
						array3[0]["moshtari_name"] = frm_Sanad_Dasti.Tozih;
						this.gridex2.UpdateData();
					}
					else
					{
						DataRow dataRow2 = ((DataTable)this.gridex2.DataSource).NewRow();
						dataRow2["dptype_id"] = -7;
						dataRow2["dp_name"] = "سند دستی";
						dataRow2["mablagh"] = frm_Sanad_Dasti.Mablagh;
						dataRow2["tozih"] = frm_Sanad_Dasti.Tozih;
						dataRow2["moshtari_name"] = frm_Sanad_Dasti.Tozih;
						((DataTable)this.gridex2.DataSource).Rows.Add(dataRow2);
					}
				}
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00007347 File Offset: 0x00005547
		private void txt_fee_dolar_Validated(object sender, EventArgs e)
		{
			((DataRowView)this.GridEX1.GetRow().DataRow)["fishvariz_fa"] = this.txt_fee_dolar.Value;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00116D74 File Offset: 0x00114F74
		private void txt_phavale_bank_Validated(object sender, EventArgs e)
		{
			bool flag = (DataRowView)this.gridex2.GetRow().DataRow != null;
			if (flag)
			{
				bool flag2 = this.txt_phavale_bank.Value != null;
				if (flag2)
				{
					((DataRowView)this.gridex2.GetRow().DataRow)["bemoshtari_id"] = RuntimeHelpers.GetObjectValue(this.txt_phavale_bank.Value);
					((DataRowView)this.gridex2.GetRow().DataRow)["bemoshtari_name"] = this.txt_phavale_bank.Text;
				}
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0000737B File Offset: 0x0000557B
		private void txt_pfee_dolar_Validated(object sender, EventArgs e)
		{
			((DataRowView)this.gridex2.GetRow().DataRow)["fishvariz_fa"] = this.txt_pfee_dolar.Value;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00116E14 File Offset: 0x00115014
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_rpt_Sandugh showFrm = new Frm_rpt_Sandugh
			{
				tarikh = this.txt_tarikh.Text
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x040008CD RID: 2253
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040008CF RID: 2255
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x040008D0 RID: 2256
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040008D1 RID: 2257
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008D2 RID: 2258
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040008D3 RID: 2259
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040008D4 RID: 2260
		[AccessedThroughProperty("group_dnaghd")]
		private UIGroupBox _group_dnaghd;

		// Token: 0x040008D5 RID: 2261
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040008D6 RID: 2262
		[AccessedThroughProperty("txt_babat")]
		private EditBox _txt_babat;

		// Token: 0x040008D7 RID: 2263
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040008D8 RID: 2264
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040008D9 RID: 2265
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040008DA RID: 2266
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040008DB RID: 2267
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x040008DC RID: 2268
		[AccessedThroughProperty("Panel1")]
		private PanelEx _Panel1;

		// Token: 0x040008DD RID: 2269
		[AccessedThroughProperty("group_dcheck")]
		private UIGroupBox _group_dcheck;

		// Token: 0x040008DE RID: 2270
		[AccessedThroughProperty("txt_shobe")]
		private EditBox _txt_shobe;

		// Token: 0x040008DF RID: 2271
		[AccessedThroughProperty("txt_bank")]
		private SelectItem _txt_bank;

		// Token: 0x040008E0 RID: 2272
		[AccessedThroughProperty("txt_shcheck")]
		private NumericBox _txt_shcheck;

		// Token: 0x040008E1 RID: 2273
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040008E2 RID: 2274
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040008E3 RID: 2275
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040008E4 RID: 2276
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040008E5 RID: 2277
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040008E6 RID: 2278
		[AccessedThroughProperty("txt_babatcheck")]
		private EditBox _txt_babatcheck;

		// Token: 0x040008E7 RID: 2279
		[AccessedThroughProperty("group_dfish")]
		private UIGroupBox _group_dfish;

		// Token: 0x040008E8 RID: 2280
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040008E9 RID: 2281
		[AccessedThroughProperty("txt_fishbabat")]
		private EditBox _txt_fishbabat;

		// Token: 0x040008EA RID: 2282
		[AccessedThroughProperty("txt_fishbankhesab")]
		private SelectItem _txt_fishbankhesab;

		// Token: 0x040008EB RID: 2283
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040008EC RID: 2284
		[AccessedThroughProperty("gridex2")]
		private DataEntryGrid _gridex2;

		// Token: 0x040008ED RID: 2285
		[AccessedThroughProperty("Group_DnaghdCheck")]
		private UIGroupBox _Group_DnaghdCheck;

		// Token: 0x040008EE RID: 2286
		[AccessedThroughProperty("CurrencyBox1")]
		private CurrencyBox _CurrencyBox1;

		// Token: 0x040008EF RID: 2287
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040008F0 RID: 2288
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040008F1 RID: 2289
		[AccessedThroughProperty("txt_dbabatnc")]
		private EditBox _txt_dbabatnc;

		// Token: 0x040008F2 RID: 2290
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040008F3 RID: 2291
		[AccessedThroughProperty("Group_Letf")]
		private UIGroupBox _Group_Letf;

		// Token: 0x040008F4 RID: 2292
		[AccessedThroughProperty("Group_Right")]
		private UIGroupBox _Group_Right;

		// Token: 0x040008F5 RID: 2293
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x040008F6 RID: 2294
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040008F7 RID: 2295
		[AccessedThroughProperty("txt_sarresid")]
		private DateBox2 _txt_sarresid;

		// Token: 0x040008F8 RID: 2296
		[AccessedThroughProperty("txt_mablaghpardakht")]
		private CurrencyBox _txt_mablaghpardakht;

		// Token: 0x040008F9 RID: 2297
		[AccessedThroughProperty("Highlighter1")]
		private Highlighter _Highlighter1;

		// Token: 0x040008FA RID: 2298
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040008FB RID: 2299
		[AccessedThroughProperty("Group_VarizCheck")]
		private UIGroupBox _Group_VarizCheck;

		// Token: 0x040008FC RID: 2300
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040008FD RID: 2301
		[AccessedThroughProperty("txt_babatvariz")]
		private EditBox _txt_babatvariz;

		// Token: 0x040008FE RID: 2302
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x040008FF RID: 2303
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000900 RID: 2304
		[AccessedThroughProperty("Metro_Right")]
		private MetroStatusBar _Metro_Right;

		// Token: 0x04000901 RID: 2305
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000902 RID: 2306
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000903 RID: 2307
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000904 RID: 2308
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000905 RID: 2309
		[AccessedThroughProperty("lbl_daryafti")]
		private LabelItem _lbl_daryafti;

		// Token: 0x04000906 RID: 2310
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000907 RID: 2311
		[AccessedThroughProperty("lbl_pardakhti")]
		private LabelItem _lbl_pardakhti;

		// Token: 0x04000908 RID: 2312
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000909 RID: 2313
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x0400090A RID: 2314
		[AccessedThroughProperty("Group_NaghdCheck")]
		private UIGroupBox _Group_NaghdCheck;

		// Token: 0x0400090B RID: 2315
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x0400090C RID: 2316
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x0400090D RID: 2317
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x0400090E RID: 2318
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x0400090F RID: 2319
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000910 RID: 2320
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000911 RID: 2321
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000912 RID: 2322
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000913 RID: 2323
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000914 RID: 2324
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000915 RID: 2325
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000916 RID: 2326
		[AccessedThroughProperty("GroupKartkhan")]
		private UIGroupBox _GroupKartkhan;

		// Token: 0x04000917 RID: 2327
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000918 RID: 2328
		[AccessedThroughProperty("txt_shtarakonesh")]
		private EditBox _txt_shtarakonesh;

		// Token: 0x04000919 RID: 2329
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x0400091A RID: 2330
		[AccessedThroughProperty("Group_BankVajh")]
		private UIGroupBox _Group_BankVajh;

		// Token: 0x0400091B RID: 2331
		[AccessedThroughProperty("txt_vajhbank")]
		private EditBox _txt_vajhbank;

		// Token: 0x0400091C RID: 2332
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x0400091D RID: 2333
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x0400091E RID: 2334
		[AccessedThroughProperty("UiButton5")]
		private UIButton _UiButton5;

		// Token: 0x0400091F RID: 2335
		[AccessedThroughProperty("txt_moshtariHesab")]
		private SelectItem _txt_moshtariHesab;

		// Token: 0x04000920 RID: 2336
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000921 RID: 2337
		[AccessedThroughProperty("UiButton6")]
		private UIButton _UiButton6;

		// Token: 0x04000922 RID: 2338
		[AccessedThroughProperty("Group_kart_be_Kart")]
		private UIGroupBox _Group_kart_be_Kart;

		// Token: 0x04000923 RID: 2339
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x04000924 RID: 2340
		[AccessedThroughProperty("txt_babat_kart")]
		private EditBox _txt_babat_kart;

		// Token: 0x04000925 RID: 2341
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x04000926 RID: 2342
		[AccessedThroughProperty("txt_kart_bankhesab")]
		private SelectItem _txt_kart_bankhesab;

		// Token: 0x04000927 RID: 2343
		[AccessedThroughProperty("Group_Bank_Hazine")]
		private UIGroupBox _Group_Bank_Hazine;

		// Token: 0x04000928 RID: 2344
		[AccessedThroughProperty("txt_babat_hazine_bank")]
		private EditBox _txt_babat_hazine_bank;

		// Token: 0x04000929 RID: 2345
		[AccessedThroughProperty("txt_bank_hazine")]
		private SelectItem _txt_bank_hazine;

		// Token: 0x0400092A RID: 2346
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x0400092B RID: 2347
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x0400092C RID: 2348
		[AccessedThroughProperty("Group_Bank_To_Bank")]
		private UIGroupBox _Group_Bank_To_Bank;

		// Token: 0x0400092D RID: 2349
		[AccessedThroughProperty("txt_bank_shcheck")]
		private SelectItem _txt_bank_shcheck;

		// Token: 0x0400092E RID: 2350
		[AccessedThroughProperty("txt_bank_bankhesab")]
		private SelectItem _txt_bank_bankhesab;

		// Token: 0x0400092F RID: 2351
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x04000930 RID: 2352
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x04000931 RID: 2353
		[AccessedThroughProperty("txt_bank_babat")]
		private EditBox _txt_bank_babat;

		// Token: 0x04000932 RID: 2354
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x04000933 RID: 2355
		[AccessedThroughProperty("Group_Hazine")]
		private UIGroupBox _Group_Hazine;

		// Token: 0x04000934 RID: 2356
		[AccessedThroughProperty("txt_babat_hazine")]
		private EditBox _txt_babat_hazine;

		// Token: 0x04000935 RID: 2357
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x04000936 RID: 2358
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x04000937 RID: 2359
		[AccessedThroughProperty("txt_hazine_shcheck")]
		private SelectItem _txt_hazine_shcheck;

		// Token: 0x04000938 RID: 2360
		[AccessedThroughProperty("txt_nahvePardakht")]
		private SelectItem _txt_nahvePardakht;

		// Token: 0x04000939 RID: 2361
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x0400093A RID: 2362
		[AccessedThroughProperty("txt_hazine_sarresid")]
		private DateBox2 _txt_hazine_sarresid;

		// Token: 0x0400093B RID: 2363
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x0400093C RID: 2364
		[AccessedThroughProperty("Group_barzamin")]
		private UIGroupBox _Group_barzamin;

		// Token: 0x0400093D RID: 2365
		[AccessedThroughProperty("txt_vazn")]
		private NumericBox _txt_vazn;

		// Token: 0x0400093E RID: 2366
		[AccessedThroughProperty("txt_tedad")]
		private NumericBox _txt_tedad;

		// Token: 0x0400093F RID: 2367
		[AccessedThroughProperty("txt_jens")]
		private SelectItem _txt_jens;

		// Token: 0x04000940 RID: 2368
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000941 RID: 2369
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000942 RID: 2370
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000943 RID: 2371
		[AccessedThroughProperty("txt_search2")]
		private EditBox _txt_search2;

		// Token: 0x04000944 RID: 2372
		[AccessedThroughProperty("txt_search1")]
		private EditBox _txt_search1;

		// Token: 0x04000945 RID: 2373
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000946 RID: 2374
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000947 RID: 2375
		[AccessedThroughProperty("Group_Gest")]
		private UIGroupBox _Group_Gest;

		// Token: 0x04000948 RID: 2376
		[AccessedThroughProperty("txt_nahvepardakht_agsat")]
		private SelectItem _txt_nahvepardakht_agsat;

		// Token: 0x04000949 RID: 2377
		[AccessedThroughProperty("txt_babat_agsat")]
		private EditBox _txt_babat_agsat;

		// Token: 0x0400094A RID: 2378
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x0400094B RID: 2379
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x0400094C RID: 2380
		[AccessedThroughProperty("Group_PardakhtTankhah")]
		private UIGroupBox _Group_PardakhtTankhah;

		// Token: 0x0400094D RID: 2381
		[AccessedThroughProperty("txt_nahvePardakhtTankhah")]
		private SelectItem _txt_nahvePardakhtTankhah;

		// Token: 0x0400094E RID: 2382
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x0400094F RID: 2383
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000950 RID: 2384
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000951 RID: 2385
		[AccessedThroughProperty("txt_babattankhah")]
		private EditBox _txt_babattankhah;

		// Token: 0x04000952 RID: 2386
		[AccessedThroughProperty("txt_tankhah_hesabbanki")]
		private SelectItem _txt_tankhah_hesabbanki;

		// Token: 0x04000953 RID: 2387
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x04000954 RID: 2388
		[AccessedThroughProperty("txt_hazine_kartbekart")]
		private SelectItem _txt_hazine_kartbekart;

		// Token: 0x04000955 RID: 2389
		[AccessedThroughProperty("txt_hazinetankhah")]
		private SelectItem _txt_hazinetankhah;

		// Token: 0x04000956 RID: 2390
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		// Token: 0x04000957 RID: 2391
		[AccessedThroughProperty("group_moshtari_be_moshtari")]
		private UIGroupBox _group_moshtari_be_moshtari;

		// Token: 0x04000958 RID: 2392
		[AccessedThroughProperty("txt_be_moshtari")]
		private SelectItem _txt_be_moshtari;

		// Token: 0x04000959 RID: 2393
		[AccessedThroughProperty("txt_babat_moshtari_be_moshtari")]
		private EditBox _txt_babat_moshtari_be_moshtari;

		// Token: 0x0400095A RID: 2394
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		// Token: 0x0400095B RID: 2395
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		// Token: 0x0400095C RID: 2396
		[AccessedThroughProperty("group_bank_be_sandugh")]
		private UIGroupBox _group_bank_be_sandugh;

		// Token: 0x0400095D RID: 2397
		[AccessedThroughProperty("txt_bs_shCheck")]
		private SelectItem _txt_bs_shCheck;

		// Token: 0x0400095E RID: 2398
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x0400095F RID: 2399
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		// Token: 0x04000960 RID: 2400
		[AccessedThroughProperty("txt_bs_babat")]
		private EditBox _txt_bs_babat;

		// Token: 0x04000961 RID: 2401
		[AccessedThroughProperty("txt_bankhesab_gest")]
		private SelectItem _txt_bankhesab_gest;

		// Token: 0x04000962 RID: 2402
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		// Token: 0x04000963 RID: 2403
		[AccessedThroughProperty("Group_checkNaghd")]
		private UIGroupBox _Group_checkNaghd;

		// Token: 0x04000964 RID: 2404
		[AccessedThroughProperty("UiButton7")]
		private UIButton _UiButton7;

		// Token: 0x04000965 RID: 2405
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000966 RID: 2406
		[AccessedThroughProperty("group_havale_arzi")]
		private UIGroupBox _group_havale_arzi;

		// Token: 0x04000967 RID: 2407
		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		// Token: 0x04000968 RID: 2408
		[AccessedThroughProperty("txt_havale_babat")]
		private EditBox _txt_havale_babat;

		// Token: 0x04000969 RID: 2409
		[AccessedThroughProperty("txt_havale_bank")]
		private SelectItem _txt_havale_bank;

		// Token: 0x0400096A RID: 2410
		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		// Token: 0x0400096B RID: 2411
		[AccessedThroughProperty("txt_fee_dolar")]
		private CurrencyBox _txt_fee_dolar;

		// Token: 0x0400096C RID: 2412
		[AccessedThroughProperty("Label50")]
		private Label _Label50;

		// Token: 0x0400096D RID: 2413
		[AccessedThroughProperty("group_phavale_arzi")]
		private UIGroupBox _group_phavale_arzi;

		// Token: 0x0400096E RID: 2414
		[AccessedThroughProperty("txt_pfee_dolar")]
		private CurrencyBox _txt_pfee_dolar;

		// Token: 0x0400096F RID: 2415
		[AccessedThroughProperty("Label51")]
		private Label _Label51;

		// Token: 0x04000970 RID: 2416
		[AccessedThroughProperty("txt_phavale_babat")]
		private EditBox _txt_phavale_babat;

		// Token: 0x04000971 RID: 2417
		[AccessedThroughProperty("txt_phavale_bank")]
		private SelectItem _txt_phavale_bank;

		// Token: 0x04000972 RID: 2418
		[AccessedThroughProperty("Label53")]
		private Label _Label53;

		// Token: 0x04000973 RID: 2419
		[AccessedThroughProperty("Label54")]
		private Label _Label54;

		// Token: 0x04000974 RID: 2420
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000975 RID: 2421
		[AccessedThroughProperty("Group_Takhfif")]
		private UIGroupBox _Group_Takhfif;

		// Token: 0x04000976 RID: 2422
		[AccessedThroughProperty("Label52")]
		private Label _Label52;

		// Token: 0x04000977 RID: 2423
		[AccessedThroughProperty("txt_babat_takhfif")]
		private EditBox _txt_babat_takhfif;

		// Token: 0x04000978 RID: 2424
		private DaryaftPardakht dp;

		// Token: 0x04000979 RID: 2425
		private Frm_SelectItem frm;

		// Token: 0x0400097A RID: 2426
		private Sanad Sanad;

		// Token: 0x0400097B RID: 2427
		private Sandugh Sandug;

		// Token: 0x0400097C RID: 2428
		private bool prevent;

		// Token: 0x0400097D RID: 2429
		private List<listCheckDaryaft> ListDaryaft_Identity;

		// Token: 0x0400097E RID: 2430
		private bool gridex1focused;

		// Token: 0x0400097F RID: 2431
		private string tarikhemroz;

		// Token: 0x04000980 RID: 2432
		private DataTable origin_daryaft;

		// Token: 0x04000981 RID: 2433
		private DataTable origin_pardakht;

		// Token: 0x04000982 RID: 2434
		private DataTable dt_search1;

		// Token: 0x04000983 RID: 2435
		private DataTable dt_search2;

		// Token: 0x04000984 RID: 2436
		private HistoryLog historyLog;

		// Token: 0x04000985 RID: 2437
		private List<TableItemChange> change;

		// Token: 0x04000986 RID: 2438
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000987 RID: 2439
		private bool prevent_close;

		// Token: 0x04000988 RID: 2440
		private bool prevent_mablagh;

		// Token: 0x04000989 RID: 2441
		private bool f2_click;

		// Token: 0x0400098A RID: 2442
		private bool home_clicked;

		// Token: 0x0400098B RID: 2443
		private long vagozari_bankhesab_id;

		// Token: 0x0400098C RID: 2444
		private string vagozari_bankhesab_Name;

		// Token: 0x0400098D RID: 2445
		[CompilerGenerated]
		private bool _ShowPreview;

		// Token: 0x0400098E RID: 2446
		[CompilerGenerated]
		private string _PreviewTarikh;
	}
}
