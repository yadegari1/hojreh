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
	// Token: 0x020000ED RID: 237
	[DesignerGenerated]
	public partial class Frm_Ersal_Bar : Form
	{
		// Token: 0x0600191A RID: 6426 RVA: 0x0011A5A4 File Offset: 0x001187A4
		public Frm_Ersal_Bar()
		{
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frm_Frush_hag_KeyDown);
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			Frm_Ersal_Bar.__ENCAddToList(this);
			this.Ersal_Bar = new Ersal_Bar();
			this.RizBar = new Furush_Hag_RizBar();
			this.ErsalBar_Keraye = new ErsalBar_Keraye();
			this.Moshtari_Info = new Moshtari_Info();
			this.kala_to_kala = new Kala_To_Kala_Furush();
			this.frm = new Frm_SelectItem();
			this.sanad = new Sanad();
			this.Sandug = new Sandugh();
			this.user = new Base_User_Control();
			this.ID = -1;
			this.Num = -1;
			this.GotoLineID = -1;
			this.Isnew = true;
			this.prevent_right = false;
			this.prevent_left = false;
			this.prevent_Enter = false;
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			this.InitializeComponent();
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0011A6B8 File Offset: 0x001188B8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Ersal_Bar.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Ersal_Bar.__ENCList.Count == Frm_Ersal_Bar.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Ersal_Bar.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Ersal_Bar.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Ersal_Bar.__ENCList[num] = Frm_Ersal_Bar.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Ersal_Bar.__ENCList.RemoveRange(num, Frm_Ersal_Bar.__ENCList.Count - num);
						Frm_Ersal_Bar.__ENCList.Capacity = Frm_Ersal_Bar.__ENCList.Count;
					}
					Frm_Ersal_Bar.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0011E060 File Offset: 0x0011C260
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00007647 File Offset: 0x00005847
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

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0011E078 File Offset: 0x0011C278
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x00007651 File Offset: 0x00005851
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0011E090 File Offset: 0x0011C290
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0000765B File Offset: 0x0000585B
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

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0011E0A8 File Offset: 0x0011C2A8
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00007665 File Offset: 0x00005865
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0011E0C0 File Offset: 0x0011C2C0
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0000766F File Offset: 0x0000586F
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0011E0D8 File Offset: 0x0011C2D8
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x00007679 File Offset: 0x00005879
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0011E0F0 File Offset: 0x0011C2F0
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00007683 File Offset: 0x00005883
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0011E108 File Offset: 0x0011C308
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0000768D File Offset: 0x0000588D
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

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0011E120 File Offset: 0x0011C320
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00007697 File Offset: 0x00005897
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0011E138 File Offset: 0x0011C338
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0011E150 File Offset: 0x0011C350
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0011E284 File Offset: 0x0011C484
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0011E29C File Offset: 0x0011C49C
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

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0011E2FC File Offset: 0x0011C4FC
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x000076A1 File Offset: 0x000058A1
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

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0011E314 File Offset: 0x0011C514
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x000076AB File Offset: 0x000058AB
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

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0011E32C File Offset: 0x0011C52C
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0011E344 File Offset: 0x0011C544
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

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0011E3A4 File Offset: 0x0011C5A4
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x000076B5 File Offset: 0x000058B5
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

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0011E3BC File Offset: 0x0011C5BC
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0011E3D4 File Offset: 0x0011C5D4
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
				EndCustomEditEventHandler value2 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				RowLoadEventHandler value4 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				KeyEventHandler value6 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value8 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value9 = new EventHandler(this.GridEX1_SelectionChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.EndCustomEdit -= value2;
					this._GridEX1.ColumnButtonClick -= value3;
					this._GridEX1.LoadingRow -= value4;
					this._GridEX1.KeyPress -= value5;
					this._GridEX1.KeyDown -= value6;
					this._GridEX1.CellEdited -= value7;
					this._GridEX1.InitCustomEdit -= value8;
					this._GridEX1.SelectionChanged -= value9;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.EndCustomEdit += value2;
					this._GridEX1.ColumnButtonClick += value3;
					this._GridEX1.LoadingRow += value4;
					this._GridEX1.KeyPress += value5;
					this._GridEX1.KeyDown += value6;
					this._GridEX1.CellEdited += value7;
					this._GridEX1.InitCustomEdit += value8;
					this._GridEX1.SelectionChanged += value9;
				}
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0011E55C File Offset: 0x0011C75C
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x000076BF File Offset: 0x000058BF
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0011E574 File Offset: 0x0011C774
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x0011E58C File Offset: 0x0011C78C
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

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x0011E5EC File Offset: 0x0011C7EC
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x0011E604 File Offset: 0x0011C804
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x0011E664 File Offset: 0x0011C864
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x0011E67C File Offset: 0x0011C87C
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x0011E6DC File Offset: 0x0011C8DC
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x0011E6F4 File Offset: 0x0011C8F4
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x0011E754 File Offset: 0x0011C954
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x0011E76C File Offset: 0x0011C96C
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

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x0011E7CC File Offset: 0x0011C9CC
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x000076C9 File Offset: 0x000058C9
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

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x0011E7E4 File Offset: 0x0011C9E4
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x000076D3 File Offset: 0x000058D3
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

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x0011E7FC File Offset: 0x0011C9FC
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x0011E814 File Offset: 0x0011CA14
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

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x0011E874 File Offset: 0x0011CA74
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0011E88C File Offset: 0x0011CA8C
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

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0011E8EC File Offset: 0x0011CAEC
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x000076DD File Offset: 0x000058DD
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

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x0011E904 File Offset: 0x0011CB04
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x000076E7 File Offset: 0x000058E7
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

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x0011E91C File Offset: 0x0011CB1C
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0011E934 File Offset: 0x0011CB34
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

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x0011E994 File Offset: 0x0011CB94
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x0011E9AC File Offset: 0x0011CBAC
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

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x0011EA0C File Offset: 0x0011CC0C
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x000076F1 File Offset: 0x000058F1
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

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0011EA24 File Offset: 0x0011CC24
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x000076FB File Offset: 0x000058FB
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

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0011EA3C File Offset: 0x0011CC3C
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00007705 File Offset: 0x00005905
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

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0011EA54 File Offset: 0x0011CC54
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000770F File Offset: 0x0000590F
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x0011EA6C File Offset: 0x0011CC6C
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00007719 File Offset: 0x00005919
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

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0011EA84 File Offset: 0x0011CC84
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00007723 File Offset: 0x00005923
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

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0011EA9C File Offset: 0x0011CC9C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000772D File Offset: 0x0000592D
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

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0011EAB4 File Offset: 0x0011CCB4
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00007737 File Offset: 0x00005937
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

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0011EACC File Offset: 0x0011CCCC
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00007741 File Offset: 0x00005941
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

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0011EAE4 File Offset: 0x0011CCE4
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000774B File Offset: 0x0000594B
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0011EAFC File Offset: 0x0011CCFC
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x00007755 File Offset: 0x00005955
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

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x0011EB14 File Offset: 0x0011CD14
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0011EB2C File Offset: 0x0011CD2C
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

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x0011EB8C File Offset: 0x0011CD8C
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x0011EBA4 File Offset: 0x0011CDA4
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

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0011EC04 File Offset: 0x0011CE04
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0011EC1C File Offset: 0x0011CE1C
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0011ECA4 File Offset: 0x0011CEA4
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x0000775F File Offset: 0x0000595F
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0011ECBC File Offset: 0x0011CEBC
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x00007769 File Offset: 0x00005969
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0011ECD4 File Offset: 0x0011CED4
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x00007773 File Offset: 0x00005973
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x0011ECEC File Offset: 0x0011CEEC
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0000777D File Offset: 0x0000597D
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0011ED04 File Offset: 0x0011CF04
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x00007787 File Offset: 0x00005987
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0011ED1C File Offset: 0x0011CF1C
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x00007791 File Offset: 0x00005991
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0011ED34 File Offset: 0x0011CF34
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000779B File Offset: 0x0000599B
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x0011ED4C File Offset: 0x0011CF4C
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x000077A5 File Offset: 0x000059A5
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

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x0011ED64 File Offset: 0x0011CF64
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x000077AF File Offset: 0x000059AF
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

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0011ED7C File Offset: 0x0011CF7C
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x000077B9 File Offset: 0x000059B9
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

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x0011ED94 File Offset: 0x0011CF94
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x000077C3 File Offset: 0x000059C3
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x0011EDAC File Offset: 0x0011CFAC
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0011EDC4 File Offset: 0x0011CFC4
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

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x0011EE24 File Offset: 0x0011D024
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x0011EE3C File Offset: 0x0011D03C
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x0011EEC4 File Offset: 0x0011D0C4
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x000077CD File Offset: 0x000059CD
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

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x0011EEDC File Offset: 0x0011D0DC
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x0011EEF4 File Offset: 0x0011D0F4
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x0011EF7C File Offset: 0x0011D17C
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x000077D7 File Offset: 0x000059D7
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0011EF94 File Offset: 0x0011D194
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x0011EFAC File Offset: 0x0011D1AC
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x0011F00C File Offset: 0x0011D20C
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x0011F024 File Offset: 0x0011D224
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x0011F084 File Offset: 0x0011D284
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0011F09C File Offset: 0x0011D29C
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0011F0FC File Offset: 0x0011D2FC
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x0011F114 File Offset: 0x0011D314
		internal virtual CurrencyBox txt_safikol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_safikol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_safikol_TextChanged);
				bool flag = this._txt_safikol != null;
				if (flag)
				{
					this._txt_safikol.TextChanged -= value2;
				}
				this._txt_safikol = value;
				flag = (this._txt_safikol != null);
				if (flag)
				{
					this._txt_safikol.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0011F174 File Offset: 0x0011D374
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x000077E1 File Offset: 0x000059E1
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

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0011F18C File Offset: 0x0011D38C
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
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

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0011F204 File Offset: 0x0011D404
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0011F21C File Offset: 0x0011D41C
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

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0011F27C File Offset: 0x0011D47C
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x000077EB File Offset: 0x000059EB
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

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0011F294 File Offset: 0x0011D494
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x000077F5 File Offset: 0x000059F5
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

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0011F2AC File Offset: 0x0011D4AC
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x000077FF File Offset: 0x000059FF
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

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0011F2C4 File Offset: 0x0011D4C4
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x00007809 File Offset: 0x00005A09
		internal virtual CurrencyBox txt_keraye_mabda
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_keraye_mabda;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_keraye_mabda = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0011F2DC File Offset: 0x0011D4DC
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x00007813 File Offset: 0x00005A13
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

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0011F2F4 File Offset: 0x0011D4F4
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0011F30C File Offset: 0x0011D50C
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

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0011F36C File Offset: 0x0011D56C
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0011F384 File Offset: 0x0011D584
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

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x0011F3E4 File Offset: 0x0011D5E4
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0011F3FC File Offset: 0x0011D5FC
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

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0011F45C File Offset: 0x0011D65C
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0011F474 File Offset: 0x0011D674
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

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0011F4D4 File Offset: 0x0011D6D4
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0000781D File Offset: 0x00005A1D
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

		// Token: 0x060019B8 RID: 6584 RVA: 0x0011F4EC File Offset: 0x0011D6EC
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

		// Token: 0x060019B9 RID: 6585 RVA: 0x0011F590 File Offset: 0x0011D790
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0011F5E4 File Offset: 0x0011D7E4
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0011F620 File Offset: 0x0011D820
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

		// Token: 0x060019BC RID: 6588 RVA: 0x0011F6B4 File Offset: 0x0011D8B4
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

		// Token: 0x060019BD RID: 6589 RVA: 0x0011F92C File Offset: 0x0011DB2C
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

		// Token: 0x060019BE RID: 6590 RVA: 0x0011FA04 File Offset: 0x0011DC04
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

		// Token: 0x060019BF RID: 6591 RVA: 0x0011FAA8 File Offset: 0x0011DCA8
		private void frm_Frush_hag_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Code", "کد", 15));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.frm.items = itemCollection;
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
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
					this.txt_safikol.TabIndex = 0;
					this.txt_num.TabIndex = 10;
					this.txt_safikol.TabStop = true;
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

		// Token: 0x060019C0 RID: 6592 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x060019C1 RID: 6593 RVA: 0x0011FDFC File Offset: 0x0011DFFC
		private void Moshtari_Select()
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
					this.frm.Text = "انتخاب فروشنده";
					this.frm.CanEdit = true;
					this.frm.CanDelete = false;
					this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
					string text = string.Empty;
					flag = (Operators.CompareString(text, string.Empty, false) == 0);
					if (flag)
					{
						text = " where moshtari.id not in (-4,-1,1,-2,-3,-6)";
					}
					else
					{
						text += ",-1,-4,1,-2,-3,-6)";
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

		// Token: 0x060019C2 RID: 6594 RVA: 0x0011FFF4 File Offset: 0x0011E1F4
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

		// Token: 0x060019C3 RID: 6595 RVA: 0x001200F8 File Offset: 0x0011E2F8
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

		// Token: 0x060019C4 RID: 6596 RVA: 0x0012037C File Offset: 0x0011E57C
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

		// Token: 0x060019C5 RID: 6597 RVA: 0x001204A4 File Offset: 0x0011E6A4
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

		// Token: 0x060019C6 RID: 6598 RVA: 0x00120580 File Offset: 0x0011E780
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

		// Token: 0x060019C7 RID: 6599 RVA: 0x00120634 File Offset: 0x0011E834
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

		// Token: 0x060019C8 RID: 6600 RVA: 0x001206FC File Offset: 0x0011E8FC
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

		// Token: 0x060019C9 RID: 6601 RVA: 0x00120B2C File Offset: 0x0011ED2C
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

		// Token: 0x060019CA RID: 6602 RVA: 0x00120F28 File Offset: 0x0011F128
		private void Kala_select()
		{
			this.frm.CanEdit = true;
			string command = "SELECT     Kala.ID, Kala.Name  FROM      Kala ";
			bool flag = this.GridEX1.CurrentRow.Cells["prekala_id"].Value != DBNull.Value;
			int? num;
			if (flag)
			{
				object expr_62 = this.GridEX1.CurrentRow.Cells["prekala_id"].Value;
				int? num2;
				num = ((expr_62 != null) ? ((int?)expr_62) : num2);
			}
			this.frm.Edit_Frm = MyProject.Forms.Frm_Kala;
			flag = (this.frm.ShowDialog(command, MyProject.Forms.Frm_Kala, 0) == DialogResult.OK);
			checked
			{
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
									flag2 = (frm_Select_Kala_To_Kala.ShowDialog() == DialogResult.OK);
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
													DataRow[] arg_4E8_0 = array2;
													int num4 = 0;
													DataRow arg_522_0 = arg_4E8_0[num4];
													string columnName = "tedad";
													arg_522_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
												}
											}
											flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
											if (flag3)
											{
												flag2 = (array[0]["vazn"] != DBNull.Value);
												if (flag2)
												{
													DataRow[] array2 = array;
													DataRow[] arg_582_0 = array2;
													int num4 = 0;
													DataRow arg_5BC_0 = arg_582_0[num4];
													string columnName = "vazn";
													arg_5BC_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
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
													DataRow arg_99F_0 = dataRow4;
													string columnName = "tedad";
													arg_99F_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow dataRow4 = this.dt_rizbar.Rows[num6];
													DataRow arg_A21_0 = dataRow4;
													string columnName = "vazn";
													arg_A21_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
												}
												DataRow[] array3 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
												flag3 = (array3.Length > 0);
												if (flag3)
												{
													flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array3;
														DataRow[] arg_AA1_0 = array2;
														int num4 = 0;
														DataRow arg_ADB_0 = arg_AA1_0[num4];
														string columnName = "tedad";
														arg_ADB_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow[] array2 = array3;
														DataRow[] arg_B1C_0 = array2;
														int num4 = 0;
														DataRow arg_B56_0 = arg_B1C_0[num4];
														string columnName = "vazn";
														arg_B56_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
											DataRow arg_C3D_0 = dataRow4;
											string columnName = "tedad";
											arg_C3D_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
										}
										flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
										if (flag3)
										{
											DataRow dataRow4 = this.dt_rizbar.Rows[num5];
											DataRow arg_CBF_0 = dataRow4;
											string columnName = "vazn";
											arg_CBF_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
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
													DataRow arg_D77_0 = dataRow4;
													string columnName = "tedad";
													arg_D77_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow dataRow4 = this.dt_rizbar.Rows[num7];
													DataRow arg_DF9_0 = dataRow4;
													string columnName = "vazn";
													arg_DF9_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
												}
												DataRow[] array4 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
												flag3 = (array4.Length > 0);
												if (flag3)
												{
													flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array4;
														DataRow[] arg_E79_0 = array2;
														int num4 = 0;
														DataRow arg_EB3_0 = arg_E79_0[num4];
														string columnName = "tedad";
														arg_EB3_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow[] array2 = array4;
														DataRow[] arg_EF4_0 = array2;
														int num4 = 0;
														DataRow arg_F2E_0 = arg_EF4_0[num4];
														string columnName = "vazn";
														arg_F2E_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
											DataRow arg_101D_0 = dataRow4;
											string columnName = "tedad";
											arg_101D_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
										}
										flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
										if (flag3)
										{
											DataRow dataRow4 = this.dt_rizbar.Rows[num8];
											DataRow arg_109F_0 = dataRow4;
											string columnName = "vazn";
											arg_109F_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
										}
										DataRow[] array5 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.frm.SelectedRow["ID"])));
										flag3 = (array5.Length > 0);
										if (flag3)
										{
											flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
											if (flag2)
											{
												DataRow[] array2 = array5;
												DataRow[] arg_1121_0 = array2;
												int num4 = 0;
												DataRow arg_115B_0 = arg_1121_0[num4];
												string columnName = "tedad";
												arg_115B_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
											flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
											if (flag3)
											{
												DataRow[] array2 = array5;
												DataRow[] arg_119C_0 = array2;
												int num4 = 0;
												DataRow arg_11D6_0 = arg_119C_0[num4];
												string columnName = "vazn";
												arg_11D6_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
											DataRow arg_131B_0 = dataRow4;
											string columnName = "tedad";
											arg_131B_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
										}
									}
									flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
									if (flag3)
									{
										flag2 = Operators.ConditionalCompareObjectNotEqual(this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]["vazn"], 0, false);
										if (flag2)
										{
											DataRow dataRow4 = this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
											DataRow arg_1413_0 = dataRow4;
											string columnName = "vazn";
											arg_1413_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
												DataRow[] arg_14A4_0 = array2;
												int num4 = 0;
												DataRow arg_14DE_0 = arg_14A4_0[num4];
												string columnName = "tedad";
												arg_14DE_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
											flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
											if (flag3)
											{
												DataRow[] array2 = array6;
												DataRow[] arg_151F_0 = array2;
												int num4 = 0;
												DataRow arg_1559_0 = arg_151F_0[num4];
												string columnName = "vazn";
												arg_1559_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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

		// Token: 0x060019CB RID: 6603 RVA: 0x00122548 File Offset: 0x00120748
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

		// Token: 0x060019CC RID: 6604 RVA: 0x00122718 File Offset: 0x00120918
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

		// Token: 0x060019CD RID: 6605 RVA: 0x00122828 File Offset: 0x00120A28
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

		// Token: 0x060019CE RID: 6606 RVA: 0x00122BF0 File Offset: 0x00120DF0
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

		// Token: 0x060019CF RID: 6607 RVA: 0x00122EE8 File Offset: 0x001210E8
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

		// Token: 0x060019D0 RID: 6608 RVA: 0x00122FEC File Offset: 0x001211EC
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "kala_name", false) == 0;
			if (flag)
			{
				this.SyncTedad();
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
										this.GetDaramad();
										this.GetSud(null);
									}
									else
									{
										flag2 = (Operators.CompareString(left, "keraye", false) == 0);
										if (flag2)
										{
											long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
											num = checked((long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye")))));
											this.txt_makharej.Text = Conversions.ToString(num);
											this.GetDaramad();
											this.GetSud(null);
										}
										else
										{
											flag2 = (Operators.CompareString(left, "mablagh_safi", false) == 0);
											if (flag2)
											{
												this.GetSud(null);
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

		// Token: 0x060019D1 RID: 6609 RVA: 0x00123660 File Offset: 0x00121860
		private void GetSud(GridEXRow Row = null)
		{
			bool flag = Row == null;
			if (flag)
			{
				Row = this.GridEX1.CurrentRow;
			}
			flag = (Row.Cells["Mablagh_safi"].Value != DBNull.Value);
			if (flag)
			{
				bool flag2 = Row.Cells["jam_kol"].Value != DBNull.Value;
				if (flag2)
				{
					long num = Conversions.ToLong(Row.Cells["Mablagh_safi"].Value);
					num = Conversions.ToLong(Operators.SubtractObject(num, Row.Cells["jam_kol"].Value));
					flag2 = (Row.Cells["keraye"].Value != DBNull.Value);
					if (flag2)
					{
						num = Conversions.ToLong(Operators.SubtractObject(num, Row.Cells["keraye"].Value));
					}
					Row.BeginEdit();
					Row.Cells["sud"].Value = num;
					Row.EndEdit();
				}
				else
				{
					Row.BeginEdit();
					Row.Cells["sud"].Value = null;
					Row.EndEdit();
				}
			}
			else
			{
				Row.BeginEdit();
				Row.Cells["sud"].Value = null;
				Row.EndEdit();
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x001237DC File Offset: 0x001219DC
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
							this.Ersal_Bar.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
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
							this.Ersal_Bar.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
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

		// Token: 0x060019D3 RID: 6611 RVA: 0x00123CE4 File Offset: 0x00121EE4
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

		// Token: 0x060019D4 RID: 6612 RVA: 0x00123D90 File Offset: 0x00121F90
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

		// Token: 0x060019D5 RID: 6613 RVA: 0x00123F28 File Offset: 0x00122128
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

		// Token: 0x060019D6 RID: 6614 RVA: 0x001240CC File Offset: 0x001222CC
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

		// Token: 0x060019D7 RID: 6615 RVA: 0x00124144 File Offset: 0x00122344
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
											flag4 = (col == this.GridEX1.RootTable.Columns["Mablagh_safi"].Position);
											if (!flag4)
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

		// Token: 0x060019D8 RID: 6616 RVA: 0x0012472C File Offset: 0x0012292C
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

		// Token: 0x060019D9 RID: 6617 RVA: 0x00124770 File Offset: 0x00122970
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

		// Token: 0x060019DA RID: 6618 RVA: 0x00007827 File Offset: 0x00005A27
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x001247C0 File Offset: 0x001229C0
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

		// Token: 0x060019DC RID: 6620 RVA: 0x00124880 File Offset: 0x00122A80
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

		// Token: 0x060019DD RID: 6621 RVA: 0x00124940 File Offset: 0x00122B40
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

		// Token: 0x060019DE RID: 6622 RVA: 0x00124A00 File Offset: 0x00122C00
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

		// Token: 0x060019DF RID: 6623 RVA: 0x00124AC0 File Offset: 0x00122CC0
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

		// Token: 0x060019E0 RID: 6624 RVA: 0x00124BA0 File Offset: 0x00122DA0
		private void MeNew()
		{
			this.Load_Default_Nahve_Furush();
			this.Isnew = true;
			this.ID = -1;
			Public_Function.SetNew(this.UiGroupBox1);
			this.setEnable(true);
			DataTable detailByID = this.Ersal_Bar.GetDetailByID(-1L);
			this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID(-1L);
			bool flag = this.dt_rizbar != null;
			if (flag)
			{
				this.dt_rizbar.Clear();
			}
			this.dt_rizbar = this.RizBar.GetByID(-1);
			detailByID.Columns["Fee"].AllowDBNull = true;
			this.GridEX1.DataSource = detailByID;
			this.Num = checked((int)this.Ersal_Bar.GetNewID());
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_num.Focus();
			this.dt_Keraye = null;
			this.Grid_RizBar.DataSource = null;
			this.Grid_RizBar.Visible = false;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00124CA4 File Offset: 0x00122EA4
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

		// Token: 0x060019E2 RID: 6626 RVA: 0x00124D64 File Offset: 0x00122F64
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

		// Token: 0x060019E3 RID: 6627 RVA: 0x001251F4 File Offset: 0x001233F4
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

		// Token: 0x060019E4 RID: 6628 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x060019E5 RID: 6629 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x060019E6 RID: 6630 RVA: 0x001254B0 File Offset: 0x001236B0
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
						IEnumerator enumerator2 = this.dt_rizbar.Rows.GetEnumerator();
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
											bool flag3 = Operators.ConditionalCompareObjectGreater(current.Tedad, dataRow2["Tedad"], false);
											if (flag3)
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
									bool flag3 = Operators.ConditionalCompareObjectEqual(current2.kala_id, dataRow2["kala_id"], false);
									if (flag3)
									{
										bool flag2 = dataRow2["vazn"] != DBNull.Value;
										if (flag2)
										{
											flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["vazn"], 0, false);
											if (flag)
											{
												flag4 = Operators.ConditionalCompareObjectGreater(current2.Tedad, dataRow2["vazn"], false);
												if (flag4)
												{
													dataTable2.Rows.Add(new object[]
													{
														RuntimeHelpers.GetObjectValue(dataRow2["kala_name"]),
														RuntimeHelpers.GetObjectValue(dataRow2["vazn"]),
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
				}
			}
			return result;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00125A84 File Offset: 0x00123C84
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

		// Token: 0x060019E8 RID: 6632 RVA: 0x00125C70 File Offset: 0x00123E70
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00125CE4 File Offset: 0x00123EE4
		private void GetDaramad()
		{
			bool hasValue = this.txt_safikol.Value.HasValue;
			checked
			{
				if (hasValue)
				{
					long num = (T)this.txt_safikol.Value;
					num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(Public_Function.GetSum(this.dt_Keraye, "Keraye"))));
					num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye"))));
					num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "jam_kol"))));
					this.txt_daramad.Text = Conversions.ToString(num);
				}
				else
				{
					this.txt_daramad.SetNew();
				}
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00125DB4 File Offset: 0x00123FB4
		private void UpdateDaramad(string id, string num, string Safi_kol, DataTable dt_kharid, DataTable dt_keraye)
		{
			string text = Public_Function.ExecuteScalar("select daramad_sanad_id from ersalBar where id=" + id).ToString();
			string text2 = string.Empty;
			bool flag = Operators.CompareString(Safi_kol, string.Empty, false) != 0;
			checked
			{
				if (flag)
				{
					long num2 = Conversions.ToLong(Safi_kol);
					num2 = (long)Math.Round(unchecked((double)num2 - Conversions.ToDouble(Public_Function.GetSum(dt_kharid, "keraye"))));
					num2 = (long)Math.Round(unchecked((double)num2 - Conversions.ToDouble(Public_Function.GetSum(dt_keraye, "keraye"))));
					num2 = (long)Math.Round(unchecked((double)num2 - Conversions.ToDouble(Public_Function.GetSum(dt_kharid, "jam_kol"))));
					Sanad sanad = new Sanad();
					flag = (Operators.CompareString(text, string.Empty, false) == 0);
					if (flag)
					{
						text2 += "declare @sanad_id bigint;";
						text2 += sanad.InsertStr("13", "0", num2.ToString(), this.txt_tarikh_vurud.Text, "درآمد ارسال بار سند " + num, "@sanad_id", Sanad.SanadType.@null);
						text2 = text2 + " update ersalbar set daramad_sanad_id=@sanad_id where id=" + id;
					}
					else
					{
						text2 += sanad.UpdateStr("13", "0", Conversions.ToString(num2), this.txt_tarikh_vurud.Text, "درآمد ارسال بار سند " + num, text, Sanad.SanadType.@null);
					}
				}
				else
				{
					flag = (Operators.CompareString(text, string.Empty, false) != 0);
					if (flag)
					{
						this.sanad.Delete(text);
						text2 = text2 + " update ersalbar set daramad_sanad_id=null where id=" + id;
					}
				}
				flag = (Operators.CompareString(text2, string.Empty, false) != 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text2);
				}
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00125F50 File Offset: 0x00124150
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

		// Token: 0x060019EC RID: 6636 RVA: 0x00125FB4 File Offset: 0x001241B4
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
								string nahve_furush = Conversions.ToString(this.GetNahve_Furush());
								flag = this.Isnew;
								if (flag)
								{
									this.ID = checked((int)this.Ersal_Bar.Insert(this.txt_num.Value.ToString(), this.txt_moshtari.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, this.txt_safikol.Value.ToString(), this.txt_keraye_mabda.Value.ToString(), nahve_furush, (DataTable)this.GridEX1.DataSource));
									this.ErsalBar_Keraye.Update(this.ID, this.dt_Keraye);
									this.UpdateDaramad(Conversions.ToString(this.ID), this.txt_num.Value, this.txt_safikol.Value.ToString(), (DataTable)this.GridEX1.DataSource, this.dt_Keraye);
									DataTable detailByID = this.Ersal_Bar.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.ErsalBar_Keraye.GetByID(this.ID);
									this.Adddt(this.dt_Keraye);
									this.Prepare_furush_detail(detailByID);
									this.RemoveZero(detailByID);
									this.GridEX1.DataSource = detailByID;
									this.Isnew = false;
								}
								else
								{
									this.ErsalBar_Keraye.Update(this.ID, this.dt_Keraye);
									this.Ersal_Bar.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), this.txt_moshtari.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, this.txt_safikol.Value.ToString(), this.txt_keraye_mabda.Value.ToString(), Conversions.ToString(this.GetNahve_Furush()), (DataTable)this.GridEX1.DataSource);
									this.UpdateDaramad(Conversions.ToString(this.ID), this.txt_num.Value, this.txt_safikol.Value.ToString(), (DataTable)this.GridEX1.DataSource, this.dt_Keraye);
									DataTable detailByID2 = this.Ersal_Bar.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.ErsalBar_Keraye.GetByID(this.ID);
									this.Adddt(this.dt_Keraye);
									this.Prepare_furush_detail(detailByID2);
									this.RemoveZero(detailByID2);
									this.GridEX1.DataSource = detailByID2;
								}
								flag = !Silent;
								if (flag)
								{
									Public_Function.ConfirmInsert();
									this.MeNew();
								}
								this.SyncSandug();
								result = true;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00126444 File Offset: 0x00124644
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

		// Token: 0x060019EE RID: 6638 RVA: 0x0012648C File Offset: 0x0012468C
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
						GridEXRow currentRow = this.GridEX1.CurrentRow;
						flag2 = (currentRow.RowType == RowType.NewRecord);
						if (flag2)
						{
							flag = (currentRow.Cells["kala_id"].Value != DBNull.Value);
							if (flag)
							{
								bool flag3 = currentRow.Cells["tedad"].Value != DBNull.Value;
								bool flag4;
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
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								bool flag4 = dataRow["tedad"] != DBNull.Value;
								if (flag4)
								{
									try
									{
										List<tedads>.Enumerator enumerator2 = list.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											tedads current = enumerator2.Current;
											bool flag3 = Operators.ConditionalCompareObjectEqual(current.kala_id, dataRow["kala_id"], false);
											if (flag3)
											{
												DataRow dataRow2 = dataRow;
												DataRow arg_4AC_0 = dataRow2;
												string columnName = "tedad";
												arg_4AC_0[columnName] = Operators.SubtractObject(dataRow2[columnName], current.Tedad);
											}
										}
									}
									finally
									{
										List<tedads>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
								flag4 = (dataRow["vazn"] != DBNull.Value);
								if (flag4)
								{
									try
									{
										List<tedads>.Enumerator enumerator3 = list2.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											tedads current2 = enumerator3.Current;
											bool flag3 = Operators.ConditionalCompareObjectEqual(current2.kala_id, dataRow["kala_id"], false);
											if (flag3)
											{
												flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["vazn"], 0, false);
												if (flag2)
												{
													DataRow dataRow2 = dataRow;
													DataRow arg_573_0 = dataRow2;
													string columnName = "vazn";
													arg_573_0[columnName] = Operators.SubtractObject(dataRow2[columnName], current2.Tedad);
												}
											}
										}
									}
									finally
									{
										List<tedads>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							bool flag4 = enumerator is IDisposable;
							if (flag4)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						this.Grid_RizBar.DataSource = dataTable;
						this.RemoveZeroVazn();
					}
				}
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00126AD0 File Offset: 0x00124CD0
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

		// Token: 0x060019F0 RID: 6640 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00126C1C File Offset: 0x00124E1C
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
			flag = (dr["mablaghsafi"] != DBNull.Value);
			if (flag)
			{
				this.txt_safikol.Text = Conversions.ToString(dr["mablaghsafi"]);
			}
			else
			{
				this.txt_safikol.SetNew();
			}
			flag = (dr["Keraye_Mabda"] != DBNull.Value);
			if (flag)
			{
				this.txt_keraye_mabda.Text = Conversions.ToString(dr["Keraye_Mabda"]);
			}
			else
			{
				this.txt_keraye_mabda.SetNew();
			}
			this.txt_tedad.Text = dr["Tedad_Kol"].ToString().Replace(".0", "");
			this.dt_Keraye = this.ErsalBar_Keraye.GetByID(this.ID);
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
			long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
			num = checked((long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye")))));
			this.txt_makharej.Text = Conversions.ToString(num);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00126F38 File Offset: 0x00125138
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

		// Token: 0x060019F3 RID: 6643 RVA: 0x001270C4 File Offset: 0x001252C4
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

		// Token: 0x060019F4 RID: 6644 RVA: 0x00127240 File Offset: 0x00125440
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

		// Token: 0x060019F5 RID: 6645 RVA: 0x00127348 File Offset: 0x00125548
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

		// Token: 0x060019F6 RID: 6646 RVA: 0x0012746C File Offset: 0x0012566C
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

		// Token: 0x060019F7 RID: 6647 RVA: 0x00127578 File Offset: 0x00125778
		private void LoadData()
		{
			DataRow byID = this.Ersal_Bar.GetByID((long)this.Num);
			bool flag = byID == null;
			checked
			{
				if (flag)
				{
					this.MeNew();
				}
				else
				{
					this.LoadHeader(byID);
					DataTable detailByID = this.Ersal_Bar.GetDetailByID(Conversions.ToLong(byID["ID"]));
					this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID(Conversions.ToLong(byID["ID"]));
					this.Prepare_furush_detail(detailByID);
					this.RemoveZero(detailByID);
					detailByID.AcceptChanges();
					this.GridEX1.SelectionChanged -= new EventHandler(this.GridEX1_SelectionChanged);
					this.GridEX1.DataSource = detailByID;
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow row = rows[i];
						this.GetSud(row);
					}
					this.SyncTedad();
					this.RemoveZeroVazn();
					this.ButtonItem4.Enabled = true;
					this.Isnew = false;
					int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID)));
					flag = (num == 1);
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
					this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
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
							this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
							flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
							if (flag2)
							{
								flag = (this.GridEX1.EditTextBox != null);
								if (flag)
								{
									this.GridEX1.EditTextBox.Text = Conversions.ToString(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
									this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
									this.GridEX1.GetRow().Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["row_index"].Value);
									this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
								}
							}
						}
					}
					long num2 = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
					num2 = (long)Math.Round(unchecked((double)num2 + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye"))));
					this.txt_makharej.Text = Conversions.ToString(num2);
					this.GetDaramad();
				}
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00127C44 File Offset: 0x00125E44
		private void txt_num_First_Click()
		{
			long navigateID = this.Ersal_Bar.GetNavigateID(Ersal_Bar.NavTo.first, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060019F9 RID: 6649 RVA: 0x00127CA0 File Offset: 0x00125EA0
		private void txt_num_Last_Click()
		{
			long navigateID = this.Ersal_Bar.GetNavigateID(Ersal_Bar.NavTo.last, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060019FA RID: 6650 RVA: 0x00127CFC File Offset: 0x00125EFC
		private void txt_num_Next_Click()
		{
			long navigateID = this.Ersal_Bar.GetNavigateID(Ersal_Bar.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060019FB RID: 6651 RVA: 0x00127D58 File Offset: 0x00125F58
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Ersal_Bar.GetNavigateID(Ersal_Bar.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060019FC RID: 6652 RVA: 0x00127DB4 File Offset: 0x00125FB4
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

		// Token: 0x060019FD RID: 6653 RVA: 0x0000785F File Offset: 0x00005A5F
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00127E34 File Offset: 0x00126034
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
					this.txt_tedad.Text = Conversions.ToString(frm_Rizbar.sum);
				}
				flag = (decimal.Compare(frm_Rizbar.Sum_Vazn, decimal.Zero) != 0);
				if (flag)
				{
					this.txt_baskul.Text = Conversions.ToString(frm_Rizbar.Sum_Vazn);
				}
				DataTable dataSource = this.dt_rizbar.Copy();
				this.Grid_RizBar.DataSource = dataSource;
				flag = (this.Grid_RizBar.RowCount > 0);
				if (flag)
				{
					this.Grid_RizBar.Visible = true;
					this.SyncTedad();
					this.RemoveZeroVazn();
				}
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00127FB0 File Offset: 0x001261B0
		public void Check_Enable()
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID)));
			bool flag = num == 1;
			if (flag)
			{
				this.setEnable(false);
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00127FF0 File Offset: 0x001261F0
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

		// Token: 0x06001A01 RID: 6657 RVA: 0x0012805C File Offset: 0x0012625C
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

		// Token: 0x06001A02 RID: 6658 RVA: 0x0012819C File Offset: 0x0012639C
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
						this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
						this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
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

		// Token: 0x06001A03 RID: 6659 RVA: 0x00128780 File Offset: 0x00126980
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.SyncTedad();
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x001287E8 File Offset: 0x001269E8
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

		// Token: 0x06001A05 RID: 6661 RVA: 0x001288B4 File Offset: 0x00126AB4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.Isnew;
			if (flag)
			{
				bool flag2 = Public_Function.ConfirmDelete() == DialogResult.Yes;
				if (flag2)
				{
					string empty = string.Empty;
					this.Ersal_Bar.Delete(Conversions.ToString(this.ID));
					this.MeNew();
				}
			}
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00128904 File Offset: 0x00126B04
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("با اصلاح اطلاعات صافی ثبت شده حذف میگردد" + Environment.NewLine + "آیا مایل به اصلاح اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Frm_Password frm_Password = new Frm_Password();
				flag = (frm_Password.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					string text = "declare @sanad_id int;declare @karmozd_sanad_id int;declare @keraye_id int;declare @hazine_id int;declare @kerayebes_id int;declare @hazinebes_id int;";
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
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00128A30 File Offset: 0x00126C30
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

		// Token: 0x06001A08 RID: 6664 RVA: 0x00128B50 File Offset: 0x00126D50
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00128B7C File Offset: 0x00126D7C
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

		// Token: 0x06001A0A RID: 6666 RVA: 0x00128BE0 File Offset: 0x00126DE0
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
					Moshtari_ID = Conversions.ToLong(this.txt_moshtari.Value)
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
				long num = Conversions.ToLong(Public_Function.GetSum(this.dt_Keraye, "keraye"));
				num = checked((long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "keraye")))));
				this.txt_makharej.Text = Conversions.ToString(num);
				long num2 = 0L;
				long? value = this.txt_makharej.Value;
				bool? arg_140_0;
				if (!value.HasValue)
				{
					arg_140_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(value.GetValueOrDefault() == num2);
					arg_140_0 = flag2;
				}
				bool? flag3 = arg_140_0;
				flag = flag3.GetValueOrDefault();
				if (flag)
				{
					this.txt_makharej.SetNew();
				}
				this.GetDaramad();
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.Col = 1;
				this.GridEX1.GetRow().BeginEdit();
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00007872 File Offset: 0x00005A72
		private void txt_makharej_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem10_Click(null, null);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00128D94 File Offset: 0x00126F94
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem10_Click(null, null);
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0000787F File Offset: 0x00005A7F
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00128DBC File Offset: 0x00126FBC
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem4_Click(null, null);
			}
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00128DE4 File Offset: 0x00126FE4
		private void ButtonItem12_Click(object sender, EventArgs e)
		{
			new Frm_Change_Kala_To_Kala
			{
				dt_kharid = this.dt_rizbar,
				dt_furush = (DataTable)this.GridEX1.DataSource,
				dt_kala_to_kala = this.dt_kala_to_kala,
				grid = this.GridEX1
			}.ShowDialog();
			this.SyncTedad();
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0000788C File Offset: 0x00005A8C
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00007897 File Offset: 0x00005A97
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000078A2 File Offset: 0x00005AA2
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.Focus();
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06001A14 RID: 6676 RVA: 0x00128F78 File Offset: 0x00127178
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

		// Token: 0x06001A15 RID: 6677 RVA: 0x001292B0 File Offset: 0x001274B0
		private void txt_sh_barname_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar.Focus();
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x001292DC File Offset: 0x001274DC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع مانده";
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0012931C File Offset: 0x0012751C
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
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
					this.prevent_Enter = true;
				}
				flag2 = (e.KeyCode == Keys.Delete);
				if (flag2)
				{
					this.txt_keraye.SetNew();
					((DataRowView)this.GridEX1.CurrentRow.DataRow)["Keraye"] = DBNull.Value;
				}
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x001293AC File Offset: 0x001275AC
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

		// Token: 0x06001A19 RID: 6681 RVA: 0x000078B2 File Offset: 0x00005AB2
		private void txt_safikol_TextChanged(object sender, EventArgs e)
		{
			this.GetDaramad();
		}

		// Token: 0x040009C9 RID: 2505
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040009CB RID: 2507
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040009CC RID: 2508
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040009CD RID: 2509
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040009CE RID: 2510
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040009CF RID: 2511
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040009D0 RID: 2512
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040009D1 RID: 2513
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040009D2 RID: 2514
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040009D3 RID: 2515
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040009D4 RID: 2516
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x040009D5 RID: 2517
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x040009D6 RID: 2518
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x040009D7 RID: 2519
		[AccessedThroughProperty("txt_tedad")]
		private NumericBox _txt_tedad;

		// Token: 0x040009D8 RID: 2520
		[AccessedThroughProperty("txt_sh_barname")]
		private EditBox _txt_sh_barname;

		// Token: 0x040009D9 RID: 2521
		[AccessedThroughProperty("txt_tarikh_vurud")]
		private DateBox2 _txt_tarikh_vurud;

		// Token: 0x040009DA RID: 2522
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040009DB RID: 2523
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040009DC RID: 2524
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040009DD RID: 2525
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040009DE RID: 2526
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040009DF RID: 2527
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x040009E0 RID: 2528
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x040009E1 RID: 2529
		[AccessedThroughProperty("txt_baskul")]
		private NumericBox _txt_baskul;

		// Token: 0x040009E2 RID: 2530
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040009E3 RID: 2531
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040009E4 RID: 2532
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x040009E5 RID: 2533
		[AccessedThroughProperty("txt_baskul_mabda")]
		private NumericBox _txt_baskul_mabda;

		// Token: 0x040009E6 RID: 2534
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040009E7 RID: 2535
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x040009E8 RID: 2536
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x040009E9 RID: 2537
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x040009EA RID: 2538
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x040009EB RID: 2539
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x040009EC RID: 2540
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x040009ED RID: 2541
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x040009EE RID: 2542
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x040009EF RID: 2543
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x040009F0 RID: 2544
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x040009F1 RID: 2545
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x040009F2 RID: 2546
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x040009F3 RID: 2547
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x040009F4 RID: 2548
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x040009F5 RID: 2549
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x040009F6 RID: 2550
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x040009F7 RID: 2551
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040009F8 RID: 2552
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x040009F9 RID: 2553
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x040009FA RID: 2554
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x040009FB RID: 2555
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x040009FC RID: 2556
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x040009FD RID: 2557
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x040009FE RID: 2558
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x040009FF RID: 2559
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000A00 RID: 2560
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000A01 RID: 2561
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000A02 RID: 2562
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000A03 RID: 2563
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000A04 RID: 2564
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000A05 RID: 2565
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000A06 RID: 2566
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000A07 RID: 2567
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000A08 RID: 2568
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000A09 RID: 2569
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000A0A RID: 2570
		[AccessedThroughProperty("txt_safikol")]
		private CurrencyBox _txt_safikol;

		// Token: 0x04000A0B RID: 2571
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000A0C RID: 2572
		[AccessedThroughProperty("txt_keraye")]
		private CurrencyBox _txt_keraye;

		// Token: 0x04000A0D RID: 2573
		[AccessedThroughProperty("txt_safi")]
		private CurrencyBox _txt_safi;

		// Token: 0x04000A0E RID: 2574
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000A0F RID: 2575
		[AccessedThroughProperty("txt_daramad")]
		private CurrencyBox _txt_daramad;

		// Token: 0x04000A10 RID: 2576
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000A11 RID: 2577
		[AccessedThroughProperty("txt_keraye_mabda")]
		private CurrencyBox _txt_keraye_mabda;

		// Token: 0x04000A12 RID: 2578
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000A13 RID: 2579
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000A14 RID: 2580
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000A15 RID: 2581
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000A16 RID: 2582
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000A17 RID: 2583
		private Ersal_Bar Ersal_Bar;

		// Token: 0x04000A18 RID: 2584
		private Furush_Hag_RizBar RizBar;

		// Token: 0x04000A19 RID: 2585
		private ErsalBar_Keraye ErsalBar_Keraye;

		// Token: 0x04000A1A RID: 2586
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000A1B RID: 2587
		private Kala_To_Kala_Furush kala_to_kala;

		// Token: 0x04000A1C RID: 2588
		private DataTable dt_Keraye;

		// Token: 0x04000A1D RID: 2589
		private DataTable dt_kala_to_kala;

		// Token: 0x04000A1E RID: 2590
		private Frm_SelectItem frm;

		// Token: 0x04000A1F RID: 2591
		private Sanad sanad;

		// Token: 0x04000A20 RID: 2592
		private Sandugh Sandug;

		// Token: 0x04000A21 RID: 2593
		private Base_User_Control user;

		// Token: 0x04000A22 RID: 2594
		private int ID;

		// Token: 0x04000A23 RID: 2595
		public int Num;

		// Token: 0x04000A24 RID: 2596
		public int GotoLineID;

		// Token: 0x04000A25 RID: 2597
		private bool Isnew;

		// Token: 0x04000A26 RID: 2598
		private DataTable dt_rizbar;

		// Token: 0x04000A27 RID: 2599
		private bool prevent_close;

		// Token: 0x04000A28 RID: 2600
		private bool prevent_right;

		// Token: 0x04000A29 RID: 2601
		private bool prevent_left;

		// Token: 0x04000A2A RID: 2602
		private bool prevent_Enter;

		// Token: 0x04000A2B RID: 2603
		[CompilerGenerated]
		private bool _Show_Preview;
	}
}
