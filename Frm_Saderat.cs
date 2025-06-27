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
	// Token: 0x02000108 RID: 264
	[DesignerGenerated]
	public partial class Frm_Saderat : Form
	{
		// Token: 0x06002411 RID: 9233 RVA: 0x001B086C File Offset: 0x001AEA6C
		public Frm_Saderat()
		{
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frm_Frush_hag_KeyDown);
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			Frm_Saderat.__ENCAddToList(this);
			this.Saderat = new Saderat();
			this.RizBar = new Furush_Hag_RizBar();
			this.Saderat_Keraye = new Saderat_Keraye();
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

		// Token: 0x06002412 RID: 9234 RVA: 0x001B0980 File Offset: 0x001AEB80
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Saderat.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Saderat.__ENCList.Count == Frm_Saderat.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Saderat.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Saderat.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Saderat.__ENCList[num] = Frm_Saderat.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Saderat.__ENCList.RemoveRange(num, Frm_Saderat.__ENCList.Count - num);
						Frm_Saderat.__ENCList.Capacity = Frm_Saderat.__ENCList.Count;
					}
					Frm_Saderat.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x001B45B0 File Offset: 0x001B27B0
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0000929E File Offset: 0x0000749E
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

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x001B45C8 File Offset: 0x001B27C8
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x000092A8 File Offset: 0x000074A8
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

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x001B45E0 File Offset: 0x001B27E0
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x000092B2 File Offset: 0x000074B2
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

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x001B45F8 File Offset: 0x001B27F8
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x000092BC File Offset: 0x000074BC
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x001B4610 File Offset: 0x001B2810
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x000092C6 File Offset: 0x000074C6
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

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x001B4628 File Offset: 0x001B2828
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x000092D0 File Offset: 0x000074D0
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

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x001B4640 File Offset: 0x001B2840
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x000092DA File Offset: 0x000074DA
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

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x001B4658 File Offset: 0x001B2858
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x000092E4 File Offset: 0x000074E4
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

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x001B4670 File Offset: 0x001B2870
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x000092EE File Offset: 0x000074EE
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

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x001B4688 File Offset: 0x001B2888
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x001B46A0 File Offset: 0x001B28A0
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

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x001B47D4 File Offset: 0x001B29D4
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x001B47EC File Offset: 0x001B29EC
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

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x001B484C File Offset: 0x001B2A4C
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x000092F8 File Offset: 0x000074F8
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

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x001B4864 File Offset: 0x001B2A64
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x00009302 File Offset: 0x00007502
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

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x001B487C File Offset: 0x001B2A7C
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x001B4894 File Offset: 0x001B2A94
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

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x001B48F4 File Offset: 0x001B2AF4
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x0000930C File Offset: 0x0000750C
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

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x001B490C File Offset: 0x001B2B0C
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x001B4924 File Offset: 0x001B2B24
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
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				InitCustomEditEventHandler value5 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value6 = new EventHandler(this.GridEX1_SelectionChanged);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EndCustomEditEventHandler value8 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value9 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
					this._GridEX1.KeyPress -= value3;
					this._GridEX1.KeyDown -= value4;
					this._GridEX1.InitCustomEdit -= value5;
					this._GridEX1.SelectionChanged -= value6;
					this._GridEX1.CellEdited -= value7;
					this._GridEX1.EndCustomEdit -= value8;
					this._GridEX1.ColumnButtonClick -= value9;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
					this._GridEX1.KeyPress += value3;
					this._GridEX1.KeyDown += value4;
					this._GridEX1.InitCustomEdit += value5;
					this._GridEX1.SelectionChanged += value6;
					this._GridEX1.CellEdited += value7;
					this._GridEX1.EndCustomEdit += value8;
					this._GridEX1.ColumnButtonClick += value9;
				}
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x001B4AAC File Offset: 0x001B2CAC
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x00009316 File Offset: 0x00007516
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

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x001B4AC4 File Offset: 0x001B2CC4
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x001B4ADC File Offset: 0x001B2CDC
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

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x001B4B3C File Offset: 0x001B2D3C
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x001B4B54 File Offset: 0x001B2D54
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

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x001B4BB4 File Offset: 0x001B2DB4
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x001B4BCC File Offset: 0x001B2DCC
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

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x001B4C2C File Offset: 0x001B2E2C
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x001B4C44 File Offset: 0x001B2E44
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

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x001B4CA4 File Offset: 0x001B2EA4
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x001B4CBC File Offset: 0x001B2EBC
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

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x001B4D1C File Offset: 0x001B2F1C
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x00009320 File Offset: 0x00007520
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

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x001B4D34 File Offset: 0x001B2F34
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x0000932A File Offset: 0x0000752A
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

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x001B4D4C File Offset: 0x001B2F4C
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x001B4D64 File Offset: 0x001B2F64
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

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x001B4DC4 File Offset: 0x001B2FC4
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x001B4DDC File Offset: 0x001B2FDC
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

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x001B4E3C File Offset: 0x001B303C
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x00009334 File Offset: 0x00007534
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

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x001B4E54 File Offset: 0x001B3054
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0000933E File Offset: 0x0000753E
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

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x001B4E6C File Offset: 0x001B306C
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x001B4E84 File Offset: 0x001B3084
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x001B4EE4 File Offset: 0x001B30E4
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x001B4EFC File Offset: 0x001B30FC
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

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x001B4F5C File Offset: 0x001B315C
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x00009348 File Offset: 0x00007548
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

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x001B4F74 File Offset: 0x001B3174
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x00009352 File Offset: 0x00007552
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

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x001B4F8C File Offset: 0x001B318C
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0000935C File Offset: 0x0000755C
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

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x001B4FA4 File Offset: 0x001B31A4
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x00009366 File Offset: 0x00007566
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

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x001B4FBC File Offset: 0x001B31BC
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x00009370 File Offset: 0x00007570
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

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x001B4FD4 File Offset: 0x001B31D4
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0000937A File Offset: 0x0000757A
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

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x001B4FEC File Offset: 0x001B31EC
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x00009384 File Offset: 0x00007584
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

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x001B5004 File Offset: 0x001B3204
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000938E File Offset: 0x0000758E
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

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x001B501C File Offset: 0x001B321C
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x00009398 File Offset: 0x00007598
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

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x001B5034 File Offset: 0x001B3234
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x000093A2 File Offset: 0x000075A2
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

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x001B504C File Offset: 0x001B324C
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x000093AC File Offset: 0x000075AC
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

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x001B5064 File Offset: 0x001B3264
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x001B507C File Offset: 0x001B327C
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x001B50DC File Offset: 0x001B32DC
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x001B50F4 File Offset: 0x001B32F4
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x001B5154 File Offset: 0x001B3354
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x001B516C File Offset: 0x001B336C
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x001B51F4 File Offset: 0x001B33F4
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x000093B6 File Offset: 0x000075B6
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x001B520C File Offset: 0x001B340C
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x000093C0 File Offset: 0x000075C0
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x001B5224 File Offset: 0x001B3424
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x000093CA File Offset: 0x000075CA
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

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x001B523C File Offset: 0x001B343C
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x000093D4 File Offset: 0x000075D4
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

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x001B5254 File Offset: 0x001B3454
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x000093DE File Offset: 0x000075DE
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x001B526C File Offset: 0x001B346C
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x000093E8 File Offset: 0x000075E8
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

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x001B5284 File Offset: 0x001B3484
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x000093F2 File Offset: 0x000075F2
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

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x001B529C File Offset: 0x001B349C
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x000093FC File Offset: 0x000075FC
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

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x001B52B4 File Offset: 0x001B34B4
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x00009406 File Offset: 0x00007606
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

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x001B52CC File Offset: 0x001B34CC
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x00009410 File Offset: 0x00007610
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

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x001B52E4 File Offset: 0x001B34E4
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0000941A File Offset: 0x0000761A
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

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x001B52FC File Offset: 0x001B34FC
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x001B5314 File Offset: 0x001B3514
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x001B5374 File Offset: 0x001B3574
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x001B538C File Offset: 0x001B358C
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

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x001B5414 File Offset: 0x001B3614
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x00009424 File Offset: 0x00007624
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

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x001B542C File Offset: 0x001B362C
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x001B5444 File Offset: 0x001B3644
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

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x001B54CC File Offset: 0x001B36CC
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x0000942E File Offset: 0x0000762E
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

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x001B54E4 File Offset: 0x001B36E4
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x001B54FC File Offset: 0x001B36FC
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x001B555C File Offset: 0x001B375C
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x001B5574 File Offset: 0x001B3774
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

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x001B55D4 File Offset: 0x001B37D4
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x001B55EC File Offset: 0x001B37EC
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

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x001B564C File Offset: 0x001B384C
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x001B5664 File Offset: 0x001B3864
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

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x001B56C4 File Offset: 0x001B38C4
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x00009438 File Offset: 0x00007638
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

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x001B56DC File Offset: 0x001B38DC
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x001B56F4 File Offset: 0x001B38F4
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

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x001B5754 File Offset: 0x001B3954
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x001B576C File Offset: 0x001B396C
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

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x001B57CC File Offset: 0x001B39CC
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x00009442 File Offset: 0x00007642
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

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x001B57E4 File Offset: 0x001B39E4
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0000944C File Offset: 0x0000764C
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

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x001B57FC File Offset: 0x001B39FC
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x00009456 File Offset: 0x00007656
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

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x001B5814 File Offset: 0x001B3A14
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x00009460 File Offset: 0x00007660
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

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x001B582C File Offset: 0x001B3A2C
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x0000946A File Offset: 0x0000766A
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x001B5844 File Offset: 0x001B3A44
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x001B585C File Offset: 0x001B3A5C
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

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x001B58BC File Offset: 0x001B3ABC
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x001B58D4 File Offset: 0x001B3AD4
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

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x001B5934 File Offset: 0x001B3B34
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x001B594C File Offset: 0x001B3B4C
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

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x001B59AC File Offset: 0x001B3BAC
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x001B59C4 File Offset: 0x001B3BC4
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

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x001B5A24 File Offset: 0x001B3C24
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x001B5A3C File Offset: 0x001B3C3C
		internal virtual CurrencyBox txt_safi_dolar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_safi_dolar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_safikol_TextChanged);
				bool flag = this._txt_safi_dolar != null;
				if (flag)
				{
					this._txt_safi_dolar.TextChanged -= value2;
				}
				this._txt_safi_dolar = value;
				flag = (this._txt_safi_dolar != null);
				if (flag)
				{
					this._txt_safi_dolar.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x001B5A9C File Offset: 0x001B3C9C
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x00009474 File Offset: 0x00007674
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

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x001B5AB4 File Offset: 0x001B3CB4
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x0000947E File Offset: 0x0000767E
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

		// Token: 0x060024B3 RID: 9395 RVA: 0x001B5ACC File Offset: 0x001B3CCC
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

		// Token: 0x060024B4 RID: 9396 RVA: 0x001B5B70 File Offset: 0x001B3D70
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x001B5BC4 File Offset: 0x001B3DC4
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x001B5C00 File Offset: 0x001B3E00
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

		// Token: 0x060024B7 RID: 9399 RVA: 0x001B5C94 File Offset: 0x001B3E94
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

		// Token: 0x060024B8 RID: 9400 RVA: 0x001B5F0C File Offset: 0x001B410C
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

		// Token: 0x060024B9 RID: 9401 RVA: 0x001B5FE4 File Offset: 0x001B41E4
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

		// Token: 0x060024BA RID: 9402 RVA: 0x001B6088 File Offset: 0x001B4288
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

		// Token: 0x060024BB RID: 9403 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x060024BC RID: 9404 RVA: 0x001B6310 File Offset: 0x001B4510
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
						text = " where moshtari.id not in (-4,-1,-2,-3,-6)";
					}
					else
					{
						text += ",-1,-4,-2,-3,-6)";
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

		// Token: 0x060024BD RID: 9405 RVA: 0x001B6508 File Offset: 0x001B4708
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

		// Token: 0x060024BE RID: 9406 RVA: 0x001B660C File Offset: 0x001B480C
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

		// Token: 0x060024BF RID: 9407 RVA: 0x001B6890 File Offset: 0x001B4A90
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

		// Token: 0x060024C0 RID: 9408 RVA: 0x001B69B8 File Offset: 0x001B4BB8
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

		// Token: 0x060024C1 RID: 9409 RVA: 0x001B6A94 File Offset: 0x001B4C94
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

		// Token: 0x060024C2 RID: 9410 RVA: 0x001B6B48 File Offset: 0x001B4D48
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

		// Token: 0x060024C3 RID: 9411 RVA: 0x001B6C10 File Offset: 0x001B4E10
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

		// Token: 0x060024C4 RID: 9412 RVA: 0x001B7040 File Offset: 0x001B5240
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

		// Token: 0x060024C5 RID: 9413 RVA: 0x001B743C File Offset: 0x001B563C
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

		// Token: 0x060024C6 RID: 9414 RVA: 0x001B8A5C File Offset: 0x001B6C5C
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

		// Token: 0x060024C7 RID: 9415 RVA: 0x001B8C2C File Offset: 0x001B6E2C
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

		// Token: 0x060024C8 RID: 9416 RVA: 0x001B8D3C File Offset: 0x001B6F3C
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

		// Token: 0x060024C9 RID: 9417 RVA: 0x001B9104 File Offset: 0x001B7304
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

		// Token: 0x060024CA RID: 9418 RVA: 0x001B93FC File Offset: 0x001B75FC
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

		// Token: 0x060024CB RID: 9419 RVA: 0x001B9500 File Offset: 0x001B7700
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

		// Token: 0x060024CC RID: 9420 RVA: 0x001B9B74 File Offset: 0x001B7D74
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

		// Token: 0x060024CD RID: 9421 RVA: 0x001B9CF0 File Offset: 0x001B7EF0
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
							this.Saderat.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
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
							this.Saderat.DeleteDetailByID(Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["ID"]));
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

		// Token: 0x060024CE RID: 9422 RVA: 0x001BA1F8 File Offset: 0x001B83F8
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

		// Token: 0x060024CF RID: 9423 RVA: 0x00123D90 File Offset: 0x00121F90
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

		// Token: 0x060024D0 RID: 9424 RVA: 0x001BA2A4 File Offset: 0x001B84A4
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

		// Token: 0x060024D1 RID: 9425 RVA: 0x001BA448 File Offset: 0x001B8648
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

		// Token: 0x060024D2 RID: 9426 RVA: 0x001BA4C0 File Offset: 0x001B86C0
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

		// Token: 0x060024D3 RID: 9427 RVA: 0x001BAAA8 File Offset: 0x001B8CA8
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

		// Token: 0x060024D4 RID: 9428 RVA: 0x001BAAEC File Offset: 0x001B8CEC
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
						flag2 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
						if (flag2)
						{
							this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_fa"].Position;
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row++;
							this.GridEX1.EditMode = EditMode.EditOn;
						}
					}
				}
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00009488 File Offset: 0x00007688
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x001BAB94 File Offset: 0x001B8D94
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

		// Token: 0x060024D7 RID: 9431 RVA: 0x001BAC54 File Offset: 0x001B8E54
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

		// Token: 0x060024D8 RID: 9432 RVA: 0x001BAD14 File Offset: 0x001B8F14
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

		// Token: 0x060024D9 RID: 9433 RVA: 0x001BADD4 File Offset: 0x001B8FD4
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

		// Token: 0x060024DA RID: 9434 RVA: 0x001BAE94 File Offset: 0x001B9094
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

		// Token: 0x060024DB RID: 9435 RVA: 0x001BAF74 File Offset: 0x001B9174
		private void MeNew()
		{
			this.Load_Default_Nahve_Furush();
			this.Isnew = true;
			this.ID = -1;
			Public_Function.SetNew(this.UiGroupBox1);
			this.setEnable(true);
			DataTable detailByID = this.Saderat.GetDetailByID(-1L);
			this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID(-1L);
			bool flag = this.dt_rizbar != null;
			if (flag)
			{
				this.dt_rizbar.Clear();
			}
			this.dt_rizbar = this.RizBar.GetByID(-1);
			detailByID.Columns["Fee"].AllowDBNull = true;
			this.GridEX1.DataSource = detailByID;
			this.Num = checked((int)this.Saderat.GetNewID());
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_num.Focus();
			this.dt_Keraye = null;
			this.Grid_RizBar.DataSource = null;
			this.Grid_RizBar.Visible = false;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x001BB078 File Offset: 0x001B9278
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

		// Token: 0x060024DD RID: 9437 RVA: 0x001BB138 File Offset: 0x001B9338
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

		// Token: 0x060024DE RID: 9438 RVA: 0x001BB5C8 File Offset: 0x001B97C8
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

		// Token: 0x060024DF RID: 9439 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x060024E0 RID: 9440 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x060024E1 RID: 9441 RVA: 0x001BB804 File Offset: 0x001B9A04
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

		// Token: 0x060024E2 RID: 9442 RVA: 0x001BBDD8 File Offset: 0x001B9FD8
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

		// Token: 0x060024E3 RID: 9443 RVA: 0x001BBFC4 File Offset: 0x001BA1C4
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x001BC038 File Offset: 0x001BA238
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

		// Token: 0x060024E5 RID: 9445 RVA: 0x001BC108 File Offset: 0x001BA308
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

		// Token: 0x060024E6 RID: 9446 RVA: 0x001BC2A4 File Offset: 0x001BA4A4
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

		// Token: 0x060024E7 RID: 9447 RVA: 0x001BC308 File Offset: 0x001BA508
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
									this.ID = checked((int)this.Saderat.Insert(this.txt_num.Value.ToString(), this.txt_moshtari.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, this.txt_safikol.Value.ToString(), this.txt_keraye_mabda.Value.ToString(), nahve_furush, this.txt_safi_dolar.Value.ToString(), (DataTable)this.GridEX1.DataSource));
									this.Saderat_Keraye.Update(this.ID, this.dt_Keraye);
									DataTable detailByID = this.Saderat.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.Saderat_Keraye.GetByID(this.ID);
									this.Prepare_furush_detail(detailByID);
									this.RemoveZero(detailByID);
									this.GridEX1.DataSource = detailByID;
									this.Isnew = false;
								}
								else
								{
									this.Saderat_Keraye.Update(this.ID, this.dt_Keraye);
									this.Saderat.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), this.txt_moshtari.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, this.txt_safikol.Value.ToString(), this.txt_keraye_mabda.Value.ToString(), Conversions.ToString(this.GetNahve_Furush()), this.txt_safi_dolar.Value.ToString(), (DataTable)this.GridEX1.DataSource);
									DataTable detailByID2 = this.Saderat.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.Saderat_Keraye.GetByID(this.ID);
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

		// Token: 0x060024E8 RID: 9448 RVA: 0x001BC718 File Offset: 0x001BA918
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

		// Token: 0x060024E9 RID: 9449 RVA: 0x001BC760 File Offset: 0x001BA960
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

		// Token: 0x060024EA RID: 9450 RVA: 0x001BCDA4 File Offset: 0x001BAFA4
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

		// Token: 0x060024EB RID: 9451 RVA: 0x001BCEAC File Offset: 0x001BB0AC
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
			flag = (dr["safi_dolar"] != DBNull.Value);
			if (flag)
			{
				this.txt_safi_dolar.Text = Conversions.ToString(dr["safi_dolar"]);
			}
			else
			{
				this.txt_safi_dolar.SetNew();
			}
			this.txt_tedad.Text = dr["Tedad_Kol"].ToString().Replace(".0", "");
			this.dt_Keraye = this.Saderat_Keraye.GetByID(this.ID);
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

		// Token: 0x060024EC RID: 9452 RVA: 0x00126F38 File Offset: 0x00125138
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

		// Token: 0x060024ED RID: 9453 RVA: 0x001BD200 File Offset: 0x001BB400
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

		// Token: 0x060024EE RID: 9454 RVA: 0x001BD37C File Offset: 0x001BB57C
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

		// Token: 0x060024EF RID: 9455 RVA: 0x001BD484 File Offset: 0x001BB684
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

		// Token: 0x060024F0 RID: 9456 RVA: 0x001BD5A8 File Offset: 0x001BB7A8
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

		// Token: 0x060024F1 RID: 9457 RVA: 0x001BD6B4 File Offset: 0x001BB8B4
		private void LoadData()
		{
			DataRow byID = this.Saderat.GetByID((long)this.Num);
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
					DataTable detailByID = this.Saderat.GetDetailByID(Conversions.ToLong(byID["ID"]));
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

		// Token: 0x060024F2 RID: 9458 RVA: 0x001BDD80 File Offset: 0x001BBF80
		private void txt_num_First_Click()
		{
			long navigateID = this.Saderat.GetNavigateID(Saderat.NavTo.first, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060024F3 RID: 9459 RVA: 0x001BDDDC File Offset: 0x001BBFDC
		private void txt_num_Last_Click()
		{
			long navigateID = this.Saderat.GetNavigateID(Saderat.NavTo.last, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060024F4 RID: 9460 RVA: 0x001BDE38 File Offset: 0x001BC038
		private void txt_num_Next_Click()
		{
			long navigateID = this.Saderat.GetNavigateID(Saderat.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060024F5 RID: 9461 RVA: 0x001BDE94 File Offset: 0x001BC094
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Saderat.GetNavigateID(Saderat.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x060024F6 RID: 9462 RVA: 0x001BDEF0 File Offset: 0x001BC0F0
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

		// Token: 0x060024F7 RID: 9463 RVA: 0x000094C0 File Offset: 0x000076C0
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x001BDF70 File Offset: 0x001BC170
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

		// Token: 0x060024F9 RID: 9465 RVA: 0x001BE0EC File Offset: 0x001BC2EC
		public void Check_Enable()
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from safi_furush where furush_hag_id=" + Conversions.ToString(this.ID)));
			bool flag = num == 1;
			if (flag)
			{
				this.setEnable(false);
			}
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x001BE12C File Offset: 0x001BC32C
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

		// Token: 0x060024FB RID: 9467 RVA: 0x001BE198 File Offset: 0x001BC398
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

		// Token: 0x060024FC RID: 9468 RVA: 0x001BE2D8 File Offset: 0x001BC4D8
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

		// Token: 0x060024FD RID: 9469 RVA: 0x001BE8BC File Offset: 0x001BCABC
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.SyncTedad();
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x001BE924 File Offset: 0x001BCB24
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

		// Token: 0x060024FF RID: 9471 RVA: 0x001BE9F0 File Offset: 0x001BCBF0
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.Isnew;
			if (flag)
			{
				bool flag2 = Public_Function.ConfirmDelete() == DialogResult.Yes;
				if (flag2)
				{
					string empty = string.Empty;
					this.Saderat.Delete(Conversions.ToString(this.ID));
					this.MeNew();
				}
			}
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x001BEA40 File Offset: 0x001BCC40
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

		// Token: 0x06002501 RID: 9473 RVA: 0x001BEB6C File Offset: 0x001BCD6C
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

		// Token: 0x06002502 RID: 9474 RVA: 0x001BEC8C File Offset: 0x001BCE8C
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x001BECB8 File Offset: 0x001BCEB8
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

		// Token: 0x06002504 RID: 9476 RVA: 0x001BED1C File Offset: 0x001BCF1C
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

		// Token: 0x06002505 RID: 9477 RVA: 0x000094D3 File Offset: 0x000076D3
		private void txt_makharej_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem10_Click(null, null);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x001BEED0 File Offset: 0x001BD0D0
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem10_Click(null, null);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000094E0 File Offset: 0x000076E0
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x001BEEF8 File Offset: 0x001BD0F8
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem4_Click(null, null);
			}
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x001BEF20 File Offset: 0x001BD120
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

		// Token: 0x0600250A RID: 9482 RVA: 0x000094ED File Offset: 0x000076ED
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000094F8 File Offset: 0x000076F8
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00009503 File Offset: 0x00007703
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.Focus();
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x0600250E RID: 9486 RVA: 0x001BEF84 File Offset: 0x001BD184
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
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x001BF2B4 File Offset: 0x001BD4B4
		private void txt_sh_barname_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar.Focus();
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x001292DC File Offset: 0x001274DC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع مانده";
			}
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x001BF2E0 File Offset: 0x001BD4E0
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

		// Token: 0x06002512 RID: 9490 RVA: 0x001BF370 File Offset: 0x001BD570
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

		// Token: 0x06002513 RID: 9491 RVA: 0x00009513 File Offset: 0x00007713
		private void txt_safikol_TextChanged(object sender, EventArgs e)
		{
			this.GetDaramad();
		}

		// Token: 0x04000E05 RID: 3589
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000E07 RID: 3591
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000E08 RID: 3592
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000E09 RID: 3593
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000E0A RID: 3594
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000E0B RID: 3595
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000E0C RID: 3596
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000E0D RID: 3597
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000E0E RID: 3598
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000E0F RID: 3599
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04000E10 RID: 3600
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000E11 RID: 3601
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000E12 RID: 3602
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x04000E13 RID: 3603
		[AccessedThroughProperty("txt_tedad")]
		private NumericBox _txt_tedad;

		// Token: 0x04000E14 RID: 3604
		[AccessedThroughProperty("txt_sh_barname")]
		private EditBox _txt_sh_barname;

		// Token: 0x04000E15 RID: 3605
		[AccessedThroughProperty("txt_tarikh_vurud")]
		private DateBox2 _txt_tarikh_vurud;

		// Token: 0x04000E16 RID: 3606
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000E17 RID: 3607
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000E18 RID: 3608
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000E19 RID: 3609
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000E1A RID: 3610
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000E1B RID: 3611
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000E1C RID: 3612
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000E1D RID: 3613
		[AccessedThroughProperty("txt_baskul")]
		private NumericBox _txt_baskul;

		// Token: 0x04000E1E RID: 3614
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000E1F RID: 3615
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000E20 RID: 3616
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000E21 RID: 3617
		[AccessedThroughProperty("txt_baskul_mabda")]
		private NumericBox _txt_baskul_mabda;

		// Token: 0x04000E22 RID: 3618
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000E23 RID: 3619
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000E24 RID: 3620
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000E25 RID: 3621
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000E26 RID: 3622
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000E27 RID: 3623
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000E28 RID: 3624
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000E29 RID: 3625
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000E2A RID: 3626
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000E2B RID: 3627
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000E2C RID: 3628
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000E2D RID: 3629
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000E2E RID: 3630
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000E2F RID: 3631
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000E30 RID: 3632
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000E31 RID: 3633
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000E32 RID: 3634
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000E33 RID: 3635
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000E34 RID: 3636
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000E35 RID: 3637
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000E36 RID: 3638
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000E37 RID: 3639
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000E38 RID: 3640
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000E39 RID: 3641
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000E3A RID: 3642
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000E3B RID: 3643
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000E3C RID: 3644
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000E3D RID: 3645
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000E3E RID: 3646
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000E3F RID: 3647
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000E40 RID: 3648
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000E41 RID: 3649
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000E42 RID: 3650
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000E43 RID: 3651
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000E44 RID: 3652
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000E45 RID: 3653
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000E46 RID: 3654
		[AccessedThroughProperty("txt_safikol")]
		private CurrencyBox _txt_safikol;

		// Token: 0x04000E47 RID: 3655
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000E48 RID: 3656
		[AccessedThroughProperty("txt_keraye")]
		private CurrencyBox _txt_keraye;

		// Token: 0x04000E49 RID: 3657
		[AccessedThroughProperty("txt_safi")]
		private CurrencyBox _txt_safi;

		// Token: 0x04000E4A RID: 3658
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000E4B RID: 3659
		[AccessedThroughProperty("txt_daramad")]
		private CurrencyBox _txt_daramad;

		// Token: 0x04000E4C RID: 3660
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000E4D RID: 3661
		[AccessedThroughProperty("txt_keraye_mabda")]
		private CurrencyBox _txt_keraye_mabda;

		// Token: 0x04000E4E RID: 3662
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000E4F RID: 3663
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000E50 RID: 3664
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000E51 RID: 3665
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000E52 RID: 3666
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000E53 RID: 3667
		[AccessedThroughProperty("txt_safi_dolar")]
		private CurrencyBox _txt_safi_dolar;

		// Token: 0x04000E54 RID: 3668
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000E55 RID: 3669
		private Saderat Saderat;

		// Token: 0x04000E56 RID: 3670
		private Furush_Hag_RizBar RizBar;

		// Token: 0x04000E57 RID: 3671
		private Saderat_Keraye Saderat_Keraye;

		// Token: 0x04000E58 RID: 3672
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000E59 RID: 3673
		private Kala_To_Kala_Furush kala_to_kala;

		// Token: 0x04000E5A RID: 3674
		private DataTable dt_Keraye;

		// Token: 0x04000E5B RID: 3675
		private DataTable dt_kala_to_kala;

		// Token: 0x04000E5C RID: 3676
		private Frm_SelectItem frm;

		// Token: 0x04000E5D RID: 3677
		private Sanad sanad;

		// Token: 0x04000E5E RID: 3678
		private Sandugh Sandug;

		// Token: 0x04000E5F RID: 3679
		private Base_User_Control user;

		// Token: 0x04000E60 RID: 3680
		private int ID;

		// Token: 0x04000E61 RID: 3681
		public int Num;

		// Token: 0x04000E62 RID: 3682
		public int GotoLineID;

		// Token: 0x04000E63 RID: 3683
		private bool Isnew;

		// Token: 0x04000E64 RID: 3684
		private DataTable dt_rizbar;

		// Token: 0x04000E65 RID: 3685
		private bool prevent_close;

		// Token: 0x04000E66 RID: 3686
		private bool prevent_right;

		// Token: 0x04000E67 RID: 3687
		private bool prevent_left;

		// Token: 0x04000E68 RID: 3688
		private bool prevent_Enter;

		// Token: 0x04000E69 RID: 3689
		[CompilerGenerated]
		private bool _Show_Preview;
	}
}
