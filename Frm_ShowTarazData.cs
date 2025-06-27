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
	// Token: 0x0200007E RID: 126
	[DesignerGenerated]
	public partial class Frm_ShowTarazData : Form
	{
		// Token: 0x06000AF0 RID: 2800 RVA: 0x0000429D File Offset: 0x0000249D
		[DebuggerNonUserCode]
		public Frm_ShowTarazData()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_ShowTarazData_KeyDown);
			base.Load += new EventHandler(this.Frm_ShowTarazData_Load);
			Frm_ShowTarazData.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0008B2F4 File Offset: 0x000894F4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_ShowTarazData.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_ShowTarazData.__ENCList.Count == Frm_ShowTarazData.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_ShowTarazData.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_ShowTarazData.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_ShowTarazData.__ENCList[num] = Frm_ShowTarazData.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_ShowTarazData.__ENCList.RemoveRange(num, Frm_ShowTarazData.__ENCList.Count - num);
						Frm_ShowTarazData.__ENCList.Capacity = Frm_ShowTarazData.__ENCList.Count;
					}
					Frm_ShowTarazData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0008B698 File Offset: 0x00089898
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000042DD File Offset: 0x000024DD
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0008B6B0 File Offset: 0x000898B0
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x000042E7 File Offset: 0x000024E7
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

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_ShowTarazData_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000042F1 File Offset: 0x000024F1
		private void Frm_ShowTarazData_Load(object sender, EventArgs e)
		{
			this.GridEX1.DataSource = this.dt;
		}

		// Token: 0x04000452 RID: 1106
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000454 RID: 1108
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000455 RID: 1109
		[CompilerGenerated]
		private DataTable _dt;
	}
}
