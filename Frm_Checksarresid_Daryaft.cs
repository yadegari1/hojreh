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
	// Token: 0x0200011C RID: 284
	[DesignerGenerated]
	public partial class Frm_Checksarresid_Daryaft : Form
	{
		// Token: 0x060029B3 RID: 10675 RVA: 0x0000A4D4 File Offset: 0x000086D4
		[DebuggerNonUserCode]
		public Frm_Checksarresid_Daryaft()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Checksarresid_Daryaft_KeyDown);
			base.Load += new EventHandler(this.Frm_Checksarresid_Daryaft_Load);
			Frm_Checksarresid_Daryaft.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x001F781C File Offset: 0x001F5A1C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Checksarresid_Daryaft.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Checksarresid_Daryaft.__ENCList.Count == Frm_Checksarresid_Daryaft.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Checksarresid_Daryaft.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Checksarresid_Daryaft.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Checksarresid_Daryaft.__ENCList[num] = Frm_Checksarresid_Daryaft.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Checksarresid_Daryaft.__ENCList.RemoveRange(num, Frm_Checksarresid_Daryaft.__ENCList.Count - num);
						Frm_Checksarresid_Daryaft.__ENCList.Capacity = Frm_Checksarresid_Daryaft.__ENCList.Count;
					}
					Frm_Checksarresid_Daryaft.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x001F7BAC File Offset: 0x001F5DAC
		// (set) Token: 0x060029B8 RID: 10680 RVA: 0x0000A514 File Offset: 0x00008714
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
				this._GridEX2 = value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x001F7BC4 File Offset: 0x001F5DC4
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x0000A51E File Offset: 0x0000871E
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

		// Token: 0x060029BB RID: 10683 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Checksarresid_Daryaft_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0000A528 File Offset: 0x00008728
		private void Frm_Checksarresid_Daryaft_Load(object sender, EventArgs e)
		{
			this.GridEX2.DataSource = this.dt;
		}

		// Token: 0x04001048 RID: 4168
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400104A RID: 4170
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x0400104B RID: 4171
		[CompilerGenerated]
		private DataTable _dt;
	}
}
