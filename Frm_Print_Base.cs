using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000073 RID: 115
	[DesignerGenerated]
	public partial class Frm_Print_Base : Form
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x00003A7D File Offset: 0x00001C7D
		[DebuggerNonUserCode]
		public Frm_Print_Base()
		{
			Frm_Print_Base.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0007B19C File Offset: 0x0007939C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Print_Base.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Print_Base.__ENCList.Count == Frm_Print_Base.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Print_Base.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Print_Base.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Print_Base.__ENCList[num] = Frm_Print_Base.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Print_Base.__ENCList.RemoveRange(num, Frm_Print_Base.__ENCList.Count - num);
						Frm_Print_Base.__ENCList.Capacity = Frm_Print_Base.__ENCList.Count;
					}
					Frm_Print_Base.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0007BF7C File Offset: 0x0007A17C
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00003A95 File Offset: 0x00001C95
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0007BF94 File Offset: 0x0007A194
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00003A9F File Offset: 0x00001C9F
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

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0007BFAC File Offset: 0x0007A1AC
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00003AA9 File Offset: 0x00001CA9
		internal virtual UIRadioButton UiRadioButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton3 = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00003AB3 File Offset: 0x00001CB3
		internal virtual UIRadioButton UiRadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton2 = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0007BFDC File Offset: 0x0007A1DC
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00003ABD File Offset: 0x00001CBD
		internal virtual UIRadioButton UiRadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton1 = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0007BFF4 File Offset: 0x0007A1F4
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00003AC7 File Offset: 0x00001CC7
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0007C00C File Offset: 0x0007A20C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00003AD1 File Offset: 0x00001CD1
		internal virtual UIRadioButton UiRadioButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton5 = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0007C024 File Offset: 0x0007A224
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00003ADB File Offset: 0x00001CDB
		internal virtual UIRadioButton UiRadioButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton4 = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0007C03C File Offset: 0x0007A23C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00003AE5 File Offset: 0x00001CE5
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0007C054 File Offset: 0x0007A254
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00003AEF File Offset: 0x00001CEF
		internal virtual UIComboBox UiComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiComboBox1 = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0007C06C File Offset: 0x0007A26C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00003AF9 File Offset: 0x00001CF9
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0007C084 File Offset: 0x0007A284
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00003B03 File Offset: 0x00001D03
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiButton3 = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0007C09C File Offset: 0x0007A29C
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00003B0D File Offset: 0x00001D0D
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiButton2 = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0007C0B4 File Offset: 0x0007A2B4
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00003B17 File Offset: 0x00001D17
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiButton1 = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0007C0CC File Offset: 0x0007A2CC
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00003B21 File Offset: 0x00001D21
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0007C0E4 File Offset: 0x0007A2E4
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00003B2B File Offset: 0x00001D2B
		internal virtual UICheckBox UiCheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox2 = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0007C0FC File Offset: 0x0007A2FC
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00003B35 File Offset: 0x00001D35
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiButton4 = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0007C114 File Offset: 0x0007A314
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00003B3F File Offset: 0x00001D3F
		internal virtual UICheckBox UiCheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox3 = value;
			}
		}

		// Token: 0x04000388 RID: 904
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400038A RID: 906
		[AccessedThroughProperty("OfficeFormAdorner1")]
		private OfficeFormAdorner _OfficeFormAdorner1;

		// Token: 0x0400038B RID: 907
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400038C RID: 908
		[AccessedThroughProperty("UiRadioButton3")]
		private UIRadioButton _UiRadioButton3;

		// Token: 0x0400038D RID: 909
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x0400038E RID: 910
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x0400038F RID: 911
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000390 RID: 912
		[AccessedThroughProperty("UiRadioButton5")]
		private UIRadioButton _UiRadioButton5;

		// Token: 0x04000391 RID: 913
		[AccessedThroughProperty("UiRadioButton4")]
		private UIRadioButton _UiRadioButton4;

		// Token: 0x04000392 RID: 914
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000393 RID: 915
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x04000394 RID: 916
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000395 RID: 917
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04000396 RID: 918
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000397 RID: 919
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000398 RID: 920
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x04000399 RID: 921
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x0400039A RID: 922
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x0400039B RID: 923
		[AccessedThroughProperty("UiCheckBox3")]
		private UICheckBox _UiCheckBox3;
	}
}
