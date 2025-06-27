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
	// Token: 0x02000116 RID: 278
	[DesignerGenerated]
	public partial class Frm_Varedat : Form
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x001E6508 File Offset: 0x001E4708
		public Frm_Varedat()
		{
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Kharid_Furush_KeyDown);
			Frm_Varedat.__ENCAddToList(this);
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			this.Varedat = new Varedat();
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

		// Token: 0x06002849 RID: 10313 RVA: 0x001E661C File Offset: 0x001E481C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Varedat.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Varedat.__ENCList.Count == Frm_Varedat.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Varedat.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Varedat.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Varedat.__ENCList[num] = Frm_Varedat.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Varedat.__ENCList.RemoveRange(num, Frm_Varedat.__ENCList.Count - num);
						Frm_Varedat.__ENCList.Capacity = Frm_Varedat.__ENCList.Count;
					}
					Frm_Varedat.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x001E91D0 File Offset: 0x001E73D0
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x001E91E8 File Offset: 0x001E73E8
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
				EventHandler value2 = new EventHandler(this.UiGroupBox1_Click);
				bool flag = this._UiGroupBox1 != null;
				if (flag)
				{
					this._UiGroupBox1.Click -= value2;
				}
				this._UiGroupBox1 = value;
				flag = (this._UiGroupBox1 != null);
				if (flag)
				{
					this._UiGroupBox1.Click += value2;
				}
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x001E9248 File Offset: 0x001E7448
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x00009FE9 File Offset: 0x000081E9
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

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x001E9260 File Offset: 0x001E7460
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x00009FF3 File Offset: 0x000081F3
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x001E9278 File Offset: 0x001E7478
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x001E9290 File Offset: 0x001E7490
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x001E93C4 File Offset: 0x001E75C4
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x001E93DC File Offset: 0x001E75DC
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x001E943C File Offset: 0x001E763C
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x00009FFD File Offset: 0x000081FD
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x001E9454 File Offset: 0x001E7654
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x001E946C File Offset: 0x001E766C
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x001E94CC File Offset: 0x001E76CC
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x001E94E4 File Offset: 0x001E76E4
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x001E9544 File Offset: 0x001E7744
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x001E955C File Offset: 0x001E775C
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x001E95BC File Offset: 0x001E77BC
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x001E95D4 File Offset: 0x001E77D4
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

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x001E9634 File Offset: 0x001E7834
		// (set) Token: 0x06002861 RID: 10337 RVA: 0x001E964C File Offset: 0x001E784C
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x001E96AC File Offset: 0x001E78AC
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x001E96C4 File Offset: 0x001E78C4
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

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x001E9724 File Offset: 0x001E7924
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x001E973C File Offset: 0x001E793C
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x001E979C File Offset: 0x001E799C
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x001E97B4 File Offset: 0x001E79B4
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

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x001E9814 File Offset: 0x001E7A14
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x0000A007 File Offset: 0x00008207
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x001E982C File Offset: 0x001E7A2C
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x0000A011 File Offset: 0x00008211
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

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x001E9844 File Offset: 0x001E7A44
		// (set) Token: 0x0600286D RID: 10349 RVA: 0x0000A01B File Offset: 0x0000821B
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

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x001E985C File Offset: 0x001E7A5C
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x0000A025 File Offset: 0x00008225
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x001E9874 File Offset: 0x001E7A74
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x0000A02F File Offset: 0x0000822F
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x001E988C File Offset: 0x001E7A8C
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x0000A039 File Offset: 0x00008239
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x001E98A4 File Offset: 0x001E7AA4
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x0000A043 File Offset: 0x00008243
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

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x001E98BC File Offset: 0x001E7ABC
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x0000A04D File Offset: 0x0000824D
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

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x001E98D4 File Offset: 0x001E7AD4
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x0000A057 File Offset: 0x00008257
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

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x001E98EC File Offset: 0x001E7AEC
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x0000A061 File Offset: 0x00008261
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

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x001E9904 File Offset: 0x001E7B04
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0000A06B File Offset: 0x0000826B
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

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x001E991C File Offset: 0x001E7B1C
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x0000A075 File Offset: 0x00008275
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

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x001E9934 File Offset: 0x001E7B34
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x001E994C File Offset: 0x001E7B4C
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

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x001E99AC File Offset: 0x001E7BAC
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x001E99C4 File Offset: 0x001E7BC4
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x001E9A4C File Offset: 0x001E7C4C
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x0000A07F File Offset: 0x0000827F
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x001E9A64 File Offset: 0x001E7C64
		// (set) Token: 0x06002887 RID: 10375 RVA: 0x0000A089 File Offset: 0x00008289
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x001E9A7C File Offset: 0x001E7C7C
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x001E9A94 File Offset: 0x001E7C94
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x001E9B1C File Offset: 0x001E7D1C
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x0000A093 File Offset: 0x00008293
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

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x001E9B34 File Offset: 0x001E7D34
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x001E9B4C File Offset: 0x001E7D4C
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x001E9BD4 File Offset: 0x001E7DD4
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x0000A09D File Offset: 0x0000829D
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

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x001E9BEC File Offset: 0x001E7DEC
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0000A0A7 File Offset: 0x000082A7
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

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x001E9C04 File Offset: 0x001E7E04
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x0000A0B1 File Offset: 0x000082B1
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

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x001E9C1C File Offset: 0x001E7E1C
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x0000A0BB File Offset: 0x000082BB
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

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x001E9C34 File Offset: 0x001E7E34
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0000A0C5 File Offset: 0x000082C5
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x001E9C4C File Offset: 0x001E7E4C
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0000A0CF File Offset: 0x000082CF
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

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x001E9C64 File Offset: 0x001E7E64
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x0000A0D9 File Offset: 0x000082D9
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x001E9C7C File Offset: 0x001E7E7C
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x0000A0E3 File Offset: 0x000082E3
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x001E9C94 File Offset: 0x001E7E94
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0000A0ED File Offset: 0x000082ED
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x001E9CAC File Offset: 0x001E7EAC
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0000A0F7 File Offset: 0x000082F7
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

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x001E9CC4 File Offset: 0x001E7EC4
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0000A101 File Offset: 0x00008301
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x001E9CDC File Offset: 0x001E7EDC
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x001E9CF4 File Offset: 0x001E7EF4
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

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x001E9D54 File Offset: 0x001E7F54
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0000A10B File Offset: 0x0000830B
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x001E9D6C File Offset: 0x001E7F6C
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0000A115 File Offset: 0x00008315
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

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x001E9D84 File Offset: 0x001E7F84
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x0000A11F File Offset: 0x0000831F
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

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x001E9D9C File Offset: 0x001E7F9C
		// (set) Token: 0x060028AD RID: 10413 RVA: 0x0000A129 File Offset: 0x00008329
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

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x001E9DB4 File Offset: 0x001E7FB4
		// (set) Token: 0x060028AF RID: 10415 RVA: 0x0000A133 File Offset: 0x00008333
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

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x001E9DCC File Offset: 0x001E7FCC
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0000A13D File Offset: 0x0000833D
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

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x001E9DE4 File Offset: 0x001E7FE4
		// (set) Token: 0x060028B3 RID: 10419 RVA: 0x0000A147 File Offset: 0x00008347
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

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x001E9DFC File Offset: 0x001E7FFC
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x0000A151 File Offset: 0x00008351
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x001E9E14 File Offset: 0x001E8014
		// (set) Token: 0x060028B7 RID: 10423 RVA: 0x0000A15B File Offset: 0x0000835B
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

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x001E9E2C File Offset: 0x001E802C
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x001E9E44 File Offset: 0x001E8044
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

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x001E9EA4 File Offset: 0x001E80A4
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x001E9EBC File Offset: 0x001E80BC
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

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x001E9F1C File Offset: 0x001E811C
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x0000A165 File Offset: 0x00008365
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

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x001E9F34 File Offset: 0x001E8134
		// (set) Token: 0x060028BF RID: 10431 RVA: 0x001E9F4C File Offset: 0x001E814C
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

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x001E9FAC File Offset: 0x001E81AC
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x001E9FC4 File Offset: 0x001E81C4
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

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x001EA024 File Offset: 0x001E8224
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x001EA03C File Offset: 0x001E823C
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x001EA09C File Offset: 0x001E829C
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x001EA0B4 File Offset: 0x001E82B4
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

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x001EA114 File Offset: 0x001E8314
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x0000A16F File Offset: 0x0000836F
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
				this._ButtonItem10 = value;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x001EA12C File Offset: 0x001E832C
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x001EA144 File Offset: 0x001E8344
		internal virtual ButtonItem ButtonItem16_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem16_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem16_2_Click);
				bool flag = this._ButtonItem16_2 != null;
				if (flag)
				{
					this._ButtonItem16_2.Click -= value2;
				}
				this._ButtonItem16_2 = value;
				flag = (this._ButtonItem16_2 != null);
				if (flag)
				{
					this._ButtonItem16_2.Click += value2;
				}
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x001EA1A4 File Offset: 0x001E83A4
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x001EA1BC File Offset: 0x001E83BC
		internal virtual ButtonItem ButtonItem17_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem17_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem17_2_Click);
				bool flag = this._ButtonItem17_2 != null;
				if (flag)
				{
					this._ButtonItem17_2.Click -= value2;
				}
				this._ButtonItem17_2 = value;
				flag = (this._ButtonItem17_2 != null);
				if (flag)
				{
					this._ButtonItem17_2.Click += value2;
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x001EA21C File Offset: 0x001E841C
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x001EA234 File Offset: 0x001E8434
		internal virtual ButtonItem ButtonItem18_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem18_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem18_2_Click);
				bool flag = this._ButtonItem18_2 != null;
				if (flag)
				{
					this._ButtonItem18_2.Click -= value2;
				}
				this._ButtonItem18_2 = value;
				flag = (this._ButtonItem18_2 != null);
				if (flag)
				{
					this._ButtonItem18_2.Click += value2;
				}
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x001EA294 File Offset: 0x001E8494
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x001EA2AC File Offset: 0x001E84AC
		internal virtual ButtonItem ButtonItem19_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem19_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem19_2_Click);
				bool flag = this._ButtonItem19_2 != null;
				if (flag)
				{
					this._ButtonItem19_2.Click -= value2;
				}
				this._ButtonItem19_2 = value;
				flag = (this._ButtonItem19_2 != null);
				if (flag)
				{
					this._ButtonItem19_2.Click += value2;
				}
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x001EA30C File Offset: 0x001E850C
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x001EA324 File Offset: 0x001E8524
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value4 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value5 = new EventHandler(this.GridEX1_SelectionChanged);
				KeyPressEventHandler value6 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EndCustomEditEventHandler value7 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value8 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				RowLoadEventHandler value9 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.CellEdited -= value3;
					this._GridEX1.InitCustomEdit -= value4;
					this._GridEX1.SelectionChanged -= value5;
					this._GridEX1.KeyPress -= value6;
					this._GridEX1.EndCustomEdit -= value7;
					this._GridEX1.ColumnButtonClick -= value8;
					this._GridEX1.LoadingRow -= value9;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.CellEdited += value3;
					this._GridEX1.InitCustomEdit += value4;
					this._GridEX1.SelectionChanged += value5;
					this._GridEX1.KeyPress += value6;
					this._GridEX1.EndCustomEdit += value7;
					this._GridEX1.ColumnButtonClick += value8;
					this._GridEX1.LoadingRow += value9;
				}
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x001EA4AC File Offset: 0x001E86AC
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0000A179 File Offset: 0x00008379
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

		// Token: 0x060028D4 RID: 10452 RVA: 0x001EA4C4 File Offset: 0x001E86C4
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x001EA4F0 File Offset: 0x001E86F0
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

		// Token: 0x060028D6 RID: 10454 RVA: 0x001EA584 File Offset: 0x001E8784
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

		// Token: 0x060028D7 RID: 10455 RVA: 0x001EA724 File Offset: 0x001E8924
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

		// Token: 0x060028D8 RID: 10456 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x060028D9 RID: 10457 RVA: 0x001EA8B8 File Offset: 0x001E8AB8
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

		// Token: 0x060028DA RID: 10458 RVA: 0x001EA96C File Offset: 0x001E8B6C
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

		// Token: 0x060028DB RID: 10459 RVA: 0x001EAA34 File Offset: 0x001E8C34
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

		// Token: 0x060028DC RID: 10460 RVA: 0x001EAB3C File Offset: 0x001E8D3C
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

		// Token: 0x060028DD RID: 10461 RVA: 0x001EAD98 File Offset: 0x001E8F98
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

		// Token: 0x060028DE RID: 10462 RVA: 0x001EAEA8 File Offset: 0x001E90A8
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

		// Token: 0x060028DF RID: 10463 RVA: 0x001EB270 File Offset: 0x001E9470
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

		// Token: 0x060028E0 RID: 10464 RVA: 0x001EB568 File Offset: 0x001E9768
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

		// Token: 0x060028E1 RID: 10465 RVA: 0x001655F0 File Offset: 0x001637F0
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

		// Token: 0x060028E2 RID: 10466 RVA: 0x00172E1C File Offset: 0x0017101C
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

		// Token: 0x060028E3 RID: 10467 RVA: 0x001EB66C File Offset: 0x001E986C
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

		// Token: 0x060028E4 RID: 10468 RVA: 0x001EBA18 File Offset: 0x001E9C18
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

		// Token: 0x060028E5 RID: 10469 RVA: 0x00165DD4 File Offset: 0x00163FD4
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

		// Token: 0x060028E6 RID: 10470 RVA: 0x001EBBA0 File Offset: 0x001E9DA0
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

		// Token: 0x060028E7 RID: 10471 RVA: 0x001EBD28 File Offset: 0x001E9F28
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

		// Token: 0x060028E8 RID: 10472 RVA: 0x001EBE50 File Offset: 0x001EA050
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

		// Token: 0x060028E9 RID: 10473 RVA: 0x001EBF2C File Offset: 0x001EA12C
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

		// Token: 0x060028EA RID: 10474 RVA: 0x001EC34C File Offset: 0x001EA54C
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

		// Token: 0x060028EB RID: 10475 RVA: 0x001EC464 File Offset: 0x001EA664
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

		// Token: 0x060028EC RID: 10476 RVA: 0x001EC57C File Offset: 0x001EA77C
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

		// Token: 0x060028ED RID: 10477 RVA: 0x001EC7C8 File Offset: 0x001EA9C8
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
							this.Varedat.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
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
						flag4 = num3.HasValue;
						if (flag4)
						{
						}
						flag4 = kala_id.HasValue;
						if (flag4)
						{
							DataRow[] array = this.dt_Kharid.Select("kala_id=" + (kala_id.HasValue ? Conversions.ToString(kala_id.GetValueOrDefault()) : null));
							flag4 = (array.Length > 0);
							if (flag4)
							{
							}
						}
					}
					else
					{
						flag4 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"] != DBNull.Value);
						if (flag4)
						{
							this.Varedat.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
						}
						this.sanad.Delete(Conversions.ToString(this.GridEX1.CurrentRow.Cells["sanad_id"].Value));
						flag4 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
						decimal? num;
						decimal? tedad2;
						if (flag4)
						{
							object expr_3AC = this.GridEX1.CurrentRow.Cells["tedad"].Value;
							tedad2 = ((expr_3AC != null) ? ((decimal?)expr_3AC) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
						decimal? vazn2;
						if (flag4)
						{
							object expr_410 = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value;
							vazn2 = ((expr_410 != null) ? ((decimal?)expr_410) : num);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["kala_id"].Value != DBNull.Value);
						int? num2;
						int? kala_id2;
						if (flag4)
						{
							object expr_474 = this.GridEX1.CurrentRow.Cells["kala_id"].Value;
							kala_id2 = ((expr_474 != null) ? ((int?)expr_474) : num2);
						}
						flag4 = (this.GridEX1.CurrentRow.Cells["row_index"].Value != DBNull.Value);
						int? num4;
						if (flag4)
						{
							object expr_4D8 = this.GridEX1.CurrentRow.Cells["row_index"].Value;
							num4 = ((expr_4D8 != null) ? ((int?)expr_4D8) : num2);
						}
						this.GridEX1.CurrentRow.Delete();
						this.RollBackTedadVazn(kala_id2, ref num4, tedad2, vazn2);
						flag4 = num4.HasValue;
						if (flag4)
						{
						}
						flag4 = kala_id2.HasValue;
						if (flag4)
						{
							DataRow[] array2 = this.dt_Kharid.Select("kala_id=" + (kala_id2.HasValue ? Conversions.ToString(kala_id2.GetValueOrDefault()) : null));
							flag4 = (array2.Length > 0);
							if (flag4)
							{
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

		// Token: 0x060028EE RID: 10478 RVA: 0x001ECD84 File Offset: 0x001EAF84
		private void MeNew()
		{
			this.Isnew = true;
			this.Load_Default_Nahve_Kharid();
			this.Load_Default_Nahve_furush();
			Public_Function.SetNew(this.UiGroupBox1);
			this.setEnable(true);
			DataTable detailByID = this.Varedat.GetDetailByID(-1L);
			detailByID.Columns["Fee"].AllowDBNull = true;
			this.GridEX1.DataSource = detailByID;
			this.dt_kala_to_kala = this.kala_to_kala.GetByKharid_ID(-1L);
			this.Num = checked((int)this.Varedat.GetNewID());
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_num.Focus();
			this.dt_Kharid = this.RizKharid.GetByID(-1);
			this.dt_Keraye = null;
			this.dt_Darsad = null;
			this.dt_mande = null;
			this.lbl_daramad.Text = string.Empty;
			this.Grid_RizBar.DataSource = null;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x001ECE7C File Offset: 0x001EB07C
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

		// Token: 0x060028F0 RID: 10480 RVA: 0x001ECEE8 File Offset: 0x001EB0E8
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

		// Token: 0x060028F1 RID: 10481 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x060028F2 RID: 10482 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x060028F3 RID: 10483 RVA: 0x001ED378 File Offset: 0x001EB578
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

		// Token: 0x060028F4 RID: 10484 RVA: 0x001ED994 File Offset: 0x001EBB94
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

		// Token: 0x060028F5 RID: 10485 RVA: 0x001EDB28 File Offset: 0x001EBD28
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x001EDB9C File Offset: 0x001EBD9C
		private int GetNahve_Furush()
		{
			bool @checked = this.ButtonItem16_2.Checked;
			int result;
			if (@checked)
			{
				result = 1;
			}
			else
			{
				@checked = this.ButtonItem17_2.Checked;
				if (@checked)
				{
					result = 2;
				}
				else
				{
					@checked = this.ButtonItem18_2.Checked;
					if (@checked)
					{
						result = 3;
					}
					else
					{
						@checked = this.ButtonItem19_2.Checked;
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

		// Token: 0x060028F8 RID: 10488 RVA: 0x001EDC00 File Offset: 0x001EBE00
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
					flag = !this.ValidateGridData();
					if (flag)
					{
						this.addhandle();
						result = false;
					}
					else
					{
						this.addhandle();
						string nahve_kharid = Conversions.ToString(this.GetNahve_Kharid());
						string nahve_furush = Conversions.ToString(this.GetNahve_Furush());
						flag = this.Isnew;
						if (flag)
						{
							this.ID = checked((int)this.Varedat.Insert(this.txt_num.Value.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), this.txt_desc.Text, nahve_kharid, nahve_furush, (DataTable)this.GridEX1.DataSource));
							this.RizKharid.Update(this.ID, this.dt_Kharid);
							this.kharid_keraye.Update(this.ID, this.dt_Keraye);
							this.Kharid_Sud.Update(this.ID, this.dt_Darsad);
							flag = !silent;
							if (flag)
							{
								Public_Function.ConfirmInsert();
							}
							DataTable detailByID = this.Varedat.GetDetailByID((long)this.ID);
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
							this.Varedat.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), this.txt_desc.Text, nahve_kharid, nahve_furush, (DataTable)this.GridEX1.DataSource);
							DataTable detailByID2 = this.Varedat.GetDetailByID((long)this.ID);
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
			}
			return result;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x001EDFBC File Offset: 0x001EC1BC
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

		// Token: 0x060028FA RID: 10490 RVA: 0x001EE004 File Offset: 0x001EC204
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

		// Token: 0x060028FB RID: 10491 RVA: 0x001EE0D8 File Offset: 0x001EC2D8
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
												bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataRow2["vazn_mande"], 0, false);
												if (flag3)
												{
													DataRow dataRow3 = dataRow2;
													DataRow arg_6D3_0 = dataRow3;
													string columnName = "vazn_mande";
													arg_6D3_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current2.Tedad);
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

		// Token: 0x060028FC RID: 10492 RVA: 0x001EE994 File Offset: 0x001ECB94
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

		// Token: 0x060028FD RID: 10493 RVA: 0x001EEB74 File Offset: 0x001ECD74
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

		// Token: 0x060028FE RID: 10494 RVA: 0x00176994 File Offset: 0x00174B94
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

		// Token: 0x060028FF RID: 10495 RVA: 0x001EEC6C File Offset: 0x001ECE6C
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

		// Token: 0x06002900 RID: 10496 RVA: 0x001EED7C File Offset: 0x001ECF7C
		private void DeleteTekrari(string num)
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"select id from kharid_sardkhane where type=1 and num=",
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
						this.Varedat.Delete(Conversions.ToString(dataRow["ID"]));
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

		// Token: 0x06002901 RID: 10497 RVA: 0x001EEE5C File Offset: 0x001ED05C
		private void LoadNahve_kharid(DataRow dr)
		{
			bool flag = dr["nahve_kharid"] == DBNull.Value;
			if (flag)
			{
				this.uncheckmenu();
				this.ButtonItem16.Checked = true;
				this.ButtonItem16_Click(null, null);
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(dr["nahve_kharid"]);
				this.uncheckmenu();
				object left = objectValue;
				flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
				if (flag)
				{
					this.ButtonItem16.Checked = true;
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
					if (flag)
					{
						this.ButtonItem17.Checked = true;
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
						if (flag)
						{
							this.ButtonItem18.Checked = true;
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
							if (flag)
							{
								this.ButtonItem19.Checked = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x001EEF44 File Offset: 0x001ED144
		private void LoadNahve_Furush(DataRow dr)
		{
			bool flag = dr["nahve_furush"] == DBNull.Value;
			if (flag)
			{
				this.uncheckmenu2();
				this.ButtonItem16_2.Checked = true;
				this.ButtonItem16_2_Click(null, null);
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(dr["nahve_furush"]);
				this.uncheckmenu2();
				object left = objectValue;
				flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
				if (flag)
				{
					this.ButtonItem16_2.Checked = true;
					this.ButtonItem16_2_Click(null, null);
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
					if (flag)
					{
						this.ButtonItem17_2.Checked = true;
						this.ButtonItem17_2_Click(null, null);
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
						if (flag)
						{
							this.ButtonItem18_2.Checked = true;
							this.ButtonItem18_2_Click(null, null);
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
							if (flag)
							{
								this.ButtonItem19_2.Checked = true;
								this.ButtonItem19_2_Click(null, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x001EF050 File Offset: 0x001ED250
		private void LoadData()
		{
			DataRow byID = this.Varedat.GetByID((long)this.Num);
			bool flag = byID == null;
			checked
			{
				if (flag)
				{
					this.ButtonItem1_Click(null, null);
				}
				else
				{
					this.LoadHeader(byID);
					this.LoadNahve_kharid(byID);
					this.LoadNahve_Furush(byID);
					this.DeleteTekrari(Conversions.ToString(this.Num));
					this.dt_Darsad = this.Kharid_Sud.GetByID(this.ID);
					DataTable detailByID = this.Varedat.GetDetailByID(Conversions.ToLong(byID["ID"]));
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
				}
			}
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x001EF66C File Offset: 0x001ED86C
		private void txt_num_First_Click()
		{
			long navigateID = this.Varedat.GetNavigateID(Varedat.NavTo.first, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06002905 RID: 10501 RVA: 0x001EF6C8 File Offset: 0x001ED8C8
		private void txt_num_Last_Click()
		{
			long navigateID = this.Varedat.GetNavigateID(Varedat.NavTo.last, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06002906 RID: 10502 RVA: 0x001EF724 File Offset: 0x001ED924
		private void txt_num_Next_Click()
		{
			long navigateID = this.Varedat.GetNavigateID(Varedat.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06002907 RID: 10503 RVA: 0x001EF780 File Offset: 0x001ED980
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Varedat.GetNavigateID(Varedat.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06002908 RID: 10504 RVA: 0x001EF7DC File Offset: 0x001ED9DC
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

		// Token: 0x06002909 RID: 10505 RVA: 0x0000A183 File Offset: 0x00008383
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x001EF85C File Offset: 0x001EDA5C
		private void Load_Default_Nahve_Kharid()
		{
			this.uncheckmenu();
			string left = Public_Function.dict["nahve_kharid"];
			bool flag = Operators.CompareString(left, Conversions.ToString(1), false) == 0;
			if (flag)
			{
				this.ButtonItem16.Checked = true;
			}
			else
			{
				flag = (Operators.CompareString(left, Conversions.ToString(2), false) == 0);
				if (flag)
				{
					this.ButtonItem17.Checked = true;
				}
				else
				{
					flag = (Operators.CompareString(left, Conversions.ToString(3), false) == 0);
					if (flag)
					{
						this.ButtonItem18.Checked = true;
					}
					else
					{
						flag = (Operators.CompareString(left, Conversions.ToString(4), false) == 0);
						if (flag)
						{
							this.ButtonItem19.Checked = true;
						}
					}
				}
			}
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x0000A196 File Offset: 0x00008396
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0000A1CE File Offset: 0x000083CE
		private void uncheckmenu2()
		{
			this.ButtonItem16_2.Checked = false;
			this.ButtonItem17_2.Checked = false;
			this.ButtonItem18_2.Checked = false;
			this.ButtonItem19_2.Checked = false;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0000A206 File Offset: 0x00008406
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			this.uncheckmenu();
			this.ButtonItem16.Checked = true;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0000A21E File Offset: 0x0000841E
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			this.uncheckmenu();
			this.ButtonItem17.Checked = true;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0000A236 File Offset: 0x00008436
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			this.uncheckmenu();
			this.ButtonItem18.Checked = true;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0000A24E File Offset: 0x0000844E
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			this.uncheckmenu();
			this.ButtonItem19.Checked = true;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x001EF914 File Offset: 0x001EDB14
		private void Load_Default_Nahve_furush()
		{
			this.uncheckmenu_2();
			string left = Public_Function.dict["nahve_furush"];
			bool flag = Operators.CompareString(left, Conversions.ToString(1), false) == 0;
			if (flag)
			{
				this.ButtonItem16_2.Checked = true;
				this.ButtonItem16_2_Click(null, null);
			}
			else
			{
				flag = (Operators.CompareString(left, Conversions.ToString(2), false) == 0);
				if (flag)
				{
					this.ButtonItem17_2.Checked = true;
					this.ButtonItem17_2_Click(null, null);
				}
				else
				{
					flag = (Operators.CompareString(left, Conversions.ToString(3), false) == 0);
					if (flag)
					{
						this.ButtonItem18_2.Checked = true;
						this.ButtonItem18_2_Click(null, null);
					}
					else
					{
						flag = (Operators.CompareString(left, Conversions.ToString(4), false) == 0);
						if (flag)
						{
							this.ButtonItem19_2.Checked = true;
							this.ButtonItem19_2_Click(null, null);
						}
					}
				}
			}
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0000A1CE File Offset: 0x000083CE
		private void uncheckmenu_2()
		{
			this.ButtonItem16_2.Checked = false;
			this.ButtonItem17_2.Checked = false;
			this.ButtonItem18_2.Checked = false;
			this.ButtonItem19_2.Checked = false;
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x001EF9F4 File Offset: 0x001EDBF4
		private void ButtonItem16_2_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu_2();
			this.ButtonItem16_2.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x001EFAB4 File Offset: 0x001EDCB4
		private void ButtonItem17_2_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = false;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu_2();
			this.ButtonItem17_2.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x001EFB74 File Offset: 0x001EDD74
		private void ButtonItem18_2_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = false;
			this.uncheckmenu_2();
			this.ButtonItem18_2.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x001EFC34 File Offset: 0x001EDE34
		private void ButtonItem19_2_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu_2();
			this.ButtonItem19_2.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x001EFCF4 File Offset: 0x001EDEF4
		private int GetNahve_Kharid()
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

		// Token: 0x06002918 RID: 10520 RVA: 0x001EFD58 File Offset: 0x001EDF58
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			Frm_Sardkhane_RizKharid frm_Sardkhane_RizKharid = new Frm_Sardkhane_RizKharid
			{
				Furush_Table = (DataTable)this.GridEX1.DataSource,
				Text = "ریز خرید",
				nahve_kharid = this.GetNahve_Kharid(),
				is_Varedat = true
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
				flag = this.Isnew;
				if (flag)
				{
					this.dt_mande = this.dt_Kharid.Copy();
				}
				else
				{
					this.Get_Dt_Mande((long)this.ID);
				}
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

		// Token: 0x06002919 RID: 10521 RVA: 0x0000A266 File Offset: 0x00008466
		private void Get_Dt_Mande(long Kharid_id)
		{
			this.dt_mande = Public_Function.FillData(" SELECT     Kharid_Sardkhane_Detail.Kala_ID,max(Kala.Name) AS Kala_Name,sum ( Kharid_Sardkhane_Detail.Tedad) AS Tedad, sum(  Kharid_Sardkhane_Detail.Vazn_Kol) AS Vazn_Kol,sum(  Kharid_Sardkhane_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf  FROM         Kharid_Sardkhane_Detail INNER JOIN  Moshtari ON Kharid_Sardkhane_Detail.Moshtari_id = Moshtari.ID INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID   where Kharid_Sardkhane_ID = " + Conversions.ToString(Kharid_id) + " group by kala_id ");
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x001EFEA8 File Offset: 0x001EE0A8
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.CanDelete = false;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			string text = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
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

		// Token: 0x0600291B RID: 10523 RVA: 0x001F0088 File Offset: 0x001EE288
		private void Kala_select()
		{
			bool flag = this.dt_Kharid.Rows.Count == 0;
			checked
			{
				if (flag)
				{
					Public_Function.ShowMessage("ریز خرید را وارد نمایید", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					this.txt_rizbar.Focus();
				}
				else
				{
					this.frm.CanEdit = false;
					this.frm.CanDelete = true;
					string command = "SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=" + Public_Function.GetID(this.dt_Kharid, "moshtari_id", "");
					flag = (this.GridEX1.CurrentRow.Cells["prekala_id"].Value != DBNull.Value);
					int? num;
					if (flag)
					{
						object expr_C4 = this.GridEX1.CurrentRow.Cells["prekala_id"].Value;
						int? num2;
						num = ((expr_C4 != null) ? ((int?)expr_C4) : num2);
					}
					flag = (this.frm.ShowDialog(command, null, 0) == DialogResult.OK);
					if (flag)
					{
						bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position && this.GridEX1.EditTextBox != null;
						if (flag2)
						{
							this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
							this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
							flag2 = (this.dt_Kharid.Rows.Count == 0);
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
											Dt_Kharid = this.dt_Kharid
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
										dataRow["Furush_sardkhane_ID"] = this.ID;
										dataRow["child_kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
										dataRow["Parent_kala_id"] = RuntimeHelpers.GetObjectValue(frm_Select_Kala_To_Kala.Selected_Row.Cells["Kala_ID"].Value);
										this.dt_kala_to_kala.Rows.Add(dataRow);
										DataRow dataRow2 = this.dt_Kharid.NewRow();
										dataRow2["kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
										dataRow2["kala_name"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"]);
										int num3 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
										dataRow2["auto"] = true;
										flag2 = num.HasValue;
										bool flag3;
										if (flag2)
										{
											DataRow[] array = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
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
														DataRow[] arg_52B_0 = array2;
														int num4 = 0;
														DataRow arg_565_0 = arg_52B_0[num4];
														string columnName = "tedad";
														arg_565_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
													}
												}
												flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
												if (flag3)
												{
													flag2 = (array[0]["vazn"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array;
														DataRow[] arg_5C5_0 = array2;
														int num4 = 0;
														DataRow arg_5FF_0 = arg_5C5_0[num4];
														string columnName = "vazn";
														arg_5FF_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
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
										this.dt_Kharid.Rows.InsertAt(dataRow2, num3 + 1);
										((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num3;
										this.SyncTedad();
									}
									else
									{
										bool flag3 = !this.Is_In_Kharid_auto(Conversions.ToLong(this.frm.SelectedRow["ID"]));
										if (flag3)
										{
											DataRow dataRow3 = this.dt_Kharid.NewRow();
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
														DataRow dataRow4 = this.dt_Kharid.Rows[num6];
														DataRow arg_9E2_0 = dataRow4;
														string columnName = "tedad";
														arg_9E2_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow dataRow4 = this.dt_Kharid.Rows[num6];
														DataRow arg_A64_0 = dataRow4;
														string columnName = "vazn";
														arg_A64_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													DataRow[] array3 = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
													flag3 = (array3.Length > 0);
													if (flag3)
													{
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag2)
														{
															DataRow[] array2 = array3;
															DataRow[] arg_AE4_0 = array2;
															int num4 = 0;
															DataRow arg_B1E_0 = arg_AE4_0[num4];
															string columnName = "tedad";
															arg_B1E_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag3)
														{
															DataRow[] array2 = array3;
															DataRow[] arg_B5F_0 = array2;
															int num4 = 0;
															DataRow arg_B99_0 = arg_B5F_0[num4];
															string columnName = "vazn";
															arg_B99_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
														}
														this.CheckForDeleteKharid(array3[0]);
														flag3 = (array3[0].RowState != DataRowState.Detached);
														if (flag3)
														{
														}
													}
												}
											}
											this.dt_Kharid.Rows.InsertAt(dataRow3, num5 + 1);
											((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num5;
											flag3 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_Kharid.Rows[num5];
												DataRow arg_C80_0 = dataRow4;
												string columnName = "tedad";
												arg_C80_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
											}
											flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
											if (flag3)
											{
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
														DataRow dataRow4 = this.dt_Kharid.Rows[num7];
														DataRow arg_D68_0 = dataRow4;
														string columnName = "tedad";
														arg_D68_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow dataRow4 = this.dt_Kharid.Rows[num7];
														DataRow arg_DEA_0 = dataRow4;
														string columnName = "vazn";
														arg_DEA_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													DataRow[] array4 = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
													flag3 = (array4.Length > 0);
													if (flag3)
													{
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag2)
														{
															DataRow[] array2 = array4;
															DataRow[] arg_E6A_0 = array2;
															int num4 = 0;
															DataRow arg_EA4_0 = arg_E6A_0[num4];
															string columnName = "tedad";
															arg_EA4_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag3)
														{
															DataRow[] array2 = array4;
															DataRow[] arg_EE5_0 = array2;
															int num4 = 0;
															DataRow arg_F1F_0 = arg_EE5_0[num4];
															string columnName = "vazn";
															arg_F1F_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
												DataRow dataRow4 = this.dt_Kharid.Rows[num8];
												DataRow arg_100E_0 = dataRow4;
												string columnName = "tedad";
												arg_100E_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
											flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_Kharid.Rows[num8];
												DataRow arg_1090_0 = dataRow4;
												string columnName = "vazn";
												arg_1090_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
											}
											DataRow[] array5 = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.frm.SelectedRow["ID"])));
											flag3 = (array5.Length > 0);
											if (flag3)
											{
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
												if (flag2)
												{
													DataRow[] array2 = array5;
													DataRow[] arg_1112_0 = array2;
													int num4 = 0;
													DataRow arg_114C_0 = arg_1112_0[num4];
													string columnName = "tedad";
													arg_114C_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow[] array2 = array5;
													DataRow[] arg_118D_0 = array2;
													int num4 = 0;
													DataRow arg_11C7_0 = arg_118D_0[num4];
													string columnName = "vazn";
													arg_11C7_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
											flag = (this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]["tedad"] != DBNull.Value);
											if (flag)
											{
												DataRow dataRow4 = this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_130C_0 = dataRow4;
												string columnName = "tedad";
												arg_130C_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
										}
										flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
										if (flag3)
										{
											flag2 = Operators.ConditionalCompareObjectNotEqual(this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]["vazn"], 0, false);
											if (flag2)
											{
												DataRow dataRow4 = this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_1404_0 = dataRow4;
												string columnName = "vazn";
												arg_1404_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
											}
										}
										flag3 = num.HasValue;
										if (flag3)
										{
											DataRow[] array6 = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
											flag3 = (array6.Length > 0);
											if (flag3)
											{
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
												if (flag2)
												{
													DataRow[] array2 = array6;
													DataRow[] arg_1495_0 = array2;
													int num4 = 0;
													DataRow arg_14CF_0 = arg_1495_0[num4];
													string columnName = "tedad";
													arg_14CF_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow[] array2 = array6;
													DataRow[] arg_1510_0 = array2;
													int num4 = 0;
													DataRow arg_154A_0 = arg_1510_0[num4];
													string columnName = "vazn";
													arg_154A_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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

		// Token: 0x0600291C RID: 10524 RVA: 0x001F1698 File Offset: 0x001EF898
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
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x001F1C50 File Offset: 0x001EFE50
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

		// Token: 0x0600291E RID: 10526 RVA: 0x00142128 File Offset: 0x00140328
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

		// Token: 0x0600291F RID: 10527 RVA: 0x001F1CFC File Offset: 0x001EFEFC
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

		// Token: 0x06002920 RID: 10528 RVA: 0x001F1DE8 File Offset: 0x001EFFE8
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

		// Token: 0x06002921 RID: 10529 RVA: 0x001F1E60 File Offset: 0x001F0060
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
							this.Kala_select();
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_name"].Position);
						if (flag3)
						{
							this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
							this.Moshtari_Select();
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
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
						else
						{
							flag3 = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
							if (flag3)
							{
								flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag2)
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
								flag3 = (col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
								if (flag3)
								{
									flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag2)
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
									flag3 = (col == this.GridEX1.RootTable.Columns["fee"].Position);
									if (flag3)
									{
										e.SuppressKeyPress = true;
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

		// Token: 0x06002922 RID: 10530 RVA: 0x001F2474 File Offset: 0x001F0674
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

		// Token: 0x06002923 RID: 10531 RVA: 0x001F2540 File Offset: 0x001F0740
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x001F256C File Offset: 0x001F076C
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

		// Token: 0x06002925 RID: 10533 RVA: 0x001F2B50 File Offset: 0x001F0D50
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

		// Token: 0x06002926 RID: 10534 RVA: 0x001F2B8C File Offset: 0x001F0D8C
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
					else
					{
						this.GridEX1.Col = this.GridEX1.RootTable.Columns["moshtari_Name"].Position;
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
						this.GridEX1_SelectionChanged(null, null);
					}
				}
			}
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x001F2C8C File Offset: 0x001F0E8C
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

		// Token: 0x06002928 RID: 10536 RVA: 0x001F2D30 File Offset: 0x001F0F30
		private void GetStatusInfo()
		{
			DataTable dataTable = Public_Function.FillData("SELECT    isnull( sum (Furush_Sardkhane_Detail.Jam_Kol),0) as jam_kol     FROM         Furush_Sardkhane_Detail INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN   Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where Furush_Sardkhane_Detail.moshtari_id in (-1,-2)   and Kharid_Sardkhane.num=" + Conversions.ToString(this.Num) + " union all    SELECT    isnull( sum (Furush_Sardkhane_Detail.Jam_Kol),0) as jam_kol    FROM         Furush_Sardkhane_Detail INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN   Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where Furush_Sardkhane_Detail.moshtari_id not in (-1,-2)   and Kharid_Sardkhane.num=" + Conversions.ToString(this.Num));
			this.LabelCommand7.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[0]["jam_kol"])));
			this.LabelCommand5.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[1]["jam_kol"])));
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x001F2DD4 File Offset: 0x001F0FD4
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x001F2E28 File Offset: 0x001F1028
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.Get_Daramad();
			this.Varedat.UpdateDaramad(Conversions.ToString(this.Num));
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x001F2EA4 File Offset: 0x001F10A4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.Isnew;
			if (flag)
			{
				bool flag2 = Public_Function.ConfirmDelete() == DialogResult.Yes;
				if (flag2)
				{
					this.Varedat.Delete(Conversions.ToString(this.ID));
					this.MeNew();
					this.txt_rizbar.Focus();
				}
			}
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x001F2EF8 File Offset: 0x001F10F8
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

		// Token: 0x0600292D RID: 10541 RVA: 0x001F30CC File Offset: 0x001F12CC
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
			this.GridEX1.Focus();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.Col = 1;
			this.GridEX1.GetRow().BeginEdit();
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x001F31AC File Offset: 0x001F13AC
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

		// Token: 0x0600292F RID: 10543 RVA: 0x00177D54 File Offset: 0x00175F54
		private void txt_desc_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
			}
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x0000A28A File Offset: 0x0000848A
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x0000A297 File Offset: 0x00008497
		private void CurrencyBox2_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem7_Click(null, null);
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x001F32B4 File Offset: 0x001F14B4
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar_ButtonClick(null, null);
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x001F32DC File Offset: 0x001F14DC
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.CurrencyBox2_ButtonClick(null, null);
			}
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x001F3304 File Offset: 0x001F1504
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

		// Token: 0x06002935 RID: 10549 RVA: 0x001F3378 File Offset: 0x001F1578
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

		// Token: 0x06002936 RID: 10550 RVA: 0x0000A2A4 File Offset: 0x000084A4
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0000A2AF File Offset: 0x000084AF
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x001F33DC File Offset: 0x001F15DC
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			bool enabled = this.ButtonItem16_2.Enabled;
			if (enabled)
			{
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x0600293A RID: 10554 RVA: 0x001F33FC File Offset: 0x001F15FC
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
			StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text4");
			stiText = (StiText)stiReport.GetComponentByName("Text26");
			stiText = (StiText)stiReport.GetComponentByName("Text27");
			stiText = (StiText)stiReport.GetComponentByName("Text28");
			stiText = (StiText)stiReport.GetComponentByName("Text36");
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Show(false);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x001F3520 File Offset: 0x001F1720
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

		// Token: 0x0600293C RID: 10556 RVA: 0x001F3610 File Offset: 0x001F1810
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
							string text = Conversions.ToString(Public_Function.ExecuteScalar("select daramad_sanad_id from kharid_sardkhane where num=" + Conversions.ToString(this.Num)));
							flag2 = (Operators.CompareString(text, string.Empty, false) != 0);
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

		// Token: 0x0600293D RID: 10557 RVA: 0x0000205D File Offset: 0x0000025D
		private void UiGroupBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000FBC RID: 4028
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000FBE RID: 4030
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000FBF RID: 4031
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000FC0 RID: 4032
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000FC1 RID: 4033
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000FC2 RID: 4034
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000FC3 RID: 4035
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000FC4 RID: 4036
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000FC5 RID: 4037
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000FC6 RID: 4038
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000FC7 RID: 4039
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000FC8 RID: 4040
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000FC9 RID: 4041
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000FCA RID: 4042
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000FCB RID: 4043
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000FCC RID: 4044
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000FCD RID: 4045
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000FCE RID: 4046
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000FCF RID: 4047
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000FD0 RID: 4048
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000FD1 RID: 4049
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000FD2 RID: 4050
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000FD3 RID: 4051
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000FD4 RID: 4052
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000FD5 RID: 4053
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000FD6 RID: 4054
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000FD7 RID: 4055
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000FD8 RID: 4056
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000FD9 RID: 4057
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000FDA RID: 4058
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000FDB RID: 4059
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000FDC RID: 4060
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000FDD RID: 4061
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000FDE RID: 4062
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000FDF RID: 4063
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000FE0 RID: 4064
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000FE1 RID: 4065
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000FE2 RID: 4066
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000FE3 RID: 4067
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000FE4 RID: 4068
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000FE5 RID: 4069
		[AccessedThroughProperty("lbl_daramad")]
		private Label _lbl_daramad;

		// Token: 0x04000FE6 RID: 4070
		[AccessedThroughProperty("lbl_sardkhane")]
		private CurrencyBox _lbl_sardkhane;

		// Token: 0x04000FE7 RID: 4071
		[AccessedThroughProperty("lbl_kerayekharid")]
		private CurrencyBox _lbl_kerayekharid;

		// Token: 0x04000FE8 RID: 4072
		[AccessedThroughProperty("lbl_sayer")]
		private CurrencyBox _lbl_sayer;

		// Token: 0x04000FE9 RID: 4073
		[AccessedThroughProperty("lbl_sardkhane2")]
		private CurrencyBox _lbl_sardkhane2;

		// Token: 0x04000FEA RID: 4074
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000FEB RID: 4075
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000FEC RID: 4076
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000FED RID: 4077
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000FEE RID: 4078
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000FEF RID: 4079
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000FF0 RID: 4080
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000FF1 RID: 4081
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000FF2 RID: 4082
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000FF3 RID: 4083
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000FF4 RID: 4084
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000FF5 RID: 4085
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000FF6 RID: 4086
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000FF7 RID: 4087
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000FF8 RID: 4088
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000FF9 RID: 4089
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000FFA RID: 4090
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000FFB RID: 4091
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000FFC RID: 4092
		[AccessedThroughProperty("ButtonItem16_2")]
		private ButtonItem _ButtonItem16_2;

		// Token: 0x04000FFD RID: 4093
		[AccessedThroughProperty("ButtonItem17_2")]
		private ButtonItem _ButtonItem17_2;

		// Token: 0x04000FFE RID: 4094
		[AccessedThroughProperty("ButtonItem18_2")]
		private ButtonItem _ButtonItem18_2;

		// Token: 0x04000FFF RID: 4095
		[AccessedThroughProperty("ButtonItem19_2")]
		private ButtonItem _ButtonItem19_2;

		// Token: 0x04001000 RID: 4096
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001001 RID: 4097
		[CompilerGenerated]
		private bool _Show_Preview;

		// Token: 0x04001002 RID: 4098
		private Varedat Varedat;

		// Token: 0x04001003 RID: 4099
		private Kharid_Sardkhane_detail RizKharid;

		// Token: 0x04001004 RID: 4100
		private Kharid_Sardkhane_Keraye kharid_keraye;

		// Token: 0x04001005 RID: 4101
		private Kala_To_Kala_Kharid kala_to_kala;

		// Token: 0x04001006 RID: 4102
		private Kharid_Sardkhane_Darsad Kharid_Sud;

		// Token: 0x04001007 RID: 4103
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04001008 RID: 4104
		public int GotoLineID;

		// Token: 0x04001009 RID: 4105
		private Frm_SelectItem frm;

		// Token: 0x0400100A RID: 4106
		private Sanad sanad;

		// Token: 0x0400100B RID: 4107
		private Sandugh Sandug;

		// Token: 0x0400100C RID: 4108
		private int ID;

		// Token: 0x0400100D RID: 4109
		public int Num;

		// Token: 0x0400100E RID: 4110
		private bool Isnew;

		// Token: 0x0400100F RID: 4111
		private decimal? Darsad_Sud;

		// Token: 0x04001010 RID: 4112
		private DataTable dt_Kharid;

		// Token: 0x04001011 RID: 4113
		private DataTable dt_Keraye;

		// Token: 0x04001012 RID: 4114
		private DataTable dt_Darsad;

		// Token: 0x04001013 RID: 4115
		private DataTable dt_kala_to_kala;

		// Token: 0x04001014 RID: 4116
		private DataTable dt_mande;

		// Token: 0x04001015 RID: 4117
		private bool prevent_close;

		// Token: 0x04001016 RID: 4118
		private bool prevent_right;

		// Token: 0x04001017 RID: 4119
		private bool prevent_left;
	}
}
