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
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000114 RID: 276
	[DesignerGenerated]
	public partial class Frm_SudKhorde : Form
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x00009E0A File Offset: 0x0000800A
		[DebuggerNonUserCode]
		public Frm_SudKhorde()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Sud_KeyDown);
			base.Load += new EventHandler(this.Frm_Sud_Load);
			Frm_SudKhorde.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x001E18EC File Offset: 0x001DFAEC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SudKhorde.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SudKhorde.__ENCList.Count == Frm_SudKhorde.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SudKhorde.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SudKhorde.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SudKhorde.__ENCList[num] = Frm_SudKhorde.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SudKhorde.__ENCList.RemoveRange(num, Frm_SudKhorde.__ENCList.Count - num);
						Frm_SudKhorde.__ENCList.Capacity = Frm_SudKhorde.__ENCList.Count;
					}
					Frm_SudKhorde.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x001E3904 File Offset: 0x001E1B04
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x00009E4A File Offset: 0x0000804A
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
				this._ButtonItem2 = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x001E391C File Offset: 0x001E1B1C
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x00009E54 File Offset: 0x00008054
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

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x001E3934 File Offset: 0x001E1B34
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x00009E5E File Offset: 0x0000805E
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

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x001E394C File Offset: 0x001E1B4C
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x00009E68 File Offset: 0x00008068
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x001E3964 File Offset: 0x001E1B64
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x00009E72 File Offset: 0x00008072
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x001E397C File Offset: 0x001E1B7C
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x00009E7C File Offset: 0x0000807C
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

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x001E3994 File Offset: 0x001E1B94
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x00009E86 File Offset: 0x00008086
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

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x001E39AC File Offset: 0x001E1BAC
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x00009E90 File Offset: 0x00008090
		internal virtual Bar Bar2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar2 = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x001E39C4 File Offset: 0x001E1BC4
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x00009E9A File Offset: 0x0000809A
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x001E39DC File Offset: 0x001E1BDC
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x00009EA4 File Offset: 0x000080A4
		internal virtual Bar Bar3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar3 = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x001E39F4 File Offset: 0x001E1BF4
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x001E3A0C File Offset: 0x001E1C0C
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

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x001E3A6C File Offset: 0x001E1C6C
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x00009EAE File Offset: 0x000080AE
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

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x001E3A84 File Offset: 0x001E1C84
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x001E3A9C File Offset: 0x001E1C9C
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
				NavBox.Previous_ClickEventHandler obj = new NavBox.Previous_ClickEventHandler(this.txt_num_Previous_Click);
				bool flag = this._txt_num != null;
				if (flag)
				{
					this._txt_num.Previous_Click -= obj;
				}
				this._txt_num = value;
				flag = (this._txt_num != null);
				if (flag)
				{
					this._txt_num.Previous_Click += obj;
				}
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x001E3AFC File Offset: 0x001E1CFC
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x00009EB8 File Offset: 0x000080B8
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

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x001E3B14 File Offset: 0x001E1D14
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x00009EC2 File Offset: 0x000080C2
		internal virtual CurrencyBox txt_sud
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sud;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sud = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x001E3B2C File Offset: 0x001E1D2C
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x00009ECC File Offset: 0x000080CC
		internal virtual CurrencyBox txt_kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kharid = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x001E3B44 File Offset: 0x001E1D44
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x00009ED6 File Offset: 0x000080D6
		internal virtual CurrencyBox txt_furush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_furush;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_furush = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x001E3B5C File Offset: 0x001E1D5C
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x001E3B74 File Offset: 0x001E1D74
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

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x001E3BD4 File Offset: 0x001E1DD4
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x00009EE0 File Offset: 0x000080E0
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

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x001E3BEC File Offset: 0x001E1DEC
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x00009EEA File Offset: 0x000080EA
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

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x001E3C04 File Offset: 0x001E1E04
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x00009EF4 File Offset: 0x000080F4
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x001E3C1C File Offset: 0x001E1E1C
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x00009EFE File Offset: 0x000080FE
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

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x001E3C34 File Offset: 0x001E1E34
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x001E3C4C File Offset: 0x001E1E4C
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

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x001E3CAC File Offset: 0x001E1EAC
		// (set) Token: 0x06002809 RID: 10249 RVA: 0x00009F08 File Offset: 0x00008108
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x001E3CC4 File Offset: 0x001E1EC4
		// (set) Token: 0x0600280B RID: 10251 RVA: 0x00009F12 File Offset: 0x00008112
		internal virtual EditBox txt_ta_tarikh
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
				this._txt_ta_tarikh = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x001E3CDC File Offset: 0x001E1EDC
		// (set) Token: 0x0600280D RID: 10253 RVA: 0x00009F1C File Offset: 0x0000811C
		internal virtual EditBox txt_az_tarikh
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
				this._txt_az_tarikh = value;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x001E3CF4 File Offset: 0x001E1EF4
		// (set) Token: 0x0600280F RID: 10255 RVA: 0x00009F26 File Offset: 0x00008126
		internal virtual DataEntryGrid DataEntryGrid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataEntryGrid1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataEntryGrid1 = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x001E3D0C File Offset: 0x001E1F0C
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x00009F30 File Offset: 0x00008130
		internal virtual CurrencyBox txt_hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hazine = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x001E3D24 File Offset: 0x001E1F24
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x00009F3A File Offset: 0x0000813A
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

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x001E3D3C File Offset: 0x001E1F3C
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x001E3D54 File Offset: 0x001E1F54
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
				EventHandler value2 = new EventHandler(this.CurrencyBox1_TextChanged);
				bool flag = this._CurrencyBox1 != null;
				if (flag)
				{
					this._CurrencyBox1.TextChanged -= value2;
				}
				this._CurrencyBox1 = value;
				flag = (this._CurrencyBox1 != null);
				if (flag)
				{
					this._CurrencyBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x001E3DB4 File Offset: 0x001E1FB4
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x00009F44 File Offset: 0x00008144
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

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x001E3DCC File Offset: 0x001E1FCC
		// (set) Token: 0x06002819 RID: 10265 RVA: 0x00009F4E File Offset: 0x0000814E
		internal virtual CurrencyBox CurrencyBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CurrencyBox2 = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x001E3DE4 File Offset: 0x001E1FE4
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x00009F58 File Offset: 0x00008158
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

		// Token: 0x0600281C RID: 10268 RVA: 0x00031770 File Offset: 0x0002F970
		private void Frm_Sud_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F2);
				if (flag)
				{
				}
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x001E3DFC File Offset: 0x001E1FFC
		private void LoadData()
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			bool flag = Operators.CompareString(this.txt_az_tarikh.Text, "اول دوره", false) == 0;
			if (flag)
			{
				text = "  tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
				text2 = "  sanad.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
				text3 = "  khordefurushi.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			}
			else
			{
				flag = (Operators.CompareString(this.txt_az_tarikh.Text, this.txt_ta_tarikh.Text, false) > 0);
				if (flag)
				{
					this.txt_ta_tarikh.Text = this.txt_az_tarikh.Text;
				}
				text = " tarikh >=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
				text2 = " sanad.tarikh >=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND sanad.Tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
				text3 = " khordefurushi.tarikh >=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND khordefurushi.Tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			}
			this.txt_num.Value = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(max(num)+1,1) from sud"));
			this.CurrencyBox1.SetNew();
			string text4 = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 mablagh_kharid from sud order by id desc"));
			flag = (text4 != null);
			if (flag)
			{
				this.CurrencyBox2.Text = text4;
			}
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT    tarikh_fa,isnull(sum( KhordeFurushi_Detail.Jam_Kol),0) as kharid,0 as furush,isnull(sum(keraye),0) as hazine,1 as code FROM         KhordeFurushi INNER JOIN KhordeFurushi_Detail ON KhordeFurushi.ID = KhordeFurushi_Detail.Khordefurushi_id  where ",
				text,
				" group by Tarikh_fa   union all   select tarikh_fa,0 as kharid,isnull(sum(mablagh),0) as furush,0 as hazine,2 as code from daryaftpardakht where dptype_id=35 AND ",
				text,
				" group by Tarikh_fa   union all  select tarikh_fa,0 as kharid,0 as furush,sum(hazine) as hazine,3 as code from(  SELECT    tarikh_fa, isnull(sum(Bed),0)-isnull(sum(Bes),0) as hazine  FROM Sanad where CodeHesab_ID in (select id from code_hesab where grouh_ID=5)  AND ",
				text,
				" group by Tarikh_fa  union all   SELECT      sanad.tarikh_fa,isnull(sum(Sanad.Bed),0)-isnull(sum(Sanad.Bes),0) as hazine   FROM         DaryaftPardakht INNER JOIN Sanad ON DaryaftPardakht.SanadBed_ID = Sanad.ID    WHERE     (DaryaftPardakht.dpType_ID IN (15, 30)) AND (DaryaftPardakht.Moshtari_ID IS NOT NULL) AND ",
				text2,
				" group by sanad.Tarikh_fa  union all  SELECT   KhordeFurushi.tarikh_fa,sum(KhordeFurushi_Keraye.Keraye) as hazine FROM KhordeFurushi_Keraye INNER JOIN KhordeFurushi ON KhordeFurushi_Keraye.Khordefurushi_ID = KhordeFurushi.ID  where ",
				text3,
				" group by KhordeFurushi.tarikh_fa)t   group by tarikh_fa   order by tarikh_fa,code"
			}));
			dataTable.Columns.Add("sud", typeof(long));
			string right = string.Empty;
			int arg_281_0 = 0;
			checked
			{
				int num = dataTable.Rows.Count - 1;
				int num2 = arg_281_0;
				bool flag4;
				while (true)
				{
					int arg_5A5_0 = num2;
					int num3 = num;
					if (arg_5A5_0 > num3)
					{
						break;
					}
					flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num2]["tarikh_fa"], right, false);
					if (flag)
					{
						right = Conversions.ToString(dataTable.Rows[num2]["tarikh_fa"]);
						object left = dataTable.Rows[num2]["code"];
						flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
						if (flag)
						{
							bool flag2 = num2 + 1 <= dataTable.Rows.Count - 1;
							if (flag2)
							{
								bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2 + 1]["tarikh_fa"], right, false);
								if (flag3)
								{
									object left2 = dataTable.Rows[num2 + 1]["code"];
									flag4 = Operators.ConditionalCompareObjectEqual(left2, 2, false);
									if (flag4)
									{
										dataTable.Rows[num2]["furush"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[num2 + 1]["furush"]);
									}
									else
									{
										flag4 = Operators.ConditionalCompareObjectEqual(left2, 3, false);
										if (flag4)
										{
											DataRow dataRow = dataTable.Rows[num2];
											DataRow arg_405_0 = dataRow;
											string columnName = "hazine";
											arg_405_0[columnName] = Operators.AddObject(dataRow[columnName], dataTable.Rows[num2 + 1]["hazine"]);
										}
									}
								}
							}
							flag4 = (num2 + 2 <= dataTable.Rows.Count - 1);
							if (flag4)
							{
								bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2 + 2]["tarikh_fa"], right, false);
								if (flag3)
								{
									DataRow dataRow = dataTable.Rows[num2];
									DataRow arg_491_0 = dataRow;
									string columnName = "hazine";
									arg_491_0[columnName] = Operators.AddObject(dataRow[columnName], dataTable.Rows[num2 + 2]["hazine"]);
								}
							}
						}
						else
						{
							flag4 = Operators.ConditionalCompareObjectEqual(left, 2, false);
							if (flag4)
							{
								dataTable.Rows[num2]["code"] = 1;
								flag4 = (num2 + 1 <= dataTable.Rows.Count - 1);
								if (flag4)
								{
									bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2 + 1]["tarikh_fa"], right, false);
									if (flag3)
									{
										DataRow dataRow = dataTable.Rows[num2];
										DataRow arg_557_0 = dataRow;
										string columnName = "hazine";
										arg_557_0[columnName] = Operators.AddObject(dataRow[columnName], dataTable.Rows[num2 + 1]["hazine"]);
									}
								}
							}
							else
							{
								flag4 = Operators.ConditionalCompareObjectEqual(left, 3, false);
								if (flag4)
								{
									dataTable.Rows[num2]["code"] = 1;
								}
							}
						}
					}
					num2++;
				}
				this.DataEntryGrid1.DataSource = dataTable;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						dataRow2["sud"] = Operators.SubtractObject(dataRow2["furush"], Operators.AddObject(dataRow2["kharid"], dataRow2["hazine"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag4 = (enumerator is IDisposable);
					if (flag4)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				long? value = this.CurrencyBox2.Value;
				flag4 = value.HasValue;
				long num4;
				long? value2;
				if (flag4)
				{
					DataTable dataTable2 = (DataTable)this.DataEntryGrid1.DataSource;
					flag4 = (dataTable2 != null);
					if (flag4)
					{
						bool flag3 = dataTable2.Rows.Count > 0;
						if (flag3)
						{
							DataRow dataRow3 = dataTable2.Rows[dataTable2.Rows.Count - 1];
							flag4 = Operators.ConditionalCompareObjectEqual(dataRow3["tarikh_fa"], "خرید از قبل", false);
							if (flag4)
							{
								dataRow3["kharid"] = this.CurrencyBox2.Value;
								DataRow arg_737_0 = dataRow3;
								string arg_737_1 = "sud";
								num4 = -1L;
								value = this.CurrencyBox2.Value;
								long? arg_732_0;
								if (!value.HasValue)
								{
									arg_732_0 = null;
								}
								else
								{
									value2 = new long?(num4 * value.GetValueOrDefault());
									arg_732_0 = value2;
								}
								arg_737_0[arg_737_1] = arg_732_0;
							}
							else
							{
								DataRow dataRow4 = dataTable2.NewRow();
								dataRow4["tarikh_fa"] = "خرید از قبل";
								DataRow arg_7A4_0 = dataRow4;
								string arg_7A4_1 = "sud";
								num4 = -1L;
								value2 = this.CurrencyBox2.Value;
								long? arg_79F_0;
								if (!value2.HasValue)
								{
									arg_79F_0 = null;
								}
								else
								{
									value = new long?(num4 * value2.GetValueOrDefault());
									arg_79F_0 = value;
								}
								arg_7A4_0[arg_7A4_1] = arg_79F_0;
								dataRow4["kharid"] = this.CurrencyBox2.Value;
								dataTable2.Rows.InsertAt(dataRow4, 0);
							}
						}
					}
				}
				this.txt_kharid.Text = Conversions.ToString(this.DataEntryGrid1.GetTotal(this.DataEntryGrid1.RootTable.Columns["kharid"], AggregateFunction.Sum));
				this.txt_hazine.Text = Conversions.ToString(this.DataEntryGrid1.GetTotal(this.DataEntryGrid1.RootTable.Columns["hazine"], AggregateFunction.Sum));
				this.txt_furush.Text = Conversions.ToString(this.DataEntryGrid1.GetTotal(this.DataEntryGrid1.RootTable.Columns["furush"], AggregateFunction.Sum));
				this.txt_sud.Text = Conversions.ToString(this.DataEntryGrid1.GetTotal(this.DataEntryGrid1.RootTable.Columns["sud"], AggregateFunction.Sum));
				flag4 = (dataTable.Rows.Count > 0);
				if (flag4)
				{
					this.txt_az_tarikh.Text = Conversions.ToString(dataTable.Rows[0]["tarikh_fa"]);
					this.txt_ta_tarikh.Text = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["tarikh_fa"]);
				}
				else
				{
					this.txt_ta_tarikh.Text = this.txt_az_tarikh.Text;
				}
				this.loadSharik();
				num4 = 0L;
				value2 = this.txt_sud.Value;
				bool? arg_982_0;
				if (!value2.HasValue)
				{
					arg_982_0 = null;
				}
				else
				{
					bool? flag5 = new bool?(value2.GetValueOrDefault() == num4);
					arg_982_0 = flag5;
				}
				bool? flag6 = arg_982_0;
				flag4 = flag6.GetValueOrDefault();
				if (flag4)
				{
					this.txt_sud.ForeColor = Color.Black;
				}
				else
				{
					num4 = 0L;
					value2 = this.txt_sud.Value;
					bool? arg_9DF_0;
					if (!value2.HasValue)
					{
						arg_9DF_0 = null;
					}
					else
					{
						flag6 = new bool?(value2.GetValueOrDefault() > num4);
						arg_9DF_0 = flag6;
					}
					bool? flag5 = arg_9DF_0;
					flag4 = flag5.GetValueOrDefault();
					if (flag4)
					{
						this.txt_sud.ForeColor = Color.Blue;
					}
					else
					{
						this.txt_sud.ForeColor = Color.Red;
					}
				}
			}
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x001E4830 File Offset: 0x001E2A30
		private void Frm_Sud_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 tarikh from sud order by tarikh desc"));
			bool flag = Operators.CompareString(text, string.Empty, false) == 0 || text == null;
			if (flag)
			{
				this.txt_az_tarikh.Text = "اول دوره";
			}
			else
			{
				DateTime datetime = Conversions.ToDate(text).AddDays(1.0);
				this.txt_az_tarikh.Text = Public_Function.MiladiToShamsi(datetime);
			}
			this.txt_ta_tarikh.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			this.txt_num.NumericBox1.Font = this.Font;
			this.txt_num.UiButton4.Visible = false;
			this.txt_num.UiButton2.Visible = false;
			this.txt_num.Height = 36;
			this.LoadData();
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x001E4928 File Offset: 0x001E2B28
		private void loadSharik()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Sharik.Moshtari_ID, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name,Moshtari.CodeHesab_ID, Sharik.Darsad  FROM         Sharik INNER JOIN  Moshtari ON Sharik.Moshtari_ID = Moshtari.ID  where darsad>0");
			dataTable.Columns.Add("mablagh", typeof(long));
			this.GridEX1.DataSource = dataTable;
			decimal num = 0m;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					num = Conversions.ToDecimal(Operators.AddObject(num, dataRow["darsad"]));
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
			flag = (decimal.Compare(num, new decimal(100L)) != 0);
			if (flag)
			{
				this.UiGroupBox2.Visible = true;
			}
			else
			{
				this.UiGroupBox2.Visible = false;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						DataRow arg_18C_0 = dataRow2;
						string arg_18C_1 = "mablagh";
						double num2 = 100.0;
						long? value = this.txt_sud.Value;
						double? arg_14C_0;
						if (!value.HasValue)
						{
							arg_14C_0 = null;
						}
						else
						{
							double? num3 = new double?((double)value.GetValueOrDefault());
							arg_14C_0 = num3;
						}
						double? num4 = arg_14C_0;
						double? arg_177_0;
						if (!num4.HasValue)
						{
							arg_177_0 = null;
						}
						else
						{
							double? num5 = new double?(num4.GetValueOrDefault() / num2);
							arg_177_0 = num5;
						}
						arg_18C_0[arg_18C_1] = Operators.MultiplyObject(arg_177_0, dataRow2["darsad"]);
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
			}
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x001E4B1C File Offset: 0x001E2D1C
		private void Insert()
		{
			string text = "declare @daramad_id bigint,@hazine_id bigint,@sud_id int,@sanad_id bigint;";
			Sanad sanad = new Sanad();
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(max(num),0)+1 from sud"));
			string tozih = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				"INSERT INTO [Sud] ([Num],[Tarikh],[Tarikh_Fa],mablagh_kharid) VALUES(",
				text2,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)),
				",",
				Public_Function.GetValue(this.txt_ta_tarikh.Text),
				",",
				Public_Function.GetValue(this.CurrencyBox1.Value.ToString()),
				");select @sud_id=Scope_Identity();"
			});
			try
			{
				IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					long num = 0L;
					long? value = this.txt_sud.Value;
					bool? arg_131_0;
					bool? flag;
					if (!value.HasValue)
					{
						arg_131_0 = null;
					}
					else
					{
						flag = new bool?(value.GetValueOrDefault() > num);
						arg_131_0 = flag;
					}
					bool? flag2 = arg_131_0;
					bool flag3 = flag2.GetValueOrDefault();
					if (flag3)
					{
						tozih = "سود مغازه از تاریخ" + this.txt_az_tarikh.Text + " تاتاریخ " + this.txt_ta_tarikh.Text;
					}
					else
					{
						tozih = "زیان مغازه از تاریخ" + this.txt_az_tarikh.Text + " تاتاریخ " + this.txt_ta_tarikh.Text;
					}
					num = 0L;
					value = this.txt_sud.Value;
					bool? arg_1CB_0;
					if (!value.HasValue)
					{
						arg_1CB_0 = null;
					}
					else
					{
						flag2 = new bool?(value.GetValueOrDefault() > num);
						arg_1CB_0 = flag2;
					}
					flag = arg_1CB_0;
					flag3 = flag.GetValueOrDefault();
					if (flag3)
					{
						text += sanad.InsertStr(Conversions.ToString(dataRow["codehesab_ID"]), "0", Conversions.ToString(dataRow["mablagh"]), Public_Function.MiladiToShamsi(DateAndTime.Now), tozih, "@sanad_id", Sanad.SanadType.@null);
					}
					else
					{
						text += sanad.InsertStr(Conversions.ToString(dataRow["codehesab_ID"]), Conversions.ToString(dataRow["mablagh"]), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), tozih, "@sanad_id", Sanad.SanadType.@null);
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [Sud_Detail] ([Sud_ID],[Moshtari_ID],[Darsad],[Mablagh],[Sanad_ID]) values(@sud_id,", dataRow["moshtari_id"]), ","), dataRow["darsad"]), ","), dataRow["mablagh"]), ",@sanad_id);")));
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
			Public_Function.ExecuteNonQuery(text);
			Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x001E4E5C File Offset: 0x001E305C
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			Frm_SahebSaham showFrm = new Frm_SahebSaham();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
			this.loadSharik();
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x001E4E8C File Offset: 0x001E308C
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			long num = 0L;
			long? value = this.txt_sud.Value;
			bool? arg_3C_0;
			if (!value.HasValue)
			{
				arg_3C_0 = null;
			}
			else
			{
				bool? flag = new bool?(value.GetValueOrDefault() == num);
				arg_3C_0 = flag;
			}
			bool? flag2 = arg_3C_0;
			bool flag3 = flag2.GetValueOrDefault();
			if (!flag3)
			{
				flag3 = this.UiGroupBox2.Visible;
				if (!flag3)
				{
					this.Insert();
					string text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 tarikh from sud order by tarikh desc"));
					flag3 = (Operators.CompareString(text, string.Empty, false) == 0 || text == null);
					if (flag3)
					{
						this.txt_az_tarikh.Text = "اول دوره";
					}
					else
					{
						DateTime datetime = Conversions.ToDate(text).AddDays(1.0);
						this.txt_az_tarikh.Text = Public_Function.MiladiToShamsi(datetime);
					}
					this.txt_ta_tarikh.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
					this.LoadData();
				}
			}
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x001E4F94 File Offset: 0x001E3194
		private void txt_num_Previous_Click()
		{
			checked
			{
				long value = (long)Math.Round(unchecked(Conversions.ToDouble(this.txt_num.Value) - 1.0));
				DataTable dataTable = Public_Function.FillData("select * from sud where num=" + Conversions.ToString(value));
				bool flag = dataTable.Rows.Count > 0;
				if (flag)
				{
					this.txt_num.Value = Conversions.ToString(value);
					this.txt_az_tarikh.Text = Conversions.ToString(dataTable.Rows[0]["tarikh_fa"]);
					DataTable dataTable2 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from sanad where id in( ", dataTable.Rows[0]["DaramadSanad_ID"]), ","), dataTable.Rows[0]["HazineSanad_ID"]), ")")));
					flag = (dataTable2.Rows.Count > 0);
					if (flag)
					{
						this.txt_furush.Text = Conversions.ToString(dataTable2.Rows[0]["bed"]);
						this.txt_kharid.Text = Conversions.ToString(dataTable2.Rows[1]["bes"]);
						Control arg_1A6_0 = this.txt_sud;
						long? value2 = this.txt_furush.Value;
						bool arg_174_0 = value2.HasValue;
						long? value3 = this.txt_kharid.Value;
						long? arg_19C_0;
						if (!(arg_174_0 & value3.HasValue))
						{
							arg_19C_0 = null;
						}
						else
						{
							long? num = new long?(value2.GetValueOrDefault() - value3.GetValueOrDefault());
							arg_19C_0 = num;
						}
						arg_1A6_0.Text = Conversions.ToString((T)arg_19C_0);
						this.loadSharik();
					}
				}
			}
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x001E5158 File Offset: 0x001E3358
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			DataTable dataTable = Public_Function.FillData("select * from sud where num=" + this.txt_num.Value);
			string text = "";
			string text2 = "";
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataTable.Rows[0]["DaramadSanad_ID"]), ","), dataTable.Rows[0]["HazineSanad_ID"]), ")")));
				DataTable dt = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from sud_detail where sud_id=", dataTable.Rows[0]["ID"])));
				text2 += Public_Function.GetID(dt, "Sanad_ID", "");
				text = text + "delete from sanad where id in(" + text2 + ");";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sud_detail where sud_id=", dataTable.Rows[0]["ID"]), ";")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("delete from sud where id =", dataTable.Rows[0]["ID"])));
				Public_Function.ExecuteNonQuery(text);
				Public_Function.ShowMessage("اطلاعات مورد نظر حذف گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x001E52D0 File Offset: 0x001E34D0
		private void CurrencyBox1_TextChanged(object sender, EventArgs e)
		{
			long num = 0L;
			long? value = this.CurrencyBox1.Value;
			bool? arg_3C_0;
			if (!value.HasValue)
			{
				arg_3C_0 = null;
			}
			else
			{
				bool? flag = new bool?(value.GetValueOrDefault() > num);
				arg_3C_0 = flag;
			}
			bool? flag2 = arg_3C_0;
			bool flag3 = flag2.GetValueOrDefault();
			checked
			{
				if (flag3)
				{
					DataTable dataTable = (DataTable)this.DataEntryGrid1.DataSource;
					flag3 = (dataTable != null);
					if (flag3)
					{
						DataRow dataRow = dataTable.Rows[dataTable.Rows.Count - 1];
						flag3 = Operators.ConditionalCompareObjectEqual(dataRow["tarikh_fa"], "خرید مانده در مغازه", false);
						if (flag3)
						{
							DataRow arg_E9_0 = dataRow;
							string arg_E9_1 = "kharid";
							num = -1L;
							value = this.CurrencyBox1.Value;
							long? arg_E4_0;
							if (!value.HasValue)
							{
								arg_E4_0 = null;
							}
							else
							{
								long? value2 = new long?(num * value.GetValueOrDefault());
								arg_E4_0 = value2;
							}
							arg_E9_0[arg_E9_1] = arg_E4_0;
							dataRow["sud"] = this.CurrencyBox1.Value;
						}
						else
						{
							DataRow dataRow2 = dataTable.NewRow();
							dataRow2["tarikh_fa"] = "خرید مانده در مغازه";
							dataRow2["sud"] = this.CurrencyBox1.Value;
							DataRow arg_18A_0 = dataRow2;
							string arg_18A_1 = "kharid";
							num = -1L;
							long? value2 = this.CurrencyBox1.Value;
							long? arg_185_0;
							if (!value2.HasValue)
							{
								arg_185_0 = null;
							}
							else
							{
								value = new long?(num * value2.GetValueOrDefault());
								arg_185_0 = value;
							}
							arg_18A_0[arg_18A_1] = arg_185_0;
							dataTable.Rows.Add(dataRow2);
						}
					}
				}
				else
				{
					DataTable dataTable2 = (DataTable)this.DataEntryGrid1.DataSource;
					flag3 = (dataTable2 != null);
					if (flag3)
					{
						DataRow dataRow3 = dataTable2.Rows[dataTable2.Rows.Count - 1];
						flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["tarikh_fa"], "خرید مانده در مغازه", false);
						if (flag3)
						{
							dataTable2.Rows[dataTable2.Rows.Count - 1].Delete();
							dataTable2.AcceptChanges();
						}
					}
				}
				this.txt_sud.Text = Conversions.ToString(this.DataEntryGrid1.GetTotal(this.DataEntryGrid1.RootTable.Columns["sud"], AggregateFunction.Sum));
				this.loadSharik();
			}
		}

		// Token: 0x04000F8C RID: 3980
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F8E RID: 3982
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000F8F RID: 3983
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000F90 RID: 3984
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F91 RID: 3985
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000F92 RID: 3986
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000F93 RID: 3987
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000F94 RID: 3988
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F95 RID: 3989
		[AccessedThroughProperty("Bar2")]
		private Bar _Bar2;

		// Token: 0x04000F96 RID: 3990
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F97 RID: 3991
		[AccessedThroughProperty("Bar3")]
		private Bar _Bar3;

		// Token: 0x04000F98 RID: 3992
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000F99 RID: 3993
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000F9A RID: 3994
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000F9B RID: 3995
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000F9C RID: 3996
		[AccessedThroughProperty("txt_sud")]
		private CurrencyBox _txt_sud;

		// Token: 0x04000F9D RID: 3997
		[AccessedThroughProperty("txt_kharid")]
		private CurrencyBox _txt_kharid;

		// Token: 0x04000F9E RID: 3998
		[AccessedThroughProperty("txt_furush")]
		private CurrencyBox _txt_furush;

		// Token: 0x04000F9F RID: 3999
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000FA0 RID: 4000
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000FA1 RID: 4001
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000FA2 RID: 4002
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000FA3 RID: 4003
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000FA4 RID: 4004
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000FA5 RID: 4005
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000FA6 RID: 4006
		[AccessedThroughProperty("txt_ta_tarikh")]
		private EditBox _txt_ta_tarikh;

		// Token: 0x04000FA7 RID: 4007
		[AccessedThroughProperty("txt_az_tarikh")]
		private EditBox _txt_az_tarikh;

		// Token: 0x04000FA8 RID: 4008
		[AccessedThroughProperty("DataEntryGrid1")]
		private DataEntryGrid _DataEntryGrid1;

		// Token: 0x04000FA9 RID: 4009
		[AccessedThroughProperty("txt_hazine")]
		private CurrencyBox _txt_hazine;

		// Token: 0x04000FAA RID: 4010
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000FAB RID: 4011
		[AccessedThroughProperty("CurrencyBox1")]
		private CurrencyBox _CurrencyBox1;

		// Token: 0x04000FAC RID: 4012
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000FAD RID: 4013
		[AccessedThroughProperty("CurrencyBox2")]
		private CurrencyBox _CurrencyBox2;

		// Token: 0x04000FAE RID: 4014
		[AccessedThroughProperty("Label11")]
		private Label _Label11;
	}
}
