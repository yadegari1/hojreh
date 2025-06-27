using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000060 RID: 96
	[DesignerGenerated]
	public partial class Frm_Base : Form
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x00002F66 File Offset: 0x00001166
		[DebuggerNonUserCode]
		public Frm_Base()
		{
			Frm_Base.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00066F54 File Offset: 0x00065154
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Base.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Base.__ENCList.Count == Frm_Base.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Base.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Base.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Base.__ENCList[num] = Frm_Base.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Base.__ENCList.RemoveRange(num, Frm_Base.__ENCList.Count - num);
						Frm_Base.__ENCList.Capacity = Frm_Base.__ENCList.Count;
					}
					Frm_Base.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x04000282 RID: 642
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
