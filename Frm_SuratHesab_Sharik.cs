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
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200014F RID: 335
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Sharik : Form
	{
		// Token: 0x06003234 RID: 12852 RVA: 0x00249034 File Offset: 0x00247234
		public Frm_SuratHesab_Sharik()
		{
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Moshtari_KeyDown);
			Frm_SuratHesab_Sharik.__ENCAddToList(this);
			this.Moshtari_Info = new Moshtari_Info();
			this.Moshtari_Pic = new Moshtari_Pic();
			this.last_mande = 0L;
			this.InitializeComponent();
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x002490A0 File Offset: 0x002472A0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Sharik.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Sharik.__ENCList.Count == Frm_SuratHesab_Sharik.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Sharik.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Sharik.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Sharik.__ENCList[num] = Frm_SuratHesab_Sharik.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Sharik.__ENCList.RemoveRange(num, Frm_SuratHesab_Sharik.__ENCList.Count - num);
						Frm_SuratHesab_Sharik.__ENCList.Capacity = Frm_SuratHesab_Sharik.__ENCList.Count;
					}
					Frm_SuratHesab_Sharik.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x0024B41C File Offset: 0x0024961C
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x0000CA31 File Offset: 0x0000AC31
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

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x0024B434 File Offset: 0x00249634
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x0000CA3B File Offset: 0x0000AC3B
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

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x0024B44C File Offset: 0x0024964C
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x0024B464 File Offset: 0x00249664
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				RowLoadEventHandler value3 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.LoadingRow -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.LoadingRow += value3;
				}
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x0024B4EC File Offset: 0x002496EC
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x0000CA45 File Offset: 0x0000AC45
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

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x0024B504 File Offset: 0x00249704
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x0024B51C File Offset: 0x0024971C
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged -= obj;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x0024B57C File Offset: 0x0024977C
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x0000CA4F File Offset: 0x0000AC4F
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

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x0024B594 File Offset: 0x00249794
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x0000CA59 File Offset: 0x0000AC59
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

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x0024B5AC File Offset: 0x002497AC
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x0000CA63 File Offset: 0x0000AC63
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

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x0024B5C4 File Offset: 0x002497C4
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x0000CA6D File Offset: 0x0000AC6D
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

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x0024B5DC File Offset: 0x002497DC
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x0000CA77 File Offset: 0x0000AC77
		internal virtual Label lbl_tel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel3 = value;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x0024B5F4 File Offset: 0x002497F4
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x0000CA81 File Offset: 0x0000AC81
		internal virtual Label lbl_tel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel4 = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x0024B60C File Offset: 0x0024980C
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x0000CA8B File Offset: 0x0000AC8B
		internal virtual Label lbl_tel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel2 = value;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x0024B624 File Offset: 0x00249824
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x0000CA95 File Offset: 0x0000AC95
		internal virtual Label lbl_tel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel1 = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x0024B63C File Offset: 0x0024983C
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x0000CA9F File Offset: 0x0000AC9F
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

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x0024B654 File Offset: 0x00249854
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x0000CAA9 File Offset: 0x0000ACA9
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

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x0024B66C File Offset: 0x0024986C
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x0000CAB3 File Offset: 0x0000ACB3
		internal virtual Label lbl_codemelli
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_codemelli;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_codemelli = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x0024B684 File Offset: 0x00249884
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x0000CABD File Offset: 0x0000ACBD
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

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x0024B69C File Offset: 0x0024989C
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x0000CAC7 File Offset: 0x0000ACC7
		internal virtual Label lbl_addr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_addr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_addr = value;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x0024B6B4 File Offset: 0x002498B4
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x0000CAD1 File Offset: 0x0000ACD1
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

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x0024B6CC File Offset: 0x002498CC
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x0000CADB File Offset: 0x0000ACDB
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

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x0024B6E4 File Offset: 0x002498E4
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x0000CAE5 File Offset: 0x0000ACE5
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

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x0024B6FC File Offset: 0x002498FC
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x0000CAEF File Offset: 0x0000ACEF
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

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x0024B714 File Offset: 0x00249914
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x0000CAF9 File Offset: 0x0000ACF9
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

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x0024B72C File Offset: 0x0024992C
		// (set) Token: 0x06003267 RID: 12903 RVA: 0x0000CB03 File Offset: 0x0000AD03
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

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003268 RID: 12904 RVA: 0x0024B744 File Offset: 0x00249944
		// (set) Token: 0x06003269 RID: 12905 RVA: 0x0000CB0D File Offset: 0x0000AD0D
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

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x0024B75C File Offset: 0x0024995C
		// (set) Token: 0x0600326B RID: 12907 RVA: 0x0000CB17 File Offset: 0x0000AD17
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

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x0600326C RID: 12908 RVA: 0x0024B774 File Offset: 0x00249974
		// (set) Token: 0x0600326D RID: 12909 RVA: 0x0000CB21 File Offset: 0x0000AD21
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

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x0024B78C File Offset: 0x0024998C
		// (set) Token: 0x0600326F RID: 12911 RVA: 0x0000CB2B File Offset: 0x0000AD2B
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

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x0024B7A4 File Offset: 0x002499A4
		// (set) Token: 0x06003271 RID: 12913 RVA: 0x0000CB35 File Offset: 0x0000AD35
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

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x0024B7BC File Offset: 0x002499BC
		// (set) Token: 0x06003273 RID: 12915 RVA: 0x0000CB3F File Offset: 0x0000AD3F
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

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x0024B7D4 File Offset: 0x002499D4
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x0000CB49 File Offset: 0x0000AD49
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

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x0024B7EC File Offset: 0x002499EC
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0024B804 File Offset: 0x00249A04
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

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x0024B864 File Offset: 0x00249A64
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x0024B87C File Offset: 0x00249A7C
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

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x0024B8DC File Offset: 0x00249ADC
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x0024B8F4 File Offset: 0x00249AF4
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x0024B954 File Offset: 0x00249B54
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x0024B96C File Offset: 0x00249B6C
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

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x0024B9CC File Offset: 0x00249BCC
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x0024B9E4 File Offset: 0x00249BE4
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

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0024BA44 File Offset: 0x00249C44
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0000CB53 File Offset: 0x0000AD53
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

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x0024BA5C File Offset: 0x00249C5C
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x0024BA74 File Offset: 0x00249C74
		internal virtual DateBox2 txt_ta_tarikh
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x0024BAD4 File Offset: 0x00249CD4
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x0024BAEC File Offset: 0x00249CEC
		internal virtual DateBox2 txt_az_tarikh
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.KeyDown -= value2;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0024BB4C File Offset: 0x00249D4C
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x0000CB5D File Offset: 0x0000AD5D
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

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0024BB64 File Offset: 0x00249D64
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x0000CB67 File Offset: 0x0000AD67
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

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x0024BB7C File Offset: 0x00249D7C
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x0000CB71 File Offset: 0x0000AD71
		internal virtual Label lbl_code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_code = value;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x0024BB94 File Offset: 0x00249D94
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x0024BBAC File Offset: 0x00249DAC
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

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x0024BC0C File Offset: 0x00249E0C
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x0000CB7B File Offset: 0x0000AD7B
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

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x0024BC24 File Offset: 0x00249E24
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x0000CB85 File Offset: 0x0000AD85
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

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x0024BC3C File Offset: 0x00249E3C
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x0000CB8F File Offset: 0x0000AD8F
		internal virtual Label lbl_shahr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_shahr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_shahr = value;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x0024BC54 File Offset: 0x00249E54
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x0024BC6C File Offset: 0x00249E6C
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

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x0024BCCC File Offset: 0x00249ECC
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x0024BCE4 File Offset: 0x00249EE4
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

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x0024BD44 File Offset: 0x00249F44
		// (set) Token: 0x06003299 RID: 12953 RVA: 0x0000CB99 File Offset: 0x0000AD99
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

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x0024BD5C File Offset: 0x00249F5C
		// (set) Token: 0x0600329B RID: 12955 RVA: 0x0000CBA3 File Offset: 0x0000ADA3
		public int? Moshtari_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_id = value;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x0024BD74 File Offset: 0x00249F74
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x0000CBAD File Offset: 0x0000ADAD
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

		// Token: 0x0600329E RID: 12958 RVA: 0x0024BD8C File Offset: 0x00249F8C
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

		// Token: 0x0600329F RID: 12959 RVA: 0x0024BE30 File Offset: 0x0024A030
		private int GetNextPosx(Frm_SuratHesab_Sharik.bedbes bedbes, int pos, DataTable dt)
		{
			checked
			{
				int arg_16_0 = pos + 1;
				int num = dt.Rows.Count - 1;
				int num2 = arg_16_0;
				int num4;
				long num5;
				while (true)
				{
					int arg_1F6_0 = num2;
					int num3 = num;
					if (arg_1F6_0 > num3)
					{
						goto Block_8;
					}
					bool flag = bedbes == Frm_SuratHesab_Sharik.bedbes.bed;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bed"], 0, false);
						if (flag2)
						{
							num4 = num2;
							num5 = Conversions.ToLong(dt.Rows[num2]["rembed"]);
							DateTime dateTime = Conversions.ToDate(dt.Rows[num2]["tarikh"]);
							flag2 = (num4 + 1 > dt.Rows.Count - 1);
							if (flag2)
							{
								break;
							}
							int arg_C5_0 = num4 + 1;
							int num6 = dt.Rows.Count - 1;
							int num7 = arg_C5_0;
							while (true)
							{
								int arg_183_0 = num7;
								num3 = num6;
								if (arg_183_0 > num3)
								{
									break;
								}
								flag2 = (Operators.ConditionalCompareObjectEqual(dt.Rows[num7]["tarikh"], dateTime, false) && Operators.ConditionalCompareObjectGreater(dt.Rows[num7]["bed"], 0, false));
								if (!flag2)
								{
									goto IL_14E;
								}
								num4 = num7;
								num5 = Conversions.ToLong(Operators.AddObject(num5, dt.Rows[num7]["rembed"]));
								num7++;
							}
						}
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bes"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["stat"], "بد", false);
						if (flag2)
						{
							goto Block_7;
						}
					}
					num2++;
				}
				int result = num4;
				return result;
				IL_14E:
				dt.Rows[num4]["rembed"] = num5;
				result = num4;
				return result;
				Block_7:
				result = num2;
				return result;
				Block_8:
				result = -1;
				return result;
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x0024C040 File Offset: 0x0024A240
		private int GetNextPos(Frm_SuratHesab_Sharik.bedbes bedbes, int pos, DataTable dt)
		{
			checked
			{
				int arg_12_0 = pos + 1;
				int num = dt.Rows.Count - 1;
				int num2 = arg_12_0;
				while (true)
				{
					int arg_101_0 = num2;
					int num3 = num;
					if (arg_101_0 > num3)
					{
						goto Block_6;
					}
					bool flag = bedbes == Frm_SuratHesab_Sharik.bedbes.bed;
					bool flag2;
					if (!flag)
					{
						if (!Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bes"], 0, false))
						{
							goto IL_E5;
						}
						if (!Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["stat"], "بد", false) && !Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["stat"], "ت", false))
						{
							if (!Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["stat"], "بس", false))
							{
								goto IL_E5;
							}
						}
						bool arg_EA_0 = true;
						IL_E9:
						flag2 = arg_EA_0;
						if (flag2)
						{
							goto Block_5;
						}
						goto IL_F5;
						IL_E5:
						arg_EA_0 = false;
						goto IL_E9;
					}
					flag2 = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bed"], 0, false);
					if (flag2)
					{
						break;
					}
					IL_F5:
					num2++;
				}
				int result = num2;
				return result;
				Block_5:
				result = num2;
				return result;
				Block_6:
				result = -1;
				return result;
			}
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x0024C158 File Offset: 0x0024A358
		private void LoadPic(DataRow dr)
		{
			bool flag = dr == null;
			if (flag)
			{
				this.PictureBox1.Image = null;
			}
			else
			{
				flag = (dr["PicData"] != DBNull.Value);
				if (flag)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write((byte[])dr["Picdata"], 0, ((byte[])dr["Picdata"]).Length);
					this.PictureBox1.Image = Image.FromStream(memoryStream);
				}
				else
				{
					this.PictureBox1.Image = null;
				}
			}
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x0024C1EC File Offset: 0x0024A3EC
		private void LoadMoshtariData(string id)
		{
			DataRow dataRow = Public_Function.FillDataRow("SELECT     Grouh_Moshtari.Name AS Shahr1, Grouh_Moshtari2.Name AS Shahr2, Moshtari.*  FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID where Moshtari.id=" + id);
			bool flag = dataRow != null;
			if (flag)
			{
				this.lbl_shahr.Text = string.Empty;
				this.lbl_code.Text = id;
				this.Label7.Text = dataRow["moaref"].ToString();
				this.lbl_tel1.Text = dataRow["tel1"].ToString();
				this.lbl_tel2.Text = dataRow["tel2"].ToString();
				this.lbl_tel3.Text = dataRow["tel3"].ToString();
				this.lbl_tel4.Text = dataRow["tel4"].ToString();
				this.lbl_addr.Text = dataRow["address"].ToString();
				this.lbl_codemelli.Text = dataRow["codemelli"].ToString();
				flag = (dataRow["shahr1"] != DBNull.Value);
				if (flag)
				{
					this.lbl_shahr.Text = Conversions.ToString(dataRow["shahr1"]);
				}
				flag = (dataRow["shahr2"] != DBNull.Value);
				if (flag)
				{
					this.lbl_shahr.Text = Conversions.ToString(dataRow["shahr2"]);
				}
				DataRow byID = this.Moshtari_Pic.GetByID(id);
				this.LoadPic(byID);
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00224154 File Offset: 0x00222354
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
						dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_kol"]));
					}
					flag = (dataRow["ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["ba_zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["ba_zarf"]));
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

		// Token: 0x060032A4 RID: 12964 RVA: 0x0024C380 File Offset: 0x0024A580
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadMoshtariData(Conversions.ToString(this.txt_moshtari.Value));
			int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
			}, null, null, null));
			string command = string.Empty;
			command = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount   FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + "   UNION all " + "  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, " + "  Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount" + "  FROM         Kala INNER JOIN " + "  Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN" + "  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID " + "   WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + "   union all " + "  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih,null AS Kala_Name, Sanad.Bed AS rembed, " + "  Sanad.Bes AS rembes, null as Tedad,null as  Vazn_Kol,NULL AS Fee,NULL as ba_zarf,1 as sanadtype,-1 as printcount " + "   FROM Sanad " + "   WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + "  and Sanad.ID not in(select Sanad_ID from Furush_Hag_Detail where moshtari_id= ", this.txt_moshtari.Value), " AND Sanad_ID is not null) and sanad.id not in(select Sanad_ID from Kharid_Furush where moshtari_ID="), this.txt_moshtari.Value), " AND Sanad_ID is not null) and sanad.id not in(select sanad_id from safi_furush) and sanad.id not in(SELECT Kharid_Detail.sanad_id FROM Kharid INNER JOIN  Kharid_Detail ON Kharid.ID = Kharid_Detail.Kharid_ID where Kharid.moshtari_id="), this.txt_moshtari.Value), ")"), "  union all"), "  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS kala_name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, t.Tedad, t.vazn_kol, NULL AS Fee,t.ba_zarf as ba_zarf,4 as SanadType,Safi_Furush_1.printcount "), " FROM         Safi_Furush AS Safi_Furush_1 INNER JOIN "), " Sanad ON Safi_Furush_1.Sanad_ID = Sanad.ID INNER JOIN "), " (SELECT     Safi_Furush.ID, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Kol) AS vazn_kol,SUM(Furush_Hag_Detail.vazn_ba_zarf) AS ba_zarf "), " FROM         Safi_Furush INNER JOIN "), " Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN "), " Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID "), " WHERE Furush_Hag.Moshtari_ID = "), this.txt_moshtari.Value), "  GROUP BY Safi_Furush.ID) AS t ON Safi_Furush_1.ID = t.ID "), " union all "), " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, Kharid_Detail.Tedad, Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee, Kharid_Detail.Vazn_Ba_Zarf AS ba_zarf, 5 AS sanadtype,  "), " - 1 AS printcount "), " FROM         Sanad INNER JOIN "), " Kharid_Detail ON Sanad.ID = Kharid_Detail.sanad_id INNER JOIN "), " Kala ON Kharid_Detail.Kala_ID = Kala.ID INNER JOIN "), " Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID "), "  where Kharid_Detail.Moshtari_id = "), this.txt_moshtari.Value), "  ORDER BY sanad.Tarikh,sanadtype "));
			DataTable dataTable = Public_Function.FillData(command);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["kala_name"] != DBNull.Value;
					if (flag)
					{
						DataRow dataRow2 = dataRow;
						DataRow arg_2C5_0 = dataRow2;
						string columnName = "Tozih";
						arg_2C5_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" / ", dataRow["kala_Name"]));
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
			this.RemoveZero(dataTable);
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator2.Current;
					long num = Conversions.ToLong(Operators.AddObject(num, dataRow3["bed"]));
					num = Conversions.ToLong(Operators.SubtractObject(num, dataRow3["bes"]));
					dataRow3["mande"] = Math.Abs(num);
					bool flag = num > 0L;
					if (flag)
					{
						dataRow3["stat"] = "بد";
					}
					else
					{
						flag = (num < 0L);
						if (flag)
						{
							dataRow3["stat"] = "بس";
						}
						else
						{
							dataRow3["stat"] = "ت";
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
			int num2 = -1;
			int num3 = -1;
			string text = string.Empty;
			num2 = this.GetNextPosx(Frm_SuratHesab_Sharik.bedbes.bed, num2, dataTable);
			num3 = this.GetNextPos(Frm_SuratHesab_Sharik.bedbes.bes, num3, dataTable);
			bool flag2;
			while (num2 != -1 && num3 != -1)
			{
				bool flag = Operators.ConditionalCompareObjectLess(dataTable.Rows[num3]["rembes"], dataTable.Rows[num2]["rembed"], false);
				if (flag)
				{
					flag2 = (Operators.CompareString(text, string.Empty, false) != 0);
					DataRow dataRow2;
					string columnName;
					if (flag2)
					{
						dataRow2 = dataTable.Rows[num3];
						DataRow arg_4FD_0 = dataRow2;
						columnName = "Tozih";
						arg_4FD_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " ( تسویه تا " + text + " ) ");
						text = string.Empty;
					}
					dataRow2 = dataTable.Rows[num2];
					DataRow arg_549_0 = dataRow2;
					columnName = "rembed";
					arg_549_0[columnName] = Operators.SubtractObject(dataRow2[columnName], dataTable.Rows[num3]["rembes"]);
					flag2 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num3]["stat"], "ت", false);
					if (flag2)
					{
						dataRow2 = dataTable.Rows[num3];
						DataRow arg_5FB_0 = dataRow2;
						columnName = "Tozih";
						arg_5FB_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( وجه به ", dataTable.Rows[num2]["Tarikh_Fa"]), " - مانده "), Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[num2]["rembed"]))), " ) "));
					}
					num3 = this.GetNextPos(Frm_SuratHesab_Sharik.bedbes.bes, num3, dataTable);
				}
				else
				{
					long num4 = Conversions.ToLong(Operators.SubtractObject(dataTable.Rows[num3]["rembes"], dataTable.Rows[num2]["rembed"]));
					dataTable.Rows[num2]["rembed"] = 0;
					text = Conversions.ToString(dataTable.Rows[num2]["Tarikh_Fa"]);
					num2 = this.GetNextPosx(Frm_SuratHesab_Sharik.bedbes.bed, num2, dataTable);
					dataTable.Rows[num3]["rembes"] = num4;
				}
			}
			int num5 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
			}, null, null, null));
			flag2 = (num5 > 0);
			if (flag2)
			{
				long value2 = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
				}, null, null, null));
				this.LabelCommand10.Text = "جمع " + Conversions.ToString(num5) + " فقره چک برگشتی " + Public_Function.FormatPrice(Conversions.ToString(value2));
			}
			else
			{
				this.LabelCommand10.Text = string.Empty;
			}
			this.GridEX1.DataSource = dataTable;
			flag2 = (dataTable.Rows.Count > 0);
			if (flag2)
			{
				object arg_816_0 = this.txt_az_tarikh;
				Type arg_816_1 = null;
				string arg_816_2 = "SetDate";
				object[] array = new object[1];
				object[] arg_7FC_0 = array;
				int arg_7FC_1 = 0;
				DataRow dataRow2 = dataTable.Rows[0];
				DataRow arg_7F2_0 = dataRow2;
				string columnName = "tarikh_Fa";
				arg_7FC_0[arg_7FC_1] = RuntimeHelpers.GetObjectValue(arg_7F2_0[columnName]);
				object[] array2 = array;
				object[] arg_816_3 = array2;
				string[] arg_816_4 = null;
				Type[] arg_816_5 = null;
				bool[] array3 = new bool[]
				{
					true
				};
				NewLateBinding.LateCall(arg_816_0, arg_816_1, arg_816_2, arg_816_3, arg_816_4, arg_816_5, array3, true);
				if (array3[0])
				{
					dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				this.last_mande = Conversions.ToLong(dataTable.Rows[checked(dataTable.Rows.Count - 1)]["mande"]);
			}
			else
			{
				this.last_mande = 0L;
			}
			try
			{
				IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator3.Current;
					flag2 = (dataRow4["Kala_Name"] == DBNull.Value);
					if (flag2)
					{
						dataRow4["kala_Name"] = string.Empty;
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
			this.Add();
			this.GridEX1.MoveLast();
			this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.txt_moshtari.Value);
			this.Refresh_Status();
			this.txt_az_tarikh.Focus();
			this.txt_az_tarikh.SelectionLength = 0;
			this.txt_az_tarikh.SelectionStart = 5;
			this.txt_az_tarikh.SelectionLength = 2;
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x0024CD0C File Offset: 0x0024AF0C
		public void Add()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
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
							IEnumerator enumerator2 = this.GridEX1.RootTable.Columns.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GridEXColumn gridEXColumn = (GridEXColumn)enumerator2.Current;
								text += dataRow[gridEXColumn.DataMember].ToString();
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

		// Token: 0x060032A6 RID: 12966 RVA: 0x0024CE78 File Offset: 0x0024B078
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.Moshtari_Info.ShowSharik = true;
			bool hasValue = this.Moshtari_id.HasValue;
			if (hasValue)
			{
				string arg_73_0 = "select count(moshtari_id) from sharik where moshtari_id=";
				int? moshtari_id = this.Moshtari_id;
				bool flag = Operators.ConditionalCompareObjectEqual(Public_Function.ExecuteScalar(arg_73_0 + (moshtari_id.HasValue ? Conversions.ToString(moshtari_id.GetValueOrDefault()) : null)), 1, false);
				if (flag)
				{
					return;
				}
				this.Moshtari_Info.Moshtari_ID = (T)this.Moshtari_id;
				this.txt_moshtari.SetValue(this.Moshtari_Name, this.Moshtari_id);
				this.SelectItem1_SelectedValueChanged(null, null);
				this.Refresh_Status();
			}
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x0024CF74 File Offset: 0x0024B174
		private void Frm_SuratHesab_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F6);
				if (flag)
				{
					this.ButtonItem4_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F7);
					if (flag)
					{
						this.ButtonItem7_Click(null, null);
					}
				}
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.txt_moshtari.PerformButtonClick();
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0024CFFC File Offset: 0x0024B1FC
		private void showkharid(DataRowView row)
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Kharid.Num  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID where sanad_id=", row["id"])
			}, null, null, null));
			Frm_Kharid_Furush frm_Kharid_Furush = new Frm_Kharid_Furush();
			frm_Kharid_Furush.Num = num;
			frm_Kharid_Furush.Show_Preview = true;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Kharid_Furush);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0024D070 File Offset: 0x0024B270
		private void ShowFurush(DataRowView row)
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Furush_Hag.Num  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID where sanad_id=", row["id"])
			}, null, null, null));
			frm_Frush_hag frm_Frush_hag = new frm_Frush_hag();
			frm_Frush_hag.Num = num;
			frm_Frush_hag.Show_Preview = true;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Frush_hag);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x0024D0E4 File Offset: 0x0024B2E4
		private void ShowSafi(DataRowView row)
		{
			DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from safi_furush where sanad_id=", row["ID"])));
			Frm_Safi frm_Safi = new Frm_Safi();
			frm_Safi.Furush_ID = Conversions.ToLong(dataRow["furush_hag_id"]);
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Safi);
			dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from safi_furush where sanad_id=", row["ID"])));
			bool flag = dataRow["printcount"] != DBNull.Value;
			if (flag)
			{
				this.GridEX1.CurrentRow.Cells["printcount"].Value = 1;
				this.GridEX1.Refresh();
			}
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x002263B8 File Offset: 0x002245B8
		private void ShowDaryaftPardakht(DataRowView row)
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Tarikh  FROM DaryaftPardakht  where sanadbed_id=", row["id"])
			}, null, null, null));
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT     Tarikh  FROM DaryaftPardakht  where sanadbes_id=", row["id"])
				}, null, null, null));
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				Frm_DaryaftPardakht frm_DaryaftPardakht = new Frm_DaryaftPardakht();
				frm_DaryaftPardakht.PreviewTarikh = Public_Function.MiladiToShamsi(Conversions.ToDate(text));
				frm_DaryaftPardakht.ShowPreview = true;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_DaryaftPardakht);
			}
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x0024D1B4 File Offset: 0x0024B3B4
		private void ShowrizKharid(DataRowView row)
		{
			long num = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("select id from kharid where moshtari_sanad_id=", row["id"])
			}, null, null, null));
			Frm_RizKharid frm_RizKharid = new Frm_RizKharid
			{
				Kharid_ID = num,
				Preview = true
			};
			Kharid_Detail kharid_Detail = new Kharid_Detail();
			DataTable byID = kharid_Detail.GetByID(checked((int)num));
			frm_RizKharid.dt_Kharid = byID;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_RizKharid);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0024D24C File Offset: 0x0024B44C
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
				object left = dataRowView["sanadtype"];
				flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
				if (flag)
				{
					this.ShowDaryaftPardakht(dataRowView);
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
					if (flag)
					{
						this.showkharid(dataRowView);
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
						if (flag)
						{
							this.ShowFurush(dataRowView);
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
							if (flag)
							{
								this.ShowSafi(dataRowView);
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, 5, false);
								if (flag)
								{
									this.ShowrizKharid(dataRowView);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0024D324 File Offset: 0x0024B524
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Moshtari_Hesab showFrm = new Frm_Moshtari_Hesab
			{
				Moshtari_ID = Conversions.ToString(this.txt_moshtari.Value)
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x0024D364 File Offset: 0x0024B564
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkDaryafti frm_rpt_checkDaryafti = new Frm_rpt_checkDaryafti();
			Frm_rpt_checkDaryafti arg_25_0 = frm_rpt_checkDaryafti;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checkDaryafti.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checkDaryafti showFrm = frm_rpt_checkDaryafti;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0024D3C4 File Offset: 0x0024B5C4
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkPardakhtani frm_rpt_checkPardakhtani = new Frm_rpt_checkPardakhtani();
			Frm_rpt_checkPardakhtani arg_25_0 = frm_rpt_checkPardakhtani;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checkPardakhtani.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checkPardakhtani showFrm = frm_rpt_checkPardakhtani;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x060032B2 RID: 12978 RVA: 0x0024D424 File Offset: 0x0024B624
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				StiReport stiReport = new StiReport();
				stiReport.Load(Application.StartupPath + "\\reports\\surathesab.mrt");
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataTable dataTable2 = dataTable.Copy();
				DataTable dataTable3 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from moshtari_pic  where moshtari_id=", this.txt_moshtari.Value)));
				dataTable3.TableName = "pic";
				dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
				stiReport.RegData(dataTable2.DefaultView);
				stiReport.RegData(dataTable3);
				this.SetHeader(stiReport);
				StiText stiText = (StiText)stiReport.GetComponentByName("Text13");
				stiText.Text = this.txt_moshtari.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text31");
				stiText.Text = this.lbl_tel1.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text33");
				stiText.Text = this.lbl_tel2.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text37");
				stiText.Text = this.Label7.Text.ToString();
				stiText = (StiText)stiReport.GetComponentByName("Text16");
				stiText.Text = this.lbl_addr.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text49");
				stiText.Text = this.lbl_code.Text;
				stiText = (StiText)stiReport.GetComponentByName("txt_codemelli");
				stiText.Text = this.lbl_codemelli.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text47");
				stiText.Text = this.lbl_shahr.Text;
				stiText = (StiText)stiReport.GetComponentByName("Text35");
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
				stiText = (StiText)stiReport.GetComponentByName("Text40");
				stiText.Text = this.Moshtari_Info.LastTozih;
				stiText = (StiText)stiReport.GetComponentByName("Text41");
				stiText.Text = this.Moshtari_Info.Check_Status;
				stiText = (StiText)stiReport.GetComponentByName("Text2");
				stiText.Text = "از تاریخ " + this.txt_az_tarikh.Text + "تا تاریخ " + this.txt_ta_tarikh.Text;
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
				}, null, null, null));
				flag = (num > 0);
				if (flag)
				{
					long value = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					stiText = (StiText)stiReport.GetComponentByName("Text42");
					stiText.Text = "جمع " + Conversions.ToString(num) + " فقره چک برگشتی " + Public_Function.FormatPrice(Conversions.ToString(value));
				}
				Public_Function.SetReport_MarginTop(stiReport);
				Public_Function.AddTazminText(stiReport, true, false);
				stiReport.Print(false);
			}
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0000CBB7 File Offset: 0x0000ADB7
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0024D7F8 File Offset: 0x0024B9F8
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
				DataRow dataRow = Public_Function.FillDataRow("  SELECT     null as ID, null as CodeHesab_ID,isnull(sum( Sanad.Bed),0) as Bed,isnull(sum( Sanad.Bes),0) as Bes,max(tarikh) as Tarikh, null as Tarikh_Fa, '' as Tozih,null AS Kala_Name,null AS rembed,   null AS rembes, null as Tedad,null as  Vazn_Kol,NULL AS Fee,NULL as ba_zarf,-1 as sanadtype,-1 as printcount    FROM Sanad    WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + " and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
				dataRow["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text);
				dataRow["Tozih"] = "مانده از قبل";
				DataRow dataRow2 = dataTable.NewRow();
				flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], dataRow["bes"], false);
				if (flag)
				{
					dataRow2["mande"] = Operators.SubtractObject(dataRow["bed"], dataRow["bes"]);
					dataRow2["stat"] = "بد";
				}
				else
				{
					dataRow2["mande"] = Operators.SubtractObject(dataRow["bes"], dataRow["bed"]);
					dataRow2["stat"] = "بس";
				}
				flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["mande"], 0, false);
				if (flag)
				{
					bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
					if (flag2)
					{
						dataTable.Rows[0].Delete();
					}
					dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
					dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
					dataRow2["tozih"] = "مانده از قبل";
					dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
					dataRow2["printcount"] = -1;
					dataTable.Rows.InsertAt(dataRow2, 0);
				}
				dataTable.DefaultView.RowFilter = string.Concat(new string[]
				{
					"tarikh >= '",
					Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
					"' AND tarikh<='",
					Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
					"'"
				});
			}
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0024DAB0 File Offset: 0x0024BCB0
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x0000CBD2 File Offset: 0x0000ADD2
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.PerformButtonClick();
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x0024DAD8 File Offset: 0x0024BCD8
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			if (!flag)
			{
				Frm_Rpt_Furush frm_Rpt_Furush = new Frm_Rpt_Furush();
				frm_Rpt_Furush.txt_moshtari.SetValue(this.txt_moshtari.Text, RuntimeHelpers.GetObjectValue(this.txt_moshtari.Value));
				frm_Rpt_Furush.loaddata();
				frm_Rpt_Furush.ShowDialog();
			}
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0024DB38 File Offset: 0x0024BD38
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(Conversions.ToString(this.last_mande));
			}
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x0024DB88 File Offset: 0x0024BD88
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
				Frm_Moshtari arg_3D_0 = frm_Moshtari;
				object expr_2B = this.txt_moshtari.Value;
				int? num;
				arg_3D_0.ID = ((expr_2B != null) ? ((int?)expr_2B) : num);
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Moshtari);
				this.txt_moshtari.Text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select name+' '+family from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
			}
		}

		// Token: 0x04001376 RID: 4982
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001378 RID: 4984
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001379 RID: 4985
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400137A RID: 4986
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400137B RID: 4987
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400137C RID: 4988
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x0400137D RID: 4989
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400137E RID: 4990
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400137F RID: 4991
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04001380 RID: 4992
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001381 RID: 4993
		[AccessedThroughProperty("lbl_tel3")]
		private Label _lbl_tel3;

		// Token: 0x04001382 RID: 4994
		[AccessedThroughProperty("lbl_tel4")]
		private Label _lbl_tel4;

		// Token: 0x04001383 RID: 4995
		[AccessedThroughProperty("lbl_tel2")]
		private Label _lbl_tel2;

		// Token: 0x04001384 RID: 4996
		[AccessedThroughProperty("lbl_tel1")]
		private Label _lbl_tel1;

		// Token: 0x04001385 RID: 4997
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001386 RID: 4998
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04001387 RID: 4999
		[AccessedThroughProperty("lbl_codemelli")]
		private Label _lbl_codemelli;

		// Token: 0x04001388 RID: 5000
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04001389 RID: 5001
		[AccessedThroughProperty("lbl_addr")]
		private Label _lbl_addr;

		// Token: 0x0400138A RID: 5002
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400138B RID: 5003
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400138C RID: 5004
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400138D RID: 5005
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x0400138E RID: 5006
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x0400138F RID: 5007
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04001390 RID: 5008
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04001391 RID: 5009
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04001392 RID: 5010
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04001393 RID: 5011
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x04001394 RID: 5012
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04001395 RID: 5013
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04001396 RID: 5014
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001397 RID: 5015
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04001398 RID: 5016
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04001399 RID: 5017
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x0400139A RID: 5018
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400139B RID: 5019
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400139C RID: 5020
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x0400139D RID: 5021
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x0400139E RID: 5022
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x0400139F RID: 5023
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040013A0 RID: 5024
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040013A1 RID: 5025
		[AccessedThroughProperty("lbl_code")]
		private Label _lbl_code;

		// Token: 0x040013A2 RID: 5026
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040013A3 RID: 5027
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x040013A4 RID: 5028
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x040013A5 RID: 5029
		[AccessedThroughProperty("lbl_shahr")]
		private Label _lbl_shahr;

		// Token: 0x040013A6 RID: 5030
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040013A7 RID: 5031
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040013A8 RID: 5032
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040013A9 RID: 5033
		private Moshtari_Info Moshtari_Info;

		// Token: 0x040013AA RID: 5034
		[CompilerGenerated]
		private int? _Moshtari_id;

		// Token: 0x040013AB RID: 5035
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x040013AC RID: 5036
		private Moshtari_Pic Moshtari_Pic;

		// Token: 0x040013AD RID: 5037
		private long last_mande;

		// Token: 0x02000150 RID: 336
		public enum bedbes
		{
			// Token: 0x040013AF RID: 5039
			bed,
			// Token: 0x040013B0 RID: 5040
			bes
		}
	}
}
