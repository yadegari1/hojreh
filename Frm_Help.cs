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
	// Token: 0x0200006C RID: 108
	[DesignerGenerated]
	public partial class Frm_Help : Form
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x00003783 File Offset: 0x00001983
		[DebuggerNonUserCode]
		public Frm_Help()
		{
			base.Load += new EventHandler(this.Frm_Help_Load);
			Frm_Help.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00075FEC File Offset: 0x000741EC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Help.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Help.__ENCList.Count == Frm_Help.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Help.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Help.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Help.__ENCList[num] = Frm_Help.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Help.__ENCList.RemoveRange(num, Frm_Help.__ENCList.Count - num);
						Frm_Help.__ENCList.Capacity = Frm_Help.__ENCList.Count;
					}
					Frm_Help.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00076250 File Offset: 0x00074450
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x000037AF File Offset: 0x000019AF
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_Help_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400033F RID: 831
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000341 RID: 833
		[AccessedThroughProperty("Button1")]
		private Button _Button1;
	}
}
