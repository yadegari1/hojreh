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
	// Token: 0x020000F1 RID: 241
	[DesignerGenerated]
	public partial class Frm_Frush_Sardkhane : Form
	{
		// Token: 0x06001B15 RID: 6933 RVA: 0x001395D8 File Offset: 0x001377D8
		public Frm_Frush_Sardkhane()
		{
			base.Deactivate += new EventHandler(this.Frm_Frush_Sardkhane_Deactivate);
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Kharid_Furush_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frm_Frush_hag_KeyDown);
			base.Load += new EventHandler(this.frm_Frush_hag_Load);
			Frm_Frush_Sardkhane.__ENCAddToList(this);
			this.Furush = new Furush_Sardkhane();
			this.RizBar = new Furush_Sardkhane_RizBar();
			this.Furush_Keraye = new Furush_Sardkhane_Keraye();
			this.Moshtari_Info = new Moshtari_Info();
			this.kala_to_kala = new Kala_To_Kala_Furush_Sardkhane();
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
			bool show_Preview = false;
			this.Show_Preview = show_Preview;
			this.InitializeComponent();
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x001396F8 File Offset: 0x001378F8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Frush_Sardkhane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Frush_Sardkhane.__ENCList.Count == Frm_Frush_Sardkhane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Frush_Sardkhane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Frush_Sardkhane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Frush_Sardkhane.__ENCList[num] = Frm_Frush_Sardkhane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Frush_Sardkhane.__ENCList.RemoveRange(num, Frm_Frush_Sardkhane.__ENCList.Count - num);
						Frm_Frush_Sardkhane.__ENCList.Capacity = Frm_Frush_Sardkhane.__ENCList.Count;
					}
					Frm_Frush_Sardkhane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0013C714 File Offset: 0x0013A914
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x00007B1B File Offset: 0x00005D1B
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

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0013C72C File Offset: 0x0013A92C
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x00007B25 File Offset: 0x00005D25
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

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0013C744 File Offset: 0x0013A944
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00007B2F File Offset: 0x00005D2F
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

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0013C75C File Offset: 0x0013A95C
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x00007B39 File Offset: 0x00005D39
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

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x0013C774 File Offset: 0x0013A974
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x00007B43 File Offset: 0x00005D43
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

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0013C78C File Offset: 0x0013A98C
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x00007B4D File Offset: 0x00005D4D
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

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0013C7A4 File Offset: 0x0013A9A4
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x00007B57 File Offset: 0x00005D57
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

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0013C7BC File Offset: 0x0013A9BC
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x00007B61 File Offset: 0x00005D61
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

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0013C7D4 File Offset: 0x0013A9D4
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0013C7EC File Offset: 0x0013A9EC
		internal virtual SelectItem txt_kharid
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_kharid != null;
				if (flag)
				{
					this._txt_kharid.SelectedValueChanged -= obj;
				}
				this._txt_kharid = value;
				flag = (this._txt_kharid != null);
				if (flag)
				{
					this._txt_kharid.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0013C84C File Offset: 0x0013AA4C
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0013C864 File Offset: 0x0013AA64
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

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0013C998 File Offset: 0x0013AB98
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0013C9B0 File Offset: 0x0013ABB0
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0013CA10 File Offset: 0x0013AC10
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00007B6B File Offset: 0x00005D6B
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

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0013CA28 File Offset: 0x0013AC28
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00007B75 File Offset: 0x00005D75
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

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0013CA40 File Offset: 0x0013AC40
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0013CA58 File Offset: 0x0013AC58
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0013CAB8 File Offset: 0x0013ACB8
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x00007B7F File Offset: 0x00005D7F
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

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0013CAD0 File Offset: 0x0013ACD0
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0013CAE8 File Offset: 0x0013ACE8
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
				EndCustomEditEventHandler value4 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				KeyEventHandler value5 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				RowLoadEventHandler value8 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyPressEventHandler value9 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.InitCustomEdit -= value2;
					this._GridEX1.SelectionChanged -= value3;
					this._GridEX1.EndCustomEdit -= value4;
					this._GridEX1.KeyDown -= value5;
					this._GridEX1.ColumnButtonClick -= value6;
					this._GridEX1.CellEdited -= value7;
					this._GridEX1.LoadingRow -= value8;
					this._GridEX1.KeyPress -= value9;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.InitCustomEdit += value2;
					this._GridEX1.SelectionChanged += value3;
					this._GridEX1.EndCustomEdit += value4;
					this._GridEX1.KeyDown += value5;
					this._GridEX1.ColumnButtonClick += value6;
					this._GridEX1.CellEdited += value7;
					this._GridEX1.LoadingRow += value8;
					this._GridEX1.KeyPress += value9;
				}
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0013CC70 File Offset: 0x0013AE70
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00007B89 File Offset: 0x00005D89
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

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0013CC88 File Offset: 0x0013AE88
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x0013CCA0 File Offset: 0x0013AEA0
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x0013CD00 File Offset: 0x0013AF00
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0013CD18 File Offset: 0x0013AF18
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x0013CD78 File Offset: 0x0013AF78
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0013CD90 File Offset: 0x0013AF90
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x0013CDF0 File Offset: 0x0013AFF0
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0013CE08 File Offset: 0x0013B008
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

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x0013CE68 File Offset: 0x0013B068
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0013CE80 File Offset: 0x0013B080
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

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0013CEE0 File Offset: 0x0013B0E0
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x00007B93 File Offset: 0x00005D93
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

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0013CEF8 File Offset: 0x0013B0F8
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00007B9D File Offset: 0x00005D9D
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

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x0013CF10 File Offset: 0x0013B110
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x0013CF28 File Offset: 0x0013B128
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

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x0013CF88 File Offset: 0x0013B188
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0013CFA0 File Offset: 0x0013B1A0
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

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x0013D000 File Offset: 0x0013B200
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00007BA7 File Offset: 0x00005DA7
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

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0013D018 File Offset: 0x0013B218
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00007BB1 File Offset: 0x00005DB1
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

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0013D030 File Offset: 0x0013B230
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x0013D048 File Offset: 0x0013B248
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0013D0A8 File Offset: 0x0013B2A8
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0013D0C0 File Offset: 0x0013B2C0
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0013D120 File Offset: 0x0013B320
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00007BBB File Offset: 0x00005DBB
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

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0013D138 File Offset: 0x0013B338
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00007BC5 File Offset: 0x00005DC5
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

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0013D150 File Offset: 0x0013B350
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x00007BCF File Offset: 0x00005DCF
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

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0013D168 File Offset: 0x0013B368
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00007BD9 File Offset: 0x00005DD9
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0013D180 File Offset: 0x0013B380
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00007BE3 File Offset: 0x00005DE3
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0013D198 File Offset: 0x0013B398
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00007BED File Offset: 0x00005DED
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

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0013D1B0 File Offset: 0x0013B3B0
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00007BF7 File Offset: 0x00005DF7
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

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0013D1C8 File Offset: 0x0013B3C8
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00007C01 File Offset: 0x00005E01
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

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0013D1E0 File Offset: 0x0013B3E0
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00007C0B File Offset: 0x00005E0B
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

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0013D1F8 File Offset: 0x0013B3F8
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x00007C15 File Offset: 0x00005E15
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

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0013D210 File Offset: 0x0013B410
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x00007C1F File Offset: 0x00005E1F
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

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0013D228 File Offset: 0x0013B428
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0013D240 File Offset: 0x0013B440
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

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0013D2A0 File Offset: 0x0013B4A0
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0013D2B8 File Offset: 0x0013B4B8
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

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0013D318 File Offset: 0x0013B518
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0013D330 File Offset: 0x0013B530
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

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0013D3B8 File Offset: 0x0013B5B8
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x00007C29 File Offset: 0x00005E29
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

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0013D3D0 File Offset: 0x0013B5D0
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x00007C33 File Offset: 0x00005E33
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

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0013D3E8 File Offset: 0x0013B5E8
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x00007C3D File Offset: 0x00005E3D
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

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0013D400 File Offset: 0x0013B600
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x00007C47 File Offset: 0x00005E47
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

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0013D418 File Offset: 0x0013B618
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x00007C51 File Offset: 0x00005E51
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

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0013D430 File Offset: 0x0013B630
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x00007C5B File Offset: 0x00005E5B
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

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x0013D448 File Offset: 0x0013B648
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00007C65 File Offset: 0x00005E65
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

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x0013D460 File Offset: 0x0013B660
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x00007C6F File Offset: 0x00005E6F
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

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0013D478 File Offset: 0x0013B678
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x00007C79 File Offset: 0x00005E79
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

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0013D490 File Offset: 0x0013B690
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x00007C83 File Offset: 0x00005E83
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

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0013D4A8 File Offset: 0x0013B6A8
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x00007C8D File Offset: 0x00005E8D
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

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x0013D4C0 File Offset: 0x0013B6C0
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x0013D4D8 File Offset: 0x0013B6D8
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

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0013D538 File Offset: 0x0013B738
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0013D550 File Offset: 0x0013B750
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

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0013D5D8 File Offset: 0x0013B7D8
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x00007C97 File Offset: 0x00005E97
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0013D5F0 File Offset: 0x0013B7F0
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0013D608 File Offset: 0x0013B808
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

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0013D690 File Offset: 0x0013B890
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x00007CA1 File Offset: 0x00005EA1
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

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0013D6A8 File Offset: 0x0013B8A8
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0013D6C0 File Offset: 0x0013B8C0
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0013D720 File Offset: 0x0013B920
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0013D738 File Offset: 0x0013B938
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

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0013D798 File Offset: 0x0013B998
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0013D7B0 File Offset: 0x0013B9B0
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

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0013D810 File Offset: 0x0013BA10
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x00007CAB File Offset: 0x00005EAB
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

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0013D828 File Offset: 0x0013BA28
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0013D840 File Offset: 0x0013BA40
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

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0013D8A0 File Offset: 0x0013BAA0
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0013D8B8 File Offset: 0x0013BAB8
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

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0013D918 File Offset: 0x0013BB18
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0013D930 File Offset: 0x0013BB30
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

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0013D990 File Offset: 0x0013BB90
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0013D9A8 File Offset: 0x0013BBA8
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

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0013DA08 File Offset: 0x0013BC08
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x00007CB5 File Offset: 0x00005EB5
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Timer1 = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0013DA20 File Offset: 0x0013BC20
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x00007CBF File Offset: 0x00005EBF
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

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0013DA38 File Offset: 0x0013BC38
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

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0013DADC File Offset: 0x0013BCDC
		private void Clean_Status()
		{
			this.LabelCommand2.Text = string.Empty;
			this.LabelCommand1.Text = string.Empty;
			this.LabelCommand3.Text = string.Empty;
			this.LabelCommand4.Text = string.Empty;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0013DB30 File Offset: 0x0013BD30
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
			else
			{
				this.GridEX1.Refetch();
				this.GridEX1.Focus();
				this.GridEX1.Col = 1;
				this.GridEX1.EditMode = EditMode.EditOn;
				this.txt_num.Focus();
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00007CC9 File Offset: 0x00005EC9
		private void Frm_Frush_Sardkhane_Deactivate(object sender, EventArgs e)
		{
			this.GridEX1.Col = 1;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0013DBAC File Offset: 0x0013BDAC
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

		// Token: 0x06001BAA RID: 7082 RVA: 0x0013DC40 File Offset: 0x0013BE40
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

		// Token: 0x06001BAB RID: 7083 RVA: 0x0013DEBC File Offset: 0x0013C0BC
		private bool CanClose()
		{
			bool result = false;
			bool flag = this.Isnew && this.txt_kharid.Value == null && Operators.CompareString(this.txt_sh_mashin.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_sh_barname.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_baskul_mabda.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_baskul.Text, string.Empty, false) == 0 && Operators.CompareString(this.txt_tedad.Text, string.Empty, false) == 0 && this.Grid_RizBar.RowCount == 0 && this.GridEX1.RowCount == 1;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0013DF94 File Offset: 0x0013C194
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

		// Token: 0x06001BAD RID: 7085 RVA: 0x0013E038 File Offset: 0x0013C238
		private void frm_Frush_hag_Load(object sender, EventArgs e)
		{
			this.txt_kharid.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Code", "کد", 15));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.frm.items = itemCollection;
			this.txt_kharid.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_kharid.Edit_Frm = MyProject.Forms.Frm_Moshtari;
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
						this.txt_kharid.Enabled = false;
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

		// Token: 0x06001BAE RID: 7086 RVA: 0x0011FD30 File Offset: 0x0011DF30
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

		// Token: 0x06001BAF RID: 7087 RVA: 0x0013E298 File Offset: 0x0013C498
		private void Moshtari_Select()
		{
			bool flag = this.txt_kharid.Value == null;
			checked
			{
				if (flag)
				{
					this.txt_kharid.ShowTip("لطفا ابتدا صاحب بار را مشخص فرمائید ");
				}
				else
				{
					this.frm.CanEdit = true;
					this.frm.CanDelete = false;
					this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
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

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0013E4A4 File Offset: 0x0013C6A4
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
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from moshtari_kala where moshtari_id=", this.txt_kharid.Value), " and kala_id="), this.frm.GridEX1.CurrentRow.Cells["ID"].Value)
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

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0013E5A8 File Offset: 0x0013C7A8
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

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0013E82C File Offset: 0x0013CA2C
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

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0013E954 File Offset: 0x0013CB54
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

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0013EA30 File Offset: 0x0013CC30
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

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0013EAE4 File Offset: 0x0013CCE4
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

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0013EBAC File Offset: 0x0013CDAC
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

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0013EFDC File Offset: 0x0013D1DC
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

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0013F3D8 File Offset: 0x0013D5D8
		private void Kala_select()
		{
			bool flag = this.txt_kharid.Value == null;
			checked
			{
				if (flag)
				{
					Public_Function.ShowMessage("لطفا شماره خرید را انتخاب فرمائید", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					this.txt_kharid.Focus();
				}
				else
				{
					this.frm.CanEdit = false;
					this.frm.CanDelete = true;
					string text = Conversions.ToString(Operators.ConcatenateObject("SELECT     Kharid_Sardkhane_Detail.Kala_ID AS ID, min(Kala.Name) AS Name  FROM         Kharid_Sardkhane_Detail INNER JOIN   Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID   where kharid_sardkhane_id =  ", this.txt_kharid.Value));
					text += "  group by Kharid_Sardkhane_Detail.Kala_ID";
					flag = (this.GridEX1.CurrentRow.Cells["prekala_id"].Value != DBNull.Value);
					int? num;
					if (flag)
					{
						object expr_C6 = this.GridEX1.CurrentRow.Cells["prekala_id"].Value;
						int? num2;
						num = ((expr_C6 != null) ? ((int?)expr_C6) : num2);
					}
					this.frm.ExtraData = Conversions.ToLong(this.txt_kharid.Value);
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
														DataRow[] arg_552_0 = array2;
														int num4 = 0;
														DataRow arg_58C_0 = arg_552_0[num4];
														string columnName = "tedad";
														arg_58C_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
													}
												}
												flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
												if (flag3)
												{
													flag2 = (array[0]["vazn"] != DBNull.Value);
													if (flag2)
													{
														DataRow[] array2 = array;
														DataRow[] arg_5EC_0 = array2;
														int num4 = 0;
														DataRow arg_626_0 = arg_5EC_0[num4];
														string columnName = "vazn";
														arg_626_0[columnName] = Operators.SubtractObject(array2[num4][columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
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
														DataRow arg_A09_0 = dataRow4;
														string columnName = "tedad";
														arg_A09_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow dataRow4 = this.dt_rizbar.Rows[num6];
														DataRow arg_A8B_0 = dataRow4;
														string columnName = "vazn";
														arg_A8B_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													DataRow[] array3 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
													flag3 = (array3.Length > 0);
													if (flag3)
													{
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag2)
														{
															DataRow[] array2 = array3;
															DataRow[] arg_B0B_0 = array2;
															int num4 = 0;
															DataRow arg_B45_0 = arg_B0B_0[num4];
															string columnName = "tedad";
															arg_B45_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag3)
														{
															DataRow[] array2 = array3;
															DataRow[] arg_B86_0 = array2;
															int num4 = 0;
															DataRow arg_BC0_0 = arg_B86_0[num4];
															string columnName = "vazn";
															arg_BC0_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
												DataRow arg_CA7_0 = dataRow4;
												string columnName = "tedad";
												arg_CA7_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["tedad"].Value);
											}
											flag3 = (this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[num5];
												DataRow arg_D29_0 = dataRow4;
												string columnName = "vazn";
												arg_D29_0[columnName] = Operators.SubtractObject(dataRow4[columnName], this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].Value);
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
														DataRow arg_DE1_0 = dataRow4;
														string columnName = "tedad";
														arg_DE1_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
													}
													flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
													if (flag3)
													{
														DataRow dataRow4 = this.dt_rizbar.Rows[num7];
														DataRow arg_E63_0 = dataRow4;
														string columnName = "vazn";
														arg_E63_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
													}
													DataRow[] array4 = this.dt_rizbar.Select("kala_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
													flag3 = (array4.Length > 0);
													if (flag3)
													{
														flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
														if (flag2)
														{
															DataRow[] array2 = array4;
															DataRow[] arg_EE3_0 = array2;
															int num4 = 0;
															DataRow arg_F1D_0 = arg_EE3_0[num4];
															string columnName = "tedad";
															arg_F1D_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
														}
														flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
														if (flag3)
														{
															DataRow[] array2 = array4;
															DataRow[] arg_F5E_0 = array2;
															int num4 = 0;
															DataRow arg_F98_0 = arg_F5E_0[num4];
															string columnName = "vazn";
															arg_F98_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
												DataRow arg_1087_0 = dataRow4;
												string columnName = "tedad";
												arg_1087_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
											flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
											if (flag3)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[num8];
												DataRow arg_1109_0 = dataRow4;
												string columnName = "vazn";
												arg_1109_0[columnName] = Operators.SubtractObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
											}
											DataRow[] array5 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.frm.SelectedRow["ID"])));
											flag3 = (array5.Length > 0);
											if (flag3)
											{
												flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"] != DBNull.Value);
												if (flag2)
												{
													DataRow[] array2 = array5;
													DataRow[] arg_118B_0 = array2;
													int num4 = 0;
													DataRow arg_11C5_0 = arg_118B_0[num4];
													string columnName = "tedad";
													arg_11C5_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow[] array2 = array5;
													DataRow[] arg_1206_0 = array2;
													int num4 = 0;
													DataRow arg_1240_0 = arg_1206_0[num4];
													string columnName = "vazn";
													arg_1240_0[columnName] = Operators.AddObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
												DataRow arg_1385_0 = dataRow4;
												string columnName = "tedad";
												arg_1385_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
											}
										}
										flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
										if (flag3)
										{
											flag2 = Operators.ConditionalCompareObjectNotEqual(this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])]["vazn"], 0, false);
											if (flag2)
											{
												DataRow dataRow4 = this.dt_rizbar.Rows[Conversions.ToInteger(((DataRowView)this.GridEX1.CurrentRow.DataRow)["row_index"])];
												DataRow arg_147D_0 = dataRow4;
												string columnName = "vazn";
												arg_147D_0[columnName] = Operators.AddObject(dataRow4[columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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
													DataRow[] arg_150E_0 = array2;
													int num4 = 0;
													DataRow arg_1548_0 = arg_150E_0[num4];
													string columnName = "tedad";
													arg_1548_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_tedad"]);
												}
												flag3 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"] != DBNull.Value);
												if (flag3)
												{
													DataRow[] array2 = array6;
													DataRow[] arg_1589_0 = array2;
													int num4 = 0;
													DataRow arg_15C3_0 = arg_1589_0[num4];
													string columnName = "vazn";
													arg_15C3_0[columnName] = Operators.SubtractObject(array2[num4][columnName], ((DataRowView)this.GridEX1.CurrentRow.DataRow)["tafazol_vazn"]);
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

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00140A64 File Offset: 0x0013EC64
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

		// Token: 0x06001BBA RID: 7098 RVA: 0x00140C34 File Offset: 0x0013EE34
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

		// Token: 0x06001BBB RID: 7099 RVA: 0x00140D44 File Offset: 0x0013EF44
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

		// Token: 0x06001BBC RID: 7100 RVA: 0x0014110C File Offset: 0x0013F30C
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
					object expr_125 = this.GridEX1.GetRow().Cells["tedad"].Value;
					num = ((expr_125 != null) ? ((decimal?)expr_125) : num2);
				}
			}
			flag2 = (this.GridEX1.GetRow().Cells["fee"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["fee"].Value != null);
			decimal? num3;
			if (flag2)
			{
				object expr_1AB = this.GridEX1.GetRow().Cells["fee"].Value;
				num3 = ((expr_1AB != null) ? ((decimal?)expr_1AB) : num2);
			}
			flag2 = (this.GridEX1.GetRow().Cells["jam_Kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_Kol"].Value != null);
			decimal? num4;
			if (flag2)
			{
				object expr_230 = this.GridEX1.GetRow().Cells["jam_Kol"].Value;
				num4 = ((expr_230 != null) ? ((decimal?)expr_230) : num2);
			}
			if (calc_jam_kol)
			{
				flag = (num.HasValue && num3.HasValue);
				if (flag)
				{
					GridEXCell arg_2C1_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
					decimal? arg_2BC_0;
					if (!(num.HasValue & num3.HasValue))
					{
						arg_2BC_0 = null;
					}
					else
					{
						decimal? num5 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
						arg_2BC_0 = num5;
					}
					arg_2C1_0.Value = arg_2BC_0;
				}
			}
			if (calc_fee)
			{
				flag = (num.HasValue && num4.HasValue);
				if (flag)
				{
					decimal zero = decimal.Zero;
					bool? arg_32A_0;
					if (!num.HasValue)
					{
						arg_32A_0 = null;
					}
					else
					{
						bool? flag3 = new bool?(decimal.Compare(num.GetValueOrDefault(), zero) == 0);
						arg_32A_0 = flag3;
					}
					bool? flag4 = arg_32A_0;
					bool valueOrDefault = flag4.GetValueOrDefault();
					if (!valueOrDefault)
					{
						GridEXCell arg_395_0 = this.GridEX1.CurrentRow.Cells["fee"];
						decimal? arg_390_0;
						if (!(num4.HasValue & num.HasValue))
						{
							arg_390_0 = null;
						}
						else
						{
							decimal? num5 = new decimal?(decimal.Divide(num4.GetValueOrDefault(), num.GetValueOrDefault()));
							arg_390_0 = num5;
						}
						arg_395_0.Value = arg_390_0;
					}
				}
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x001414B8 File Offset: 0x0013F6B8
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

		// Token: 0x06001BBE RID: 7102 RVA: 0x001415BC File Offset: 0x0013F7BC
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

		// Token: 0x06001BBF RID: 7103 RVA: 0x00141B74 File Offset: 0x0013FD74
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

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0014207C File Offset: 0x0014027C
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

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00142128 File Offset: 0x00140328
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

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0014221C File Offset: 0x0014041C
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

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00142308 File Offset: 0x00140508
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

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00142380 File Offset: 0x00140580
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
								flag = (Operators.CompareString(this.txt_tarikhGrid.Text, this.txt_tarikh_vurud.Text, false) < 0);
								if (flag)
								{
									bool flag4 = Public_Function.ShowMessage("تاریخ فروش قبل از تاریخ ورود بار میباشد آیا مایل به اصلاح میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes;
									if (flag4)
									{
										this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
									}
									else
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
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

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00142A24 File Offset: 0x00140C24
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

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00142A60 File Offset: 0x00140C60
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

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00142B60 File Offset: 0x00140D60
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

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00142C40 File Offset: 0x00140E40
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
			this.Num = checked((int)this.Furush.GetNewID(Conversions.ToString(this.txt_kharid.Value)));
			this.txt_num.Value = Conversions.ToString(this.Num);
			this.txt_num.Focus();
			this.dt_Keraye = null;
			this.Grid_RizBar.DataSource = null;
			this.Grid_RizBar.Visible = false;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00142D54 File Offset: 0x00140F54
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
						if (!flag)
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

		// Token: 0x06001BCA RID: 7114 RVA: 0x00142DF0 File Offset: 0x00140FF0
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

		// Token: 0x06001BCB RID: 7115 RVA: 0x001432E0 File Offset: 0x001414E0
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

		// Token: 0x06001BCC RID: 7116 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x06001BCD RID: 7117 RVA: 0x00125430 File Offset: 0x00123630
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

		// Token: 0x06001BCE RID: 7118 RVA: 0x0014351C File Offset: 0x0014171C
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

		// Token: 0x06001BCF RID: 7119 RVA: 0x00143AF0 File Offset: 0x00141CF0
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

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00143CDC File Offset: 0x00141EDC
		private void addhandle()
		{
			this.GridEX1.EndCustomEdit += new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
			this.GridEX1.CellEdited += new ColumnActionEventHandler(this.GridEX1_CellEdited);
			this.GridEX1.SelectionChanged += new EventHandler(this.GridEX1_SelectionChanged);
			this.GridEX1.LoadingRow += new RowLoadEventHandler(this.GridEX1_LoadingRow);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00143D50 File Offset: 0x00141F50
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

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00143DB4 File Offset: 0x00141FB4
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
									this.ID = checked((int)this.Furush.Insert(this.txt_num.Value.ToString(), this.txt_kharid.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, nahve_furush, (DataTable)this.GridEX1.DataSource));
									this.RizBar.Update(this.ID, this.dt_rizbar);
									this.Furush_Keraye.Update(this.ID, this.dt_Keraye);
									this.kala_to_kala.Update((long)this.ID, this.dt_kala_to_kala);
									DataTable detailByID = this.Furush.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.Furush_Keraye.GetByID(this.ID);
									this.dt_kala_to_kala = this.kala_to_kala.GetByFurush_ID((long)this.ID);
									this.Prepare_furush_detail(detailByID);
									this.RemoveZero(detailByID);
									this.GridEX1.DataSource = detailByID;
									this.Isnew = false;
								}
								else
								{
									this.Furush_Keraye.Update(this.ID, this.dt_Keraye);
									this.Furush.Update(Conversions.ToString(this.ID), this.txt_num.Value.ToString(), this.txt_kharid.Value.ToString(), this.txt_sh_mashin.Text, this.txt_sh_barname.Text, this.txt_tarikh_vurud.Text, this.txt_desc.Text, this.txt_baskul.Text, this.txt_baskul_mabda.Text, this.txt_tedad.Text, nahve_furush, (DataTable)this.GridEX1.DataSource);
									this.RizBar.Update(this.ID, this.dt_rizbar);
									this.kala_to_kala.Update((long)this.ID, this.dt_kala_to_kala);
									DataTable detailByID2 = this.Furush.GetDetailByID((long)this.ID);
									this.dt_Keraye = this.Furush_Keraye.GetByID(this.ID);
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
											break;
										}
										case DialogResult.Yes:
											this.ButtonItem5_Click(null, null);
											break;
										case DialogResult.No:
											this.MeNew();
											break;
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

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00144710 File Offset: 0x00142910
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

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00144758 File Offset: 0x00142958
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
								flag2 = (gridEXRow.Cells["Vazn_Ba_Zarf"].Value != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(gridEXRow.Cells["Vazn_Ba_Zarf"].Value, 0, false));
								if (flag2)
								{
									flag = !this.ContainsVazn(list2, Conversions.ToLong(gridEXRow.Cells["kala_id"].Value), Conversions.ToDecimal(gridEXRow.Cells["Vazn_Ba_Zarf"].Value));
									if (flag)
									{
										list2.Add(new tedads
										{
											kala_id = Conversions.ToLong(gridEXRow.Cells["kala_id"].Value),
											Tedad = Conversions.ToDecimal(gridEXRow.Cells["Vazn_Ba_Zarf"].Value)
										});
									}
								}
								else
								{
									flag2 = (gridEXRow.Cells["Vazn_Kol"].Value != DBNull.Value);
									if (flag2)
									{
										flag = !this.ContainsVazn(list2, Conversions.ToLong(gridEXRow.Cells["kala_id"].Value), Conversions.ToDecimal(gridEXRow.Cells["Vazn_Kol"].Value));
										if (flag)
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
								flag4 = (currentRow.Cells["Vazn_Ba_Zarf"].Value != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(currentRow.Cells["Vazn_Ba_Zarf"].Value, 0, false));
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
								else
								{
									flag4 = (currentRow.Cells["Vazn_Kol"].Value != DBNull.Value);
									if (flag4)
									{
										flag3 = !this.ContainsVazn(list2, Conversions.ToLong(currentRow.Cells["kala_id"].Value), Conversions.ToDecimal(currentRow.Cells["Vazn_Kol"].Value));
										if (flag3)
										{
											list2.Add(new tedads
											{
												kala_id = Conversions.ToLong(currentRow.Cells["kala_id"].Value),
												Tedad = Conversions.ToDecimal(currentRow.Cells["Vazn_Kol"].Value)
											});
										}
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
												DataRow arg_68E_0 = dataRow2;
												string columnName = "tedad";
												arg_68E_0[columnName] = Operators.SubtractObject(dataRow2[columnName], current.Tedad);
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
													DataRow arg_755_0 = dataRow2;
													string columnName = "vazn";
													arg_755_0[columnName] = Operators.SubtractObject(dataRow2[columnName], current2.Tedad);
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

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00144F80 File Offset: 0x00143180
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

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00145088 File Offset: 0x00143288
		private void DeleteEzafiRizbar(DataTable dt)
		{
			string text = string.Empty;
			checked
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("kala_id=", dataRow["Kala_ID"]), " AND ID<>"), dataRow["ID"])));
						bool flag = array.Length > 0;
						if (flag)
						{
							DataRow[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								DataRow dataRow2 = array2[i];
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from Furush_Sardkhane_RizBar where id=", dataRow2["ID"]), ";")));
							}
							flag = (text.Length > 0);
							if (flag)
							{
								Public_Function.ExecuteNonQuery(text);
								this.dt_rizbar = this.RizBar.GetByID(this.ID);
								break;
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

		// Token: 0x06001BD7 RID: 7127 RVA: 0x001451CC File Offset: 0x001433CC
		private void LoadHeader(DataRow dr)
		{
			this.txt_num.Value = Conversions.ToString(dr["Num"]);
			this.ID = Conversions.ToInteger(dr["ID"]);
			this.txt_kharid.SetValue(Conversions.ToString(dr["Kharid_Num"]), RuntimeHelpers.GetObjectValue(dr["Kharid_Sardkhane_ID"]));
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
			this.dt_rizbar = this.RizBar.GetByID(this.ID);
			this.DeleteEzafiRizbar(this.dt_rizbar);
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

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00126F38 File Offset: 0x00125138
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

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00145428 File Offset: 0x00143628
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
			this.ButtonItem4.Enabled = en;
			this.ButtonItem6.Enabled = en;
			this.ButtonItem10.Enabled = en;
			this.ButtonItem12.Enabled = en;
			this.txt_makharej.Enabled = en;
			this.txt_kharid.Enabled = en;
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

		// Token: 0x06001BDA RID: 7130 RVA: 0x00145598 File Offset: 0x00143798
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

		// Token: 0x06001BDB RID: 7131 RVA: 0x001456A0 File Offset: 0x001438A0
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

		// Token: 0x06001BDC RID: 7132 RVA: 0x001457C4 File Offset: 0x001439C4
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

		// Token: 0x06001BDD RID: 7133 RVA: 0x001458D0 File Offset: 0x00143AD0
		private void LoadData()
		{
			DataRow byID = this.Furush.GetByID((long)this.Num);
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
					int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from furush_Sardkhane_Safi where furush_Sardkhane_id=" + Conversions.ToString(this.ID)));
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

		// Token: 0x06001BDE RID: 7134 RVA: 0x00007CDA File Offset: 0x00005EDA
		private void uncheckmenu()
		{
			this.ButtonItem16.Checked = false;
			this.ButtonItem17.Checked = false;
			this.ButtonItem18.Checked = false;
			this.ButtonItem19.Checked = false;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00145ECC File Offset: 0x001440CC
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

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00145F8C File Offset: 0x0014418C
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

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0014604C File Offset: 0x0014424C
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

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0014610C File Offset: 0x0014430C
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

		// Token: 0x06001BE3 RID: 7139 RVA: 0x001461CC File Offset: 0x001443CC
		private void txt_num_First_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Sardkhane.NavTo.first, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00146228 File Offset: 0x00144428
		private void txt_num_Last_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Sardkhane.NavTo.last, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00146284 File Offset: 0x00144484
		private void txt_num_Next_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Sardkhane.NavTo.forward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001BE6 RID: 7142 RVA: 0x001462E0 File Offset: 0x001444E0
		private void txt_num_Previous_Click()
		{
			long navigateID = this.Furush.GetNavigateID(Furush_Sardkhane.NavTo.backward, Conversions.ToLong(this.txt_num.Value));
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

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0014633C File Offset: 0x0014453C
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

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00007D12 File Offset: 0x00005F12
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			this.txt_num_NumberBox_Keydown(null, new KeyEventArgs(Keys.Return));
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x001463BC File Offset: 0x001445BC
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_kharid.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_kharid.ShowTip("شماره خرید را انتخاب فرمائید");
			}
			else
			{
				Frm_Rizbar_Sardkhane frm_Rizbar_Sardkhane = new Frm_Rizbar_Sardkhane
				{
					Tedad_Kol = this.txt_tedad.Text,
					Kharid_ID = Conversions.ToLong(this.txt_kharid.Value),
					FurushTable = (DataTable)this.GridEX1.DataSource
				};
				frm_Rizbar_Sardkhane.dt_kala_to_kala = this.dt_kala_to_kala;
				frm_Rizbar_Sardkhane.dt_rizbar = this.dt_rizbar;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Rizbar_Sardkhane);
				this.dt_rizbar = frm_Rizbar_Sardkhane.dt_rizbar;
				this.dt_rizbar.AcceptChanges();
				flag = (decimal.Compare(frm_Rizbar_Sardkhane.sum, decimal.Zero) != 0);
				if (flag)
				{
					this.txt_tedad.Text = Conversions.ToString(Public_Function.GetDecimalValue(frm_Rizbar_Sardkhane.sum));
				}
				flag = (decimal.Compare(frm_Rizbar_Sardkhane.Sum_Vazn, decimal.Zero) != 0);
				if (flag)
				{
					this.txt_baskul.Text = Conversions.ToString(Public_Function.GetDecimalValue(frm_Rizbar_Sardkhane.Sum_Vazn));
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

		// Token: 0x06001BEA RID: 7146 RVA: 0x00146540 File Offset: 0x00144740
		public void Check_Enable()
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from furush_Sardkhane_Safi where furush_Sardkhane_id=" + Conversions.ToString(this.ID)));
			bool flag = num == 1;
			if (flag)
			{
				this.setEnable(false);
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00146580 File Offset: 0x00144780
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = !this.ValidateRizBar();
			if (!flag)
			{
				Frm_Safi_Sardkhane frm_Safi_Sardkhane = new Frm_Safi_Sardkhane
				{
					Furush_ID = (long)this.ID
				};
				frm_Safi_Sardkhane.txt_num.TabStop = false;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Safi_Sardkhane);
				flag = frm_Safi_Sardkhane.save;
				if (flag)
				{
					this.MeNew();
				}
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x001465EC File Offset: 0x001447EC
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

		// Token: 0x06001BED RID: 7149 RVA: 0x0014672C File Offset: 0x0014492C
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

		// Token: 0x06001BEE RID: 7150 RVA: 0x00146D10 File Offset: 0x00144F10
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			this.DelKala();
			this.SyncTedad();
			this.GridEX1.Focus();
			this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00146D78 File Offset: 0x00144F78
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

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00146E44 File Offset: 0x00145044
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.Isnew;
			if (flag)
			{
				bool flag2 = Public_Function.ConfirmDelete() == DialogResult.Yes;
				if (flag2)
				{
					string empty = string.Empty;
					this.Furush.Delete(Conversions.ToString(this.ID));
					this.MeNew();
				}
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00146E94 File Offset: 0x00145094
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
					text = text + "select @sanad_id=sanad_id , @karmozd_sanad_id=karmozd_sanad_id from furush_Sardkhane_Safi where furush_Sardkhane_id=" + Conversions.ToString(this.ID) + ";";
					text = text + "update Furush_Sardkhane_Safi set sanad_id=null,karmozd_sanad_id=null where furush_Sardkhane_id=" + Conversions.ToString(this.ID) + ";";
					text += "delete from sanad where id=@sanad_id;";
					text += "delete from sanad where id=@karmozd_sanad_id;";
					text = text + "delete from Furush_Sardkhane_Safi where furush_Sardkhane_id=" + Conversions.ToString(this.ID) + ";";
					Public_Function.ExecuteNonQuery(text);
					this.setEnable(true);
					Public_Function.InvokeMethod("LoadSafiData");
				}
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00146F70 File Offset: 0x00145170
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

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00147090 File Offset: 0x00145290
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x001470BC File Offset: 0x001452BC
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

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00147120 File Offset: 0x00145320
		private void ButtonItem10_Click(object sender, EventArgs e)
		{
			Frm_Furush_Sardkhane_Keraye frm_Furush_Sardkhane_Keraye = new Frm_Furush_Sardkhane_Keraye
			{
				dt_keraye = this.dt_Keraye,
				Moshtari_ID = Conversions.ToLong(this.txt_kharid.Value)
			};
			bool flag = this.Isnew;
			if (flag)
			{
				frm_Furush_Sardkhane_Keraye.Furush_ID = -1L;
			}
			else
			{
				frm_Furush_Sardkhane_Keraye.Furush_ID = (long)this.ID;
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Furush_Sardkhane_Keraye);
			this.dt_Keraye = frm_Furush_Sardkhane_Keraye.dt_keraye;
			this.dt_Keraye.AcceptChanges();
			this.txt_makharej.Text = Public_Function.GetSum(this.dt_Keraye, "keraye");
			long num = 0L;
			long? value = this.txt_makharej.Value;
			bool? arg_D3_0;
			if (!value.HasValue)
			{
				arg_D3_0 = null;
			}
			else
			{
				bool? flag2 = new bool?(value.GetValueOrDefault() == num);
				arg_D3_0 = flag2;
			}
			bool? flag3 = arg_D3_0;
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

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00007D25 File Offset: 0x00005F25
		private void txt_makharej_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem10_Click(null, null);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00147260 File Offset: 0x00145460
		private void txt_makharej_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem10_Click(null, null);
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00007D32 File Offset: 0x00005F32
		private void txt_rizbar_ButtonClick(object sender, EventArgs e)
		{
			this.ButtonItem4_Click(null, null);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00147288 File Offset: 0x00145488
		private void txt_rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ButtonItem4_Click(null, null);
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x001472B0 File Offset: 0x001454B0
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

		// Token: 0x06001BFB RID: 7163 RVA: 0x00007D3F File Offset: 0x00005F3F
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00007D4A File Offset: 0x00005F4A
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00007D55 File Offset: 0x00005F55
		private void ButtonItem13_Click(object sender, EventArgs e)
		{
			this.txt_kharid.Focus();
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06001BFF RID: 7167 RVA: 0x00147314 File Offset: 0x00145514
		public void ButtonItem14_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\furush.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			this.dt_rizbar.TableName = "rizbar";
			stiReport.RegData(dataTable);
			stiReport.RegData(this.dt_rizbar);
			Public_Function.SetReport_MarginTop(stiReport);
			this.SetHeader(stiReport);
			StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
			stiText.Text = this.txt_num.Value;
			stiText = (StiText)stiReport.GetComponentByName("Text4");
			stiText.Text = this.txt_kharid.Text;
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

		// Token: 0x06001C00 RID: 7168 RVA: 0x0014750C File Offset: 0x0014570C
		private void txt_sh_barname_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_rizbar.Focus();
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x001292DC File Offset: 0x001274DC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع مانده";
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0000205D File Offset: 0x0000025D
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000A8E RID: 2702
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000A90 RID: 2704
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000A91 RID: 2705
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000A92 RID: 2706
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000A93 RID: 2707
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000A94 RID: 2708
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000A95 RID: 2709
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000A96 RID: 2710
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000A97 RID: 2711
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000A98 RID: 2712
		[AccessedThroughProperty("txt_kharid")]
		private SelectItem _txt_kharid;

		// Token: 0x04000A99 RID: 2713
		[AccessedThroughProperty("txt_num")]
		private NavBox _txt_num;

		// Token: 0x04000A9A RID: 2714
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000A9B RID: 2715
		[AccessedThroughProperty("txt_sh_mashin")]
		private EditBox _txt_sh_mashin;

		// Token: 0x04000A9C RID: 2716
		[AccessedThroughProperty("txt_tedad")]
		private NumericBox _txt_tedad;

		// Token: 0x04000A9D RID: 2717
		[AccessedThroughProperty("txt_sh_barname")]
		private EditBox _txt_sh_barname;

		// Token: 0x04000A9E RID: 2718
		[AccessedThroughProperty("txt_tarikh_vurud")]
		private DateBox2 _txt_tarikh_vurud;

		// Token: 0x04000A9F RID: 2719
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000AA0 RID: 2720
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000AA1 RID: 2721
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000AA2 RID: 2722
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000AA3 RID: 2723
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000AA4 RID: 2724
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000AA5 RID: 2725
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000AA6 RID: 2726
		[AccessedThroughProperty("txt_baskul")]
		private NumericBox _txt_baskul;

		// Token: 0x04000AA7 RID: 2727
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000AA8 RID: 2728
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000AA9 RID: 2729
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000AAA RID: 2730
		[AccessedThroughProperty("txt_baskul_mabda")]
		private NumericBox _txt_baskul_mabda;

		// Token: 0x04000AAB RID: 2731
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000AAC RID: 2732
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000AAD RID: 2733
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000AAE RID: 2734
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000AAF RID: 2735
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000AB0 RID: 2736
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000AB1 RID: 2737
		[AccessedThroughProperty("LabelItem3")]
		private LabelItem _LabelItem3;

		// Token: 0x04000AB2 RID: 2738
		[AccessedThroughProperty("LabelItem4")]
		private LabelItem _LabelItem4;

		// Token: 0x04000AB3 RID: 2739
		[AccessedThroughProperty("LabelItem5")]
		private LabelItem _LabelItem5;

		// Token: 0x04000AB4 RID: 2740
		[AccessedThroughProperty("LabelItem6")]
		private LabelItem _LabelItem6;

		// Token: 0x04000AB5 RID: 2741
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04000AB6 RID: 2742
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x04000AB7 RID: 2743
		[AccessedThroughProperty("MicroChartItem1")]
		private MicroChartItem _MicroChartItem1;

		// Token: 0x04000AB8 RID: 2744
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x04000AB9 RID: 2745
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000ABA RID: 2746
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04000ABB RID: 2747
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000ABC RID: 2748
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000ABD RID: 2749
		[AccessedThroughProperty("ControlContainerItem2")]
		private ControlContainerItem _ControlContainerItem2;

		// Token: 0x04000ABE RID: 2750
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000ABF RID: 2751
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000AC0 RID: 2752
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04000AC1 RID: 2753
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000AC2 RID: 2754
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000AC3 RID: 2755
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000AC4 RID: 2756
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000AC5 RID: 2757
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000AC6 RID: 2758
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04000AC7 RID: 2759
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x04000AC8 RID: 2760
		[AccessedThroughProperty("txt_makharej")]
		private CurrencyBox _txt_makharej;

		// Token: 0x04000AC9 RID: 2761
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000ACA RID: 2762
		[AccessedThroughProperty("txt_rizbar")]
		private CurrencyBox _txt_rizbar;

		// Token: 0x04000ACB RID: 2763
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000ACC RID: 2764
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x04000ACD RID: 2765
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x04000ACE RID: 2766
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000ACF RID: 2767
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x04000AD0 RID: 2768
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x04000AD1 RID: 2769
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000AD2 RID: 2770
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000AD3 RID: 2771
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x04000AD4 RID: 2772
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000AD5 RID: 2773
		private Furush_Sardkhane Furush;

		// Token: 0x04000AD6 RID: 2774
		private Furush_Sardkhane_RizBar RizBar;

		// Token: 0x04000AD7 RID: 2775
		private Furush_Sardkhane_Keraye Furush_Keraye;

		// Token: 0x04000AD8 RID: 2776
		private Moshtari_Info Moshtari_Info;

		// Token: 0x04000AD9 RID: 2777
		private Kala_To_Kala_Furush_Sardkhane kala_to_kala;

		// Token: 0x04000ADA RID: 2778
		private DataTable dt_Keraye;

		// Token: 0x04000ADB RID: 2779
		private DataTable dt_kala_to_kala;

		// Token: 0x04000ADC RID: 2780
		private Frm_SelectItem frm;

		// Token: 0x04000ADD RID: 2781
		private Sanad sanad;

		// Token: 0x04000ADE RID: 2782
		private Sandugh Sandug;

		// Token: 0x04000ADF RID: 2783
		private Base_User_Control user;

		// Token: 0x04000AE0 RID: 2784
		private int ID;

		// Token: 0x04000AE1 RID: 2785
		public int Num;

		// Token: 0x04000AE2 RID: 2786
		public int GotoLineID;

		// Token: 0x04000AE3 RID: 2787
		private bool Isnew;

		// Token: 0x04000AE4 RID: 2788
		private DataTable dt_rizbar;

		// Token: 0x04000AE5 RID: 2789
		private bool prevent_close;

		// Token: 0x04000AE6 RID: 2790
		private bool prevent_right;

		// Token: 0x04000AE7 RID: 2791
		private bool prevent_left;

		// Token: 0x04000AE8 RID: 2792
		[CompilerGenerated]
		private bool _Show_Preview;
	}
}
