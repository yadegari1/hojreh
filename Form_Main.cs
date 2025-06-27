﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro.ColorTables;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.ButtonBar;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.Ribbon;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200005A RID: 90
	[DesignerGenerated]
	public partial class Form_Main : Form
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x0004F4B0 File Offset: 0x0004D6B0
		public Form_Main()
		{
			base.Load += new EventHandler(this.Form1_Load);
			base.FormClosing += new FormClosingEventHandler(this.Form_Main_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Form_Main_KeyDown);
			base.KeyUp += new KeyEventHandler(this.Form_Main_KeyUp);
			Form_Main.__ENCAddToList(this);
			this.frm_size = new Frm_Size();
			this.grid_size = new Grid_Size();
			this.user = new base_user();
			this.user_conreol = new Base_User_Control();
			this.note = new Note();
			this.stickymanager = new StickyManager();
			this.setting = new setting();
			this.tabclose_Flag = false;
			this.miveh = new string[]
			{
				"banana",
				"goje",
				"gara",
				"sir",
				"gilas",
				"felfel",
				"golabi",
				"limu",
				"tutfarangi",
				"tutgermez",
				"tutsiah",
				"limu"
			};
			this.imgbanana = (Image)Resources.ResourceManager.GetObject(this.miveh[Public_Function.GetRandom(0, 10)]);
			this.frms = new List<Form>();
			this.bar_focus = false;
			this.frm_menu = new Frm_Menu();
			this.InitializeComponent();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0004F638 File Offset: 0x0004D838
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form_Main.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form_Main.__ENCList.Count == Form_Main.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form_Main.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form_Main.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form_Main.__ENCList[num] = Form_Main.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form_Main.__ENCList.RemoveRange(num, Form_Main.__ENCList.Count - num);
						Form_Main.__ENCList.Capacity = Form_Main.__ENCList.Count;
					}
					Form_Main.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00055CA4 File Offset: 0x00053EA4
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00055CBC File Offset: 0x00053EBC
		internal virtual ButtonBar ButtonBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ItemEventHandler value2 = new ItemEventHandler(this.ButtonBar1_ItemClick);
				bool flag = this._ButtonBar1 != null;
				if (flag)
				{
					this._ButtonBar1.ItemClick -= value2;
				}
				this._ButtonBar1 = value;
				flag = (this._ButtonBar1 != null);
				if (flag)
				{
					this._ButtonBar1.ItemClick += value2;
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00055D1C File Offset: 0x00053F1C
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00055D34 File Offset: 0x00053F34
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
				PaintEventHandler value2 = new PaintEventHandler(this.UiGroupBox1_Paint);
				bool flag = this._UiGroupBox1 != null;
				if (flag)
				{
					this._UiGroupBox1.Paint -= value2;
				}
				this._UiGroupBox1 = value;
				flag = (this._UiGroupBox1 != null);
				if (flag)
				{
					this._UiGroupBox1.Paint += value2;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00055D94 File Offset: 0x00053F94
		// (set) Token: 0x060003DC RID: 988 RVA: 0x000029BC File Offset: 0x00000BBC
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00055DAC File Offset: 0x00053FAC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000029C6 File Offset: 0x00000BC6
		internal virtual UIPanelManager UiPanelManager1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiPanelManager1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiPanelManager1 = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00055DC4 File Offset: 0x00053FC4
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000029D0 File Offset: 0x00000BD0
		internal virtual UIPanel uiPanel0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel0 = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00055DDC File Offset: 0x00053FDC
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000029DA File Offset: 0x00000BDA
		internal virtual UIPanelInnerContainer uiPanel0Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel0Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel0Container = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00055DF4 File Offset: 0x00053FF4
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000029E4 File Offset: 0x00000BE4
		internal virtual SuperTabControl SuperTabControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SuperTabControl1 = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00055E0C File Offset: 0x0005400C
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000029EE File Offset: 0x00000BEE
		internal virtual SuperTabControlPanel SuperTabControlPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabControlPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SuperTabControlPanel1 = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00055E24 File Offset: 0x00054024
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000029F8 File Offset: 0x00000BF8
		internal virtual SuperTabItem SuperTabItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SuperTabItem1 = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00055E3C File Offset: 0x0005403C
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00055E54 File Offset: 0x00054054
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
				KeyEventHandler value2 = new KeyEventHandler(this.Bar1_KeyDown);
				EventHandler value3 = new EventHandler(this.Bar1_GotFocus);
				bool flag = this._Bar1 != null;
				if (flag)
				{
					this._Bar1.KeyDown -= value2;
					this._Bar1.GotFocus -= value3;
				}
				this._Bar1 = value;
				flag = (this._Bar1 != null);
				if (flag)
				{
					this._Bar1.KeyDown += value2;
					this._Bar1.GotFocus += value3;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00055EDC File Offset: 0x000540DC
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002A02 File Offset: 0x00000C02
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00055EF4 File Offset: 0x000540F4
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002A0C File Offset: 0x00000C0C
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
				this._ButtonItem14 = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00055F0C File Offset: 0x0005410C
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00055F24 File Offset: 0x00054124
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00055F84 File Offset: 0x00054184
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002A16 File Offset: 0x00000C16
		internal virtual LabelCommand txt_CompanyName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_CompanyName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_CompanyName = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00055F9C File Offset: 0x0005419C
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00002A20 File Offset: 0x00000C20
		internal virtual LabelCommand lbl_user
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_user;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_user = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00055FB4 File Offset: 0x000541B4
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00002A2A File Offset: 0x00000C2A
		internal virtual StyleManager StyleManager1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StyleManager1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StyleManager1 = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00055FCC File Offset: 0x000541CC
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00055FE4 File Offset: 0x000541E4
		internal virtual PanelEx PanelEx1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PanelEx1_Click);
				bool flag = this._PanelEx1 != null;
				if (flag)
				{
					this._PanelEx1.Click -= value2;
				}
				this._PanelEx1 = value;
				flag = (this._PanelEx1 != null);
				if (flag)
				{
					this._PanelEx1.Click += value2;
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00056044 File Offset: 0x00054244
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0005605C File Offset: 0x0005425C
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000560BC File Offset: 0x000542BC
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000560D4 File Offset: 0x000542D4
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00056134 File Offset: 0x00054334
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00002A34 File Offset: 0x00000C34
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0005614C File Offset: 0x0005434C
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00002A3E File Offset: 0x00000C3E
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00056164 File Offset: 0x00054364
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0005617C File Offset: 0x0005437C
		internal virtual ButtonCommand ButtonCommand1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCommand1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CommandEventHandler value2 = new CommandEventHandler(this.ButtonCommand1_Click);
				bool flag = this._ButtonCommand1 != null;
				if (flag)
				{
					this._ButtonCommand1.Click -= value2;
				}
				this._ButtonCommand1 = value;
				flag = (this._ButtonCommand1 != null);
				if (flag)
				{
					this._ButtonCommand1.Click += value2;
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000561DC File Offset: 0x000543DC
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x000561F4 File Offset: 0x000543F4
		internal virtual ButtonCommand ButtonCommand2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCommand2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CommandEventHandler value2 = new CommandEventHandler(this.ButtonCommand2_Click);
				bool flag = this._ButtonCommand2 != null;
				if (flag)
				{
					this._ButtonCommand2.Click -= value2;
				}
				this._ButtonCommand2 = value;
				flag = (this._ButtonCommand2 != null);
				if (flag)
				{
					this._ButtonCommand2.Click += value2;
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00056254 File Offset: 0x00054454
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00002A48 File Offset: 0x00000C48
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0005626C File Offset: 0x0005446C
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002A52 File Offset: 0x00000C52
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00056284 File Offset: 0x00054484
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00002A5C File Offset: 0x00000C5C
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0005629C File Offset: 0x0005449C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000562B4 File Offset: 0x000544B4
		internal virtual SuperTabStrip SuperTabStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler<SuperTabStripSelectedTabChangedEventArgs> value2 = new EventHandler<SuperTabStripSelectedTabChangedEventArgs>(this.SuperTabStrip1_SelectedTabChanged);
				EventHandler<SuperTabStripTabItemCloseEventArgs> value3 = new EventHandler<SuperTabStripTabItemCloseEventArgs>(this.SuperTabStrip1_TabItemClose);
				bool flag = this._SuperTabStrip1 != null;
				if (flag)
				{
					this._SuperTabStrip1.SelectedTabChanged -= value2;
					this._SuperTabStrip1.TabItemClose -= value3;
				}
				this._SuperTabStrip1 = value;
				flag = (this._SuperTabStrip1 != null);
				if (flag)
				{
					this._SuperTabStrip1.SelectedTabChanged += value2;
					this._SuperTabStrip1.TabItemClose += value3;
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0005633C File Offset: 0x0005453C
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00056354 File Offset: 0x00054554
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x000563B4 File Offset: 0x000545B4
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x000563CC File Offset: 0x000545CC
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0005642C File Offset: 0x0005462C
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00002A66 File Offset: 0x00000C66
		internal virtual OfficeFormAdorner OfficeFormAdorner1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OfficeFormAdorner1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OfficeFormAdorner1 = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00056444 File Offset: 0x00054644
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00002A70 File Offset: 0x00000C70
		internal virtual ButtonItem ButtonItem36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem36 = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0005645C File Offset: 0x0005465C
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00002A7A File Offset: 0x00000C7A
		internal virtual RibbonTabItem RibbonTabItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonTabItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonTabItem4 = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00056474 File Offset: 0x00054674
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00002A84 File Offset: 0x00000C84
		internal virtual RibbonTabItem RibbonTabItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonTabItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonTabItem3 = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0005648C File Offset: 0x0005468C
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00002A8E File Offset: 0x00000C8E
		internal virtual RibbonTabItem RibbonTabItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonTabItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonTabItem2 = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x000564A4 File Offset: 0x000546A4
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00002A98 File Offset: 0x00000C98
		internal virtual RibbonTabItem RibbonTabItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonTabItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonTabItem5 = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x000564BC File Offset: 0x000546BC
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00002AA2 File Offset: 0x00000CA2
		internal virtual RibbonTabItem RibbonTabItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonTabItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonTabItem1 = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x000564D4 File Offset: 0x000546D4
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00002AAC File Offset: 0x00000CAC
		internal virtual Office2007StartButton Office2007StartButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Office2007StartButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Office2007StartButton1 = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000564EC File Offset: 0x000546EC
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00002AB6 File Offset: 0x00000CB6
		internal virtual ItemContainer ItemContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItemContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ItemContainer1 = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00056504 File Offset: 0x00054704
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00002AC0 File Offset: 0x00000CC0
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0005651C File Offset: 0x0005471C
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00002ACA File Offset: 0x00000CCA
		internal virtual ItemContainer ItemContainer3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItemContainer3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ItemContainer3 = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00056534 File Offset: 0x00054734
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00002AD4 File Offset: 0x00000CD4
		internal virtual ButtonItem ButtonItem24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem24 = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0005654C File Offset: 0x0005474C
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00002ADE File Offset: 0x00000CDE
		internal virtual ButtonItem ButtonItem25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem25 = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00056564 File Offset: 0x00054764
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00002AE8 File Offset: 0x00000CE8
		internal virtual ButtonItem ButtonItem26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem26 = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0005657C File Offset: 0x0005477C
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00002AF2 File Offset: 0x00000CF2
		internal virtual ButtonItem ButtonItem27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem27 = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00056594 File Offset: 0x00054794
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00002AFC File Offset: 0x00000CFC
		internal virtual ButtonItem ButtonItem28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem28 = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000565AC File Offset: 0x000547AC
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00002B06 File Offset: 0x00000D06
		internal virtual ButtonItem ButtonItem29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem29 = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000565C4 File Offset: 0x000547C4
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00002B10 File Offset: 0x00000D10
		internal virtual GalleryContainer GalleryContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GalleryContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GalleryContainer1 = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x000565DC File Offset: 0x000547DC
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00002B1A File Offset: 0x00000D1A
		internal virtual LabelItem labelItem8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._labelItem8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._labelItem8 = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000565F4 File Offset: 0x000547F4
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00002B24 File Offset: 0x00000D24
		internal virtual ButtonItem ButtonItem30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem30 = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0005660C File Offset: 0x0005480C
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00002B2E File Offset: 0x00000D2E
		internal virtual ButtonItem ButtonItem31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem31 = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00056624 File Offset: 0x00054824
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00002B38 File Offset: 0x00000D38
		internal virtual ButtonItem ButtonItem32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem32 = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0005663C File Offset: 0x0005483C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00002B42 File Offset: 0x00000D42
		internal virtual ButtonItem ButtonItem33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem33 = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00056654 File Offset: 0x00054854
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal virtual ItemContainer ItemContainer4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItemContainer4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ItemContainer4 = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0005666C File Offset: 0x0005486C
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00002B56 File Offset: 0x00000D56
		internal virtual ButtonItem ButtonItem34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem34 = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00056684 File Offset: 0x00054884
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0005669C File Offset: 0x0005489C
		internal virtual ButtonItem ButtonItem35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem35_Click);
				bool flag = this._ButtonItem35 != null;
				if (flag)
				{
					this._ButtonItem35.Click -= value2;
				}
				this._ButtonItem35 = value;
				flag = (this._ButtonItem35 != null);
				if (flag)
				{
					this._ButtonItem35.Click += value2;
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000566FC File Offset: 0x000548FC
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00056714 File Offset: 0x00054914
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00056774 File Offset: 0x00054974
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0005678C File Offset: 0x0005498C
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000567EC File Offset: 0x000549EC
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00002B60 File Offset: 0x00000D60
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
				this._ButtonItem5 = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00056804 File Offset: 0x00054A04
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0005681C File Offset: 0x00054A1C
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0005687C File Offset: 0x00054A7C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00056894 File Offset: 0x00054A94
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000568F4 File Offset: 0x00054AF4
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0005690C File Offset: 0x00054B0C
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
				EventHandler value2 = new EventHandler(this.ButtonItem8_Click);
				bool flag = this._ButtonItem8 != null;
				if (flag)
				{
					this._ButtonItem8.Click -= value2;
				}
				this._ButtonItem8 = value;
				flag = (this._ButtonItem8 != null);
				if (flag)
				{
					this._ButtonItem8.Click += value2;
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0005696C File Offset: 0x00054B6C
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00056984 File Offset: 0x00054B84
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x000569E4 File Offset: 0x00054BE4
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00002B6A File Offset: 0x00000D6A
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x000569FC File Offset: 0x00054BFC
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00056A14 File Offset: 0x00054C14
		internal virtual ButtonItem ButtonItem22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem22_Click);
				bool flag = this._ButtonItem22 != null;
				if (flag)
				{
					this._ButtonItem22.Click -= value2;
				}
				this._ButtonItem22 = value;
				flag = (this._ButtonItem22 != null);
				if (flag)
				{
					this._ButtonItem22.Click += value2;
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00056A74 File Offset: 0x00054C74
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00002B74 File Offset: 0x00000D74
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00056A8C File Offset: 0x00054C8C
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00056AA4 File Offset: 0x00054CA4
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
				EventHandler value2 = new EventHandler(this.ButtonItem9_Click_1);
				bool flag = this._ButtonItem9 != null;
				if (flag)
				{
					this._ButtonItem9.Click -= value2;
				}
				this._ButtonItem9 = value;
				flag = (this._ButtonItem9 != null);
				if (flag)
				{
					this._ButtonItem9.Click += value2;
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00056B04 File Offset: 0x00054D04
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00056B1C File Offset: 0x00054D1C
		internal virtual ButtonItem ButtonItem39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem39_Click);
				bool flag = this._ButtonItem39 != null;
				if (flag)
				{
					this._ButtonItem39.Click -= value2;
				}
				this._ButtonItem39 = value;
				flag = (this._ButtonItem39 != null);
				if (flag)
				{
					this._ButtonItem39.Click += value2;
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00056B7C File Offset: 0x00054D7C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00056B94 File Offset: 0x00054D94
		internal virtual ButtonItem ButtonItem40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem40_Click);
				bool flag = this._ButtonItem40 != null;
				if (flag)
				{
					this._ButtonItem40.Click -= value2;
				}
				this._ButtonItem40 = value;
				flag = (this._ButtonItem40 != null);
				if (flag)
				{
					this._ButtonItem40.Click += value2;
				}
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00056BF4 File Offset: 0x00054DF4
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00056C0C File Offset: 0x00054E0C
		internal virtual ButtonItem ButtonItem41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem41_Click);
				bool flag = this._ButtonItem41 != null;
				if (flag)
				{
					this._ButtonItem41.Click -= value2;
				}
				this._ButtonItem41 = value;
				flag = (this._ButtonItem41 != null);
				if (flag)
				{
					this._ButtonItem41.Click += value2;
				}
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00056C6C File Offset: 0x00054E6C
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00056C84 File Offset: 0x00054E84
		internal virtual ButtonItem ButtonItem42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem42_Click);
				bool flag = this._ButtonItem42 != null;
				if (flag)
				{
					this._ButtonItem42.Click -= value2;
				}
				this._ButtonItem42 = value;
				flag = (this._ButtonItem42 != null);
				if (flag)
				{
					this._ButtonItem42.Click += value2;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00056CE4 File Offset: 0x00054EE4
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00056CFC File Offset: 0x00054EFC
		internal virtual ButtonItem ButtonItem43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem43_Click);
				bool flag = this._ButtonItem43 != null;
				if (flag)
				{
					this._ButtonItem43.Click -= value2;
				}
				this._ButtonItem43 = value;
				flag = (this._ButtonItem43 != null);
				if (flag)
				{
					this._ButtonItem43.Click += value2;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00056D5C File Offset: 0x00054F5C
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00056D74 File Offset: 0x00054F74
		internal virtual ButtonItem ButtonItem44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem44_Click);
				bool flag = this._ButtonItem44 != null;
				if (flag)
				{
					this._ButtonItem44.Click -= value2;
				}
				this._ButtonItem44 = value;
				flag = (this._ButtonItem44 != null);
				if (flag)
				{
					this._ButtonItem44.Click += value2;
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00056DD4 File Offset: 0x00054FD4
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00056DEC File Offset: 0x00054FEC
		internal virtual ButtonItem ButtonItem45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem45_Click);
				bool flag = this._ButtonItem45 != null;
				if (flag)
				{
					this._ButtonItem45.Click -= value2;
				}
				this._ButtonItem45 = value;
				flag = (this._ButtonItem45 != null);
				if (flag)
				{
					this._ButtonItem45.Click += value2;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00056E4C File Offset: 0x0005504C
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00056E64 File Offset: 0x00055064
		internal virtual ButtonItem ButtonItem46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem46_Click);
				bool flag = this._ButtonItem46 != null;
				if (flag)
				{
					this._ButtonItem46.Click -= value2;
				}
				this._ButtonItem46 = value;
				flag = (this._ButtonItem46 != null);
				if (flag)
				{
					this._ButtonItem46.Click += value2;
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00056EC4 File Offset: 0x000550C4
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00056EDC File Offset: 0x000550DC
		internal virtual ButtonItem ButtonItem47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem47_Click);
				bool flag = this._ButtonItem47 != null;
				if (flag)
				{
					this._ButtonItem47.Click -= value2;
				}
				this._ButtonItem47 = value;
				flag = (this._ButtonItem47 != null);
				if (flag)
				{
					this._ButtonItem47.Click += value2;
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00056F3C File Offset: 0x0005513C
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00056F54 File Offset: 0x00055154
		internal virtual ButtonItem ButtonItem48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem48_Click);
				bool flag = this._ButtonItem48 != null;
				if (flag)
				{
					this._ButtonItem48.Click -= value2;
				}
				this._ButtonItem48 = value;
				flag = (this._ButtonItem48 != null);
				if (flag)
				{
					this._ButtonItem48.Click += value2;
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00056FB4 File Offset: 0x000551B4
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00056FCC File Offset: 0x000551CC
		internal virtual ButtonItem ButtonItem49
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem49;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem49_Click);
				bool flag = this._ButtonItem49 != null;
				if (flag)
				{
					this._ButtonItem49.Click -= value2;
				}
				this._ButtonItem49 = value;
				flag = (this._ButtonItem49 != null);
				if (flag)
				{
					this._ButtonItem49.Click += value2;
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0005702C File Offset: 0x0005522C
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00057044 File Offset: 0x00055244
		internal virtual ButtonItem ButtonItem50
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem50;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem50_Click);
				bool flag = this._ButtonItem50 != null;
				if (flag)
				{
					this._ButtonItem50.Click -= value2;
				}
				this._ButtonItem50 = value;
				flag = (this._ButtonItem50 != null);
				if (flag)
				{
					this._ButtonItem50.Click += value2;
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000570A4 File Offset: 0x000552A4
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x000570BC File Offset: 0x000552BC
		internal virtual ButtonItem ButtonItem51
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem51;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem51_Click);
				bool flag = this._ButtonItem51 != null;
				if (flag)
				{
					this._ButtonItem51.Click -= value2;
				}
				this._ButtonItem51 = value;
				flag = (this._ButtonItem51 != null);
				if (flag)
				{
					this._ButtonItem51.Click += value2;
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0005711C File Offset: 0x0005531C
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00057134 File Offset: 0x00055334
		internal virtual ButtonItem ButtonItem52
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem52;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem52_Click);
				bool flag = this._ButtonItem52 != null;
				if (flag)
				{
					this._ButtonItem52.Click -= value2;
				}
				this._ButtonItem52 = value;
				flag = (this._ButtonItem52 != null);
				if (flag)
				{
					this._ButtonItem52.Click += value2;
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00057194 File Offset: 0x00055394
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000571AC File Offset: 0x000553AC
		internal virtual ButtonItem ButtonItem53
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem53;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem53_Click);
				bool flag = this._ButtonItem53 != null;
				if (flag)
				{
					this._ButtonItem53.Click -= value2;
				}
				this._ButtonItem53 = value;
				flag = (this._ButtonItem53 != null);
				if (flag)
				{
					this._ButtonItem53.Click += value2;
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0005720C File Offset: 0x0005540C
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00057224 File Offset: 0x00055424
		internal virtual ButtonItem ButtonItem54
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem54;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem54_Click);
				bool flag = this._ButtonItem54 != null;
				if (flag)
				{
					this._ButtonItem54.Click -= value2;
				}
				this._ButtonItem54 = value;
				flag = (this._ButtonItem54 != null);
				if (flag)
				{
					this._ButtonItem54.Click += value2;
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00057284 File Offset: 0x00055484
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0005729C File Offset: 0x0005549C
		internal virtual ButtonItem ButtonItem55
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem55;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem55_Click);
				bool flag = this._ButtonItem55 != null;
				if (flag)
				{
					this._ButtonItem55.Click -= value2;
				}
				this._ButtonItem55 = value;
				flag = (this._ButtonItem55 != null);
				if (flag)
				{
					this._ButtonItem55.Click += value2;
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000572FC File Offset: 0x000554FC
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00057314 File Offset: 0x00055514
		internal virtual ButtonItem ButtonItem56
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem56;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem56_Click);
				bool flag = this._ButtonItem56 != null;
				if (flag)
				{
					this._ButtonItem56.Click -= value2;
				}
				this._ButtonItem56 = value;
				flag = (this._ButtonItem56 != null);
				if (flag)
				{
					this._ButtonItem56.Click += value2;
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00057374 File Offset: 0x00055574
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00002B7E File Offset: 0x00000D7E
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0005738C File Offset: 0x0005558C
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00002B88 File Offset: 0x00000D88
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000573A4 File Offset: 0x000555A4
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000573BC File Offset: 0x000555BC
		internal virtual ButtonItem ButtonItem57
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem57;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem57_Click);
				bool flag = this._ButtonItem57 != null;
				if (flag)
				{
					this._ButtonItem57.Click -= value2;
				}
				this._ButtonItem57 = value;
				flag = (this._ButtonItem57 != null);
				if (flag)
				{
					this._ButtonItem57.Click += value2;
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0005741C File Offset: 0x0005561C
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00057434 File Offset: 0x00055634
		internal virtual ButtonItem ButtonItem59
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem59;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem59_Click);
				bool flag = this._ButtonItem59 != null;
				if (flag)
				{
					this._ButtonItem59.Click -= value2;
				}
				this._ButtonItem59 = value;
				flag = (this._ButtonItem59 != null);
				if (flag)
				{
					this._ButtonItem59.Click += value2;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00057494 File Offset: 0x00055694
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00002B92 File Offset: 0x00000D92
		internal virtual UIPanel uiPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel1 = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000574AC File Offset: 0x000556AC
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00002B9C File Offset: 0x00000D9C
		internal virtual UIPanelInnerContainer uiPanel1Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel1Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel1Container = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000574C4 File Offset: 0x000556C4
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x000574DC File Offset: 0x000556DC
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
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0005753C File Offset: 0x0005573C
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00057554 File Offset: 0x00055754
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
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000575B4 File Offset: 0x000557B4
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x000575CC File Offset: 0x000557CC
		internal virtual EditBox txt_pass
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pass;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_pass_KeyDown);
				bool flag = this._txt_pass != null;
				if (flag)
				{
					this._txt_pass.KeyDown -= value2;
				}
				this._txt_pass = value;
				flag = (this._txt_pass != null);
				if (flag)
				{
					this._txt_pass.KeyDown += value2;
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0005762C File Offset: 0x0005582C
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00057644 File Offset: 0x00055844
		internal virtual UIComboBox txt_user
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_user;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_user_KeyDown);
				bool flag = this._txt_user != null;
				if (flag)
				{
					this._txt_user.KeyDown -= value2;
				}
				this._txt_user = value;
				flag = (this._txt_user != null);
				if (flag)
				{
					this._txt_user.KeyDown += value2;
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000576A4 File Offset: 0x000558A4
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00002BA6 File Offset: 0x00000DA6
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000576BC File Offset: 0x000558BC
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00002BB0 File Offset: 0x00000DB0
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000576D4 File Offset: 0x000558D4
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x000576EC File Offset: 0x000558EC
		internal virtual ButtonItem ButtonItem61
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem61;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem61_Click);
				bool flag = this._ButtonItem61 != null;
				if (flag)
				{
					this._ButtonItem61.Click -= value2;
				}
				this._ButtonItem61 = value;
				flag = (this._ButtonItem61 != null);
				if (flag)
				{
					this._ButtonItem61.Click += value2;
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0005774C File Offset: 0x0005594C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00002BBA File Offset: 0x00000DBA
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

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00057764 File Offset: 0x00055964
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0005777C File Offset: 0x0005597C
		internal virtual ButtonItem ButtonItem60
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem60;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem60_Click);
				bool flag = this._ButtonItem60 != null;
				if (flag)
				{
					this._ButtonItem60.Click -= value2;
				}
				this._ButtonItem60 = value;
				flag = (this._ButtonItem60 != null);
				if (flag)
				{
					this._ButtonItem60.Click += value2;
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000577DC File Offset: 0x000559DC
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000577F4 File Offset: 0x000559F4
		internal virtual ButtonItem ButtonItem58
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem58;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem58_Click_1);
				bool flag = this._ButtonItem58 != null;
				if (flag)
				{
					this._ButtonItem58.Click -= value2;
				}
				this._ButtonItem58 = value;
				flag = (this._ButtonItem58 != null);
				if (flag)
				{
					this._ButtonItem58.Click += value2;
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00057854 File Offset: 0x00055A54
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0005786C File Offset: 0x00055A6C
		internal virtual ButtonItem ButtonItem65
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem65;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem65_Click);
				bool flag = this._ButtonItem65 != null;
				if (flag)
				{
					this._ButtonItem65.Click -= value2;
				}
				this._ButtonItem65 = value;
				flag = (this._ButtonItem65 != null);
				if (flag)
				{
					this._ButtonItem65.Click += value2;
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000578CC File Offset: 0x00055ACC
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000578E4 File Offset: 0x00055AE4
		internal virtual ButtonItem ButtonItem66
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem66;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem66_Click);
				bool flag = this._ButtonItem66 != null;
				if (flag)
				{
					this._ButtonItem66.Click -= value2;
				}
				this._ButtonItem66 = value;
				flag = (this._ButtonItem66 != null);
				if (flag)
				{
					this._ButtonItem66.Click += value2;
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00057944 File Offset: 0x00055B44
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00002BC4 File Offset: 0x00000DC4
		internal virtual UIPanel uiPanel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel2 = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0005795C File Offset: 0x00055B5C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00002BCE File Offset: 0x00000DCE
		internal virtual UIPanelInnerContainer uiPanel2Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel2Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel2Container = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00057974 File Offset: 0x00055B74
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0005798C File Offset: 0x00055B8C
		internal virtual GridEX GridEX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX2_ColumnButtonClick);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.ColumnButtonClick -= value2;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.ColumnButtonClick += value2;
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000579EC File Offset: 0x00055BEC
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00057A04 File Offset: 0x00055C04
		internal virtual ButtonItem ButtonItem62
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem62;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem62_Click);
				bool flag = this._ButtonItem62 != null;
				if (flag)
				{
					this._ButtonItem62.Click -= value2;
				}
				this._ButtonItem62 = value;
				flag = (this._ButtonItem62 != null);
				if (flag)
				{
					this._ButtonItem62.Click += value2;
				}
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00057A64 File Offset: 0x00055C64
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00057A7C File Offset: 0x00055C7C
		internal virtual ButtonItem ButtonItem63
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem63;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem63_Click);
				bool flag = this._ButtonItem63 != null;
				if (flag)
				{
					this._ButtonItem63.Click -= value2;
				}
				this._ButtonItem63 = value;
				flag = (this._ButtonItem63 != null);
				if (flag)
				{
					this._ButtonItem63.Click += value2;
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00057ADC File Offset: 0x00055CDC
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00057AF4 File Offset: 0x00055CF4
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click_1);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00057B54 File Offset: 0x00055D54
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00002BD8 File Offset: 0x00000DD8
		internal virtual UIPanel uiPanel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel3 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00057B6C File Offset: 0x00055D6C
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00002BE2 File Offset: 0x00000DE2
		internal virtual UIPanelInnerContainer uiPanel3Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel3Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel3Container = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00057B84 File Offset: 0x00055D84
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00057B9C File Offset: 0x00055D9C
		internal virtual GridEX GridEX3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX3_ColumnButtonClick);
				bool flag = this._GridEX3 != null;
				if (flag)
				{
					this._GridEX3.ColumnButtonClick -= value2;
				}
				this._GridEX3 = value;
				flag = (this._GridEX3 != null);
				if (flag)
				{
					this._GridEX3.ColumnButtonClick += value2;
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00057BFC File Offset: 0x00055DFC
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00057C14 File Offset: 0x00055E14
		internal virtual UIButton UiButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton5_Click_1);
				bool flag = this._UiButton5 != null;
				if (flag)
				{
					this._UiButton5.Click -= value2;
				}
				this._UiButton5 = value;
				flag = (this._UiButton5 != null);
				if (flag)
				{
					this._UiButton5.Click += value2;
				}
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00057C74 File Offset: 0x00055E74
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00002BEC File Offset: 0x00000DEC
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00057C8C File Offset: 0x00055E8C
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002BF6 File Offset: 0x00000DF6
		internal virtual UIPanel uiPanel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel4 = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00057CA4 File Offset: 0x00055EA4
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00002C00 File Offset: 0x00000E00
		internal virtual UIPanelInnerContainer uiPanel4Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel4Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel4Container = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00057CBC File Offset: 0x00055EBC
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00002C0A File Offset: 0x00000E0A
		internal virtual UIPanel uiPanel5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel5 = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00057CD4 File Offset: 0x00055ED4
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00002C14 File Offset: 0x00000E14
		internal virtual UIPanelInnerContainer uiPanel5Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel5Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel5Container = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00057CEC File Offset: 0x00055EEC
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00057D04 File Offset: 0x00055F04
		internal virtual GridEX GridEX5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX5_RowDoubleClick);
				bool flag = this._GridEX5 != null;
				if (flag)
				{
					this._GridEX5.RowDoubleClick -= value2;
				}
				this._GridEX5 = value;
				flag = (this._GridEX5 != null);
				if (flag)
				{
					this._GridEX5.RowDoubleClick += value2;
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00057D64 File Offset: 0x00055F64
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00057D7C File Offset: 0x00055F7C
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
				EventHandler value2 = new EventHandler(this.ButtonItem16_Click_1);
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00057DDC File Offset: 0x00055FDC
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00057DF4 File Offset: 0x00055FF4
		internal virtual ButtonItem ButtonItem64
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem64;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem64_Click_1);
				bool flag = this._ButtonItem64 != null;
				if (flag)
				{
					this._ButtonItem64.Click -= value2;
				}
				this._ButtonItem64 = value;
				flag = (this._ButtonItem64 != null);
				if (flag)
				{
					this._ButtonItem64.Click += value2;
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00057E54 File Offset: 0x00056054
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00057E6C File Offset: 0x0005606C
		internal virtual ButtonItem ButtonItem67
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem67;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem67_Click);
				bool flag = this._ButtonItem67 != null;
				if (flag)
				{
					this._ButtonItem67.Click -= value2;
				}
				this._ButtonItem67 = value;
				flag = (this._ButtonItem67 != null);
				if (flag)
				{
					this._ButtonItem67.Click += value2;
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00057ECC File Offset: 0x000560CC
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00057EE4 File Offset: 0x000560E4
		internal virtual ButtonItem ButtonItem68
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem68;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem68_Click);
				bool flag = this._ButtonItem68 != null;
				if (flag)
				{
					this._ButtonItem68.Click -= value2;
				}
				this._ButtonItem68 = value;
				flag = (this._ButtonItem68 != null);
				if (flag)
				{
					this._ButtonItem68.Click += value2;
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00057F44 File Offset: 0x00056144
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00057F5C File Offset: 0x0005615C
		internal virtual ButtonItem ButtonItem69
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem69;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem69_Click);
				bool flag = this._ButtonItem69 != null;
				if (flag)
				{
					this._ButtonItem69.Click -= value2;
				}
				this._ButtonItem69 = value;
				flag = (this._ButtonItem69 != null);
				if (flag)
				{
					this._ButtonItem69.Click += value2;
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00057FBC File Offset: 0x000561BC
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00002C1E File Offset: 0x00000E1E
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00057FD4 File Offset: 0x000561D4
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00002C28 File Offset: 0x00000E28
		internal virtual ButtonItem ButtonItem72
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem72;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem72 = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00057FEC File Offset: 0x000561EC
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00058004 File Offset: 0x00056204
		internal virtual ButtonItem ButtonItem23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem23_Click_1);
				bool flag = this._ButtonItem23 != null;
				if (flag)
				{
					this._ButtonItem23.Click -= value2;
				}
				this._ButtonItem23 = value;
				flag = (this._ButtonItem23 != null);
				if (flag)
				{
					this._ButtonItem23.Click += value2;
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00058064 File Offset: 0x00056264
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x0005807C File Offset: 0x0005627C
		internal virtual ButtonItem ButtonItem37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem37_Click_1);
				bool flag = this._ButtonItem37 != null;
				if (flag)
				{
					this._ButtonItem37.Click -= value2;
				}
				this._ButtonItem37 = value;
				flag = (this._ButtonItem37 != null);
				if (flag)
				{
					this._ButtonItem37.Click += value2;
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000580DC File Offset: 0x000562DC
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000580F4 File Offset: 0x000562F4
		internal virtual ButtonItem ButtonItem73
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem73;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem73_Click);
				bool flag = this._ButtonItem73 != null;
				if (flag)
				{
					this._ButtonItem73.Click -= value2;
				}
				this._ButtonItem73 = value;
				flag = (this._ButtonItem73 != null);
				if (flag)
				{
					this._ButtonItem73.Click += value2;
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00058154 File Offset: 0x00056354
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0005816C File Offset: 0x0005636C
		internal virtual ButtonItem ButtonItem74
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem74;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem74_Click);
				bool flag = this._ButtonItem74 != null;
				if (flag)
				{
					this._ButtonItem74.Click -= value2;
				}
				this._ButtonItem74 = value;
				flag = (this._ButtonItem74 != null);
				if (flag)
				{
					this._ButtonItem74.Click += value2;
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000581CC File Offset: 0x000563CC
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x000581E4 File Offset: 0x000563E4
		internal virtual ButtonItem ButtonItem75
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem75;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem75_Click);
				bool flag = this._ButtonItem75 != null;
				if (flag)
				{
					this._ButtonItem75.Click -= value2;
				}
				this._ButtonItem75 = value;
				flag = (this._ButtonItem75 != null);
				if (flag)
				{
					this._ButtonItem75.Click += value2;
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00058244 File Offset: 0x00056444
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0005825C File Offset: 0x0005645C
		internal virtual UIButton UiButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton6 != null;
				if (flag)
				{
					this._UiButton6.Click -= value2;
				}
				this._UiButton6 = value;
				flag = (this._UiButton6 != null);
				if (flag)
				{
					this._UiButton6.Click += value2;
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000582BC File Offset: 0x000564BC
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000582D4 File Offset: 0x000564D4
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00058334 File Offset: 0x00056534
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00002C32 File Offset: 0x00000E32
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0005834C File Offset: 0x0005654C
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002C3C File Offset: 0x00000E3C
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00058364 File Offset: 0x00056564
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00002C46 File Offset: 0x00000E46
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0005837C File Offset: 0x0005657C
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00058394 File Offset: 0x00056594
		internal virtual EditBox EditBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox2_TextChanged);
				bool flag = this._EditBox2 != null;
				if (flag)
				{
					this._EditBox2.TextChanged -= value2;
				}
				this._EditBox2 = value;
				flag = (this._EditBox2 != null);
				if (flag)
				{
					this._EditBox2.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000583F4 File Offset: 0x000565F4
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0005840C File Offset: 0x0005660C
		internal virtual UIButton UiButton7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton7_Click);
				bool flag = this._UiButton7 != null;
				if (flag)
				{
					this._UiButton7.Click -= value2;
				}
				this._UiButton7 = value;
				flag = (this._UiButton7 != null);
				if (flag)
				{
					this._UiButton7.Click += value2;
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0005846C File Offset: 0x0005666C
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00002C50 File Offset: 0x00000E50
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00058484 File Offset: 0x00056684
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00002C5A File Offset: 0x00000E5A
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0005849C File Offset: 0x0005669C
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000584B4 File Offset: 0x000566B4
		internal virtual EditBox EditBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox3_TextChanged);
				bool flag = this._EditBox3 != null;
				if (flag)
				{
					this._EditBox3.TextChanged -= value2;
				}
				this._EditBox3 = value;
				flag = (this._EditBox3 != null);
				if (flag)
				{
					this._EditBox3.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00058514 File Offset: 0x00056714
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0005852C File Offset: 0x0005672C
		internal virtual UIButton UiButton8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton8_Click);
				bool flag = this._UiButton8 != null;
				if (flag)
				{
					this._UiButton8.Click -= value2;
				}
				this._UiButton8 = value;
				flag = (this._UiButton8 != null);
				if (flag)
				{
					this._UiButton8.Click += value2;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0005858C File Offset: 0x0005678C
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000585A4 File Offset: 0x000567A4
		internal virtual GridEX GridEX4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX4_RowDoubleClick);
				bool flag = this._GridEX4 != null;
				if (flag)
				{
					this._GridEX4.RowDoubleClick -= value2;
				}
				this._GridEX4 = value;
				flag = (this._GridEX4 != null);
				if (flag)
				{
					this._GridEX4.RowDoubleClick += value2;
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00058604 File Offset: 0x00056804
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00002C64 File Offset: 0x00000E64
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0005861C File Offset: 0x0005681C
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00058634 File Offset: 0x00056834
		internal virtual UIButton UiButton9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton9_Click);
				bool flag = this._UiButton9 != null;
				if (flag)
				{
					this._UiButton9.Click -= value2;
				}
				this._UiButton9 = value;
				flag = (this._UiButton9 != null);
				if (flag)
				{
					this._UiButton9.Click += value2;
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00058694 File Offset: 0x00056894
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x000586AC File Offset: 0x000568AC
		internal virtual EditBox EditBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox4_TextChanged);
				bool flag = this._EditBox4 != null;
				if (flag)
				{
					this._EditBox4.TextChanged -= value2;
				}
				this._EditBox4 = value;
				flag = (this._EditBox4 != null);
				if (flag)
				{
					this._EditBox4.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0005870C File Offset: 0x0005690C
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00002C6E File Offset: 0x00000E6E
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00058724 File Offset: 0x00056924
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0005873C File Offset: 0x0005693C
		internal virtual ButtonItem ButtonItem77
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem77;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem77_Click);
				bool flag = this._ButtonItem77 != null;
				if (flag)
				{
					this._ButtonItem77.Click -= value2;
				}
				this._ButtonItem77 = value;
				flag = (this._ButtonItem77 != null);
				if (flag)
				{
					this._ButtonItem77.Click += value2;
				}
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0005879C File Offset: 0x0005699C
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x000587B4 File Offset: 0x000569B4
		internal virtual ButtonItem ButtonItem78
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem78;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem78_Click);
				bool flag = this._ButtonItem78 != null;
				if (flag)
				{
					this._ButtonItem78.Click -= value2;
				}
				this._ButtonItem78 = value;
				flag = (this._ButtonItem78 != null);
				if (flag)
				{
					this._ButtonItem78.Click += value2;
				}
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00058814 File Offset: 0x00056A14
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x0005882C File Offset: 0x00056A2C
		internal virtual ButtonItem ButtonItem79
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem79;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem79_Click);
				bool flag = this._ButtonItem79 != null;
				if (flag)
				{
					this._ButtonItem79.Click -= value2;
				}
				this._ButtonItem79 = value;
				flag = (this._ButtonItem79 != null);
				if (flag)
				{
					this._ButtonItem79.Click += value2;
				}
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0005888C File Offset: 0x00056A8C
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00002C78 File Offset: 0x00000E78
		internal virtual UIPanel uiPanel6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel6 = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000588A4 File Offset: 0x00056AA4
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00002C82 File Offset: 0x00000E82
		internal virtual UIPanelInnerContainer uiPanel6Container
		{
			[DebuggerNonUserCode]
			get
			{
				return this._uiPanel6Container;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._uiPanel6Container = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000588BC File Offset: 0x00056ABC
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00002C8C File Offset: 0x00000E8C
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000588D4 File Offset: 0x00056AD4
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00002C96 File Offset: 0x00000E96
		internal virtual GridEX GridEX6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEX6 = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000588EC File Offset: 0x00056AEC
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00002CA0 File Offset: 0x00000EA0
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00058904 File Offset: 0x00056B04
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x0005891C File Offset: 0x00056B1C
		internal virtual UIComboBox txt_database
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_database;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_database_SelectedValueChanged);
				bool flag = this._txt_database != null;
				if (flag)
				{
					this._txt_database.SelectedValueChanged -= value2;
				}
				this._txt_database = value;
				flag = (this._txt_database != null);
				if (flag)
				{
					this._txt_database.SelectedValueChanged += value2;
				}
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0005897C File Offset: 0x00056B7C
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00058994 File Offset: 0x00056B94
		internal virtual ButtonItem ButtonItem80
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem80;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem80_Click);
				bool flag = this._ButtonItem80 != null;
				if (flag)
				{
					this._ButtonItem80.Click -= value2;
				}
				this._ButtonItem80 = value;
				flag = (this._ButtonItem80 != null);
				if (flag)
				{
					this._ButtonItem80.Click += value2;
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000589F4 File Offset: 0x00056BF4
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00002CAA File Offset: 0x00000EAA
		internal virtual LabelCommand lbl_salmali
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_salmali;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_salmali = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00058A0C File Offset: 0x00056C0C
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00058A24 File Offset: 0x00056C24
		internal virtual ButtonItem ButtonItem38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem38_Click_2);
				bool flag = this._ButtonItem38 != null;
				if (flag)
				{
					this._ButtonItem38.Click -= value2;
				}
				this._ButtonItem38 = value;
				flag = (this._ButtonItem38 != null);
				if (flag)
				{
					this._ButtonItem38.Click += value2;
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00058A84 File Offset: 0x00056C84
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00058A9C File Offset: 0x00056C9C
		internal virtual ButtonItem ButtonItem81
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem81;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem81_Click);
				bool flag = this._ButtonItem81 != null;
				if (flag)
				{
					this._ButtonItem81.Click -= value2;
				}
				this._ButtonItem81 = value;
				flag = (this._ButtonItem81 != null);
				if (flag)
				{
					this._ButtonItem81.Click += value2;
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00058AFC File Offset: 0x00056CFC
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00058B14 File Offset: 0x00056D14
		internal virtual ButtonItem ButtonItem82
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem82;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem82_Click);
				bool flag = this._ButtonItem82 != null;
				if (flag)
				{
					this._ButtonItem82.Click -= value2;
				}
				this._ButtonItem82 = value;
				flag = (this._ButtonItem82 != null);
				if (flag)
				{
					this._ButtonItem82.Click += value2;
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00058B74 File Offset: 0x00056D74
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00058B8C File Offset: 0x00056D8C
		internal virtual ButtonItem ButtonItem83
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem83;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem83_Click);
				bool flag = this._ButtonItem83 != null;
				if (flag)
				{
					this._ButtonItem83.Click -= value2;
				}
				this._ButtonItem83 = value;
				flag = (this._ButtonItem83 != null);
				if (flag)
				{
					this._ButtonItem83.Click += value2;
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00058BEC File Offset: 0x00056DEC
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00058C04 File Offset: 0x00056E04
		internal virtual ButtonItem ButtonItem84
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem84;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem84_Click);
				bool flag = this._ButtonItem84 != null;
				if (flag)
				{
					this._ButtonItem84.Click -= value2;
				}
				this._ButtonItem84 = value;
				flag = (this._ButtonItem84 != null);
				if (flag)
				{
					this._ButtonItem84.Click += value2;
				}
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00058C64 File Offset: 0x00056E64
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00058C7C File Offset: 0x00056E7C
		internal virtual ButtonItem ButtonItem85
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem85;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem85_Click);
				bool flag = this._ButtonItem85 != null;
				if (flag)
				{
					this._ButtonItem85.Click -= value2;
				}
				this._ButtonItem85 = value;
				flag = (this._ButtonItem85 != null);
				if (flag)
				{
					this._ButtonItem85.Click += value2;
				}
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00058CDC File Offset: 0x00056EDC
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00058CF4 File Offset: 0x00056EF4
		internal virtual ButtonItem ButtonItem86
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem86;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem86_Click);
				bool flag = this._ButtonItem86 != null;
				if (flag)
				{
					this._ButtonItem86.Click -= value2;
				}
				this._ButtonItem86 = value;
				flag = (this._ButtonItem86 != null);
				if (flag)
				{
					this._ButtonItem86.Click += value2;
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00058D54 File Offset: 0x00056F54
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00058D6C File Offset: 0x00056F6C
		internal virtual ButtonItem ButtonItem87
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem87;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem87_Click);
				bool flag = this._ButtonItem87 != null;
				if (flag)
				{
					this._ButtonItem87.Click -= value2;
				}
				this._ButtonItem87 = value;
				flag = (this._ButtonItem87 != null);
				if (flag)
				{
					this._ButtonItem87.Click += value2;
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00058DCC File Offset: 0x00056FCC
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00058DE4 File Offset: 0x00056FE4
		internal virtual ButtonItem ButtonItem88
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem88;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem88_Click);
				bool flag = this._ButtonItem88 != null;
				if (flag)
				{
					this._ButtonItem88.Click -= value2;
				}
				this._ButtonItem88 = value;
				flag = (this._ButtonItem88 != null);
				if (flag)
				{
					this._ButtonItem88.Click += value2;
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00058E44 File Offset: 0x00057044
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00058E5C File Offset: 0x0005705C
		internal virtual ButtonItem ButtonItem89
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem89;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem89_Click);
				bool flag = this._ButtonItem89 != null;
				if (flag)
				{
					this._ButtonItem89.Click -= value2;
				}
				this._ButtonItem89 = value;
				flag = (this._ButtonItem89 != null);
				if (flag)
				{
					this._ButtonItem89.Click += value2;
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00058EBC File Offset: 0x000570BC
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00058ED4 File Offset: 0x000570D4
		internal virtual ButtonItem ButtonItem90
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem90;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem90_Click);
				bool flag = this._ButtonItem90 != null;
				if (flag)
				{
					this._ButtonItem90.Click -= value2;
				}
				this._ButtonItem90 = value;
				flag = (this._ButtonItem90 != null);
				if (flag)
				{
					this._ButtonItem90.Click += value2;
				}
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00058F34 File Offset: 0x00057134
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00058F4C File Offset: 0x0005714C
		internal virtual ButtonItem ButtonItem91
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem91;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem91_Click);
				bool flag = this._ButtonItem91 != null;
				if (flag)
				{
					this._ButtonItem91.Click -= value2;
				}
				this._ButtonItem91 = value;
				flag = (this._ButtonItem91 != null);
				if (flag)
				{
					this._ButtonItem91.Click += value2;
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00058FAC File Offset: 0x000571AC
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00058FC4 File Offset: 0x000571C4
		internal virtual ButtonItem ButtonItem92
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem92;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem92_Click);
				bool flag = this._ButtonItem92 != null;
				if (flag)
				{
					this._ButtonItem92.Click -= value2;
				}
				this._ButtonItem92 = value;
				flag = (this._ButtonItem92 != null);
				if (flag)
				{
					this._ButtonItem92.Click += value2;
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00059024 File Offset: 0x00057224
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x0005903C File Offset: 0x0005723C
		internal virtual ButtonItem ButtonItem93
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem93;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem93_Click);
				bool flag = this._ButtonItem93 != null;
				if (flag)
				{
					this._ButtonItem93.Click -= value2;
				}
				this._ButtonItem93 = value;
				flag = (this._ButtonItem93 != null);
				if (flag)
				{
					this._ButtonItem93.Click += value2;
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0005909C File Offset: 0x0005729C
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000590B4 File Offset: 0x000572B4
		internal virtual ButtonItem ButtonItem94
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem94;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem94_Click);
				bool flag = this._ButtonItem94 != null;
				if (flag)
				{
					this._ButtonItem94.Click -= value2;
				}
				this._ButtonItem94 = value;
				flag = (this._ButtonItem94 != null);
				if (flag)
				{
					this._ButtonItem94.Click += value2;
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00059114 File Offset: 0x00057314
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x0005912C File Offset: 0x0005732C
		internal virtual ButtonItem ButtonItem95
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem95;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem95_Click);
				bool flag = this._ButtonItem95 != null;
				if (flag)
				{
					this._ButtonItem95.Click -= value2;
				}
				this._ButtonItem95 = value;
				flag = (this._ButtonItem95 != null);
				if (flag)
				{
					this._ButtonItem95.Click += value2;
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0005918C File Offset: 0x0005738C
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00002CB4 File Offset: 0x00000EB4
		internal virtual LabelCommand lbl_ver
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_ver;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_ver = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000591A4 File Offset: 0x000573A4
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000591BC File Offset: 0x000573BC
		internal virtual ButtonItem ButtonItem96
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem96;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem96_Click_2);
				bool flag = this._ButtonItem96 != null;
				if (flag)
				{
					this._ButtonItem96.Click -= value2;
				}
				this._ButtonItem96 = value;
				flag = (this._ButtonItem96 != null);
				if (flag)
				{
					this._ButtonItem96.Click += value2;
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0005921C File Offset: 0x0005741C
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00059234 File Offset: 0x00057434
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
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
				bool flag = this._BackgroundWorker1 != null;
				if (flag)
				{
					this._BackgroundWorker1.DoWork -= value2;
				}
				this._BackgroundWorker1 = value;
				flag = (this._BackgroundWorker1 != null);
				if (flag)
				{
					this._BackgroundWorker1.DoWork += value2;
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00059294 File Offset: 0x00057494
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00002CBE File Offset: 0x00000EBE
		internal virtual ButtonItem ButtonItem98
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem98;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem98 = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000592AC File Offset: 0x000574AC
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x000592C4 File Offset: 0x000574C4
		internal virtual ButtonItem ButtonItem99
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem99;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ColorMenuClick);
				bool flag = this._ButtonItem99 != null;
				if (flag)
				{
					this._ButtonItem99.Click -= value2;
				}
				this._ButtonItem99 = value;
				flag = (this._ButtonItem99 != null);
				if (flag)
				{
					this._ButtonItem99.Click += value2;
				}
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00059324 File Offset: 0x00057524
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0005933C File Offset: 0x0005753C
		internal virtual ButtonItem ButtonItem100
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem100;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem100_Click);
				bool flag = this._ButtonItem100 != null;
				if (flag)
				{
					this._ButtonItem100.Click -= value2;
				}
				this._ButtonItem100 = value;
				flag = (this._ButtonItem100 != null);
				if (flag)
				{
					this._ButtonItem100.Click += value2;
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0005939C File Offset: 0x0005759C
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00002CC8 File Offset: 0x00000EC8
		internal virtual ButtonItem ButtonItem101
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem101;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem101 = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000593B4 File Offset: 0x000575B4
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x000593CC File Offset: 0x000575CC
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
				EventHandler value2 = new EventHandler(this.ButtonItem18_Click_1);
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0005942C File Offset: 0x0005762C
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00059444 File Offset: 0x00057644
		internal virtual ButtonItem txt_register
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_register;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem15_Click_1);
				bool flag = this._txt_register != null;
				if (flag)
				{
					this._txt_register.Click -= value2;
				}
				this._txt_register = value;
				flag = (this._txt_register != null);
				if (flag)
				{
					this._txt_register.Click += value2;
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000594A4 File Offset: 0x000576A4
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x000594BC File Offset: 0x000576BC
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
				EventHandler value2 = new EventHandler(this.ButtonItem15_Click_2);
				bool flag = this._ButtonItem15 != null;
				if (flag)
				{
					this._ButtonItem15.Click -= value2;
				}
				this._ButtonItem15 = value;
				flag = (this._ButtonItem15 != null);
				if (flag)
				{
					this._ButtonItem15.Click += value2;
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0005951C File Offset: 0x0005771C
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00059534 File Offset: 0x00057734
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
				EventHandler value2 = new EventHandler(this.ButtonItem19_Click_1);
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00059594 File Offset: 0x00057794
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x000595AC File Offset: 0x000577AC
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
				EventHandler value2 = new EventHandler(this.ButtonItem20_Click_1);
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0005960C File Offset: 0x0005780C
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00059624 File Offset: 0x00057824
		internal virtual ButtonItem ButtonItem21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem21_Click_3);
				bool flag = this._ButtonItem21 != null;
				if (flag)
				{
					this._ButtonItem21.Click -= value2;
				}
				this._ButtonItem21 = value;
				flag = (this._ButtonItem21 != null);
				if (flag)
				{
					this._ButtonItem21.Click += value2;
				}
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00059684 File Offset: 0x00057884
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0005969C File Offset: 0x0005789C
		internal virtual ButtonItem ButtonItem70
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem70;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem70_Click_1);
				bool flag = this._ButtonItem70 != null;
				if (flag)
				{
					this._ButtonItem70.Click -= value2;
				}
				this._ButtonItem70 = value;
				flag = (this._ButtonItem70 != null);
				if (flag)
				{
					this._ButtonItem70.Click += value2;
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x000596FC File Offset: 0x000578FC
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00059714 File Offset: 0x00057914
		internal virtual ButtonItem ButtonItem71
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem71;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem71_Click_1);
				bool flag = this._ButtonItem71 != null;
				if (flag)
				{
					this._ButtonItem71.Click -= value2;
				}
				this._ButtonItem71 = value;
				flag = (this._ButtonItem71 != null);
				if (flag)
				{
					this._ButtonItem71.Click += value2;
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00059774 File Offset: 0x00057974
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0005978C File Offset: 0x0005798C
		internal virtual ButtonItem ButtonItem76
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem76;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem76_Click_1);
				bool flag = this._ButtonItem76 != null;
				if (flag)
				{
					this._ButtonItem76.Click -= value2;
				}
				this._ButtonItem76 = value;
				flag = (this._ButtonItem76 != null);
				if (flag)
				{
					this._ButtonItem76.Click += value2;
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000597EC File Offset: 0x000579EC
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00059804 File Offset: 0x00057A04
		internal virtual ButtonItem ButtonItem97
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem97;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem97_Click_1);
				bool flag = this._ButtonItem97 != null;
				if (flag)
				{
					this._ButtonItem97.Click -= value2;
				}
				this._ButtonItem97 = value;
				flag = (this._ButtonItem97 != null);
				if (flag)
				{
					this._ButtonItem97.Click += value2;
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00059864 File Offset: 0x00057A64
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00002CD2 File Offset: 0x00000ED2
		internal virtual ButtonItem ButtonItem102
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem102;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem102 = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0005987C File Offset: 0x00057A7C
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00059894 File Offset: 0x00057A94
		internal virtual ButtonItem ButtonItem103
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem103;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem103_Click);
				bool flag = this._ButtonItem103 != null;
				if (flag)
				{
					this._ButtonItem103.Click -= value2;
				}
				this._ButtonItem103 = value;
				flag = (this._ButtonItem103 != null);
				if (flag)
				{
					this._ButtonItem103.Click += value2;
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000598F4 File Offset: 0x00057AF4
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x0005990C File Offset: 0x00057B0C
		internal virtual ButtonItem ButtonItem104
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem104;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem104_Click);
				bool flag = this._ButtonItem104 != null;
				if (flag)
				{
					this._ButtonItem104.Click -= value2;
				}
				this._ButtonItem104 = value;
				flag = (this._ButtonItem104 != null);
				if (flag)
				{
					this._ButtonItem104.Click += value2;
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0005996C File Offset: 0x00057B6C
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00059984 File Offset: 0x00057B84
		internal virtual ButtonItem ButtonItem105
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem105;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem105_Click);
				bool flag = this._ButtonItem105 != null;
				if (flag)
				{
					this._ButtonItem105.Click -= value2;
				}
				this._ButtonItem105 = value;
				flag = (this._ButtonItem105 != null);
				if (flag)
				{
					this._ButtonItem105.Click += value2;
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000599E4 File Offset: 0x00057BE4
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x000599FC File Offset: 0x00057BFC
		internal virtual ButtonItem ButtonItem106
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem106;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem106_Click);
				bool flag = this._ButtonItem106 != null;
				if (flag)
				{
					this._ButtonItem106.Click -= value2;
				}
				this._ButtonItem106 = value;
				flag = (this._ButtonItem106 != null);
				if (flag)
				{
					this._ButtonItem106.Click += value2;
				}
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00059A5C File Offset: 0x00057C5C
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00059A74 File Offset: 0x00057C74
		internal virtual ButtonItem ButtonItem107
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem107;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem107_Click);
				bool flag = this._ButtonItem107 != null;
				if (flag)
				{
					this._ButtonItem107.Click -= value2;
				}
				this._ButtonItem107 = value;
				flag = (this._ButtonItem107 != null);
				if (flag)
				{
					this._ButtonItem107.Click += value2;
				}
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00059AD4 File Offset: 0x00057CD4
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00059AEC File Offset: 0x00057CEC
		internal virtual ButtonItem ButtonItem108
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem108;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem108_Click);
				bool flag = this._ButtonItem108 != null;
				if (flag)
				{
					this._ButtonItem108.Click -= value2;
				}
				this._ButtonItem108 = value;
				flag = (this._ButtonItem108 != null);
				if (flag)
				{
					this._ButtonItem108.Click += value2;
				}
			}
		}

		// Token: 0x06000561 RID: 1377
		[DllImport("User32.dll")]
		private static extern bool GetLastInputInfo(ref Form_Main.LASTINPUTINFO Dummy);

		// Token: 0x06000562 RID: 1378
		[DllImport("Kernel32.dll")]
		private static extern uint GetLastError();

		// Token: 0x06000563 RID: 1379 RVA: 0x00059B4C File Offset: 0x00057D4C
		public void AddSticky(string text)
		{
			CtrlStickyNote ctrlStickyNote = new CtrlStickyNote();
			ctrlStickyNote.Text = text;
			this.Controls.Add(ctrlStickyNote);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00059B78 File Offset: 0x00057D78
		public void AddFilter(GridEX Grid)
		{
			bool flag = Grid.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)Grid.DataSource;
				flag = !dataTable.Columns.Contains("Filter");
				if (flag)
				{
					dataTable.Columns.Add("Filter", typeof(string));
				}
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						try
						{
							IEnumerator enumerator2 = Grid.RootTable.Columns.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GridEXColumn gridEXColumn = (GridEXColumn)enumerator2.Current;
								flag = (Operators.CompareString(gridEXColumn.DataMember, string.Empty, false) == 0);
								if (!flag)
								{
									text += dataRow[gridEXColumn.DataMember].ToString();
								}
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
						dataRow["filter"] = text;
						text = string.Empty;
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

		// Token: 0x06000565 RID: 1381 RVA: 0x0000205D File Offset: 0x0000025D
		private void Form_Close(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00059CF4 File Offset: 0x00057EF4
		private long AddVusul(DataRow row)
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@moshtari_hesabid bigint,@althesab_id bigint,@sanadbed_id bigint,@sanadbes_id bigint;";
			string tozih = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Mablagh,Tarikh_Fa) VALUES(19," + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ",NULL,NULL,", row["Mablagh"]), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())))), ");select @parent_id=scope_identity();")));
			DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id=18 and pardakhtcheck_id=", row["ID"])));
			string right = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", row["id"])
			}, null, null, null));
			tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک دریافتی از  ", row["Bank_Name"]), " به شماره "), row["Sh_Check"]), " از "), right));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=codehesab_mojodi from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
			text += sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(row["Mablagh"]), Conversions.ToString(0), Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())), tozih, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			text += sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(row["Mablagh"]), Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())), tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(20," + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ",@sanadbed_id,@sanadbes_id ," + Public_Function.GetValueInt(Conversions.ToString(dataRow["bankhesab_id"])) + ",", row["Mablagh"]), ","), Public_Function.GetValue(row["Tozih"].ToString())), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())))), ","), Public_Function.GetValue(row["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(row["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(row["Check_ShomareHesab"].ToString())), ",3,"), dataRow["PardakhtCheck_ID"]), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dataRow["PardakhtCheck_ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0005A138 File Offset: 0x00058338
		private long AddVusulSandugh(DataRow row)
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@moshtari_hesabid bigint,@althesab_id bigint,@sanadbed_id bigint,@sanadbes_id bigint;";
			string empty = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(25," + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ",NULL,NULL,1,", row["Mablagh"]), ","), Public_Function.GetValue(row["Tozih"].ToString())), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())))), ");select @parent_id=scope_identity();")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(26," + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ",NULL,NULL ,1,", row["Mablagh"]), ","), Public_Function.GetValue(row["Tozih"].ToString())), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())))), ","), Public_Function.GetValue(row["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(row["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(row["Check_ShomareHesab"].ToString())), ",3,"), Public_Function.GetValueInt(Conversions.ToString(row["ID"]))), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", row["ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0005A3D0 File Offset: 0x000585D0
		private long AddVusulPardakhti(DataRow row)
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@althesab_id bigint,@sanadbes_id bigint;";
			string tozih = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Mablagh,Tarikh_Fa) VALUES(19," + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ",NULL,NULL,", row["Mablagh"]), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())))), ");select @parent_id=scope_identity();")));
			string right = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", row["id"])
			}, null, null, null));
			tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک پرداختی به شماره ", row["Sh_Check"]), "به سررسید  "), row["Check_Sarresid_Fa"]), " به "), right));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Mojodi from bank_hesab where id=", row["CheckBank_ID"]), ";")));
			text += sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(row["Mablagh"]), Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())), tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,CheckBarg_ID,Parent_ID) VALUES(20," + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ",NULL,@sanadbes_id ," + Public_Function.GetValueInt(row["CheckBank_ID"].ToString()) + ",", row["Mablagh"]), ","), Public_Function.GetValue(row["Tozih"].ToString())), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(Conversions.ToDate(DateAndTime.Now.ToShortDateString())))), ","), Public_Function.GetValue(row["Sh_Check"].ToString())), ","), Public_Function.GetValue(row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(row["Check_ShomareHesab"].ToString())), ",3,"), row["ID"]), ","), row["checkbarg_ID"]), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", row["ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0005A758 File Offset: 0x00058958
		public void addautoVusul()
		{
			string command = string.Empty;
			bool flag = Conversions.ToBoolean(Public_Function.dict["auto_vusul_d"]);
			bool flag2;
			if (flag)
			{
				command = string.Concat(new string[]
				{
					"SELECT     t.ID, t.dpType_ID, t.Tarikh, t.SanadBed_ID, t.SanadBes_ID, t.Moshtari_ID, t.Mablagh, t.Tozih, t.Tarikh_Fa, t.Sh_Check, t.CheckBank_ID, t.Check_Shobe,  t.Check_Sarresid, t.Check_Sarresid_Fa, t.Check_Status, t.Check_ShomareHesab, t.Moshtari_Name, t.Bank_Name,  Bank_1.Name + ' ' + Bank_Hesab.Shobe + ' ' + Bank_Hesab.SahebHesab AS BankHesab_Name   FROM         (SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID,                        DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,                       DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa,                       DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,                       Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN                        Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN                        Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID  WHERE     DaryaftPardakht.dpType_ID IN (2, - 99, 42) AND DaryaftPardakht.Check_Status IN (2) AND DaryaftPardakht.Check_Sarresid = ",
					Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
					")  AS t INNER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.PardakhtCheck_ID INNER JOIN  Bank_Hesab ON DaryaftPardakht_1.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID   WHERE DaryaftPardakht_1.dpType_ID = 18  UNION ALL   SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,  DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,  DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,  DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, 'نزد صندوق' AS bankhesab_Name   FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID  WHERE     DaryaftPardakht.dpType_ID IN (2, - 99, 42) AND DaryaftPardakht.Check_Status IN (1) AND DaryaftPardakht.Check_Sarresid = ",
					Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
					"  ORDER BY t.Check_Sarresid"
				});
				DataTable dataTable = Public_Function.FillData(command);
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id=18 and pardakhtcheck_id=", dataRow["ID"])));
						flag = (dataRow2 == null);
						if (flag)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(dataRow["check_status"], 1, false);
							if (flag2)
							{
							}
						}
						else
						{
							this.AddVusul(dataRow);
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
			flag2 = Conversions.ToBoolean(Public_Function.dict["auto_vusul"]);
			if (flag2)
			{
				command = "SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, Bank_Hesab.Shobe AS Check_Shobe,   DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name + ' ' + Bank_Hesab.Shobe + '-' + Bank_Hesab.SahebHesab AS Bank_Name,   DasteCheckBarg.ID AS CheckBarg_ID, Bank_Hesab.ID AS CheckBank_ID, Hazine.Name AS Hazine_Name   FROM         DaryaftPardakht INNER JOIN   DasteCheckBarg ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID INNER JOIN   DasteCheck ON DasteCheckBarg.DasteCheck_ID = DasteCheck.ID INNER JOIN   Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID LEFT OUTER JOIN   Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     (DaryaftPardakht.dpType_ID in(11,12,-98,15)) AND (DaryaftPardakht.Check_Status in (5)) and (Check_Sarresid  =" + Public_Function.GetValue(DateAndTime.Now.ToShortDateString()) + ") order by DaryaftPardakht.Check_Sarresid";
				DataTable dataTable = Public_Function.FillData(command);
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator2.Current;
						flag2 = Operators.ConditionalCompareObjectEqual(dataRow3["dpType_ID"], -98, false);
						if (flag2)
						{
							dataRow3["Tarikh_Fa"] = "اول دوره";
						}
						flag2 = (dataRow3["Moshtari_Name"] == DBNull.Value);
						if (flag2)
						{
							dataRow3["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["Hazine_Name"]);
							flag2 = (Operators.CompareString(dataRow3["Moshtari_Name"].ToString(), string.Empty, false) == 0);
							if (flag2)
							{
								dataRow3["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["Tozih"]);
							}
						}
						this.AddVusulPardakhti(dataRow3);
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
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0005AA08 File Offset: 0x00058C08
		private void LoadUsers()
		{
			this.txt_user.Items.Clear();
			DataTable all = this.user.GetAll();
			bool flag;
			try
			{
				IEnumerator enumerator = all.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					this.txt_user.Items.Add(RuntimeHelpers.GetObjectValue(dataRow["username"]));
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
			flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = false;
				try
				{
					IEnumerator enumerator2 = this.txt_user.Items.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						UIComboBoxItem uIComboBoxItem = (UIComboBoxItem)enumerator2.Current;
						flag = (Operators.CompareString(uIComboBoxItem.Text.ToLower(), "admin", false) == 0);
						if (flag)
						{
							this.txt_user.SelectedItem = uIComboBoxItem;
							this.txt_pass.Text = Conversions.ToString(1);
							this.UiButton2.Focus();
							flag2 = true;
						}
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
				flag = !flag2;
				if (flag)
				{
					this.txt_user.Items.Add("Admin");
					this.txt_user.SelectedIndex = checked(this.txt_user.Items.Count - 1);
					this.txt_pass.Text = Conversions.ToString(1);
					this.UiButton2.Focus();
				}
			}
			flag = (this.txt_user.Items.Count == 1);
			if (flag)
			{
				this.txt_user.SelectedIndex = 0;
				this.txt_pass.Focus();
			}
			else
			{
				this.txt_user.Focus();
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0005AC20 File Offset: 0x00058E20
		private bool HasPermission(Form frm)
		{
			return this.user_conreol.Form_Permission(frm.Text);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0005AC44 File Offset: 0x00058E44
		private void SetVisible(Control ctl, string Name)
		{
			try
			{
				IEnumerator enumerator = ctl.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is Bar;
					bool flag2;
					if (flag)
					{
						try
						{
							IEnumerator enumerator2 = ((Bar)control).Items.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								ButtonItem buttonItem = (ButtonItem)enumerator2.Current;
								flag2 = (Operators.CompareString(buttonItem.Text, Name, false) == 0);
								if (flag2)
								{
									buttonItem.Visible = false;
									return;
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
					flag2 = (control is UIGroupBox);
					if (flag2)
					{
						this.SetVisible(control, Name);
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
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0005AD5C File Offset: 0x00058F5C
		private void SetPermission(Form frm)
		{
			DataTable dataTable = this.user_conreol.FormChild_Permission(frm.Text);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					this.SetVisible(frm, Conversions.ToString(dataRow["Name"]));
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

		// Token: 0x0600056E RID: 1390 RVA: 0x0005ADEC File Offset: 0x00058FEC
		private bool CheckExistanceOfForm(string title)
		{
			bool result = false;
			try
			{
				IEnumerator enumerator = this.SuperTabStrip1.Tabs.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SuperTabItem superTabItem = (SuperTabItem)enumerator.Current;
					bool flag = Operators.CompareString(superTabItem.Text, title, false) == 0;
					if (flag)
					{
						this.SuperTabStrip1.SelectedTab = superTabItem;
						result = true;
						break;
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
			try
			{
				IEnumerator enumerator2 = MyProject.Application.OpenForms.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Form form = (Form)enumerator2.Current;
					bool flag = Operators.CompareString(form.Text, title, false) == 0;
					if (flag)
					{
						form.Focus();
						form.BringToFront();
						form.Activate();
					}
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
			return result;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0005AF1C File Offset: 0x0005911C
		private void UpdateGridSize(Control ParentControl)
		{
			try
			{
				IEnumerator enumerator = ParentControl.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is GridEX;
					bool flag2;
					if (flag)
					{
						flag2 = (((GridEX)control).ParentForm is Frm_SelectItem);
						if (flag2)
						{
							this.grid_size.Update(((GridEX)control).ParentForm.Text, control.Name, ((GridEX)control).RootTable.Columns);
						}
						else
						{
							flag2 = (((GridEX)control).RootTable == null);
							if (flag2)
							{
								break;
							}
							this.grid_size.Update(((GridEX)control).ParentForm.Name, control.Name, ((GridEX)control).RootTable.Columns);
						}
					}
					flag2 = (control.Controls.Count > 0);
					if (flag2)
					{
						this.UpdateGridSize(control);
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
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0005B048 File Offset: 0x00059248
		public void Get_mande_Safi()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Hag.ID, 'فروش / ' + CAST(max(Furush_Hag.Num) AS nvarchar(10)) AS num,MAX(Baskul) as Baskul,max(Furush_Hag.Tedad_Kol) AS Tedad_Kol,max(Tarikh_Vurud) AS Tarikh_Vurud, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf,  SUM(Furush_Hag_Detail.Vazn_Kol) AS Vazn_Kol, SUM(Furush_Hag_Detail.Jam_Kol) AS Jam_Kol, max(Moshtari.Name)+' '+ max(Moshtari.Family) AS Moshtari_Name,Null as Vazn_Mande,Max(sh_mashin) as sh_mashin,1 as kind  FROM         Furush_Hag LEFT OUTER JOIN  Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  WHERE     (Furush_Hag.ID NOT IN  (SELECT     Furush_Hag_ID  FROM         Safi_Furush))  GROUP BY Furush_Hag.ID union all   SELECT     ErsalBar.ID,'ارسال بار/ '+  CAST(MAX(ErsalBar.Num) AS nvarchar(10)) AS num,max(ErsalBar_Detail.Vazn_Ba_Zarf) AS Baskul,null as Tedad_Kol,max(ErsalBar.Tarikh_Vurud) AS Tarikh_Vurud,null as tedad,null as vazn_ba_zarf,null as vazn_kol,null as jam_kol,max(Moshtari.Name)+' '+ max(Moshtari.Family) AS Moshtari_Name,null as vazn_mande, MAX(ErsalBar.Sh_Mashin) AS sh_mashin,2 as kind   FROM         ErsalBar INNER JOIN  ErsalBar_Detail ON ErsalBar.ID = ErsalBar_Detail.ErsalBar_ID INNER JOIN  Moshtari ON ErsalBar.Moshtari_ID = Moshtari.ID   where mablaghsafi Is null  group by ErsalBar.ID  order by tarikh_vurud");
			dataTable.Columns.Add("Tedad_mande", typeof(decimal));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Vazn_Ba_Zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Ba_Zarf"] = dataRow["Vazn_Ba_Zarf"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Kol"] = dataRow["Vazn_Kol"].ToString().Replace(".0", "");
					}
					flag = (dataRow["baskul"] != DBNull.Value);
					if (flag)
					{
						dataRow["baskul"] = dataRow["baskul"].ToString().Replace(".0", "");
						flag = (dataRow["Vazn_Ba_Zarf"] != DBNull.Value);
						if (flag)
						{
							dataRow["Vazn_Mande"] = Operators.SubtractObject(dataRow["baskul"], dataRow["Vazn_Ba_Zarf"]);
						}
					}
					flag = (dataRow["Jam_Kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["Jam_Kol"] = dataRow["Jam_Kol"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Tedad_Kol"] != DBNull.Value);
					if (flag)
					{
						bool flag2 = dataRow["Tedad"] != DBNull.Value;
						if (flag2)
						{
							dataRow["Tedad_Mande"] = Operators.SubtractObject(dataRow["Tedad_Kol"], dataRow["Tedad"]);
							dataRow["Tedad_Mande"] = dataRow["Tedad_Mande"].ToString().Replace(".0", "");
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
			this.GridEX5.DataSource = dataTable;
			this.AddFilter(this.GridEX5);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0005B328 File Offset: 0x00059528
		public void Get_mande_furush()
		{
			string command = "SELECT     Furush_Hag_Detail.ID, 'فروش / ' + CAST(Furush_Hag.Num AS nvarchar(10)) AS num, Furush_Hag.Num AS furush_num, Furush_Hag_Detail.Tarikh_Fa,  Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name, Kala.Name AS kala_Name, CAST(Furush_Hag_Detail.Tedad AS int) AS tedad, Moshtari_1.Name + ' ' + Moshtari_1.Family AS Saheb,1 as furush   FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID INNER JOIN  Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN  Moshtari AS Moshtari_1 ON Furush_Hag.Moshtari_ID = Moshtari_1.ID  WHERE Furush_Hag_Detail.Jam_Kol = 0   union all   SELECT     Kharid_Furush.ID, 'خرید / ' + CAST(Kharid.Num AS nvarchar(10)) AS num, Kharid.Num AS furush_num, Kharid_Furush.Tarikh_Fa, Moshtari_1.Name + ' ' + Moshtari_1.Family AS moshtari_name,  Kala.Name AS kala_name, CAST(Kharid_Furush.Tedad AS int) AS tedad,Moshtari.Name + ' ' + Moshtari.Family as saheb,0 as furush  FROM         Kharid INNER JOIN  Kharid_Furush ON Kharid.ID = Kharid_Furush.Kharid_ID INNER JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID INNER JOIN  Moshtari AS Moshtari_1 ON Kharid_Furush.Moshtari_ID = Moshtari_1.ID  where Kharid_Furush.Jam_Kol=0  union all    SELECT     DaryaftPardakht.ID, CAST('دریافت/پرداخت' AS nvarchar(100)) AS num, NULL AS furush_num, DaryaftPardakht.Tarikh_Fa AS tarikh_fa, Moshtari.Name+' '+    Moshtari.Family as moshtari_name,Tozih as kala_name,null as tedad,'' as saheb,2 as furush   FROM         DaryaftPardakht INNER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID    WHERE     (DaryaftPardakht.dpType_ID = 28) AND (DaryaftPardakht.Mablagh = 0) union all SELECT     ErsalBar_Detail.ID,'ارسال بار/ ' + CAST( ErsalBar.Num AS nvarchar(10)) as num, ErsalBar.Num as furush_num, ErsalBar_Detail.Tarikh_Fa, Moshtari.Name+' '+ Moshtari.Family AS moshtari_name, Kala.Name AS Kala_Name, ErsalBar_Detail.Tedad,null as saheb,3 as furush  FROM         ErsalBar INNER JOIN                  ErsalBar_Detail ON ErsalBar.ID = ErsalBar_Detail.ErsalBar_ID INNER JOIN                  Moshtari ON ErsalBar_Detail.Moshtari_ID = Moshtari.ID INNER JOIN                  Kala ON ErsalBar_Detail.Kala_ID = Kala.ID where ErsalBar_Detail.jam_kol=0 and ersalbar_detail.moshtari_id<> -5 UNION ALL SELECT     Kharid_Detail.ID, 'ریز خرید /' + CAST(Kharid.Num AS nvarchar(10)) AS num, Kharid.Num AS furush_num, '' AS tarikh_fa,  Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name, Kala.Name AS kala_name, CAST(Kharid_Detail.Tedad AS int) AS tedad, Moshtari_1.Name+''+ Moshtari_1.Family as saheb,4 as furush  FROM         Kharid_Detail INNER JOIN Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID INNER JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID INNER JOIN  Moshtari AS Moshtari_1 ON Kharid.Moshtari_ID = Moshtari_1.ID   WHERE   (Kharid.daramad_sanad_id is null) AND  (Kharid_Detail.Jam_Kol = 0) AND (Kharid_Detail.auto is null) union all SELECT     Furush_Sardkhane_Detail.ID, 'فروش سردخانه/ ' + CAST(Furush_Sardkhane.Num AS nvarchar(10)) AS num, Furush_Sardkhane.Num AS furush_num,  Furush_Sardkhane_Detail.Tarikh_Fa, Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name, Kala.Name AS Kala_Name, Furush_Sardkhane_Detail.Tedad,     'خرید سردخانه/ '+ cast( Kharid_Sardkhane.Num as nvarchar(10)) AS Saheb, 5 AS furush  FROM         Furush_Sardkhane_Detail INNER JOIN                   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN                   Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID INNER JOIN                   Moshtari ON Furush_Sardkhane_Detail.Moshtari_ID = Moshtari.ID INNER JOIN                   Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID     WHERE     (Furush_Sardkhane_Detail.Jam_Kol = 0)   ";
			DataTable dataTable = Public_Function.FillData(command);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["furush"], 2, false);
					if (flag)
					{
						string[] array = dataRow["kala_name"].ToString().Split(new char[]
						{
							'-'
						});
						flag = (array.Length > 0);
						if (flag)
						{
							dataRow["kala_name"] = array[0];
							flag = (Operators.CompareString(array[1], string.Empty, false) != 0);
							if (flag)
							{
								dataRow["tedad"] = array[1];
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
			Public_Function.RemoveZero(dataTable, "tedad");
			this.GridEX4.DataSource = dataTable;
			this.AddFilter(this.GridEX4);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0005B45C File Offset: 0x0005965C
		public void Get_Check_Moshtari()
		{
			DataTable dataSource = Public_Function.FillData("                                        SELECT     t.bes, t.bed, t.jam_bed, t.CodeHesab_ID, t.Moshtari_Name, Moshtari_1.ID, Moshtari_1.Name, Moshtari_1.Family, Moshtari_1.AvalDore_Tarikh,                       m.count AS Check_Count, m.mablagh AS Check_Mablagh  FROM         (SELECT     SUM(Sanad.Bes) AS bes, SUM(Sanad.Bed) AS bed, SUM(Sanad.Bed - Sanad.Bes) AS jam_bed, Sanad.CodeHesab_ID, MIN(Code_Hesab.Name)                                                AS Moshtari_Name                          FROM         Sanad INNER JOIN                                                Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN                                                Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID                          WHERE     (Code_Hesab.Grouh_ID = 2) AND (Moshtari.ID NOT IN                                                    (SELECT     Moshtari_ID                                                       FROM         Sharik)) AND (Moshtari.ID NOT IN                                                    (SELECT     Moshtari_ID                                                       FROM         Moshtari_ListSiah))                          GROUP BY Sanad.CodeHesab_ID                          HAVING      (SUM(Sanad.Bed - Sanad.Bes) = 0)) AS t INNER JOIN                        Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID INNER JOIN                            (SELECT     Moshtari_ID, COUNT(ID) AS count, SUM(Mablagh) AS mablagh                               FROM         DaryaftPardakht                               WHERE     (dpType_ID = 2) AND (Check_Status IN (1, 2)) AND (PardakhtCheck_ID IS NULL)                               GROUP BY Moshtari_ID                               HAVING      (COUNT(ID) > 0)) AS m ON Moshtari_1.ID = m.Moshtari_ID ");
			this.GridEX6.DataSource = dataSource;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0005B484 File Offset: 0x00059684
		public void Get_Sarresid()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     t.ID, t.dpType_ID, t.Tarikh, t.SanadBed_ID, t.SanadBes_ID, t.Moshtari_ID, t.Mablagh, t.Tozih, t.Tarikh_Fa, t.Sh_Check, t.CheckBank_ID, t.Check_Shobe,  t.Check_Sarresid, t.Check_Sarresid_Fa, t.Check_Status, t.Check_ShomareHesab, t.Moshtari_Name, t.Bank_Name,  Bank_1.Name + ' ' + Bank_Hesab.Shobe + ' ' + Bank_Hesab.SahebHesab AS BankHesab_Name  FROM         (SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID,        DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,        DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa,        DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,        Bank.Name AS Bank_Name        FROM         DaryaftPardakht INNER JOIN        Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN       Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID    WHERE     (DaryaftPardakht.dpType_ID IN (2, - 99,42)) AND (DaryaftPardakht.Check_Status IN (2)) AND (DaryaftPardakht.Check_Sarresid <=",
				Public_Function.GetValue(DateAndTime.Now.AddDays(Conversions.ToDouble(Public_Function.dict["sarresid_d"])).ToShortDateString()),
				"))   AS t INNER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.PardakhtCheck_ID INNER JOIN  Bank_Hesab ON DaryaftPardakht_1.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID  WHERE     (DaryaftPardakht_1.dpType_ID = 18) union all  SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,  DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,  DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,  DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name,'نزد صندوق' as bankhesab_Name   FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID  WHERE     (DaryaftPardakht.dpType_ID IN (2, - 99,42)) AND (DaryaftPardakht.Check_Status IN (1)) AND (DaryaftPardakht.Check_Sarresid <= ",
				Public_Function.GetValue(DateAndTime.Now.AddDays(Conversions.ToDouble(Public_Function.dict["sarresid_d"])).ToShortDateString()),
				")  ORDER BY Check_Sarresid"
			}));
			string iD = Public_Function.GetID(dataTable, "id", "");
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dpType_ID"], -99, false);
					if (flag)
					{
						dataRow["Tarikh_Fa"] = "اول دوره";
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
			flag = (Operators.CompareString(iD, string.Empty, false) != 0);
			if (flag)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("UPDATE daryaftpardakht SET check_status=3 WHERE id in (select pardakhtcheck_id from daryaftpardakht where pardakhtcheck_id in(" + iD + ") and check_status=3);select @@rowcount;"));
				flag = Operators.ConditionalCompareObjectGreater(objectValue, 0, false);
				if (flag)
				{
					this.Get_Sarresid();
					return;
				}
			}
			this.GridEX2.DataSource = dataTable;
			this.AddFilter(this.GridEX2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0005B640 File Offset: 0x00059840
		public void Get_sarresid_Pardakht()
		{
			string command = string.Empty;
			command = "SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, Bank_Hesab.Shobe AS Check_Shobe,   DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name + ' ' + Bank_Hesab.Shobe + '-' + Bank_Hesab.SahebHesab AS Bank_Name,   DasteCheckBarg.ID AS CheckBarg_ID, Bank_Hesab.ID AS CheckBank_ID, Hazine.Name AS Hazine_Name   FROM         DaryaftPardakht INNER JOIN   DasteCheckBarg ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID INNER JOIN   DasteCheck ON DasteCheckBarg.DasteCheck_ID = DasteCheck.ID INNER JOIN   Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID LEFT OUTER JOIN   Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     (DaryaftPardakht.dpType_ID in(11,12,-98,15)) AND (DaryaftPardakht.Check_Status in (5)) and (Check_Sarresid  <=" + Public_Function.GetValue(DateAndTime.Now.AddDays(Conversions.ToDouble(Public_Function.dict["sarresid_p"])).ToShortDateString()) + ") order by DaryaftPardakht.Check_Sarresid";
			DataTable dataTable = Public_Function.FillData(command);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dpType_ID"], -98, false);
					if (flag)
					{
						dataRow["Tarikh_Fa"] = "اول دوره";
					}
					flag = (dataRow["Moshtari_Name"] == DBNull.Value);
					if (flag)
					{
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
						flag = (Operators.CompareString(dataRow["Moshtari_Name"].ToString(), string.Empty, false) == 0);
						if (flag)
						{
							dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Tozih"]);
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
			this.GridEX3.DataSource = dataTable;
			this.AddFilter(this.GridEX3);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0005B7C4 File Offset: 0x000599C4
		private void FormDialog_Closing(object sender, FormClosingEventArgs e)
		{
			Form form = (Form)sender;
			bool flag = form is Frm_SelectItem;
			if (flag)
			{
				this.frm_size.Update(form.Text, form.Location, form.Size);
			}
			else
			{
				this.frm_size.Update(form.Name, form.Location, form.Size);
			}
			this.UpdateGridSize(form);
			flag = (form is Frm_SelectItem);
			DataRow[] array;
			if (flag)
			{
				array = Public_Function.Dt_FrmSize.Select("Name='" + form.Text + "'");
			}
			else
			{
				array = Public_Function.Dt_FrmSize.Select("Name='" + form.Name + "'");
			}
			flag = (array.Length == 0);
			if (flag)
			{
				bool flag2 = form is Frm_SelectItem;
				if (flag2)
				{
					Public_Function.Dt_FrmSize.Rows.Add(new object[]
					{
						0,
						form.Text,
						form.Top,
						form.Left,
						form.Width,
						form.Height
					});
				}
				else
				{
					Public_Function.Dt_FrmSize.Rows.Add(new object[]
					{
						0,
						form.Name,
						form.Top,
						form.Left,
						form.Width,
						form.Height
					});
				}
			}
			else
			{
				array[0]["top"] = form.Top;
				array[0]["left"] = form.Left;
				array[0]["width"] = form.Width;
				array[0]["height"] = form.Height;
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0005B9D8 File Offset: 0x00059BD8
		private void Form_Closing(object sender, FormClosingEventArgs e)
		{
			bool flag = e.Cancel;
			if (!flag)
			{
				Form form = (Form)sender;
				flag = !Conversions.ToBoolean(Public_Function.dict["showmax"]);
				if (flag)
				{
					this.frm_size.Update(form.Name, form.Location, form.Size);
					this.UpdateGridSize(form);
					DataRow[] array = Public_Function.Dt_FrmSize.Select("Name='" + form.Name + "'");
					flag = (array.Length == 0);
					if (flag)
					{
						Public_Function.Dt_FrmSize.Rows.Add(new object[]
						{
							0,
							form.Name,
							form.Top,
							form.Left,
							form.Width,
							form.Height
						});
					}
					else
					{
						array[0]["top"] = form.Top;
						array[0]["left"] = form.Left;
						array[0]["width"] = form.Width;
						array[0]["height"] = form.Height;
					}
				}
				else
				{
					this.UpdateGridSize(form);
				}
				try
				{
					IEnumerator enumerator = this.SuperTabStrip1.Tabs.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SuperTabItem superTabItem = (SuperTabItem)enumerator.Current;
						flag = (Operators.CompareString(superTabItem.Text, form.Text, false) == 0);
						if (flag)
						{
							bool flag2 = Public_Function.CurrentData.AutoClose;
							if (flag2)
							{
								this.tabclose_Flag = true;
								superTabItem.Close();
								break;
							}
							this.tabclose_Flag = true;
							superTabItem.Close();
							break;
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
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0005BC08 File Offset: 0x00059E08
		private void Form_Activate(object sender, EventArgs e)
		{
			try
			{
				IEnumerator enumerator = this.SuperTabStrip1.Tabs.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SuperTabItem superTabItem = (SuperTabItem)enumerator.Current;
					bool flag = Operators.CompareString(superTabItem.Text, ((Form)sender).Text, false) == 0;
					if (flag)
					{
						this.SuperTabStrip1.SelectedTab = superTabItem;
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

		// Token: 0x06000578 RID: 1400 RVA: 0x0005BCA0 File Offset: 0x00059EA0
		private void UpdateColumnSize(Control Parentcontrol)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = Parentcontrol.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						bool flag = control is GridEX;
						bool flag2;
						if (flag)
						{
							flag2 = (((GridEX)control).ParentForm is Frm_SelectItem);
							DataTable byName;
							if (flag2)
							{
								byName = this.grid_size.GetByName(((GridEX)control).ParentForm.Text, ((GridEX)control).Name);
							}
							else
							{
								byName = this.grid_size.GetByName(((GridEX)control).ParentForm.Name, ((GridEX)control).Name);
							}
							flag2 = (((GridEX)control).RootTable == null);
							if (flag2)
							{
								break;
							}
							flag2 = (byName.Rows.Count > 0);
							if (flag2)
							{
								try
								{
									IEnumerator enumerator2 = byName.Rows.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										DataRow dataRow = (DataRow)enumerator2.Current;
										flag = ((GridEX)control).RootTable.Columns.Contains(dataRow["key"].ToString());
										if (flag)
										{
											((GridEX)control).RootTable.Columns[dataRow["key"].ToString()].Width = Conversions.ToInteger(dataRow["width"]);
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
							else
							{
								GridEX gridEX = (GridEX)control;
								flag2 = (gridEX.RowCount > 0);
								if (flag2)
								{
									try
									{
										IEnumerator enumerator3 = gridEX.RootTable.Columns.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											GridEXColumn gridEXColumn = (GridEXColumn)enumerator3.Current;
											flag = gridEXColumn.Visible;
											if (flag)
											{
												gridEXColumn.AutoSize();
												GridEXColumn gridEXColumn2 = gridEXColumn;
												gridEXColumn2.Width += 15;
											}
										}
									}
									finally
									{
										IEnumerator enumerator3;
										flag2 = (enumerator3 is IDisposable);
										if (flag2)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
							}
						}
						flag2 = (control.Controls.Count > 0);
						if (flag2)
						{
							this.UpdateColumnSize(control);
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
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0005BF7C File Offset: 0x0005A17C
		public void ApplyFont(Control frm)
		{
			try
			{
				string left = Public_Function.dict["gridfont"].ToString().Split(new char[]
				{
					';'
				})[2];
				bool flag = Operators.CompareString(left, "regular", false) == 0;
				int style;
				if (flag)
				{
					style = 0;
				}
				else
				{
					flag = (Operators.CompareString(left, "bold", false) == 0);
					if (flag)
					{
						style = 1;
					}
					else
					{
						flag = (Operators.CompareString(left, "italic", false) == 0);
						if (flag)
						{
							style = 2;
						}
					}
				}
				Font font = new Font(Public_Function.dict["gridfont"].ToString().Split(new char[]
				{
					';'
				})[0], Conversions.ToSingle(Public_Function.dict["gridfont"].ToString().Split(new char[]
				{
					';'
				})[1]), (FontStyle)style, GraphicsUnit.Point);
				try
				{
					IEnumerator enumerator = frm.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						flag = (control is NavBox);
						if (flag)
						{
							((NavBox)control).NumericBox1.Font = font;
						}
						flag = (control is SelectItem);
						if (flag)
						{
							((SelectItem)control).Font = font;
						}
						flag = (control is EditBox);
						if (flag)
						{
							((EditBox)control).Font = font;
						}
						flag = (control is DateBox2);
						if (flag)
						{
							((DateBox2)control).Font = font;
						}
						flag = (control is GridEX);
						bool flag2;
						if (flag)
						{
							((GridEX)control).Font = font;
							int cellAscent = ((GridEX)control).Font.FontFamily.GetCellAscent(FontStyle.Regular);
							decimal d = new decimal(this.Font.Size * (float)cellAscent / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
							int cellDescent = ((GridEX)control).Font.FontFamily.GetCellDescent(FontStyle.Regular);
							decimal d2 = new decimal(this.Font.Size * (float)cellDescent / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
							int lineSpacing = ((GridEX)control).Font.FontFamily.GetLineSpacing(FontStyle.Regular);
							decimal d3 = new decimal(this.Font.Size * (float)lineSpacing / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
							flag = (((GridEX)control).RootTable != null);
							if (flag)
							{
								flag2 = (decimal.Compare(new decimal(((GridEX)control).RootTable.RowHeight), decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(d, d2), d2), d2), d3), new decimal(2L))) < 0);
								if (flag2)
								{
									((GridEX)control).RootTable.RowHeight = Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(d, d2), d2), d2), d3), new decimal(2L)));
								}
							}
						}
						flag2 = (frm.Controls.Count > 0);
						if (flag2)
						{
							this.ApplyFont(control);
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
			}
			catch (Exception expr_373)
			{
				ProjectData.SetProjectError(expr_373);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0005C344 File Offset: 0x0005A544
		public void ApplyTheme(Control frm)
		{
			bool flag = frm is Frm_Coloring;
			if (!flag)
			{
				flag = (this.dr_theme == null);
				if (flag)
				{
					try
					{
						IEnumerator enumerator = frm.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							bool flag2 = control is GridEX;
							if (flag2)
							{
								((GridEX)control).TotalRowFormatStyle.BackColor = Color.AliceBlue;
								((GridEX)control).TotalRowFormatStyle.BackColorGradient = Color.DarkTurquoise;
								((GridEX)control).TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
							}
							flag2 = (frm.Controls.Count > 0);
							if (flag2)
							{
								this.ApplyTheme(control);
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
				}
				else
				{
					try
					{
						IEnumerator enumerator2 = frm.Controls.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Control control2 = (Control)enumerator2.Current;
							bool flag2 = control2 is Bar;
							if (flag2)
							{
								flag = (this.dr_theme["toolbarBackground"] != DBNull.Value);
								if (flag)
								{
									control2.BackColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["toolbarBackground"]));
								}
							}
							flag2 = (control2 is UIGroupBox);
							if (flag2)
							{
								flag = (this.dr_theme["Background"] != DBNull.Value);
								if (flag)
								{
									((UIGroupBox)control2).BackgroundStyle = BackgroundStyle.Default;
									((UIGroupBox)control2).BackColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["Background"]));
								}
							}
							flag2 = (control2 is UIButton);
							if (flag2)
							{
								flag = (this.dr_theme["ButtonBackground"] != DBNull.Value);
								if (flag)
								{
									((UIButton)control2).OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
									((UIButton)control2).OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
								}
							}
							flag2 = (control2 is NavBox);
							if (flag2)
							{
								flag = (this.dr_theme["ButtonBackground"] != DBNull.Value);
								if (flag)
								{
									control2.BackColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
									((NavBox)control2).UiButton1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
									((NavBox)control2).UiButton2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
									((NavBox)control2).UiButton3.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
									((NavBox)control2).UiButton4.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
									((NavBox)control2).UiButton1.OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
									((NavBox)control2).UiButton2.OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
									((NavBox)control2).UiButton3.OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
									((NavBox)control2).UiButton4.OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
								}
							}
							flag2 = (control2 is SelectItem);
							if (flag2)
							{
								flag = (this.dr_theme["ButtonBackground"] != DBNull.Value);
								if (flag)
								{
									((SelectItem)control2).OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom;
									((SelectItem)control2).OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
								}
							}
							flag2 = (control2 is EditBox);
							if (flag2)
							{
								flag = (this.dr_theme["ButtonBackground"] != DBNull.Value);
								if (flag)
								{
									((EditBox)control2).OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom;
									((EditBox)control2).OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
								}
							}
							flag2 = (control2 is DateBox2);
							if (flag2)
							{
								flag = (this.dr_theme["ButtonBackground"] != DBNull.Value);
								if (flag)
								{
									((DateBox2)control2).OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom;
									((DateBox2)control2).OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["ButtonBackground"]));
								}
							}
							flag2 = (control2 is GridEX);
							if (flag2)
							{
								((GridEX)control2).TotalRowFormatStyle.BackColor = Color.AliceBlue;
								((GridEX)control2).TotalRowFormatStyle.BackColorGradient = Color.DarkTurquoise;
								((GridEX)control2).TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
								flag2 = (this.dr_theme["GridColor"] != DBNull.Value);
								if (flag2)
								{
									((GridEX)control2).OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom;
									((GridEX)control2).OfficeCustomColor = Color.FromArgb(Conversions.ToInteger(this.dr_theme["GridColor"]));
									((GridEX)control2).TotalRowFormatStyle.BackColor = Color.AliceBlue;
									((GridEX)control2).TotalRowFormatStyle.BackColorGradient = Color.DarkTurquoise;
									((GridEX)control2).TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
								}
							}
							flag2 = (frm.Controls.Count > 0);
							if (flag2)
							{
								this.ApplyTheme(control2);
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
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0005C958 File Offset: 0x0005AB58
		private void Form_Load(object sender, EventArgs e)
		{
			this.UpdateColumnSize((Control)sender);
			this.ApplyFont((Control)sender);
			bool flag = Conversions.ToDouble(Public_Function.dict["theme"]) != -1.0;
			if (flag)
			{
				this.ApplyTheme((Control)sender);
			}
			else
			{
				this.ApplyTheme((Control)sender);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0005C9C8 File Offset: 0x0005ABC8
		public DialogResult Dialog_ShowForm(Form ShowFrm)
		{
			ShowFrm.FormClosing += new FormClosingEventHandler(this.FormDialog_Closing);
			ShowFrm.Load += new EventHandler(this.Form_Load);
			bool flag = ShowFrm is Frm_SelectItem;
			DataRow[] array;
			if (flag)
			{
				array = Public_Function.Dt_FrmSize.Select("name='" + ShowFrm.Text + "'");
			}
			else
			{
				array = Public_Function.Dt_FrmSize.Select("name='" + ShowFrm.Name + "'");
			}
			flag = (array.Length == 0);
			checked
			{
				if (flag)
				{
					ShowFrm.StartPosition = FormStartPosition.CenterScreen;
					flag = (ShowFrm.Width > this.Width);
					if (flag)
					{
						ShowFrm.Width = this.Width - 100;
					}
					flag = (ShowFrm.Height > this.Height);
					if (flag)
					{
						ShowFrm.Height = this.Height - 100;
					}
				}
				else
				{
					flag = (Operators.ConditionalCompareObjectEqual(array[0]["width"], 150, false) && Operators.ConditionalCompareObjectEqual(array[0]["height"], 150, false));
					if (flag)
					{
						ShowFrm.StartPosition = FormStartPosition.CenterScreen;
					}
					flag = Operators.ConditionalCompareObjectNotEqual(array[0]["width"], 150, false);
					if (flag)
					{
						ShowFrm.Width = Conversions.ToInteger(array[0]["Width"]);
					}
					flag = Operators.ConditionalCompareObjectNotEqual(array[0]["height"], 150, false);
					if (flag)
					{
						ShowFrm.Height = Conversions.ToInteger(array[0]["Height"]);
					}
				}
				return ShowFrm.ShowDialog();
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0005CB80 File Offset: 0x0005AD80
		public void ShowForm(Form ShowFrm)
		{
			bool flag = !this.CheckExistanceOfForm(ShowFrm.Text);
			checked
			{
				if (flag)
				{
					ShowFrm.FormClosing += new FormClosingEventHandler(this.Form_Closing);
					ShowFrm.Activated += new EventHandler(this.Form_Activate);
					ShowFrm.Load += new EventHandler(this.Form_Load);
					ShowFrm.MdiParent = this;
					flag = (ShowFrm.FormBorderStyle != FormBorderStyle.FixedSingle);
					if (flag)
					{
						DataRow[] array = Public_Function.Dt_FrmSize.Select("name='" + ShowFrm.Name + "'");
						flag = (array.Length == 0);
						if (flag)
						{
							ShowFrm.StartPosition = FormStartPosition.CenterScreen;
						}
						else
						{
							ShowFrm.StartPosition = FormStartPosition.Manual;
							ShowFrm.Left = Conversions.ToInteger(array[0]["Left"]);
							ShowFrm.Top = Conversions.ToInteger(array[0]["Top"]);
							ShowFrm.Width = Conversions.ToInteger(array[0]["Width"]);
							ShowFrm.Height = Conversions.ToInteger(array[0]["Height"]);
						}
					}
					else
					{
						ShowFrm.StartPosition = FormStartPosition.CenterScreen;
					}
					ShowFrm.WindowState = FormWindowState.Normal;
					Size clientSize = this.ClientSize;
					flag = (ShowFrm.Height > clientSize.Height);
					if (flag)
					{
						ShowFrm.Height = clientSize.Height - this.Bar1.Height - this.SuperTabStrip1.Height - this.RibbonStatusBar1.Height - 30;
						ShowFrm.Top = 4;
						ShowFrm.StartPosition = FormStartPosition.Manual;
					}
					flag = (ShowFrm.Width > clientSize.Width);
					if (flag)
					{
						ShowFrm.StartPosition = FormStartPosition.Manual;
						ShowFrm.Width = clientSize.Width - 15;
						ShowFrm.Left = 0;
					}
					ShowFrm.KeyPreview = true;
					SuperTabItem superTabItem = new SuperTabItem();
					ShowFrm.Show();
					ShowFrm.WindowState = FormWindowState.Normal;
					superTabItem.Text = ShowFrm.Text;
					this.SuperTabStrip1.Tabs.Add(superTabItem);
					this.SuperTabStrip1.SelectedTab = superTabItem;
					ShowFrm.BringToFront();
					ShowFrm.Focus();
					ShowFrm.Activate();
					flag = Conversions.ToBoolean(Public_Function.dict["showmax"]);
					if (flag)
					{
						ShowFrm.FormBorderStyle = FormBorderStyle.None;
						ShowFrm.WindowState = FormWindowState.Maximized;
					}
				}
				else
				{
					ShowFrm.Dispose();
				}
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0005CDDC File Offset: 0x0005AFDC
		public void AddForm(Form frm)
		{
			bool flag = frm.IsDisposed;
			checked
			{
				if (!flag)
				{
					flag = !this.HasPermission(frm);
					if (flag)
					{
						frm.Dispose();
						Public_Function.ShowMessage("کاربر گرامی ؛ امکان دسترسی به این مکان را ندارید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					}
					else
					{
						this.PanelEx2.Visible = true;
						this.PanelEx2.Refresh();
						flag = Public_Function.CurrentData.Tabbed;
						if (flag)
						{
							bool flag2;
							try
							{
								IEnumerator enumerator = this.SuperTabControl1.Tabs.GetEnumerator();
								while (enumerator.MoveNext())
								{
									SuperTabItem superTabItem = (SuperTabItem)enumerator.Current;
									flag2 = (Operators.CompareString(superTabItem.Text, frm.Text, false) == 0);
									if (flag2)
									{
										this.SuperTabControl1.SelectedTab = superTabItem;
										frm.Dispose();
										return;
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
							SuperTabItem superTabItem2 = new SuperTabItem();
							superTabItem2.Text = frm.Text;
							SuperTabControlPanel superTabControlPanel = new SuperTabControlPanel();
							superTabControlPanel.Dock = DockStyle.Fill;
							Control arg_126_0 = superTabControlPanel;
							Point location = new Point(0, 24);
							arg_126_0.Location = location;
							Control arg_141_0 = superTabControlPanel;
							Size size = new Size(1010, 331);
							arg_141_0.Size = size;
							superTabItem2.AttachedControl = superTabControlPanel;
							superTabControlPanel.TabItem = superTabItem2;
							this.SuperTabControl1.Controls.Add(superTabControlPanel);
							this.SuperTabControl1.Tabs.Add(superTabItem2);
							this.SuperTabControl1.ApplyPanelStyle(superTabControlPanel);
							frm.MdiParent = this;
							frm.FormBorderStyle = FormBorderStyle.None;
							frm.WindowState = FormWindowState.Maximized;
							superTabControlPanel.Controls.Add(frm);
							Size size2 = superTabControlPanel.Size;
							flag2 = (frm.Height > size2.Height);
							if (flag2)
							{
								frm.Height = size2.Height - 35;
							}
							location = new Point((int)Math.Round((double)(superTabControlPanel.Width - frm.Width) / 2.0), 35);
							frm.Location = location;
							superTabControlPanel.Resize += new EventHandler(this.Panel_Resize);
							this.SuperTabControl1.SelectedTab = superTabItem2;
							frm.Show();
						}
						else
						{
							this.ShowForm(frm);
						}
						this.SetPermission(frm);
						this.PanelEx2.Visible = false;
					}
				}
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0005D050 File Offset: 0x0005B250
		private void Panel_Resize(object sender, EventArgs e)
		{
			SuperTabControlPanel superTabControlPanel = (SuperTabControlPanel)sender;
			bool flag = superTabControlPanel.Tag != null && Operators.ConditionalCompareObjectEqual(superTabControlPanel.Tag, "max", false);
			checked
			{
				if (flag)
				{
					Size size = superTabControlPanel.Size;
					Form form = (Form)superTabControlPanel.Controls[0];
					size.Width -= 20;
					size.Height -= 15;
					form.Size = size;
					Form arg_9D_0 = form;
					Point location = new Point((int)Math.Round((double)(superTabControlPanel.Width - form.Width) / 2.0), 5);
					arg_9D_0.Location = location;
				}
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0005D104 File Offset: 0x0005B304
		private void ButtonBar1_ItemClick(object sender, ItemEventArgs e)
		{
			string key = e.Item.Key;
			Form form;
			bool flag = form == null;
			if (!flag)
			{
				this.AddForm(form);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000205D File Offset: 0x0000025D
		private void DrawBackground(Control e)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0005D134 File Offset: 0x0005B334
		private void painting(object sender, PaintEventArgs e)
		{
			bool flag = this.bmp == null;
			if (flag)
			{
				Point point = new Point(0, 0);
				Point point2 = new Point(0, ((Control)sender).Height);
				LinearGradientBrush brush = new LinearGradientBrush(point, point2, Color.FromArgb(239, 246, 253), Color.FromArgb(216, 228, 242));
				Pen pen = new Pen(brush);
				e.Graphics.FillRectangle(brush, 0, 0, ((Control)sender).Width, ((Control)sender).Height);
			}
			else
			{
				Graphics arg_BB_0 = e.Graphics;
				Image arg_BB_1 = this.bmp;
				Rectangle rect = new Rectangle(0, 0, ((Control)sender).Width, ((Control)sender).Height);
				arg_BB_0.DrawImage(arg_BB_1, rect);
				this.Paint_Text((Control)sender, e);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0005D214 File Offset: 0x0005B414
		private void PaintMdiBackground()
		{
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is MdiClient;
					if (flag)
					{
						control.Paint += new PaintEventHandler(this.painting);
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

		// Token: 0x06000584 RID: 1412 RVA: 0x0005D29C File Offset: 0x0005B49C
		private void _btn_subsub_Click(object sender, EventArgs e)
		{
			string text = ((Control)sender).Text;
			int num = 20;
			checked
			{
				try
				{
					IEnumerator enumerator = this.Bar1.Items[this.frm_menu.Main_Menu_Index].SubItems[this.frm_menu.sub_menu_index].SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag = Operators.CompareString(baseItem.Text, text, false) == 0;
						if (flag)
						{
							this.frm_menu.UiGroupBox4.Controls.Clear();
							flag = (baseItem.SubItems.Count == 0);
							if (flag)
							{
								baseItem.RaiseClick();
								break;
							}
							try
							{
								IEnumerator enumerator2 = baseItem.SubItems.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									BaseItem baseItem2 = (BaseItem)enumerator2.Current;
									UIButton uIButton = new UIButton();
									Control arg_E9_0 = uIButton;
									Size size = new Size(162, 40);
									arg_E9_0.Size = size;
									uIButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
									this.frm_menu.UiGroupBox4.Controls.Add(uIButton);
									Control arg_11D_0 = uIButton;
									Point location = new Point(10, num);
									arg_11D_0.Location = location;
									uIButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
									uIButton.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
									uIButton.Text = baseItem2.Text;
									num += 50;
									uIButton.Click += new EventHandler(this._btn_sub_Click);
									uIButton.PreviewKeyDown += new PreviewKeyDownEventHandler(this._btn_keydown);
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

		// Token: 0x06000585 RID: 1413 RVA: 0x0005D4BC File Offset: 0x0005B6BC
		private void _btn_sub_Click(object sender, EventArgs e)
		{
			string text = ((Control)sender).Text;
			this.frm_menu.sub_menu_index = Conversions.ToInteger(((Control)sender).Tag);
			int num = 20;
			checked
			{
				try
				{
					IEnumerator enumerator = this.Bar1.Items[this.frm_menu.Main_Menu_Index].SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag = Operators.CompareString(baseItem.Text, text, false) == 0;
						if (flag)
						{
							this.frm_menu.UiGroupBox4.Controls.Clear();
							flag = (baseItem.SubItems.Count == 0);
							if (flag)
							{
								baseItem.RaiseClick();
								break;
							}
							try
							{
								IEnumerator enumerator2 = baseItem.SubItems.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									BaseItem baseItem2 = (BaseItem)enumerator2.Current;
									UIButton uIButton = new UIButton();
									Control arg_F0_0 = uIButton;
									Size size = new Size(250, 40);
									arg_F0_0.Size = size;
									uIButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
									this.frm_menu.UiGroupBox4.Controls.Add(uIButton);
									Control arg_123_0 = uIButton;
									Point location = new Point(0, num);
									arg_123_0.Location = location;
									uIButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
									uIButton.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
									uIButton.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
									uIButton.Text = baseItem2.Text;
									num += 50;
									uIButton.Click += new EventHandler(this._btn_subsub_Click);
									uIButton.PreviewKeyDown += new PreviewKeyDownEventHandler(this._btn_keydown);
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
							this.frm_menu.UiGroupBox4.Focus();
							this.frm_menu.UiGroupBox4.Controls[0].Focus();
							this.frm_menu.Group_Index = 2;
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

		// Token: 0x06000586 RID: 1414 RVA: 0x0005D724 File Offset: 0x0005B924
		private void _btn_Click(object sender, EventArgs e)
		{
			string text = ((Control)sender).Text;
			this.frm_menu.Main_Menu_Index = Conversions.ToInteger(((Control)sender).Tag);
			int num = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = this.Bar1.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag = Operators.CompareString(baseItem.Text, text, false) == 0;
						if (flag)
						{
							int num2 = 20;
							this.frm_menu.UiGroupBox3.Controls.Clear();
							this.frm_menu.UiGroupBox4.Controls.Clear();
							flag = (baseItem.SubItems.Count == 0);
							if (flag)
							{
								baseItem.RaiseClick();
								break;
							}
							try
							{
								IEnumerator enumerator2 = baseItem.SubItems.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									BaseItem baseItem2 = (BaseItem)enumerator2.Current;
									flag = !baseItem2.Visible;
									if (!flag)
									{
										UIButton uIButton = new UIButton();
										uIButton.Tag = num;
										num++;
										Control arg_11D_0 = uIButton;
										Size size = new Size(162, 40);
										arg_11D_0.Size = size;
										uIButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
										this.frm_menu.UiGroupBox3.Controls.Add(uIButton);
										Control arg_154_0 = uIButton;
										Point location = new Point(10, num2);
										arg_154_0.Location = location;
										uIButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
										uIButton.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
										uIButton.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
										uIButton.Text = baseItem2.Text;
										num2 += 50;
										uIButton.Click += new EventHandler(this._btn_sub_Click);
										uIButton.PreviewKeyDown += new PreviewKeyDownEventHandler(this._btn_keydown);
									}
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
							this.frm_menu.UiGroupBox3.Focus();
							this.frm_menu.UiGroupBox3.Controls[0].Focus();
							this.frm_menu.Group_Index = 1;
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

		// Token: 0x06000587 RID: 1415 RVA: 0x0005D9C0 File Offset: 0x0005BBC0
		private void _btn_keydown(object sender, PreviewKeyDownEventArgs e)
		{
			checked
			{
				switch (e.KeyCode)
				{
				case Keys.Left:
				{
					Frm_Menu frm_Menu = this.frm_menu;
					frm_Menu.Group_Index++;
					bool flag = this.frm_menu.Group_Index == 3;
					if (flag)
					{
						this.frm_menu.Group_Index = 0;
					}
					switch (this.frm_menu.Group_Index)
					{
					case 0:
						this.frm_menu.UiGroupBox2.Focus();
						flag = (this.frm_menu.UiGroupBox2.Controls.Count > 0);
						if (flag)
						{
							this.frm_menu.UiGroupBox2.Controls[0].Focus();
						}
						break;
					case 1:
						this.frm_menu.UiGroupBox3.Focus();
						flag = (this.frm_menu.UiGroupBox3.Controls.Count > 0);
						if (flag)
						{
							this.frm_menu.UiGroupBox3.Controls[1].Focus();
						}
						break;
					case 2:
						this.frm_menu.UiGroupBox4.Focus();
						flag = (this.frm_menu.UiGroupBox4.Controls.Count > 0);
						if (flag)
						{
							this.frm_menu.UiGroupBox4.Controls[1].Focus();
						}
						break;
					}
					break;
				}
				case Keys.Right:
				{
					Frm_Menu frm_Menu = this.frm_menu;
					frm_Menu.Group_Index--;
					bool flag = this.frm_menu.Group_Index == -1;
					if (flag)
					{
						this.frm_menu.Group_Index = 0;
					}
					switch (this.frm_menu.Group_Index)
					{
					case 0:
					{
						int num = this.frm_menu.Main_Menu_Index - 1;
						flag = (num == -1);
						if (flag)
						{
							num = 7;
						}
						this.frm_menu.UiGroupBox2.Focus();
						flag = (this.frm_menu.UiGroupBox2.Controls.Count > 0);
						if (flag)
						{
							this.frm_menu.UiGroupBox2.Controls[num].Focus();
						}
						break;
					}
					case 1:
					{
						int num2 = this.frm_menu.sub_menu_index - 1;
						flag = (num2 == -1);
						if (flag)
						{
							num2 = this.frm_menu.UiGroupBox3.Controls.Count - 1;
						}
						this.frm_menu.UiGroupBox3.Focus();
						flag = (this.frm_menu.UiGroupBox3.Controls.Count > 0);
						if (flag)
						{
							this.frm_menu.UiGroupBox3.Controls[num2].Focus();
						}
						break;
					}
					case 2:
						this.frm_menu.UiGroupBox4.Focus();
						flag = (this.frm_menu.UiGroupBox4.Controls.Count > 0);
						if (flag)
						{
							this.frm_menu.UiGroupBox4.Controls[0].Focus();
						}
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0005DCE0 File Offset: 0x0005BEE0
		private void _btn_focus(object sender, EventArgs e)
		{
			UIButton uIButton = (UIButton)sender;
			uIButton.Image = Resources.item_enable;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0005DD04 File Offset: 0x0005BF04
		private void _btn_lost_focus(object sender, EventArgs e)
		{
			UIButton uIButton = (UIButton)sender;
			uIButton.Image = null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0005DD24 File Offset: 0x0005BF24
		private void CreateFrm_Menu_Items()
		{
			this.frm_menu.UiGroupBox2.Controls.Clear();
			int num = 20;
			int num2 = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = this.Bar1.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag = baseItem is LabelItem;
						if (!flag)
						{
							flag = !baseItem.Visible;
							if (!flag)
							{
								UIButton uIButton = new UIButton();
								Control arg_83_0 = uIButton;
								Size size = new Size(160, 40);
								arg_83_0.Size = size;
								UIButton arg_98_0 = uIButton;
								size = new Size(16, 16);
								arg_98_0.ImageSize = size;
								uIButton.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
								uIButton.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
								uIButton.Tag = num2;
								num2++;
								uIButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
								this.frm_menu.UiGroupBox2.Controls.Add(uIButton);
								Control arg_ED_0 = uIButton;
								Point location = new Point(10, num);
								arg_ED_0.Location = location;
								uIButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
								uIButton.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
								uIButton.Text = baseItem.Text;
								uIButton.Click += new EventHandler(this._btn_Click);
								uIButton.PreviewKeyDown += new PreviewKeyDownEventHandler(this._btn_keydown);
								num += 50;
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

		// Token: 0x0600058B RID: 1419 RVA: 0x0005DEC4 File Offset: 0x0005C0C4
		private void SetMainMenupermissions()
		{
			DataTable dataTable = this.user_conreol.Main_Permission();
			try
			{
				IEnumerator enumerator = this.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					baseItem.Visible = true;
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
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator2.Current;
					bool flag;
					try
					{
						IEnumerator enumerator3 = this.Bar1.Items.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							BaseItem baseItem2 = (BaseItem)enumerator3.Current;
							flag = (baseItem2 is LabelItem);
							if (!flag)
							{
								flag = Operators.ConditionalCompareObjectEqual(baseItem2.Text, dataRow["Name"], false);
								if (flag)
								{
									baseItem2.Visible = false;
									break;
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator3;
						flag = (enumerator3 is IDisposable);
						if (flag)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["name"], "سربرگ ها", false);
					if (flag)
					{
						try
						{
							IEnumerator enumerator4 = ((IEnumerable)this.UiPanelManager1.Panels).GetEnumerator();
							while (enumerator4.MoveNext())
							{
								UIPanel uIPanel = (UIPanel)enumerator4.Current;
								uIPanel.Closed = true;
							}
						}
						finally
						{
							IEnumerator enumerator4;
							flag = (enumerator4 is IDisposable);
							if (flag)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
					}
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
			this.Bar1.Refresh();
			this.Bar1.Update();
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0005E11C File Offset: 0x0005C31C
		private void SetSubMenuPermissions()
		{
			DataTable dataTable = this.user_conreol.MenuPermissions();
			try
			{
				IEnumerator enumerator = this.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag = baseItem is LabelItem;
					if (!flag)
					{
						try
						{
							IEnumerator enumerator2 = baseItem.SubItems.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								BaseItem baseItem2 = (BaseItem)enumerator2.Current;
								baseItem2.Visible = true;
								try
								{
									IEnumerator enumerator3 = baseItem2.SubItems.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										BaseItem baseItem3 = (BaseItem)enumerator3.Current;
										baseItem3.Visible = true;
									}
								}
								finally
								{
									IEnumerator enumerator3;
									flag = (enumerator3 is IDisposable);
									if (flag)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
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
			DataRow[] array = dataTable.Select("parent_id=-1");
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					try
					{
						IEnumerator enumerator4 = ((IEnumerable)this.UiPanelManager1.Panels).GetEnumerator();
						while (enumerator4.MoveNext())
						{
							UIPanel uIPanel = (UIPanel)enumerator4.Current;
							bool flag = Operators.ConditionalCompareObjectEqual(dataRow["name"], uIPanel.Text, false);
							if (flag)
							{
								uIPanel.Closed = true;
							}
						}
					}
					finally
					{
						IEnumerator enumerator4;
						bool flag = enumerator4 is IDisposable;
						if (flag)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
				try
				{
					IEnumerator enumerator5 = this.Bar1.Items.GetEnumerator();
					while (enumerator5.MoveNext())
					{
						BaseItem baseItem4 = (BaseItem)enumerator5.Current;
						bool flag = baseItem4 is LabelItem;
						if (!flag)
						{
							array = dataTable.Select("MainMenuName='" + baseItem4.Text + "'");
							DataRow[] array3 = array;
							for (int j = 0; j < array3.Length; j++)
							{
								DataRow dataRow2 = array3[j];
								try
								{
									IEnumerator enumerator6 = baseItem4.SubItems.GetEnumerator();
									while (enumerator6.MoveNext())
									{
										BaseItem baseItem5 = (BaseItem)enumerator6.Current;
										flag = Operators.ConditionalCompareObjectEqual(baseItem5.Text, dataRow2["Name"], false);
										if (flag)
										{
											baseItem5.Visible = false;
										}
										try
										{
											IEnumerator enumerator7 = baseItem5.SubItems.GetEnumerator();
											while (enumerator7.MoveNext())
											{
												BaseItem baseItem6 = (BaseItem)enumerator7.Current;
												flag = Operators.ConditionalCompareObjectEqual(baseItem6.Text, dataRow2["Name"], false);
												if (flag)
												{
													baseItem6.Visible = false;
												}
											}
										}
										finally
										{
											IEnumerator enumerator7;
											flag = (enumerator7 is IDisposable);
											if (flag)
											{
												(enumerator7 as IDisposable).Dispose();
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator6;
									flag = (enumerator6 is IDisposable);
									if (flag)
									{
										(enumerator6 as IDisposable).Dispose();
									}
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator5;
					bool flag = enumerator5 is IDisposable;
					if (flag)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0005E570 File Offset: 0x0005C770
		private void Load_SubsubMenu(BaseItem menu, int id)
		{
			DataTable dataTable = Public_Function.FillData("select * from Menu_Sort where parent_id =" + Conversions.ToString(id) + " order by [order]");
			int num = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num2 = 0;
						try
						{
							IEnumerator enumerator2 = menu.SubItems.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								BaseItem baseItem = (BaseItem)enumerator2.Current;
								bool flag = !(baseItem is ButtonItem);
								if (!flag)
								{
									flag = Operators.ConditionalCompareObjectEqual(baseItem.Text, dataRow["name"], false);
									if (flag)
									{
										ButtonItem item = (ButtonItem)baseItem;
										menu.SubItems.RemoveAt(num2);
										menu.SubItems.Insert(num, item);
										num++;
										break;
									}
									num2++;
								}
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

		// Token: 0x0600058E RID: 1422 RVA: 0x0005E6C8 File Offset: 0x0005C8C8
		private void Load_SubMenu(BaseItem menu, int id)
		{
			DataTable dataTable = Public_Function.FillData("select * from Menu_Sort where parent_id =" + Conversions.ToString(id) + " order by [order]");
			int num = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num2 = 0;
						try
						{
							IEnumerator enumerator2 = menu.SubItems.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								BaseItem baseItem = (BaseItem)enumerator2.Current;
								bool flag = !(baseItem is ButtonItem);
								if (!flag)
								{
									flag = Operators.ConditionalCompareObjectEqual(baseItem.Text, dataRow["name"], false);
									if (flag)
									{
										ButtonItem buttonItem = (ButtonItem)baseItem;
										menu.SubItems.RemoveAt(num2);
										menu.SubItems.Insert(num, buttonItem);
										this.Load_SubsubMenu(buttonItem, Conversions.ToInteger(dataRow["ID"]));
										num++;
										break;
									}
									num2++;
								}
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

		// Token: 0x0600058F RID: 1423 RVA: 0x0005E854 File Offset: 0x0005CA54
		public void Load_Root_Menu()
		{
			DataTable dataTable = Public_Function.FillData("select * from Menu_Sort where parent_id is null order by [order]");
			int num = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num2 = 0;
						try
						{
							IEnumerator enumerator2 = this.Bar1.Items.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								BaseItem baseItem = (BaseItem)enumerator2.Current;
								bool flag = Operators.ConditionalCompareObjectEqual(baseItem.Text, dataRow["name"], false);
								if (flag)
								{
									ButtonItem item = (ButtonItem)baseItem;
									this.Bar1.Items.RemoveAt(num2);
									this.Bar1.Items.Insert(num, item);
									num++;
									this.Load_SubMenu(baseItem, Conversions.ToInteger(dataRow["ID"]));
									break;
								}
								num2++;
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

		// Token: 0x06000590 RID: 1424 RVA: 0x0005E9CC File Offset: 0x0005CBCC
		private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			bool flag = Public_Function.dict.ContainsKey("backuppath");
			if (flag)
			{
				text = Public_Function.dict["backuppath"];
				flag = (Public_Function.dict.ContainsKey("backup_category") && Conversions.ToBoolean(Public_Function.dict["backup_category"]));
				if (flag)
				{
					text2 = Public_Function.MiladiToShamsi(DateAndTime.Now).Substring(0, 4);
					text3 = Public_Function.MiladiToShamsi(DateAndTime.Now).Substring(5, 2);
					flag = !Directory.Exists(Public_Function.dict["backuppath"] + "\\" + text2);
					if (flag)
					{
						Directory.CreateDirectory(Public_Function.dict["backuppath"] + "\\" + text2);
					}
					flag = !Directory.Exists(string.Concat(new string[]
					{
						Public_Function.dict["backuppath"],
						"\\",
						text2,
						"\\",
						text3
					}));
					if (flag)
					{
						Directory.CreateDirectory(string.Concat(new string[]
						{
							Public_Function.dict["backuppath"],
							"\\",
							text2,
							"\\",
							text3
						}));
					}
					text = string.Concat(new string[]
					{
						text,
						"\\",
						text2,
						"\\",
						text3
					});
				}
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			checked
			{
				bool flag3;
				if (flag)
				{
					bool flag2 = Public_Function.dict.ContainsKey("backuponexit");
					if (flag2)
					{
						flag3 = Conversions.ToBoolean(Public_Function.dict["backuponexit"]);
						if (flag3)
						{
							Frm_Backup frm_Backup = new Frm_Backup();
							flag3 = (Operators.CompareString(Public_Function.dict["backuppath"], string.Empty, false) != 0 && Directory.Exists(Public_Function.dict["backuppath"]));
							if (flag3)
							{
								flag2 = (Public_Function.dict.ContainsKey("onebackup") && Conversions.ToBoolean(Public_Function.dict["onebackup"]));
								if (flag2)
								{
									string[] files = Directory.GetFiles(text, "tazmin-" + Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "") + "*");
									flag3 = (files.Length > 0);
									if (flag3)
									{
										string[] array = files;
										for (int i = 0; i < array.Length; i++)
										{
											string path = array[i];
											File.Delete(path);
										}
									}
								}
								frm_Backup.Path = text;
								frm_Backup.ShowDialog();
							}
						}
					}
				}
				flag3 = (Public_Function.dict.ContainsKey("altbackup") && Public_Function.dict.ContainsKey("altbackup_path"));
				if (flag3)
				{
					bool flag2 = Conversions.ToBoolean(Public_Function.dict["altbackup"]);
					if (flag2)
					{
						text = Public_Function.dict["altbackup_path"];
						text2 = string.Empty;
						text3 = string.Empty;
						flag3 = (Public_Function.dict.ContainsKey("backup_category") && Conversions.ToBoolean(Public_Function.dict["backup_category"]));
						if (flag3)
						{
							text2 = Public_Function.MiladiToShamsi(DateAndTime.Now).Substring(0, 4);
							text3 = Public_Function.MiladiToShamsi(DateAndTime.Now).Substring(5, 2);
							flag3 = !Directory.Exists(Public_Function.dict["altbackup_path"] + "\\" + text2);
							if (flag3)
							{
								Directory.CreateDirectory(Public_Function.dict["altbackup_path"] + "\\" + text2);
							}
							flag3 = !Directory.Exists(string.Concat(new string[]
							{
								Public_Function.dict["altbackup_path"],
								"\\",
								text2,
								"\\",
								text3
							}));
							if (flag3)
							{
								Directory.CreateDirectory(string.Concat(new string[]
								{
									Public_Function.dict["altbackup_path"],
									"\\",
									text2,
									"\\",
									text3
								}));
							}
							text = string.Concat(new string[]
							{
								text,
								"\\",
								text2,
								"\\",
								text3
							});
						}
						Frm_Backup frm_Backup2 = new Frm_Backup();
						flag3 = (Operators.CompareString(Public_Function.dict["altbackup_path"], string.Empty, false) != 0 && Directory.Exists(Public_Function.dict["altbackup_path"]));
						if (flag3)
						{
							flag2 = Conversions.ToBoolean(Public_Function.dict["onebackup"]);
							if (flag2)
							{
								string[] files2 = Directory.GetFiles(text, "tazmin-" + Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "") + "*");
								flag3 = (files2.Length > 0);
								if (flag3)
								{
									string[] array2 = files2;
									for (int j = 0; j < array2.Length; j++)
									{
										string path2 = array2[j];
										File.Delete(path2);
									}
								}
							}
							frm_Backup2.Path = text;
							frm_Backup2.ShowDialog();
						}
					}
				}
				Frm_Size arg_5E4_0 = this.frm_size;
				string arg_5E4_1 = "uiPanel1";
				Point point = new Point(0, 0);
				Point arg_5E4_2 = point;
				Size size = new Size(this.uiPanel1.Width, 0);
				arg_5E4_0.Update(arg_5E4_1, arg_5E4_2, size);
				Frm_Size arg_617_0 = this.frm_size;
				string arg_617_1 = "uiPanel2";
				point = new Point(0, 0);
				Point arg_617_2 = point;
				size = new Size(this.uiPanel2.Width, 0);
				arg_617_0.Update(arg_617_1, arg_617_2, size);
				Frm_Size arg_64A_0 = this.frm_size;
				string arg_64A_1 = "uiPanel3";
				point = new Point(0, 0);
				Point arg_64A_2 = point;
				size = new Size(this.uiPanel3.Width, 0);
				arg_64A_0.Update(arg_64A_1, arg_64A_2, size);
				Frm_Size arg_67D_0 = this.frm_size;
				string arg_67D_1 = "uiPanel4";
				point = new Point(0, 0);
				Point arg_67D_2 = point;
				size = new Size(this.uiPanel4.Width, 0);
				arg_67D_0.Update(arg_67D_1, arg_67D_2, size);
				Frm_Size arg_6B0_0 = this.frm_size;
				string arg_6B0_1 = "uiPanel5";
				point = new Point(0, 0);
				Point arg_6B0_2 = point;
				size = new Size(this.uiPanel5.Width, 0);
				arg_6B0_0.Update(arg_6B0_1, arg_6B0_2, size);
				Frm_Size arg_6E3_0 = this.frm_size;
				string arg_6E3_1 = "uiPanel6";
				point = new Point(0, 0);
				Point arg_6E3_2 = point;
				size = new Size(this.uiPanel6.Width, 0);
				arg_6E3_0.Update(arg_6E3_1, arg_6E3_2, size);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0005F0C4 File Offset: 0x0005D2C4
		public void ColorMenuClick(object sender, EventArgs e)
		{
			bool flag;
			try
			{
				IEnumerator enumerator = this.ButtonItem98.SubItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ButtonItem buttonItem = (ButtonItem)enumerator.Current;
					buttonItem.Checked = false;
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
			((ButtonItem)sender).Checked = true;
			this.setting.Update("theme", Conversions.ToString(((ButtonItem)sender).Tag));
			flag = Public_Function.dict.ContainsKey("theme");
			if (flag)
			{
				Public_Function.dict["theme"] = Conversions.ToString(((ButtonItem)sender).Tag);
			}
			else
			{
				Public_Function.dict.Add("theme", Conversions.ToString(((ButtonItem)sender).Tag));
			}
			this.dr_theme = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from theme where id=", ((ButtonItem)sender).Tag)));
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0005F1E4 File Offset: 0x0005D3E4
		public void ColorMenuEdit(object sender, EventArgs e)
		{
			this.AddForm(new Frm_Coloring
			{
				ID = Conversions.ToLong(((ButtonItem)sender).Tag)
			});
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0005F218 File Offset: 0x0005D418
		private void LoadThemeMenu()
		{
			int num = -1;
			bool flag = Public_Function.dict.ContainsKey("theme");
			if (flag)
			{
				num = Conversions.ToInteger(Public_Function.dict["theme"]);
			}
			else
			{
				num = -1;
			}
			flag = (num == -1);
			if (flag)
			{
				this.ButtonItem99.Checked = true;
			}
			this.ButtonItem101.SubItems.Clear();
			DataTable dataTable = Public_Function.FillData("select id,name from theme order by id desc");
			checked
			{
				int i = this.ButtonItem98.SubItems.Count - 1;
				while (i >= 0)
				{
					flag = (Operators.CompareString(this.ButtonItem98.SubItems[i].Tag.ToString(), "-1", false) == 0 || Operators.CompareString(this.ButtonItem98.SubItems[i].Tag.ToString(), "0", false) == 0);
					if (flag)
					{
						i--;
					}
					else
					{
						this.ButtonItem98.SubItems.RemoveAt(i);
						i--;
					}
				}
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						ButtonItem buttonItem = new ButtonItem();
						buttonItem.Click += new EventHandler(this.ColorMenuClick);
						buttonItem.Text = Conversions.ToString(dataRow["name"]);
						buttonItem.Tag = RuntimeHelpers.GetObjectValue(dataRow["id"]);
						flag = Operators.ConditionalCompareObjectEqual(dataRow["id"], num, false);
						if (flag)
						{
							buttonItem.Checked = true;
						}
						this.ButtonItem98.SubItems.Add(buttonItem, 3);
						ButtonItem buttonItem2 = new ButtonItem();
						buttonItem2.Click += new EventHandler(this.ColorMenuEdit);
						buttonItem2.Text = Conversions.ToString(dataRow["name"]);
						buttonItem2.Tag = RuntimeHelpers.GetObjectValue(dataRow["id"]);
						this.ButtonItem101.SubItems.Add(buttonItem2, 0);
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
				this.dr_theme = Public_Function.FillDataRow("select * from theme where id=" + Conversions.ToString(num));
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
		private void Form_Main_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F1;
			checked
			{
				if (flag)
				{
					this.frm_menu.UiGroupBox3.Controls.Clear();
					this.frm_menu.UiGroupBox4.Controls.Clear();
					this.frm_menu.Group_Index = 0;
					Form arg_73_0 = this.frm_menu;
					Point location = new Point(this.Width - this.frm_menu.Width - 30, 50);
					arg_73_0.Location = location;
					this.frm_menu.Show();
					Form arg_AB_0 = this.frm_menu;
					location = new Point(this.Width - this.frm_menu.Width - 30, 50);
					arg_AB_0.Location = location;
					this.frm_menu.BringToFront();
					this.frm_menu.UiGroupBox2.Controls[0].Focus();
				}
				flag = (e.KeyCode == Keys.F12);
				if (flag)
				{
					this.UiButton4_Click(null, null);
				}
				flag = (e.Control && e.Shift && e.KeyCode == Keys.G);
				bool flag3;
				if (flag)
				{
					bool flag2 = Public_Function.dict.ContainsKey("eval");
					if (flag2)
					{
						flag3 = Conversions.ToBoolean(Public_Function.dict["eval"]);
						if (flag3)
						{
							Frm_Register frm_Register = new Frm_Register();
							frm_Register.ShowDialog();
						}
					}
				}
				flag3 = (e.Control && e.Shift && e.KeyCode == Keys.P);
				if (flag3)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select isnull(password,'') from users where user='admin'"));
					flag3 = (objectValue != null);
					if (flag3)
					{
						Public_Function.ShowMessage(objectValue.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					}
				}
				flag3 = (e.Control && e.KeyCode == Keys.D);
				if (flag3)
				{
					this.UiPanelManager1.Panels[1].Activate();
				}
				flag3 = (e.Control && e.KeyCode == Keys.P);
				if (flag3)
				{
					this.UiPanelManager1.Panels[2].Activate();
				}
				flag3 = (e.KeyCode == Keys.Escape);
				if (flag3)
				{
					bool flag2 = MyProject.Application.OpenForms.Count == 1;
					if (flag2)
					{
						flag = (Public_Function.ShowMessage("آیا مایل به خروج از برنامه میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
						if (flag)
						{
							this.ButtonItem61_Click(null, null);
						}
					}
					flag3 = (MyProject.Application.OpenForms.Count == 2);
					if (flag3)
					{
						flag2 = (Operators.CompareString(MyProject.Application.OpenForms[1].Text, "انتخاب منو", false) == 0);
						if (flag2)
						{
							flag = (Public_Function.ShowMessage("آیا مایل به خروج از برنامه میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
							if (flag)
							{
								this.ButtonItem61_Click(null, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000205D File Offset: 0x0000025D
		private void Form_Main_KeyUp(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0005F77C File Offset: 0x0005D97C
		private void Paint_Text(Control control, PaintEventArgs e)
		{
			StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
			Font font = new Font("mitra", 30f);
			if (Operators.CompareString(font.FontFamily.Name.ToLower(), "mitra", false) != 0)
			{
				font = new Font("b mitra", Conversions.ToSingle("30"));
			}
			SizeF sizeF = e.Graphics.MeasureString(Public_Function.dict["owner"], font, 1500);
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(180, 255, 255, 255)), (float)(checked(control.Width - 50)) - sizeF.Width, 100f, sizeF.Width, sizeF.Height);
			Graphics arg_FA_0 = e.Graphics;
			string s = Public_Function.dict["owner"];
			Font font2 = font;
			Brush black = Brushes.Black;
			checked
			{
				Point p = new Point(control.Width - 50, 100);
				arg_FA_0.DrawString(s, font2, black, p, format);
				if (Public_Function.dict.ContainsKey("eval") && Conversions.ToBoolean(Public_Function.dict["eval"]))
				{
					string text = "شماره تلفن مهندس یادگاری : 09019024221";
					sizeF = e.Graphics.MeasureString(text, font, 2500);
					e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(180, 255, 255, 255)), unchecked((float)(checked(control.Width - 50)) - sizeF.Width), 170f, sizeF.Width, sizeF.Height);
					Graphics arg_1CC_0 = e.Graphics;
					string s2 = text;
					Font font3 = font;
					Brush black2 = Brushes.Black;
					p = new Point(control.Width - 50, 170);
					arg_1CC_0.DrawString(s2, font3, black2, p, format);
					text = "وب سایت : www.hojreh-app.ir";
					sizeF = e.Graphics.MeasureString(text, font, 2500);
					e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(180, 255, 255, 255)), unchecked((float)(checked(control.Width - 50)) - sizeF.Width), 240f, sizeF.Width, sizeF.Height);
					Graphics arg_271_0 = e.Graphics;
					string s3 = text;
					Font font4 = font;
					Brush black3 = Brushes.Black;
					p = new Point(control.Width - 50, 240);
					arg_271_0.DrawString(s3, font4, black3, p, format);
				}
				if (Conversions.ToBoolean(Public_Function.dict["desktop_note"]))
				{
					DataTable dataTable = Public_Function.FillData("select * from note");
					int num = (int)Math.Round((double)(unchecked(100f + sizeF.Height + 20f)));
					try
					{
						foreach (DataRow dataRow in dataTable.Rows)
						{
							sizeF = e.Graphics.MeasureString(Conversions.ToString(dataRow["text"]), font, 1000);
							e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(180, 255, 255, 255)), unchecked((float)(checked(control.Width - 50)) - sizeF.Width), (float)num, sizeF.Width, sizeF.Height);
							Graphics arg_38A_0 = e.Graphics;
							string s4 = Conversions.ToString(dataRow["text"]);
							Font font5 = font;
							Brush black4 = Brushes.Black;
							p = new Point(control.Width - 50, num);
							arg_38A_0.DrawString(s4, font5, black4, p, format);
							num = (int)Math.Round((double)(unchecked((float)num + (sizeF.Height + 20f))));
						}
					}
					finally
					{
						IEnumerator enumerator2 = null;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0005FBA8 File Offset: 0x0005DDA8
		private void Init_background_image()
		{
			bool flag = Directory.Exists(Public_Function.Startup_Path() + "\\image\\");
			checked
			{
				if (flag)
				{
					string[] files = Directory.GetFiles(Public_Function.Startup_Path() + "\\image", "*.jpg", SearchOption.TopDirectoryOnly);
					flag = (files.Length == 0);
					if (!flag)
					{
						setting setting = new setting();
						flag = !Public_Function.dict.ContainsKey("back_image");
						if (flag)
						{
							this.bmp = new Bitmap(files[0]);
							setting.Update("back_image", Path.GetFileName(files[0]));
						}
						else
						{
							int arg_9A_0 = 0;
							int num = files.Length - 1;
							int num2 = arg_9A_0;
							while (true)
							{
								int arg_107_0 = num2;
								int num3 = num;
								if (arg_107_0 > num3)
								{
									break;
								}
								flag = (Operators.CompareString(Path.GetFileName(files[num2]), Public_Function.dict["back_image"], false) == 0);
								if (flag)
								{
									int num4 = num2 + 1;
									flag = (num4 > files.Length - 1);
									if (flag)
									{
										num4 = 0;
									}
									this.bmp = new Bitmap(files[num4]);
									setting.Update("back_image", Path.GetFileName(files[num4]));
								}
								num2++;
							}
							flag = (this.bmp == null);
							if (flag)
							{
								bool flag2 = files.Length > 0;
								if (flag2)
								{
									this.bmp = new Bitmap(files[0]);
									setting.Update("back_image", Path.GetFileName(files[0]));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0005FD00 File Offset: 0x0005DF00
		private void Form1_Load(object sender, EventArgs e)
		{
			this.imgbanana = (Image)Resources.ResourceManager.GetObject(this.miveh[Public_Function.GetRandom(0, 10)]);
			if (Public_Function.dict.ContainsKey("eval"))
			{
				this.OfficeFormAdorner1.DocumentName = "****نسخه آزمایشی****";
			}
			this.LabelItem1.Text = "نرم افزار حسابداری حجره - " + Public_Function.dict["owner"];
			if (!Public_Function.CurrentData.Tabbed)
			{
				this.PaintMdiBackground();
			}
			this.LoadUsers();
			this.uiPanel0.Closed = true;
			PersianCalendar persianCalendar = new PersianCalendar();
			string[] array = Public_Function.MiladiToShamsi(DateAndTime.Now).Split(new char[]
			{
				'/'
			});
			int num = (int)(checked(persianCalendar.GetDayOfWeek(DateAndTime.Now) + 2));
			if (num == 8)
			{
				num = 1;
			}
			this.ButtonCommand1.Text = string.Concat(new string[]
			{
				"امروز ",
				Public_Function.GetDayName(num),
				" ",
				array[2],
				" ",
				Public_Function.GetMonthName(Conversions.ToInteger(array[1])),
				" ",
				array[0]
			});
			this.Load_Root_Menu();
			this.LoadThemeMenu();
			this.addautoVusul();
			this.Get_Sarresid();
			this.Get_sarresid_Pardakht();
			this.Get_Check_Moshtari();
			this.ApplyFont(this.GridEX1.Parent);
			this.ApplyFont(this.GridEX2.Parent);
			this.ApplyFont(this.GridEX3.Parent);
			this.ApplyFont(this.GridEX4.Parent);
			this.ApplyFont(this.GridEX5.Parent);
			this.ApplyFont(this.GridEX6.Parent);
			DataRow[] array2 = Public_Function.Dt_FrmSize.Select("name='uiPanel1'");
			if (array2.Length != 0)
			{
				this.uiPanel1.Width = Conversions.ToInteger(array2[0]["width"]);
			}
			array2 = Public_Function.Dt_FrmSize.Select("name='uiPanel2'");
			if (array2.Length != 0)
			{
				this.uiPanel2.Width = Conversions.ToInteger(array2[0]["width"]);
			}
			array2 = Public_Function.Dt_FrmSize.Select("name='uiPanel3'");
			if (array2.Length != 0)
			{
				this.uiPanel3.Width = Conversions.ToInteger(array2[0]["width"]);
			}
			array2 = Public_Function.Dt_FrmSize.Select("name='uiPanel4'");
			if (array2.Length != 0)
			{
				this.uiPanel4.Width = Conversions.ToInteger(array2[0]["width"]);
			}
			array2 = Public_Function.Dt_FrmSize.Select("name='uiPanel5'");
			if (array2.Length != 0)
			{
				this.uiPanel5.Width = Conversions.ToInteger(array2[0]["width"]);
			}
			array2 = Public_Function.Dt_FrmSize.Select("name='uiPanel6'");
			if (array2.Length != 0)
			{
				this.uiPanel6.Width = Conversions.ToInteger(array2[0]["width"]);
			}
			DataTable byName = this.grid_size.GetByName("Form_Main", "GridEX1");
			try
			{
				foreach (DataRow dataRow in byName.Rows)
				{
					if (this.GridEX1.RootTable.Columns.Contains(dataRow["key"].ToString()))
					{
						this.GridEX1.RootTable.Columns[dataRow["key"].ToString()].Width = Conversions.ToInteger(dataRow["width"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator2 = null;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			byName = this.grid_size.GetByName("Form_Main", "GridEX2");
			try
			{
				foreach (DataRow dataRow2 in byName.Rows)
				{
					if (this.GridEX2.RootTable.Columns.Contains(dataRow2["key"].ToString()))
					{
						this.GridEX2.RootTable.Columns[dataRow2["key"].ToString()].Width = Conversions.ToInteger(dataRow2["width"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator3 = null;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			byName = this.grid_size.GetByName("Form_Main", "GridEX3");
			try
			{
				foreach (DataRow dataRow3 in byName.Rows)
				{
					if (this.GridEX3.RootTable.Columns.Contains(dataRow3["key"].ToString()))
					{
						this.GridEX3.RootTable.Columns[dataRow3["key"].ToString()].Width = Conversions.ToInteger(dataRow3["width"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator4 = null;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			byName = this.grid_size.GetByName("Form_Main", "GridEX4");
			try
			{
				foreach (DataRow dataRow4 in byName.Rows)
				{
					if (this.GridEX4.RootTable.Columns.Contains(dataRow4["key"].ToString()))
					{
						this.GridEX4.RootTable.Columns[dataRow4["key"].ToString()].Width = Conversions.ToInteger(dataRow4["width"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator5 = null;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
			}
			byName = this.grid_size.GetByName("Form_Main", "GridEX5");
			try
			{
				foreach (DataRow dataRow5 in byName.Rows)
				{
					if (this.GridEX5.RootTable.Columns.Contains(dataRow5["key"].ToString()))
					{
						this.GridEX5.RootTable.Columns[dataRow5["key"].ToString()].Width = Conversions.ToInteger(dataRow5["width"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator6 = null;
				if (enumerator6 is IDisposable)
				{
					(enumerator6 as IDisposable).Dispose();
				}
			}
			byName = this.grid_size.GetByName("Form_Main", "GridEX6");
			try
			{
				foreach (DataRow dataRow6 in byName.Rows)
				{
					if (this.GridEX6.RootTable.Columns.Contains(dataRow6["key"].ToString()))
					{
						this.GridEX6.RootTable.Columns[dataRow6["key"].ToString()].Width = Conversions.ToInteger(dataRow6["width"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator7 = null;
				if (enumerator7 is IDisposable)
				{
					(enumerator7 as IDisposable).Dispose();
				}
			}
			this.Init_background_image();
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0006058C File Offset: 0x0005E78C
		private void UiGroupBox1_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			bool flag = Public_Function.AppType == 1 | Public_Function.AppType == 3;
			if (flag)
			{
				bool flag2 = this.bmp != null;
				if (flag2)
				{
					Graphics arg_55_0 = graphics;
					Image arg_55_1 = this.bmp;
					Rectangle rect = new Rectangle(0, 0, ((Control)sender).Width, ((Control)sender).Height);
					arg_55_0.DrawImage(arg_55_1, rect);
				}
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002CDC File Offset: 0x00000EDC
		private void ButtonItem35_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000605F8 File Offset: 0x0005E7F8
		private void ButtonItem38_Click(object sender, EventArgs e)
		{
			Form frm = new Frm_EditUser();
			this.AddForm(frm);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00060618 File Offset: 0x0005E818
		private void ButtonItem21_Click(object sender, EventArgs e)
		{
			string a = this.HDDID();
			Public_Function.ShowMessage(this.HashCode(a, "1234567890"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00060644 File Offset: 0x0005E844
		public string HDDID()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
			string result;
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					result = Strings.Trim(managementObject["SerialNumber"].ToString());
					return result;
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				bool flag = enumerator != null;
				if (flag)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			managementObjectSearcher.Dispose();
			result = "";
			return result;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000606D8 File Offset: 0x0005E8D8
		private string HashCode(string a, string b)
		{
			string text = "";
			bool flag = a.Length >= b.Length;
			checked
			{
				if (flag)
				{
					int length = b.Length;
					for (int i = 1; i <= length; i++)
					{
						text = Conversions.ToString((byte)(Strings.Asc(Strings.Mid(a, i, 1)) + Strings.Asc(Strings.Mid(b, i, 1)))) + text;
					}
				}
				else
				{
					int length2 = a.Length;
					for (int i = 1; i <= length2; i++)
					{
						text = Conversions.ToString((byte)(Strings.Asc(Strings.Mid(a, i, 1)) + Strings.Asc(Strings.Mid(b, i, 1)))) + text;
					}
				}
				flag = (Operators.CompareString(Strings.Trim(text), "", false) == 0);
				if (flag)
				{
					text = b;
				}
				return Strings.StrReverse(text);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000607BC File Offset: 0x0005E9BC
		public static string EncodeStr(string text)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			string text2 = "";
			int num = 0;
			checked
			{
				int arg_44_0;
				int num2;
				do
				{
					text2 = text2 + Conversions.ToString(mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(text))[num]) + "-";
					num++;
					arg_44_0 = num;
					num2 = 14;
				}
				while (arg_44_0 <= num2);
				return text2.Substring(0, text2.Length - 1);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00060824 File Offset: 0x0005EA24
		private void ShowSarresid()
		{
			bool flag = ((DataTable)this.GridEX2.DataSource).Rows.Count > 0;
			if (flag)
			{
				Frm_Checksarresid_Daryaft frm_Checksarresid_Daryaft = new Frm_Checksarresid_Daryaft();
				frm_Checksarresid_Daryaft.MdiParent = this;
				frm_Checksarresid_Daryaft.FormClosing += new FormClosingEventHandler(this.FormDialog_Closing);
				frm_Checksarresid_Daryaft.Load += new EventHandler(this.Form_Load);
				DataRow[] array = Public_Function.Dt_FrmSize.Select("name='" + frm_Checksarresid_Daryaft.Name + "'");
				flag = (array.Length == 0);
				if (flag)
				{
					frm_Checksarresid_Daryaft.StartPosition = FormStartPosition.CenterScreen;
				}
				else
				{
					frm_Checksarresid_Daryaft.StartPosition = FormStartPosition.Manual;
					frm_Checksarresid_Daryaft.Left = Conversions.ToInteger(array[0]["Left"]);
					frm_Checksarresid_Daryaft.Top = Conversions.ToInteger(array[0]["Top"]);
					frm_Checksarresid_Daryaft.Width = Conversions.ToInteger(array[0]["Width"]);
					frm_Checksarresid_Daryaft.Height = Conversions.ToInteger(array[0]["Height"]);
				}
				frm_Checksarresid_Daryaft.dt = (DataTable)this.GridEX2.DataSource;
				frm_Checksarresid_Daryaft.Show();
			}
			flag = (((DataTable)this.GridEX3.DataSource).Rows.Count > 0);
			if (flag)
			{
				Frm_Checksarresid_Pardakht frm_Checksarresid_Pardakht = new Frm_Checksarresid_Pardakht();
				frm_Checksarresid_Pardakht.MdiParent = this;
				frm_Checksarresid_Pardakht.FormClosing += new FormClosingEventHandler(this.FormDialog_Closing);
				frm_Checksarresid_Pardakht.Load += new EventHandler(this.Form_Load);
				DataRow[] array2 = Public_Function.Dt_FrmSize.Select("name='" + frm_Checksarresid_Pardakht.Name + "'");
				flag = (array2.Length == 0);
				if (flag)
				{
					frm_Checksarresid_Pardakht.StartPosition = FormStartPosition.CenterScreen;
				}
				else
				{
					frm_Checksarresid_Pardakht.StartPosition = FormStartPosition.Manual;
					frm_Checksarresid_Pardakht.Left = Conversions.ToInteger(array2[0]["Left"]);
					frm_Checksarresid_Pardakht.Top = Conversions.ToInteger(array2[0]["Top"]);
					frm_Checksarresid_Pardakht.Width = Conversions.ToInteger(array2[0]["Width"]);
					frm_Checksarresid_Pardakht.Height = Conversions.ToInteger(array2[0]["Height"]);
				}
				frm_Checksarresid_Pardakht.st = (DataTable)this.GridEX3.DataSource;
				frm_Checksarresid_Pardakht.Show();
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00060A84 File Offset: 0x0005EC84
		private void ShowSalMali()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select value from setting where [key]='salmali'"));
			bool flag = objectValue == null;
			if (flag)
			{
				this.lbl_salmali.Visible = false;
			}
			else
			{
				string text = objectValue.ToString();
				flag = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag)
				{
					this.lbl_salmali.Visible = true;
					this.lbl_salmali.Text = "سال مالی : " + text;
				}
				else
				{
					this.lbl_salmali.Visible = false;
					this.lbl_salmali.Text = string.Empty;
				}
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00060B20 File Offset: 0x0005ED20
		private void UiButton2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.PanelEx1);
			if (!flag)
			{
				flag = (this.txt_user.SelectedItem == null);
				if (flag)
				{
					Public_Function.ShowMessage("نام کاربری را مشخص نمائید", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				}
				else
				{
					flag = this.user.Login(this.txt_user.SelectedItem.Text, this.txt_pass.Text);
					if (flag)
					{
						try
						{
							this.BackgroundWorker1.RunWorkerAsync();
						}
						catch (Exception expr_81)
						{
							ProjectData.SetProjectError(expr_81);
							ProjectData.ClearProjectError();
						}
						flag = this.txt_database.Visible;
						if (flag)
						{
							Public_Function.dict["dbname"] = Conversions.ToString(this.txt_database.SelectedValue);
						}
						flag = Conversions.ToBoolean(Public_Function.dict["showmemo"]);
						if (flag)
						{
							this.uiPanel1.Closed = false;
						}
						else
						{
							this.uiPanel1.Closed = true;
						}
						this.uiPanel2.Closed = false;
						this.uiPanel3.Closed = false;
						this.uiPanel4.Closed = false;
						this.uiPanel5.Closed = false;
						this.uiPanel6.Closed = false;
						this.lbl_user.Text = Public_Function.CurrentData.Username;
						string text = Assembly.GetEntryAssembly().GetName().Version.ToString();
						flag = text.EndsWith(".0.0");
						if (flag)
						{
							this.lbl_ver.Text = "نسخه " + text.Replace(".0.0", "");
						}
						else
						{
							flag = text.EndsWith(".0");
							if (flag)
							{
								this.lbl_ver.Text = "نسخه " + text.Remove(checked(text.Length - 2), 2);
							}
							else
							{
								this.lbl_ver.Text = "نسخه " + text;
							}
						}
						this.UiGroupBox1.Visible = false;
						DataTable all = this.note.GetAll();
						this.GridEX1.DataSource = all;
						switch (Public_Function.CurrentData.Gui)
						{
						case 0:
							this.Bar1.Visible = true;
							this.Bar1.SendToBack();
							this.Bar1.Refresh();
							break;
						case 1:
							this.Bar1.Visible = false;
							break;
						}
						flag = Public_Function.CurrentData.Tabbed;
						if (flag)
						{
							this.SuperTabControl1.Visible = true;
							this.SuperTabControl1.Dock = DockStyle.Fill;
						}
						else
						{
							this.SuperTabControl1.Visible = false;
							this.SuperTabStrip1.Visible = true;
						}
						flag = Conversions.ToBoolean(Public_Function.dict["elan_check"]);
						if (flag)
						{
							this.ShowSarresid();
						}
						this.SetMainMenupermissions();
						this.SetSubMenuPermissions();
						Public_Function.SetFarsi();
						this.Get_mande_furush();
						this.Get_mande_Safi();
						this.ShowSalMali();
						try
						{
							List<Form>.Enumerator enumerator = this.frms.GetEnumerator();
							while (enumerator.MoveNext())
							{
								Form current = enumerator.Current;
								flag = (current is Frm_Checksarresid_Daryaft);
								if (flag)
								{
									current.Close();
								}
								else
								{
									flag = (current is Frm_Checksarresid_Pardakht);
									if (flag)
									{
										current.Close();
									}
									else
									{
										current.Visible = true;
										flag = (current.WindowState == FormWindowState.Maximized);
										if (flag)
										{
											current.WindowState = FormWindowState.Normal;
											current.WindowState = FormWindowState.Maximized;
										}
									}
								}
							}
						}
						finally
						{
							List<Form>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.SuperTabStrip1.Refresh();
						this.frms.Clear();
						flag = Conversions.ToBoolean(Public_Function.dict["startup"]);
						if (flag)
						{
							Frm_Startup frm_Startup = new Frm_Startup();
							frm_Startup.Show();
						}
						flag = (Public_Function.AppType == 1 | Public_Function.AppType == 3);
						if (flag)
						{
							this.ButtonItem87.Visible = false;
							this.ButtonItem88.Visible = false;
						}
						else
						{
							this.ButtonItem40.Visible = false;
							this.ButtonItem3.Visible = false;
							this.ButtonItem48.Visible = false;
							this.ButtonItem78.Visible = false;
							this.ButtonItem79.Visible = false;
							this.ButtonItem77.Visible = false;
							this.ButtonItem80.Visible = false;
							this.ButtonItem81.Visible = false;
							this.ButtonItem75.Visible = false;
							this.ButtonItem83.Visible = false;
							this.ButtonItem95.Visible = false;
							this.ButtonItem19.Visible = false;
							this.ButtonItem70.Visible = false;
							this.ButtonItem76.Visible = false;
							Frm_DaryaftPardakht frm = new Frm_DaryaftPardakht();
							this.AddForm(frm);
						}
						this.CreateFrm_Menu_Items();
						flag = Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
						if (!flag)
						{
							this.ButtonItem91.Visible = false;
						}
						flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
						if (flag)
						{
							this.ButtonItem96.Visible = true;
						}
						else
						{
							this.ButtonItem96.Visible = false;
						}
						flag = (Public_Function.AppType == 3);
						if (flag)
						{
							this.ButtonItem40.Visible = false;
							this.ButtonItem3.Visible = false;
							this.ButtonItem78.Visible = false;
							this.ButtonItem79.Visible = false;
							this.ButtonItem87.Visible = false;
							this.ButtonItem95.Visible = false;
						}
						flag = Public_Function.dict.ContainsKey("eval");
						if (flag)
						{
							bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
							if (flag2)
							{
								this.txt_register.Visible = true;
							}
							else
							{
								this.txt_register.Visible = false;
							}
						}
						else
						{
							this.txt_register.Visible = false;
						}
					}
					else
					{
						Public_Function.ShowMessage("نام کاربری و یا گذرواژه اشتباه میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						this.txt_pass.Text = string.Empty;
						this.txt_pass.Focus();
					}
				}
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00061170 File Offset: 0x0005F370
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton3_Click(object sender, EventArgs e)
		{
			try
			{
				Application.Exit();
			}
			catch (Exception expr_0A)
			{
				ProjectData.SetProjectError(expr_0A);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000611B0 File Offset: 0x0005F3B0
		private void ButtonCommand2_Click(object sender, CommandEventArgs e)
		{
			checked
			{
				int num = MyProject.Application.OpenForms.Count - 1;
				int arg_16_0 = 1;
				int num2 = num;
				int num3 = arg_16_0;
				while (true)
				{
					int arg_55_0 = num3;
					int num4 = num2;
					if (arg_55_0 > num4)
					{
						break;
					}
					this.frms.Add(MyProject.Application.OpenForms[1]);
					MyProject.Application.OpenForms[1].Visible = false;
					num3++;
				}
				this.UiGroupBox1.Visible = true;
				this.SuperTabStrip1.Visible = false;
				this.SuperTabControl1.Visible = false;
				this.Bar1.Visible = false;
				this.uiPanel0.Visible = false;
				this.uiPanel1.Closed = true;
				this.uiPanel2.Closed = true;
				this.uiPanel3.Closed = true;
				this.uiPanel4.Closed = true;
				this.uiPanel5.Closed = true;
				this.uiPanel6.Closed = true;
				this.txt_user.SelectedItem = null;
				this.txt_pass.Text = string.Empty;
				this.lbl_user.Text = string.Empty;
				bool flag = this.txt_user.Items.Count == 1;
				if (flag)
				{
					this.txt_user.SelectedIndex = 0;
					this.txt_pass.Focus();
				}
				else
				{
					this.txt_user.Focus();
				}
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00061318 File Offset: 0x0005F518
		private void ButtonCommand1_Click(object sender, CommandEventArgs e)
		{
			ToolStripDropDown toolStripDropDown = new ToolStripDropDown();
			DatePanel datePanel = new DatePanel();
			ToolStripControlHost toolStripControlHost = new ToolStripControlHost(datePanel);
			PersianCalendar persianCalendar = new PersianCalendar();
			string[] array = Public_Function.MiladiToShamsi(DateAndTime.Now).Split(new char[]
			{
				'/'
			});
			datePanel.Sal = Conversions.ToInteger(array[0]);
			datePanel.Mah = Conversions.ToInteger(array[1]);
			datePanel.DropDown = toolStripDropDown;
			toolStripDropDown.AutoSize = false;
			Control arg_83_0 = toolStripDropDown;
			Size size = new Size(datePanel.Width, datePanel.Height);
			arg_83_0.Size = size;
			toolStripControlHost.Control.Dock = DockStyle.Fill;
			toolStripControlHost.Control.Top = 0;
			toolStripControlHost.Control.Left = 0;
			toolStripDropDown.Items.Add(toolStripControlHost);
			toolStripDropDown.Show(this, 5, checked(this.Height + 1));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000613F8 File Offset: 0x0005F5F8
		private void SuperTabStrip1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
		{
			bool flag = this.SuperTabStrip1.SelectedTab == null;
			if (!flag)
			{
				try
				{
					IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Form form = (Form)enumerator.Current;
						flag = (Operators.CompareString(form.Text, this.SuperTabStrip1.SelectedTab.Text, false) == 0);
						if (flag)
						{
							form.Focus();
							form.BringToFront();
							form.Activate();
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

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000614B4 File Offset: 0x0005F6B4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			frm_Frush_hag frm = new frm_Frush_hag();
			this.AddForm(frm);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000614D4 File Offset: 0x0005F6D4
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Kala frm = new Frm_Kala();
			this.AddForm(frm);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000614F4 File Offset: 0x0005F6F4
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			Frm_Bank frm = new Frm_Bank();
			this.AddForm(frm);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00061514 File Offset: 0x0005F714
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			Frm_Bank_Hesab frm = new Frm_Bank_Hesab();
			this.AddForm(frm);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00061534 File Offset: 0x0005F734
		private void ButtonItem12_Click(object sender, EventArgs e)
		{
			Frm_DaryaftPardakht frm = new Frm_DaryaftPardakht();
			this.AddForm(frm);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00061554 File Offset: 0x0005F754
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			Check_Sandugh frm = new Check_Sandugh();
			this.AddForm(frm);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00061574 File Offset: 0x0005F774
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			Check_Bank frm = new Check_Bank();
			this.AddForm(frm);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00061594 File Offset: 0x0005F794
		private void ButtonItem21_Click_1(object sender, EventArgs e)
		{
			Frm_Pardakht frm = new Frm_Pardakht();
			this.AddForm(frm);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000615B4 File Offset: 0x0005F7B4
		private void ButtonItem22_Click(object sender, EventArgs e)
		{
			Frm_Moshtari frm = new Frm_Moshtari();
			this.AddForm(frm);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000615D4 File Offset: 0x0005F7D4
		private void ButtonItem23_Click(object sender, EventArgs e)
		{
			Frm_list_BankHesab frm = new Frm_list_BankHesab();
			this.AddForm(frm);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000615F4 File Offset: 0x0005F7F4
		private void ButtonItem37_Click(object sender, EventArgs e)
		{
			Frm_list_Moshtari frm = new Frm_list_Moshtari();
			this.AddForm(frm);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00061614 File Offset: 0x0005F814
		private void ButtonItem9_Click_1(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm = new Frm_SuratHesab_Moshtari();
			this.AddForm(frm);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00061634 File Offset: 0x0005F834
		private void ButtonItem20_Click(object sender, EventArgs e)
		{
			Frm_List_Safi frm = new Frm_List_Safi();
			this.AddForm(frm);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00061654 File Offset: 0x0005F854
		private void ButtonItem38_Click_1(object sender, EventArgs e)
		{
			Frm_Safi frm = new Frm_Safi();
			this.AddForm(frm);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00061674 File Offset: 0x0005F874
		private void ButtonItem39_Click(object sender, EventArgs e)
		{
			Frm_ClearData frm = new Frm_ClearData();
			this.AddForm(frm);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00061694 File Offset: 0x0005F894
		private void ButtonItem40_Click(object sender, EventArgs e)
		{
			Frm_Kharid_Furush frm = new Frm_Kharid_Furush();
			this.AddForm(frm);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000616B4 File Offset: 0x0005F8B4
		private void ButtonItem41_Click(object sender, EventArgs e)
		{
			Frm_Grouh_Moshtari frm = new Frm_Grouh_Moshtari();
			this.AddForm(frm);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000616D4 File Offset: 0x0005F8D4
		private void ButtonItem42_Click(object sender, EventArgs e)
		{
			Frm_SahebSaham frm = new Frm_SahebSaham();
			this.AddForm(frm);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000616F4 File Offset: 0x0005F8F4
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			Frm_User_Admin frm = new Frm_User_Admin();
			this.AddForm(frm);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00061714 File Offset: 0x0005F914
		private void ButtonItem43_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Bank frm = new Frm_SuratHesab_Bank();
			this.AddForm(frm);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00061734 File Offset: 0x0005F934
		private void ButtonItem44_Click(object sender, EventArgs e)
		{
			Frm_Hazine frm = new Frm_Hazine();
			this.AddForm(frm);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00061754 File Offset: 0x0005F954
		private void ButtonItem45_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.AppType == 1 | Public_Function.AppType == 3;
			if (flag)
			{
				Frm_SuratHesab_Daramad frm = new Frm_SuratHesab_Daramad();
				this.AddForm(frm);
			}
			else
			{
				Frm_SuratHesab_Daramad_Khorde frm2 = new Frm_SuratHesab_Daramad_Khorde();
				this.AddForm(frm2);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00061798 File Offset: 0x0005F998
		private void ButtonItem46_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Hazine frm = new Frm_SuratHesab_Hazine();
			this.AddForm(frm);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000617B8 File Offset: 0x0005F9B8
		private void ButtonItem47_Click(object sender, EventArgs e)
		{
			Frm_Daramad frm = new Frm_Daramad();
			this.AddForm(frm);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000617D8 File Offset: 0x0005F9D8
		private void ButtonItem48_Click(object sender, EventArgs e)
		{
			Frm_Ersal_Bar frm = new Frm_Ersal_Bar();
			this.AddForm(frm);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000617F8 File Offset: 0x0005F9F8
		private void ButtonItem49_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkDaryafti frm = new Frm_rpt_checkDaryafti();
			this.AddForm(frm);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00061818 File Offset: 0x0005FA18
		private void ButtonItem50_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkdarjaryan frm = new Frm_rpt_checkdarjaryan();
			this.AddForm(frm);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00061838 File Offset: 0x0005FA38
		private void ButtonItem51_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkvusul frm = new Frm_rpt_checkvusul();
			this.AddForm(frm);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00061858 File Offset: 0x0005FA58
		private void ButtonItem53_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkbargasht frm = new Frm_rpt_checkbargasht();
			this.AddForm(frm);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00061878 File Offset: 0x0005FA78
		private void ButtonItem52_Click(object sender, EventArgs e)
		{
			Frm_rpt_dastecheck frm = new Frm_rpt_dastecheck();
			this.AddForm(frm);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00061898 File Offset: 0x0005FA98
		private void ButtonItem54_Click(object sender, EventArgs e)
		{
			Frm_rpt_bedehkaran frm = new Frm_rpt_bedehkaran();
			this.AddForm(frm);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000618B8 File Offset: 0x0005FAB8
		private void ButtonItem55_Click(object sender, EventArgs e)
		{
			Frm_rpt_bestankaran frm = new Frm_rpt_bestankaran();
			this.AddForm(frm);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000618D8 File Offset: 0x0005FAD8
		private void ButtonItem56_Click(object sender, EventArgs e)
		{
			Frm_SortMenu frm = new Frm_SortMenu();
			this.AddForm(frm);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000618F8 File Offset: 0x0005FAF8
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				new Frm_Backup
				{
					Path = this.FolderBrowserDialog1.SelectedPath
				}.ShowDialog();
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0006193C File Offset: 0x0005FB3C
		private void ButtonItem10_Click(object sender, EventArgs e)
		{
			bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				new Frm_Restore
				{
					Path = this.OpenFileDialog1.FileName
				}.ShowDialog();
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00061980 File Offset: 0x0005FB80
		private void ButtonItem57_Click(object sender, EventArgs e)
		{
			Frm_DasteCheck frm = new Frm_DasteCheck();
			this.AddForm(frm);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000619A0 File Offset: 0x0005FBA0
		private void ButtonItem58_Click(object sender, EventArgs e)
		{
			Frm_SelectDasteCheck frm = new Frm_SelectDasteCheck();
			this.AddForm(frm);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000619C0 File Offset: 0x0005FBC0
		private void ButtonItem59_Click(object sender, EventArgs e)
		{
			Frm_Setting frm = new Frm_Setting();
			this.AddForm(frm);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000619E0 File Offset: 0x0005FBE0
		private void UiButton1_Click(object sender, EventArgs e)
		{
			Frm_Note frm_Note = new Frm_Note();
			frm_Note.ShowDialog();
			DataTable all = this.note.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00061A18 File Offset: 0x0005FC18
		private void txt_user_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_pass.Focus();
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00061A44 File Offset: 0x0005FC44
		private void txt_pass_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.UiButton2.Focus();
				this.UiButton2_Click(null, null);
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00061A78 File Offset: 0x0005FC78
		private void CloseMenu()
		{
			try
			{
				IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Form form = (Form)enumerator.Current;
					bool flag = form is Frm_Menu;
					if (flag)
					{
						form.Close();
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

		// Token: 0x060005D3 RID: 1491 RVA: 0x00061AF8 File Offset: 0x0005FCF8
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ButtonItem61_Click(object sender, EventArgs e)
		{
			Frm_Size arg_2C_0 = this.frm_size;
			string arg_2C_1 = "uiPanel1";
			Point point = new Point(0, 0);
			Point arg_2C_2 = point;
			Size size = new Size(this.uiPanel1.Width, 0);
			arg_2C_0.Update(arg_2C_1, arg_2C_2, size);
			Frm_Size arg_5D_0 = this.frm_size;
			string arg_5D_1 = "uiPanel2";
			point = new Point(0, 0);
			Point arg_5D_2 = point;
			size = new Size(this.uiPanel2.Width, 0);
			arg_5D_0.Update(arg_5D_1, arg_5D_2, size);
			Frm_Size arg_8E_0 = this.frm_size;
			string arg_8E_1 = "uiPanel3";
			point = new Point(0, 0);
			Point arg_8E_2 = point;
			size = new Size(this.uiPanel3.Width, 0);
			arg_8E_0.Update(arg_8E_1, arg_8E_2, size);
			Frm_Size arg_BF_0 = this.frm_size;
			string arg_BF_1 = "uiPanel4";
			point = new Point(0, 0);
			Point arg_BF_2 = point;
			size = new Size(this.uiPanel4.Width, 0);
			arg_BF_0.Update(arg_BF_1, arg_BF_2, size);
			Frm_Size arg_F0_0 = this.frm_size;
			string arg_F0_1 = "uiPanel5";
			point = new Point(0, 0);
			Point arg_F0_2 = point;
			size = new Size(this.uiPanel5.Width, 0);
			arg_F0_0.Update(arg_F0_1, arg_F0_2, size);
			Frm_Size arg_121_0 = this.frm_size;
			string arg_121_1 = "uiPanel6";
			point = new Point(0, 0);
			Point arg_121_2 = point;
			size = new Size(this.uiPanel6.Width, 0);
			arg_121_0.Update(arg_121_1, arg_121_2, size);
			this.grid_size.Update("Form_Main", "GridEX1", this.GridEX1.RootTable.Columns);
			this.grid_size.Update("Form_Main", "GridEX2", this.GridEX2.RootTable.Columns);
			this.grid_size.Update("Form_Main", "GridEX3", this.GridEX3.RootTable.Columns);
			this.grid_size.Update("Form_Main", "GridEX4", this.GridEX4.RootTable.Columns);
			this.grid_size.Update("Form_Main", "GridEX5", this.GridEX5.RootTable.Columns);
			this.grid_size.Update("Form_Main", "GridEX6", this.GridEX6.RootTable.Columns);
			this.Close();
			try
			{
				Application.Exit();
				ProjectData.EndApp();
			}
			catch (Exception expr_221)
			{
				ProjectData.SetProjectError(expr_221);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00061D50 File Offset: 0x0005FF50
		private void ButtonItem21_Click_2(object sender, EventArgs e)
		{
			Frm_Coloring frm = new Frm_Coloring();
			this.AddForm(frm);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00061D70 File Offset: 0x0005FF70
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			this.note.Delete(Conversions.ToString(this.GridEX1.CurrentRow.Cells["id"].Value));
			this.GridEX1.CurrentRow.Delete();
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00061DC0 File Offset: 0x0005FFC0
		private void ButtonItem60_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Barzamin frm = new Frm_SuratHesab_Barzamin();
			this.AddForm(frm);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00061DE0 File Offset: 0x0005FFE0
		private void ButtonItem58_Click_1(object sender, EventArgs e)
		{
			Frm_rpt_checksearch frm = new Frm_rpt_checksearch();
			this.AddForm(frm);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00061E00 File Offset: 0x00060000
		private void SuperTabStrip1_TabItemClose(object sender, SuperTabStripTabItemCloseEventArgs e)
		{
			bool flag = this.tabclose_Flag;
			if (flag)
			{
				this.tabclose_Flag = false;
			}
			else
			{
				try
				{
					IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Form form = (Form)enumerator.Current;
						flag = (Operators.CompareString(form.Text, e.Tab.Text, false) == 0);
						if (flag)
						{
							this.frm_size.Update(form.Name, form.Location, form.Size);
							this.UpdateGridSize(form);
							form.Close();
							flag = form.IsDisposed;
							if (flag)
							{
								break;
							}
							e.Cancel = true;
							break;
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

		// Token: 0x060005D9 RID: 1497 RVA: 0x00061EEC File Offset: 0x000600EC
		private void ButtonItem65_Click(object sender, EventArgs e)
		{
			Frm_DaryaftCheck_Avaldore frm = new Frm_DaryaftCheck_Avaldore();
			this.AddForm(frm);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00061F0C File Offset: 0x0006010C
		private void ButtonItem66_Click(object sender, EventArgs e)
		{
			Frm_rpt_ruzane frm = new Frm_rpt_ruzane();
			this.AddForm(frm);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00061F2C File Offset: 0x0006012C
		private void ButtonItem62_Click(object sender, EventArgs e)
		{
			Frm_PardakhtCheck_Avaldore frm = new Frm_PardakhtCheck_Avaldore();
			this.AddForm(frm);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00061F4C File Offset: 0x0006014C
		private void ButtonItem63_Click(object sender, EventArgs e)
		{
			Frm_PardakhtKonande frm = new Frm_PardakhtKonande();
			this.AddForm(frm);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00061F6C File Offset: 0x0006016C
		private void ButtonItem64_Click(object sender, EventArgs e)
		{
			Frm_BankReport_Design frm = new Frm_BankReport_Design();
			this.AddForm(frm);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00061F8C File Offset: 0x0006018C
		public void UiButton4_Click(object sender, EventArgs e)
		{
			try
			{
				IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Form form = (Form)enumerator.Current;
					bool flag = form is Frm_Calc;
					if (flag)
					{
						form.BringToFront();
						return;
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
			Frm_Calc frm_Calc = new Frm_Calc();
			frm_Calc.Show();
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0006201C File Offset: 0x0006021C
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
				rpt.Pages[0].Watermark.Angle = 45f;
				rpt.Pages[0].Watermark.Font = new Font("mitra", 80f);
				rpt.Pages[0].Watermark.ShowBehind = true;
				rpt.Pages[0].Watermark.Text = Public_Function.dict["owner"].ToString();
				rpt.Pages[0].Watermark.TextBrush = new StiSolidBrush(Color.FromArgb(20, 0, 0, 0));
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000621E4 File Offset: 0x000603E4
		private void UiButton5_Click_1(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checksarresid.mrt");
			DataTable dataTable = (DataTable)this.GridEX2.DataSource;
			dataTable.TableName = "data";
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			Public_Function.AddTazminText(stiReport, true, false);
			this.SetHeader(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0006227C File Offset: 0x0006047C
		private void GridEX5_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			object left = ((DataRowView)this.GridEX5.CurrentRow.DataRow)["kind"];
			bool flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
			if (flag)
			{
				this.Dialog_ShowForm(new Frm_Safi
				{
					Furush_ID = Conversions.ToLong(this.GridEX5.CurrentRow.Cells["ID"].Value)
				});
			}
			else
			{
				flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
				if (flag)
				{
					Frm_Ersal_Bar frm_Ersal_Bar = new Frm_Ersal_Bar();
					string value = Conversions.ToString(this.GridEX5.CurrentRow.Cells["num"].Value).Replace("ارسال بار", "").Replace("/", "");
					frm_Ersal_Bar.Num = Conversions.ToInteger(value);
					this.Dialog_ShowForm(frm_Ersal_Bar);
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00062374 File Offset: 0x00060574
		private void GridEX4_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			object left = ((DataRowView)this.GridEX4.CurrentRow.DataRow)["furush"];
			bool flag = Operators.ConditionalCompareObjectEqual(left, 0, false);
			if (flag)
			{
				this.Dialog_ShowForm(new Frm_Kharid_Furush
				{
					Num = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["furush_num"]),
					GotoLineID = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["ID"])
				});
			}
			else
			{
				flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
				if (flag)
				{
					this.Dialog_ShowForm(new frm_Frush_hag
					{
						Num = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["furush_num"]),
						GotoLineID = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["ID"])
					});
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
						if (flag)
						{
							this.Dialog_ShowForm(new Frm_Ersal_Bar
							{
								Num = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["furush_num"]),
								GotoLineID = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["ID"])
							});
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
							if (flag)
							{
								Frm_RizKharid frm_RizKharid = new Frm_RizKharid();
								string value = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
								{
									Operators.ConcatenateObject("select kharid_id from kharid_detail where id=", ((DataRowView)this.GridEX4.CurrentRow.DataRow)["ID"])
								}, null, null, null));
								frm_RizKharid.Kharid_ID = Conversions.ToLong(value);
								frm_RizKharid.EditAndSave = true;
								frm_RizKharid.GotoLineID = Conversions.ToLong(((DataRowView)this.GridEX4.CurrentRow.DataRow)["ID"]);
								this.Dialog_ShowForm(frm_RizKharid);
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, 5, false);
								if (flag)
								{
									this.Dialog_ShowForm(new Frm_Frush_Sardkhane
									{
										Num = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["furush_num"]),
										GotoLineID = Conversions.ToInteger(((DataRowView)this.GridEX4.CurrentRow.DataRow)["ID"])
									});
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00062670 File Offset: 0x00060870
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			Frm_ChapSafi frm = new Frm_ChapSafi();
			this.AddForm(frm);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00062690 File Offset: 0x00060890
		private void ButtonItem16_Click_1(object sender, EventArgs e)
		{
			Frm_SuratHesab_Sharik frm = new Frm_SuratHesab_Sharik();
			this.AddForm(frm);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000626B0 File Offset: 0x000608B0
		private void ButtonItem64_Click_1(object sender, EventArgs e)
		{
			Frm_rpt_Sandugh frm = new Frm_rpt_Sandugh();
			this.AddForm(frm);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000626D0 File Offset: 0x000608D0
		private void ButtonItem67_Click(object sender, EventArgs e)
		{
			Frm_rpt_kasrezafesandug frm = new Frm_rpt_kasrezafesandug();
			this.AddForm(frm);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000626F0 File Offset: 0x000608F0
		private bool checkForusageinPardakht()
		{
			bool result;
			try
			{
				IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Form form = (Form)enumerator.Current;
					bool flag = form is Frm_DaryaftPardakht;
					if (flag)
					{
						Frm_DaryaftPardakht frm_DaryaftPardakht = (Frm_DaryaftPardakht)form;
						DataTable dataTable = (DataTable)frm_DaryaftPardakht.gridex2.DataSource;
						try
						{
							IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator2.Current;
								flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false);
								if (flag)
								{
									bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["sh_check"], ((DataRowView)this.GridEX3.CurrentRow.DataRow)["sh_check"], false);
									if (flag2)
									{
										bool flag3 = Operators.ConditionalCompareObjectEqual(dataRow["mablagh"], ((DataRowView)this.GridEX3.CurrentRow.DataRow)["mablagh"], false);
										if (flag3)
										{
											bool flag4 = Operators.ConditionalCompareObjectEqual(dataRow["check_sarresid_fa"], ((DataRowView)this.GridEX3.CurrentRow.DataRow)["check_sarresid_fa"], false);
											if (flag4)
											{
												result = true;
												return result;
											}
										}
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							bool flag4 = enumerator2 is IDisposable;
							if (flag4)
							{
								(enumerator2 as IDisposable).Dispose();
							}
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
			result = false;
			return result;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000628E4 File Offset: 0x00060AE4
		private void GridEX3_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = this.checkForusageinPardakht();
			if (flag)
			{
				Public_Function.ShowMessage("چک مورد نظر در پنجره دریافت و پرداخت انتخاب شده است", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
			}
			else
			{
				flag = (new Frm_Vusul_Check
				{
					Row = (DataRowView)this.GridEX3.CurrentRow.DataRow
				}.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					this.GridEX3.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00062954 File Offset: 0x00060B54
		private void ButtonItem68_Click(object sender, EventArgs e)
		{
			Frm_FoctorFurush frm = new Frm_FoctorFurush();
			this.AddForm(frm);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00062974 File Offset: 0x00060B74
		private void ButtonItem69_Click(object sender, EventArgs e)
		{
			Frm_Rpt_Furush frm = new Frm_Rpt_Furush();
			this.AddForm(frm);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00062994 File Offset: 0x00060B94
		private bool checkForusageinPardakht2()
		{
			bool result;
			try
			{
				IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Form form = (Form)enumerator.Current;
					bool flag = form is Frm_DaryaftPardakht;
					if (flag)
					{
						Frm_DaryaftPardakht frm_DaryaftPardakht = (Frm_DaryaftPardakht)form;
						DataTable dataTable = (DataTable)frm_DaryaftPardakht.gridex2.DataSource;
						try
						{
							IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator2.Current;
								flag = (dataRow["dptype_id"] == DBNull.Value);
								if (!flag)
								{
									flag = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false));
									if (flag)
									{
										bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["sh_check"], ((DataRowView)this.GridEX2.CurrentRow.DataRow)["sh_check"], false);
										if (flag2)
										{
											bool flag3 = Operators.ConditionalCompareObjectEqual(dataRow["mablagh"], ((DataRowView)this.GridEX2.CurrentRow.DataRow)["mablagh"], false);
											if (flag3)
											{
												bool flag4 = Operators.ConditionalCompareObjectEqual(dataRow["check_sarresid_fa"], ((DataRowView)this.GridEX2.CurrentRow.DataRow)["check_sarresid_fa"], false);
												if (flag4)
												{
													result = true;
													return result;
												}
											}
										}
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							bool flag4 = enumerator2 is IDisposable;
							if (flag4)
							{
								(enumerator2 as IDisposable).Dispose();
							}
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
			result = false;
			return result;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00062BC8 File Offset: 0x00060DC8
		private void GridEX2_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "vusul", false) == 0;
			bool flag2;
			if (flag)
			{
				flag2 = this.checkForusageinPardakht2();
				if (flag2)
				{
					Public_Function.ShowMessage("چک مورد نظر در پنجره دریافت و پرداخت انتخاب شده است", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					return;
				}
				flag2 = (new Frm_Vusul_Checkd
				{
					Row = (DataRowView)this.GridEX2.CurrentRow.DataRow
				}.ShowDialog() == DialogResult.OK);
				if (flag2)
				{
					this.GridEX2.CurrentRow.Delete();
				}
			}
			flag2 = (Operators.CompareString(e.Column.Key, "bargasht", false) == 0);
			if (flag2)
			{
				flag = this.checkForusageinPardakht2();
				if (flag)
				{
					Public_Function.ShowMessage("چک مورد نظر در پنجره دریافت و پرداخت انتخاب شده است", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				}
				else
				{
					flag2 = (new Frm_Bargasht_Checkd
					{
						Row = (DataRowView)this.GridEX2.CurrentRow.DataRow
					}.ShowDialog() == DialogResult.OK);
					if (flag2)
					{
						this.GridEX2.CurrentRow.Delete();
					}
				}
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00062CD4 File Offset: 0x00060ED4
		private void ButtonItem23_Click_1(object sender, EventArgs e)
		{
			Frm_SuratHesab_Tafavot frm = new Frm_SuratHesab_Tafavot();
			this.AddForm(frm);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00062CF4 File Offset: 0x00060EF4
		private void ButtonItem37_Click_1(object sender, EventArgs e)
		{
			Frm_MoshtariSearch frm = new Frm_MoshtariSearch();
			this.AddForm(frm);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00062D14 File Offset: 0x00060F14
		private void Bar1_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.bar_focus;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Form form = (Form)enumerator.Current;
						bool flag2 = form is Frm_DaryaftPardakht;
						if (flag2)
						{
							((Frm_DaryaftPardakht)form).Focus();
							((Frm_DaryaftPardakht)form).GridEX1.Focus();
							this.Bar1.ReleaseFocus();
							this.bar_focus = false;
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
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00062DCC File Offset: 0x00060FCC
		private void Bar1_KeyDown(object sender, KeyEventArgs e)
		{
			bool alt = e.Alt;
			if (alt)
			{
				try
				{
					IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Form form = (Form)enumerator.Current;
						bool flag = form is Frm_DaryaftPardakht;
						if (flag)
						{
							((Frm_DaryaftPardakht)form).Focus();
							((Frm_DaryaftPardakht)form).GridEX1.Focus();
							this.Bar1.ReleaseFocus();
							this.bar_focus = true;
							e.SuppressKeyPress = true;
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

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem70_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00062E8C File Offset: 0x0006108C
		private void ButtonItem71_Click(object sender, EventArgs e)
		{
			Frm_About frm_About = new Frm_About();
			frm_About.ShowDialog();
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00062EA8 File Offset: 0x000610A8
		private void ButtonItem73_Click(object sender, EventArgs e)
		{
			Frm_Hazine_Kharid frm = new Frm_Hazine_Kharid();
			this.AddForm(frm);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00062EC8 File Offset: 0x000610C8
		private void ButtonItem74_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Takhlie frm = new Frm_SuratHesab_Takhlie();
			this.AddForm(frm);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00062EE8 File Offset: 0x000610E8
		private void ButtonItem75_Click(object sender, EventArgs e)
		{
			Frm_Karmozd frm = new Frm_Karmozd();
			this.AddForm(frm);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002CE6 File Offset: 0x00000EE6
		private void UiButton4_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00062F08 File Offset: 0x00061108
		private void ButtonItem76_Click(object sender, EventArgs e)
		{
			Frm_Startup frm_Startup = new Frm_Startup();
			frm_Startup.Show();
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002CF2 File Offset: 0x00000EF2
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX2, this.EditBox1.Text);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002D0D File Offset: 0x00000F0D
		private void EditBox2_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX3, this.EditBox2.Text);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002D28 File Offset: 0x00000F28
		private void EditBox3_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX4, this.EditBox3.Text);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002D43 File Offset: 0x00000F43
		private void EditBox4_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX5, this.EditBox4.Text);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00062F24 File Offset: 0x00061124
		private void UiButton7_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checksarresidpardakhti.mrt");
			DataTable dataTable = (DataTable)this.GridEX3.DataSource;
			dataTable.TableName = "data";
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			Public_Function.AddTazminText(stiReport, true, false);
			this.SetHeader(stiReport);
			Public_Function.setReportFont(stiReport, "Text1,Text12,Text4,Text13");
			stiReport.Print(false);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00062FC8 File Offset: 0x000611C8
		private void UiButton8_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\gheymatmande.mrt");
			DataTable dataTable = (DataTable)this.GridEX4.DataSource;
			dataTable.TableName = "data";
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			Public_Function.AddTazminText(stiReport, true, false);
			this.SetHeader(stiReport);
			Public_Function.setReportFont(stiReport, "Text7,Text12,Text14");
			stiReport.Print(false);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0006306C File Offset: 0x0006126C
		private void UiButton9_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\safimande.mrt");
			DataTable dataTable = (DataTable)this.GridEX5.DataSource;
			dataTable.TableName = "data";
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			Public_Function.AddTazminText(stiReport, true, false);
			this.SetHeader(stiReport);
			Public_Function.setReportFont(stiReport, "Text7,Text12,Text4,Text13,Text14,Text6");
			stiReport.Print(false);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00063110 File Offset: 0x00061310
		private void ButtonItem77_Click(object sender, EventArgs e)
		{
			Frm_Sud frm = new Frm_Sud();
			this.AddForm(frm);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00063130 File Offset: 0x00061330
		private void ButtonItem78_Click(object sender, EventArgs e)
		{
			Frm_KharidSardkhane frm = new Frm_KharidSardkhane();
			this.AddForm(frm);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00063150 File Offset: 0x00061350
		private void ButtonItem79_Click(object sender, EventArgs e)
		{
			Frm_Frush_Sardkhane frm = new Frm_Frush_Sardkhane();
			this.AddForm(frm);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00063170 File Offset: 0x00061370
		public void txt_database_SelectedValueChanged(object sender, EventArgs e)
		{
			Public_Function.Connection.ChangeDatabase(Conversions.ToString(this.txt_database.SelectedValue));
			this.Form1_Load(null, null);
			Initdb initdb = new Initdb();
			initdb.InitDb1();
			initdb.initdb2();
			initdb.InitDB3();
			Public_Function.LoadApplicationSetting();
			Public_Function.dict["dbname"] = Conversions.ToString(this.txt_database.SelectedValue);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000631E4 File Offset: 0x000613E4
		private void ButtonItem80_Click(object sender, EventArgs e)
		{
			Frm_Sal_Mali frm = new Frm_Sal_Mali();
			this.AddForm(frm);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00063204 File Offset: 0x00061404
		private void ButtonItem38_Click_2(object sender, EventArgs e)
		{
			Frm_Rpt_TarazName frm = new Frm_Rpt_TarazName();
			this.AddForm(frm);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00063224 File Offset: 0x00061424
		private void ButtonItem81_Click(object sender, EventArgs e)
		{
			Frm_Delete_SalMali frm = new Frm_Delete_SalMali();
			this.AddForm(frm);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00063244 File Offset: 0x00061444
		private void ButtonItem82_Click(object sender, EventArgs e)
		{
			this.AddForm(new Frm_rpt_bedehkaran
			{
				Text = "لیست دیرکرد",
				Is_Listdirkard = true
			});
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00063278 File Offset: 0x00061478
		private void ButtonItem83_Click(object sender, EventArgs e)
		{
			Frm_sms_ruzane frm = new Frm_sms_ruzane();
			this.AddForm(frm);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00063298 File Offset: 0x00061498
		private void ButtonItem84_Click(object sender, EventArgs e)
		{
			Frm_Sortdp frm = new Frm_Sortdp();
			this.AddForm(frm);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000632B8 File Offset: 0x000614B8
		private void ButtonItem85_Click(object sender, EventArgs e)
		{
			Frm_EbtalCheck frm = new Frm_EbtalCheck();
			this.AddForm(frm);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000632D8 File Offset: 0x000614D8
		private void ButtonItem86_Click(object sender, EventArgs e)
		{
			Frm_Daramad_avaldore frm = new Frm_Daramad_avaldore();
			this.AddForm(frm);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000632F8 File Offset: 0x000614F8
		private void ButtonItem87_Click(object sender, EventArgs e)
		{
			Frm_KhordeFurushi frm = new Frm_KhordeFurushi();
			this.AddForm(frm);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00063318 File Offset: 0x00061518
		private void ButtonItem88_Click(object sender, EventArgs e)
		{
			Frm_SudKhorde frm = new Frm_SudKhorde();
			this.AddForm(frm);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00063338 File Offset: 0x00061538
		private void ButtonItem89_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Tankhah frm = new Frm_SuratHesab_Tankhah();
			this.AddForm(frm);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00063358 File Offset: 0x00061558
		private void ButtonItem90_Click(object sender, EventArgs e)
		{
			Frm_Sendto_sqlite frm = new Frm_Sendto_sqlite();
			this.AddForm(frm);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00063378 File Offset: 0x00061578
		private void ButtonItem91_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Takhlie2 frm = new Frm_SuratHesab_Takhlie2();
			this.AddForm(frm);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00063398 File Offset: 0x00061598
		private void ButtonItem92_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Sandugh frm = new Frm_SuratHesab_Sandugh();
			this.AddForm(frm);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000633B8 File Offset: 0x000615B8
		private void ButtonItem93_Click(object sender, EventArgs e)
		{
			Frm_rpt_nesieRuz frm = new Frm_rpt_nesieRuz();
			this.AddForm(frm);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000633D8 File Offset: 0x000615D8
		private void ButtonItem94_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Vam frm = new Frm_SuratHesab_Vam();
			this.AddForm(frm);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000633F8 File Offset: 0x000615F8
		private void ButtonItem95_Click(object sender, EventArgs e)
		{
			Frm_Kiosk_Furush frm = new Frm_Kiosk_Furush();
			this.AddForm(frm);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00063418 File Offset: 0x00061618
		private void ButtonItem96_Click(object sender, EventArgs e)
		{
			Form1 frm = new Form1();
			this.AddForm(frm);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00063438 File Offset: 0x00061638
		private void ButtonItem96_Click_1(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			this.AddForm(frm);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000205D File Offset: 0x0000025D
		private void PanelEx1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00063458 File Offset: 0x00061658
		private void ButtonItem96_Click_2(object sender, EventArgs e)
		{
			Frm_SuratHesab_kargari frm = new Frm_SuratHesab_kargari();
			this.AddForm(frm);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00063438 File Offset: 0x00061638
		private void ButtonItem97_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			this.AddForm(frm);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00063478 File Offset: 0x00061678
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			bool flag = !Conversions.ToBoolean(Public_Function.dict["show_newversion"]);
			if (!flag)
			{
				try
				{
					ServicePointManager.Expect100Continue = true;
					ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls);
					WebClient webClient = new WebClient();
					Stream stream = webClient.OpenRead("http://www.update.tazminco.ir/version.txt");
					StreamReader streamReader = new StreamReader(stream);
					string text = streamReader.ReadToEnd();
					string right = Assembly.GetEntryAssembly().GetName().Version.ToString();
					string helpText = string.Empty;
					flag = (Operators.CompareString(text, right, false) > 0);
					if (flag)
					{
						try
						{
							Stream stream2 = webClient.OpenRead("http://www.update.tazminco.ir/" + text.ToString() + ".txt");
							StreamReader streamReader2 = new StreamReader(stream2);
							helpText = streamReader2.ReadToEnd();
						}
						catch (Exception expr_BB)
						{
							ProjectData.SetProjectError(expr_BB);
							ProjectData.ClearProjectError();
						}
						Control.CheckForIllegalCrossThreadCalls = false;
						new Frm_NewVersion
						{
							Version = text,
							HelpText = helpText
						}.ShowDialog(this);
					}
				}
				catch (Exception expr_F9)
				{
					ProjectData.SetProjectError(expr_F9);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000635AC File Offset: 0x000617AC
		public static ulong GetIdleTime()
		{
			checked
			{
				ulong result;
				try
				{
					Form_Main.LASTINPUTINFO lASTINPUTINFO = default(Form_Main.LASTINPUTINFO);
					lASTINPUTINFO.cbSize = (uint)Marshal.SizeOf(lASTINPUTINFO);
					Form_Main.GetLastInputInfo(ref lASTINPUTINFO);
					result = (ulong)Environment.TickCount - unchecked((ulong)lASTINPUTINFO.dwTime);
				}
				catch (Exception expr_39)
				{
					ProjectData.SetProjectError(expr_39);
					result = 0uL;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00063624 File Offset: 0x00061824
		public static long GetTickCount()
		{
			return (long)Environment.TickCount;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0006363C File Offset: 0x0006183C
		public static long GetLastInputTime()
		{
			Form_Main.LASTINPUTINFO lASTINPUTINFO = default(Form_Main.LASTINPUTINFO);
			lASTINPUTINFO.cbSize = checked((uint)Marshal.SizeOf(lASTINPUTINFO));
			bool flag = !Form_Main.GetLastInputInfo(ref lASTINPUTINFO);
			if (flag)
			{
				throw new Exception(Form_Main.GetLastError().ToString());
			}
			return (long)((ulong)lASTINPUTINFO.dwTime);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00063694 File Offset: 0x00061894
		private void ButtonItem100_Click(object sender, EventArgs e)
		{
			Frm_Coloring frm_Coloring = new Frm_Coloring();
			this.AddForm(MyProject.Forms.Frm_Coloring);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002D5E File Offset: 0x00000F5E
		private void ButtonItem18_Click_1(object sender, EventArgs e)
		{
			Process.Start("anydesk.exe");
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000636BC File Offset: 0x000618BC
		private void ButtonItem15_Click_1(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag2)
				{
					Frm_Register frm_Register = new Frm_Register();
					frm_Register.ShowDialog();
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00063708 File Offset: 0x00061908
		private void ButtonItem15_Click_2(object sender, EventArgs e)
		{
			Frm_cmd frm_cmd = new Frm_cmd();
			frm_cmd.ShowDialog();
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00063724 File Offset: 0x00061924
		private void ButtonItem19_Click_1(object sender, EventArgs e)
		{
			Frm_Saderat frm = new Frm_Saderat();
			this.AddForm(frm);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00063744 File Offset: 0x00061944
		private void ButtonItem20_Click_1(object sender, EventArgs e)
		{
			Frm_SuratHesab_Arzi_Moshtari frm = new Frm_SuratHesab_Arzi_Moshtari();
			this.AddForm(frm);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00063764 File Offset: 0x00061964
		private void ButtonItem21_Click_3(object sender, EventArgs e)
		{
			Frm_SuratHesab_HavaleArzi frm = new Frm_SuratHesab_HavaleArzi();
			this.AddForm(frm);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00063784 File Offset: 0x00061984
		private void ButtonItem70_Click_1(object sender, EventArgs e)
		{
			Frm_Varedat frm = new Frm_Varedat();
			this.AddForm(frm);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000637A4 File Offset: 0x000619A4
		private void ButtonItem71_Click_1(object sender, EventArgs e)
		{
			Frm_rpt_Rizkharid frm = new Frm_rpt_Rizkharid();
			this.AddForm(frm);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000637C4 File Offset: 0x000619C4
		private void ButtonItem76_Click_1(object sender, EventArgs e)
		{
			Frm_Furush_Nesie frm = new Frm_Furush_Nesie();
			this.AddForm(frm);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000637E4 File Offset: 0x000619E4
		private void ButtonItem97_Click_1(object sender, EventArgs e)
		{
			Frm_SuratHesab_Anbar frm = new Frm_SuratHesab_Anbar();
			this.AddForm(frm);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00063804 File Offset: 0x00061A04
		private void ButtonItem103_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Kharid frm = new Frm_SuratHesab_Kharid();
			this.AddForm(frm);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00063824 File Offset: 0x00061A24
		private void ButtonItem104_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Furush frm = new Frm_SuratHesab_Furush();
			this.AddForm(frm);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00063844 File Offset: 0x00061A44
		private void ButtonItem105_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_KharidFurush frm = new Frm_SuratHesab_KharidFurush();
			this.AddForm(frm);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00063864 File Offset: 0x00061A64
		private void ButtonItem106_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Daryafti_Moshtari frm = new Frm_SuratHesab_Daryafti_Moshtari();
			this.AddForm(frm);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00063884 File Offset: 0x00061A84
		private void ButtonItem107_Click(object sender, EventArgs e)
		{
			Frm_Sarbarg frm = new Frm_Sarbarg();
			this.AddForm(frm);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000638A4 File Offset: 0x00061AA4
		private void ButtonItem108_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Sherakat frm = new Frm_SuratHesab_Sherakat();
			this.AddForm(frm);
		}

		// Token: 0x04000182 RID: 386
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000184 RID: 388
		[AccessedThroughProperty("ButtonBar1")]
		private ButtonBar _ButtonBar1;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000186 RID: 390
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("UiPanelManager1")]
		private UIPanelManager _UiPanelManager1;

		// Token: 0x04000188 RID: 392
		[AccessedThroughProperty("uiPanel0")]
		private UIPanel _uiPanel0;

		// Token: 0x04000189 RID: 393
		[AccessedThroughProperty("uiPanel0Container")]
		private UIPanelInnerContainer _uiPanel0Container;

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("SuperTabControl1")]
		private SuperTabControl _SuperTabControl1;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("SuperTabControlPanel1")]
		private SuperTabControlPanel _SuperTabControlPanel1;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("SuperTabItem1")]
		private SuperTabItem _SuperTabItem1;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("ButtonItem13")]
		private ButtonItem _ButtonItem13;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("ButtonItem14")]
		private ButtonItem _ButtonItem14;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("ButtonItem17")]
		private ButtonItem _ButtonItem17;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("txt_CompanyName")]
		private LabelCommand _txt_CompanyName;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("lbl_user")]
		private LabelCommand _lbl_user;

		// Token: 0x04000193 RID: 403
		[AccessedThroughProperty("StyleManager1")]
		private StyleManager _StyleManager1;

		// Token: 0x04000194 RID: 404
		[AccessedThroughProperty("PanelEx1")]
		private PanelEx _PanelEx1;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000196 RID: 406
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04000197 RID: 407
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000198 RID: 408
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000199 RID: 409
		[AccessedThroughProperty("ButtonCommand1")]
		private ButtonCommand _ButtonCommand1;

		// Token: 0x0400019A RID: 410
		[AccessedThroughProperty("ButtonCommand2")]
		private ButtonCommand _ButtonCommand2;

		// Token: 0x0400019B RID: 411
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x0400019C RID: 412
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x0400019D RID: 413
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400019E RID: 414
		[AccessedThroughProperty("SuperTabStrip1")]
		private SuperTabStrip _SuperTabStrip1;

		// Token: 0x0400019F RID: 415
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x040001A0 RID: 416
		[AccessedThroughProperty("ButtonItem10")]
		private ButtonItem _ButtonItem10;

		// Token: 0x040001A1 RID: 417
		[AccessedThroughProperty("OfficeFormAdorner1")]
		private OfficeFormAdorner _OfficeFormAdorner1;

		// Token: 0x040001A2 RID: 418
		[AccessedThroughProperty("ButtonItem36")]
		private ButtonItem _ButtonItem36;

		// Token: 0x040001A3 RID: 419
		[AccessedThroughProperty("RibbonTabItem4")]
		private RibbonTabItem _RibbonTabItem4;

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("RibbonTabItem3")]
		private RibbonTabItem _RibbonTabItem3;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("RibbonTabItem2")]
		private RibbonTabItem _RibbonTabItem2;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("RibbonTabItem5")]
		private RibbonTabItem _RibbonTabItem5;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("RibbonTabItem1")]
		private RibbonTabItem _RibbonTabItem1;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("Office2007StartButton1")]
		private Office2007StartButton _Office2007StartButton1;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("ItemContainer1")]
		private ItemContainer _ItemContainer1;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("ItemContainer2")]
		private ItemContainer _ItemContainer2;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("ItemContainer3")]
		private ItemContainer _ItemContainer3;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("ButtonItem24")]
		private ButtonItem _ButtonItem24;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("ButtonItem25")]
		private ButtonItem _ButtonItem25;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("ButtonItem26")]
		private ButtonItem _ButtonItem26;

		// Token: 0x040001AF RID: 431
		[AccessedThroughProperty("ButtonItem27")]
		private ButtonItem _ButtonItem27;

		// Token: 0x040001B0 RID: 432
		[AccessedThroughProperty("ButtonItem28")]
		private ButtonItem _ButtonItem28;

		// Token: 0x040001B1 RID: 433
		[AccessedThroughProperty("ButtonItem29")]
		private ButtonItem _ButtonItem29;

		// Token: 0x040001B2 RID: 434
		[AccessedThroughProperty("GalleryContainer1")]
		private GalleryContainer _GalleryContainer1;

		// Token: 0x040001B3 RID: 435
		[AccessedThroughProperty("labelItem8")]
		private LabelItem _labelItem8;

		// Token: 0x040001B4 RID: 436
		[AccessedThroughProperty("ButtonItem30")]
		private ButtonItem _ButtonItem30;

		// Token: 0x040001B5 RID: 437
		[AccessedThroughProperty("ButtonItem31")]
		private ButtonItem _ButtonItem31;

		// Token: 0x040001B6 RID: 438
		[AccessedThroughProperty("ButtonItem32")]
		private ButtonItem _ButtonItem32;

		// Token: 0x040001B7 RID: 439
		[AccessedThroughProperty("ButtonItem33")]
		private ButtonItem _ButtonItem33;

		// Token: 0x040001B8 RID: 440
		[AccessedThroughProperty("ItemContainer4")]
		private ItemContainer _ItemContainer4;

		// Token: 0x040001B9 RID: 441
		[AccessedThroughProperty("ButtonItem34")]
		private ButtonItem _ButtonItem34;

		// Token: 0x040001BA RID: 442
		[AccessedThroughProperty("ButtonItem35")]
		private ButtonItem _ButtonItem35;

		// Token: 0x040001BB RID: 443
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040001BC RID: 444
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040001BD RID: 445
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x040001BE RID: 446
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x040001BF RID: 447
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x040001C0 RID: 448
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x040001C1 RID: 449
		[AccessedThroughProperty("ButtonItem12")]
		private ButtonItem _ButtonItem12;

		// Token: 0x040001C2 RID: 450
		[AccessedThroughProperty("ControlContainerItem1")]
		private ControlContainerItem _ControlContainerItem1;

		// Token: 0x040001C3 RID: 451
		[AccessedThroughProperty("ButtonItem22")]
		private ButtonItem _ButtonItem22;

		// Token: 0x040001C4 RID: 452
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040001C5 RID: 453
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x040001C6 RID: 454
		[AccessedThroughProperty("ButtonItem39")]
		private ButtonItem _ButtonItem39;

		// Token: 0x040001C7 RID: 455
		[AccessedThroughProperty("ButtonItem40")]
		private ButtonItem _ButtonItem40;

		// Token: 0x040001C8 RID: 456
		[AccessedThroughProperty("ButtonItem41")]
		private ButtonItem _ButtonItem41;

		// Token: 0x040001C9 RID: 457
		[AccessedThroughProperty("ButtonItem42")]
		private ButtonItem _ButtonItem42;

		// Token: 0x040001CA RID: 458
		[AccessedThroughProperty("ButtonItem43")]
		private ButtonItem _ButtonItem43;

		// Token: 0x040001CB RID: 459
		[AccessedThroughProperty("ButtonItem44")]
		private ButtonItem _ButtonItem44;

		// Token: 0x040001CC RID: 460
		[AccessedThroughProperty("ButtonItem45")]
		private ButtonItem _ButtonItem45;

		// Token: 0x040001CD RID: 461
		[AccessedThroughProperty("ButtonItem46")]
		private ButtonItem _ButtonItem46;

		// Token: 0x040001CE RID: 462
		[AccessedThroughProperty("ButtonItem47")]
		private ButtonItem _ButtonItem47;

		// Token: 0x040001CF RID: 463
		[AccessedThroughProperty("ButtonItem48")]
		private ButtonItem _ButtonItem48;

		// Token: 0x040001D0 RID: 464
		[AccessedThroughProperty("ButtonItem49")]
		private ButtonItem _ButtonItem49;

		// Token: 0x040001D1 RID: 465
		[AccessedThroughProperty("ButtonItem50")]
		private ButtonItem _ButtonItem50;

		// Token: 0x040001D2 RID: 466
		[AccessedThroughProperty("ButtonItem51")]
		private ButtonItem _ButtonItem51;

		// Token: 0x040001D3 RID: 467
		[AccessedThroughProperty("ButtonItem52")]
		private ButtonItem _ButtonItem52;

		// Token: 0x040001D4 RID: 468
		[AccessedThroughProperty("ButtonItem53")]
		private ButtonItem _ButtonItem53;

		// Token: 0x040001D5 RID: 469
		[AccessedThroughProperty("ButtonItem54")]
		private ButtonItem _ButtonItem54;

		// Token: 0x040001D6 RID: 470
		[AccessedThroughProperty("ButtonItem55")]
		private ButtonItem _ButtonItem55;

		// Token: 0x040001D7 RID: 471
		[AccessedThroughProperty("ButtonItem56")]
		private ButtonItem _ButtonItem56;

		// Token: 0x040001D8 RID: 472
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x040001D9 RID: 473
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x040001DA RID: 474
		[AccessedThroughProperty("ButtonItem57")]
		private ButtonItem _ButtonItem57;

		// Token: 0x040001DB RID: 475
		[AccessedThroughProperty("ButtonItem59")]
		private ButtonItem _ButtonItem59;

		// Token: 0x040001DC RID: 476
		[AccessedThroughProperty("uiPanel1")]
		private UIPanel _uiPanel1;

		// Token: 0x040001DD RID: 477
		[AccessedThroughProperty("uiPanel1Container")]
		private UIPanelInnerContainer _uiPanel1Container;

		// Token: 0x040001DE RID: 478
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040001DF RID: 479
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040001E0 RID: 480
		[AccessedThroughProperty("txt_pass")]
		private EditBox _txt_pass;

		// Token: 0x040001E1 RID: 481
		[AccessedThroughProperty("txt_user")]
		private UIComboBox _txt_user;

		// Token: 0x040001E2 RID: 482
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040001E3 RID: 483
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040001E4 RID: 484
		[AccessedThroughProperty("ButtonItem61")]
		private ButtonItem _ButtonItem61;

		// Token: 0x040001E5 RID: 485
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x040001E6 RID: 486
		[AccessedThroughProperty("ButtonItem60")]
		private ButtonItem _ButtonItem60;

		// Token: 0x040001E7 RID: 487
		[AccessedThroughProperty("ButtonItem58")]
		private ButtonItem _ButtonItem58;

		// Token: 0x040001E8 RID: 488
		[AccessedThroughProperty("ButtonItem65")]
		private ButtonItem _ButtonItem65;

		// Token: 0x040001E9 RID: 489
		[AccessedThroughProperty("ButtonItem66")]
		private ButtonItem _ButtonItem66;

		// Token: 0x040001EA RID: 490
		[AccessedThroughProperty("uiPanel2")]
		private UIPanel _uiPanel2;

		// Token: 0x040001EB RID: 491
		[AccessedThroughProperty("uiPanel2Container")]
		private UIPanelInnerContainer _uiPanel2Container;

		// Token: 0x040001EC RID: 492
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x040001ED RID: 493
		[AccessedThroughProperty("ButtonItem62")]
		private ButtonItem _ButtonItem62;

		// Token: 0x040001EE RID: 494
		[AccessedThroughProperty("ButtonItem63")]
		private ButtonItem _ButtonItem63;

		// Token: 0x040001EF RID: 495
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x040001F0 RID: 496
		[AccessedThroughProperty("uiPanel3")]
		private UIPanel _uiPanel3;

		// Token: 0x040001F1 RID: 497
		[AccessedThroughProperty("uiPanel3Container")]
		private UIPanelInnerContainer _uiPanel3Container;

		// Token: 0x040001F2 RID: 498
		[AccessedThroughProperty("GridEX3")]
		private GridEX _GridEX3;

		// Token: 0x040001F3 RID: 499
		[AccessedThroughProperty("UiButton5")]
		private UIButton _UiButton5;

		// Token: 0x040001F4 RID: 500
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040001F5 RID: 501
		[AccessedThroughProperty("uiPanel4")]
		private UIPanel _uiPanel4;

		// Token: 0x040001F6 RID: 502
		[AccessedThroughProperty("uiPanel4Container")]
		private UIPanelInnerContainer _uiPanel4Container;

		// Token: 0x040001F7 RID: 503
		[AccessedThroughProperty("uiPanel5")]
		private UIPanel _uiPanel5;

		// Token: 0x040001F8 RID: 504
		[AccessedThroughProperty("uiPanel5Container")]
		private UIPanelInnerContainer _uiPanel5Container;

		// Token: 0x040001F9 RID: 505
		[AccessedThroughProperty("GridEX5")]
		private GridEX _GridEX5;

		// Token: 0x040001FA RID: 506
		[AccessedThroughProperty("ButtonItem16")]
		private ButtonItem _ButtonItem16;

		// Token: 0x040001FB RID: 507
		[AccessedThroughProperty("ButtonItem64")]
		private ButtonItem _ButtonItem64;

		// Token: 0x040001FC RID: 508
		[AccessedThroughProperty("ButtonItem67")]
		private ButtonItem _ButtonItem67;

		// Token: 0x040001FD RID: 509
		[AccessedThroughProperty("ButtonItem68")]
		private ButtonItem _ButtonItem68;

		// Token: 0x040001FE RID: 510
		[AccessedThroughProperty("ButtonItem69")]
		private ButtonItem _ButtonItem69;

		// Token: 0x040001FF RID: 511
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000200 RID: 512
		[AccessedThroughProperty("ButtonItem72")]
		private ButtonItem _ButtonItem72;

		// Token: 0x04000201 RID: 513
		[AccessedThroughProperty("ButtonItem23")]
		private ButtonItem _ButtonItem23;

		// Token: 0x04000202 RID: 514
		[AccessedThroughProperty("ButtonItem37")]
		private ButtonItem _ButtonItem37;

		// Token: 0x04000203 RID: 515
		[AccessedThroughProperty("ButtonItem73")]
		private ButtonItem _ButtonItem73;

		// Token: 0x04000204 RID: 516
		[AccessedThroughProperty("ButtonItem74")]
		private ButtonItem _ButtonItem74;

		// Token: 0x04000205 RID: 517
		[AccessedThroughProperty("ButtonItem75")]
		private ButtonItem _ButtonItem75;

		// Token: 0x04000206 RID: 518
		[AccessedThroughProperty("UiButton6")]
		private UIButton _UiButton6;

		// Token: 0x04000207 RID: 519
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04000208 RID: 520
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000209 RID: 521
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x0400020A RID: 522
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400020B RID: 523
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x0400020C RID: 524
		[AccessedThroughProperty("UiButton7")]
		private UIButton _UiButton7;

		// Token: 0x0400020D RID: 525
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x0400020E RID: 526
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400020F RID: 527
		[AccessedThroughProperty("EditBox3")]
		private EditBox _EditBox3;

		// Token: 0x04000210 RID: 528
		[AccessedThroughProperty("UiButton8")]
		private UIButton _UiButton8;

		// Token: 0x04000211 RID: 529
		[AccessedThroughProperty("GridEX4")]
		private GridEX _GridEX4;

		// Token: 0x04000212 RID: 530
		[AccessedThroughProperty("UiGroupBox5")]
		private UIGroupBox _UiGroupBox5;

		// Token: 0x04000213 RID: 531
		[AccessedThroughProperty("UiButton9")]
		private UIButton _UiButton9;

		// Token: 0x04000214 RID: 532
		[AccessedThroughProperty("EditBox4")]
		private EditBox _EditBox4;

		// Token: 0x04000215 RID: 533
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000216 RID: 534
		[AccessedThroughProperty("ButtonItem77")]
		private ButtonItem _ButtonItem77;

		// Token: 0x04000217 RID: 535
		[AccessedThroughProperty("ButtonItem78")]
		private ButtonItem _ButtonItem78;

		// Token: 0x04000218 RID: 536
		[AccessedThroughProperty("ButtonItem79")]
		private ButtonItem _ButtonItem79;

		// Token: 0x04000219 RID: 537
		[AccessedThroughProperty("uiPanel6")]
		private UIPanel _uiPanel6;

		// Token: 0x0400021A RID: 538
		[AccessedThroughProperty("uiPanel6Container")]
		private UIPanelInnerContainer _uiPanel6Container;

		// Token: 0x0400021B RID: 539
		[AccessedThroughProperty("UiGroupBox6")]
		private UIGroupBox _UiGroupBox6;

		// Token: 0x0400021C RID: 540
		[AccessedThroughProperty("GridEX6")]
		private GridEX _GridEX6;

		// Token: 0x0400021D RID: 541
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x0400021E RID: 542
		[AccessedThroughProperty("txt_database")]
		private UIComboBox _txt_database;

		// Token: 0x0400021F RID: 543
		[AccessedThroughProperty("ButtonItem80")]
		private ButtonItem _ButtonItem80;

		// Token: 0x04000220 RID: 544
		[AccessedThroughProperty("lbl_salmali")]
		private LabelCommand _lbl_salmali;

		// Token: 0x04000221 RID: 545
		[AccessedThroughProperty("ButtonItem38")]
		private ButtonItem _ButtonItem38;

		// Token: 0x04000222 RID: 546
		[AccessedThroughProperty("ButtonItem81")]
		private ButtonItem _ButtonItem81;

		// Token: 0x04000223 RID: 547
		[AccessedThroughProperty("ButtonItem82")]
		private ButtonItem _ButtonItem82;

		// Token: 0x04000224 RID: 548
		[AccessedThroughProperty("ButtonItem83")]
		private ButtonItem _ButtonItem83;

		// Token: 0x04000225 RID: 549
		[AccessedThroughProperty("ButtonItem84")]
		private ButtonItem _ButtonItem84;

		// Token: 0x04000226 RID: 550
		[AccessedThroughProperty("ButtonItem85")]
		private ButtonItem _ButtonItem85;

		// Token: 0x04000227 RID: 551
		[AccessedThroughProperty("ButtonItem86")]
		private ButtonItem _ButtonItem86;

		// Token: 0x04000228 RID: 552
		[AccessedThroughProperty("ButtonItem87")]
		private ButtonItem _ButtonItem87;

		// Token: 0x04000229 RID: 553
		[AccessedThroughProperty("ButtonItem88")]
		private ButtonItem _ButtonItem88;

		// Token: 0x0400022A RID: 554
		[AccessedThroughProperty("ButtonItem89")]
		private ButtonItem _ButtonItem89;

		// Token: 0x0400022B RID: 555
		[AccessedThroughProperty("ButtonItem90")]
		private ButtonItem _ButtonItem90;

		// Token: 0x0400022C RID: 556
		[AccessedThroughProperty("ButtonItem91")]
		private ButtonItem _ButtonItem91;

		// Token: 0x0400022D RID: 557
		[AccessedThroughProperty("ButtonItem92")]
		private ButtonItem _ButtonItem92;

		// Token: 0x0400022E RID: 558
		[AccessedThroughProperty("ButtonItem93")]
		private ButtonItem _ButtonItem93;

		// Token: 0x0400022F RID: 559
		[AccessedThroughProperty("ButtonItem94")]
		private ButtonItem _ButtonItem94;

		// Token: 0x04000230 RID: 560
		[AccessedThroughProperty("ButtonItem95")]
		private ButtonItem _ButtonItem95;

		// Token: 0x04000231 RID: 561
		[AccessedThroughProperty("lbl_ver")]
		private LabelCommand _lbl_ver;

		// Token: 0x04000232 RID: 562
		[AccessedThroughProperty("ButtonItem96")]
		private ButtonItem _ButtonItem96;

		// Token: 0x04000233 RID: 563
		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x04000234 RID: 564
		[AccessedThroughProperty("ButtonItem98")]
		private ButtonItem _ButtonItem98;

		// Token: 0x04000235 RID: 565
		[AccessedThroughProperty("ButtonItem99")]
		private ButtonItem _ButtonItem99;

		// Token: 0x04000236 RID: 566
		[AccessedThroughProperty("ButtonItem100")]
		private ButtonItem _ButtonItem100;

		// Token: 0x04000237 RID: 567
		[AccessedThroughProperty("ButtonItem101")]
		private ButtonItem _ButtonItem101;

		// Token: 0x04000238 RID: 568
		[AccessedThroughProperty("ButtonItem18")]
		private ButtonItem _ButtonItem18;

		// Token: 0x04000239 RID: 569
		[AccessedThroughProperty("txt_register")]
		private ButtonItem _txt_register;

		// Token: 0x0400023A RID: 570
		[AccessedThroughProperty("ButtonItem15")]
		private ButtonItem _ButtonItem15;

		// Token: 0x0400023B RID: 571
		[AccessedThroughProperty("ButtonItem19")]
		private ButtonItem _ButtonItem19;

		// Token: 0x0400023C RID: 572
		[AccessedThroughProperty("ButtonItem20")]
		private ButtonItem _ButtonItem20;

		// Token: 0x0400023D RID: 573
		[AccessedThroughProperty("ButtonItem21")]
		private ButtonItem _ButtonItem21;

		// Token: 0x0400023E RID: 574
		[AccessedThroughProperty("ButtonItem70")]
		private ButtonItem _ButtonItem70;

		// Token: 0x0400023F RID: 575
		[AccessedThroughProperty("ButtonItem71")]
		private ButtonItem _ButtonItem71;

		// Token: 0x04000240 RID: 576
		[AccessedThroughProperty("ButtonItem76")]
		private ButtonItem _ButtonItem76;

		// Token: 0x04000241 RID: 577
		[AccessedThroughProperty("ButtonItem97")]
		private ButtonItem _ButtonItem97;

		// Token: 0x04000242 RID: 578
		[AccessedThroughProperty("ButtonItem102")]
		private ButtonItem _ButtonItem102;

		// Token: 0x04000243 RID: 579
		[AccessedThroughProperty("ButtonItem103")]
		private ButtonItem _ButtonItem103;

		// Token: 0x04000244 RID: 580
		[AccessedThroughProperty("ButtonItem104")]
		private ButtonItem _ButtonItem104;

		// Token: 0x04000245 RID: 581
		[AccessedThroughProperty("ButtonItem105")]
		private ButtonItem _ButtonItem105;

		// Token: 0x04000246 RID: 582
		[AccessedThroughProperty("ButtonItem106")]
		private ButtonItem _ButtonItem106;

		// Token: 0x04000247 RID: 583
		[AccessedThroughProperty("ButtonItem107")]
		private ButtonItem _ButtonItem107;

		// Token: 0x04000248 RID: 584
		[AccessedThroughProperty("ButtonItem108")]
		private ButtonItem _ButtonItem108;

		// Token: 0x04000249 RID: 585
		private Frm_Size frm_size;

		// Token: 0x0400024A RID: 586
		private Grid_Size grid_size;

		// Token: 0x0400024B RID: 587
		private base_user user;

		// Token: 0x0400024C RID: 588
		private Base_User_Control user_conreol;

		// Token: 0x0400024D RID: 589
		private Note note;

		// Token: 0x0400024E RID: 590
		private StickyManager stickymanager;

		// Token: 0x0400024F RID: 591
		private setting setting;

		// Token: 0x04000250 RID: 592
		private DataRow dr_theme;

		// Token: 0x04000251 RID: 593
		private bool tabclose_Flag;

		// Token: 0x04000252 RID: 594
		private string[] miveh;

		// Token: 0x04000253 RID: 595
		private Image imgbanana;

		// Token: 0x04000254 RID: 596
		private List<Form> frms;

		// Token: 0x04000255 RID: 597
		private bool bar_focus;

		// Token: 0x04000256 RID: 598
		private Frm_Menu frm_menu;

		// Token: 0x04000257 RID: 599
		private Bitmap bmp;

		// Token: 0x0200005B RID: 91
		internal struct LASTINPUTINFO
		{
			// Token: 0x04000258 RID: 600
			public uint cbSize;

			// Token: 0x04000259 RID: 601
			public uint dwTime;
		}
	}
}
