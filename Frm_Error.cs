using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000069 RID: 105
	[DesignerGenerated]
	public partial class Frm_Error : Form
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x00003404 File Offset: 0x00001604
		[DebuggerNonUserCode]
		public Frm_Error()
		{
			Frm_Error.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000709A0 File Offset: 0x0006EBA0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Error.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Error.__ENCList.Count == Frm_Error.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Error.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Error.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Error.__ENCList[num] = Frm_Error.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Error.__ENCList.RemoveRange(num, Frm_Error.__ENCList.Count - num);
						Frm_Error.__ENCList.Capacity = Frm_Error.__ENCList.Count;
					}
					Frm_Error.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00070D28 File Offset: 0x0006EF28
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x0000341C File Offset: 0x0000161C
		internal virtual GridEX Gridex1
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

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00070D40 File Offset: 0x0006EF40
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00003426 File Offset: 0x00001626
		internal virtual GridSize GridSize1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridSize1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridSize1 = value;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00070D58 File Offset: 0x0006EF58
		public DialogResult ShowDialog(ErrorListManager errorList)
		{
			try
			{
				List<string>.Enumerator enumerator = errorList.List.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					this.Gridex1.AddItem(new object[]
					{
						current
					});
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return base.ShowDialog();
		}

		// Token: 0x040002F4 RID: 756
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002F6 RID: 758
		[AccessedThroughProperty("Gridex1")]
		private GridEX _Gridex1;

		// Token: 0x040002F7 RID: 759
		[AccessedThroughProperty("GridSize1")]
		private GridSize _GridSize1;
	}
}
