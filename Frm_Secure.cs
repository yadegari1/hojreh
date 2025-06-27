using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000079 RID: 121
	[DesignerGenerated]
	public partial class Frm_Secure : Form
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x00003E4E File Offset: 0x0000204E
		[DebuggerNonUserCode]
		public Frm_Secure()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Secure_FormClosing);
			Frm_Secure.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0008280C File Offset: 0x00080A0C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Secure.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					if (Frm_Secure.__ENCList.Count == Frm_Secure.__ENCList.Capacity)
					{
						int num = 0;
						int arg_34_0 = 0;
						int num2 = Frm_Secure.__ENCList.Count - 1;
						int num3 = arg_34_0;
						while (true)
						{
							int arg_3B_0 = num3;
							int num4 = num2;
							if (arg_3B_0 > num4)
							{
								break;
							}
							if (Frm_Secure.__ENCList[num3].IsAlive)
							{
								if (num3 != num)
								{
									Frm_Secure.__ENCList[num] = Frm_Secure.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Secure.__ENCList.RemoveRange(num, Frm_Secure.__ENCList.Count - num);
						Frm_Secure.__ENCList.Capacity = Frm_Secure.__ENCList.Count;
					}
					Frm_Secure.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00003E74 File Offset: 0x00002074
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00003E7C File Offset: 0x0000207C
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00003E85 File Offset: 0x00002085
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x000833D8 File Offset: 0x000815D8
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
				EventHandler value2 = new EventHandler(this.UiGroupBox2_Click);
				if (this._UiGroupBox2 != null)
				{
					this._UiGroupBox2.Click -= value2;
				}
				this._UiGroupBox2 = value;
				if (this._UiGroupBox2 != null)
				{
					this._UiGroupBox2.Click += value2;
				}
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00003E8D File Offset: 0x0000208D
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00003E95 File Offset: 0x00002095
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00003E9E File Offset: 0x0000209E
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00003EA6 File Offset: 0x000020A6
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

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00003EAF File Offset: 0x000020AF
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00003EB7 File Offset: 0x000020B7
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00003EC0 File Offset: 0x000020C0
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00083428 File Offset: 0x00081628
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
				if (this._UiButton1 != null)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				if (this._UiButton1 != null)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00003EC8 File Offset: 0x000020C8
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00083478 File Offset: 0x00081678
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
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				if (this._UiButton2 != null)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				if (this._UiButton2 != null)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00003ED0 File Offset: 0x000020D0
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00003ED8 File Offset: 0x000020D8
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00003EE1 File Offset: 0x000020E1
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00003EE9 File Offset: 0x000020E9
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00003EF2 File Offset: 0x000020F2
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00003EFA File Offset: 0x000020FA
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00003F03 File Offset: 0x00002103
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00003F0B File Offset: 0x0000210B
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00003F14 File Offset: 0x00002114
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00003F1C File Offset: 0x0000211C
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00003F25 File Offset: 0x00002125
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00003F2D File Offset: 0x0000212D
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00003F36 File Offset: 0x00002136
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton2_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00003F3D File Offset: 0x0000213D
		private void UiButton1_Click(object sender, EventArgs e)
		{
			new Frm_Register().ShowDialog();
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00003F36 File Offset: 0x00002136
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Frm_Secure_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00003F4A File Offset: 0x0000214A
		private void UiGroupBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040003E8 RID: 1000
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003EA RID: 1002
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040003EB RID: 1003
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040003EC RID: 1004
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040003ED RID: 1005
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003EE RID: 1006
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003EF RID: 1007
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040003F0 RID: 1008
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040003F1 RID: 1009
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040003F2 RID: 1010
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040003F3 RID: 1011
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040003F4 RID: 1012
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040003F5 RID: 1013
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040003F6 RID: 1014
		[AccessedThroughProperty("Label8")]
		private Label _Label8;
	}
}
