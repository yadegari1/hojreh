using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B7 RID: 183
	public class CtrlStyledSplitContainer : SplitContainer
	{
		// Token: 0x06000EC4 RID: 3780 RVA: 0x000A9D68 File Offset: 0x000A7F68
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStyledSplitContainer.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStyledSplitContainer.__ENCList.Count == CtrlStyledSplitContainer.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStyledSplitContainer.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStyledSplitContainer.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStyledSplitContainer.__ENCList[num] = CtrlStyledSplitContainer.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStyledSplitContainer.__ENCList.RemoveRange(num, CtrlStyledSplitContainer.__ENCList.Count - num);
						CtrlStyledSplitContainer.__ENCList.Capacity = CtrlStyledSplitContainer.__ENCList.Count;
					}
					CtrlStyledSplitContainer.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00005388 File Offset: 0x00003588
		public CtrlStyledSplitContainer()
		{
			CtrlStyledSplitContainer.__ENCAddToList(this);
			this.TabStop = false;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x000A9E6C File Offset: 0x000A806C
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x000053A2 File Offset: 0x000035A2
		[DefaultValue(false)]
		public new bool TabStop
		{
			get
			{
				return base.TabStop;
			}
			set
			{
				base.TabStop = value;
			}
		}

		// Token: 0x040005C3 RID: 1475
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
