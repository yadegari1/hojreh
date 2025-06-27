using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006A RID: 106
	[DesignerGenerated]
	public partial class Frm_Extra_Setting : Form
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x0000343D File Offset: 0x0000163D
		[DebuggerNonUserCode]
		public Frm_Extra_Setting()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Amniat_Setting_KeyDown);
			base.Load += new EventHandler(this.Frm_Extra_Setting_Load);
			Frm_Extra_Setting.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00070DD0 File Offset: 0x0006EFD0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Extra_Setting.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Extra_Setting.__ENCList.Count == Frm_Extra_Setting.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Extra_Setting.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Extra_Setting.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Extra_Setting.__ENCList[num] = Frm_Extra_Setting.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Extra_Setting.__ENCList.RemoveRange(num, Frm_Extra_Setting.__ENCList.Count - num);
						Frm_Extra_Setting.__ENCList.Capacity = Frm_Extra_Setting.__ENCList.Count;
					}
					Frm_Extra_Setting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00073B8C File Offset: 0x00071D8C
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x0000347D File Offset: 0x0000167D
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00073BA4 File Offset: 0x00071DA4
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00003487 File Offset: 0x00001687
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00073BBC File Offset: 0x00071DBC
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00073BD4 File Offset: 0x00071DD4
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00073C34 File Offset: 0x00071E34
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00003491 File Offset: 0x00001691
		internal virtual BackgroundWorker BackgroundWorker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BackgroundWorker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BackgroundWorker1 = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00073C4C File Offset: 0x00071E4C
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x0000349B File Offset: 0x0000169B
		internal virtual UICheckBox UiCheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox2 = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00073C64 File Offset: 0x00071E64
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x000034A5 File Offset: 0x000016A5
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00073C7C File Offset: 0x00071E7C
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x000034AF File Offset: 0x000016AF
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00073C94 File Offset: 0x00071E94
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x000034B9 File Offset: 0x000016B9
		internal virtual UICheckBox txt_backupCategory
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_backupCategory;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_backupCategory = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00073CAC File Offset: 0x00071EAC
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x000034C3 File Offset: 0x000016C3
		internal virtual UICheckBox txt_oneBackup
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_oneBackup;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_oneBackup = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00073CC4 File Offset: 0x00071EC4
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x000034CD File Offset: 0x000016CD
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00073CDC File Offset: 0x00071EDC
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x000034D7 File Offset: 0x000016D7
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00073CF4 File Offset: 0x00071EF4
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x000034E1 File Offset: 0x000016E1
		internal virtual UICheckBox UiCheckBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox6 = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00073D0C File Offset: 0x00071F0C
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x000034EB File Offset: 0x000016EB
		internal virtual UICheckBox UiCheckBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox5 = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00073D24 File Offset: 0x00071F24
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x000034F5 File Offset: 0x000016F5
		internal virtual UICheckBox UiCheckBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox4 = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00073D3C File Offset: 0x00071F3C
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x000034FF File Offset: 0x000016FF
		internal virtual UICheckBox UiCheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox3 = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00073D54 File Offset: 0x00071F54
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00003509 File Offset: 0x00001709
		internal virtual UICheckBox txt_fullscreen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fullscreen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_fullscreen = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00073D6C File Offset: 0x00071F6C
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00003513 File Offset: 0x00001713
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00073D84 File Offset: 0x00071F84
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x0000351D File Offset: 0x0000171D
		internal virtual UIGroupBox UiGroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox5 = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00073D9C File Offset: 0x00071F9C
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00073DB4 File Offset: 0x00071FB4
		internal virtual EditBox txt_altbackupPath
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_altbackupPath;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_altbackupPath_ButtonClick);
				bool flag = this._txt_altbackupPath != null;
				if (flag)
				{
					this._txt_altbackupPath.ButtonClick -= value2;
				}
				this._txt_altbackupPath = value;
				flag = (this._txt_altbackupPath != null);
				if (flag)
				{
					this._txt_altbackupPath.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00073E14 File Offset: 0x00072014
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00003527 File Offset: 0x00001727
		internal virtual UICheckBox txt_altbackup
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_altbackup;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_altbackup = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00073E2C File Offset: 0x0007202C
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00003531 File Offset: 0x00001731
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00073E44 File Offset: 0x00072044
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x0000353B File Offset: 0x0000173B
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderBrowserDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00073E5C File Offset: 0x0007205C
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00003545 File Offset: 0x00001745
		internal virtual UICheckBox txt_elan_check
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_elan_check;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_elan_check = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00073E74 File Offset: 0x00072074
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0000354F File Offset: 0x0000174F
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00073E8C File Offset: 0x0007208C
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00003559 File Offset: 0x00001759
		internal virtual UICheckBox txt_desktop_note
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_desktop_note;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_desktop_note = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00073EA4 File Offset: 0x000720A4
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00003563 File Offset: 0x00001763
		internal virtual UICheckBox UiCheckBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox7 = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00073EBC File Offset: 0x000720BC
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000356D File Offset: 0x0000176D
		internal virtual UIGroupBox UiGroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox6 = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00073ED4 File Offset: 0x000720D4
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00003577 File Offset: 0x00001777
		internal virtual UICheckBox txt_sahebcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sahebcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sahebcheck = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00073EEC File Offset: 0x000720EC
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00003581 File Offset: 0x00001781
		internal virtual UICheckBox txt_shobe
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00073F04 File Offset: 0x00072104
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0000358B File Offset: 0x0000178B
		internal virtual UICheckBox txt_bank
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00073F1C File Offset: 0x0007211C
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00003595 File Offset: 0x00001795
		internal virtual UICheckBox txt_shomarehesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shomarehesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shomarehesab = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00073F34 File Offset: 0x00072134
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x0000359F File Offset: 0x0000179F
		internal virtual UICheckBox txt_kiosk_auto_kasr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kiosk_auto_kasr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kiosk_auto_kasr = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00073F4C File Offset: 0x0007214C
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x000035A9 File Offset: 0x000017A9
		internal virtual UICheckBox txt_newrow_kala
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_newrow_kala;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_newrow_kala = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00073F64 File Offset: 0x00072164
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x000035B3 File Offset: 0x000017B3
		internal virtual UICheckBox txt_Auto_Vusul
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_Auto_Vusul;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_Auto_Vusul = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00073F7C File Offset: 0x0007217C
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x000035BD File Offset: 0x000017BD
		internal virtual UICheckBox txt_auto_vusul_d
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_auto_vusul_d;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_auto_vusul_d = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00073F94 File Offset: 0x00072194
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x000035C7 File Offset: 0x000017C7
		internal virtual UIGroupBox UiGroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox7 = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00073FAC File Offset: 0x000721AC
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x000035D1 File Offset: 0x000017D1
		internal virtual UICheckBox txt_sardkhane_vaznkol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sardkhane_vaznkol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sardkhane_vaznkol = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00073FC4 File Offset: 0x000721C4
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000035DB File Offset: 0x000017DB
		internal virtual UICheckBox txt_sardkhane_keraye_tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sardkhane_keraye_tozih;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sardkhane_keraye_tozih = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00073FDC File Offset: 0x000721DC
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x000035E5 File Offset: 0x000017E5
		internal virtual UICheckBox txt_sardkhane_keraye_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sardkhane_keraye_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sardkhane_keraye_moshtari = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00073FF4 File Offset: 0x000721F4
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000035EF File Offset: 0x000017EF
		internal virtual UICheckBox txt_sh_factor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sh_factor;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sh_factor = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0007400C File Offset: 0x0007220C
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x000035F9 File Offset: 0x000017F9
		internal virtual UIComboBox txt_nahve_kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_nahve_kharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_nahve_kharid = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00074024 File Offset: 0x00072224
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00003603 File Offset: 0x00001803
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0007403C File Offset: 0x0007223C
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x0000360D File Offset: 0x0000180D
		internal virtual UIGroupBox UiGroupBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox8 = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00074054 File Offset: 0x00072254
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00003617 File Offset: 0x00001817
		internal virtual UICheckBox txt_moshtari_pic
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari_pic;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_moshtari_pic = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0007406C File Offset: 0x0007226C
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00003621 File Offset: 0x00001821
		internal virtual UICheckBox txt_moshtari_mahal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari_mahal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_moshtari_mahal = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00074084 File Offset: 0x00072284
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x0000362B File Offset: 0x0000182B
		internal virtual UICheckBox txt_moshtari_show_contact
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari_show_contact;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_moshtari_show_contact = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0007409C File Offset: 0x0007229C
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00003635 File Offset: 0x00001835
		internal virtual UIGroupBox UiGroupBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox9 = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000740B4 File Offset: 0x000722B4
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0000363F File Offset: 0x0000183F
		internal virtual UICheckBox txt_moshtari_exit_on_save
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari_exit_on_save;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_moshtari_exit_on_save = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000740CC File Offset: 0x000722CC
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00003649 File Offset: 0x00001849
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000740E4 File Offset: 0x000722E4
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00003653 File Offset: 0x00001853
		internal virtual UIComboBox txt_three_zero
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_three_zero;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_three_zero = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000740FC File Offset: 0x000722FC
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x0000365D File Offset: 0x0000185D
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00074114 File Offset: 0x00072314
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00003667 File Offset: 0x00001867
		internal virtual UIGroupBox UiGroupBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox10 = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0007412C File Offset: 0x0007232C
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00003671 File Offset: 0x00001871
		internal virtual UICheckBox txt_kharid_keraye_tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kharid_keraye_tozih;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kharid_keraye_tozih = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00074144 File Offset: 0x00072344
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x0000367B File Offset: 0x0000187B
		internal virtual UICheckBox txt_kharid_keraye_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kharid_keraye_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kharid_keraye_moshtari = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x0007415C File Offset: 0x0007235C
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00003685 File Offset: 0x00001885
		internal virtual UIComboBox txt_surat_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_surat_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_surat_bank = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00074174 File Offset: 0x00072374
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x0000368F File Offset: 0x0000188F
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

		// Token: 0x0600082D RID: 2093 RVA: 0x0007418C File Offset: 0x0007238C
		private void Frm_Amniat_Setting_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F2);
			if (flag)
			{
				bool visible = this.ButtonItem2.Visible;
				if (visible)
				{
					this.ButtonItem2_Click(null, null);
				}
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000741DC File Offset: 0x000723DC
		private void LoadData()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["kharid_keraye_moshtari"]);
			if (flag)
			{
				this.txt_kharid_keraye_moshtari.Checked = true;
			}
			else
			{
				this.txt_kharid_keraye_moshtari.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["kharid_keraye_tozih"]);
			if (flag)
			{
				this.txt_kharid_keraye_tozih.Checked = true;
			}
			else
			{
				this.txt_kharid_keraye_tozih.Checked = false;
			}
			flag = (Conversions.ToDouble(Public_Function.dict["surat_bank_kind"]) == 1.0);
			if (flag)
			{
				this.txt_surat_bank.SelectedValue = 1;
			}
			else
			{
				this.txt_surat_bank.SelectedValue = 2;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["three_zero"]);
			if (flag)
			{
				this.txt_three_zero.SelectedValue = true;
			}
			else
			{
				this.txt_three_zero.SelectedValue = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["sardkhane_keraye_moshtari"]);
			if (flag)
			{
				this.txt_sardkhane_keraye_moshtari.Checked = true;
			}
			else
			{
				this.txt_sardkhane_keraye_moshtari.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["sardkhane_keraye_tozih"]);
			if (flag)
			{
				this.txt_sardkhane_keraye_tozih.Checked = true;
			}
			else
			{
				this.txt_sardkhane_keraye_tozih.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["sardkhane_vaznkol"]);
			if (flag)
			{
				this.txt_sardkhane_vaznkol.Checked = true;
			}
			else
			{
				this.txt_sardkhane_vaznkol.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["auto_vusul"]);
			if (flag)
			{
				this.txt_Auto_Vusul.Checked = true;
			}
			else
			{
				this.txt_Auto_Vusul.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["auto_vusul_d"]);
			if (flag)
			{
				this.txt_auto_vusul_d.Checked = true;
			}
			else
			{
				this.txt_auto_vusul_d.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["elan_check"]);
			if (flag)
			{
				this.txt_elan_check.Checked = true;
			}
			else
			{
				this.txt_elan_check.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["desktop_note"]);
			if (flag)
			{
				this.txt_desktop_note.Checked = true;
			}
			else
			{
				this.txt_desktop_note.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["no_hazine_agsat"]);
			if (flag)
			{
				this.UiCheckBox2.Checked = true;
			}
			flag = Public_Function.dict.ContainsKey("onebackup");
			if (flag)
			{
				this.txt_oneBackup.Checked = Conversions.ToBoolean(Public_Function.dict["onebackup"]);
			}
			flag = Public_Function.dict.ContainsKey("backup_category");
			if (flag)
			{
				this.txt_backupCategory.Checked = Conversions.ToBoolean(Public_Function.dict["backup_category"]);
			}
			flag = Conversions.ToBoolean(Public_Function.dict["fullscreen"]);
			if (flag)
			{
				this.txt_fullscreen.Checked = true;
			}
			else
			{
				this.txt_fullscreen.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["showstatus"]);
			if (flag)
			{
				this.UiCheckBox3.Checked = true;
			}
			else
			{
				this.UiCheckBox3.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["showmemo"]);
			if (flag)
			{
				this.UiCheckBox4.Checked = true;
			}
			else
			{
				this.UiCheckBox4.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["showtoolbar"]);
			if (flag)
			{
				this.UiCheckBox5.Checked = true;
			}
			else
			{
				this.UiCheckBox5.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["showmax"]);
			if (flag)
			{
				this.UiCheckBox6.Checked = true;
			}
			else
			{
				this.UiCheckBox6.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["kiosk_auto_kasr"]);
			if (flag)
			{
				this.txt_kiosk_auto_kasr.Checked = true;
			}
			else
			{
				this.txt_kiosk_auto_kasr.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["newrow_kala"]);
			if (flag)
			{
				this.txt_newrow_kala.Checked = true;
			}
			else
			{
				this.txt_newrow_kala.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["kharid_sardkhane_factor"]);
			if (flag)
			{
				this.txt_sh_factor.Checked = true;
			}
			else
			{
				this.txt_sh_factor.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["moshtari_show_contact_info"]);
			if (flag)
			{
				this.txt_moshtari_show_contact.Checked = true;
			}
			else
			{
				this.txt_moshtari_show_contact.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["moshtari_show_pic"]);
			if (flag)
			{
				this.txt_moshtari_pic.Checked = true;
			}
			else
			{
				this.txt_moshtari_pic.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["moshtari_show_mahal"]);
			if (flag)
			{
				this.txt_moshtari_mahal.Checked = true;
			}
			else
			{
				this.txt_moshtari_mahal.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["moshtari_exit_on_save"]);
			if (flag)
			{
				this.txt_moshtari_exit_on_save.Checked = true;
			}
			else
			{
				this.txt_moshtari_exit_on_save.Checked = false;
			}
			flag = Public_Function.dict.ContainsKey("altbackup");
			bool flag2;
			if (flag)
			{
				flag2 = Conversions.ToBoolean(Public_Function.dict["altbackup"]);
				if (flag2)
				{
					this.txt_altbackup.Checked = true;
				}
				else
				{
					this.txt_altbackup.Checked = false;
				}
			}
			else
			{
				this.txt_altbackup.Checked = false;
			}
			flag2 = Public_Function.dict.ContainsKey("altbackup_path");
			if (flag2)
			{
				flag = (Public_Function.dict["altbackup_path"] != DBNull.Value);
				if (flag)
				{
					this.txt_altbackupPath.Text = Public_Function.dict["altbackup_path"];
				}
			}
			string text = string.Empty;
			text = Public_Function.dict["daryaftcheck"];
			flag2 = (Operators.CompareString(text.Substring(0, 1), "0", false) == 0);
			if (flag2)
			{
				this.txt_shomarehesab.Checked = false;
			}
			else
			{
				this.txt_shomarehesab.Checked = true;
			}
			flag2 = (Operators.CompareString(text.Substring(1, 1), "0", false) == 0);
			if (flag2)
			{
				this.txt_bank.Checked = false;
			}
			else
			{
				this.txt_bank.Checked = true;
			}
			flag2 = (Operators.CompareString(text.Substring(2, 1), "0", false) == 0);
			if (flag2)
			{
				this.txt_shobe.Checked = false;
			}
			else
			{
				this.txt_shobe.Checked = true;
			}
			flag2 = (Operators.CompareString(text.Substring(3, 1), "0", false) == 0);
			if (flag2)
			{
				this.txt_sahebcheck.Checked = false;
			}
			else
			{
				this.txt_sahebcheck.Checked = true;
			}
			flag2 = Public_Function.dict.ContainsKey("nahve_kharid");
			if (flag2)
			{
				this.txt_nahve_kharid.SelectedValue = Public_Function.dict["nahve_kharid"];
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00074940 File Offset: 0x00072B40
		private void Save()
		{
			setting setting = new setting();
			setting.Update("surat_bank_kind", Conversions.ToString(this.txt_surat_bank.SelectedValue));
			Public_Function.dict["surat_bank_kind"] = Conversions.ToString(this.txt_surat_bank.SelectedValue);
			setting.Update("three_zero", Conversions.ToString(this.txt_three_zero.SelectedValue));
			Public_Function.dict["three_zero"] = Conversions.ToString(this.txt_three_zero.SelectedValue);
			setting.Update("no_hazine_agsat", Conversions.ToString(this.UiCheckBox2.Checked));
			Public_Function.dict["no_hazine_agsat"] = Conversions.ToString(this.UiCheckBox2.Checked);
			setting.Update("fullscreen", Conversions.ToString(this.txt_fullscreen.Checked));
			setting.Update("showstatus", Conversions.ToString(this.UiCheckBox3.Checked));
			setting.Update("showmemo", Conversions.ToString(this.UiCheckBox4.Checked));
			setting.Update("showtoolbar", Conversions.ToString(this.UiCheckBox5.Checked));
			setting.Update("showmax", Conversions.ToString(this.UiCheckBox6.Checked));
			setting.Update("onebackup", Conversions.ToString(this.txt_oneBackup.Checked));
			setting.Update("altbackup", Conversions.ToString(this.txt_altbackup.Checked));
			setting.Update("auto_vusul", Conversions.ToString(this.txt_Auto_Vusul.Checked));
			setting.Update("auto_vusul_d", Conversions.ToString(this.txt_auto_vusul_d.Checked));
			setting.Update("sardkhane_vaznkol", Conversions.ToString(this.txt_sardkhane_vaznkol.Checked));
			setting.Update("sardkhane_keraye_moshtari", Conversions.ToString(this.txt_sardkhane_keraye_moshtari.Checked));
			setting.Update("sardkhane_keraye_tozih", Conversions.ToString(this.txt_sardkhane_keraye_tozih.Checked));
			setting.Update("kharid_keraye_moshtari", Conversions.ToString(this.txt_kharid_keraye_moshtari.Checked));
			setting.Update("kharid_keraye_tozih", Conversions.ToString(this.txt_kharid_keraye_tozih.Checked));
			setting.Update("kharid_sardkhane_factor", Conversions.ToString(this.txt_sh_factor.Checked));
			bool flag = Operators.CompareString(this.txt_altbackupPath.Text, string.Empty, false) != 0;
			if (flag)
			{
				setting.Update("altbackup_path", this.txt_altbackupPath.Text);
			}
			setting.Update("backup_category", Conversions.ToString(this.txt_backupCategory.Checked));
			setting.Update("elan_check", Conversions.ToString(this.txt_elan_check.Checked));
			setting.Update("desktop_note", Conversions.ToString(this.txt_desktop_note.Checked));
			setting.Update("kiosk_auto_kasr", Conversions.ToString(this.txt_kiosk_auto_kasr.Checked));
			setting.Update("newrow_kala", Conversions.ToString(this.txt_newrow_kala.Checked));
			Public_Function.dict["kharid_keraye_moshtari"] = Conversions.ToString(this.txt_kharid_keraye_moshtari.Checked);
			Public_Function.dict["kharid_keraye_tozih"] = Conversions.ToString(this.txt_kharid_keraye_tozih.Checked);
			Public_Function.dict["auto_vusul"] = Conversions.ToString(this.txt_Auto_Vusul.Checked);
			Public_Function.dict["auto_vusul_d"] = Conversions.ToString(this.txt_auto_vusul_d.Checked);
			Public_Function.dict["fullscreen"] = Conversions.ToString(this.txt_fullscreen.Checked);
			Public_Function.dict["showstatus"] = Conversions.ToString(this.UiCheckBox3.Checked);
			Public_Function.dict["showmemo"] = Conversions.ToString(this.UiCheckBox4.Checked);
			Public_Function.dict["showtoolbar"] = Conversions.ToString(this.UiCheckBox5.Checked);
			Public_Function.dict["onebackup"] = Conversions.ToString(this.txt_oneBackup.Checked);
			Public_Function.dict["altbackup"] = Conversions.ToString(this.txt_altbackup.Checked);
			Public_Function.dict["kiosk_auto_kasr"] = Conversions.ToString(this.txt_kiosk_auto_kasr.Checked);
			Public_Function.dict["newrow_kala"] = Conversions.ToString(this.txt_newrow_kala.Checked);
			Public_Function.dict["sardkhane_vaznkol"] = Conversions.ToString(this.txt_sardkhane_vaznkol.Checked);
			Public_Function.dict["sardkhane_keraye_moshtari"] = Conversions.ToString(this.txt_sardkhane_keraye_moshtari.Checked);
			Public_Function.dict["sardkhane_keraye_tozih"] = Conversions.ToString(this.txt_sardkhane_keraye_tozih.Checked);
			Public_Function.dict["kharid_sardkhane_factor"] = Conversions.ToString(this.txt_sh_factor.Checked);
			Public_Function.dict["moshtari_show_contact_info"] = Conversions.ToString(this.txt_moshtari_show_contact.Checked);
			Public_Function.dict["moshtari_show_pic"] = Conversions.ToString(this.txt_moshtari_pic.Checked);
			Public_Function.dict["moshtari_show_mahal"] = Conversions.ToString(this.txt_moshtari_mahal.Checked);
			Public_Function.dict["moshtari_exit_on_save"] = Conversions.ToString(this.txt_moshtari_exit_on_save.Checked);
			setting.Update("moshtari_show_contact_info", Conversions.ToString(this.txt_moshtari_show_contact.Checked));
			setting.Update("moshtari_show_pic", Conversions.ToString(this.txt_moshtari_pic.Checked));
			setting.Update("moshtari_show_mahal", Conversions.ToString(this.txt_moshtari_mahal.Checked));
			setting.Update("moshtari_exit_on_save", Conversions.ToString(this.txt_moshtari_exit_on_save.Checked));
			flag = (Operators.CompareString(this.txt_altbackupPath.Text, string.Empty, false) != 0);
			if (flag)
			{
				Public_Function.dict["altbackup_path"] = this.txt_altbackupPath.Text;
			}
			Public_Function.dict["backup_category"] = Conversions.ToString(this.txt_backupCategory.Checked);
			Public_Function.dict["elan_check"] = Conversions.ToString(this.txt_elan_check.Checked);
			Public_Function.dict["desktop_note"] = Conversions.ToString(this.txt_desktop_note.Checked);
			flag = this.txt_fullscreen.Checked;
			if (flag)
			{
				MyProject.Forms.Form_Main.FormBorderStyle = FormBorderStyle.None;
			}
			else
			{
				MyProject.Forms.Form_Main.FormBorderStyle = FormBorderStyle.Sizable;
			}
			flag = this.UiCheckBox3.Checked;
			if (flag)
			{
				MyProject.Forms.Form_Main.RibbonStatusBar1.Visible = true;
			}
			else
			{
				MyProject.Forms.Form_Main.RibbonStatusBar1.Visible = false;
			}
			flag = this.UiCheckBox4.Checked;
			if (flag)
			{
				MyProject.Forms.Form_Main.uiPanel1.Closed = false;
			}
			else
			{
				MyProject.Forms.Form_Main.uiPanel1.Closed = true;
			}
			string text = string.Empty;
			flag = this.txt_shomarehesab.Checked;
			if (flag)
			{
				text += "1";
			}
			else
			{
				text += "0";
			}
			flag = this.txt_bank.Checked;
			if (flag)
			{
				text += "1";
			}
			else
			{
				text += "0";
			}
			flag = this.txt_shobe.Checked;
			if (flag)
			{
				text += "1";
			}
			else
			{
				text += "0";
			}
			flag = this.txt_sahebcheck.Checked;
			if (flag)
			{
				text += "1";
			}
			else
			{
				text += "0";
			}
			Public_Function.dict["daryaftcheck"] = text;
			setting.Update("daryaftcheck", text);
			setting.Update("nahve_kharid", Conversions.ToString(this.txt_nahve_kharid.SelectedValue));
			Public_Function.dict["nahve_kharid"] = Conversions.ToString(this.txt_nahve_kharid.SelectedValue);
			Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.Close();
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00003699 File Offset: 0x00001899
		private void Frm_Extra_Setting_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000036A4 File Offset: 0x000018A4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000751D4 File Offset: 0x000733D4
		private void txt_altbackupPath_ButtonClick(object sender, EventArgs e)
		{
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.txt_altbackupPath.Text = this.FolderBrowserDialog1.SelectedPath;
			}
		}

		// Token: 0x040002F8 RID: 760
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002FA RID: 762
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040002FB RID: 763
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040002FC RID: 764
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040002FD RID: 765
		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x040002FE RID: 766
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040002FF RID: 767
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000300 RID: 768
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x04000301 RID: 769
		[AccessedThroughProperty("txt_backupCategory")]
		private UICheckBox _txt_backupCategory;

		// Token: 0x04000302 RID: 770
		[AccessedThroughProperty("txt_oneBackup")]
		private UICheckBox _txt_oneBackup;

		// Token: 0x04000303 RID: 771
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000304 RID: 772
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000305 RID: 773
		[AccessedThroughProperty("UiCheckBox6")]
		private UICheckBox _UiCheckBox6;

		// Token: 0x04000306 RID: 774
		[AccessedThroughProperty("UiCheckBox5")]
		private UICheckBox _UiCheckBox5;

		// Token: 0x04000307 RID: 775
		[AccessedThroughProperty("UiCheckBox4")]
		private UICheckBox _UiCheckBox4;

		// Token: 0x04000308 RID: 776
		[AccessedThroughProperty("UiCheckBox3")]
		private UICheckBox _UiCheckBox3;

		// Token: 0x04000309 RID: 777
		[AccessedThroughProperty("txt_fullscreen")]
		private UICheckBox _txt_fullscreen;

		// Token: 0x0400030A RID: 778
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x0400030B RID: 779
		[AccessedThroughProperty("UiGroupBox5")]
		private UIGroupBox _UiGroupBox5;

		// Token: 0x0400030C RID: 780
		[AccessedThroughProperty("txt_altbackupPath")]
		private EditBox _txt_altbackupPath;

		// Token: 0x0400030D RID: 781
		[AccessedThroughProperty("txt_altbackup")]
		private UICheckBox _txt_altbackup;

		// Token: 0x0400030E RID: 782
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400030F RID: 783
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x04000310 RID: 784
		[AccessedThroughProperty("txt_elan_check")]
		private UICheckBox _txt_elan_check;

		// Token: 0x04000311 RID: 785
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x04000312 RID: 786
		[AccessedThroughProperty("txt_desktop_note")]
		private UICheckBox _txt_desktop_note;

		// Token: 0x04000313 RID: 787
		[AccessedThroughProperty("UiCheckBox7")]
		private UICheckBox _UiCheckBox7;

		// Token: 0x04000314 RID: 788
		[AccessedThroughProperty("UiGroupBox6")]
		private UIGroupBox _UiGroupBox6;

		// Token: 0x04000315 RID: 789
		[AccessedThroughProperty("txt_sahebcheck")]
		private UICheckBox _txt_sahebcheck;

		// Token: 0x04000316 RID: 790
		[AccessedThroughProperty("txt_shobe")]
		private UICheckBox _txt_shobe;

		// Token: 0x04000317 RID: 791
		[AccessedThroughProperty("txt_bank")]
		private UICheckBox _txt_bank;

		// Token: 0x04000318 RID: 792
		[AccessedThroughProperty("txt_shomarehesab")]
		private UICheckBox _txt_shomarehesab;

		// Token: 0x04000319 RID: 793
		[AccessedThroughProperty("txt_kiosk_auto_kasr")]
		private UICheckBox _txt_kiosk_auto_kasr;

		// Token: 0x0400031A RID: 794
		[AccessedThroughProperty("txt_newrow_kala")]
		private UICheckBox _txt_newrow_kala;

		// Token: 0x0400031B RID: 795
		[AccessedThroughProperty("txt_Auto_Vusul")]
		private UICheckBox _txt_Auto_Vusul;

		// Token: 0x0400031C RID: 796
		[AccessedThroughProperty("txt_auto_vusul_d")]
		private UICheckBox _txt_auto_vusul_d;

		// Token: 0x0400031D RID: 797
		[AccessedThroughProperty("UiGroupBox7")]
		private UIGroupBox _UiGroupBox7;

		// Token: 0x0400031E RID: 798
		[AccessedThroughProperty("txt_sardkhane_vaznkol")]
		private UICheckBox _txt_sardkhane_vaznkol;

		// Token: 0x0400031F RID: 799
		[AccessedThroughProperty("txt_sardkhane_keraye_tozih")]
		private UICheckBox _txt_sardkhane_keraye_tozih;

		// Token: 0x04000320 RID: 800
		[AccessedThroughProperty("txt_sardkhane_keraye_moshtari")]
		private UICheckBox _txt_sardkhane_keraye_moshtari;

		// Token: 0x04000321 RID: 801
		[AccessedThroughProperty("txt_sh_factor")]
		private UICheckBox _txt_sh_factor;

		// Token: 0x04000322 RID: 802
		[AccessedThroughProperty("txt_nahve_kharid")]
		private UIComboBox _txt_nahve_kharid;

		// Token: 0x04000323 RID: 803
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000324 RID: 804
		[AccessedThroughProperty("UiGroupBox8")]
		private UIGroupBox _UiGroupBox8;

		// Token: 0x04000325 RID: 805
		[AccessedThroughProperty("txt_moshtari_pic")]
		private UICheckBox _txt_moshtari_pic;

		// Token: 0x04000326 RID: 806
		[AccessedThroughProperty("txt_moshtari_mahal")]
		private UICheckBox _txt_moshtari_mahal;

		// Token: 0x04000327 RID: 807
		[AccessedThroughProperty("txt_moshtari_show_contact")]
		private UICheckBox _txt_moshtari_show_contact;

		// Token: 0x04000328 RID: 808
		[AccessedThroughProperty("UiGroupBox9")]
		private UIGroupBox _UiGroupBox9;

		// Token: 0x04000329 RID: 809
		[AccessedThroughProperty("txt_moshtari_exit_on_save")]
		private UICheckBox _txt_moshtari_exit_on_save;

		// Token: 0x0400032A RID: 810
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400032B RID: 811
		[AccessedThroughProperty("txt_three_zero")]
		private UIComboBox _txt_three_zero;

		// Token: 0x0400032C RID: 812
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400032D RID: 813
		[AccessedThroughProperty("UiGroupBox10")]
		private UIGroupBox _UiGroupBox10;

		// Token: 0x0400032E RID: 814
		[AccessedThroughProperty("txt_kharid_keraye_tozih")]
		private UICheckBox _txt_kharid_keraye_tozih;

		// Token: 0x0400032F RID: 815
		[AccessedThroughProperty("txt_kharid_keraye_moshtari")]
		private UICheckBox _txt_kharid_keraye_moshtari;

		// Token: 0x04000330 RID: 816
		[AccessedThroughProperty("txt_surat_bank")]
		private UIComboBox _txt_surat_bank;

		// Token: 0x04000331 RID: 817
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
	}
}
