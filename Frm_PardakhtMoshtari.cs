using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Validator;
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
	// Token: 0x02000104 RID: 260
	[DesignerGenerated]
	public partial class Frm_PardakhtMoshtari : Form
	{
		// Token: 0x060022E9 RID: 8937 RVA: 0x001A0E30 File Offset: 0x0019F030
		public Frm_PardakhtMoshtari()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_PardakhtMoshtari.__ENCAddToList(this);
			this.frm_hesabBanki = new Frm_SelectItem();
			this.frmCheck_Select = new Frm_SelectItem();
			string empty = string.Empty;
			this.Kart_be_Kart_ID = empty;
			this.dp = new DaryaftPardakht();
			this.sanad = new Sanad();
			this.prevent = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.notin = string.Empty;
			this.Notin_Pardakht = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x001A0EF4 File Offset: 0x0019F0F4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_PardakhtMoshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_PardakhtMoshtari.__ENCList.Count == Frm_PardakhtMoshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_PardakhtMoshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_PardakhtMoshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_PardakhtMoshtari.__ENCList[num] = Frm_PardakhtMoshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_PardakhtMoshtari.__ENCList.RemoveRange(num, Frm_PardakhtMoshtari.__ENCList.Count - num);
						Frm_PardakhtMoshtari.__ENCList.Capacity = Frm_PardakhtMoshtari.__ENCList.Count;
					}
					Frm_PardakhtMoshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x001A2838 File Offset: 0x001A0A38
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x001A2850 File Offset: 0x001A0A50
		internal virtual GridEX GridEX1
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
				EventHandler value2 = new EventHandler(this.gridex3_RecordAdded);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				EventHandler value7 = new EventHandler(this.GridEX1_RecordAdded);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RecordAdded -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.KeyPress -= value5;
					this._GridEX1.ColumnButtonClick -= value6;
					this._GridEX1.RecordAdded -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RecordAdded += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.KeyPress += value5;
					this._GridEX1.ColumnButtonClick += value6;
					this._GridEX1.RecordAdded += value7;
				}
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x001A2984 File Offset: 0x001A0B84
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00008F8B File Offset: 0x0000718B
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

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x001A299C File Offset: 0x001A0B9C
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x001A29B4 File Offset: 0x001A0BB4
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
				EventHandler value2 = new EventHandler(this.gridex3_RecordAdded);
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value4 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				EventHandler value5 = new EventHandler(this.GridEX1_RecordAdded);
				KeyEventHandler value6 = new KeyEventHandler(this.GridEX2_KeyDown);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX2_ColumnButtonClick);
				ColumnActionEventHandler value8 = new ColumnActionEventHandler(this.GridEX2_CellEdited);
				EventHandler value9 = new EventHandler(this.GridEX2_RecordAdded);
				KeyPressEventHandler value10 = new KeyPressEventHandler(this.GridEX2_KeyPress);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.RecordAdded -= value2;
					this._GridEX2.InitCustomEdit -= value3;
					this._GridEX2.EndCustomEdit -= value4;
					this._GridEX2.RecordAdded -= value5;
					this._GridEX2.KeyDown -= value6;
					this._GridEX2.ColumnButtonClick -= value7;
					this._GridEX2.CellEdited -= value8;
					this._GridEX2.RecordAdded -= value9;
					this._GridEX2.KeyPress -= value10;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.RecordAdded += value2;
					this._GridEX2.InitCustomEdit += value3;
					this._GridEX2.EndCustomEdit += value4;
					this._GridEX2.RecordAdded += value5;
					this._GridEX2.KeyDown += value6;
					this._GridEX2.ColumnButtonClick += value7;
					this._GridEX2.CellEdited += value8;
					this._GridEX2.RecordAdded += value9;
					this._GridEX2.KeyPress += value10;
				}
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x001A2B68 File Offset: 0x001A0D68
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00008F95 File Offset: 0x00007195
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x001A2B80 File Offset: 0x001A0D80
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x001A2B98 File Offset: 0x001A0D98
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
				bool flag = this._txt_tarikhGrid != null;
				if (flag)
				{
					this._txt_tarikhGrid.OnRight -= obj;
				}
				this._txt_tarikhGrid = value;
				flag = (this._txt_tarikhGrid != null);
				if (flag)
				{
					this._txt_tarikhGrid.OnRight += obj;
				}
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x001A2BF8 File Offset: 0x001A0DF8
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x00008F9F File Offset: 0x0000719F
		internal virtual Highlighter Highlighter1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Highlighter1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Highlighter1 = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x001A2C10 File Offset: 0x001A0E10
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x001A2C28 File Offset: 0x001A0E28
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x001A2C88 File Offset: 0x001A0E88
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x00008FA9 File Offset: 0x000071A9
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

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x001A2CA0 File Offset: 0x001A0EA0
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x00008FB3 File Offset: 0x000071B3
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

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x001A2CB8 File Offset: 0x001A0EB8
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x00008FBD File Offset: 0x000071BD
		internal virtual LabelCommand lbl_jamcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_jamcheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_jamcheck = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x001A2CD0 File Offset: 0x001A0ED0
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x00008FC7 File Offset: 0x000071C7
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

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x001A2CE8 File Offset: 0x001A0EE8
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x00008FD1 File Offset: 0x000071D1
		internal virtual LabelCommand lbl_jamkol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_jamkol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_jamkol = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x001A2D00 File Offset: 0x001A0F00
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x00008FDB File Offset: 0x000071DB
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

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x001A2D18 File Offset: 0x001A0F18
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x00008FE5 File Offset: 0x000071E5
		internal virtual LabelCommand lbl_codem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_codem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_codem = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x001A2D30 File Offset: 0x001A0F30
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x00008FEF File Offset: 0x000071EF
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x001A2D48 File Offset: 0x001A0F48
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x00008FF9 File Offset: 0x000071F9
		internal virtual LabelCommand lbl_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_name = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x001A2D60 File Offset: 0x001A0F60
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x00009003 File Offset: 0x00007203
		internal virtual LabelCommand LabelCommand9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand9 = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x001A2D78 File Offset: 0x001A0F78
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x0000900D File Offset: 0x0000720D
		internal virtual LabelCommand LabelCommand10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand10 = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x001A2D90 File Offset: 0x001A0F90
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00009017 File Offset: 0x00007217
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

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x001A2DA8 File Offset: 0x001A0FA8
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x00009021 File Offset: 0x00007221
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x001A2DC0 File Offset: 0x001A0FC0
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x0000902B File Offset: 0x0000722B
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x001A2DD8 File Offset: 0x001A0FD8
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x001A2DF0 File Offset: 0x001A0FF0
		internal virtual CurrencyBox txt_naghd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_naghd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_naghd_KeyDown);
				bool flag = this._txt_naghd != null;
				if (flag)
				{
					this._txt_naghd.KeyDown -= value2;
				}
				this._txt_naghd = value;
				flag = (this._txt_naghd != null);
				if (flag)
				{
					this._txt_naghd.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x001A2E50 File Offset: 0x001A1050
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x001A2E68 File Offset: 0x001A1068
		internal virtual CurrencyBox txt_cart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_cart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_cart_ButtonClick);
				CancelEventHandler value3 = new CancelEventHandler(this.txt_cart_Validating);
				bool flag = this._txt_cart != null;
				if (flag)
				{
					this._txt_cart.ButtonClick -= value2;
					this._txt_cart.Validating -= value3;
				}
				this._txt_cart = value;
				flag = (this._txt_cart != null);
				if (flag)
				{
					this._txt_cart.ButtonClick += value2;
					this._txt_cart.Validating += value3;
				}
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x001A2EF0 File Offset: 0x001A10F0
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00009035 File Offset: 0x00007235
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

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x001A2F08 File Offset: 0x001A1108
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x0000903F File Offset: 0x0000723F
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

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x001A2F20 File Offset: 0x001A1120
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x00009049 File Offset: 0x00007249
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

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x001A2F38 File Offset: 0x001A1138
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x00009053 File Offset: 0x00007253
		internal virtual SelectItem txt_kart_bankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kart_bankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kart_bankhesab = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x001A2F50 File Offset: 0x001A1150
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x0000905D File Offset: 0x0000725D
		internal virtual EditBox txt_babat_kart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_babat_kart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_babat_kart = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x001A2F68 File Offset: 0x001A1168
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x00009067 File Offset: 0x00007267
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x001A2F80 File Offset: 0x001A1180
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00009071 File Offset: 0x00007271
		public string Tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tozih;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tozih = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x001A2F98 File Offset: 0x001A1198
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x0000907B File Offset: 0x0000727B
		public DataTable Pardakht_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Table = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x001A2FB0 File Offset: 0x001A11B0
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x00009085 File Offset: 0x00007285
		public List<listCheckDaryaft> ListDaryaft_Identity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListDaryaft_Identity;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ListDaryaft_Identity = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x001A2FC8 File Offset: 0x001A11C8
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x0000908F File Offset: 0x0000728F
		public long Mablagh_Kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mablagh_Kol;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mablagh_Kol = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x001A2FE0 File Offset: 0x001A11E0
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00009099 File Offset: 0x00007299
		public int HazineKharid_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HazineKharid_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HazineKharid_ID = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x001A2FF8 File Offset: 0x001A11F8
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x000090A3 File Offset: 0x000072A3
		public string HazineKharid_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HazineKharid_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HazineKharid_Name = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x001A3010 File Offset: 0x001A1210
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x000090AD File Offset: 0x000072AD
		public string Moshtari_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_Name = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x001A3028 File Offset: 0x001A1228
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x000090B7 File Offset: 0x000072B7
		public string Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x001A3040 File Offset: 0x001A1240
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x000090C1 File Offset: 0x000072C1
		public string Pardakht_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_ID = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x001A3058 File Offset: 0x001A1258
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x000090CB File Offset: 0x000072CB
		public string Kart_be_Kart_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kart_be_Kart_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kart_be_Kart_ID = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x001A3070 File Offset: 0x001A1270
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x000090D5 File Offset: 0x000072D5
		public DataTable dt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt = value;
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x001A3088 File Offset: 0x001A1288
		private bool ValidateCurrentGridRow(int row)
		{
			bool flag = row == -1;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				flag = (Operators.CompareString(this.GridEX2.GetRow(row).Cells["mablagh"].Value.ToString(), string.Empty, false) == 0);
				if (flag)
				{
					Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Mablagh", "مبلغ چک را وارد کنید");
					result = false;
				}
				else
				{
					flag = (Operators.CompareString(this.GridEX2.GetRow(row).Cells["Sh_Check"].Value.ToString(), string.Empty, false) == 0);
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Sh_Check", "شماره چک را وارد کنید");
						result = false;
					}
					else
					{
						flag = (Operators.CompareString(this.GridEX2.GetRow(row).Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
							result = false;
						}
						else
						{
							flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(this.GridEX2.GetRow(row).Cells["Check_Sarresid_Fa"].Value));
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
								result = false;
							}
							else
							{
								flag = (this.GridEX2.GetRow(row).Cells["BankHesab_Id"].Value == DBNull.Value);
								if (flag)
								{
									Public_Function.GridRaiseSoftError(this.GridEX2, this.GridEX2.GetRow(row), "BankHesab_Name", "حساب بانکی را مشخص فرمائید");
									result = false;
								}
								else
								{
									result = true;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x001A3278 File Offset: 0x001A1478
		private bool ValidateGrid()
		{
			this.GridEX1.UpdateData();
			this.GridEX2.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX2.DataSource;
			int i = 0;
			bool flag = dataTable == null;
			checked
			{
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					while (i <= dataTable.Rows.Count - 1)
					{
						flag = (dataTable.Rows[i].RowState == DataRowState.Deleted);
						if (flag)
						{
							i++;
						}
						else
						{
							flag = (dataTable.Rows[i]["CheckBarg_ID"] == DBNull.Value && dataTable.Rows[i]["BankHesab_ID"] == DBNull.Value);
							if (flag)
							{
								dataTable.Rows[i].Delete();
								i--;
							}
							i++;
						}
					}
					dataTable.AcceptChanges();
					GridEXRow[] rows = this.GridEX2.GetRows();
					for (int j = 0; j < rows.Length; j++)
					{
						GridEXRow gridEXRow = rows[j];
						flag = (Operators.CompareString(gridEXRow.Cells["mablagh"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Mablagh", "مبلغ چک را وارد کنید");
							result = false;
							return result;
						}
						flag = (Operators.CompareString(gridEXRow.Cells["Sh_Check"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Sh_Check", "شماره چک را وارد کنید");
							result = false;
							return result;
						}
						flag = (Operators.CompareString(gridEXRow.Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
							result = false;
							return result;
						}
						flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(gridEXRow.Cells["Check_Sarresid_Fa"].Value));
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
							result = false;
							return result;
						}
						flag = (gridEXRow.Cells["BankHesab_Id"].Value == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX2, gridEXRow, "BankHesab_Name", "حساب بانکی را مشخص فرمائید");
							result = false;
							return result;
						}
					}
					flag = (Operators.CompareString(this.txt_cart.Text, string.Empty, false) != 0);
					if (flag)
					{
						bool flag2 = this.txt_kart_bankhesab.Value == null;
						if (flag2)
						{
							Public_Function.ShowTip(this.txt_kart_bankhesab, "لطفا حساب بانکی را انتخاب فرمایید");
							result = false;
							return result;
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		private bool Check_SayerAmaliyat(long id, string Tarikh)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from daryaftpardakht where pardakhtcheck_id=" + Conversions.ToString(id) + " and tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))));
			bool flag = num == 0;
			return !flag;
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x001A3560 File Offset: 0x001A1760
		public long Sum_Mablagh()
		{
			long? value = this.txt_naghd.Value;
			bool hasValue = value.HasValue;
			checked
			{
				long? value3;
				long num;
				if (hasValue)
				{
					long? value2 = this.txt_naghd.Value;
					long? arg_4E_0;
					if (!value2.HasValue)
					{
						arg_4E_0 = null;
					}
					else
					{
						value3 = new long?(num + value2.GetValueOrDefault());
						arg_4E_0 = value3;
					}
					num = (T)arg_4E_0;
				}
				value3 = this.txt_cart.Value;
				hasValue = value3.HasValue;
				if (hasValue)
				{
					long? value2 = this.txt_cart.Value;
					long? arg_A2_0;
					if (!value2.HasValue)
					{
						arg_A2_0 = null;
					}
					else
					{
						value = new long?(num + value2.GetValueOrDefault());
						arg_A2_0 = value;
					}
					num = (T)arg_A2_0;
				}
				num = (long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX1.DataSource, "Mablagh"))));
				num = (long)Math.Round(unchecked((double)num + Conversions.ToDouble(Public_Function.GetSum((DataTable)this.GridEX2.DataSource, "Mablagh"))));
				return num;
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x001A3670 File Offset: 0x001A1870
		private void LoadData()
		{
			bool flag = this.Pardakht_ID == null;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.dt == null;
				if (flag2)
				{
					this.dt = this.dp.GetPardakhtByID("-1");
					this.dt.Columns.Add("isnew", typeof(bool));
				}
				else
				{
					try
					{
						IEnumerator enumerator = this.dt.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							dataRow["isnew"] = false;
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
			}
			else
			{
				bool flag2 = this.dt == null;
				if (flag2)
				{
					this.dt = this.dp.GetPardakhtByID(this.Pardakht_ID);
					this.dt.Columns.Add("isnew", typeof(bool));
					try
					{
						IEnumerator enumerator2 = this.dt.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							dataRow2["isnew"] = false;
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
				flag2 = (this.dt != null);
				if (flag2)
				{
					flag = (this.dt.Rows.Count == 1);
					if (flag)
					{
						flag3 = Operators.ConditionalCompareObjectEqual(this.dt.Rows[0]["dptype_id"], -2, false);
						if (flag3)
						{
							this.dt.Rows.Clear();
						}
					}
				}
			}
			DataTable dataTable = this.dt.Clone();
			DataTable dataTable2 = this.dt.Clone();
			flag3 = (this.dt.Rows.Count == 0);
			if (flag3)
			{
				this.txt_naghd.Text = Conversions.ToString(this.Mablagh_Kol);
			}
			else
			{
				this.txt_naghd.Text = "0";
			}
			long num = 0L;
			try
			{
				IEnumerator enumerator3 = this.dt.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], -4, false);
					if (!flag3)
					{
						flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 13, false);
						if (!flag3)
						{
							flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 10, false);
							if (flag3)
							{
								this.txt_naghd.Text = Conversions.ToString(dataRow3["mablagh"]);
							}
							flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 11, false);
							if (flag3)
							{
								dataTable.ImportRow(dataRow3);
								num = Conversions.ToLong(Operators.AddObject(num, dataRow3["mablagh"]));
							}
							flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 12, false);
							if (flag3)
							{
								dataTable2.ImportRow(dataRow3);
								num = Conversions.ToLong(Operators.AddObject(num, dataRow3["mablagh"]));
							}
							flag3 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 29, false);
							if (flag3)
							{
								this.txt_cart.Text = Conversions.ToString(dataRow3["mablagh"]);
								num = Conversions.ToLong(Operators.AddObject(num, dataRow3["mablagh"]));
								this.txt_kart_bankhesab.SetValue(Conversions.ToString(dataRow3["bankhesab_name"]), RuntimeHelpers.GetObjectValue(dataRow3["bankhesab_id"]));
								this.txt_babat_kart.Text = dataRow3["Tozih"].ToString();
								flag3 = (dataRow3["ID"] != DBNull.Value);
								if (flag3)
								{
									this.Kart_be_Kart_ID = Conversions.ToString(dataRow3["ID"]);
								}
								this.txt_cart.Tag = RuntimeHelpers.GetObjectValue(dataRow3["mablagh"]);
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				flag3 = (enumerator3 is IDisposable);
				if (flag3)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			this.txt_naghd.Text = Conversions.ToString(checked(this.Mablagh_Kol - num));
			this.GridEX1.DataSource = dataTable2;
			this.GridEX2.DataSource = dataTable;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x001A3BB8 File Offset: 0x001A1DB8
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.ValidateGrid();
			if (flag)
			{
				e.Cancel = true;
			}
			else
			{
				try
				{
					IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["ID"] == DBNull.Value);
						if (flag)
						{
							dataRow["dptype_id"] = 12;
							flag = (dataRow["isnew"] == DBNull.Value);
							if (flag)
							{
								this.dt.ImportRow(dataRow);
							}
						}
						else
						{
							DataRow[] array = this.dt.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
							flag = (array.Length > 0);
							if (flag)
							{
								array[0]["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
								array[0]["mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
								array[0]["sh_check"] = RuntimeHelpers.GetObjectValue(dataRow["sh_check"]);
								array[0]["check_sarresid_fa"] = RuntimeHelpers.GetObjectValue(dataRow["check_sarresid_fa"]);
								array[0]["BankHesab_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
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
				try
				{
					IEnumerator enumerator2 = ((DataTable)this.GridEX2.DataSource).Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag = (dataRow2["ID"] == DBNull.Value);
						if (flag)
						{
							dataRow2["dptype_id"] = 11;
							flag = (dataRow2["isnew"] == DBNull.Value);
							if (flag)
							{
								this.dt.ImportRow(dataRow2);
							}
						}
						else
						{
							DataRow[] array2 = this.dt.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow2["ID"])));
							flag = (array2.Length > 0);
							if (flag)
							{
								array2[0]["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["BankHesab_ID"]);
								array2[0]["mablagh"] = RuntimeHelpers.GetObjectValue(dataRow2["mablagh"]);
								array2[0]["sh_check"] = RuntimeHelpers.GetObjectValue(dataRow2["sh_check"]);
								array2[0]["check_sarresid_fa"] = RuntimeHelpers.GetObjectValue(dataRow2["check_sarresid_fa"]);
								array2[0]["BankHesab_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["BankHesab_Name"]);
								array2[0]["CheckBarg_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["CheckBarg_ID"]);
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
				flag = (Operators.CompareString(this.txt_cart.Text, string.Empty, false) != 0);
				bool flag2;
				if (flag)
				{
					DataRow[] array3 = this.dt.Select("dptype_id=29");
					flag = (array3.Length > 0);
					if (flag)
					{
						array3[0]["dptype_id"] = 29;
						array3[0]["HazineKharid_id"] = this.HazineKharid_ID;
						array3[0]["BankHesab_id"] = RuntimeHelpers.GetObjectValue(this.txt_kart_bankhesab.Value);
						array3[0]["BankHesab_name"] = this.txt_kart_bankhesab.Text;
						array3[0]["Tozih"] = this.txt_babat_kart.Text;
						array3[0]["mablagh"] = this.txt_cart.Value;
					}
					else
					{
						DataRow dataRow3 = this.dt.NewRow();
						dataRow3["dptype_id"] = 29;
						dataRow3["HazineKharid_id"] = this.HazineKharid_ID;
						dataRow3["BankHesab_id"] = RuntimeHelpers.GetObjectValue(this.txt_kart_bankhesab.Value);
						dataRow3["BankHesab_name"] = this.txt_kart_bankhesab.Text;
						dataRow3["mablagh"] = this.txt_cart.Value;
						dataRow3["Tozih"] = this.txt_babat_kart.Text;
						this.dt.Rows.Add(dataRow3);
					}
				}
				else
				{
					DataRow[] array4 = this.dt.Select("dptype_id=29");
					flag = (array4.Length > 0);
					if (flag)
					{
						this.dt.Rows.Remove(array4[0]);
						flag = (this.dt.Rows.Count == 1);
						if (flag)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(this.dt.Rows[0]["dptype_id"], -4, false);
							if (flag2)
							{
								NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
								{
									Operators.ConcatenateObject("update daryaftpardakht set dptype_id=-2 where id=", this.dt.Rows[0]["id"])
								}, null, null, null, true);
								return;
							}
						}
					}
				}
				flag2 = (this.dt.Rows.Count == 0);
				if (!flag2)
				{
					DataRow[] array5 = this.dt.Select("dptype_id=10");
					flag2 = (array5.Length > 0);
					if (flag2)
					{
						array5[0]["mablagh"] = this.txt_naghd.Value;
					}
					else
					{
						long num = 0L;
						long? value = this.txt_naghd.Value;
						bool? arg_674_0;
						if (!value.HasValue)
						{
							arg_674_0 = null;
						}
						else
						{
							bool? flag3 = new bool?(value.GetValueOrDefault() != num);
							arg_674_0 = flag3;
						}
						bool? flag4 = arg_674_0;
						flag2 = flag4.GetValueOrDefault();
						if (flag2)
						{
							DataRow dataRow4 = this.dt.NewRow();
							dataRow4["dptype_id"] = 10;
							dataRow4["mablagh"] = this.txt_naghd.Value;
							this.dt.Rows.Add(dataRow4);
						}
					}
					long num2 = this.Sum_Mablagh();
					flag2 = (num2 > 0L);
					if (flag2)
					{
						DataRow[] array6 = this.dt.Select("dptype_id=-4");
						flag2 = (array6.Length > 0);
						if (flag2)
						{
							array6[0]["mablagh"] = num2;
						}
						else
						{
							DataRow dataRow5 = this.dt.NewRow();
							dataRow5["dptype_id"] = -4;
							dataRow5["mablagh"] = num2;
							this.dt.Rows.InsertAt(dataRow5, 0);
						}
					}
				}
			}
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x001A436C File Offset: 0x001A256C
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.Check_Print();
			}
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x001A43A8 File Offset: 0x001A25A8
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			this.Text += "-چاپ چک=F4";
			ItemCollection itemCollection = new ItemCollection();
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm_hesabBanki.items = itemCollection;
			itemCollection2.Add(new Column("Sh_Check", "شماره چک ", 15));
			itemCollection2.Add(new Column("Mablagh", "مبلغ", 15));
			itemCollection2.Add(new Column("Bank_Name", "بانک", 10));
			itemCollection2.Add(new Column("Check_Shobe", "شعبه", 15));
			itemCollection2.Add(new Column("Check_ShomareHesab", "شماره حساب", 15));
			itemCollection2.Add(new Column("Moshtari_Name", "پرداخت کننده", 20));
			itemCollection2.Add(new Column("Check_Sarresid_Fa", "سررسید", 10));
			this.frmCheck_Select.items = itemCollection2;
			this.LoadData();
			this.GetSum();
			this.GridEX2.MoveToNewRecord();
			this.GridEX2.Col = 0;
			this.GridEX2.EditMode = EditMode.EditOn;
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x001A44E8 File Offset: 0x001A26E8
		private object Contains_In_List(int Operation_ID, int PardakhtCheck_ID)
		{
			object result;
			try
			{
				List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
				while (enumerator.MoveNext())
				{
					listCheckDaryaft current = enumerator.Current;
					bool flag = current.Operation_id == Operation_ID && current.PardakhtCheck_ID == PardakhtCheck_ID;
					if (flag)
					{
						result = true;
						return result;
					}
				}
			}
			finally
			{
				List<listCheckDaryaft>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			result = false;
			return result;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x001A456C File Offset: 0x001A276C
		public void Check_Select()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
			text = Public_Function.RemoveLast(text);
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " AND DaryaftPardakht.ID NOT IN(" + text + ")";
			}
			DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=",
				Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
				text,
				this.notin,
				" order by DaryaftPardakht.Check_Sarresid"
			}));
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			flag = (this.frmCheck_Select.ShowDialog(dataTable2, null, "پرداخت چک - انتخاب چک") == DialogResult.OK);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectGreater(this.frmCheck_Select.SelectedRow["Mablagh"], this.txt_naghd.Value, false);
				if (flag2)
				{
					Public_Function.ShowMessage("مبلغ چک بیشتر از مبلغ کل میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				}
				else
				{
					this.prevent = true;
					flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null);
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
						this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
						this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
						this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
						this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
						this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
						this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["ID"]);
						this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
						flag2 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
						if (flag2)
						{
							flag = (this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value);
							if (flag)
							{
								this.ListDaryaft_Identity.Add(new listCheckDaryaft
								{
									Operation_id = 12,
									Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
								});
							}
							else
							{
								this.ListDaryaft_Identity.Add(new listCheckDaryaft
								{
									Operation_id = 12,
									PardakhtCheck_ID = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["PardakhtCheck_ID"])
								});
							}
						}
						this.GridEX1.UpdateData();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x001A4A34 File Offset: 0x001A2C34
		private void BankHesab_Select()
		{
			string command = "SELECT        Bank_Hesab.ID, Bank.Name + ' - ' + Bank_Hesab.Shobe AS Name  FROM            Bank_Hesab INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID";
			bool flag = this.frm_hesabBanki.ShowDialog(command, MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX2.Col == this.GridEX2.RootTable.Columns["BankHesab_Name"].Position && this.GridEX2.EditTextBox != null;
					if (flag2)
					{
						this.GridEX2.EditTextBox.Text = Conversions.ToString(this.frm_hesabBanki.SelectedRow["Name"]);
						this.GridEX2.GetRow().Cells["BankHesab_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm_hesabBanki.SelectedRow["ID"]);
						GridEX gridEX = this.GridEX2;
						gridEX.Col++;
						this.GridEX2.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x001A4B3C File Offset: 0x001A2D3C
		private void Shobe_Select()
		{
			DataTable dt = Public_Function.FillData("select distinct Check_shobe as name  from daryaftpardakht where Check_Shobe is not null");
			bool flag = this.frm_hesabBanki.ShowDialog(dt, null, "انتخاب شعبه") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm_hesabBanki.SelectedRow["Name"]);
						GridEX gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x001A4BF8 File Offset: 0x001A2DF8
		private void GetSum()
		{
			long num = 0L;
			int arg_13_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_13_0;
				while (true)
				{
					int arg_83_0 = num3;
					int num4 = num2;
					if (arg_83_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX1.GetRow(num3).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToLong(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells["Mablagh"].Value));
					}
					num3++;
				}
				int arg_95_0 = 0;
				int num5 = this.GridEX2.RowCount - 1;
				int num6 = arg_95_0;
				while (true)
				{
					int arg_106_0 = num6;
					int num4 = num5;
					if (arg_106_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX2.GetRow(num6).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToLong(Operators.AddObject(num, this.GridEX2.GetRow(num6).Cells["Mablagh"].Value));
					}
					num6++;
				}
				this.lbl_jamcheck.Text = Public_Function.ToFarsi(Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True));
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x001A4D30 File Offset: 0x001A2F30
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "sh_check", false) == 0;
			if (flag)
			{
				this.GetSum();
				flag = (this.GridEX1.CurrentRow.Cells["mablagh"].Value != null);
				if (flag)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.SubtractObject(txt_naghd.Text, this.GridEX1.CurrentRow.Cells["mablagh"].Value));
				}
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x001A4DD0 File Offset: 0x001A2FD0
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 18,
				Daryaft_Identity = value
			});
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x001A4E04 File Offset: 0x001A3004
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataRowView dataRowView = (DataRowView)row.DataRow;
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			if (flag)
			{
				string text = ((DataRowView)row.DataRow)["PardakhtCheck_ID"].ToString();
				string text2 = string.Empty;
				long value = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
				DataRow dataRow = Public_Function.FillDataRow("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + Conversions.ToString(value) + ")");
				text2 = text2 + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + Conversions.ToString(value) + ");";
				text2 = text2 + "delete from daryaftpardakht where id in(" + Conversions.ToString(value) + ");";
				flag = (dataRow["sanadbed_id"] != DBNull.Value);
				if (flag)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbed_id"]), ");")));
				}
				flag = (dataRow["sanadbes_id"] != DBNull.Value);
				if (flag)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbes_id"]), ");")));
				}
				Public_Function.ExecuteNonQuery(text2);
				flag = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag)
				{
					text2 = "declare @st int;";
					text2 = text2 + "select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=" + text + " order by id desc;";
					text2 += "if @st is null set @st=1;";
					text2 = text2 + "update daryaftpardakht set check_status=@st where id=" + text + ";";
					Public_Function.ExecuteNonQuery(text2);
				}
				try
				{
					IEnumerator enumerator = this.dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						flag = (dataRow2["ID"] != DBNull.Value);
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["ID"], NewLateBinding.LateIndexGet(row.DataRow, new object[]
							{
								"ID"
							}, null), false);
							if (flag2)
							{
								dataRow2.Delete();
								this.dt.AcceptChanges();
								break;
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
			}
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0000205D File Offset: 0x0000025D
		private void GetChackeUsageInPardakhtForPardakht(GridEXRow row, DataTable dt2)
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x001A50A4 File Offset: 0x001A32A4
		private bool GetDasteCheckUsage(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = ((DataRowView)row.DataRow)["CheckBarg_ID"] != DBNull.Value;
			if (flag)
			{
				text = Conversions.ToString(((DataRowView)row.DataRow)["CheckBarg_ID"]);
			}
			else
			{
				text = "-1";
			}
			string text3 = string.Empty;
			flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
			if (flag)
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(" AND DaryaftPardakht.ID>", ((DataRowView)row.DataRow)["ID"]));
				text2 = Conversions.ToString(((DataRowView)row.DataRow)["ID"]);
			}
			else
			{
				text2 = "-1";
			}
			dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Sh_Check, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type=2 and DaryaftPardakht.CheckBarg_ID in(",
				text,
				") AND DaryaftPardakht.ID Not IN(",
				text2,
				")",
				text3
			}));
			flag = (dataTable.Rows.Count > 0);
			bool result;
			if (flag)
			{
				new Frm_DeleteDaryaftPardakht
				{
					ListDaryaft_Identity = this.ListDaryaft_Identity,
					dt_opr = dataTable
				}.ShowDialog();
				result = false;
			}
			else
			{
				this.DeletePardakhtRedif(row);
				result = true;
			}
			return result;
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x001A521C File Offset: 0x001A341C
		private void GetCheckUsagePardakht(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = ((DataRowView)row.DataRow)["pardakhtcheck_id"] != DBNull.Value;
			if (flag)
			{
				text = Conversions.ToString(((DataRowView)row.DataRow)["pardakhtcheck_id"]);
			}
			else
			{
				text = "-1";
			}
			string text3 = string.Empty;
			flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
			if (flag)
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(" AND DaryaftPardakht.ID>", ((DataRowView)row.DataRow)["ID"]));
				text2 = Conversions.ToString(((DataRowView)row.DataRow)["ID"]);
			}
			else
			{
				text2 = "-1";
			}
			dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Sh_Check, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type=2 and DaryaftPardakht.pardakhtcheck_id in(",
				text,
				") AND DaryaftPardakht.ID Not IN(",
				text2,
				")",
				text3
			}));
			this.GetChackeUsageInPardakhtForPardakht(row, dataTable);
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				new Frm_DeleteDaryaftPardakht
				{
					ListDaryaft_Identity = this.ListDaryaft_Identity,
					dt_opr = dataTable
				}.ShowDialog();
			}
			else
			{
				flag = (Public_Function.ShowMessage("آیا مایل به حذف ردیف مورد نظر میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag)
				{
					this.DeletePardakhtRedif(row);
					flag = (this.GridEX1.CurrentRow.RowType == RowType.Record);
					if (flag)
					{
						bool flag2 = this.GridEX1.GetRow().Cells["daryaft_identity"].Value != DBNull.Value;
						if (flag2)
						{
							this.Delete_Listdaryaft(Conversions.ToInteger(this.GridEX1.GetRow().Cells["daryaft_identity"].Value));
						}
						this.Update_MablaghNaghd(this.GridEX1.CurrentRow);
						CurrencyBox txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX1.CurrentRow.Cells["mablagh"].Value));
						this.GridEX1.CurrentRow.Delete();
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						this.GetSum();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x001A54CC File Offset: 0x001A36CC
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				this.Check_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
				if (flag)
				{
					this.BankHesab_Select();
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["check_shobe"].Position);
					if (flag)
					{
						this.Shobe_Select();
					}
					else
					{
						flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
						if (flag)
						{
							bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
							if (flag2)
							{
								this.GetCheckUsagePardakht(this.GridEX1.CurrentRow);
							}
							flag2 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
							if (flag2)
							{
								this.GridEX1.CancelCurrentEdit();
								this.GetSum();
							}
						}
					}
				}
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x001A55FC File Offset: 0x001A37FC
		private void Daste_Check_Select()
		{
			Frm_SelectDasteCheck frm_SelectDasteCheck = new Frm_SelectDasteCheck();
			bool flag = this.GridEX2.CurrentRow.Cells["CheckBarg_ID"].Value != DBNull.Value;
			if (flag)
			{
				Frm_SelectDasteCheck arg_68_0 = frm_SelectDasteCheck;
				object expr_56 = this.GridEX2.CurrentRow.Cells["CheckBarg_ID"].Value;
				int? num;
				arg_68_0.ID = ((expr_56 != null) ? ((int?)expr_56) : num);
			}
			string text = string.Empty;
			GridEXRow[] rows = this.GridEX2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (gridEXRow.Cells["Checkbarg_id"].Value != DBNull.Value);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(gridEXRow.Cells["Checkbarg_id"].Value, ",")));
					}
				}
				text = Public_Function.RemoveLast(text);
				frm_SelectDasteCheck.Notin_Me = text;
				frm_SelectDasteCheck.Notin_Pardakht = this.Notin_Pardakht;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SelectDasteCheck);
				flag = (frm_SelectDasteCheck.ShomareBarg != null);
				if (flag)
				{
					this.GridEX2.CurrentRow.Cells["Sh_Check"].Value = frm_SelectDasteCheck.ShomareBarg;
					this.GridEX2.CurrentRow.Cells["CheckBarg_ID"].Value = frm_SelectDasteCheck.ID;
					this.GridEX2.CurrentRow.Cells["BankHesab_Name"].Value = frm_SelectDasteCheck.BankHesab_Name;
					this.GridEX2.CurrentRow.Cells["BankHesab_ID"].Value = frm_SelectDasteCheck.BankHesab_ID;
					GridEX gridEX = this.GridEX2;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x000E9708 File Offset: 0x000E7908
		private void Update_MablaghNaghd(GridEXRow row)
		{
			bool flag = ((DataRowView)row.DataRow)["parent_id"] == DBNull.Value;
			if (!flag)
			{
				string text = "declare @id int;declare @sanadbed_id int;declare @mablagh bigint;";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" select @id=id,@sanadbed_id=sanadbed_id from daryaftpardakht  where parent_id=", ((DataRowView)row.DataRow)["parent_id"]), " and dptype_id=10;")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update daryaftpardakht set mablagh=mablagh+", row.Cells["mablagh"].Value), " where id=@id;")));
				text += "select @mablagh=mablagh from daryaftpardakht where id=@id;";
				text += " update sanad set bed=@mablagh where id=@sanadbed_id;";
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000E97CC File Offset: 0x000E79CC
		private void Update_MablaghNaghd(string Parent_id, string Mablagh)
		{
			string text = "declare @id int;declare @sanadbed_id int;declare @mablagh bigint;";
			text = text + " select @id=id,@sanadbed_id=sanadbed_id from daryaftpardakht  where parent_id=" + Parent_id + " and dptype_id=10;";
			text = text + " update daryaftpardakht set mablagh=mablagh+" + Mablagh + " where id=@id;";
			text += "select @mablagh=mablagh from daryaftpardakht where id=@id;";
			text += " update sanad set bed=@mablagh where id=@sanadbed_id;";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x001A57FC File Offset: 0x001A39FC
		private void Del_CheckBarg()
		{
			int value = Conversions.ToInteger(((DataRowView)this.GridEX2.CurrentRow.DataRow)["ID"]);
			string text = "declare @sanadbed_id int,@sanadbes_id int;select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=" + Conversions.ToString(value) + ";";
			text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id=" + Conversions.ToString(value);
			text += "delete from sanad where id=@sanadbed_id;";
			text += "delete from sanad where id=@sanadbes_id;";
			text = text + "delete from daryaftpardakht where id=" + Conversions.ToString(value);
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x001A588C File Offset: 0x001A3A8C
		private void Del_DasteCheck()
		{
			bool flag = this.GridEX2.CurrentRow.RowType == RowType.Record;
			bool flag2;
			if (flag)
			{
				flag2 = (((DataRowView)this.GridEX2.CurrentRow.DataRow)["ID"] == DBNull.Value);
				if (flag2)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
					this.GridEX2.CurrentRow.Delete();
					((DataTable)this.GridEX2.DataSource).AcceptChanges();
					this.GetSum();
					this.GridEX2.MoveToNewRecord();
					this.GridEX2.Col = 0;
					this.GridEX2.EditMode = EditMode.EditOn;
				}
				else
				{
					flag2 = (Public_Function.ShowMessage("آیا مایل به حذف پرداخت چک میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
					if (flag2)
					{
						flag = this.GetDasteCheckUsage(this.GridEX2.CurrentRow);
						if (flag)
						{
							this.Del_CheckBarg();
							this.Update_MablaghNaghd(this.GridEX2.CurrentRow);
							CurrencyBox txt_naghd = this.txt_naghd;
							txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
							this.GridEX2.CurrentRow.Delete();
							((DataTable)this.GridEX2.DataSource).AcceptChanges();
							this.GetSum();
							this.GridEX2.MoveToNewRecord();
							this.GridEX2.Col = 0;
							this.GridEX2.EditMode = EditMode.EditOn;
						}
					}
				}
			}
			flag2 = (this.GridEX2.CurrentRow.RowType == RowType.NewRecord);
			if (flag2)
			{
				flag = (this.GridEX2.CurrentRow.Cells["mablagh"].Value != null);
				if (flag)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
				}
				this.GridEX2.CancelCurrentEdit();
				this.GetSum();
				this.GridEX2.MoveToNewRecord();
				this.GridEX2.Col = this.GridEX2.RootTable.Columns["sh_check"].Position;
				this.GridEX2.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x001A5B30 File Offset: 0x001A3D30
		private void Check_Print()
		{
			bool flag = this.GridEX2.CurrentRow == null;
			if (!flag)
			{
				flag = !this.ValidateCurrentGridRow(this.GridEX2.CurrentRow.Position);
				if (!flag)
				{
					Frm_Check_Print frm_Check_Print = new Frm_Check_Print();
					DataTable dataTable = ((DataTable)this.GridEX2.DataSource).Clone();
					dataTable.ImportRow(((DataRowView)this.GridEX2.CurrentRow.DataRow).Row);
					dataTable.Rows[0]["mablagh"] = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["mablagh"].Value);
					dataTable.Rows[0]["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["Check_Sarresid_Fa"].Value);
					flag = (dataTable.Rows[0]["tozih"] == DBNull.Value);
					if (flag)
					{
					}
					frm_Check_Print.dt = dataTable;
					frm_Check_Print.Tozih = dataTable.Rows[0]["tozih"].ToString();
					frm_Check_Print.Moshtari_Name = this.Moshtari_Name;
					MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Check_Print);
					this.GridEX2.CurrentRow.BeginEdit();
					this.GridEX2.CurrentRow.Cells["tozih"].Value = frm_Check_Print.EditBox1.Text;
					this.GridEX2.CurrentRow.EndEdit();
				}
			}
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x001A5CE8 File Offset: 0x001A3EE8
		private void gridex3_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["sh_check"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
				GridEXRow[] rows2 = this.GridEX1.GetRows();
				for (int j = 0; j < rows2.Length; j++)
				{
					GridEXRow gridEXRow2 = rows2[j];
					bool flag = gridEXRow2.Cells["sh_check"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow2.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x001A5DA4 File Offset: 0x001A3FA4
		private void GridEX2_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = this.GridEX2.CurrentRow.Cells["mablagh"].Value == DBNull.Value;
			if (!flag)
			{
				flag = (e.Column.Position == this.GridEX2.RootTable.Columns["mablagh"].Position);
				if (flag)
				{
					bool flag2 = this.GridEX2.CurrentRow.Cells["mablagh2"].Value != null;
					bool flag3;
					if (flag2)
					{
						flag3 = Operators.ConditionalCompareObjectGreater(this.GridEX2.CurrentRow.Cells["mablagh"].Value, this.txt_naghd.Value, false);
						CurrencyBox txt_naghd;
						if (flag3)
						{
							this.GridEX2.CurrentRow.Cells["Mablagh"].Value = DBNull.Value;
							this.GridEX2.Col = this.GridEX2.RootTable.Columns["mablagh"].Position;
							txt_naghd = this.txt_naghd;
							txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh2"].Value));
							this.GridEX2.CurrentRow.Cells["mablagh2"].Value = null;
							return;
						}
						txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh2"].Value));
						this.GridEX2.CurrentRow.Cells["mablagh2"].Value = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["mablagh"].Value);
					}
					else
					{
						flag3 = Operators.ConditionalCompareObjectGreater(this.GridEX2.CurrentRow.Cells["mablagh"].Value, this.txt_naghd.Value, false);
						if (flag3)
						{
							this.GridEX2.CurrentRow.Cells["Mablagh"].Value = DBNull.Value;
							this.GridEX2.Col = this.GridEX2.RootTable.Columns["mablagh"].Position;
							return;
						}
						this.GridEX2.CurrentRow.Cells["mablagh2"].Value = RuntimeHelpers.GetObjectValue(this.GridEX2.CurrentRow.Cells["mablagh"].Value);
					}
					flag3 = (this.GridEX2.CurrentRow.Cells["mablagh"].Value != null);
					if (flag3)
					{
						CurrencyBox txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.SubtractObject(txt_naghd.Text, this.GridEX2.CurrentRow.Cells["mablagh"].Value));
					}
				}
			}
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x001A60F8 File Offset: 0x001A42F8
		private void GridEX2_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX2.RootTable.Columns["Sh_Check"].Position;
			if (flag)
			{
				this.Daste_Check_Select();
			}
			else
			{
				flag = (position == this.GridEX2.RootTable.Columns["del"].Position);
				if (flag)
				{
					this.Del_DasteCheck();
				}
				else
				{
					flag = (position == this.GridEX2.RootTable.Columns["print"].Position);
					if (flag)
					{
						this.Check_Print();
					}
				}
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x000EA1CC File Offset: 0x000E83CC
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "check_sarresid_fa", false) == 0;
			if (flag)
			{
				e.Value = ((DateBox2)e.EditControl).Text;
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (hasValue)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
				}
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x001A61A4 File Offset: 0x001A43A4
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "check_sarresid_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				flag = (e.Value != null);
				if (flag)
				{
					this.txt_tarikhGrid.SetDate(e.Value.ToString());
				}
				else
				{
					this.txt_tarikhGrid.SetDate("");
				}
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_mablagh;
					flag = (e.Value != null);
					if (flag)
					{
						this.txt_mablagh.Text = e.Value.ToString();
					}
					else
					{
						this.txt_mablagh.Text = string.Empty;
					}
					this.txt_mablagh.SelectAll();
				}
			}
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x001A6290 File Offset: 0x001A4490
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.GridEX2.Focus();
				this.GridEX2.MoveToNewRecord();
				this.GridEX2.Col = 0;
				this.GridEX2.EditMode = EditMode.EditOn;
			}
			flag = (this.GridEX1.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False);
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX1.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox != null);
						if (flag)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["CheckBank_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Up:
						flag2 = (this.GridEX1.Row > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX1;
							gridEX.Row--;
							e.SuppressKeyPress = true;
							return;
						}
						this.GridEX2.Focus();
						this.GridEX2.Col = 0;
						this.GridEX2.EditMode = EditMode.EditOn;
						break;
					case Keys.Down:
						flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
						if (flag2)
						{
							GridEX gridEX = this.GridEX1;
							gridEX.Row++;
							e.SuppressKeyPress = true;
							return;
						}
						this.txt_naghd.Focus();
						break;
					}
					flag2 = (e.KeyCode == Keys.Return);
					if (flag2)
					{
						int col = this.GridEX1.Col;
						flag = (col == this.GridEX1.RootTable.Columns["sh_check"].Position);
						if (flag)
						{
							bool flag3 = this.GridEX1.EditTextBox == null;
							if (flag3)
							{
								this.GridEX1.GetRow().BeginEdit();
							}
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Check_Select();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x001A654C File Offset: 0x001A474C
		private void MoveToNewRecord()
		{
			checked
			{
				bool flag = this.GridEX1.Row < this.GridEX1.RowCount - 1;
				if (flag)
				{
					this.GridEX1.Col = 0;
					GridEX gridEX = this.GridEX1;
					gridEX.Row++;
					this.GridEX1.Focus();
				}
			}
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x001A65AC File Offset: 0x001A47AC
		private void GridEX2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
			flag = (this.GridEX2.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False);
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX2.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX2.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX2.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX2.EditTextBox != null);
						if (flag)
						{
							this.GridEX2.EditTextBox.Text = string.Empty;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
						flag2 = this.prevent_left;
						if (flag2)
						{
							this.prevent_left = false;
							this.GridEX2.EditMode = EditMode.EditOn;
							return;
						}
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						GridEX gridEX = this.GridEX2;
						gridEX.Col++;
						e.SuppressKeyPress = true;
						this.GridEX2.EditMode = EditMode.EditOn;
						return;
					}
					case Keys.Up:
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Up));
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX2.Row > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX2;
							gridEX.Row--;
							this.GridEX2.EditMode = EditMode.EditOn;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					case Keys.Right:
						flag2 = this.prevent_right;
						if (flag2)
						{
							this.prevent_right = false;
							return;
						}
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX2.Col > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX2;
							gridEX.Col--;
							e.SuppressKeyPress = true;
							this.GridEX2.EditMode = EditMode.EditOn;
							return;
						}
						break;
					case Keys.Down:
						flag2 = (this.GridEX2.Col == this.GridEX2.RootTable.Columns["check_sarresid_fa"].Position);
						if (flag2)
						{
							this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Down));
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX2.Row < this.GridEX2.RowCount - 1);
						if (flag2)
						{
							GridEX gridEX = this.GridEX2;
							gridEX.Row++;
							this.GridEX2.EditMode = EditMode.EditOn;
							e.SuppressKeyPress = true;
							return;
						}
						this.GridEX1.Focus();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
						break;
					}
					flag2 = (e.KeyCode == Keys.Return);
					if (flag2)
					{
						int col = this.GridEX2.Col;
						flag = (col == this.GridEX2.RootTable.Columns["Sh_Check"].Position);
						if (flag)
						{
							bool flag3 = this.GridEX2.EditTextBox == null;
							if (flag3)
							{
								this.GridEX2.GetRow().BeginEdit();
							}
							flag3 = (Operators.CompareString(this.GridEX2.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Daste_Check_Select();
							}
						}
						else
						{
							bool flag3 = col == this.GridEX2.RootTable.Columns["Check_Sarresid_Fa"].Position;
							if (flag3)
							{
								this.GridEX2.UpdateData();
								this.GridEX2.MoveToNewRecord();
								this.GridEX2.Col = 0;
								this.GridEX2.EditMode = EditMode.EditOn;
							}
							else
							{
								GridEX gridEX = this.GridEX2;
								gridEX.Col++;
								this.GridEX2.EditMode = EditMode.EditOn;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x001A6AA0 File Offset: 0x001A4CA0
		private void GridEX2_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX2.Col == this.GridEX2.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			else
			{
				flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x001A6B28 File Offset: 0x001A4D28
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			else
			{
				flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position);
				if (!flag)
				{
					flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
					if (flag)
					{
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x001A6BE4 File Offset: 0x001A4DE4
		private void design_print()
		{
			StiReport stiReport = new StiReport();
			string str = Conversions.ToString(1);
			DataRow dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.Columns["sh_check"].ColumnName = "شماره_چک";
			dataTable2.Columns.Remove("ID");
			dataTable2.Columns.Remove("dptype_id");
			dataTable2.Columns.Remove("Tarikh");
			dataTable2.Columns.Remove("sanadbed_id");
			dataTable2.Columns.Remove("sanadbes_id");
			dataTable2.Columns.Remove("moshtari_id");
			dataTable2.Columns.Remove("sandug_id");
			dataTable2.Columns.Remove("bankhesab_id");
			dataTable2.Columns.Remove("tarikh_fa");
			dataTable2.Columns.Remove("checkbank_id");
			dataTable2.Columns.Remove("Parent_ID");
			dataTable2.Columns.Remove("dp_name");
			dataTable2.Columns.Remove("check_status");
			dataTable2.Columns.Remove("sh_fish");
			dataTable2.Columns.Remove("fishvariz");
			dataTable2.Columns.Remove("fishvariz_fa");
			dataTable2.Columns.Remove("hazine_ID");
			dataTable2.Columns.Remove("Hazine_Name");
			dataTable2.Columns.Remove("pardakhtcheck_ID");
			dataTable2.Columns.Remove("Tozih");
			dataTable2.Columns.Remove("check_sarresid");
			dataTable2.Columns.Remove("moshtari_name");
			dataTable2.Columns.Remove("checkbarg_id");
			dataTable2.Columns.Remove("daryaft_identity");
			dataTable2.Columns.Remove("is_child");
			dataTable2.Columns.Remove("identity");
			dataTable2.Columns.Remove("parent_identity");
			dataTable2.Columns.Remove("moshtari_id2");
			dataTable2.Columns.Remove("moshtari_name2");
			dataTable2.Columns["mablagh"].ColumnName = "مبلغ";
			dataTable2.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
			dataTable2.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
			dataTable2.Columns.Add(new DataColumn("shobe", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("huruf", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("تلفن", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("آدرس", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			try
			{
				IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator.Current;
					dataRow3["shobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["checkbank_name"], "/"), dataRow3["check_shobe"]);
					dataRow3["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow3["مبلغ"]), huruf.ConvertType.هیچکدام);
					dataRow3["تلفن"] = dataRow["tel"].ToString();
					dataRow3["آدرس"] = dataRow["address"].ToString();
					dataRow3["شماره_حساب"] = dataRow["sh_hesab"].ToString();
					dataRow3["صاحب_حساب"] = dataRow["sahebhesab"].ToString();
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
			dataTable2.Columns["shobe"].ColumnName = "بانک_چک";
			dataTable2.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
			dataTable2.Columns.Remove("checkbank_name");
			dataTable2.Columns.Remove("check_shobe");
			dataTable2.Columns.Remove("bankhesab_name");
			dataTable2.TableName = "data";
			stiReport.RegData(dataTable2);
			StiDataBand stiDataBand = new StiDataBand();
			stiDataBand.DataSourceName = "data";
			stiDataBand.Height = stiReport.Pages[0].Height;
			stiReport.Pages[0].Components.Add(stiDataBand);
			StiOptions.Designer.DontAskSaveReport = true;
			StiOptions.Designer.DontSaveDesignerConfig = true;
			StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
			StiOptions.Designer.AllowSaveStandaloneReport = false;
			StiOptions.Designer.CodeTabVisible = false;
			StiOptions.Designer.HtmlPreviewReportVisible = false;
			stiReport.Design();
			NewLateBinding.LateCall(stiReport, null, "Save", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow2["ID"]), ".mrt")
			}, null, null, null, true);
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x001A7218 File Offset: 0x001A5418
		private void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			string text = Conversions.ToString(1);
			DataTable dataTable = (DataTable)this.GridEX2.DataSource;
			DataRow dataRow2;
			DataRow dataRow3;
			bool flag2;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					string str = Conversions.ToString(dataRow["bankhesab_id"]);
					dataRow2 = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
					dataRow3 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow2["bank_ID"])));
					bool flag = !File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow3["ID"]), ".mrt")));
					if (flag)
					{
						flag2 = (Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگ واگذاری به بانک ", dataRow3["Name"]), "  طراحی نگردیده است"), Environment.NewLine), "آیا مایل به طراحی برگ میباشید؟")), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes);
						if (flag2)
						{
							this.design_print();
							return;
						}
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
			NewLateBinding.LateCall(stiReport, null, "Load", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow3["ID"]), ".mrt")
			}, null, null, null, true);
			DataTable dataTable2 = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable3 = dataTable2.Copy();
			dataTable3.Columns["sh_check"].ColumnName = "شماره_چک";
			dataTable3.Columns.Remove("ID");
			dataTable3.Columns.Remove("dptype_id");
			dataTable3.Columns.Remove("Tarikh");
			dataTable3.Columns.Remove("sanadbed_id");
			dataTable3.Columns.Remove("sanadbes_id");
			dataTable3.Columns.Remove("moshtari_id");
			dataTable3.Columns.Remove("sandug_id");
			dataTable3.Columns.Remove("bankhesab_id");
			dataTable3.Columns.Remove("tarikh_fa");
			dataTable3.Columns.Remove("Parent_ID");
			dataTable3.Columns.Remove("dp_name");
			dataTable3.Columns.Remove("check_status");
			dataTable3.Columns.Remove("sh_fish");
			dataTable3.Columns.Remove("fishvariz");
			dataTable3.Columns.Remove("fishvariz_fa");
			dataTable3.Columns.Remove("hazine_ID");
			dataTable3.Columns.Remove("Hazine_Name");
			dataTable3.Columns.Remove("pardakhtcheck_ID");
			dataTable3.Columns.Remove("Tozih");
			dataTable3.Columns.Remove("check_sarresid");
			dataTable3.Columns.Remove("moshtari_name");
			dataTable3.Columns.Remove("checkbarg_id");
			dataTable3.Columns.Remove("daryaft_identity");
			dataTable3.Columns.Remove("is_child");
			dataTable3.Columns.Remove("identity");
			dataTable3.Columns.Remove("parent_identity");
			dataTable3.Columns.Remove("moshtari_id2");
			dataTable3.Columns.Remove("moshtari_name2");
			dataTable3.Columns["mablagh"].ColumnName = "مبلغ";
			dataTable3.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
			dataTable3.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
			dataTable3.Columns.Add(new DataColumn("shobe", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("huruf", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("تلفن", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("آدرس", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			dataTable3.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			try
			{
				IEnumerator enumerator2 = dataTable3.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator2.Current;
					dataRow4["shobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow4["checkbank_name"], "/"), dataRow4["check_shobe"]);
					dataRow4["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow4["مبلغ"]), huruf.ConvertType.هیچکدام);
					dataRow4["تلفن"] = dataRow2["tel"].ToString();
					dataRow4["آدرس"] = dataRow2["address"].ToString();
					dataRow4["شماره_حساب"] = dataRow2["sh_hesab"].ToString();
					dataRow4["صاحب_حساب"] = dataRow2["sahebhesab"].ToString();
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
			dataTable3.Columns["shobe"].ColumnName = "بانک_چک";
			dataTable3.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
			dataTable3.Columns.Remove("checkbank_name");
			dataTable3.Columns.Remove("check_shobe");
			dataTable3.Columns.Remove("bankhesab_name");
			dataTable3.TableName = "data";
			stiReport.RegData(dataTable3);
			flag2 = !Design;
			if (flag2)
			{
				stiReport.Show();
			}
			else
			{
				StiOptions.Designer.DontAskSaveReport = true;
				StiOptions.Designer.DontSaveDesignerConfig = true;
				StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
				StiOptions.Designer.AllowSaveStandaloneReport = false;
				StiOptions.Designer.CodeTabVisible = false;
				StiOptions.Designer.HtmlPreviewReportVisible = false;
				stiReport.Design();
				NewLateBinding.LateCall(stiReport, null, "Save", new object[]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\checkprint\\", dataRow3["ID"]), ".mrt")
				}, null, null, null, true);
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x000090DF File Offset: 0x000072DF
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.ShowReport(false);
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x001A795C File Offset: 0x001A5B5C
		private void GridEX2_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX2.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["bankhesab_id"].Value == DBNull.Value && gridEXRow.Cells["checkbarg_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x000090EB File Offset: 0x000072EB
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x000090F6 File Offset: 0x000072F6
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			this.GetSum();
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x001A79DC File Offset: 0x001A5BDC
		private void txt_naghd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Down;
			if (flag)
			{
				this.txt_cart.Focus();
			}
			flag = (e.KeyCode == Keys.Up);
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x001A7A3C File Offset: 0x001A5C3C
		private void txt_cart_Validating(object sender, CancelEventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_cart.Text, string.Empty, false) == 0;
			if (flag)
			{
				bool flag2 = this.txt_cart.Tag != null;
				if (flag2)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.txt_cart.Tag));
					this.txt_cart.Tag = null;
				}
			}
			else
			{
				bool flag2 = this.txt_cart.Tag == null;
				if (flag2)
				{
					long? value = this.txt_cart.Value;
					bool arg_BC_0 = value.HasValue;
					long? value2 = this.txt_naghd.Value;
					bool? arg_E5_0;
					if (!(arg_BC_0 & value2.HasValue))
					{
						arg_E5_0 = null;
					}
					else
					{
						bool? flag3 = new bool?(value.GetValueOrDefault() > value2.GetValueOrDefault());
						arg_E5_0 = flag3;
					}
					bool? flag4 = arg_E5_0;
					flag = flag4.GetValueOrDefault();
					if (flag)
					{
						this.txt_cart.Text = string.Empty;
					}
					else
					{
						CurrencyBox txt_naghd = this.txt_naghd;
						Control arg_189_0 = txt_naghd;
						double num = Conversions.ToDouble(txt_naghd.Text);
						value2 = this.txt_cart.Value;
						double? arg_154_0;
						if (!value2.HasValue)
						{
							arg_154_0 = null;
						}
						else
						{
							double? num2 = new double?((double)value2.GetValueOrDefault());
							arg_154_0 = num2;
						}
						double? num3 = arg_154_0;
						double? arg_17F_0;
						if (!num3.HasValue)
						{
							arg_17F_0 = null;
						}
						else
						{
							double? num4 = new double?(num - num3.GetValueOrDefault());
							arg_17F_0 = num4;
						}
						arg_189_0.Text = Conversions.ToString((T)arg_17F_0);
						this.txt_cart.Tag = this.txt_cart.Value;
					}
				}
				else
				{
					flag2 = Operators.ConditionalCompareObjectGreater(this.txt_cart.Value, Operators.AddObject(this.txt_naghd.Value, this.txt_cart.Tag), false);
					if (flag2)
					{
						this.txt_cart.Text = string.Empty;
						flag2 = (this.txt_cart.Tag != null);
						if (flag2)
						{
							CurrencyBox txt_naghd = this.txt_naghd;
							txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.txt_cart.Tag));
							this.txt_cart.Tag = null;
						}
					}
					else
					{
						CurrencyBox txt_naghd = this.txt_naghd;
						txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.txt_cart.Tag));
						txt_naghd = this.txt_naghd;
						Control arg_2FA_0 = txt_naghd;
						double num = Conversions.ToDouble(txt_naghd.Text);
						long? value2 = this.txt_cart.Value;
						double? arg_2C5_0;
						if (!value2.HasValue)
						{
							arg_2C5_0 = null;
						}
						else
						{
							double? num3 = new double?((double)value2.GetValueOrDefault());
							arg_2C5_0 = num3;
						}
						double? num2 = arg_2C5_0;
						double? arg_2F0_0;
						if (!num2.HasValue)
						{
							arg_2F0_0 = null;
						}
						else
						{
							double? num4 = new double?(num - num2.GetValueOrDefault());
							arg_2F0_0 = num4;
						}
						arg_2FA_0.Text = Conversions.ToString((T)arg_2F0_0);
						this.txt_cart.Tag = this.txt_cart.Value;
					}
				}
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x001A7D68 File Offset: 0x001A5F68
		private void txt_cart_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف کارت به کارت میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				long value = 0L;
				flag = (this.txt_cart.Tag != null);
				if (flag)
				{
					CurrencyBox txt_naghd = this.txt_naghd;
					txt_naghd.Text = Conversions.ToString(Operators.AddObject(txt_naghd.Text, this.txt_cart.Tag));
					value = Conversions.ToLong(this.txt_cart.Tag);
					this.txt_cart.Tag = null;
					this.txt_cart.Text = string.Empty;
				}
				long? value2;
				this.txt_cart.Value = value2;
				this.txt_cart.Tag = null;
				this.txt_kart_bankhesab.SetNew();
				this.txt_babat_kart.SetNew();
				flag = (Operators.CompareString(this.Kart_be_Kart_ID, string.Empty, false) != 0);
				if (flag)
				{
					DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
					daryaftPardakht.DeleteDaryaftPardakhtRadif(this.Kart_be_Kart_ID, "", "");
					this.Update_MablaghNaghd(this.Pardakht_ID, Conversions.ToString(value));
					long mablagh_Kol = this.Mablagh_Kol;
					long? value3 = this.txt_naghd.Value;
					bool? arg_150_0;
					if (!value3.HasValue)
					{
						arg_150_0 = null;
					}
					else
					{
						bool? flag2 = new bool?(value3.GetValueOrDefault() == mablagh_Kol);
						arg_150_0 = flag2;
					}
					bool? flag3 = arg_150_0;
					flag = flag3.GetValueOrDefault();
					if (flag)
					{
						DataRow[] array = this.dt.Select("dptype_id=10");
						flag = (array.Length > 0);
						if (flag)
						{
							array[0]["mablagh"] = this.txt_naghd.Value;
						}
						array = this.dt.Select("dptype_id=29");
						flag = (array.Length > 0);
						if (flag)
						{
							array[0].Delete();
							this.dt.AcceptChanges();
						}
					}
				}
			}
		}

		// Token: 0x04000D99 RID: 3481
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000D9B RID: 3483
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000D9C RID: 3484
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000D9D RID: 3485
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x04000D9E RID: 3486
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000D9F RID: 3487
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000DA0 RID: 3488
		[AccessedThroughProperty("Highlighter1")]
		private Highlighter _Highlighter1;

		// Token: 0x04000DA1 RID: 3489
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000DA2 RID: 3490
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04000DA3 RID: 3491
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000DA4 RID: 3492
		[AccessedThroughProperty("lbl_jamcheck")]
		private LabelCommand _lbl_jamcheck;

		// Token: 0x04000DA5 RID: 3493
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000DA6 RID: 3494
		[AccessedThroughProperty("lbl_jamkol")]
		private LabelCommand _lbl_jamkol;

		// Token: 0x04000DA7 RID: 3495
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04000DA8 RID: 3496
		[AccessedThroughProperty("lbl_codem")]
		private LabelCommand _lbl_codem;

		// Token: 0x04000DA9 RID: 3497
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04000DAA RID: 3498
		[AccessedThroughProperty("lbl_name")]
		private LabelCommand _lbl_name;

		// Token: 0x04000DAB RID: 3499
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x04000DAC RID: 3500
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x04000DAD RID: 3501
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000DAE RID: 3502
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000DAF RID: 3503
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000DB0 RID: 3504
		[AccessedThroughProperty("txt_naghd")]
		private CurrencyBox _txt_naghd;

		// Token: 0x04000DB1 RID: 3505
		[AccessedThroughProperty("txt_cart")]
		private CurrencyBox _txt_cart;

		// Token: 0x04000DB2 RID: 3506
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000DB3 RID: 3507
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000DB4 RID: 3508
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000DB5 RID: 3509
		[AccessedThroughProperty("txt_kart_bankhesab")]
		private SelectItem _txt_kart_bankhesab;

		// Token: 0x04000DB6 RID: 3510
		[AccessedThroughProperty("txt_babat_kart")]
		private EditBox _txt_babat_kart;

		// Token: 0x04000DB7 RID: 3511
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x04000DB8 RID: 3512
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x04000DB9 RID: 3513
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000DBA RID: 3514
		[CompilerGenerated]
		private string _Tozih;

		// Token: 0x04000DBB RID: 3515
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x04000DBC RID: 3516
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x04000DBD RID: 3517
		[CompilerGenerated]
		private long _Mablagh_Kol;

		// Token: 0x04000DBE RID: 3518
		[CompilerGenerated]
		private int _HazineKharid_ID;

		// Token: 0x04000DBF RID: 3519
		[CompilerGenerated]
		private string _HazineKharid_Name;

		// Token: 0x04000DC0 RID: 3520
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x04000DC1 RID: 3521
		[CompilerGenerated]
		private string _Moshtari_ID;

		// Token: 0x04000DC2 RID: 3522
		[CompilerGenerated]
		private string _Pardakht_ID;

		// Token: 0x04000DC3 RID: 3523
		[CompilerGenerated]
		private string _Kart_be_Kart_ID;

		// Token: 0x04000DC4 RID: 3524
		private DaryaftPardakht dp;

		// Token: 0x04000DC5 RID: 3525
		private Sanad sanad;

		// Token: 0x04000DC6 RID: 3526
		private bool prevent;

		// Token: 0x04000DC7 RID: 3527
		private bool prevent_right;

		// Token: 0x04000DC8 RID: 3528
		private bool prevent_left;

		// Token: 0x04000DC9 RID: 3529
		private string notin;

		// Token: 0x04000DCA RID: 3530
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000DCB RID: 3531
		private string Notin_Pardakht;
	}
}
