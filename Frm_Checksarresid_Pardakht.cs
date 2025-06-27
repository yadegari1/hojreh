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
	// Token: 0x0200011D RID: 285
	[DesignerGenerated]
	public partial class Frm_Checksarresid_Pardakht : Form
	{
		// Token: 0x060029BE RID: 10686 RVA: 0x0000A54B File Offset: 0x0000874B
		[DebuggerNonUserCode]
		public Frm_Checksarresid_Pardakht()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Checksarresid_Pardakht_KeyDown);
			base.Load += new EventHandler(this.Frm_Checksarresid_Pardakht_Load);
			Frm_Checksarresid_Pardakht.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x001F7BDC File Offset: 0x001F5DDC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Checksarresid_Pardakht.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Checksarresid_Pardakht.__ENCList.Count == Frm_Checksarresid_Pardakht.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Checksarresid_Pardakht.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Checksarresid_Pardakht.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Checksarresid_Pardakht.__ENCList[num] = Frm_Checksarresid_Pardakht.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Checksarresid_Pardakht.__ENCList.RemoveRange(num, Frm_Checksarresid_Pardakht.__ENCList.Count - num);
						Frm_Checksarresid_Pardakht.__ENCList.Capacity = Frm_Checksarresid_Pardakht.__ENCList.Count;
					}
					Frm_Checksarresid_Pardakht.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x001F7F6C File Offset: 0x001F616C
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x0000A58B File Offset: 0x0000878B
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
				this._GridEX3 = value;
			}
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Checksarresid_Pardakht_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0000A595 File Offset: 0x00008795
		private void Frm_Checksarresid_Pardakht_Load(object sender, EventArgs e)
		{
			this.GridEX3.DataSource = this.st;
		}

		// Token: 0x0400104C RID: 4172
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400104E RID: 4174
		[AccessedThroughProperty("GridEX3")]
		private GridEX _GridEX3;

		// Token: 0x0400104F RID: 4175
		public DataTable st;
	}
}
