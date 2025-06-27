using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000123 RID: 291
	[DesignerGenerated]
	public partial class Frm_Rotbe_Detailvb : Form
	{
		// Token: 0x06002A43 RID: 10819 RVA: 0x0000A844 File Offset: 0x00008A44
		[DebuggerNonUserCode]
		public Frm_Rotbe_Detailvb()
		{
			base.Load += new EventHandler(this.Frm_Rotbe_Detailvb_Load);
			Frm_Rotbe_Detailvb.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x001FC7AC File Offset: 0x001FA9AC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rotbe_Detailvb.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rotbe_Detailvb.__ENCList.Count == Frm_Rotbe_Detailvb.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rotbe_Detailvb.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rotbe_Detailvb.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rotbe_Detailvb.__ENCList[num] = Frm_Rotbe_Detailvb.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rotbe_Detailvb.__ENCList.RemoveRange(num, Frm_Rotbe_Detailvb.__ENCList.Count - num);
						Frm_Rotbe_Detailvb.__ENCList.Capacity = Frm_Rotbe_Detailvb.__ENCList.Count;
					}
					Frm_Rotbe_Detailvb.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x001FCB48 File Offset: 0x001FAD48
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x0000A870 File Offset: 0x00008A70
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x001FCB60 File Offset: 0x001FAD60
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x0000A87A File Offset: 0x00008A7A
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

		// Token: 0x06002A4B RID: 10827 RVA: 0x0000A884 File Offset: 0x00008A84
		private void Frm_Rotbe_Detailvb_Load(object sender, EventArgs e)
		{
			this.GridEX1.DataSource = this.dt;
			this.GridEX1.RetrieveStructure();
		}

		// Token: 0x0400107C RID: 4220
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400107E RID: 4222
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400107F RID: 4223
		[CompilerGenerated]
		private DataTable _dt;
	}
}
