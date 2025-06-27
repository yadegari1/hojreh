using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000074 RID: 116
	[DesignerGenerated]
	public partial class Frm_RegHelp : Form
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x00003B56 File Offset: 0x00001D56
		[DebuggerNonUserCode]
		public Frm_RegHelp()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_RegHelp_KeyDown);
			Frm_RegHelp.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0007C12C File Offset: 0x0007A32C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_RegHelp.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_RegHelp.__ENCList.Count == Frm_RegHelp.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_RegHelp.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_RegHelp.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_RegHelp.__ENCList[num] = Frm_RegHelp.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_RegHelp.__ENCList.RemoveRange(num, Frm_RegHelp.__ENCList.Count - num);
						Frm_RegHelp.__ENCList.Capacity = Frm_RegHelp.__ENCList.Count;
					}
					Frm_RegHelp.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0007C7D0 File Offset: 0x0007A9D0
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00003B82 File Offset: 0x00001D82
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0007C7E8 File Offset: 0x0007A9E8
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00003B8C File Offset: 0x00001D8C
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0007C800 File Offset: 0x0007AA00
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00003B96 File Offset: 0x00001D96
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0007C818 File Offset: 0x0007AA18
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00003BA0 File Offset: 0x00001DA0
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0007C830 File Offset: 0x0007AA30
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0007C848 File Offset: 0x0007AA48
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
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0007C8A8 File Offset: 0x0007AAA8
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00003BAA File Offset: 0x00001DAA
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0007C8C0 File Offset: 0x0007AAC0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton1_Click(object sender, EventArgs e)
		{
			try
			{
				Application.Exit();
				ProjectData.EndApp();
			}
			catch (Exception expr_10)
			{
				ProjectData.SetProjectError(expr_10);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0007C904 File Offset: 0x0007AB04
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Frm_RegHelp_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				try
				{
					Application.Exit();
					ProjectData.EndApp();
				}
				catch (Exception expr_1E)
				{
					ProjectData.SetProjectError(expr_1E);
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0400039C RID: 924
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400039E RID: 926
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400039F RID: 927
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040003A0 RID: 928
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003A1 RID: 929
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003A2 RID: 930
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040003A3 RID: 931
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;
	}
}
