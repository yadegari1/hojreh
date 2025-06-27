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
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Kavenegar.SDK;
using Kavenegar.SDK.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Export;

namespace FruitBox
{
	// Token: 0x0200010A RID: 266
	[DesignerGenerated]
	public partial class Frm_Safi : Form
	{
		// Token: 0x06002516 RID: 9494 RVA: 0x001BF45C File Offset: 0x001BD65C
		public Frm_Safi()
		{
			base.Load += new EventHandler(this.Frm_Safi_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Safi_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Safi_KeyDown);
			Frm_Safi.__ENCAddToList(this);
			this.furush = new Furush_Hag();
			this.Safi_Furush = new Safi_Furush();
			this.Sarak = new Safi_Extend();
			this.save = false;
			this.darsad_focus = false;
			this.calc_karmozd = false;
			this.calc_darsad = false;
			this.has_sarak = false;
			this.jens = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x001BF50C File Offset: 0x001BD70C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Safi.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Safi.__ENCList.Count == Frm_Safi.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Safi.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Safi.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Safi.__ENCList[num] = Frm_Safi.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Safi.__ENCList.RemoveRange(num, Frm_Safi.__ENCList.Count - num);
						Frm_Safi.__ENCList.Capacity = Frm_Safi.__ENCList.Count;
					}
					Frm_Safi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x001C357C File Offset: 0x001C177C
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x001C3594 File Offset: 0x001C1794
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.Grid_RizBar_CellEdited);
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.Grid_RizBar_InitCustomEdit);
				EndCustomEditEventHandler value4 = new EndCustomEditEventHandler(this.Grid_RizBar_EndCustomEdit);
				RowLoadEventHandler value5 = new RowLoadEventHandler(this.Grid_RizBar_LoadingRow);
				KeyEventHandler value6 = new KeyEventHandler(this.Grid_RizBar_KeyDown);
				bool flag = this._Grid_RizBar != null;
				if (flag)
				{
					this._Grid_RizBar.CellEdited -= value2;
					this._Grid_RizBar.InitCustomEdit -= value3;
					this._Grid_RizBar.EndCustomEdit -= value4;
					this._Grid_RizBar.LoadingRow -= value5;
					this._Grid_RizBar.KeyDown -= value6;
				}
				this._Grid_RizBar = value;
				flag = (this._Grid_RizBar != null);
				if (flag)
				{
					this._Grid_RizBar.CellEdited += value2;
					this._Grid_RizBar.InitCustomEdit += value3;
					this._Grid_RizBar.EndCustomEdit += value4;
					this._Grid_RizBar.LoadingRow += value5;
					this._Grid_RizBar.KeyDown += value6;
				}
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x001C369C File Offset: 0x001C189C
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x0000952B File Offset: 0x0000772B
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

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x001C36B4 File Offset: 0x001C18B4
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00009535 File Offset: 0x00007735
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x001C36CC File Offset: 0x001C18CC
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x001C36E4 File Offset: 0x001C18E4
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x001C3744 File Offset: 0x001C1944
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0000953F File Offset: 0x0000773F
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x001C375C File Offset: 0x001C195C
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x001C3774 File Offset: 0x001C1974
		internal virtual CurrencyBox txt_takhlie
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_takhlie;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_takhlie_TextChanged);
				bool flag = this._txt_takhlie != null;
				if (flag)
				{
					this._txt_takhlie.TextChanged -= value2;
				}
				this._txt_takhlie = value;
				flag = (this._txt_takhlie != null);
				if (flag)
				{
					this._txt_takhlie.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x001C37D4 File Offset: 0x001C19D4
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x00009549 File Offset: 0x00007749
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

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x001C37EC File Offset: 0x001C19EC
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00009553 File Offset: 0x00007753
		internal virtual CurrencyBox txt_jamFurush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jamFurush;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jamFurush = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x001C3804 File Offset: 0x001C1A04
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0000955D File Offset: 0x0000775D
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

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x001C381C File Offset: 0x001C1A1C
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x00009567 File Offset: 0x00007767
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

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x001C3834 File Offset: 0x001C1A34
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x001C384C File Offset: 0x001C1A4C
		internal virtual CurrencyBox txt_karmozd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_karmozd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_karmozd_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_karmozd_GotFocus);
				bool flag = this._txt_karmozd != null;
				if (flag)
				{
					this._txt_karmozd.KeyDown -= value2;
					this._txt_karmozd.GotFocus -= value3;
				}
				this._txt_karmozd = value;
				flag = (this._txt_karmozd != null);
				if (flag)
				{
					this._txt_karmozd.KeyDown += value2;
					this._txt_karmozd.GotFocus += value3;
				}
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x001C38D4 File Offset: 0x001C1AD4
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x00009571 File Offset: 0x00007771
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x001C38EC File Offset: 0x001C1AEC
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x001C3904 File Offset: 0x001C1B04
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
				EventHandler value2 = new EventHandler(this.txt_keraye_TextChanged);
				bool flag = this._txt_keraye != null;
				if (flag)
				{
					this._txt_keraye.TextChanged -= value2;
				}
				this._txt_keraye = value;
				flag = (this._txt_keraye != null);
				if (flag)
				{
					this._txt_keraye.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x001C3964 File Offset: 0x001C1B64
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x0000957B File Offset: 0x0000777B
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x001C397C File Offset: 0x001C1B7C
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x00009585 File Offset: 0x00007785
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x001C3994 File Offset: 0x001C1B94
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x001C39AC File Offset: 0x001C1BAC
		internal virtual CurrencyBox txt_mande
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mande;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_mande_GotFocus);
				bool flag = this._txt_mande != null;
				if (flag)
				{
					this._txt_mande.GotFocus -= value2;
				}
				this._txt_mande = value;
				flag = (this._txt_mande != null);
				if (flag)
				{
					this._txt_mande.GotFocus += value2;
				}
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x001C3A0C File Offset: 0x001C1C0C
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x0000958F File Offset: 0x0000778F
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

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x001C3A24 File Offset: 0x001C1C24
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x001C3A3C File Offset: 0x001C1C3C
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

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x001C3A9C File Offset: 0x001C1C9C
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x001C3AB4 File Offset: 0x001C1CB4
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

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x001C3B14 File Offset: 0x001C1D14
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x00009599 File Offset: 0x00007799
		internal virtual WarningBox WarningBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WarningBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WarningBox1 = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x001C3B2C File Offset: 0x001C1D2C
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x001C3B44 File Offset: 0x001C1D44
		internal virtual NumericBox txt_darsad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_darsad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_darsad_LostFocus);
				EventHandler value3 = new EventHandler(this.txt_darsad_GotFocus);
				bool flag = this._txt_darsad != null;
				if (flag)
				{
					this._txt_darsad.LostFocus -= value2;
					this._txt_darsad.GotFocus -= value3;
				}
				this._txt_darsad = value;
				flag = (this._txt_darsad != null);
				if (flag)
				{
					this._txt_darsad.LostFocus += value2;
					this._txt_darsad.GotFocus += value3;
				}
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x001C3BCC File Offset: 0x001C1DCC
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x001C3BE4 File Offset: 0x001C1DE4
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

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x001C3C44 File Offset: 0x001C1E44
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x000095A3 File Offset: 0x000077A3
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

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x001C3C5C File Offset: 0x001C1E5C
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x000095AD File Offset: 0x000077AD
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

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x001C3C74 File Offset: 0x001C1E74
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x000095B7 File Offset: 0x000077B7
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

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x001C3C8C File Offset: 0x001C1E8C
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x000095C1 File Offset: 0x000077C1
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

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x001C3CA4 File Offset: 0x001C1EA4
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x000095CB File Offset: 0x000077CB
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

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x001C3CBC File Offset: 0x001C1EBC
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x000095D5 File Offset: 0x000077D5
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

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x001C3CD4 File Offset: 0x001C1ED4
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x000095DF File Offset: 0x000077DF
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

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x001C3CEC File Offset: 0x001C1EEC
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x000095E9 File Offset: 0x000077E9
		internal virtual Label lbl_vurudbar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vurudbar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vurudbar = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x001C3D04 File Offset: 0x001C1F04
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x000095F3 File Offset: 0x000077F3
		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x001C3D1C File Offset: 0x001C1F1C
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x000095FD File Offset: 0x000077FD
		internal virtual Label lbl_tedadkol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tedadkol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tedadkol = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x001C3D34 File Offset: 0x001C1F34
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x00009607 File Offset: 0x00007807
		internal virtual Label lbl_baskulmabda
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_baskulmabda;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_baskulmabda = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x001C3D4C File Offset: 0x001C1F4C
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x00009611 File Offset: 0x00007811
		internal virtual Label lbl_baskul
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_baskul;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_baskul = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x001C3D64 File Offset: 0x001C1F64
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x0000961B File Offset: 0x0000781B
		internal virtual Label lbl_shmashin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_shmashin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_shmashin = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x001C3D7C File Offset: 0x001C1F7C
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x00009625 File Offset: 0x00007825
		internal virtual Label lbl_sh_barname
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_sh_barname;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_sh_barname = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x001C3D94 File Offset: 0x001C1F94
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x0000962F File Offset: 0x0000782F
		internal virtual Label lbl_sahebbar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_sahebbar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_sahebbar = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x001C3DAC File Offset: 0x001C1FAC
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x001C3DC4 File Offset: 0x001C1FC4
		internal virtual NumericBox txt_num
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
				EventHandler value2 = new EventHandler(this.txt_num_ButtonClick);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_num_KeyDown);
				CancelEventHandler value4 = new CancelEventHandler(this.txt_num_Validating);
				bool flag = this._txt_num != null;
				if (flag)
				{
					this._txt_num.ButtonClick -= value2;
					this._txt_num.KeyDown -= value3;
					this._txt_num.Validating -= value4;
				}
				this._txt_num = value;
				flag = (this._txt_num != null);
				if (flag)
				{
					this._txt_num.ButtonClick += value2;
					this._txt_num.KeyDown += value3;
					this._txt_num.Validating += value4;
				}
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x001C3E74 File Offset: 0x001C2074
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x00009639 File Offset: 0x00007839
		internal virtual MaskedEditBox txt_tarikh
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

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x001C3E8C File Offset: 0x001C208C
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x00009643 File Offset: 0x00007843
		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x001C3EA4 File Offset: 0x001C20A4
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x0000964D File Offset: 0x0000784D
		internal virtual MetroStatusBar MetroStatusBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetroStatusBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetroStatusBar1 = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x001C3EBC File Offset: 0x001C20BC
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x00009657 File Offset: 0x00007857
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

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x001C3ED4 File Offset: 0x001C20D4
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x00009661 File Offset: 0x00007861
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

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x001C3EEC File Offset: 0x001C20EC
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x0000966B File Offset: 0x0000786B
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

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x001C3F04 File Offset: 0x001C2104
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00009675 File Offset: 0x00007875
		internal virtual CurrencyBox txt_hezar2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hezar2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hezar2 = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x001C3F1C File Offset: 0x001C211C
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x0000967F File Offset: 0x0000787F
		internal virtual CurrencyBox txt_hezar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hezar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hezar1 = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x001C3F34 File Offset: 0x001C2134
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00009689 File Offset: 0x00007889
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x001C3F4C File Offset: 0x001C214C
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x00009693 File Offset: 0x00007893
		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x001C3F64 File Offset: 0x001C2164
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x001C3F7C File Offset: 0x001C217C
		internal virtual EditBox txt_tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tozih;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_tozih_KeyDown);
				bool flag = this._txt_tozih != null;
				if (flag)
				{
					this._txt_tozih.KeyDown -= value2;
				}
				this._txt_tozih = value;
				flag = (this._txt_tozih != null);
				if (flag)
				{
					this._txt_tozih.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x001C3FDC File Offset: 0x001C21DC
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0000969D File Offset: 0x0000789D
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

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x001C3FF4 File Offset: 0x001C21F4
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x001C400C File Offset: 0x001C220C
		internal virtual UIRadioButton UiRadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiRadioButton2_CheckedChanged);
				bool flag = this._UiRadioButton2 != null;
				if (flag)
				{
					this._UiRadioButton2.CheckedChanged -= value2;
				}
				this._UiRadioButton2 = value;
				flag = (this._UiRadioButton2 != null);
				if (flag)
				{
					this._UiRadioButton2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x001C406C File Offset: 0x001C226C
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x001C4084 File Offset: 0x001C2284
		internal virtual UIRadioButton UiRadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiRadioButton1_CheckedChanged);
				bool flag = this._UiRadioButton1 != null;
				if (flag)
				{
					this._UiRadioButton1.CheckedChanged -= value2;
				}
				this._UiRadioButton1 = value;
				flag = (this._UiRadioButton1 != null);
				if (flag)
				{
					this._UiRadioButton1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x001C40E4 File Offset: 0x001C22E4
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x000096A7 File Offset: 0x000078A7
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x001C40FC File Offset: 0x001C22FC
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x001C4114 File Offset: 0x001C2314
		internal virtual CurrencyBox txt_sayer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sayer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_takhlie_TextChanged);
				bool flag = this._txt_sayer != null;
				if (flag)
				{
					this._txt_sayer.TextChanged -= value2;
				}
				this._txt_sayer = value;
				flag = (this._txt_sayer != null);
				if (flag)
				{
					this._txt_sayer.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x001C4174 File Offset: 0x001C2374
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x000096B1 File Offset: 0x000078B1
		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x001C418C File Offset: 0x001C238C
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x000096BB File Offset: 0x000078BB
		internal virtual MaskedEditBox txt_saat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_saat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_saat = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x001C41A4 File Offset: 0x001C23A4
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x000096C5 File Offset: 0x000078C5
		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x001C41BC File Offset: 0x001C23BC
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x001C41D4 File Offset: 0x001C23D4
		internal virtual UIRadioButton UiRadioButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiRadioButton2_CheckedChanged);
				bool flag = this._UiRadioButton3 != null;
				if (flag)
				{
					this._UiRadioButton3.CheckedChanged -= value2;
				}
				this._UiRadioButton3 = value;
				flag = (this._UiRadioButton3 != null);
				if (flag)
				{
					this._UiRadioButton3.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x001C4234 File Offset: 0x001C2434
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x000096CF File Offset: 0x000078CF
		internal virtual DataEntryGrid Grid_rizFurush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid_rizFurush;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Grid_rizFurush = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x001C424C File Offset: 0x001C244C
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x000096D9 File Offset: 0x000078D9
		internal virtual Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x001C4264 File Offset: 0x001C2464
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x001C427C File Offset: 0x001C247C
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

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x001C42DC File Offset: 0x001C24DC
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x001C42F4 File Offset: 0x001C24F4
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

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x001C4354 File Offset: 0x001C2554
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x001C436C File Offset: 0x001C256C
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x001C43CC File Offset: 0x001C25CC
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x001C43E4 File Offset: 0x001C25E4
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

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x001C4444 File Offset: 0x001C2644
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x000096E3 File Offset: 0x000078E3
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

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x001C445C File Offset: 0x001C265C
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x001C4474 File Offset: 0x001C2674
		internal virtual UIRadioButton UiRadioButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiRadioButton2_CheckedChanged);
				bool flag = this._UiRadioButton4 != null;
				if (flag)
				{
					this._UiRadioButton4.CheckedChanged -= value2;
				}
				this._UiRadioButton4 = value;
				flag = (this._UiRadioButton4 != null);
				if (flag)
				{
					this._UiRadioButton4.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x001C44D4 File Offset: 0x001C26D4
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x001C44EC File Offset: 0x001C26EC
		internal virtual CurrencyBox txt_mablagh2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_jam_kol_KeyDown);
				bool flag = this._txt_mablagh2 != null;
				if (flag)
				{
					this._txt_mablagh2.KeyDown -= value2;
				}
				this._txt_mablagh2 = value;
				flag = (this._txt_mablagh2 != null);
				if (flag)
				{
					this._txt_mablagh2.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x001C454C File Offset: 0x001C274C
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x000096ED File Offset: 0x000078ED
		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x001C4564 File Offset: 0x001C2764
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x001C457C File Offset: 0x001C277C
		internal virtual CurrencyBox txt_jamkol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jamkol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_jam_kol_KeyDown);
				bool flag = this._txt_jamkol != null;
				if (flag)
				{
					this._txt_jamkol.KeyDown -= value2;
				}
				this._txt_jamkol = value;
				flag = (this._txt_jamkol != null);
				if (flag)
				{
					this._txt_jamkol.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x001C45DC File Offset: 0x001C27DC
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x001C45F4 File Offset: 0x001C27F4
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

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x001C4654 File Offset: 0x001C2854
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x001C466C File Offset: 0x001C286C
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

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x001C46CC File Offset: 0x001C28CC
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x000096F7 File Offset: 0x000078F7
		public long? Furush_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_ID = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x001C46E4 File Offset: 0x001C28E4
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x001C4748 File Offset: 0x001C2948
		private int Safi_Type
		{
			get
			{
				bool @checked = this.UiRadioButton1.Checked;
				int result;
				if (@checked)
				{
					result = 1;
				}
				else
				{
					@checked = this.UiRadioButton2.Checked;
					if (@checked)
					{
						result = 2;
					}
					else
					{
						@checked = this.UiRadioButton3.Checked;
						if (@checked)
						{
							result = 3;
						}
						else
						{
							@checked = this.UiRadioButton4.Checked;
							if (@checked)
							{
								result = 4;
							}
							else
							{
								result = 1;
							}
						}
					}
				}
				return result;
			}
			set
			{
				switch (value)
				{
				case 1:
					this.UiRadioButton1.Checked = true;
					this.UiRadioButton1_CheckedChanged(null, null);
					break;
				case 2:
					this.UiRadioButton2.Checked = true;
					this.UiRadioButton2_CheckedChanged(null, null);
					break;
				case 3:
					this.UiRadioButton3.Checked = true;
					this.UiRadioButton2_CheckedChanged(null, null);
					break;
				case 4:
					this.UiRadioButton4.Checked = true;
					this.UiRadioButton2_CheckedChanged(null, null);
					break;
				}
			}
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x001C47D8 File Offset: 0x001C29D8
		private bool Validate_Mablagh()
		{
			string arg_26_0 = "select id,jam_kol from furush_hag_detail where furush_hug_id=";
			long? furush_ID = this.Furush_ID;
			DataTable dataTable = Public_Function.FillData(arg_26_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null));
			int num = 1;
			checked
			{
				bool result;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["jam_kol"] == DBNull.Value;
						if (flag)
						{
							this.WarningBox1.Visible = true;
							WarningBox warningBox = this.WarningBox1;
							warningBox.Text = warningBox.Text + "<b>مبلغ فروش ردیف " + Conversions.ToString(num) + " وارد نگردیده است </b>";
							result = false;
							return result;
						}
						flag = Operators.ConditionalCompareObjectEqual(dataRow["jam_kol"], 0, false);
						if (flag)
						{
							this.WarningBox1.Visible = true;
							WarningBox warningBox = this.WarningBox1;
							warningBox.Text = warningBox.Text + "<b>مبلغ فروش ردیف " + Conversions.ToString(num) + " وارد نگردیده است </b>";
							result = false;
							return result;
						}
						num++;
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
				result = true;
				return result;
			}
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x001C493C File Offset: 0x001C2B3C
		private bool Validate_Vazn()
		{
			string arg_26_0 = "select baskul from furush_hag where id=";
			long? furush_ID = this.Furush_ID;
			object obj = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar(arg_26_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
			bool flag = obj == DBNull.Value;
			if (flag)
			{
				obj = 0;
			}
			flag = Operators.ConditionalCompareObjectEqual(obj, 0, false);
			if (flag)
			{
				string arg_84_0 = "select isnull(baskul_mabda,0) from furush_hag where id=";
				furush_ID = this.Furush_ID;
				obj = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar(arg_84_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
			}
			flag = Operators.ConditionalCompareObjectEqual(obj, 0, false);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				string[] array = new string[5];
				array[0] = "select isnull(sum(vazn_ba_zarf),0) from furush_hag_detail where furush_hug_id=";
				string[] arg_E2_0 = array;
				int arg_E2_1 = 1;
				furush_ID = this.Furush_ID;
				arg_E2_0[arg_E2_1] = (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null);
				array[2] = " AND kala_id not in(select kala_id from furush_hag_rizbar where furush_hag_id=";
				string[] arg_10F_0 = array;
				int arg_10F_1 = 3;
				long? furush_ID2 = this.Furush_ID;
				arg_10F_0[arg_10F_1] = (furush_ID2.HasValue ? Conversions.ToString(furush_ID2.GetValueOrDefault()) : null);
				array[4] = " and vazn=0 ) ";
				decimal num = Conversions.ToDecimal(Public_Function.ExecuteScalar(string.Concat(array)));
				flag = Operators.ConditionalCompareObjectGreater(num, obj, false);
				if (flag)
				{
					this.WarningBox1.Visible = true;
					WarningBox warningBox = this.WarningBox1;
					warningBox.Text = warningBox.Text + "<b> وزن بار فروخته شده به میزان " + Operators.SubtractObject(num, obj).ToString().Replace(".0", "") + " واحد بیشتر از وزن باسکول میباشد </b>";
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x001C4AE4 File Offset: 0x001C2CE4
		private bool Validate_Tedad()
		{
			string arg_26_0 = "select tedad_kol from furush_hag where id=";
			long? furush_ID = this.Furush_ID;
			object obj = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar(arg_26_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
			bool flag = obj == DBNull.Value;
			if (flag)
			{
				obj = 0;
			}
			this.WarningBox1.Text = string.Empty;
			string arg_82_0 = "select isnull(sum(Tedad),0) from furush_hag_detail where furush_hug_id=";
			furush_ID = this.Furush_ID;
			decimal num = Conversions.ToDecimal(Public_Function.ExecuteScalar(arg_82_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
			flag = Operators.ConditionalCompareObjectLess(num, obj, false);
			bool result;
			if (flag)
			{
				this.WarningBox1.Visible = true;
				WarningBox warningBox = this.WarningBox1;
				warningBox.Text = warningBox.Text + "<b>تعداد بار فروخته شده به میزان " + Conversions.ToString(Public_Function.GetDecimalValue(Conversions.ToDecimal(Operators.SubtractObject(obj, num)))) + " واحد کمتر از تعداد کل بار میباشد </b><br></br><br></br>";
				result = false;
			}
			else
			{
				flag = Operators.ConditionalCompareObjectNotEqual(obj, 0, false);
				if (flag)
				{
					bool flag2 = Operators.ConditionalCompareObjectGreater(num, obj, false);
					if (flag2)
					{
						this.WarningBox1.Visible = true;
						WarningBox warningBox = this.WarningBox1;
						warningBox.Text = warningBox.Text + "<b>تعداد بار فروخته شده به میزان " + Conversions.ToString(Public_Function.GetDecimalValue(Conversions.ToDecimal(Operators.SubtractObject(num, obj)))) + " واحد بیشتر از تعداد کل بار میباشد </b><br></br><br></br>";
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x001C4C64 File Offset: 0x001C2E64
		private void safibarvazn()
		{
			bool flag = this.UiRadioButton2.Checked;
			checked
			{
				if (flag)
				{
					decimal num = Conversions.ToDecimal(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["vazn_ba_zarf"], AggregateFunction.Sum));
					flag = (decimal.Compare(num, decimal.Zero) == 0);
					if (flag)
					{
						this.UiRadioButton1.Checked = true;
						Public_Function.ShowTip(this.UiRadioButton2, "وزن با ظرف وارد نگردیده است");
						return;
					}
					decimal num2 = new decimal(Conversions.ToDouble(this.txt_jamFurush.Text) / Convert.ToDouble(num));
					int num3 = 0;
					try
					{
						IEnumerator enumerator = ((DataTable)this.Grid_RizBar.DataSource).Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							this.Grid_RizBar.GetRow(num3).BeginEdit();
							this.Grid_RizBar.GetRow(num3).Cells["Mablagh"].Value = decimal.Truncate(Conversions.ToDecimal(Operators.MultiplyObject(num2, dataRow["Vazn_Kol"])));
							flag = (Operators.CompareString(this.txt_karmozd.Text, string.Empty, false) != 0);
							if (flag)
							{
								this.Grid_RizBar.GetRow(num3).Cells["karmozd"].Value = decimal.Truncate(Conversions.ToDecimal(Operators.MultiplyObject(Operators.DivideObject(this.Grid_RizBar.GetRow(num3).Cells["jam_kol"].Value, 100), this.txt_darsad.Text)));
							}
							flag = (Operators.CompareString(this.txt_keraye.Text, string.Empty, false) != 0);
							if (flag)
							{
								this.Grid_RizBar.GetRow(num3).Cells["keraye"].Value = decimal.Truncate(Conversions.ToDecimal(Operators.MultiplyObject(Conversions.ToDouble(this.txt_keraye.Text) / Convert.ToDouble(num), dataRow["Vazn_Ba_Zarf"])));
							}
							flag = (Operators.CompareString(this.txt_takhlie.Text, string.Empty, false) != 0);
							if (flag)
							{
								this.Grid_RizBar.GetRow(num3).Cells["makharej"].Value = decimal.Truncate(Conversions.ToDecimal(Operators.MultiplyObject(Conversions.ToDouble(this.txt_takhlie.Text) / Convert.ToDouble(num), dataRow["vazn_Ba_Zarf"])));
							}
							flag = (Operators.CompareString(this.txt_sayer.Text, string.Empty, false) != 0);
							if (flag)
							{
								this.Grid_RizBar.GetRow(num3).Cells["sayer"].Value = decimal.Truncate(Conversions.ToDecimal(Operators.MultiplyObject(Conversions.ToDouble(this.txt_sayer.Text) / Convert.ToDouble(num), dataRow["vazn_Ba_Zarf"])));
								flag = (this.Grid_RizBar.GetRow(num3).Cells["makharej"].Value != DBNull.Value);
								if (flag)
								{
									this.Grid_RizBar.GetRow(num3).Cells["sayer"].Value = Operators.AddObject(this.Grid_RizBar.GetRow(num3).Cells["sayer"].Value, this.Grid_RizBar.GetRow(num3).Cells["makharej"].Value);
								}
							}
							this.Grid_RizBar.GetRow(num3).EndEdit();
							num3++;
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
					long num4 = Conversions.ToLong(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
					long? value = this.txt_jamFurush.Value;
					bool? arg_47C_0;
					if (!value.HasValue)
					{
						arg_47C_0 = null;
					}
					else
					{
						bool? flag2 = new bool?(num4 < value.GetValueOrDefault());
						arg_47C_0 = flag2;
					}
					bool? flag3 = arg_47C_0;
					flag = flag3.GetValueOrDefault();
					long? value2;
					if (flag)
					{
						this.Grid_RizBar.GetRow(0).BeginEdit();
						GridEXCell gridEXCell = this.Grid_RizBar.GetRow(0).Cells["Mablagh"];
						GridEXCell arg_506_0 = gridEXCell;
						object arg_501_0 = gridEXCell.Value;
						value = this.txt_jamFurush.Value;
						long? arg_4FC_0;
						if (!value.HasValue)
						{
							arg_4FC_0 = null;
						}
						else
						{
							value2 = new long?(value.GetValueOrDefault() - num4);
							arg_4FC_0 = value2;
						}
						arg_506_0.Value = Operators.AddObject(arg_501_0, arg_4FC_0);
						this.Grid_RizBar.GetRow(0).EndEdit();
					}
					num4 = Conversions.ToLong(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["karmozd"], AggregateFunction.Sum));
					value2 = this.txt_karmozd.Value;
					flag = value2.HasValue;
					bool flag4;
					if (flag)
					{
						value = this.txt_karmozd.Value;
						bool? arg_5A0_0;
						if (!value.HasValue)
						{
							arg_5A0_0 = null;
						}
						else
						{
							flag3 = new bool?(num4 < value.GetValueOrDefault());
							arg_5A0_0 = flag3;
						}
						bool? flag2 = arg_5A0_0;
						flag4 = flag2.GetValueOrDefault();
						if (flag4)
						{
							this.Grid_RizBar.GetRow(0).BeginEdit();
							GridEXCell gridEXCell = this.Grid_RizBar.GetRow(0).Cells["karmozd"];
							GridEXCell arg_62A_0 = gridEXCell;
							object arg_625_0 = gridEXCell.Value;
							value2 = this.txt_karmozd.Value;
							long? arg_620_0;
							if (!value2.HasValue)
							{
								arg_620_0 = null;
							}
							else
							{
								value = new long?(value2.GetValueOrDefault() - num4);
								arg_620_0 = value;
							}
							arg_62A_0.Value = Operators.AddObject(arg_625_0, arg_620_0);
							this.Grid_RizBar.GetRow(0).EndEdit();
						}
					}
					num4 = Conversions.ToLong(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["keraye"], AggregateFunction.Sum));
					value2 = this.txt_keraye.Value;
					flag4 = value2.HasValue;
					if (flag4)
					{
						value = this.txt_keraye.Value;
						bool? arg_6C5_0;
						if (!value.HasValue)
						{
							arg_6C5_0 = null;
						}
						else
						{
							flag3 = new bool?(num4 < value.GetValueOrDefault());
							arg_6C5_0 = flag3;
						}
						bool? flag2 = arg_6C5_0;
						flag = flag2.GetValueOrDefault();
						if (flag)
						{
							this.Grid_RizBar.GetRow(0).BeginEdit();
							GridEXCell gridEXCell = this.Grid_RizBar.GetRow(0).Cells["keraye"];
							GridEXCell arg_74F_0 = gridEXCell;
							object arg_74A_0 = gridEXCell.Value;
							value2 = this.txt_keraye.Value;
							long? arg_745_0;
							if (!value2.HasValue)
							{
								arg_745_0 = null;
							}
							else
							{
								value = new long?(value2.GetValueOrDefault() - num4);
								arg_745_0 = value;
							}
							arg_74F_0.Value = Operators.AddObject(arg_74A_0, arg_745_0);
							this.Grid_RizBar.GetRow(0).EndEdit();
						}
					}
					num4 = Conversions.ToLong(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["makharej"], AggregateFunction.Sum));
					value2 = this.txt_takhlie.Value;
					flag4 = value2.HasValue;
					if (flag4)
					{
						value = this.txt_takhlie.Value;
						bool? arg_7EA_0;
						if (!value.HasValue)
						{
							arg_7EA_0 = null;
						}
						else
						{
							flag3 = new bool?(num4 < value.GetValueOrDefault());
							arg_7EA_0 = flag3;
						}
						bool? flag2 = arg_7EA_0;
						flag = flag2.GetValueOrDefault();
						if (flag)
						{
							this.Grid_RizBar.GetRow(0).BeginEdit();
							flag4 = (this.Grid_RizBar.GetRow(0).Cells["makharej"].Value != DBNull.Value);
							if (flag4)
							{
								GridEXCell gridEXCell = this.Grid_RizBar.GetRow(0).Cells["makharej"];
								GridEXCell arg_8A4_0 = gridEXCell;
								object arg_89F_0 = gridEXCell.Value;
								value2 = this.txt_takhlie.Value;
								long? arg_89A_0;
								if (!value2.HasValue)
								{
									arg_89A_0 = null;
								}
								else
								{
									value = new long?(value2.GetValueOrDefault() - num4);
									arg_89A_0 = value;
								}
								arg_8A4_0.Value = Operators.AddObject(arg_89F_0, arg_89A_0);
							}
							this.Grid_RizBar.GetRow(0).EndEdit();
						}
					}
					num4 = Conversions.ToLong(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["sayer"], AggregateFunction.Sum));
					long num5 = 0L;
					value2 = this.txt_takhlie.Value;
					flag4 = value2.HasValue;
					long? value3;
					if (flag4)
					{
						value = this.txt_takhlie.Value;
						long? arg_940_0;
						if (!value.HasValue)
						{
							arg_940_0 = null;
						}
						else
						{
							value3 = new long?(num5 + value.GetValueOrDefault());
							arg_940_0 = value3;
						}
						num5 = (T)arg_940_0;
					}
					value3 = this.txt_sayer.Value;
					flag4 = value3.HasValue;
					if (flag4)
					{
						value2 = this.txt_sayer.Value;
						long? arg_998_0;
						if (!value2.HasValue)
						{
							arg_998_0 = null;
						}
						else
						{
							value = new long?(num5 + value2.GetValueOrDefault());
							arg_998_0 = value;
						}
						num5 = (T)arg_998_0;
					}
					flag4 = (num4 < num5);
					if (flag4)
					{
						this.Grid_RizBar.GetRow(0).BeginEdit();
						GridEXCell gridEXCell = this.Grid_RizBar.GetRow(0).Cells["sayer"];
						gridEXCell.Value = Operators.AddObject(gridEXCell.Value, num5 - num4);
						this.Grid_RizBar.GetRow(0).EndEdit();
					}
				}
				GridEXRow[] rows = this.Grid_RizBar.GetRows();
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					long num6 = 0L;
					gridEXRow.BeginEdit();
					num6 = Conversions.ToLong(Operators.AddObject(num6, gridEXRow.Cells["jam_kol"].Value));
					bool flag4 = gridEXRow.Cells["karmozd"].Value != DBNull.Value;
					if (flag4)
					{
						num6 = Conversions.ToLong(Operators.SubtractObject(num6, gridEXRow.Cells["karmozd"].Value));
					}
					flag4 = (gridEXRow.Cells["keraye"].Value != DBNull.Value);
					if (flag4)
					{
						num6 = Conversions.ToLong(Operators.SubtractObject(num6, gridEXRow.Cells["keraye"].Value));
					}
					flag4 = !this.UiRadioButton2.Checked;
					if (flag4)
					{
						flag = (gridEXRow.Cells["makharej"].Value != DBNull.Value);
						if (flag)
						{
							num6 = Conversions.ToLong(Operators.SubtractObject(num6, gridEXRow.Cells["makharej"].Value));
						}
					}
					flag4 = (gridEXRow.Cells["sayer"].Value != DBNull.Value);
					if (flag4)
					{
						num6 = Conversions.ToLong(Operators.SubtractObject(num6, gridEXRow.Cells["sayer"].Value));
					}
					gridEXRow.Cells["mande"].Value = num6;
					gridEXRow.EndEdit();
				}
			}
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x001C5878 File Offset: 0x001C3A78
		private void LoadData(bool save = false)
		{
			this.WarningBox1.Text = string.Empty;
			this.WarningBox1.Visible = false;
			this.ButtonItem2.Enabled = true;
			string arg_52_0 = "SELECT        Furush_Hag.ID, Furush_Hag.Num, Furush_Hag.Moshtari_ID, Furush_Hag.Sh_Mashin, Furush_Hag.Sh_Barname, Furush_Hag.Tarikh_Vurud, Furush_Hag.[Desc],   Furush_Hag.Baskul, Furush_Hag.Baskul_Mabda, Furush_Hag.Tedad_Kol,  Moshtari.Name + ' ' + Moshtari.Family AS Name,Moshtari.karmozd,tel1,tel2,tel3,tel4  FROM            Furush_Hag INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID where Furush_Hag.id=";
			long? furush_ID = this.Furush_ID;
			this.dr_furush = Public_Function.FillDataRow(arg_52_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null));
			bool flag = this.dr_furush != null;
			bool flag2;
			if (flag)
			{
				flag2 = (this.dr_furush["baskul"] != DBNull.Value);
				if (flag2)
				{
					this.dr_furush["baskul"] = this.dr_furush["baskul"].ToString().Replace(".0", "");
				}
				flag2 = (this.dr_furush["tedad_kol"] != DBNull.Value);
				if (flag2)
				{
					this.dr_furush["tedad_kol"] = this.dr_furush["tedad_kol"].ToString().Replace(".0", "");
				}
				this.lbl_sahebbar.Text = Conversions.ToString(this.dr_furush["name"]);
				this.lbl_vurudbar.Text = Conversions.ToString(this.dr_furush["Tarikh_Vurud"]);
				flag2 = (this.dr_furush["baskul"] != DBNull.Value);
				if (flag2)
				{
					this.lbl_baskul.Text = this.dr_furush["baskul"].ToString().Replace(".0", "");
				}
				this.lbl_baskulmabda.Text = this.dr_furush["baskul_mabda"].ToString();
				this.lbl_sh_barname.Text = this.dr_furush["sh_barname"].ToString();
				this.lbl_shmashin.Text = this.dr_furush["sh_mashin"].ToString();
				flag2 = (this.dr_furush["tedad_kol"] != DBNull.Value);
				if (flag2)
				{
					this.lbl_tedadkol.Text = this.dr_furush["tedad_kol"].ToString().Replace(".0", "");
				}
			}
			else
			{
				this.lbl_sahebbar.Text = string.Empty;
				this.lbl_vurudbar.Text = string.Empty;
				this.lbl_baskul.Text = string.Empty;
				this.lbl_baskulmabda.Text = string.Empty;
				this.lbl_sh_barname.Text = string.Empty;
				this.lbl_shmashin.Text = string.Empty;
				this.lbl_tedadkol.Text = string.Empty;
				this.txt_keraye.Text = string.Empty;
				this.txt_takhlie.Text = string.Empty;
			}
			string arg_333_0 = "SELECT    HazineKharid_ID,  ISNULL(sum( Furush_Keraye.Keraye),0) as keraye  FROM         Furush_Keraye INNER JOIN  Hazine_Kharid ON Furush_Keraye.HazineKharid_ID = Hazine_Kharid.ID  where furush_id=";
			furush_ID = this.Furush_ID;
			DataTable dataTable = Public_Function.FillData(arg_333_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null) + " group by HazineKharid_ID");
			DataRow[] array = dataTable.Select("HazineKharid_ID=-4");
			flag2 = (array.Length > 0);
			long num;
			if (flag2)
			{
				num = Conversions.ToLong(array[0]["keraye"]);
			}
			array = dataTable.Select("HazineKharid_ID=-6");
			flag2 = (array.Length > 0);
			if (flag2)
			{
				num = Conversions.ToLong(Operators.AddObject(num, array[0]["keraye"]));
			}
			this.txt_keraye.Text = Conversions.ToString(num);
			array = dataTable.Select("HazineKharid_ID=-5");
			flag2 = (array.Length > 0);
			if (flag2)
			{
				this.txt_takhlie.Text = Conversions.ToString(array[0]["keraye"]);
			}
			int num2 = 0;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["HazineKharid_ID"], -4, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["HazineKharid_ID"], -5, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["HazineKharid_ID"], -6, false));
					if (flag2)
					{
						num2 = Conversions.ToInteger(Operators.AddObject(num2, dataRow["keraye"]));
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
			this.txt_sayer.Text = Conversions.ToString(num2);
			string arg_506_0 = " SELECT        Furush_Hag_Detail.Kala_ID, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf,  SUM(Furush_Hag_Detail.Vazn_Kol) AS Vazn_Kol, SUM(Furush_Hag_Detail.Jam_Kol) AS Jam_Kol  ,case when SUM(Furush_Hag_Detail.Vazn_Kol) <>0 then  SUM(Furush_Hag_Detail.Jam_Kol)   / isnull( SUM(Furush_Hag_Detail.Vazn_Kol),1)  else SUM(Furush_Hag_Detail.Jam_Kol)   / isnull( SUM(Furush_Hag_Detail.Tedad),1)  end  AS gheymat , MIN(Kala.Name) AS Kala_Name   FROM            Furush_Hag_Detail INNER JOIN   Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID   WHERE Furush_Hag_Detail.Furush_Hug_ID = ";
			furush_ID = this.Furush_ID;
			DataTable dataTable2 = Public_Function.FillData(arg_506_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null) + "  GROUP BY Furush_Hag_Detail.Kala_ID ");
			dataTable2.TableName = "data";
			this.jens = string.Empty;
			try
			{
				IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					this.jens = Conversions.ToString(Operators.ConcatenateObject(this.jens, Operators.ConcatenateObject(dataRow2["kala_name"], "-")));
					flag2 = (dataRow2["tedad"] != DBNull.Value);
					if (flag2)
					{
						dataRow2["tedad"] = dataRow2["tedad"].ToString().Replace(".0", "");
					}
					flag2 = (dataRow2["vazn_ba_zarf"] != DBNull.Value);
					if (flag2)
					{
						dataRow2["Vazn_ba_Zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow2["Vazn_ba_Zarf"]));
					}
					flag2 = (dataRow2["vazn_kol"] != DBNull.Value);
					if (flag2)
					{
						dataRow2["Vazn_Kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow2["Vazn_Kol"]));
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
			flag2 = (this.jens.Length > 0);
			if (flag2)
			{
				this.jens = Public_Function.RemoveLast(this.jens);
			}
			flag2 = (dataTable2.Rows.Count == 0);
			if (flag2)
			{
				this.ButtonItem2.Enabled = false;
			}
			dataTable2.Columns.Add("karmozd", typeof(decimal));
			dataTable2.Columns.Add("keraye", typeof(decimal));
			dataTable2.Columns.Add("makharej", typeof(decimal));
			dataTable2.Columns.Add("sayer", typeof(decimal));
			dataTable2.Columns.Add("mande", typeof(decimal));
			dataTable2.Columns.Add("mablagh2", typeof(long));
			dataTable2.Columns.Add("radif", typeof(int));
			int num3 = 1;
			checked
			{
				try
				{
					IEnumerator enumerator3 = dataTable2.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						dataRow3["mablagh2"] = RuntimeHelpers.GetObjectValue(dataRow3["gheymat"]);
						dataRow3["radif"] = num3;
						num3++;
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
				this.Grid_RizBar.DataSource = dataTable2;
				this.txt_jamFurush.Text = Conversions.ToString(this.Grid_RizBar.GetTotalRow().Cells["Jam_Kol"].Value);
				this.Validate_Tedad();
				this.Validate_Vazn();
				this.Validate_Mablagh();
				flag2 = !this.WarningBox1.Visible;
				if (flag2)
				{
					flag = !save;
					if (flag)
					{
						DataEntryGrid dataEntryGrid = this.Grid_RizBar;
						dataEntryGrid.Height += 77;
						dataEntryGrid = this.Grid_rizFurush;
						dataEntryGrid.Height += 77;
					}
				}
				DataRow byID = this.Safi_Furush.GetByID(Conversions.ToString((T)this.Furush_ID));
				flag2 = (byID != null);
				if (flag2)
				{
					this.txt_darsad.Text = byID["Darsad"].ToString().Replace(".0", "");
					this.txt_jamFurush.Text = byID["JamFurush"].ToString();
					this.txt_karmozd.Text = byID["Karmozd"].ToString();
					this.txt_mande.Text = byID["Mande"].ToString();
					this.Label18.Text = Public_Function.FormatPrice(this.txt_mande.Text);
					this.LabelItem1.Text = huruf.ConvertToHuruf(Conversions.ToString((T)this.txt_mande.Value), huruf.ConvertType.تومان);
					this.txt_tarikh.Text = byID["Tarikh_Fa"].ToString();
					this.txt_tozih.Text = byID["tozih"].ToString();
					object expr_9EB = byID["ID"];
					int? num4;
					this.Safi_ID = ((expr_9EB != null) ? ((int?)expr_9EB) : num4);
					this.isnew = false;
					this.txt_darsad.AllowEdit = false;
					this.txt_karmozd.AllowEdit = false;
					this.txt_mande.AllowEdit = false;
					this.Bar1.Refresh();
				}
				else
				{
					this.txt_mande.AllowEdit = true;
					this.txt_darsad.AllowEdit = true;
					this.txt_karmozd.AllowEdit = true;
					this.LabelItem1.Text = string.Empty;
					this.txt_tozih.Text = string.Empty;
					this.txt_darsad.Text = string.Empty;
					this.txt_karmozd.Text = string.Empty;
					this.txt_mande.Text = string.Empty;
					this.Label18.Text = Public_Function.FormatPrice(this.txt_mande.Text);
					this.txt_tarikh.Text = string.Empty;
					this.txt_hezar1.Text = string.Empty;
					this.txt_hezar2.Text = string.Empty;
					this.isnew = true;
				}
				DataRow byID2 = this.Sarak.GetByID(Conversions.ToString((T)this.Furush_ID));
				flag2 = (byID2 != null);
				if (flag2)
				{
					string arg_B6C_0 = "SELECT  isnull(sum(Safi_Furush_Extend.Mablagh),0) FROM       Safi_Furush_Extend INNER JOIN Furush_Hag ON Safi_Furush_Extend.Furush_ID = Furush_Hag.ID where moshtari_id in(select moshtari_id from furush_hag where furush_id=";
					furush_ID = this.Furush_ID;
					long num5 = Conversions.ToLong(Public_Function.ExecuteScalar(arg_B6C_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null) + ")"));
					flag2 = (num5 > 0L);
					if (flag2)
					{
						this.Label19.Text = Public_Function.FormatPrice(Conversions.ToString(num5));
						this.Label25.Text = "افزایش صافی";
					}
					else
					{
						flag2 = (num5 < 0L);
						if (flag2)
						{
							this.Label19.Text = Public_Function.FormatPrice(Conversions.ToString(num5));
							this.Label25.Text = "کاهش صافی";
						}
						else
						{
							flag2 = (num5 == 0L);
							if (flag2)
							{
								this.Label19.Text = "بیحساب";
								this.Label25.Text = "افزایش صافی";
							}
						}
					}
					this.ButtonItem6.Checked = true;
					this.has_sarak = true;
					this.Grid_RizBar.RootTable.Columns["mablagh2"].Visible = true;
					this.Grid_RizBar.RootTable.Columns["jam_kol"].EditType = EditType.NoEdit;
					string[] array2 = byID2["row_mablagh"].ToString().Split(new char[]
					{
						','
					});
					int num6 = 0;
					string[] array3 = array2;
					for (int i = 0; i < array3.Length; i++)
					{
						string value = array3[i];
						this.Grid_RizBar.GetRows()[num6].BeginEdit();
						this.Grid_RizBar.GetRows()[num6].Cells["jam_kol"].Value = value;
						this.Grid_RizBar.GetRows()[num6].Cells["mablagh2"].Value = Operators.DivideObject(this.Grid_RizBar.GetRows()[num6].Cells["jam_kol"].Value, this.Grid_RizBar.GetRows()[num6].Cells["vazn_kol"].Value);
						this.Grid_RizBar.GetRows()[num6].EndEdit();
						num6++;
					}
				}
				this.safibarvazn();
				this.txt_karmozd.TextChanged += new EventHandler(this.txt_karmozd_TextChanged);
				this.txt_darsad.TextChanged += new EventHandler(this.txt_darsad_TextChanged);
				flag2 = (this.dr_furush != null);
				bool flag3;
				if (flag2)
				{
					flag = (this.dr_furush["karmozd"] != DBNull.Value);
					if (flag)
					{
						flag3 = (Operators.CompareString(this.txt_darsad.Text, string.Empty, false) == 0);
						if (flag3)
						{
							this.darsad_focus = true;
							this.txt_darsad.Text = Conversions.ToString(this.dr_furush["karmozd"]);
						}
					}
				}
				this.Safi_Type = Conversions.ToInteger(Public_Function.dict["noesafi"]);
				flag3 = (byID2 != null);
				if (flag3)
				{
					this.Safi_Type = Conversions.ToInteger(byID2["safi_type"]);
				}
			}
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x001C674C File Offset: 0x001C494C
		private void Frm_Safi_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			bool @checked = this.UiRadioButton1.Checked;
			if (@checked)
			{
				setting.Update("noesafi", "1");
				Public_Function.dict["noesafi"] = "1";
			}
			@checked = this.UiRadioButton2.Checked;
			if (@checked)
			{
				setting.Update("noesafi", "2");
				Public_Function.dict["noesafi"] = "2";
			}
			@checked = this.UiRadioButton3.Checked;
			if (@checked)
			{
				setting.Update("noesafi", "3");
				Public_Function.dict["noesafi"] = "3";
			}
			@checked = this.UiRadioButton4.Checked;
			if (@checked)
			{
				setting.Update("noesafi", "4");
				Public_Function.dict["noesafi"] = "4";
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x001C683C File Offset: 0x001C4A3C
		private void Frm_Safi_KeyDown(object sender, KeyEventArgs e)
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
					flag = (this.ButtonItem2.Visible && this.ButtonItem2.Enabled);
					if (flag)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
				else
				{
					flag2 = (keyCode == Keys.F4);
					if (flag2)
					{
						flag = this.ButtonItem4.Visible;
						if (flag)
						{
							this.ButtonItem4_Click(null, null);
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
								this.ButtonItem3_Click(null, null);
							}
						}
						else
						{
							flag2 = (keyCode == Keys.F12);
							if (flag2)
							{
								MyProject.Forms.Form_Main.UiButton6.PerformClick();
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
			}
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x001C6934 File Offset: 0x001C4B34
		public void Frm_Safi_Load(object sender, EventArgs e)
		{
			this.Grid_RizBar.RootTable.Columns["mablagh2"].EditType = EditType.NoEdit;
			this.txt_karmozd.AllowNegative = true;
			bool hasValue = this.Furush_ID.HasValue;
			if (hasValue)
			{
				Control arg_7A_0 = this.txt_num;
				string arg_6B_0 = "select num from furush_hag where id=";
				long? furush_ID = this.Furush_ID;
				arg_7A_0.Text = Conversions.ToString(Public_Function.ExecuteScalar(arg_6B_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
				this.LoadData(false);
				this.GetMande();
				this.txt_darsad.Focus();
			}
			else
			{
				this.isnew = true;
				this.txt_num.Focus();
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x001C69F4 File Offset: 0x001C4BF4
		private void GetMande()
		{
			bool flag = Operators.CompareString(this.txt_jamFurush.Text, string.Empty, false) == 0;
			checked
			{
				if (!flag)
				{
					long num = Conversions.ToLong(this.txt_jamFurush.Text);
					flag = (Operators.CompareString(this.txt_karmozd.Text, string.Empty, false) != 0);
					if (flag)
					{
						num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_karmozd.Text)));
					}
					flag = (Operators.CompareString(this.txt_keraye.Text, string.Empty, false) != 0);
					if (flag)
					{
						num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_keraye.Text)));
					}
					flag = (Operators.CompareString(this.txt_takhlie.Text, string.Empty, false) != 0);
					if (flag)
					{
						num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_takhlie.Text)));
					}
					flag = (Operators.CompareString(this.txt_sayer.Text, string.Empty, false) != 0);
					if (flag)
					{
						num = (long)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_sayer.Text)));
					}
					this.txt_mande.Text = Conversions.ToString(num);
					flag = (Conversions.ToDouble(Public_Function.dict["arz_kind"]) == 0.0);
					long num2;
					if (flag)
					{
						num2 = 1000L;
					}
					else
					{
						num2 = 100L;
					}
					int num3 = (int)(num % num2);
					flag = (num3 != 0);
					if (flag)
					{
						num += num2 - unchecked((long)num3);
						this.txt_hezar1.Text = Conversions.ToString(num2 - unchecked((long)num3));
					}
					else
					{
						this.txt_hezar1.Text = "0";
					}
					this.Label18.Text = Public_Function.FormatPrice(Conversions.ToString(num));
					flag = (num < 0L);
					if (flag)
					{
						this.MetroStatusBar1.Refresh();
					}
					else
					{
						flag = (Conversions.ToDouble(Public_Function.dict["arz_kind"]) == 0.0);
						if (flag)
						{
							this.LabelItem1.Text = huruf.ConvertToHuruf(Conversions.ToString(num), huruf.ConvertType.تومان);
						}
						else
						{
							this.LabelItem1.Text = huruf.ConvertToHuruf(Conversions.ToString(num * 10L), huruf.ConvertType.تومان);
						}
						this.MetroStatusBar1.Refresh();
					}
				}
			}
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x001C6C44 File Offset: 0x001C4E44
		private void GetMande_org()
		{
			bool flag = Operators.CompareString(this.txt_darsad.Text, string.Empty, false) == 0;
			checked
			{
				if (!flag)
				{
					flag = (Operators.CompareString(this.txt_jamFurush.Text, string.Empty, false) == 0);
					if (!flag)
					{
						int num = Conversions.ToInteger(this.txt_jamFurush.Text);
						flag = (Operators.CompareString(this.txt_karmozd.Text, string.Empty, false) != 0);
						if (flag)
						{
							num = (int)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_karmozd.Text)));
						}
						flag = (Operators.CompareString(this.txt_keraye.Text, string.Empty, false) != 0);
						if (flag)
						{
							num = (int)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_keraye.Text)));
						}
						flag = (Operators.CompareString(this.txt_takhlie.Text, string.Empty, false) != 0);
						if (flag)
						{
							num = (int)Math.Round(unchecked((double)num - Conversions.ToDouble(this.txt_takhlie.Text)));
						}
						int num2 = num % 1000;
						flag = (num2 != 0);
						if (flag)
						{
							this.txt_hezar1.Text = Conversions.ToString(1000 - num2);
							num += 1000 - num2;
							CurrencyBox txt_karmozd = this.txt_karmozd;
							txt_karmozd.Text = Conversions.ToString(unchecked(Conversions.ToDouble(txt_karmozd.Text) - (double)(checked(1000 - num2))));
							this.txt_hezar2.Text = Conversions.ToString(1000 - num2);
						}
						this.txt_mande.Text = Conversions.ToString(num);
						this.Label18.Text = Public_Function.FormatPrice(this.txt_mande.Text);
						this.LabelItem1.Text = huruf.ConvertToHuruf(Conversions.ToString(num), huruf.ConvertType.تومان);
						this.MetroStatusBar1.Refresh();
					}
				}
			}
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x001C6E24 File Offset: 0x001C5024
		private void txt_darsad_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_jamFurush.Text, string.Empty, false) == 0;
			if (!flag)
			{
				flag = !this.darsad_focus;
				if (!flag)
				{
					flag = (Operators.CompareString(this.txt_darsad.Text, string.Empty, false) != 0);
					if (flag)
					{
						long value = checked((long)Math.Round(unchecked(Conversions.ToDouble(this.txt_jamFurush.Text) / 100.0 * Conversions.ToDouble(this.txt_darsad.Text))));
						this.txt_karmozd.Text = Conversions.ToString(value);
						this.GetMande();
					}
					else
					{
						this.txt_mande.Text = string.Empty;
						this.Label18.Text = Public_Function.FormatPrice(this.txt_mande.Text);
						this.txt_karmozd.Text = string.Empty;
						this.LabelItem1.Text = string.Empty;
						this.txt_hezar1.Text = string.Empty;
						this.MetroStatusBar1.Refresh();
					}
				}
			}
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00009701 File Offset: 0x00007901
		private void txt_keraye_TextChanged(object sender, EventArgs e)
		{
			this.GetMande();
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00009701 File Offset: 0x00007901
		private void txt_takhlie_TextChanged(object sender, EventArgs e)
		{
			this.GetMande();
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x001C6F44 File Offset: 0x001C5144
		private void Update_sarak()
		{
			bool flag = this.has_sarak;
			checked
			{
				if (flag)
				{
					string text = string.Empty;
					GridEXRow[] rows = this.Grid_RizBar.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow gridEXRow = rows[i];
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(gridEXRow.Cells["jam_kol"].Value, ",")));
					}
					text = Public_Function.RemoveLast(text);
					this.Sarak.Update(Conversions.ToString((T)this.Furush_ID), Conversions.ToString(this.Safi_Type), Conversions.ToString((T)this.txt_jamFurush.Value), text, "سند " + this.txt_num.Text + "-" + this.lbl_sahebbar.Text, string.Empty);
				}
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x001C7028 File Offset: 0x001C5228
		private void Saveq(bool silent = false)
		{
			string arg_26_0 = "select count(id) from furush_darsad where furush_id= ";
			long? num = this.Furush_ID;
			bool flag = Operators.ConditionalCompareObjectGreater(Public_Function.ExecuteScalar(arg_26_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null)), 0, false);
			checked
			{
				if (!flag)
				{
					bool flag2 = true;
					flag = !this.Validate_Tedad();
					if (flag)
					{
						flag2 = false;
					}
					flag = !this.Validate_Vazn();
					if (flag)
					{
						flag2 = false;
					}
					flag = !this.Validate_Mablagh();
					if (flag)
					{
						flag2 = false;
					}
					flag = !flag2;
					if (!flag)
					{
						flag = (Operators.CompareString(this.txt_darsad.Text, string.Empty, false) == 0);
						if (flag)
						{
							this.txt_darsad.ShowTip("درصد کارمزد را مشخص فرمائید");
						}
						else
						{
							flag = (Operators.CompareString(this.txt_karmozd.Text, string.Empty, false) == 0);
							if (flag)
							{
								this.txt_karmozd.ShowTip("مبلغ کارمزد را وارد نمائید");
							}
							else
							{
								flag = (Operators.CompareString(this.txt_tarikh.Text, string.Empty, false) != 0);
								bool flag3;
								if (flag)
								{
									flag3 = !Public_Function.IsValidShamsiDate(this.txt_tarikh.Text);
									if (flag3)
									{
										Public_Function.ShowTip(this.txt_tarikh, "تاریخ وارد شده معتبر نمیباشد");
										return;
									}
								}
								string text = string.Empty;
								GridEXRow[] rows = this.Grid_RizBar.GetRows();
								for (int i = 0; i < rows.Length; i++)
								{
									GridEXRow gridEXRow = rows[i];
									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(gridEXRow.Cells["kala_name"].Value, "-")));
								}
								text = Public_Function.RemoveLast(text);
								flag3 = this.isnew;
								if (flag3)
								{
									string arg_1EA_0 = "select isnull(count(id),0) from safi_furush where furush_hag_id=";
									num = this.Furush_ID;
									long num2 = Conversions.ToLong(Public_Function.ExecuteScalar(arg_1EA_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null)));
									flag3 = (num2 > 0L);
									if (flag3)
									{
										this.Safi_ID = (int)num2;
										this.isnew = false;
									}
								}
								flag3 = this.isnew;
								if (flag3)
								{
									Safi_Furush arg_31D_0 = this.Safi_Furush;
									string arg_31D_1 = this.txt_num.Text;
									string arg_31D_2 = Conversions.ToString((T)this.Furush_ID);
									string arg_31D_3 = this.txt_jamFurush.Value.ToString();
									string arg_31D_4 = this.txt_darsad.Text;
									string arg_31D_5 = this.txt_karmozd.Value.ToString();
									num = this.txt_mande.Value;
									bool arg_2B3_0 = num.HasValue;
									long? value = this.txt_hezar1.Value;
									long? arg_2DB_0;
									if (!(arg_2B3_0 & value.HasValue))
									{
										arg_2DB_0 = null;
									}
									else
									{
										long? value2 = new long?(num.GetValueOrDefault() + value.GetValueOrDefault());
										arg_2DB_0 = value2;
									}
									this.Safi_ID = (int)arg_31D_0.Insert(arg_31D_1, arg_31D_2, arg_31D_3, arg_31D_4, arg_31D_5, Conversions.ToString((T)arg_2DB_0), this.txt_tarikh.Text, this.lbl_vurudbar.Text, this.txt_tozih.Text, text, this.lbl_shmashin.Text, this.lbl_sahebbar.Text);
									this.Update_sarak();
									this.isnew = false;
									flag3 = !silent;
									if (flag3)
									{
										Public_Function.ConfirmInsert();
									}
								}
								else
								{
									flag3 = !silent;
									if (flag3)
									{
										flag = (Public_Function.ConfirmUpdate() == DialogResult.Yes);
										if (flag)
										{
											Safi_Furush arg_462_0 = this.Safi_Furush;
											string arg_462_1 = this.txt_num.Text;
											string arg_462_2 = this.txt_jamFurush.Value.ToString();
											string arg_462_3 = this.txt_darsad.Text;
											string arg_462_4 = this.txt_karmozd.Value.ToString();
											long? value2 = this.txt_mande.Value;
											bool arg_3E8_0 = value2.HasValue;
											long? value = this.txt_hezar1.Value;
											long? arg_410_0;
											if (!(arg_3E8_0 & value.HasValue))
											{
												arg_410_0 = null;
											}
											else
											{
												num = new long?(value2.GetValueOrDefault() + value.GetValueOrDefault());
												arg_410_0 = num;
											}
											arg_462_0.Update(arg_462_1, arg_462_2, arg_462_3, arg_462_4, Conversions.ToString((T)arg_410_0), this.txt_tarikh.Text, this.lbl_vurudbar.Text, this.txt_tozih.Text, text, this.lbl_shmashin.Text, this.lbl_sahebbar.Text, Conversions.ToString((T)this.Safi_ID));
											this.Update_sarak();
											Public_Function.ConfirmInsert();
										}
									}
									else
									{
										Safi_Furush arg_56E_0 = this.Safi_Furush;
										string arg_56E_1 = this.txt_num.Text;
										string arg_56E_2 = this.txt_jamFurush.Value.ToString();
										string arg_56E_3 = this.txt_darsad.Text;
										string arg_56E_4 = this.txt_karmozd.Value.ToString();
										long? value2 = this.txt_mande.Value;
										bool arg_4F4_0 = value2.HasValue;
										long? value = this.txt_hezar1.Value;
										long? arg_51C_0;
										if (!(arg_4F4_0 & value.HasValue))
										{
											arg_51C_0 = null;
										}
										else
										{
											num = new long?(value2.GetValueOrDefault() + value.GetValueOrDefault());
											arg_51C_0 = num;
										}
										arg_56E_0.Update(arg_56E_1, arg_56E_2, arg_56E_3, arg_56E_4, Conversions.ToString((T)arg_51C_0), this.txt_tarikh.Text, this.lbl_vurudbar.Text, this.txt_tozih.Text, text, this.lbl_shmashin.Text, this.lbl_sahebbar.Text, Conversions.ToString((T)this.Safi_ID));
										this.Update_sarak();
									}
								}
								this.save = true;
								Public_Function.InvokeMethod("LoadSafiData");
								MyProject.Forms.Form_Main.Get_mande_Safi();
							}
						}
					}
				}
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x001C75D8 File Offset: 0x001C57D8
		public void ButtonItem2_Click(object sender, EventArgs e)
		{
			int num = 0;
			bool @checked = this.UiRadioButton1.Checked;
			if (@checked)
			{
				num = 0;
			}
			@checked = this.UiRadioButton2.Checked;
			if (@checked)
			{
				num = 1;
			}
			@checked = this.UiRadioButton3.Checked;
			if (@checked)
			{
				num = 2;
			}
			@checked = this.UiRadioButton4.Checked;
			if (@checked)
			{
				num = 3;
			}
			this.Saveq(false);
			this.LoadData(true);
			this.GetMande();
			switch (num)
			{
			case 0:
				this.UiRadioButton1.Checked = true;
				break;
			case 1:
				this.UiRadioButton2.Checked = true;
				break;
			case 2:
				this.UiRadioButton3.Checked = true;
				break;
			case 3:
				this.UiRadioButton4.Checked = true;
				break;
			}
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x001C76A4 File Offset: 0x001C58A4
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			long? furush_ID;
			this.Furush_ID = furush_ID;
			this.Safi_ID = null;
			this.Grid_RizBar.DataSource = null;
			this.txt_num.Focus();
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x001C76F4 File Offset: 0x001C58F4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.isnew && Public_Function.ConfirmDelete() == DialogResult.Yes;
			if (flag)
			{
				this.Safi_Furush.Delete(Conversions.ToString((T)this.Safi_ID));
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x001C7744 File Offset: 0x001C5944
		private bool Validate_Furush(int ID)
		{
			string text = "declare @tedad; select @tedad=select tedad_kol from furush_hag where id=" + Conversions.ToString(ID) + ";";
			text += "";
			return Conversions.ToBoolean(text);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x001C7780 File Offset: 0x001C5980
		private StiReport RenderReport(bool pdf)
		{
			bool flag = !this.Furush_ID.HasValue;
			checked
			{
				StiReport result;
				if (flag)
				{
					result = null;
				}
				else
				{
					string arg_45_0 = "SELECT        Furush_Hag.ID, Furush_Hag.Num, Furush_Hag.Moshtari_ID, Furush_Hag.Sh_Mashin, Furush_Hag.Sh_Barname, Furush_Hag.Tarikh_Vurud, Furush_Hag.[Desc],  Furush_Hag.Baskul, Furush_Hag.Baskul_Mabda, Furush_Hag.Tedad_Kol,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,Moshtari.kind  FROM            Furush_Hag INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID where furush_hag.id=";
					long? num = this.Furush_ID;
					DataTable dataTable = Public_Function.FillData(arg_45_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
					flag = (dataTable.Rows.Count > 0);
					bool flag2;
					if (flag)
					{
						object left = dataTable.Rows[0]["kind"];
						flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 2, false))) ? true : false);
						if (flag2)
						{
							dataTable.Rows[0]["moshtari_name"] = Operators.ConcatenateObject("آقای ", dataTable.Rows[0]["moshtari_name"]);
						}
						else
						{
							flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 3, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 4, false))) ? true : false);
							if (!flag2)
							{
								flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 5, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 6, false))) ? true : false);
								if (flag2)
								{
									dataTable.Rows[0]["moshtari_name"] = Operators.ConcatenateObject("خانم ", dataTable.Rows[0]["moshtari_name"]);
								}
							}
						}
						flag2 = (dataTable.Rows[0]["baskul"] != DBNull.Value);
						if (flag2)
						{
							dataTable.Rows[0]["baskul"] = dataTable.Rows[0]["baskul"].ToString().Replace(".0", "");
						}
						flag2 = (dataTable.Rows[0]["tedad_kol"] != DBNull.Value);
						if (flag2)
						{
							dataTable.Rows[0]["tedad_kol"] = dataTable.Rows[0]["tedad_kol"].ToString().Replace(".0", "");
						}
					}
					string arg_2BB_0 = "SELECT        Safi_Furush.*  FROM            Safi_Furush where furush_hag_id=";
					num = this.Furush_ID;
					DataTable dataTable2 = Public_Function.FillData(arg_2BB_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
					flag2 = (dataTable2.Rows.Count == 0);
					if (flag2)
					{
						result = null;
					}
					else
					{
						dataTable.TableName = "head";
						dataTable2.TableName = "safi";
						StiReport stiReport = new StiReport();
						flag2 = this.UiRadioButton1.Checked;
						if (flag2)
						{
							stiReport.Load(Application.StartupPath + "\\reports\\safi.mrt");
							Public_Function.setReportFont(stiReport, "Text13,Text14,Text15,Text16,Text17,Text42,Text43,Text44,Text45,Text30,Text31,Text32,Text49,Text51,Text29,Text24,Text36,Text19,Text60,Text65,Text20,Text39,Text63,Text21,Text22");
						}
						flag2 = this.UiRadioButton2.Checked;
						if (flag2)
						{
							stiReport.Load(Application.StartupPath + "\\reports\\safi2.mrt");
							Public_Function.setReportFont(stiReport, "Text13,Text14,Text15,Text16,Text17,Text69,Text70,Text72,Text73,Text42,Text43,Text44,Text45,Text74,Text75,Text77,Text78,Text30,Text31,Text32,Text49,Text51,Text29,Text24,Text36,Text19,Text60,Text65,Text20,Text39,Text63,Text21,Text22");
						}
						flag2 = (this.UiRadioButton3.Checked || this.UiRadioButton4.Checked);
						if (flag2)
						{
							stiReport.Load(Application.StartupPath + "\\reports\\safi3.mrt");
							Public_Function.setReportFont(stiReport, "Text13,Text14,Text15,Text64,Text16,Text17,Text42,Text43,Text44,Text45,Text30,Text31,Text32,Text49,Text51,Text29,Text24,Text36,Text19,Text60,Text65,Text20,Text39,Text63,Text21,Text22");
						}
						flag2 = this.UiRadioButton4.Checked;
						StiText stiText;
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text37");
							stiText.Text = "صافی بر اساس فی فروش";
						}
						flag2 = (dataTable2.Rows[0]["printcount"] != DBNull.Value);
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("lbl_copy");
							stiText.Text = "کپی";
						}
						string text = string.Empty;
						flag2 = (Operators.CompareString(dataTable.Rows[0]["desc"].ToString(), string.Empty, false) != 0);
						if (flag2)
						{
							text = Conversions.ToString(dataTable.Rows[0]["desc"]);
						}
						flag2 = (Operators.CompareString(dataTable2.Rows[0]["tozih"].ToString(), string.Empty, false) != 0);
						if (flag2)
						{
							flag = (Operators.CompareString(text, string.Empty, false) == 0);
							if (flag)
							{
								text = dataTable2.Rows[0]["tozih"].ToString();
							}
							else
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataTable2.Rows[0]["tozih"])));
							}
						}
						stiText = (StiText)stiReport.GetComponentByName("Text67");
						stiText.Text.Value = text;
						flag2 = (!this.UiRadioButton3.Checked && !this.UiRadioButton4.Checked);
						if (flag2)
						{
							DataTable dataTable3 = ((DataTable)this.Grid_RizBar.DataSource).Clone();
							GridEXRow[] rows = this.Grid_RizBar.GetRows();
							for (int i = 0; i < rows.Length; i++)
							{
								GridEXRow gridEXRow = rows[i];
								dataTable3.ImportRow(((DataRowView)gridEXRow.DataRow).Row);
							}
							stiReport.RegData(dataTable3);
						}
						else
						{
							stiReport.RegData((DataTable)this.Grid_rizFurush.DataSource);
						}
						stiReport.RegData(dataTable2);
						stiReport.RegData(dataTable);
						flag2 = this.txt_keraye.Value.HasValue;
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text31");
							stiText.Text = "{tofarsis(\"" + Public_Function.FormatPrice(Conversions.ToString((T)this.txt_keraye.Value)) + "\")} - ";
						}
						flag2 = this.txt_karmozd.Value.HasValue;
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text30");
							stiText.Text = "{tofarsis(\"" + Public_Function.FormatPrice(Conversions.ToString((T)this.txt_karmozd.Value)) + "\")} - ";
						}
						flag2 = this.txt_takhlie.Value.HasValue;
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text32");
							stiText.Text = "{tofarsis(\"" + Public_Function.FormatPrice(Conversions.ToString((T)this.txt_takhlie.Value)) + "\")} - ";
						}
						flag2 = this.txt_sayer.Value.HasValue;
						long? num3;
						if (flag2)
						{
							long num2 = 0L;
							num3 = this.txt_sayer.Value;
							bool? arg_786_0;
							if (!num3.HasValue)
							{
								arg_786_0 = null;
							}
							else
							{
								bool? flag3 = new bool?(num3.GetValueOrDefault() != num2);
								arg_786_0 = flag3;
							}
							bool? flag4 = arg_786_0;
							flag = flag4.GetValueOrDefault();
							if (flag)
							{
								stiText = (StiText)stiReport.GetComponentByName("Text49");
								stiText.Text = "{tofarsis(\"" + Public_Function.FormatPrice(Conversions.ToString((T)this.txt_sayer.Value)) + "\")} - ";
							}
						}
						flag2 = this.txt_hezar1.Value.HasValue;
						if (flag2)
						{
							long num2 = 0L;
							num = this.txt_hezar1.Value;
							bool? arg_83B_0;
							if (!num.HasValue)
							{
								arg_83B_0 = null;
							}
							else
							{
								bool? flag4 = new bool?(num.GetValueOrDefault() != num2);
								arg_83B_0 = flag4;
							}
							bool? flag3 = arg_83B_0;
							flag = flag3.GetValueOrDefault();
							if (flag)
							{
								stiText = (StiText)stiReport.GetComponentByName("Text29");
								StiSimpleText arg_898_0 = stiText;
								string arg_88E_0 = "{tofarsis(\"";
								num3 = this.txt_hezar1.Value;
								arg_898_0.Text = arg_88E_0 + (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "\")} + ";
							}
						}
						flag2 = (Operators.CompareString(this.txt_tarikh.Text, string.Empty, false) != 0);
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text53");
							stiText.Text = this.txt_tarikh.Text;
						}
						flag2 = (Operators.CompareString(this.txt_saat.Text, string.Empty, false) != 0);
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text55");
							stiText.Text = this.txt_saat.Text;
						}
						flag2 = this.ButtonItem6.Checked;
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text16");
							stiText.Text = "{tofarsi(data.mablagh2)}";
						}
						flag2 = (Operators.CompareString(this.txt_mande.Text, string.Empty, false) != 0);
						if (flag2)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text51");
							flag2 = (Operators.CompareString(this.txt_hezar1.Text, string.Empty, false) != 0);
							if (flag2)
							{
								stiText.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString((T)this.txt_mande.Value)));
							}
							else
							{
								stiText.Text = "{tofarsis(\"" + Public_Function.FormatPrice(Conversions.ToString((T)this.txt_mande.Value)) + "\")}";
							}
						}
						stiText = (StiText)stiReport.GetComponentByName("Text61");
						stiText.Text = this.jens;
						stiText = (StiText)stiReport.GetComponentByName("Text57");
						flag2 = (Conversions.ToDouble(Public_Function.dict["arz_kind"]) == 0.0);
						if (flag2)
						{
							stiText.Text = huruf.ConvertToHuruf(Conversions.ToString(dataTable2.Rows[0]["mande"]), huruf.ConvertType.تومان);
						}
						else
						{
							stiText.Text = huruf.ConvertToHuruf(Conversions.ToString(Operators.MultiplyObject(dataTable2.Rows[0]["mande"], 10)), huruf.ConvertType.تومان);
						}
						Public_Function.SetHeader(stiReport, pdf);
						Public_Function.AddTazminText(stiReport, true, pdf);
						Public_Function.SetReport_MarginTop(stiReport);
						string arg_B3E_0 = "update safi_furush set printcount=1 where furush_hag_id=";
						num3 = this.Furush_ID;
						Public_Function.ExecuteNonQuery(arg_B3E_0 + (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null));
						result = stiReport;
					}
				}
				return result;
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x001C82DC File Offset: 0x001C64DC
		public void ButtonItem4_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport != null;
			if (flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x001C8308 File Offset: 0x001C6508
		private void txt_num_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txt_num.Text, string.Empty, false) == 0;
				if (flag2)
				{
					Frm_List_Safi frm_List_Safi = new Frm_List_Safi
					{
						DialogMode = true
					};
					MyProject.Forms.Form_Main.Dialog_ShowForm(frm_List_Safi);
					flag2 = (frm_List_Safi.SelectedNum != 0);
					if (flag2)
					{
						this.txt_num.Text = Conversions.ToString(frm_List_Safi.SelectedNum);
						this.txt_num_Validating(null, null);
						this.txt_darsad.Focus();
					}
				}
			}
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x001C83A4 File Offset: 0x001C65A4
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_num.Text, string.Empty, false) == 0;
			checked
			{
				if (!flag)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select id from furush_hag where num=" + this.txt_num.Text));
					flag = (objectValue != null);
					if (flag)
					{
						long num = Conversions.ToLong(objectValue);
						long? furush_ID = this.Furush_ID;
						bool? arg_8E_0;
						if (!furush_ID.HasValue)
						{
							arg_8E_0 = null;
						}
						else
						{
							bool? flag2 = new bool?(furush_ID.GetValueOrDefault() == num);
							arg_8E_0 = flag2;
						}
						bool? flag3 = arg_8E_0;
						bool valueOrDefault = flag3.GetValueOrDefault();
						if (!valueOrDefault)
						{
							this.Furush_ID = Conversions.ToLong(objectValue);
							this.LoadData(false);
						}
					}
					else
					{
						long? furush_ID2;
						this.Furush_ID = furush_ID2;
						this.ButtonItem2.Enabled = false;
						this.txt_hezar1.Text = string.Empty;
						this.txt_hezar2.Text = string.Empty;
						this.txt_tozih.Text = string.Empty;
						this.lbl_baskul.Text = string.Empty;
						this.lbl_baskulmabda.Text = string.Empty;
						this.lbl_sahebbar.Text = string.Empty;
						this.lbl_sh_barname.Text = string.Empty;
						this.lbl_shmashin.Text = string.Empty;
						this.lbl_tedadkol.Text = string.Empty;
						this.lbl_vurudbar.Text = string.Empty;
						this.txt_darsad.Text = string.Empty;
						this.txt_jamFurush.Text = string.Empty;
						this.txt_karmozd.Text = string.Empty;
						this.txt_keraye.Text = string.Empty;
						this.txt_takhlie.Text = string.Empty;
						this.txt_mande.Text = string.Empty;
						this.Label18.Text = Public_Function.FormatPrice(this.txt_mande.Text);
						this.txt_tarikh.Text = string.Empty;
						this.LabelItem1.Text = string.Empty;
						this.Grid_RizBar.DataSource = null;
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Height += 77;
					}
				}
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x001C8600 File Offset: 0x001C6800
		private void txt_karmozd_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_jamFurush.Text, string.Empty, false) == 0;
			if (!flag)
			{
				flag = (Operators.CompareString(this.txt_jamFurush.Text, "0", false) == 0);
				if (!flag)
				{
					flag = this.darsad_focus;
					if (!flag)
					{
						flag = this.calc_darsad;
						if (!flag)
						{
							flag = (Operators.CompareString(this.txt_karmozd.Text, string.Empty, false) != 0);
							if (flag)
							{
								bool flag2 = Operators.CompareString(this.txt_karmozd.Text, "-", false) == 0;
								if (!flag2)
								{
									this.calc_darsad = true;
									decimal num = 0m;
									long num2 = 100L;
									long? value = this.txt_karmozd.Value;
									long? arg_105_0;
									if (!value.HasValue)
									{
										arg_105_0 = null;
									}
									else
									{
										long? num3 = new long?(checked(value.GetValueOrDefault() * num2));
										arg_105_0 = num3;
									}
									long? num4 = arg_105_0;
									double? arg_12D_0;
									if (!num4.HasValue)
									{
										arg_12D_0 = null;
									}
									else
									{
										double? num5 = new double?((double)num4.GetValueOrDefault());
										arg_12D_0 = num5;
									}
									double? num6 = arg_12D_0;
									bool arg_170_0 = num6.HasValue;
									long? value2 = this.txt_jamFurush.Value;
									double? arg_168_0;
									if (!value2.HasValue)
									{
										arg_168_0 = null;
									}
									else
									{
										double? num7 = new double?((double)value2.GetValueOrDefault());
										arg_168_0 = num7;
									}
									double? num8 = arg_168_0;
									double? arg_197_0;
									if (!(arg_170_0 & num8.HasValue))
									{
										arg_197_0 = null;
									}
									else
									{
										double? num9 = new double?(num6.GetValueOrDefault() / num8.GetValueOrDefault());
										arg_197_0 = num9;
									}
									num = new decimal((T)arg_197_0);
									flag2 = (decimal.Compare(num, new decimal(100L)) < 0);
									if (flag2)
									{
										this.txt_darsad.Text = Conversions.ToString(decimal.Round(num, 2));
										flag2 = (Operators.CompareString(this.txt_darsad.Text, "0.0", false) == 0);
										if (flag2)
										{
											this.txt_darsad.Text = string.Empty;
										}
									}
									else
									{
										this.txt_karmozd.Text = string.Empty;
										this.txt_karmozd.ShowTip("مبلغ کارمزد اشتباه است");
									}
									this.GetMande();
									this.calc_darsad = false;
								}
							}
							else
							{
								this.txt_mande.Text = string.Empty;
								this.Label18.Text = Public_Function.FormatPrice(this.txt_mande.Text);
								this.txt_darsad.Text = string.Empty;
								this.LabelItem1.Text = string.Empty;
								this.txt_hezar1.Text = string.Empty;
								this.MetroStatusBar1.Refresh();
								this.calc_darsad = false;
							}
						}
					}
				}
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x001C88C0 File Offset: 0x001C6AC0
		private void UiRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Grid_RizBar.RootTable == null;
			if (!flag)
			{
				flag = !this.UiRadioButton1.Checked;
				if (flag)
				{
					this.Grid_RizBar.RootTable.Columns["Jam_Kol"].Visible = false;
				}
				else
				{
					this.Grid_RizBar.RootTable.Columns["Jam_Kol"].Visible = true;
				}
			}
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x001C893C File Offset: 0x001C6B3C
		private void UiRadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Grid_RizBar.RootTable == null;
			if (!flag)
			{
				flag = this.UiRadioButton2.Checked;
				if (flag)
				{
					this.Grid_RizBar.RootTable.Columns["Jam_Kol"].Visible = true;
					this.Grid_RizBar.RootTable.Columns["karmozd"].Visible = true;
					this.Grid_RizBar.RootTable.Columns["mande"].Visible = true;
					this.Grid_RizBar.RootTable.Columns["keraye"].Visible = true;
					this.Grid_RizBar.RootTable.Columns["sayer"].Visible = true;
					this.safibarvazn();
				}
				else
				{
					this.Grid_RizBar.RootTable.Columns["Jam_Kol"].Visible = false;
					this.Grid_RizBar.RootTable.Columns["karmozd"].Visible = false;
					this.Grid_RizBar.RootTable.Columns["mande"].Visible = false;
					this.Grid_RizBar.RootTable.Columns["keraye"].Visible = false;
					this.Grid_RizBar.RootTable.Columns["sayer"].Visible = false;
				}
				flag = this.UiRadioButton3.Checked;
				if (flag)
				{
					this.Grid_rizFurush.Visible = true;
					this.Grid_RizBar.Visible = false;
					string arg_1DA_0 = "SELECT     Furush_Hag_Detail.ID, Furush_Hag_Detail.Kala_ID, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf, Furush_Hag_Detail.Zarf,  Furush_Hag_Detail.Vazn_Kol, Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol, Kala.Name AS Kala_Name  FROM         Furush_Hag_Detail INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID where furush_hug_id=";
					long? furush_ID = this.Furush_ID;
					DataTable dataTable = Public_Function.FillData(arg_1DA_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null));
					dataTable.TableName = "data";
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag = (dataRow["tedad"] != DBNull.Value);
							if (flag)
							{
								dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
							}
							flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
							if (flag)
							{
								dataRow["Vazn_ba_Zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_ba_Zarf"]));
							}
							flag = (dataRow["vazn_kol"] != DBNull.Value);
							if (flag)
							{
								dataRow["Vazn_Kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_Kol"]));
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
					this.Grid_rizFurush.DataSource = dataTable;
					this.Grid_rizFurush.Visible = true;
					this.Grid_RizBar.Visible = false;
				}
				else
				{
					this.Grid_rizFurush.Visible = false;
					this.Grid_RizBar.Visible = true;
					flag = this.UiRadioButton4.Checked;
					if (flag)
					{
						this.Grid_rizFurush.Visible = true;
						this.Grid_RizBar.Visible = false;
						string arg_3B0_0 = "SELECT     Furush_Hag_Detail.Kala_ID,sum( Furush_Hag_Detail.Tedad) AS Tedad,isnull(sum( Furush_Hag_Detail.Vazn_Ba_Zarf) ,NULL) as  Vazn_Ba_Zarf,isnull(sum( Furush_Hag_Detail.Zarf),NULL) AS Zarf,   isnull(sum(Furush_Hag_Detail.Vazn_Kol),null) AS Vazn_Kol, Furush_Hag_Detail.Fee,sum( Furush_Hag_Detail.Jam_Kol) AS Jam_Kol,max( Kala.Name )AS Kala_Name   FROM         Furush_Hag_Detail INNER JOIN   Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID    WHERE Furush_Hag_Detail.Furush_Hug_ID =";
						long? furush_ID = this.Furush_ID;
						DataTable dataTable2 = Public_Function.FillData(arg_3B0_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null) + " group by Kala_ID,Fee order by kala_id asc,fee desc");
						dataTable2.TableName = "data";
						try
						{
							IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								flag = (dataRow2["tedad"] != DBNull.Value);
								if (flag)
								{
									dataRow2["tedad"] = dataRow2["tedad"].ToString().Replace(".0", "");
								}
								flag = (dataRow2["vazn_ba_zarf"] != DBNull.Value);
								if (flag)
								{
									dataRow2["Vazn_ba_Zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow2["Vazn_ba_Zarf"]));
								}
								flag = (dataRow2["vazn_kol"] != DBNull.Value);
								if (flag)
								{
									dataRow2["Vazn_Kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow2["Vazn_Kol"]));
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
						this.Grid_rizFurush.DataSource = dataTable2;
						this.Grid_rizFurush.Visible = true;
						this.Grid_RizBar.Visible = false;
					}
					else
					{
						this.Grid_rizFurush.Visible = false;
						this.Grid_RizBar.Visible = true;
					}
				}
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x001C8E98 File Offset: 0x001C7098
		private void txt_num_ButtonClick(object sender, EventArgs e)
		{
			Frm_List_Safi frm_List_Safi = new Frm_List_Safi
			{
				DialogMode = true
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_List_Safi);
			bool flag = frm_List_Safi.SelectedNum != 0;
			if (flag)
			{
				this.txt_num.Text = Conversions.ToString(frm_List_Safi.SelectedNum);
				this.txt_num_Validating(null, null);
				this.txt_darsad.Focus();
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0000970C File Offset: 0x0000790C
		private void txt_karmozd_GotFocus(object sender, EventArgs e)
		{
			this.txt_karmozd.SelectAll();
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0000971C File Offset: 0x0000791C
		private void txt_mande_GotFocus(object sender, EventArgs e)
		{
			this.txt_mande.SelectAll();
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x0000972C File Offset: 0x0000792C
		private void txt_darsad_GotFocus(object sender, EventArgs e)
		{
			this.darsad_focus = true;
			this.calc_darsad = false;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0000973E File Offset: 0x0000793E
		private void txt_darsad_LostFocus(object sender, EventArgs e)
		{
			this.darsad_focus = false;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x001C8F08 File Offset: 0x001C7108
		private void txt_karmozd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_tozih.Focus();
			}
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x001C8F34 File Offset: 0x001C7134
		private void txt_tozih_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_num.Focus();
			}
			flag = (e.KeyCode == Keys.Up);
			if (flag)
			{
				this.txt_num.Focus();
			}
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x001C8F7C File Offset: 0x001C717C
		private void Grid_RizBar_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "jam_kol", false) == 0;
			if (flag)
			{
				bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (hasValue)
				{
					e.Value = ((CurrencyBox)e.EditControl).Value;
				}
			}
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x001C8FEC File Offset: 0x001C71EC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع کل";
			}
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x001C902C File Offset: 0x001C722C
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool has_Delete = this.isnew;
			if (!has_Delete)
			{
				Frm_Sud_Furush frm_Sud_Furush = new Frm_Sud_Furush
				{
					Furush_ID = Conversions.ToString((T)this.Furush_ID),
					furush_num = this.txt_num.Text,
					Mablagh = (T)this.txt_jamFurush.Value,
					Darsad = this.txt_darsad.Text
				};
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Sud_Furush);
				has_Delete = frm_Sud_Furush.has_Delete;
				if (has_Delete)
				{
					this.Saveq(true);
				}
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x001C90C8 File Offset: 0x001C72C8
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			bool flag = this.has_sarak && !this.isnew;
			if (flag)
			{
				this.ButtonItem6.Checked = true;
			}
			else
			{
				flag = this.ButtonItem6.Checked;
				if (flag)
				{
					this.has_sarak = true;
					this.Grid_RizBar.RootTable.Columns["jam_kol"].EditType = EditType.Custom;
				}
				else
				{
					this.has_sarak = false;
					this.Grid_RizBar.RootTable.Columns["jam_kol"].EditType = EditType.NoEdit;
				}
				this.Grid_RizBar.RootTable.Columns["mablagh2"].Visible = true;
				this.Grid_RizBar.Focus();
				this.Grid_RizBar.Col = this.Grid_RizBar.RootTable.Columns["jam_kol"].Position;
				this.Grid_RizBar.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x001C91D0 File Offset: 0x001C73D0
		private string GetMessage()
		{
			string str = string.Empty;
			str = Public_Function.dict["sms_titr"] + Environment.NewLine;
			str = str + Public_Function.MiladiToShamsi(DateAndTime.Now) + Environment.NewLine;
			str = str + "ش م:" + this.lbl_shmashin.Text + Environment.NewLine;
			str = str + "جنس:" + this.jens + Environment.NewLine;
			bool visible = this.Grid_RizBar.Visible;
			if (visible)
			{
				str = str + "وزن:" + this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["vazn_kol"], AggregateFunction.Sum).ToString();
			}
			else
			{
				str = str + "وزن:" + this.Grid_rizFurush.GetTotal(this.Grid_rizFurush.RootTable.Columns["vazn_kol"], AggregateFunction.Sum).ToString();
			}
			str += Environment.NewLine;
			return str + "صافی:" + this.Label18.Text;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x001C92F0 File Offset: 0x001C74F0
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			bool flag = this.dr_furush["tel2"] == DBNull.Value;
			bool flag2;
			if (flag)
			{
				flag2 = (Public_Function.ShowMessage("شماره موبایل در مشخصات مشتری ثبت نگردیده است" + Environment.NewLine + "آیا مایل به ثبت شماره موبایل می باشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, null) == DialogResult.Yes);
				if (!flag2)
				{
					return;
				}
				Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
				Frm_Moshtari arg_71_0 = frm_Moshtari;
				object expr_5E = this.dr_furush["moshtari_id"];
				int? num;
				arg_71_0.ID = ((expr_5E != null) ? ((int?)expr_5E) : num);
				frm_Moshtari.ShowDialog();
				string arg_A4_0 = "SELECT        Furush_Hag.ID, Furush_Hag.Num, Furush_Hag.Moshtari_ID, Furush_Hag.Sh_Mashin, Furush_Hag.Sh_Barname, Furush_Hag.Tarikh_Vurud, Furush_Hag.[Desc],   Furush_Hag.Baskul, Furush_Hag.Baskul_Mabda, Furush_Hag.Tedad_Kol,  Moshtari.Name + ' ' + Moshtari.Family AS Name,Moshtari.karmozd,tel1,tel2,tel3,tel4  FROM            Furush_Hag INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID where Furush_Hag.id=";
				long? furush_ID = this.Furush_ID;
				this.dr_furush = Public_Function.FillDataRow(arg_A4_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null));
			}
			flag2 = (Public_Function.dict["sms_apikey"] == DBNull.Value || Operators.CompareString(Public_Function.dict["sms_apikey"].ToString().Trim(), string.Empty, false) == 0);
			if (flag2)
			{
				flag = (Public_Function.ShowMessage("تنظیمات پیامک ثبت نگردیده است" + Environment.NewLine + "آیا مایل به ثبت تنظیمات پیامک میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag)
				{
					Frm_Sms_Setting frm_Sms_Setting = new Frm_Sms_Setting();
					frm_Sms_Setting.ShowDialog();
				}
			}
			else
			{
				flag2 = (this.dr_furush["tel2"] != DBNull.Value);
				if (flag2)
				{
					KavenegarApi kavenegarApi = new KavenegarApi(Public_Function.dict["sms_apikey"]);
					try
					{
						SendResult sendResult = kavenegarApi.Send(Public_Function.dict["sms_number"], Conversions.ToString(this.dr_furush["tel2"]), this.GetMessage());
					}
					catch (Exception expr_1B3)
					{
						ProjectData.SetProjectError(expr_1B3);
						Public_Function.ShowMessage("اینترنت وصل نمیباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x001C94E4 File Offset: 0x001C76E4
		private void Remove_(StiReport report, string stitext)
		{
			string[] array = stitext.Split(new char[]
			{
				','
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string componentName = array2[i];
					StiText stiText = (StiText)report.GetComponentByName(componentName);
					bool flag = stiText == null;
					if (!flag)
					{
						stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					}
				}
			}
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x001C956C File Offset: 0x001C776C
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			bool flag = !this.isnew;
			if (flag)
			{
				StiReport stiReport = this.RenderReport(true);
				flag = (stiReport == null);
				if (!flag)
				{
					flag = (this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK);
					if (flag)
					{
						StiPdfExportService stiPdfExportService = new StiPdfExportService();
						StiJpegExportSettings stiJpegExportSettings = new StiJpegExportSettings();
						stiPdfExportService.MultipleFiles = true;
						this.Remove_(stiReport, "Text2,Text1,Text40,Text64,Text66,Text59,Text3,Text38,Text62,Text4,Text5");
						stiReport.Render(true);
						string text = Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "");
						stiPdfExportService.ExportPdf(stiReport, string.Concat(new string[]
						{
							this.FolderBrowserDialog1.SelectedPath,
							"\\",
							this.lbl_sahebbar.Text,
							"-سند",
							this.txt_num.Text,
							".pdf"
						}));
						Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					}
				}
			}
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x001C9678 File Offset: 0x001C7878
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					DataEntryGrid grid_RizBar = this.Grid_RizBar;
					grid_RizBar.Row++;
				}
			}
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x001C96AC File Offset: 0x001C78AC
		private void Grid_RizBar_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "jam_kol", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_jamkol;
				this.txt_jamkol.Text = e.Value.ToString();
				this.txt_jamkol.SelectAll();
			}
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x001C9714 File Offset: 0x001C7914
		private void Grid_RizBar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.Grid_RizBar.EditTextBox == null;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.Grid_RizBar.GetRow() != null;
				if (flag2)
				{
					flag3 = (this.Grid_RizBar.GetRow().RowType == RowType.Record);
					if (flag3)
					{
						this.Grid_RizBar.GetRow().BeginEdit();
					}
				}
			}
			flag3 = (e.KeyCode == Keys.Delete);
			if (flag3)
			{
				bool flag2 = this.Grid_RizBar.EditTextBox != null;
				if (flag2)
				{
					this.Grid_RizBar.EditTextBox.Text = string.Empty;
				}
				flag3 = (this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["mablagh2"].Position);
				if (flag3)
				{
					this.Grid_RizBar.CurrentRow.Cells["mablagh2"].Value = DBNull.Value;
				}
			}
			checked
			{
				switch (e.KeyData)
				{
				case Keys.Left:
					flag3 = (this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["jam_kol"].Position);
					if (flag3)
					{
						e.SuppressKeyPress = true;
					}
					else
					{
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Col++;
						e.SuppressKeyPress = true;
					}
					break;
				case Keys.Up:
					flag3 = (this.Grid_RizBar.Row > 0);
					if (flag3)
					{
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Row--;
						e.SuppressKeyPress = true;
					}
					break;
				case Keys.Right:
					flag3 = (this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["mablagh2"].Position);
					if (flag3)
					{
						e.SuppressKeyPress = true;
					}
					else
					{
						flag3 = (this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["jam_kol"].Position);
						if (flag3)
						{
							DataEntryGrid grid_RizBar = this.Grid_RizBar;
							grid_RizBar.Col--;
							e.SuppressKeyPress = true;
						}
					}
					break;
				case Keys.Down:
					flag3 = (this.Grid_RizBar.Row < this.Grid_RizBar.RowCount - 1);
					if (flag3)
					{
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Row++;
						e.SuppressKeyPress = true;
					}
					break;
				}
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x001C99C0 File Offset: 0x001C7BC0
		private void Grid_RizBar_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToString().ToLower(), "jam_kol", false) == 0;
			if (flag)
			{
				decimal d = decimal.Divide(Conversions.ToDecimal(this.Grid_RizBar.CurrentRow.Cells["jam_kol"].Value), Conversions.ToDecimal(this.Grid_RizBar.CurrentRow.Cells["vazn_kol"].Value));
				this.Grid_RizBar.CurrentRow.Cells["mablagh2"].Value = decimal.Floor(d);
				this.txt_jamFurush.Text = Conversions.ToString(this.Grid_RizBar.GetTotal(this.Grid_RizBar.RootTable.Columns["jam_kol"], AggregateFunction.Sum));
				this.darsad_focus = true;
				this.txt_darsad_TextChanged(null, null);
			}
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x001C9ABC File Offset: 0x001C7CBC
		private void UiButton2_Click(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(this.Grid_RizBar.CurrentRow.Cells["radif"].Value);
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow["radif"], num + 1, false);
						if (flag)
						{
							dataRow["radif"] = -1;
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
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow2["radif"], num, false);
						if (flag)
						{
							dataRow2["radif"] = num + 1;
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
				try
				{
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow3["radif"], -1, false);
						if (flag)
						{
							dataRow3["radif"] = num;
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					bool flag = enumerator3 is IDisposable;
					if (flag)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				this.Grid_RizBar.Focus();
			}
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x001C9CBC File Offset: 0x001C7EBC
		private void UiButton1_Click(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(this.Grid_RizBar.CurrentRow.Cells["radif"].Value);
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow["radif"], num - 1, false);
						if (flag)
						{
							dataRow["radif"] = -1;
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
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow2["radif"], num, false);
						if (flag)
						{
							dataRow2["radif"] = num - 1;
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
				try
				{
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow3["radif"], -1, false);
						if (flag)
						{
							dataRow3["radif"] = num;
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					bool flag = enumerator3 is IDisposable;
					if (flag)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				this.Grid_RizBar.Focus();
			}
		}

		// Token: 0x04000E6C RID: 3692
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000E6E RID: 3694
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000E6F RID: 3695
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000E70 RID: 3696
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000E71 RID: 3697
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000E72 RID: 3698
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000E73 RID: 3699
		[AccessedThroughProperty("txt_takhlie")]
		private CurrencyBox _txt_takhlie;

		// Token: 0x04000E74 RID: 3700
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000E75 RID: 3701
		[AccessedThroughProperty("txt_jamFurush")]
		private CurrencyBox _txt_jamFurush;

		// Token: 0x04000E76 RID: 3702
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000E77 RID: 3703
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000E78 RID: 3704
		[AccessedThroughProperty("txt_karmozd")]
		private CurrencyBox _txt_karmozd;

		// Token: 0x04000E79 RID: 3705
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000E7A RID: 3706
		[AccessedThroughProperty("txt_keraye")]
		private CurrencyBox _txt_keraye;

		// Token: 0x04000E7B RID: 3707
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000E7C RID: 3708
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000E7D RID: 3709
		[AccessedThroughProperty("txt_mande")]
		private CurrencyBox _txt_mande;

		// Token: 0x04000E7E RID: 3710
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000E7F RID: 3711
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000E80 RID: 3712
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000E81 RID: 3713
		[AccessedThroughProperty("WarningBox1")]
		private WarningBox _WarningBox1;

		// Token: 0x04000E82 RID: 3714
		[AccessedThroughProperty("txt_darsad")]
		private NumericBox _txt_darsad;

		// Token: 0x04000E83 RID: 3715
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000E84 RID: 3716
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000E85 RID: 3717
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000E86 RID: 3718
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000E87 RID: 3719
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000E88 RID: 3720
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000E89 RID: 3721
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000E8A RID: 3722
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000E8B RID: 3723
		[AccessedThroughProperty("lbl_vurudbar")]
		private Label _lbl_vurudbar;

		// Token: 0x04000E8C RID: 3724
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000E8D RID: 3725
		[AccessedThroughProperty("lbl_tedadkol")]
		private Label _lbl_tedadkol;

		// Token: 0x04000E8E RID: 3726
		[AccessedThroughProperty("lbl_baskulmabda")]
		private Label _lbl_baskulmabda;

		// Token: 0x04000E8F RID: 3727
		[AccessedThroughProperty("lbl_baskul")]
		private Label _lbl_baskul;

		// Token: 0x04000E90 RID: 3728
		[AccessedThroughProperty("lbl_shmashin")]
		private Label _lbl_shmashin;

		// Token: 0x04000E91 RID: 3729
		[AccessedThroughProperty("lbl_sh_barname")]
		private Label _lbl_sh_barname;

		// Token: 0x04000E92 RID: 3730
		[AccessedThroughProperty("lbl_sahebbar")]
		private Label _lbl_sahebbar;

		// Token: 0x04000E93 RID: 3731
		[AccessedThroughProperty("txt_num")]
		private NumericBox _txt_num;

		// Token: 0x04000E94 RID: 3732
		[AccessedThroughProperty("txt_tarikh")]
		private MaskedEditBox _txt_tarikh;

		// Token: 0x04000E95 RID: 3733
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000E96 RID: 3734
		[AccessedThroughProperty("MetroStatusBar1")]
		private MetroStatusBar _MetroStatusBar1;

		// Token: 0x04000E97 RID: 3735
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000E98 RID: 3736
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000E99 RID: 3737
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000E9A RID: 3738
		[AccessedThroughProperty("txt_hezar2")]
		private CurrencyBox _txt_hezar2;

		// Token: 0x04000E9B RID: 3739
		[AccessedThroughProperty("txt_hezar1")]
		private CurrencyBox _txt_hezar1;

		// Token: 0x04000E9C RID: 3740
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000E9D RID: 3741
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000E9E RID: 3742
		[AccessedThroughProperty("txt_tozih")]
		private EditBox _txt_tozih;

		// Token: 0x04000E9F RID: 3743
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000EA0 RID: 3744
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x04000EA1 RID: 3745
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x04000EA2 RID: 3746
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000EA3 RID: 3747
		[AccessedThroughProperty("txt_sayer")]
		private CurrencyBox _txt_sayer;

		// Token: 0x04000EA4 RID: 3748
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000EA5 RID: 3749
		[AccessedThroughProperty("txt_saat")]
		private MaskedEditBox _txt_saat;

		// Token: 0x04000EA6 RID: 3750
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000EA7 RID: 3751
		[AccessedThroughProperty("UiRadioButton3")]
		private UIRadioButton _UiRadioButton3;

		// Token: 0x04000EA8 RID: 3752
		[AccessedThroughProperty("Grid_rizFurush")]
		private DataEntryGrid _Grid_rizFurush;

		// Token: 0x04000EA9 RID: 3753
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000EAA RID: 3754
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000EAB RID: 3755
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04000EAC RID: 3756
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000EAD RID: 3757
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04000EAE RID: 3758
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x04000EAF RID: 3759
		[AccessedThroughProperty("UiRadioButton4")]
		private UIRadioButton _UiRadioButton4;

		// Token: 0x04000EB0 RID: 3760
		[AccessedThroughProperty("txt_mablagh2")]
		private CurrencyBox _txt_mablagh2;

		// Token: 0x04000EB1 RID: 3761
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000EB2 RID: 3762
		[AccessedThroughProperty("txt_jamkol")]
		private CurrencyBox _txt_jamkol;

		// Token: 0x04000EB3 RID: 3763
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000EB4 RID: 3764
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000EB5 RID: 3765
		private Furush_Hag furush;

		// Token: 0x04000EB6 RID: 3766
		private Safi_Furush Safi_Furush;

		// Token: 0x04000EB7 RID: 3767
		private Safi_Extend Sarak;

		// Token: 0x04000EB8 RID: 3768
		[CompilerGenerated]
		private long? _Furush_ID;

		// Token: 0x04000EB9 RID: 3769
		private int? Safi_ID;

		// Token: 0x04000EBA RID: 3770
		public bool save;

		// Token: 0x04000EBB RID: 3771
		private bool isnew;

		// Token: 0x04000EBC RID: 3772
		private DataRow dr_head;

		// Token: 0x04000EBD RID: 3773
		private bool darsad_focus;

		// Token: 0x04000EBE RID: 3774
		private bool calc_karmozd;

		// Token: 0x04000EBF RID: 3775
		private bool calc_darsad;

		// Token: 0x04000EC0 RID: 3776
		private bool has_sarak;

		// Token: 0x04000EC1 RID: 3777
		private string jens;

		// Token: 0x04000EC2 RID: 3778
		private DataRow dr_furush;
	}
}
