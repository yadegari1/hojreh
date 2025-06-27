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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200010B RID: 267
	[DesignerGenerated]
	public partial class Frm_Safi_Sardkhane : Form
	{
		// Token: 0x060025DC RID: 9692 RVA: 0x001C9EBC File Offset: 0x001C80BC
		public Frm_Safi_Sardkhane()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Safi_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Safi_KeyDown);
			base.Load += new EventHandler(this.Frm_Safi_Load);
			Frm_Safi_Sardkhane.__ENCAddToList(this);
			this.furush = new Furush_Sardkhane();
			this.safi = new Safi_Furush_Sardkhane();
			this.kharid = new Kharid_sardkhane();
			this.save = false;
			this.darsad_focus = false;
			this.calc_karmozd = false;
			this.calc_darsad = false;
			this.jens = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x001C9F64 File Offset: 0x001C8164
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Safi_Sardkhane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Safi_Sardkhane.__ENCList.Count == Frm_Safi_Sardkhane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Safi_Sardkhane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Safi_Sardkhane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Safi_Sardkhane.__ENCList[num] = Frm_Safi_Sardkhane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Safi_Sardkhane.__ENCList.RemoveRange(num, Frm_Safi_Sardkhane.__ENCList.Count - num);
						Frm_Safi_Sardkhane.__ENCList.Capacity = Frm_Safi_Sardkhane.__ENCList.Count;
					}
					Frm_Safi_Sardkhane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x001CD68C File Offset: 0x001CB88C
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x001CD6A4 File Offset: 0x001CB8A4
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

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x001CD704 File Offset: 0x001CB904
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00009756 File Offset: 0x00007956
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

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x001CD71C File Offset: 0x001CB91C
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00009760 File Offset: 0x00007960
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

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x001CD734 File Offset: 0x001CB934
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x001CD74C File Offset: 0x001CB94C
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

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x001CD7AC File Offset: 0x001CB9AC
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x0000976A File Offset: 0x0000796A
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

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x001CD7C4 File Offset: 0x001CB9C4
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x001CD7DC File Offset: 0x001CB9DC
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

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x001CD83C File Offset: 0x001CBA3C
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x00009774 File Offset: 0x00007974
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

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x001CD854 File Offset: 0x001CBA54
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x0000977E File Offset: 0x0000797E
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

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x001CD86C File Offset: 0x001CBA6C
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00009788 File Offset: 0x00007988
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

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x001CD884 File Offset: 0x001CBA84
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x00009792 File Offset: 0x00007992
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

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x001CD89C File Offset: 0x001CBA9C
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x001CD8B4 File Offset: 0x001CBAB4
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

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x001CD93C File Offset: 0x001CBB3C
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x0000979C File Offset: 0x0000799C
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x001CD954 File Offset: 0x001CBB54
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x001CD96C File Offset: 0x001CBB6C
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

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x001CD9CC File Offset: 0x001CBBCC
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x000097A6 File Offset: 0x000079A6
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

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x001CD9E4 File Offset: 0x001CBBE4
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x000097B0 File Offset: 0x000079B0
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x001CD9FC File Offset: 0x001CBBFC
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x001CDA14 File Offset: 0x001CBC14
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x001CDA74 File Offset: 0x001CBC74
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x000097BA File Offset: 0x000079BA
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

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x001CDA8C File Offset: 0x001CBC8C
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x001CDAA4 File Offset: 0x001CBCA4
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

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x001CDB04 File Offset: 0x001CBD04
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x000097C4 File Offset: 0x000079C4
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
				this._ButtonItem3 = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x001CDB1C File Offset: 0x001CBD1C
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x000097CE File Offset: 0x000079CE
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

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x001CDB34 File Offset: 0x001CBD34
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x001CDB4C File Offset: 0x001CBD4C
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

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x001CDBD4 File Offset: 0x001CBDD4
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x001CDBEC File Offset: 0x001CBDEC
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

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x001CDC4C File Offset: 0x001CBE4C
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x000097D8 File Offset: 0x000079D8
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

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x001CDC64 File Offset: 0x001CBE64
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x000097E2 File Offset: 0x000079E2
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

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x001CDC7C File Offset: 0x001CBE7C
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x000097EC File Offset: 0x000079EC
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

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x001CDC94 File Offset: 0x001CBE94
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x000097F6 File Offset: 0x000079F6
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

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x001CDCAC File Offset: 0x001CBEAC
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x00009800 File Offset: 0x00007A00
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

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x001CDCC4 File Offset: 0x001CBEC4
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x0000980A File Offset: 0x00007A0A
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

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x001CDCDC File Offset: 0x001CBEDC
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x00009814 File Offset: 0x00007A14
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x001CDCF4 File Offset: 0x001CBEF4
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0000981E File Offset: 0x00007A1E
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x001CDD0C File Offset: 0x001CBF0C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x00009828 File Offset: 0x00007A28
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x001CDD24 File Offset: 0x001CBF24
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x00009832 File Offset: 0x00007A32
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x001CDD3C File Offset: 0x001CBF3C
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0000983C File Offset: 0x00007A3C
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x001CDD54 File Offset: 0x001CBF54
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00009846 File Offset: 0x00007A46
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x001CDD6C File Offset: 0x001CBF6C
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x001CDD84 File Offset: 0x001CBF84
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x001CDE34 File Offset: 0x001CC034
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00009850 File Offset: 0x00007A50
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x001CDE4C File Offset: 0x001CC04C
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x0000985A File Offset: 0x00007A5A
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x001CDE64 File Offset: 0x001CC064
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x00009864 File Offset: 0x00007A64
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x001CDE7C File Offset: 0x001CC07C
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0000986E File Offset: 0x00007A6E
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

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x001CDE94 File Offset: 0x001CC094
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00009878 File Offset: 0x00007A78
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

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x001CDEAC File Offset: 0x001CC0AC
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x00009882 File Offset: 0x00007A82
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x001CDEC4 File Offset: 0x001CC0C4
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x0000988C File Offset: 0x00007A8C
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

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x001CDEDC File Offset: 0x001CC0DC
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x00009896 File Offset: 0x00007A96
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x001CDEF4 File Offset: 0x001CC0F4
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x000098A0 File Offset: 0x00007AA0
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

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x001CDF0C File Offset: 0x001CC10C
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x000098AA File Offset: 0x00007AAA
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x001CDF24 File Offset: 0x001CC124
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x001CDF3C File Offset: 0x001CC13C
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x001CDF9C File Offset: 0x001CC19C
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x000098B4 File Offset: 0x00007AB4
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

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x001CDFB4 File Offset: 0x001CC1B4
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x001CDFCC File Offset: 0x001CC1CC
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x001CE02C File Offset: 0x001CC22C
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x001CE044 File Offset: 0x001CC244
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

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x001CE0A4 File Offset: 0x001CC2A4
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x000098BE File Offset: 0x00007ABE
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

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x001CE0BC File Offset: 0x001CC2BC
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x001CE0D4 File Offset: 0x001CC2D4
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

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x001CE134 File Offset: 0x001CC334
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x000098C8 File Offset: 0x00007AC8
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

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x001CE14C File Offset: 0x001CC34C
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x000098D2 File Offset: 0x00007AD2
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x001CE164 File Offset: 0x001CC364
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x000098DC File Offset: 0x00007ADC
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x001CE17C File Offset: 0x001CC37C
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x001CE194 File Offset: 0x001CC394
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

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x001CE1F4 File Offset: 0x001CC3F4
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x000098E6 File Offset: 0x00007AE6
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

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x001CE20C File Offset: 0x001CC40C
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x000098F0 File Offset: 0x00007AF0
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

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x001CE224 File Offset: 0x001CC424
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x001CE23C File Offset: 0x001CC43C
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x001CE29C File Offset: 0x001CC49C
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x000098FA File Offset: 0x00007AFA
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

		// Token: 0x06002656 RID: 9814 RVA: 0x001CE2B4 File Offset: 0x001CC4B4
		private bool Validate_Mablagh()
		{
			string arg_26_0 = "select id,jam_kol from furush_Sardkhane_detail where furush_Sardkhane_id=";
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

		// Token: 0x06002657 RID: 9815 RVA: 0x001CE418 File Offset: 0x001CC618
		private bool Validate_Vazn()
		{
			string arg_26_0 = "select baskul from Furush_Sardkhane where id=";
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
				string arg_84_0 = "select isnull(baskul_mabda,0) from Furush_Sardkhane where id=";
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
				array[0] = "select isnull(sum(vazn_ba_zarf),0) from Furush_Sardkhane_detail where Furush_Sardkhane_ID=";
				string[] arg_E2_0 = array;
				int arg_E2_1 = 1;
				furush_ID = this.Furush_ID;
				arg_E2_0[arg_E2_1] = (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null);
				array[2] = " AND kala_id not in(select kala_id from Furush_Sardkhane_rizbar where Furush_Sardkhane_id=";
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

		// Token: 0x06002658 RID: 9816 RVA: 0x001CE5C0 File Offset: 0x001CC7C0
		private bool Validate_Tedad()
		{
			string arg_26_0 = "select tedad_kol from Furush_Sardkhane where id=";
			long? furush_ID = this.Furush_ID;
			object obj = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar(arg_26_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
			bool flag = obj == DBNull.Value;
			if (flag)
			{
				obj = 0;
			}
			this.WarningBox1.Text = string.Empty;
			string arg_82_0 = "select isnull(sum(Tedad),0) from Furush_Sardkhane_detail where Furush_Sardkhane_ID=";
			furush_ID = this.Furush_ID;
			decimal num = Conversions.ToDecimal(Public_Function.ExecuteScalar(arg_82_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
			flag = Operators.ConditionalCompareObjectLess(num, obj, false);
			bool result;
			if (flag)
			{
				this.WarningBox1.Visible = true;
				WarningBox warningBox = this.WarningBox1;
				warningBox.Text = warningBox.Text + "<b>تعداد بار فروخته شده به میزان " + Operators.SubtractObject(obj, num).ToString().Replace(".0", "") + " واحد کمتر از تعداد کل بار میباشد </b><br></br><br></br>";
				result = false;
			}
			else
			{
				flag = Operators.ConditionalCompareObjectGreater(num, obj, false);
				if (flag)
				{
					this.WarningBox1.Visible = true;
					WarningBox warningBox = this.WarningBox1;
					warningBox.Text = Conversions.ToString(Operators.ConcatenateObject(warningBox.Text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<b>تعداد بار فروخته شده به میزان ", Operators.SubtractObject(num, obj)), " واحد بیشتر از تعداد کل بار میباشد "), "</b><br></br><br></br>")));
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x001CE73C File Offset: 0x001CC93C
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
							GridEXCell gridEXCell = this.Grid_RizBar.GetRow(0).Cells["makharej"];
							GridEXCell arg_874_0 = gridEXCell;
							object arg_86F_0 = gridEXCell.Value;
							value2 = this.txt_takhlie.Value;
							long? arg_86A_0;
							if (!value2.HasValue)
							{
								arg_86A_0 = null;
							}
							else
							{
								value = new long?(value2.GetValueOrDefault() - num4);
								arg_86A_0 = value;
							}
							arg_874_0.Value = Operators.AddObject(arg_86F_0, arg_86A_0);
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
						long? arg_90F_0;
						if (!value.HasValue)
						{
							arg_90F_0 = null;
						}
						else
						{
							value3 = new long?(num5 + value.GetValueOrDefault());
							arg_90F_0 = value3;
						}
						num5 = (T)arg_90F_0;
					}
					value3 = this.txt_sayer.Value;
					flag4 = value3.HasValue;
					if (flag4)
					{
						value2 = this.txt_sayer.Value;
						long? arg_967_0;
						if (!value2.HasValue)
						{
							arg_967_0 = null;
						}
						else
						{
							value = new long?(num5 + value2.GetValueOrDefault());
							arg_967_0 = value;
						}
						num5 = (T)arg_967_0;
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

		// Token: 0x0600265A RID: 9818 RVA: 0x001CF320 File Offset: 0x001CD520
		private void LoadData()
		{
			this.WarningBox1.Text = string.Empty;
			this.WarningBox1.Visible = false;
			this.ButtonItem2.Enabled = true;
			string arg_51_0 = "SELECT        Furush_Sardkhane.ID, Furush_Sardkhane.Num, Furush_Sardkhane.Sh_Mashin, Furush_Sardkhane.Sh_Barname, Furush_Sardkhane.Tarikh_Vurud, Furush_Sardkhane.[Desc],   Furush_Sardkhane.Baskul, Furush_Sardkhane.Baskul_Mabda, Furush_Sardkhane.Tedad_Kol  FROM            Furush_Sardkhane    where Furush_Sardkhane.id=";
			long? furush_ID = this.Furush_ID;
			DataRow dataRow = Public_Function.FillDataRow(arg_51_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null));
			bool flag = dataRow != null;
			bool flag2;
			if (flag)
			{
				flag2 = (dataRow["baskul"] != DBNull.Value);
				if (flag2)
				{
					dataRow["baskul"] = dataRow["baskul"].ToString().Replace(".0", "");
				}
				flag2 = (dataRow["tedad_kol"] != DBNull.Value);
				if (flag2)
				{
					dataRow["tedad_kol"] = dataRow["tedad_kol"].ToString().Replace(".0", "");
				}
				this.lbl_vurudbar.Text = Conversions.ToString(dataRow["Tarikh_Vurud"]);
				flag2 = (dataRow["baskul"] != DBNull.Value);
				if (flag2)
				{
					this.lbl_baskul.Text = dataRow["baskul"].ToString().Replace(".0", "");
				}
				this.lbl_baskulmabda.Text = dataRow["baskul_mabda"].ToString();
				this.lbl_sh_barname.Text = dataRow["sh_barname"].ToString();
				this.lbl_shmashin.Text = dataRow["sh_mashin"].ToString();
				flag2 = (dataRow["tedad_kol"] != DBNull.Value);
				if (flag2)
				{
					this.lbl_tedadkol.Text = dataRow["tedad_kol"].ToString().Replace(".0", "");
				}
			}
			else
			{
				this.lbl_vurudbar.Text = string.Empty;
				this.lbl_baskul.Text = string.Empty;
				this.lbl_baskulmabda.Text = string.Empty;
				this.lbl_sh_barname.Text = string.Empty;
				this.lbl_shmashin.Text = string.Empty;
				this.lbl_tedadkol.Text = string.Empty;
				this.txt_keraye.Text = string.Empty;
				this.txt_takhlie.Text = string.Empty;
			}
			string arg_2B1_0 = "SELECT    HazineKharid_ID,  ISNULL(sum( Furush_Sardkhane_Keraye.Keraye),0) as keraye  FROM         Furush_Sardkhane_Keraye INNER JOIN  Hazine_Kharid ON Furush_Sardkhane_Keraye.HazineKharid_ID = Hazine_Kharid.ID  where furush_Sardkhane_id=";
			furush_ID = this.Furush_ID;
			DataTable dataTable = Public_Function.FillData(arg_2B1_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null) + " group by HazineKharid_ID");
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
			long num2 = 0L;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator.Current;
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow2["HazineKharid_ID"], -4, false) && Operators.ConditionalCompareObjectNotEqual(dataRow2["HazineKharid_ID"], -5, false) && Operators.ConditionalCompareObjectNotEqual(dataRow2["HazineKharid_ID"], -6, false));
					if (flag2)
					{
						num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow2["keraye"]));
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
			string arg_485_0 = " SELECT        Furush_Sardkhane_Detail.Kala_ID, SUM(Furush_Sardkhane_Detail.Tedad) AS Tedad, SUM(Furush_Sardkhane_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf,  SUM(Furush_Sardkhane_Detail.Vazn_Kol) AS Vazn_Kol, SUM(Furush_Sardkhane_Detail.Jam_Kol) AS Jam_Kol, SUM(Furush_Sardkhane_Detail.Jam_Kol)   / SUM(Furush_Sardkhane_Detail.Vazn_Kol) AS gheymat, MIN(Kala.Name) AS Kala_Name   FROM            Furush_Sardkhane_Detail INNER JOIN   Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID   WHERE Furush_Sardkhane_Detail.Furush_Sardkhane_ID = ";
			furush_ID = this.Furush_ID;
			DataTable dataTable2 = Public_Function.FillData(arg_485_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null) + "  GROUP BY Furush_Sardkhane_Detail.Kala_ID ");
			dataTable2.TableName = "data";
			this.jens = string.Empty;
			try
			{
				IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator2.Current;
					this.jens = Conversions.ToString(Operators.ConcatenateObject(this.jens, Operators.ConcatenateObject(dataRow3["kala_name"], "-")));
					flag2 = (dataRow3["tedad"] != DBNull.Value);
					if (flag2)
					{
						dataRow3["tedad"] = dataRow3["tedad"].ToString().Replace(".0", "");
					}
					flag2 = (dataRow3["vazn_ba_zarf"] != DBNull.Value);
					if (flag2)
					{
						dataRow3["Vazn_ba_Zarf"] = dataRow3["Vazn_ba_Zarf"].ToString().Replace(".0", "");
					}
					flag2 = (dataRow3["vazn_kol"] != DBNull.Value);
					if (flag2)
					{
						dataRow3["Vazn_Kol"] = dataRow3["Vazn_Kol"].ToString().Replace(".0", "");
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
			this.Grid_RizBar.DataSource = dataTable2;
			this.txt_jamFurush.Text = Conversions.ToString(this.Grid_RizBar.GetTotalRow().Cells["Jam_Kol"].Value);
			this.Validate_Tedad();
			this.Validate_Vazn();
			this.Validate_Mablagh();
			flag2 = !this.WarningBox1.Visible;
			checked
			{
				if (flag2)
				{
					DataEntryGrid dataEntryGrid = this.Grid_RizBar;
					dataEntryGrid.Height += 77;
					dataEntryGrid = this.Grid_rizFurush;
					dataEntryGrid.Height += 77;
				}
				DataRow byID = this.safi.GetByID(Conversions.ToString((T)this.Furush_ID));
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
					object expr_8A7 = byID["ID"];
					int? num3;
					this.Safi_ID = ((expr_8A7 != null) ? ((int?)expr_8A7) : num3);
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
				this.safibarvazn();
				this.txt_karmozd.TextChanged += new EventHandler(this.txt_karmozd_TextChanged);
				this.txt_darsad.TextChanged += new EventHandler(this.txt_darsad_TextChanged);
				flag2 = (Operators.CompareString(Public_Function.dict["noesafi"], "1", false) != 0);
				if (flag2)
				{
					flag = (Operators.CompareString(Public_Function.dict["noesafi"], "2", false) == 0);
					if (flag)
					{
						this.UiRadioButton2.Checked = true;
					}
					flag2 = (Operators.CompareString(Public_Function.dict["noesafi"], "3", false) == 0);
					if (flag2)
					{
						this.UiRadioButton3.Checked = true;
					}
				}
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x001CFDF8 File Offset: 0x001CDFF8
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
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x001CFEB0 File Offset: 0x001CE0B0
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
					flag = this.ButtonItem2.Visible;
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

		// Token: 0x0600265D RID: 9821 RVA: 0x001CFF6C File Offset: 0x001CE16C
		private void Frm_Safi_Load(object sender, EventArgs e)
		{
			this.txt_karmozd.AllowNegative = true;
			bool hasValue = this.Furush_ID.HasValue;
			if (hasValue)
			{
				Control arg_59_0 = this.txt_num;
				string arg_4A_0 = "select num from furush_Sardkhane where id=";
				long? furush_ID = this.Furush_ID;
				arg_59_0.Text = Conversions.ToString(Public_Function.ExecuteScalar(arg_4A_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null)));
				this.LoadData();
				this.GetMande();
				this.txt_darsad.Focus();
			}
			else
			{
				this.isnew = true;
				this.txt_num.Focus();
			}
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x001D000C File Offset: 0x001CE20C
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
					int num2 = (int)(num % 1000L);
					flag = (num2 != 0);
					if (flag)
					{
						num += unchecked((long)(checked(1000 - num2)));
						this.txt_hezar1.Text = Conversions.ToString(1000 - num2);
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
						this.LabelItem1.Text = huruf.ConvertToHuruf(Conversions.ToString(num), huruf.ConvertType.تومان);
						this.MetroStatusBar1.Refresh();
					}
				}
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x001D01F0 File Offset: 0x001CE3F0
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

		// Token: 0x06002660 RID: 9824 RVA: 0x001D03D0 File Offset: 0x001CE5D0
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
						int value = checked((int)Math.Round(unchecked(Conversions.ToDouble(this.txt_jamFurush.Text) / 100.0 * Conversions.ToDouble(this.txt_darsad.Text))));
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

		// Token: 0x06002661 RID: 9825 RVA: 0x00009904 File Offset: 0x00007B04
		private void txt_keraye_TextChanged(object sender, EventArgs e)
		{
			this.GetMande();
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00009904 File Offset: 0x00007B04
		private void txt_takhlie_TextChanged(object sender, EventArgs e)
		{
			this.GetMande();
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x001D04F0 File Offset: 0x001CE6F0
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = true;
			bool flag2 = !this.Validate_Tedad();
			if (flag2)
			{
				flag = false;
			}
			flag2 = !this.Validate_Vazn();
			if (flag2)
			{
				flag = false;
			}
			flag2 = !this.Validate_Mablagh();
			if (flag2)
			{
				flag = false;
			}
			flag2 = !flag;
			checked
			{
				if (!flag2)
				{
					flag2 = (Operators.CompareString(this.txt_tarikh.Text, string.Empty, false) != 0);
					bool flag3;
					if (flag2)
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
						string arg_134_0 = "select isnull(count(id),0) from Furush_Sardkhane_Safi where furush_Sardkhane_id=";
						long? num = this.Furush_ID;
						long num2 = Conversions.ToLong(Public_Function.ExecuteScalar(arg_134_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null)));
						flag3 = (num2 > 0L);
						if (flag3)
						{
							this.Safi_ID = (int)num2;
							this.isnew = false;
						}
					}
					flag3 = this.isnew;
					long? num3;
					if (flag3)
					{
						Safi_Furush_Sardkhane arg_25F_0 = this.safi;
						string arg_25F_1 = this.txt_num.Text;
						string arg_25F_2 = Conversions.ToString((T)this.Furush_ID);
						string arg_25F_3 = this.txt_jamFurush.Value.ToString();
						string arg_25F_4 = this.txt_darsad.Text;
						string arg_25F_5 = this.txt_karmozd.Value.ToString();
						long? num = this.txt_mande.Value;
						bool arg_200_0 = num.HasValue;
						long? value = this.txt_hezar1.Value;
						long? arg_228_0;
						if (!(arg_200_0 & value.HasValue))
						{
							arg_228_0 = null;
						}
						else
						{
							num3 = new long?(num.GetValueOrDefault() + value.GetValueOrDefault());
							arg_228_0 = num3;
						}
						this.Safi_ID = (int)arg_25F_0.Insert(arg_25F_1, arg_25F_2, arg_25F_3, arg_25F_4, arg_25F_5, Conversions.ToString((T)arg_228_0), this.txt_tarikh.Text, this.lbl_vurudbar.Text, this.txt_tozih.Text, text, this.lbl_shmashin.Text);
						this.isnew = false;
						Public_Function.ConfirmInsert();
					}
					else
					{
						flag3 = (Public_Function.ConfirmUpdate() == DialogResult.Yes);
						if (flag3)
						{
							Safi_Furush_Sardkhane arg_37A_0 = this.safi;
							string arg_37A_1 = this.txt_num.Text;
							string arg_37A_2 = this.txt_jamFurush.Value.ToString();
							string arg_37A_3 = this.txt_darsad.Text;
							string arg_37A_4 = this.txt_karmozd.Value.ToString();
							num3 = this.txt_mande.Value;
							bool arg_30B_0 = num3.HasValue;
							long? value = this.txt_hezar1.Value;
							long? arg_333_0;
							if (!(arg_30B_0 & value.HasValue))
							{
								arg_333_0 = null;
							}
							else
							{
								long? num = new long?(num3.GetValueOrDefault() + value.GetValueOrDefault());
								arg_333_0 = num;
							}
							arg_37A_0.Update(arg_37A_1, arg_37A_2, arg_37A_3, arg_37A_4, Conversions.ToString((T)arg_333_0), this.txt_tarikh.Text, this.lbl_vurudbar.Text, this.txt_tozih.Text, text, this.lbl_shmashin.Text, Conversions.ToString((T)this.Safi_ID));
							Public_Function.ConfirmInsert();
						}
					}
					this.save = true;
					Public_Function.InvokeMethod("LoadSafiData");
					MyProject.Forms.Form_Main.Get_mande_Safi();
					string arg_3CF_0 = " SELECT     Kharid_Sardkhane.Num  FROM         Furush_Sardkhane INNER JOIN  Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID where Furush_Sardkhane.ID=";
					num3 = this.Furush_ID;
					string text2 = Conversions.ToString(Public_Function.ExecuteScalar(arg_3CF_0 + (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null)));
				}
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x001D08E0 File Offset: 0x001CEAE0
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

		// Token: 0x06002665 RID: 9829 RVA: 0x001D0930 File Offset: 0x001CEB30
		private bool Validate_Furush(int ID)
		{
			string text = "declare @tedad; select @tedad=select tedad_kol from furush_Sardkhane where id=" + Conversions.ToString(ID) + ";";
			text += "";
			return Conversions.ToBoolean(text);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002667 RID: 9831 RVA: 0x001D096C File Offset: 0x001CEB6C
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = !this.Furush_ID.HasValue;
			if (!flag)
			{
				string arg_44_0 = "SELECT        Furush_Sardkhane.ID, Furush_Sardkhane.Num,  Furush_Sardkhane.Sh_Mashin, Furush_Sardkhane.Sh_Barname, Furush_Sardkhane.Tarikh_Vurud, Furush_Sardkhane.[Desc],  Furush_Sardkhane.Baskul, Furush_Sardkhane.Baskul_Mabda, Furush_Sardkhane.Tedad_Kol  FROM Furush_Sardkhane  where Furush_Sardkhane.id=";
				long? num = this.Furush_ID;
				DataTable dataTable = Public_Function.FillData(arg_44_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
				flag = (dataTable.Rows.Count > 0);
				bool flag2;
				if (flag)
				{
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
				string arg_15C_0 = "SELECT        Furush_Sardkhane_Safi.*  FROM            Furush_Sardkhane_Safi where Furush_Sardkhane_id=";
				num = this.Furush_ID;
				DataTable dataTable2 = Public_Function.FillData(arg_15C_0 + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null));
				flag2 = (dataTable2.Rows.Count == 0);
				if (!flag2)
				{
					dataTable.TableName = "head";
					dataTable2.TableName = "safi";
					StiReport stiReport = new StiReport();
					flag2 = this.UiRadioButton1.Checked;
					if (flag2)
					{
						stiReport.Load(Application.StartupPath + "\\reports\\safi.mrt");
					}
					flag2 = this.UiRadioButton2.Checked;
					if (flag2)
					{
						stiReport.Load(Application.StartupPath + "\\reports\\safi2.mrt");
					}
					flag2 = this.UiRadioButton3.Checked;
					if (flag2)
					{
						stiReport.Load(Application.StartupPath + "\\reports\\safi3.mrt");
					}
					flag2 = (dataTable2.Rows[0]["printcount"] != DBNull.Value);
					StiText stiText;
					if (flag2)
					{
						stiText = (StiText)stiReport.GetComponentByName("lbl_copy");
						stiText.Text = "کپی";
					}
					flag2 = (Operators.CompareString(dataTable.Rows[0]["desc"].ToString(), string.Empty, false) != 0);
					if (flag2)
					{
						flag = (Operators.CompareString(dataTable2.Rows[0]["tozih"].ToString(), string.Empty, false) == 0);
						if (flag)
						{
							dataTable2.Rows[0]["tozih"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["desc"]);
						}
						else
						{
							dataTable2.Rows[0]["tozih"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[0]["desc"], " - "), dataTable2.Rows[0]["tozih"]);
						}
						stiText = (StiText)stiReport.GetComponentByName("Text67");
						stiText.Text.Value = Conversions.ToString(dataTable2.Rows[0]["tozih"]);
					}
					flag2 = !this.UiRadioButton3.Checked;
					if (flag2)
					{
						stiReport.RegData((DataTable)this.Grid_RizBar.DataSource);
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
						stiText.Text = Public_Function.FormatPrice(Conversions.ToString((T)this.txt_keraye.Value)) + " - ";
					}
					flag2 = this.txt_karmozd.Value.HasValue;
					if (flag2)
					{
						stiText = (StiText)stiReport.GetComponentByName("Text30");
						stiText.Text = Public_Function.FormatPrice(Conversions.ToString((T)this.txt_karmozd.Value)) + " - ";
					}
					flag2 = this.txt_takhlie.Value.HasValue;
					if (flag2)
					{
						stiText = (StiText)stiReport.GetComponentByName("Text32");
						stiText.Text = Public_Function.FormatPrice(Conversions.ToString((T)this.txt_takhlie.Value)) + " - ";
					}
					flag2 = this.txt_sayer.Value.HasValue;
					long? num3;
					if (flag2)
					{
						long num2 = 0L;
						num3 = this.txt_sayer.Value;
						bool? arg_54B_0;
						if (!num3.HasValue)
						{
							arg_54B_0 = null;
						}
						else
						{
							bool? flag3 = new bool?(num3.GetValueOrDefault() != num2);
							arg_54B_0 = flag3;
						}
						bool? flag4 = arg_54B_0;
						flag = flag4.GetValueOrDefault();
						if (flag)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text49");
							stiText.Text = Public_Function.FormatPrice(Conversions.ToString((T)this.txt_sayer.Value)) + " - ";
						}
					}
					flag2 = this.txt_hezar1.Value.HasValue;
					if (flag2)
					{
						long num2 = 0L;
						num = this.txt_hezar1.Value;
						bool? arg_5F8_0;
						if (!num.HasValue)
						{
							arg_5F8_0 = null;
						}
						else
						{
							bool? flag4 = new bool?(num.GetValueOrDefault() != num2);
							arg_5F8_0 = flag4;
						}
						bool? flag3 = arg_5F8_0;
						flag = flag3.GetValueOrDefault();
						if (flag)
						{
							stiText = (StiText)stiReport.GetComponentByName("Text29");
							StiSimpleText arg_64D_0 = stiText;
							num3 = this.txt_hezar1.Value;
							arg_64D_0.Text = (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null) + " + ";
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
					flag2 = (Operators.CompareString(this.txt_mande.Text, string.Empty, false) != 0);
					if (flag2)
					{
						stiText = (StiText)stiReport.GetComponentByName("Text51");
						stiText.Text = Public_Function.FormatPrice(Conversions.ToString((T)this.txt_mande.Value));
					}
					stiText = (StiText)stiReport.GetComponentByName("Text61");
					stiText.Text = this.jens;
					stiText = (StiText)stiReport.GetComponentByName("Text57");
					stiText.Text = huruf.ConvertToHuruf(Conversions.ToString(dataTable2.Rows[0]["mande"]), huruf.ConvertType.تومان);
					Public_Function.SetReport_MarginTop(stiReport);
					this.SetHeader(stiReport);
					Public_Function.AddTazminText(stiReport, true, false);
					stiReport.Print(false);
					string arg_7EB_0 = "update Furush_Sardkhane_Safi set printcount=1 where furush_Sardkhane_id=";
					num3 = this.Furush_ID;
					Public_Function.ExecuteNonQuery(arg_7EB_0 + (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null));
				}
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x001D1170 File Offset: 0x001CF370
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

		// Token: 0x06002669 RID: 9833 RVA: 0x001D120C File Offset: 0x001CF40C
		private void txt_num_Validating(object sender, CancelEventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_num.Text, string.Empty, false) == 0;
			checked
			{
				if (!flag)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select id from furush_Sardkhane where num=" + this.txt_num.Text));
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
							this.LoadData();
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

		// Token: 0x0600266A RID: 9834 RVA: 0x001D1454 File Offset: 0x001CF654
		private void txt_karmozd_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_jamFurush.Text, string.Empty, false) == 0;
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
								long? arg_E0_0;
								if (!value.HasValue)
								{
									arg_E0_0 = null;
								}
								else
								{
									long? num3 = new long?(checked(value.GetValueOrDefault() * num2));
									arg_E0_0 = num3;
								}
								long? num4 = arg_E0_0;
								double? arg_108_0;
								if (!num4.HasValue)
								{
									arg_108_0 = null;
								}
								else
								{
									double? num5 = new double?((double)num4.GetValueOrDefault());
									arg_108_0 = num5;
								}
								double? num6 = arg_108_0;
								bool arg_14B_0 = num6.HasValue;
								long? value2 = this.txt_jamFurush.Value;
								double? arg_143_0;
								if (!value2.HasValue)
								{
									arg_143_0 = null;
								}
								else
								{
									double? num7 = new double?((double)value2.GetValueOrDefault());
									arg_143_0 = num7;
								}
								double? num8 = arg_143_0;
								double? arg_172_0;
								if (!(arg_14B_0 & num8.HasValue))
								{
									arg_172_0 = null;
								}
								else
								{
									double? num9 = new double?(num6.GetValueOrDefault() / num8.GetValueOrDefault());
									arg_172_0 = num9;
								}
								num = new decimal((T)arg_172_0);
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

		// Token: 0x0600266B RID: 9835 RVA: 0x001D16EC File Offset: 0x001CF8EC
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

		// Token: 0x0600266C RID: 9836 RVA: 0x001D1768 File Offset: 0x001CF968
		private void UiRadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Grid_RizBar.RootTable == null;
			if (!flag)
			{
				flag = this.UiRadioButton2.Checked;
				if (flag)
				{
					this.Grid_RizBar.RootTable.Columns["Jam_Kol"].Visible = true;
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
					string arg_1B8_0 = "SELECT     Furush_Sardkhane_Detail.ID, Furush_Sardkhane_Detail.Kala_ID, Furush_Sardkhane_Detail.Tedad, Furush_Sardkhane_Detail.Vazn_Ba_Zarf, Furush_Sardkhane_Detail.Zarf,  Furush_Sardkhane_Detail.Vazn_Kol, Furush_Sardkhane_Detail.Fee, Furush_Sardkhane_Detail.Jam_Kol, Kala.Name AS Kala_Name  FROM         Furush_Sardkhane_Detail INNER JOIN  Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID where furush_Sardkhane_id=";
					long? furush_ID = this.Furush_ID;
					DataTable dataTable = Public_Function.FillData(arg_1B8_0 + (furush_ID.HasValue ? Conversions.ToString(furush_ID.GetValueOrDefault()) : null));
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
								dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
							}
							flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
							if (flag)
							{
								dataRow["Vazn_ba_Zarf"] = dataRow["Vazn_ba_Zarf"].ToString().Replace(".0", "");
							}
							flag = (dataRow["vazn_kol"] != DBNull.Value);
							if (flag)
							{
								dataRow["Vazn_Kol"] = dataRow["Vazn_Kol"].ToString().Replace(".0", "");
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
				}
				else
				{
					this.Grid_rizFurush.Visible = false;
					this.Grid_RizBar.Visible = true;
				}
			}
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x001D1AB4 File Offset: 0x001CFCB4
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

		// Token: 0x0600266E RID: 9838 RVA: 0x0000990F File Offset: 0x00007B0F
		private void txt_karmozd_GotFocus(object sender, EventArgs e)
		{
			this.txt_karmozd.SelectAll();
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0000991F File Offset: 0x00007B1F
		private void txt_mande_GotFocus(object sender, EventArgs e)
		{
			this.txt_mande.SelectAll();
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0000992F File Offset: 0x00007B2F
		private void txt_darsad_GotFocus(object sender, EventArgs e)
		{
			this.darsad_focus = true;
			this.calc_darsad = false;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00009941 File Offset: 0x00007B41
		private void txt_darsad_LostFocus(object sender, EventArgs e)
		{
			this.darsad_focus = false;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x001D1B24 File Offset: 0x001CFD24
		private void txt_karmozd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_tozih.Focus();
			}
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x001D1B50 File Offset: 0x001CFD50
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

		// Token: 0x06002674 RID: 9844 RVA: 0x001C8FEC File Offset: 0x001C71EC
		private void Grid_RizBar_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells[0].Text = "جمع کل";
			}
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x001D1B98 File Offset: 0x001CFD98
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = this.isnew;
			if (!flag)
			{
				Frm_Sud_Furush showFrm = new Frm_Sud_Furush
				{
					Furush_ID = Conversions.ToString((T)this.Furush_ID),
					furush_num = this.txt_num.Text,
					Mablagh = (T)this.txt_karmozd.Value
				};
				MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
			}
		}

		// Token: 0x04000EC3 RID: 3779
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000EC5 RID: 3781
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000EC6 RID: 3782
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000EC7 RID: 3783
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000EC8 RID: 3784
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000EC9 RID: 3785
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000ECA RID: 3786
		[AccessedThroughProperty("txt_takhlie")]
		private CurrencyBox _txt_takhlie;

		// Token: 0x04000ECB RID: 3787
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000ECC RID: 3788
		[AccessedThroughProperty("txt_jamFurush")]
		private CurrencyBox _txt_jamFurush;

		// Token: 0x04000ECD RID: 3789
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000ECE RID: 3790
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000ECF RID: 3791
		[AccessedThroughProperty("txt_karmozd")]
		private CurrencyBox _txt_karmozd;

		// Token: 0x04000ED0 RID: 3792
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000ED1 RID: 3793
		[AccessedThroughProperty("txt_keraye")]
		private CurrencyBox _txt_keraye;

		// Token: 0x04000ED2 RID: 3794
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000ED3 RID: 3795
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000ED4 RID: 3796
		[AccessedThroughProperty("txt_mande")]
		private CurrencyBox _txt_mande;

		// Token: 0x04000ED5 RID: 3797
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000ED6 RID: 3798
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000ED7 RID: 3799
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000ED8 RID: 3800
		[AccessedThroughProperty("WarningBox1")]
		private WarningBox _WarningBox1;

		// Token: 0x04000ED9 RID: 3801
		[AccessedThroughProperty("txt_darsad")]
		private NumericBox _txt_darsad;

		// Token: 0x04000EDA RID: 3802
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000EDB RID: 3803
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000EDC RID: 3804
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000EDD RID: 3805
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000EDE RID: 3806
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000EDF RID: 3807
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000EE0 RID: 3808
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000EE1 RID: 3809
		[AccessedThroughProperty("lbl_vurudbar")]
		private Label _lbl_vurudbar;

		// Token: 0x04000EE2 RID: 3810
		[AccessedThroughProperty("lbl_tedadkol")]
		private Label _lbl_tedadkol;

		// Token: 0x04000EE3 RID: 3811
		[AccessedThroughProperty("lbl_baskulmabda")]
		private Label _lbl_baskulmabda;

		// Token: 0x04000EE4 RID: 3812
		[AccessedThroughProperty("lbl_baskul")]
		private Label _lbl_baskul;

		// Token: 0x04000EE5 RID: 3813
		[AccessedThroughProperty("lbl_shmashin")]
		private Label _lbl_shmashin;

		// Token: 0x04000EE6 RID: 3814
		[AccessedThroughProperty("lbl_sh_barname")]
		private Label _lbl_sh_barname;

		// Token: 0x04000EE7 RID: 3815
		[AccessedThroughProperty("txt_num")]
		private NumericBox _txt_num;

		// Token: 0x04000EE8 RID: 3816
		[AccessedThroughProperty("txt_tarikh")]
		private MaskedEditBox _txt_tarikh;

		// Token: 0x04000EE9 RID: 3817
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000EEA RID: 3818
		[AccessedThroughProperty("MetroStatusBar1")]
		private MetroStatusBar _MetroStatusBar1;

		// Token: 0x04000EEB RID: 3819
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000EEC RID: 3820
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000EED RID: 3821
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000EEE RID: 3822
		[AccessedThroughProperty("txt_hezar2")]
		private CurrencyBox _txt_hezar2;

		// Token: 0x04000EEF RID: 3823
		[AccessedThroughProperty("txt_hezar1")]
		private CurrencyBox _txt_hezar1;

		// Token: 0x04000EF0 RID: 3824
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000EF1 RID: 3825
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000EF2 RID: 3826
		[AccessedThroughProperty("txt_tozih")]
		private EditBox _txt_tozih;

		// Token: 0x04000EF3 RID: 3827
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000EF4 RID: 3828
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x04000EF5 RID: 3829
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x04000EF6 RID: 3830
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000EF7 RID: 3831
		[AccessedThroughProperty("txt_sayer")]
		private CurrencyBox _txt_sayer;

		// Token: 0x04000EF8 RID: 3832
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000EF9 RID: 3833
		[AccessedThroughProperty("txt_saat")]
		private MaskedEditBox _txt_saat;

		// Token: 0x04000EFA RID: 3834
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000EFB RID: 3835
		[AccessedThroughProperty("UiRadioButton3")]
		private UIRadioButton _UiRadioButton3;

		// Token: 0x04000EFC RID: 3836
		[AccessedThroughProperty("Grid_rizFurush")]
		private DataEntryGrid _Grid_rizFurush;

		// Token: 0x04000EFD RID: 3837
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000EFE RID: 3838
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04000EFF RID: 3839
		private Furush_Sardkhane furush;

		// Token: 0x04000F00 RID: 3840
		private Safi_Furush_Sardkhane safi;

		// Token: 0x04000F01 RID: 3841
		[CompilerGenerated]
		private long? _Furush_ID;

		// Token: 0x04000F02 RID: 3842
		private Kharid_sardkhane kharid;

		// Token: 0x04000F03 RID: 3843
		private int? Safi_ID;

		// Token: 0x04000F04 RID: 3844
		public bool save;

		// Token: 0x04000F05 RID: 3845
		private bool isnew;

		// Token: 0x04000F06 RID: 3846
		private DataRow dr_head;

		// Token: 0x04000F07 RID: 3847
		private bool darsad_focus;

		// Token: 0x04000F08 RID: 3848
		private bool calc_karmozd;

		// Token: 0x04000F09 RID: 3849
		private bool calc_darsad;

		// Token: 0x04000F0A RID: 3850
		private string jens;
	}
}
