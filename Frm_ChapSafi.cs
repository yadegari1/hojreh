using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
	// Token: 0x0200011A RID: 282
	[DesignerGenerated]
	public partial class Frm_ChapSafi : Form
	{
		// Token: 0x06002982 RID: 10626 RVA: 0x0000A3AF File Offset: 0x000085AF
		[DebuggerNonUserCode]
		public Frm_ChapSafi()
		{
			base.Load += new EventHandler(this.Frm_ChapSafi_Load);
			Frm_ChapSafi.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x001F6100 File Offset: 0x001F4300
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_ChapSafi.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_ChapSafi.__ENCList.Count == Frm_ChapSafi.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_ChapSafi.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_ChapSafi.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_ChapSafi.__ENCList[num] = Frm_ChapSafi.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_ChapSafi.__ENCList.RemoveRange(num, Frm_ChapSafi.__ENCList.Count - num);
						Frm_ChapSafi.__ENCList.Capacity = Frm_ChapSafi.__ENCList.Count;
					}
					Frm_ChapSafi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x001F6A50 File Offset: 0x001F4C50
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x0000A3DB File Offset: 0x000085DB
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x001F6A68 File Offset: 0x001F4C68
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x0000A3E5 File Offset: 0x000085E5
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

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x001F6A80 File Offset: 0x001F4C80
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x001F6A98 File Offset: 0x001F4C98
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

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x001F6AF8 File Offset: 0x001F4CF8
		// (set) Token: 0x0600298D RID: 10637 RVA: 0x0000A3EF File Offset: 0x000085EF
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

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x001F6B10 File Offset: 0x001F4D10
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x0000A3F9 File Offset: 0x000085F9
		internal virtual DataEntryGrid Gridex1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Gridex1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Gridex1 = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x001F6B28 File Offset: 0x001F4D28
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x001F6B40 File Offset: 0x001F4D40
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
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

		// Token: 0x06002992 RID: 10642 RVA: 0x001F6BA0 File Offset: 0x001F4DA0
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			DataTable dataSource = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     Furush_Hag.ID, Furush_Hag.Num, Furush_Hag.Moshtari_ID, Furush_Hag.Sh_Mashin, Furush_Hag.Sh_Barname, Furush_Hag.Tarikh_Vurud, Furush_Hag.[Desc],  Furush_Hag.Baskul, Furush_Hag.Baskul_Mabda, Furush_Hag.Tedad_Kol  FROM         Furush_Hag INNER JOIN  Safi_Furush ON Furush_Hag.ID = Safi_Furush.Furush_Hag_ID where moshtari_id=", this.txt_moshtari.Value), " and printcount is null ")));
			this.Gridex1.DataSource = dataSource;
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x0000A403 File Offset: 0x00008603
		private void Frm_ChapSafi_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04001034 RID: 4148
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001036 RID: 4150
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001037 RID: 4151
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001038 RID: 4152
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001039 RID: 4153
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400103A RID: 4154
		[AccessedThroughProperty("Gridex1")]
		private DataEntryGrid _Gridex1;

		// Token: 0x0400103B RID: 4155
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;
	}
}
