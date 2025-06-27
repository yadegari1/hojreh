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
	// Token: 0x020000FB RID: 251
	[DesignerGenerated]
	public partial class Frm_KharidSardkhane : Form
	{
		// Token: 0x06001EAF RID: 7855 RVA: 0x0016E2D4 File Offset: 0x0016C4D4
		public Frm_KharidSardkhane()
		{
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Kharid_Furush_KeyDown);
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			Frm_KharidSardkhane.__ENCAddToList(this);
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			this.Kharid = new Kharid_sardkhane();
			this.RizKharid = new Kharid_Sardkhane_detail();
			this.kharid_keraye = new Kharid_Sardkhane_Keraye();
			this.kala_to_kala = new Kala_To_Kala_Kharid();
			this.Kharid_Sud = new Kharid_Sardkhane_Darsad();
			this.Moshtari_Info = new Moshtari_Info();
			this.GotoLineID = -1;
			this.frm = new Frm_SelectItem();
			this.sanad = new Sanad();
			this.Sandug = new Sandugh();
			this.ID = -1;
			this.Num = -1;
			this.Isnew = true;
			this.prevent_close = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.InitializeComponent();
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0016E3E8 File Offset: 0x0016C5E8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_KharidSardkhane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_KharidSardkhane.__ENCList.Count == Frm_KharidSardkhane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_KharidSardkhane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_KharidSardkhane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_KharidSardkhane.__ENCList[num] = Frm_KharidSardkhane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_KharidSardkhane.__ENCList.RemoveRange(num, Frm_KharidSardkhane.__ENCList.Count - num);
						Frm_KharidSardkhane.__ENCList.Capacity = Frm_KharidSardkhane.__ENCList.Count;
					}
					Frm_KharidSardkhane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00170D34 File Offset: 0x0016EF34
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000083B3 File Offset: 0x000065B3
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00170D4C File Offset: 0x0016EF4C
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x000083BD File Offset: 0x000065BD
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

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00170D64 File Offset: 0x0016EF64
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x000083C7 File Offset: 0x000065C7
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00170D7C File Offset: 0x0016EF7C
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x00170D94 File Offset: 0x0016EF94
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
				NavBox.Next_ClickEventHandler obj = new NavBox.Next_ClickEventHandler(this.txt_num_Next_Click);
				NavBox.Last_ClickEventHandler obj2 = new NavBox.Last_ClickEventHandler(this.txt_num_Last_Click);
				NavBox.First_ClickEventHandler obj3 = new NavBox.First_ClickEventHandler(this.txt_num_First_Click);
				CancelEventHandler value2 = new CancelEventHandler(this.txt_num_Validating);
				NavBox.NumberBox_KeydownEventHandler obj4 = new NavBox.NumberBox_KeydownEventHandler(this.txt_num_NumberBox_Keydown);
				NavBox.Previous_ClickEventHandler obj5 = new NavBox.Previous_ClickEventHandler(this.txt_num_Previous_Click);
				bool flag = this._txt_num != null;
				if (flag)
				{
					this._txt_num.Next_Click -= obj;
					this._txt_num.Last_Click -= obj2;
					this._txt_num.First_Click -= obj3;
					this._txt_num.Validating -= value2;
					this._txt_num.NumberBox_Keydown -= obj4;
					this._txt_num.Previous_Click -= obj5;
				}
				this._txt_num = value;
				flag = (this._txt_num != null);
				if (flag)
				{
					this._txt_num.Next_Click += obj;
					this._txt_num.Last_Click += obj2;
					this._txt_num.First_Click += obj3;
					this._txt_num.Validating += value2;
					this._txt_num.NumberBox_Keydown += obj4;
					this._txt_num.Previous_Click += obj5;
				}
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00170EC8 File Offset: 0x0016F0C8
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x00170EE0 File Offset: 0x0016F0E0
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

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x00170F40 File Offset: 0x0016F140
		// (set) Token: 0x06001EBE RID: 7870 RVA: 0x00170F58 File Offset: 0x0016F158
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
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value4 = new EventHandler(this.GridEX1_SelectionChanged);
				EndCustomEditEventHandler value5 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				KeyPressEventHandler value6 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.SelectionChanged -= value4;
					this._GridEX1.EndCustomEdit -= value5;
					this._GridEX1.KeyPress -= value6;
					this._GridEX1.CellEdited -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.SelectionChanged += value4;
					this._GridEX1.EndCustomEdit += value5;
					this._GridEX1.KeyPress += value6;
					this._GridEX1.CellEdited += value7;
				}
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x0017108C File Offset: 0x0016F28C
		// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x000083D1 File Offset: 0x000065D1
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

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x001710A4 File Offset: 0x0016F2A4
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x001710BC File Offset: 0x0016F2BC
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

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x0017111C File Offset: 0x0016F31C
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x00171134 File Offset: 0x0016F334
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00171194 File Offset: 0x0016F394
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x001711AC File Offset: 0x0016F3AC
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x0017120C File Offset: 0x0016F40C
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00171224 File Offset: 0x0016F424
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

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00171284 File Offset: 0x0016F484
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0017129C File Offset: 0x0016F49C
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

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x001712FC File Offset: 0x0016F4FC
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00171314 File Offset: 0x0016F514
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00171374 File Offset: 0x0016F574
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x0017138C File Offset: 0x0016F58C
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

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x001713EC File Offset: 0x0016F5EC
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00171404 File Offset: 0x0016F604
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

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00171464 File Offset: 0x0016F664
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x000083DB File Offset: 0x000065DB
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0017147C File Offset: 0x0016F67C
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x000083E5 File Offset: 0x000065E5
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

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00171494 File Offset: 0x0016F694
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x000083EF File Offset: 0x000065EF
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

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x001714AC File Offset: 0x0016F6AC
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x000083F9 File Offset: 0x000065F9
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

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x001714C4 File Offset: 0x0016F6C4
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00008403 File Offset: 0x00006603
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

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x001714DC File Offset: 0x0016F6DC
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0000840D File Offset: 0x0000660D
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

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x001714F4 File Offset: 0x0016F6F4
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00008417 File Offset: 0x00006617
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

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0017150C File Offset: 0x0016F70C
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00008421 File Offset: 0x00006621
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

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00171524 File Offset: 0x0016F724
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x0000842B File Offset: 0x0000662B
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

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0017153C File Offset: 0x0016F73C
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00008435 File Offset: 0x00006635
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

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00171554 File Offset: 0x0016F754
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x0000843F File Offset: 0x0000663F
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

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x0017156C File Offset: 0x0016F76C
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x00008449 File Offset: 0x00006649
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
				this._Grid_RizBar = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00171584 File Offset: 0x0016F784
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0017159C File Offset: 0x0016F79C
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x001715FC File Offset: 0x0016F7FC
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x00171614 File Offset: 0x0016F814
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x0017169C File Offset: 0x0016F89C
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00008453 File Offset: 0x00006653
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

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x001716B4 File Offset: 0x0016F8B4
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x0000845D File Offset: 0x0000665D
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

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x001716CC File Offset: 0x0016F8CC
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x001716E4 File Offset: 0x0016F8E4
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

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0017176C File Offset: 0x0016F96C
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00008467 File Offset: 0x00006667
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

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00171784 File Offset: 0x0016F984
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x0017179C File Offset: 0x0016F99C
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
				EventHandler value2 = new EventHandler(this.CurrencyBox2_ButtonClick);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_makharej_KeyDown);
				bool flag = this._txt_makharej != null;
				if (flag)
				{
					this._txt_makharej.ButtonClick -= value2;
					this._txt_makharej.KeyDown -= value3;
				}
				this._txt_makharej = value;
				flag = (this._txt_makharej != null);
				if (flag)
				{
					this._txt_makharej.ButtonClick += value2;
					this._txt_makharej.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00171824 File Offset: 0x0016FA24
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00008471 File Offset: 0x00006671
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

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0017183C File Offset: 0x0016FA3C
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x0000847B File Offset: 0x0000667B
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

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x00171854 File Offset: 0x0016FA54
		// (set) Token: 0x06001EFC RID: 7932 RVA: 0x00008485 File Offset: 0x00006685
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0017186C File Offset: 0x0016FA6C
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x0000848F File Offset: 0x0000668F
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

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00171884 File Offset: 0x0016FA84
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00008499 File Offset: 0x00006699
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

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0017189C File Offset: 0x0016FA9C
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x000084A3 File Offset: 0x000066A3
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x001718B4 File Offset: 0x0016FAB4
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x000084AD File Offset: 0x000066AD
		internal virtual Label lbl_daramad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_daramad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_daramad = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x001718CC File Offset: 0x0016FACC
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x000084B7 File Offset: 0x000066B7
		internal virtual CurrencyBox lbl_sardkhane
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_sardkhane;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_sardkhane = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x001718E4 File Offset: 0x0016FAE4
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x000084C1 File Offset: 0x000066C1
		internal virtual CurrencyBox lbl_kerayekharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_kerayekharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_kerayekharid = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x001718FC File Offset: 0x0016FAFC
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x000084CB File Offset: 0x000066CB
		internal virtual CurrencyBox lbl_sayer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_sayer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_sayer = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00171914 File Offset: 0x0016FB14
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x000084D5 File Offset: 0x000066D5
		internal virtual CurrencyBox lbl_sardkhane2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_sardkhane2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_sardkhane2 = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x0017192C File Offset: 0x0016FB2C
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x00171944 File Offset: 0x0016FB44
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

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x001719A4 File Offset: 0x0016FBA4
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x000084DF File Offset: 0x000066DF
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x001719BC File Offset: 0x0016FBBC
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x000084E9 File Offset: 0x000066E9
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

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x001719D4 File Offset: 0x0016FBD4
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x000084F3 File Offset: 0x000066F3
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x001719EC File Offset: 0x0016FBEC
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x000084FD File Offset: 0x000066FD
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

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00171A04 File Offset: 0x0016FC04
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x00008507 File Offset: 0x00006707
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00171A1C File Offset: 0x0016FC1C
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x00008511 File Offset: 0x00006711
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

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00171A34 File Offset: 0x0016FC34
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000851B File Offset: 0x0000671B
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00171A4C File Offset: 0x0016FC4C
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00008525 File Offset: 0x00006725
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00171A64 File Offset: 0x0016FC64
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0000852F File Offset: 0x0000672F
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

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00171A7C File Offset: 0x0016FC7C
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00171A94 File Offset: 0x0016FC94
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00171AF4 File Offset: 0x0016FCF4
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00171B0C File Offset: 0x0016FD0C
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

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00171B6C File Offset: 0x0016FD6C
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00171B84 File Offset: 0x0016FD84
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00171BE4 File Offset: 0x0016FDE4
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x00171BFC File Offset: 0x0016FDFC
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

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00171C5C File Offset: 0x0016FE5C
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00008539 File Offset: 0x00006739
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

		// Token: 0x06001F2B RID: 7979 RVA: 0x00171C74 File Offset: 0x0016FE74
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
			}
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00171CA0 File Offset: 0x0016FEA0
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
						this.prevent_close = true;
						break;
					}
				}
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00171D34 File Offset: 0x0016FF34
		private void Frm_Kharid_Furush_KeyDown(object sender, KeyEventArgs e)
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
					flag2 = this.ButtonItem1.Enabled;
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
									this.ButtonItem13_Click(null, null);
								}
								else
								{
									flag2 = (keyCode == Keys.F7);
									if (flag2)
									{
										this.ButtonItem4_Click(null, null);
									}
									else
									{
										flag2 = (keyCode == Keys.F8);
										if (flag2)
										{
											this.ButtonItem7_Click(null, null);
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

		// Token: 0x06001F2E RID: 7982 RVA: 0x00171ED4 File Offset: 0x001700D4
		private void frm_Frush_hag_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("code", "کد", 15));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 20));
			this.frm.items = itemCollection;
			bool flag = this.Num == -1;
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
						this.txt_num.Enabled = false;
						this.txt_rizbar.Enabled = false;
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
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x06001F30 RID: 7984 RVA: 0x00172068 File Offset: 0x00170268
		private bool Is_In_Kharid_auto(long kala_ID)
		{
			bool result;
			try
			{
				IEnumerator enumerator = this.dt_Kharid.Rows.GetEnumerator();
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

		// Token: 0x06001F31 RID: 7985 RVA: 0x0017211C File Offset: 0x0017031C
		private bool Is_In_Kharid(long kala_ID)
		{
			bool flag = this.dt_Kharid == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					IEnumerator enumerator = this.dt_Kharid.Rows.GetEnumerator();
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

		// Token: 0x06001F32 RID: 7986 RVA: 0x001721E4 File Offset: 0x001703E4
		private int Get_Parent_Kala_Index_IN_Kharid(long kala_id)
		{
			DataRow[] array = this.dt_Kharid.Select("kala_id=" + Conversions.ToString(kala_id));
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
					DataRow[] array4 = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id =", dataRow["Parent_kala_id"])));
					bool flag2 = array4.Length > 0;
					if (flag2)
					{
						flag = (array4[0]["auto"] == DBNull.Value);
						if (flag)
						{
							result = this.dt_Kharid.Rows.IndexOf(array4[0]);
							return result;
						}
					}
				}
				result = -1;
				return result;
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x001722EC File Offset: 0x001704EC
		private void Add_Auto_Kala()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["kala_ID"].Value == DBNull.Value;
			if (!flag)
			{
				flag = (this.dt_Kharid.Rows.Count == 0);
				if (!flag)
				{
					flag = !this.Is_In_Kharid(Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_id"].Value));
					if (flag)
					{
						bool flag2 = !this.Is_In_Kharid_auto(Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_ID"].Value));
						if (flag2)
						{
							DataRow dataRow = this.dt_Kharid.NewRow();
							dataRow["kala_id"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["kala_id"].Value);
							dataRow["kala_name"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["kala_Name"].Value);
							int num = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_ID"].Value));
							dataRow["fee"] = RuntimeHelpers.GetObjectValue(this.dt_Kharid.Rows[num]["fee"]);
							dataRow["auto"] = true;
							dataRow["tedad"] = 0;
							dataRow["vazn_ba_zarf"] = 0;
							flag2 = (this.dt_Kharid.Rows[num]["zarf"] != DBNull.Value);
							if (flag2)
							{
								dataRow["zarf"] = RuntimeHelpers.GetObjectValue(this.dt_Kharid.Rows[num]["zarf"]);
							}
							this.dt_Kharid.Rows.InsertAt(dataRow, checked(num + 1));
							((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num;
							this.Calc_mablagh_kharid(dataRow);
						}
					}
				}
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00172548 File Offset: 0x00170748
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
					this.GridEX1.GetTotalRow().Cells[key].Text = num.ToString().Replace(".0", "");
				}
				else
				{
					this.GridEX1.GetTotalRow().Cells[key].Text = Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
				}
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00172658 File Offset: 0x00170858
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
					GridEXCell arg_350_0 = this.GridEX1.CurrentRow.Cells["vazn_kol"];
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
					decimal? num8 = arg_332_0;
					arg_350_0.Value = num8.ToString().Replace(".0", "");
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

		// Token: 0x06001F36 RID: 7990 RVA: 0x00172A20 File Offset: 0x00170C20
		private void CalcMablagh(bool calc_jam_kol, bool calc_fee)
		{
			bool flag = this.GridEX1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_kol"].Value != null;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				object expr_72 = this.GridEX1.GetRow().Cells["vazn_kol"].Value;
				num = ((expr_72 != null) ? ((decimal?)expr_72) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["fee"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["fee"].Value != null);
			decimal? num3;
			if (flag)
			{
				object expr_F7 = this.GridEX1.GetRow().Cells["fee"].Value;
				num3 = ((expr_F7 != null) ? ((decimal?)expr_F7) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["jam_Kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_Kol"].Value != null);
			decimal? num4;
			if (flag)
			{
				object expr_17C = this.GridEX1.GetRow().Cells["jam_Kol"].Value;
				num4 = ((expr_17C != null) ? ((decimal?)expr_17C) : num2);
			}
			if (calc_jam_kol)
			{
				bool flag2 = num.HasValue && num3.HasValue;
				if (flag2)
				{
					GridEXCell arg_20D_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
					decimal? arg_208_0;
					if (!(num.HasValue & num3.HasValue))
					{
						arg_208_0 = null;
					}
					else
					{
						decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
						arg_208_0 = num5;
					}
					arg_20D_0.Value = arg_208_0;
				}
			}
			if (calc_fee)
			{
				flag = (num.HasValue && num4.HasValue);
				if (flag)
				{
					decimal zero = decimal.Zero;
					bool? arg_276_0;
					if (!num.HasValue)
					{
						arg_276_0 = null;
					}
					else
					{
						bool? flag3 = new bool?(decimal.Compare(num.GetValueOrDefault(), zero) == 0);
						arg_276_0 = flag3;
					}
					bool? flag4 = arg_276_0;
					bool valueOrDefault = flag4.GetValueOrDefault();
					if (!valueOrDefault)
					{
						GridEXCell arg_2E1_0 = this.GridEX1.CurrentRow.Cells["fee"];
						decimal? arg_2DC_0;
						if (!(num4.HasValue & num.HasValue))
						{
							arg_2DC_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Divide(num4.GetValueOrDefault(), num.GetValueOrDefault()));
							arg_2DC_0 = num5;
						}
						arg_2E1_0.Value = arg_2DC_0;
					}
				}
			}
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00172D18 File Offset: 0x00170F18
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
				this.GridEX1.GetTotalRow().Cells["zarf"].Text = num.ToString().Replace(".0", "");
			}
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x001655F0 File Offset: 0x001637F0
		private void Calc_mablagh_kharid_org(DataRow row)
		{
			bool flag = row["zarf"] != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(row["vazn_ba_zarf"], 0, false);
				if (flag2)
				{
					row["vazn_kol"] = Operators.SubtractObject(row["vazn_ba_zarf"], Operators.MultiplyObject(row["tedad"], row["zarf"]).ToString().Replace(",00", "").Replace(",.", ""));
					row["jam_kol"] = Operators.MultiplyObject(row["fee"], row["vazn_kol"].ToString().Replace(",00", "").Replace(",0", ""));
				}
				else
				{
					row["jam_kol"] = 0;
				}
			}
			else
			{
				row["vazn_Kol"] = RuntimeHelpers.GetObjectValue(row["vazn_ba_Zarf"]);
				row["jam_kol"] = Operators.MultiplyObject(row["fee"], row["vazn_Kol"]);
			}
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00172E1C File Offset: 0x0017101C
		private void Calc_mablagh_kharid(DataRow row)
		{
			bool flag = row["zarf"] != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(row["vazn_ba_zarf"], 0, false);
				if (flag2)
				{
					row["vazn_kol"] = Operators.SubtractObject(row["vazn_ba_zarf"], Operators.MultiplyObject(row["tedad"], row["zarf"]).ToString().Replace(",00", "").Replace(",.", ""));
					row["jam_kol"] = Operators.MultiplyObject(row["fee"], row["vazn_kol"].ToString().Replace(",00", "").Replace(",.", ""));
				}
			}
			else
			{
				row["vazn_Kol"] = RuntimeHelpers.GetObjectValue(row["vazn_ba_Zarf"]);
				row["jam_kol"] = Operators.MultiplyObject(row["fee"], row["vazn_Kol"]);
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00172F54 File Offset: 0x00171154
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
					if (flag2)
					{
						flag = (this.dt_Kharid.Rows.Count > 0);
						if (flag)
						{
							DataRow dataRow = this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])];
							DataRow arg_CF_0 = dataRow;
							string columnName = "vazn_ba_zarf";
							arg_CF_0[columnName] = Operators.AddObject(dataRow[columnName], dataRowView["tafazol_vazn"]);
						}
					}
					flag2 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
					if (flag2)
					{
						DataRow dataRow = this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])];
						DataRow arg_160_0 = dataRow;
						string columnName = "vazn_ba_zarf";
						arg_160_0[columnName] = Operators.SubtractObject(dataRow[columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
						DataRow[] array = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
						flag2 = (array.Length > 0);
						if (flag2)
						{
							flag = (dataRowView["tafazol_vazn"] != DBNull.Value);
							DataRow[] array2;
							int num;
							if (flag)
							{
								array2 = array;
								DataRow[] arg_1D4_0 = array2;
								num = 0;
								DataRow arg_1FA_0 = arg_1D4_0[num];
								columnName = "vazn_ba_zarf";
								arg_1FA_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_vazn"]);
							}
							array2 = array;
							DataRow[] arg_20B_0 = array2;
							num = 0;
							DataRow arg_245_0 = arg_20B_0[num];
							columnName = "vazn_ba_zarf";
							arg_245_0[columnName] = Operators.AddObject(array2[num][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
							this.Calc_mablagh_kharid(array[0]);
						}
						dataRowView["tafazol_vazn"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
						this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])]);
					}
					else
					{
						DataRow[] array3 = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
						flag2 = (array3.Length > 0);
						if (flag2)
						{
							flag = (dataRowView["tafazol_vazn"] != DBNull.Value);
							if (flag)
							{
								DataRow[] array2 = array3;
								DataRow[] arg_31E_0 = array2;
								int num = 0;
								DataRow arg_344_0 = arg_31E_0[num];
								string columnName = "vazn_ba_zarf";
								arg_344_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_vazn"]);
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

		// Token: 0x06001F3B RID: 7995 RVA: 0x00173300 File Offset: 0x00171500
		private bool Can_Sub_vazn(GridEXRow grow)
		{
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			bool flag = grow.Cells["row_index"].Value != DBNull.Value;
			long num;
			if (flag)
			{
				num = Conversions.ToLong(this.dt_Kharid.Rows[Conversions.ToInteger(grow.Cells["row_index"].Value)]["kala_id"]);
			}
			else
			{
				num = Conversions.ToLong(grow.Cells["kala_id"].Value);
			}
			bool result;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["kala_id"], num, false);
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(grow.Cells["vazn_ba_zarf"].Value, this.Val(RuntimeHelpers.GetObjectValue(((DataRowView)grow.DataRow)["tafazol_vazn"]))), dataRow["vazn_mande"], false);
						if (flag2)
						{
							result = false;
							return result;
						}
						result = true;
						return result;
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
			result = true;
			return result;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00165DD4 File Offset: 0x00163FD4
		private long Val(object o)
		{
			bool flag = o == DBNull.Value;
			long result;
			if (flag)
			{
				result = 0L;
			}
			else
			{
				result = Conversions.ToLong(o);
			}
			return result;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00173488 File Offset: 0x00171688
		private bool Can_Sub_tedad(GridEXRow grow)
		{
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			bool flag = grow.Cells["row_index"].Value != DBNull.Value;
			long num;
			if (flag)
			{
				num = Conversions.ToLong(this.dt_Kharid.Rows[Conversions.ToInteger(grow.Cells["row_index"].Value)]["kala_id"]);
			}
			else
			{
				num = Conversions.ToLong(grow.Cells["kala_id"].Value);
			}
			bool result;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["kala_id"], num, false);
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(grow.Cells["tedad"].Value, this.Val(RuntimeHelpers.GetObjectValue(((DataRowView)grow.DataRow)["tafazol_tedad"]))), dataRow["tedad_mande"], false);
						if (flag2)
						{
							result = false;
							return result;
						}
						result = true;
						return result;
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
			result = true;
			return result;
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00173610 File Offset: 0x00171810
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
						DataRow[] array = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow["parent_kala_id"])));
						bool flag = array.Length > 0;
						if (flag)
						{
							int num = this.dt_Kharid.Rows.IndexOf(array[0]);
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

		// Token: 0x06001F3F RID: 7999 RVA: 0x00173738 File Offset: 0x00171938
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
				flag = (row["vazn_ba_zarf"] == DBNull.Value);
				if (flag)
				{
					flag3 = true;
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(row["vazn_ba_zarf"], 0, false);
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

		// Token: 0x06001F40 RID: 8000 RVA: 0x00173814 File Offset: 0x00171A14
		private void Subtract_from_kharid_tedad()
		{
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			bool flag = dataRowView["row_index"] != DBNull.Value;
			if (flag)
			{
				bool flag2 = dataRowView["tafazol_tedad"] != DBNull.Value;
				bool flag3;
				if (flag2)
				{
					flag3 = (this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])]["tedad"] != DBNull.Value);
					if (flag3)
					{
						DataRow dataRow = this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])];
						DataRow arg_D0_0 = dataRow;
						string columnName = "tedad";
						arg_D0_0[columnName] = Operators.AddObject(dataRow[columnName], dataRowView["tafazol_tedad"]);
					}
				}
				flag3 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
				if (flag3)
				{
					flag2 = (this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])]["tedad"] != DBNull.Value);
					if (flag2)
					{
						DataRow dataRow = this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])];
						DataRow arg_19E_0 = dataRow;
						string columnName = "tedad";
						arg_19E_0[columnName] = Operators.SubtractObject(dataRow[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
						DataRow[] array = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
						flag3 = (array.Length > 0);
						if (flag3)
						{
							flag2 = (dataRowView["tafazol_tedad"] != DBNull.Value);
							DataRow[] array2;
							int num;
							if (flag2)
							{
								array2 = array;
								DataRow[] arg_212_0 = array2;
								num = 0;
								DataRow arg_238_0 = arg_212_0[num];
								columnName = "tedad";
								arg_238_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_tedad"]);
							}
							array2 = array;
							DataRow[] arg_249_0 = array2;
							num = 0;
							DataRow arg_283_0 = arg_249_0[num];
							columnName = "tedad";
							arg_283_0[columnName] = Operators.AddObject(array2[num][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
							this.Calc_mablagh_kharid(array[0]);
						}
						dataRowView["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
						this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[Conversions.ToInteger(dataRowView["row_index"])]);
					}
					else
					{
						dataRowView["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
					}
				}
				else
				{
					DataRow[] array3 = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["kala_id"].Value)));
					flag3 = (array3.Length > 0);
					if (flag3)
					{
						flag2 = (dataRowView["tafazol_tedad"] != DBNull.Value);
						if (flag2)
						{
							DataRow[] array2 = array3;
							DataRow[] arg_390_0 = array2;
							int num = 0;
							DataRow arg_3B6_0 = arg_390_0[num];
							string columnName = "tedad";
							arg_3B6_0[columnName] = Operators.SubtractObject(array2[num][columnName], dataRowView["tafazol_tedad"]);
							this.CheckForDeleteKharid(array3[0]);
						}
						dataRowView["tafazol_tedad"] = 0;
					}
				}
			}
			else
			{
				dataRowView["tafazol_tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
			}
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00173C34 File Offset: 0x00171E34
		private void Validate_Tedad_Value()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = !this.Can_Sub_tedad(this.GridEX1.CurrentRow);
				if (flag2)
				{
					Public_Function.ShowMessage("تعداد وارد شده بیشتر از موجودی میباشد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
					if (flag2)
					{
						this.GridEX1.CurrentRow.Cells["tedad"].Value = ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"].ToString().Replace(".0", "");
					}
					else
					{
						this.GridEX1.CurrentRow.Cells["tedad"].Value = DBNull.Value;
					}
				}
			}
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00173D4C File Offset: 0x00171F4C
		private void Validate_vazn_Value()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = !this.Can_Sub_vazn(this.GridEX1.CurrentRow);
				if (flag2)
				{
					Public_Function.ShowMessage("وزن وارد شده بیشتر از موجودی میباشد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
					if (flag2)
					{
						this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value = ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"].ToString().Replace(".0", "");
					}
					else
					{
						this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value = DBNull.Value;
					}
				}
			}
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00173E64 File Offset: 0x00172064
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tedad", false) == 0;
			if (flag)
			{
				this.Add_Auto_Kala();
				this.Calc();
				this.GetSum("tedad", false);
				this.GetTotalZarf();
				this.Subtract_from_kharid_tedad();
				this.SyncTedad();
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
						}
						else
						{
							flag2 = (Operators.CompareString(left, "fee", false) == 0);
							if (flag2)
							{
								this.CalcMablagh(true, false);
							}
							else
							{
								flag2 = (Operators.CompareString(left, "jam_kol", false) == 0);
								if (flag2)
								{
									this.GetSum("jam_Kol", true);
									this.CalcMablagh(false, true);
									this.Get_Daramad();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x001741A0 File Offset: 0x001723A0
		private void RollBackTedadVazn(int? kala_id, ref int? row_index, decimal? tedad, decimal? vazn)
		{
			bool flag = !kala_id.HasValue;
			if (!flag)
			{
				flag = !row_index.HasValue;
				if (!flag)
				{
					DataRow[] array = this.dt_Kharid.Select("kala_id=" + (kala_id.HasValue ? Conversions.ToString(kala_id.GetValueOrDefault()) : null));
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
							string columnName = "vazn_ba_zarf";
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
								DataRow[] array4 = this.dt_Kharid.Select("kala_ID=" + Conversions.ToString(value));
								flag2 = (array4.Length > 0);
								if (flag2)
								{
									row_index = this.dt_Kharid.Rows.IndexOf(array4[0]);
								}
							}
						}
					}
					flag2 = tedad.HasValue;
					if (flag2)
					{
						DataRow dataRow = this.dt_Kharid.Rows[(T)row_index];
						DataRow arg_1DB_0 = dataRow;
						string columnName = "tedad";
						arg_1DB_0[columnName] = Operators.AddObject(dataRow[columnName], tedad);
					}
					flag2 = vazn.HasValue;
					if (flag2)
					{
						DataRow dataRow = this.dt_Kharid.Rows[(T)row_index];
						DataRow arg_22C_0 = dataRow;
						string columnName = "vazn_ba_zarf";
						arg_22C_0[columnName] = Operators.AddObject(dataRow[columnName], vazn);
					}
				}
				this.SyncTedad();
			}
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x001743EC File Offset: 0x001725EC
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
							this.Kharid.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
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
						int? value;
						if (flag4)
						{
							object expr_23D = this.GridEX1.CurrentRow.Cells["row_index"].Value;
							value = ((expr_23D != null) ? ((int?)expr_23D) : num2);
						}
						this.GridEX1.CurrentRow.Delete();
						this.RollBackTedadVazn(kala_id, ref value, tedad, vazn);
						flag4 = value.HasValue;
						if (flag4)
						{
							this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[(T)value]);
						}
						flag4 = kala_id.HasValue;
						if (flag4)
						{
							DataRow[] array = this.dt_Kharid.Select("kala_id=" + (kala_id.HasValue ? Conversions.ToString(kala_id.GetValueOrDefault()) : null));
							flag4 = (array.Length > 0);
							if (flag4)
							{
								this.Calc_mablagh_kharid(array[0]);
							}
						}
					}
					else
					{
						flag4 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"] != DBNull.Value);
						if (flag4)
						{
							this.Kharid.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
						}
						this.sanad.Delete(Conversions.ToString(this.GridEX1.CurrentRow.Cells["sanad_id"].Value));
						flag4 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
						decimal? num;
						decimal? tedad2;
						if (flag4)
						{
							object expr_3D4 = this.GridEX1.CurrentRow.Cells["tedad"].Value;
							tedad2 = ((expr_3D4 != null) ? ((decimal?)expr_3D4) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
						decimal? vazn2;
						if (flag4)
						{
							object expr_438 = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value;
							vazn2 = ((expr_438 != null) ? ((decimal?)expr_438) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["kala_id"].Value != DBNull.Value);
						int? num2;
						int? kala_id2;
						if (flag4)
						{
							object expr_49C = this.GridEX1.CurrentRow.Cells["kala_id"].Value;
							kala_id2 = ((expr_49C != null) ? ((int?)expr_49C) : num2);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["row_index"].Value != DBNull.Value);
						int? value2;
						if (flag4)
						{
							object expr_500 = this.GridEX1.CurrentRow.Cells["row_index"].Value;
							value2 = ((expr_500 != null) ? ((int?)expr_500) : num2);
						}
						this.GridEX1.CurrentRow.Delete();
						this.RollBackTedadVazn(kala_id2, ref value2, tedad2, vazn2);
						flag4 = value2.HasValue;
						if (flag4)
						{
							this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[(T)value2]);
						}
						flag4 = kala_id2.HasValue;
						if (flag4)
						{
							DataRow[] array2 = this.dt_Kharid.Select("kala_id=" + (kala_id2.HasValue ? Conversions.ToString(kala_id2.GetValueOrDefault()) : null));
							flag4 = (array2.Length > 0);
							if (flag4)
							{
								this.Calc_mablagh_kharid(array2[0]);
							}
						}
					}
					((DataTable)this.GridEX1.DataSource).AcceptChanges();
					flag4 = (this.ID != -1);
					if (flag4)
					{
						this.RizKharid.Update(this.ID, this.dt_Kharid);
					}
				}
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00142128 File Offset: 0x00140328
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
				}
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x001749F8 File Offset: 0x00172BF8
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
				}
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00174AE4 File Offset: 0x00172CE4
		private void txt_fee_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					e.SuppressKeyPress = true;
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00174B20 File Offset: 0x00172D20
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1;
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
					}
				}
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00174BA4 File Offset: 0x00172DA4
		private void MeNew()
		{
			this.Isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.setEnable(true);
			DataTable detailByID = this.Kharid.GetDetailByID(-1L);
			detailByID.Columns["Fee"].AllowDBNull = true;
			this.GridEX1.DataSource = detailByID;
			this.dt_kala_to_kala = this.kala_to_kala.GetByKharid_ID(-1L);
			this.Num = checked((int)this.Kharid.GetNewID());
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_num.Focus();
			this.dt_Kharid = this.RizKharid.GetByID(-1);
			this.dt_Keraye = null;
			this.dt_Darsad = null;
			this.dt_mande = null;
			this.lbl_daramad.Text = string.Empty;
			this.Grid_RizBar.DataSource = null;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00174C90 File Offset: 0x00172E90
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			switch (Public_Function.ShowMessage("آیا مایل به ذخیره اطلاعات میباشید؟", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, null))
			{
			case DialogResult.Yes:
			{
				bool flag = !this.Save(true);
				if (!flag)
				{
					this.MeNew();
				}
				break;
			}
			case DialogResult.No:
				this.MeNew();
				break;
			}
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00174CFC File Offset: 0x00172EFC
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
						flag = (dataRow2["vazn_kol"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "vazn_kol", "وزن خالص را وارد نمایید");
							result = false;
							return result;
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

		// Token: 0x06001F4D RID: 8013 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x06001F4E RID: 8014 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x06001F4F RID: 8015 RVA: 0x0017518C File Offset: 0x0017338C
		public bool ValidateRizBar()
		{
			bool flag = this.dt_Kharid == null;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				flag = (this.dt_Kharid.Rows.Count == 0);
				if (flag)
				{
					result = true;
				}
				else
				{
					DataTable dataTable = new DataTable();
					DataTable dataTable2 = new DataTable();
					dataTable.Columns.Add(new DataColumn("kala_name", typeof(string)));
					dataTable.Columns.Add(new DataColumn("tedad", typeof(decimal)));
					dataTable.Columns.Add(new DataColumn("tedadsabt", typeof(decimal)));
					dataTable2.Columns.Add(new DataColumn("kala_name", typeof(string)));
					dataTable2.Columns.Add(new DataColumn("vazn", typeof(decimal)));
					dataTable2.Columns.Add(new DataColumn("vaznsabt", typeof(decimal)));
					List<tedads> list = new List<tedads>();
					List<tedads> list2 = new List<tedads>();
					DataTable dataTable3 = (DataTable)this.GridEX1.DataSource;
					try
					{
						IEnumerator enumerator = dataTable3.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag = (dataRow["tedad"] != DBNull.Value);
							bool flag2;
							if (flag)
							{
								flag2 = !this.ContainsKala(list, Conversions.ToLong(dataRow["kala_id"]), Conversions.ToDecimal(dataRow["tedad"]));
								if (flag2)
								{
									list.Add(new tedads
									{
										kala_id = Conversions.ToLong(dataRow["kala_id"]),
										Tedad = Conversions.ToDecimal(dataRow["tedad"])
									});
								}
							}
							flag2 = (dataRow["vazn_ba_zarf"] != DBNull.Value);
							if (flag2)
							{
								flag = !this.ContainsKala(list2, Conversions.ToLong(dataRow["kala_id"]), Conversions.ToDecimal(dataRow["vazn_ba_zarf"]));
								if (flag)
								{
									list2.Add(new tedads
									{
										kala_id = Conversions.ToLong(dataRow["kala_ID"]),
										Tedad = Conversions.ToDecimal(dataRow["vazn_ba_zarf"])
									});
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
					bool flag4;
					try
					{
						IEnumerator enumerator2 = this.dt_Kharid.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							try
							{
								List<tedads>.Enumerator enumerator3 = list.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									tedads current = enumerator3.Current;
									bool flag2 = Operators.ConditionalCompareObjectEqual(current.kala_id, dataRow2["kala_id"], false);
									if (flag2)
									{
										flag = (dataRow2["tedad"] != DBNull.Value);
										if (flag)
										{
											bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataRow2["tedad"], 0, false);
											if (flag3)
											{
												flag4 = Operators.ConditionalCompareObjectGreater(current.Tedad, dataRow2["Tedad"], false);
												if (flag4)
												{
													dataTable.Rows.Add(new object[]
													{
														RuntimeHelpers.GetObjectValue(dataRow2["kala_name"]),
														RuntimeHelpers.GetObjectValue(dataRow2["tedad"]),
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
								List<tedads>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							try
							{
								List<tedads>.Enumerator enumerator4 = list2.GetEnumerator();
								while (enumerator4.MoveNext())
								{
									tedads current2 = enumerator4.Current;
									flag4 = Operators.ConditionalCompareObjectEqual(current2.kala_id, dataRow2["kala_id"], false);
									if (flag4)
									{
										bool flag3 = dataRow2["vazn_Ba_Zarf"] != DBNull.Value;
										if (flag3)
										{
											bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow2["vazn_ba_zarf"], 0, false);
											if (flag2)
											{
												flag = Operators.ConditionalCompareObjectGreater(current2.Tedad, dataRow2["vazn_Ba_Zarf"], false);
												if (flag)
												{
													dataTable2.Rows.Add(new object[]
													{
														RuntimeHelpers.GetObjectValue(dataRow2["kala_name"]),
														RuntimeHelpers.GetObjectValue(dataRow2["Vazn_Ba_Zarf"]),
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
								List<tedads>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
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

		// Token: 0x06001F50 RID: 8016 RVA: 0x001757A8 File Offset: 0x001739A8
		private void SyncSandug()
		{
			List<string> list = new List<string>();
			bool flag = Public_Function.Dt_FrmSize != null;
			if (flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
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
			flag = (this.dt_Keraye != null);
			if (flag)
			{
				try
				{
					IEnumerator enumerator2 = this.dt_Keraye.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag2 = !list.Contains(Conversions.ToString(dataRow2["tarikh_fa"]));
						if (flag2)
						{
							list.Add(Conversions.ToString(dataRow2["tarikh_fa"]));
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

		// Token: 0x06001F51 RID: 8017 RVA: 0x0017593C File Offset: 0x00173B3C
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x001759B0 File Offset: 0x00173BB0
		private bool Save(bool silent)
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
					this.addhandle();
					flag = this.Isnew;
					if (flag)
					{
						this.ID = checked((int)this.Kharid.Insert(this.txt_num.Value.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), this.txt_desc.Text));
						this.RizKharid.Update(this.ID, this.dt_Kharid);
						this.kharid_keraye.Update(this.ID, this.dt_Keraye);
						this.Kharid_Sud.Update(this.ID, this.dt_Darsad);
						flag = !silent;
						if (flag)
						{
							Public_Function.ConfirmInsert();
						}
						DataTable detailByID = this.Kharid.GetDetailByID((long)this.ID);
						this.dt_Kharid = this.RizKharid.GetByID(this.ID);
						this.dt_Darsad = this.Kharid_Sud.GetByID(this.ID);
						this.dt_kala_to_kala = this.kala_to_kala.GetByKharid_ID((long)this.ID);
						this.Prepare_furush_detail(detailByID);
						this.dt_Keraye = this.kharid_keraye.GetByID(this.ID);
						this.Adddt(this.dt_Keraye);
						this.RemoveZero(detailByID);
						this.GridEX1.DataSource = detailByID;
						this.Isnew = false;
					}
					else
					{
						this.kharid_keraye.Update(this.ID, this.dt_Keraye);
						this.RizKharid.Update(this.ID, this.dt_Kharid);
						this.Kharid_Sud.Update(this.ID, this.dt_Darsad);
						this.Kharid.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), this.txt_desc.Text);
						DataTable detailByID2 = this.Kharid.GetDetailByID((long)this.ID);
						this.dt_Kharid = this.RizKharid.GetByID(this.ID);
						this.dt_Darsad = this.Kharid_Sud.GetByID(this.ID);
						this.dt_Keraye = this.kharid_keraye.GetByID(this.ID);
						this.Adddt(this.dt_Keraye);
						this.dt_kala_to_kala = this.kala_to_kala.GetByKharid_ID((long)this.ID);
						this.Prepare_furush_detail(detailByID2);
						this.RemoveZero(detailByID2);
						this.GridEX1.DataSource = detailByID2;
						flag = !silent;
						if (flag)
						{
							Public_Function.ConfirmInsert();
						}
					}
					this.SyncSandug();
					this.ButtonItem4.Enabled = true;
					this.MeNew();
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00175D04 File Offset: 0x00173F04
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

		// Token: 0x06001F55 RID: 8021 RVA: 0x00175D4C File Offset: 0x00173F4C
		private void Get_Daramad()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum (cast (Furush_Sardkhane_Safi.Mande as bigint)),0) AS jam_furush  FROM         Furush_Sardkhane_Safi INNER JOIN  Furush_Sardkhane ON Furush_Sardkhane_Safi.Furush_Sardkhane_ID = Furush_Sardkhane.ID where kharid_sardkhane_id=" + Conversions.ToString(this.ID)));
			long num2 = Conversions.ToLong(Public_Function.GetSum(this.dt_Kharid, "jam_kol"));
			long num3 = 0L;
			bool flag = this.dt_Keraye != null;
			if (flag)
			{
				bool flag2 = this.dt_Keraye.Rows.Count > 0;
				if (flag2)
				{
					num3 = Conversions.ToLong(this.dt_Keraye.Compute("sum(keraye)", ""));
				}
			}
			checked
			{
				bool flag2 = num - (num2 + num3) != 0L;
				if (flag2)
				{
					this.lbl_daramad.Text = Public_Function.FormatPrice(Conversions.ToString(num - (num2 + num3)));
				}
				else
				{
					this.lbl_daramad.Text = Conversions.ToString(0);
				}
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00175E20 File Offset: 0x00174020
		private void SyncTedad()
		{
			bool flag = this.dt_mande == null;
			checked
			{
				if (!flag)
				{
					DataTable dataTable = this.dt_mande.Copy();
					dataTable.Columns.Add(new DataColumn("tedad_mande", typeof(decimal)));
					dataTable.Columns.Add(new DataColumn("vazn_mande", typeof(decimal)));
					flag = (dataTable.Rows.Count == 0);
					if (!flag)
					{
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								dataRow["tedad_mande"] = RuntimeHelpers.GetObjectValue(dataRow["tedad"]);
								flag = !Conversions.ToBoolean(Public_Function.dict["sardkhane_vaznkol"]);
								if (flag)
								{
									dataRow["vazn_mande"] = RuntimeHelpers.GetObjectValue(dataRow["vazn_ba_zarf"]);
									flag = Operators.ConditionalCompareObjectEqual(dataRow["vazn_mande"], 0, false);
									if (flag)
									{
										dataRow["vazn_mande"] = RuntimeHelpers.GetObjectValue(dataRow["vazn_Kol"]);
									}
								}
								else
								{
									dataRow["vazn_mande"] = RuntimeHelpers.GetObjectValue(dataRow["vazn_Kol"]);
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
						DataTable dataTable2 = (DataTable)this.GridEX1.DataSource;
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
								flag2 = (gridEXRow.Cells["Vazn_Kol"].Value == DBNull.Value);
								if (!flag2)
								{
									flag2 = !this.ContainsVazn(list2, Conversions.ToLong(gridEXRow.Cells["kala_id"].Value), Conversions.ToDecimal(gridEXRow.Cells["Vazn_Kol"].Value));
									if (flag2)
									{
										list2.Add(new tedads
										{
											kala_id = Conversions.ToLong(gridEXRow.Cells["kala_id"].Value),
											Tedad = Conversions.ToDecimal(gridEXRow.Cells["Vazn_Kol"].Value)
										});
									}
								}
							}
						}
						GridEXRow currentRow = this.GridEX1.CurrentRow;
						flag2 = (currentRow != null);
						if (flag2)
						{
							flag = (currentRow.RowType == RowType.NewRecord);
							if (flag)
							{
								bool flag3 = currentRow.Cells["kala_id"].Value != DBNull.Value;
								if (flag3)
								{
									bool flag4 = currentRow.Cells["tedad"].Value != DBNull.Value;
									bool flag5;
									if (flag4)
									{
										flag5 = !this.ContainsKala(list, Conversions.ToLong(currentRow.Cells["kala_id"].Value), Conversions.ToDecimal(currentRow.Cells["tedad"].Value));
										if (flag5)
										{
											list.Add(new tedads
											{
												kala_id = Conversions.ToLong(currentRow.Cells["kala_id"].Value),
												Tedad = Conversions.ToDecimal(currentRow.Cells["tedad"].Value)
											});
										}
									}
									flag5 = (currentRow.Cells["Vazn_Ba_Zarf"].Value != DBNull.Value);
									if (flag5)
									{
										flag4 = !this.ContainsKala(list2, Conversions.ToLong(currentRow.Cells["kala_id"].Value), Conversions.ToDecimal(currentRow.Cells["Vazn_Ba_Zarf"].Value));
										if (flag4)
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
						}
						try
						{
							IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								bool flag5 = dataRow2["tedad_mande"] != DBNull.Value;
								if (flag5)
								{
									try
									{
										List<tedads>.Enumerator enumerator3 = list.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											tedads current = enumerator3.Current;
											bool flag4 = Operators.ConditionalCompareObjectEqual(current.kala_id, dataRow2["kala_id"], false);
											if (flag4)
											{
												DataRow dataRow3 = dataRow2;
												DataRow arg_60C_0 = dataRow3;
												string columnName = "tedad_mande";
												arg_60C_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current.Tedad);
											}
										}
									}
									finally
									{
										List<tedads>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
								}
								flag5 = (dataRow2["Vazn_Ba_Zarf"] != DBNull.Value);
								if (flag5)
								{
									try
									{
										List<tedads>.Enumerator enumerator4 = list2.GetEnumerator();
										while (enumerator4.MoveNext())
										{
											tedads current2 = enumerator4.Current;
											bool flag4 = Operators.ConditionalCompareObjectEqual(current2.kala_id, dataRow2["kala_id"], false);
											if (flag4)
											{
												DataRow dataRow3 = dataRow2;
												DataRow arg_6B5_0 = dataRow3;
												string columnName = "vazn_mande";
												arg_6B5_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current2.Tedad);
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
							bool flag5 = enumerator2 is IDisposable;
							if (flag5)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						this.Grid_RizBar.DataSource = dataTable;
						this.RemoveZeroVazn();
						this.Grid_RizBar.RootTable.Columns["zarf"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["vazn_mande"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["vazn_kol"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["fee"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["jam_kol"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["tedad"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["tedad_mande"].AutoSize();
						this.Grid_RizBar.RootTable.Columns["vazn_ba_zarf"].AutoSize();
					}
				}
			}
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x001766BC File Offset: 0x001748BC
		private void RemoveZeroVazn()
		{
			try
			{
				IEnumerator enumerator = ((DataTable)this.Grid_RizBar.DataSource).Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["Tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["Tedad"] = dataRow["Tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Vazn_Ba_Zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Ba_Zarf"] = dataRow["Vazn_Ba_Zarf"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Tedad_mande"] != DBNull.Value);
					if (flag)
					{
						dataRow["tedad_mande"] = dataRow["Tedad_mande"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_mande"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_mande"] = dataRow["vazn_mande"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".0", "");
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

		// Token: 0x06001F58 RID: 8024 RVA: 0x0017689C File Offset: 0x00174A9C
		private void LoadHeader(DataRow dr)
		{
			this.txt_num.Value = Conversions.ToString(dr["Num"]);
			this.ID = Conversions.ToInteger(dr["ID"]);
			this.txt_desc.Text = dr["Desc"].ToString();
			this.dt_Keraye = this.kharid_keraye.GetByID(this.ID);
			this.Adddt(this.dt_Keraye);
			this.dt_Kharid = this.RizKharid.GetByID(this.ID);
			this.txt_rizbar.Text = Public_Function.GetSum(this.dt_Kharid, "jam_kol");
			this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
			this.Get_Dt_Mande((long)this.ID);
			this.Grid_RizBar.DataSource = this.dt_mande;
			this.get_keraye();
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00176994 File Offset: 0x00174B94
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
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".0", "");
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

		// Token: 0x06001F5A RID: 8026 RVA: 0x00176A8C File Offset: 0x00174C8C
		private void Prepare_furush_detail(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_ID=", dataRow["kala_ID"])));
					bool flag = array.Length == 0;
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

		// Token: 0x06001F5B RID: 8027 RVA: 0x00176B9C File Offset: 0x00174D9C
		private void DeleteTekrari(string num)
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"select id from kharid_sardkhane where type is null and num=",
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
						this.Kharid.Delete(Conversions.ToString(dataRow["ID"]));
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

		// Token: 0x06001F5C RID: 8028 RVA: 0x00176C7C File Offset: 0x00174E7C
		private void LoadData()
		{
			DataRow byID = this.Kharid.GetByID((long)this.Num);
			bool flag = byID == null;
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			else
			{
				this.LoadHeader(byID);
				this.DeleteTekrari(Conversions.ToString(this.Num));
				this.dt_Darsad = this.Kharid_Sud.GetByID(this.ID);
				DataTable detailByID = this.Kharid.GetDetailByID(Conversions.ToLong(byID["ID"]));
				this.dt_kala_to_kala = this.kala_to_kala.GetByKharid_ID(Conversions.ToLong(byID["ID"]));
				this.Prepare_furush_detail(detailByID);
				this.RemoveZero(detailByID);
				detailByID.AcceptChanges();
				this.GridEX1.DataSource = detailByID;
				this.SyncTedad();
				this.RemoveZeroVazn();
				this.ButtonItem4.Enabled = true;
				this.Isnew = false;
				flag = (byID["daramad_sanad_id"] == DBNull.Value);
				if (flag)
				{
					this.setEnable(true);
				}
				else
				{
					this.setEnable(false);
				}
				this.Get_Daramad();
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00176D9C File Offset: 0x00174F9C
		private void txt_num_First_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid_sardkhane.NavTo.first, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001F5E RID: 8030 RVA: 0x00176DF8 File Offset: 0x00174FF8
		private void txt_num_Last_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid_sardkhane.NavTo.last, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001F5F RID: 8031 RVA: 0x00176E54 File Offset: 0x00175054
		private void txt_num_Next_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid_sardkhane.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001F60 RID: 8032 RVA: 0x00176EB0 File Offset: 0x001750B0
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid_sardkhane.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001F61 RID: 8033 RVA: 0x00176F0C File Offset: 0x0017510C
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

		// Token: 0x06001F62 RID: 8034 RVA: 0x00008543 File Offset: 0x00006743
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00176F8C File Offset: 0x0017518C
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			Frm_Sardkhane_RizKharid frm_Sardkhane_RizKharid = new Frm_Sardkhane_RizKharid
			{
				Furush_Table = (DataTable)this.GridEX1.DataSource
			};
			bool flag = this.Isnew;
			if (flag)
			{
				frm_Sardkhane_RizKharid.Kharid_ID = -1L;
			}
			else
			{
				frm_Sardkhane_RizKharid.Kharid_ID = (long)this.ID;
			}
			frm_Sardkhane_RizKharid.dt_kala_to_kala = this.dt_kala_to_kala;
			frm_Sardkhane_RizKharid.dt_Kharid = this.dt_Kharid;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Sardkhane_RizKharid);
			flag = (frm_Sardkhane_RizKharid.DialogResult != DialogResult.Abort);
			if (flag)
			{
				this.dt_Kharid = frm_Sardkhane_RizKharid.dt_Kharid;
				this.dt_Kharid.AcceptChanges();
				this.txt_rizbar.Text = Public_Function.GetSum(this.dt_Kharid, "jam_kol");
				this.Get_Dt_Mande((long)this.ID);
				this.Grid_RizBar.DataSource = this.dt_mande;
				flag = (this.Grid_RizBar.RowCount > 0);
				if (flag)
				{
					this.SyncTedad();
					this.RemoveZeroVazn();
				}
			}
			this.Get_Daramad();
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00008556 File Offset: 0x00006756
		private void Get_Dt_Mande(long Kharid_id)
		{
			this.dt_mande = Public_Function.FillData(" SELECT     Kharid_Sardkhane_Detail.Kala_ID,max(Kala.Name) AS Kala_Name,sum ( Kharid_Sardkhane_Detail.Tedad) AS Tedad, sum(  Kharid_Sardkhane_Detail.Vazn_Kol) AS Vazn_Kol,sum(  Kharid_Sardkhane_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf  FROM         Kharid_Sardkhane_Detail INNER JOIN  Moshtari ON Kharid_Sardkhane_Detail.Moshtari_id = Moshtari.ID INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID   where Kharid_Sardkhane_ID = " + Conversions.ToString(Kharid_id) + " group by kala_id ");
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00177098 File Offset: 0x00175298
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

		// Token: 0x06001F66 RID: 8038 RVA: 0x0017713C File Offset: 0x0017533C
		private void GetStatusInfo()
		{
			DataTable dataTable = Public_Function.FillData("SELECT    isnull( sum (Furush_Sardkhane_Detail.Jam_Kol),0) as jam_kol     FROM         Furush_Sardkhane_Detail INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN   Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where Furush_Sardkhane_Detail.moshtari_id in (-1,-2)   and Kharid_Sardkhane.num=" + Conversions.ToString(this.Num) + " union all    SELECT    isnull( sum (Furush_Sardkhane_Detail.Jam_Kol),0) as jam_kol    FROM         Furush_Sardkhane_Detail INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN   Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where Furush_Sardkhane_Detail.moshtari_id not in (-1,-2)   and Kharid_Sardkhane.num=" + Conversions.ToString(this.Num));
			this.LabelCommand7.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[0]["jam_kol"])));
			this.LabelCommand5.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[1]["jam_kol"])));
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x001771E0 File Offset: 0x001753E0
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00177234 File Offset: 0x00175434
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.Row < 0;
			if (flag)
			{
				this.GridEX1.Row = 0;
			}
			flag = (this.GridEX1.CurrentRow.Cells["moshtari_ID"].Value != DBNull.Value);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectGreater(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, 0, false);
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
			checked
			{
				bool flag2 = this.GridEX1.GetRow().Cells["Kala_ID"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0;
				if (flag2)
				{
					flag = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value != DBNull.Value);
					if (flag)
					{
						this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
						this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
						this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
						flag2 = (this.GridEX1.GetRow(this.GridEX1.Row - 1).Cells["row_index"].Value != DBNull.Value);
						if (flag2)
						{
							this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRow(this.GridEX1.Row - 1).Cells["row_index"].Value);
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
						if (flag2)
						{
							flag = (this.GridEX1.EditTextBox != null);
							if (flag)
							{
								this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
							}
						}
					}
				}
				flag2 = (this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
				if (flag2)
				{
					flag = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
					if (flag)
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
				flag2 = (this.GridEX1.GetRow().Cells["Tarikh_Fa"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
				if (flag2)
				{
					this.GridEX1.GetRow().Cells["Tarikh_Fa"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Tarikh_Fa"].Value);
					flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position);
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox != null);
						if (flag)
						{
							this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Tarikh_Fa"].Value);
						}
					}
				}
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00177814 File Offset: 0x00175A14
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.Get_Daramad();
			this.Kharid.UpdateDaramad(Conversions.ToString(this.Num));
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00177890 File Offset: 0x00175A90
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["kala_Name"].Position);
			if (flag)
			{
				e.Handled = true;
			}
			flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0 && Strings.Asc(e.KeyChar) != 8);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0017795C File Offset: 0x00175B5C
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.Isnew;
			if (flag)
			{
				bool flag2 = Public_Function.ConfirmDelete() == DialogResult.Yes;
				if (flag2)
				{
					this.Kharid.Delete(Conversions.ToString(this.ID));
					this.MeNew();
					this.txt_rizbar.Focus();
				}
			}
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x001779B0 File Offset: 0x00175BB0
		private void get_keraye()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
			decimal num4 = 0m;
			try
			{
				IEnumerator enumerator = this.dt_Keraye.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					object left = dataRow["hazinekharid_id"];
					bool flag = Operators.ConditionalCompareObjectEqual(left, -1, false);
					if (flag)
					{
						num = Conversions.ToDecimal(Operators.AddObject(num, dataRow["keraye"]));
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, -2, false);
						if (flag)
						{
							num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataRow["keraye"]));
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, -3, false);
							if (flag)
							{
								num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataRow["keraye"]));
							}
							else
							{
								num4 = Conversions.ToDecimal(Operators.AddObject(num4, dataRow["keraye"]));
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
			this.lbl_kerayekharid.Text = Public_Function.FormatPrice(Conversions.ToString(num));
			this.lbl_sardkhane.Text = Public_Function.FormatPrice(Conversions.ToString(num2));
			this.lbl_sardkhane2.Text = Public_Function.FormatPrice(Conversions.ToString(num3));
			this.lbl_sayer.Text = Public_Function.FormatPrice(Conversions.ToString(num4));
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00177B84 File Offset: 0x00175D84
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Kharid_Sardkhane_Keraye2 frm_Kharid_Sardkhane_Keraye = new Frm_Kharid_Sardkhane_Keraye2
			{
				dt_keraye = this.dt_Keraye
			};
			bool isnew = this.Isnew;
			if (isnew)
			{
				frm_Kharid_Sardkhane_Keraye.Kharid_ID = -1L;
			}
			else
			{
				frm_Kharid_Sardkhane_Keraye.Kharid_ID = (long)this.ID;
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Kharid_Sardkhane_Keraye);
			this.dt_Keraye = frm_Kharid_Sardkhane_Keraye.dt_keraye;
			this.dt_Keraye.AcceptChanges();
			this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
			this.get_keraye();
			this.Get_Daramad();
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00177C20 File Offset: 0x00175E20
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
				if (flag2)
				{
					bool flag3 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, -1, false);
					if (flag3)
					{
						Frm_SuratHesab_Moshtari arg_B2_0 = frm_SuratHesab_Moshtari;
						object expr_A0 = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value;
						int? num;
						arg_B2_0.Moshtari_id = ((expr_A0 != null) ? ((int?)expr_A0) : num);
						frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
					}
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00177D28 File Offset: 0x00175F28
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00177D54 File Offset: 0x00175F54
		private void txt_desc_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
			}
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0000857A File Offset: 0x0000677A
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00008587 File Offset: 0x00006787
		private void CurrencyBox2_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem7_Click(null, null);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00177D74 File Offset: 0x00175F74
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar_ButtonClick(null, null);
			}
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00177D9C File Offset: 0x00175F9C
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.CurrencyBox2_ButtonClick(null, null);
			}
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00177DC4 File Offset: 0x00175FC4
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_Sud_Kharid_Sardkhane frm_Sud_Kharid_Sardkhane = new Frm_Sud_Kharid_Sardkhane
			{
				dt_Darsad = this.dt_Darsad
			};
			bool isnew = this.Isnew;
			if (isnew)
			{
				frm_Sud_Kharid_Sardkhane.Kharid_ID = -1L;
			}
			else
			{
				frm_Sud_Kharid_Sardkhane.Kharid_ID = (long)this.ID;
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Sud_Kharid_Sardkhane);
			this.dt_Darsad = frm_Sud_Kharid_Sardkhane.dt_Darsad;
			this.dt_Darsad.AcceptChanges();
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00177E38 File Offset: 0x00176038
		private void ButtonItem10_Click(object sender, EventArgs e)
		{
			new Frm_Change_Kala_To_Kala_Kharid
			{
				dt_kharid = this.dt_Kharid,
				dt_furush = (DataTable)this.GridEX1.DataSource,
				dt_kala_to_kala = this.dt_kala_to_kala,
				grid = this.GridEX1
			}.ShowDialog();
			this.SyncTedad();
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00008594 File Offset: 0x00006794
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0000859F File Offset: 0x0000679F
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00177E9C File Offset: 0x0017609C
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			bool enabled = this.ButtonItem13.Enabled;
			if (enabled)
			{
			}
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00177EBC File Offset: 0x001760BC
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
			stiText = (StiText)rpt.GetComponentByName("Text29");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
			}
			stiText = (StiText)rpt.GetComponentByName("Text30");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head2"];
			}
			stiText = (StiText)rpt.GetComponentByName("Text56");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
			}
			stiText = (StiText)rpt.GetComponentByName("Text57");
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

		// Token: 0x06001F7B RID: 8059 RVA: 0x001780CC File Offset: 0x001762CC
		public void ButtonItem12_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\kharidsardkhane.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			this.dt_Keraye.TableName = "keraye";
			dataTable.TableName = "furush";
			this.dt_Kharid.TableName = "rizbar";
			stiReport.RegData(dataTable);
			stiReport.RegData(this.dt_Kharid);
			stiReport.RegData(this.dt_Keraye);
			this.SetHeader(stiReport);
			bool flag = this.dt_Keraye.Rows.Count == 0;
			if (flag)
			{
				StiPage stiPage = (StiPage)stiReport.GetComponentByName("Page2");
				stiPage.Enabled = false;
			}
			flag = (dataTable.Rows.Count == 0);
			if (flag)
			{
				StiPage stiPage = (StiPage)stiReport.GetComponentByName("Page3");
				stiPage.Enabled = false;
			}
			StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text33");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text59");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text4");
			stiText = (StiText)stiReport.GetComponentByName("Text26");
			stiText = (StiText)stiReport.GetComponentByName("Text27");
			stiText = (StiText)stiReport.GetComponentByName("Text28");
			stiText = (StiText)stiReport.GetComponentByName("Text36");
			Public_Function.setReportFont(stiReport, "Text62,Text71,Text72");
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x001782B4 File Offset: 0x001764B4
		private void setEnable(bool en)
		{
			if (en)
			{
				this.ButtonItem7.Visible = false;
				this.Bar1.Refresh();
				this.ButtonItem14.Text = "بستن سند (F9)";
			}
			else
			{
				this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				this.GridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
				this.ButtonItem14.Text = "باز کردن سند (F9)";
				this.Bar1.Refresh();
			}
			this.ButtonItem2.Enabled = en;
			this.ButtonItem3.Enabled = en;
			this.ButtonItem4.Enabled = en;
			this.ButtonItem6.Enabled = en;
			this.ButtonItem10.Enabled = en;
			this.txt_makharej.Enabled = en;
			this.txt_desc.Enabled = en;
			this.txt_fee.Enabled = en;
			this.txt_rizbar.Enabled = en;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x001783A4 File Offset: 0x001765A4
		private void ButtonItem14_Click(object sender, EventArgs e)
		{
			bool flag = this.Isnew;
			if (!flag)
			{
				flag = this.txt_rizbar.Enabled;
				if (flag)
				{
					bool flag2 = Public_Function.ShowMessage("آیا مایل به بستن سند میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
					if (flag2)
					{
						DataTable dataTable = Public_Function.FillData("SELECT     Furush_Sardkhane.Num, Furush_Sardkhane_Safi.ID  FROM         Furush_Sardkhane_Safi RIGHT OUTER JOIN  Furush_Sardkhane ON Furush_Sardkhane_Safi.Furush_Sardkhane_ID = Furush_Sardkhane.ID  where Furush_Sardkhane.kharid_sardkhane_id=" + Conversions.ToString(this.ID) + " and Furush_Sardkhane_Safi.ID is null");
						flag2 = (dataTable.Rows.Count == 0);
						if (flag2)
						{
							Kharid_sardkhane kharid_sardkhane = new Kharid_sardkhane();
							kharid_sardkhane.UpdateDaramad(Conversions.ToString(this.Num));
							this.setEnable(false);
						}
						else
						{
							Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" صافی فروش شماره ", dataTable.Rows[0]["num"]), " ثبت نگردیده است "), Environment.NewLine), "امکان بستن سند وجود ندارد")), MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						}
					}
				}
				else
				{
					bool flag2 = Public_Function.ShowMessage("آیا مایل به باز کردن سند میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
					if (flag2)
					{
						Frm_Password frm_Password = new Frm_Password();
						flag2 = (frm_Password.ShowDialog() == DialogResult.OK);
						if (flag2)
						{
							string text = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(daramad_sanad_id,'') from kharid_sardkhane where num=" + Conversions.ToString(this.Num)));
							flag2 = (text != null && Operators.CompareString(text, string.Empty, false) != 0);
							if (flag2)
							{
								string text2 = "delete from sanad where id=" + text + ";";
								text2 = text2 + "update kharid_sardkhane set daramad_sanad_id=null where num=" + Conversions.ToString(this.Num);
								Public_Function.ExecuteNonQuery(text2);
								this.setEnable(true);
							}
						}
					}
				}
			}
		}

		// Token: 0x04000BEC RID: 3052
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000BEE RID: 3054
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000BEF RID: 3055
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000BF0 RID: 3056
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000BF1 RID: 3057
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000BF2 RID: 3058
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000BF3 RID: 3059
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000BF4 RID: 3060
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000BF5 RID: 3061
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000BF6 RID: 3062
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000BF7 RID: 3063
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000BF8 RID: 3064
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000BF9 RID: 3065
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000BFA RID: 3066
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000BFB RID: 3067
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000BFC RID: 3068
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000BFD RID: 3069
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000BFE RID: 3070
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000BFF RID: 3071
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000C00 RID: 3072
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000C01 RID: 3073
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000C02 RID: 3074
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000C03 RID: 3075
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000C04 RID: 3076
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000C05 RID: 3077
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000C06 RID: 3078
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000C07 RID: 3079
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000C08 RID: 3080
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000C09 RID: 3081
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000C0A RID: 3082
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000C0B RID: 3083
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000C0C RID: 3084
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000C0D RID: 3085
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000C0E RID: 3086
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000C0F RID: 3087
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000C10 RID: 3088
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000C11 RID: 3089
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000C12 RID: 3090
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000C13 RID: 3091
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000C14 RID: 3092
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000C15 RID: 3093
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000C16 RID: 3094
		[AccessedThroughProperty("lbl_daramad")]
		private Label _lbl_daramad;

		// Token: 0x04000C17 RID: 3095
		[AccessedThroughProperty("lbl_sardkhane")]
		private CurrencyBox _lbl_sardkhane;

		// Token: 0x04000C18 RID: 3096
		[AccessedThroughProperty("lbl_kerayekharid")]
		private CurrencyBox _lbl_kerayekharid;

		// Token: 0x04000C19 RID: 3097
		[AccessedThroughProperty("lbl_sayer")]
		private CurrencyBox _lbl_sayer;

		// Token: 0x04000C1A RID: 3098
		[AccessedThroughProperty("lbl_sardkhane2")]
		private CurrencyBox _lbl_sardkhane2;

		// Token: 0x04000C1B RID: 3099
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000C1C RID: 3100
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000C1D RID: 3101
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000C1E RID: 3102
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000C1F RID: 3103
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000C20 RID: 3104
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000C21 RID: 3105
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000C22 RID: 3106
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000C23 RID: 3107
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000C24 RID: 3108
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000C25 RID: 3109
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000C26 RID: 3110
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000C27 RID: 3111
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000C28 RID: 3112
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000C29 RID: 3113
		[CompilerGenerated]
		private bool _Show_Preview;

		// Token: 0x04000C2A RID: 3114
		private Kharid_sardkhane Kharid;

		// Token: 0x04000C2B RID: 3115
		private Kharid_Sardkhane_detail RizKharid;

		// Token: 0x04000C2C RID: 3116
		private Kharid_Sardkhane_Keraye kharid_keraye;

		// Token: 0x04000C2D RID: 3117
		private Kala_To_Kala_Kharid kala_to_kala;

		// Token: 0x04000C2E RID: 3118
		private Kharid_Sardkhane_Darsad Kharid_Sud;

		// Token: 0x04000C2F RID: 3119
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000C30 RID: 3120
		public int GotoLineID;

		// Token: 0x04000C31 RID: 3121
		private Frm_SelectItem frm;

		// Token: 0x04000C32 RID: 3122
		private Sanad sanad;

		// Token: 0x04000C33 RID: 3123
		private Sandugh Sandug;

		// Token: 0x04000C34 RID: 3124
		private int ID;

		// Token: 0x04000C35 RID: 3125
		public int Num;

		// Token: 0x04000C36 RID: 3126
		private bool Isnew;

		// Token: 0x04000C37 RID: 3127
		private decimal? Darsad_Sud;

		// Token: 0x04000C38 RID: 3128
		private DataTable dt_Kharid;

		// Token: 0x04000C39 RID: 3129
		private DataTable dt_Keraye;

		// Token: 0x04000C3A RID: 3130
		private DataTable dt_Darsad;

		// Token: 0x04000C3B RID: 3131
		private DataTable dt_kala_to_kala;

		// Token: 0x04000C3C RID: 3132
		private DataTable dt_mande;

		// Token: 0x04000C3D RID: 3133
		private bool prevent_close;

		// Token: 0x04000C3E RID: 3134
		private bool prevent_right;

		// Token: 0x04000C3F RID: 3135
		private bool prevent_left;
	}
}
