using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000C3 RID: 195
	[DesignerGenerated]
	public partial class Frm_Bank_Hesab : Form
	{
		// Token: 0x06000FAA RID: 4010 RVA: 0x000ADCB0 File Offset: 0x000ABEB0
		public Frm_Bank_Hesab()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Moshtari_KeyDown);
			base.Load += new EventHandler(this.Frm_Bank_Hesab_Load);
			Frm_Bank_Hesab.__ENCAddToList(this);
			this.CodeHesab = new Code_Hesab();
			this.isnew = true;
			this.Bank_Hesab = new Bank_Hesab();
			this.Sanad = new Sanad();
			this.InitializeComponent();
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000ADD24 File Offset: 0x000ABF24
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Bank_Hesab.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Bank_Hesab.__ENCList.Count == Frm_Bank_Hesab.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Bank_Hesab.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Bank_Hesab.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Bank_Hesab.__ENCList[num] = Frm_Bank_Hesab.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Bank_Hesab.__ENCList.RemoveRange(num, Frm_Bank_Hesab.__ENCList.Count - num);
						Frm_Bank_Hesab.__ENCList.Capacity = Frm_Bank_Hesab.__ENCList.Count;
					}
					Frm_Bank_Hesab.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x000B0810 File Offset: 0x000AEA10
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0000557E File Offset: 0x0000377E
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x000B0828 File Offset: 0x000AEA28
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00005588 File Offset: 0x00003788
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x000B0840 File Offset: 0x000AEA40
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00005592 File Offset: 0x00003792
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x000B0858 File Offset: 0x000AEA58
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0000559C File Offset: 0x0000379C
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000B0870 File Offset: 0x000AEA70
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000055A6 File Offset: 0x000037A6
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000B0888 File Offset: 0x000AEA88
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x000055B0 File Offset: 0x000037B0
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
				this._txt_tarikh = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x000B08A0 File Offset: 0x000AEAA0
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x000055BA File Offset: 0x000037BA
		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x000B08B8 File Offset: 0x000AEAB8
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x000055C4 File Offset: 0x000037C4
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000B08D0 File Offset: 0x000AEAD0
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x000055CE File Offset: 0x000037CE
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x000B08E8 File Offset: 0x000AEAE8
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x000055D8 File Offset: 0x000037D8
		internal virtual SelectItem txt_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bank = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000B0900 File Offset: 0x000AEB00
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x000055E2 File Offset: 0x000037E2
		internal virtual EditBox txt_shobe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shobe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shobe = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000B0918 File Offset: 0x000AEB18
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x000055EC File Offset: 0x000037EC
		internal virtual NumericBox txt_hesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hesab = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x000B0930 File Offset: 0x000AEB30
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x000055F6 File Offset: 0x000037F6
		internal virtual NumericBox txt_kart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kart = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000B0948 File Offset: 0x000AEB48
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00005600 File Offset: 0x00003800
		internal virtual EditBox txt_shaba
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shaba;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shaba = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000B0960 File Offset: 0x000AEB60
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0000560A File Offset: 0x0000380A
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000B0978 File Offset: 0x000AEB78
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00005614 File Offset: 0x00003814
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000B0990 File Offset: 0x000AEB90
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000561E File Offset: 0x0000381E
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000B09A8 File Offset: 0x000AEBA8
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00005628 File Offset: 0x00003828
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000B09C0 File Offset: 0x000AEBC0
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x000B09D8 File Offset: 0x000AEBD8
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000B0A38 File Offset: 0x000AEC38
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x000B0A50 File Offset: 0x000AEC50
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x000B0AB0 File Offset: 0x000AECB0
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x000B0AC8 File Offset: 0x000AECC8
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000B0B28 File Offset: 0x000AED28
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00005632 File Offset: 0x00003832
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000B0B40 File Offset: 0x000AED40
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0000563C File Offset: 0x0000383C
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x000B0B58 File Offset: 0x000AED58
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00005646 File Offset: 0x00003846
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

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000B0B70 File Offset: 0x000AED70
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00005650 File Offset: 0x00003850
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

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000B0B88 File Offset: 0x000AED88
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0000565A File Offset: 0x0000385A
		internal virtual EditBox txt_address
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_address;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_address = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000B0BA0 File Offset: 0x000AEDA0
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00005664 File Offset: 0x00003864
		internal virtual EditBox txt_sahebhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sahebhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sahebhesab = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x000B0BB8 File Offset: 0x000AEDB8
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000566E File Offset: 0x0000386E
		internal virtual EditBox txt_sadere
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sadere;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sadere = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000B0BD0 File Offset: 0x000AEDD0
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00005678 File Offset: 0x00003878
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000B0BE8 File Offset: 0x000AEDE8
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x00005682 File Offset: 0x00003882
		internal virtual EditBox txt_codemelli
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codemelli;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codemelli = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000B0C00 File Offset: 0x000AEE00
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0000568C File Offset: 0x0000388C
		internal virtual EditBox txt_shsh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shsh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shsh = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000B0C18 File Offset: 0x000AEE18
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00005696 File Offset: 0x00003896
		internal virtual EditBox txt_namepedar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_namepedar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_namepedar = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000B0C30 File Offset: 0x000AEE30
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000056A0 File Offset: 0x000038A0
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000B0C48 File Offset: 0x000AEE48
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000056AA File Offset: 0x000038AA
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000B0C60 File Offset: 0x000AEE60
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000056B4 File Offset: 0x000038B4
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x000B0C78 File Offset: 0x000AEE78
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x000056BE File Offset: 0x000038BE
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

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x000B0C90 File Offset: 0x000AEE90
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000056C8 File Offset: 0x000038C8
		internal virtual EditBox txt_tel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tel = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000B0CA8 File Offset: 0x000AEEA8
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000056D2 File Offset: 0x000038D2
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x000B0CC0 File Offset: 0x000AEEC0
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000056DC File Offset: 0x000038DC
		internal virtual EditBox txt_codeposti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codeposti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codeposti = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x000B0CD8 File Offset: 0x000AEED8
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x000056E6 File Offset: 0x000038E6
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x000B0CF0 File Offset: 0x000AEEF0
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x000B0D08 File Offset: 0x000AEF08
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x000B0D68 File Offset: 0x000AEF68
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x000B0D80 File Offset: 0x000AEF80
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
				EventHandler value2 = new EventHandler(this.UiButton1_Click_1);
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x000B0DE0 File Offset: 0x000AEFE0
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x000056F0 File Offset: 0x000038F0
		internal virtual OpenFileDialog OpenFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x000B0DF8 File Offset: 0x000AEFF8
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x000056FA File Offset: 0x000038FA
		internal virtual UICheckBox txt_enable
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_enable;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_enable = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x000B0E10 File Offset: 0x000AF010
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00005704 File Offset: 0x00003904
		public int? ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0000570E File Offset: 0x0000390E
		public void newfrm()
		{
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0000571B File Offset: 0x0000391B
		private void cmb_avaldore_SelectedValueChanged(object sender, EventArgs e)
		{
			this.txt_mablagh.Text = string.Empty;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000B0E28 File Offset: 0x000AF028
		private void Frm_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Insert;
			if (flag)
			{
				bool flag2 = this.ButtonItem1.Visible;
				if (flag2)
				{
					this.ButtonItem1_Click(null, null);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.F2;
				if (flag2)
				{
					flag = this.ButtonItem2.Visible;
					if (flag)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
				else
				{
					flag2 = (keyCode == Keys.F5);
					if (flag2)
					{
						flag = this.ButtonItem3.Visible;
						if (flag)
						{
						}
					}
					else
					{
						flag2 = (keyCode == Keys.Escape);
						if (flag2)
						{
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000B0EB8 File Offset: 0x000AF0B8
		private void UiButton5_Click(object sender, EventArgs e)
		{
			Public_Function.SetNew(this.UiGroupBox1);
			this.Sanad_ID = null;
			int? iD;
			this.ID = iD;
			this.isnew = true;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000B0EF0 File Offset: 0x000AF0F0
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			checked
			{
				if (!flag)
				{
					long num = 0L;
					string tozih = " موجودی اول دوره " + this.txt_bank.Text + "-" + this.txt_shobe.Text;
					flag = this.txt_mablagh.Value.HasValue;
					if (flag)
					{
						num = Conversions.ToLong(this.txt_mablagh.Value.ToString());
					}
					flag = (Operators.CompareString(this.txt_hesab.Text, string.Empty, false) == 0);
					if (flag)
					{
						this.txt_hesab.Text = " ";
					}
					flag = this.isnew;
					if (flag)
					{
						this.CodeHesabMojodi_ID = (int)this.CodeHesab.Insert(Code_Hesab.GrohHesab.حساب_بانکی, this.txt_bank.Text + "-" + this.txt_shobe.Text);
						this.CodeHesabVusul_ID = (int)this.CodeHesab.Insert(Code_Hesab.GrohHesab.در_جریان_وصول, this.txt_bank.Text + "-" + this.txt_shobe.Text);
						this.ID = (int)this.Bank_Hesab.Insert(Conversions.ToString(this.txt_bank.Value), this.txt_shobe.Text, this.txt_hesab.Text, this.txt_kart.Text, this.txt_shaba.Text, this.txt_mablagh.Value.ToString(), this.txt_tarikh.Text, Conversions.ToString(this.CodeHesabMojodi_ID), Conversions.ToString(this.CodeHesabVusul_ID), Conversions.ToString(this.UiCheckBox1.Checked), this.txt_sahebhesab.Text, this.txt_address.Text, this.txt_tel.Text, this.txt_namepedar.Text, this.txt_codemelli.Text, this.txt_shsh.Text, this.txt_sadere.Text, this.txt_codeposti.Text);
						flag = (num != 0L);
						if (flag)
						{
							this.Sanad_ID = (int)this.Sanad.Insert(Conversions.ToString(this.CodeHesabMojodi_ID), Conversions.ToString(num), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
							this.Bank_Hesab.Update_SanadID(Conversions.ToString((T)this.Sanad_ID), Conversions.ToString((T)this.ID));
						}
						flag = (this.PictureBox1.Image != null && Operators.CompareString(this.OpenFileDialog1.FileName, string.Empty, false) != 0);
						byte[] picdata;
						if (flag)
						{
							picdata = File.ReadAllBytes(this.OpenFileDialog1.FileName);
						}
						this.Bank_Hesab.UpdatePicData(picdata, Conversions.ToString((T)this.ID));
						Public_Function.ConfirmInsert();
						this.isnew = false;
						this.Close();
					}
					else
					{
						flag = (Public_Function.ConfirmUpdate() == DialogResult.Yes);
						if (flag)
						{
							string visible = string.Empty;
							flag = this.txt_enable.Checked;
							if (flag)
							{
								visible = "1";
							}
							else
							{
								visible = "null";
							}
							this.Bank_Hesab.Update(Conversions.ToString(this.txt_bank.Value), this.txt_shobe.Text, this.txt_hesab.Text, this.txt_kart.Text, this.txt_shaba.Text, Conversions.ToString(num), this.txt_tarikh.Text, Conversions.ToString(this.UiCheckBox1.Checked), Conversions.ToString((T)this.ID), this.txt_sahebhesab.Text, this.txt_address.Text, this.txt_tel.Text, this.txt_namepedar.Text, this.txt_codemelli.Text, this.txt_shsh.Text, this.txt_sadere.Text, this.txt_codeposti.Text, visible);
							this.CodeHesab.Update(this.txt_bank.Text + " " + this.txt_shobe.Text, Conversions.ToString(this.CodeHesabVusul_ID));
							this.CodeHesab.Update(this.txt_bank.Text + " " + this.txt_shobe.Text, Conversions.ToString(this.CodeHesabMojodi_ID));
							flag = (this.PictureBox1.Image != null);
							bool flag2;
							byte[] array;
							if (flag)
							{
								flag2 = (Operators.CompareString(this.OpenFileDialog1.FileName, string.Empty, false) != 0);
								if (flag2)
								{
									array = File.ReadAllBytes(this.OpenFileDialog1.FileName);
								}
							}
							flag2 = (array != null);
							if (flag2)
							{
								this.Bank_Hesab.UpdatePicData(array, Conversions.ToString((T)this.ID));
							}
							else
							{
								flag2 = (this.PictureBox1.Image == null);
								if (flag2)
								{
									this.Bank_Hesab.UpdatePicData(null, Conversions.ToString((T)this.ID));
								}
							}
							bool arg_59D_0;
							if (Operators.CompareString(this.txt_mablagh.Text, string.Empty, false) != 0)
							{
								long num2 = 0L;
								long? value = this.txt_mablagh.Value;
								bool? arg_58D_0;
								if (!value.HasValue)
								{
									arg_58D_0 = null;
								}
								else
								{
									bool? flag3 = new bool?(value.GetValueOrDefault() != num2);
									arg_58D_0 = flag3;
								}
								bool? flag4 = arg_58D_0;
								if (flag4.GetValueOrDefault())
								{
									arg_59D_0 = true;
									goto IL_59C;
								}
							}
							arg_59D_0 = false;
							IL_59C:
							flag2 = arg_59D_0;
							if (flag2)
							{
								flag = this.Sanad_ID.HasValue;
								if (flag)
								{
									this.Sanad.Update(Conversions.ToString(this.CodeHesabMojodi_ID), Conversions.ToString(num), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Conversions.ToString((T)this.Sanad_ID), Sanad.SanadType.@null);
								}
								else
								{
									this.Sanad_ID = (int)this.Sanad.Insert(Conversions.ToString(this.CodeHesabMojodi_ID), Conversions.ToString(num), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
									this.Bank_Hesab.Update_SanadID(Conversions.ToString((T)this.Sanad_ID), Conversions.ToString((T)this.ID));
								}
							}
							else
							{
								this.Bank_Hesab.Update_SanadID("", Conversions.ToString((T)this.ID));
								flag2 = this.Sanad_ID.HasValue;
								if (flag2)
								{
									this.Sanad.Delete(Conversions.ToString((T)this.Sanad_ID));
								}
							}
							Public_Function.ConfirmInsert();
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000B15C4 File Offset: 0x000AF7C4
		private void LoadPic(DataRow dr)
		{
			bool flag = dr == null;
			if (flag)
			{
				this.PictureBox1.Image = null;
			}
			else
			{
				flag = (dr["signpic"] != DBNull.Value);
				if (flag)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write((byte[])dr["signpic"], 0, ((byte[])dr["signpic"]).Length);
					this.PictureBox1.Image = Image.FromStream(memoryStream);
				}
				else
				{
					this.PictureBox1.Image = null;
				}
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000B1658 File Offset: 0x000AF858
		private void LoadDatarow(DataRow dr)
		{
			this.isnew = false;
			this.txt_bank.SetValue(Conversions.ToString(dr["Bank_Name"]), RuntimeHelpers.GetObjectValue(dr["Bank_ID"]));
			this.txt_shobe.Text = dr["Shobe"].ToString();
			this.txt_hesab.Text = dr["Sh_Hesab"].ToString();
			this.txt_kart.Text = dr["Sh_Card"].ToString();
			this.txt_shaba.Text = dr["Sh_Shaba"].ToString();
			this.txt_mablagh.Text = dr["AvalDore"].ToString();
			this.txt_address.Text = dr["address"].ToString();
			this.txt_sadere.Text = dr["tel"].ToString();
			this.txt_sahebhesab.Text = dr["sahebhesab"].ToString();
			this.txt_shsh.Text = dr["shsh"].ToString();
			this.txt_namepedar.Text = dr["namepedar"].ToString();
			this.txt_codemelli.Text = dr["codemelli"].ToString();
			this.txt_sadere.Text = dr["sadere"].ToString();
			this.txt_codeposti.Text = dr["codeposti"].ToString();
			this.CodeHesabMojodi_ID = Conversions.ToInteger(dr["CodeHesab_Mojodi"]);
			this.CodeHesabVusul_ID = Conversions.ToInteger(dr["CodeHesab_Vusul"]);
			this.LoadPic(dr);
			bool flag = dr["kartkhan"] != DBNull.Value;
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectEqual(dr["kartkhan"], true, false);
				if (flag2)
				{
					this.UiCheckBox1.Checked = true;
				}
				else
				{
					this.UiCheckBox1.Checked = false;
				}
			}
			else
			{
				this.UiCheckBox1.Checked = false;
			}
			flag2 = (dr["visible"] != DBNull.Value);
			if (flag2)
			{
				flag = Operators.ConditionalCompareObjectEqual(dr["visible"], true, false);
				if (flag)
				{
					this.txt_enable.Checked = true;
				}
				else
				{
					this.txt_enable.Checked = false;
				}
			}
			else
			{
				this.txt_enable.Checked = false;
			}
			flag2 = (dr["AvalDore"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dr["AvalDore"], "0", false));
			if (flag2)
			{
				this.txt_tarikh.Text = dr["AvalDore_Tarikh"].ToString();
			}
			else
			{
				this.txt_tarikh.SetNew();
			}
			flag2 = (dr["Sanad_ID"] != DBNull.Value);
			if (flag2)
			{
				object expr_31E = dr["Sanad_ID"];
				int? num;
				this.Sanad_ID = ((expr_31E != null) ? ((int?)expr_31E) : num);
			}
			else
			{
				this.Sanad_ID = null;
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000B19AC File Offset: 0x000AFBAC
		private void Frm_Bank_Hesab_Load(object sender, EventArgs e)
		{
			bool flag = this.ID.HasValue;
			if (flag)
			{
				this.txt_enable.Visible = true;
				DataRow byID = this.Bank_Hesab.GetByID(Conversions.ToString((T)this.ID));
				flag = (byID != null);
				if (flag)
				{
					this.LoadDatarow(byID);
				}
				else
				{
					this.UiButton5_Click(null, null);
				}
			}
			else
			{
				this.isnew = true;
				this.txt_enable.Visible = false;
				this.UiButton5_Click(null, null);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00005730 File Offset: 0x00003930
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.UiButton5_Click(null, null);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0000573D File Offset: 0x0000393D
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.UiButton1_Click(null, null);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000B1A38 File Offset: 0x000AFC38
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool hasValue = this.ID.HasValue;
			if (hasValue)
			{
				bool flag = Public_Function.ShowMessage("آیا مایل به حذف حساب میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
				if (flag)
				{
					string str = string.Empty;
					string arg_5E_0 = "select codehesab_mojodi from bank_hesab where id=";
					int? iD = this.ID;
					long value = Conversions.ToLong(Public_Function.ExecuteScalar(arg_5E_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null)));
					flag = this.Sanad_ID.HasValue;
					if (flag)
					{
						str = " and id not in(" + (this.Sanad_ID.HasValue ? Conversions.ToString(this.Sanad_ID.GetValueOrDefault()) : null) + ")";
					}
					long num = Conversions.ToLong(Public_Function.ExecuteScalar("select count(id) from sanad where codehesab_id=" + Conversions.ToString(value) + str));
					flag = (num > 0L);
					if (flag)
					{
						Public_Function.ShowMessage("حساب مورد نظر دارای گردش میباشد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					}
					else
					{
						string arg_117_0 = "select codehesab_vusul from bank_hesab where id=";
						iD = this.ID;
						value = Conversions.ToLong(Public_Function.ExecuteScalar(arg_117_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null)));
						long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select count(id) from sanad where codehesab_id=" + Conversions.ToString(value) + str));
						flag = (num2 > 0L);
						if (flag)
						{
							Public_Function.ShowMessage("حساب مورد نظر دارای گردش میباشد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
						}
						else
						{
							string text = string.Empty;
							flag = this.Sanad_ID.HasValue;
							if (flag)
							{
								string arg_1A6_0 = "update bank_hesab set sanad_id=null where id=";
								iD = this.ID;
								text = arg_1A6_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null) + ";";
								text = text + "delete from sanad where id=" + (this.Sanad_ID.HasValue ? Conversions.ToString(this.Sanad_ID.GetValueOrDefault()) : null) + ";";
							}
							string arg_208_0 = text;
							string arg_208_1 = "delete from bank_hesab where id=";
							iD = this.ID;
							text = arg_208_0 + arg_208_1 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null);
							Public_Function.ExecuteNonQuery(text);
							Public_Function.ShowMessage("حساب مورد نظر با موفقیت حذف گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
							this.ButtonItem1_Click(null, null);
						}
					}
				}
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000B1C78 File Offset: 0x000AFE78
		private void UiButton1_Click_1(object sender, EventArgs e)
		{
			bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				byte[] array = File.ReadAllBytes(this.OpenFileDialog1.FileName);
				this.PictureBox1.Image = Image.FromFile(this.OpenFileDialog1.FileName);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0000574A File Offset: 0x0000394A
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = null;
		}

		// Token: 0x040005E4 RID: 1508
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005E6 RID: 1510
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040005E7 RID: 1511
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040005E8 RID: 1512
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040005E9 RID: 1513
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040005EA RID: 1514
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040005EB RID: 1515
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x040005EC RID: 1516
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040005ED RID: 1517
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040005EE RID: 1518
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x040005EF RID: 1519
		[AccessedThroughProperty("txt_bank")]
		private SelectItem _txt_bank;

		// Token: 0x040005F0 RID: 1520
		[AccessedThroughProperty("txt_shobe")]
		private EditBox _txt_shobe;

		// Token: 0x040005F1 RID: 1521
		[AccessedThroughProperty("txt_hesab")]
		private NumericBox _txt_hesab;

		// Token: 0x040005F2 RID: 1522
		[AccessedThroughProperty("txt_kart")]
		private NumericBox _txt_kart;

		// Token: 0x040005F3 RID: 1523
		[AccessedThroughProperty("txt_shaba")]
		private EditBox _txt_shaba;

		// Token: 0x040005F4 RID: 1524
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x040005F5 RID: 1525
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040005F6 RID: 1526
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040005F7 RID: 1527
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040005F8 RID: 1528
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040005F9 RID: 1529
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040005FA RID: 1530
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040005FB RID: 1531
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x040005FC RID: 1532
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040005FD RID: 1533
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040005FE RID: 1534
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040005FF RID: 1535
		[AccessedThroughProperty("txt_address")]
		private EditBox _txt_address;

		// Token: 0x04000600 RID: 1536
		[AccessedThroughProperty("txt_sahebhesab")]
		private EditBox _txt_sahebhesab;

		// Token: 0x04000601 RID: 1537
		[AccessedThroughProperty("txt_sadere")]
		private EditBox _txt_sadere;

		// Token: 0x04000602 RID: 1538
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000603 RID: 1539
		[AccessedThroughProperty("txt_codemelli")]
		private EditBox _txt_codemelli;

		// Token: 0x04000604 RID: 1540
		[AccessedThroughProperty("txt_shsh")]
		private EditBox _txt_shsh;

		// Token: 0x04000605 RID: 1541
		[AccessedThroughProperty("txt_namepedar")]
		private EditBox _txt_namepedar;

		// Token: 0x04000606 RID: 1542
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000607 RID: 1543
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000608 RID: 1544
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000609 RID: 1545
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x0400060A RID: 1546
		[AccessedThroughProperty("txt_tel")]
		private EditBox _txt_tel;

		// Token: 0x0400060B RID: 1547
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400060C RID: 1548
		[AccessedThroughProperty("txt_codeposti")]
		private EditBox _txt_codeposti;

		// Token: 0x0400060D RID: 1549
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400060E RID: 1550
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400060F RID: 1551
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000610 RID: 1552
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x04000611 RID: 1553
		[AccessedThroughProperty("txt_enable")]
		private UICheckBox _txt_enable;

		// Token: 0x04000612 RID: 1554
		private Code_Hesab CodeHesab;

		// Token: 0x04000613 RID: 1555
		private int CodeHesabMojodi_ID;

		// Token: 0x04000614 RID: 1556
		private int CodeHesabVusul_ID;

		// Token: 0x04000615 RID: 1557
		private bool isnew;

		// Token: 0x04000616 RID: 1558
		[CompilerGenerated]
		private int? _ID;

		// Token: 0x04000617 RID: 1559
		private int? Sanad_ID;

		// Token: 0x04000618 RID: 1560
		private Bank_Hesab Bank_Hesab;

		// Token: 0x04000619 RID: 1561
		private Sanad Sanad;
	}
}
