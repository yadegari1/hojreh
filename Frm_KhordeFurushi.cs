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
	// Token: 0x020000FC RID: 252
	[DesignerGenerated]
	public partial class Frm_KhordeFurushi : Form
	{
		// Token: 0x06001F7F RID: 8063 RVA: 0x0017854C File Offset: 0x0017674C
		public Frm_KhordeFurushi()
		{
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frm_Frush_hag_KeyDown);
			Frm_KhordeFurushi.__ENCAddToList(this);
			this.KhordeFurushi = new KhordeFurushi();
			this.KhordeFurushi_Keraye = new KhordeFurushi_Keraye();
			this.Moshtari_Info = new Moshtari_Info();
			this.frm = new Frm_SelectItem();
			this.sanad = new Sanad();
			this.Sandug = new Sandugh();
			this.user = new Base_User_Control();
			this.ID = -1;
			this.Num = -1;
			this.GotoLineID = -1;
			this.prevent_right = false;
			this.prevent_left = false;
			this.prevent_Enter = false;
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			string empty = string.Empty;
			this.tarikh = empty;
			this.InitializeComponent();
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00178650 File Offset: 0x00176850
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_KhordeFurushi.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_KhordeFurushi.__ENCList.Count == Frm_KhordeFurushi.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_KhordeFurushi.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_KhordeFurushi.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_KhordeFurushi.__ENCList[num] = Frm_KhordeFurushi.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_KhordeFurushi.__ENCList.RemoveRange(num, Frm_KhordeFurushi.__ENCList.Count - num);
						Frm_KhordeFurushi.__ENCList.Capacity = Frm_KhordeFurushi.__ENCList.Count;
					}
					Frm_KhordeFurushi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0017A85C File Offset: 0x00178A5C
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x000085B7 File Offset: 0x000067B7
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

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x0017A874 File Offset: 0x00178A74
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x000085C1 File Offset: 0x000067C1
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

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0017A88C File Offset: 0x00178A8C
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x000085CB File Offset: 0x000067CB
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

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0017A8A4 File Offset: 0x00178AA4
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0017A8BC File Offset: 0x00178ABC
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

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0017A9F0 File Offset: 0x00178BF0
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x0017AA08 File Offset: 0x00178C08
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
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.Validated -= value2;
					this._txt_tarikh.KeyDown -= value3;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.Validated += value2;
					this._txt_tarikh.KeyDown += value3;
				}
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0017AA90 File Offset: 0x00178C90
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x0017AAA8 File Offset: 0x00178CA8
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
				InitCustomEditEventHandler value5 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value6 = new EventHandler(this.GridEX1_SelectionChanged);
				KeyPressEventHandler value7 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EndCustomEditEventHandler value8 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value9 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.InitCustomEdit -= value5;
					this._GridEX1.SelectionChanged -= value6;
					this._GridEX1.KeyPress -= value7;
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
					this._GridEX1.InitCustomEdit += value5;
					this._GridEX1.SelectionChanged += value6;
					this._GridEX1.KeyPress += value7;
					this._GridEX1.EndCustomEdit += value8;
					this._GridEX1.ColumnButtonClick += value9;
				}
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0017AC30 File Offset: 0x00178E30
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x000085D5 File Offset: 0x000067D5
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0017AC48 File Offset: 0x00178E48
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0017AC60 File Offset: 0x00178E60
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

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0017ACC0 File Offset: 0x00178EC0
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0017ACD8 File Offset: 0x00178ED8
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

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0017AD38 File Offset: 0x00178F38
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0017AD50 File Offset: 0x00178F50
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

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0017ADB0 File Offset: 0x00178FB0
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0017ADC8 File Offset: 0x00178FC8
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

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0017AE28 File Offset: 0x00179028
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0017AE40 File Offset: 0x00179040
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0017AEA0 File Offset: 0x001790A0
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x000085DF File Offset: 0x000067DF
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
				this._ButtonItem4 = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0017AEB8 File Offset: 0x001790B8
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0017AED0 File Offset: 0x001790D0
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0017AF30 File Offset: 0x00179130
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0017AF48 File Offset: 0x00179148
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0017AFA8 File Offset: 0x001791A8
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x000085E9 File Offset: 0x000067E9
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
				this._ButtonItem7 = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0017AFC0 File Offset: 0x001791C0
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x000085F3 File Offset: 0x000067F3
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

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0017AFD8 File Offset: 0x001791D8
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x000085FD File Offset: 0x000067FD
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

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0017AFF0 File Offset: 0x001791F0
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00008607 File Offset: 0x00006807
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

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0017B008 File Offset: 0x00179208
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00008611 File Offset: 0x00006811
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

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0017B020 File Offset: 0x00179220
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0000861B File Offset: 0x0000681B
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

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0017B038 File Offset: 0x00179238
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00008625 File Offset: 0x00006825
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

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0017B050 File Offset: 0x00179250
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x0000862F File Offset: 0x0000682F
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0017B068 File Offset: 0x00179268
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00008639 File Offset: 0x00006839
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0017B080 File Offset: 0x00179280
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00008643 File Offset: 0x00006843
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0017B098 File Offset: 0x00179298
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0000864D File Offset: 0x0000684D
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0017B0B0 File Offset: 0x001792B0
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00008657 File Offset: 0x00006857
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0017B0C8 File Offset: 0x001792C8
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0017B0E0 File Offset: 0x001792E0
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

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0017B140 File Offset: 0x00179340
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0017B158 File Offset: 0x00179358
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

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0017B1E0 File Offset: 0x001793E0
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00008661 File Offset: 0x00006861
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

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0017B1F8 File Offset: 0x001793F8
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0000866B File Offset: 0x0000686B
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0017B210 File Offset: 0x00179410
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00008675 File Offset: 0x00006875
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0017B228 File Offset: 0x00179428
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0000867F File Offset: 0x0000687F
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

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0017B240 File Offset: 0x00179440
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00008689 File Offset: 0x00006889
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0017B258 File Offset: 0x00179458
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00008693 File Offset: 0x00006893
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

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0017B270 File Offset: 0x00179470
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0000869D File Offset: 0x0000689D
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

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0017B288 File Offset: 0x00179488
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x000086A7 File Offset: 0x000068A7
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

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0017B2A0 File Offset: 0x001794A0
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x000086B1 File Offset: 0x000068B1
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

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0017B2B8 File Offset: 0x001794B8
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x000086BB File Offset: 0x000068BB
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0017B2D0 File Offset: 0x001794D0
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x000086C5 File Offset: 0x000068C5
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

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0017B2E8 File Offset: 0x001794E8
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0017B300 File Offset: 0x00179500
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

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0017B360 File Offset: 0x00179560
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0017B378 File Offset: 0x00179578
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
				EventHandler value2 = new EventHandler(this.txt_makharej_TextChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_makharej_KeyDown);
				EventHandler value4 = new EventHandler(this.txt_makharej_ButtonClick);
				bool flag = this._txt_makharej != null;
				if (flag)
				{
					this._txt_makharej.TextChanged -= value2;
					this._txt_makharej.KeyDown -= value3;
					this._txt_makharej.ButtonClick -= value4;
				}
				this._txt_makharej = value;
				flag = (this._txt_makharej != null);
				if (flag)
				{
					this._txt_makharej.TextChanged += value2;
					this._txt_makharej.KeyDown += value3;
					this._txt_makharej.ButtonClick += value4;
				}
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0017B428 File Offset: 0x00179628
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x000086CF File Offset: 0x000068CF
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

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0017B440 File Offset: 0x00179640
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x000086D9 File Offset: 0x000068D9
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
				this._txt_rizbar = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0017B458 File Offset: 0x00179658
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x000086E3 File Offset: 0x000068E3
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

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0017B470 File Offset: 0x00179670
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x000086ED File Offset: 0x000068ED
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
				this._ButtonItem12 = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0017B488 File Offset: 0x00179688
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x000086F7 File Offset: 0x000068F7
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
				this._ButtonItem13 = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0017B4A0 File Offset: 0x001796A0
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x0017B4B8 File Offset: 0x001796B8
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

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0017B518 File Offset: 0x00179718
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0017B530 File Offset: 0x00179730
		internal virtual CurrencyBox txt_keraye
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_keraye;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_keraye_KeyDown);
				bool flag = this._txt_keraye != null;
				if (flag)
				{
					this._txt_keraye.KeyDown -= value2;
				}
				this._txt_keraye = value;
				flag = (this._txt_keraye != null);
				if (flag)
				{
					this._txt_keraye.KeyDown += value2;
				}
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0017B590 File Offset: 0x00179790
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0017B5A8 File Offset: 0x001797A8
		internal virtual CurrencyBox txt_safi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_safi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_safi_KeyDown);
				bool flag = this._txt_safi != null;
				if (flag)
				{
					this._txt_safi.KeyDown -= value2;
				}
				this._txt_safi = value;
				flag = (this._txt_safi != null);
				if (flag)
				{
					this._txt_safi.KeyDown += value2;
				}
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0017B608 File Offset: 0x00179808
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00008701 File Offset: 0x00006901
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

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0017B620 File Offset: 0x00179820
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0017B638 File Offset: 0x00179838
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0017B698 File Offset: 0x00179898
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x0017B6B0 File Offset: 0x001798B0
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0017B710 File Offset: 0x00179910
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0017B728 File Offset: 0x00179928
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0017B788 File Offset: 0x00179988
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x0017B7A0 File Offset: 0x001799A0
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0017B800 File Offset: 0x00179A00
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x0017B818 File Offset: 0x00179A18
		internal virtual ButtonItem ButtonItem20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem20_Click);
				bool flag = this._ButtonItem20 != null;
				if (flag)
				{
					this._ButtonItem20.Click -= value2;
				}
				this._ButtonItem20 = value;
				flag = (this._ButtonItem20 != null);
				if (flag)
				{
					this._ButtonItem20.Click += value2;
				}
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0017B878 File Offset: 0x00179A78
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x0000870B File Offset: 0x0000690B
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0017B890 File Offset: 0x00179A90
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00008715 File Offset: 0x00006915
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

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0017B8A8 File Offset: 0x00179AA8
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

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0017B94C File Offset: 0x00179B4C
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0017B9A0 File Offset: 0x00179BA0
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0017B9DC File Offset: 0x00179BDC
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

		// Token: 0x06001FFB RID: 8187 RVA: 0x0017BA70 File Offset: 0x00179C70
		private void frm_Frush_hag_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.Control && e.KeyCode == Keys.F5;
			if (flag)
			{
				this.ButtonItem3_Click(null, null);
			}
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
								flag2 = (keyCode == Keys.F7);
								if (flag2)
								{
									flag = this.ButtonItem20.Enabled;
									if (flag)
									{
										this.ButtonItem20_Click(null, null);
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

		// Token: 0x06001FFC RID: 8188 RVA: 0x0017BC78 File Offset: 0x00179E78
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

		// Token: 0x06001FFD RID: 8189 RVA: 0x0017BD1C File Offset: 0x00179F1C
		private void frm_Frush_hag_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Code", "کد", 15));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.frm.items = itemCollection;
			bool flag = Operators.CompareString(this.tarikh, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_tarikh.SetNew();
			}
			else
			{
				this.txt_tarikh.Text = this.tarikh;
				this.tarikh = string.Empty;
			}
			this.LoadData(this.txt_tarikh.Text);
			flag = this.Show_Preview;
			if (flag)
			{
				this.Bar1.Visible = false;
				this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				this.txt_fee.Enabled = false;
				this.txt_jam_kol.Enabled = false;
				this.txt_makharej.Enabled = false;
				this.txt_num.Enabled = false;
				this.txt_rizbar.Enabled = false;
				this.txt_tarikh.Enabled = false;
				this.txt_tarikhGrid.Enabled = false;
			}
			flag = (this.GotoLineID != -1);
			checked
			{
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
				this.frm.GridEX1.ColumnButtonClick += new ColumnActionEventHandler(this.btn_click);
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x06001FFF RID: 8191 RVA: 0x0017BF44 File Offset: 0x0017A144
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.CanDelete = false;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			string text = string.Empty;
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = " where moshtari.id not in (-4,-5,1,-2,-3,-6)";
			}
			else
			{
				text += ",-5,-4,1,-2,-3,-6)";
			}
			flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
			checked
			{
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

		// Token: 0x06002000 RID: 8192 RVA: 0x0017C104 File Offset: 0x0017A304
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
						this.frm.GridEX1.CurrentRow.Delete();
					}
					catch (Exception expr_51)
					{
						ProjectData.SetProjectError(expr_51);
						Public_Function.ShowMessage("امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0017C194 File Offset: 0x0017A394
		private void Kala_select()
		{
			this.frm.CanEdit = true;
			string command = "SELECT     Kala.ID, Kala.Name  FROM      Kala ";
			this.frm.Edit_Frm = MyProject.Forms.Frm_Kala;
			bool flag = this.frm.ShowDialog(command, MyProject.Forms.Frm_Kala, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0017C2AC File Offset: 0x0017A4AC
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

		// Token: 0x06002003 RID: 8195 RVA: 0x0017C3BC File Offset: 0x0017A5BC
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

		// Token: 0x06002004 RID: 8196 RVA: 0x0017C784 File Offset: 0x0017A984
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

		// Token: 0x06002005 RID: 8197 RVA: 0x0017CA7C File Offset: 0x0017AC7C
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

		// Token: 0x06002006 RID: 8198 RVA: 0x0017CB80 File Offset: 0x0017AD80
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tedad", false) == 0;
			if (flag)
			{
				this.Calc();
				this.GetSum("tedad", false);
				this.GetTotalZarf();
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
					this.Calc();
					this.GetSum("vazn_ba_zarf", false);
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
							this.GetSum("vazn_ba_zarf", false);
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
								}
								else
								{
									flag2 = (Operators.CompareString(left, "keraye", false) == 0);
									if (flag2)
									{
										long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
										num = checked((long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye")))));
										this.txt_makharej.Text = Conversions.ToString(num);
									}
									else
									{
										flag2 = (Operators.CompareString(left, "mablagh_safi", false) == 0);
										if (flag2)
										{
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0017D164 File Offset: 0x0017B364
		private void DelKala()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					bool flag3 = ((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"] != DBNull.Value;
					if (flag3)
					{
						this.KhordeFurushi.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
					}
					this.GridEX1.CurrentRow.Delete();
					((DataTable)this.GridEX1.DataSource).AcceptChanges();
				}
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0017D22C File Offset: 0x0017B42C
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
			if (flag)
			{
				this.Moshtari_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["kala_Name"].Position);
				if (flag)
				{
					this.Kala_select();
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

		// Token: 0x06002009 RID: 8201 RVA: 0x00123D90 File Offset: 0x00121F90
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
						flag2 = (Operators.CompareString(left, "keraye", false) == 0);
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
							flag2 = (Operators.CompareString(left, "mablagh_safi", false) == 0);
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
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0017D2D8 File Offset: 0x0017B4D8
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
						flag = (Operators.CompareString(left, "keraye", false) == 0);
						if (flag)
						{
							e.EditControl = this.txt_keraye;
							flag = (e.Value != null);
							if (flag)
							{
								this.txt_keraye.Text = e.Value.ToString();
							}
							this.txt_keraye.SelectAll();
						}
						else
						{
							flag = (Operators.CompareString(left, "mablagh_safi", false) == 0);
							if (flag)
							{
								e.EditControl = this.txt_safi;
								flag = (e.Value != null);
								if (flag)
								{
									this.txt_safi.Text = e.Value.ToString();
								}
								this.txt_safi.SelectAll();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0017D47C File Offset: 0x0017B67C
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

		// Token: 0x0600200C RID: 8204 RVA: 0x0017D4F4 File Offset: 0x0017B6F4
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
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_name"].Position);
						if (flag3)
						{
							this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
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
						flag3 = (this.GridEX1.Row == 0);
						if (flag3)
						{
							this.txt_makharej.Focus();
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
						bool flag2 = this.prevent_Enter;
						if (flag2)
						{
							this.prevent_Enter = false;
						}
						else
						{
							flag3 = (this.GridEX1.EditTextBox == null);
							if (flag3)
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
									flag = (Operators.CompareString(this.txt_tarikhGrid.Text, this.txt_tarikh.Text, false) < 0);
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
										this.Moshtari_Select();
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
											this.Kala_select();
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
											flag4 = (col == this.GridEX1.RootTable.Columns["keraye"].Position);
											if (flag4)
											{
												this.prevent_Enter = true;
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
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0017DB04 File Offset: 0x0017BD04
		private void txt_fee_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					this.prevent_Enter = true;
					e.SuppressKeyPress = true;
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0017DB48 File Offset: 0x0017BD48
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					bool flag2 = this.prevent_Enter;
					if (flag2)
					{
						this.prevent_Enter = false;
					}
					else
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
						this.prevent_Enter = true;
					}
				}
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0000871F File Offset: 0x0000691F
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0017DB98 File Offset: 0x0017BD98
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

		// Token: 0x06002011 RID: 8209 RVA: 0x0017DC58 File Offset: 0x0017BE58
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

		// Token: 0x06002012 RID: 8210 RVA: 0x0017DD18 File Offset: 0x0017BF18
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

		// Token: 0x06002013 RID: 8211 RVA: 0x0017DDD8 File Offset: 0x0017BFD8
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

		// Token: 0x06002014 RID: 8212 RVA: 0x0017DE98 File Offset: 0x0017C098
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

		// Token: 0x06002015 RID: 8213 RVA: 0x0017DF78 File Offset: 0x0017C178
		private void MeNew()
		{
			this.Load_Default_Nahve_Furush();
			this.ID = -1;
			this.txt_keraye.SetNew();
			this.txt_makharej.SetNew();
			this.setEnable(true);
			DataTable detailByID = this.KhordeFurushi.GetDetailByID(-1L);
			detailByID.Columns["Fee"].AllowDBNull = true;
			this.GridEX1.DataSource = detailByID;
			this.Num = checked((int)this.KhordeFurushi.GetNewID());
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_num.Focus();
			this.dt_Keraye = null;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0017E024 File Offset: 0x0017C224
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
						flag = !this.Save(true);
						if (flag)
						{
							MyProject.Forms.Form_Main.Get_mande_furush();
							MyProject.Forms.Form_Main.Get_mande_Safi();
						}
						else
						{
							this.MeNew();
						}
						break;
					case DialogResult.No:
						this.MeNew();
						break;
					}
				}
			}
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0017E0E4 File Offset: 0x0017C2E4
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
						flag = (dataTable.Rows[i]["kala_name"] == DBNull.Value && dataTable.Rows[i]["Vazn_Kol"] == DBNull.Value && dataTable.Rows[i]["fee"] == DBNull.Value && dataTable.Rows[i]["jam_kol"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[i].Delete();
							i--;
						}
						i++;
					}
				}
				dataTable.AcceptChanges();
				int num = 0;
				bool result;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["Moshtari_ID"] == DBNull.Value;
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Moshtari_Name", "خریدار را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["Kala_ID"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "kala_Name", "جنس را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["vazn_kol"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "vazn_kol", "وزن خالص را وارد نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["fee"] == DBNull.Value && dataRow["jam_kol"] == DBNull.Value);
						if (flag)
						{
							dataRow["fee"] = 0;
							dataRow["jam_kol"] = 0;
						}
						flag = (dataRow["fee"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "fee", "فی واحد را وارد نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["jam_kol"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "jam_kol", "قیمت کل را وارد نمایید");
							result = false;
							return result;
						}
						flag = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) && Operators.ConditionalCompareObjectEqual(dataRow["jam_kol"], 0, false));
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
					IEnumerator enumerator;
					bool flag = enumerator is IDisposable;
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0017E48C File Offset: 0x0017C68C
		private bool Validate_Tedad()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			bool flag;
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = text + Environment.NewLine + "آیا مایل به ثبت اطلاعات میباشید؟";
			}
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				flag = (Public_Function.ShowMessage(text, MessageBoxButtons.YesNo, MessageBoxIcon.Hand, null) == DialogResult.Yes);
				result = flag;
			}
			return result;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x0600201A RID: 8218 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x0600201B RID: 8219 RVA: 0x0017E604 File Offset: 0x0017C804
		public bool ValidateRizBar()
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
			bool flag2;
			try
			{
				IEnumerator enumerator = dataTable3.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
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
				flag2 = (enumerator is IDisposable);
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			flag2 = (dataTable.Rows.Count > 0 || dataTable2.Rows.Count > 0);
			bool result;
			if (flag2)
			{
				new Frm_TedadKala
				{
					dt_tedad = dataTable,
					dt_vazn = dataTable2
				}.ShowDialog();
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0017E8EC File Offset: 0x0017CAEC
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
						flag = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false);
						if (flag)
						{
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
			flag = (this.dt_Keraye != null);
			if (flag)
			{
				try
				{
					IEnumerator enumerator2 = this.dt_Keraye.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
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

		// Token: 0x0600201D RID: 8221 RVA: 0x0017EA64 File Offset: 0x0017CC64
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0017EAD8 File Offset: 0x0017CCD8
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

		// Token: 0x0600201F RID: 8223 RVA: 0x0017EB3C File Offset: 0x0017CD3C
		private bool Save(bool Silent)
		{
			this.GridEX1.EndCustomEdit -= new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited -= new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged -= new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow -= new RowLoadEventHandler(this.GridEX1_LoadingRow);
			bool flag = !this.ValidateGridData();
			bool result;
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
					string nahve_furush = Conversions.ToString(this.GetNahve_Furush());
					this.KhordeFurushi.Update(this.txt_tarikh.Text.ToString(), nahve_furush, (DataTable)this.GridEX1.DataSource);
					this.KhordeFurushi_Keraye.Update(this.txt_tarikh.Text, this.dt_Keraye);
					DataRow byID = this.KhordeFurushi.GetByID(this.txt_tarikh.Text);
					flag = (byID == null);
					if (flag)
					{
						this.MeNew();
						result = true;
					}
					else
					{
						DataTable detailByID = this.KhordeFurushi.GetDetailByID(Conversions.ToLong(byID["ID"]));
						this.dt_Keraye = this.KhordeFurushi_Keraye.GetByID(Conversions.ToInteger(byID["ID"]));
						this.RemoveZero(detailByID);
						this.GridEX1.DataSource = detailByID;
						flag = !Silent;
						if (flag)
						{
							Public_Function.ConfirmInsert();
						}
						this.SyncSandug();
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0017ECE4 File Offset: 0x0017CEE4
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

		// Token: 0x06002021 RID: 8225 RVA: 0x0017ED2C File Offset: 0x0017CF2C
		private void LoadHeader(DataRow dr)
		{
			this.txt_num.Value = Conversions.ToString(dr["Num"]);
			this.ID = Conversions.ToInteger(dr["ID"]);
			bool flag = dr["Tarikh_Vurud"] != DBNull.Value;
			if (flag)
			{
				this.txt_tarikh.SetDate(dr["Tarikh_Vurud"].ToString());
			}
			else
			{
				this.txt_tarikh.SetDefault();
			}
			this.dt_Keraye = this.KhordeFurushi_Keraye.GetByID(this.ID);
			long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
			num = checked((long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye")))));
			this.txt_makharej.Text = Conversions.ToString(num);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00126F38 File Offset: 0x00125138
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
						dataRow["zarf"] = dataRow["zarf"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".0", "");
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

		// Token: 0x06002023 RID: 8227 RVA: 0x0017EE1C File Offset: 0x0017D01C
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
			this.txt_fee.Enabled = en;
			this.txt_tarikh.Enabled = en;
			this.txt_rizbar.Enabled = en;
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0017EF40 File Offset: 0x0017D140
		private void LoadNahve_Furush(DataRow dr)
		{
			bool flag = dr["nahve_furush"] == DBNull.Value;
			if (flag)
			{
				this.uncheckmenu();
				this.ButtonItem19.Checked = true;
				this.ButtonItem19_Click(null, null);
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

		// Token: 0x06002025 RID: 8229 RVA: 0x0017F04C File Offset: 0x0017D24C
		private void LoadData(string Load_tarikh)
		{
			this.txt_makharej.Enabled = true;
			this.GridEX1.Enabled = true;
			this.txt_makharej.ButtonStyle = EditButtonStyle.TextButton;
			bool flag = Operators.CompareString(Load_tarikh, this.tarikh, false) != 0;
			checked
			{
				if (flag)
				{
					this.tarikh = Load_tarikh;
					this.txt_tarikh.SetDate(Load_tarikh);
					DataRow byID = this.KhordeFurushi.GetByID(Load_tarikh);
					flag = (byID == null);
					if (flag)
					{
						this.MeNew();
					}
					else
					{
						DataTable detailByID = this.KhordeFurushi.GetDetailByID(Conversions.ToLong(byID["ID"]));
						this.RemoveZero(detailByID);
						detailByID.AcceptChanges();
						this.GridEX1.DataSource = detailByID;
						this.ButtonItem4.Enabled = true;
						this.dt_Keraye = this.KhordeFurushi_Keraye.GetByID(Conversions.ToInteger(byID["ID"]));
						this.LoadNahve_Furush(byID);
						this.GridEX1.Col = 1;
						this.GridEX1.MoveFirst();
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
						flag2 = (this.GridEX1.GetRow().Cells["Kala_Name"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
						if (flag2)
						{
							flag = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["kala_Name"].Value != DBNull.Value);
							if (flag)
							{
								this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
								this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
								this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
								flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
								if (flag2)
								{
									flag = (this.GridEX1.EditTextBox != null);
									if (flag)
									{
										this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
										this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
										this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
									}
								}
							}
						}
						long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
						num = (long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye"))));
						this.txt_makharej.Text = Conversions.ToString(num);
						string right = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 tarikh_fa from sud order by tarikh_fa desc"));
						flag2 = (Operators.CompareString(this.txt_tarikh.Text, right, false) <= 0);
						if (flag2)
						{
							this.txt_makharej.Enabled = false;
							this.txt_makharej.ButtonStyle = EditButtonStyle.NoButton;
							this.GridEX1.Enabled = false;
						}
						else
						{
							this.txt_makharej.Enabled = true;
							this.GridEX1.Enabled = true;
							this.txt_makharej.ButtonStyle = EditButtonStyle.TextButton;
						}
					}
				}
			}
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0017F660 File Offset: 0x0017D860
		private void txt_num_First_Click()
		{
			long navigateID = this.KhordeFurushi.GetNavigateID(KhordeFurushi.NavTo.first, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData(this.txt_tarikh.Text);
				}
			}
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0017F6C4 File Offset: 0x0017D8C4
		private void txt_num_Last_Click()
		{
			long navigateID = this.KhordeFurushi.GetNavigateID(KhordeFurushi.NavTo.last, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData(this.txt_tarikh.Text);
				}
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0017F728 File Offset: 0x0017D928
		private void txt_num_Next_Click()
		{
			long navigateID = this.KhordeFurushi.GetNavigateID(KhordeFurushi.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData(this.txt_tarikh.Text);
				}
			}
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0017F78C File Offset: 0x0017D98C
		private void txt_num_Previous_Click()
		{
			long navigateID = this.KhordeFurushi.GetNavigateID(KhordeFurushi.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
			bool flag = navigateID == 0L;
			if (!flag)
			{
				flag = (navigateID != (long)this.Num);
				if (flag)
				{
					this.Num = checked((int)navigateID);
					this.LoadData(this.txt_tarikh.Text);
				}
			}
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0017F7F0 File Offset: 0x0017D9F0
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
						this.LoadData(this.txt_tarikh.Text);
					}
				}
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00008757 File Offset: 0x00006957
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0017F878 File Offset: 0x0017DA78
		public void Check_Enable()
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID)));
			bool flag = num == 1;
			if (flag)
			{
				this.setEnable(false);
			}
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0017F8B8 File Offset: 0x0017DAB8
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
					this.MeNew();
				}
			}
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x0017F924 File Offset: 0x0017DB24
		private void GetStatusInfo()
		{
			long num = 0L;
			long num2 = 0L;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["Moshtari_ID"].Value == DBNull.Value;
					if (!flag)
					{
						flag = (gridEXRow.Cells["jam_Kol"].Value == DBNull.Value);
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["Moshtari_ID"].Value, -1, false);
							if (flag)
							{
								num = Conversions.ToLong(Operators.AddObject(num, gridEXRow.Cells["jam_Kol"].Value));
							}
							else
							{
								num2 = Conversions.ToLong(Operators.AddObject(num2, gridEXRow.Cells["jam_Kol"].Value));
							}
						}
					}
				}
				this.LabelCommand7.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num)));
				this.LabelCommand5.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(num2)));
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0017FA64 File Offset: 0x0017DC64
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
				bool flag2 = this.GridEX1.GetRow().Cells["moshtari_id"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0;
				if (flag2)
				{
					flag = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["moshtari_id"].Value != DBNull.Value);
					if (flag)
					{
						this.GridEX1.GetRow().Cells["moshtari_id"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["moshtari_id"].Value);
						this.GridEX1.GetRow().Cells["moshtari_name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["moshtari_name"].Value);
						flag2 = (this.GridEX1.GetRow(this.GridEX1.Row - 1).Cells["row_index"].Value != DBNull.Value);
						if (flag2)
						{
							this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRow(this.GridEX1.Row - 1).Cells["row_index"].Value);
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
						if (flag2)
						{
							flag = (this.GridEX1.EditTextBox != null);
							if (flag)
							{
								this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["moshtari_name"].Value);
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

		// Token: 0x06002030 RID: 8240 RVA: 0x0017FFF4 File Offset: 0x0017E1F4
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00180054 File Offset: 0x0017E254
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

		// Token: 0x06002032 RID: 8242 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00180120 File Offset: 0x0017E320
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

		// Token: 0x06002034 RID: 8244 RVA: 0x00180240 File Offset: 0x0017E440
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0018026C File Offset: 0x0017E46C
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

		// Token: 0x06002036 RID: 8246 RVA: 0x001802D0 File Offset: 0x0017E4D0
		private void ButtonItem10_Click(object sender, EventArgs e)
		{
			Frm_KhordeFurushi_Keraye frm_KhordeFurushi_Keraye = new Frm_KhordeFurushi_Keraye
			{
				dt_keraye = this.dt_Keraye
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_KhordeFurushi_Keraye);
			this.dt_Keraye = frm_KhordeFurushi_Keraye.dt_keraye;
			this.dt_Keraye.AcceptChanges();
			long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
			num = checked((long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye")))));
			this.txt_makharej.Text = Conversions.ToString(num);
			long num2 = 0L;
			long? value = this.txt_makharej.Value;
			bool? arg_CB_0;
			if (!value.HasValue)
			{
				arg_CB_0 = null;
			}
			else
			{
				bool? flag = new bool?(value.GetValueOrDefault() == num2);
				arg_CB_0 = flag;
			}
			bool? flag2 = arg_CB_0;
			bool valueOrDefault = flag2.GetValueOrDefault();
			if (valueOrDefault)
			{
				this.txt_makharej.SetNew();
			}
			this.GridEX1.Focus();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.Col = 1;
			this.GridEX1.GetRow().BeginEdit();
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0000876A File Offset: 0x0000696A
		private void txt_makharej_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem10_Click(null, null);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00180408 File Offset: 0x0017E608
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem10_Click(null, null);
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00008777 File Offset: 0x00006977
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00008782 File Offset: 0x00006982
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x0600203C RID: 8252 RVA: 0x00180430 File Offset: 0x0017E630
		public void ButtonItem14_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\ersalbar.mrt");
			DataTable dataTable = Public_Function.FillData("SELECT     sum( ErsalBar_Detail.Tedad) as Tedad, sum(ErsalBar_Detail.Vazn_Ba_Zarf) as Vazn_Ba_Zarf,sum( ErsalBar_Detail.Vazn_Kol) as Vazn_Kol,sum( ErsalBar_Detail.Jam_Kol) as Jam_Kol,max( Kala.Name ) AS kala_name   FROM         ErsalBar_Detail INNER JOIN   Kala ON ErsalBar_Detail.Kala_ID = Kala.ID   WHERE ErsalBar_Detail.ErsalBar_ID =  " + Conversions.ToString(this.ID) + "  group by kala_id");
			dataTable.Columns.Add("avg", typeof(decimal));
			Public_Function.RemoveZero(dataTable, "tedad");
			Public_Function.RemoveZero(dataTable, "vazn_ba_zarf");
			Public_Function.RemoveZero(dataTable, "vazn_kol");
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["vazn_ba_zarf"] == DBNull.Value;
					if (!flag)
					{
						flag = (dataRow["jam_kol"] == DBNull.Value);
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(dataRow["vazn_ba_zarf"], 0, false);
							if (!flag)
							{
								dataRow["avg"] = decimal.Round(Conversions.ToDecimal(Operators.DivideObject(dataRow["jam_kol"], dataRow["vazn_ba_zarf"])), 0);
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
			dataTable.TableName = "data";
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text4");
			stiText = (StiText)stiReport.GetComponentByName("Text26");
			stiText = (StiText)stiReport.GetComponentByName("Text27");
			stiText = (StiText)stiReport.GetComponentByName("Text28");
			stiText.Text = this.txt_tarikh.Text;
			stiText = (StiText)stiReport.GetComponentByName("Text33");
			stiText = (StiText)stiReport.GetComponentByName("Text34");
			stiText = (StiText)stiReport.GetComponentByName("Text35");
			stiText = (StiText)stiReport.GetComponentByName("Text36");
			stiText.Text = this.txt_makharej.Text;
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x001806C0 File Offset: 0x0017E8C0
		private void txt_sh_barname_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar.Focus();
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x001292DC File Offset: 0x001274DC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع مانده";
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x001806EC File Offset: 0x0017E8EC
		private void txt_keraye_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				bool flag2;
				if (flag)
				{
					flag2 = this.prevent_Enter;
					if (flag2)
					{
						this.prevent_Enter = false;
						return;
					}
					this.prevent_Enter = true;
					flag2 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
					if (flag2)
					{
						this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
				flag2 = (e.KeyCode == Keys.Delete);
				if (flag2)
				{
					this.txt_safi.SetNew();
				}
				flag2 = (e.KeyCode == Keys.Delete);
				if (flag2)
				{
					this.txt_keraye.SetNew();
					((DataRowView)this.GridEX1.CurrentRow.DataRow)["Keraye"] = DBNull.Value;
				}
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x001807FC File Offset: 0x0017E9FC
		private void txt_safi_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				bool flag2;
				if (flag)
				{
					flag2 = this.prevent_Enter;
					if (flag2)
					{
						this.prevent_Enter = false;
						return;
					}
					flag2 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
					if (flag2)
					{
						this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
				flag2 = (e.KeyCode == Keys.Delete);
				if (flag2)
				{
					this.txt_safi.SetNew();
					((DataRowView)this.GridEX1.CurrentRow.DataRow)["mablagh_safi"] = DBNull.Value;
				}
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x001808E8 File Offset: 0x0017EAE8
		private void txt_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_makharej.Focus();
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0000878D File Offset: 0x0000698D
		private void txt_tarikh_Validated(object sender, EventArgs e)
		{
			this.LoadData(this.txt_tarikh.Text);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0000205D File Offset: 0x0000025D
		private void txt_makharej_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00180914 File Offset: 0x0017EB14
		private void ButtonItem20_Click(object sender, EventArgs e)
		{
			object[] parameters = new object[]
			{
				this.txt_tarikh.Text
			};
			Public_Function.InvokeMethod("frm_daryaftpardakht", "ShowFurushRuzane", parameters);
		}

		// Token: 0x04000C40 RID: 3136
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000C42 RID: 3138
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000C43 RID: 3139
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000C44 RID: 3140
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000C45 RID: 3141
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000C46 RID: 3142
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04000C47 RID: 3143
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000C48 RID: 3144
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000C49 RID: 3145
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000C4A RID: 3146
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000C4B RID: 3147
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000C4C RID: 3148
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000C4D RID: 3149
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000C4E RID: 3150
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000C4F RID: 3151
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000C50 RID: 3152
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000C51 RID: 3153
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000C52 RID: 3154
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000C53 RID: 3155
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000C54 RID: 3156
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000C55 RID: 3157
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000C56 RID: 3158
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000C57 RID: 3159
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000C58 RID: 3160
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000C59 RID: 3161
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000C5A RID: 3162
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000C5B RID: 3163
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000C5C RID: 3164
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000C5D RID: 3165
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000C5E RID: 3166
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000C5F RID: 3167
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000C60 RID: 3168
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000C61 RID: 3169
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000C62 RID: 3170
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000C63 RID: 3171
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000C64 RID: 3172
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000C65 RID: 3173
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000C66 RID: 3174
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000C67 RID: 3175
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000C68 RID: 3176
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000C69 RID: 3177
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000C6A RID: 3178
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000C6B RID: 3179
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000C6C RID: 3180
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000C6D RID: 3181
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000C6E RID: 3182
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000C6F RID: 3183
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000C70 RID: 3184
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000C71 RID: 3185
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000C72 RID: 3186
		[AccessedThroughProperty("txt_keraye")]
		private CurrencyBox _txt_keraye;

		// Token: 0x04000C73 RID: 3187
		[AccessedThroughProperty("txt_safi")]
		private CurrencyBox _txt_safi;

		// Token: 0x04000C74 RID: 3188
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000C75 RID: 3189
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000C76 RID: 3190
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000C77 RID: 3191
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000C78 RID: 3192
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000C79 RID: 3193
		[AccessedThroughProperty("ButtonItem20")]
		private ButtonItem _ButtonItem20;

		// Token: 0x04000C7A RID: 3194
		private KhordeFurushi KhordeFurushi;

		// Token: 0x04000C7B RID: 3195
		private KhordeFurushi_Keraye KhordeFurushi_Keraye;

		// Token: 0x04000C7C RID: 3196
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000C7D RID: 3197
		private DataTable dt_Keraye;

		// Token: 0x04000C7E RID: 3198
		private Frm_SelectItem frm;

		// Token: 0x04000C7F RID: 3199
		private Sanad sanad;

		// Token: 0x04000C80 RID: 3200
		private Sandugh Sandug;

		// Token: 0x04000C81 RID: 3201
		private Base_User_Control user;

		// Token: 0x04000C82 RID: 3202
		private int ID;

		// Token: 0x04000C83 RID: 3203
		public int Num;

		// Token: 0x04000C84 RID: 3204
		public int GotoLineID;

		// Token: 0x04000C85 RID: 3205
		private bool prevent_close;

		// Token: 0x04000C86 RID: 3206
		private bool prevent_right;

		// Token: 0x04000C87 RID: 3207
		private bool prevent_left;

		// Token: 0x04000C88 RID: 3208
		private bool prevent_Enter;

		// Token: 0x04000C89 RID: 3209
		[CompilerGenerated]
		private bool _Show_Preview;

		// Token: 0x04000C8A RID: 3210
		[CompilerGenerated]
		private string _tarikh;
	}
}
