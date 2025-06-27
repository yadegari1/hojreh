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
	// Token: 0x020000EF RID: 239
	[DesignerGenerated]
	public partial class frm_Frush_hag : Form
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x00129498 File Offset: 0x00127698
		public frm_Frush_hag()
		{
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frm_Frush_hag_KeyDown);
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			frm_Frush_hag.__ENCAddToList(this);
			this.Furush = new Furush_Hag();
			this.RizBar = new Furush_Hag_RizBar();
			this.Furush_Keraye = new Furush_Keraye();
			this.Moshtari_Info = new Moshtari_Info();
			this.kala_to_kala = new Kala_To_Kala_Furush();
			this.frm = new Frm_SelectItem();
			this.frm_furush = new Frm_SelectItem();
			this.sanad = new Sanad();
			this.Sandug = new Sandugh();
			this.user = new Base_User_Control();
			this.ID = -1;
			this.Num = -1;
			this.GotoLineID = -1;
			this.Isnew = true;
			this.prevent_enter = false;
			this.prevent_right = false;
			this.prevent_left = false;
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			this.InitializeComponent();
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x001295B4 File Offset: 0x001277B4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = frm_Frush_hag.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = frm_Frush_hag.__ENCList.Count == frm_Frush_hag.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = frm_Frush_hag.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = frm_Frush_hag.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									frm_Frush_hag.__ENCList[num] = frm_Frush_hag.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						frm_Frush_hag.__ENCList.RemoveRange(num, frm_Frush_hag.__ENCList.Count - num);
						frm_Frush_hag.__ENCList.Capacity = frm_Frush_hag.__ENCList.Count;
					}
					frm_Frush_hag.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0012C848 File Offset: 0x0012AA48
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x000078CA File Offset: 0x00005ACA
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

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x0012C860 File Offset: 0x0012AA60
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x000078D4 File Offset: 0x00005AD4
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0012C878 File Offset: 0x0012AA78
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x000078DE File Offset: 0x00005ADE
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

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0012C890 File Offset: 0x0012AA90
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x000078E8 File Offset: 0x00005AE8
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

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0012C8A8 File Offset: 0x0012AAA8
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x000078F2 File Offset: 0x00005AF2
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x0012C8C0 File Offset: 0x0012AAC0
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x000078FC File Offset: 0x00005AFC
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

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0012C8D8 File Offset: 0x0012AAD8
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00007906 File Offset: 0x00005B06
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

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x0012C8F0 File Offset: 0x0012AAF0
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x00007910 File Offset: 0x00005B10
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

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0012C908 File Offset: 0x0012AB08
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0000791A File Offset: 0x00005B1A
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
				this._txt_moshtari = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0012C920 File Offset: 0x0012AB20
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0012C938 File Offset: 0x0012AB38
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
				NavBox.NumberBox_KeydownEventHandler obj = new NavBox.NumberBox_KeydownEventHandler(this.txt_num_NumberBox_Keydown);
				NavBox.Previous_ClickEventHandler obj2 = new NavBox.Previous_ClickEventHandler(this.txt_num_Previous_Click);
				NavBox.Next_ClickEventHandler obj3 = new NavBox.Next_ClickEventHandler(this.txt_num_Next_Click);
				NavBox.Last_ClickEventHandler obj4 = new NavBox.Last_ClickEventHandler(this.txt_num_Last_Click);
				NavBox.First_ClickEventHandler obj5 = new NavBox.First_ClickEventHandler(this.txt_num_First_Click);
				CancelEventHandler value2 = new CancelEventHandler(this.txt_num_Validating);
				bool flag = this._txt_num != null;
				if (flag)
				{
					this._txt_num.NumberBox_Keydown -= obj;
					this._txt_num.Previous_Click -= obj2;
					this._txt_num.Next_Click -= obj3;
					this._txt_num.Last_Click -= obj4;
					this._txt_num.First_Click -= obj5;
					this._txt_num.Validating -= value2;
				}
				this._txt_num = value;
				flag = (this._txt_num != null);
				if (flag)
				{
					this._txt_num.NumberBox_Keydown += obj;
					this._txt_num.Previous_Click += obj2;
					this._txt_num.Next_Click += obj3;
					this._txt_num.Last_Click += obj4;
					this._txt_num.First_Click += obj5;
					this._txt_num.Validating += value2;
				}
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0012CA6C File Offset: 0x0012AC6C
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0012CA84 File Offset: 0x0012AC84
		internal virtual EditBox txt_desc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_desc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_desc_KeyDown);
				bool flag = this._txt_desc != null;
				if (flag)
				{
					this._txt_desc.KeyDown -= value2;
				}
				this._txt_desc = value;
				flag = (this._txt_desc != null);
				if (flag)
				{
					this._txt_desc.KeyDown += value2;
				}
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0012CAE4 File Offset: 0x0012ACE4
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x00007924 File Offset: 0x00005B24
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x0012CAFC File Offset: 0x0012ACFC
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0000792E File Offset: 0x00005B2E
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
				this._txt_tedad = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x0012CB14 File Offset: 0x0012AD14
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0012CB2C File Offset: 0x0012AD2C
		internal virtual EditBox txt_sh_barname
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sh_barname;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_sh_barname_KeyDown);
				bool flag = this._txt_sh_barname != null;
				if (flag)
				{
					this._txt_sh_barname.KeyDown -= value2;
				}
				this._txt_sh_barname = value;
				flag = (this._txt_sh_barname != null);
				if (flag)
				{
					this._txt_sh_barname.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x0012CB8C File Offset: 0x0012AD8C
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x00007938 File Offset: 0x00005B38
		internal virtual DateBox2 txt_tarikh_vurud
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh_vurud;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikh_vurud = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x0012CBA4 File Offset: 0x0012ADA4
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0012CBBC File Offset: 0x0012ADBC
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
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				InitCustomEditEventHandler value6 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value7 = new EventHandler(this.GridEX1_SelectionChanged);
				EndCustomEditEventHandler value8 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value9 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.KeyPress -= value5;
					this._GridEX1.InitCustomEdit -= value6;
					this._GridEX1.SelectionChanged -= value7;
					this._GridEX1.EndCustomEdit -= value8;
					this._GridEX1.ColumnButtonClick -= value9;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.KeyPress += value5;
					this._GridEX1.InitCustomEdit += value6;
					this._GridEX1.SelectionChanged += value7;
					this._GridEX1.EndCustomEdit += value8;
					this._GridEX1.ColumnButtonClick += value9;
				}
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x0012CD44 File Offset: 0x0012AF44
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x00007942 File Offset: 0x00005B42
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

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0012CD5C File Offset: 0x0012AF5C
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0012CD74 File Offset: 0x0012AF74
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

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0012CDD4 File Offset: 0x0012AFD4
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0012CDEC File Offset: 0x0012AFEC
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

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x0012CE4C File Offset: 0x0012B04C
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0012CE64 File Offset: 0x0012B064
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0012CEC4 File Offset: 0x0012B0C4
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0012CEDC File Offset: 0x0012B0DC
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

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x0012CF3C File Offset: 0x0012B13C
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0012CF54 File Offset: 0x0012B154
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

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0012CFB4 File Offset: 0x0012B1B4
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000794C File Offset: 0x00005B4C
		internal virtual NumericBox txt_baskul
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_baskul;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_baskul = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0012CFCC File Offset: 0x0012B1CC
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x00007956 File Offset: 0x00005B56
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x0012CFE4 File Offset: 0x0012B1E4
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0012CFFC File Offset: 0x0012B1FC
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0012D05C File Offset: 0x0012B25C
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0012D074 File Offset: 0x0012B274
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

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0012D0D4 File Offset: 0x0012B2D4
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x00007960 File Offset: 0x00005B60
		internal virtual NumericBox txt_baskul_mabda
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_baskul_mabda;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_baskul_mabda = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0012D0EC File Offset: 0x0012B2EC
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000796A File Offset: 0x00005B6A
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

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0012D104 File Offset: 0x0012B304
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0012D11C File Offset: 0x0012B31C
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0012D17C File Offset: 0x0012B37C
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0012D194 File Offset: 0x0012B394
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0012D1F4 File Offset: 0x0012B3F4
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x00007974 File Offset: 0x00005B74
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

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0012D20C File Offset: 0x0012B40C
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000797E File Offset: 0x00005B7E
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
				this._ButtonItem8 = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0012D224 File Offset: 0x0012B424
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00007988 File Offset: 0x00005B88
		internal virtual LabelItem LabelItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem2 = value;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0012D23C File Offset: 0x0012B43C
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x00007992 File Offset: 0x00005B92
		internal virtual LabelItem LabelItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem3 = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0012D254 File Offset: 0x0012B454
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000799C File Offset: 0x00005B9C
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0012D26C File Offset: 0x0012B46C
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x000079A6 File Offset: 0x00005BA6
		internal virtual LabelItem LabelItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem5 = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0012D284 File Offset: 0x0012B484
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x000079B0 File Offset: 0x00005BB0
		internal virtual LabelItem LabelItem6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem6 = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0012D29C File Offset: 0x0012B49C
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x000079BA File Offset: 0x00005BBA
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
				this._ButtonItem9 = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0012D2B4 File Offset: 0x0012B4B4
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x000079C4 File Offset: 0x00005BC4
		internal virtual ControlContainerItem ControlContainerItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ControlContainerItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ControlContainerItem1 = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0012D2CC File Offset: 0x0012B4CC
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x000079CE File Offset: 0x00005BCE
		internal virtual MicroChartItem MicroChartItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MicroChartItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MicroChartItem1 = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0012D2E4 File Offset: 0x0012B4E4
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x000079D8 File Offset: 0x00005BD8
		internal virtual ItemContainer ItemContainer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItemContainer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ItemContainer2 = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0012D2FC File Offset: 0x0012B4FC
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0012D314 File Offset: 0x0012B514
		internal virtual DataEntryGrid Grid_RizBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid_RizBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.Grid_RizBar_LoadingRow);
				bool flag = this._Grid_RizBar != null;
				if (flag)
				{
					this._Grid_RizBar.LoadingRow -= value2;
				}
				this._Grid_RizBar = value;
				flag = (this._Grid_RizBar != null);
				if (flag)
				{
					this._Grid_RizBar.LoadingRow += value2;
				}
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0012D374 File Offset: 0x0012B574
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0012D38C File Offset: 0x0012B58C
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

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0012D3EC File Offset: 0x0012B5EC
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0012D404 File Offset: 0x0012B604
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
				DateBox2.OnLeftEventHandler obj2 = new DateBox2.OnLeftEventHandler(this.txt_tarikhGrid_OnLeft);
				bool flag = this._txt_tarikhGrid != null;
				if (flag)
				{
					this._txt_tarikhGrid.OnRight -= obj;
					this._txt_tarikhGrid.OnLeft -= obj2;
				}
				this._txt_tarikhGrid = value;
				flag = (this._txt_tarikhGrid != null);
				if (flag)
				{
					this._txt_tarikhGrid.OnRight += obj;
					this._txt_tarikhGrid.OnLeft += obj2;
				}
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0012D48C File Offset: 0x0012B68C
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x000079E2 File Offset: 0x00005BE2
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0012D4A4 File Offset: 0x0012B6A4
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x000079EC File Offset: 0x00005BEC
		internal virtual ControlContainerItem ControlContainerItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ControlContainerItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ControlContainerItem2 = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0012D4BC File Offset: 0x0012B6BC
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x000079F6 File Offset: 0x00005BF6
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

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0012D4D4 File Offset: 0x0012B6D4
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x00007A00 File Offset: 0x00005C00
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

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0012D4EC File Offset: 0x0012B6EC
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00007A0A File Offset: 0x00005C0A
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0012D504 File Offset: 0x0012B704
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00007A14 File Offset: 0x00005C14
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0012D51C File Offset: 0x0012B71C
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00007A1E File Offset: 0x00005C1E
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0012D534 File Offset: 0x0012B734
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x00007A28 File Offset: 0x00005C28
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

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0012D54C File Offset: 0x0012B74C
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x00007A32 File Offset: 0x00005C32
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

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0012D564 File Offset: 0x0012B764
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x00007A3C File Offset: 0x00005C3C
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

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0012D57C File Offset: 0x0012B77C
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x00007A46 File Offset: 0x00005C46
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

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0012D594 File Offset: 0x0012B794
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0012D5AC File Offset: 0x0012B7AC
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

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0012D60C File Offset: 0x0012B80C
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x0012D624 File Offset: 0x0012B824
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_makharej_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_makharej_ButtonClick);
				bool flag = this._txt_makharej != null;
				if (flag)
				{
					this._txt_makharej.KeyDown -= value2;
					this._txt_makharej.ButtonClick -= value3;
				}
				this._txt_makharej = value;
				flag = (this._txt_makharej != null);
				if (flag)
				{
					this._txt_makharej.KeyDown += value2;
					this._txt_makharej.ButtonClick += value3;
				}
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0012D6AC File Offset: 0x0012B8AC
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x00007A50 File Offset: 0x00005C50
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0012D6C4 File Offset: 0x0012B8C4
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0012D6DC File Offset: 0x0012B8DC
		internal virtual CurrencyBox txt_rizbar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_rizbar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_rizbar_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_rizbar_ButtonClick);
				bool flag = this._txt_rizbar != null;
				if (flag)
				{
					this._txt_rizbar.KeyDown -= value2;
					this._txt_rizbar.ButtonClick -= value3;
				}
				this._txt_rizbar = value;
				flag = (this._txt_rizbar != null);
				if (flag)
				{
					this._txt_rizbar.KeyDown += value2;
					this._txt_rizbar.ButtonClick += value3;
				}
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0012D764 File Offset: 0x0012B964
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x00007A5A File Offset: 0x00005C5A
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

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0012D77C File Offset: 0x0012B97C
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0012D794 File Offset: 0x0012B994
		internal virtual ButtonItem ButtonItem12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem12_Click);
				bool flag = this._ButtonItem12 != null;
				if (flag)
				{
					this._ButtonItem12.Click -= value2;
				}
				this._ButtonItem12 = value;
				flag = (this._ButtonItem12 != null);
				if (flag)
				{
					this._ButtonItem12.Click += value2;
				}
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0012D7F4 File Offset: 0x0012B9F4
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0012D80C File Offset: 0x0012BA0C
		internal virtual ButtonItem ButtonItem13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem13_Click);
				bool flag = this._ButtonItem13 != null;
				if (flag)
				{
					this._ButtonItem13.Click -= value2;
				}
				this._ButtonItem13 = value;
				flag = (this._ButtonItem13 != null);
				if (flag)
				{
					this._ButtonItem13.Click += value2;
				}
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0012D86C File Offset: 0x0012BA6C
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0012D884 File Offset: 0x0012BA84
		internal virtual ButtonItem ButtonItem14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem14_Click);
				bool flag = this._ButtonItem14 != null;
				if (flag)
				{
					this._ButtonItem14.Click -= value2;
				}
				this._ButtonItem14 = value;
				flag = (this._ButtonItem14 != null);
				if (flag)
				{
					this._ButtonItem14.Click += value2;
				}
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0012D8E4 File Offset: 0x0012BAE4
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x00007A64 File Offset: 0x00005C64
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
				this._ButtonItem15 = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0012D8FC File Offset: 0x0012BAFC
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0012D914 File Offset: 0x0012BB14
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

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0012D974 File Offset: 0x0012BB74
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0012D98C File Offset: 0x0012BB8C
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0012D9EC File Offset: 0x0012BBEC
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0012DA04 File Offset: 0x0012BC04
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0012DA64 File Offset: 0x0012BC64
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0012DA7C File Offset: 0x0012BC7C
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0012DADC File Offset: 0x0012BCDC
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0012DAF4 File Offset: 0x0012BCF4
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

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0012DB54 File Offset: 0x0012BD54
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0012DB6C File Offset: 0x0012BD6C
		internal virtual CurrencyBox txt_pardakhti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pardakhti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_pardakhti_KeyDown);
				bool flag = this._txt_pardakhti != null;
				if (flag)
				{
					this._txt_pardakhti.KeyDown -= value2;
				}
				this._txt_pardakhti = value;
				flag = (this._txt_pardakhti != null);
				if (flag)
				{
					this._txt_pardakhti.KeyDown += value2;
				}
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0012DBCC File Offset: 0x0012BDCC
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x00007A6E File Offset: 0x00005C6E
		public bool Show_Preview
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Show_Preview;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Show_Preview = value;
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0012DBE4 File Offset: 0x0012BDE4
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

		// Token: 0x06001AAF RID: 6831 RVA: 0x0012DC88 File Offset: 0x0012BE88
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0012DCDC File Offset: 0x0012BEDC
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0012DD18 File Offset: 0x0012BF18
		private void Frm_Kharid_Furush_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.Show_Preview;
			if (!flag)
			{
				flag = this.prevent_close;
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
					case DialogResult.No:
						this.RollBackKeraye();
						this.prevent_close = true;
						break;
					}
				}
			}
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0012DDB4 File Offset: 0x0012BFB4
		private void frm_Frush_hag_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.Control && e.KeyCode == Keys.F5;
			if (flag)
			{
				this.ButtonItem3_Click(null, null);
			}
			else
			{
				Keys keyCode = e.KeyCode;
				flag = (keyCode == Keys.Insert);
				bool flag2;
				if (flag)
				{
					flag2 = this.ButtonItem1.Visible;
					if (flag2)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
				else
				{
					flag2 = (keyCode == Keys.F2);
					if (flag2)
					{
						flag = this.ButtonItem2.Enabled;
						if (flag)
						{
							this.ButtonItem2_Click(null, null);
						}
					}
					else
					{
						flag2 = (keyCode == Keys.F3);
						if (flag2)
						{
							flag = this.ButtonItem11.Enabled;
							if (flag)
							{
								this.ButtonItem11_Click(null, null);
							}
						}
						else
						{
							flag2 = (keyCode == Keys.F4);
							if (flag2)
							{
								flag = this.ButtonItem14.Enabled;
								if (flag)
								{
									this.ButtonItem14_Click(null, null);
								}
							}
							else
							{
								flag2 = (keyCode == Keys.F5);
								if (flag2)
								{
									flag = this.ButtonItem6.Enabled;
									if (flag)
									{
										this.ButtonItem6_Click(null, null);
									}
								}
								else
								{
									flag2 = (keyCode == Keys.F6);
									if (flag2)
									{
										flag = this.ButtonItem13.Enabled;
										if (flag)
										{
											this.ButtonItem13_Click(null, null);
										}
									}
									else
									{
										flag2 = (keyCode == Keys.F10);
										if (flag2)
										{
											flag = this.ButtonItem7.Enabled;
											if (flag)
											{
												this.ButtonItem7_Click(null, null);
											}
										}
										else
										{
											flag2 = (keyCode == Keys.F7);
											if (flag2)
											{
												flag = this.ButtonItem4.Enabled;
												if (flag)
												{
													this.ButtonItem4_Click(null, null);
												}
											}
											else
											{
												flag2 = (keyCode == Keys.F8);
												if (flag2)
												{
													flag = this.ButtonItem10.Enabled;
													if (flag)
													{
														this.ButtonItem10_Click(null, null);
													}
												}
												else
												{
													flag2 = (keyCode == Keys.F9);
													if (flag2)
													{
														this.ButtonItem5_Click(null, null);
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
				Keys keyCode2 = e.KeyCode;
				flag2 = (keyCode2 == Keys.Escape);
				if (flag2)
				{
					flag = this.Show_Preview;
					if (flag)
					{
						this.Close();
					}
					else
					{
						this.prevent_close = true;
						flag2 = this.CanClose();
						if (flag2)
						{
							this.Close();
						}
						else
						{
							flag2 = !this.ButtonItem2.Enabled;
							if (flag2)
							{
								this.Close();
							}
							else
							{
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

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0012E030 File Offset: 0x0012C230
		private bool CanClose()
		{
			bool result = false;
			bool flag = this.Isnew && this.txt_moshtari.Value == null && Operators.CompareString(this.txt_sh_mashin.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_sh_barname.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_baskul_mabda.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_baskul.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_tedad.Text, string.Empty, false) == 0 && this.Grid_RizBar.RowCount == 0 && this.GridEX1.RowCount == 1;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0012E108 File Offset: 0x0012C308
		private void SetFont(Control parent)
		{
			try
			{
				IEnumerator enumerator = parent.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is Label;
					if (flag)
					{
						control.Font = this.Label1.Font;
					}
					flag = (control.Controls.Count > 0);
					if (flag)
					{
						this.SetFont(control);
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

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0012E1AC File Offset: 0x0012C3AC
		private void frm_Frush_hag_Load(object sender, EventArgs e)
		{
			this.txt_num.UiButton2.Image = null;
			this.txt_num.UiButton2.Text = "...";
			bool flag = !Conversions.ToBoolean(Public_Function.dict["show_avg"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["avg"].Visible = false;
			}
			else
			{
				this.GridEX1.RootTable.Columns["avg"].Visible = true;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["kargari"].Visible = true;
				this.GridEX1.RootTable.Columns["jamkol_ba_kargari"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.Columns["kargari"].Visible = false;
				this.GridEX1.RootTable.Columns["jamkol_ba_kargari"].Visible = false;
			}
			this.txt_moshtari.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("num", "سند", 15));
			itemCollection.Add(new Column("Moshtari_Name", "صاحب بار", 65));
			this.frm_furush.items = itemCollection;
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection2.Add(new Column("Code", "کد", 15));
			itemCollection2.Add(new Column("Name", "عنوان", 65));
			itemCollection2.Add(new Column("shahr", "منطقه", 25));
			this.frm.items = itemCollection2;
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			flag = (this.Num == -1);
			checked
			{
				if (flag)
				{
					this.MeNew();
				}
				else
				{
					this.LoadData();
					flag = this.Show_Preview;
					if (flag)
					{
						this.Bar1.Visible = false;
						this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
						this.txt_desc.Enabled = false;
						this.txt_fee.Enabled = false;
						this.txt_jam_kol.Enabled = false;
						this.txt_makharej.Enabled = false;
						this.txt_moshtari.Enabled = false;
						this.txt_num.Enabled = false;
						this.txt_rizbar.Enabled = false;
						this.txt_sh_barname.Enabled = false;
						this.txt_sh_mashin.Enabled = false;
						this.txt_tarikh_vurud.Enabled = false;
						this.txt_tarikhGrid.Enabled = false;
					}
					flag = (this.GotoLineID != -1);
					if (flag)
					{
						GridEXRow[] rows = this.GridEX1.GetRows();
						for (int i = 0; i < rows.Length; i++)
						{
							GridEXRow gridEXRow = rows[i];
							bool flag2 = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["ID"], this.GotoLineID, false);
							if (flag2)
							{
								this.GridEX1.Focus();
								this.GridEX1.MoveTo(gridEXRow);
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["fee"].Position;
								this.GridEX1.EditMode = EditMode.EditOn;
								break;
							}
						}
					}
				}
				this.frm.GridEX1.ColumnButtonClick += new ColumnActionEventHandler(this.btn_click);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0011FD30 File Offset: 0x0011DF30
		private int GetNextPos(Frm_SuratHesab_Moshtari.bedbes bedbes, int pos, DataTable dt)
		{
			checked
			{
				int arg_12_0 = pos + 1;
				int num = dt.Rows.Count - 1;
				int num2 = arg_12_0;
				while (true)
				{
					int arg_B3_0 = num2;
					int num3 = num;
					if (arg_B3_0 > num3)
					{
						goto Block_5;
					}
					bool flag = bedbes == Frm_SuratHesab_Moshtari.bedbes.bed;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bed"], 0, false);
						if (flag2)
						{
							break;
						}
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bes"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["stat"], "بد", false);
						if (flag2)
						{
							goto Block_4;
						}
					}
					num2++;
				}
				int result = num2;
				return result;
				Block_4:
				result = num2;
				return result;
				Block_5:
				result = -1;
				return result;
			}
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0012E580 File Offset: 0x0012C780
		private void Furush_select()
		{
			this.frm_furush.CanEdit = false;
			this.frm_furush.CanDelete = false;
			this.frm_furush.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm_furush.Text = "انتخاب سند فروش";
			string empty = string.Empty;
			string command = "SELECT     Furush_Hag.ID, max(Furush_Hag.Num) AS num,max(Tarikh_Vurud) AS Tarikh_Vurud,  max(Moshtari.Name)+' '+ max(Moshtari.Family) AS Moshtari_Name FROM         Furush_Hag LEFT OUTER JOIN  Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  WHERE (Furush_Hag.ID NOT IN  (SELECT     Furush_Hag_ID  FROM         Safi_Furush))  GROUP BY Furush_Hag.ID  order by tarikh_vurud";
			bool flag = this.frm_furush.ShowDialog(command, null, 0) == DialogResult.OK;
			if (flag)
			{
				long num = Conversions.ToLong(this.frm_furush.SelectedRow["num"]);
				flag = (num == 0L);
				if (!flag)
				{
					flag = (num != (long)this.Num);
					if (flag)
					{
						this.Num = checked((int)num);
						this.LoadData();
					}
				}
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0012E63C File Offset: 0x0012C83C
		private void Moshtari_Select(char chr = '\0')
		{
			bool flag = this.txt_moshtari.Value == null;
			checked
			{
				if (flag)
				{
					this.txt_moshtari.ShowTip("لطفا ابتدا صاحب بار را مشخص فرمائید ");
				}
				else
				{
					this.frm.CanEdit = true;
					this.frm.CanDelete = false;
					this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
					this.frm.chara = chr;
					string text = string.Empty;
					flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
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
					flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
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
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0012E854 File Offset: 0x0012CA54
		private void btn_click(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "del", false) == 0;
			if (flag)
			{
				bool flag2 = this.frm.GridEX1.CurrentRow != null;
				if (flag2)
				{
					try
					{
						NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
						{
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from moshtari_kala where moshtari_id=", this.txt_moshtari.Value), " and kala_id="), this.frm.GridEX1.CurrentRow.Cells["ID"].Value)
						}, null, null, null, true);
						this.frm.GridEX1.CurrentRow.Delete();
					}
					catch (Exception expr_C5)
					{
						ProjectData.SetProjectError(expr_C5);
						Public_Function.ShowMessage("امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0012E958 File Offset: 0x0012CB58
		private void RollBackTedadVazn(int? kala_id, ref int? row_index, decimal? tedad, decimal? vazn)
		{
			bool flag = !kala_id.HasValue;
			if (!flag)
			{
				flag = !row_index.HasValue;
				if (!flag)
				{
					DataRow[] array = this.dt_rizbar.Select("kala_id=" + (kala_id.HasValue ? Conversions.ToString(kala_id.GetValueOrDefault()) : null));
					flag = (array.Length > 0);
					bool flag2;
					if (flag)
					{
						flag2 = tedad.HasValue;
						if (flag2)
						{
							DataRow[] array2 = array;
							DataRow[] arg_81_0 = array2;
							int num = 0;
							DataRow arg_A2_0 = arg_81_0[num];
							string columnName = "tedad";
							arg_A2_0[columnName] = Operators.SubtractObject(array2[num][columnName], tedad);
						}
						flag2 = vazn.HasValue;
						if (flag2)
						{
							DataRow[] array2 = array;
							DataRow[] arg_C0_0 = array2;
							int num = 0;
							DataRow arg_E2_0 = arg_C0_0[num];
							string columnName = "vazn";
							arg_E2_0[columnName] = Operators.SubtractObject(array2[num][columnName], vazn);
						}
						flag2 = this.CheckForDeleteKharid(array[0]);
						if (flag2)
						{
							DataRow[] array3 = this.dt_kala_to_kala.Select("child_kala_id=" + (kala_id.HasValue ? Conversions.ToString(kala_id.GetValueOrDefault()) : null));
							flag2 = (array3.Length > 0);
							if (flag2)
							{
								int value = Conversions.ToInteger(array3[0]["parent_kala_id"]);
								DataRow[] array4 = this.dt_rizbar.Select("kala_ID=" + Conversions.ToString(value));
								flag2 = (array4.Length > 0);
								if (flag2)
								{
									row_index = this.dt_rizbar.Rows.IndexOf(array4[0]);
								}
							}
						}
					}
					flag2 = tedad.HasValue;
					if (flag2)
					{
						DataRow dataRow = this.dt_rizbar.Rows[(T)row_index];
						DataRow arg_1DB_0 = dataRow;
						string columnName = "tedad";
						arg_1DB_0[columnName] = Operators.AddObject(dataRow[columnName], tedad);
					}
					flag2 = Operators.ConditionalCompareObjectNotEqual(this.dt_rizbar.Rows[(T)row_index]["vazn"], 0, false);
					if (flag2)
					{
						flag = vazn.HasValue;
						if (flag)
						{
							DataRow dataRow = this.dt_rizbar.Rows[(T)row_index];
							DataRow arg_263_0 = dataRow;
							string columnName = "vazn";
							arg_263_0[columnName] = Operators.AddObject(dataRow[columnName], vazn);
						}
					}
				}
				this.SyncTedad();
			}
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0012EBDC File Offset: 0x0012CDDC
		private void Re_Index()
		{
			checked
			{
				try
				{
					IEnumerator enumerator = this.dt_kala_to_kala.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow[] array = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow["parent_kala_id"])));
						bool flag = array.Length > 0;
						if (flag)
						{
							int num = this.dt_rizbar.Rows.IndexOf(array[0]);
							DataRow[] array2 = ((DataTable)this.GridEX1.DataSource).Select(Conversions.ToString(Operators.ConcatenateObject("kala_ID=", dataRow["child_kala_id"])));
							DataRow[] array3 = array2;
							for (int i = 0; i < array3.Length; i++)
							{
								DataRow dataRow2 = array3[i];
								dataRow2["row_index"] = num;
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
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0012ED04 File Offset: 0x0012CF04
		private bool CheckForDeleteKharid(DataRow row)
		{
			bool flag = row["auto"] == DBNull.Value;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = false;
				bool flag3 = false;
				flag = ("tedad" == DBNull.Value);
				if (flag)
				{
					flag2 = true;
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(row["tedad"], 0, false);
					if (flag)
					{
						flag2 = true;
					}
				}
				flag = (row["vazn"] == DBNull.Value);
				if (flag)
				{
					flag3 = true;
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(row["vazn"], 0, false);
					if (flag)
					{
						flag3 = true;
					}
				}
				flag = (flag2 & flag3);
				if (flag)
				{
					DataTable table = row.Table;
					row.Delete();
					table.AcceptChanges();
					this.Re_Index();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0012EDE0 File Offset: 0x0012CFE0
		private bool Is_In_Kharid_auto(long kala_ID)
		{
			bool result;
			try
			{
				IEnumerator enumerator = this.dt_rizbar.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["kala_ID"], kala_ID, false), dataRow["auto"] != DBNull.Value));
					if (flag)
					{
						result = true;
						return result;
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
			result = false;
			return result;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0012EE94 File Offset: 0x0012D094
		private bool Is_In_Kharid(long kala_ID)
		{
			bool flag = this.dt_rizbar == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					IEnumerator enumerator = this.dt_rizbar.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["kala_ID"], kala_ID, false), dataRow["auto"] == DBNull.Value));
						if (flag)
						{
							result = true;
							return result;
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
				result = false;
			}
			return result;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0012EF5C File Offset: 0x0012D15C
		private void Subtract_from_kharid_tedad()
		{
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			bool flag = dataRowView["row_index"] != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(dataRowView["row_index"], -1, false);
				if (!flag2)
				{
					flag2 = (dataRowView["tafazol_tedad"] != DBNull.Value);
					if (flag2)
					{
						flag = (this.dt_rizbar.Rows.Count == 0);
						if (flag)
						{
							return;
						}
						flag2 = (this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])]["tedad"] != DBNull.Value);
						if (flag2)
						{
							DataRow dataRow = this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])];
							DataRow arg_112_0 = dataRow;
							string columnName = "tedad";
							arg_112_0[columnName] = Operators.AddObject(dataRow[columnName], dataRowView["tafazol_tedad"]);
						}
					}
					flag2 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
					if (flag2)
					{
						flag = (this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])]["tedad"] != DBNull.Value);
						if (flag)
						{
							DataRow dataRow = this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])];
							DataRow arg_1E0_0 = dataRow;
							string columnName = "tedad";
							arg_1E0_0[columnName] = Operators.SubtractObject(dataRow[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
							DataRow[] array = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
							flag2 = (array.Length > 0);
							if (flag2)
							{
								flag = (dataRowView["tafazol_tedad"] != DBNull.Value);
								DataRow[] array2;
								int num;
								if (flag)
								{
									array2 = array;
									DataRow[] arg_254_0 = array2;
									num = 0;
									DataRow arg_27A_0 = arg_254_0[num];
									columnName = "tedad";
									arg_27A_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_tedad"]);
								}
								array2 = array;
								DataRow[] arg_28B_0 = array2;
								num = 0;
								DataRow arg_2C5_0 = arg_28B_0[num];
								columnName = "tedad";
								arg_2C5_0[columnName] = Operators.AddObject(array2[num][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
							}
							dataRowView["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
						}
						else
						{
							dataRowView["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
						}
					}
					else
					{
						DataRow[] array3 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
						flag2 = (array3.Length > 0);
						if (flag2)
						{
							flag = (dataRowView["tafazol_tedad"] != DBNull.Value);
							if (flag)
							{
								DataRow[] array2 = array3;
								DataRow[] arg_3A1_0 = array2;
								int num = 0;
								DataRow arg_3C7_0 = arg_3A1_0[num];
								string columnName = "tedad";
								arg_3C7_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_tedad"]);
								this.CheckForDeleteKharid(array3[0]);
							}
							dataRowView["tafazol_tedad"] = 0;
						}
					}
				}
			}
			else
			{
				dataRowView["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0012F38C File Offset: 0x0012D58C
		private void Subtract_from_kharid_vazn()
		{
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			bool flag = dataRowView["row_index"] != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(dataRowView["row_index"], -1, false);
				if (!flag2)
				{
					flag2 = (dataRowView["tafazol_vazn"] != DBNull.Value);
					bool flag3;
					if (flag2)
					{
						flag = (this.dt_rizbar.Rows.Count > 0);
						if (flag)
						{
							flag3 = Operators.ConditionalCompareObjectNotEqual(this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])]["vazn"], 0, false);
							if (flag3)
							{
								DataRow dataRow = this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])];
								DataRow arg_111_0 = dataRow;
								string columnName = "vazn";
								arg_111_0[columnName] = Operators.AddObject(dataRow[columnName], dataRowView["tafazol_vazn"]);
							}
						}
					}
					flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
					if (flag3)
					{
						flag2 = Operators.ConditionalCompareObjectNotEqual(this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])]["vazn"], 0, false);
						if (flag2)
						{
							DataRow dataRow = this.dt_rizbar.Rows[Conversions.ToInteger(dataRowView["row_index"])];
							DataRow arg_1DF_0 = dataRow;
							string columnName = "vazn";
							arg_1DF_0[columnName] = Operators.SubtractObject(dataRow[columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
						}
						DataRow[] array = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
						flag3 = (array.Length > 0);
						if (flag3)
						{
							flag2 = (dataRowView["tafazol_vazn"] != DBNull.Value);
							string columnName;
							DataRow[] array2;
							int num;
							if (flag2)
							{
								array2 = array;
								DataRow[] arg_254_0 = array2;
								num = 0;
								DataRow arg_27A_0 = arg_254_0[num];
								columnName = "vazn";
								arg_27A_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_vazn"]);
							}
							array2 = array;
							DataRow[] arg_28B_0 = array2;
							num = 0;
							DataRow arg_2C5_0 = arg_28B_0[num];
							columnName = "vazn";
							arg_2C5_0[columnName] = Operators.AddObject(array2[num][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
						}
						dataRowView["tafazol_vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
					}
					else
					{
						DataRow[] array3 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
						flag3 = (array3.Length > 0);
						if (flag3)
						{
							flag2 = (dataRowView["tafazol_vazn"] != DBNull.Value);
							if (flag2)
							{
								DataRow[] array2 = array3;
								DataRow[] arg_36D_0 = array2;
								int num = 0;
								DataRow arg_393_0 = arg_36D_0[num];
								string columnName = "vazn";
								arg_393_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_vazn"]);
								this.CheckForDeleteKharid(array3[0]);
							}
							dataRowView["tafazol_vazn"] = 0;
						}
					}
				}
			}
			else
			{
				dataRowView["tafazol_vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0012F788 File Offset: 0x0012D988
		private void Kala_select(char chr = '\0')
		{
			bool flag = this.txt_moshtari.Value == null;
			checked
			{
				if (flag)
				{
					Public_Function.ShowMessage("لطفا صاحب بار را انتخاب فرمائید", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					this.txt_moshtari.Focus();
				}
				else
				{
					this.frm.CanEdit = false;
					this.frm.CanDelete = true;
					this.frm.chara = chr;
					string iD = Public_Function.GetID(this.dt_rizbar, "kala_id", "");
					string right = string.Empty;
					flag = (Operators.CompareString(iD, string.Empty, false) != 0);
					if (flag)
					{
						right = " AND Kala_ID not in (" + iD + ")";
					}
					string text = string.Empty;
					flag = (Operators.CompareString(iD, string.Empty, false) != 0);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=", this.txt_moshtari.Value), " AND Kala_ID in ("), iD), ")"), " UNION ALL ")));
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=", this.txt_moshtari.Value), right)));
					flag = (this.GridEX1.CurrentRow.Cells["prekala_id"].Value != DBNull.Value);
					int? num;
					if (flag)
					{
						object expr_17D = this.GridEX1.CurrentRow.Cells["prekala_id"].Value;
						int? num2;
						num = ((expr_17D != null) ? ((int?)expr_17D) : num2);
					}
					this.frm.ExtraData = Conversions.ToLong(this.txt_moshtari.Value);
					flag = (this.frm.ShowDialog(text, MyProject.Forms.Frm_Moshtari_kala, 0) == DialogResult.OK);
					if (flag)
					{
						bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position && this.GridEX1.EditTextBox != null;
						if (flag2)
						{
							this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
							this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							flag2 = (this.dt_rizbar.Rows.Count == 0);
							if (flag2)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
							else
							{
								flag2 = num.HasValue;
								DataEntryGrid gridEX;
								if (flag2)
								{
									flag = Operators.ConditionalCompareObjectEqual(num, this.frm.SelectedRow["ID"], false);
									if (flag)
									{
										gridEX = this.GridEX1;
										gridEX.Col++;
										return;
									}
								}
								flag2 = !this.Is_In_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
								if (flag2)
								{
									flag = (this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"])) == -1);
									if (flag)
									{
										Frm_Select_Kala_To_Kala frm_Select_Kala_To_Kala = new Frm_Select_Kala_To_Kala
										{
											Dt_Kharid = this.dt_rizbar
										};
										frm_Select_Kala_To_Kala.GridEX1.RootTable.Columns["vazn_ba_zarf"].DataMember = "vazn";
										flag2 = (MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Select_Kala_To_Kala) == DialogResult.OK);
										if (!flag2)
										{
											this.GridEX1.EditTextBox.Text = string.Empty;
											this.GridEX1.GetRow().Cells["Kala_ID"].Value = DBNull.Value;
											return;
										}
										flag = (this.ID != -1);
										if (flag)
										{
											this.kala_to_kala.Insert(unchecked((long)this.ID), Conversions.ToLong(frm_Select_Kala_To_Kala.Selected_Row.Cells["Kala_ID"].Value), Conversions.ToLong(this.frm.SelectedRow["ID"]));
										}
										DataRow dataRow = this.dt_kala_to_kala.NewRow();
										dataRow["Furush_ID"] = this.ID;
										dataRow["child_kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
										dataRow["Parent_kala_id"] = RuntimeHelpers.GetObjectValue(frm_Select_Kala_To_Kala.Selected_Row.Cells["Kala_ID"].Value);
										this.dt_kala_to_kala.Rows.Add(dataRow);
										DataRow dataRow2 = this.dt_rizbar.NewRow();
										dataRow2["kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
										dataRow2["kala_name"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"]);
										int num3 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
										dataRow2["auto"] = true;
										flag2 = num.HasValue;
										bool flag3;
										if (flag2)
										{
											DataRow[] array = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
											flag2 = (array.Length > 0);
											if (flag2)
											{
												flag = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
												if (flag)
												{
													flag3 = (array[0]["tedad"] != DBNull.Value);
													if (flag3)
													{
														DataRow[] array2 = array;
														DataRow[] arg_61C_0 = array2;
														int num4 = 0;
														DataRow arg_656_0 = arg_61C_0[num4];
														string columnName = "tedad";
														arg_656_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
													}
												}
												flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
												if (flag3)
												{
													flag2 = (array[0]["vazn"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array;
														DataRow[] arg_6B6_0 = array2;
														int num4 = 0;
														DataRow arg_6F0_0 = arg_6B6_0[num4];
														string columnName = "vazn";
														arg_6F0_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
													}
												}
												this.CheckForDeleteKharid(array[0]);
											}
										}
										flag3 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
										if (flag3)
										{
											dataRow2["tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
										}
										else
										{
											dataRow2["tedad"] = 0;
										}
										flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
										if (flag3)
										{
											dataRow2["vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
										}
										else
										{
											dataRow2["vazn"] = 0;
										}
										this.dt_rizbar.Rows.InsertAt(dataRow2, num3 + 1);
										((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num3;
										this.SyncTedad();
									}
									else
									{
										bool flag3 = !this.Is_In_Kharid_auto(Conversions.ToLong(this.frm.SelectedRow["ID"]));
										if (flag3)
										{
											DataRow dataRow3 = this.dt_rizbar.NewRow();
											dataRow3["kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
											dataRow3["kala_name"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"]);
											int num5 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
											dataRow3["auto"] = true;
											flag3 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
											if (flag3)
											{
												dataRow3["tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
											}
											else
											{
												dataRow3["tedad"] = 0;
											}
											flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
											if (flag3)
											{
												dataRow3["vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
											}
											else
											{
												dataRow3["vazn"] = 0;
											}
											flag3 = num.HasValue;
											if (flag3)
											{
												int num6 = this.Get_Parent_Kala_Index_IN_Kharid(unchecked((long)((T)num)));
												flag3 = (num6 != -1);
												if (flag3)
												{
													flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
													if (flag2)
													{
														DataRow dataRow4 = this.dt_rizbar.Rows[num6];
														DataRow arg_AD8_0 = dataRow4;
														string columnName = "tedad";
														arg_AD8_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow dataRow4 = this.dt_rizbar.Rows[num6];
														DataRow arg_B5A_0 = dataRow4;
														string columnName = "vazn";
														arg_B5A_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													DataRow[] array3 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
													flag3 = (array3.Length > 0);
													if (flag3)
													{
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag2)
														{
															DataRow[] array2 = array3;
															DataRow[] arg_BDA_0 = array2;
															int num4 = 0;
															DataRow arg_C14_0 = arg_BDA_0[num4];
															string columnName = "tedad";
															arg_C14_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag3)
														{
															DataRow[] array2 = array3;
															DataRow[] arg_C55_0 = array2;
															int num4 = 0;
															DataRow arg_C8F_0 = arg_C55_0[num4];
															string columnName = "vazn";
															arg_C8F_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
														}
														this.CheckForDeleteKharid(array3[0]);
														flag3 = (array3[0].RowState != DataRowState.Detached);
														if (flag3)
														{
														}
													}
												}
											}
											this.dt_rizbar.Rows.InsertAt(dataRow3, num5 + 1);
											((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num5;
											flag3 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[num5];
												DataRow arg_D76_0 = dataRow4;
												string columnName = "tedad";
												arg_D76_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
											}
											flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[num5];
												DataRow arg_DF8_0 = dataRow4;
												string columnName = "vazn";
												arg_DF8_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
											}
										}
										else
										{
											flag3 = num.HasValue;
											if (flag3)
											{
												int num7 = this.Get_Parent_Kala_Index_IN_Kharid(unchecked((long)((T)num)));
												flag3 = (num7 != -1);
												if (flag3)
												{
													flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
													if (flag2)
													{
														DataRow dataRow4 = this.dt_rizbar.Rows[num7];
														DataRow arg_EB0_0 = dataRow4;
														string columnName = "tedad";
														arg_EB0_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow dataRow4 = this.dt_rizbar.Rows[num7];
														DataRow arg_F32_0 = dataRow4;
														string columnName = "vazn";
														arg_F32_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													DataRow[] array4 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
													flag3 = (array4.Length > 0);
													if (flag3)
													{
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag2)
														{
															DataRow[] array2 = array4;
															DataRow[] arg_FB2_0 = array2;
															int num4 = 0;
															DataRow arg_FEC_0 = arg_FB2_0[num4];
															string columnName = "tedad";
															arg_FEC_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag3)
														{
															DataRow[] array2 = array4;
															DataRow[] arg_102D_0 = array2;
															int num4 = 0;
															DataRow arg_1067_0 = arg_102D_0[num4];
															string columnName = "vazn";
															arg_1067_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
														}
														this.CheckForDeleteKharid(array4[0]);
														flag3 = (array4[0].RowState != DataRowState.Detached);
														if (flag3)
														{
														}
													}
												}
											}
											int num8 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
											((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num8;
											flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[num8];
												DataRow arg_1156_0 = dataRow4;
												string columnName = "tedad";
												arg_1156_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
											flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[num8];
												DataRow arg_11D8_0 = dataRow4;
												string columnName = "vazn";
												arg_11D8_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
											}
											DataRow[] array5 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.frm.SelectedRow["ID"])));
											flag3 = (array5.Length > 0);
											if (flag3)
											{
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
												if (flag2)
												{
													DataRow[] array2 = array5;
													DataRow[] arg_125A_0 = array2;
													int num4 = 0;
													DataRow arg_1294_0 = arg_125A_0[num4];
													string columnName = "tedad";
													arg_1294_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow[] array2 = array5;
													DataRow[] arg_12D5_0 = array2;
													int num4 = 0;
													DataRow arg_130F_0 = arg_12D5_0[num4];
													string columnName = "vazn";
													arg_130F_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
												}
											}
										}
										this.Subtract_from_kharid_tedad();
										this.Subtract_from_kharid_vazn();
										this.SyncTedad();
									}
								}
								else
								{
									bool flag3 = ((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] != DBNull.Value;
									if (flag3)
									{
										flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
										if (flag2)
										{
											flag = (this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]["tedad"] != DBNull.Value);
											if (flag)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_1454_0 = dataRow4;
												string columnName = "tedad";
												arg_1454_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
										}
										flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
										if (flag3)
										{
											flag2 = Operators.ConditionalCompareObjectNotEqual(this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]["vazn"], 0, false);
											if (flag2)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_154C_0 = dataRow4;
												string columnName = "vazn";
												arg_154C_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
											}
										}
										flag3 = num.HasValue;
										if (flag3)
										{
											DataRow[] array6 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
											flag3 = (array6.Length > 0);
											if (flag3)
											{
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
												if (flag2)
												{
													DataRow[] array2 = array6;
													DataRow[] arg_15DD_0 = array2;
													int num4 = 0;
													DataRow arg_1617_0 = arg_15DD_0[num4];
													string columnName = "tedad";
													arg_1617_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow[] array2 = array6;
													DataRow[] arg_1658_0 = array2;
													int num4 = 0;
													DataRow arg_1692_0 = arg_1658_0[num4];
													string columnName = "vazn";
													arg_1692_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
												}
												int num9 = Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"]);
												flag3 = (num9 != -1);
												if (flag3)
												{
													this.CheckForDeleteKharid(array6[0]);
												}
											}
										}
										((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = DBNull.Value;
										this.Subtract_from_kharid_tedad();
										this.Subtract_from_kharid_vazn();
										this.SyncTedad();
									}
									else
									{
										this.Subtract_from_kharid_tedad();
										this.Subtract_from_kharid_vazn();
										this.SyncTedad();
									}
								}
								gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00130EE0 File Offset: 0x0012F0E0
		private void Add_Auto_Kala()
		{
			bool flag = this.dt_rizbar.Rows.Count == 0;
			if (!flag)
			{
				flag = (this.GridEX1.CurrentRow.Cells["kala_ID"].Value == DBNull.Value);
				if (!flag)
				{
					flag = !this.Is_In_Kharid(Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_id"].Value));
					if (flag)
					{
						bool flag2 = !this.Is_In_Kharid_auto(Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_ID"].Value));
						if (flag2)
						{
							DataRow dataRow = this.dt_rizbar.NewRow();
							dataRow["kala_id"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["kala_id"].Value);
							dataRow["kala_name"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["kala_Name"].Value);
							int num = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_ID"].Value));
							dataRow["auto"] = true;
							dataRow["tedad"] = 0;
							dataRow["vazn"] = 0;
							this.dt_rizbar.Rows.InsertAt(dataRow, checked(num + 1));
							((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num;
						}
					}
				}
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x001310B0 File Offset: 0x0012F2B0
		private void GetSum(string key, bool GroupDigit = false)
		{
			decimal num = 0m;
			int arg_18_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_18_0;
				bool flag;
				while (true)
				{
					int arg_96_0 = num3;
					int num4 = num2;
					if (arg_96_0 > num4)
					{
						break;
					}
					flag = (this.GridEX1.GetRow(num3).RowType == RowType.TotalRow);
					if (!flag)
					{
						flag = (this.GridEX1.GetRow(num3).Cells[key].Value == DBNull.Value);
						if (!flag)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells[key].Value));
						}
					}
					num3++;
				}
				flag = !GroupDigit;
				if (flag)
				{
					this.GridEX1.GetTotalRow().Cells[key].Text = Conversions.ToString(Public_Function.GetDecimalValue(num));
				}
				else
				{
					this.GridEX1.GetTotalRow().Cells[key].Text = Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
				}
			}
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x001311B4 File Offset: 0x0012F3B4
		private void Calc()
		{
			bool flag = this.GridEX1.GetRow().Cells["Tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Tedad"].Value != null;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				object expr_72 = this.GridEX1.GetRow().Cells["Tedad"].Value;
				num = ((expr_72 != null) ? ((decimal?)expr_72) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["Zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Zarf"].Value != null);
			decimal? num3;
			if (flag)
			{
				object expr_F7 = this.GridEX1.GetRow().Cells["Zarf"].Value;
				num3 = ((expr_F7 != null) ? ((decimal?)expr_F7) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != null);
			decimal? num4;
			if (flag)
			{
				object expr_17C = this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value;
				num4 = ((expr_17C != null) ? ((decimal?)expr_17C) : num2);
			}
			flag = (num.HasValue && num4.HasValue && num3.HasValue);
			bool flag4;
			if (flag)
			{
				decimal? arg_1F3_0;
				if (!(num3.HasValue & num.HasValue))
				{
					arg_1F3_0 = null;
				}
				else
				{
					decimal? num5 = new decimal?(decimal.Multiply(num3.GetValueOrDefault(), num.GetValueOrDefault()));
					arg_1F3_0 = num5;
				}
				decimal? num6 = arg_1F3_0;
				bool? arg_235_0;
				if (!(num6.HasValue & num4.HasValue))
				{
					arg_235_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(decimal.Compare(num6.GetValueOrDefault(), num4.GetValueOrDefault()) >= 0);
					arg_235_0 = flag2;
				}
				bool? flag3 = arg_235_0;
				flag4 = flag3.GetValueOrDefault();
				if (flag4)
				{
					this.GridEX1.CurrentRow.Cells["Zarf"].Value = DBNull.Value;
					this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = num4;
					this.GetSum("zarf", false);
				}
				else
				{
					GridEXCell arg_341_0 = this.GridEX1.CurrentRow.Cells["vazn_kol"];
					bool arg_306_0 = num4.HasValue;
					decimal? arg_2FD_0;
					if (!(num.HasValue & num3.HasValue))
					{
						arg_2FD_0 = null;
					}
					else
					{
						decimal? num7 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
						arg_2FD_0 = num7;
					}
					decimal? num5 = arg_2FD_0;
					decimal? arg_332_0;
					if (!(arg_306_0 & num5.HasValue))
					{
						arg_332_0 = null;
					}
					else
					{
						num6 = new decimal?(decimal.Subtract(num4.GetValueOrDefault(), num5.GetValueOrDefault()));
						arg_332_0 = num6;
					}
					arg_341_0.Value = Public_Function.GetDecimalValue((T)arg_332_0);
				}
			}
			flag4 = (!num.HasValue || !num3.HasValue);
			if (flag4)
			{
				flag = num4.HasValue;
				if (flag)
				{
					this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = num4;
				}
			}
			this.GetSum("vazn_kol", false);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0013156C File Offset: 0x0012F76C
		private void CalcMablagh(bool calc_jam_kol, bool calc_fee)
		{
			bool flag = this.GridEX1.RootTable.Columns["vazn_kol"].Visible;
			bool flag2;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				flag2 = (this.GridEX1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_kol"].Value != null);
				if (flag2)
				{
					object expr_9A = this.GridEX1.GetRow().Cells["vazn_kol"].Value;
					num = ((expr_9A != null) ? ((decimal?)expr_9A) : num2);
				}
			}
			else
			{
				flag2 = (this.GridEX1.GetRow().Cells["tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["tedad"].Value != null);
				if (flag2)
				{
					object expr_126 = this.GridEX1.GetRow().Cells["tedad"].Value;
					num = ((expr_126 != null) ? ((decimal?)expr_126) : num2);
				}
			}
			flag2 = (this.GridEX1.GetRow().Cells["fee"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["fee"].Value != null);
			decimal? num3;
			if (flag2)
			{
				object expr_1AD = this.GridEX1.GetRow().Cells["fee"].Value;
				num3 = ((expr_1AD != null) ? ((decimal?)expr_1AD) : num2);
			}
			flag2 = (this.GridEX1.GetRow().Cells["jam_Kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_Kol"].Value != null);
			decimal? num4;
			if (flag2)
			{
				object expr_233 = this.GridEX1.GetRow().Cells["jam_Kol"].Value;
				num4 = ((expr_233 != null) ? ((decimal?)expr_233) : num2);
			}
			if (calc_jam_kol)
			{
				flag = (num.HasValue && num3.HasValue);
				if (flag)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["jam_kol"].Value == DBNull.Value;
					if (flag3)
					{
						GridEXCell arg_2F7_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
						decimal? arg_2F2_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_2F2_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_2F2_0 = num5;
						}
						arg_2F7_0.Value = arg_2F2_0;
					}
					else
					{
						decimal? arg_33D_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_33D_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_33D_0 = num5;
						}
						decimal value = Conversions.ToDecimal(Operators.SubtractObject(arg_33D_0, this.GridEX1.CurrentRow.Cells["jam_kol"].Value));
						flag3 = (decimal.Compare(Math.Abs(value), new decimal(1000L)) > 0);
						if (flag3)
						{
							GridEXCell arg_3E5_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
							decimal? arg_3E0_0;
							if (!(num.HasValue & num3.HasValue))
							{
								arg_3E0_0 = null;
							}
							else
							{
								decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
								arg_3E0_0 = num5;
							}
							arg_3E5_0.Value = arg_3E0_0;
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
					bool? arg_450_0;
					if (!num.HasValue)
					{
						arg_450_0 = null;
					}
					else
					{
						bool? flag4 = new bool?(decimal.Compare(num.GetValueOrDefault(), zero) == 0);
						arg_450_0 = flag4;
					}
					bool? flag5 = arg_450_0;
					flag = flag5.GetValueOrDefault();
					if (!flag)
					{
						GridEXCell arg_4BB_0 = this.GridEX1.CurrentRow.Cells["fee"];
						decimal? arg_4B6_0;
						if (!(num4.HasValue & num.HasValue))
						{
							arg_4B6_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Divide(num4.GetValueOrDefault(), num.GetValueOrDefault()));
							arg_4B6_0 = num5;
						}
						arg_4BB_0.Value = arg_4B6_0;
					}
				}
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00131A40 File Offset: 0x0012FC40
		private void GetTotalZarf()
		{
			decimal num = 0m;
			GridEXRow[] rows = this.GridEX1.GetRows();
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
				this.GridEX1.GetTotalRow().Cells["zarf"].Text = Conversions.ToString(Public_Function.GetDecimalValue(num));
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00131B3C File Offset: 0x0012FD3C
		private void update_avg()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["tedad"].Value == DBNull.Value;
			if (flag)
			{
				this.GridEX1.CurrentRow.Cells["avg"].Value = DBNull.Value;
			}
			else
			{
				flag = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value == DBNull.Value);
				if (flag)
				{
					this.GridEX1.CurrentRow.Cells["avg"].Value = DBNull.Value;
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["tedad"].Value, 0, false);
					if (flag)
					{
						this.GridEX1.CurrentRow.Cells["avg"].Value = DBNull.Value;
					}
					else
					{
						this.GridEX1.CurrentRow.Cells["avg"].Value = decimal.Round(Conversions.ToDecimal(Operators.DivideObject(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value, this.GridEX1.CurrentRow.Cells["tedad"].Value)), 2);
					}
				}
			}
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00131CC4 File Offset: 0x0012FEC4
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "kala_name", false) == 0;
			if (flag)
			{
				this.SyncTedad();
				this.Calc_Kargari();
			}
			else
			{
				flag = (Operators.CompareString(left, "tedad", false) == 0);
				if (flag)
				{
					this.Add_Auto_Kala();
					this.Calc();
					this.GetSum("tedad", false);
					this.GetTotalZarf();
					this.Subtract_from_kharid_tedad();
					this.SyncTedad();
					this.update_avg();
					flag = (this.GridEX1.CurrentRow.Cells["row_Index"].Value == DBNull.Value);
					if (flag)
					{
						bool flag2 = this.GridEX1.CurrentRow.Cells["tedad"] != DBNull.Value;
						if (flag2)
						{
							((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
						}
						else
						{
							((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] = 0;
						}
					}
					this.Calc_Kargari();
				}
				else
				{
					bool flag2 = Operators.CompareString(left, "vazn_ba_zarf", false) == 0;
					if (flag2)
					{
						this.Add_Auto_Kala();
						this.Calc();
						this.GetSum("vazn_ba_zarf", false);
						this.Subtract_from_kharid_vazn();
						this.SyncTedad();
						this.update_avg();
						flag2 = (this.GridEX1.CurrentRow.Cells["row_Index"].Value == DBNull.Value);
						if (flag2)
						{
							flag = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"] != DBNull.Value);
							if (flag)
							{
								((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
							}
							else
							{
								((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] = 0;
							}
						}
					}
					else
					{
						flag2 = (Operators.CompareString(left, "vazn_kol", false) == 0);
						if (flag2)
						{
							this.GetSum("Vazn_Kol", false);
							this.CalcMablagh(true, false);
							flag2 = !this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible;
							if (flag2)
							{
								decimal d = 0m;
								flag2 = (this.GridEX1.CurrentRow.Cells["zarf"].Value != DBNull.Value);
								if (flag2)
								{
									d = Conversions.ToDecimal(this.GridEX1.CurrentRow.Cells["zarf"].Value);
								}
								decimal d2 = 0m;
								flag2 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
								if (flag2)
								{
									d2 = Conversions.ToDecimal(this.GridEX1.CurrentRow.Cells["tedad"].Value);
								}
								flag2 = (this.GridEX1.CurrentRow.Cells["vazn_kol"].Value != DBNull.Value);
								if (flag2)
								{
									this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value = Operators.AddObject(this.GridEX1.CurrentRow.Cells["vazn_kol"].Value, decimal.Multiply(d2, d));
								}
								this.Add_Auto_Kala();
								this.update_avg();
								this.GetSum("vazn_ba_zarf", false);
								this.Subtract_from_kharid_vazn();
								this.SyncTedad();
								this.Calc_Kargari();
								flag2 = (this.GridEX1.CurrentRow.Cells["row_Index"].Value == DBNull.Value);
								if (flag2)
								{
									flag = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"] != DBNull.Value);
									if (flag)
									{
										((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
									}
									else
									{
										((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] = 0;
									}
								}
							}
						}
						else
						{
							flag2 = (Operators.CompareString(left, "zarf", false) == 0);
							if (flag2)
							{
								flag = (this.GridEX1.CurrentRow.Cells["zarf"].Value == DBNull.Value);
								if (flag)
								{
									this.GridEX1.CurrentRow.Cells["zarf"].Value = 0;
								}
								this.Add_Auto_Kala();
								this.Calc();
								this.GetTotalZarf();
								this.SyncTedad();
							}
							else
							{
								flag2 = (Operators.CompareString(left, "fee", false) == 0);
								if (flag2)
								{
									this.CalcMablagh(true, false);
									this.Calc_Kargari();
									this.SyncTedad();
								}
								else
								{
									flag2 = (Operators.CompareString(left, "jam_kol", false) == 0);
									if (flag2)
									{
										this.GetSum("jam_Kol", true);
										this.CalcMablagh(false, true);
										this.Calc_Kargari();
										this.SyncTedad();
									}
									else
									{
										flag2 = (Operators.CompareString(left, "kargari", false) == 0);
										if (flag2)
										{
											flag = (this.GridEX1.GetRow().Cells["jam_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_kol"].Value != null);
											if (flag)
											{
												bool flag3 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.GetRow().Cells["jam_kol"].Value, 0, false);
												if (flag3)
												{
													bool flag4 = this.GridEX1.GetRow().Cells["kargari"].Value != DBNull.Value;
													if (flag4)
													{
														this.GridEX1.GetRow().Cells["jamkol_ba_kargari"].Value = Operators.AddObject(this.GridEX1.GetRow().Cells["jam_kol"].Value, this.GridEX1.GetRow().Cells["kargari"].Value);
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

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00132408 File Offset: 0x00130608
		private void Calc_Kargari()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(Public_Function.dict["kargari_kind"]) == 1.0;
				if (flag2)
				{
					bool flag3 = this.GridEX1.GetRow().Cells["tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["tedad"].Value != null;
					if (flag3)
					{
						bool flag4 = this.GridEX1.GetRow().Cells["kala_id"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["kala_id"].Value != null;
						if (flag4)
						{
							DataRow[] array = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.GetRow().Cells["kala_id"].Value)));
							flag4 = (array.Length > 0);
							if (flag4)
							{
								flag3 = (array[0]["mablagh_kargari"] != DBNull.Value);
								if (flag3)
								{
									this.GridEX1.GetRow().Cells["kargari"].Value = Operators.MultiplyObject(array[0]["mablagh_kargari"], this.GridEX1.GetRow().Cells["tedad"].Value);
									flag4 = (this.GridEX1.GetRow().Cells["jam_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_kol"].Value != null);
									if (flag4)
									{
										flag3 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.GetRow().Cells["jam_kol"].Value, 0, false);
										if (flag3)
										{
											this.GridEX1.GetRow().Cells["jamkol_ba_kargari"].Value = Operators.AddObject(this.GridEX1.GetRow().Cells["jam_kol"].Value, this.GridEX1.GetRow().Cells["kargari"].Value);
										}
										else
										{
											this.GridEX1.GetRow().Cells["jamkol_ba_kargari"].Value = 0;
										}
									}
								}
								else
								{
									flag4 = (this.GridEX1.GetRow().Cells["kargari"].Value != DBNull.Value);
									if (flag4)
									{
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
				else
				{
					bool flag4 = Public_Function.dict["kargari_fee"] != DBNull.Value && Public_Function.dict["kargari_fee"] != null;
					if (flag4)
					{
						bool flag3 = this.GridEX1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_kol"].Value != null;
						if (flag3)
						{
							this.GridEX1.GetRow().Cells["kargari"].Value = Operators.MultiplyObject(Public_Function.dict["kargari_fee"], this.GridEX1.GetRow().Cells["vazn_kol"].Value);
							flag4 = (this.GridEX1.GetRow().Cells["jam_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_kol"].Value != null);
							if (flag4)
							{
								flag3 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.GetRow().Cells["jam_kol"].Value, 0, false);
								if (flag3)
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

		// Token: 0x06001ACA RID: 6858 RVA: 0x00132A10 File Offset: 0x00130C10
		private void DelKala()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["sanad_id"].Value == DBNull.Value;
					bool flag4;
					if (flag3)
					{
						flag4 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"] != DBNull.Value);
						if (flag4)
						{
							this.Furush.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
						decimal? num;
						decimal? tedad;
						if (flag4)
						{
							object expr_114 = this.GridEX1.CurrentRow.Cells["tedad"].Value;
							tedad = ((expr_114 != null) ? ((decimal?)expr_114) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
						decimal? vazn;
						if (flag4)
						{
							object expr_177 = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value;
							vazn = ((expr_177 != null) ? ((decimal?)expr_177) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["kala_id"].Value != DBNull.Value);
						int? num2;
						int? kala_id;
						if (flag4)
						{
							object expr_1DA = this.GridEX1.CurrentRow.Cells["kala_id"].Value;
							kala_id = ((expr_1DA != null) ? ((int?)expr_1DA) : num2);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["row_index"].Value != DBNull.Value);
						int? num3;
						if (flag4)
						{
							object expr_23D = this.GridEX1.CurrentRow.Cells["row_index"].Value;
							num3 = ((expr_23D != null) ? ((int?)expr_23D) : num2);
						}
						this.GridEX1.CurrentRow.Delete();
						this.RollBackTedadVazn(kala_id, ref num3, tedad, vazn);
					}
					else
					{
						flag4 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"] != DBNull.Value);
						if (flag4)
						{
							this.Furush.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
						}
						this.sanad.Delete(Conversions.ToString(this.GridEX1.CurrentRow.Cells["sanad_id"].Value));
						flag4 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
						decimal? num;
						decimal? tedad2;
						if (flag4)
						{
							object expr_353 = this.GridEX1.CurrentRow.Cells["tedad"].Value;
							tedad2 = ((expr_353 != null) ? ((decimal?)expr_353) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
						decimal? vazn2;
						if (flag4)
						{
							object expr_3B7 = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value;
							vazn2 = ((expr_3B7 != null) ? ((decimal?)expr_3B7) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["kala_id"].Value != DBNull.Value);
						int? num2;
						int? kala_id2;
						if (flag4)
						{
							object expr_41B = this.GridEX1.CurrentRow.Cells["kala_id"].Value;
							kala_id2 = ((expr_41B != null) ? ((int?)expr_41B) : num2);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["row_index"].Value != DBNull.Value);
						int? num4;
						if (flag4)
						{
							object expr_47F = this.GridEX1.CurrentRow.Cells["row_index"].Value;
							num4 = ((expr_47F != null) ? ((int?)expr_47F) : num2);
						}
						this.GridEX1.CurrentRow.Delete();
						this.RollBackTedadVazn(kala_id2, ref num4, tedad2, vazn2);
					}
					((DataTable)this.GridEX1.DataSource).AcceptChanges();
					flag4 = (this.ID != -1);
					if (flag4)
					{
						this.RizBar.Update(this.ID, this.dt_rizbar);
					}
				}
			}
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00132F18 File Offset: 0x00131118
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
			if (flag)
			{
				this.Moshtari_Select('\0');
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["kala_Name"].Position);
				if (flag)
				{
					this.Kala_select('\0');
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
					if (flag)
					{
						this.DelKala();
					}
				}
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00132FC8 File Offset: 0x001311C8
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.Value = ((DateBox2)e.EditControl).Text;
			}
			else
			{
				flag = (Operators.CompareString(left, "fee", false) == 0);
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
						else
						{
							flag2 = (Operators.CompareString(left, "pardakhti", false) == 0);
							if (flag2)
							{
								flag = ((CurrencyBox)e.EditControl).Value.HasValue;
								if (flag)
								{
									e.Value = ((CurrencyBox)e.EditControl).Value;
								}
								else
								{
									e.Value = DBNull.Value;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00133170 File Offset: 0x00131370
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				this.txt_tarikhGrid.SetDate(e.Value.ToString());
			}
			else
			{
				flag = (Operators.CompareString(left, "fee", false) == 0);
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
						else
						{
							flag = (Operators.CompareString(left, "pardakhti", false) == 0);
							if (flag)
							{
								e.EditControl = this.txt_pardakhti;
								flag = (e.Value != null);
								if (flag)
								{
									this.txt_pardakhti.Text = e.Value.ToString();
									this.txt_pardakhti.SelectAll();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00133314 File Offset: 0x00131514
		private void move_right()
		{
			int col = this.GridEX1.Col;
			DataEntryGrid gridEX = this.GridEX1;
			checked
			{
				gridEX.Col--;
				bool flag = col == this.GridEX1.Col;
				if (flag)
				{
					int num = 2;
					while (this.GridEX1.Col >= col)
					{
						gridEX = this.GridEX1;
						gridEX.Col -= num;
						num++;
					}
				}
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0013338C File Offset: 0x0013158C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False;
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
					flag3 = (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0);
					if (flag3)
					{
						bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_name"].Position;
						if (flag2)
						{
							flag = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag)
							{
								this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = -1;
								this.GridEX1.CurrentRow.Cells["Moshtari_name"].Value = "نقدی";
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["kala_name"].Position;
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
							this.Kala_select('\0');
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_name"].Position);
						if (flag3)
						{
							this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
							this.Moshtari_Select('\0');
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
						flag3 = this.prevent_left;
						if (flag3)
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
					case Keys.Up:
						flag3 = (this.GridEX1.Row > 0);
						if (flag3)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row--;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					case Keys.Right:
						flag3 = this.prevent_right;
						if (flag3)
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
							this.move_right();
							e.SuppressKeyPress = true;
							return;
						}
						break;
					case Keys.Down:
						flag3 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
						if (flag3)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row++;
							e.SuppressKeyPress = true;
							return;
						}
						break;
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
						flag3 = (col == this.GridEX1.RootTable.Columns["Tarikh_fa"].Position);
						if (flag3)
						{
							flag2 = (Operators.CompareString(this.txt_tarikhGrid.Text, string.Empty, false) != 0);
							if (flag2)
							{
								flag = (Operators.CompareString(this.txt_tarikhGrid.Text, this.txt_tarikh_vurud.Text, false) < 0);
								if (flag)
								{
									bool flag4 = Public_Function.ShowMessage("تاریخ فروش قبل از تاریخ ورود بار میباشد آیا مایل به ادامه عملیات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes;
									if (flag4)
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
									else
									{
										this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
									}
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
						}
						else
						{
							bool flag4 = col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
							if (flag4)
							{
								flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag3)
								{
									this.Moshtari_Select('\0');
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
							else
							{
								flag4 = (col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
								if (flag4)
								{
									flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag3)
									{
										this.Kala_select('\0');
									}
									else
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
								else
								{
									flag4 = (col == this.GridEX1.RootTable.Columns["fee"].Position);
									if (flag4)
									{
										e.SuppressKeyPress = true;
									}
									else
									{
										flag4 = this.prevent_enter;
										if (flag4)
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
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00133A4C File Offset: 0x00131C4C
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

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00133A90 File Offset: 0x00131C90
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
					flag2 = !this.GridEX1.RootTable.Columns["pardakhti"].Visible;
					if (flag2)
					{
						flag = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
						if (flag)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row++;
							this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
						}
					}
					else
					{
						flag2 = (this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value != null && this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value != DBNull.Value);
						if (flag2)
						{
							flag = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value, -1, false);
							if (flag)
							{
								this.prevent_enter = true;
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["pardakhti"].Position;
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
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00133C74 File Offset: 0x00131E74
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
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
					flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag2)
					{
						flag = !this.GridEX1.RootTable.Columns["pardakhti"].Visible;
						if (flag)
						{
							bool flag3 = this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1;
							if (flag3)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Row++;
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
							}
						}
						else
						{
							bool flag3 = this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value != null && this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value != DBNull.Value;
							if (flag3)
							{
								flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value, -1, false);
								if (flag2)
								{
									this.prevent_enter = true;
									this.GridEX1.Col = this.GridEX1.RootTable.Columns["pardakhti"].Position;
								}
								else
								{
									flag3 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
									if (flag3)
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Row++;
										this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
									}
								}
							}
						}
					}
					else
					{
						this.prevent_enter = true;
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00133E98 File Offset: 0x00132098
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

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00133F78 File Offset: 0x00132178
		private void MeNew()
		{
			this.Load_Default_Nahve_Furush();
			this.Isnew = true;
			this.ID = -1;
			Public_Function.SetNew(this.UiGroupBox1);
			this.setEnable(true);
			DataTable detailByID = this.Furush.GetDetailByID(-1L);
			this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID(-1L);
			bool flag = this.dt_rizbar != null;
			if (flag)
			{
				this.dt_rizbar.Clear();
			}
			this.dt_rizbar = this.RizBar.GetByID(-1);
			detailByID.Columns["Fee"].AllowDBNull = true;
			this.GridEX1.DataSource = detailByID;
			this.Num = checked((int)this.Furush.GetNewID());
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_moshtari.Focus();
			this.dt_Keraye = null;
			this.Grid_RizBar.DataSource = null;
			this.Grid_RizBar.Visible = false;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0013407C File Offset: 0x0013227C
		private void RollBackKeraye()
		{
			DataTable dataTable = Public_Function.FillData("select * from furush_keraye where furush_id=" + Conversions.ToString(this.ID));
			bool flag = this.dt_Keraye == null;
			if (!flag)
			{
				try
				{
					IEnumerator enumerator = this.dt_Keraye.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["Keraye_Pardakht_ID2"] != DBNull.Value);
						if (flag)
						{
							DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["id"])));
							flag = (array.Length > 0);
							if (flag)
							{
								bool flag2 = array[0]["keraye_pardakht_id2"] == DBNull.Value;
								if (flag2)
								{
									DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
									daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(dataRow["keraye_pardakht_id2"]), "furush_keraye", "Keraye_pardakht_id2", Conversions.ToString(dataRow["ID"]));
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
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x001341C8 File Offset: 0x001323C8
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = !this.ButtonItem1.Enabled;
			if (!flag)
			{
				flag = !this.ButtonItem2.Enabled;
				if (flag)
				{
					this.MeNew();
				}
				else
				{
					switch (Public_Function.ShowMessage("آیا مایل به ذخیره اطلاعات میباشید؟", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, null))
					{
					case DialogResult.Yes:
						flag = this.Save(true);
						if (flag)
						{
							MyProject.Forms.Form_Main.Get_mande_furush();
							MyProject.Forms.Form_Main.Get_mande_Safi();
							this.MeNew();
						}
						break;
					case DialogResult.No:
						this.RollBackKeraye();
						this.MeNew();
						break;
					}
				}
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0013428C File Offset: 0x0013248C
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
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
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["Tarikh_Fa"] == DBNull.Value;
						if (flag)
						{
							dataRow["Tarikh_Fa"] = Public_Function.dict["today"];
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
				int num = 0;
				bool result;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(dataRow2["Tarikh_fa"]));
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Tarikh_Fa", "تاریخ وارد شده معتبر نمیباشد");
							result = false;
							return result;
						}
						flag = (dataRow2["Moshtari_ID"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Moshtari_Name", "خریدار را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow2["Kala_ID"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "kala_Name", "جنس را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow2["vazn_kol"] == DBNull.Value && this.GridEX1.RootTable.Columns["vazn_kol"].Visible);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "vazn_kol", "وزن خالص را وارد نمایید");
							result = false;
							return result;
						}
						flag = !this.GridEX1.RootTable.Columns["vazn_kol"].Visible;
						if (flag)
						{
							dataRow2["vazn_kol"] = 0;
						}
						flag = (dataRow2["fee"] == DBNull.Value && dataRow2["jam_kol"] == DBNull.Value);
						if (flag)
						{
							dataRow2["fee"] = 0;
							dataRow2["jam_kol"] = 0;
						}
						flag = (dataRow2["fee"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "fee", "فی واحد را وارد نمایید");
							result = false;
							return result;
						}
						flag = (dataRow2["jam_kol"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "jam_kol", "قیمت کل را وارد نمایید");
							result = false;
							return result;
						}
						flag = (Operators.ConditionalCompareObjectEqual(dataRow2["moshtari_id"], -1, false) && Operators.ConditionalCompareObjectEqual(dataRow2["jam_kol"], 0, false));
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

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0013477C File Offset: 0x0013297C
		private bool Validate_Tedad()
		{
			bool flag = Operators.CompareString(this.txt_tedad.Text, string.Empty, false) == 0;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				decimal num = 0m;
				decimal num2 = 0m;
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["tedad"] != DBNull.Value);
						if (flag)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, dataRow["Tedad"]));
						}
						flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
						if (flag)
						{
							num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataRow["Vazn_Ba_Zarf"]));
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
				string text = string.Empty;
				flag = (Operators.CompareString(this.txt_tedad.Text, string.Empty, false) != 0);
				bool flag2;
				if (flag)
				{
					flag2 = (Convert.ToDouble(num) > Conversions.ToDouble(this.txt_tedad.Text));
					if (flag2)
					{
						text = "تعداد فروشی بیشتر از تعداد کل میباشد";
					}
				}
				flag2 = (Operators.CompareString(this.txt_baskul.Text, string.Empty, false) != 0);
				if (flag2)
				{
					flag = (Convert.ToDouble(num2) > Conversions.ToDouble(this.txt_baskul.Text));
					if (flag)
					{
						text = text + Environment.NewLine + "وزن فروشی بیشتر از وزن باسکول میباشد";
					}
				}
				flag2 = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag2)
				{
					text = text + Environment.NewLine + "آیا مایل به ثبت اطلاعات میباشید؟";
				}
				flag2 = (Operators.CompareString(text, string.Empty, false) == 0);
				if (flag2)
				{
					result = true;
				}
				else
				{
					flag2 = (Public_Function.ShowMessage(text, MessageBoxButtons.YesNo, MessageBoxIcon.Hand, null) == DialogResult.Yes);
					result = flag2;
				}
			}
			return result;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00125430 File Offset: 0x00123630
		private bool ContainsKala(List<tedads> tedad, long kala_id, decimal Tedadd)
		{
			bool result;
			try
			{
				List<tedads>.Enumerator enumerator = tedad.GetEnumerator();
				while (enumerator.MoveNext())
				{
					tedads current = enumerator.Current;
					bool flag = current.kala_id == kala_id;
					if (flag)
					{
						tedads tedads = current;
						tedads.Tedad = decimal.Add(tedads.Tedad, Tedadd);
						result = true;
						return result;
					}
				}
			}
			finally
			{
				List<tedads>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			result = false;
			return result;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00125430 File Offset: 0x00123630
		private bool ContainsVazn(List<tedads> tedad, long kala_id, decimal Vazn)
		{
			bool result;
			try
			{
				List<tedads>.Enumerator enumerator = tedad.GetEnumerator();
				while (enumerator.MoveNext())
				{
					tedads current = enumerator.Current;
					bool flag = current.kala_id == kala_id;
					if (flag)
					{
						tedads tedads = current;
						tedads.Tedad = decimal.Add(tedads.Tedad, Vazn);
						result = true;
						return result;
					}
				}
			}
			finally
			{
				List<tedads>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			result = false;
			return result;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x001349B8 File Offset: 0x00132BB8
		public bool ValidateRizBar()
		{
			bool flag = this.dt_rizbar == null;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				flag = (this.dt_rizbar.Rows.Count == 0);
				if (flag)
				{
					result = true;
				}
				else
				{
					DataTable dataTable = new DataTable();
					DataTable dataTable2 = new DataTable();
					DataTable dataTable3 = new DataTable();
					dataTable.Columns.Add(new DataColumn("kala_name", typeof(string)));
					dataTable.Columns.Add(new DataColumn("tedad", typeof(decimal)));
					dataTable.Columns.Add(new DataColumn("tedadsabt", typeof(decimal)));
					dataTable2.Columns.Add(new DataColumn("kala_name", typeof(string)));
					dataTable2.Columns.Add(new DataColumn("vazn", typeof(decimal)));
					dataTable2.Columns.Add(new DataColumn("vaznsabt", typeof(decimal)));
					dataTable3.Columns.Add(new DataColumn("kala_id", typeof(long)));
					dataTable3.Columns.Add(new DataColumn("tedad", typeof(decimal)));
					dataTable3.Columns.Add(new DataColumn("vazn", typeof(decimal)));
					dataTable3.Columns.Add(new DataColumn("kala_name", typeof(string)));
					try
					{
						IEnumerator enumerator = this.dt_rizbar.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							DataRow[] array = dataTable3.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow["kala_id"])));
							flag = (array.Length == 0);
							if (flag)
							{
								dataTable3.Rows.Add(new object[]
								{
									RuntimeHelpers.GetObjectValue(dataRow["kala_id"]),
									RuntimeHelpers.GetObjectValue(dataRow["tedad"]),
									RuntimeHelpers.GetObjectValue(dataRow["vazn"])
								});
							}
							else
							{
								flag = (dataRow["tedad"] != DBNull.Value);
								if (flag)
								{
									DataRow[] array2 = array;
									DataRow[] arg_267_0 = array2;
									int num = 0;
									DataRow arg_298_0 = arg_267_0[num];
									string columnName = "tedad";
									arg_298_0[columnName] = Operators.AddObject(array2[num][columnName], Conversions.ToDecimal(dataRow["tedad"]));
								}
								flag = (dataRow["vazn"] != DBNull.Value);
								if (flag)
								{
									DataRow[] array2 = array;
									DataRow[] arg_2C6_0 = array2;
									int num = 0;
									DataRow arg_2F7_0 = arg_2C6_0[num];
									string columnName = "vazn";
									arg_2F7_0[columnName] = Operators.AddObject(array2[num][columnName], Conversions.ToDecimal(dataRow["vazn"]));
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
					List<tedads> list = new List<tedads>();
					List<tedads> list2 = new List<tedads>();
					DataTable dataTable4 = (DataTable)this.GridEX1.DataSource;
					try
					{
						IEnumerator enumerator2 = dataTable4.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag = (dataRow2["tedad"] != DBNull.Value);
							bool flag2;
							if (flag)
							{
								flag2 = !this.ContainsKala(list, Conversions.ToLong(dataRow2["kala_id"]), Conversions.ToDecimal(dataRow2["tedad"]));
								if (flag2)
								{
									list.Add(new tedads
									{
										kala_id = Conversions.ToLong(dataRow2["kala_id"]),
										Tedad = Conversions.ToDecimal(dataRow2["tedad"])
									});
								}
							}
							flag2 = (dataRow2["vazn_ba_zarf"] != DBNull.Value);
							if (flag2)
							{
								flag = !this.ContainsKala(list2, Conversions.ToLong(dataRow2["kala_id"]), Conversions.ToDecimal(dataRow2["vazn_ba_zarf"]));
								if (flag)
								{
									list2.Add(new tedads
									{
										kala_id = Conversions.ToLong(dataRow2["kala_ID"]),
										Tedad = Conversions.ToDecimal(dataRow2["vazn_ba_zarf"])
									});
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
					bool flag4;
					try
					{
						IEnumerator enumerator3 = dataTable3.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							try
							{
								List<tedads>.Enumerator enumerator4 = list.GetEnumerator();
								while (enumerator4.MoveNext())
								{
									tedads current = enumerator4.Current;
									bool flag2 = Operators.ConditionalCompareObjectEqual(current.kala_id, dataRow3["kala_id"], false);
									if (flag2)
									{
										flag = (dataRow3["tedad"] != DBNull.Value);
										if (flag)
										{
											bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataRow3["tedad"], 0, false);
											if (flag3)
											{
												flag4 = Operators.ConditionalCompareObjectGreater(current.Tedad, dataRow3["Tedad"], false);
												if (flag4)
												{
													dataTable.Rows.Add(new object[]
													{
														RuntimeHelpers.GetObjectValue(dataRow3["kala_name"]),
														RuntimeHelpers.GetObjectValue(dataRow3["tedad"]),
														current.Tedad
													});
												}
											}
										}
									}
								}
							}
							finally
							{
								List<tedads>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							try
							{
								List<tedads>.Enumerator enumerator5 = list2.GetEnumerator();
								while (enumerator5.MoveNext())
								{
									tedads current2 = enumerator5.Current;
									flag4 = Operators.ConditionalCompareObjectEqual(current2.kala_id, dataRow3["kala_id"], false);
									if (flag4)
									{
										bool flag3 = dataRow3["vazn"] != DBNull.Value;
										if (flag3)
										{
											bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow3["vazn"], 0, false);
											if (flag2)
											{
												flag = Operators.ConditionalCompareObjectGreater(current2.Tedad, dataRow3["vazn"], false);
												if (flag)
												{
													dataTable2.Rows.Add(new object[]
													{
														RuntimeHelpers.GetObjectValue(dataRow3["kala_name"]),
														RuntimeHelpers.GetObjectValue(dataRow3["vazn"]),
														current2.Tedad
													});
												}
											}
										}
									}
								}
							}
							finally
							{
								List<tedads>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
						}
					}
					finally
					{
						IEnumerator enumerator3;
						flag4 = (enumerator3 is IDisposable);
						if (flag4)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					flag4 = (dataTable.Rows.Count > 0 || dataTable2.Rows.Count > 0);
					if (flag4)
					{
						Frm_TedadKala frm_TedadKala = new Frm_TedadKala();
						frm_TedadKala.Is_Kharid = true;
						frm_TedadKala.dt_tedad = dataTable;
						frm_TedadKala.dt_vazn = dataTable2;
						flag4 = (MyProject.Forms.Form_Main.Dialog_ShowForm(frm_TedadKala) == DialogResult.OK);
						result = flag4;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00135218 File Offset: 0x00133418
		private void SyncSandug()
		{
			List<string> list = new List<string>();
			bool flag = Public_Function.Dt_FrmSize != null;
			bool flag2;
			if (flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false);
						if (flag)
						{
							flag2 = !list.Contains(Conversions.ToString(dataRow["tarikh_fa"]));
							if (flag2)
							{
								list.Add(Conversions.ToString(dataRow["tarikh_fa"]));
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
			}
			flag2 = (this.dt_Keraye != null);
			if (flag2)
			{
				try
				{
					IEnumerator enumerator2 = this.dt_Keraye.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag = !list.Contains(Conversions.ToString(dataRow2["tarikh_fa"]));
						if (flag)
						{
							list.Add(Conversions.ToString(dataRow2["tarikh_fa"]));
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
			}
			try
			{
				List<string>.Enumerator enumerator3 = list.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string current = enumerator3.Current;
					this.Sandug.SynckasrEzafe(current);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00135404 File Offset: 0x00133604
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00135478 File Offset: 0x00133678
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

		// Token: 0x06001ADF RID: 6879 RVA: 0x001354DC File Offset: 0x001336DC
		private bool Save(bool Silent)
		{
			bool flag = Conversions.ToDouble(this.txt_num.Value) != (double)this.Num;
			bool result;
			if (flag)
			{
				this.txt_num_Validating(null, null);
				result = false;
			}
			else
			{
				flag = (!this.txt_rizbar.Enabled && !this.txt_makharej.Enabled);
				if (flag)
				{
					this.ButtonItem1_Click(null, null);
					result = true;
				}
				else
				{
					flag = Public_Function.HasNull(this.UiGroupBox1);
					if (flag)
					{
						result = false;
					}
					else
					{
						this.GridEX1.EndCustomEdit -= new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
						this.GridEX1.CellEdited -= new ColumnActionEventHandler(this.GridEX1_CellEdited);
						this.GridEX1.SelectionChanged -= new EventHandler(this.GridEX1_SelectionChanged);
						this.GridEX1.LoadingRow -= new RowLoadEventHandler(this.GridEX1_LoadingRow);
						flag = !this.ValidateGridData();
						if (flag)
						{
							this.addhandle();
							result = false;
						}
						else
						{
							flag = !this.Validate_Tedad();
							if (flag)
							{
								this.addhandle();
								result = false;
							}
							else
							{
								this.addhandle();
								string text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 id from furush_hag where num=" + Conversions.ToString(this.Num)));
								flag = (text == null);
								if (flag)
								{
									this.Isnew = true;
									this.ID = -1;
								}
								else
								{
									this.Isnew = false;
									this.ID = Conversions.ToInteger(text);
								}
								int nahve_Furush = this.GetNahve_Furush();
								flag = this.Isnew;
								if (flag)
								{
									this.ID = checked((int)this.Furush.Insert(this.txt_num.Value.ToString(), this.txt_moshtari.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, Conversions.ToString(nahve_Furush), (DataTable)this.GridEX1.DataSource));
									this.RizBar.Update(this.ID, this.dt_rizbar);
									this.Furush_Keraye.Update(this.ID, this.dt_Keraye);
									this.kala_to_kala.Update((long)this.ID, this.dt_kala_to_kala);
									DataTable detailByID = this.Furush.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.Furush_Keraye.GetByID(this.ID);
									this.Adddt(this.dt_Keraye);
									this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID((long)this.ID);
									this.Prepare_furush_detail(detailByID);
									this.RemoveZero(detailByID);
									this.GridEX1.DataSource = detailByID;
									this.Isnew = false;
								}
								else
								{
									this.Furush_Keraye.Update(this.ID, this.dt_Keraye);
									this.Furush.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), this.txt_moshtari.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, Conversions.ToString(nahve_Furush), (DataTable)this.GridEX1.DataSource);
									this.RizBar.Update(this.ID, this.dt_rizbar);
									this.kala_to_kala.Update((long)this.ID, this.dt_kala_to_kala);
									DataTable detailByID2 = this.Furush.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.Furush_Keraye.GetByID(this.ID);
									this.Adddt(this.dt_Keraye);
									this.dt_rizbar = this.RizBar.GetByID(this.ID);
									this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID((long)this.ID);
									this.Prepare_furush_detail(detailByID2);
									this.RemoveZero(detailByID2);
									this.GridEX1.DataSource = detailByID2;
								}
								flag = !Silent;
								checked
								{
									if (flag)
									{
										switch (Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید" + Environment.NewLine + "آیا مایل به ثبت صافی میباشید؟", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, null))
										{
										case DialogResult.Cancel:
										{
											this.GridEX1.Focus();
											this.GridEX1.MoveToNewRecord();
											this.GridEX1.Col = 0;
											this.GridEX1.EditMode = EditMode.EditOn;
											flag = (this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
											bool flag2;
											if (flag)
											{
												flag2 = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
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
											flag2 = Conversions.ToBoolean(Public_Function.dict["newrow_kala"]);
											if (flag2)
											{
												flag = (this.GridEX1.GetRow().Cells["Kala_Name"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
												if (flag)
												{
													bool flag3 = this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["kala_Name"].Value != DBNull.Value;
													if (flag3)
													{
														this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
														this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
														this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
														this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
														flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
														if (flag3)
														{
															flag2 = (this.GridEX1.EditTextBox != null);
															if (flag2)
															{
																this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
																this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
																this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
																this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
															}
														}
													}
												}
											}
											break;
										}
										case DialogResult.Yes:
											this.ButtonItem5_Click(null, null);
											break;
										case DialogResult.No:
										{
											long navigateID = this.Furush.GetNavigateID(Furush_Hag.NavTo.nextopen, Conversions.ToLong(this.txt_num.Value));
											flag = (navigateID == 0L);
											if (flag)
											{
												this.MeNew();
											}
											else
											{
												flag = (navigateID != unchecked((long)this.Num));
												if (flag)
												{
													this.Num = (int)navigateID;
													this.LoadData();
												}
											}
											break;
										}
										}
									}
									this.SyncSandug();
									result = true;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00135F1C File Offset: 0x0013411C
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool enabled = this.ButtonItem2.Enabled;
			if (enabled)
			{
				this.Save(false);
				MyProject.Forms.Form_Main.Get_mande_furush();
				MyProject.Forms.Form_Main.Get_mande_Safi();
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00135F64 File Offset: 0x00134164
		private void SyncTedad()
		{
			bool flag = this.dt_rizbar == null;
			checked
			{
				if (!flag)
				{
					DataTable dataTable = this.dt_rizbar.Copy();
					flag = (dataTable.Rows.Count == 0);
					if (!flag)
					{
						DataTable dataTable2 = this.Create_Rizbar_table(dataTable);
						dataTable2.Columns.Add(new DataColumn("jam_kol_furush", typeof(long)));
						flag = (dataTable2.Rows.Count == 0);
						if (!flag)
						{
							try
							{
								IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									dataRow["jam_kol_furush"] = 0;
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
							List<tedads> list = new List<tedads>();
							List<tedads> list2 = new List<tedads>();
							DataTable dataTable3 = (DataTable)this.GridEX1.DataSource;
							GridEXRow[] rows = this.GridEX1.GetRows();
							bool flag2;
							for (int i = 0; i < rows.Length; i++)
							{
								GridEXRow gridEXRow = rows[i];
								flag = (gridEXRow.Cells["kala_id"].Value == DBNull.Value);
								if (!flag)
								{
									flag = (gridEXRow.Cells["Tedad"].Value != DBNull.Value);
									if (flag)
									{
										flag2 = !this.ContainsKala(list, Conversions.ToLong(gridEXRow.Cells["kala_id"].Value), Conversions.ToDecimal(gridEXRow.Cells["tedad"].Value));
										if (flag2)
										{
											list.Add(new tedads
											{
												kala_id = Conversions.ToLong(gridEXRow.Cells["kala_id"].Value),
												Tedad = Conversions.ToDecimal(gridEXRow.Cells["tedad"].Value)
											});
										}
									}
									flag2 = (gridEXRow.Cells["Vazn_Ba_Zarf"].Value == DBNull.Value);
									if (!flag2)
									{
										flag2 = !this.ContainsVazn(list2, Conversions.ToLong(gridEXRow.Cells["kala_id"].Value), Conversions.ToDecimal(gridEXRow.Cells["Vazn_Ba_Zarf"].Value));
										if (flag2)
										{
											list2.Add(new tedads
											{
												kala_id = Conversions.ToLong(gridEXRow.Cells["kala_id"].Value),
												Tedad = Conversions.ToDecimal(gridEXRow.Cells["Vazn_Ba_Zarf"].Value)
											});
										}
									}
								}
							}
							GridEXRow[] rows2 = this.GridEX1.GetRows();
							for (int j = 0; j < rows2.Length; j++)
							{
								GridEXRow gridEXRow2 = rows2[j];
								flag2 = (gridEXRow2.Cells["kala_id"].Value == DBNull.Value);
								if (!flag2)
								{
									flag2 = (gridEXRow2.Cells["jam_kol"].Value != DBNull.Value);
									if (flag2)
									{
										DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", gridEXRow2.Cells["kala_id"].Value)));
										flag2 = (array.Length > 0);
										if (flag2)
										{
											flag = (gridEXRow2.Cells["jam_kol"] != DBNull.Value);
											if (flag)
											{
												DataRow[] array2 = array;
												DataRow[] arg_3BB_0 = array2;
												int num = 0;
												DataRow arg_3EC_0 = arg_3BB_0[num];
												string columnName = "jam_kol_furush";
												arg_3EC_0[columnName] = Operators.AddObject(array2[num][columnName], gridEXRow2.Cells["jam_kol"].Value);
											}
										}
									}
								}
							}
							GridEXRow currentRow = this.GridEX1.CurrentRow;
							flag2 = (currentRow.RowType == RowType.NewRecord);
							bool flag4;
							if (flag2)
							{
								flag = (currentRow.Cells["kala_id"].Value != DBNull.Value);
								if (flag)
								{
									bool flag3 = currentRow.Cells["tedad"].Value != DBNull.Value;
									if (flag3)
									{
										flag4 = !this.ContainsKala(list, Conversions.ToLong(currentRow.Cells["kala_id"].Value), Conversions.ToDecimal(currentRow.Cells["tedad"].Value));
										if (flag4)
										{
											list.Add(new tedads
											{
												kala_id = Conversions.ToLong(currentRow.Cells["kala_id"].Value),
												Tedad = Conversions.ToDecimal(currentRow.Cells["tedad"].Value)
											});
										}
									}
									flag4 = (currentRow.Cells["Vazn_Ba_Zarf"].Value != DBNull.Value);
									if (flag4)
									{
										flag3 = !this.ContainsKala(list2, Conversions.ToLong(currentRow.Cells["kala_id"].Value), Conversions.ToDecimal(currentRow.Cells["Vazn_Ba_Zarf"].Value));
										if (flag3)
										{
											list2.Add(new tedads
											{
												kala_id = Conversions.ToLong(currentRow.Cells["kala_id"].Value),
												Tedad = Conversions.ToDecimal(currentRow.Cells["Vazn_Ba_Zarf"].Value)
											});
										}
									}
								}
							}
							currentRow = this.GridEX1.CurrentRow;
							flag4 = (currentRow.RowType == RowType.NewRecord);
							if (flag4)
							{
								bool flag3 = currentRow.Cells["kala_id"].Value != DBNull.Value && currentRow.Cells["kala_id"].Value != null;
								if (flag3)
								{
									flag2 = (currentRow.Cells["jam_kol"].Value != DBNull.Value);
									if (flag2)
									{
										DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", currentRow.Cells["kala_id"].Value)));
										flag4 = (array.Length > 0);
										if (flag4)
										{
											DataRow[] array2 = array;
											DataRow[] arg_6B1_0 = array2;
											int num = 0;
											DataRow arg_6E2_0 = arg_6B1_0[num];
											string columnName = "jam_kol_furush";
											arg_6E2_0[columnName] = Operators.AddObject(array2[num][columnName], currentRow.Cells["jam_kol"].Value);
										}
									}
								}
							}
							try
							{
								IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow dataRow2 = (DataRow)enumerator2.Current;
									flag4 = (dataRow2["tedad"] != DBNull.Value);
									if (flag4)
									{
										try
										{
											List<tedads>.Enumerator enumerator3 = list.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												tedads current = enumerator3.Current;
												bool flag3 = Operators.ConditionalCompareObjectEqual(current.kala_id, dataRow2["kala_id"], false);
												if (flag3)
												{
													DataRow dataRow3 = dataRow2;
													DataRow arg_78E_0 = dataRow3;
													string columnName = "tedad";
													arg_78E_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current.Tedad);
												}
											}
										}
										finally
										{
											List<tedads>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									flag4 = (dataRow2["vazn"] != DBNull.Value);
									if (flag4)
									{
										try
										{
											List<tedads>.Enumerator enumerator4 = list2.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												tedads current2 = enumerator4.Current;
												bool flag3 = Operators.ConditionalCompareObjectEqual(current2.kala_id, dataRow2["kala_id"], false);
												if (flag3)
												{
													flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow2["vazn"], 0, false);
													if (flag2)
													{
														DataRow dataRow3 = dataRow2;
														DataRow arg_855_0 = dataRow3;
														string columnName = "vazn";
														arg_855_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current2.Tedad);
													}
												}
											}
										}
										finally
										{
											List<tedads>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								flag4 = (enumerator2 is IDisposable);
								if (flag4)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							this.Grid_RizBar.DataSource = dataTable2;
							this.RemoveZeroVazn();
						}
					}
				}
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x001368A4 File Offset: 0x00134AA4
		private void RemoveZeroVazn()
		{
			try
			{
				IEnumerator enumerator = ((DataTable)this.Grid_RizBar.DataSource).Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["vazn"] != DBNull.Value;
					if (flag)
					{
						dataRow["vazn"] = dataRow["vazn"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Tedad"] != DBNull.Value);
					if (flag)
					{
						dataRow["Tedad"] = dataRow["Tedad"].ToString().Replace(".0", "");
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

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x001369AC File Offset: 0x00134BAC
		private void LoadHeader(DataRow dr)
		{
			this.txt_num.Value = Conversions.ToString(dr["Num"]);
			this.ID = Conversions.ToInteger(dr["ID"]);
			this.txt_moshtari.SetValue(Conversions.ToString(dr["Moshtari_Name"]), RuntimeHelpers.GetObjectValue(dr["Moshtari_ID"]));
			this.txt_sh_mashin.Text = dr["Sh_Mashin"].ToString();
			this.txt_sh_barname.Text = dr["Sh_Barname"].ToString();
			bool flag = dr["Tarikh_Vurud"] != DBNull.Value;
			if (flag)
			{
				this.txt_tarikh_vurud.SetDate(dr["Tarikh_Vurud"].ToString());
			}
			else
			{
				this.txt_tarikh_vurud.SetDefault();
			}
			this.txt_desc.Text = dr["Desc"].ToString();
			this.txt_baskul.Text = dr["Baskul"].ToString().Replace(".0", "");
			flag = (dr["baskul_mabda"] != DBNull.Value);
			if (flag)
			{
				this.txt_baskul_mabda.Text = dr["Baskul_Mabda"].ToString().Replace(".0", "");
			}
			else
			{
				this.txt_baskul_mabda.Text = string.Empty;
			}
			this.txt_tedad.Text = dr["Tedad_Kol"].ToString().Replace(".0", "");
			this.dt_Keraye = this.Furush_Keraye.GetByID(this.ID);
			this.Adddt(this.dt_Keraye);
			this.dt_rizbar = this.RizBar.GetByID(this.ID);
			DataTable dataSource = this.dt_rizbar.Copy();
			this.Grid_RizBar.DataSource = dataSource;
			flag = (this.dt_rizbar.Rows.Count > 0);
			if (flag)
			{
				this.Grid_RizBar.Visible = true;
			}
			else
			{
				this.Grid_RizBar.Visible = false;
			}
			this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00136C08 File Offset: 0x00134E08
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
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["zarf"] = dataRow["zarf"].ToString().Replace(".00", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".00", "");
					}
					flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_ba_zarf"] = dataRow["vazn_ba_zarf"].ToString().Replace(".0", "");
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

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00136D94 File Offset: 0x00134F94
		private void setEnable(bool en)
		{
			if (en)
			{
				this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				this.GridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
				this.ButtonItem7.Visible = false;
				this.Bar1.Refresh();
			}
			else
			{
				this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				this.GridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
				bool flag = this.user.Form_Control_Permission(this.Text, this.ButtonItem7.Text);
				if (flag)
				{
					this.ButtonItem7.Visible = true;
				}
				this.Bar1.Refresh();
			}
			this.ButtonItem2.Enabled = en;
			this.ButtonItem3.Enabled = en;
			this.ButtonItem4.Enabled = en;
			this.ButtonItem6.Enabled = en;
			this.ButtonItem10.Enabled = en;
			this.ButtonItem12.Enabled = en;
			this.txt_makharej.Enabled = en;
			this.txt_moshtari.Enabled = en;
			this.txt_baskul.Enabled = en;
			this.txt_baskul_mabda.Enabled = en;
			this.txt_desc.Enabled = en;
			this.txt_fee.Enabled = en;
			this.txt_tedad.Enabled = en;
			this.txt_tarikh_vurud.Enabled = en;
			this.txt_sh_barname.Enabled = en;
			this.txt_sh_mashin.Enabled = en;
			this.txt_rizbar.Enabled = en;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00136F10 File Offset: 0x00135110
		private int Get_Parent_Kala_Index_IN_Kharid(long kala_id)
		{
			DataRow[] array = this.dt_rizbar.Select("kala_id=" + Conversions.ToString(kala_id));
			bool flag = array.Length > 0;
			if (flag)
			{
				bool flag2 = array[0]["auto"] == DBNull.Value;
				if (flag2)
				{
					int result = -1;
					return result;
				}
			}
			DataRow[] array2 = this.dt_kala_to_kala.Select("child_kala_id=" + Conversions.ToString(kala_id));
			DataRow[] array3 = array2;
			checked
			{
				int result;
				for (int i = 0; i < array3.Length; i++)
				{
					DataRow dataRow = array3[i];
					DataRow[] array4 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id =", dataRow["Parent_kala_id"])));
					bool flag2 = array4.Length > 0;
					if (flag2)
					{
						flag = (array4[0]["auto"] == DBNull.Value);
						if (flag)
						{
							result = this.dt_rizbar.Rows.IndexOf(array4[0]);
							return result;
						}
					}
				}
				result = -1;
				return result;
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00137018 File Offset: 0x00135218
		private void Prepare_furush_detail(DataTable dt)
		{
			bool flag = this.dt_rizbar == null;
			if (!flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["kala_id"] == DBNull.Value);
						if (!flag)
						{
							DataRow[] array = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_ID=", dataRow["kala_ID"])));
							flag = (array.Length == 0);
							if (!flag)
							{
								flag = (array[0]["auto"] == DBNull.Value);
								if (!flag)
								{
									flag = Operators.ConditionalCompareObjectEqual(array[0]["auto"], false, false);
									if (!flag)
									{
										int num = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(dataRow["kala_id"]));
										dataRow["row_index"] = num;
									}
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
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00137158 File Offset: 0x00135358
		private void DeleteTekrari(string num)
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"select id from furush_hag where num=",
				num,
				" and id not in(",
				Conversions.ToString(this.ID),
				") "
			}));
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						this.Furush.Delete(Conversions.ToString(dataRow["ID"]));
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

		// Token: 0x06001AEA RID: 6890 RVA: 0x00137238 File Offset: 0x00135438
		private void LoadNahve_Furush(DataRow dr)
		{
			bool flag = dr["nahve_furush"] == DBNull.Value;
			if (flag)
			{
				this.uncheckmenu();
				this.ButtonItem16.Checked = true;
				this.ButtonItem16_Click(null, null);
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(dr["nahve_furush"]);
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

		// Token: 0x06001AEB RID: 6891 RVA: 0x00137344 File Offset: 0x00135544
		private void LoadData()
		{
			DataRow byID = this.Furush.GetByID((long)this.Num);
			bool flag = byID == null;
			checked
			{
				if (flag)
				{
					string left = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 id from furush_hag where num>" + Conversions.ToString(this.Num)));
					int num = this.Num;
					this.MeNew();
					flag = (Operators.CompareString(left, string.Empty, false) != 0);
					if (flag)
					{
						this.Num = num;
						this.txt_num.Value = Conversions.ToString(num);
						this.txt_num.Focus();
					}
				}
				else
				{
					this.LoadHeader(byID);
					this.DeleteTekrari(Conversions.ToString(this.Num));
					DataTable detailByID = this.Furush.GetDetailByID(Conversions.ToLong(byID["ID"]));
					this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID(Conversions.ToLong(byID["ID"]));
					this.Prepare_furush_detail(detailByID);
					this.RemoveZero(detailByID);
					detailByID.AcceptChanges();
					this.GridEX1.DataSource = detailByID;
					this.SyncTedad();
					this.RemoveZeroVazn();
					this.ButtonItem4.Enabled = true;
					this.Isnew = false;
					int num2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID)));
					flag = (num2 == 1);
					if (flag)
					{
						this.setEnable(false);
					}
					else
					{
						this.setEnable(true);
					}
					this.LoadNahve_Furush(byID);
					this.GridEX1.Focus();
					this.GridEX1.MoveToNewRecord();
					this.GridEX1.Col = 0;
					this.GridEX1.Col = 1;
					this.GridEX1.EditMode = EditMode.EditOn;
					flag = (this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
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
					flag2 = Conversions.ToBoolean(Public_Function.dict["newrow_kala"]);
					if (flag2)
					{
						flag = (this.GridEX1.GetRow().Cells["Kala_Name"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
						if (flag)
						{
							bool flag3 = this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["kala_Name"].Value != DBNull.Value;
							if (flag3)
							{
								this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
								this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
								this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
								this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
								flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
								if (flag3)
								{
									flag2 = (this.GridEX1.EditTextBox != null);
									if (flag2)
									{
										this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
										this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
										this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
										this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00007A78 File Offset: 0x00005C78
		private void txt_num_First_Click()
		{
			this.Furush_select();
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x001379E4 File Offset: 0x00135BE4
		private void txt_num_Last_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Hag.NavTo.last, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData();
				}
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00137A40 File Offset: 0x00135C40
		private void txt_num_Next_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Hag.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData();
				}
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00137A9C File Offset: 0x00135C9C
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Hag.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData();
				}
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00137AF8 File Offset: 0x00135CF8
		private void txt_num_NumberBox_Keydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txt_num.Value, string.Empty, false) != 0;
				if (flag2)
				{
					bool flag3 = Conversions.ToDouble(this.txt_num.Value) != (double)this.Num;
					if (flag3)
					{
						this.Num = Conversions.ToInteger(this.txt_num.Value);
						this.LoadData();
					}
				}
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00007A83 File Offset: 0x00005C83
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00137B78 File Offset: 0x00135D78
		private DataTable Create_Rizbar_table(DataTable dt)
		{
			DataTable dataTable = dt.Clone();
			DataColumn dataColumn = new DataColumn("checked", typeof(bool));
			dataColumn.DefaultValue = false;
			dt.Columns.Add(dataColumn);
			decimal num = 0m;
			decimal num2 = 0m;
			checked
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("kala_id=", dataRow["kala_id"]), " and checked=false")));
						bool flag = array.Length == 0;
						if (!flag)
						{
							flag = (array.Length == 1);
							if (flag)
							{
								dataTable.ImportRow(dataRow);
								dataRow["checked"] = true;
							}
							else
							{
								num = 0m;
								num2 = 0m;
								DataRow[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									DataRow dataRow2 = array2[i];
									num = Conversions.ToDecimal(Operators.AddObject(num, dataRow2["tedad"]));
									num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataRow2["vazn"]));
									dataRow2["checked"] = true;
								}
								dataRow["tedad"] = num;
								dataRow["vazn"] = num2;
								dataTable.ImportRow(dataRow);
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
				return dataTable;
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00137D74 File Offset: 0x00135F74
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_moshtari.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_moshtari.ShowTip("صاحب بار را انتخاب فرمائید");
			}
			else
			{
				Frm_Rizbar frm_Rizbar = new Frm_Rizbar
				{
					Tedad_Kol = this.txt_tedad.Text,
					Moshtari_ID = Conversions.ToLong(this.txt_moshtari.Value),
					FurushTable = (DataTable)this.GridEX1.DataSource
				};
				frm_Rizbar.dt_kala_to_kala = this.dt_kala_to_kala;
				frm_Rizbar.dt_rizbar = this.dt_rizbar;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Rizbar);
				this.dt_rizbar = frm_Rizbar.dt_rizbar;
				this.dt_rizbar.AcceptChanges();
				flag = (decimal.Compare(frm_Rizbar.sum, decimal.Zero) != 0);
				if (flag)
				{
					this.txt_tedad.Text = Conversions.ToString(Public_Function.GetDecimalValue(frm_Rizbar.sum));
				}
				else
				{
					this.txt_tedad.Text = string.Empty;
				}
				flag = (decimal.Compare(frm_Rizbar.Sum_Vazn, decimal.Zero) != 0);
				if (flag)
				{
					this.txt_baskul.Text = Conversions.ToString(Public_Function.GetDecimalValue(frm_Rizbar.Sum_Vazn));
				}
				else
				{
					this.txt_baskul.Text = string.Empty;
				}
				DataTable dt = this.dt_rizbar.Copy();
				this.Grid_RizBar.DataSource = this.Create_Rizbar_table(dt);
				flag = (this.Grid_RizBar.RowCount > 0);
				if (flag)
				{
					this.Grid_RizBar.Visible = true;
					this.SyncTedad();
					this.RemoveZeroVazn();
					flag = (this.GridEX1.DataSource != null);
					if (flag)
					{
						this.Prepare_furush_detail((DataTable)this.GridEX1.DataSource);
					}
				}
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00137F54 File Offset: 0x00136154
		public void Check_Enable()
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID)));
			bool flag = num == 1;
			if (flag)
			{
				this.setEnable(false);
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00137F94 File Offset: 0x00136194
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = !this.ValidateRizBar();
			if (!flag)
			{
				Frm_Safi frm_Safi = new Frm_Safi
				{
					Furush_ID = (long)this.ID
				};
				frm_Safi.txt_num.TabStop = false;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Safi);
				flag = frm_Safi.save;
				if (flag)
				{
					long navigateID = this.Furush.GetNavigateID(Furush_Hag.NavTo.nextopen, Conversions.ToLong(this.txt_num.Value));
					flag = (navigateID == 0L);
					if (flag)
					{
						this.MeNew();
					}
					else
					{
						flag = (navigateID != (long)this.Num);
						if (flag)
						{
							this.Num = checked((int)navigateID);
							this.LoadData();
						}
					}
				}
			}
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00138050 File Offset: 0x00136250
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

		// Token: 0x06001AF7 RID: 6903 RVA: 0x001381B0 File Offset: 0x001363B0
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.Row < 0;
			if (flag)
			{
				this.GridEX1.Row = 0;
			}
			flag = (this.GridEX1.CurrentRow.Cells["moshtari_ID"].Value != DBNull.Value);
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectGreater(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, 0, false);
				if (flag2)
				{
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value);
					this.Refresh_Status();
				}
				else
				{
					this.Clean_Status();
				}
			}
			this.GetStatusInfo();
			flag2 = Conversions.ToBoolean(Public_Function.dict["newrow_kala"]);
			checked
			{
				bool flag3;
				if (flag2)
				{
					flag = (this.GridEX1.GetRow().Cells["Kala_ID"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
					if (flag)
					{
						flag3 = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value != DBNull.Value);
						if (flag3)
						{
							this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
							this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
							this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
							flag3 = (this.GridEX1.GetRow(this.GridEX1.Row - 1).Cells["row_index"].Value != DBNull.Value);
							if (flag3)
							{
								this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRow(this.GridEX1.Row - 1).Cells["row_index"].Value);
							}
							flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
							if (flag3)
							{
								flag2 = (this.GridEX1.EditTextBox != null);
								if (flag2)
								{
									this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
								}
							}
						}
					}
				}
				flag3 = (this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
				if (flag3)
				{
					flag2 = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
					if (flag2)
					{
						this.GridEX1.GetRow().Cells["Zarf"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value);
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Zarf"].Position);
						if (flag3)
						{
							flag2 = (this.GridEX1.EditTextBox != null);
							if (flag2)
							{
								this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value);
							}
						}
					}
				}
				flag3 = (this.GridEX1.GetRow().Cells["Tarikh_Fa"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
				if (flag3)
				{
					this.GridEX1.GetRow().Cells["Tarikh_Fa"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Tarikh_Fa"].Value);
					flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position);
					if (flag3)
					{
						flag2 = (this.GridEX1.EditTextBox != null);
						if (flag2)
						{
							this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Tarikh_Fa"].Value);
						}
					}
				}
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x001387B0 File Offset: 0x001369B0
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.SyncTedad();
			Public_Function.InvokeMethod("Frm_DaryaftPardakht", "Refresh_Furush_Naghd", null);
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00138828 File Offset: 0x00136A28
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position;
			bool flag2;
			if (flag)
			{
				flag2 = (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar));
				if (flag2)
				{
					this.Moshtari_Select(e.KeyChar);
					e.Handled = true;
					return;
				}
				e.Handled = true;
			}
			flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["kala_Name"].Position);
			if (flag2)
			{
				flag = (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar));
				if (flag)
				{
					this.Kala_select(e.KeyChar);
					e.Handled = true;
					return;
				}
				e.Handled = true;
			}
			flag2 = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0 && Strings.Asc(e.KeyChar) != 8);
			if (flag2)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00138970 File Offset: 0x00136B70
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.Isnew;
			if (flag)
			{
				bool flag2 = Public_Function.ConfirmDelete() == DialogResult.Yes;
				if (flag2)
				{
					Public_Function.Delete_Row("furush_hag", (long)this.ID);
					string empty = string.Empty;
					this.Furush.Delete(Conversions.ToString(this.ID));
					this.MeNew();
				}
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x001389D0 File Offset: 0x00136BD0
		private void Eslah_safi()
		{
			string text = "declare @sanad_id int;declare @karmozd_sanad_id int;declare @keraye_id int;declare @hazine_id int;declare @kerayebes_id int;declare @hazinebes_id int;";
			text = text + "delete from sanad where id in (select sanad_id from safi_furush_extend where furush_id=" + Conversions.ToString(this.ID) + ");";
			text = text + "delete from safi_furush_extend where furush_id=" + Conversions.ToString(this.ID) + ";";
			text = text + "select @sanad_id=sanad_id , @karmozd_sanad_id=karmozd_sanad_id from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID) + ";";
			text = text + "update safi_furush set sanad_id=null,karmozd_sanad_id=null where furush_hag_id=" + Conversions.ToString(this.ID) + ";";
			text += "delete from sanad where id=@sanad_id;";
			text += "delete from sanad where id=@karmozd_sanad_id;";
			text = text + "delete from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID) + ";";
			text = text + "delete from sanad where id in (select sanadbed_id from furush_darsad where furush_id=" + Conversions.ToString(this.ID) + ");";
			text = text + "delete from sanad where id in (select sanadbes_id from furush_darsad where furush_id=" + Conversions.ToString(this.ID) + ");";
			text = text + "delete from furush_darsad where furush_id=" + Conversions.ToString(this.ID);
			Public_Function.ExecuteNonQuery(text);
			this.setEnable(true);
			Public_Function.InvokeMethod("LoadSafiData");
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00138AF4 File Offset: 0x00136CF4
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("با اصلاح اطلاعات صافی ثبت شده حذف میگردد" + Environment.NewLine + "آیا مایل به اصلاح اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				bool flag2 = !Public_Function.dict.ContainsKey("eslah_safi") || Conversions.ToDouble(Public_Function.dict["eslah_safi"]) == 1.0;
				if (flag2)
				{
					this.Eslah_safi();
				}
				else
				{
					flag2 = (Conversions.ToDouble(Public_Function.dict["eslah_safi"]) == 3.0);
					if (flag2)
					{
						flag2 = (new Frm_Password
						{
							Auth_type = 2
						}.ShowDialog() == DialogResult.OK);
						if (flag2)
						{
							this.Eslah_safi();
						}
					}
				}
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00138BBC File Offset: 0x00136DBC
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, -1, false) && Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, -3, false);
				if (flag2)
				{
					Frm_SuratHesab_Moshtari arg_CD_0 = frm_SuratHesab_Moshtari;
					object expr_BB = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value;
					int? num;
					arg_CD_0.Moshtari_id = ((expr_BB != null) ? ((int?)expr_BB) : num);
					frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00138CDC File Offset: 0x00136EDC
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
				flag = (e.Row.Cells["vazn_kol"].Value != DBNull.Value);
				if (flag)
				{
					e.Row.Cells["vazn_kol"].Value = Public_Function.GetDecimalValue(Conversions.ToDecimal(e.Row.Cells["vazn_kol"].Value));
				}
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00138D74 File Offset: 0x00136F74
		private void txt_desc_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.Col = 1;
				this.GridEX1.GetRow().BeginEdit();
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00138DD8 File Offset: 0x00136FD8
		private void ButtonItem10_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_moshtari.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_moshtari.ShowTip("صاحب بار را انتخاب فرمائید");
			}
			else
			{
				Frm_Furush_Keraye frm_Furush_Keraye = new Frm_Furush_Keraye
				{
					dt_keraye = this.dt_Keraye,
					Moshtari_ID = Conversions.ToLong(this.txt_moshtari.Value),
					Furush_num = this.txt_num.Value
				};
				flag = this.Isnew;
				if (flag)
				{
					frm_Furush_Keraye.Furush_ID = -1L;
				}
				else
				{
					frm_Furush_Keraye.Furush_ID = (long)this.ID;
				}
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Furush_Keraye);
				this.dt_Keraye = frm_Furush_Keraye.dt_keraye;
				this.dt_Keraye.AcceptChanges();
				this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
				long num = 0L;
				long? value = this.txt_makharej.Value;
				bool? arg_11C_0;
				if (!value.HasValue)
				{
					arg_11C_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(value.GetValueOrDefault() == num);
					arg_11C_0 = flag2;
				}
				bool? flag3 = arg_11C_0;
				flag = flag3.GetValueOrDefault();
				if (flag)
				{
					this.txt_makharej.SetNew();
				}
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.Col = 1;
				this.GridEX1.GetRow().BeginEdit();
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00007A96 File Offset: 0x00005C96
		private void txt_makharej_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem10_Click(null, null);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00138F60 File Offset: 0x00137160
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem10_Click(null, null);
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00007AA3 File Offset: 0x00005CA3
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00138F88 File Offset: 0x00137188
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem4_Click(null, null);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00138FB0 File Offset: 0x001371B0
		private void ButtonItem12_Click(object sender, EventArgs e)
		{
			Frm_Change_Kala_To_Kala frm_Change_Kala_To_Kala = new Frm_Change_Kala_To_Kala();
			frm_Change_Kala_To_Kala.dt_kharid = this.dt_rizbar;
			frm_Change_Kala_To_Kala.dt_furush = (DataTable)this.GridEX1.DataSource;
			frm_Change_Kala_To_Kala.dt_kala_to_kala = this.dt_kala_to_kala;
			frm_Change_Kala_To_Kala.grid = this.GridEX1;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Change_Kala_To_Kala);
			this.SyncTedad();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00007AB0 File Offset: 0x00005CB0
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00007ABB File Offset: 0x00005CBB
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00007AC6 File Offset: 0x00005CC6
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.Focus();
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00128E48 File Offset: 0x00127048
		private void SetHeader(StiReport rpt)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
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

		// Token: 0x06001B0A RID: 6922 RVA: 0x0013901C File Offset: 0x0013721C
		public void ButtonItem14_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\furush.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			this.dt_rizbar.TableName = "rizbar";
			stiReport.RegData(dataTable);
			stiReport.RegData(this.dt_rizbar);
			this.SetHeader(stiReport);
			StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text4");
			stiText.Text = this.txt_moshtari.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text26");
			stiText.Text = this.txt_sh_mashin.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text27");
			stiText.Text = this.txt_sh_barname.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text28");
			stiText.Text = this.txt_tarikh_vurud.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text33");
			stiText.Text = this.txt_baskul_mabda.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text34");
			stiText.Text = this.txt_baskul.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text35");
			stiText.Text = this.txt_tedad.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text36");
			stiText.Text = this.txt_makharej.Text;
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00139214 File Offset: 0x00137414
		private void txt_sh_barname_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar.Focus();
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x001292DC File Offset: 0x001274DC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع مانده";
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00007AD6 File Offset: 0x00005CD6
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00139240 File Offset: 0x00137440
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem16.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00139300 File Offset: 0x00137500
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = false;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem17.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x001393C0 File Offset: 0x001375C0
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = false;
			this.uncheckmenu();
			this.ButtonItem18.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00139480 File Offset: 0x00137680
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem19.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00139540 File Offset: 0x00137740
		private void txt_pardakhti_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000A2E RID: 2606
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000A30 RID: 2608
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000A31 RID: 2609
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000A32 RID: 2610
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000A33 RID: 2611
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000A34 RID: 2612
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000A35 RID: 2613
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000A36 RID: 2614
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000A37 RID: 2615
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000A38 RID: 2616
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04000A39 RID: 2617
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000A3A RID: 2618
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000A3B RID: 2619
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x04000A3C RID: 2620
		[AccessedThroughProperty("txt_tedad")]
		private NumericBox _txt_tedad;

		// Token: 0x04000A3D RID: 2621
		[AccessedThroughProperty("txt_sh_barname")]
		private EditBox _txt_sh_barname;

		// Token: 0x04000A3E RID: 2622
		[AccessedThroughProperty("txt_tarikh_vurud")]
		private DateBox2 _txt_tarikh_vurud;

		// Token: 0x04000A3F RID: 2623
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000A40 RID: 2624
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000A41 RID: 2625
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000A42 RID: 2626
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000A43 RID: 2627
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000A44 RID: 2628
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000A45 RID: 2629
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000A46 RID: 2630
		[AccessedThroughProperty("txt_baskul")]
		private NumericBox _txt_baskul;

		// Token: 0x04000A47 RID: 2631
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000A48 RID: 2632
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000A49 RID: 2633
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000A4A RID: 2634
		[AccessedThroughProperty("txt_baskul_mabda")]
		private NumericBox _txt_baskul_mabda;

		// Token: 0x04000A4B RID: 2635
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000A4C RID: 2636
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000A4D RID: 2637
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000A4E RID: 2638
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000A4F RID: 2639
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000A50 RID: 2640
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000A51 RID: 2641
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000A52 RID: 2642
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000A53 RID: 2643
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000A54 RID: 2644
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000A55 RID: 2645
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000A56 RID: 2646
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000A57 RID: 2647
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000A58 RID: 2648
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000A59 RID: 2649
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000A5A RID: 2650
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000A5B RID: 2651
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000A5C RID: 2652
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000A5D RID: 2653
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000A5E RID: 2654
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000A5F RID: 2655
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000A60 RID: 2656
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000A61 RID: 2657
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000A62 RID: 2658
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000A63 RID: 2659
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000A64 RID: 2660
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000A65 RID: 2661
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000A66 RID: 2662
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000A67 RID: 2663
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000A68 RID: 2664
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000A69 RID: 2665
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000A6A RID: 2666
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000A6B RID: 2667
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000A6C RID: 2668
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000A6D RID: 2669
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000A6E RID: 2670
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000A6F RID: 2671
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000A70 RID: 2672
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000A71 RID: 2673
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000A72 RID: 2674
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000A73 RID: 2675
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000A74 RID: 2676
		[AccessedThroughProperty("txt_kargari")]
		private CurrencyBox _txt_kargari;

		// Token: 0x04000A75 RID: 2677
		[AccessedThroughProperty("txt_pardakhti")]
		private CurrencyBox _txt_pardakhti;

		// Token: 0x04000A76 RID: 2678
		private Furush_Hag Furush;

		// Token: 0x04000A77 RID: 2679
		private Furush_Hag_RizBar RizBar;

		// Token: 0x04000A78 RID: 2680
		private Furush_Keraye Furush_Keraye;

		// Token: 0x04000A79 RID: 2681
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000A7A RID: 2682
		private Kala_To_Kala_Furush kala_to_kala;

		// Token: 0x04000A7B RID: 2683
		private DataTable dt_Keraye;

		// Token: 0x04000A7C RID: 2684
		private DataTable dt_kala_to_kala;

		// Token: 0x04000A7D RID: 2685
		private Frm_SelectItem frm;

		// Token: 0x04000A7E RID: 2686
		private Frm_SelectItem frm_furush;

		// Token: 0x04000A7F RID: 2687
		private Sanad sanad;

		// Token: 0x04000A80 RID: 2688
		private Sandugh Sandug;

		// Token: 0x04000A81 RID: 2689
		private Base_User_Control user;

		// Token: 0x04000A82 RID: 2690
		private int ID;

		// Token: 0x04000A83 RID: 2691
		public int Num;

		// Token: 0x04000A84 RID: 2692
		public int GotoLineID;

		// Token: 0x04000A85 RID: 2693
		private bool Isnew;

		// Token: 0x04000A86 RID: 2694
		private DataTable dt_rizbar;

		// Token: 0x04000A87 RID: 2695
		private bool prevent_enter;

		// Token: 0x04000A88 RID: 2696
		private bool prevent_close;

		// Token: 0x04000A89 RID: 2697
		private bool prevent_right;

		// Token: 0x04000A8A RID: 2698
		private bool prevent_left;

		// Token: 0x04000A8B RID: 2699
		[CompilerGenerated]
		private bool _Show_Preview;
	}
}
