using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.Ribbon;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report.Viewer;

namespace FruitBox
{
	// Token: 0x02000084 RID: 132
	[DesignerGenerated]
	public partial class Frm_Stimul_Report : Form
	{
		// Token: 0x06000B9C RID: 2972 RVA: 0x000045F3 File Offset: 0x000027F3
		[DebuggerNonUserCode]
		public Frm_Stimul_Report()
		{
			Frm_Stimul_Report.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0009129C File Offset: 0x0008F49C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Stimul_Report.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Stimul_Report.__ENCList.Count == Frm_Stimul_Report.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Stimul_Report.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Stimul_Report.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Stimul_Report.__ENCList[num] = Frm_Stimul_Report.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Stimul_Report.__ENCList.RemoveRange(num, Frm_Stimul_Report.__ENCList.Count - num);
						Frm_Stimul_Report.__ENCList.Capacity = Frm_Stimul_Report.__ENCList.Count;
					}
					Frm_Stimul_Report.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x000915A8 File Offset: 0x0008F7A8
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0000460B File Offset: 0x0000280B
		public virtual StiViewerControl StiViewerControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StiViewerControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StiViewerControl1 = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000915C0 File Offset: 0x0008F7C0
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00004615 File Offset: 0x00002815
		internal virtual OfficeFormAdorner OfficeFormAdorner1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OfficeFormAdorner1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OfficeFormAdorner1 = value;
			}
		}

		// Token: 0x04000495 RID: 1173
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000497 RID: 1175
		[AccessedThroughProperty("StiViewerControl1")]
		private StiViewerControl _StiViewerControl1;

		// Token: 0x04000498 RID: 1176
		[AccessedThroughProperty("OfficeFormAdorner1")]
		private OfficeFormAdorner _OfficeFormAdorner1;
	}
}
