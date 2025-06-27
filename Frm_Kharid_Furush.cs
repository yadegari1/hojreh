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
	// Token: 0x020000FA RID: 250
	[DesignerGenerated]
	public partial class Frm_Kharid_Furush : Form
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x0015D4FC File Offset: 0x0015B6FC
		public Frm_Kharid_Furush()
		{
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			base.Resize += new EventHandler(this.Frm_Kharid_Furush_Resize);
			base.KeyDown += new KeyEventHandler(this.Frm_Kharid_Furush_KeyDown);
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			Frm_Kharid_Furush.__ENCAddToList(this);
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			this.Kharid = new Kharid();
			this.RizKharid = new Kharid_Detail();
			this.kharid_keraye = new Kharid_Keraye();
			this.kala_to_kala = new Kala_To_Kala_Kharid();
			this.Kharid_Sud = new Kharid_Darsad();
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
			this.prevent_enter = false;
			this.frm_furush = new Frm_SelectItem();
			this.InitializeComponent();
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0015D634 File Offset: 0x0015B834
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Kharid_Furush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Kharid_Furush.__ENCList.Count == Frm_Kharid_Furush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Kharid_Furush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Kharid_Furush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Kharid_Furush.__ENCList[num] = Frm_Kharid_Furush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Kharid_Furush.__ENCList.RemoveRange(num, Frm_Kharid_Furush.__ENCList.Count - num);
						Frm_Kharid_Furush.__ENCList.Capacity = Frm_Kharid_Furush.__ENCList.Count;
					}
					Frm_Kharid_Furush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00160CFC File Offset: 0x0015EEFC
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0000812A File Offset: 0x0000632A
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

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00160D14 File Offset: 0x0015EF14
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00008134 File Offset: 0x00006334
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

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00160D2C File Offset: 0x0015EF2C
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000813E File Offset: 0x0000633E
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

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00160D44 File Offset: 0x0015EF44
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00008148 File Offset: 0x00006348
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00160D5C File Offset: 0x0015EF5C
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00008152 File Offset: 0x00006352
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

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00160D74 File Offset: 0x0015EF74
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000815C File Offset: 0x0000635C
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

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00160D8C File Offset: 0x0015EF8C
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00008166 File Offset: 0x00006366
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

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00160DA4 File Offset: 0x0015EFA4
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00008170 File Offset: 0x00006370
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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00160DBC File Offset: 0x0015EFBC
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00160DD4 File Offset: 0x0015EFD4
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

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00160F08 File Offset: 0x0015F108
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00160F20 File Offset: 0x0015F120
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

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00160F80 File Offset: 0x0015F180
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0000817A File Offset: 0x0000637A
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

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00160F98 File Offset: 0x0015F198
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00008184 File Offset: 0x00006384
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
				this._txt_sh_barname = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00160FB0 File Offset: 0x0015F1B0
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0000818E File Offset: 0x0000638E
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

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00160FC8 File Offset: 0x0015F1C8
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00160FE0 File Offset: 0x0015F1E0
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				RowLoadEventHandler value3 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				KeyEventHandler value5 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value7 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value8 = new EventHandler(this.GridEX1_SelectionChanged);
				EndCustomEditEventHandler value9 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.LoadingRow -= value3;
					this._GridEX1.KeyPress -= value4;
					this._GridEX1.KeyDown -= value5;
					this._GridEX1.CellEdited -= value6;
					this._GridEX1.InitCustomEdit -= value7;
					this._GridEX1.SelectionChanged -= value8;
					this._GridEX1.EndCustomEdit -= value9;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.LoadingRow += value3;
					this._GridEX1.KeyPress += value4;
					this._GridEX1.KeyDown += value5;
					this._GridEX1.CellEdited += value6;
					this._GridEX1.InitCustomEdit += value7;
					this._GridEX1.SelectionChanged += value8;
					this._GridEX1.EndCustomEdit += value9;
				}
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00161168 File Offset: 0x0015F368
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00008198 File Offset: 0x00006398
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

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00161180 File Offset: 0x0015F380
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00161198 File Offset: 0x0015F398
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

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x001611F8 File Offset: 0x0015F3F8
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00161210 File Offset: 0x0015F410
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

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00161270 File Offset: 0x0015F470
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00161288 File Offset: 0x0015F488
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

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x001612E8 File Offset: 0x0015F4E8
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00161300 File Offset: 0x0015F500
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

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00161360 File Offset: 0x0015F560
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00161378 File Offset: 0x0015F578
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

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x001613D8 File Offset: 0x0015F5D8
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x001613F0 File Offset: 0x0015F5F0
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

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00161450 File Offset: 0x0015F650
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00161468 File Offset: 0x0015F668
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x001614C8 File Offset: 0x0015F6C8
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x001614E0 File Offset: 0x0015F6E0
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

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00161540 File Offset: 0x0015F740
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x000081A2 File Offset: 0x000063A2
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00161558 File Offset: 0x0015F758
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x000081AC File Offset: 0x000063AC
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

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00161570 File Offset: 0x0015F770
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x000081B6 File Offset: 0x000063B6
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00161588 File Offset: 0x0015F788
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x000081C0 File Offset: 0x000063C0
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x001615A0 File Offset: 0x0015F7A0
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x000081CA File Offset: 0x000063CA
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x001615B8 File Offset: 0x0015F7B8
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x000081D4 File Offset: 0x000063D4
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

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x001615D0 File Offset: 0x0015F7D0
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x000081DE File Offset: 0x000063DE
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

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x001615E8 File Offset: 0x0015F7E8
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x000081E8 File Offset: 0x000063E8
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00161600 File Offset: 0x0015F800
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x000081F2 File Offset: 0x000063F2
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

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00161618 File Offset: 0x0015F818
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x000081FC File Offset: 0x000063FC
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00161630 File Offset: 0x0015F830
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00008206 File Offset: 0x00006406
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00161648 File Offset: 0x0015F848
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00008210 File Offset: 0x00006410
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

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00161660 File Offset: 0x0015F860
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00161678 File Offset: 0x0015F878
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x001616D8 File Offset: 0x0015F8D8
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x001616F0 File Offset: 0x0015F8F0
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

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00161778 File Offset: 0x0015F978
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0000821A File Offset: 0x0000641A
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00161790 File Offset: 0x0015F990
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x00008224 File Offset: 0x00006424
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

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x001617A8 File Offset: 0x0015F9A8
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x001617C0 File Offset: 0x0015F9C0
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

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00161848 File Offset: 0x0015FA48
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0000822E File Offset: 0x0000642E
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00161860 File Offset: 0x0015FA60
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00161878 File Offset: 0x0015FA78
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00161900 File Offset: 0x0015FB00
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00008238 File Offset: 0x00006438
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00161918 File Offset: 0x0015FB18
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00008242 File Offset: 0x00006442
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

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00161930 File Offset: 0x0015FB30
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0000824C File Offset: 0x0000644C
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00161948 File Offset: 0x0015FB48
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00008256 File Offset: 0x00006456
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

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00161960 File Offset: 0x0015FB60
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00008260 File Offset: 0x00006460
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

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00161978 File Offset: 0x0015FB78
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0000826A File Offset: 0x0000646A
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

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00161990 File Offset: 0x0015FB90
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x00008274 File Offset: 0x00006474
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

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x001619A8 File Offset: 0x0015FBA8
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0000827E File Offset: 0x0000647E
		internal virtual CurrencyBox txt_jam_keraye
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam_keraye;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jam_keraye = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x001619C0 File Offset: 0x0015FBC0
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x00008288 File Offset: 0x00006488
		internal virtual CurrencyBox txt_jam_kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam_kharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jam_kharid = value;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x001619D8 File Offset: 0x0015FBD8
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x00008292 File Offset: 0x00006492
		internal virtual CurrencyBox txt_jam_daramad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam_daramad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jam_daramad = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x001619F0 File Offset: 0x0015FBF0
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0000829C File Offset: 0x0000649C
		internal virtual CurrencyBox txt_jam_furush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam_furush;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jam_furush = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00161A08 File Offset: 0x0015FC08
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00161A20 File Offset: 0x0015FC20
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

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00161A80 File Offset: 0x0015FC80
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x000082A6 File Offset: 0x000064A6
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

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00161A98 File Offset: 0x0015FC98
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x000082B0 File Offset: 0x000064B0
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00161AB0 File Offset: 0x0015FCB0
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x000082BA File Offset: 0x000064BA
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

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00161AC8 File Offset: 0x0015FCC8
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x000082C4 File Offset: 0x000064C4
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

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00161AE0 File Offset: 0x0015FCE0
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x000082CE File Offset: 0x000064CE
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

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00161AF8 File Offset: 0x0015FCF8
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x000082D8 File Offset: 0x000064D8
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x00161B10 File Offset: 0x0015FD10
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x000082E2 File Offset: 0x000064E2
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

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x00161B28 File Offset: 0x0015FD28
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x000082EC File Offset: 0x000064EC
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

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00161B40 File Offset: 0x0015FD40
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x000082F6 File Offset: 0x000064F6
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00161B58 File Offset: 0x0015FD58
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00161B70 File Offset: 0x0015FD70
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00161BD0 File Offset: 0x0015FDD0
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x00161BE8 File Offset: 0x0015FDE8
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

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00161C48 File Offset: 0x0015FE48
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00161C60 File Offset: 0x0015FE60
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

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00161CC0 File Offset: 0x0015FEC0
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x00161CD8 File Offset: 0x0015FED8
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00161D38 File Offset: 0x0015FF38
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x00008300 File Offset: 0x00006500
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00161D50 File Offset: 0x0015FF50
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x00161D68 File Offset: 0x0015FF68
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

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x00161DC8 File Offset: 0x0015FFC8
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x00161DE0 File Offset: 0x0015FFE0
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00161E40 File Offset: 0x00160040
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x00161E58 File Offset: 0x00160058
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

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00161EB8 File Offset: 0x001600B8
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x00161ED0 File Offset: 0x001600D0
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

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00161F30 File Offset: 0x00160130
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x00161F48 File Offset: 0x00160148
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

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00161FA8 File Offset: 0x001601A8
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x00161FC0 File Offset: 0x001601C0
		internal virtual ButtonItem Btn_Daryaft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Btn_Daryaft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem20_Click);
				bool flag = this._Btn_Daryaft != null;
				if (flag)
				{
					this._Btn_Daryaft.Click -= value2;
				}
				this._Btn_Daryaft = value;
				flag = (this._Btn_Daryaft != null);
				if (flag)
				{
					this._Btn_Daryaft.Click += value2;
				}
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00162020 File Offset: 0x00160220
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x00162038 File Offset: 0x00160238
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x00162098 File Offset: 0x00160298
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x001620B0 File Offset: 0x001602B0
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

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x00162110 File Offset: 0x00160310
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0000830A File Offset: 0x0000650A
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

		// Token: 0x06001E41 RID: 7745 RVA: 0x00162128 File Offset: 0x00160328
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00162164 File Offset: 0x00160364
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

		// Token: 0x06001E43 RID: 7747 RVA: 0x001621F8 File Offset: 0x001603F8
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

		// Token: 0x06001E44 RID: 7748 RVA: 0x00162380 File Offset: 0x00160580
		private bool CanClose()
		{
			bool result = false;
			bool flag = this.Isnew && this.txt_moshtari.Value == null && Operators.CompareString(this.txt_sh_mashin.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_sh_barname.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_makharej.Text, string.Empty, false) == 0 && this.Grid_RizBar.RowCount == 0 && this.GridEX1.RowCount == 1;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00162420 File Offset: 0x00160620
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
										else
										{
											flag2 = (keyCode == Keys.F9);
											if (flag2)
											{
												this.ButtonItem14_Click(null, null);
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

		// Token: 0x06001E46 RID: 7750 RVA: 0x001625F0 File Offset: 0x001607F0
		private void frm_Frush_hag_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("num", "سند", 15));
			itemCollection.Add(new Column("Moshtari_Name", "صاحب بار", 65));
			this.frm_furush.items = itemCollection;
			this.txt_num.UiButton2.Image = null;
			this.txt_num.UiButton2.Text = "...";
			bool flag = !Conversions.ToBoolean(Public_Function.dict["show_avg"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["avg"].Visible = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			bool flag2;
			if (flag)
			{
				flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				}
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Caption = "وزن ناخالص";
				this.GridEX1.RootTable.Columns["zarf"].Caption = "افت";
				this.GridEX1.RootTable.Columns["zarf"].AggregateFunction = AggregateFunction.None;
				this.GridEX1.RootTable.Columns["zarf"].AggregateFunction = AggregateFunction.Sum;
				this.GridEX1.Refresh();
			}
			flag2 = (Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 2.0);
			checked
			{
				if (flag2)
				{
					this.Label5.Visible = false;
					this.txt_moshtari.Visible = false;
					int num = this.txt_num.Bottom - this.txt_moshtari.Top - 1;
					this.txt_rizbar.Top = this.txt_num.Bottom + num;
					this.Label2.Top = (int)Math.Round(unchecked((double)this.txt_rizbar.Top + (double)this.txt_rizbar.Height / 4.0));
					this.txt_sh_mashin.Top = this.txt_rizbar.Bottom + num;
					this.Label9.Top = (int)Math.Round(unchecked((double)this.txt_sh_mashin.Top + (double)this.txt_sh_mashin.Height / 4.0));
					this.txt_sh_barname.Top = this.txt_sh_mashin.Bottom + num;
					this.Label10.Top = (int)Math.Round(unchecked((double)this.txt_sh_barname.Top + (double)this.txt_sh_barname.Height / 4.0));
					this.txt_tarikh_vurud.Top = this.txt_sh_barname.Bottom + num;
					this.Label11.Top = (int)Math.Round(unchecked((double)this.txt_tarikh_vurud.Top + (double)this.txt_tarikh_vurud.Height / 4.0));
					this.txt_makharej.Top = this.txt_tarikh_vurud.Bottom + num;
					this.Label3.Top = (int)Math.Round(unchecked((double)this.txt_makharej.Top + (double)this.txt_makharej.Height / 4.0));
					this.txt_desc.Top = this.txt_makharej.Bottom + num;
					this.Label12.Top = (int)Math.Round(unchecked((double)this.txt_desc.Top + (double)this.txt_desc.Height / 4.0));
					this.Grid_RizBar.Height = this.txt_desc.Bottom - 6;
					int top = this.GridEX1.Top;
					this.GridEX1.Top = this.Grid_RizBar.Bottom + 5;
				}
				this.txt_moshtari.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
				ItemCollection itemCollection2 = new ItemCollection();
				itemCollection2.Add(new Column("code", "کد", 15));
				itemCollection2.Add(new Column("Name", "عنوان", 65));
				itemCollection2.Add(new Column("shahr", "منطقه", 20));
				this.frm.items = itemCollection2;
				flag2 = Conversions.ToBoolean(Public_Function.dict["kargari"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["kargari"].Visible = true;
					this.GridEX1.RootTable.Columns["jamkol_ba_kargari"].Visible = true;
				}
				else
				{
					this.GridEX1.RootTable.Columns["kargari"].Visible = false;
					this.GridEX1.RootTable.Columns["jamkol_ba_kargari"].Visible = false;
				}
				flag2 = (this.Num == -1);
				if (flag2)
				{
					this.MeNew();
				}
				else
				{
					this.LoadData();
					flag2 = this.Show_Preview;
					if (flag2)
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
					flag2 = (this.GotoLineID != -1);
					if (flag2)
					{
						GridEXRow[] rows = this.GridEX1.GetRows();
						for (int i = 0; i < rows.Length; i++)
						{
							GridEXRow gridEXRow = rows[i];
							flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["ID"], this.GotoLineID, false);
							if (flag)
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
				this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
				this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			}
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x06001E48 RID: 7752 RVA: 0x00162CF0 File Offset: 0x00160EF0
		private void Moshtari_Select()
		{
			bool flag = Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0 && this.txt_moshtari.Value == null;
			checked
			{
				if (flag)
				{
					this.txt_moshtari.ShowTip("لطفا ابتدا صاحب بار را مشخص فرمائید ");
				}
				else
				{
					this.frm.CanEdit = true;
					this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
					this.frm.CanDelete = false;
					string str = string.Empty;
					flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
					if (flag)
					{
						str = ",-3";
					}
					flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE moshtari.id not in(-2,-4,-5" + str + ") order by moshtari.code", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
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

		// Token: 0x06001E49 RID: 7753 RVA: 0x00162EF4 File Offset: 0x001610F4
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

		// Token: 0x06001E4A RID: 7754 RVA: 0x00162FA8 File Offset: 0x001611A8
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

		// Token: 0x06001E4B RID: 7755 RVA: 0x00163070 File Offset: 0x00161270
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

		// Token: 0x06001E4C RID: 7756 RVA: 0x00163178 File Offset: 0x00161378
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

		// Token: 0x06001E4D RID: 7757 RVA: 0x001633D4 File Offset: 0x001615D4
		private void Kala_select()
		{
			bool flag = Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0 && this.txt_moshtari.Value == null;
			checked
			{
				if (flag)
				{
					Public_Function.ShowMessage("لطفا صاحب بار را انتخاب فرمائید", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					this.txt_moshtari.Focus();
				}
				else
				{
					string str = string.Empty;
					flag = (this.dt_Kharid != null && this.dt_Kharid.Rows.Count > 0);
					if (flag)
					{
						string iD = Public_Function.GetID(this.dt_Kharid, "kala_id", "");
						flag = (iD.Length > 0);
						if (flag)
						{
							str = " where id in(" + iD + ")";
						}
						string command = "SELECT     Kala.ID, Kala.Name  FROM         kala " + str;
						flag = (this.GridEX1.CurrentRow.Cells["prekala_id"].Value != DBNull.Value);
						int? num;
						if (flag)
						{
							object expr_121 = this.GridEX1.CurrentRow.Cells["prekala_id"].Value;
							int? num2;
							num = ((expr_121 != null) ? ((int?)expr_121) : num2);
						}
						this.frm.CanEdit = false;
						this.frm.ExtraData = Conversions.ToLong(this.txt_moshtari.Value);
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
											dataRow["Kharid_ID"] = this.ID;
											dataRow["child_kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
											dataRow["Parent_kala_id"] = RuntimeHelpers.GetObjectValue(frm_Select_Kala_To_Kala.Selected_Row.Cells["Kala_ID"].Value);
											this.dt_kala_to_kala.Rows.Add(dataRow);
											DataRow dataRow2 = this.dt_Kharid.NewRow();
											dataRow2["kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
											dataRow2["kala_name"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"]);
											int num3 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
											dataRow2["fee"] = RuntimeHelpers.GetObjectValue(this.dt_Kharid.Rows[num3]["fee"]);
											dataRow2["auto"] = true;
											flag2 = num.HasValue;
											if (flag2)
											{
												DataRow[] array = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
												flag2 = (array.Length > 0);
												if (flag2)
												{
													flag = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
													if (flag)
													{
														DataRow[] array2 = array;
														DataRow[] arg_5A4_0 = array2;
														int num4 = 0;
														DataRow arg_5DE_0 = arg_5A4_0[num4];
														string columnName = "tedad";
														arg_5DE_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
													}
													flag2 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array;
														DataRow[] arg_61F_0 = array2;
														int num4 = 0;
														DataRow arg_659_0 = arg_61F_0[num4];
														string columnName = "vazn_ba_zarf";
														arg_659_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
													}
													this.Calc_mablagh_kharid_org(array[0]);
													this.CheckForDeleteKharid(array[0]);
												}
											}
											flag2 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
											if (flag2)
											{
												dataRow2["tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
											}
											else
											{
												dataRow2["tedad"] = 0;
											}
											flag2 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
											if (flag2)
											{
												dataRow2["vazn_ba_zarf"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
											}
											else
											{
												dataRow2["vazn_ba_zarf"] = 0;
											}
											flag2 = (this.dt_Kharid.Rows[num3]["zarf"] != DBNull.Value);
											if (flag2)
											{
												dataRow2["zarf"] = RuntimeHelpers.GetObjectValue(this.dt_Kharid.Rows[num3]["zarf"]);
											}
											this.dt_Kharid.Rows.InsertAt(dataRow2, num3 + 1);
											((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num3;
											this.Calc_mablagh_kharid(dataRow2);
											this.SyncTedad();
										}
										else
										{
											flag2 = !this.Is_In_Kharid_auto(Conversions.ToLong(this.frm.SelectedRow["ID"]));
											if (flag2)
											{
												DataRow dataRow3 = this.dt_Kharid.NewRow();
												dataRow3["kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
												dataRow3["kala_name"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["name"]);
												int num5 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
												dataRow3["fee"] = RuntimeHelpers.GetObjectValue(this.dt_Kharid.Rows[num5]["fee"]);
												dataRow3["auto"] = true;
												flag2 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
												if (flag2)
												{
													dataRow3["tedad"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["tedad"].Value);
												}
												else
												{
													dataRow3["tedad"] = 0;
												}
												flag2 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
												if (flag2)
												{
													dataRow3["vazn_ba_zarf"] = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
												}
												else
												{
													dataRow3["vazn_ba_zarf"] = 0;
												}
												flag2 = num.HasValue;
												if (flag2)
												{
													int num6 = this.Get_Parent_Kala_Index_IN_Kharid(unchecked((long)((T)num)));
													flag2 = (num6 != -1);
													if (flag2)
													{
														flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag)
														{
															DataRow dataRow4 = this.dt_Kharid.Rows[num6];
															DataRow arg_ADD_0 = dataRow4;
															string columnName = "tedad";
															arg_ADD_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag2)
														{
															DataRow dataRow4 = this.dt_Kharid.Rows[num6];
															DataRow arg_B5F_0 = dataRow4;
															string columnName = "vazn_ba_zarf";
															arg_B5F_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
														}
														this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[num6]);
														DataRow[] array3 = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
														flag2 = (array3.Length > 0);
														if (flag2)
														{
															flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
															if (flag)
															{
																DataRow[] array2 = array3;
																DataRow[] arg_BF8_0 = array2;
																int num4 = 0;
																DataRow arg_C32_0 = arg_BF8_0[num4];
																string columnName = "tedad";
																arg_C32_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
															}
															flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
															if (flag2)
															{
																DataRow[] array2 = array3;
																DataRow[] arg_C73_0 = array2;
																int num4 = 0;
																DataRow arg_CAD_0 = arg_C73_0[num4];
																string columnName = "vazn_ba_zarf";
																arg_CAD_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
															}
															this.CheckForDeleteKharid(array3[0]);
															flag2 = (array3[0].RowState != DataRowState.Detached);
															if (flag2)
															{
																this.Calc_mablagh_kharid(array3[0]);
															}
														}
													}
												}
												flag2 = (this.dt_Kharid.Rows[num5]["zarf"] != DBNull.Value);
												if (flag2)
												{
													dataRow3["zarf"] = RuntimeHelpers.GetObjectValue(this.dt_Kharid.Rows[num5]["zarf"]);
												}
												this.dt_Kharid.Rows.InsertAt(dataRow3, num5 + 1);
												((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num5;
												flag2 = (this.GridEX1.CurrentRow.Cells["tedad"].Value != DBNull.Value);
												if (flag2)
												{
													DataRow dataRow4 = this.dt_Kharid.Rows[num5];
													DataRow arg_DFA_0 = dataRow4;
													string columnName = "tedad";
													arg_DFA_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
												}
												flag2 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
												if (flag2)
												{
													DataRow dataRow4 = this.dt_Kharid.Rows[num5];
													DataRow arg_E7C_0 = dataRow4;
													string columnName = "vazn_ba_zarf";
													arg_E7C_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
												}
											}
											else
											{
												flag2 = num.HasValue;
												if (flag2)
												{
													int num7 = this.Get_Parent_Kala_Index_IN_Kharid(unchecked((long)((T)num)));
													flag2 = (num7 != -1);
													if (flag2)
													{
														flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag)
														{
															DataRow dataRow4 = this.dt_Kharid.Rows[num7];
															DataRow arg_F34_0 = dataRow4;
															string columnName = "tedad";
															arg_F34_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag2)
														{
															DataRow dataRow4 = this.dt_Kharid.Rows[num7];
															DataRow arg_FB6_0 = dataRow4;
															string columnName = "vazn_ba_zarf";
															arg_FB6_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
														}
														this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[num7]);
														DataRow[] array4 = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
														flag2 = (array4.Length > 0);
														if (flag2)
														{
															flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
															if (flag)
															{
																DataRow[] array2 = array4;
																DataRow[] arg_104F_0 = array2;
																int num4 = 0;
																DataRow arg_1089_0 = arg_104F_0[num4];
																string columnName = "tedad";
																arg_1089_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
															}
															flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
															if (flag2)
															{
																DataRow[] array2 = array4;
																DataRow[] arg_10CA_0 = array2;
																int num4 = 0;
																DataRow arg_1104_0 = arg_10CA_0[num4];
																string columnName = "vazn_ba_zarf";
																arg_1104_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
															}
															this.CheckForDeleteKharid(array4[0]);
															flag2 = (array4[0].RowState != DataRowState.Detached);
															if (flag2)
															{
																this.Calc_mablagh_kharid(array4[0]);
															}
														}
													}
												}
												int num8 = this.Get_Parent_Kala_Index_IN_Kharid(Conversions.ToLong(this.frm.SelectedRow["ID"]));
												((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] = num8;
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
												if (flag2)
												{
													DataRow dataRow4 = this.dt_Kharid.Rows[num8];
													DataRow arg_11FE_0 = dataRow4;
													string columnName = "tedad";
													arg_11FE_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag2)
												{
													DataRow dataRow4 = this.dt_Kharid.Rows[num8];
													DataRow arg_1280_0 = dataRow4;
													string columnName = "vazn_ba_zarf";
													arg_1280_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
												}
												DataRow[] array5 = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.frm.SelectedRow["ID"])));
												flag2 = (array5.Length > 0);
												if (flag2)
												{
													flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
													if (flag)
													{
														DataRow[] array2 = array5;
														DataRow[] arg_1302_0 = array2;
														int num4 = 0;
														DataRow arg_133C_0 = arg_1302_0[num4];
														string columnName = "tedad";
														arg_133C_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array5;
														DataRow[] arg_137D_0 = array2;
														int num4 = 0;
														DataRow arg_13B7_0 = arg_137D_0[num4];
														string columnName = "vazn_ba_zarf";
														arg_13B7_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
										flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"] != DBNull.Value);
										if (flag2)
										{
											flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
											if (flag)
											{
												DataRow dataRow4 = this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_14AB_0 = dataRow4;
												string columnName = "tedad";
												arg_14AB_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
											flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
											if (flag2)
											{
												DataRow dataRow4 = this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_154F_0 = dataRow4;
												string columnName = "vazn_ba_zarf";
												arg_154F_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
											}
											this.Calc_mablagh_kharid_org(this.dt_Kharid.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]);
											flag2 = num.HasValue;
											if (flag2)
											{
												DataRow[] array6 = this.dt_Kharid.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
												flag2 = (array6.Length > 0);
												if (flag2)
												{
													flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
													if (flag)
													{
														DataRow[] array2 = array6;
														DataRow[] arg_161A_0 = array2;
														int num4 = 0;
														DataRow arg_1654_0 = arg_161A_0[num4];
														string columnName = "tedad";
														arg_1654_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array6;
														DataRow[] arg_1695_0 = array2;
														int num4 = 0;
														DataRow arg_16CF_0 = arg_1695_0[num4];
														string columnName = "vazn_ba_zarf";
														arg_16CF_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													this.Calc_mablagh_kharid(array6[0]);
													this.CheckForDeleteKharid(array6[0]);
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
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00164B40 File Offset: 0x00162D40
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

		// Token: 0x06001E4F RID: 7759 RVA: 0x00164C44 File Offset: 0x00162E44
		private void Calc()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (!flag)
			{
				flag = (this.GridEX1.GetRow().Cells["Tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Tedad"].Value != null);
				decimal? num2;
				decimal? num;
				if (flag)
				{
					object expr_93 = this.GridEX1.GetRow().Cells["Tedad"].Value;
					num = ((expr_93 != null) ? ((decimal?)expr_93) : num2);
				}
				flag = (this.GridEX1.GetRow().Cells["Zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Zarf"].Value != null);
				decimal? num3;
				if (flag)
				{
					object expr_118 = this.GridEX1.GetRow().Cells["Zarf"].Value;
					num3 = ((expr_118 != null) ? ((decimal?)expr_118) : num2);
				}
				flag = (this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != null);
				decimal? num4;
				if (flag)
				{
					object expr_19D = this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value;
					num4 = ((expr_19D != null) ? ((decimal?)expr_19D) : num2);
				}
				flag = (num.HasValue && num4.HasValue && num3.HasValue);
				bool flag4;
				if (flag)
				{
					decimal? arg_214_0;
					if (!(num3.HasValue & num.HasValue))
					{
						arg_214_0 = null;
					}
					else
					{
						decimal? num5 = new decimal?(decimal.Multiply(num3.GetValueOrDefault(), num.GetValueOrDefault()));
						arg_214_0 = num5;
					}
					decimal? num6 = arg_214_0;
					bool? arg_256_0;
					if (!(num6.HasValue & num4.HasValue))
					{
						arg_256_0 = null;
					}
					else
					{
						bool? flag2 = new bool?(decimal.Compare(num6.GetValueOrDefault(), num4.GetValueOrDefault()) >= 0);
						arg_256_0 = flag2;
					}
					bool? flag3 = arg_256_0;
					flag4 = flag3.GetValueOrDefault();
					if (flag4)
					{
						this.GridEX1.CurrentRow.Cells["Zarf"].Value = DBNull.Value;
						this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = num4;
						this.GetSum("zarf", false);
					}
					else
					{
						GridEXCell arg_362_0 = this.GridEX1.CurrentRow.Cells["vazn_kol"];
						bool arg_327_0 = num4.HasValue;
						decimal? arg_31E_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_31E_0 = null;
						}
						else
						{
							decimal? num7 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_31E_0 = num7;
						}
						decimal? num5 = arg_31E_0;
						decimal? arg_353_0;
						if (!(arg_327_0 & num5.HasValue))
						{
							arg_353_0 = null;
						}
						else
						{
							num6 = new decimal?(decimal.Subtract(num4.GetValueOrDefault(), num5.GetValueOrDefault()));
							arg_353_0 = num6;
						}
						arg_362_0.Value = Public_Function.GetDecimalValue((T)arg_353_0);
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
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0016501C File Offset: 0x0016321C
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
						flag3 = (decimal.Compare(Math.Abs(value), new decimal(100L)) > 0);
						if (flag3)
						{
							GridEXCell arg_3E2_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
							decimal? arg_3DD_0;
							if (!(num.HasValue & num3.HasValue))
							{
								arg_3DD_0 = null;
							}
							else
							{
								decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
								arg_3DD_0 = num5;
							}
							arg_3E2_0.Value = arg_3DD_0;
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
					bool? arg_44D_0;
					if (!num.HasValue)
					{
						arg_44D_0 = null;
					}
					else
					{
						bool? flag4 = new bool?(decimal.Compare(num.GetValueOrDefault(), zero) == 0);
						arg_44D_0 = flag4;
					}
					bool? flag5 = arg_44D_0;
					flag = flag5.GetValueOrDefault();
					if (!flag)
					{
						GridEXCell arg_4B8_0 = this.GridEX1.CurrentRow.Cells["fee"];
						decimal? arg_4B3_0;
						if (!(num4.HasValue & num.HasValue))
						{
							arg_4B3_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Divide(num4.GetValueOrDefault(), num.GetValueOrDefault()));
							arg_4B3_0 = num5;
						}
						arg_4B8_0.Value = arg_4B3_0;
					}
				}
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x001654EC File Offset: 0x001636EC
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

		// Token: 0x06001E52 RID: 7762 RVA: 0x001655F0 File Offset: 0x001637F0
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

		// Token: 0x06001E53 RID: 7763 RVA: 0x0016573C File Offset: 0x0016393C
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
				bool flag2 = row["vazn_Kol"] != DBNull.Value && row["fee"] != DBNull.Value;
				if (flag2)
				{
					row["jam_kol"] = Operators.MultiplyObject(row["fee"], row["vazn_Kol"]);
				}
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x001658A0 File Offset: 0x00163AA0
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

		// Token: 0x06001E55 RID: 7765 RVA: 0x00165C4C File Offset: 0x00163E4C
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

		// Token: 0x06001E56 RID: 7766 RVA: 0x00165DD4 File Offset: 0x00163FD4
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

		// Token: 0x06001E57 RID: 7767 RVA: 0x00165E04 File Offset: 0x00164004
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

		// Token: 0x06001E58 RID: 7768 RVA: 0x00165F8C File Offset: 0x0016418C
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

		// Token: 0x06001E59 RID: 7769 RVA: 0x001660B4 File Offset: 0x001642B4
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

		// Token: 0x06001E5A RID: 7770 RVA: 0x00166190 File Offset: 0x00164390
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x001665B0 File Offset: 0x001647B0
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

		// Token: 0x06001E5C RID: 7772 RVA: 0x001666C8 File Offset: 0x001648C8
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

		// Token: 0x06001E5D RID: 7773 RVA: 0x001667E0 File Offset: 0x001649E0
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

		// Token: 0x06001E5E RID: 7774 RVA: 0x00166858 File Offset: 0x00164A58
		private void Calc_oft2()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != null && this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value;
				if (flag2)
				{
					this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = Operators.SubtractObject(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value, this.GridEX1.CurrentRow.Cells["zarf"].Value);
				}
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00166938 File Offset: 0x00164B38
		private void Calc_oft()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != null && this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value;
				if (flag2)
				{
					this.GridEX1.CurrentRow.Cells["zarf"].Value = Operators.ModObject(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value, 10);
					this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = Operators.SubtractObject(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value, Operators.ModObject(this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value, 10));
				}
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00166A74 File Offset: 0x00164C74
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
						this.Calc_oft();
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
								this.Calc_oft2();
								this.SyncTedad();
							}
							else
							{
								flag2 = (Operators.CompareString(left, "fee", false) == 0);
								if (flag2)
								{
									this.CalcMablagh(true, false);
									this.Get_Daramad();
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
										this.Get_Daramad();
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

		// Token: 0x06001E61 RID: 7777 RVA: 0x001671D4 File Offset: 0x001653D4
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
							DataRow[] array = this.dt_Kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.GetRow().Cells["kala_id"].Value)));
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

		// Token: 0x06001E62 RID: 7778 RVA: 0x001677DC File Offset: 0x001659DC
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

		// Token: 0x06001E63 RID: 7779 RVA: 0x00167A28 File Offset: 0x00165C28
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
						this.RizKharid.Update(this.ID, this.dt_Kharid, Conversions.ToInteger(Public_Function.dict["kharid_kind"]));
					}
				}
			}
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00168048 File Offset: 0x00166248
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

		// Token: 0x06001E65 RID: 7781 RVA: 0x00132FC8 File Offset: 0x001311C8
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

		// Token: 0x06001E66 RID: 7782 RVA: 0x001680F4 File Offset: 0x001662F4
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

		// Token: 0x06001E67 RID: 7783 RVA: 0x00168298 File Offset: 0x00166498
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
						int col = this.GridEX1.Col;
						bool flag2 = col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
						if (flag2)
						{
							flag = (this.GridEX1.EditTextBox == null);
							if (flag)
							{
								this.GridEX1.GetRow().BeginEdit();
								this.GridEX1.EditMode = EditMode.EditOn;
							}
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
									flag3 = (col == this.GridEX1.RootTable.Columns["jam_kol"].Position);
									if (!flag3)
									{
										flag3 = (col == this.GridEX1.RootTable.Columns["kargari"].Position);
										if (!flag3)
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

		// Token: 0x06001E68 RID: 7784 RVA: 0x001688AC File Offset: 0x00166AAC
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

		// Token: 0x06001E69 RID: 7785 RVA: 0x001688F0 File Offset: 0x00166AF0
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

		// Token: 0x06001E6A RID: 7786 RVA: 0x00168AD4 File Offset: 0x00166CD4
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

		// Token: 0x06001E6B RID: 7787 RVA: 0x00168CF8 File Offset: 0x00166EF8
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
			flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				}
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00168E2C File Offset: 0x0016702C
		private void MeNew()
		{
			this.Load_Default_Nahve_Furush();
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
			this.lbl_daramad.Text = string.Empty;
			this.Grid_RizBar.DataSource = null;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00168F18 File Offset: 0x00167118
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

		// Token: 0x06001E6E RID: 7790 RVA: 0x00168F84 File Offset: 0x00167184
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

		// Token: 0x06001E6F RID: 7791 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x06001E70 RID: 7792 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x06001E71 RID: 7793 RVA: 0x00169474 File Offset: 0x00167674
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
						IEnumerator enumerator = this.dt_Kharid.Rows.GetEnumerator();
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
									RuntimeHelpers.GetObjectValue(dataRow["vazn_ba_zarf"]),
									RuntimeHelpers.GetObjectValue(dataRow["kala_name"])
								});
							}
							else
							{
								flag = (dataRow["tedad"] != DBNull.Value);
								if (flag)
								{
									DataRow[] array2 = array;
									DataRow[] arg_27D_0 = array2;
									int num = 0;
									DataRow arg_2AE_0 = arg_27D_0[num];
									string columnName = "tedad";
									arg_2AE_0[columnName] = Operators.AddObject(array2[num][columnName], Conversions.ToDecimal(dataRow["tedad"]));
								}
								flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
								if (flag)
								{
									DataRow[] array2 = array;
									DataRow[] arg_2DC_0 = array2;
									int num = 0;
									DataRow arg_30D_0 = arg_2DC_0[num];
									string columnName = "vazn";
									arg_30D_0[columnName] = Operators.AddObject(array2[num][columnName], Conversions.ToDecimal(dataRow["vazn_ba_zarf"]));
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

		// Token: 0x06001E72 RID: 7794 RVA: 0x00169CEC File Offset: 0x00167EEC
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

		// Token: 0x06001E73 RID: 7795 RVA: 0x00169ED8 File Offset: 0x001680D8
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00169F4C File Offset: 0x0016814C
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

		// Token: 0x06001E75 RID: 7797 RVA: 0x00169FB0 File Offset: 0x001681B0
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
						flag = !this.ValidateRizBar();
						if (flag)
						{
							this.addhandle();
							result = false;
						}
						else
						{
							this.addhandle();
							string nahve_furush = Conversions.ToString(this.GetNahve_Furush());
							string moshtari_ID = string.Empty;
							flag = (this.txt_moshtari.Value != null);
							if (flag)
							{
								moshtari_ID = Conversions.ToString(this.txt_moshtari.Value);
							}
							flag = this.Isnew;
							if (flag)
							{
								this.ID = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(id,0) from kharid where num=" + this.txt_num.Value));
								flag = (this.ID != 0);
								if (flag)
								{
									this.Isnew = false;
								}
							}
							flag = this.Isnew;
							if (flag)
							{
								this.ID = checked((int)this.Kharid.Insert(this.txt_num.Value.ToString(), moshtari_ID, this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.Darsad_Sud.ToString(), nahve_furush, (DataTable)this.GridEX1.DataSource));
								this.RizKharid.Update(this.ID, this.dt_Kharid, Conversions.ToInteger(Public_Function.dict["kharid_kind"]));
								this.kala_to_kala.Update((long)this.ID, this.dt_kala_to_kala);
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
								this.RemoveZero(detailByID);
								this.GridEX1.DataSource = detailByID;
								this.Isnew = false;
							}
							else
							{
								flag = (Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0);
								if (flag)
								{
									NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
									{
										Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid set moshtari_id=", this.txt_moshtari.Value), " where id="), this.ID)
									}, null, null, null, true);
								}
								this.kharid_keraye.Update(this.ID, this.dt_Keraye);
								this.RizKharid.Update(this.ID, this.dt_Kharid, Conversions.ToInteger(Public_Function.dict["kharid_kind"]));
								this.Kharid_Sud.Update(this.ID, this.dt_Darsad);
								this.Kharid.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), moshtari_ID, this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.Darsad_Sud.ToString(), nahve_furush, (DataTable)this.GridEX1.DataSource);
								DataTable detailByID2 = this.Kharid.GetDetailByID((long)this.ID);
								this.dt_Kharid = this.RizKharid.GetByID(this.ID);
								this.dt_Darsad = this.Kharid_Sud.GetByID(this.ID);
								this.dt_Keraye = this.kharid_keraye.GetByID(this.ID);
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
							this.GridEX1.Focus();
							this.GridEX1.MoveToNewRecord();
							this.GridEX1.Col = this.GridEX1.RootTable.Columns["moshtari_name"].Position;
							this.GridEX1.GetRow().BeginEdit();
							this.MeNew();
							result = true;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0016A540 File Offset: 0x00168740
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

		// Token: 0x06001E77 RID: 7799 RVA: 0x0016A588 File Offset: 0x00168788
		private long Get_Daramad()
		{
			long num = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["jam_kol"], AggregateFunction.Sum));
			this.txt_jam_furush.Text = Conversions.ToString(num);
			long num2 = Conversions.ToLong(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["jam_kol"], AggregateFunction.Sum));
			this.txt_jam_kharid.Text = Conversions.ToString(num2);
			long num3 = 0L;
			bool flag = this.dt_Keraye != null;
			if (flag)
			{
				bool flag2 = this.dt_Keraye.Rows.Count > 0;
				if (flag2)
				{
					num3 = Conversions.ToLong(this.dt_Keraye.Compute("sum(keraye)", ""));
					this.txt_jam_keraye.Text = Conversions.ToString(num3);
				}
				else
				{
					this.txt_jam_keraye.Text = Conversions.ToString(0);
				}
			}
			else
			{
				this.txt_jam_keraye.Text = Conversions.ToString(0);
			}
			checked
			{
				bool flag2 = num - (num2 + num3) != 0L;
				if (flag2)
				{
					this.lbl_daramad.Text = Public_Function.FormatPrice(Conversions.ToString(num - (num2 + num3)));
					this.txt_jam_daramad.Text = Conversions.ToString(num - (num2 + num3));
					long num4 = 0L;
					long? value = this.txt_jam_daramad.Value;
					bool? arg_188_0;
					if (!value.HasValue)
					{
						arg_188_0 = null;
					}
					else
					{
						bool? flag3 = new bool?(value.GetValueOrDefault() > num4);
						arg_188_0 = flag3;
					}
					bool? flag4 = arg_188_0;
					flag2 = flag4.GetValueOrDefault();
					if (flag2)
					{
						this.txt_jam_daramad.ForeColor = Color.Green;
					}
					else
					{
						this.txt_jam_daramad.ForeColor = Color.Red;
					}
				}
				else
				{
					this.lbl_daramad.Text = Conversions.ToString(0);
					this.txt_jam_daramad.Text = Conversions.ToString(0);
					this.txt_jam_daramad.ForeColor = Color.Black;
				}
				return num - (num2 + num3);
			}
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0016A794 File Offset: 0x00168994
		private void SyncTedad()
		{
			bool flag = this.dt_Kharid == null;
			checked
			{
				if (!flag)
				{
					string text = string.Empty;
					flag = (this.GetNahve_Furush() == 1 | this.GetNahve_Furush() == 2 | this.GetNahve_Furush() == 3);
					if (flag)
					{
						text = "vazn_kol";
					}
					else
					{
						text = "Vazn_Ba_Zarf";
					}
					DataTable dt = this.dt_Kharid.Copy();
					DataTable dataTable = this.Create_Rizbar_table(dt);
					dataTable.Columns.Add(new DataColumn("tedad_mande", typeof(decimal)));
					dataTable.Columns.Add(new DataColumn("vazn_mande", typeof(decimal)));
					dataTable.Columns.Add(new DataColumn("jam_kol_furush", typeof(long)));
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
								dataRow["vazn_mande"] = RuntimeHelpers.GetObjectValue(dataRow[text]);
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
								flag2 = (gridEXRow.Cells[text].Value == DBNull.Value);
								if (!flag2)
								{
									flag2 = !this.ContainsVazn(list2, Conversions.ToLong(gridEXRow.Cells["kala_id"].Value), Conversions.ToDecimal(gridEXRow.Cells[text].Value));
									if (flag2)
									{
										list2.Add(new tedads
										{
											kala_id = Conversions.ToLong(gridEXRow.Cells["kala_id"].Value),
											Tedad = Conversions.ToDecimal(gridEXRow.Cells[text].Value)
										});
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
								flag4 = (currentRow.Cells[text].Value != DBNull.Value);
								if (flag4)
								{
									flag3 = !this.ContainsKala(list2, Conversions.ToLong(currentRow.Cells["kala_id"].Value), Conversions.ToDecimal(currentRow.Cells[text].Value));
									if (flag3)
									{
										list2.Add(new tedads
										{
											kala_id = Conversions.ToLong(currentRow.Cells["kala_id"].Value),
											Tedad = Conversions.ToDecimal(currentRow.Cells[text].Value)
										});
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
								flag4 = (dataRow2["tedad_mande"] != DBNull.Value);
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
												DataRow arg_5EE_0 = dataRow3;
												string columnName = "tedad_mande";
												arg_5EE_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current.Tedad);
											}
										}
									}
									finally
									{
										List<tedads>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
								}
								flag4 = (dataRow2[text] != DBNull.Value);
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
												DataRow dataRow3 = dataRow2;
												DataRow arg_694_0 = dataRow3;
												string columnName = "vazn_mande";
												arg_694_0[columnName] = Operators.SubtractObject(dataRow3[columnName], current2.Tedad);
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
						GridEXRow[] rows2 = this.GridEX1.GetRows();
						for (int j = 0; j < rows2.Length; j++)
						{
							GridEXRow gridEXRow2 = rows2[j];
							flag4 = (gridEXRow2.Cells["kala_id"].Value == DBNull.Value);
							if (!flag4)
							{
								flag4 = (gridEXRow2.Cells["jam_kol"].Value != DBNull.Value);
								if (flag4)
								{
									DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", gridEXRow2.Cells["kala_id"].Value)));
									flag4 = (array.Length > 0);
									if (flag4)
									{
										DataRow[] array2 = array;
										DataRow[] arg_79E_0 = array2;
										int num = 0;
										DataRow arg_7CF_0 = arg_79E_0[num];
										string columnName = "jam_kol_furush";
										arg_7CF_0[columnName] = Operators.AddObject(array2[num][columnName], gridEXRow2.Cells["jam_kol"].Value);
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
									DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", currentRow.Cells["kala_id"].Value)));
									flag4 = (array.Length > 0);
									if (flag4)
									{
										DataRow[] array2 = array;
										DataRow[] arg_8BA_0 = array2;
										int num = 0;
										DataRow arg_8EB_0 = arg_8BA_0[num];
										string columnName = "jam_kol_furush";
										arg_8EB_0[columnName] = Operators.AddObject(array2[num][columnName], currentRow.Cells["jam_kol"].Value);
									}
								}
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

		// Token: 0x06001E79 RID: 7801 RVA: 0x0016B210 File Offset: 0x00169410
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
						dataRow["Tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Tedad"]));
					}
					flag = (dataRow["Vazn_Ba_Zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Ba_Zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_Ba_Zarf"]));
					}
					flag = (dataRow["Tedad_mande"] != DBNull.Value);
					if (flag)
					{
						dataRow["tedad_mande"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Tedad_mande"]));
					}
					flag = (dataRow["vazn_mande"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_mande"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_mande"]));
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_kol"]));
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

		// Token: 0x06001E7A RID: 7802 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0016B3D8 File Offset: 0x001695D8
		private void RemoveZero_kharid(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["vazn_ba_oft"] != DBNull.Value;
					if (flag)
					{
						dataRow["vazn_ba_oft"] = dataRow["vazn_ba_oft"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_oft"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_oft"] = dataRow["vazn_oft"].ToString().Replace(".0", "");
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

		// Token: 0x06001E7C RID: 7804 RVA: 0x0016B4D0 File Offset: 0x001696D0
		private void LoadHeader(DataRow dr)
		{
			this.txt_num.Value = Conversions.ToString(dr["Num"]);
			this.ID = Conversions.ToInteger(dr["ID"]);
			bool flag = dr["moshtari_id"] != DBNull.Value;
			if (flag)
			{
				this.txt_moshtari.SetValue(Conversions.ToString(dr["Moshtari_Name"]), RuntimeHelpers.GetObjectValue(dr["Moshtari_ID"]));
			}
			else
			{
				this.txt_moshtari.SetNew();
			}
			this.txt_sh_mashin.Text = dr["Sh_Mashin"].ToString();
			this.txt_sh_barname.Text = dr["Sh_Barname"].ToString();
			flag = (dr["Tarikh_Vurud"] != DBNull.Value);
			if (flag)
			{
				this.txt_tarikh_vurud.SetDate(dr["Tarikh_Vurud"].ToString());
			}
			else
			{
				this.txt_tarikh_vurud.SetDefault();
			}
			this.txt_desc.Text = dr["Desc"].ToString();
			flag = (dr["darsad"] != DBNull.Value);
			if (flag)
			{
				this.Darsad_Sud = Conversions.ToDecimal(dr["darsad"]);
			}
			else
			{
				this.Darsad_Sud = null;
			}
			this.dt_Keraye = this.kharid_keraye.GetByID(this.ID);
			this.Adddt(this.dt_Keraye);
			this.dt_Kharid = this.RizKharid.GetByID(this.ID);
			this.RemoveZero_kharid(this.dt_Kharid);
			this.txt_rizbar.Text = Public_Function.GetSum(this.dt_Kharid, "jam_kol");
			flag = (dr["moshtari_id"] != DBNull.Value);
			if (flag)
			{
				string value = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select name +' '+ family from moshtari where id=", dr["moshtari_id"])
				}, null, null, null));
				try
				{
					IEnumerator enumerator = this.dt_Kharid.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["moshtari_id"] == DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_id"] = RuntimeHelpers.GetObjectValue(dr["moshtari_id"]);
							dataRow["moshtari_name"] = value;
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
			this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
			DataTable dataSource = this.dt_Kharid.Copy();
			this.Grid_RizBar.DataSource = dataSource;
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0006A070 File Offset: 0x00068270
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

		// Token: 0x06001E7E RID: 7806 RVA: 0x0016B7E8 File Offset: 0x001699E8
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

		// Token: 0x06001E7F RID: 7807 RVA: 0x0016B8F8 File Offset: 0x00169AF8
		private void setEnable(bool en)
		{
			if (en)
			{
				this.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				this.GridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
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
			this.txt_moshtari.Enabled = en;
			this.txt_desc.Enabled = en;
			this.txt_fee.Enabled = en;
			this.txt_tarikh_vurud.Enabled = en;
			this.txt_sh_barname.Enabled = en;
			this.txt_sh_mashin.Enabled = en;
			this.txt_rizbar.Enabled = en;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00008314 File Offset: 0x00006514
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0016BA34 File Offset: 0x00169C34
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				}
			}
			this.uncheckmenu();
			this.ButtonItem16.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0016BB4C File Offset: 0x00169D4C
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = false;
			this.Grid_RizBar.RootTable.Columns["tedad_mande"].Visible = false;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			this.uncheckmenu();
			this.ButtonItem17.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0016BC30 File Offset: 0x00169E30
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.Grid_RizBar.RootTable.Columns["vazn_mande"].Visible = false;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = false;
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				}
			}
			this.uncheckmenu();
			this.ButtonItem18.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0016BD68 File Offset: 0x00169F68
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				}
			}
			this.uncheckmenu();
			this.ButtonItem19.Checked = true;
			this.GridEX1.Focus();
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0016BE80 File Offset: 0x0016A080
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
				flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
				if (flag)
				{
					bool flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
					if (flag2)
					{
						this.GridEX1.RootTable.Columns["tedad"].Visible = false;
					}
				}
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x0016BFE4 File Offset: 0x0016A1E4
		private void Delete_Tekrari(string num, string id)
		{
			DataTable dataTable = Public_Function.FillData("select id from kharid where num=" + num + " and id<>" + id);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					try
					{
						this.Kharid.Delete(Conversions.ToString(dataRow["id"]));
					}
					catch (Exception expr_52)
					{
						ProjectData.SetProjectError(expr_52);
						ProjectData.ClearProjectError();
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

		// Token: 0x06001E87 RID: 7815 RVA: 0x0016C0A0 File Offset: 0x0016A2A0
		private void LoadData()
		{
			DataRow byID = this.Kharid.GetByID((long)this.Num);
			bool flag = byID == null;
			checked
			{
				if (flag)
				{
					string left = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 id from kharid where num>" + Conversions.ToString(this.Num)));
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
					this.Delete_Tekrari(Conversions.ToString(this.Num), Conversions.ToString(this.ID));
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
					this.LoadNahve_Furush(byID);
					this.GridEX1.Focus();
					this.GridEX1.MoveToNewRecord();
					this.GridEX1.Col = 0;
					this.GridEX1.Col = 1;
					this.GridEX1.EditMode = EditMode.EditOn;
					flag = !Conversions.ToBoolean(Public_Function.dict["oft"]);
					bool flag3;
					if (flag)
					{
						bool flag2 = this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0;
						if (flag2)
						{
							flag3 = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
							if (flag3)
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
					}
					flag3 = Conversions.ToBoolean(Public_Function.dict["newrow_kala"]);
					if (flag3)
					{
						bool flag2 = this.GridEX1.GetRow().Cells["Kala_Name"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0;
						if (flag2)
						{
							flag = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["kala_Name"].Value != DBNull.Value);
							if (flag)
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

		// Token: 0x06001E88 RID: 7816 RVA: 0x0016C778 File Offset: 0x0016A978
		private void Kharid_select()
		{
			this.frm_furush.CanEdit = false;
			this.frm_furush.CanDelete = false;
			this.frm_furush.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm_furush.Text = "انتخاب سند خرید";
			DataTable dataTable = Public_Function.FillData("SELECT  ID,Num FROM Kharid where daramad_sanad_id is null");
			DataTable dataTable2 = Public_Function.FillData("  select kharid_id,moshtari_id,name +' '+ family as moshtari_name from (    select kharid_id,moshtari_id from kharid_detail    where kharid_id in(select id from kharid    where daramad_sanad_id is null)  group by kharid_id,moshtari_id  ) as kharid  inner join moshtari  on kharid.moshtari_id=moshtari.id");
			dataTable.Columns.Add("moshtari_name", typeof(string));
			string text = string.Empty;
			checked
			{
				bool flag;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						text = string.Empty;
						DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject("kharid_id=", dataRow["id"])));
						DataRow[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							DataRow dataRow2 = array2[i];
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow2["moshtari_name"], "-")));
						}
						text = Public_Function.RemoveLast(text);
						dataRow["moshtari_name"] = text;
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
				flag = (this.frm_furush.ShowDialog(dataTable, null, "") == DialogResult.OK);
				if (flag)
				{
					long num = Conversions.ToLong(this.frm_furush.SelectedRow["num"]);
					flag = (num == 0L);
					if (!flag)
					{
						flag = (num != unchecked((long)this.Num));
						if (flag)
						{
							this.Num = (int)num;
							this.LoadData();
						}
					}
				}
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0000834C File Offset: 0x0000654C
		private void txt_num_First_Click()
		{
			this.Kharid_select();
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0016C958 File Offset: 0x0016AB58
		private void txt_num_Last_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid.NavTo.last, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001E8B RID: 7819 RVA: 0x0016C9B4 File Offset: 0x0016ABB4
		private void txt_num_Next_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001E8C RID: 7820 RVA: 0x0016CA10 File Offset: 0x0016AC10
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Kharid.GetNavigateID(Kharid.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001E8D RID: 7821 RVA: 0x0016CA6C File Offset: 0x0016AC6C
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

		// Token: 0x06001E8E RID: 7822 RVA: 0x00008357 File Offset: 0x00006557
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0016CAEC File Offset: 0x0016ACEC
		private DataTable Create_Rizbar_table(DataTable dt)
		{
			DataTable dataTable = dt.Clone();
			DataColumn dataColumn = new DataColumn("checked", typeof(bool));
			dataColumn.DefaultValue = false;
			dt.Columns.Add(dataColumn);
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
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
								num3 = 0m;
								long num4 = 0L;
								DataRow[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									DataRow dataRow2 = array2[i];
									flag = (dataRow2["tedad"] != DBNull.Value);
									if (flag)
									{
										num = Conversions.ToDecimal(Operators.AddObject(num, dataRow2["tedad"]));
									}
									flag = (dataRow2["vazn_ba_zarf"] != DBNull.Value);
									if (flag)
									{
										num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataRow2["vazn_ba_zarf"]));
									}
									flag = (dataRow2["vazn_kol"] != DBNull.Value);
									if (flag)
									{
										num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataRow2["vazn_kol"]));
									}
									flag = (dataRow2["jam_kol"] != DBNull.Value);
									if (flag)
									{
										num4 = Conversions.ToLong(Operators.AddObject(num4, dataRow2["jam_kol"]));
									}
									dataRow2["checked"] = true;
								}
								dataRow["tedad"] = num;
								dataRow["vazn_ba_zarf"] = num2;
								dataRow["vazn_kol"] = num3;
								dataRow["jam_kol"] = num4;
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

		// Token: 0x06001E90 RID: 7824 RVA: 0x0016CDD4 File Offset: 0x0016AFD4
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0 && Operators.CompareString(this.txt_moshtari.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_moshtari.ShowTip("صاحب بار را انتخاب فرمائید");
			}
			else
			{
				Frm_RizKharid frm_RizKharid = new Frm_RizKharid();
				Frm_RizKharid arg_A9_0 = frm_RizKharid;
				object expr_6E = this.txt_moshtari.Value;
				int? num2;
				int? num = (expr_6E != null) ? ((int?)expr_6E) : num2;
				long? arg_A9_1;
				if (!num.HasValue)
				{
					arg_A9_1 = null;
				}
				else
				{
					long? num3 = new long?((long)num.GetValueOrDefault());
					arg_A9_1 = num3;
				}
				arg_A9_0.Moshtari_ID = arg_A9_1;
				frm_RizKharid.Furush_Table = (DataTable)this.GridEX1.DataSource;
				frm_RizKharid.Nahvefurush = this.GetNahve_Furush();
				Frm_RizKharid frm_RizKharid2 = frm_RizKharid;
				flag = this.Isnew;
				if (flag)
				{
					frm_RizKharid2.Kharid_ID = -1L;
				}
				else
				{
					frm_RizKharid2.Kharid_ID = (long)this.ID;
				}
				frm_RizKharid2.dt_kala_to_kala = this.dt_kala_to_kala;
				frm_RizKharid2.dt_Kharid = this.dt_Kharid;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_RizKharid2);
				flag = (frm_RizKharid2.DialogResult != DialogResult.Abort);
				if (flag)
				{
					this.dt_Kharid = frm_RizKharid2.dt_Kharid;
					this.dt_Kharid.AcceptChanges();
					this.txt_rizbar.Text = Public_Function.GetSum(this.dt_Kharid, "jam_kol");
					DataTable dt = this.dt_Kharid.Copy();
					this.Grid_RizBar.DataSource = this.Create_Rizbar_table(dt);
					flag = (this.Grid_RizBar.RowCount > 0);
					if (flag)
					{
						this.SyncTedad();
						this.RemoveZeroVazn();
					}
				}
				this.Get_Daramad();
			}
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0016CFA0 File Offset: 0x0016B1A0
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

		// Token: 0x06001E92 RID: 7826 RVA: 0x0016D044 File Offset: 0x0016B244
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

		// Token: 0x06001E93 RID: 7827 RVA: 0x0016D1A4 File Offset: 0x0016B3A4
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0016D1F8 File Offset: 0x0016B3F8
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
							this.GridEX1.GetRow().Cells["preKala_ID"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_ID"].Value);
							this.GridEX1.GetRow().Cells["Kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Kala_Name"].Value);
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
				flag3 = !Conversions.ToBoolean(Public_Function.dict["oft"]);
				if (flag3)
				{
					flag2 = (this.GridEX1.GetRow().Cells["Zarf"].Value == DBNull.Value && this.GridEX1.Row - 1 >= 0);
					if (flag2)
					{
						flag = (this.GridEX1.GetRows()[this.GridEX1.Row - 1].Cells["Zarf"].Value != DBNull.Value);
						if (flag)
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

		// Token: 0x06001E95 RID: 7829 RVA: 0x0016D814 File Offset: 0x0016BA14
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.Get_Daramad();
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0016D87C File Offset: 0x0016BA7C
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

		// Token: 0x06001E97 RID: 7831 RVA: 0x0016D948 File Offset: 0x0016BB48
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
				}
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0016D990 File Offset: 0x0016BB90
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			bool flag = Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0 && Operators.CompareString(this.txt_moshtari.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_moshtari.ShowTip("صاحب بار را انتخاب فرمائید");
			}
			else
			{
				Frm_Kharid_Keraye frm_Kharid_Keraye = new Frm_Kharid_Keraye
				{
					dt_keraye = this.dt_Keraye,
					Moshtari_ID = Conversions.ToLong(this.txt_moshtari.Value)
				};
				flag = this.Isnew;
				if (flag)
				{
					frm_Kharid_Keraye.Kharid_ID = -1L;
				}
				else
				{
					frm_Kharid_Keraye.Kharid_ID = (long)this.ID;
				}
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Kharid_Keraye);
				this.dt_Keraye = frm_Kharid_Keraye.dt_keraye;
				this.dt_Keraye.AcceptChanges();
				this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
				this.Get_Daramad();
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0016DA98 File Offset: 0x0016BC98
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, -1, false);
				if (flag2)
				{
					Frm_SuratHesab_Moshtari arg_98_0 = frm_SuratHesab_Moshtari;
					object expr_86 = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value;
					int? num;
					arg_98_0.Moshtari_id = ((expr_86 != null) ? ((int?)expr_86) : num);
					frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0016DB84 File Offset: 0x0016BD84
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0016DBB0 File Offset: 0x0016BDB0
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

		// Token: 0x06001E9C RID: 7836 RVA: 0x0000836A File Offset: 0x0000656A
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
			this.txt_sh_mashin.Focus();
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00008383 File Offset: 0x00006583
		private void CurrencyBox2_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem7_Click(null, null);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0016DC14 File Offset: 0x0016BE14
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar_ButtonClick(null, null);
				this.txt_sh_mashin.Focus();
			}
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0016DC48 File Offset: 0x0016BE48
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.CurrencyBox2_ButtonClick(null, null);
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0016DC70 File Offset: 0x0016BE70
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_Sud_Kharid frm_Sud_Kharid = new Frm_Sud_Kharid
			{
				dt_Darsad = this.dt_Darsad
			};
			bool isnew = this.Isnew;
			if (isnew)
			{
				frm_Sud_Kharid.Kharid_ID = -1L;
			}
			else
			{
				frm_Sud_Kharid.Kharid_ID = (long)this.ID;
			}
			frm_Sud_Kharid.Sh_Sanad = Conversions.ToLong(this.txt_num.Value);
			frm_Sud_Kharid.Jam = this.Get_Daramad();
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Sud_Kharid);
			this.dt_Darsad = frm_Sud_Kharid.dt_Darsad;
			this.dt_Darsad.AcceptChanges();
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0016DD08 File Offset: 0x0016BF08
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

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00008390 File Offset: 0x00006590
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0000839B File Offset: 0x0000659B
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0016DD6C File Offset: 0x0016BF6C
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			bool enabled = this.ButtonItem13.Enabled;
			if (enabled)
			{
				this.txt_moshtari.Focus();
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0016DD98 File Offset: 0x0016BF98
		private string GetMoshtari_Name()
		{
			DataTable dt = Public_Function.FillData("SELECT distinct Kharid_Detail.moshtari_id,Moshtari.name +' '+ Moshtari.Family as moshtari_name  FROM [Kharid]  inner join Kharid_Detail  on Kharid.ID=Kharid_Detail.Kharid_ID  inner join Moshtari  on Kharid_Detail.moshtari_id=Moshtari.ID  where num=" + this.txt_num.Value);
			return Public_Function.GetID(dt, "moshtari_name", "");
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0016DDD8 File Offset: 0x0016BFD8
		public void ButtonItem12_Click(object sender, EventArgs e)
		{
			new Frm_Chap_Kharid
			{
				Jam_Furush = this.txt_jam_furush.Text,
				Jam_Daramad = this.txt_jam_daramad.Text,
				Kharid_num = Conversions.ToLong(this.txt_num.Value),
				NahveKharid = this.GetNahve_Furush(),
				Makharej = this.txt_makharej.Text
			}.ShowDialog();
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0016DE50 File Offset: 0x0016C050
		private void Render_footer(StiReport rpt, string s)
		{
			string[] array = s.Split(new char[]
			{
				';'
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string text = array2[i];
					bool flag = Operators.CompareString(text, string.Empty, false) == 0;
					if (flag)
					{
						break;
					}
					StiText stiText = (StiText)rpt.GetComponentByName(text.Split(new char[]
					{
						':'
					})[0]);
					StiText stiText2 = (StiText)rpt.GetComponentByName(text.Split(new char[]
					{
						':'
					})[1]);
					flag = !stiText.Enabled;
					if (flag)
					{
						stiText2.Enabled = false;
					}
					else
					{
						stiText2.Width = stiText.Width;
						stiText2.Left = stiText.Left;
					}
				}
			}
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0016DF38 File Offset: 0x0016C138
		private void Baz()
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select daramad_sanad_id from kharid where num=" + Conversions.ToString(this.Num)));
			bool flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				string text2 = "delete from sanad where id=" + text + ";";
				text2 = text2 + "update kharid set daramad_sanad_id=null where num=" + Conversions.ToString(this.Num);
				Public_Function.ExecuteNonQuery(text2);
				this.setEnable(true);
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0016DFB8 File Offset: 0x0016C1B8
		private void ButtonItem14_Click(object sender, EventArgs e)
		{
			bool flag = this.Isnew;
			if (!flag)
			{
				flag = this.txt_moshtari.Enabled;
				if (flag)
				{
					bool flag2 = Public_Function.ShowMessage("آیا مایل به بستن سند میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
					if (flag2)
					{
						Kharid kharid = new Kharid();
						kharid.UpdateDaramad(Conversions.ToString(this.Num));
						this.setEnable(false);
					}
				}
				else
				{
					bool flag2 = Public_Function.ShowMessage("آیا مایل به باز کردن سند میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
					if (flag2)
					{
						flag = (Conversions.ToDouble(Public_Function.dict["kharid_baz"]) == 1.0);
						if (flag)
						{
							this.Baz();
						}
						else
						{
							flag2 = (Conversions.ToDouble(Public_Function.dict["kharid_baz"]) == 3.0);
							if (flag2)
							{
								flag2 = (new Frm_Password
								{
									Auth_type = 2
								}.ShowDialog() == DialogResult.OK);
								if (flag2)
								{
									this.Baz();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0016E0B0 File Offset: 0x0016C2B0
		private void Frm_Kharid_Furush_Resize(object sender, EventArgs e)
		{
			checked
			{
				this.Grid_RizBar.Width = this.txt_jam_kharid.Left - 6;
				this.GridEX1.Height = this.RibbonStatusBar1.Top - this.GridEX1.Top - this.RibbonStatusBar1.Height - 14;
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0016E10C File Offset: 0x0016C30C
		private void ButtonItem20_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value != DBNull.Value && this.GridEX1.CurrentRow.Cells["moshtari_id"].Value != null;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value, -1, false);
				if (flag2)
				{
					Frm_Daryaft_AzMoshtari frm_Daryaft_AzMoshtari = new Frm_Daryaft_AzMoshtari();
					frm_Daryaft_AzMoshtari.Moshtari_ID = Conversions.ToString(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value);
					frm_Daryaft_AzMoshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
					frm_Daryaft_AzMoshtari.Tarikh = Conversions.ToString(this.GridEX1.CurrentRow.Cells["tarikh_fa"].Value);
					MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Daryaft_AzMoshtari);
				}
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0016E23C File Offset: 0x0016C43C
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

		// Token: 0x04000B86 RID: 2950
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000B88 RID: 2952
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000B89 RID: 2953
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000B8A RID: 2954
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000B8B RID: 2955
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000B8C RID: 2956
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000B8D RID: 2957
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000B8E RID: 2958
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000B8F RID: 2959
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04000B90 RID: 2960
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000B91 RID: 2961
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000B92 RID: 2962
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x04000B93 RID: 2963
		[AccessedThroughProperty("txt_sh_barname")]
		private EditBox _txt_sh_barname;

		// Token: 0x04000B94 RID: 2964
		[AccessedThroughProperty("txt_tarikh_vurud")]
		private DateBox2 _txt_tarikh_vurud;

		// Token: 0x04000B95 RID: 2965
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000B96 RID: 2966
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000B97 RID: 2967
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000B98 RID: 2968
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000B99 RID: 2969
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000B9A RID: 2970
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000B9B RID: 2971
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000B9C RID: 2972
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000B9D RID: 2973
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000B9E RID: 2974
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000B9F RID: 2975
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000BA0 RID: 2976
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000BA1 RID: 2977
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000BA2 RID: 2978
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000BA3 RID: 2979
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000BA4 RID: 2980
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000BA5 RID: 2981
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000BA6 RID: 2982
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000BA7 RID: 2983
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000BA8 RID: 2984
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000BA9 RID: 2985
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000BAA RID: 2986
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000BAB RID: 2987
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000BAC RID: 2988
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000BAD RID: 2989
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000BAE RID: 2990
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000BAF RID: 2991
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000BB0 RID: 2992
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000BB1 RID: 2993
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000BB2 RID: 2994
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000BB3 RID: 2995
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000BB4 RID: 2996
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000BB5 RID: 2997
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000BB6 RID: 2998
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000BB7 RID: 2999
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000BB8 RID: 3000
		[AccessedThroughProperty("lbl_daramad")]
		private Label _lbl_daramad;

		// Token: 0x04000BB9 RID: 3001
		[AccessedThroughProperty("txt_jam_keraye")]
		private CurrencyBox _txt_jam_keraye;

		// Token: 0x04000BBA RID: 3002
		[AccessedThroughProperty("txt_jam_kharid")]
		private CurrencyBox _txt_jam_kharid;

		// Token: 0x04000BBB RID: 3003
		[AccessedThroughProperty("txt_jam_daramad")]
		private CurrencyBox _txt_jam_daramad;

		// Token: 0x04000BBC RID: 3004
		[AccessedThroughProperty("txt_jam_furush")]
		private CurrencyBox _txt_jam_furush;

		// Token: 0x04000BBD RID: 3005
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000BBE RID: 3006
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000BBF RID: 3007
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000BC0 RID: 3008
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000BC1 RID: 3009
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000BC2 RID: 3010
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000BC3 RID: 3011
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000BC4 RID: 3012
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000BC5 RID: 3013
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000BC6 RID: 3014
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000BC7 RID: 3015
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000BC8 RID: 3016
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000BC9 RID: 3017
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000BCA RID: 3018
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000BCB RID: 3019
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000BCC RID: 3020
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000BCD RID: 3021
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000BCE RID: 3022
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000BCF RID: 3023
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000BD0 RID: 3024
		[AccessedThroughProperty("txt_kargari")]
		private CurrencyBox _txt_kargari;

		// Token: 0x04000BD1 RID: 3025
		[AccessedThroughProperty("Btn_Daryaft")]
		private ButtonItem _Btn_Daryaft;

		// Token: 0x04000BD2 RID: 3026
		[AccessedThroughProperty("ButtonItem20")]
		private ButtonItem _ButtonItem20;

		// Token: 0x04000BD3 RID: 3027
		[AccessedThroughProperty("txt_pardakhti")]
		private CurrencyBox _txt_pardakhti;

		// Token: 0x04000BD4 RID: 3028
		[CompilerGenerated]
		private bool _Show_Preview;

		// Token: 0x04000BD5 RID: 3029
		private Kharid Kharid;

		// Token: 0x04000BD6 RID: 3030
		private Kharid_Detail RizKharid;

		// Token: 0x04000BD7 RID: 3031
		private Kharid_Keraye kharid_keraye;

		// Token: 0x04000BD8 RID: 3032
		private Kala_To_Kala_Kharid kala_to_kala;

		// Token: 0x04000BD9 RID: 3033
		private Kharid_Darsad Kharid_Sud;

		// Token: 0x04000BDA RID: 3034
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000BDB RID: 3035
		public int GotoLineID;

		// Token: 0x04000BDC RID: 3036
		private Frm_SelectItem frm;

		// Token: 0x04000BDD RID: 3037
		private Sanad sanad;

		// Token: 0x04000BDE RID: 3038
		private Sandugh Sandug;

		// Token: 0x04000BDF RID: 3039
		private int ID;

		// Token: 0x04000BE0 RID: 3040
		public int Num;

		// Token: 0x04000BE1 RID: 3041
		private bool Isnew;

		// Token: 0x04000BE2 RID: 3042
		private decimal? Darsad_Sud;

		// Token: 0x04000BE3 RID: 3043
		private DataTable dt_Kharid;

		// Token: 0x04000BE4 RID: 3044
		private DataTable dt_Keraye;

		// Token: 0x04000BE5 RID: 3045
		private DataTable dt_Darsad;

		// Token: 0x04000BE6 RID: 3046
		private DataTable dt_kala_to_kala;

		// Token: 0x04000BE7 RID: 3047
		private bool prevent_close;

		// Token: 0x04000BE8 RID: 3048
		private bool prevent_right;

		// Token: 0x04000BE9 RID: 3049
		private bool prevent_left;

		// Token: 0x04000BEA RID: 3050
		private bool prevent_enter;

		// Token: 0x04000BEB RID: 3051
		private Frm_SelectItem frm_furush;
	}
}
