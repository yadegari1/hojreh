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
using Janus.Windows.Ribbon;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x02000102 RID: 258
	[DesignerGenerated]
	public partial class Frm_PardakhtCheck : Form
	{
		// Token: 0x06002243 RID: 8771 RVA: 0x00197784 File Offset: 0x00195984
		public Frm_PardakhtCheck()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_PardakhtCheck.__ENCAddToList(this);
			this.frm_hesabBanki = new Frm_SelectItem();
			this.frmCheck_Select = new Frm_SelectItem();
			DataTable dataTable = new DataTable();
			this.dt = dataTable;
			dataTable = new DataTable();
			this.dt_dcheck = dataTable;
			this.prevent = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.notin = string.Empty;
			this.Notin_Pardakht = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00197840 File Offset: 0x00195A40
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_PardakhtCheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_PardakhtCheck.__ENCList.Count == Frm_PardakhtCheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_PardakhtCheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_PardakhtCheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_PardakhtCheck.__ENCList[num] = Frm_PardakhtCheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_PardakhtCheck.__ENCList.RemoveRange(num, Frm_PardakhtCheck.__ENCList.Count - num);
						Frm_PardakhtCheck.__ENCList.Capacity = Frm_PardakhtCheck.__ENCList.Count;
					}
					Frm_PardakhtCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0019886C File Offset: 0x00196A6C
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x00198884 File Offset: 0x00196A84
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
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EventHandler value4 = new EventHandler(this.GridEX1_RecordAdded);
				KeyEventHandler value5 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.KeyPress -= value3;
					this._GridEX1.RecordAdded -= value4;
					this._GridEX1.KeyDown -= value5;
					this._GridEX1.CellEdited -= value6;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.KeyPress += value3;
					this._GridEX1.RecordAdded += value4;
					this._GridEX1.KeyDown += value5;
					this._GridEX1.CellEdited += value6;
				}
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x0019898C File Offset: 0x00196B8C
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x00008DA3 File Offset: 0x00006FA3
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

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x001989A4 File Offset: 0x00196BA4
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x001989BC File Offset: 0x00196BBC
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
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX2_KeyDown);
				EventHandler value4 = new EventHandler(this.GridEX1_RecordAdded);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX2_ColumnButtonClick);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX2_CellEdited);
				EventHandler value7 = new EventHandler(this.GridEX2_RecordAdded);
				InitCustomEditEventHandler value8 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value9 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.KeyPress -= value2;
					this._GridEX2.KeyDown -= value3;
					this._GridEX2.RecordAdded -= value4;
					this._GridEX2.ColumnButtonClick -= value5;
					this._GridEX2.CellEdited -= value6;
					this._GridEX2.RecordAdded -= value7;
					this._GridEX2.InitCustomEdit -= value8;
					this._GridEX2.EndCustomEdit -= value9;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.KeyPress += value2;
					this._GridEX2.KeyDown += value3;
					this._GridEX2.RecordAdded += value4;
					this._GridEX2.ColumnButtonClick += value5;
					this._GridEX2.CellEdited += value6;
					this._GridEX2.RecordAdded += value7;
					this._GridEX2.InitCustomEdit += value8;
					this._GridEX2.EndCustomEdit += value9;
				}
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x00198B44 File Offset: 0x00196D44
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x00008DAD File Offset: 0x00006FAD
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

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00198B5C File Offset: 0x00196D5C
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x00008DB7 File Offset: 0x00006FB7
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

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00198B74 File Offset: 0x00196D74
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x00008DC1 File Offset: 0x00006FC1
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

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00198B8C File Offset: 0x00196D8C
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x00198BA4 File Offset: 0x00196DA4
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

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00198C04 File Offset: 0x00196E04
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x00008DCB File Offset: 0x00006FCB
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

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00198C1C File Offset: 0x00196E1C
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x00198C34 File Offset: 0x00196E34
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

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00198C94 File Offset: 0x00196E94
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x00008DD5 File Offset: 0x00006FD5
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

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00198CAC File Offset: 0x00196EAC
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x00008DDF File Offset: 0x00006FDF
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

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x00198CC4 File Offset: 0x00196EC4
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x00008DE9 File Offset: 0x00006FE9
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

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x00198CDC File Offset: 0x00196EDC
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x00008DF3 File Offset: 0x00006FF3
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

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x00198CF4 File Offset: 0x00196EF4
		// (set) Token: 0x06002262 RID: 8802 RVA: 0x00008DFD File Offset: 0x00006FFD
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

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x00198D0C File Offset: 0x00196F0C
		// (set) Token: 0x06002264 RID: 8804 RVA: 0x00008E07 File Offset: 0x00007007
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

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00198D24 File Offset: 0x00196F24
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x00008E11 File Offset: 0x00007011
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

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x00198D3C File Offset: 0x00196F3C
		// (set) Token: 0x06002268 RID: 8808 RVA: 0x00008E1B File Offset: 0x0000701B
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

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x00198D54 File Offset: 0x00196F54
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x00008E25 File Offset: 0x00007025
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

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x00198D6C File Offset: 0x00196F6C
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x00008E2F File Offset: 0x0000702F
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

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00198D84 File Offset: 0x00196F84
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x00008E39 File Offset: 0x00007039
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

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x00198D9C File Offset: 0x00196F9C
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x00008E43 File Offset: 0x00007043
		public DataRow ParentDatarow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParentDatarow;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ParentDatarow = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x00198DB4 File Offset: 0x00196FB4
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x00008E4D File Offset: 0x0000704D
		public long sum_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sum_mablagh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sum_mablagh = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00198DCC File Offset: 0x00196FCC
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x00008E57 File Offset: 0x00007057
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

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x00198DE4 File Offset: 0x00196FE4
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x00008E61 File Offset: 0x00007061
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

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x00198DFC File Offset: 0x00196FFC
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x00008E6B File Offset: 0x0000706B
		public DataTable dt_dcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_dcheck;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_dcheck = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x00198E14 File Offset: 0x00197014
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x00008E75 File Offset: 0x00007075
		public DataTable dt_daryaft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_daryaft;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_daryaft = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x00198E2C File Offset: 0x0019702C
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x00008E7F File Offset: 0x0000707F
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

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x00198E44 File Offset: 0x00197044
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x00008E89 File Offset: 0x00007089
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

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x00198E5C File Offset: 0x0019705C
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x00008E93 File Offset: 0x00007093
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

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x00198E74 File Offset: 0x00197074
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x00008E9D File Offset: 0x0000709D
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

		// Token: 0x06002283 RID: 8835 RVA: 0x00198E8C File Offset: 0x0019708C
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

		// Token: 0x06002284 RID: 8836 RVA: 0x0019907C File Offset: 0x0019727C
		private bool ValidateGrid()
		{
			this.GridEX1.UpdateData();
			this.GridEX2.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX2.DataSource;
			int i = 0;
			checked
			{
				bool flag;
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
				int j = 0;
				bool result;
				while (j < rows.Length)
				{
					GridEXRow gridEXRow = rows[j];
					flag = (Operators.CompareString(gridEXRow.Cells["mablagh"].Value.ToString(), string.Empty, false) == 0);
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Mablagh", "مبلغ چک را وارد کنید");
						result = false;
					}
					else
					{
						flag = (Operators.CompareString(gridEXRow.Cells["Sh_Check"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Sh_Check", "شماره چک را وارد کنید");
							result = false;
						}
						else
						{
							flag = (Operators.CompareString(gridEXRow.Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
								result = false;
							}
							else
							{
								flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(gridEXRow.Cells["Check_Sarresid_Fa"].Value));
								if (flag)
								{
									Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
									result = false;
								}
								else
								{
									flag = (gridEXRow.Cells["BankHesab_Id"].Value == DBNull.Value);
									if (!flag)
									{
										j++;
										continue;
									}
									Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "BankHesab_Name", "حساب بانکی را مشخص فرمائید");
									result = false;
								}
							}
						}
					}
					return result;
				}
				long num = Conversions.ToLong(this.GridEX2.GetTotal(this.GridEX2.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
				num = Conversions.ToLong(Operators.AddObject(num, this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum)));
				flag = (num - this.Mablagh_Kol > 0L);
				if (flag)
				{
					Public_Function.ShowMessage("مبلغ چک ها بیشتر از مبلغ کل میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					result = false;
					return result;
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0019939C File Offset: 0x0019759C
		private DataTable LoadData()
		{
			this.dt = this.ParentDatarow.Table.Clone();
			return this.dt;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x001993CC File Offset: 0x001975CC
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.ValidateGrid();
			checked
			{
				if (flag)
				{
					e.Cancel = true;
				}
				else
				{
					object expr_2E = this.ParentDatarow["Moshtari_ID"];
					int? num2;
					int? num = (expr_2E != null) ? ((int?)expr_2E) : num2;
					string value = Conversions.ToString(this.ParentDatarow["Moshtari_Name"]);
					DataTable table = this.ParentDatarow.Table;
					int num3 = this.ParentDatarow.Table.Rows.IndexOf(this.ParentDatarow);
					DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_identity=", this.ParentDatarow["Identity"])));
					flag = (array.Length > 0);
					if (flag)
					{
						int arg_BB_0 = 0;
						int num4 = array.Length - 1;
						int num5 = arg_BB_0;
						while (true)
						{
							int arg_102_0 = num5;
							int num6 = num4;
							if (arg_102_0 > num6)
							{
								break;
							}
							bool flag2 = Operators.ConditionalCompareObjectEqual(array[num5]["dptype_id"], 10, false);
							if (flag2)
							{
								num3++;
							}
							else
							{
								array[num5].Delete();
							}
							num5++;
						}
					}
					table.AcceptChanges();
					try
					{
						IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							num3++;
							DataRow dataRow2 = table.NewRow();
							bool flag2 = num.HasValue;
							if (flag2)
							{
								dataRow2["Moshtari_Name"] = value;
								dataRow2["Moshtari_ID"] = num;
							}
							flag2 = (dataRow["ID"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["ID"] = RuntimeHelpers.GetObjectValue(dataRow["ID"]);
							}
							flag2 = (dataRow["Parent_ID"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["Parent_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_ID"]);
							}
							dataRow2["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
							dataRow2["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
							dataRow2["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
							dataRow2["is_child"] = true;
							dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(this.ParentDatarow["identity"]);
							flag2 = (dataRow["tarikh"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh"]);
							}
							flag2 = (dataRow["sanadbed_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["sanadbed_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbed_id"]);
							}
							flag2 = (dataRow["sanadbes_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["sanadbes_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbes_id"]);
							}
							dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
							dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
							dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
							dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
							dataRow2["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow["daryaft_identity"]);
							dataRow2["dp_Name"] = "پرداخت چک مشتری";
							dataRow2["dptype_id"] = 12;
							dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
							table.Rows.InsertAt(dataRow2, num3);
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
					try
					{
						IEnumerator enumerator2 = ((DataTable)this.GridEX2.DataSource).Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator2.Current;
							num3++;
							DataRow dataRow4 = table.NewRow();
							bool flag2 = num.HasValue;
							if (flag2)
							{
								dataRow4["Moshtari_Name"] = value;
								dataRow4["Moshtari_ID"] = num;
							}
							flag2 = (dataRow3["ID"] != DBNull.Value);
							if (flag2)
							{
								dataRow4["ID"] = RuntimeHelpers.GetObjectValue(dataRow3["ID"]);
							}
							flag2 = (dataRow3["Parent_ID"] != DBNull.Value);
							if (flag2)
							{
								dataRow4["Parent_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["Parent_ID"]);
							}
							dataRow4["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow3["Mablagh"]);
							dataRow4["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow3["Sh_Check"]);
							dataRow4["checkBarg_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["CheckBarg_ID"]);
							dataRow4["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow3["Check_Sarresid_Fa"]);
							dataRow4["is_child"] = true;
							dataRow4["parent_identity"] = RuntimeHelpers.GetObjectValue(this.ParentDatarow["identity"]);
							dataRow4["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["BankHesab_ID"]);
							dataRow4["BankHesab_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["BankHesab_Name"]);
							flag2 = (dataRow3["tarikh"] != DBNull.Value);
							if (flag2)
							{
								dataRow4["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow3["tarikh"]);
							}
							flag2 = (dataRow3["sanadbed_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow4["sanadbed_id"] = RuntimeHelpers.GetObjectValue(dataRow3["sanadbed_id"]);
							}
							flag2 = (dataRow3["sanadbes_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow4["sanadbes_id"] = RuntimeHelpers.GetObjectValue(dataRow3["sanadbes_id"]);
							}
							dataRow4["dp_Name"] = "پرداخت دسته چک";
							dataRow4["dptype_id"] = 11;
							dataRow4["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["CheckBank_Name"]);
							dataRow4["tozih"] = RuntimeHelpers.GetObjectValue(dataRow3["tozih"]);
							table.Rows.InsertAt(dataRow4, num3);
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
				}
				this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
				this.sum_mablagh = Conversions.ToLong(Operators.AddObject(this.sum_mablagh, this.GridEX2.GetTotal(this.GridEX2.RootTable.Columns["Mablagh"], AggregateFunction.Sum)));
			}
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00199BF8 File Offset: 0x00197DF8
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

		// Token: 0x06002288 RID: 8840 RVA: 0x00199C34 File Offset: 0x00197E34
		private void GetNotin()
		{
			this.notin = string.Empty;
			DataTable table = this.ParentDatarow.Table;
			bool flag2;
			try
			{
				IEnumerator enumerator = table.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["dptype_id"] == DBNull.Value;
					if (!flag)
					{
						if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
						{
							goto IL_A2;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false))
						{
							goto IL_A2;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false))
						{
							goto IL_C1;
						}
						bool arg_C3_0 = false;
						IL_C2:
						flag = arg_C3_0;
						if (flag)
						{
							flag2 = (dataRow["PardakhtCheck_ID"] != DBNull.Value);
							if (flag2)
							{
								this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
							}
						}
						continue;
						IL_C1:
						arg_C3_0 = true;
						goto IL_C2;
						IL_A2:
						goto IL_C1;
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
			flag2 = (Operators.CompareString(this.notin, string.Empty, false) != 0);
			if (flag2)
			{
				this.notin = Public_Function.RemoveLast(this.notin);
				this.notin = " and DaryaftPardakht.ID not in (" + this.notin + ")";
			}
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00199DEC File Offset: 0x00197FEC
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			this.Text += "-چاپ چک=F4";
			this.lbl_jamkol.Text = Public_Function.ToFarsi(Strings.FormatNumber(this.Mablagh_Kol, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True));
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
			this.GetNotin();
			this.Get_Notin_Pardakht();
			DataTable table = this.ParentDatarow.Table;
			this.dt = table.Clone();
			this.dt_dcheck = table.Clone();
			DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_Identity=", this.ParentDatarow["identity"])));
			DataRow[] array2 = array;
			checked
			{
				bool flag;
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 10, false);
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false);
						if (flag)
						{
							this.dt.ImportRow(dataRow);
						}
						flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false);
						if (flag)
						{
							this.dt_dcheck.ImportRow(dataRow);
						}
					}
				}
				flag = (this.dt.Rows.Count > 0);
				if (flag)
				{
					this.dt.TableName = "data";
					this.GridEX1.DataSource = this.dt;
				}
				else
				{
					this.GridEX1.DataSource = this.LoadData();
				}
				flag = (this.dt_dcheck.Rows.Count > 0);
				if (flag)
				{
					this.GridEX2.DataSource = this.dt_dcheck;
				}
				else
				{
					this.GridEX2.DataSource = this.LoadData();
				}
				this.GetSum();
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0019A0EC File Offset: 0x001982EC
		public void Check_Select_ByNum()
		{
			bool flag = this.prevent;
			if (flag)
			{
				this.prevent = false;
			}
			else
			{
				string text = string.Empty;
				flag = (this.GridEX1.EditTextBox == null);
				bool flag2;
				if (flag)
				{
					flag2 = (this.GridEX1.GetRow().Cells["sh_check"].Value == DBNull.Value);
					if (flag2)
					{
						return;
					}
					text = Conversions.ToString(this.GridEX1.GetRow().Cells["sh_check"].Value);
				}
				else
				{
					text = this.GridEX1.EditTextBox.Text;
				}
				flag2 = (text == null);
				if (!flag2)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					string text2 = string.Empty;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
					try
					{
						IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 26, false);
							if (flag2)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow2["PardakhtCheck_ID"], ",")));
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
					text2 = Public_Function.RemoveLast(text2);
					flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag2)
					{
						text2 = " AND DaryaftPardakht.ID NOT IN(" + text2 + ")";
					}
					this.GridEX1.Col = 0;
					this.GridEX1.GetRow().BeginEdit();
					this.GridEX1.EditMode = EditMode.EditOn;
					DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
					{
						"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99) And check_Status=1 and DaryaftPardakht.Tarikh<=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
						text2,
						this.notin,
						" AND DaryaftPardakht.Sh_Check='",
						text,
						"'"
					}));
					dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
					try
					{
						IEnumerator enumerator3 = this.dt_daryaft.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							flag2 = (dataRow3["id"] != DBNull.Value);
							if (!flag2)
							{
								flag2 = (Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow3["dptype_ID"], 26, false));
								if (flag2)
								{
									flag = (dataRow3["id"] != DBNull.Value);
									if (!flag)
									{
										flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 12,
											Daryaft_Identity = Conversions.ToInteger(dataRow3["identity"])
										});
										if (!flag2)
										{
											flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
											{
												Operation_id = 18,
												Daryaft_Identity = Conversions.ToInteger(dataRow3["identity"])
											});
											if (!flag2)
											{
												flag2 = (dataRow3["PardakhtCheck_ID"] != DBNull.Value);
												if (flag2)
												{
													flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
													{
														Operation_id = 26,
														PardakhtCheck_ID = Conversions.ToInteger(dataRow3["PardakhtCheck_ID"])
													});
													if (flag)
													{
														continue;
													}
												}
												DataRow dataRow4 = dataTable2.NewRow();
												dataRow4["ID"] = 0;
												dataRow4["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow3["Tarikh"]);
												dataRow4["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["Moshtari_ID"]);
												dataRow4["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow3["Mablagh"]);
												dataRow4["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow3["Tozih"]);
												dataRow4["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow3["Tarikh_Fa"]);
												dataRow4["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow3["Sh_Check"]);
												dataRow4["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["CheckBank_ID"]);
												dataRow4["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow3["Check_Shobe"]);
												dataRow4["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow3["Check_Sarresid_Fa"]);
												dataRow4["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["Moshtari_Name"]);
												dataRow4["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["CheckBank_Name"]);
												dataRow4["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow3["identity"]);
												dataTable2.Rows.Add(dataRow4);
											}
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
					this.Sync_Check_Info(dataTable2);
					flag2 = (dataTable2.Rows.Count == 0);
					if (flag2)
					{
						this.prevent = true;
						this.GridEX1.CancelCurrentEdit();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
					else
					{
						flag2 = (dataTable2.Rows.Count == 1);
						if (flag2)
						{
							this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Mablagh"]);
							this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CheckBank_ID"]);
							this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Bank_Name"]);
							this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_Sarresid_Fa"]);
							this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_Shobe"]);
							this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["ID"]);
							this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["daryaft_identity"]);
							flag2 = Operators.ConditionalCompareObjectEqual(dataTable2.Rows[0]["ID"], 0, false);
							if (flag2)
							{
								flag = (dataTable2.Rows[0]["daryaft_identity"] != DBNull.Value);
								if (flag)
								{
									this.ListDaryaft_Identity.Add(new listCheckDaryaft
									{
										Operation_id = 12,
										Daryaft_Identity = Conversions.ToInteger(dataTable2.Rows[0]["daryaft_identity"])
									});
								}
								else
								{
									this.ListDaryaft_Identity.Add(new listCheckDaryaft
									{
										Operation_id = 12,
										PardakhtCheck_ID = Conversions.ToInteger(dataTable2.Rows[0]["PardakhtCheck_ID"])
									});
								}
							}
							this.prevent = true;
							this.GridEX1.UpdateData();
							this.GridEX1.MoveToNewRecord();
							this.GridEX1.Col = 0;
							this.GridEX1.EditMode = EditMode.EditOn;
						}
						else
						{
							flag2 = (dataTable2.Rows.Count > 1);
							if (flag2)
							{
								flag = (this.frmCheck_Select.ShowDialog(dataTable2, null, "پرداخت چک - انتخاب چک") == DialogResult.OK);
								if (flag)
								{
									bool flag3 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null;
									if (flag3)
									{
										this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
										this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
										this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
										this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
										this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
										this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
										this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["ID"]);
										this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
										flag3 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
										if (flag3)
										{
											flag2 = (dataTable2.Rows[0]["daryaft_identity"] != DBNull.Value);
											if (flag2)
											{
												this.ListDaryaft_Identity.Add(new listCheckDaryaft
												{
													Operation_id = 12,
													Daryaft_Identity = Conversions.ToInteger(dataTable2.Rows[0]["daryaft_identity"])
												});
											}
											else
											{
												this.ListDaryaft_Identity.Add(new listCheckDaryaft
												{
													Operation_id = 12,
													PardakhtCheck_ID = Conversions.ToInteger(dataTable2.Rows[0]["PardakhtCheck_ID"])
												});
											}
										}
										this.prevent = true;
										this.GridEX1.UpdateData();
										this.GridEX1.MoveToNewRecord();
										this.GridEX1.Col = 0;
										this.GridEX1.EditMode = EditMode.EditOn;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0019ADCC File Offset: 0x00198FCC
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

		// Token: 0x0600228C RID: 8844 RVA: 0x0019AE50 File Offset: 0x00199050
		private void Sync_Check_Info(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = this.dt_daryaft.Rows.GetEnumerator();
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

		// Token: 0x0600228D RID: 8845 RVA: 0x0019B088 File Offset: 0x00199288
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
			try
			{
				IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 26, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow2["PardakhtCheck_ID"], ",")));
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
			text = Public_Function.RemoveLast(text);
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " AND DaryaftPardakht.ID NOT IN(" + text + ")";
			}
			DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht Left Outer JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				text,
				this.notin,
				" order by DaryaftPardakht.Check_Sarresid"
			}));
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			try
			{
				IEnumerator enumerator3 = dataTable2.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					flag = (dataRow3["bank_Name"] == DBNull.Value);
					if (flag)
					{
						dataRow3["bank_Name"] = string.Empty;
					}
					flag = (dataRow3["check_shobe"] == DBNull.Value);
					if (flag)
					{
						dataRow3["check_Shobe"] = string.Empty;
					}
					flag = (dataRow3["Check_ShomareHesab"] == DBNull.Value);
					if (flag)
					{
						dataRow3["Check_ShomareHesab"] = string.Empty;
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
			bool flag2;
			try
			{
				IEnumerator enumerator4 = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator4.Current;
					flag = (Operators.ConditionalCompareObjectEqual(dataRow4["dptype_id"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow4["dptype_ID"], 26, false));
					if (flag)
					{
						flag2 = (dataRow4["id"] != DBNull.Value);
						if (!flag2)
						{
							flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
							{
								Operation_id = 12,
								Daryaft_Identity = Conversions.ToInteger(dataRow4["identity"])
							});
							if (!flag2)
							{
								flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
								{
									Operation_id = 18,
									Daryaft_Identity = Conversions.ToInteger(dataRow4["identity"])
								});
								if (!flag2)
								{
									flag2 = (dataRow4["PardakhtCheck_ID"] != DBNull.Value);
									if (flag2)
									{
										flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 26,
											PardakhtCheck_ID = Conversions.ToInteger(dataRow4["PardakhtCheck_ID"])
										});
										if (flag)
										{
											continue;
										}
									}
									DataRow dataRow5 = dataTable2.NewRow();
									dataRow5["ID"] = 0;
									dataRow5["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow4["Tarikh"]);
									dataRow5["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow4["Moshtari_ID"]);
									dataRow5["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow4["Mablagh"]);
									dataRow5["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow4["Tozih"]);
									dataRow5["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow4["Tarikh_Fa"]);
									dataRow5["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow4["Sh_Check"]);
									dataRow5["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow4["CheckBank_ID"]);
									dataRow5["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow4["Check_Shobe"]);
									dataRow5["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow4["Check_Sarresid_Fa"]);
									dataRow5["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow4["Moshtari_Name"]);
									dataRow5["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow4["CheckBank_Name"]);
									dataRow5["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow4["identity"]);
									dataTable2.Rows.Add(dataRow5);
								}
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
			this.Sync_Check_Info(dataTable2);
			flag2 = (this.frmCheck_Select.ShowDialog(dataTable2, null, "پرداخت چک - انتخاب چک") == DialogResult.OK);
			if (flag2)
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

		// Token: 0x0600228E RID: 8846 RVA: 0x0019BA10 File Offset: 0x00199C10
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

		// Token: 0x0600228F RID: 8847 RVA: 0x0019BB18 File Offset: 0x00199D18
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

		// Token: 0x06002290 RID: 8848 RVA: 0x0019BBD4 File Offset: 0x00199DD4
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

		// Token: 0x06002291 RID: 8849 RVA: 0x0019BD0C File Offset: 0x00199F0C
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "sh_check", false) == 0;
			if (flag)
			{
				this.Check_Select_ByNum();
				this.GetSum();
			}
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0019BD4C File Offset: 0x00199F4C
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 18,
				Daryaft_Identity = value
			});
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0019BD80 File Offset: 0x00199F80
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataRowView dataRowView = (DataRowView)row.DataRow;
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			bool flag2;
			if (flag)
			{
				flag2 = (((DataRowView)row.DataRow)["PardakhtCheck_ID"] != DBNull.Value);
				string str;
				if (flag2)
				{
					str = Conversions.ToString(((DataRowView)row.DataRow)["PardakhtCheck_ID"]);
				}
				else
				{
					str = Conversions.ToString(-1);
				}
				string text = string.Empty;
				long value = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
				DataRow dataRow = Public_Function.FillDataRow("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + Conversions.ToString(value) + ")");
				text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + Conversions.ToString(value) + ");";
				text = text + "delete from daryaftpardakht where id in(" + Conversions.ToString(value) + ");";
				flag2 = (dataRow["sanadbed_id"] != DBNull.Value);
				if (flag2)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbed_id"]), ");")));
				}
				flag2 = (dataRow["sanadbes_id"] != DBNull.Value);
				if (flag2)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbes_id"]), ");")));
				}
				Public_Function.ExecuteNonQuery(text);
				text = "declare @st int;";
				text = text + "select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=" + str + " order by id desc;";
				text += "if @st is null set @st=1;";
				text = text + "update daryaftpardakht set check_status=@st where id=" + str + ";";
				Public_Function.ExecuteNonQuery(text);
			}
			flag2 = (this.GridEX1.CurrentRow.RowType == RowType.Record);
			if (flag2)
			{
				flag = (this.GridEX1.GetRow().Cells["daryaft_identity"].Value != DBNull.Value);
				if (flag)
				{
					this.Delete_Listdaryaft(Conversions.ToInteger(this.GridEX1.GetRow().Cells["daryaft_identity"].Value));
				}
				this.Update_MablaghNaghd(this.GridEX1.CurrentRow);
				this.GridEX1.CurrentRow.Delete();
				((DataTable)this.GridEX1.DataSource).AcceptChanges();
				this.GetSum();
				this.GetNotin();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0019C048 File Offset: 0x0019A248
		private void GetChackeUsageInPardakhtForPardakht(GridEXRow row, DataTable dt2)
		{
			long num = Conversions.ToLong(((DataRowView)row.DataRow)["Identity"]);
			int num2 = this.Pardakht_Table.Rows.IndexOf(this.ParentDatarow);
			bool flag = row.Cells["pardakhtcheck_id"].Value != DBNull.Value;
			bool flag2;
			DataRow[] array;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectNotEqual(row.Cells["pardakhtcheck_id"].Value, 0, false);
				if (flag2)
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("pardakhtcheck_id=", row.Cells["pardakhtcheck_id"].Value), " and dptype_id<>12  AND ID IS NULL")));
				}
				else
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("daryaft_identity=", row.Cells["daryaft_identity"].Value), " and dptype_id<>12  AND ID IS NULL")));
				}
			}
			flag2 = (array != null);
			checked
			{
				if (flag2)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						flag = (this.Pardakht_Table.Rows.IndexOf(dataRow) > num2);
						if (flag)
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
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0019C270 File Offset: 0x0019A470
		private void GetDasteCheckUsage(GridEXRow row)
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
				}
			}
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0019C3F4 File Offset: 0x0019A5F4
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
				}
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0019C580 File Offset: 0x0019A780
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

		// Token: 0x06002298 RID: 8856 RVA: 0x0019C6B0 File Offset: 0x0019A8B0
		private void Get_Notin_Pardakht()
		{
			try
			{
				IEnumerator enumerator = this.Pardakht_Table.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["dptype_id"] == DBNull.Value;
					if (!flag)
					{
						if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false))
						{
							goto IL_93;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 31, false))
						{
							goto IL_93;
						}
						bool arg_95_0 = false;
						IL_94:
						flag = arg_95_0;
						if (flag)
						{
							bool flag2 = dataRow["checkBarg_ID"] != DBNull.Value;
							if (flag2)
							{
								this.Notin_Pardakht = Conversions.ToString(Operators.ConcatenateObject(this.Notin_Pardakht, Operators.ConcatenateObject(dataRow["checkBarg_ID"], ",")));
							}
						}
						continue;
						IL_93:
						arg_95_0 = true;
						goto IL_94;
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
			this.Notin_Pardakht = Public_Function.RemoveLast(this.Notin_Pardakht);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0019C7F0 File Offset: 0x0019A9F0
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

		// Token: 0x0600229A RID: 8858 RVA: 0x000E9708 File Offset: 0x000E7908
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

		// Token: 0x0600229B RID: 8859 RVA: 0x0019C9F0 File Offset: 0x0019ABF0
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

		// Token: 0x0600229C RID: 8860 RVA: 0x0019CA80 File Offset: 0x0019AC80
		private void Del_DasteCheck()
		{
			bool flag = this.GridEX2.CurrentRow.RowType == RowType.Record;
			bool flag2;
			if (flag)
			{
				flag2 = (((DataRowView)this.GridEX2.CurrentRow.DataRow)["ID"] == DBNull.Value);
				if (flag2)
				{
					this.GridEX2.CurrentRow.Delete();
					((DataTable)this.GridEX2.DataSource).AcceptChanges();
					this.GetSum();
					this.GetNotin();
					this.GridEX2.MoveToNewRecord();
					this.GridEX2.Col = 0;
					this.GridEX2.EditMode = EditMode.EditOn;
				}
				else
				{
					flag2 = (Public_Function.ShowMessage("آیا مایل به حذف پرداخت چک میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
					if (flag2)
					{
						this.GetDasteCheckUsage(this.GridEX2.CurrentRow);
						this.Del_CheckBarg();
						this.Update_MablaghNaghd(this.GridEX2.CurrentRow);
						this.GridEX2.CurrentRow.Delete();
						((DataTable)this.GridEX2.DataSource).AcceptChanges();
						this.GetSum();
						this.GetNotin();
						this.GridEX2.MoveToNewRecord();
						this.GridEX2.Col = 0;
						this.GridEX2.EditMode = EditMode.EditOn;
					}
				}
			}
			flag2 = (this.GridEX2.CurrentRow.RowType == RowType.NewRecord);
			if (flag2)
			{
				this.GridEX2.CancelCurrentEdit();
				this.GetSum();
			}
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0019CC00 File Offset: 0x0019AE00
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
						dataTable.Rows[0]["tozih"] = RuntimeHelpers.GetObjectValue(this.ParentDatarow["tozih"]);
					}
					frm_Check_Print.dt = dataTable;
					frm_Check_Print.Tozih = dataTable.Rows[0]["tozih"].ToString();
					frm_Check_Print.Moshtari_Name = this.Moshtari_Name;
					frm_Check_Print.moshtari_id = Conversions.ToString(this.ParentDatarow["moshtari_id"]);
					MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Check_Print);
					this.GridEX2.CurrentRow.BeginEdit();
					this.GridEX2.CurrentRow.Cells["tozih"].Value = frm_Check_Print.EditBox1.Text;
					this.GridEX2.CurrentRow.EndEdit();
				}
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0000205D File Offset: 0x0000025D
		private void GridEX2_CellEdited(object sender, ColumnActionEventArgs e)
		{
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0019CE00 File Offset: 0x0019B000
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

		// Token: 0x060022A0 RID: 8864 RVA: 0x000EA1CC File Offset: 0x000E83CC
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

		// Token: 0x060022A1 RID: 8865 RVA: 0x0019CEAC File Offset: 0x0019B0AC
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

		// Token: 0x060022A2 RID: 8866 RVA: 0x0019CF98 File Offset: 0x0019B198
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
						this.GridEX2.Focus();
						this.GridEX2.Col = 0;
						this.GridEX2.EditMode = EditMode.EditOn;
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
							else
							{
								this.Check_Select_ByNum();
							}
						}
					}
				}
			}
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0019D24C File Offset: 0x0019B44C
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

		// Token: 0x060022A4 RID: 8868 RVA: 0x0019D2AC File Offset: 0x0019B4AC
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

		// Token: 0x060022A5 RID: 8869 RVA: 0x0019D778 File Offset: 0x0019B978
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position;
			if (!flag)
			{
				flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0019D7F8 File Offset: 0x0019B9F8
		private void design_print()
		{
			StiReport stiReport = new StiReport();
			string str = Conversions.ToString(this.ParentDatarow["moshtari_ID"]);
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

		// Token: 0x060022A7 RID: 8871 RVA: 0x0019DE3C File Offset: 0x0019C03C
		private void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			string text = Conversions.ToString(this.ParentDatarow["moshtari_Name"]);
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

		// Token: 0x060022A8 RID: 8872 RVA: 0x00008EA7 File Offset: 0x000070A7
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.ShowReport(false);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0019E590 File Offset: 0x0019C790
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

		// Token: 0x060022AA RID: 8874 RVA: 0x00008EB3 File Offset: 0x000070B3
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00008EBE File Offset: 0x000070BE
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			this.GetSum();
		}

		// Token: 0x04000D5D RID: 3421
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000D5F RID: 3423
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000D60 RID: 3424
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000D61 RID: 3425
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x04000D62 RID: 3426
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000D63 RID: 3427
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x04000D64 RID: 3428
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000D65 RID: 3429
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000D66 RID: 3430
		[AccessedThroughProperty("Highlighter1")]
		private Highlighter _Highlighter1;

		// Token: 0x04000D67 RID: 3431
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000D68 RID: 3432
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000D69 RID: 3433
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000D6A RID: 3434
		[AccessedThroughProperty("lbl_jamcheck")]
		private LabelCommand _lbl_jamcheck;

		// Token: 0x04000D6B RID: 3435
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000D6C RID: 3436
		[AccessedThroughProperty("lbl_jamkol")]
		private LabelCommand _lbl_jamkol;

		// Token: 0x04000D6D RID: 3437
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000D6E RID: 3438
		[AccessedThroughProperty("lbl_codem")]
		private LabelCommand _lbl_codem;

		// Token: 0x04000D6F RID: 3439
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000D70 RID: 3440
		[AccessedThroughProperty("lbl_name")]
		private LabelCommand _lbl_name;

		// Token: 0x04000D71 RID: 3441
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x04000D72 RID: 3442
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x04000D73 RID: 3443
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x04000D74 RID: 3444
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x04000D75 RID: 3445
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x04000D76 RID: 3446
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x04000D77 RID: 3447
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000D78 RID: 3448
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000D79 RID: 3449
		[CompilerGenerated]
		private DataTable _dt_dcheck;

		// Token: 0x04000D7A RID: 3450
		[CompilerGenerated]
		private DataTable _dt_daryaft;

		// Token: 0x04000D7B RID: 3451
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x04000D7C RID: 3452
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x04000D7D RID: 3453
		[CompilerGenerated]
		private long _Mablagh_Kol;

		// Token: 0x04000D7E RID: 3454
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x04000D7F RID: 3455
		private bool prevent;

		// Token: 0x04000D80 RID: 3456
		private bool prevent_right;

		// Token: 0x04000D81 RID: 3457
		private bool prevent_left;

		// Token: 0x04000D82 RID: 3458
		private string notin;

		// Token: 0x04000D83 RID: 3459
		private string Notin_Pardakht;
	}
}
